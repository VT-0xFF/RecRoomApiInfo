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
		[Cpp2IlInjected.Address(RVA = "0x6C8CAC0", Offset = "0x6C8B6C0", VA = "0x186C8CAC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ODACKOHMFNB : IComparer<HEJGHJHBLCB>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class IOOAKMLJNIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HEJGHJHBLCB x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public HEJGHJHBLCB y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IOOAKMLJNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x11914F0", Offset = "0x11900F0", VA = "0x1811914F0")]
		internal bool HODJHDFCEKB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x159A620", Offset = "0x1599220", VA = "0x18159A620")]
		internal bool LFHHKABCPON(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x11914F0", Offset = "0x11900F0", VA = "0x1811914F0")]
		internal bool NGDDBFLINNP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x159A620", Offset = "0x1599220", VA = "0x18159A620")]
		internal bool PGLPHIOBBDL(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> KGJCMEKJJLI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public ODACKOHMFNB(List<KeepsakeCategoryThemePair> BIEINMHOIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C190", Offset = "0x6C8AD90", VA = "0x186C8C190", Slot = "4")]
	public int Compare(HEJGHJHBLCB MBJABMPNEHF, HEJGHJHBLCB MNMGCDILGBO)
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
		public HEJGHJHBLCB KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CGPAMFEMIJK]
public class GAJHGFJLOFG : NCGDHPLKFLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GKFBIIHAIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HEJGHJHBLCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GKFBIIHAIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B1A0", Offset = "0x6C89DA0", VA = "0x186C8B1A0")]
		internal HHDNLBNGHMC<Guid> HDMKCKKBOAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B300", Offset = "0x6C89F00", VA = "0x186C8B300")]
		internal void JIIHMIKKGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B140", Offset = "0x6C89D40", VA = "0x186C8B140")]
		internal void GGNGDDJDFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AD30", Offset = "0x6C89930", VA = "0x186C8AD30")]
		internal void BIEGPALLKIH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B330", Offset = "0x6C89F30", VA = "0x186C8B330")]
		internal void LKDGONGKNPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DLCAGEMCOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GAJHGFJLOFG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DLCAGEMCOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C510", Offset = "0x6C7B110", VA = "0x186C7C510")]
		internal void OOHOOMKEEBO(FJHDAABADEM response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C4B0", Offset = "0x6C7B0B0", VA = "0x186C7C4B0")]
		internal void LJNPEIAGLGN(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PONGAOIBONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PONGAOIBONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C890", Offset = "0x6C8B490", VA = "0x186C8C890")]
		internal bool MMEGMICDFNF(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CADKDOOALBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public HEJGHJHBLCB? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CADKDOOALBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BC60", Offset = "0x6C7A860", VA = "0x186C7BC60")]
		internal void HAGMIEHIHCJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BC30", Offset = "0x6C7A830", VA = "0x186C7BC30")]
		internal void FFLPCMLHIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BCF0", Offset = "0x6C7A8F0", VA = "0x186C7BCF0")]
		internal HHDNLBNGHMC<IEnumerable<Guid>> PJPHDGAOMLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6872980", Offset = "0x6871580", VA = "0x186872980")]
		internal bool IGDCNEMJJPA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IAFFJGAJEAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CADKDOOALBE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IAFFJGAJEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B360", Offset = "0x6C89F60", VA = "0x186C8B360")]
		internal HHDNLBNGHMC<IEnumerable<Guid>> ONNEHJELOPI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DJBCNAEONEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IAFFJGAJEAG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DJBCNAEONEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C180", Offset = "0x6C7AD80", VA = "0x186C7C180")]
		internal bool BHAPGGOCLGE(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FALNOAIMJCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DJBCNAEONEL CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public FALNOAIMJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CCC0", Offset = "0x6C7B8C0", VA = "0x186C7CCC0")]
		internal bool IGJBEFJEOGA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DAEFKIADHPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DAEFKIADHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C010", Offset = "0x6C7AC10", VA = "0x186C7C010")]
		internal HHDNLBNGHMC<IEnumerable<Guid>> MEGAONHEEKP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BFF0", Offset = "0x6C7ABF0", VA = "0x186C7BFF0")]
		internal bool GGMCOEAEICE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class EABCDEJDAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GAJHGFJLOFG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EABCDEJDAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CBB0", Offset = "0x6C7B7B0", VA = "0x186C7CBB0")]
		internal void PJKNMINHPDK(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BC30", Offset = "0x6C7A830", VA = "0x186C7BC30")]
		internal void DBELPFKBFDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C8C0", Offset = "0x6C7B4C0", VA = "0x186C7C8C0")]
		internal HHDNLBNGHMC<Dictionary<Guid, HEJGHJHBLCB>> GCEPELEBHMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6872980", Offset = "0x6871580", VA = "0x186872980")]
		internal bool AINLLFHBAPP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MNKLFMAGJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MNKLFMAGJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BF50", Offset = "0x6C8AB50", VA = "0x186C8BF50")]
		internal HHDNLBNGHMC<Dictionary<Guid, HEJGHJHBLCB>> FEKNIKEKAPI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AFPINJAGJOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AFPINJAGJOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B850", Offset = "0x6C7A450", VA = "0x186C7B850")]
		internal bool NHDGEAAOCPG(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B700", Offset = "0x6C7A300", VA = "0x186C7B700")]
		internal KeyValuePair<Guid, HEJGHJHBLCB> MABDFDHPKGH(Guid instanceId)
		{
			return default(KeyValuePair<Guid, HEJGHJHBLCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class ELDKIODOJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ELDKIODOJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B31170", Offset = "0x1B2FD70", VA = "0x181B31170")]
		internal bool JCIEJKOLFDF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NHLDMFFEJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NHLDMFFEJBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1B31170", Offset = "0x1B2FD70", VA = "0x181B31170")]
		internal bool HKOIDDGBBCH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DJOFAHHDDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DJOFAHHDDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C2B0", Offset = "0x6C7AEB0", VA = "0x186C7C2B0")]
		internal HHDNLBNGHMC<Dictionary<Guid, HEJGHJHBLCB>> FGKJECCODFN(Dictionary<Guid, HEJGHJHBLCB> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BFF0", Offset = "0x6C7ABF0", VA = "0x186C7BFF0")]
		internal bool KAANNAIHPHP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EELFELFPFEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EELFELFPFEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC40", Offset = "0x6C7B840", VA = "0x186C7CC40")]
		internal bool IABPJHMILAN(KeyValuePair<Guid, HEJGHJHBLCB> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PIPEODFPIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, HEJGHJHBLCB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PIPEODFPIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C500", Offset = "0x6C8B100", VA = "0x186C8C500")]
		internal KeyValuePair<HEJGHJHBLCB, int> JFDFIMLEGCH(HEJGHJHBLCB category)
		{
			return default(KeyValuePair<HEJGHJHBLCB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MKHJPMPFEOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HEJGHJHBLCB category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MKHJPMPFEOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x14EB800", Offset = "0x14EA400", VA = "0x1814EB800")]
		internal bool BNPMKNDGOLK(HEJGHJHBLCB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PKMNIBGABMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, HEJGHJHBLCB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PKMNIBGABMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C650", Offset = "0x6C8B250", VA = "0x186C8C650")]
		internal KeyValuePair<HEJGHJHBLCB, int> BDDLIHHNAFC(HEJGHJHBLCB category)
		{
			return default(KeyValuePair<HEJGHJHBLCB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OAEFCCEIILD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public HEJGHJHBLCB category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OAEFCCEIILD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x14EB800", Offset = "0x14EA400", VA = "0x1814EB800")]
		internal bool NIMOCOOMDIE(HEJGHJHBLCB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JACMJFKCANH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JACMJFKCANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B5C0", Offset = "0x6C8A1C0", VA = "0x186C8B5C0")]
		internal bool NIFGCPJPPKG(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B500", Offset = "0x6C8A100", VA = "0x186C8B500")]
		internal bool KDLPGFCDNNH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B4E0", Offset = "0x6C8A0E0", VA = "0x186C8B4E0")]
		internal bool LPCDGOHHACF(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B4E0", Offset = "0x6C8A0E0", VA = "0x186C8B4E0")]
		internal bool AEDNJJHFJFN(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LNENKEODDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public LNENKEODDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAE9C40", Offset = "0xAE8840", VA = "0x180AE9C40")]
		internal bool CKMAJPDPLKI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KMNIBAJEKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KMNIBAJEKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BC40", Offset = "0x6C8A840", VA = "0x186C8BC40")]
		internal bool KNHLKJEHOPN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1AFC1B0", Offset = "0x1AFADB0", VA = "0x181AFC1B0")]
		internal bool KGKPEEABEMN(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OMDGFPJKFFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OMDGFPJKFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C440", Offset = "0x6C8B040", VA = "0x186C8C440")]
		internal bool KMFBHOECGEE(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MEOMJIJCBNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MEOMJIJCBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAE9C40", Offset = "0xAE8840", VA = "0x180AE9C40")]
		internal bool AGPKENJMIKI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PHOGHBGJGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PHOGHBGJGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C4A0", Offset = "0x6C8B0A0", VA = "0x186C8C4A0")]
		internal bool OJKCHHDLBCF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JMFCDHOJLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HEJGHJHBLCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JMFCDHOJLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1770BD0", Offset = "0x176F7D0", VA = "0x181770BD0")]
		internal bool FJPPICCHBAP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NIGPKDFAHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NIGPKDFAHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C130", Offset = "0x6C8AD30", VA = "0x186C8C130")]
		internal bool IPNIEBJIDMA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IIMPMKCHLIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public HEJGHJHBLCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IIMPMKCHLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B4A0", Offset = "0x6C8A0A0", VA = "0x186C8B4A0")]
		internal bool KLKJEOBKNMG(KeyValuePair<Guid, HEJGHJHBLCB> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OEDOGFOLFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HEJGHJHBLCB newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OEDOGFOLFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1770BD0", Offset = "0x176F7D0", VA = "0x181770BD0")]
		internal bool NDIADHEBNIP(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AEKIHAJHOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AEKIHAJHOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B680", Offset = "0x6C7A280", VA = "0x186C7B680")]
		internal bool IAIKIGACCKE(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class PMPLKGLMLKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PMPLKGLMLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C7A0", Offset = "0x6C8B3A0", VA = "0x186C8C7A0")]
		internal bool JBMKKAMIGCD(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GKCHPAOLBAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PMPLKGLMLKP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GKCHPAOLBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ACB0", Offset = "0x6C898B0", VA = "0x186C8ACB0")]
		internal bool JLEEJKPHLOM(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JDAOHCDBGFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public BEHJNDNGPEO args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B6B0", Offset = "0x6C8A2B0", VA = "0x186C8B6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BBE0", Offset = "0x6C8A7E0", VA = "0x186C8BBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ALPNOKKLFDJ : IAsyncStateMachine
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
		public GAJHGFJLOFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B930", Offset = "0x6C7A530", VA = "0x186C7B930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BBD0", Offset = "0x6C7A7D0", VA = "0x186C7BBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime JGGGFAPADJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BJMCPMBFICI OMFLLGLIPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JLEOPKBBOIE DMDOADBNNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly APMMABMPALM GENOBPPKOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BCKIOPMPMCB KDFHJLEDCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PEMMGMCEFGA IJOFDKELBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GLJOHNIMEHC OFGNIKFELLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LBMJGOHHNLK GNLPKCMNNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DALGFALCFLA EAKHDFPJOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DFNBAPCAPEA KLAFHGPPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NMNGDGJOAIJ OBKCDBAOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CDEIFEPMIKE MJNMHPCCNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EMIKLMNHPKL AGGOAHHCNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly APJBBMJCKPI DMLKGGBCGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HAOCJBNKGCE EMNFNFJOCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PCJJBDFPBKI JKNBMKCLLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DGPJCKMIHCC<KeepsakesConfig.KeepsakesOptions> OGIKBJOPPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AJLACEJPNNH AIPNDDKPMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> KMIAOIDIGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> GPNDLPPDBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> HGNPNCCDOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<HEJGHJHBLCB, int> DEPEPCIIION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> NJPGIAPDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable GMGMKFHGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task DOHKMGIABMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private HHDNLBNGHMC<Guid> DJLGLCGDGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? AEGLIMJMKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO PGGBILPNKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HHDNLBNGHMC<KeepsakeProgressionEventInstancesDTO> EFHCEKKOEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<HEJGHJHBLCB, KeepsakeCategoryConfigDTO> IJJENNJKBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO FNCLLKGLOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> FFFIMPPBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> MLPIILDLCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> CBJEPNGGNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> ECANENGPHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> CBONBJBGHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> HHGFNDNMEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> KGMBOALAPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> FNMIEAAJGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EJLGCKLHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OOBAJAKBDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> JHIELAIBFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> CPCLMPBOJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime NMAEBBKDENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable PDNOGDIKKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, HEJGHJHBLCB> PJAOHPDOFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<HEJGHJHBLCB, int> CNEMHIJNKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> BIEINMHOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ODACKOHMFNB DKHDDBLLIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool JGDKJNJKBNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMILOEOEKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B6010", Offset = "0x8B4C10", VA = "0x1808B6010", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D90", Offset = "0x8B4990", VA = "0x1808B5D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PPENEGMGOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C82C30", Offset = "0x6C81830", VA = "0x186C82C30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IGHKHKKGIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C81AB0", Offset = "0x6C806B0", VA = "0x186C81AB0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long GEJIELDFHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C84010", Offset = "0x6C82C10", VA = "0x186C84010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? ECAHECDHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C81540", Offset = "0x6C80140", VA = "0x186C81540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool LBAGDEGENKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D080", Offset = "0x6C7BC80", VA = "0x186C7D080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> EJIANGEKDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x93F350", Offset = "0x93DF50", VA = "0x18093F350", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> CFHMCPEEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCCEE20", Offset = "0xCCDA20", VA = "0x180CCEE20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> PBCDBNELOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x961BB0", Offset = "0x9607B0", VA = "0x180961BB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> BAOCOMKPMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCCEC30", Offset = "0xCCD830", VA = "0x180CCEC30", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool KEPHKOFHLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C855B0", Offset = "0x6C841B0", VA = "0x186C855B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> EIKGDPNPLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C855C0", Offset = "0x6C841C0", VA = "0x186C855C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C81DC0", Offset = "0x6C809C0", VA = "0x186C81DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MHPHCBMALKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C882E0", Offset = "0x6C86EE0", VA = "0x186C882E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C83080", Offset = "0x6C81C80", VA = "0x186C83080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FNBMNLIMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C89640", Offset = "0x6C88240", VA = "0x186C89640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C83F00", Offset = "0x6C82B00", VA = "0x186C83F00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C896E0", Offset = "0x6C882E0", VA = "0x186C896E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GAJHGFJLOFG([JGAMIMHCGFI(null)][NotNull] BJMCPMBFICI OMFLLGLIPPH, [NotNull][JGAMIMHCGFI(null)] POEFAGDFHGA OKHLKCKKIOH, [NotNull][JGAMIMHCGFI(null)] JLEOPKBBOIE DMDOADBNNCM, [NotNull][JGAMIMHCGFI(null)] APMMABMPALM GENOBPPKOCI, [JGAMIMHCGFI(null)][NotNull] BCKIOPMPMCB KDFHJLEDCCA, [JGAMIMHCGFI(null)][NotNull] PEMMGMCEFGA IJOFDKELBEG, [JGAMIMHCGFI(null)][NotNull] GLJOHNIMEHC OFGNIKFELLO, [NotNull][JGAMIMHCGFI(null)] LBMJGOHHNLK GNLPKCMNNHP, [NotNull][JGAMIMHCGFI(null)] DALGFALCFLA EAKHDFPJOPO, [NotNull][JGAMIMHCGFI(null)] EGINLHCPDOP DAHABMMDFHN, [NotNull][JGAMIMHCGFI(null)] DFNBAPCAPEA KLAFHGPPFKO, [NotNull][JGAMIMHCGFI(null)] NMNGDGJOAIJ OBKCDBAOGIH, [NotNull][JGAMIMHCGFI(null)] CDEIFEPMIKE MJNMHPCCNNB, [NotNull][JGAMIMHCGFI(null)] EMIKLMNHPKL AGGOAHHCNOO, [JGAMIMHCGFI(null)][NotNull] APJBBMJCKPI DMLKGGBCGBB, [JGAMIMHCGFI(null)][NotNull] HAOCJBNKGCE EMNFNFJOCII, [NotNull][JGAMIMHCGFI(null)] PCJJBDFPBKI JKNBMKCLLCJ, [JGAMIMHCGFI(null)][NotNull] DGPJCKMIHCC<KeepsakesConfig.KeepsakesOptions> OGIKBJOPPCP, [NotNull][JGAMIMHCGFI(null)] AJLACEJPNNH AIPNDDKPMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C81020", Offset = "0x6C7FC20", VA = "0x186C81020", Slot = "15")]
	public bool FADDBHEBBNI(List<string> GGBPPKCPJGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F170", Offset = "0x6C7DD70", VA = "0x186C7F170", Slot = "16")]
	public HHDNLBNGHMC<Guid> DBDDKIHMFCK(HEJGHJHBLCB GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7CDD0", Offset = "0x6C7B9D0", VA = "0x186C7CDD0", Slot = "17")]
	public DMMKPEDFDBF AEDDJGGFPPF(Guid PGLONPJBOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F8C0", Offset = "0x6C7E4C0", VA = "0x186C7F8C0", Slot = "18")]
	public DMMKPEDFDBF DJHDBCCDFCL(Guid PGLONPJBOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C88FD0", Offset = "0x6C87BD0", VA = "0x186C88FD0", Slot = "19")]
	public bool OOPOMPEOPHF(Guid PGLONPJBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FD50", Offset = "0x6C7E950", VA = "0x186C7FD50", Slot = "20")]
	public bool DOMOLEDIMFL(Guid PGLONPJBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C886F0", Offset = "0x6C872F0", VA = "0x186C886F0")]
	public KeepsakeTheme OCMPCIEHJIL(Guid PGLONPJBOEL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C84DC0", Offset = "0x6C839C0", VA = "0x186C84DC0")]
	public bool JMMEFHLMMIK(HEJGHJHBLCB GCOLDAKADHJ, [Out] KeepsakeTheme ADAENFEGFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C834D0", Offset = "0x6C820D0", VA = "0x186C834D0")]
	public List<KeepsakeTheme> HNCPNINAHNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C801E0", Offset = "0x6C7EDE0", VA = "0x186C801E0")]
	public int EBDAKPJPOHE(HEJGHJHBLCB GCOLDAKADHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C86760", Offset = "0x6C85360", VA = "0x186C86760")]
	public HEJGHJHBLCB NBNBOPHJNCJ(Guid PGLONPJBOEL)
	{
		return default(HEJGHJHBLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DB80", Offset = "0x6C7C780", VA = "0x186C7DB80", Slot = "34")]
	public List<HEJGHJHBLCB> ANCDOPDPCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C81D00", Offset = "0x6C80900", VA = "0x186C81D00", Slot = "35")]
	public IComparer<HEJGHJHBLCB> FKKHHPLPOAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C80EA0", Offset = "0x6C7FAA0", VA = "0x186C80EA0", Slot = "32")]
	public string EPBADIOHFNC(HEJGHJHBLCB GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E290", Offset = "0x6C7CE90", VA = "0x186C7E290", Slot = "33")]
	public string BLJPMNHENBG(HEJGHJHBLCB GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C812B0", Offset = "0x6C7FEB0", VA = "0x186C812B0", Slot = "21")]
	public bool FAPBHMLGOPH(Guid PGLONPJBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C88380", Offset = "0x6C86F80", VA = "0x186C88380", Slot = "22")]
	public void OAIAIOOEENN(Guid PGLONPJBOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C88830", Offset = "0x6C87430", VA = "0x186C88830", Slot = "23")]
	public void OGANMMMPHDB(HEJGHJHBLCB GCOLDAKADHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C87040", Offset = "0x6C85C40", VA = "0x186C87040", Slot = "24")]
	public void NJOPIKFOFJN(Guid PGLONPJBOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C803E0", Offset = "0x6C7EFE0", VA = "0x186C803E0", Slot = "25")]
	public int EKHHEIIKDCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C840E0", Offset = "0x6C82CE0", VA = "0x186C840E0", Slot = "31")]
	public HHDNLBNGHMC<IEnumerable<Guid>> IIAIKGKPCLA(long GLOFJPFEAOO, long NJDNKLCCOMD, HEJGHJHBLCB? GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C84490", Offset = "0x6C83090", VA = "0x186C84490", Slot = "30")]
	public HHDNLBNGHMC<IEnumerable<Guid>> IJLFPFNIGMC(long GLOFJPFEAOO, long NJDNKLCCOMD, HEJGHJHBLCB? GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C83120", Offset = "0x6C81D20", VA = "0x186C83120", Slot = "54")]
	public HHDNLBNGHMC<Dictionary<Guid, HEJGHJHBLCB>> HKEEAJDBGNH(long GLOFJPFEAOO, long NJDNKLCCOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C88560", Offset = "0x6C87160", VA = "0x186C88560", Slot = "55")]
	public HHDNLBNGHMC<Dictionary<Guid, HEJGHJHBLCB>> OCIPENDBIIO(long GLOFJPFEAOO, long NJDNKLCCOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C84B10", Offset = "0x6C83710", VA = "0x186C84B10", Slot = "26")]
	public HHDNLBNGHMC<int> JKBEKHDIBCF(long GLOFJPFEAOO, long NJDNKLCCOMD, HEJGHJHBLCB? GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D890", Offset = "0x6C7C490", VA = "0x186C7D890", Slot = "27")]
	public HHDNLBNGHMC<int> AMPFLBLFCEK(long GLOFJPFEAOO, long NJDNKLCCOMD, HEJGHJHBLCB? GCOLDAKADHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C80BB0", Offset = "0x6C7F7B0", VA = "0x186C80BB0", Slot = "28")]
	public HHDNLBNGHMC<Dictionary<HEJGHJHBLCB, int>> EMFBFLOLKLI(long GLOFJPFEAOO, long NJDNKLCCOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EFA0", Offset = "0x6C7DBA0", VA = "0x186C7EFA0", Slot = "29")]
	public HHDNLBNGHMC<Dictionary<HEJGHJHBLCB, int>> CNMAFHPFDJI(long GLOFJPFEAOO, long NJDNKLCCOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DCC0", Offset = "0x6C7C8C0", VA = "0x186C7DCC0", Slot = "37")]
	public bool AONMHENLBDN(long GLOFJPFEAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C85550", Offset = "0x6C84150", VA = "0x186C85550", Slot = "56")]
	public bool KMDOIPCHLEP(long GLOFJPFEAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E520", Offset = "0x6C7D120", VA = "0x186C7E520", Slot = "38")]
	public bool CAIHOPHBPCA(long GLOFJPFEAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C85A80", Offset = "0x6C84680", VA = "0x186C85A80", Slot = "57")]
	public bool LGMAOGCBKEG(long GLOFJPFEAOO, [Out] NCJKDFCIEIG GJBJOKBJAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C86360", Offset = "0x6C84F60", VA = "0x186C86360", Slot = "39")]
	public bool MMICJHLJLOF(long KBHMJIHHPGB, [Out] DateTime BHKLEEBDBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D090", Offset = "0x6C7BC90", VA = "0x186C7D090", Slot = "40")]
	public long AGFDPGIGKGL(long KBHMJIHHPGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C85950", Offset = "0x6C84550", VA = "0x186C85950", Slot = "41")]
	public long LDGKNJIIECB(long GLOFJPFEAOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C84FA0", Offset = "0x6C83BA0", VA = "0x186C84FA0", Slot = "42")]
	public int JPAMNFDBNEH(long KBHMJIHHPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C85870", Offset = "0x6C84470", VA = "0x186C85870", Slot = "43")]
	public bool LDCIJDHEGID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C81B70", Offset = "0x6C80770", VA = "0x186C81B70", Slot = "44")]
	public bool FKGPFJLOALA(long KBHMJIHHPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C89130", Offset = "0x6C87D30", VA = "0x186C89130", Slot = "45")]
	public IReadOnlyList<long> PAMDJOFLDJO(long KBHMJIHHPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C82DF0", Offset = "0x6C819F0", VA = "0x186C82DF0", Slot = "46")]
	public int HGCIMFFCGME(long KBHMJIHHPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D5D0", Offset = "0x6C7C1D0", VA = "0x186C7D5D0", Slot = "50")]
	public long AMKHDKCOOFK(long FDBGEPLOLNL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C86000", Offset = "0x6C84C00", VA = "0x186C86000", Slot = "51")]
	public HEJGHJHBLCB MJBENGCEOGB()
	{
		return default(HEJGHJHBLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C86F10", Offset = "0x6C85B10", VA = "0x186C86F10")]
	private bool NJNOOLHDFGH(Guid PGLONPJBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C869F0", Offset = "0x6C855F0", VA = "0x186C869F0")]
	private void NCLCMLGILJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C88C30", Offset = "0x6C87830", VA = "0x186C88C30")]
	private HEJGHJHBLCB OJALILEGJMG()
	{
		return default(HEJGHJHBLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C82350", Offset = "0x6C80F50", VA = "0x186C82350")]
	private void GDHMNKGKDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C88A90", Offset = "0x6C87690", VA = "0x186C88A90")]
	private int OHMGEIDLAFN(KeepsakeRoomListDTO DBIJOBCMPBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E5C0", Offset = "0x6C7D1C0", VA = "0x186C7E5C0")]
	private int CBIOKNMDHLN(DateTime PKOLELKKPMB, DateTime OMGBGDIOLBH, TimeSpan FCPHCOMKDLK, int IMNECOKLOGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C847F0", Offset = "0x6C833F0", VA = "0x186C847F0")]
	private void JHEALFDJEML(IEnumerable<KeepsakeInstanceDTO> KMIAOIDIGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81870", Offset = "0x6C80470", VA = "0x186C81870")]
	private void FDLDCDAPANH(IEnumerable<KeepsakeCollectionRecordDTO> OIPPCEBIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F110", Offset = "0x6C7DD10", VA = "0x186C7F110")]
	private void CPLBKFKOCNM(IEnumerable<long> HIDOJOCPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xBFF7E0", Offset = "0xBFE3E0", VA = "0x180BFF7E0")]
	private void AANMDEMPCMC(KeepsakeGlobalConfigDTO FNCLLKGLOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C893E0", Offset = "0x6C87FE0", VA = "0x186C893E0")]
	private bool PPJGJIHOHHC(HEJGHJHBLCB GCOLDAKADHJ, [Out] Guid AGGJIHHFHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FCB0", Offset = "0x6C7E8B0", VA = "0x186C7FCB0")]
	private bool DNILICGBDOJ([Out] Guid AGGJIHHFHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FC50", Offset = "0x6C7E850", VA = "0x186C7FC50")]
	private bool DMNHBHINJNE(Guid PGLONPJBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C82AE0", Offset = "0x6C816E0", VA = "0x186C82AE0")]
	private IEnumerable<Guid> GNDHHLLKIBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C81E70", Offset = "0x6C80A70", VA = "0x186C81E70")]
	private IEnumerable<KeepsakeInstanceDTO> FOPMPBGNACG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C84A80", Offset = "0x6C83680", VA = "0x186C84A80")]
	private void JJBCNOPONHG(Guid PGLONPJBOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F060", Offset = "0x6C7DC60", VA = "0x186C7F060")]
	private bool CPEPLBGMJDN(Guid PGLONPJBOEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D9E0", Offset = "0x6C7C5E0", VA = "0x186C7D9E0")]
	private void ANBIMAPIPBE(Guid PGLONPJBOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C80DC0", Offset = "0x6C7F9C0", VA = "0x186C80DC0")]
	private void EMHBFGJNMEG(HEJGHJHBLCB GGOHEOEPIEI, int ILMOEOPPFGN, Dictionary<HEJGHJHBLCB, int> OBCNIGDIFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E410", Offset = "0x6C7D010", VA = "0x186C7E410")]
	private int BMCLNFFFLNF(HEJGHJHBLCB GCOLDAKADHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DF00", Offset = "0x6C7CB00", VA = "0x186C7DF00")]
	private void BGKILPFOEPA(KeepsakeInstanceDTO KLOPBHAMKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C88880", Offset = "0x6C87480", VA = "0x186C88880")]
	private void OHHNEPNKDOG(KeepsakeInstanceDTO KLOPBHAMKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C85180", Offset = "0x6C83D80", VA = "0x186C85180")]
	private void KDPECGCAFAE(Guid PGLONPJBOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D050", Offset = "0x6C7BC50", VA = "0x186C7D050")]
	private void MGLECGJMCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EBE0", Offset = "0x6C7D7E0", VA = "0x186C7EBE0")]
	private void CKHNAPMGLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C83FA0", Offset = "0x6C82BA0", VA = "0x186C83FA0")]
	private void IGGOPNBJBPA(JBMPDGIJAJE GNCJCGJGMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D050", Offset = "0x6C7BC50", VA = "0x186C7D050")]
	private void AFAKJLHAAHI(DPNFAMEPFGE PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D050", Offset = "0x6C7BC50", VA = "0x186C7D050")]
	private void GBNPNPFMEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EC00", Offset = "0x6C7D800", VA = "0x186C7EC00")]
	private void CLGNOAFDEEI(float GFACMBMMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C83880", Offset = "0x6C82480", VA = "0x186C83880")]
	private void HNHHELDNGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C85670", Offset = "0x6C84270", VA = "0x186C85670")]
	private bool LBOOBPEIPEL(Guid PGLONPJBOEL, [Out] string DOMNOHMGCFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C85E30", Offset = "0x6C84A30", VA = "0x186C85E30")]
	private bool MANNDBOLKHP(Guid PGLONPJBOEL, [Out] KeepsakeCategoryConfigDTO GGOHEOEPIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C83E20", Offset = "0x6C82A20", VA = "0x186C83E20")]
	private void HNMOLAMOKBG(string NMFCIBCONKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C815D0", Offset = "0x6C801D0", VA = "0x186C815D0")]
	private bool FDACOHGOGAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C864A0", Offset = "0x6C850A0", VA = "0x186C864A0")]
	private List<long> MODCKDNKNPD(IEnumerable<KeepsakeRoomDTO> KCNKBBCKFOE, IReadOnlyList<KeepsakeRoomListDTO> HNAGNFPCLBK, long KBHMJIHHPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E6C0", Offset = "0x6C7D2C0", VA = "0x186C7E6C0")]
	private bool CFHLKDEFLNE(Guid PGLONPJBOEL, [Out] string IHNODDPNJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C86EB0", Offset = "0x6C85AB0", VA = "0x186C86EB0", Slot = "47")]
	public string NDHCEBHPHDO(GFDAEJNIKMG PEOFIEMIPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C81F30", Offset = "0x6C80B30", VA = "0x186C81F30", Slot = "49")]
	public string GANJIJGGIDC(GFDAEJNIKMG PEOFIEMIPOK, long GLOFJPFEAOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DD20", Offset = "0x6C7C920", VA = "0x186C7DD20", Slot = "48")]
	public string BAOIBDAPMFG(GFDAEJNIKMG PEOFIEMIPOK, int JEHCNGHIEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C87410", Offset = "0x6C86010", VA = "0x186C87410")]
	private void NMBEOKGLHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C816E0", Offset = "0x6C802E0", VA = "0x186C816E0")]
	private void FDDFJPAHMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C85A60", Offset = "0x6C84660", VA = "0x186C85A60")]
	private GFDAEJNIKMG LFFMAHDNIKM(KEIDIPHHKEB EKBDIOBHJCD)
	{
		return default(GFDAEJNIKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E500", Offset = "0x6C7D100", VA = "0x186C7E500")]
	private GFDAEJNIKMG BNIFLPDOJNP(KEIDIPHHKEB EKBDIOBHJCD)
	{
		return default(GFDAEJNIKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C82EA0", Offset = "0x6C81AA0", VA = "0x186C82EA0")]
	internal static string HICPMPENJDI(FJHDAABADEM EMHBPBPAMFL, string NMJKCFDBLEP, bool CDAJONEHBNJ, int EEMMLANOOMD, int HJIKCBEEJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FD80", Offset = "0x6C7E980", VA = "0x186C7FD80", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C80360", Offset = "0x6C7EF60", VA = "0x186C80360")]
	private BKDEHOMOLNC EIIJGPMBHEB(JNNGHBDDOHB KJLMNGICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C84630", Offset = "0x6C83230", VA = "0x186C84630")]
	private MINIIFFOFBF IMKDDBEBFLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C80800", Offset = "0x6C7F400", VA = "0x186C80800")]
	private Task ELPBMGJFLJL(BEHJNDNGPEO JIAHCJFCHOA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C7DDF0", Offset = "0x6C7C9F0", VA = "0x186C7DDF0")]
	[AsyncStateMachine(typeof(JDAOHCDBGFJ))]
	private Task BELPLFFKFMI(BEHJNDNGPEO JIAHCJFCHOA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C88F00", Offset = "0x6C87B00", VA = "0x186C88F00")]
	private Task OLMKBFOHPHN(BEHJNDNGPEO JIAHCJFCHOA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C868C0", Offset = "0x6C854C0", VA = "0x186C868C0")]
	[AsyncStateMachine(typeof(ALPNOKKLFDJ))]
	private Task NCEBJGLAHDA(string LFKIGNHCOID, TimeSpan BFALLICLLDN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C893C0", Offset = "0x6C87FC0", VA = "0x186C893C0")]
	[CompilerGenerated]
	private void PNPPEKJFKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C82A90", Offset = "0x6C81690", VA = "0x186C82A90")]
	[CompilerGenerated]
	private void GJMGBLJKCIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C82990", Offset = "0x6C81590", VA = "0x186C82990")]
	[CompilerGenerated]
	private bool GFBEKHJJELI(KeepsakeInstanceDTO MBJABMPNEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C82C80", Offset = "0x6C81880", VA = "0x186C82C80")]
	[CompilerGenerated]
	private HHDNLBNGHMC<Dictionary<HEJGHJHBLCB, int>> HAFHFAKOHED(Dictionary<Guid, HEJGHJHBLCB> NHFCEHLNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C883F0", Offset = "0x6C86FF0", VA = "0x186C883F0")]
	[CompilerGenerated]
	private HHDNLBNGHMC<Dictionary<HEJGHJHBLCB, int>> OAIPAGPGCJC(Dictionary<Guid, HEJGHJHBLCB> NHFCEHLNLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C893A0", Offset = "0x6C87FA0", VA = "0x186C893A0")]
	[CompilerGenerated]
	private bool PFLOAFLNAEA(KeepsakeRoomListDTO MBJABMPNEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F790", Offset = "0x6C7E390", VA = "0x186C7F790")]
	[CompilerGenerated]
	private bool DDCBKCAJGIL(KeepsakeInstanceDTO MBJABMPNEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C87280", Offset = "0x6C85E80", VA = "0x186C87280")]
	[CompilerGenerated]
	private void NLCIOMJACMH(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<HEJGHJHBLCB, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CBFFADJCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C7CD70", Offset = "0x6C7B970", VA = "0x186C7CD70")]
	[CompilerGenerated]
	private void ABDCACPELHN(string IHNODDPNJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E0D0", Offset = "0x6C7CCD0", VA = "0x186C7E0D0")]
	[CompilerGenerated]
	private Task BIMOFGOCFGF(CancellationToken BKIIFLBJIFA)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, DGPJCKMIHCC<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class MPLEAHMLMPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
				public MPLEAHMLMPJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6C8C100", Offset = "0x6C8AD00", VA = "0x186C8C100")]
				internal bool DBHDIELGDPF(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6C8C100", Offset = "0x6C8AD00", VA = "0x186C8C100")]
				internal bool EGJABNMBHGF(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6C8BD80", Offset = "0x6C8A980", VA = "0x186C8BD80")]
			public bool ENDOAEACJHG(string GHGMNDDPDNB, [Out] KeepsakeTheme ADAENFEGFLI)
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
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8BD00", Offset = "0x6C8A900", VA = "0x186C8BD00")]
		[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
		internal static void JDLGENCKOOG(EAEKKMJPCLA EBEEBGHJNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8F3410", Offset = "0x8F2010", VA = "0x1808F3410")]
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
