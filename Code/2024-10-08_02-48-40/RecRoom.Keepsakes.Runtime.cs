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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6CACE80", Offset = "0x6CAC080", VA = "0x186CACE80", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MAPMKNIEEEA : IComparer<MHCJLGGOLOL>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LHACIMPMDNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MHCJLGGOLOL x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MHCJLGGOLOL y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LHACIMPMDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1258B70", Offset = "0x1257D70", VA = "0x181258B70")]
		internal bool LMCJBKAJMOK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17A7110", Offset = "0x17A6310", VA = "0x1817A7110")]
		internal bool PGAGDNJHMJP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1258B70", Offset = "0x1257D70", VA = "0x181258B70")]
		internal bool JKGGCGJKOIL(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17A7110", Offset = "0x17A6310", VA = "0x1817A7110")]
		internal bool ELDGINKKBPK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> KENBPMONABF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public MAPMKNIEEEA(List<KeepsakeCategoryThemePair> FNNLILEFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6CABA80", Offset = "0x6CAAC80", VA = "0x186CABA80", Slot = "4")]
	public int Compare(MHCJLGGOLOL AKHPALIKFFK, MHCJLGGOLOL PGLPHKNNCEF)
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
		public MHCJLGGOLOL KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HAAHLEBGOKA]
public class ABOHBBGCLMA : ONIHNJBGLHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IOPKLKPIFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MHCJLGGOLOL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IOPKLKPIFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAFF0", Offset = "0x6CAA1F0", VA = "0x186CAAFF0")]
		internal PIHPPMDHIHB<Guid> DLJBKJAIEJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB5E0", Offset = "0x6CAA7E0", VA = "0x186CAB5E0")]
		internal void MMBEJMKCCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB140", Offset = "0x6CAA340", VA = "0x186CAB140")]
		internal void GNNLLIEBEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB1D0", Offset = "0x6CAA3D0", VA = "0x186CAB1D0")]
		internal void JNEEJBOHBKA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB1A0", Offset = "0x6CAA3A0", VA = "0x186CAB1A0")]
		internal void HBEGNKIMNAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HHEJCPMIPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ABOHBBGCLMA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HHEJCPMIPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA900", Offset = "0x6CA9B00", VA = "0x186CAA900")]
		internal void HNDJIKIIAKG(DOFKLNOGMAN response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA8A0", Offset = "0x6CA9AA0", VA = "0x186CAA8A0")]
		internal void GMFLJIMHLOJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NPCLPFPGBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NPCLPFPGBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC380", Offset = "0x6CAB580", VA = "0x186CAC380")]
		internal bool KDDBKPAPONM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EOOILBAENHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MHCJLGGOLOL? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public EOOILBAENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA6A0", Offset = "0x6CA98A0", VA = "0x186CAA6A0")]
		internal void IAPHDFKCKCB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA730", Offset = "0x6CA9930", VA = "0x186CAA730")]
		internal void LFEAKKAHMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA3A0", Offset = "0x6CA95A0", VA = "0x186CAA3A0")]
		internal PIHPPMDHIHB<IEnumerable<Guid>> CMPJCMFCLKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x68DB270", Offset = "0x68DA470", VA = "0x1868DB270")]
		internal bool OFDFDKIHKLL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FNEAAFPPADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public EOOILBAENHC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public FNEAAFPPADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA760", Offset = "0x6CA9960", VA = "0x186CAA760")]
		internal PIHPPMDHIHB<IEnumerable<Guid>> DEGPFBJELJI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KKGNOFJKDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FNEAAFPPADB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KKGNOFJKDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB610", Offset = "0x6CAA810", VA = "0x186CAB610")]
		internal bool EIAKOFFOONK(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OOEACPMGAAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KKGNOFJKDBE CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OOEACPMGAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC3D0", Offset = "0x6CAB5D0", VA = "0x186CAC3D0")]
		internal bool ABFJLPEEOML(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AMLDKCEEOHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AMLDKCEEOHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9B10", Offset = "0x6CA8D10", VA = "0x186CA9B10")]
		internal PIHPPMDHIHB<IEnumerable<Guid>> HJNECMIMCOH(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9AF0", Offset = "0x6CA8CF0", VA = "0x186CA9AF0")]
		internal bool AHFBGKNAMLO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MMNNFCCBJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ABOHBBGCLMA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public MMNNFCCBJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6CABDB0", Offset = "0x6CAAFB0", VA = "0x186CABDB0")]
		internal void FEOCMCDENMP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA730", Offset = "0x6CA9930", VA = "0x186CAA730")]
		internal void OHOLKLKOHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CABE40", Offset = "0x6CAB040", VA = "0x186CABE40")]
		internal PIHPPMDHIHB<Dictionary<Guid, MHCJLGGOLOL>> HOCDEPIJOGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68DB270", Offset = "0x68DA470", VA = "0x1868DB270")]
		internal bool IBFMJJDDEOL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HLCMMKHHMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HLCMMKHHMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CAACB0", Offset = "0x6CA9EB0", VA = "0x186CAACB0")]
		internal PIHPPMDHIHB<Dictionary<Guid, MHCJLGGOLOL>> HLOPAMNCOGH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OOHEKMGAPNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OOHEKMGAPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC480", Offset = "0x6CAB680", VA = "0x186CAC480")]
		internal bool EBEENOOPKBC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC560", Offset = "0x6CAB760", VA = "0x186CAC560")]
		internal KeyValuePair<Guid, MHCJLGGOLOL> HGLIKKCOLDE(Guid instanceId)
		{
			return default(KeyValuePair<Guid, MHCJLGGOLOL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class MHEBIJOFCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public MHEBIJOFCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D23940", Offset = "0x1D22B40", VA = "0x181D23940")]
		internal bool LCJLHPKOJIC(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OKDHOFJFJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OKDHOFJFJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D23940", Offset = "0x1D22B40", VA = "0x181D23940")]
		internal bool DCHBPENADJH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PHNPPADCMBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public PHNPPADCMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC770", Offset = "0x6CAB970", VA = "0x186CAC770")]
		internal PIHPPMDHIHB<Dictionary<Guid, MHCJLGGOLOL>> CNLPDEGODFO(Dictionary<Guid, MHCJLGGOLOL> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9AF0", Offset = "0x6CA8CF0", VA = "0x186CA9AF0")]
		internal bool HBKHLLFILDH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MCPLDGMPFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public MCPLDGMPFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CABD30", Offset = "0x6CAAF30", VA = "0x186CABD30")]
		internal bool FCCHALPFADC(KeyValuePair<Guid, MHCJLGGOLOL> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AAELJIAIKLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, MHCJLGGOLOL> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AAELJIAIKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C9BBC0", Offset = "0x6C9ADC0", VA = "0x186C9BBC0")]
		internal KeyValuePair<MHCJLGGOLOL, int> EHEDGCEONJP(MHCJLGGOLOL category)
		{
			return default(KeyValuePair<MHCJLGGOLOL, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OGLLGEFEJNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MHCJLGGOLOL category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OGLLGEFEJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x931B50", Offset = "0x930D50", VA = "0x180931B50")]
		internal bool IDLEFCADNOE(MHCJLGGOLOL instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ICMPJCEMNDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, MHCJLGGOLOL> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public ICMPJCEMNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAE60", Offset = "0x6CAA060", VA = "0x186CAAE60")]
		internal KeyValuePair<MHCJLGGOLOL, int> EHBEKBLBNCJ(MHCJLGGOLOL category)
		{
			return default(KeyValuePair<MHCJLGGOLOL, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IECJIECGDDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MHCJLGGOLOL category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IECJIECGDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x931B50", Offset = "0x930D50", VA = "0x180931B50")]
		internal bool FKCLNKHMOJI(MHCJLGGOLOL instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NLMAMBFALMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NLMAMBFALMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC290", Offset = "0x6CAB490", VA = "0x186CAC290")]
		internal bool IGOCEJKBNAG(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC1B0", Offset = "0x6CAB3B0", VA = "0x186CAC1B0")]
		internal bool CENBCPAEKBF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC270", Offset = "0x6CAB470", VA = "0x186CAC270")]
		internal bool CFJHNFKABHO(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC270", Offset = "0x6CAB470", VA = "0x186CAC270")]
		internal bool NLLAGMPIEND(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FCDBBCOMBLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public FCDBBCOMBLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x98EA90", Offset = "0x98DC90", VA = "0x18098EA90")]
		internal bool AIBPKMFHJAC(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OOOELEAKOPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OOOELEAKOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC6B0", Offset = "0x6CAB8B0", VA = "0x186CAC6B0")]
		internal bool AGEECEOPJFL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CCBDD0", Offset = "0x1CCAFD0", VA = "0x181CCBDD0")]
		internal bool DGJFKNNCGFE(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CODILEGHNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CODILEGHNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA280", Offset = "0x6CA9480", VA = "0x186CAA280")]
		internal bool AGGGEDEPPMI(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GAOBFAOHFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GAOBFAOHFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x98EA90", Offset = "0x98DC90", VA = "0x18098EA90")]
		internal bool HNJPGJMDFDI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DJHJHOJBDMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DJHJHOJBDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA340", Offset = "0x6CA9540", VA = "0x186CAA340")]
		internal bool EGFOAHHABCH(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DKFIBCMACMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MHCJLGGOLOL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DKFIBCMACMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x199A1E0", Offset = "0x19993E0", VA = "0x18199A1E0")]
		internal bool IOAFLOBPKLI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DFNIKCDOCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DFNIKCDOCGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA2E0", Offset = "0x6CA94E0", VA = "0x186CAA2E0")]
		internal bool KEEGLPEFEBA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IFADFHMCMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MHCJLGGOLOL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IFADFHMCMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAFB0", Offset = "0x6CAA1B0", VA = "0x186CAAFB0")]
		internal bool AJHCKGNACND(KeyValuePair<Guid, MHCJLGGOLOL> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BBANNMBCJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MHCJLGGOLOL newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public BBANNMBCJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x199A1E0", Offset = "0x19993E0", VA = "0x18199A1E0")]
		internal bool BGGHHEDHMAI(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NCGADOCEDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NCGADOCEDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC130", Offset = "0x6CAB330", VA = "0x186CAC130")]
		internal bool NCIINLGMGIO(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LBCJLMKLPKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LBCJLMKLPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB990", Offset = "0x6CAAB90", VA = "0x186CAB990")]
		internal bool OENNPNNAEJC(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CBCNJKDGGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LBCJLMKLPKC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CBCNJKDGGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA200", Offset = "0x6CA9400", VA = "0x186CAA200")]
		internal bool AMNFENDHOJE(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct BCHJNHKANLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DIIPKNKAKCB args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9C80", Offset = "0x6CA8E80", VA = "0x186CA9C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA1A0", Offset = "0x6CA93A0", VA = "0x186CAA1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct PKPDGCBDODE : IAsyncStateMachine
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
		public ABOHBBGCLMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC970", Offset = "0x6CABB70", VA = "0x186CAC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6CACC10", Offset = "0x6CABE10", VA = "0x186CACC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime BBJAGKHOIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OPMENNKCOPJ NGGEMBHJHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KGKLHKLBHEP NOHKLCCPLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ANPEPIFJEGP BPMPHOMEAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DPEMLDCJKIP GHNIIHNFCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IOBGJGDLBKF CODOKBAINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly AJEBGAJKGME MJBKBMHNJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FIEDFBOFLNG NHCOKLIIHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IGFNPFMEJLK COJLHENICIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JNIPFIMJOIL AOADPAMHGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NHOIMAFHCFO APNANKOEAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FBDKKNGIJOJ PPLEABEAABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IHGIJIECEBN NDAPDKEPGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DKBNNPFDOBC LIDFPDLJKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DHBKDBOMAOI MIMCKPDCOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PACHMFNGNKE HIMGNMIHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MIFLDGENOJO<KeepsakesConfig.KeepsakesOptions> PCHCKDDGLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ILGPNHEOFNI KLIMJCHPKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> CNACNPONBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> BCMEMNIEBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> ILCNMBIAABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<MHCJLGGOLOL, int> NABPFEJCGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> LKEKOPHNJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable JEBJBIHGKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task LMCGBGKGNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private PIHPPMDHIHB<Guid> BODGJNKCGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? NIMEAOAJEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO HCDEPEFPGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PIHPPMDHIHB<KeepsakeProgressionEventInstancesDTO> ABLLNDPHFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<MHCJLGGOLOL, KeepsakeCategoryConfigDTO> NBNFKANBAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO NAHGFABJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> KFACGKEPODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> EDMOFEHDHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> CDPJBKKBKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> OMBCGNCNMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> KDJHDPCPGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> KCOPMFILAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> LMELPDDCGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> NPBHMDNLAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KJINNIIOAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OAAHKIJPIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> FMGHEEDCIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> JNPLHOECGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime MBHEGOEDFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable JJFLIJKIDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, MHCJLGGOLOL> FJLDKNLPOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<MHCJLGGOLOL, int> NOMDMFDJPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> FNNLILEFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MAPMKNIEEEA GKGJMIJNJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool CPBFEPIAJPJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BHIIJGKCICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC92370", VA = "0x180C93170", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD92370", Offset = "0xD91570", VA = "0x180D92370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KANFMEDKGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C650", Offset = "0x6C9B850", VA = "0x186C9C650", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KNCMFGGOKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7E40", Offset = "0x6CA7040", VA = "0x186CA7E40", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long DDKPAFBFPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2EC0", Offset = "0x6CA20C0", VA = "0x186CA2EC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? IHOPLCBOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2BA0", Offset = "0x6CA1DA0", VA = "0x186CA2BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IPILKBOMGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DA50", Offset = "0x6C9CC50", VA = "0x186C9DA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> NALAGIMKFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CB0", Offset = "0x8E4EB0", VA = "0x1808E5CB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KMBNGNGLGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9E40E0", Offset = "0x9E32E0", VA = "0x1809E40E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> OCLJLNNCMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9E0D80", Offset = "0x9DFF80", VA = "0x1809E0D80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> GLHMNMIMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C0", Offset = "0x90A6C0", VA = "0x18090B4C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool HEGHKBBFNON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C32CB0", Offset = "0x1C31EB0", VA = "0x181C32CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LKFHOONPBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E940", Offset = "0x6C9DB40", VA = "0x186C9E940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DA60", Offset = "0x6C9CC60", VA = "0x186C9DA60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FINNEPJOMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1B10", Offset = "0x6CA0D10", VA = "0x186CA1B10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E360", Offset = "0x6C9D560", VA = "0x186C9E360", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JJGCIEJNIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA41E0", Offset = "0x6CA33E0", VA = "0x186CA41E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6160", Offset = "0x6CA5360", VA = "0x186CA6160", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8580", Offset = "0x6CA7780", VA = "0x186CA8580")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ABOHBBGCLMA([GEFLINBOFNF(null)][NotNull] OPMENNKCOPJ NGGEMBHJHPC, [NotNull][GEFLINBOFNF(null)] DFLKLMDMHDN JNPKPDKGKHI, [NotNull][GEFLINBOFNF(null)] KGKLHKLBHEP NOHKLCCPLLL, [NotNull][GEFLINBOFNF(null)] ANPEPIFJEGP BPMPHOMEAML, [GEFLINBOFNF(null)][NotNull] DPEMLDCJKIP GHNIIHNFCII, [GEFLINBOFNF(null)][NotNull] IOBGJGDLBKF CODOKBAINDB, [GEFLINBOFNF(null)][NotNull] AJEBGAJKGME MJBKBMHNJEF, [NotNull][GEFLINBOFNF(null)] FIEDFBOFLNG NHCOKLIIHEE, [NotNull][GEFLINBOFNF(null)] IGFNPFMEJLK COJLHENICIL, [NotNull][GEFLINBOFNF(null)] MCGBNBBMNBG DBGJDLPGGLA, [NotNull][GEFLINBOFNF(null)] JNIPFIMJOIL AOADPAMHGJL, [NotNull][GEFLINBOFNF(null)] NHOIMAFHCFO APNANKOEAGD, [NotNull][GEFLINBOFNF(null)] FBDKKNGIJOJ PPLEABEAABL, [NotNull][GEFLINBOFNF(null)] IHGIJIECEBN NDAPDKEPGKL, [GEFLINBOFNF(null)][NotNull] DKBNNPFDOBC LIDFPDLJKOK, [GEFLINBOFNF(null)][NotNull] DHBKDBOMAOI MIMCKPDCOFK, [NotNull][GEFLINBOFNF(null)] PACHMFNGNKE HIMGNMIHEHA, [GEFLINBOFNF(null)][NotNull] MIFLDGENOJO<KeepsakesConfig.KeepsakesOptions> PCHCKDDGLBA, [NotNull][GEFLINBOFNF(null)] ILGPNHEOFNI KLIMJCHPKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2C30", Offset = "0x6CA1E30", VA = "0x186CA2C30", Slot = "15")]
	public bool JHOJFPNOAPH(List<string> KPLMFILOJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2F90", Offset = "0x6CA2190", VA = "0x186CA2F90", Slot = "16")]
	public PIHPPMDHIHB<Guid> JLOCJAFDIFF(MHCJLGGOLOL KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EA10", Offset = "0x6C9DC10", VA = "0x186C9EA10", Slot = "17")]
	public KAHDNIHNJDF DNBPABDJBGA(Guid PGHMPIEDMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5DE0", Offset = "0x6CA4FE0", VA = "0x186CA5DE0", Slot = "18")]
	public KAHDNIHNJDF NAEFEICNKMO(Guid PGHMPIEDMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6C50", Offset = "0x6CA5E50", VA = "0x186CA6C50", Slot = "19")]
	public bool OFDKBKKEONM(Guid PGHMPIEDMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2500", Offset = "0x6CA1700", VA = "0x186CA2500", Slot = "20")]
	public bool ICOBMONCJHB(Guid PGHMPIEDMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FDC0", Offset = "0x6C9EFC0", VA = "0x186C9FDC0")]
	public KeepsakeTheme EJJDIPCBDHN(Guid PGHMPIEDMEN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1BB0", Offset = "0x6CA0DB0", VA = "0x186CA1BB0")]
	public bool HBGFAHIAEOJ(MHCJLGGOLOL KLEDGAFGMCL, [Out] KeepsakeTheme NJOEPENBBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BD10", Offset = "0x6C9AF10", VA = "0x186C9BD10")]
	public List<KeepsakeTheme> AAJKADLKICC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D200", Offset = "0x6C9C400", VA = "0x186C9D200")]
	public int BPFDMDJEBHF(MHCJLGGOLOL KLEDGAFGMCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F8C0", Offset = "0x6C9EAC0", VA = "0x186C9F8C0")]
	public MHCJLGGOLOL EDJGABAIIKP(Guid PGHMPIEDMEN)
	{
		return default(MHCJLGGOLOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EE00", Offset = "0x6C9E000", VA = "0x186C9EE00", Slot = "34")]
	public List<MHCJLGGOLOL> DPIIFDFMIIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4280", Offset = "0x6CA3480", VA = "0x186CA4280", Slot = "35")]
	public IComparer<MHCJLGGOLOL> LFMLPLGGHHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CA40", Offset = "0x6C9BC40", VA = "0x186C9CA40", Slot = "32")]
	public string BCCPINCGHMG(MHCJLGGOLOL KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CBC0", Offset = "0x6C9BDC0", VA = "0x186C9CBC0", Slot = "33")]
	public string BEOPDLKIPEC(MHCJLGGOLOL KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CE10", Offset = "0x6C9C010", VA = "0x186C9CE10", Slot = "21")]
	public bool BKHNAOJPBDK(Guid PGHMPIEDMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5900", Offset = "0x6CA4B00", VA = "0x186CA5900", Slot = "22")]
	public void MMGMFGPIBLN(Guid PGHMPIEDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CD40", Offset = "0x6C9BF40", VA = "0x186C9CD40", Slot = "23")]
	public void BHFDFGGCKBO(MHCJLGGOLOL KLEDGAFGMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA17A0", Offset = "0x6CA09A0", VA = "0x186CA17A0", Slot = "24")]
	public void GPFFCFDFNOL(Guid PGHMPIEDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D530", Offset = "0x6C9C730", VA = "0x186C9D530", Slot = "25")]
	public int CHGMELHBDPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DC50", Offset = "0x6C9CE50", VA = "0x186C9DC50", Slot = "31")]
	public PIHPPMDHIHB<IEnumerable<Guid>> CLGDLPIOBKF(long MMNCPOOFGEF, long MCGEBBCEJDD, MHCJLGGOLOL? KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6CA59D0", Offset = "0x6CA4BD0", VA = "0x186CA59D0", Slot = "30")]
	public PIHPPMDHIHB<IEnumerable<Guid>> MOCJONDLJPM(long MMNCPOOFGEF, long MCGEBBCEJDD, MHCJLGGOLOL? KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0760", Offset = "0x6C9F960", VA = "0x186CA0760", Slot = "54")]
	public PIHPPMDHIHB<Dictionary<Guid, MHCJLGGOLOL>> FDFOINALFBE(long MMNCPOOFGEF, long MCGEBBCEJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D3A0", Offset = "0x6C9C5A0", VA = "0x186C9D3A0", Slot = "55")]
	public PIHPPMDHIHB<Dictionary<Guid, MHCJLGGOLOL>> CEFHIIHBLAL(long MMNCPOOFGEF, long MCGEBBCEJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1D90", Offset = "0x6CA0F90", VA = "0x186CA1D90", Slot = "26")]
	public PIHPPMDHIHB<int> HDOLCGJGNMN(long MMNCPOOFGEF, long MCGEBBCEJDD, MHCJLGGOLOL? KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0190", Offset = "0x6C9F390", VA = "0x186CA0190", Slot = "27")]
	public PIHPPMDHIHB<int> FADPAPNCBGN(long MMNCPOOFGEF, long MCGEBBCEJDD, MHCJLGGOLOL? KLEDGAFGMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6CA22F0", Offset = "0x6CA14F0", VA = "0x186CA22F0", Slot = "28")]
	public PIHPPMDHIHB<Dictionary<MHCJLGGOLOL, int>> HNNMDJIFLDL(long MMNCPOOFGEF, long MCGEBBCEJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8440", Offset = "0x6CA7640", VA = "0x186CA8440", Slot = "29")]
	public PIHPPMDHIHB<Dictionary<MHCJLGGOLOL, int>> PMDPJFCLKDJ(long MMNCPOOFGEF, long MCGEBBCEJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2050", Offset = "0x6CA1250", VA = "0x186CA2050", Slot = "37")]
	public bool HGKLCAKKOMO(long MMNCPOOFGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E260", Offset = "0x6C9D460", VA = "0x186C9E260", Slot = "56")]
	public bool CPNOKOKCPIL(long MMNCPOOFGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E2C0", Offset = "0x6C9D4C0", VA = "0x186C9E2C0", Slot = "38")]
	public bool DAODBOEIOON(long MMNCPOOFGEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5550", Offset = "0x6CA4750", VA = "0x186CA5550", Slot = "57")]
	public bool MKNBGHFJDJG(long MMNCPOOFGEF, [Out] HCNBJDDICFG ELDFGEEDFKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3770", Offset = "0x6CA2970", VA = "0x186CA3770", Slot = "39")]
	public bool JNEFNEPGFEN(long HLEPJJIGHKG, [Out] DateTime AANJEPBGMCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E400", Offset = "0x6C9D600", VA = "0x186C9E400", Slot = "40")]
	public long DGCNCMIFPEM(long HLEPJJIGHKG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA38B0", Offset = "0x6CA2AB0", VA = "0x186CA38B0", Slot = "41")]
	public long JNGFKDLAJID(long MMNCPOOFGEF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6780", Offset = "0x6CA5980", VA = "0x186CA6780", Slot = "42")]
	public int OBPFAMOBPPI(long HLEPJJIGHKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6CA39C0", Offset = "0x6CA2BC0", VA = "0x186CA39C0", Slot = "43")]
	public bool KABIJCCMOMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2640", Offset = "0x6CA1840", VA = "0x186CA2640", Slot = "44")]
	public bool IFIALPBGPDA(long HLEPJJIGHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4340", Offset = "0x6CA3540", VA = "0x186CA4340", Slot = "45")]
	public IEnumerable<long> LIAGALAEJAN(long HLEPJJIGHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5D30", Offset = "0x6CA4F30", VA = "0x186CA5D30", Slot = "46")]
	public int MOOMGLONAGA(long HLEPJJIGHKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6CA64C0", Offset = "0x6CA56C0", VA = "0x186CA64C0", Slot = "50")]
	public long OBMCMMMBBJH(long PNEPLOMLFAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4BB0", Offset = "0x6CA3DB0", VA = "0x186CA4BB0", Slot = "51")]
	public MHCJLGGOLOL MGIMHDJJBHI()
	{
		return default(MHCJLGGOLOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6CA19E0", Offset = "0x6CA0BE0", VA = "0x186CA19E0")]
	private bool GPGHCMKLCPI(Guid PGHMPIEDMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0D20", Offset = "0x6C9FF20", VA = "0x186CA0D20")]
	private void FMCPPHAINID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C770", Offset = "0x6C9B970", VA = "0x186C9C770")]
	private MHCJLGGOLOL BBPGMGLPGMI()
	{
		return default(MHCJLGGOLOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4F10", Offset = "0x6CA4110", VA = "0x186CA4F10")]
	private void MIGOKDMMBBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA02E0", Offset = "0x6C9F4E0", VA = "0x186CA02E0")]
	private int FALHGFHIPIA(KeepsakeRoomListDTO GGOPIMEAHMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D950", Offset = "0x6C9CB50", VA = "0x186C9D950")]
	private int CHHMMFAHPFK(DateTime JGGFKDOIEBN, DateTime AENKKHCIKNE, TimeSpan EJLDAIFNNKH, int KOKHDJCBNHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FF00", Offset = "0x6C9F100", VA = "0x186C9FF00")]
	private void ENKFIFIIEDK(IEnumerable<KeepsakeInstanceDTO> CNACNPONBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1360", Offset = "0x6CA0560", VA = "0x186CA1360")]
	private void GFELDMHHGJI(IEnumerable<KeepsakeCollectionRecordDTO> ADKHMDDGLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DB10", Offset = "0x6C9CD10", VA = "0x186C9DB10")]
	private void CLAFBFIGFJC(IEnumerable<long> EOELKHIFBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xE47550", Offset = "0xE46750", VA = "0x180E47550")]
	private void IHNJMHJLCIE(KeepsakeGlobalConfigDTO NAHGFABJLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E000", Offset = "0x6C9D200", VA = "0x186C9E000")]
	private bool CMKNBHDFCAI(MHCJLGGOLOL KLEDGAFGMCL, [Out] Guid BHOPODPBGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6200", Offset = "0x6CA5400", VA = "0x186CA6200")]
	private bool NNNOEGCIDDE([Out] Guid BHOPODPBGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6CA29A0", Offset = "0x6CA1BA0", VA = "0x186CA29A0")]
	private bool ILGKBNGJDPA(Guid PGHMPIEDMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7F00", Offset = "0x6CA7100", VA = "0x186CA7F00")]
	private IEnumerable<Guid> OPICPAADGBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6CA28E0", Offset = "0x6CA1AE0", VA = "0x186CA28E0")]
	private IEnumerable<KeepsakeInstanceDTO> IJGLHBMADCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6CA62A0", Offset = "0x6CA54A0", VA = "0x186CA62A0")]
	private void NNPHKPPHECL(Guid PGHMPIEDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6CA20B0", Offset = "0x6CA12B0", VA = "0x186CA20B0")]
	private bool HINGADMDBFM(Guid PGHMPIEDMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2A00", Offset = "0x6CA1C00", VA = "0x186CA2A00")]
	private void JDHGNBGHOCH(Guid PGHMPIEDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DB70", Offset = "0x6C9CD70", VA = "0x186C9DB70")]
	private void CLFFLFFJJFK(MHCJLGGOLOL OOGDAKLIBDA, int DDMGFDCDGKA, Dictionary<MHCJLGGOLOL, int> FBBMNMACLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4AC0", Offset = "0x6CA3CC0", VA = "0x186CA4AC0")]
	private int MGFENGGIMEG(MHCJLGGOLOL KLEDGAFGMCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA35A0", Offset = "0x6CA27A0", VA = "0x186CA35A0")]
	private void JMANCCKJDOM(KeepsakeInstanceDTO FKCMMLHGJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0480", Offset = "0x6C9F680", VA = "0x186CA0480")]
	private void FAOOPNBJPOE(KeepsakeInstanceDTO FKCMMLHGJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8050", Offset = "0x6CA7250", VA = "0x186CA8050")]
	private void PGALOJIEDDA(Guid PGHMPIEDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CDE0", Offset = "0x6C9BFE0", VA = "0x186C9CDE0")]
	private void FGCFJPAPADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D380", Offset = "0x6C9C580", VA = "0x186C9D380")]
	private void CEANEPNIOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4170", Offset = "0x6CA3370", VA = "0x186CA4170")]
	private void LAGEBAIELEH(LBACLDDCKCC NKIEKOPHFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CDE0", Offset = "0x6C9BFE0", VA = "0x186C9CDE0")]
	private void BJICCBNFOOO(JLKIEJHMDCI JMJAOKJJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CDE0", Offset = "0x6C9BFE0", VA = "0x186C9CDE0")]
	private void EJAPJJLFHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FA20", Offset = "0x6C9EC20", VA = "0x186C9FA20")]
	private void EGAOELOAHDC(float NKDNNEIGLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4520", Offset = "0x6CA3720", VA = "0x186CA4520")]
	private void LNNODLEAJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6CA15A0", Offset = "0x6CA07A0", VA = "0x186CA15A0")]
	private bool GNLNPDIIBJB(Guid PGHMPIEDMEN, [Out] string IBDDBOOMLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6DB0", Offset = "0x6CA5FB0", VA = "0x186CA6DB0")]
	private bool OJGGENMAAEH(Guid PGHMPIEDMEN, [Out] KeepsakeCategoryConfigDTO OOGDAKLIBDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0B10", Offset = "0x6C9FD10", VA = "0x186CA0B10")]
	private void FGOOFCGNDEO(string LCPJNEAFGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2530", Offset = "0x6CA1730", VA = "0x186CA2530")]
	private bool IFEJFDIKHBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3AA0", Offset = "0x6CA2CA0", VA = "0x186CA3AA0")]
	private IEnumerable<long> KACNCLAHBKJ(IEnumerable<KeepsakeRoomDTO> HJCLJOGBECB, IEnumerable<KeepsakeRoomListDTO> BABALIFLCOM, long HLEPJJIGHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EF40", Offset = "0x6C9E140", VA = "0x186C9EF40")]
	private bool DPOGNLEJDOK(Guid PGHMPIEDMEN, [Out] string BAHJDCJDFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D1A0", Offset = "0x6C9C3A0", VA = "0x186C9D1A0", Slot = "47")]
	public string BOMCMBHNKDJ(ACKOIJIFDPG JJCAHCAMKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3D50", Offset = "0x6CA2F50", VA = "0x186CA3D50", Slot = "49")]
	public string KDNOICGNFCN(ACKOIJIFDPG JJCAHCAMKID, long MMNCPOOFGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C6A0", Offset = "0x6C9B8A0", VA = "0x186C9C6A0", Slot = "48")]
	public string BAODIGIGDLM(ACKOIJIFDPG JJCAHCAMKID, int GCCIDOBEOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6F80", Offset = "0x6CA6180", VA = "0x186CA6F80")]
	private void OJIDIOPFDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2160", Offset = "0x6CA1360", VA = "0x186CA2160")]
	private void HJBOKJIAGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1340", Offset = "0x6CA0540", VA = "0x186CA1340")]
	private ACKOIJIFDPG GDDKDEDDPFB(LNBMFGHFODD BHAIBABKMIE)
	{
		return default(ACKOIJIFDPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2030", Offset = "0x6CA1230", VA = "0x186CA2030")]
	private ACKOIJIFDPG HGEGOIBDOAL(LNBMFGHFODD BHAIBABKMIE)
	{
		return default(ACKOIJIFDPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C0C0", Offset = "0x6C9B2C0", VA = "0x186C9C0C0")]
	internal static string AMHFKMABLLI(DOFKLNOGMAN CLPFGJJLCLL, string HPMANGOBDGI, bool HHBFOMOOEPF, int IGDNHDCGBBM, int GLPDIPNLDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F460", Offset = "0x6C9E660", VA = "0x186C9F460", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8500", Offset = "0x6CA7700", VA = "0x186CA8500")]
	private DBDMDNJLBIJ PMICJKKDDLD(FGKAGKAJGLO KGAJHFNOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5B70", Offset = "0x6CA4D70", VA = "0x186CA5B70")]
	private JNBMCDLLJCO MONKDPKJFNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C2A0", Offset = "0x6C9B4A0", VA = "0x186C9C2A0")]
	private Task ANPFGKAGEIC(DIIPKNKAKCB KLDEANCBDEG, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6CA27D0", Offset = "0x6CA19D0", VA = "0x186CA27D0")]
	[AsyncStateMachine(typeof(BCHJNHKANLC))]
	private Task IIFNKOACKJG(DIIPKNKAKCB KLDEANCBDEG, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0690", Offset = "0x6C9F890", VA = "0x186CA0690")]
	private Task FBBOKECCFOA(DIIPKNKAKCB KLDEANCBDEG, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0BF0", Offset = "0x6C9FDF0", VA = "0x186CA0BF0")]
	[AsyncStateMachine(typeof(PKPDGCBDODE))]
	private Task FJGPNKNMJBP(string ADNFLGLLNKI, TimeSpan MFLHDFLOLJL, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E9F0", Offset = "0x6C9DBF0", VA = "0x186C9E9F0")]
	[CompilerGenerated]
	private void DIBHJIHFJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CD90", Offset = "0x6C9BF90", VA = "0x186C9CD90")]
	[CompilerGenerated]
	private void BIBPKICDJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D0A0", Offset = "0x6C9C2A0", VA = "0x186C9D0A0")]
	[CompilerGenerated]
	private bool BLFFPOPBLGI(KeepsakeInstanceDTO AKHPALIKFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA11D0", Offset = "0x6CA03D0", VA = "0x186CA11D0")]
	[CompilerGenerated]
	private PIHPPMDHIHB<Dictionary<MHCJLGGOLOL, int>> FNMGOHPJHNF(Dictionary<Guid, MHCJLGGOLOL> NIAKAPGGBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EC90", Offset = "0x6C9DE90", VA = "0x186C9EC90")]
	[CompilerGenerated]
	private PIHPPMDHIHB<Dictionary<MHCJLGGOLOL, int>> DNCCDDDLKIP(Dictionary<Guid, MHCJLGGOLOL> NIAKAPGGBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8420", Offset = "0x6CA7620", VA = "0x186CA8420")]
	[CompilerGenerated]
	private bool PGLHEMNBJCA(KeepsakeRoomListDTO AKHPALIKFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6B20", Offset = "0x6CA5D20", VA = "0x186CA6B20")]
	[CompilerGenerated]
	private bool OELMEJIKAJI(KeepsakeInstanceDTO AKHPALIKFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6330", Offset = "0x6CA5530", VA = "0x186CA6330")]
	[CompilerGenerated]
	private void NOGHKPDELFM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MHCJLGGOLOL, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> BBJKDECJPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5970", Offset = "0x6CA4B70", VA = "0x186CA5970")]
	[CompilerGenerated]
	private void MNAFBCOBCHI(string BAHJDCJDFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6960", Offset = "0x6CA5B60", VA = "0x186CA6960")]
	[CompilerGenerated]
	private Task ODGIDONOALO(CancellationToken AFBCIHHPPDL)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, MIFLDGENOJO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class OBBMOPDNFJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
				public OBBMOPDNFJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6CAC3A0", Offset = "0x6CAB5A0", VA = "0x186CAC3A0")]
				internal bool PBLHAMJCGPC(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6CAC3A0", Offset = "0x6CAB5A0", VA = "0x186CAC3A0")]
				internal bool FFMGKOLBJFK(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6CAB7C0", Offset = "0x6CAA9C0", VA = "0x186CAB7C0")]
			public bool NEJHHIPNNPD(string IAOCAGNLCGA, [Out] KeepsakeTheme NJOEPENBBAB)
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
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB740", Offset = "0x6CAA940", VA = "0x186CAB740")]
		[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
		internal static void NLJAFONFJGA(KHAIBIPGEJP DDIEINIMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA0A330", Offset = "0xA09530", VA = "0x180A0A330")]
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
