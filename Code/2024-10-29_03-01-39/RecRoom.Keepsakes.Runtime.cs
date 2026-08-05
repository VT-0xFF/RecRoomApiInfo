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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EF08C0", Offset = "0x6EEF8C0", VA = "0x186EF08C0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NOBAKNHHIPP : IComparer<JCBPJOGMEFH>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CKCEOBOKNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JCBPJOGMEFH x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public JCBPJOGMEFH y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CKCEOBOKNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9651D0", Offset = "0x9641D0", VA = "0x1809651D0")]
		internal bool GFLDDIPLOCF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18DECF0", Offset = "0x18DDCF0", VA = "0x1818DECF0")]
		internal bool AKLBMGLECCJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9651D0", Offset = "0x9641D0", VA = "0x1809651D0")]
		internal bool FEDHLNKLHFI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x18DECF0", Offset = "0x18DDCF0", VA = "0x1818DECF0")]
		internal bool OIPJOAADEKA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> PNDNNMHHKKO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public NOBAKNHHIPP(List<KeepsakeCategoryThemePair> OBPCFKLDMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EEFEF0", Offset = "0x6EEEEF0", VA = "0x186EEFEF0", Slot = "4")]
	public int Compare(JCBPJOGMEFH GOCMFEAMGHO, JCBPJOGMEFH AEFHGLLPABH)
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
		public JCBPJOGMEFH KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PGJOKJDJLNC]
public class HCDADPGGOGB : KBEKIEKONKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IFDGBEILEBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JCBPJOGMEFH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IFDGBEILEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE820", Offset = "0x6EED820", VA = "0x186EEE820")]
		internal OBJFFICJNII<Guid> CNFAALHCCBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE980", Offset = "0x6EED980", VA = "0x186EEE980")]
		internal void FOFHAEJCAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEDF0", Offset = "0x6EEDDF0", VA = "0x186EEEDF0")]
		internal void PKEKMFEGLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE9E0", Offset = "0x6EED9E0", VA = "0x186EEE9E0")]
		internal void OCHPJNFPFDK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6EEE9B0", Offset = "0x6EED9B0", VA = "0x186EEE9B0")]
		internal void GFAMCECONAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DIIAKIJMPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HCDADPGGOGB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public DIIAKIJMPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF8F0", Offset = "0x6EDE8F0", VA = "0x186EDF8F0")]
		internal void OLOLHAOJPNN(EPLKLKKJMJO response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF890", Offset = "0x6EDE890", VA = "0x186EDF890")]
		internal void FLEPPEMPFMP(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BJCHCJOMPJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BJCHCJOMPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF6C0", Offset = "0x6EDE6C0", VA = "0x186EDF6C0")]
		internal bool PGDCPIJAIGM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NHNDNFCJDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JCBPJOGMEFH? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NHNDNFCJDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFB60", Offset = "0x6EEEB60", VA = "0x186EEFB60")]
		internal void EAPIKBACJBC(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFAA0", Offset = "0x6EEEAA0", VA = "0x186EEFAA0")]
		internal void ABDICIBDJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFBF0", Offset = "0x6EEEBF0", VA = "0x186EEFBF0")]
		internal OBJFFICJNII<IEnumerable<Guid>> HOEBLIJMPGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B29E70", Offset = "0x6B28E70", VA = "0x186B29E70")]
		internal bool AMFFPHAOBJL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MCJKLBGCKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NHNDNFCJDEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MCJKLBGCKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF630", Offset = "0x6EEE630", VA = "0x186EEF630")]
		internal OBJFFICJNII<IEnumerable<Guid>> JEAKLIBCMFD(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BPHJDAKONEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MCJKLBGCKBI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BPHJDAKONEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF760", Offset = "0x6EDE760", VA = "0x186EDF760")]
		internal bool LDKDJOIMBDO(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GACEACDLEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BPHJDAKONEF CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GACEACDLEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE00D0", Offset = "0x6EDF0D0", VA = "0x186EE00D0")]
		internal bool MBFCAJIGIPF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ONFOPKGCDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ONFOPKGCDPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF01A0", Offset = "0x6EEF1A0", VA = "0x186EF01A0")]
		internal OBJFFICJNII<IEnumerable<Guid>> DENKNPNHBEO(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0310", Offset = "0x6EEF310", VA = "0x186EF0310")]
		internal bool PMCBOHKBJIG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NGHJKNLLEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HCDADPGGOGB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NGHJKNLLEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFAD0", Offset = "0x6EEEAD0", VA = "0x186EEFAD0")]
		internal void JEFLJDILCGD(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EEFAA0", Offset = "0x6EEEAA0", VA = "0x186EEFAA0")]
		internal void FEGELBPNPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF7B0", Offset = "0x6EEE7B0", VA = "0x186EEF7B0")]
		internal OBJFFICJNII<Dictionary<Guid, JCBPJOGMEFH>> AMEPJOLPDEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B29E70", Offset = "0x6B28E70", VA = "0x186B29E70")]
		internal bool HOAENOHCHCK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JNGINDGBAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JNGINDGBAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF170", Offset = "0x6EEE170", VA = "0x186EEF170")]
		internal OBJFFICJNII<Dictionary<Guid, JCBPJOGMEFH>> DMEALGLOOLC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JCKMPFGFIEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JCKMPFGFIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEFA0", Offset = "0x6EEDFA0", VA = "0x186EEEFA0")]
		internal bool OCBOIGPGFHL(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEE50", Offset = "0x6EEDE50", VA = "0x186EEEE50")]
		internal KeyValuePair<Guid, JCBPJOGMEFH> OALEJGKFLIJ(Guid instanceId)
		{
			return default(KeyValuePair<Guid, JCBPJOGMEFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GPCDCPAKMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GPCDCPAKMAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E4D190", Offset = "0x1E4C190", VA = "0x181E4D190")]
		internal bool PDOLOPGJEBH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BHGJKCPJDAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BHGJKCPJDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E4D190", Offset = "0x1E4C190", VA = "0x181E4D190")]
		internal bool LBAEKGDDPND(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OPLEBGNPGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OPLEBGNPGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0330", Offset = "0x6EEF330", VA = "0x186EF0330")]
		internal OBJFFICJNII<Dictionary<Guid, JCBPJOGMEFH>> PLEMPOALKJN(Dictionary<Guid, JCBPJOGMEFH> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0310", Offset = "0x6EEF310", VA = "0x186EF0310")]
		internal bool FLOKMHLCJNH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BOPACMEKKNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BOPACMEKKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF6E0", Offset = "0x6EDE6E0", VA = "0x186EDF6E0")]
		internal bool NNJEBEIJNHO(KeyValuePair<Guid, JCBPJOGMEFH> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PBDIFLLKBLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, JCBPJOGMEFH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PBDIFLLKBLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF0530", Offset = "0x6EEF530", VA = "0x186EF0530")]
		internal KeyValuePair<JCBPJOGMEFH, int> FEBDKBDCBEH(JCBPJOGMEFH category)
		{
			return default(KeyValuePair<JCBPJOGMEFH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CBMAFIAPIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JCBPJOGMEFH category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CBMAFIAPIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A980", Offset = "0xA39980", VA = "0x180A3A980")]
		internal bool MIDHILNGIBP(JCBPJOGMEFH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ADKDFHFFOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, JCBPJOGMEFH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ADKDFHFFOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF570", Offset = "0x6EDE570", VA = "0x186EDF570")]
		internal KeyValuePair<JCBPJOGMEFH, int> DBIFNAPCPPB(JCBPJOGMEFH category)
		{
			return default(KeyValuePair<JCBPJOGMEFH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JNNHCJPCJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JCBPJOGMEFH category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JNNHCJPCJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3A980", Offset = "0xA39980", VA = "0x180A3A980")]
		internal bool KMNLDBMDHHB(JCBPJOGMEFH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GBCDMCDPJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GBCDMCDPJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0260", Offset = "0x6EDF260", VA = "0x186EE0260")]
		internal bool MAIOPEEHODF(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EE01A0", Offset = "0x6EDF1A0", VA = "0x186EE01A0")]
		internal bool EANNENIGLPG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0180", Offset = "0x6EDF180", VA = "0x186EE0180")]
		internal bool ECHGJMHHOCO(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0180", Offset = "0x6EDF180", VA = "0x186EE0180")]
		internal bool CKLAEIIPDDG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DPIPEEFDNCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public DPIPEEFDNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC5BF0", VA = "0x180AC6BF0")]
		internal bool MJBDMOKAHCL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FHCLMLCJELF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FHCLMLCJELF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0010", Offset = "0x6EDF010", VA = "0x186EE0010")]
		internal bool PHIOAEGBFIN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FDE0", Offset = "0x1E0EDE0", VA = "0x181E0FDE0")]
		internal bool PAMGCAICJFJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KJJKPNDBGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KJJKPNDBGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF320", Offset = "0x6EEE320", VA = "0x186EEF320")]
		internal bool ONKBHDGEODF(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LAOLIPKMCHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LAOLIPKMCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC5BF0", VA = "0x180AC6BF0")]
		internal bool DKHMMICGPGA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GIGNIAIGMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GIGNIAIGMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE03D0", Offset = "0x6EDF3D0", VA = "0x186EE03D0")]
		internal bool NLGJHICBCCK(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ENMBFCBEDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JCBPJOGMEFH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ENMBFCBEDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2A30", Offset = "0x1AD1A30", VA = "0x181AD2A30")]
		internal bool OOLHGHCBOAD(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LFFHDPBKJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LFFHDPBKJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF5D0", Offset = "0x6EEE5D0", VA = "0x186EEF5D0")]
		internal bool AECLHDIFGLD(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NDDOFFHJOJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JCBPJOGMEFH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NDDOFFHJOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF770", Offset = "0x6EEE770", VA = "0x186EEF770")]
		internal bool NIHNCMCPLEI(KeyValuePair<Guid, JCBPJOGMEFH> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EAFPNODDCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JCBPJOGMEFH newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public EAFPNODDCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2A30", Offset = "0x1AD1A30", VA = "0x181AD2A30")]
		internal bool NCFIBPCOPEM(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FELMHHLAJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FELMHHLAJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFF90", Offset = "0x6EDEF90", VA = "0x186EDFF90")]
		internal bool HJHPFEHFKHJ(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JMMAEBOGJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JMMAEBOGJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF080", Offset = "0x6EEE080", VA = "0x186EEF080")]
		internal bool AGOJMLGACJL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GEFEJMHBKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JMMAEBOGJDJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GEFEJMHBKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0350", Offset = "0x6EDF350", VA = "0x186EE0350")]
		internal bool DDMEGBOPAHM(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GIINBNOGOLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GAAHBJLKBPP args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0430", Offset = "0x6EDF430", VA = "0x186EE0430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0960", Offset = "0x6EDF960", VA = "0x186EE0960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EEAADGBMJGM : IAsyncStateMachine
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
		public HCDADPGGOGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFCA0", Offset = "0x6EDECA0", VA = "0x186EDFCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFF30", Offset = "0x6EDEF30", VA = "0x186EDFF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime GHIOMJHHMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ICLEFKKGEJK KCDABEGAIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CDPHAHFIJGK JPNADGHDOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly PFCGHLGMIHG OPBACGHDBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NMCFPDANAHI HOICJHFCNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FJPHLODGACH GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FMFOLAMGLAA LLGANCPAAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IOKFDEJPJJE PLCEJCAGGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BDOMLLOLHMM LOCLKBGPLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NALGAFOLJNG CEBJIMOOBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MEIMGFEEEKB FJBBNBBIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly INDMEDOKNGA PPLGDEOIOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BGOMCGMCDNN MFIHKLMJCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EOFMDOIHHPP MMNNOBIAPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NAAEIEAKGMH AGNAOKAOOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NDCJIIFFPED<KeepsakesConfig.KeepsakesOptions> HKFJGLOCDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OJMFEDOPAFE JFKDGCHPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> LBEJEHBCOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> DMHICDDIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> DCMKKAJOPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<JCBPJOGMEFH, int> JAEJNMCHOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> GIJCONKOIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable GPLMLLKNKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task NACOEOHKIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private OBJFFICJNII<Guid> ADPPCCFBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? OCEIDOKCOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO LAIDPLFPNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OBJFFICJNII<KeepsakeProgressionEventInstancesDTO> ACALLLMDBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<JCBPJOGMEFH, KeepsakeCategoryConfigDTO> HPDEPEDLHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO NHONKMDFDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> LICBPMIPEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> FNNGLIFBOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> KJHKMCEAKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> FKLHDDGCNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> BCKIPPMIADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> PKMGBILIADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> ELCFFDDABFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> MIPAKKNMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EMLMPNNHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> PPACKBBDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> OMGKAKCKJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> OJGCKMALGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime IDMAPLDMKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable HALANOANMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, JCBPJOGMEFH> LGMDBIBGEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<JCBPJOGMEFH, int> DBKBEGFJECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> OBPCFKLDMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NOBAKNHHIPP AGONOCLMGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool OCCJACDEOJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LIHHOIEBNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x93B330", Offset = "0x93A330", VA = "0x18093B330", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x93A590", Offset = "0x939590", VA = "0x18093A590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NLAMPPHGDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EEAB80", Offset = "0x6EE9B80", VA = "0x186EEAB80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PHDKGLBLECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EEA070", Offset = "0x6EE9070", VA = "0x186EEA070", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long OKKHGKFFGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4CA0", Offset = "0x6EE3CA0", VA = "0x186EE4CA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? EPJHHLBIGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EECF40", Offset = "0x6EEBF40", VA = "0x186EECF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PLFJBNNCCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EE22D0", Offset = "0x6EE12D0", VA = "0x186EE22D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> NOOMBKPEGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA170E0", Offset = "0xA160E0", VA = "0x180A170E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> HOKPANMBJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A40", Offset = "0x9B0A40", VA = "0x1809B1A40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> DGPIKGJGNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB08460", Offset = "0xB07460", VA = "0x180B08460", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> OLCFIHMFKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA17220", Offset = "0xA16220", VA = "0x180A17220", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool GMOCHKOCPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D75460", Offset = "0x1D74460", VA = "0x181D75460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> KBNEEGIGFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9130", Offset = "0x6EE8130", VA = "0x186EE9130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE77D0", Offset = "0x6EE67D0", VA = "0x186EE77D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EMFABADPECN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE78E0", Offset = "0x6EE68E0", VA = "0x186EE78E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2900", Offset = "0x6EE1900", VA = "0x186EE2900", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OHDNCGDDCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7730", Offset = "0x6EE6730", VA = "0x186EE7730", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0F10", Offset = "0x6EDFF10", VA = "0x186EE0F10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EED250", Offset = "0x6EEC250", VA = "0x186EED250")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HCDADPGGOGB([GAHPILLNNBL(null)][NotNull] ICLEFKKGEJK KCDABEGAIEA, [NotNull][GAHPILLNNBL(null)] PPCKAPHHIOA BOAMFOJBBEB, [NotNull][GAHPILLNNBL(null)] CDPHAHFIJGK JPNADGHDOCM, [NotNull][GAHPILLNNBL(null)] PFCGHLGMIHG OPBACGHDBMP, [GAHPILLNNBL(null)][NotNull] NMCFPDANAHI HOICJHFCNCE, [GAHPILLNNBL(null)][NotNull] FJPHLODGACH GAIEJGCLEHG, [GAHPILLNNBL(null)][NotNull] FMFOLAMGLAA LLGANCPAAEN, [NotNull][GAHPILLNNBL(null)] IOKFDEJPJJE PLCEJCAGGKI, [NotNull][GAHPILLNNBL(null)] ADPKBHEBFGA INDOLNBFLPL, [NotNull][GAHPILLNNBL(null)] JALHDHKMMPF NNJIJCJDCKB, [NotNull][GAHPILLNNBL(null)] BDOMLLOLHMM LOCLKBGPLEM, [NotNull][GAHPILLNNBL(null)] NALGAFOLJNG CEBJIMOOBCJ, [NotNull][GAHPILLNNBL(null)] MEIMGFEEEKB FJBBNBBIFKF, [NotNull][GAHPILLNNBL(null)] INDMEDOKNGA PPLGDEOIOJK, [GAHPILLNNBL(null)][NotNull] BGOMCGMCDNN MFIHKLMJCKF, [GAHPILLNNBL(null)][NotNull] EOFMDOIHHPP MMNNOBIAPIB, [NotNull][GAHPILLNNBL(null)] NAAEIEAKGMH AGNAOKAOOII, [GAHPILLNNBL(null)][NotNull] NDCJIIFFPED<KeepsakesConfig.KeepsakesOptions> HKFJGLOCDGD, [NotNull][GAHPILLNNBL(null)] OJMFEDOPAFE JFKDGCHPBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2B60", Offset = "0x6EE1B60", VA = "0x186EE2B60", Slot = "15")]
	public bool DAEIIKIPGDN(List<string> MLLNJEPKJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3FF0", Offset = "0x6EE2FF0", VA = "0x186EE3FF0", Slot = "16")]
	public OBJFFICJNII<Guid> EBLOLJHPKOH(JCBPJOGMEFH ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9710", Offset = "0x6EE8710", VA = "0x186EE9710", Slot = "17")]
	public KKJPAEAJCIM JELMFGLHKNP(Guid BBFGBGLJEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0B80", Offset = "0x6EDFB80", VA = "0x186EE0B80", Slot = "18")]
	public KKJPAEAJCIM ACGHAPGAFGJ(Guid BBFGBGLJEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EE91E0", Offset = "0x6EE81E0", VA = "0x186EE91E0", Slot = "19")]
	public bool IIGJEMEFOJP(Guid BBFGBGLJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3970", Offset = "0x6EE2970", VA = "0x186EE3970", Slot = "20")]
	public bool DMBNJPACPGG(Guid BBFGBGLJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9990", Offset = "0x6EE8990", VA = "0x186EE9990")]
	public KeepsakeTheme JFOLKKONENJ(Guid BBFGBGLJEMA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7D00", Offset = "0x6EE6D00", VA = "0x186EE7D00")]
	public bool GPALKLNIBOI(JCBPJOGMEFH ALNEPPEDLDB, [Out] KeepsakeTheme JFMHNEDBFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB2A0", Offset = "0x6EEA2A0", VA = "0x186EEB2A0")]
	public List<KeepsakeTheme> NCFGNLCNPAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBB70", Offset = "0x6EEAB70", VA = "0x186EEBB70")]
	public int NJCGPODLEFJ(JCBPJOGMEFH ALNEPPEDLDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EE09C0", Offset = "0x6EDF9C0", VA = "0x186EE09C0")]
	public JCBPJOGMEFH ACCAKBMIDGO(Guid BBFGBGLJEMA)
	{
		return default(JCBPJOGMEFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EE19A0", Offset = "0x6EE09A0", VA = "0x186EE19A0", Slot = "34")]
	public List<JCBPJOGMEFH> BCJGBIJPKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3760", Offset = "0x6EE2760", VA = "0x186EE3760", Slot = "35")]
	public IComparer<JCBPJOGMEFH> DKPHLFNADNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9C60", Offset = "0x6EE8C60", VA = "0x186EE9C60", Slot = "32")]
	public string KAEJIGEIBOO(JCBPJOGMEFH ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6AD0", Offset = "0x6EE5AD0", VA = "0x186EE6AD0", Slot = "33")]
	public string FKALDAPCKDP(JCBPJOGMEFH ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1E90", Offset = "0x6EE0E90", VA = "0x186EE1E90", Slot = "21")]
	public bool BDBBIGLMLCP(Guid BBFGBGLJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEAC30", Offset = "0x6EE9C30", VA = "0x186EEAC30", Slot = "22")]
	public void MMMLOCCODAC(Guid BBFGBGLJEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB250", Offset = "0x6EEA250", VA = "0x186EEB250", Slot = "23")]
	public void MPJHJPKDLEP(JCBPJOGMEFH ALNEPPEDLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7980", Offset = "0x6EE6980", VA = "0x186EE7980", Slot = "24")]
	public void GLIMFFKKJED(Guid BBFGBGLJEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBF60", Offset = "0x6EEAF60", VA = "0x186EEBF60", Slot = "25")]
	public int NNGBFDDMION()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6DE0", Offset = "0x6EE5DE0", VA = "0x186EE6DE0", Slot = "31")]
	public OBJFFICJNII<IEnumerable<Guid>> FNKHKCLCDBG(long AHNLEKFKAGC, long IBBGBBBCFPD, JCBPJOGMEFH? ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB710", Offset = "0x6EEA710", VA = "0x186EEB710", Slot = "30")]
	public OBJFFICJNII<IEnumerable<Guid>> NEMNCJCCPBB(long AHNLEKFKAGC, long IBBGBBBCFPD, JCBPJOGMEFH? ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EE88D0", Offset = "0x6EE78D0", VA = "0x186EE88D0", Slot = "54")]
	public OBJFFICJNII<Dictionary<Guid, JCBPJOGMEFH>> HMBIJCMKHOA(long AHNLEKFKAGC, long IBBGBBBCFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9AD0", Offset = "0x6EE8AD0", VA = "0x186EE9AD0", Slot = "55")]
	public OBJFFICJNII<Dictionary<Guid, JCBPJOGMEFH>> JIFPHNAGMJD(long AHNLEKFKAGC, long IBBGBBBCFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8630", Offset = "0x6EE7630", VA = "0x186EE8630", Slot = "26")]
	public OBJFFICJNII<int> HLNPFIGOJKB(long AHNLEKFKAGC, long IBBGBBBCFPD, JCBPJOGMEFH? ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3820", Offset = "0x6EE2820", VA = "0x186EE3820", Slot = "27")]
	public OBJFFICJNII<int> DLNGNMDACDJ(long AHNLEKFKAGC, long IBBGBBBCFPD, JCBPJOGMEFH? ALNEPPEDLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9E60", Offset = "0x6EE8E60", VA = "0x186EE9E60", Slot = "28")]
	public OBJFFICJNII<Dictionary<JCBPJOGMEFH, int>> KKOGLNBNGOH(long AHNLEKFKAGC, long IBBGBBBCFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7EE0", Offset = "0x6EE6EE0", VA = "0x186EE7EE0", Slot = "29")]
	public OBJFFICJNII<Dictionary<JCBPJOGMEFH, int>> HGEPCMHOBFK(long AHNLEKFKAGC, long IBBGBBBCFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC820", Offset = "0x6EEB820", VA = "0x186EEC820", Slot = "37")]
	public bool OGMBMKGBEGI(long AHNLEKFKAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9E00", Offset = "0x6EE8E00", VA = "0x186EE9E00", Slot = "56")]
	public bool KJIBHBEDJKG(long AHNLEKFKAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4D70", Offset = "0x6EE3D70", VA = "0x186EE4D70", Slot = "38")]
	public bool ELFOGFIAKDD(long AHNLEKFKAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1AE0", Offset = "0x6EE0AE0", VA = "0x186EE1AE0", Slot = "57")]
	public bool BCOPDGCMBEI(long AHNLEKFKAGC, [Out] NKDOLPGAGAK DFFPCDCHFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7BC0", Offset = "0x6EE6BC0", VA = "0x186EE7BC0", Slot = "39")]
	public bool GOADILAOHFH(long JCHCLKMKCBB, [Out] DateTime EANIBGCNDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA400", Offset = "0x6EE9400", VA = "0x186EEA400", Slot = "40")]
	public long LOLCIHNLKFD(long JCHCLKMKCBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3650", Offset = "0x6EE2650", VA = "0x186EE3650", Slot = "41")]
	public long DECEPBNIHBK(long AHNLEKFKAGC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EED070", Offset = "0x6EEC070", VA = "0x186EED070", Slot = "42")]
	public int PFLAGOKOBNH(long JCHCLKMKCBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EE18C0", Offset = "0x6EE08C0", VA = "0x186EE18C0", Slot = "43")]
	public bool BCGLHBKMHNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4A40", Offset = "0x6EE3A40", VA = "0x186EE4A40", Slot = "44")]
	public bool EFOFNCDIEFA(long JCHCLKMKCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1380", Offset = "0x6EE0380", VA = "0x186EE1380", Slot = "45")]
	public IEnumerable<long> AGNIBGINPCM(long JCHCLKMKCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBEB0", Offset = "0x6EEAEB0", VA = "0x186EEBEB0", Slot = "46")]
	public int NMMPMIAPIGD(long JCHCLKMKCBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB8B0", Offset = "0x6EEA8B0", VA = "0x186EEB8B0", Slot = "50")]
	public long NGOKMJAKKDI(long OAJKNPAKNJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6770", Offset = "0x6EE5770", VA = "0x186EE6770", Slot = "51")]
	public JCBPJOGMEFH FJIHIJBKJJF()
	{
		return default(JCBPJOGMEFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6190", Offset = "0x6EE5190", VA = "0x186EE6190")]
	private bool FGAAMGLOAGP(Guid BBFGBGLJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8170", Offset = "0x6EE7170", VA = "0x186EE8170")]
	private void HKOGCHKHALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA130", Offset = "0x6EE9130", VA = "0x186EEA130")]
	private JCBPJOGMEFH LBMFGDNMILK()
	{
		return default(JCBPJOGMEFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC900", Offset = "0x6EEB900", VA = "0x186EEC900")]
	private void PBIEJJHJJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1720", Offset = "0x6EE0720", VA = "0x186EE1720")]
	private int AINMLLBJBBK(KeepsakeRoomListDTO AIEMLCAELEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEACA0", Offset = "0x6EE9CA0", VA = "0x186EEACA0")]
	private int MOEGEMMINLM(DateTime OIJHCNODDCG, DateTime GALOLALINIH, TimeSpan HCMENFHOGAF, int FGMCCEEGGIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4600", Offset = "0x6EE3600", VA = "0x186EE4600")]
	private void EDCLCHMOPNN(IEnumerable<KeepsakeInstanceDTO> LBEJEHBCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEA940", Offset = "0x6EE9940", VA = "0x186EEA940")]
	private void MCMJPGOODOG(IEnumerable<KeepsakeCollectionRecordDTO> BEGGGBCFDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0B20", Offset = "0x6EDFB20", VA = "0x186EE0B20")]
	private void ACCEGIGLHLK(IEnumerable<long> FJFCDCBOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB64630", Offset = "0xB63630", VA = "0x180B64630")]
	private void NHPCABHKMIA(KeepsakeGlobalConfigDTO NHONKMDFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8ED0", Offset = "0x6EE7ED0", VA = "0x186EE8ED0")]
	private bool ICJMFKGLBNH(JCBPJOGMEFH ALNEPPEDLDB, [Out] Guid AOMGFOHFMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EECFD0", Offset = "0x6EEBFD0", VA = "0x186EECFD0")]
	private bool PDMKINBLOJE([Out] Guid AOMGFOHFMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7880", Offset = "0x6EE6880", VA = "0x186EE7880")]
	private bool GIPOCIAONMA(Guid BBFGBGLJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC560", Offset = "0x6EEB560", VA = "0x186EEC560")]
	private IEnumerable<Guid> OEJPFDKCCHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB650", Offset = "0x6EEA650", VA = "0x186EEB650")]
	private IEnumerable<KeepsakeInstanceDTO> NEBDDJHMFEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8E40", Offset = "0x6EE7E40", VA = "0x186EE8E40")]
	private void HOPENJBIHCA(Guid BBFGBGLJEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2120", Offset = "0x6EE1120", VA = "0x186EE2120")]
	private bool BGLILBMGFEF(Guid BBFGBGLJEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7FD0", Offset = "0x6EE6FD0", VA = "0x186EE7FD0")]
	private void HIMHJAKBMAI(Guid BBFGBGLJEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBCF0", Offset = "0x6EEACF0", VA = "0x186EEBCF0")]
	private void NKBDPFOIINE(JCBPJOGMEFH GGGCMBBMAME, int ANFJIJOFHEO, Dictionary<JCBPJOGMEFH, int> FOFMBKFOMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1630", Offset = "0x6EE0630", VA = "0x186EE1630")]
	private int AINKJIFNOFA(JCBPJOGMEFH ALNEPPEDLDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE39C0", Offset = "0x6EE29C0", VA = "0x186EE39C0")]
	private void DPLMGKEMODL(KeepsakeInstanceDTO JOOIPGMCDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2DF0", Offset = "0x6EE1DF0", VA = "0x186EE2DF0")]
	private void DBFJJADMBJO(KeepsakeInstanceDTO JOOIPGMCDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0FB0", Offset = "0x6EDFFB0", VA = "0x186EE0FB0")]
	private void AFEANAFLCDI(Guid BBFGBGLJEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7FA0", Offset = "0x6EE6FA0", VA = "0x186EE7FA0")]
	private void HHBEKEEIJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE39A0", Offset = "0x6EE29A0", VA = "0x186EE39A0")]
	private void DMJKADIBHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EE22E0", Offset = "0x6EE12E0", VA = "0x186EE22E0")]
	private void BKPNFGDHJCI(JNNCAHPPKJI MCPCCOBALOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7FA0", Offset = "0x6EE6FA0", VA = "0x186EE7FA0")]
	private void HJBPIDFAAGL(DMDPHKBCMNH IFPBFCLBBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7FA0", Offset = "0x6EE6FA0", VA = "0x186EE7FA0")]
	private void NOIAFNPEEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EE63D0", Offset = "0x6EE53D0", VA = "0x186EE63D0")]
	private void FGHIIGKMNJI(float HECONEAPGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7190", Offset = "0x6EE6190", VA = "0x186EE7190")]
	private void FOHFGBFNPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EEB050", Offset = "0x6EEA050", VA = "0x186EEB050")]
	private bool MPHLDMGENBN(Guid BBFGBGLJEMA, [Out] string AHFACBKABIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4E30", Offset = "0x6EE3E30", VA = "0x186EE4E30")]
	private bool FANBAIIMEJD(Guid BBFGBGLJEMA, [Out] KeepsakeCategoryConfigDTO GGGCMBBMAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EEBDD0", Offset = "0x6EEADD0", VA = "0x186EEBDD0")]
	private void NKIBNKAPDFM(string JCLHICKJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6C50", Offset = "0x6EE5C50", VA = "0x186EE6C50")]
	private bool FKFKKNGJEEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EEADA0", Offset = "0x6EE9DA0", VA = "0x186EEADA0")]
	private IEnumerable<long> MOJEHOPFEHC(IEnumerable<KeepsakeRoomDTO> ODFNLHCKJDA, IEnumerable<KeepsakeRoomListDTO> CLCCIFDIMED, long JCHCLKMKCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3130", Offset = "0x6EE2130", VA = "0x186EE3130")]
	private bool DDFOFOECCEK(Guid BBFGBGLJEMA, [Out] string IPLILPPMPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEABD0", Offset = "0x6EE9BD0", VA = "0x186EEABD0", Slot = "47")]
	public string MHOLNPMPDON(EOOFNLFANHP APILDMFOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE24E0", Offset = "0x6EE14E0", VA = "0x186EE24E0", Slot = "49")]
	public string BPMHHKDKCNG(EOOFNLFANHP APILDMFOLHL, long AHNLEKFKAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4BD0", Offset = "0x6EE3BD0", VA = "0x186EE4BD0", Slot = "48")]
	public string EKFIHNIKKMI(EOOFNLFANHP APILDMFOLHL, int MCBDHAKAMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5000", Offset = "0x6EE4000", VA = "0x186EE5000")]
	private void FCHNFNBHKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2350", Offset = "0x6EE1350", VA = "0x186EE2350")]
	private void BKPPONNCNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4E10", Offset = "0x6EE3E10", VA = "0x186EE4E10")]
	private EOOFNLFANHP EPABNKDHAMM(NPICJIFGBKK IKIAAEEIAEK)
	{
		return default(EOOFNLFANHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EE96F0", Offset = "0x6EE86F0", VA = "0x186EE96F0")]
	private EOOFNLFANHP IOCFJKBLEOO(NPICJIFGBKK IKIAAEEIAEK)
	{
		return default(EOOFNLFANHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC380", Offset = "0x6EEB380", VA = "0x186EEC380")]
	internal static string OCOHHACEIJN(EPLKLKKJMJO LAKHMOBEGCJ, string MIDGEDIKJAB, bool CGGHKBEAKFC, int MOGENAJNKBI, int EBJMKCPCPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3B90", Offset = "0x6EE2B90", VA = "0x186EE3B90", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC880", Offset = "0x6EEB880", VA = "0x186EEC880")]
	private JECONNLHJLM OIENDCKIMLG(NKLIIMCFHAI PHAFKBHJAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8C80", Offset = "0x6EE7C80", VA = "0x186EE8C80")]
	private PHOFBAJGOEC HOMACJEBOHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9340", Offset = "0x6EE8340", VA = "0x186EE9340")]
	private Task IKKOBMKJDMF(GAAHBJLKBPP NABJMDALPIF, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EE62C0", Offset = "0x6EE52C0", VA = "0x186EE62C0")]
	[AsyncStateMachine(typeof(GIINBNOGOLF))]
	private Task FGBCAHBDHLH(GAAHBJLKBPP NABJMDALPIF, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1560", Offset = "0x6EE0560", VA = "0x186EE1560")]
	private Task AHGAIDBKCIM(GAAHBJLKBPP NABJMDALPIF, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5ED0", Offset = "0x6EE4ED0", VA = "0x186EE5ED0")]
	[AsyncStateMachine(typeof(EEAADGBMJGM))]
	private Task FCMEKKNDMFO(string ABHPFCOODAJ, TimeSpan BGIFKBIIOHF, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9DE0", Offset = "0x6EE8DE0", VA = "0x186EE9DE0")]
	[CompilerGenerated]
	private void KBIPEHEJAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE49F0", Offset = "0x6EE39F0", VA = "0x186EE49F0")]
	[CompilerGenerated]
	private void EDLABFJMBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE21D0", Offset = "0x6EE11D0", VA = "0x186EE21D0")]
	[CompilerGenerated]
	private bool BIDHDAIFKAM(KeepsakeInstanceDTO GOCMFEAMGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC6B0", Offset = "0x6EEB6B0", VA = "0x186EEC6B0")]
	[CompilerGenerated]
	private OBJFFICJNII<Dictionary<JCBPJOGMEFH, int>> OFGLBBJAHEK(Dictionary<Guid, JCBPJOGMEFH> LJMLGGPEIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4880", Offset = "0x6EE3880", VA = "0x186EE4880")]
	[CompilerGenerated]
	private OBJFFICJNII<Dictionary<JCBPJOGMEFH, int>> EDDLCIOABPH(Dictionary<Guid, JCBPJOGMEFH> LJMLGGPEIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6DC0", Offset = "0x6EE5DC0", VA = "0x186EE6DC0")]
	[CompilerGenerated]
	private bool FMPAGFHHLFG(KeepsakeRoomListDTO GOCMFEAMGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3000", Offset = "0x6EE2000", VA = "0x186EE3000")]
	[CompilerGenerated]
	private bool DBGNPCLNMOA(KeepsakeInstanceDTO GOCMFEAMGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6000", Offset = "0x6EE5000", VA = "0x186EE6000")]
	[CompilerGenerated]
	private void FFPECHAFAAN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<JCBPJOGMEFH, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> INNMCPIJFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6D60", Offset = "0x6EE5D60", VA = "0x186EE6D60")]
	[CompilerGenerated]
	private void FLGLAECIPMC(string IPLILPPMPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EE29A0", Offset = "0x6EE19A0", VA = "0x186EE29A0")]
	[CompilerGenerated]
	private Task CFNKBIJFENH(CancellationToken DGEKAJPHLKM)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, NDCJIIFFPED<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class PKAGIGMCOHM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
				public PKAGIGMCOHM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6EF0680", Offset = "0x6EEF680", VA = "0x186EF0680")]
				internal bool GCMAJPEPCNE(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6EF0680", Offset = "0x6EEF680", VA = "0x186EF0680")]
				internal bool ONMMKOKHGDH(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6EEF400", Offset = "0x6EEE400", VA = "0x186EEF400")]
			public bool NKDJDPDKIMJ(string IICPDKNBEHC, [Out] KeepsakeTheme JFMHNEDBFHA)
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EEF380", Offset = "0x6EEE380", VA = "0x186EEF380")]
		[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
		internal static void LPMGDCHBOCO(MAONAIOKEHK GHHOPPHGNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x975580", VA = "0x180976580")]
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
