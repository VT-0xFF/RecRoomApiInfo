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
		[Cpp2IlInjected.Address(RVA = "0x8301690", Offset = "0x8300A90", VA = "0x188301690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CLALMIHDJCK : IComparer<IJIHCOGNCDJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class IGMIMIBNCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IJIHCOGNCDJ x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IJIHCOGNCDJ y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IGMIMIBNCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE367A0", Offset = "0xE35BA0", VA = "0x180E367A0")]
		internal bool IHPHFKIOEIA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2185970", Offset = "0x2184D70", VA = "0x182185970")]
		internal bool CCBOGLLKENC(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE367A0", Offset = "0xE35BA0", VA = "0x180E367A0")]
		internal bool BFCOBENKDMD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2185970", Offset = "0x2184D70", VA = "0x182185970")]
		internal bool DGFMFGOKFIK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> LGOABFFGNHB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public CLALMIHDJCK(List<KeepsakeCategoryThemePair> LDKAIGMIFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82F0B90", Offset = "0x82EFF90", VA = "0x1882F0B90", Slot = "4")]
	public int Compare(IJIHCOGNCDJ FNBJHADJBNG, IJIHCOGNCDJ MODFPFNICHM)
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
		public IJIHCOGNCDJ KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EAFHNCFGKJO]
public class DJDMBDOBPGE : BKFAJJKENCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CNMENBDOIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public IJIHCOGNCDJ keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CNMENBDOIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82F1510", Offset = "0x82F0910", VA = "0x1882F1510")]
		internal FHMCAMOMJOP<Guid> NEGKNEHGGHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82F10D0", Offset = "0x82F04D0", VA = "0x1882F10D0")]
		internal void GABDEMJDAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82F1070", Offset = "0x82F0470", VA = "0x1882F1070")]
		internal void EOAFJEBJFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x82F1100", Offset = "0x82F0500", VA = "0x1882F1100")]
		internal void GOMENKKPHBC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x82F1040", Offset = "0x82F0440", VA = "0x1882F1040")]
		internal void CIMICBDJBIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JEKKKHAILCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DJDMBDOBPGE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JEKKKHAILCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8300180", Offset = "0x82FF580", VA = "0x188300180")]
		internal void EGDANPLCMCP(BNCNBJEIEJD response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8300530", Offset = "0x82FF930", VA = "0x188300530")]
		internal void IFILAKPPOOM(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NLAOPIMGGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NLAOPIMGGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8301020", Offset = "0x8300420", VA = "0x188301020")]
		internal bool JCCPHEOKIND(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MOMOAFEINGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public IJIHCOGNCDJ? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MOMOAFEINGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8300C90", Offset = "0x8300090", VA = "0x188300C90")]
		internal void LPLDCECNDPN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83000A0", Offset = "0x82FF4A0", VA = "0x1883000A0")]
		internal void KJMOHBKJDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8300D20", Offset = "0x8300120", VA = "0x188300D20")]
		internal FHMCAMOMJOP<IEnumerable<Guid>> NACEOOAJAEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DCC310", Offset = "0x7DCB710", VA = "0x187DCC310")]
		internal bool MMIEJONHIKF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CLHDEAMKPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MOMOAFEINGN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CLHDEAMKPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82F0E40", Offset = "0x82F0240", VA = "0x1882F0E40")]
		internal FHMCAMOMJOP<IEnumerable<Guid>> HCCCKLFKLII(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MBPEMCKCAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CLHDEAMKPPN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MBPEMCKCAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8300AE0", Offset = "0x82FFEE0", VA = "0x188300AE0")]
		internal bool IPBJEHPBEOF(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FDJNHEBJIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public MBPEMCKCAGP CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FDJNHEBJIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82FF750", Offset = "0x82FEB50", VA = "0x1882FF750")]
		internal bool NOHBJKJONDB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BPJGADPPPPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BPJGADPPPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x82F0A20", Offset = "0x82EFE20", VA = "0x1882F0A20")]
		internal FHMCAMOMJOP<IEnumerable<Guid>> LOHMILJECHF(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82F0A00", Offset = "0x82EFE00", VA = "0x1882F0A00")]
		internal bool DIKAMOBIGPO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HGJMHPKMAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DJDMBDOBPGE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HGJMHPKMAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82FFD20", Offset = "0x82FF120", VA = "0x1882FFD20")]
		internal void BBJBICNEILN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83000A0", Offset = "0x82FF4A0", VA = "0x1883000A0")]
		internal void ODFIJMLPMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x82FFDB0", Offset = "0x82FF1B0", VA = "0x1882FFDB0")]
		internal FHMCAMOMJOP<Dictionary<Guid, IJIHCOGNCDJ>> FMOLMBNLLCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DCC310", Offset = "0x7DCB710", VA = "0x187DCC310")]
		internal bool IHNAAACGNCN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class AFNCANJJNKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AFNCANJJNKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x82F01B0", Offset = "0x82EF5B0", VA = "0x1882F01B0")]
		internal FHMCAMOMJOP<Dictionary<Guid, IJIHCOGNCDJ>> ENFMKGJNEMP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OLDELGLPAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OLDELGLPAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8301040", Offset = "0x8300440", VA = "0x188301040")]
		internal bool BGAHCNDBCNG(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8301120", Offset = "0x8300520", VA = "0x188301120")]
		internal KeyValuePair<Guid, IJIHCOGNCDJ> KJMPEMCMCJD(Guid instanceId)
		{
			return default(KeyValuePair<Guid, IJIHCOGNCDJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GEKDKAFOFOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GEKDKAFOFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xFE3360", Offset = "0xFE2760", VA = "0x180FE3360")]
		internal bool IFJHEJHFKIJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MIFPPCLBBKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MIFPPCLBBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xFE3360", Offset = "0xFE2760", VA = "0x180FE3360")]
		internal bool LOHKFMNGDOB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PPNJJDDJKHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PPNJJDDJKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8301270", Offset = "0x8300670", VA = "0x188301270")]
		internal FHMCAMOMJOP<Dictionary<Guid, IJIHCOGNCDJ>> IPFPKHNNFKA(Dictionary<Guid, IJIHCOGNCDJ> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x82F0A00", Offset = "0x82EFE00", VA = "0x1882F0A00")]
		internal bool FPPCKCFKKJM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BALIAMNAGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BALIAMNAGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x82F0940", Offset = "0x82EFD40", VA = "0x1882F0940")]
		internal bool NKHIABEGLPN(KeyValuePair<Guid, IJIHCOGNCDJ> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LDHLLLPGFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, IJIHCOGNCDJ> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LDHLLLPGFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8300840", Offset = "0x82FFC40", VA = "0x188300840")]
		internal KeyValuePair<IJIHCOGNCDJ, int> EMGLFNDLNEB(IJIHCOGNCDJ category)
		{
			return default(KeyValuePair<IJIHCOGNCDJ, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EANHGJJOPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IJIHCOGNCDJ category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EANHGJJOPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF590F0", Offset = "0xF584F0", VA = "0x180F590F0")]
		internal bool GGJFMNBFOKA(IJIHCOGNCDJ instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LKDDBPBOGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, IJIHCOGNCDJ> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LKDDBPBOGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8300990", Offset = "0x82FFD90", VA = "0x188300990")]
		internal KeyValuePair<IJIHCOGNCDJ, int> LJBNIDIEADJ(IJIHCOGNCDJ category)
		{
			return default(KeyValuePair<IJIHCOGNCDJ, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KKMMFMBJHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IJIHCOGNCDJ category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KKMMFMBJHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF590F0", Offset = "0xF584F0", VA = "0x180F590F0")]
		internal bool KDLCOKMMPOB(IJIHCOGNCDJ instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GEGCJLHOBBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GEGCJLHOBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x82FFBD0", Offset = "0x82FEFD0", VA = "0x1882FFBD0")]
		internal bool PLEIKHMJHPK(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82FFB10", Offset = "0x82FEF10", VA = "0x1882FFB10")]
		internal bool LAKEGGAAOKO(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAF0", Offset = "0x82FEEF0", VA = "0x1882FFAF0")]
		internal bool HMEAFGKCDDB(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x82FFAF0", Offset = "0x82FEEF0", VA = "0x1882FFAF0")]
		internal bool LJMHNBJOCMD(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NIHOOLBDJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NIHOOLBDJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFB8DA0", Offset = "0xFB81A0", VA = "0x180FB8DA0")]
		internal bool NCOFMFJBNMG(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CMFFFBOIJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CMFFFBOIJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82F0F80", Offset = "0x82F0380", VA = "0x1882F0F80")]
		internal bool CJMPMNNHOIH(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x27D8E40", Offset = "0x27D8240", VA = "0x1827D8E40")]
		internal bool CGPOLNBOOHJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AOIBAFHBLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AOIBAFHBLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x82F08E0", Offset = "0x82EFCE0", VA = "0x1882F08E0")]
		internal bool AJHEEDMHBPI(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JKHEPPMGBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JKHEPPMGBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFB8DA0", Offset = "0xFB81A0", VA = "0x180FB8DA0")]
		internal bool LIKGILIAELC(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GILAPMENIDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GILAPMENIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x82FFCC0", Offset = "0x82FF0C0", VA = "0x1882FFCC0")]
		internal bool LKHKINNMDGE(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ALNOBMOIODE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public IJIHCOGNCDJ keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ALNOBMOIODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x23C96C0", Offset = "0x23C8AC0", VA = "0x1823C96C0")]
		internal bool PDGPHEDCODD(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KNPCJENEAKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KNPCJENEAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8300590", Offset = "0x82FF990", VA = "0x188300590")]
		internal bool AFGCDKPPFLN(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BBCBDNPOHLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IJIHCOGNCDJ keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BBCBDNPOHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x82F09C0", Offset = "0x82EFDC0", VA = "0x1882F09C0")]
		internal bool ENJDEOGJLDH(KeyValuePair<Guid, IJIHCOGNCDJ> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ICIMPPNBANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IJIHCOGNCDJ newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ICIMPPNBANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x23C96C0", Offset = "0x23C8AC0", VA = "0x1823C96C0")]
		internal bool AFJNHAOIJDA(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MDAPIGKBAKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MDAPIGKBAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8300C10", Offset = "0x8300010", VA = "0x188300C10")]
		internal bool FMACNKIIFEC(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DEJDGEBLLOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DEJDGEBLLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x82F1660", Offset = "0x82F0A60", VA = "0x1882F1660")]
		internal bool HCJFKKECDFL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IPJPICJDCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DEJDGEBLLOD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IPJPICJDCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8300100", Offset = "0x82FF500", VA = "0x188300100")]
		internal bool KMDJHDIOCME(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct AMFLBAAAOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public PJKBEIHEIIE args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x82F0360", Offset = "0x82EF760", VA = "0x1882F0360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x82F0880", Offset = "0x82EFC80", VA = "0x1882F0880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct FPAOEMJHHJH : IAsyncStateMachine
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
		public DJDMBDOBPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x82FF800", Offset = "0x82FEC00", VA = "0x1882FF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x82FFA90", Offset = "0x82FEE90", VA = "0x1882FFA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime PBCJINEOKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LIOPEKKCMPE BEEJIMKKBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DANPDPMCDKL OHLHAPLENGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IAJPLJPJADG EKIGIOIGAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EGEKLDMIJPP AOFILBHDBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly BOKALKOMIFP IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly AKJEBEPKLNK OLKAKEHAOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GCFCNBPHIEF EIIIIMAMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ANLOIIDDCAA PJHGBENBHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PBLHAOEIOPI CMJGOPHDNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly IMHNEFIICNI DGKDEBNHPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PJOPJNFKKAJ OLENCDNPPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GGPAGPBMOHM IPKGHAJGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JGNFJIADEKL JIEDDFONOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly KEPKCCNNHIG NMHGBBCEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ICJKHMOHJIB<KeepsakesConfig.KeepsakesOptions> LFFPIIDBFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LFMDEIGOMOD HPKDJJIICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> OANNFECODDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> GGAHOMMANOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> HMPMDMNIGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<IJIHCOGNCDJ, int> GEONCIBFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> GMDAAOEIAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable FKHCHBCIBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task DPGFAKODHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private FHMCAMOMJOP<Guid> CMMCACAIONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? KHLIGDBDDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO PBCDNGIHLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FHMCAMOMJOP<KeepsakeProgressionEventInstancesDTO> NBNBFBHIDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<IJIHCOGNCDJ, KeepsakeCategoryConfigDTO> PPMGGNKPLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO BGGBADEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> LDOEGHMJDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> LCCLJAJNMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> CCGIBBCPOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> OKKOFPGEIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> LACJBGFPILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> NCMBAEDKCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> BFGMDPFGGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> GFJMKDIFPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EBGKPBIECDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> AELGAAFKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> BNJCMDAFAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> KCCNBINIENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime IHNHEKNNHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable DCBFEPLICOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, IJIHCOGNCDJ> DKOCHGMJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<IJIHCOGNCDJ, int> CLDIIKFFFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> LDKAIGMIFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private CLALMIHDJCK NNHPMBAPHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NAKIFMGCCOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IGLKFHPPEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FCHFKEEAILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82FC300", Offset = "0x82FB700", VA = "0x1882FC300", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BADOGEBEIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82F9FE0", Offset = "0x82F93E0", VA = "0x1882F9FE0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long BBFLIKDNBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82F2750", Offset = "0x82F1B50", VA = "0x1882F2750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OKOENOJODJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82F91C0", Offset = "0x82F85C0", VA = "0x1882F91C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GCPPNBFMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82F59E0", Offset = "0x82F4DE0", VA = "0x1882F59E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> AJBLFFMNEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBCF390", Offset = "0xBCE790", VA = "0x180BCF390", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> JHCAJKCDMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBD0B90", Offset = "0xBCFF90", VA = "0x180BD0B90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FEDNBGHKNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBE0820", Offset = "0xBDFC20", VA = "0x180BE0820", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> KPDIHGMGAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBC8C10", Offset = "0xBC8010", VA = "0x180BC8C10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool GLPEKGOONJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB2F330", Offset = "0xB2E730", VA = "0x180B2F330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> MHENJHFFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82F1750", Offset = "0x82F0B50", VA = "0x1882F1750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82F67D0", Offset = "0x82F5BD0", VA = "0x1882F67D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NFFCMPHLILM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82F36D0", Offset = "0x82F2AD0", VA = "0x1882F36D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82F89B0", Offset = "0x82F7DB0", VA = "0x1882F89B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DABKPKFILDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82FB110", Offset = "0x82FA510", VA = "0x1882FB110", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82F2BF0", Offset = "0x82F1FF0", VA = "0x1882F2BF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82FE190", Offset = "0x82FD590", VA = "0x1882FE190")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DJDMBDOBPGE([PKIHAALFADL(null)][NotNull] LIOPEKKCMPE BEEJIMKKBFF, [NotNull][PKIHAALFADL(null)] ECFCPGIOFGO KPJGMLONPEC, [NotNull][PKIHAALFADL(null)] DANPDPMCDKL OHLHAPLENGA, [NotNull][PKIHAALFADL(null)] IAJPLJPJADG EKIGIOIGAMD, [PKIHAALFADL(null)][NotNull] EGEKLDMIJPP AOFILBHDBJD, [PKIHAALFADL(null)][NotNull] BOKALKOMIFP IDEPICHODDC, [PKIHAALFADL(null)][NotNull] AKJEBEPKLNK OLKAKEHAOAO, [NotNull][PKIHAALFADL(null)] GCFCNBPHIEF EIIIIMAMBPH, [NotNull][PKIHAALFADL(null)] CFAOIDGAGLN KMFAHFKEGPF, [NotNull][PKIHAALFADL(null)] DFCJBOBNCKJ ILEIBOELBAE, [NotNull][PKIHAALFADL(null)] ANLOIIDDCAA PJHGBENBHHB, [NotNull][PKIHAALFADL(null)] PBLHAOEIOPI CMJGOPHDNAP, [NotNull][PKIHAALFADL(null)] IMHNEFIICNI DGKDEBNHPFP, [NotNull][PKIHAALFADL(null)] PJOPJNFKKAJ OLENCDNPPNC, [PKIHAALFADL(null)][NotNull] GGPAGPBMOHM IPKGHAJGBDL, [PKIHAALFADL(null)][NotNull] JGNFJIADEKL JIEDDFONOAP, [NotNull][PKIHAALFADL(null)] KEPKCCNNHIG NMHGBBCEPEC, [PKIHAALFADL(null)][NotNull] ICJKHMOHJIB<KeepsakesConfig.KeepsakesOptions> LFFPIIDBFOJ, [NotNull][PKIHAALFADL(null)] LFMDEIGOMOD HPKDJJIICKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82FBB40", Offset = "0x82FAF40", VA = "0x1882FBB40", Slot = "15")]
	public bool NPMECBFABKD(List<string> DKPLHHKMCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82F4340", Offset = "0x82F3740", VA = "0x1882F4340", Slot = "16")]
	public FHMCAMOMJOP<Guid> EAMNJBAIEDE(IJIHCOGNCDJ GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82F1800", Offset = "0x82F0C00", VA = "0x1882F1800", Slot = "17")]
	public IHCAHILICGC ADLLDHIGOLM(Guid DBIALNJHNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82FB7C0", Offset = "0x82FABC0", VA = "0x1882FB7C0", Slot = "18")]
	public IHCAHILICGC NPJDOPCDJKM(Guid DBIALNJHNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82F9250", Offset = "0x82F8650", VA = "0x1882F9250", Slot = "19")]
	public bool KHPPNPPOFNC(Guid DBIALNJHNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82F3CE0", Offset = "0x82F30E0", VA = "0x1882F3CE0", Slot = "20")]
	public bool DNMONPDIEKM(Guid DBIALNJHNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82F6880", Offset = "0x82F5C80", VA = "0x1882F6880")]
	public KeepsakeTheme HJDAHMJDOGI(Guid DBIALNJHNFJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82F9D60", Offset = "0x82F9160", VA = "0x1882F9D60")]
	public bool LJFIPFJBAGH(IJIHCOGNCDJ GAGNGHPMDNA, [Out] KeepsakeTheme BFEPBBGLJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82FA0A0", Offset = "0x82F94A0", VA = "0x1882FA0A0")]
	public List<KeepsakeTheme> MDKDCKJPKMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82F8D20", Offset = "0x82F8120", VA = "0x1882F8D20")]
	public int KAGLINDCMCE(IJIHCOGNCDJ GAGNGHPMDNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82FBF30", Offset = "0x82FB330", VA = "0x1882FBF30")]
	public IJIHCOGNCDJ OEJKCGFIGGC(Guid DBIALNJHNFJ)
	{
		return default(IJIHCOGNCDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x82FAB10", Offset = "0x82F9F10", VA = "0x1882FAB10", Slot = "34")]
	public List<IJIHCOGNCDJ> NBIIDPKDLJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82F1C50", Offset = "0x82F1050", VA = "0x1882F1C50", Slot = "35")]
	public IComparer<IJIHCOGNCDJ> AHMDODNAEIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82F5180", Offset = "0x82F4580", VA = "0x1882F5180", Slot = "32")]
	public string ELGOFLCENJJ(IJIHCOGNCDJ GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82F5CB0", Offset = "0x82F50B0", VA = "0x1882F5CB0", Slot = "33")]
	public string GMODPPMBCAC(IJIHCOGNCDJ GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82F6DD0", Offset = "0x82F61D0", VA = "0x1882F6DD0", Slot = "21")]
	public bool IDBIPCGHDOP(Guid DBIALNJHNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82F5300", Offset = "0x82F4700", VA = "0x1882F5300", Slot = "22")]
	public void EMONCIOEMMK(Guid DBIALNJHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82F9660", Offset = "0x82F8A60", VA = "0x1882F9660", Slot = "23")]
	public void LEFKBLKLAJE(IJIHCOGNCDJ GAGNGHPMDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82F53D0", Offset = "0x82F47D0", VA = "0x1882F53D0", Slot = "24")]
	public void FAJDFGEECMM(Guid DBIALNJHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82F3790", Offset = "0x82F2B90", VA = "0x1882F3790", Slot = "25")]
	public int DIJKFACIIKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82F23A0", Offset = "0x82F17A0", VA = "0x1882F23A0", Slot = "31")]
	public FHMCAMOMJOP<IEnumerable<Guid>> CHDIJJNBMDJ(long DCONEHIDLCB, long JAMKCCNJKDH, IJIHCOGNCDJ? GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82FAC60", Offset = "0x82FA060", VA = "0x1882FAC60", Slot = "30")]
	public FHMCAMOMJOP<IEnumerable<Guid>> NBMIGDOAOPJ(long DCONEHIDLCB, long JAMKCCNJKDH, IJIHCOGNCDJ? GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82F4A30", Offset = "0x82F3E30", VA = "0x1882F4A30", Slot = "54")]
	public FHMCAMOMJOP<Dictionary<Guid, IJIHCOGNCDJ>> EGPBKKAKBPK(long DCONEHIDLCB, long JAMKCCNJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82F7EF0", Offset = "0x82F72F0", VA = "0x1882F7EF0", Slot = "55")]
	public FHMCAMOMJOP<Dictionary<Guid, IJIHCOGNCDJ>> INCCDBKNOKD(long DCONEHIDLCB, long JAMKCCNJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82F4DE0", Offset = "0x82F41E0", VA = "0x1882F4DE0", Slot = "26")]
	public FHMCAMOMJOP<int> EHGONLIGNEM(long DCONEHIDLCB, long JAMKCCNJKDH, IJIHCOGNCDJ? GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82FBDD0", Offset = "0x82FB1D0", VA = "0x1882FBDD0", Slot = "27")]
	public FHMCAMOMJOP<int> OEBJMOENLBE(long DCONEHIDLCB, long JAMKCCNJKDH, IJIHCOGNCDJ? GAGNGHPMDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82FA450", Offset = "0x82F9850", VA = "0x1882FA450", Slot = "28")]
	public FHMCAMOMJOP<Dictionary<IJIHCOGNCDJ, int>> MEFNNGJFNBK(long DCONEHIDLCB, long JAMKCCNJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82F5BF0", Offset = "0x82F4FF0", VA = "0x1882F5BF0", Slot = "29")]
	public FHMCAMOMJOP<Dictionary<IJIHCOGNCDJ, int>> GFEMPPLFCFD(long DCONEHIDLCB, long JAMKCCNJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82FE130", Offset = "0x82FD530", VA = "0x1882FE130", Slot = "37")]
	public bool PLDLCKINJAN(long DCONEHIDLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82F2280", Offset = "0x82F1680", VA = "0x1882F2280", Slot = "56")]
	public bool CGOLLCLNCFM(long DCONEHIDLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82F4170", Offset = "0x82F3570", VA = "0x1882F4170", Slot = "38")]
	public bool EAFKMBDGOKG(long DCONEHIDLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82F96D0", Offset = "0x82F8AD0", VA = "0x1882F96D0", Slot = "57")]
	public bool LHPEIHKHEPA(long DCONEHIDLCB, [Out] HNFJJCAKPAK GHPDABNIGIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82FB680", Offset = "0x82FAA80", VA = "0x1882FB680", Slot = "39")]
	public bool NMOLDFDLNKG(long KBKINMPLJNM, [Out] DateTime CIHPELGAJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82F7250", Offset = "0x82F6650", VA = "0x1882F7250", Slot = "40")]
	public long IEKFOPMBMIP(long KBKINMPLJNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82FADF0", Offset = "0x82FA1F0", VA = "0x1882FADF0", Slot = "41")]
	public long NDKCGFIFGOM(long DCONEHIDLCB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82F7070", Offset = "0x82F6470", VA = "0x1882F7070", Slot = "42")]
	public int IEJAOGCJMNI(long KBKINMPLJNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82FA840", Offset = "0x82F9C40", VA = "0x1882FA840", Slot = "43")]
	public bool MLMCCFFJHBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x82F56F0", Offset = "0x82F4AF0", VA = "0x1882F56F0", Slot = "44")]
	public bool FGFBNDABHIB(long KBKINMPLJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82FC090", Offset = "0x82FB490", VA = "0x1882FC090", Slot = "45")]
	public IReadOnlyList<long> OFLJIDFBDHF(long KBKINMPLJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x82F2F70", Offset = "0x82F2370", VA = "0x1882F2F70", Slot = "46")]
	public int DAKAGKJOOMI(long KBKINMPLJNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82F8EA0", Offset = "0x82F82A0", VA = "0x1882F8EA0", Slot = "50")]
	public long KCKJOMFKJAH(long IGIBGOHEIOK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82FD9A0", Offset = "0x82FCDA0", VA = "0x1882FD9A0", Slot = "51")]
	public IJIHCOGNCDJ PKDJBKHBANC()
	{
		return default(IJIHCOGNCDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82F4210", Offset = "0x82F3610", VA = "0x1882F4210")]
	private bool EAJFDODMCBG(Guid DBIALNJHNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82F84E0", Offset = "0x82F78E0", VA = "0x1882F84E0")]
	private void JJGGKGOHDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82F2C90", Offset = "0x82F2090", VA = "0x1882F2C90")]
	private IJIHCOGNCDJ CLIANHFGGIA()
	{
		return default(IJIHCOGNCDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82F5F40", Offset = "0x82F5340", VA = "0x1882F5F40")]
	private void HGNOOCPAHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82FD7E0", Offset = "0x82FCBE0", VA = "0x1882FD7E0")]
	private int OOCBKJOEIGO(KeepsakeRoomListDTO PBHNEILCCMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82F5080", Offset = "0x82F4480", VA = "0x1882F5080")]
	private int EJNDICOPGEF(DateTime PCJJKAACEMJ, DateTime MCBGEGOKNKO, TimeSpan LCENKKOALHB, int FICMGDHFEHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82FD240", Offset = "0x82FC640", VA = "0x1882FD240")]
	private void OLCLFLJALLJ(IEnumerable<KeepsakeInstanceDTO> OANNFECODDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82F6580", Offset = "0x82F5980", VA = "0x1882F6580")]
	private void HICGCPMAICN(IEnumerable<KeepsakeCollectionRecordDTO> GFKDOFBLFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82F5370", Offset = "0x82F4770", VA = "0x1882F5370")]
	private void ENEOAIBJAMO(IEnumerable<long> LAMJEGBOFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB44890", Offset = "0xB43C90", VA = "0x180B44890")]
	private void FFFJNBMNFEA(KeepsakeGlobalConfigDTO BGGBADEOKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82F2980", Offset = "0x82F1D80", VA = "0x1882F2980")]
	private bool CJCHOKGPEAF(IJIHCOGNCDJ GAGNGHPMDNA, [Out] Guid NLICMDIIGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82F9F40", Offset = "0x82F9340", VA = "0x1882F9F40")]
	private bool LLLEADNHDPI([Out] Guid NLICMDIIGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82F9160", Offset = "0x82F8560", VA = "0x1882F9160")]
	private bool KDLAMJJDGDG(Guid DBIALNJHNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82F2820", Offset = "0x82F1C20", VA = "0x1882F2820")]
	private IEnumerable<Guid> CIPLCPNFHJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82F22E0", Offset = "0x82F16E0", VA = "0x1882F22E0")]
	private IEnumerable<KeepsakeInstanceDTO> CHCAOHMFGBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82F82A0", Offset = "0x82F76A0", VA = "0x1882F82A0")]
	private void JDNGFBPADJO(Guid DBIALNJHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82F8C10", Offset = "0x82F8010", VA = "0x1882F8C10")]
	private bool JKMJIHOFHPM(Guid DBIALNJHNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82FD4D0", Offset = "0x82FC8D0", VA = "0x1882FD4D0")]
	private void OLNMIFMNBIN(Guid DBIALNJHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82F4950", Offset = "0x82F3D50", VA = "0x1882F4950")]
	private void ECDPHKCDIML(IJIHCOGNCDJ AEKNMLHGMDI, int FJDKBIOMMOM, Dictionary<IJIHCOGNCDJ, int> OONMFEJBLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82F81B0", Offset = "0x82F75B0", VA = "0x1882F81B0")]
	private int JBJNOIPLLCB(IJIHCOGNCDJ GAGNGHPMDNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82F1A80", Offset = "0x82F0E80", VA = "0x1882F1A80")]
	private void AEOBEJJGLPG(KeepsakeInstanceDTO MDBNAHAGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82FAF00", Offset = "0x82FA300", VA = "0x1882FAF00")]
	private void NDNIJPJNAFO(KeepsakeInstanceDTO MDBNAHAGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82FB2B0", Offset = "0x82FA6B0", VA = "0x1882FB2B0")]
	private void NMFIKDLIHDL(Guid DBIALNJHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82F3BD0", Offset = "0x82F2FD0", VA = "0x1882F3BD0")]
	private void NNLFAFGFIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82FD980", Offset = "0x82FCD80", VA = "0x1882FD980")]
	private void PJEPFOHJMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x82F69C0", Offset = "0x82F5DC0", VA = "0x1882F69C0")]
	private void HKKEMLJBAEA(NBKAILCGOBA KKPBBNLOJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82F3BD0", Offset = "0x82F2FD0", VA = "0x1882F3BD0")]
	private void DJLABEAFFBJ(PGONCLBKNNI DEJGDIIDCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82F3BD0", Offset = "0x82F2FD0", VA = "0x1882F3BD0")]
	private void LJMHLFAMCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82F6A30", Offset = "0x82F5E30", VA = "0x1882F6A30")]
	private void HOPHHNALLHE(float EMAMJICFHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82F7950", Offset = "0x82F6D50", VA = "0x1882F7950")]
	private void IIJNOCHCCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82F59F0", Offset = "0x82F4DF0", VA = "0x1882F59F0")]
	private bool GEKLPCMFJAD(Guid DBIALNJHNFJ, [Out] string GKCNFMOMMKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82F9490", Offset = "0x82F8890", VA = "0x1882F9490")]
	private bool KOGICFGFCIM(Guid DBIALNJHNFJ, [Out] KeepsakeCategoryConfigDTO AEKNMLHGMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82F3C00", Offset = "0x82F3000", VA = "0x1882F3C00")]
	private void DMNDPCMAIJE(string CAIIFLDFGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82F5E30", Offset = "0x82F5230", VA = "0x1882F5E30")]
	private bool HDIMDMHMDOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82F9A80", Offset = "0x82F8E80", VA = "0x1882F9A80")]
	private List<long> LJEKKOMHIAF(IEnumerable<KeepsakeRoomDTO> FNIOEKOBAGK, IReadOnlyList<KeepsakeRoomListDTO> EIFNPHOHCNI, long KBKINMPLJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x82F3020", Offset = "0x82F2420", VA = "0x1882F3020")]
	private bool DEACIHPAJND(Guid DBIALNJHNFJ, [Out] string FKPCAPOIAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82F2220", Offset = "0x82F1620", VA = "0x1882F2220", Slot = "47")]
	public string AOMBLEGJIFO(KPKHJDEEIFF FLFNOBAMBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82FDD10", Offset = "0x82FD110", VA = "0x1882FDD10", Slot = "49")]
	public string PKOGFGHBIEH(KPKHJDEEIFF FLFNOBAMBOH, long DCONEHIDLCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82F5610", Offset = "0x82F4A10", VA = "0x1882F5610", Slot = "48")]
	public string FEONHPCFDIC(KPKHJDEEIFF FLFNOBAMBOH, int MOBEJADKMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x82FC350", Offset = "0x82FB750", VA = "0x1882FC350")]
	private void OHFPOICAMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82F3540", Offset = "0x82F2940", VA = "0x1882F3540")]
	private void DHDMPOOKHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x82F3770", Offset = "0x82F2B70", VA = "0x1882F3770")]
	private KPKHJDEEIFF DIAIOPKHGLG(CFEADMJDODF GLDCJNFPFBO)
	{
		return default(KPKHJDEEIFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82F8330", Offset = "0x82F7730", VA = "0x1882F8330")]
	private KPKHJDEEIFF JHLKOFECIKH(CFEADMJDODF GLDCJNFPFBO)
	{
		return default(KPKHJDEEIFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82FA660", Offset = "0x82F9A60", VA = "0x1882FA660")]
	internal static string MKPHIPNKBNI(BNCNBJEIEJD HGHNDNAANCF, string BNELMAIPDKO, bool KKLGJPCMKEP, int ICHOOJDNKEF, int OLLELGFDFPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82F3D10", Offset = "0x82F3110", VA = "0x1882F3D10", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82FAA90", Offset = "0x82F9E90", VA = "0x1882FAA90")]
	private LALFMHKAHCO NBHLEGDCBMK(NELIJLIGAOD MAJOHFIPFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82F7790", Offset = "0x82F6B90", VA = "0x1882F7790")]
	private HGKAPEFBFIF IIFHAEHMEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82F1D10", Offset = "0x82F1110", VA = "0x1882F1D10")]
	private Task AIPENEGPNFG(PJKBEIHEIIE PHAOHJHLKGO, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82F5880", Offset = "0x82F4C80", VA = "0x1882F5880")]
	[AsyncStateMachine(typeof(AMFLBAAAOHA))]
	private Task FOBAIHMEOIB(PJKBEIHEIIE PHAOHJHLKGO, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82F93B0", Offset = "0x82F87B0", VA = "0x1882F93B0")]
	private Task KKEOFEFHKLL(PJKBEIHEIIE PHAOHJHLKGO, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82F20F0", Offset = "0x82F14F0", VA = "0x1882F20F0")]
	[AsyncStateMachine(typeof(FPAOEMJHHJH))]
	private Task ANBNBKONCIM(string AFDNIPHJHMO, TimeSpan GACAILCFNJI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82F20D0", Offset = "0x82F14D0", VA = "0x1882F20D0")]
	[CompilerGenerated]
	private void AMDHLHGMNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82F5990", Offset = "0x82F4D90", VA = "0x1882F5990")]
	[CompilerGenerated]
	private void GBCBPKFBAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82FB1B0", Offset = "0x82FA5B0", VA = "0x1882FB1B0")]
	[CompilerGenerated]
	private bool NKKCIKKHNMI(KeepsakeInstanceDTO FNBJHADJBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82FD670", Offset = "0x82FCA70", VA = "0x1882FD670")]
	[CompilerGenerated]
	private FHMCAMOMJOP<Dictionary<IJIHCOGNCDJ, int>> ONMKAMFOMHA(Dictionary<Guid, IJIHCOGNCDJ> BHCAMJJBLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82FA920", Offset = "0x82F9D20", VA = "0x1882FA920")]
	[CompilerGenerated]
	private FHMCAMOMJOP<Dictionary<IJIHCOGNCDJ, int>> MOADAFBMOFB(Dictionary<Guid, IJIHCOGNCDJ> BHCAMJJBLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82F96B0", Offset = "0x82F8AB0", VA = "0x1882F96B0")]
	[CompilerGenerated]
	private bool LGCBOMEKKHN(KeepsakeRoomListDTO FNBJHADJBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82F8080", Offset = "0x82F7480", VA = "0x1882F8080")]
	[CompilerGenerated]
	private bool IOIEJJEBNNM(KeepsakeInstanceDTO FNBJHADJBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82F8350", Offset = "0x82F7750", VA = "0x1882F8350")]
	[CompilerGenerated]
	private void JIAIBCMDPCN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<IJIHCOGNCDJ, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> LJLNHEOADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82F8CC0", Offset = "0x82F80C0", VA = "0x1882F8CC0")]
	[CompilerGenerated]
	private void JPBMOLDJCOM(string FKPCAPOIAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82F8A50", Offset = "0x82F7E50", VA = "0x1882F8A50")]
	[CompilerGenerated]
	private Task JKEILFNEHND(CancellationToken JOEJJLACDJL)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, ICJKHMOHJIB<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class HOOKECEDCDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				public HOOKECEDCDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x83000D0", Offset = "0x82FF4D0", VA = "0x1883000D0")]
				internal bool EFBPKGEEJKH(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x83000D0", Offset = "0x82FF4D0", VA = "0x1883000D0")]
				internal bool CEKFKOHIBAH(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8300670", Offset = "0x82FFA70", VA = "0x188300670")]
			public bool KKELGAGEPJA(string NJPHBMBCPHL, [Out] KeepsakeTheme BFEPBBGLJPA)
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83005F0", Offset = "0x82FF9F0", VA = "0x1883005F0")]
		[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
		internal static void IBCLJHGLFJL(JFAGCPCLAAF MNCIANLLPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
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
