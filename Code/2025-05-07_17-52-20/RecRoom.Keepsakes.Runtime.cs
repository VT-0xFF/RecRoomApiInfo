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
		[Cpp2IlInjected.Address(RVA = "0x7CB67B0", Offset = "0x7CB57B0", VA = "0x187CB67B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IPHICIAMMHH : IComparer<AFACIFHCNFE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CIKPMNLIFFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AFACIFHCNFE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AFACIFHCNFE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CIKPMNLIFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCC7C90", Offset = "0xCC6C90", VA = "0x180CC7C90")]
		internal bool FKJEAFKOHGF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E75D10", Offset = "0x1E74D10", VA = "0x181E75D10")]
		internal bool BMGCFKOHHBH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCC7C90", Offset = "0xCC6C90", VA = "0x180CC7C90")]
		internal bool ANEKHBJKDHJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E75D10", Offset = "0x1E74D10", VA = "0x181E75D10")]
		internal bool IGPENJAIJMO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> OFPOALBHIKE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public IPHICIAMMHH(List<KeepsakeCategoryThemePair> DANFIPBJOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6900", Offset = "0x7CA5900", VA = "0x187CA6900", Slot = "4")]
	public int Compare(AFACIFHCNFE CEJAAIDLEPA, AFACIFHCNFE IMNDAJIDDFG)
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
		public AFACIFHCNFE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJNCDIOGCJG]
public class LECBEAFJNJC : NKOPLKBCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EBLKHEJAGIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AFACIFHCNFE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EBLKHEJAGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5CC0", Offset = "0x7CA4CC0", VA = "0x187CA5CC0")]
		internal KGAPFDAFEHM<Guid> PJMDOHJBLEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5C00", Offset = "0x7CA4C00", VA = "0x187CA5C00")]
		internal void HKDIMOGKEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5C60", Offset = "0x7CA4C60", VA = "0x187CA5C60")]
		internal void NAFBPJKPNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CA57F0", Offset = "0x7CA47F0", VA = "0x187CA57F0")]
		internal void EDDGMHFOJAN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5C30", Offset = "0x7CA4C30", VA = "0x187CA5C30")]
		internal void IJIPKCOLLBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HAGNLCFMKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LECBEAFJNJC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public HAGNLCFMKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA63C0", Offset = "0x7CA53C0", VA = "0x187CA63C0")]
		internal void PBPCJBNJPGM(BHMEEJACIIA response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6360", Offset = "0x7CA5360", VA = "0x187CA6360")]
		internal void KHFJPFANONA(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JCMNEOHLOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JCMNEOHLOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6BB0", Offset = "0x7CA5BB0", VA = "0x187CA6BB0")]
		internal bool BCJBDLADILP(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JPHMOAPCKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AFACIFHCNFE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JPHMOAPCKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6C00", Offset = "0x7CA5C00", VA = "0x187CA6C00")]
		internal void ENLOPNMJOGH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6BD0", Offset = "0x7CA5BD0", VA = "0x187CA6BD0")]
		internal void CKMMHNOBNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6C90", Offset = "0x7CA5C90", VA = "0x187CA6C90")]
		internal KGAPFDAFEHM<IEnumerable<Guid>> KMDFCLCEIEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77D6030", Offset = "0x77D5030", VA = "0x1877D6030")]
		internal bool GJJGHNKAMPG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PJBJBHAFMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public JPHMOAPCKJD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PJBJBHAFMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6450", Offset = "0x7CB5450", VA = "0x187CB6450")]
		internal KGAPFDAFEHM<IEnumerable<Guid>> CLJOMILJDKH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HIEAOGADHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public PJBJBHAFMBJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public HIEAOGADHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6770", Offset = "0x7CA5770", VA = "0x187CA6770")]
		internal bool CKKKKJMMICG(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EPNMBMPIJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HIEAOGADHHO CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EPNMBMPIJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5F00", Offset = "0x7CA4F00", VA = "0x187CA5F00")]
		internal bool JOBAJBIFEOP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BCLECBMAEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BCLECBMAEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5440", Offset = "0x7CA4440", VA = "0x187CA5440")]
		internal KGAPFDAFEHM<IEnumerable<Guid>> MEEBNIAOGCA(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5420", Offset = "0x7CA4420", VA = "0x187CA5420")]
		internal bool GALPCPDJBBA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OFGHMHGBAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LECBEAFJNJC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OFGHMHGBAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5AC0", Offset = "0x7CB4AC0", VA = "0x187CB5AC0")]
		internal void MNBOIKDNPCB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6BD0", Offset = "0x7CA5BD0", VA = "0x187CA6BD0")]
		internal void FKCPEOMMKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5B50", Offset = "0x7CB4B50", VA = "0x187CB5B50")]
		internal KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> NIIBFAGNIJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77D6030", Offset = "0x77D5030", VA = "0x1877D6030")]
		internal bool HBHGAGGDBEC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FBAGHLJAFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FBAGHLJAFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5FB0", Offset = "0x7CA4FB0", VA = "0x187CA5FB0")]
		internal KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> AAPNJNBIKCE(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KEFIDKPPBJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KEFIDKPPBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7CA70E0", Offset = "0x7CA60E0", VA = "0x187CA70E0")]
		internal bool HCKNLEAJDCE(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6F90", Offset = "0x7CA5F90", VA = "0x187CA6F90")]
		internal KeyValuePair<Guid, AFACIFHCNFE> GDICKBCOHBO(Guid instanceId)
		{
			return default(KeyValuePair<Guid, AFACIFHCNFE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class ALMDENPHAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ALMDENPHAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x24AEBC0", Offset = "0x24ADBC0", VA = "0x1824AEBC0")]
		internal bool PHCALKNNMHI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HHPHGKMIHEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public HHPHGKMIHEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x24AEBC0", Offset = "0x24ADBC0", VA = "0x1824AEBC0")]
		internal bool JMHLJMLLBLI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GBMDGEJDGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GBMDGEJDGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6160", Offset = "0x7CA5160", VA = "0x187CA6160")]
		internal KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> FDHNHKFOKJI(Dictionary<Guid, AFACIFHCNFE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5420", Offset = "0x7CA4420", VA = "0x187CA5420")]
		internal bool EMEFAPIEBJG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EOBEDGLAAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EOBEDGLAAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5E80", Offset = "0x7CA4E80", VA = "0x187CA5E80")]
		internal bool GLECEIPNIPM(KeyValuePair<Guid, AFACIFHCNFE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BKNJMCPBHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, AFACIFHCNFE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BKNJMCPBHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA55B0", Offset = "0x7CA45B0", VA = "0x187CA55B0")]
		internal KeyValuePair<AFACIFHCNFE, int> AMLJBPBAEJN(AFACIFHCNFE category)
		{
			return default(KeyValuePair<AFACIFHCNFE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GNJGGLMMHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AFACIFHCNFE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GNJGGLMMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xDDA490", Offset = "0xDD9490", VA = "0x180DDA490")]
		internal bool IBLKGDCPPCE(AFACIFHCNFE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ANMFNGAINBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, AFACIFHCNFE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ANMFNGAINBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7CA52D0", Offset = "0x7CA42D0", VA = "0x187CA52D0")]
		internal KeyValuePair<AFACIFHCNFE, int> JPMFKCMPJDI(AFACIFHCNFE category)
		{
			return default(KeyValuePair<AFACIFHCNFE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MKPJIKANHJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AFACIFHCNFE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MKPJIKANHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDDA490", Offset = "0xDD9490", VA = "0x180DDA490")]
		internal bool JIDODGEABFE(AFACIFHCNFE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OEGKGKLOHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OEGKGKLOHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB59B0", Offset = "0x7CB49B0", VA = "0x187CB59B0")]
		internal bool JMCLOKKGGKP(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB58F0", Offset = "0x7CB48F0", VA = "0x187CB58F0")]
		internal bool JAMFNLCENPL(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5AA0", Offset = "0x7CB4AA0", VA = "0x187CB5AA0")]
		internal bool LKLCIEFGIBE(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5AA0", Offset = "0x7CB4AA0", VA = "0x187CB5AA0")]
		internal bool MMBBGECEINP(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NKBCGPLMGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NKBCGPLMGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xE3FC80", Offset = "0xE3EC80", VA = "0x180E3FC80")]
		internal bool FEDFDBFKNDJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NHDPCMGFCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NHDPCMGFCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CB57C0", Offset = "0x7CB47C0", VA = "0x187CB57C0")]
		internal bool IBPFOOBGCBJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x24555A0", Offset = "0x24545A0", VA = "0x1824555A0")]
		internal bool NLDJMGFBGKH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IMLMOFPBOGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IMLMOFPBOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA68A0", Offset = "0x7CA58A0", VA = "0x187CA68A0")]
		internal bool HFPBACCMEBD(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class POIIABKOGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public POIIABKOGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xE3FC80", Offset = "0xE3EC80", VA = "0x180E3FC80")]
		internal bool JFPIBNAMOJH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LDAOAJAPMFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LDAOAJAPMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CA7410", Offset = "0x7CA6410", VA = "0x187CA7410")]
		internal bool JGGEMJMLDGF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JGFCFIJDAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AFACIFHCNFE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JGFCFIJDAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2089AF0", Offset = "0x2088AF0", VA = "0x182089AF0")]
		internal bool FOJAJHAJPJG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EDNKGIMPOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EDNKGIMPOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5E20", Offset = "0x7CA4E20", VA = "0x187CA5E20")]
		internal bool DEIOBJBGIMF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OBFACGHIOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AFACIFHCNFE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OBFACGHIOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB58B0", Offset = "0x7CB48B0", VA = "0x187CB58B0")]
		internal bool JPAEKFPBBLB(KeyValuePair<Guid, AFACIFHCNFE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IMIIDBCBLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AFACIFHCNFE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IMIIDBCBLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2089AF0", Offset = "0x2088AF0", VA = "0x182089AF0")]
		internal bool GBBKKOMPBIL(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ADHEOCNJLNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ADHEOCNJLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5250", Offset = "0x7CA4250", VA = "0x187CA5250")]
		internal bool FHJLDBPBADG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DEFOELMGGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DEFOELMGGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5700", Offset = "0x7CA4700", VA = "0x187CA5700")]
		internal bool JMEGODOEOKG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PDEHFDAEGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DEFOELMGGEG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PDEHFDAEGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CB63D0", Offset = "0x7CB53D0", VA = "0x187CB63D0")]
		internal bool IPLKKIPEOEO(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ONNGBHANMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JOEFAEBJKIB args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5E40", Offset = "0x7CB4E40", VA = "0x187CB5E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CB6370", Offset = "0x7CB5370", VA = "0x187CB6370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct MJKIECGFLOE : IAsyncStateMachine
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
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CB54D0", Offset = "0x7CB44D0", VA = "0x187CB54D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB5760", Offset = "0x7CB4760", VA = "0x187CB5760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime FNOHCKAPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OALKBAEBPMC NGBPIDANFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ACLHKLLKNMH MFIGFFKMKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly EFKGGIOBKBJ KJGIFOBJBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KLKLDJKIJAI IHLJLJKADLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GHEABDPEEMJ BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HBLAEJNBENG DLDECNJKBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MBAMAOLNFEE MHAEOAHGKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HLICHGGPCCA IMGLEKANDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JEPLPAAEIMH AFBAPDBEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HEAKNPJEKDG LAIFMBJMEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LDBCIIKLAGJ EKPGCGJEGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HGPCKPIAKLB HCKHHIJHPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CFFBBPKENGE KMMCBALEKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ILKBOCNMCLO<KeepsakesConfig.KeepsakesOptions> BFEGEHMOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JAHOCBPGMLL AJHJEIPEGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> AGJEJPPAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> ODDKGOAOBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> CJKLGNELOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<AFACIFHCNFE, int> EPDCMHIAAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> BFLODJPCBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable KBPKFMHMMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task IHGDHMCMLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KGAPFDAFEHM<Guid> MKAACNEOJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? BFJACEAHEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO EGAPGLGIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KGAPFDAFEHM<KeepsakeProgressionEventInstancesDTO> MHOAEJGEOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<AFACIFHCNFE, KeepsakeCategoryConfigDTO> KCJMFPEDJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO NHIBEEAMDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> OAANKPILHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> OJPNLOGFKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> GIHECAEIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> CMGGFJCELCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> KHGGJMBPKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> MMAEBJDCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> JLFLAGHEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> GOIOOBPMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> FGDNLEJGHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> JMBHBEKBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> LANHHPOHOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> HGPKOKCMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime FNKKFCKABLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable GHOHNJCABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, AFACIFHCNFE> JKAANIJPEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<AFACIFHCNFE, int> LDJONBJNGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> DANFIPBJOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IPHICIAMMHH CAKBCJBAFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool OAIKHKPDNMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LBLJPFEFHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1DF60", Offset = "0xA1CF60", VA = "0x180A1DF60", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CD80", VA = "0x180A1DD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GPHDADNBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CADDC0", Offset = "0x7CACDC0", VA = "0x187CADDC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NPJFMOBNCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CB3E40", Offset = "0x7CB2E40", VA = "0x187CB3E40", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long ANBOEKFEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CACD20", Offset = "0x7CABD20", VA = "0x187CACD20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OGPDCFPPNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1E70", Offset = "0x7CB0E70", VA = "0x187CB1E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IEDPPGBODIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7CA87B0", Offset = "0x7CA77B0", VA = "0x187CA87B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GMDHBIAAJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA9F930", Offset = "0xA9E930", VA = "0x180A9F930", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> MEBCPDPMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA0EB0", Offset = "0xA9FEB0", VA = "0x180AA0EB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> HDNOBIJEPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAB04C0", Offset = "0xAAF4C0", VA = "0x180AB04C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DCKCBGAGKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9A820", Offset = "0xA99820", VA = "0x180A9A820", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool OLMKHKNNOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB6B6B0", Offset = "0xB6A6B0", VA = "0x180B6B6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NMCEDEGNFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0700", Offset = "0x7CAF700", VA = "0x187CB0700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE8E0", Offset = "0x7CAD8E0", VA = "0x187CAE8E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IFGNHOJLIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAD2F0", Offset = "0x7CAC2F0", VA = "0x187CAD2F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB10B0", Offset = "0x7CB00B0", VA = "0x187CB10B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ELCIPCDALKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0440", Offset = "0x7CAF440", VA = "0x187CB0440", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7CABA10", Offset = "0x7CAAA10", VA = "0x187CABA10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3F00", Offset = "0x7CB2F00", VA = "0x187CB3F00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LECBEAFJNJC([DJIFKCCBBND(null)][NotNull] OALKBAEBPMC NGBPIDANFJD, [NotNull][DJIFKCCBBND(null)] JJOKNLDHNDC DGGBKPBNENO, [NotNull][DJIFKCCBBND(null)] ACLHKLLKNMH MFIGFFKMKAE, [NotNull][DJIFKCCBBND(null)] EFKGGIOBKBJ KJGIFOBJBII, [DJIFKCCBBND(null)][NotNull] KLKLDJKIJAI IHLJLJKADLH, [DJIFKCCBBND(null)][NotNull] GHEABDPEEMJ BFCIGLOEMAP, [DJIFKCCBBND(null)][NotNull] HBLAEJNBENG DLDECNJKBCP, [NotNull][DJIFKCCBBND(null)] MBAMAOLNFEE MHAEOAHGKDE, [NotNull][DJIFKCCBBND(null)] LDMAAALPMPJ NODDAHEDIAD, [NotNull][DJIFKCCBBND(null)] CNKBCNLGABK PAOEKOPNKAL, [NotNull][DJIFKCCBBND(null)] HLICHGGPCCA IMGLEKANDJE, [NotNull][DJIFKCCBBND(null)] JEPLPAAEIMH AFBAPDBEIOD, [NotNull][DJIFKCCBBND(null)] HEAKNPJEKDG LAIFMBJMEGH, [NotNull][DJIFKCCBBND(null)] LDBCIIKLAGJ EKPGCGJEGDB, [DJIFKCCBBND(null)][NotNull] HGPCKPIAKLB HCKHHIJHPNM, [DJIFKCCBBND(null)][NotNull] CFFBBPKENGE KMMCBALEKPA, [NotNull][DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF, [DJIFKCCBBND(null)][NotNull] ILKBOCNMCLO<KeepsakesConfig.KeepsakesOptions> BFEGEHMOFBB, [NotNull][DJIFKCCBBND(null)] JAHOCBPGMLL AJHJEIPEGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEFB0", Offset = "0x7CADFB0", VA = "0x187CAEFB0", Slot = "15")]
	public bool IBBMGDLHIDE(List<string> DOMAEGHOIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9AF0", Offset = "0x7CA8AF0", VA = "0x187CA9AF0", Slot = "16")]
	public KGAPFDAFEHM<Guid> CBBAGMCFADN(AFACIFHCNFE HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3160", Offset = "0x7CB2160", VA = "0x187CB3160", Slot = "17")]
	public HPIGCMLNLFB OOKKLLFFHHB(Guid JMMICACHJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAA30", Offset = "0x7CA9A30", VA = "0x187CAAA30", Slot = "18")]
	public HPIGCMLNLFB DGIEHHIBNHN(Guid JMMICACHJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CB05A0", Offset = "0x7CAF5A0", VA = "0x187CB05A0", Slot = "19")]
	public bool KCIHHGPDIPG(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CACDF0", Offset = "0x7CABDF0", VA = "0x187CACDF0", Slot = "20")]
	public bool FJCHHOLFEHN(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA8C0", Offset = "0x7CA98C0", VA = "0x187CAA8C0")]
	public KeepsakeTheme CLALKOJNLOL(Guid JMMICACHJNH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD110", Offset = "0x7CAC110", VA = "0x187CAD110")]
	public bool FNMGFNIGAHH(AFACIFHCNFE HCKJHIJFJHB, [Out] KeepsakeTheme LCKKGMFHCLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC7F0", Offset = "0x7CAB7F0", VA = "0x187CAC7F0")]
	public List<KeepsakeTheme> FBHHOIFPJCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CACBA0", Offset = "0x7CABBA0", VA = "0x187CACBA0")]
	public int FELGBNANGCJ(AFACIFHCNFE HCKJHIJFJHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8650", Offset = "0x7CA7650", VA = "0x187CA8650")]
	public AFACIFHCNFE BMKMJNPJIMJ(Guid JMMICACHJNH)
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CA84A0", Offset = "0x7CA74A0", VA = "0x187CA84A0", Slot = "34")]
	public List<AFACIFHCNFE> BKBPFKAAOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CB29D0", Offset = "0x7CB19D0", VA = "0x187CB29D0", Slot = "35")]
	public IComparer<AFACIFHCNFE> OBOIJEABHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAE40", Offset = "0x7CA9E40", VA = "0x187CAAE40", Slot = "32")]
	public string DMMHNIIOGNE(AFACIFHCNFE HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2000", Offset = "0x7CB1000", VA = "0x187CB2000", Slot = "33")]
	public string MBNPJOJFEFL(AFACIFHCNFE HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CADE10", Offset = "0x7CACE10", VA = "0x187CADE10", Slot = "21")]
	public bool HFMHJOKKBNO(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0FF0", Offset = "0x7CAFFF0", VA = "0x187CB0FF0", Slot = "22")]
	public void KOOENPJKLND(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1060", Offset = "0x7CB0060", VA = "0x187CB1060", Slot = "23")]
	public void LABPHLPNBGM(AFACIFHCNFE HCKJHIJFJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2790", Offset = "0x7CB1790", VA = "0x187CB2790", Slot = "24")]
	public void OAKGNPCBDEL(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFD10", Offset = "0x7CAED10", VA = "0x187CAFD10", Slot = "25")]
	public int JJAMMPPCNIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9730", Offset = "0x7CA8730", VA = "0x187CA9730", Slot = "31")]
	public KGAPFDAFEHM<IEnumerable<Guid>> CAMDHOLMIIO(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CACF80", Offset = "0x7CABF80", VA = "0x187CACF80", Slot = "30")]
	public KGAPFDAFEHM<IEnumerable<Guid>> FNJDKOMMEDN(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7A70", Offset = "0x7CA6A70", VA = "0x187CA7A70", Slot = "54")]
	public KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> AONNEBOCJBF(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0C10", Offset = "0x7CAFC10", VA = "0x187CB0C10", Slot = "55")]
	public KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> KJAJJFFHEEN(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE990", Offset = "0x7CAD990", VA = "0x187CAE990", Slot = "26")]
	public KGAPFDAFEHM<int> HMOOFKNMDEG(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD9C0", Offset = "0x7CAC9C0", VA = "0x187CAD9C0", Slot = "27")]
	public KGAPFDAFEHM<int> GIKBMDOIEBH(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD390", Offset = "0x7CAC390", VA = "0x187CAD390", Slot = "28")]
	public KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> GAKLEELILCF(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0ED0", Offset = "0x7CAFED0", VA = "0x187CB0ED0", Slot = "29")]
	public KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> KNAPILKEBKG(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CB23D0", Offset = "0x7CB13D0", VA = "0x187CB23D0", Slot = "37")]
	public bool MPKOKCOBPGN(long CINEDGEJAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0F90", Offset = "0x7CAFF90", VA = "0x187CB0F90", Slot = "56")]
	public bool KNEOGKOKCGB(long CINEDGEJAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0B70", Offset = "0x7CAFB70", VA = "0x187CB0B70", Slot = "38")]
	public bool KIDMMMNJBKG(long CINEDGEJAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF960", Offset = "0x7CAE960", VA = "0x187CAF960", Slot = "57")]
	public bool JAOHPBAKFDJ(long CINEDGEJAIA, [Out] HBIEODGBPJP JKGMBBJKHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2DB0", Offset = "0x7CB1DB0", VA = "0x187CB2DB0", Slot = "39")]
	public bool OHDLCKOLKLK(long LEFNFFBHJLH, [Out] DateTime PCOPOHCFOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA380", Offset = "0x7CA9380", VA = "0x187CAA380", Slot = "40")]
	public long CIPNDKFOHMO(long LEFNFFBHJLH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0DA0", Offset = "0x7CAFDA0", VA = "0x187CB0DA0", Slot = "41")]
	public long KLJDKKKJPMN(long CINEDGEJAIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF780", Offset = "0x7CAE780", VA = "0x187CAF780", Slot = "42")]
	public int IMLPCICOANG(long LEFNFFBHJLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC710", Offset = "0x7CAB710", VA = "0x187CAC710", Slot = "43")]
	public bool EJLAOEGCPAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE580", Offset = "0x7CAD580", VA = "0x187CAE580", Slot = "44")]
	public bool HICOLJJMCJD(long LEFNFFBHJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2EF0", Offset = "0x7CB1EF0", VA = "0x187CB2EF0", Slot = "45")]
	public IReadOnlyList<long> OJDGLONCKHN(long LEFNFFBHJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1A70", Offset = "0x7CB0A70", VA = "0x187CB1A70", Slot = "46")]
	public int LFOFCFKLNCI(long LEFNFFBHJLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7470", Offset = "0x7CA6470", VA = "0x187CA7470", Slot = "50")]
	public long AAEOKOGAAMB(long NBJFEGFELAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEC40", Offset = "0x7CADC40", VA = "0x187CAEC40", Slot = "51")]
	public AFACIFHCNFE HNNDJMBLIDL()
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1C90", Offset = "0x7CB0C90", VA = "0x187CB1C90")]
	private bool LHIHCECELPM(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE0B0", Offset = "0x7CAD0B0", VA = "0x187CAE0B0")]
	private void HHHFMILOEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CA81C0", Offset = "0x7CA71C0", VA = "0x187CA81C0")]
	private AFACIFHCNFE BJEHNKDMJCN()
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CAC0D0", Offset = "0x7CAB0D0", VA = "0x187CAC0D0")]
	private void EHLNELGCGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA78D0", Offset = "0x7CA68D0", VA = "0x187CA78D0")]
	private int AKPKFJAHCCA(KeepsakeRoomListDTO NPCFGEHHIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2CB0", Offset = "0x7CB1CB0", VA = "0x187CB2CB0")]
	private int OGHAPHFOGDF(DateTime LONKALAOHFJ, DateTime DNKHHGLMKIP, TimeSpan FNAMPKBJNAA, int IIAMKMGPMAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB01B0", Offset = "0x7CAF1B0", VA = "0x187CB01B0")]
	private void JPMNGOLIBIC(IEnumerable<KeepsakeInstanceDTO> AGJEJPPAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2180", Offset = "0x7CB1180", VA = "0x187CB2180")]
	private void MIBKFFEGJFK(IEnumerable<KeepsakeCollectionRecordDTO> MEBNFOKBONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAADE0", Offset = "0x7CA9DE0", VA = "0x187CAADE0")]
	private void DHONBNNDJIP(IEnumerable<long> NHDFHNMBLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xABA740", Offset = "0xAB9740", VA = "0x180ABA740")]
	private void EJPGFIJBOCF(KeepsakeGlobalConfigDTO NHIBEEAMDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3BD0", Offset = "0x7CB2BD0", VA = "0x187CB3BD0")]
	private bool PKOKONDNNFC(AFACIFHCNFE HCKJHIJFJHB, [Out] Guid KOPMOEEACCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA110", Offset = "0x7CA9110", VA = "0x187CAA110")]
	private bool CBOCPBLDFOE([Out] Guid KOPMOEEACCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0150", Offset = "0x7CAF150", VA = "0x187CB0150")]
	private bool JPMEEFDFHLN(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CACE20", Offset = "0x7CABE20", VA = "0x187CACE20")]
	private IEnumerable<Guid> FNCEPDACNEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CB04E0", Offset = "0x7CAF4E0", VA = "0x187CB04E0")]
	private IEnumerable<KeepsakeInstanceDTO> KCFIAEOCENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAFC0", Offset = "0x7CA9FC0", VA = "0x187CAAFC0")]
	private void DOIPNBPPLNB(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1DC0", Offset = "0x7CB0DC0", VA = "0x187CB1DC0")]
	private bool LJGJLGNIHMA(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2430", Offset = "0x7CB1430", VA = "0x187CB2430")]
	private void NBBBIDLBDMB(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF430", Offset = "0x7CAE430", VA = "0x187CAF430")]
	private void IJMMHKBEHNP(AFACIFHCNFE BMEHNMPPGJP, int MKEAIFEPEDJ, Dictionary<AFACIFHCNFE, int> EBHOGNIHHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2AB0", Offset = "0x7CB1AB0", VA = "0x187CB2AB0")]
	private int ODAGAINEPLA(AFACIFHCNFE HCKJHIJFJHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE710", Offset = "0x7CAD710", VA = "0x187CAE710")]
	private void HJALLKIOCCI(KeepsakeInstanceDTO LFNFMCBMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7E20", Offset = "0x7CA6E20", VA = "0x187CA7E20")]
	private void BABLDOGDDHI(KeepsakeInstanceDTO LFNFMCBMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB33E0", Offset = "0x7CB23E0", VA = "0x187CB33E0")]
	private void PDDHONKBENF(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAA00", Offset = "0x7CA9A00", VA = "0x187CAAA00")]
	private void FCDKBNJEABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA78B0", Offset = "0x7CA68B0", VA = "0x187CA78B0")]
	private void AHJLCDDEEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CA96C0", Offset = "0x7CA86C0", VA = "0x187CA96C0")]
	private void BONLKPHLNPB(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAA00", Offset = "0x7CA9A00", VA = "0x187CAAA00")]
	private void MGMLBGHJCFJ(NPAEHGHLPDF BOMDCGFKGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAA00", Offset = "0x7CA9A00", VA = "0x187CAAA00")]
	private void DCLCIADAFJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB670", Offset = "0x7CAA670", VA = "0x187CAB670")]
	private void EDOMDFCNJEL(float ECBHLBONMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CABB30", Offset = "0x7CAAB30", VA = "0x187CABB30")]
	private void EHLEELDJNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1150", Offset = "0x7CB0150", VA = "0x187CB1150")]
	private bool LAMIKCLPMJD(Guid JMMICACHJNH, [Out] string JODDHBMOGLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA1B0", Offset = "0x7CA91B0", VA = "0x187CAA1B0")]
	private bool CEEGINGHOCJ(Guid JMMICACHJNH, [Out] KeepsakeCategoryConfigDTO BMEHNMPPGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF510", Offset = "0x7CAE510", VA = "0x187CAF510")]
	private void IKDEBNCKKDN(string HKOKFJFBOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF320", Offset = "0x7CAE320", VA = "0x187CAF320")]
	private bool IIFHKIFKKHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CB37B0", Offset = "0x7CB27B0", VA = "0x187CB37B0")]
	private List<long> PGMLLHGIACD(IEnumerable<KeepsakeRoomDTO> EDKLNJCHBGM, IReadOnlyList<KeepsakeRoomListDTO> OGKLOLLJFHF, long LEFNFFBHJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1350", Offset = "0x7CB0350", VA = "0x187CB1350")]
	private bool LBGHCBMHNGB(Guid JMMICACHJNH, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3A90", Offset = "0x7CB2A90", VA = "0x187CB3A90", Slot = "47")]
	public string PJOLPNLHCHD(KFHGHFECODO EFDNENPKLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD5A0", Offset = "0x7CAC5A0", VA = "0x187CAD5A0", Slot = "49")]
	public string GBJCBBBHNEI(KFHGHFECODO EFDNENPKLBL, long CINEDGEJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF240", Offset = "0x7CAE240", VA = "0x187CAF240", Slot = "48")]
	public string IBNONOAANNC(KFHGHFECODO EFDNENPKLBL, int BBHCPOJFPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA87C0", Offset = "0x7CA77C0", VA = "0x187CA87C0")]
	private void BNENMMOEDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF5F0", Offset = "0x7CAE5F0", VA = "0x187CAF5F0")]
	private void IKOAHNKOALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CAADC0", Offset = "0x7CA9DC0", VA = "0x187CAADC0")]
	private KFHGHFECODO DGKJABNMJCF(MCEBFBBCOHL COMHFDPJFFN)
	{
		return default(KFHGHFECODO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1870", Offset = "0x7CB0870", VA = "0x187CB1870")]
	private KFHGHFECODO LCBPNJADCOJ(MCEBFBBCOHL COMHFDPJFFN)
	{
		return default(KFHGHFECODO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1890", Offset = "0x7CB0890", VA = "0x187CB1890")]
	internal static string LCJOIIFOHEH(BHMEEJACIIA CGKDHHEHGIL, string PBKDFEGIFHB, bool PCLIHCFJJKH, int KHOCALLPCNJ, int HCECBCJAPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB210", Offset = "0x7CAA210", VA = "0x187CAB210", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CABAB0", Offset = "0x7CAAAB0", VA = "0x187CABAB0")]
	private GGIHIJCCBHJ EHBANKHCLAC(AIPAHMNCJKP DODIIHCCFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CB25D0", Offset = "0x7CB15D0", VA = "0x187CB25D0")]
	private LFLPPHCMPGO NDHMFNIHOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CB07B0", Offset = "0x7CAF7B0", VA = "0x187CB07B0")]
	private Task KGNODACOBFF(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2BA0", Offset = "0x7CB1BA0", VA = "0x187CB2BA0")]
	[AsyncStateMachine(typeof(ONNGBHANMAL))]
	private Task ODJJBDEMKIJ(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3AF0", Offset = "0x7CB2AF0", VA = "0x187CB3AF0")]
	private Task PJPGPFGLAKM(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CADB20", Offset = "0x7CACB20", VA = "0x187CADB20")]
	[AsyncStateMachine(typeof(MJKIECGFLOE))]
	private Task HADAPDODJED(string NAAMEAFIHJI, TimeSpan LLLNDHJJMGP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2A90", Offset = "0x7CB1A90", VA = "0x187CB2A90")]
	[CompilerGenerated]
	private void OCPCDFIADOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7730", Offset = "0x7CA6730", VA = "0x187CA7730")]
	[CompilerGenerated]
	private void AGDKIKBOJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1F00", Offset = "0x7CB0F00", VA = "0x187CB1F00")]
	[CompilerGenerated]
	private bool LMKGGMOPOIP(KeepsakeInstanceDTO CEJAAIDLEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1B20", Offset = "0x7CB0B20", VA = "0x187CB1B20")]
	[CompilerGenerated]
	private KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> LGLBDMBDOMI(Dictionary<Guid, AFACIFHCNFE> FKKOHBOMLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CADC50", Offset = "0x7CACC50", VA = "0x187CADC50")]
	[CompilerGenerated]
	private KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> HAEMMKKJKAI(Dictionary<Guid, AFACIFHCNFE> FKKOHBOMLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0EB0", Offset = "0x7CAFEB0", VA = "0x187CB0EB0")]
	[CompilerGenerated]
	private bool KMLEOFOIDMB(KeepsakeRoomListDTO CEJAAIDLEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7780", Offset = "0x7CA6780", VA = "0x187CA7780")]
	[CompilerGenerated]
	private bool AGFNFLEHBHK(KeepsakeInstanceDTO CEJAAIDLEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8030", Offset = "0x7CA7030", VA = "0x187CA8030")]
	[CompilerGenerated]
	private void BHHBKJGCHDM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<AFACIFHCNFE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NOMCIBPFMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CA85F0", Offset = "0x7CA75F0", VA = "0x187CA85F0")]
	[CompilerGenerated]
	private void BKKPIHBHOJL(string JHEMEKBLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB050", Offset = "0x7CAA050", VA = "0x187CAB050")]
	[CompilerGenerated]
	private Task DPLAOEKDFEP(CancellationToken LOJEONOEAMK)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, ILKBOCNMCLO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class OAOFGLHKCDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
				public OAOFGLHKCDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7CB5880", Offset = "0x7CB4880", VA = "0x187CB5880")]
				internal bool OECNGOEJMLE(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7CB5880", Offset = "0x7CB4880", VA = "0x187CB5880")]
				internal bool POFNPAPMAME(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7CA7240", Offset = "0x7CA6240", VA = "0x187CA7240")]
			public bool EGEJLKHFEAJ(string PDOFEIFJPIC, [Out] KeepsakeTheme LCKKGMFHCLN)
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA71C0", Offset = "0x7CA61C0", VA = "0x187CA71C0")]
		[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
		internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xBA1DF0", Offset = "0xBA0DF0", VA = "0x180BA1DF0")]
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
