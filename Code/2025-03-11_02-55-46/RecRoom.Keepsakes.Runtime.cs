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
		[Cpp2IlInjected.Address(RVA = "0x76363A0", Offset = "0x76357A0", VA = "0x1876363A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KOHONEKEAGC : IComparer<DINILGKMLAO>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class DBMBAOFBNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DINILGKMLAO x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public DINILGKMLAO y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DBMBAOFBNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBE1490", Offset = "0xBE0890", VA = "0x180BE1490")]
		internal bool LIKHMHOLANF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CAB090", Offset = "0x1CAA490", VA = "0x181CAB090")]
		internal bool MLKFKLLNLDE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBE1490", Offset = "0xBE0890", VA = "0x180BE1490")]
		internal bool ONBBCEJGCHN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CAB090", Offset = "0x1CAA490", VA = "0x181CAB090")]
		internal bool EHNCLJOJGOI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> EGKILLCDLEI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public KOHONEKEAGC(List<KeepsakeCategoryThemePair> DBDIELCMMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7634280", Offset = "0x7633680", VA = "0x187634280", Slot = "4")]
	public int Compare(DINILGKMLAO COMHOHNLIIN, DINILGKMLAO PJGBAACMKFF)
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
		public DINILGKMLAO KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MENIDINFMMJ]
public class CBPINMPIBJE : CMBFELMIEKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MHDAFAOMDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DINILGKMLAO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MHDAFAOMDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7634C30", Offset = "0x7634030", VA = "0x187634C30")]
		internal HHPFDJMLPAL<Guid> NEBOLDIKLMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7634BA0", Offset = "0x7633FA0", VA = "0x187634BA0")]
		internal void IBLDCJEJGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7634BD0", Offset = "0x7633FD0", VA = "0x187634BD0")]
		internal void IPBEGIFPLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7634D80", Offset = "0x7634180", VA = "0x187634D80")]
		internal void OPHLCENFDEL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7634B70", Offset = "0x7633F70", VA = "0x187634B70")]
		internal void CBLKLAFKPKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NPPHFALNAHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CBPINMPIBJE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NPPHFALNAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7635A90", Offset = "0x7634E90", VA = "0x187635A90")]
		internal void BGKBMNOIODB(MDCBBMPDEDC response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7635E40", Offset = "0x7635240", VA = "0x187635E40")]
		internal void JJFECKBOMIK(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HDEKAAFIDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HDEKAAFIDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x76337D0", Offset = "0x7632BD0", VA = "0x1876337D0")]
		internal bool LILLFACEJLC(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LADBCFBECCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DINILGKMLAO? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LADBCFBECCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7634A80", Offset = "0x7633E80", VA = "0x187634A80")]
		internal void MIJGDBHNNHG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7633F00", Offset = "0x7633300", VA = "0x187633F00")]
		internal void PNIAMIKALOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7634780", Offset = "0x7633B80", VA = "0x187634780")]
		internal HHPFDJMLPAL<IEnumerable<Guid>> GIGBOHDAKEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71AD4C0", Offset = "0x71AC8C0", VA = "0x1871AD4C0")]
		internal bool KBBPDPMPFFJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EPDLADDLNKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public LADBCFBECCL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EPDLADDLNKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76335B0", Offset = "0x76329B0", VA = "0x1876335B0")]
		internal HHPFDJMLPAL<IEnumerable<Guid>> PEGEEPNOINJ(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AJPECJBNGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public EPDLADDLNKJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AJPECJBNGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7624FE0", Offset = "0x76243E0", VA = "0x187624FE0")]
		internal bool HPANFMEIJNP(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JGDGFCGEIOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AJPECJBNGNC CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JGDGFCGEIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7633DC0", Offset = "0x76331C0", VA = "0x187633DC0")]
		internal bool DEJOBOGJMHE(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EDNDHFEAKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EDNDHFEAKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76332D0", Offset = "0x76326D0", VA = "0x1876332D0")]
		internal HHPFDJMLPAL<IEnumerable<Guid>> AJCCNJDGJGL(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7633440", Offset = "0x7632840", VA = "0x187633440")]
		internal bool AKIFNNAJGPP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KENEGEKEHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CBPINMPIBJE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KENEGEKEHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7633E70", Offset = "0x7633270", VA = "0x187633E70")]
		internal void KFNEEMKIJLH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7633F00", Offset = "0x7633300", VA = "0x187633F00")]
		internal void LNABBBHNDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7633F30", Offset = "0x7633330", VA = "0x187633F30")]
		internal HHPFDJMLPAL<Dictionary<Guid, DINILGKMLAO>> MLPGDBHLHCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71AD4C0", Offset = "0x71AC8C0", VA = "0x1871AD4C0")]
		internal bool KDFBOCCHDCP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EDFOMHFPKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EDFOMHFPKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7633120", Offset = "0x7632520", VA = "0x187633120")]
		internal HHPFDJMLPAL<Dictionary<Guid, DINILGKMLAO>> ONAJGEJCNBH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class MHICPHIEBJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MHICPHIEBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76352E0", Offset = "0x76346E0", VA = "0x1876352E0")]
		internal bool OMCCJONBFAM(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7635190", Offset = "0x7634590", VA = "0x187635190")]
		internal KeyValuePair<Guid, DINILGKMLAO> HIPMDFFBLPN(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DINILGKMLAO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GIOLOJKLBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GIOLOJKLBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x22B8260", Offset = "0x22B7660", VA = "0x1822B8260")]
		internal bool KPLAFDGFDEA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class APGHPGPCKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public APGHPGPCKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x22B8260", Offset = "0x22B7660", VA = "0x1822B8260")]
		internal bool OLABLENDOHJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PPEGLELLDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PPEGLELLDOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7635F90", Offset = "0x7635390", VA = "0x187635F90")]
		internal HHPFDJMLPAL<Dictionary<Guid, DINILGKMLAO>> KDONIHCOBAC(Dictionary<Guid, DINILGKMLAO> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7633440", Offset = "0x7632840", VA = "0x187633440")]
		internal bool FHADLHMCMJA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IKJIIFOJCKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public IKJIIFOJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7633B70", Offset = "0x7632F70", VA = "0x187633B70")]
		internal bool GMIFJPGCPDE(KeyValuePair<Guid, DINILGKMLAO> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EJLGBNOOPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, DINILGKMLAO> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EJLGBNOOPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7633460", Offset = "0x7632860", VA = "0x187633460")]
		internal KeyValuePair<DINILGKMLAO, int> JMDCPLPEFJB(DINILGKMLAO category)
		{
			return default(KeyValuePair<DINILGKMLAO, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KKHBPJPLPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DINILGKMLAO category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KKHBPJPLPBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xCF2BA0", Offset = "0xCF1FA0", VA = "0x180CF2BA0")]
		internal bool KBGKHFCJPBD(DINILGKMLAO instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MJLINJPPLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, DINILGKMLAO> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MJLINJPPLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x76353C0", Offset = "0x76347C0", VA = "0x1876353C0")]
		internal KeyValuePair<DINILGKMLAO, int> OPFGMFEENBG(DINILGKMLAO category)
		{
			return default(KeyValuePair<DINILGKMLAO, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GKFNMIMJGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DINILGKMLAO category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GKFNMIMJGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCF2BA0", Offset = "0xCF1FA0", VA = "0x180CF2BA0")]
		internal bool GLLANOGAFPK(DINILGKMLAO instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JECENJKKEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JECENJKKEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7633CB0", Offset = "0x76330B0", VA = "0x187633CB0")]
		internal bool GKDCBINEAOH(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7633BF0", Offset = "0x7632FF0", VA = "0x187633BF0")]
		internal bool DIBFOADLKJC(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7633DA0", Offset = "0x76331A0", VA = "0x187633DA0")]
		internal bool LJEJEKEDMFJ(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7633DA0", Offset = "0x76331A0", VA = "0x187633DA0")]
		internal bool NPBLPJPJEOO(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MJIALAIGMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MJIALAIGMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD50E80", Offset = "0xD50280", VA = "0x180D50E80")]
		internal bool MNDBLLJLKGN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BKDGCCHJPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BKDGCCHJPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7625140", Offset = "0x7624540", VA = "0x187625140")]
		internal bool CIONKFDMHEF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2277B70", Offset = "0x2276F70", VA = "0x182277B70")]
		internal bool ECCPAMCFLBE(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LDOLFIJGNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LDOLFIJGNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7634B10", Offset = "0x7633F10", VA = "0x187634B10")]
		internal bool IGCLLAFCBLD(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AGHJDBHKDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AGHJDBHKDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xD50E80", Offset = "0xD50280", VA = "0x180D50E80")]
		internal bool KACJDEJBAHA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HACNCDONIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HACNCDONIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x76336F0", Offset = "0x7632AF0", VA = "0x1876336F0")]
		internal bool ADPKAJKEEKA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PKCAELMBNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DINILGKMLAO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PKCAELMBNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3620", Offset = "0x1EB2A20", VA = "0x181EB3620")]
		internal bool BJOLKDEILNA(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KGLEMAJGCHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KGLEMAJGCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7634220", Offset = "0x7633620", VA = "0x187634220")]
		internal bool LNEJODJEBHM(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BNDOIJFJKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DINILGKMLAO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BNDOIJFJKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7625200", Offset = "0x7624600", VA = "0x187625200")]
		internal bool JNLOENADCHE(KeyValuePair<Guid, DINILGKMLAO> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DDJCKJKIDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DINILGKMLAO newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DDJCKJKIDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3620", Offset = "0x1EB2A20", VA = "0x181EB3620")]
		internal bool JJNKCBGOJEN(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HDAHFOGEAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HDAHFOGEAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7633750", Offset = "0x7632B50", VA = "0x187633750")]
		internal bool NNDCKCMIPJB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OBKOOFHOHAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OBKOOFHOHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7635EA0", Offset = "0x76352A0", VA = "0x187635EA0")]
		internal bool IIGHHFHGLBA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HDMAFOFPMDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OBKOOFHOHAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HDMAFOFPMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x76337F0", Offset = "0x7632BF0", VA = "0x1876337F0")]
		internal bool KGNPJBCLION(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MLPBKJBJELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DOFGKDAOBGJ args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7635510", Offset = "0x7634910", VA = "0x187635510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7635A30", Offset = "0x7634E30", VA = "0x187635A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HHILLJMLJEN : IAsyncStateMachine
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
		public CBPINMPIBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7633870", Offset = "0x7632C70", VA = "0x187633870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7633B10", Offset = "0x7632F10", VA = "0x187633B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime PEMBLHDKPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ILDFPNDOLOF AOGHNFPNLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ODCBBGIOGKP OGKGCJCMJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NFGBBPLJLMC OAAGOEANFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KBKDDDANPPI IMDFGDJNLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JHABIGLANJE OKINEPMMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OKNBBOOKNPK BLBCDIHEGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BEEMHPLPFOO AFMCEDMHHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HHMOMAGJIPE BCLILIMLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BNHIABEDMJE CHELLIFPKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ECPOMMMLMLP OBGADOODOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HDGOFKDDLOO ADMPIJOGFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GLHAJNDABIP CJEPBHGPJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BOONHAPKPMH OEBNGBGGEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BPDKBFIANMO BEIGAAKBPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly JJHMNFHFHIL NLLOMHBDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FDJAODJIBPM<KeepsakesConfig.KeepsakesOptions> OMCEIGOCOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly PAJFLGMBLIE OFOFLKGFIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FGMBAMFEJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> LGIGIFIBNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> EKJOAEBLDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<DINILGKMLAO, int> GKGMCJADJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> OIFANLLBPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable OHHOGJCLCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task FNPABJDCMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private HHPFDJMLPAL<Guid> NAFMHAHGKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DFBAABDJEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO LBMGGNKIIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HHPFDJMLPAL<KeepsakeProgressionEventInstancesDTO> KBLAMHBHJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<DINILGKMLAO, KeepsakeCategoryConfigDTO> NHDMLMIALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO MIHECABKJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> JDPCFPGJOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> LHDPBMKAEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> NBBJDBKIEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> PCEPNLOPEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> CGKDLMLDEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> BODPDNCCKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> DNDFHCMKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> IHMFHNMMCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DJHNLALKIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DPFEDKLBHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> OPFOEFJEFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> AEABFEJPEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime ONEHHCKHNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable FAFKDEBPLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, DINILGKMLAO> PEJEEJNJPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<DINILGKMLAO, int> JCMHCOCHGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> DBDIELCMMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KOHONEKEAGC MLBPGNGIJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool AIKILADHDLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CPPDPAAINMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x993140", Offset = "0x992540", VA = "0x180993140", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x992EC0", Offset = "0x9922C0", VA = "0x180992EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PNNGFJBGFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7629990", Offset = "0x7628D90", VA = "0x187629990", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JFJJMBCLLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7625730", Offset = "0x7624B30", VA = "0x187625730", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long OACPCOFCDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76284D0", Offset = "0x76278D0", VA = "0x1876284D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? EEFBMAONJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76267D0", Offset = "0x7625BD0", VA = "0x1876267D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool LBNEEFBPKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x762A490", Offset = "0x7629890", VA = "0x18762A490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GOFJLFLLMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C10", Offset = "0x9D9010", VA = "0x1809D9C10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> IMGPCADBDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9E2DD0", Offset = "0x9E21D0", VA = "0x1809E2DD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> EGKEIOJPKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9E36E0", Offset = "0x9E2AE0", VA = "0x1809E36E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> PEIHOCIHBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9E0F80", Offset = "0x9E0380", VA = "0x1809E0F80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool EPOLENKJDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA89B50", Offset = "0xA88F50", VA = "0x180A89B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> FANOOHKNOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76254C0", Offset = "0x76248C0", VA = "0x1876254C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x762AE40", Offset = "0x762A240", VA = "0x18762AE40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FLDHLGFCGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7629590", Offset = "0x7628990", VA = "0x187629590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x762BBA0", Offset = "0x762AFA0", VA = "0x18762BBA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DCMMMKGLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x762F150", Offset = "0x762E550", VA = "0x18762F150", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7625EB0", Offset = "0x76252B0", VA = "0x187625EB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7631B60", Offset = "0x7630F60", VA = "0x187631B60")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CBPINMPIBJE([PNFCCJKFMBH(null)][NotNull] ILDFPNDOLOF AOGHNFPNLIE, [NotNull][PNFCCJKFMBH(null)] HAGJBHKCPHN GAFKPKKAMEA, [NotNull][PNFCCJKFMBH(null)] ODCBBGIOGKP OGKGCJCMJAJ, [NotNull][PNFCCJKFMBH(null)] NFGBBPLJLMC OAAGOEANFDA, [PNFCCJKFMBH(null)][NotNull] KBKDDDANPPI IMDFGDJNLDI, [PNFCCJKFMBH(null)][NotNull] JHABIGLANJE OKINEPMMKIG, [PNFCCJKFMBH(null)][NotNull] OKNBBOOKNPK BLBCDIHEGEM, [NotNull][PNFCCJKFMBH(null)] BEEMHPLPFOO AFMCEDMHHLI, [NotNull][PNFCCJKFMBH(null)] HHMOMAGJIPE BCLILIMLEBK, [NotNull][PNFCCJKFMBH(null)] NHOGLAIMMNJ NJKFPNGDBPI, [NotNull][PNFCCJKFMBH(null)] BNHIABEDMJE CHELLIFPKBP, [NotNull][PNFCCJKFMBH(null)] ECPOMMMLMLP OBGADOODOLE, [NotNull][PNFCCJKFMBH(null)] HDGOFKDDLOO ADMPIJOGFNI, [NotNull][PNFCCJKFMBH(null)] GLHAJNDABIP CJEPBHGPJKB, [PNFCCJKFMBH(null)][NotNull] BOONHAPKPMH OEBNGBGGEOP, [PNFCCJKFMBH(null)][NotNull] BPDKBFIANMO BEIGAAKBPFK, [NotNull][PNFCCJKFMBH(null)] JJHMNFHFHIL NLLOMHBDPLH, [PNFCCJKFMBH(null)][NotNull] FDJAODJIBPM<KeepsakesConfig.KeepsakesOptions> OMCEIGOCOKM, [NotNull][PNFCCJKFMBH(null)] PAJFLGMBLIE OFOFLKGFIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x762F7A0", Offset = "0x762EBA0", VA = "0x18762F7A0", Slot = "15")]
	public bool OAGDHIDDMMJ(List<string> COFHLGOPHNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7627650", Offset = "0x7626A50", VA = "0x187627650", Slot = "16")]
	public HHPFDJMLPAL<Guid> EEADJLLBGGC(DINILGKMLAO HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7625C30", Offset = "0x7625030", VA = "0x187625C30", Slot = "17")]
	public OCLDKMPDLBK CKMMEACAPLI(Guid JFGNPLFCOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x762A0E0", Offset = "0x76294E0", VA = "0x18762A0E0", Slot = "18")]
	public OCLDKMPDLBK HBKILCIHALJ(Guid JFGNPLFCOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x762CE60", Offset = "0x762C260", VA = "0x18762CE60", Slot = "19")]
	public bool LCBMKMDKDKP(Guid JFGNPLFCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x762C500", Offset = "0x762B900", VA = "0x18762C500", Slot = "20")]
	public bool KEFPPNBJAHO(Guid JFGNPLFCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x762F660", Offset = "0x762EA60", VA = "0x18762F660")]
	public KeepsakeTheme NMNOOKNOHCN(Guid JFGNPLFCOBO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76288F0", Offset = "0x7627CF0", VA = "0x1876288F0")]
	public bool FOEKDIIHFFD(DINILGKMLAO HPIOPHHLCME, [Out] KeepsakeTheme PPLDKNELGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x762F1F0", Offset = "0x762E5F0", VA = "0x18762F1F0")]
	public List<KeepsakeTheme> NKIDCHBHPFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7625340", Offset = "0x7624740", VA = "0x187625340")]
	public int AOEJMGLDKBO(DINILGKMLAO HPIOPHHLCME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x762AEF0", Offset = "0x762A2F0", VA = "0x18762AEF0")]
	public DINILGKMLAO IPDPBGBBBBO(Guid JFGNPLFCOBO)
	{
		return default(DINILGKMLAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7631A00", Offset = "0x7630E00", VA = "0x187631A00", Slot = "34")]
	public List<DINILGKMLAO> PNKGANMAIIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7628830", Offset = "0x7627C30", VA = "0x187628830", Slot = "35")]
	public IComparer<DINILGKMLAO> FNLPMNMEENO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7626860", Offset = "0x7625C60", VA = "0x187626860", Slot = "32")]
	public string DCIGFJOCFHB(DINILGKMLAO HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x762B150", Offset = "0x762A550", VA = "0x18762B150", Slot = "33")]
	public string JAHJMNFAGDP(DINILGKMLAO HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76285A0", Offset = "0x76279A0", VA = "0x1876285A0", Slot = "21")]
	public bool FMFAKAGHEAI(Guid JFGNPLFCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x762C530", Offset = "0x762B930", VA = "0x18762C530", Slot = "22")]
	public void KEMLKPCBKPK(Guid JFGNPLFCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7626DA0", Offset = "0x76261A0", VA = "0x187626DA0", Slot = "23")]
	public void DGEKEIBLGGN(DINILGKMLAO HPIOPHHLCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x762CFC0", Offset = "0x762C3C0", VA = "0x18762CFC0", Slot = "24")]
	public void LFMKMJJGEGL(Guid JFGNPLFCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7628AD0", Offset = "0x7627ED0", VA = "0x187628AD0", Slot = "25")]
	public int FPLBKIDPMNN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x762C5A0", Offset = "0x762B9A0", VA = "0x18762C5A0", Slot = "31")]
	public HHPFDJMLPAL<IEnumerable<Guid>> KFKBNKDMCPK(long LFNEDMLHPHM, long NJNFCLODBKD, DINILGKMLAO? HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x762E190", Offset = "0x762D590", VA = "0x18762E190", Slot = "30")]
	public HHPFDJMLPAL<IEnumerable<Guid>> MIEPGOKJMKA(long LFNEDMLHPHM, long NJNFCLODBKD, DINILGKMLAO? HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x762E680", Offset = "0x762DA80", VA = "0x18762E680", Slot = "54")]
	public HHPFDJMLPAL<Dictionary<Guid, DINILGKMLAO>> MMBPGMGBIEM(long LFNEDMLHPHM, long NJNFCLODBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x762D200", Offset = "0x762C600", VA = "0x18762D200", Slot = "55")]
	public HHPFDJMLPAL<Dictionary<Guid, DINILGKMLAO>> LFNGLGBGCJF(long LFNEDMLHPHM, long NJNFCLODBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76257F0", Offset = "0x7624BF0", VA = "0x1876257F0", Slot = "26")]
	public HHPFDJMLPAL<int> CAMIGBONICD(long LFNEDMLHPHM, long NJNFCLODBKD, DINILGKMLAO? HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7626DF0", Offset = "0x76261F0", VA = "0x187626DF0", Slot = "27")]
	public HHPFDJMLPAL<int> DLLAIOGGAAD(long LFNEDMLHPHM, long NJNFCLODBKD, DINILGKMLAO? HPIOPHHLCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x762A4A0", Offset = "0x76298A0", VA = "0x18762A4A0", Slot = "28")]
	public HHPFDJMLPAL<Dictionary<DINILGKMLAO, int>> HOADFJAILMK(long LFNEDMLHPHM, long NJNFCLODBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x762C950", Offset = "0x762BD50", VA = "0x18762C950", Slot = "29")]
	public HHPFDJMLPAL<Dictionary<DINILGKMLAO, int>> KIFHIFFMIKJ(long LFNEDMLHPHM, long NJNFCLODBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x76269E0", Offset = "0x7625DE0", VA = "0x1876269E0", Slot = "37")]
	public bool DDCCPFEMFGL(long LFNEDMLHPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE50", Offset = "0x762E250", VA = "0x18762EE50", Slot = "56")]
	public bool MPOJNJNBKKJ(long LFNEDMLHPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7627410", Offset = "0x7626810", VA = "0x187627410", Slot = "38")]
	public bool EDAOAPCIGFA(long LFNEDMLHPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x762FA30", Offset = "0x762EE30", VA = "0x18762FA30", Slot = "57")]
	public bool OFKOANHAGGA(long LFNEDMLHPHM, [Out] LEKMNOIOGOB MLFEMIOGMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x762C3C0", Offset = "0x762B7C0", VA = "0x18762C3C0", Slot = "39")]
	public bool KDFLAEKHNBO(long GBKDJHCNOOI, [Out] DateTime OACMCPDNADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7625FB0", Offset = "0x76253B0", VA = "0x187625FB0", Slot = "40")]
	public long CPJNJOBEDPF(long GBKDJHCNOOI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x762F040", Offset = "0x762E440", VA = "0x18762F040", Slot = "41")]
	public long NGMBBOOLJEF(long LFNEDMLHPHM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76282F0", Offset = "0x76276F0", VA = "0x1876282F0", Slot = "42")]
	public int FBPMPKIICKB(long GBKDJHCNOOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7629D80", Offset = "0x7629180", VA = "0x187629D80", Slot = "43")]
	public bool GOAPFEJDJPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7630380", Offset = "0x762F780", VA = "0x187630380", Slot = "44")]
	public bool PFPDDILIAPA(long GBKDJHCNOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x762BD70", Offset = "0x762B170", VA = "0x18762BD70", Slot = "45")]
	public IReadOnlyList<long> JLNAAGAGBNF(long GBKDJHCNOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x762BA90", Offset = "0x762AE90", VA = "0x18762BA90", Slot = "46")]
	public int JJPIHIGONNN(long GBKDJHCNOOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x762AB80", Offset = "0x7629F80", VA = "0x18762AB80", Slot = "50")]
	public long IEBGCFKACMC(long PFLHBOPDNBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7626A40", Offset = "0x7625E40", VA = "0x187626A40", Slot = "51")]
	public DINILGKMLAO DFEDKBBDMAG()
	{
		return default(DINILGKMLAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7625600", Offset = "0x7624A00", VA = "0x187625600")]
	private bool BLCANDIJGGC(Guid JFGNPLFCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x762DC00", Offset = "0x762D000", VA = "0x18762DC00")]
	private void MEIKBEPPPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x762D7C0", Offset = "0x762CBC0", VA = "0x18762D7C0")]
	private DINILGKMLAO MDIOKLHINEF()
	{
		return default(DINILGKMLAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7628F50", Offset = "0x7628350", VA = "0x187628F50")]
	private void GAOMNFEGAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x762BFE0", Offset = "0x762B3E0", VA = "0x18762BFE0")]
	private int JPGGNBKCNID(KeepsakeRoomListDTO OBGMNFFOBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x762B050", Offset = "0x762A450", VA = "0x18762B050")]
	private int JABGAEFJMEJ(DateTime LFLPLFMOKMD, DateTime NFLHHCFFIID, TimeSpan OEHDKBLCGBN, int PJAGOCNGEOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x762B5F0", Offset = "0x762A9F0", VA = "0x18762B5F0")]
	private void JIEFNEHLMMK(IEnumerable<KeepsakeInstanceDTO> FGMBAMFEJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x762C180", Offset = "0x762B580", VA = "0x18762C180")]
	private void KBINEHKGOGO(IEnumerable<KeepsakeCollectionRecordDTO> GNOBAOMDMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7628EF0", Offset = "0x76282F0", VA = "0x187628EF0")]
	private void GADHOKMLFGE(IEnumerable<long> LHBLGBELIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9DD710", Offset = "0x9DCB10", VA = "0x1809DD710")]
	private void OAAILEBBPBE(KeepsakeGlobalConfigDTO MIHECABKJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7629E60", Offset = "0x7629260", VA = "0x187629E60")]
	private bool GOOAKAHMKAF(DINILGKMLAO HPIOPHHLCME, [Out] Guid PPJCGEJGNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x762B2D0", Offset = "0x762A6D0", VA = "0x18762B2D0")]
	private bool JBDEHFNLNIA([Out] Guid PPJCGEJGNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x762D760", Offset = "0x762CB60", VA = "0x18762D760")]
	private bool MDHJJPNLDPA(Guid JFGNPLFCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7625A90", Offset = "0x7624E90", VA = "0x187625A90")]
	private IEnumerable<Guid> CILGEFBAMFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x762F5A0", Offset = "0x762E9A0", VA = "0x18762F5A0")]
	private IEnumerable<KeepsakeInstanceDTO> NMNHCMDIACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7625570", Offset = "0x7624970", VA = "0x187625570")]
	private void BFOEECFEMKO(Guid JFGNPLFCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x762CA10", Offset = "0x762BE10", VA = "0x18762CA10")]
	private bool KIMPJCJOFGB(Guid JFGNPLFCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76274B0", Offset = "0x76268B0", VA = "0x1876274B0")]
	private void EDMHDNEPFFJ(Guid JFGNPLFCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x762A6B0", Offset = "0x7629AB0", VA = "0x18762A6B0")]
	private void ICBKHHJIKPI(DINILGKMLAO EFJBPHHNLAK, int OOBHKNAFJBA, Dictionary<DINILGKMLAO, int> NCJPLIGEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7630510", Offset = "0x762F910", VA = "0x187630510")]
	private int PGMHLCFOIAL(DINILGKMLAO HPIOPHHLCME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7628050", Offset = "0x7627450", VA = "0x187628050")]
	private void EKAFGEDCNAD(KeepsakeInstanceDTO KELGLBJLEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x762B880", Offset = "0x762AC80", VA = "0x18762B880")]
	private void JJPFMLMAFBH(KeepsakeInstanceDTO KELGLBJLEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7627C80", Offset = "0x7627080", VA = "0x187627C80")]
	private void EILNNCAEBDA(Guid JFGNPLFCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x762A460", Offset = "0x7629860", VA = "0x18762A460")]
	private void IEAOLCEOBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7627C60", Offset = "0x7627060", VA = "0x187627C60")]
	private void EELBMLNLKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7626F40", Offset = "0x7626340", VA = "0x187626F40")]
	private void DPNNGGMONLB(AFOKKDBKELL JMAPFIDMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x762A460", Offset = "0x7629860", VA = "0x18762A460")]
	private void HIMJGCANOCD(NINPCJANIKP NBAMGPFDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x762A460", Offset = "0x7629860", VA = "0x18762A460")]
	private void OIPLOFGCLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76299E0", Offset = "0x7628DE0", VA = "0x1876299E0")]
	private void GIILCAKPOPF(float HEDKILDIFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x762FDE0", Offset = "0x762F1E0", VA = "0x18762FDE0")]
	private void PEPICIHBMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x76265D0", Offset = "0x76259D0", VA = "0x1876265D0")]
	private bool DAKJNAIJDNC(Guid JFGNPLFCOBO, [Out] string IPKJMOHGHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7629630", Offset = "0x7628A30", VA = "0x187629630")]
	private bool GEGFOOGIHGM(Guid JFGNPLFCOBO, [Out] KeepsakeCategoryConfigDTO EFJBPHHNLAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76264F0", Offset = "0x76258F0", VA = "0x1876264F0")]
	private void DAJBCOLAKPD(string AOFEJGHEJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x762EF30", Offset = "0x762E330", VA = "0x18762EF30")]
	private bool NEBCEDJNDJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x762A790", Offset = "0x7629B90", VA = "0x18762A790")]
	private List<long> ICLJJKHLNBL(IEnumerable<KeepsakeRoomDTO> NCJBCGPAKMP, IReadOnlyList<KeepsakeRoomListDTO> FDOAIBBNACE, long GBKDJHCNOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x76314E0", Offset = "0x76308E0", VA = "0x1876314E0")]
	private bool PNKAICMLBBK(Guid JFGNPLFCOBO, [Out] string JPAKKPAOGDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x762BB40", Offset = "0x762AF40", VA = "0x18762BB40", Slot = "47")]
	public string JLBFOOJBHCM(EMIPMCBINMI ICHDAHOLMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x762EA30", Offset = "0x762DE30", VA = "0x18762EA30", Slot = "49")]
	public string MMOKACCDLFO(EMIPMCBINMI ICHDAHOLMLF, long LFNEDMLHPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x762E0C0", Offset = "0x762D4C0", VA = "0x18762E0C0", Slot = "48")]
	public string MHEJEDAMBKI(EMIPMCBINMI ICHDAHOLMLF, int KENDONOOADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7630620", Offset = "0x762FA20", VA = "0x187630620")]
	private void PLKEGAEILLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x762E330", Offset = "0x762D730", VA = "0x18762E330")]
	private void MLGHDPAFBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x762D740", Offset = "0x762CB40", VA = "0x18762D740")]
	private EMIPMCBINMI MAICFMLKBFB(EIFGCHNCOHI ICPCLLPLNHA)
	{
		return default(EMIPMCBINMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7630600", Offset = "0x762FA00", VA = "0x187630600")]
	private EMIPMCBINMI PJGLMDOEPNM(EIFGCHNCOHI ICPCLLPLNHA)
	{
		return default(EMIPMCBINMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x762CAC0", Offset = "0x762BEC0", VA = "0x18762CAC0")]
	internal static string KKCJELOPKPG(MDCBBMPDEDC GLGDOFEFILE, string KAAMPHNLJEJ, bool ALCIBAOIMGB, int CGNGMHBBOPF, int KBMJGAFCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7626FB0", Offset = "0x76263B0", VA = "0x187626FB0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x762EEB0", Offset = "0x762E2B0", VA = "0x18762EEB0")]
	private MLDDIEDIFAF NBNFPGIAMJJ(NOFCMGEHFOO PFDFFAPLFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x762CCA0", Offset = "0x762C0A0", VA = "0x18762CCA0")]
	private JBDMCPFFKFC KKNBOLOPPLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x762D390", Offset = "0x762C790", VA = "0x18762D390")]
	private Task LLLMAKAFPGE(DOFGKDAOBGJ BKIADHLGJLK, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x762B370", Offset = "0x762A770", VA = "0x18762B370")]
	[AsyncStateMachine(typeof(MLPBKJBJELO))]
	private Task JDBHJACBPGJ(DOFGKDAOBGJ BKIADHLGJLK, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7628220", Offset = "0x7627620", VA = "0x187628220")]
	private Task EMEICKGLDIK(DOFGKDAOBGJ BKIADHLGJLK, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x762AA50", Offset = "0x7629E50", VA = "0x18762AA50")]
	[AsyncStateMachine(typeof(HHILLJMLJEN))]
	private Task IDNBMNIAPCP(string LPIFIOEEOGF, TimeSpan BEIIJFOMEEB, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7631B40", Offset = "0x7630F40", VA = "0x187631B40")]
	[CompilerGenerated]
	private void POGAJAPLGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7625BE0", Offset = "0x7624FE0", VA = "0x187625BE0")]
	[CompilerGenerated]
	private void CJIGFJCEMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7625240", Offset = "0x7624640", VA = "0x187625240")]
	[CompilerGenerated]
	private bool ABCANHIINDF(KeepsakeInstanceDTO COMHOHNLIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x762DA90", Offset = "0x762CE90", VA = "0x18762DA90")]
	[CompilerGenerated]
	private HHPFDJMLPAL<Dictionary<DINILGKMLAO, int>> MDKFJDKPOIB(Dictionary<Guid, DINILGKMLAO> JOLBIKAGKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x762B480", Offset = "0x762A880", VA = "0x18762B480")]
	[CompilerGenerated]
	private HHPFDJMLPAL<Dictionary<DINILGKMLAO, int>> JFHOBBFEGHK(Dictionary<Guid, DINILGKMLAO> JOLBIKAGKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x762A0C0", Offset = "0x76294C0", VA = "0x18762A0C0")]
	[CompilerGenerated]
	private bool HACBODIEPJG(KeepsakeRoomListDTO COMHOHNLIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x762BC40", Offset = "0x762B040", VA = "0x18762BC40")]
	[CompilerGenerated]
	private bool JLMBPDMKNFB(KeepsakeInstanceDTO COMHOHNLIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7629800", Offset = "0x7628C00", VA = "0x187629800")]
	[CompilerGenerated]
	private void GGAEBFHOGLD(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DINILGKMLAO, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> EMHDIMFOJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7625F50", Offset = "0x7625350", VA = "0x187625F50")]
	[CompilerGenerated]
	private void COPKBGKHCNO(string JPAKKPAOGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x762E4C0", Offset = "0x762D8C0", VA = "0x18762E4C0")]
	[CompilerGenerated]
	private Task MLIMOFIHDFE(CancellationToken ALKBFHHPDMD)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, FDJAODJIBPM<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class AKGDMOEBDHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
				public AKGDMOEBDHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7625110", Offset = "0x7624510", VA = "0x187625110")]
				internal bool JNLJMKENFDK(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7625110", Offset = "0x7624510", VA = "0x187625110")]
				internal bool HJCCLALFFBA(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x76345B0", Offset = "0x76339B0", VA = "0x1876345B0")]
			public bool CFOPNIHIPEG(string EEFFHNHPOGC, [Out] KeepsakeTheme PPLDKNELGMB)
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7634530", Offset = "0x7633930", VA = "0x187634530")]
		[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
		internal static void GFLBPMFPPHA(LEPFMCICNAK EOMAFKDOFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAA00D0", Offset = "0xA9F4D0", VA = "0x180AA00D0")]
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
