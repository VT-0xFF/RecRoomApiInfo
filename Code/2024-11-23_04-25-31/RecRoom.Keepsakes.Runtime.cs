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
		[Cpp2IlInjected.Address(RVA = "0x6E38D40", Offset = "0x6E37740", VA = "0x186E38D40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DCPODNLHHFB : IComparer<JLDMECKKCCB>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LKIJBDCGMLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JLDMECKKCCB x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public JLDMECKKCCB y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LKIJBDCGMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x914340", Offset = "0x912D40", VA = "0x180914340")]
		internal bool ALIPGLGIPOA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17AC950", Offset = "0x17AB350", VA = "0x1817AC950")]
		internal bool FENPONJLDLG(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x914340", Offset = "0x912D40", VA = "0x180914340")]
		internal bool BJCMLKAGEPO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17AC950", Offset = "0x17AB350", VA = "0x1817AC950")]
		internal bool OMLFECHFLFD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> EEMKIIOBPEM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public DCPODNLHHFB(List<KeepsakeCategoryThemePair> NBFJIAOFEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E285C0", Offset = "0x6E26FC0", VA = "0x186E285C0", Slot = "4")]
	public int Compare(JLDMECKKCCB PMBJFHIMJKC, JLDMECKKCCB HBABDGBANAP)
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
		public JLDMECKKCCB KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AOOPPFIKPBO]
public class GOPCBCOHKCF : BKNGICPKNMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NOMPIEALIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JLDMECKKCCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NOMPIEALIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E38160", Offset = "0x6E36B60", VA = "0x186E38160")]
		internal BJOGDIODDMJ<Guid> BJDMBKPONCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E382C0", Offset = "0x6E36CC0", VA = "0x186E382C0")]
		internal void HIJPJLHFEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E38100", Offset = "0x6E36B00", VA = "0x186E38100")]
		internal void APENBAHANJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E382F0", Offset = "0x6E36CF0", VA = "0x186E382F0")]
		internal void HJHLHPFNEMO(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E38700", Offset = "0x6E37100", VA = "0x186E38700")]
		internal void LLEFMDPINJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class COFCBDMOHKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GOPCBCOHKCF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public COFCBDMOHKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E280C0", Offset = "0x6E26AC0", VA = "0x186E280C0")]
		internal void OEGGDFAIFCG(JFOGGMONBBE response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E28060", Offset = "0x6E26A60", VA = "0x186E28060")]
		internal void ADPMIJOMPHH(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LIGGACHJCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LIGGACHJCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E37550", Offset = "0x6E35F50", VA = "0x186E37550")]
		internal bool JFNHDHBIEHM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MFGHCBCLANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JLDMECKKCCB? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MFGHCBCLANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E37990", Offset = "0x6E36390", VA = "0x186E37990")]
		internal void PHKCLCNNDJC(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E27CA0", Offset = "0x6E266A0", VA = "0x186E27CA0")]
		internal void GDLFMCBMDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E37690", Offset = "0x6E36090", VA = "0x186E37690")]
		internal BJOGDIODDMJ<IEnumerable<Guid>> GCPADHNFNDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A46020", Offset = "0x6A44A20", VA = "0x186A46020")]
		internal bool GJGDBJOOJOE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LDMAHNAJFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MFGHCBCLANI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LDMAHNAJFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E37410", Offset = "0x6E35E10", VA = "0x186E37410")]
		internal BJOGDIODDMJ<IEnumerable<Guid>> NBLLHOGBAGG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EBOCLDCHEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LDMAHNAJFKK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EBOCLDCHEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E28A60", Offset = "0x6E27460", VA = "0x186E28A60")]
		internal bool BDKINKONFKG(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HJHOKBJHMEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EBOCLDCHEEM CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HJHOKBJHMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E36DB0", Offset = "0x6E357B0", VA = "0x186E36DB0")]
		internal bool ODIPGBIIMMP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class CMCGJKHNCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CMCGJKHNCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E27ED0", Offset = "0x6E268D0", VA = "0x186E27ED0")]
		internal BJOGDIODDMJ<IEnumerable<Guid>> GNFKPPFKAKO(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E28040", Offset = "0x6E26A40", VA = "0x186E28040")]
		internal bool PJLHMGHONAD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AOBIBBCKHPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GOPCBCOHKCF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AOBIBBCKHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E27CD0", Offset = "0x6E266D0", VA = "0x186E27CD0")]
		internal void IMHOHIHPPMI(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E27CA0", Offset = "0x6E266A0", VA = "0x186E27CA0")]
		internal void IDLAAKKAPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E279B0", Offset = "0x6E263B0", VA = "0x186E279B0")]
		internal BJOGDIODDMJ<Dictionary<Guid, JLDMECKKCCB>> AIKFFLOGPBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A46020", Offset = "0x6A44A20", VA = "0x186A46020")]
		internal bool CCFHGLMJHOO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EBHDKOFHJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EBHDKOFHJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E288B0", Offset = "0x6E272B0", VA = "0x186E288B0")]
		internal BJOGDIODDMJ<Dictionary<Guid, JLDMECKKCCB>> CNMNONAANEJ(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PGNIMAGGHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PGNIMAGGHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E38A50", Offset = "0x6E37450", VA = "0x186E38A50")]
		internal bool JLDJKIBHGKL(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E38900", Offset = "0x6E37300", VA = "0x186E38900")]
		internal KeyValuePair<Guid, JLDMECKKCCB> IPBOEBBKBDE(Guid instanceId)
		{
			return default(KeyValuePair<Guid, JLDMECKKCCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class EJGGDBOPLAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EJGGDBOPLAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D56410", Offset = "0x1D54E10", VA = "0x181D56410")]
		internal bool OGCGPLNBHIN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DCMAILNJCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DCMAILNJCDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D56410", Offset = "0x1D54E10", VA = "0x181D56410")]
		internal bool OBLMBOPFEMA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IHDAOBHFLMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IHDAOBHFLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E36E60", Offset = "0x6E35860", VA = "0x186E36E60")]
		internal BJOGDIODDMJ<Dictionary<Guid, JLDMECKKCCB>> ALAGLBGLIKG(Dictionary<Guid, JLDMECKKCCB> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E28040", Offset = "0x6E26A40", VA = "0x186E28040")]
		internal bool ODHPGKFBAOD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JGDGPPGCJPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JGDGPPGCJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E370E0", Offset = "0x6E35AE0", VA = "0x186E370E0")]
		internal bool JGFOKADBDBO(KeyValuePair<Guid, JLDMECKKCCB> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MOCJEJGHKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, JLDMECKKCCB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MOCJEJGHKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E37A20", Offset = "0x6E36420", VA = "0x186E37A20")]
		internal KeyValuePair<JLDMECKKCCB, int> CGLBGCBDFNL(JLDMECKKCCB category)
		{
			return default(KeyValuePair<JLDMECKKCCB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PIACFKLKEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JLDMECKKCCB category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PIACFKLKEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x992AD0", Offset = "0x9914D0", VA = "0x180992AD0")]
		internal bool GCGGFGCANJG(JLDMECKKCCB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DCDIHDPBOII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, JLDMECKKCCB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DCDIHDPBOII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E28470", Offset = "0x6E26E70", VA = "0x186E28470")]
		internal KeyValuePair<JLDMECKKCCB, int> EBDIMLGJMHB(JLDMECKKCCB category)
		{
			return default(KeyValuePair<JLDMECKKCCB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JNGJCEOPMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JLDMECKKCCB category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JNGJCEOPMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x992AD0", Offset = "0x9914D0", VA = "0x180992AD0")]
		internal bool DFPELLOPAIA(JLDMECKKCCB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PGBACGKLKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PGBACGKLKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E38810", Offset = "0x6E37210", VA = "0x186E38810")]
		internal bool LODEPBFEBBN(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E38730", Offset = "0x6E37130", VA = "0x186E38730")]
		internal bool EMIPOLGLMCE(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E387F0", Offset = "0x6E371F0", VA = "0x186E387F0")]
		internal bool PKPJJHACBLF(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E387F0", Offset = "0x6E371F0", VA = "0x186E387F0")]
		internal bool HNHPMHENFBG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KOKOKKHJAEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KOKOKKHJAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0CD10", Offset = "0xA0B710", VA = "0x180A0CD10")]
		internal bool NFLOBNOLCHB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LOJKOGKPBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LOJKOGKPBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E37570", Offset = "0x6E35F70", VA = "0x186E37570")]
		internal bool OJFHCNDFEJJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CD7570", Offset = "0x1CD5F70", VA = "0x181CD7570")]
		internal bool CNPIEHBJNFF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ELDDCGJAJCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ELDDCGJAJCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E28B90", Offset = "0x6E27590", VA = "0x186E28B90")]
		internal bool FDNMNAHECKC(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GPIPIADBCAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GPIPIADBCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0CD10", Offset = "0xA0B710", VA = "0x180A0CD10")]
		internal bool FBOFJFFLLIK(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MEBENAJCKDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MEBENAJCKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E37630", Offset = "0x6E36030", VA = "0x186E37630")]
		internal bool ICOBJJCKJMG(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MBFNJPGMLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JLDMECKKCCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MBFNJPGMLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x19BC080", Offset = "0x19BAA80", VA = "0x1819BC080")]
		internal bool GNKPFIMANHF(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KCMMEKBGKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KCMMEKBGKIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E37160", Offset = "0x6E35B60", VA = "0x186E37160")]
		internal bool LNKOACNEIIL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DPGDGLGGEGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JLDMECKKCCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DPGDGLGGEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E28870", Offset = "0x6E27270", VA = "0x186E28870")]
		internal bool ECEAGGKHBNF(KeyValuePair<Guid, JLDMECKKCCB> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EOGPAJEPMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JLDMECKKCCB newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EOGPAJEPMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x19BC080", Offset = "0x19BAA80", VA = "0x1819BC080")]
		internal bool CFNICMNIKKL(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IJNCECIMKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IJNCECIMKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E37060", Offset = "0x6E35A60", VA = "0x186E37060")]
		internal bool JGJLMILIGOH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class BMOHCDEJBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BMOHCDEJBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E27DE0", Offset = "0x6E267E0", VA = "0x186E27DE0")]
		internal bool JHIGCEDEIFI(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BDGNMNCKPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public BMOHCDEJBEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BDGNMNCKPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E27D60", Offset = "0x6E26760", VA = "0x186E27D60")]
		internal bool IKGHEHJLFLE(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NMDEAGLNDLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LKMBJDMKDPJ args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E37B70", Offset = "0x6E36570", VA = "0x186E37B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E380A0", Offset = "0x6E36AA0", VA = "0x186E380A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct GOHHFLBNBIN : IAsyncStateMachine
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
		public GOPCBCOHKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E28C20", Offset = "0x6E27620", VA = "0x186E28C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E28EC0", Offset = "0x6E278C0", VA = "0x186E28EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime CFMKBDFMMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BOLEJOOMEKF NAOGJHMKMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AKJMFGKNPOO OJCNHOEGAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MMMLIOHBHGL PNJAIDEECJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IFPCPBEPEBN MPOPIAPIMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GCBBJGEAAKC GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NAKJNNPFOKN DCHAKOGAAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DBGOGJCAPOP EHBONKLPEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OALDAIIAOFB BPIBNBKGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DHEFIBKHIFN IBODIJDAFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FKHGPLCMANB APPKJADNEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OCFLCBNDEHD AMLHAEKDDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DHKCELMFKHP EPKHBHHNPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EACACNPLBGM HLMAEBEBHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MKDIGONPDGF KDKHLEEPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly PLCEPPOHCLE<KeepsakesConfig.KeepsakesOptions> JKPMAFPDDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CLNMMCDHJBN LNJEDLFHNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> ICOIFAFKJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> MJNPHOBKNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> FGFEMOIBCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<JLDMECKKCCB, int> BGMHJFLPOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> EKNKEJODAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable ODPONMFIEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task MKILDKNKKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BJOGDIODDMJ<Guid> PFNILBOHDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? AFNEINIIIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO KGPHFCDBNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BJOGDIODDMJ<KeepsakeProgressionEventInstancesDTO> MCAPBECBBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<JLDMECKKCCB, KeepsakeCategoryConfigDTO> LBKKIDEAMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO LPJNFAOMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> GGDANCHHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> CBDKOJDOCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> ADEDABLMPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> GALCAAOOGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> JMNNOCOPFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> KJKIJCAEOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> LMGGLGOODIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> OGOONPOANBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GAOBHLPHEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DEMDGDEECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> MPMDCGBPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> MHDEAAHGBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime OGHEMELGFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable EGMOJCOMLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, JLDMECKKCCB> PADFAHBBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<JLDMECKKCCB, int> ABAEOCBIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> NBFJIAOFEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private DCPODNLHHFB IHNBGIFPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NAGPPLOBGIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PLCECBEMAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x964220", Offset = "0x962C20", VA = "0x180964220", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9630A0", Offset = "0x961AA0", VA = "0x1809630A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AFKNFLFFGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E29030", Offset = "0x6E27A30", VA = "0x186E29030", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IOKMNLFHAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E330A0", Offset = "0x6E31AA0", VA = "0x186E330A0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long KNBMEPHBOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E33EE0", Offset = "0x6E328E0", VA = "0x186E33EE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OJPIJOPIBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E321D0", Offset = "0x6E30BD0", VA = "0x186E321D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool HINMCCPFOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E33930", Offset = "0x6E32330", VA = "0x186E33930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> KEOMKEMDJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97E810", Offset = "0x97D210", VA = "0x18097E810", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DNCFGCBGHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9173E0", Offset = "0x915DE0", VA = "0x1809173E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> CECGFKGIJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA557A0", Offset = "0xA541A0", VA = "0x180A557A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> EFLLJLJKDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x97E9A0", Offset = "0x97D3A0", VA = "0x18097E9A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool KOCEIPKGGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C673E0", Offset = "0x1C65DE0", VA = "0x181C673E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> BEPJPEBBKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E32120", Offset = "0x6E30B20", VA = "0x186E32120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E33270", Offset = "0x6E31C70", VA = "0x186E33270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LACNCFDLPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E351F0", Offset = "0x6E33BF0", VA = "0x186E351F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2E480", Offset = "0x6E2CE80", VA = "0x186E2E480", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MEGAHINLODM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A240", Offset = "0x6E28C40", VA = "0x186E2A240", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F730", Offset = "0x6E2E130", VA = "0x186E2F730", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E357E0", Offset = "0x6E341E0", VA = "0x186E357E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GOPCBCOHKCF([CCLEDEMDDDH(null)][NotNull] BOLEJOOMEKF NAOGJHMKMNA, [NotNull][CCLEDEMDDDH(null)] OIJGODLJCJF GFHJCFNDBGP, [NotNull][CCLEDEMDDDH(null)] AKJMFGKNPOO OJCNHOEGAKE, [NotNull][CCLEDEMDDDH(null)] MMMLIOHBHGL PNJAIDEECJB, [CCLEDEMDDDH(null)][NotNull] IFPCPBEPEBN MPOPIAPIMFL, [CCLEDEMDDDH(null)][NotNull] GCBBJGEAAKC GDNLGDEFCDG, [CCLEDEMDDDH(null)][NotNull] NAKJNNPFOKN DCHAKOGAAJF, [NotNull][CCLEDEMDDDH(null)] DBGOGJCAPOP EHBONKLPEJA, [NotNull][CCLEDEMDDDH(null)] AFIFLHJBILJ PPPAPIDLOLG, [NotNull][CCLEDEMDDDH(null)] GBAFANLCLGO NEDMMPIOOJE, [NotNull][CCLEDEMDDDH(null)] OALDAIIAOFB BPIBNBKGNMF, [NotNull][CCLEDEMDDDH(null)] DHEFIBKHIFN IBODIJDAFAH, [NotNull][CCLEDEMDDDH(null)] FKHGPLCMANB APPKJADNEOB, [NotNull][CCLEDEMDDDH(null)] OCFLCBNDEHD AMLHAEKDDJB, [CCLEDEMDDDH(null)][NotNull] DHKCELMFKHP EPKHBHHNPIP, [CCLEDEMDDDH(null)][NotNull] EACACNPLBGM HLMAEBEBHCG, [NotNull][CCLEDEMDDDH(null)] MKDIGONPDGF KDKHLEEPODK, [CCLEDEMDDDH(null)][NotNull] PLCEPPOHCLE<KeepsakesConfig.KeepsakesOptions> JKPMAFPDDOK, [NotNull][CCLEDEMDDDH(null)] CLNMMCDHJBN LNJEDLFHNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E30E90", Offset = "0x6E2F890", VA = "0x186E30E90", Slot = "15")]
	public bool JECBKBCLIAF(List<string> DADBMJBMLLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FEE0", Offset = "0x6E2E8E0", VA = "0x186E2FEE0", Slot = "16")]
	public BJOGDIODDMJ<Guid> IDBOIKPOKBM(JLDMECKKCCB PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E326A0", Offset = "0x6E310A0", VA = "0x186E326A0", Slot = "17")]
	public HGKKEBPLLAP LBALKKEFFBP(Guid ODKODKJAEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F3A0", Offset = "0x6E2DDA0", VA = "0x186E2F3A0", Slot = "18")]
	public HGKKEBPLLAP HDFEENPGLMO(Guid ODKODKJAEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C6B0", Offset = "0x6E2B0B0", VA = "0x186E2C6B0", Slot = "19")]
	public bool DIFFDMDAAGF(Guid ODKODKJAEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E32CD0", Offset = "0x6E316D0", VA = "0x186E32CD0", Slot = "20")]
	public bool LHIPDCIOOBL(Guid ODKODKJAEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A4D0", Offset = "0x6E28ED0", VA = "0x186E2A4D0")]
	public KeepsakeTheme BDFAALLNFBB(Guid ODKODKJAEOJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E2AB80", Offset = "0x6E29580", VA = "0x186E2AB80")]
	public bool CIDGGKKBNCE(JLDMECKKCCB PNCNHDNJJLC, [Out] KeepsakeTheme DOBJKEPNPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E30500", Offset = "0x6E2EF00", VA = "0x186E30500")]
	public List<KeepsakeTheme> IHOAMBOPFPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E344F0", Offset = "0x6E32EF0", VA = "0x186E344F0")]
	public int NGOBHIECNNK(JLDMECKKCCB PNCNHDNJJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CD50", Offset = "0x6E2B750", VA = "0x186E2CD50")]
	public JLDMECKKCCB DMEBHDJMJND(Guid ODKODKJAEOJ)
	{
		return default(JLDMECKKCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C4D0", Offset = "0x6E2AED0", VA = "0x186E2C4D0", Slot = "34")]
	public List<JLDMECKKCCB> DCADGPFKBAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E31B40", Offset = "0x6E30540", VA = "0x186E31B40", Slot = "35")]
	public IComparer<JLDMECKKCCB> KELDOAIANEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E0F0", Offset = "0x6E2CAF0", VA = "0x186E2E0F0", Slot = "32")]
	public string FPPABIPPKKK(JLDMECKKCCB PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E35400", Offset = "0x6E33E00", VA = "0x186E35400", Slot = "33")]
	public string PNDGJIJAIGA(JLDMECKKCCB PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E29A90", Offset = "0x6E28490", VA = "0x186E29A90", Slot = "21")]
	public bool AKBCCFPCDCD(Guid ODKODKJAEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E294F0", Offset = "0x6E27EF0", VA = "0x186E294F0", Slot = "22")]
	public void AJCGOCJDHLL(Guid ODKODKJAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A7A0", Offset = "0x6E291A0", VA = "0x186E2A7A0", Slot = "23")]
	public void BIOMFFBPCGP(JLDMECKKCCB PNCNHDNJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E31180", Offset = "0x6E2FB80", VA = "0x186E31180", Slot = "24")]
	public void JIOJPHDIMEO(Guid ODKODKJAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E29560", Offset = "0x6E27F60", VA = "0x186E29560", Slot = "25")]
	public int AJJBNCGDIND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BFD0", Offset = "0x6E2A9D0", VA = "0x186E2BFD0", Slot = "31")]
	public BJOGDIODDMJ<IEnumerable<Guid>> COPOCPLAIPC(long NPGHGEFGHLA, long FBDCBEPJOOA, JLDMECKKCCB? PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F7D0", Offset = "0x6E2E1D0", VA = "0x186E2F7D0", Slot = "30")]
	public BJOGDIODDMJ<IEnumerable<Guid>> HFEOAKINIOD(long NPGHGEFGHLA, long FBDCBEPJOOA, JLDMECKKCCB? PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E34140", Offset = "0x6E32B40", VA = "0x186E34140", Slot = "54")]
	public BJOGDIODDMJ<Dictionary<Guid, JLDMECKKCCB>> NGILIFLKKPB(long NPGHGEFGHLA, long FBDCBEPJOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A610", Offset = "0x6E29010", VA = "0x186E2A610", Slot = "55")]
	public BJOGDIODDMJ<Dictionary<Guid, JLDMECKKCCB>> BDOHMCIIOAI(long NPGHGEFGHLA, long FBDCBEPJOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E33320", Offset = "0x6E31D20", VA = "0x186E33320", Slot = "26")]
	public BJOGDIODDMJ<int> MLFJICFBFPL(long NPGHGEFGHLA, long FBDCBEPJOOA, JLDMECKKCCB? PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DDE0", Offset = "0x6E2C7E0", VA = "0x186E2DDE0", Slot = "27")]
	public BJOGDIODDMJ<int> FFJLMDAGCIH(long NPGHGEFGHLA, long FBDCBEPJOOA, JLDMECKKCCB? PNCNHDNJJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E32920", Offset = "0x6E31320", VA = "0x186E32920", Slot = "28")]
	public BJOGDIODDMJ<Dictionary<JLDMECKKCCB, int>> LCKFKDCJIDF(long NPGHGEFGHLA, long FBDCBEPJOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E35060", Offset = "0x6E33A60", VA = "0x186E35060", Slot = "29")]
	public BJOGDIODDMJ<Dictionary<JLDMECKKCCB, int>> OGCPBOKLPJH(long NPGHGEFGHLA, long FBDCBEPJOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E33210", Offset = "0x6E31C10", VA = "0x186E33210", Slot = "37")]
	public bool LNIEOPIJIOK(long NPGHGEFGHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E313C0", Offset = "0x6E2FDC0", VA = "0x186E313C0", Slot = "56")]
	public bool JJJCODIHNEH(long NPGHGEFGHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E29190", Offset = "0x6E27B90", VA = "0x186E29190", Slot = "38")]
	public bool AGOIBNCJOFC(long NPGHGEFGHLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E348E0", Offset = "0x6E332E0", VA = "0x186E348E0", Slot = "57")]
	public bool NPDGKCAKCHM(long NPGHGEFGHLA, [Out] NHIJFNNDEAD KLKBMGJICGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E30CF0", Offset = "0x6E2F6F0", VA = "0x186E30CF0", Slot = "39")]
	public bool JCIELCMCFLH(long NHDGKODKBAL, [Out] DateTime LJFCOKCIKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C810", Offset = "0x6E2B210", VA = "0x186E2C810", Slot = "40")]
	public long DIPHIDPIHCO(long NHDGKODKBAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E29080", Offset = "0x6E27A80", VA = "0x186E29080", Slot = "41")]
	public long AENIMGMPHFF(long NPGHGEFGHLA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F9E0", Offset = "0x6E2E3E0", VA = "0x186E2F9E0", Slot = "42")]
	public int HNDEKCLLMAD(long NHDGKODKBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DD00", Offset = "0x6E2C700", VA = "0x186E2DD00", Slot = "43")]
	public bool FDBGJNJIPJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E34670", Offset = "0x6E33070", VA = "0x186E34670", Slot = "44")]
	public bool NIJFOBCBELJ(long NHDGKODKBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E2EEC0", Offset = "0x6E2D8C0", VA = "0x186E2EEC0", Slot = "45")]
	public IEnumerable<long> HAHMILFOFOK(long NHDGKODKBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E33160", Offset = "0x6E31B60", VA = "0x186E33160", Slot = "46")]
	public int LMKCJLEMFNC(long NHDGKODKBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E29230", Offset = "0x6E27C30", VA = "0x186E29230", Slot = "50")]
	public long AIDCIFEDLKO(long LOODDCFCOON)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D660", Offset = "0x6E2C060", VA = "0x186E2D660", Slot = "51")]
	public JLDMECKKCCB ELCMDEJPACA()
	{
		return default(JLDMECKKCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E34010", Offset = "0x6E32A10", VA = "0x186E34010")]
	private bool NFKAPHHNCNN(Guid ODKODKJAEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E8D0", Offset = "0x6E2D2D0", VA = "0x186E2E8D0")]
	private void GMKNDCIJILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E335D0", Offset = "0x6E31FD0", VA = "0x186E335D0")]
	private JLDMECKKCCB MMNILPPJDOK()
	{
		return default(JLDMECKKCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E31420", Offset = "0x6E2FE20", VA = "0x186E31420")]
	private void JKAJHLCMPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E32D00", Offset = "0x6E31700", VA = "0x186E32D00")]
	private int LIDNJLCCGGO(KeepsakeRoomListDTO OCAMIGNEAPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A140", Offset = "0x6E28B40", VA = "0x186E2A140")]
	private int AKPGIMHDKOM(DateTime LJFKCFFHDLP, DateTime OAOBNOCPEKJ, TimeSpan APAJCDAAAGG, int PIEJPICAJKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A7F0", Offset = "0x6E291F0", VA = "0x186E2A7F0")]
	private void BJGGJLLLOKJ(IEnumerable<KeepsakeInstanceDTO> ICOIFAFKJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E308B0", Offset = "0x6E2F2B0", VA = "0x186E308B0")]
	private void IKNILNFEOLE(IEnumerable<KeepsakeCollectionRecordDTO> FEBEGDHALOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FBC0", Offset = "0x6E2E5C0", VA = "0x186E2FBC0")]
	private void HODOKIJFIAE(IEnumerable<long> IHIEMIGLOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xD7D870", Offset = "0xD7C270", VA = "0x180D7D870")]
	private void AOLAFCPOKFP(KeepsakeGlobalConfigDTO LPJNFAOMHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E35580", Offset = "0x6E33F80", VA = "0x186E35580")]
	private bool POHFACHELDJ(JLDMECKKCCB PNCNHDNJJLC, [Out] Guid JNDJKKAMHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C610", Offset = "0x6E2B010", VA = "0x186E2C610")]
	private bool DHGOENBNBCL([Out] Guid JNDJKKAMHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E33FB0", Offset = "0x6E329B0", VA = "0x186E33FB0")]
	private bool NFFCBAOEKPF(Guid ODKODKJAEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E2C380", Offset = "0x6E2AD80", VA = "0x186E2C380")]
	private IEnumerable<Guid> DBAHMEMOHGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E31A80", Offset = "0x6E30480", VA = "0x186E31A80")]
	private IEnumerable<KeepsakeInstanceDTO> KCMHHIPFKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E338A0", Offset = "0x6E322A0", VA = "0x186E338A0")]
	private void MNFANCAGLBG(Guid ODKODKJAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DF30", Offset = "0x6E2C930", VA = "0x186E2DF30")]
	private bool FHJCOMCFMHM(Guid ODKODKJAEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D330", Offset = "0x6E2BD30", VA = "0x186E2D330")]
	private void EAHEAFCPKOO(Guid ODKODKJAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E2AA80", Offset = "0x6E29480", VA = "0x186E2AA80")]
	private void CADCMIEIMBJ(JLDMECKKCCB PJIBCLIGOPL, int HOMLNGKABCJ, Dictionary<JLDMECKKCCB, int> HHDDELBNGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E000", Offset = "0x6E2CA00", VA = "0x186E2E000")]
	private int FMCBIIHOGDO(JLDMECKKCCB PNCNHDNJJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D9C0", Offset = "0x6E2C3C0", VA = "0x186E2D9C0")]
	private void EMFHMGNJNKO(KeepsakeInstanceDTO PDNKDCEKBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E270", Offset = "0x6E2CC70", VA = "0x186E2E270")]
	private void GKLBIDIIKJD(KeepsakeInstanceDTO PDNKDCEKBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E34C90", Offset = "0x6E33690", VA = "0x186E34C90")]
	private void OGAGPODGDKJ(Guid ODKODKJAEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A4A0", Offset = "0x6E28EA0", VA = "0x186E2A4A0")]
	private void JCFGHOBEIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CEB0", Offset = "0x6E2B8B0", VA = "0x186E2CEB0")]
	private void DNIFAHHOFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F970", Offset = "0x6E2E370", VA = "0x186E2F970")]
	private void HMNBGMJKNIP(PPGGANEOPEN JFBLNKBHMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A4A0", Offset = "0x6E28EA0", VA = "0x186E2A4A0")]
	private void BBBJIGGAMIK(JKDMAJFHDGO BBNKFKDCOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A4A0", Offset = "0x6E28EA0", VA = "0x186E2A4A0")]
	private void DJHFOGNMFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E2BC30", Offset = "0x6E2A630", VA = "0x186E2BC30")]
	private void CJJNEGLNPGD(float BCADOEPDABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E33940", Offset = "0x6E32340", VA = "0x186E33940")]
	private void NCOADDNCKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E30AF0", Offset = "0x6E2F4F0", VA = "0x186E30AF0")]
	private bool JAIPLEPNEMK(Guid ODKODKJAEOJ, [Out] string HKIGIKBCMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F0A0", Offset = "0x6E2DAA0", VA = "0x186E2F0A0")]
	private bool HAIDNJNOADE(Guid ODKODKJAEOJ, [Out] KeepsakeCategoryConfigDTO PJIBCLIGOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E34800", Offset = "0x6E33200", VA = "0x186E34800")]
	private void NMLILDKHPEN(string FBNKCILBNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E28F20", Offset = "0x6E27920", VA = "0x186E28F20")]
	private bool AAIEEODCHPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E323F0", Offset = "0x6E30DF0", VA = "0x186E323F0")]
	private IEnumerable<long> KOODELDMFOH(IEnumerable<KeepsakeRoomDTO> BHDKAFONCJC, IEnumerable<KeepsakeRoomListDTO> DJJLIJOMPDO, long NHDGKODKBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E31C00", Offset = "0x6E30600", VA = "0x186E31C00")]
	private bool KFBJEBFBDBF(Guid ODKODKJAEOJ, [Out] string BHAOKKINJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E31120", Offset = "0x6E2FB20", VA = "0x186E31120", Slot = "47")]
	public string JIBMCINJJNF(FCKABMOAEOI DHAMIKJOIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E29D20", Offset = "0x6E28720", VA = "0x186E29D20", Slot = "49")]
	public string AKHGKEEPGPP(FCKABMOAEOI DHAMIKJOIIE, long NPGHGEFGHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E32B30", Offset = "0x6E31530", VA = "0x186E32B30", Slot = "48")]
	public string LDICPCDMMJI(FCKABMOAEOI DHAMIKJOIIE, int BKLDHKBBAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2AD60", Offset = "0x6E29760", VA = "0x186E2AD60")]
	private void CIGOOFGHPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D4D0", Offset = "0x6E2BED0", VA = "0x186E2D4D0")]
	private void ELCDLLKPHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DFE0", Offset = "0x6E2C9E0", VA = "0x186E2DFE0")]
	private FCKABMOAEOI FIPAHKCKDNK(BBCMLHEBPLG GPBNKPLPPCL)
	{
		return default(FCKABMOAEOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E31A60", Offset = "0x6E30460", VA = "0x186E31A60")]
	private FCKABMOAEOI KBDMNEIMPJB(BBCMLHEBPLG GPBNKPLPPCL)
	{
		return default(FCKABMOAEOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E32EA0", Offset = "0x6E318A0", VA = "0x186E32EA0")]
	internal static string LKKCLLIBNPJ(JFOGGMONBBE EDNLPNKDDAE, string FDAKDMFPDAP, bool DHOAOGLJOCA, int JJLCAAEOFBN, int EHDCIPNJPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E2CED0", Offset = "0x6E2B8D0", VA = "0x186E2CED0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E35120", Offset = "0x6E33B20", VA = "0x186E35120")]
	private ICNNFOGCALN OKNCEINMCMI(OGOAPNICIIH FONFDDLBDFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A2E0", Offset = "0x6E28CE0", VA = "0x186E2A2E0")]
	private LFIFNCDGBCI BAGJJGCFHJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E520", Offset = "0x6E2CF20", VA = "0x186E2E520")]
	private Task GLIACGDBDNM(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E29980", Offset = "0x6E28380", VA = "0x186E29980")]
	[AsyncStateMachine(typeof(NMDEAGLNDLJ))]
	private Task AJMJPDHCBNA(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E32C00", Offset = "0x6E31600", VA = "0x186E32C00")]
	private Task LENKHCBLDGA(LKMBJDMKDPJ LPLPEHNKFMM, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E2ED90", Offset = "0x6E2D790", VA = "0x186E2ED90")]
	[AsyncStateMachine(typeof(GOHHFLBNBIN))]
	private Task GNLJFLEPCNO(string FCMDIEEAPHD, TimeSpan FFBJJPKIMEH, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E33080", Offset = "0x6E31A80", VA = "0x186E33080")]
	[CompilerGenerated]
	private void LLJPJCLDMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E351A0", Offset = "0x6E33BA0", VA = "0x186E351A0")]
	[CompilerGenerated]
	private void PDCCMJKGNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FDE0", Offset = "0x6E2E7E0", VA = "0x186E2FDE0")]
	[CompilerGenerated]
	private bool IBLCOOCGJFF(KeepsakeInstanceDTO PMBJFHIMJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E35290", Offset = "0x6E33C90", VA = "0x186E35290")]
	[CompilerGenerated]
	private BJOGDIODDMJ<Dictionary<JLDMECKKCCB, int>> PMMOEOJDCDP(Dictionary<Guid, JLDMECKKCCB> DKAMPBGAEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E2DB90", Offset = "0x6E2C590", VA = "0x186E2DB90")]
	[CompilerGenerated]
	private BJOGDIODDMJ<Dictionary<JLDMECKKCCB, int>> FADLLLIHEPD(Dictionary<Guid, JLDMECKKCCB> DKAMPBGAEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2AB60", Offset = "0x6E29560", VA = "0x186E2AB60")]
	[CompilerGenerated]
	private bool CECHLKJKNJP(KeepsakeRoomListDTO PMBJFHIMJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E2F270", Offset = "0x6E2DC70", VA = "0x186E2F270")]
	[CompilerGenerated]
	private bool HDEFKNJABKC(KeepsakeInstanceDTO PMBJFHIMJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E32260", Offset = "0x6E30C60", VA = "0x186E32260")]
	[CompilerGenerated]
	private void KKAHKNLPJHA(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<JLDMECKKCCB, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> BFGLEBJGKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E30E30", Offset = "0x6E2F830", VA = "0x186E30E30")]
	[CompilerGenerated]
	private void JDCBDGBLGFA(string BHAOKKINJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E2FC20", Offset = "0x6E2E620", VA = "0x186E2FC20")]
	[CompilerGenerated]
	private Task IAIINCFJOLD(CancellationToken BPEFHOGJDOF)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, PLCEPPOHCLE<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class EPLCNNBALDK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
				public EPLCNNBALDK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6E28BF0", Offset = "0x6E275F0", VA = "0x186E28BF0")]
				internal bool FBBLLCFMKDO(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6E28BF0", Offset = "0x6E275F0", VA = "0x186E28BF0")]
				internal bool ELFJOCBHMPD(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6E37240", Offset = "0x6E35C40", VA = "0x186E37240")]
			public bool AFEBMJCLLJD(string NALOOEBJCJE, [Out] KeepsakeTheme DOBJKEPNPOK)
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E371C0", Offset = "0x6E35BC0", VA = "0x186E371C0")]
		[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
		internal static void EHEFGOAOAHF(KNPHAFHLPCE DNJEODDCEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
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
