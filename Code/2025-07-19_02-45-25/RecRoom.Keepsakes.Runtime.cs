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
		[Cpp2IlInjected.Address(RVA = "0x81C6860", Offset = "0x81C5860", VA = "0x1881C6860", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BIIABGHDEFB : IComparer<GEAEHEAKOFP>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class AEANGEKAMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GEAEHEAKOFP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GEAEHEAKOFP y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public AEANGEKAMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE266D0", Offset = "0xE256D0", VA = "0x180E266D0")]
		internal bool CLKMNEGKHDJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2143850", Offset = "0x2142850", VA = "0x182143850")]
		internal bool DMPKHIJPAMF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE266D0", Offset = "0xE256D0", VA = "0x180E266D0")]
		internal bool GNFCIOPHEHH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2143850", Offset = "0x2142850", VA = "0x182143850")]
		internal bool LLFONKJFBJK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> GILAGELMLEE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public BIIABGHDEFB(List<KeepsakeCategoryThemePair> HEGKJDMCNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81B5500", Offset = "0x81B4500", VA = "0x1881B5500", Slot = "4")]
	public int Compare(GEAEHEAKOFP OEFDFBLCHHF, GEAEHEAKOFP GDBEEAKMPMB)
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
		public GEAEHEAKOFP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NMAHPGPJLGN]
public class GLGEEEFLKAK : EJHNPOJJKLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EDOKHDJAGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GEAEHEAKOFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EDOKHDJAGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81B5CC0", Offset = "0x81B4CC0", VA = "0x1881B5CC0")]
		internal KPIPLFECKNC<Guid> DHLGBGCOBBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81B6230", Offset = "0x81B5230", VA = "0x1881B6230")]
		internal void PFCJBMODPDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81B5C60", Offset = "0x81B4C60", VA = "0x1881B5C60")]
		internal void CMOLFPGFINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81B5E20", Offset = "0x81B4E20", VA = "0x1881B5E20")]
		internal void MMBACOPLPGN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81B6260", Offset = "0x81B5260", VA = "0x1881B6260")]
		internal void PIJBOEMGPIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OLDBOKHNLED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GLGEEEFLKAK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OLDBOKHNLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81C5D60", Offset = "0x81C4D60", VA = "0x1881C5D60")]
		internal void CBLGELFJHKA(PBPJGPNKAHF response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81C6110", Offset = "0x81C5110", VA = "0x1881C6110")]
		internal void HOLJOJLFKEP(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HMLHDDEGLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HMLHDDEGLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81C46E0", Offset = "0x81C36E0", VA = "0x1881C46E0")]
		internal bool OGLJMJPIGII(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KPBPMIGBHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public GEAEHEAKOFP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KPBPMIGBHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81C5360", Offset = "0x81C4360", VA = "0x1881C5360")]
		internal void NANFOLFDAFJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81C5030", Offset = "0x81C4030", VA = "0x1881C5030")]
		internal void HCLOPPJIPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81C5060", Offset = "0x81C4060", VA = "0x1881C5060")]
		internal KPIPLFECKNC<IEnumerable<Guid>> ILHLFNFKHIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BC50", Offset = "0x7C9AC50", VA = "0x187C9BC50")]
		internal bool BGPPMOBENEH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DBNJGFOLHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KPBPMIGBHNF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DBNJGFOLHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x81B59D0", Offset = "0x81B49D0", VA = "0x1881B59D0")]
		internal KPIPLFECKNC<IEnumerable<Guid>> EKLKFPLBFFK(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JDFKDONKJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public DBNJGFOLHOA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public JDFKDONKJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x81C4CD0", Offset = "0x81C3CD0", VA = "0x1881C4CD0")]
		internal bool LJCCMJMPGNE(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BMKNHKJLOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JDFKDONKJDA CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BMKNHKJLOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x81B57B0", Offset = "0x81B47B0", VA = "0x1881B57B0")]
		internal bool EKHKNKIJGFL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BHFIKGMEBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BHFIKGMEBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81B5370", Offset = "0x81B4370", VA = "0x1881B5370")]
		internal KPIPLFECKNC<IEnumerable<Guid>> KKCHDJGEAJI(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x81B54E0", Offset = "0x81B44E0", VA = "0x1881B54E0")]
		internal bool MCAFJBPGOON(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NEPJMAJNIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GLGEEEFLKAK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NEPJMAJNIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81C5960", Offset = "0x81C4960", VA = "0x1881C5960")]
		internal void AACICLDILLJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81C5030", Offset = "0x81C4030", VA = "0x1881C5030")]
		internal void MABBPFIAAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81C59F0", Offset = "0x81C49F0", VA = "0x1881C59F0")]
		internal KPIPLFECKNC<Dictionary<Guid, GEAEHEAKOFP>> FHJEEFKEGHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9BC50", Offset = "0x7C9AC50", VA = "0x187C9BC50")]
		internal bool ABINKGOGDIJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PODAJEHMPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PODAJEHMPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x81C6490", Offset = "0x81C5490", VA = "0x1881C6490")]
		internal KPIPLFECKNC<Dictionary<Guid, GEAEHEAKOFP>> JKKBFANPDMG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KHGFEPFKNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KHGFEPFKNEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x81C4E00", Offset = "0x81C3E00", VA = "0x1881C4E00")]
		internal bool JGEPKFCMADL(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81C4EE0", Offset = "0x81C3EE0", VA = "0x1881C4EE0")]
		internal KeyValuePair<Guid, GEAEHEAKOFP> NLKICCLAMPH(Guid instanceId)
		{
			return default(KeyValuePair<Guid, GEAEHEAKOFP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KJKCLKEPFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KJKCLKEPFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x27F1750", Offset = "0x27F0750", VA = "0x1827F1750")]
		internal bool DIHOILBDNGO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LLCOHAHFOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LLCOHAHFOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x27F1750", Offset = "0x27F0750", VA = "0x1827F1750")]
		internal bool EBBBPNHKGJP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LBMKMLNHHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LBMKMLNHHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x81C5640", Offset = "0x81C4640", VA = "0x1881C5640")]
		internal KPIPLFECKNC<Dictionary<Guid, GEAEHEAKOFP>> JCELAEMADKI(Dictionary<Guid, GEAEHEAKOFP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x81B54E0", Offset = "0x81B44E0", VA = "0x1881B54E0")]
		internal bool EGIFGHPDCAA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CAGOHLIHLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CAGOHLIHLMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x81B5860", Offset = "0x81B4860", VA = "0x1881B5860")]
		internal bool MBFJPGIBNKD(KeyValuePair<Guid, GEAEHEAKOFP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PNJHCHKJKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, GEAEHEAKOFP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PNJHCHKJKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x81C6340", Offset = "0x81C5340", VA = "0x1881C6340")]
		internal KeyValuePair<GEAEHEAKOFP, int> ENKJOBOMMIO(GEAEHEAKOFP category)
		{
			return default(KeyValuePair<GEAEHEAKOFP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HPEOIGHCIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GEAEHEAKOFP category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HPEOIGHCIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF3C530", Offset = "0xF3B530", VA = "0x180F3C530")]
		internal bool FFLKDPBKOGF(GEAEHEAKOFP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DMIPDIIPMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, GEAEHEAKOFP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DMIPDIIPMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x81B5B10", Offset = "0x81B4B10", VA = "0x1881B5B10")]
		internal KeyValuePair<GEAEHEAKOFP, int> GDCLNNAHHBL(GEAEHEAKOFP category)
		{
			return default(KeyValuePair<GEAEHEAKOFP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MDOMBJMIJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GEAEHEAKOFP category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MDOMBJMIJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF3C530", Offset = "0xF3B530", VA = "0x180F3C530")]
		internal bool MEEDEPFBENL(GEAEHEAKOFP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PJHMNCFKCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PJHMNCFKCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x81C6190", Offset = "0x81C5190", VA = "0x1881C6190")]
		internal bool KGMMHLDPABO(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x81C6280", Offset = "0x81C5280", VA = "0x1881C6280")]
		internal bool OHLECEDICEJ(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x81C6170", Offset = "0x81C5170", VA = "0x1881C6170")]
		internal bool CCNAMLEMMHP(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x81C6170", Offset = "0x81C5170", VA = "0x1881C6170")]
		internal bool PDJEJAGBKEF(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HCNDKABCJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HCNDKABCJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFAC850", Offset = "0xFAB850", VA = "0x180FAC850")]
		internal bool ILEGOJEHLFD(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LDPLBNLDGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LDPLBNLDGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x81C5840", Offset = "0x81C4840", VA = "0x1881C5840")]
		internal bool JNMKJDGNFAL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x278E790", Offset = "0x278D790", VA = "0x18278E790")]
		internal bool CEHEPNOHCOK(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MBDECEEGGIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MBDECEEGGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x81C5900", Offset = "0x81C4900", VA = "0x1881C5900")]
		internal bool JBKEAMKHJEA(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MBCNHMMCAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MBCNHMMCAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFAC850", Offset = "0xFAB850", VA = "0x180FAC850")]
		internal bool BLMIBIHIILI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HEIOHEKHMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HEIOHEKHMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x81C4680", Offset = "0x81C3680", VA = "0x1881C4680")]
		internal bool KIKPGDIBGAC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ICEDLINDNCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GEAEHEAKOFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ICEDLINDNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2388C10", Offset = "0x2387C10", VA = "0x182388C10")]
		internal bool GGBBKLEPJDM(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EPNLEKKCEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EPNLEKKCEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x81B65B0", Offset = "0x81B55B0", VA = "0x1881B65B0")]
		internal bool AFKMBJMEKHN(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IEPBMOKEBJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GEAEHEAKOFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public IEPBMOKEBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x81C4700", Offset = "0x81C3700", VA = "0x1881C4700")]
		internal bool PPIDILNBOEK(KeyValuePair<Guid, GEAEHEAKOFP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HOMBAOPAGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GEAEHEAKOFP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HOMBAOPAGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2388C10", Offset = "0x2387C10", VA = "0x182388C10")]
		internal bool CBMLFIODKFM(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NLPGPCGCKKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NLPGPCGCKKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x81C5CE0", Offset = "0x81C4CE0", VA = "0x1881C5CE0")]
		internal bool NDDOMBCMELE(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CPFONFAPJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CPFONFAPJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x81B58E0", Offset = "0x81B48E0", VA = "0x1881B58E0")]
		internal bool NLJOLDJMJIG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ACAGMJEHOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CPFONFAPJFA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ACAGMJEHOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x81B52F0", Offset = "0x81B42F0", VA = "0x1881B52F0")]
		internal bool BLHBEKJJKNG(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JBIOCEOELAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public OCFEIKJADOO args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x81C4740", Offset = "0x81C3740", VA = "0x1881C4740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x81C4C70", Offset = "0x81C3C70", VA = "0x1881C4C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EIDHMOJBKBD : IAsyncStateMachine
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
		public GLGEEEFLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x81B62C0", Offset = "0x81B52C0", VA = "0x1881B62C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x81B6550", Offset = "0x81B5550", VA = "0x1881B6550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime INHDFPGFMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JDLFHCKLFBB HHGOIPABDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KBPPAOOMKPN NNHGMPGLKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FIAPEONIDIG MILOEMFNAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DMLICIELFJM DPFANJMCHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KCEOPKCFKNB FKCIIOMDKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BBPDOCPMPJE DLNBGEHLLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HGGNDNEIJJL KBNFHOBIMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GDDFOMHBNHP LHHAPIMNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KPPGAAACGAM BNKIOGHLOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CBGAILADKLK MPGPABKBHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NNBHCKAIOLB FJHJDHBIADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LOPPHNNDFGE CNPGJHPOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LBIOJOKOPKD OKINKNMAEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ACFOGNHCCKO FJPGCACLODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PFDLEOBDONH CHJCOCHCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly BKCCENPKEOH<KeepsakesConfig.KeepsakesOptions> EGBMNBJEHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly MEPJMFNAPAB BCCDLAFBNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> IKMKHPOAGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> BHFBGIBJELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> EBOCCNAGNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<GEAEHEAKOFP, int> FAJLDNFGGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> EODLELLMAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable PBGNACCIAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task JBJCENCCHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KPIPLFECKNC<Guid> HFDDJFBIFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? CFAIGEMNALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO JPPEKCGDDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KPIPLFECKNC<KeepsakeProgressionEventInstancesDTO> EMJKNHFHPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<GEAEHEAKOFP, KeepsakeCategoryConfigDTO> MEJIAFIGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO OKDDDINDMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> LHJEPGCHGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> FHDDKNKCMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> MIHEMCOGBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> PFEMGJLDJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> LMFNGFHJBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> MNEPJHMHCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> BIOPOKAIBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> HKLFMEMLIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GFPMIHFHDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GBLNBBHKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> DPNDFFKLIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> LBCCMIJINMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime CMALBGMALJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable AMOCNDHDNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, GEAEHEAKOFP> EGCOBHHJABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<GEAEHEAKOFP, int> GBJJNDIAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> HEGKJDMCNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BIIABGHDEFB KPJMGIEDCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool ICPNKIJJJAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AIDDMPIBGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FNGHHEEDHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81C27B0", Offset = "0x81C17B0", VA = "0x1881C27B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BCHGBKNAIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81C04B0", Offset = "0x81BF4B0", VA = "0x1881C04B0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long GJMEPGPDKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81B7140", Offset = "0x81B6140", VA = "0x1881B7140")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? JBLLAKILPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81B9C30", Offset = "0x81B8C30", VA = "0x1881B9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GNIJGMKJBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81BBBD0", Offset = "0x81BABD0", VA = "0x1881BBBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> CDKIDJPHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBB8140", Offset = "0xBB7140", VA = "0x180BB8140", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KPHJKEDEMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBB9A50", Offset = "0xBB8A50", VA = "0x180BB9A50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FMJIIFPOKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBD2150", Offset = "0xBD1150", VA = "0x180BD2150", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> EOPBPHLOGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBC3C60", Offset = "0xBC2C60", VA = "0x180BC3C60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool DFMJLDAELIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB23C40", Offset = "0xB22C40", VA = "0x180B23C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> EFLKKLBFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81B9CC0", Offset = "0x81B8CC0", VA = "0x1881B9CC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81C0050", Offset = "0x81BF050", VA = "0x1881C0050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GBDJKOPPKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81C1C90", Offset = "0x81C0C90", VA = "0x1881C1C90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81BE400", Offset = "0x81BD400", VA = "0x1881BE400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JGHGPDHDECN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81B6770", Offset = "0x81B5770", VA = "0x1881B6770", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81C24C0", Offset = "0x81C14C0", VA = "0x1881C24C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81C30B0", Offset = "0x81C20B0", VA = "0x1881C30B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GLGEEEFLKAK([KELEGLJPNHI(null)][NotNull] JDLFHCKLFBB HHGOIPABDED, [NotNull][KELEGLJPNHI(null)] DDAPLCBMGDI JCLJEPFEBAL, [NotNull][KELEGLJPNHI(null)] KBPPAOOMKPN NNHGMPGLKJO, [NotNull][KELEGLJPNHI(null)] FIAPEONIDIG MILOEMFNAAL, [KELEGLJPNHI(null)][NotNull] DMLICIELFJM DPFANJMCHNA, [KELEGLJPNHI(null)][NotNull] KCEOPKCFKNB FKCIIOMDKAN, [KELEGLJPNHI(null)][NotNull] BBPDOCPMPJE DLNBGEHLLCP, [NotNull][KELEGLJPNHI(null)] HGGNDNEIJJL KBNFHOBIMJD, [NotNull][KELEGLJPNHI(null)] GDDFOMHBNHP LHHAPIMNBBP, [NotNull][KELEGLJPNHI(null)] DLNEHLPODNE EFADAKJEBDO, [NotNull][KELEGLJPNHI(null)] KPPGAAACGAM BNKIOGHLOMJ, [NotNull][KELEGLJPNHI(null)] CBGAILADKLK MPGPABKBHFO, [NotNull][KELEGLJPNHI(null)] NNBHCKAIOLB FJHJDHBIADB, [NotNull][KELEGLJPNHI(null)] LOPPHNNDFGE CNPGJHPOPEB, [KELEGLJPNHI(null)][NotNull] LBIOJOKOPKD OKINKNMAEOF, [KELEGLJPNHI(null)][NotNull] ACFOGNHCCKO FJPGCACLODM, [NotNull][KELEGLJPNHI(null)] PFDLEOBDONH CHJCOCHCMLP, [KELEGLJPNHI(null)][NotNull] BKCCENPKEOH<KeepsakesConfig.KeepsakesOptions> EGBMNBJEHHO, [NotNull][KELEGLJPNHI(null)] MEPJMFNAPAB BCCDLAFBNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x81C2230", Offset = "0x81C1230", VA = "0x1881C2230", Slot = "15")]
	public bool OLMDIBOKAHE(List<string> IMFIOGNONFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x81BFA30", Offset = "0x81BEA30", VA = "0x1881BFA30", Slot = "16")]
	public KPIPLFECKNC<Guid> MACOMIEFNAL(GEAEHEAKOFP NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81BDF60", Offset = "0x81BCF60", VA = "0x1881BDF60", Slot = "17")]
	public JCFICNGFDLA KEIJJOBHKGL(Guid GJOGOFAANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81C0A10", Offset = "0x81BFA10", VA = "0x1881C0A10", Slot = "18")]
	public JCFICNGFDLA NFPOHJNAIBE(Guid GJOGOFAANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81C1D60", Offset = "0x81C0D60", VA = "0x1881C1D60", Slot = "19")]
	public bool OJKKFKGDLJD(Guid GJOGOFAANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81B8510", Offset = "0x81B7510", VA = "0x1881B8510", Slot = "20")]
	public bool CIDPONKCFJM(Guid GJOGOFAANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81B7750", Offset = "0x81B6750", VA = "0x1881B7750")]
	public KeepsakeTheme BKLBCECAPLJ(Guid GJOGOFAANPP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81C0100", Offset = "0x81BF100", VA = "0x1881C0100")]
	public bool MINHFKNDDDJ(GEAEHEAKOFP NJCHGBOMHEO, [Out] KeepsakeTheme KJDPIIDOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81B9880", Offset = "0x81B8880", VA = "0x1881B9880")]
	public List<KeepsakeTheme> EMMBCGCLMOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81BD670", Offset = "0x81BC670", VA = "0x1881BD670")]
	public int IOMDEEJHCJH(GEAEHEAKOFP NJCHGBOMHEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81BDDA0", Offset = "0x81BCDA0", VA = "0x1881BDDA0")]
	public GEAEHEAKOFP KBCFNLLLHCD(Guid GJOGOFAANPP)
	{
		return default(GEAEHEAKOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81BF450", Offset = "0x81BE450", VA = "0x1881BF450", Slot = "34")]
	public List<GEAEHEAKOFP> LHIJMFBDCBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81BBA50", Offset = "0x81BAA50", VA = "0x1881BBA50", Slot = "35")]
	public IComparer<GEAEHEAKOFP> GMHLPCFKKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81C1AF0", Offset = "0x81C0AF0", VA = "0x1881C1AF0", Slot = "32")]
	public string OGADDFEOPGJ(GEAEHEAKOFP NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x81BD7F0", Offset = "0x81BC7F0", VA = "0x1881BD7F0", Slot = "33")]
	public string JJJCFMMCIEH(GEAEHEAKOFP NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81BBBE0", Offset = "0x81BABE0", VA = "0x1881BBBE0", Slot = "21")]
	public bool HBBLHHMPHGK(Guid GJOGOFAANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81BC140", Offset = "0x81BB140", VA = "0x1881BC140", Slot = "22")]
	public void HNFBHMDDCJA(Guid GJOGOFAANPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81B7A00", Offset = "0x81B6A00", VA = "0x1881B7A00", Slot = "23")]
	public void BMACLKLLPMB(GEAEHEAKOFP NJCHGBOMHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81B9E70", Offset = "0x81B8E70", VA = "0x1881B9E70", Slot = "24")]
	public void FGOGHGNIDGH(Guid GJOGOFAANPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81C2910", Offset = "0x81C1910", VA = "0x1881C2910", Slot = "25")]
	public int PFGNIPADPGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81BC560", Offset = "0x81BB560", VA = "0x1881BC560", Slot = "31")]
	public KPIPLFECKNC<IEnumerable<Guid>> HPAEGPFPHPE(long DJJNJEHBMJK, long MIPJHCDOMJG, GEAEHEAKOFP? NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81B8540", Offset = "0x81B7540", VA = "0x1881B8540", Slot = "30")]
	public KPIPLFECKNC<IEnumerable<Guid>> CNAOOJHMFEN(long DJJNJEHBMJK, long MIPJHCDOMJG, GEAEHEAKOFP? NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81BA7A0", Offset = "0x81B97A0", VA = "0x1881BA7A0", Slot = "54")]
	public KPIPLFECKNC<Dictionary<Guid, GEAEHEAKOFP>> GKIGMAEBMMO(long DJJNJEHBMJK, long MIPJHCDOMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81BD2D0", Offset = "0x81BC2D0", VA = "0x1881BD2D0", Slot = "55")]
	public KPIPLFECKNC<Dictionary<Guid, GEAEHEAKOFP>> IGICBHDGJDG(long DJJNJEHBMJK, long MIPJHCDOMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81BCCB0", Offset = "0x81BBCB0", VA = "0x1881BCCB0", Slot = "26")]
	public KPIPLFECKNC<int> ICCHDCGHJCJ(long DJJNJEHBMJK, long MIPJHCDOMJG, GEAEHEAKOFP? NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81B6610", Offset = "0x81B5610", VA = "0x1881B6610", Slot = "27")]
	public KPIPLFECKNC<int> ADGGPONPLBO(long DJJNJEHBMJK, long MIPJHCDOMJG, GEAEHEAKOFP? NJCHGBOMHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81B68F0", Offset = "0x81B58F0", VA = "0x1881B68F0", Slot = "28")]
	public KPIPLFECKNC<Dictionary<GEAEHEAKOFP, int>> AMNBNDNNIEI(long DJJNJEHBMJK, long MIPJHCDOMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81BA470", Offset = "0x81B9470", VA = "0x1881BA470", Slot = "29")]
	public KPIPLFECKNC<Dictionary<GEAEHEAKOFP, int>> FIPKLECCPBL(long DJJNJEHBMJK, long MIPJHCDOMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81BDF00", Offset = "0x81BCF00", VA = "0x1881BDF00", Slot = "37")]
	public bool KEGFEKAMKLA(long DJJNJEHBMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81B7AB0", Offset = "0x81B6AB0", VA = "0x1881B7AB0", Slot = "56")]
	public bool CAOOMDGLAPM(long DJJNJEHBMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x81B97E0", Offset = "0x81B87E0", VA = "0x1881B97E0", Slot = "38")]
	public bool EGJJFOLFPIF(long DJJNJEHBMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81BC1B0", Offset = "0x81BB1B0", VA = "0x1881BC1B0", Slot = "57")]
	public bool HNKPJBJEKHG(long DJJNJEHBMJK, [Out] PAJBPNPPLLC JEPFEHEMJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81C2F70", Offset = "0x81C1F70", VA = "0x1881C2F70", Slot = "39")]
	public bool POKCCHPHOGC(long CEHOCNMHCFI, [Out] DateTime IKLEJBEAOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81B7210", Offset = "0x81B6210", VA = "0x1881B7210", Slot = "40")]
	public long BBBKENAHGFP(long CEHOCNMHCFI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x81B7BF0", Offset = "0x81B6BF0", VA = "0x1881B7BF0", Slot = "41")]
	public long CEJIMEHMGGD(long DJJNJEHBMJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x81C0620", Offset = "0x81BF620", VA = "0x1881C0620", Slot = "42")]
	public int MKMLJDIDBMH(long CEHOCNMHCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x81B6810", Offset = "0x81B5810", VA = "0x1881B6810", Slot = "43")]
	public bool AMEOIIEAGKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x81BF5A0", Offset = "0x81BE5A0", VA = "0x1881BF5A0", Slot = "44")]
	public bool LNFFLFDGDOL(long CEHOCNMHCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x81BE4A0", Offset = "0x81BD4A0", VA = "0x1881BE4A0", Slot = "45")]
	public IReadOnlyList<long> KMBCPCIMKAG(long CEHOCNMHCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x81BA530", Offset = "0x81B9530", VA = "0x1881BA530", Slot = "46")]
	public int FPBGOKNGBHO(long CEHOCNMHCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x81BBE80", Offset = "0x81BAE80", VA = "0x1881BBE80", Slot = "50")]
	public long HGEJLCOHFMO(long ENIJDOEAKPE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x81C1EC0", Offset = "0x81C0EC0", VA = "0x1881C1EC0", Slot = "51")]
	public GEAEHEAKOFP OLGLBNPLBKM()
	{
		return default(GEAEHEAKOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x81C1510", Offset = "0x81C0510", VA = "0x1881C1510")]
	private bool OCKGHNHAEDK(Guid GJOGOFAANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x81BEBB0", Offset = "0x81BDBB0", VA = "0x1881BEBB0")]
	private void LCCLGMDCABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x81BCFF0", Offset = "0x81BBFF0", VA = "0x1881BCFF0")]
	private GEAEHEAKOFP IFECOFIJLDI()
	{
		return default(GEAEHEAKOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x81B6B00", Offset = "0x81B5B00", VA = "0x1881B6B00")]
	private void APECJKDKOEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81BE1E0", Offset = "0x81BD1E0", VA = "0x1881BE1E0")]
	private int KGJKBAKLDCP(KeepsakeRoomListDTO FPKBIBJJGDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81B9D70", Offset = "0x81B8D70", VA = "0x1881B9D70")]
	private int FEBLHKOPEBP(DateTime PDGJOCICGCG, DateTime NEKGHGJLHCB, TimeSpan AJPIEBPMOPN, int CLFDNHHGPBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81BDAA0", Offset = "0x81BCAA0", VA = "0x1881BDAA0")]
	private void JPLKJGHPCHB(IEnumerable<KeepsakeInstanceDTO> IKMKHPOAGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81C2560", Offset = "0x81C1560", VA = "0x1881C2560")]
	private void PAIFIOLEGMB(IEnumerable<KeepsakeCollectionRecordDTO> NOLGGHNHKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81B8F70", Offset = "0x81B7F70", VA = "0x1881B8F70")]
	private void DJIIEPGHIBP(IEnumerable<long> DMNHLBLOCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB2B180", Offset = "0xB2A180", VA = "0x180B2B180")]
	private void GOMOLHPPFDO(KeepsakeGlobalConfigDTO OKDDDINDMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81B7D00", Offset = "0x81B6D00", VA = "0x1881B7D00")]
	private bool CFCKLDJKOJJ(GEAEHEAKOFP NJCHGBOMHEO, [Out] Guid KDPONDGMKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81C2D50", Offset = "0x81C1D50", VA = "0x1881C2D50")]
	private bool PGPBFJIJJKG([Out] Guid KDPONDGMKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81C14B0", Offset = "0x81C04B0", VA = "0x1881C14B0")]
	private bool NNPMHAMEJME(Guid GJOGOFAANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81B8B00", Offset = "0x81B7B00", VA = "0x1881B8B00")]
	private IEnumerable<Guid> DACKPOGCJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x81BBB10", Offset = "0x81BAB10", VA = "0x1881BBB10")]
	private IEnumerable<KeepsakeInstanceDTO> HAFNCCPPKJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81BCF60", Offset = "0x81BBF60", VA = "0x1881BCF60")]
	private void IFDOEDMPANB(Guid GJOGOFAANPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81C0570", Offset = "0x81BF570", VA = "0x1881C0570")]
	private bool MKFFENBCMGN(Guid GJOGOFAANPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x81C12C0", Offset = "0x81C02C0", VA = "0x1881C12C0")]
	private void NKDPDEPLFLD(Guid GJOGOFAANPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x81BE710", Offset = "0x81BD710", VA = "0x1881BE710")]
	private void KMBKIBBFMIO(GEAEHEAKOFP AJJONCKACFM, int OPDIBJAEANI, Dictionary<GEAEHEAKOFP, int> JIMDJBCPEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81B9430", Offset = "0x81B8430", VA = "0x1881B9430")]
	private int EAEIPHNCOKC(GEAEHEAKOFP NJCHGBOMHEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81C1640", Offset = "0x81C0640", VA = "0x1881C1640")]
	private void OEADBPGBMOB(KeepsakeInstanceDTO KMHIPONIJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81C0800", Offset = "0x81BF800", VA = "0x1881C0800")]
	private void NCBEIENBOOH(KeepsakeInstanceDTO KMHIPONIJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81BF080", Offset = "0x81BE080", VA = "0x1881BF080")]
	private void LENOKEEFIFE(Guid GJOGOFAANPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x81C1D30", Offset = "0x81C0D30", VA = "0x1881C1D30")]
	private void PJGIJEGAGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x81C1C70", Offset = "0x81C0C70", VA = "0x1881C1C70")]
	private void OHDPJCBPOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81BDD30", Offset = "0x81BCD30", VA = "0x1881BDD30")]
	private void KAEMPABFHED(LAAMCDOLEFK NPDPGMFHOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x81C1D30", Offset = "0x81C0D30", VA = "0x1881C1D30")]
	private void PIIJJNOBBEK(BLACPMBKBHH PGIOEBKALDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81C1D30", Offset = "0x81C0D30", VA = "0x1881C1D30")]
	private void OJIIIOEDANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81BA0B0", Offset = "0x81B90B0", VA = "0x1881BA0B0")]
	private void FHOKFEDEBJO(float PHKAANJAFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81B7F70", Offset = "0x81B6F70", VA = "0x1881B7F70")]
	private void CFJJEPLPLNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81BCAB0", Offset = "0x81BBAB0", VA = "0x1881BCAB0")]
	private bool IBHEGOJFIPE(Guid GJOGOFAANPP, [Out] string KDHIONDDPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81C02E0", Offset = "0x81BF2E0", VA = "0x1881C02E0")]
	private bool MJECKJEHECH(Guid GJOGOFAANPP, [Out] KeepsakeCategoryConfigDTO AJJONCKACFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81B9540", Offset = "0x81B8540", VA = "0x1881B9540")]
	private void EDOFPDCFNHF(string NCBKJJBPLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81BD560", Offset = "0x81BC560", VA = "0x1881BD560")]
	private bool INPBLGFNFBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81C1810", Offset = "0x81C0810", VA = "0x1881C1810")]
	private List<long> OEFCLMAJNDF(IEnumerable<KeepsakeRoomDTO> OAJDEAAFCHB, IReadOnlyList<KeepsakeRoomListDTO> CMIBEFJEHAH, long CEHOCNMHCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x81C0DA0", Offset = "0x81BFDA0", VA = "0x1881C0DA0")]
	private bool NJPNNBDJNIJ(Guid GJOGOFAANPP, [Out] string MGECNFLHDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81BE380", Offset = "0x81BD380", VA = "0x1881BE380", Slot = "47")]
	public string KHPAOEOJGNG(OJGDLMKFFCF GIIOLCKGBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x81B86E0", Offset = "0x81B76E0", VA = "0x1881B86E0", Slot = "49")]
	public string DAAGKNNFKPP(OJGDLMKFFCF GIIOLCKGBPL, long DJJNJEHBMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x81BD480", Offset = "0x81BC480", VA = "0x1881BD480", Slot = "48")]
	public string IMJCILPBAJL(OJGDLMKFFCF GIIOLCKGBPL, int KBMKLCOBEAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x81BAB50", Offset = "0x81B9B50", VA = "0x1881BAB50")]
	private void GLKNBNONKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x81BC920", Offset = "0x81BB920", VA = "0x1881BC920")]
	private void HPGPODPGAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x81BE3E0", Offset = "0x81BD3E0", VA = "0x1881BE3E0")]
	private OJGDLMKFFCF KIECADAMFLG(DIMLKCOCNNK BIPDBFOMEHO)
	{
		return default(OJGDLMKFFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x81B9520", Offset = "0x81B8520", VA = "0x1881B9520")]
	private OJGDLMKFFCF EBJOMGGIFPF(DIMLKCOCNNK BIPDBFOMEHO)
	{
		return default(OJGDLMKFFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x81B8C60", Offset = "0x81B7C60", VA = "0x1881B8C60")]
	internal static string DFAKFBHDFLF(PBPJGPNKAHF GLGHOKJGILM, string DJMJGJOIHLK, bool MJCBOFJOJJF, int GIGNKMEMLEC, int ADFGHFFJHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x81B8FD0", Offset = "0x81B7FD0", VA = "0x1881B8FD0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81C2DF0", Offset = "0x81C1DF0", VA = "0x1881C2DF0")]
	private GCLAAFAMBMC PJEOIKCDCAG(IALDHONKEJC BDEHCELPPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81B9620", Offset = "0x81B8620", VA = "0x1881B9620")]
	private AKLKNLKMADI EGEPCBKDOHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81BE7F0", Offset = "0x81BD7F0", VA = "0x1881BE7F0")]
	private Task KOGJJCFJMIL(OCFEIKJADOO DELLHDJPKBE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81C2800", Offset = "0x81C1800", VA = "0x1881C2800")]
	[AsyncStateMachine(typeof(JBIOCEOELAA))]
	private Task PEILLHGNLPD(OCFEIKJADOO DELLHDJPKBE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81B7B10", Offset = "0x81B6B10", VA = "0x1881B7B10")]
	private Task CDMIOCKGHEH(OCFEIKJADOO DELLHDJPKBE, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81BD970", Offset = "0x81BC970", VA = "0x1881BD970")]
	[AsyncStateMachine(typeof(EIDHMOJBKBD))]
	private Task JJKHOFGMEFG(string OBCNAJEENCI, TimeSpan NBGNFJAHIKJ, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81BA450", Offset = "0x81B9450", VA = "0x1881BA450")]
	[CompilerGenerated]
	private void FIKIJLKKANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81C1460", Offset = "0x81C0460", VA = "0x1881C1460")]
	[CompilerGenerated]
	private void NLGKEEINFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81C2E70", Offset = "0x81C1E70", VA = "0x1881C2E70")]
	[CompilerGenerated]
	private bool PJNLCFPGIGJ(KeepsakeInstanceDTO OEFDFBLCHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x81B7890", Offset = "0x81B6890", VA = "0x1881B7890")]
	[CompilerGenerated]
	private KPIPLFECKNC<Dictionary<GEAEHEAKOFP, int>> BLOFPPBJNKC(Dictionary<Guid, GEAEHEAKOFP> INKDPFDPKBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81BF8C0", Offset = "0x81BE8C0", VA = "0x1881BF8C0")]
	[CompilerGenerated]
	private KPIPLFECKNC<Dictionary<GEAEHEAKOFP, int>> LPCIEFALOJG(Dictionary<Guid, GEAEHEAKOFP> INKDPFDPKBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81BD460", Offset = "0x81BC460", VA = "0x1881BD460")]
	[CompilerGenerated]
	private bool IMIGEBBCKPG(KeepsakeRoomListDTO OEFDFBLCHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81B8E40", Offset = "0x81B7E40", VA = "0x1881B8E40")]
	[CompilerGenerated]
	private bool DHOKCCEOOFC(KeepsakeInstanceDTO OEFDFBLCHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81BF730", Offset = "0x81BE730", VA = "0x1881BF730")]
	[CompilerGenerated]
	private void LNFNNGPCCND(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<GEAEHEAKOFP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> MHPOCKAHOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x81B7A50", Offset = "0x81B6A50", VA = "0x1881B7A50")]
	[CompilerGenerated]
	private void BMADCEPCNGB(string MGECNFLHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81BA5E0", Offset = "0x81B95E0", VA = "0x1881BA5E0")]
	[CompilerGenerated]
	private Task GGEEBGFHHKJ(CancellationToken OMFDMJPEHHA)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, BKCCENPKEOH<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class EHHKJELDMCO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
				public EHHKJELDMCO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x81B6290", Offset = "0x81B5290", VA = "0x1881B6290")]
				internal bool JLLOJHGGNON(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x81B6290", Offset = "0x81B5290", VA = "0x1881B6290")]
				internal bool BDMGLPJECLI(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x81C5470", Offset = "0x81C4470", VA = "0x1881C5470")]
			public bool AEJMFFAALBE(string BPBEMBAFJCL, [Out] KeepsakeTheme KJDPIIDOJGA)
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x81C53F0", Offset = "0x81C43F0", VA = "0x1881C53F0")]
		[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
		internal static void JPGJPCMNFEJ(CBHAAKGBAOP PFJIPDCNGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
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
