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
		[Cpp2IlInjected.Address(RVA = "0x7FFF650", Offset = "0x7FFDC50", VA = "0x187FFF650", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BEOAMFMPDGN : IComparer<DJAEGFIGJOO>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HOHGBDLMLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DJAEGFIGJOO x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public DJAEGFIGJOO y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HOHGBDLMLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xDC1B40", Offset = "0xDC0140", VA = "0x180DC1B40")]
		internal bool GGBFLLBIPHN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x206F310", Offset = "0x206D910", VA = "0x18206F310")]
		internal bool FOODEJHOJND(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDC1B40", Offset = "0xDC0140", VA = "0x180DC1B40")]
		internal bool OHHMNLAJJOM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x206F310", Offset = "0x206D910", VA = "0x18206F310")]
		internal bool IDFELIJOFCJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> PNHJKBJJGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public BEOAMFMPDGN(List<KeepsakeCategoryThemePair> JHENBMDOIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE790", Offset = "0x7FECD90", VA = "0x187FEE790", Slot = "4")]
	public int Compare(DJAEGFIGJOO POMHCCBBBGD, DJAEGFIGJOO JKKMGDMGNFG)
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
		public DJAEGFIGJOO KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HIAEMPMDAHB]
public class NGPIEGJJLBJ : MECFDLBDOAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FLAOEJMJCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DJAEGFIGJOO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FLAOEJMJCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFAA0", Offset = "0x7FEE0A0", VA = "0x187FEFAA0")]
		internal EHBLMFNEKIG<Guid> MBLBCGOIBAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFC50", Offset = "0x7FEE250", VA = "0x187FEFC50")]
		internal void NPKOKHPJOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFBF0", Offset = "0x7FEE1F0", VA = "0x187FEFBF0")]
		internal void NDCMCEMKNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFC80", Offset = "0x7FEE280", VA = "0x187FEFC80")]
		internal void PFPFMKMFLNA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFA70", Offset = "0x7FEE070", VA = "0x187FEFA70")]
		internal void CGEGADGHGEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BDNFHFNKANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NGPIEGJJLBJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BDNFHFNKANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE3E0", Offset = "0x7FEC9E0", VA = "0x187FEE3E0")]
		internal void JBGECCFKLEN(FBOIPGFCCKN response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE380", Offset = "0x7FEC980", VA = "0x187FEE380")]
		internal void CCJNHDNPKFA(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CCIHFPFHPFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CCIHFPFHPFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEBF0", Offset = "0x7FED1F0", VA = "0x187FEEBF0")]
		internal bool BFMDNAPMODK(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EFIFOLNEKKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DJAEGFIGJOO? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EFIFOLNEKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF940", Offset = "0x7FEDF40", VA = "0x187FEF940")]
		internal void NIHJDOEEPME(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEF90", Offset = "0x7FED590", VA = "0x187FEEF90")]
		internal void CPCKINLPLEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF640", Offset = "0x7FEDC40", VA = "0x187FEF640")]
		internal EHBLMFNEKIG<IEnumerable<Guid>> JJAJNLNIBKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F10", Offset = "0x7B00510", VA = "0x187B01F10")]
		internal bool MFILPEMEGHM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JOHOJNFBNMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public EFIFOLNEKKC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JOHOJNFBNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0D70", Offset = "0x7FEF370", VA = "0x187FF0D70")]
		internal EHBLMFNEKIG<IEnumerable<Guid>> LCLEAKOOENC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MLAKFKEHFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JOHOJNFBNMC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MLAKFKEHFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1230", Offset = "0x7FEF830", VA = "0x187FF1230")]
		internal bool NHHJNKMAPAA(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NABEBOMBAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public MLAKFKEHFDP CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NABEBOMBAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1360", Offset = "0x7FEF960", VA = "0x187FF1360")]
		internal bool ONHNIIMKFII(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GEANEGHNAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GEANEGHNAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0260", Offset = "0x7FEE860", VA = "0x187FF0260")]
		internal EHBLMFNEKIG<IEnumerable<Guid>> PMDOONDDMOK(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF3F0", Offset = "0x7FED9F0", VA = "0x187FEF3F0")]
		internal bool AHDGCOINENB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CFDGBACBPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NGPIEGJJLBJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CFDGBACBPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEC10", Offset = "0x7FED210", VA = "0x187FEEC10")]
		internal void HHEAHDAIEAO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEF90", Offset = "0x7FED590", VA = "0x187FEEF90")]
		internal void NHJHMAFPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FEECA0", Offset = "0x7FED2A0", VA = "0x187FEECA0")]
		internal EHBLMFNEKIG<Dictionary<Guid, DJAEGFIGJOO>> IAKOHCKFDIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F10", Offset = "0x7B00510", VA = "0x187B01F10")]
		internal bool DDAIAHJFEJL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CLKIPKJIPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CLKIPKJIPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF040", Offset = "0x7FED640", VA = "0x187FEF040")]
		internal EHBLMFNEKIG<Dictionary<Guid, DJAEGFIGJOO>> DADJGGHLDEC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class EDAAFODPHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EDAAFODPHMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF560", Offset = "0x7FEDB60", VA = "0x187FEF560")]
		internal bool PODFBOOJJIO(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF410", Offset = "0x7FEDA10", VA = "0x187FEF410")]
		internal KeyValuePair<Guid, DJAEGFIGJOO> OEHPHFOGGDO(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DJAEGFIGJOO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JAHNNNDDBLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JAHNNNDDBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26FD060", Offset = "0x26FB660", VA = "0x1826FD060")]
		internal bool PHDLCACCKDK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IIAHGNDGPLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IIAHGNDGPLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x26FD060", Offset = "0x26FB660", VA = "0x1826FD060")]
		internal bool DNMJCLFHLFG(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DDMBPAFOCJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DDMBPAFOCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF1F0", Offset = "0x7FED7F0", VA = "0x187FEF1F0")]
		internal EHBLMFNEKIG<Dictionary<Guid, DJAEGFIGJOO>> GAALOJJGOOD(Dictionary<Guid, DJAEGFIGJOO> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF3F0", Offset = "0x7FED9F0", VA = "0x187FEF3F0")]
		internal bool JDDAJPNILAH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CLJDCDBCOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CLJDCDBCOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEFC0", Offset = "0x7FED5C0", VA = "0x187FEEFC0")]
		internal bool AGPOAPIGNBH(KeyValuePair<Guid, DJAEGFIGJOO> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BPHHCHFGIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, DJAEGFIGJOO> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BPHHCHFGIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEA40", Offset = "0x7FED040", VA = "0x187FEEA40")]
		internal KeyValuePair<DJAEGFIGJOO, int> CONDKFNCGCF(DJAEGFIGJOO category)
		{
			return default(KeyValuePair<DJAEGFIGJOO, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LNHAIKGKJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DJAEGFIGJOO category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LNHAIKGKJFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xEAC3B0", Offset = "0xEAA9B0", VA = "0x180EAC3B0")]
		internal bool BEJFCGNLAFI(DJAEGFIGJOO instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AFJJLJOADDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, DJAEGFIGJOO> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AFJJLJOADDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE140", Offset = "0x7FEC740", VA = "0x187FEE140")]
		internal KeyValuePair<DJAEGFIGJOO, int> IAKFJAFFDDH(DJAEGFIGJOO category)
		{
			return default(KeyValuePair<DJAEGFIGJOO, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MCPKABFGEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DJAEGFIGJOO category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MCPKABFGEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xEAC3B0", Offset = "0xEAA9B0", VA = "0x180EAC3B0")]
		internal bool AKBFKFNLKED(DJAEGFIGJOO instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FNFOMIBPPLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FNFOMIBPPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF00B0", Offset = "0x7FEE6B0", VA = "0x187FF00B0")]
		internal bool DHJPGAADAAB(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FF01A0", Offset = "0x7FEE7A0", VA = "0x187FF01A0")]
		internal bool PPHOFPELPMA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0090", Offset = "0x7FEE690", VA = "0x187FF0090")]
		internal bool HIBJLAPDBDA(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0090", Offset = "0x7FEE690", VA = "0x187FF0090")]
		internal bool CCBPKDEPFLG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LLPGAEJDJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LLPGAEJDJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xF54700", Offset = "0xF52D00", VA = "0x180F54700")]
		internal bool DHAFKDLDBAB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IFAKOOBIHKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IFAKOOBIHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FF06D0", Offset = "0x7FEECD0", VA = "0x187FF06D0")]
		internal bool LPEIFHPMGEM(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2682710", Offset = "0x2680D10", VA = "0x182682710")]
		internal bool CEAKDDGBNDF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CBEHPGIDDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CBEHPGIDDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEB90", Offset = "0x7FED190", VA = "0x187FEEB90")]
		internal bool NEHHLPBOHAN(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class COGMLHIBFED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public COGMLHIBFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xF54700", Offset = "0xF52D00", VA = "0x180F54700")]
		internal bool HAODPDEDDAH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FCKOBJEJBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FCKOBJEJBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFA10", Offset = "0x7FEE010", VA = "0x187FEFA10")]
		internal bool GBKDBHFOBAC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IDOKPGEPHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DJAEGFIGJOO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public IDOKPGEPHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x22925C0", Offset = "0x2290BC0", VA = "0x1822925C0")]
		internal bool JBEOCKPCIBM(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JLBEIBLDOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JLBEIBLDOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0790", Offset = "0x7FEED90", VA = "0x187FF0790")]
		internal bool GOONKLNMODB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EMBKKILHKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DJAEGFIGJOO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EMBKKILHKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF9D0", Offset = "0x7FEDFD0", VA = "0x187FEF9D0")]
		internal bool HNGFNENOMJJ(KeyValuePair<Guid, DJAEGFIGJOO> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BJAGJOGNFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DJAEGFIGJOO newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BJAGJOGNFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x22925C0", Offset = "0x2290BC0", VA = "0x1822925C0")]
		internal bool CAAAIBMIFBO(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LENNFANEOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LENNFANEOAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1180", Offset = "0x7FEF780", VA = "0x187FF1180")]
		internal bool PENLGKFPNME(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class AMBICIDAEHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AMBICIDAEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE290", Offset = "0x7FEC890", VA = "0x187FEE290")]
		internal bool NGBLOEJHAII(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KNGBCGPPAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AMBICIDAEHB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KNGBCGPPAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0EB0", Offset = "0x7FEF4B0", VA = "0x187FF0EB0")]
		internal bool OENLBFHPAMC(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JLHKJEKODBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JBAPOOINJKO args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FF07F0", Offset = "0x7FEEDF0", VA = "0x187FF07F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0D10", Offset = "0x7FEF310", VA = "0x187FF0D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HBAHALAGDNI : IAsyncStateMachine
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
		public NGPIEGJJLBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FF03D0", Offset = "0x7FEE9D0", VA = "0x187FF03D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0670", Offset = "0x7FEEC70", VA = "0x187FF0670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime LAKMBEJNAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IKGEIBFBBLG INLFFKAAODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly IPMEPLBPCGL NOCOJIFIPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CJEAGPJDJNI EOKLJLGFONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MIFBDAKAGKK EJFFKDJMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JFIDBHHFOOE GEJAMCMAAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OMOKHHNAINK GKDONLMEFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IKIILEMDACF PPLAKJAADCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KEDGPMDLKIM ILCCHPCLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KGLNFLBOGCL DKCKANGBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JEHOECNOINJ OJFGPLIDEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NONJPMGFCKL JEMGNCELELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KKLMHFHACEF APMJPFKJFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CLCHHNPEFDM IGOMEHBDBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OBAHBIIHJNK FEOCAOBMDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HJILBECDIFL KOFKJMOGEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FJDHHPBBPOJ<KeepsakesConfig.KeepsakesOptions> PANLLLBJFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly MFFKJDDAJBP HINKJLIAKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FEEDCKMLNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> ABDLBIECBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> AHLDCGOHDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<DJAEGFIGJOO, int> JKLBJAEBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> FJPKPLEFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable MHLOFPIOOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task BJNFMPLGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EHBLMFNEKIG<Guid> ACKIMLHGAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? BKHFPIGJHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO PFDECPKGDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EHBLMFNEKIG<KeepsakeProgressionEventInstancesDTO> MHENKLLJANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<DJAEGFIGJOO, KeepsakeCategoryConfigDTO> GFKNBKCDJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO BLKNNDEJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> NFOKJHKAHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> EJCAOMGPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> NBONCCDACAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> EKGFMAKCCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> OGIPECMOJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> AIILJKBODLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> BBNHJFJMPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> LFCDMGMGLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KDGCELGBPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LIGJIODGEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> DNPIOBDMIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> FFLDMLFBEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime JPFDNCLDKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable KEIGEAGAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, DJAEGFIGJOO> CMMCLFFMJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<DJAEGFIGJOO, int> DKFFJADLJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> JHENBMDOIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BEOAMFMPDGN GMHGKONHNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool MCPHHAANLHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LGMKIDODKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ELCGHGGPJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FF21D0", Offset = "0x7FF07D0", VA = "0x187FF21D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OCJKHAFEJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FF64D0", Offset = "0x7FF4AD0", VA = "0x187FF64D0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long NOGPGEEFPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7620", Offset = "0x7FF5C20", VA = "0x187FF7620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? PMFEABNFJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5FD0", Offset = "0x7FF45D0", VA = "0x187FF5FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IMOIDMHNLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7FF83C0", Offset = "0x7FF69C0", VA = "0x187FF83C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> BEMEFKMICEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB5C6A0", Offset = "0xB5ACA0", VA = "0x180B5C6A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DLILNELHNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB5E6D0", Offset = "0xB5CCD0", VA = "0x180B5E6D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> NLHKNPBGDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB72A80", Offset = "0xB71080", VA = "0x180B72A80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> AOBKDAGKMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB5DCF0", Offset = "0xB5C2F0", VA = "0x180B5DCF0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NALIAIOKCDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC4AF90", Offset = "0xC49590", VA = "0x180C4AF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LLLEFMEDEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB210", Offset = "0x7FF9810", VA = "0x187FFB210", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB4D0", Offset = "0x7FF9AD0", VA = "0x187FFB4D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PBIBEHPEOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9230", Offset = "0x7FF7830", VA = "0x187FF9230", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFADA0", Offset = "0x7FF93A0", VA = "0x187FFADA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LFMJLOCAHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF86B0", Offset = "0x7FF6CB0", VA = "0x187FF86B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDB40", Offset = "0x7FFC140", VA = "0x187FFDB40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDE70", Offset = "0x7FFC470", VA = "0x187FFDE70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NGPIEGJJLBJ([GGNLMCAPMLP(null)][NotNull] IKGEIBFBBLG INLFFKAAODH, [NotNull][GGNLMCAPMLP(null)] NHGJFNPGAOK PDHGMIGEJPA, [NotNull][GGNLMCAPMLP(null)] IPMEPLBPCGL NOCOJIFIPOJ, [NotNull][GGNLMCAPMLP(null)] CJEAGPJDJNI EOKLJLGFONM, [GGNLMCAPMLP(null)][NotNull] MIFBDAKAGKK EJFFKDJMMMM, [GGNLMCAPMLP(null)][NotNull] JFIDBHHFOOE GEJAMCMAAHF, [GGNLMCAPMLP(null)][NotNull] OMOKHHNAINK GKDONLMEFDJ, [NotNull][GGNLMCAPMLP(null)] IKIILEMDACF PPLAKJAADCA, [NotNull][GGNLMCAPMLP(null)] KEDGPMDLKIM ILCCHPCLICG, [NotNull][GGNLMCAPMLP(null)] MEIHBANPFAL GKBMHPGKCNA, [NotNull][GGNLMCAPMLP(null)] KGLNFLBOGCL DKCKANGBCBK, [NotNull][GGNLMCAPMLP(null)] JEHOECNOINJ OJFGPLIDEAA, [NotNull][GGNLMCAPMLP(null)] NONJPMGFCKL JEMGNCELELN, [NotNull][GGNLMCAPMLP(null)] KKLMHFHACEF APMJPFKJFAC, [GGNLMCAPMLP(null)][NotNull] CLCHHNPEFDM IGOMEHBDBHG, [GGNLMCAPMLP(null)][NotNull] OBAHBIIHJNK FEOCAOBMDBL, [NotNull][GGNLMCAPMLP(null)] HJILBECDIFL KOFKJMOGEGK, [GGNLMCAPMLP(null)][NotNull] FJDHHPBBPOJ<KeepsakesConfig.KeepsakesOptions> PANLLLBJFBB, [NotNull][GGNLMCAPMLP(null)] MFFKJDDAJBP HINKJLIAKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4480", Offset = "0x7FF2A80", VA = "0x187FF4480", Slot = "15")]
	public bool DKBJILBCPLB(List<string> KDBJLKFFHAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB5A0", Offset = "0x7FF9BA0", VA = "0x187FFB5A0", Slot = "16")]
	public EHBLMFNEKIG<Guid> NGAOJKCCNGC(DJAEGFIGJOO PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9920", Offset = "0x7FF7F20", VA = "0x187FF9920", Slot = "17")]
	public NCBJFOCOMOJ KHDJLCADBHP(Guid LDPNMFLPJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4EE0", Offset = "0x7FF34E0", VA = "0x187FF4EE0", Slot = "18")]
	public NCBJFOCOMOJ DOIEOGEIIPL(Guid LDPNMFLPJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6060", Offset = "0x7FF4660", VA = "0x187FF6060", Slot = "19")]
	public bool EINAEGIHNIE(Guid LDPNMFLPJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDB10", Offset = "0x7FFC110", VA = "0x187FFDB10", Slot = "20")]
	public bool PEACGKMBECB(Guid LDPNMFLPJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FFBF70", Offset = "0x7FFA570", VA = "0x187FFBF70")]
	public KeepsakeTheme OIIKPCHIIJH(Guid LDPNMFLPJKL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9430", Offset = "0x7FF7A30", VA = "0x187FF9430")]
	public bool KANCCAKJFHI(DJAEGFIGJOO PFFBPBHCNNM, [Out] KeepsakeTheme EMCPFDAGEII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1B80", Offset = "0x7FF0180", VA = "0x187FF1B80")]
	public List<KeepsakeTheme> AELCJJJFCFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA290", Offset = "0x7FF8890", VA = "0x187FFA290")]
	public int KLDIDPKMKGC(DJAEGFIGJOO PFFBPBHCNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8260", Offset = "0x7FF6860", VA = "0x187FF8260")]
	public DJAEGFIGJOO GMPMFILNJGO(Guid LDPNMFLPJKL)
	{
		return default(DJAEGFIGJOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAEB0", Offset = "0x7FF94B0", VA = "0x187FFAEB0", Slot = "34")]
	public List<DJAEGFIGJOO> MBCHKCGEPDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5260", Offset = "0x7FF3860", VA = "0x187FF5260", Slot = "35")]
	public IComparer<DJAEGFIGJOO> DPMGPLENIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF65F0", Offset = "0x7FF4BF0", VA = "0x187FF65F0", Slot = "32")]
	public string ELPGHBJMFLB(DJAEGFIGJOO PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6350", Offset = "0x7FF4950", VA = "0x187FF6350", Slot = "33")]
	public string ELJEPNBMDAH(DJAEGFIGJOO PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7270", Offset = "0x7FF5870", VA = "0x187FF7270", Slot = "21")]
	public bool FNBNBEEACEN(Guid LDPNMFLPJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA470", Offset = "0x7FF8A70", VA = "0x187FFA470", Slot = "22")]
	public void KOODAJBPDOF(Guid LDPNMFLPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2220", Offset = "0x7FF0820", VA = "0x187FF2220", Slot = "23")]
	public void AOFJNKOIHCP(DJAEGFIGJOO PFFBPBHCNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8750", Offset = "0x7FF6D50", VA = "0x187FF8750", Slot = "24")]
	public void JBKDDLHEHEK(Guid LDPNMFLPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD190", Offset = "0x7FFB790", VA = "0x187FFD190", Slot = "25")]
	public int OOGIKOCFAAA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6EC0", Offset = "0x7FF54C0", VA = "0x187FF6EC0", Slot = "31")]
	public EHBLMFNEKIG<IEnumerable<Guid>> FGMBLMDKKBG(long CDFGHIILPDC, long CCPDACGIOEI, DJAEGFIGJOO? PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA0F0", Offset = "0x7FF86F0", VA = "0x187FFA0F0", Slot = "30")]
	public EHBLMFNEKIG<IEnumerable<Guid>> KIGEMLAJMCJ(long CDFGHIILPDC, long CCPDACGIOEI, DJAEGFIGJOO? PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1410", Offset = "0x7FEFA10", VA = "0x187FF1410", Slot = "54")]
	public EHBLMFNEKIG<Dictionary<Guid, DJAEGFIGJOO>> AAMGBPIOCAB(long CDFGHIILPDC, long CCPDACGIOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9F60", Offset = "0x7FF8560", VA = "0x187FF9F60", Slot = "55")]
	public EHBLMFNEKIG<Dictionary<Guid, DJAEGFIGJOO>> KIDHPFDCEOH(long CDFGHIILPDC, long CCPDACGIOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3730", Offset = "0x7FF1D30", VA = "0x187FF3730", Slot = "26")]
	public EHBLMFNEKIG<int> BMDDEJDMGBF(long CDFGHIILPDC, long CCPDACGIOEI, DJAEGFIGJOO? PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7D60", Offset = "0x7FF6360", VA = "0x187FF7D60", Slot = "27")]
	public EHBLMFNEKIG<int> GLJGCENAMAO(long CDFGHIILPDC, long CCPDACGIOEI, DJAEGFIGJOO? PFFBPBHCNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9610", Offset = "0x7FF7C10", VA = "0x187FF9610", Slot = "28")]
	public EHBLMFNEKIG<Dictionary<DJAEGFIGJOO, int>> KDKMFBMMIOH(long CDFGHIILPDC, long CCPDACGIOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FF83D0", Offset = "0x7FF69D0", VA = "0x187FF83D0", Slot = "29")]
	public EHBLMFNEKIG<Dictionary<DJAEGFIGJOO, int>> HHEAFEHLHLK(long CDFGHIILPDC, long CCPDACGIOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB470", Offset = "0x7FF9A70", VA = "0x187FFB470", Slot = "37")]
	public bool MPKNLDKCKBG(long CDFGHIILPDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6590", Offset = "0x7FF4B90", VA = "0x187FF6590", Slot = "56")]
	public bool ELNJFDNKCJD(long CDFGHIILPDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB2C0", Offset = "0x7FF98C0", VA = "0x187FFB2C0", Slot = "38")]
	public bool MOFCJACNOEN(long CDFGHIILPDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4B30", Offset = "0x7FF3130", VA = "0x187FF4B30", Slot = "57")]
	public bool DNHLEJLBGKA(long CDFGHIILPDC, [Out] LHGJOLJIKGI KFAJNNJAKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3170", Offset = "0x7FF1770", VA = "0x187FF3170", Slot = "39")]
	public bool BGGNOLIELDI(long MKLOBBGCMNK, [Out] DateTime PGIIEIOELGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD5D0", Offset = "0x7FFBBD0", VA = "0x187FFD5D0", Slot = "40")]
	public long OPBLBJNIEJF(long MKLOBBGCMNK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7510", Offset = "0x7FF5B10", VA = "0x187FF7510", Slot = "41")]
	public long GCDOHMGBIHI(long CDFGHIILPDC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDC90", Offset = "0x7FFC290", VA = "0x187FFDC90", Slot = "42")]
	public int PPEHPGBOJNJ(long MKLOBBGCMNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9820", Offset = "0x7FF7E20", VA = "0x187FF9820", Slot = "43")]
	public bool KEJEOINEOCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA8B0", Offset = "0x7FF8EB0", VA = "0x187FFA8B0", Slot = "44")]
	public bool LGHOKIPACMC(long MKLOBBGCMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FFBBB0", Offset = "0x7FFA1B0", VA = "0x187FFBBB0", Slot = "45")]
	public IReadOnlyList<long> OADKOKMMJOG(long MKLOBBGCMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDBE0", Offset = "0x7FFC1E0", VA = "0x187FFDBE0", Slot = "46")]
	public int PMCJHKFKHOB(long MKLOBBGCMNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4060", Offset = "0x7FF2660", VA = "0x187FF4060", Slot = "50")]
	public long DECECILEGKO(long BBJPDFBMNFA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2380", Offset = "0x7FF0980", VA = "0x187FF2380", Slot = "51")]
	public DJAEGFIGJOO BBNOELNACGC()
	{
		return default(DJAEGFIGJOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FF26F0", Offset = "0x7FF0CF0", VA = "0x187FF26F0")]
	private bool BCEDCHJFMAG(Guid LDPNMFLPJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7890", Offset = "0x7FF5E90", VA = "0x187FF7890")]
	private void GKICGMHNIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3D40", Offset = "0x7FF2340", VA = "0x187FF3D40")]
	private DJAEGFIGJOO CNEPBIBMMDK()
	{
		return default(DJAEGFIGJOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8990", Offset = "0x7FF6F90", VA = "0x187FF8990")]
	private void JFDLMLDMOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3590", Offset = "0x7FF1B90", VA = "0x187FF3590")]
	private int BIKNHGJLFKJ(KeepsakeRoomListDTO JPCFCPHGJPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5D50", Offset = "0x7FF4350", VA = "0x187FF5D50")]
	private int EDILEHPDEBO(DateTime JPDFLGDPEHA, DateTime DINBBAAFHNK, TimeSpan KKOPJJLJKFI, int JNPBENFPNJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF18F0", Offset = "0x7FEFEF0", VA = "0x187FF18F0")]
	private void AEAGJINBFOK(IEnumerable<KeepsakeInstanceDTO> FEEDCKMLNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1F30", Offset = "0x7FF0530", VA = "0x187FF1F30")]
	private void AGLPMPPAPJI(IEnumerable<KeepsakeCollectionRecordDTO> JHKDEIODCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA410", Offset = "0x7FF8A10", VA = "0x187FFA410")]
	private void KNDBPCCBJOO(IEnumerable<long> HOFGAMBAMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xACAD60", Offset = "0xAC9360", VA = "0x180ACAD60")]
	private void IOBAAPJJHMF(KeepsakeGlobalConfigDTO BLKNNDEJGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAB30", Offset = "0x7FF9130", VA = "0x187FFAB30")]
	private bool LIBKMAEHCLG(DJAEGFIGJOO PFFBPBHCNNM, [Out] Guid KNCBGJEIDNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5F30", Offset = "0x7FF4530", VA = "0x187FF5F30")]
	private bool EGLKBHDLKKN([Out] Guid KNCBGJEIDNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8650", Offset = "0x7FF6C50", VA = "0x187FF8650")]
	private bool IBMNKLPKKEF(Guid LDPNMFLPJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FF92D0", Offset = "0x7FF78D0", VA = "0x187FF92D0")]
	private IEnumerable<Guid> KAFPODDKCLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2B00", Offset = "0x7FF1100", VA = "0x187FF2B00")]
	private IEnumerable<KeepsakeInstanceDTO> BGDELFOEGIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FF39D0", Offset = "0x7FF1FD0", VA = "0x187FF39D0")]
	private void BNMACNBAMKK(Guid LDPNMFLPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5CA0", Offset = "0x7FF42A0", VA = "0x187FF5CA0")]
	private bool EDGBKNPPAEF(Guid LDPNMFLPJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FF76F0", Offset = "0x7FF5CF0", VA = "0x187FF76F0")]
	private void GHMLJGOJEIF(Guid LDPNMFLPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5E50", Offset = "0x7FF4450", VA = "0x187FF5E50")]
	private void EDNJDIMKLNH(DJAEGFIGJOO BAIHHLMIMOE, int KCIAAEBOAON, Dictionary<DJAEGFIGJOO, int> MCENLMGDFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAA40", Offset = "0x7FF9040", VA = "0x187FFAA40")]
	private int LGKPELJAMON(DJAEGFIGJOO PFFBPBHCNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6770", Offset = "0x7FF4D70", VA = "0x187FF6770")]
	private void ENEOGPLCKFO(KeepsakeInstanceDTO KAIKAKHPOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB000", Offset = "0x7FF9600", VA = "0x187FFB000")]
	private void MLBOENDDKGH(KeepsakeInstanceDTO KAIKAKHPOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA4E0", Offset = "0x7FF8AE0", VA = "0x187FFA4E0")]
	private void LBNFLJGHENO(Guid LDPNMFLPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2270", Offset = "0x7FF0870", VA = "0x187FF2270")]
	private void EJCLFFIFLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB580", Offset = "0x7FF9B80", VA = "0x187FFB580")]
	private void NCMHGEAFMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAE40", Offset = "0x7FF9440", VA = "0x187FFAE40")]
	private void LLJPHGEMHAL(DLDIJLNEIBF HFPKGHFHAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2270", Offset = "0x7FF0870", VA = "0x187FF2270")]
	private void GBCFEOCABGJ(NFKKOLFFFBJ ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2270", Offset = "0x7FF0870", VA = "0x187FF2270")]
	private void AOKNGKJBDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7EC0", Offset = "0x7FF64C0", VA = "0x187FF7EC0")]
	private void GMMECOGHMCN(float MMEJKCJEAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2BC0", Offset = "0x7FF11C0", VA = "0x187FF2BC0")]
	private void BGFCMDGHHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9030", Offset = "0x7FF7630", VA = "0x187FF9030")]
	private bool JIHLIBIHMNN(Guid LDPNMFLPJKL, [Out] string JDCFNJPBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6940", Offset = "0x7FF4F40", VA = "0x187FF6940")]
	private bool EOANAJMEDHN(Guid LDPNMFLPJKL, [Out] KeepsakeCategoryConfigDTO BAIHHLMIMOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4320", Offset = "0x7FF2920", VA = "0x187FF4320")]
	private void DECMLMNGGPF(string GHLKMGHMNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB360", Offset = "0x7FF9960", VA = "0x187FFB360")]
	private bool MPIJIMKBBCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2820", Offset = "0x7FF0E20", VA = "0x187FF2820")]
	private List<long> BFFGJNGGAGK(IEnumerable<KeepsakeRoomDTO> NPBNEGJJBKK, IReadOnlyList<KeepsakeRoomListDTO> BDHBAILNBNI, long MKLOBBGCMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5780", Offset = "0x7FF3D80", VA = "0x187FF5780")]
	private bool EALDILJBGJO(Guid LDPNMFLPJKL, [Out] string NNDNCFBMBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC240", Offset = "0x7FFA840", VA = "0x187FFC240", Slot = "47")]
	public string OKHBPJOOPEF(BOPEDGLNAMN ACBPIDOMBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4710", Offset = "0x7FF2D10", VA = "0x187FF4710", Slot = "49")]
	public string DKLOJMNKOFC(BOPEDGLNAMN ACBPIDOMBHJ, long CDFGHIILPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF22A0", Offset = "0x7FF08A0", VA = "0x187FF22A0", Slot = "48")]
	public string BBBFHMJDKOA(BOPEDGLNAMN ACBPIDOMBHJ, int IIDKALFDCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC2A0", Offset = "0x7FFA8A0", VA = "0x187FFC2A0")]
	private void ONPOLGMBGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF61C0", Offset = "0x7FF47C0", VA = "0x187FF61C0")]
	private void ELCDKMOMMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4020", Offset = "0x7FF2620", VA = "0x187FF4020")]
	private BOPEDGLNAMN DAHPMFGIKFK(LAHFMAFBGDD HLGGADCGNDK)
	{
		return default(BOPEDGLNAMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4040", Offset = "0x7FF2640", VA = "0x187FF4040")]
	private BOPEDGLNAMN DEBNIHPPNFL(LAHFMAFBGDD HLGGADCGNDK)
	{
		return default(BOPEDGLNAMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3A60", Offset = "0x7FF2060", VA = "0x187FF3A60")]
	internal static string CAPIBCFPMCH(FBOIPGFCCKN AIOFBMIEPCB, string ECHJJJNKKBJ, bool FPAJOECIDDM, int CDCJJGKGHAO, int PAODJICHAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5320", Offset = "0x7FF3920", VA = "0x187FF5320", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4400", Offset = "0x7FF2A00", VA = "0x187FF4400")]
	private JDKMKDKEGJC DENMLAOJEOK(KNOJHPOMDED ODLCNMKCNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6C20", Offset = "0x7FF5220", VA = "0x187FF6C20")]
	private JHFENBPHJMD FELLCJJPMDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9BA0", Offset = "0x7FF81A0", VA = "0x187FF9BA0")]
	private Task KHPDGIINFPC(JBAPOOINJKO MMCAOMENGOP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6B10", Offset = "0x7FF5110", VA = "0x187FF6B10")]
	[AsyncStateMachine(typeof(JLHKJEKODBA))]
	private Task EOPBOEJHOEM(JBAPOOINJKO MMCAOMENGOP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6DE0", Offset = "0x7FF53E0", VA = "0x187FF6DE0")]
	private Task FFFBDNHFDDJ(JBAPOOINJKO MMCAOMENGOP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FF17C0", Offset = "0x7FEFDC0", VA = "0x187FF17C0")]
	[AsyncStateMachine(typeof(HBAHALAGDNI))]
	private Task AANEGBPAOKK(string CJIMOMNMAGD, TimeSpan KDMPGHGOLIP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFBE20", Offset = "0x7FFA420", VA = "0x187FFBE20")]
	[CompilerGenerated]
	private void OCGFMDFLGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2180", Offset = "0x7FF0780", VA = "0x187FF2180")]
	[CompilerGenerated]
	private void AJMHOIIDLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3C40", Offset = "0x7FF2240", VA = "0x187FF3C40")]
	[CompilerGenerated]
	private bool CGHLBJILKOF(KeepsakeInstanceDTO POMHCCBBBGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3420", Offset = "0x7FF1A20", VA = "0x187FF3420")]
	[CompilerGenerated]
	private EHBLMFNEKIG<Dictionary<DJAEGFIGJOO, int>> BGHBIMGHNAB(Dictionary<Guid, DJAEGFIGJOO> ACENLJAOFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF32B0", Offset = "0x7FF18B0", VA = "0x187FF32B0")]
	[CompilerGenerated]
	private EHBLMFNEKIG<Dictionary<DJAEGFIGJOO, int>> BGHACFELAJC(Dictionary<Guid, DJAEGFIGJOO> ACENLJAOFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9900", Offset = "0x7FF7F00", VA = "0x187FF9900")]
	[CompilerGenerated]
	private bool KENCKPPMKIJ(KeepsakeRoomListDTO POMHCCBBBGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FFBE40", Offset = "0x7FFA440", VA = "0x187FFBE40")]
	[CompilerGenerated]
	private bool OHMIEHMACKM(KeepsakeInstanceDTO POMHCCBBBGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC0B0", Offset = "0x7FFA6B0", VA = "0x187FFC0B0")]
	[CompilerGenerated]
	private void OKACJHJFNDF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DJAEGFIGJOO, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JMMJIFKPGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8FD0", Offset = "0x7FF75D0", VA = "0x187FF8FD0")]
	[CompilerGenerated]
	private void JHIKGKLFHOD(string NNDNCFBMBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FF8490", Offset = "0x7FF6A90", VA = "0x187FF8490")]
	[CompilerGenerated]
	private Task HINOLAMAHJN(CancellationToken KPHOKEINLFO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, FJDHHPBBPOJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class MIJGOAKMEOD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
				public MIJGOAKMEOD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7FF1200", Offset = "0x7FEF800", VA = "0x187FF1200")]
				internal bool FABNHJGEAON(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7FF1200", Offset = "0x7FEF800", VA = "0x187FF1200")]
				internal bool AMOCFDJGBEK(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7FF0FB0", Offset = "0x7FEF5B0", VA = "0x187FF0FB0")]
			public bool HIHOBNAJDOM(string HPIBAEHAMPI, [Out] KeepsakeTheme EMCPFDAGEII)
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0F30", Offset = "0x7FEF530", VA = "0x187FF0F30")]
		[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
		internal static void PCDILHPDLBD(DCNOMJHNEOK FAIEEFHMPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC6D2F0", Offset = "0xC6B8F0", VA = "0x180C6D2F0")]
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
