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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1D10", Offset = "0x6BD0710", VA = "0x186BD1D10", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IPNGCELDDMC : IComparer<GAPPDCPCNCP>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class ILONKHKCANN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GAPPDCPCNCP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GAPPDCPCNCP y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ILONKHKCANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x11D0020", Offset = "0x11CEA20", VA = "0x1811D0020")]
		internal bool EJBAOEODPMO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16860B0", Offset = "0x1684AB0", VA = "0x1816860B0")]
		internal bool LNBBOPMBEIH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x11D0020", Offset = "0x11CEA20", VA = "0x1811D0020")]
		internal bool PGFOODAFADA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x16860B0", Offset = "0x1684AB0", VA = "0x1816860B0")]
		internal bool CCKCOJOIMHO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> BMIFNOMNLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public IPNGCELDDMC(List<KeepsakeCategoryThemePair> CNJBBMFICPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0AD0", Offset = "0x6BCF4D0", VA = "0x186BD0AD0", Slot = "4")]
	public int Compare(GAPPDCPCNCP OFCNMBDJPHM, GAPPDCPCNCP CONCKFNNMJO)
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
		public GAPPDCPCNCP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DEKINLCKNLM]
public class DNHBBPBJEAC : IDLEPFJPCFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BDFCGLCDBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GAPPDCPCNCP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BDFCGLCDBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0F90", Offset = "0x6BBF990", VA = "0x186BC0F90")]
		internal HABLMKCEIGL<Guid> POJKNDKOJJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0F30", Offset = "0x6BBF930", VA = "0x186BC0F30")]
		internal void LOIODCGNLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0AC0", Offset = "0x6BBF4C0", VA = "0x186BC0AC0")]
		internal void BABMGGFBMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0B20", Offset = "0x6BBF520", VA = "0x186BC0B20")]
		internal void EEMGGNNMIFA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0F60", Offset = "0x6BBF960", VA = "0x186BC0F60")]
		internal void NINHEAEBPDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HFOGMJANJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DNHBBPBJEAC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HFOGMJANJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD03D0", Offset = "0x6BCEDD0", VA = "0x186BD03D0")]
		internal void IGBPFJDBOEO(FDHLBFMKGCO response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0370", Offset = "0x6BCED70", VA = "0x186BD0370")]
		internal void ALCCCMPACID(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OBIJDDPBJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OBIJDDPBJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1690", Offset = "0x6BD0090", VA = "0x186BD1690")]
		internal bool MEAOFLHDDBK(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PDEHINCCGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public GAPPDCPCNCP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PDEHINCCGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1A70", Offset = "0x6BD0470", VA = "0x186BD1A70")]
		internal void KKLBADCKDOP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6BC11E0", Offset = "0x6BBFBE0", VA = "0x186BC11E0")]
		internal void LJMIJIHPNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1770", Offset = "0x6BD0170", VA = "0x186BD1770")]
		internal HABLMKCEIGL<IEnumerable<Guid>> DLCINOJKINC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6848600", Offset = "0x6847000", VA = "0x186848600")]
		internal bool MBFDBCFJKHH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FPNFFBJBNFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PDEHINCCGCM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FPNFFBJBNFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0230", Offset = "0x6BCEC30", VA = "0x186BD0230")]
		internal HABLMKCEIGL<IEnumerable<Guid>> NAKHMICJEPM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DAHOCEPODEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FPNFFBJBNFN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DAHOCEPODEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1500", Offset = "0x6BBFF00", VA = "0x186BC1500")]
		internal bool KNDBJPEOHND(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IAHOOBHBIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DAHOCEPODEE CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IAHOOBHBIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6BD07B0", Offset = "0x6BCF1B0", VA = "0x186BD07B0")]
		internal bool EIAOMNMDIEN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FGIBCHLMKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FGIBCHLMKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFDD0", Offset = "0x6BCE7D0", VA = "0x186BCFDD0")]
		internal HABLMKCEIGL<IEnumerable<Guid>> IKHABAJHNKO(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFDB0", Offset = "0x6BCE7B0", VA = "0x186BCFDB0")]
		internal bool CLFAEHKJDCE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CFNDLDNKNAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DNHBBPBJEAC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CFNDLDNKNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1150", Offset = "0x6BBFB50", VA = "0x186BC1150")]
		internal void DNBFFKMEDJM(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC11E0", Offset = "0x6BBFBE0", VA = "0x186BC11E0")]
		internal void FNDHHIJDJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1210", Offset = "0x6BBFC10", VA = "0x186BC1210")]
		internal HABLMKCEIGL<Dictionary<Guid, GAPPDCPCNCP>> IEKOGAMGGID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6848600", Offset = "0x6847000", VA = "0x186848600")]
		internal bool OAHADMMNOJM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IMKLAEKJLFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IMKLAEKJLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0920", Offset = "0x6BCF320", VA = "0x186BD0920")]
		internal HABLMKCEIGL<Dictionary<Guid, GAPPDCPCNCP>> FCBFMLNJEKF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JDHCHGDJNPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JDHCHGDJNPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0ED0", Offset = "0x6BCF8D0", VA = "0x186BD0ED0")]
		internal bool OKGPCIOPBEM(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0D80", Offset = "0x6BCF780", VA = "0x186BD0D80")]
		internal KeyValuePair<Guid, GAPPDCPCNCP> ANECMFOKGGF(Guid instanceId)
		{
			return default(KeyValuePair<Guid, GAPPDCPCNCP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PLEJMAKJIPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PLEJMAKJIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1BCACE0", Offset = "0x1BC96E0", VA = "0x181BCACE0")]
		internal bool DFCOLFMKBBK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EHDMLCIDLOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EHDMLCIDLOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1BCACE0", Offset = "0x1BC96E0", VA = "0x181BCACE0")]
		internal bool NJAFDJBEGBL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JLBCGPEGIEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JLBCGPEGIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0FF0", Offset = "0x6BCF9F0", VA = "0x186BD0FF0")]
		internal HABLMKCEIGL<Dictionary<Guid, GAPPDCPCNCP>> PMAGPDNGMFP(Dictionary<Guid, GAPPDCPCNCP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFDB0", Offset = "0x6BCE7B0", VA = "0x186BCFDB0")]
		internal bool LAABEBPFCLK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class ANLNMJBIOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ANLNMJBIOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0A40", Offset = "0x6BBF440", VA = "0x186BC0A40")]
		internal bool MHOFGAJHCAE(KeyValuePair<Guid, GAPPDCPCNCP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ABDPCLIIDPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, GAPPDCPCNCP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ABDPCLIIDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6BC08F0", Offset = "0x6BBF2F0", VA = "0x186BC08F0")]
		internal KeyValuePair<GAPPDCPCNCP, int> LACIMDJDCNG(GAPPDCPCNCP category)
		{
			return default(KeyValuePair<GAPPDCPCNCP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HPOLMDJCKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GAPPDCPCNCP category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HPOLMDJCKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x151EBA0", Offset = "0x151D5A0", VA = "0x18151EBA0")]
		internal bool ANLMGOLJGIP(GAPPDCPCNCP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KMJAKBIBLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, GAPPDCPCNCP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KMJAKBIBLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1270", Offset = "0x6BCFC70", VA = "0x186BD1270")]
		internal KeyValuePair<GAPPDCPCNCP, int> MCNNHBMFEOM(GAPPDCPCNCP category)
		{
			return default(KeyValuePair<GAPPDCPCNCP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NJJJAKAILCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GAPPDCPCNCP category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public NJJJAKAILCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x151EBA0", Offset = "0x151D5A0", VA = "0x18151EBA0")]
		internal bool MJLJBGIGOIB(GAPPDCPCNCP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EIIOGCDEDJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EIIOGCDEDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFBB0", Offset = "0x6BCE5B0", VA = "0x186BCFBB0")]
		internal bool FEAKBPAOEKP(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFAF0", Offset = "0x6BCE4F0", VA = "0x186BCFAF0")]
		internal bool AONGBOFCPHI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFCA0", Offset = "0x6BCE6A0", VA = "0x186BCFCA0")]
		internal bool FOGDPJFCMKN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFCA0", Offset = "0x6BCE6A0", VA = "0x186BCFCA0")]
		internal bool MPEGJMOLAPF(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PIHKLKMODEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PIHKLKMODEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x937850", Offset = "0x936250", VA = "0x180937850")]
		internal bool OFOEGDPIGBN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IFDFHLDCMLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IFDFHLDCMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0860", Offset = "0x6BCF260", VA = "0x186BD0860")]
		internal bool ODHABOIKDLB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1B8A890", Offset = "0x1B89290", VA = "0x181B8A890")]
		internal bool CLNGPCLCJOJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OPINICHIOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OPINICHIOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1710", Offset = "0x6BD0110", VA = "0x186BD1710")]
		internal bool LILJEHCCKOL(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KBJEJCDFIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KBJEJCDFIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x937850", Offset = "0x936250", VA = "0x180937850")]
		internal bool OOIICNIAKAJ(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OPHMDANMMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OPHMDANMMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6BD16B0", Offset = "0x6BD00B0", VA = "0x186BD16B0")]
		internal bool LGEIGHNALPJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CBIAIJKIPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GAPPDCPCNCP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CBIAIJKIPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1878CC0", Offset = "0x18776C0", VA = "0x181878CC0")]
		internal bool LDGGFJMOOGM(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BMNKHOFBNAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BMNKHOFBNAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6BC10F0", Offset = "0x6BBFAF0", VA = "0x186BC10F0")]
		internal bool MPDHPEIOJOB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JECMJPOAKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GAPPDCPCNCP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JECMJPOAKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0FB0", Offset = "0x6BCF9B0", VA = "0x186BD0FB0")]
		internal bool IIMJHAHEOPL(KeyValuePair<Guid, GAPPDCPCNCP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LEAOPGLOCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GAPPDCPCNCP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LEAOPGLOCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1878CC0", Offset = "0x18776C0", VA = "0x181878CC0")]
		internal bool OGOABGIAOEB(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MGMLGGEFNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MGMLGGEFNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BD1610", Offset = "0x6BD0010", VA = "0x186BD1610")]
		internal bool DHHOLKKBOCB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FFLALEIKELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FFLALEIKELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFCC0", Offset = "0x6BCE6C0", VA = "0x186BCFCC0")]
		internal bool BLNMGLECAJL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JMHMDAHDDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FFLALEIKELD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JMHMDAHDDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD11F0", Offset = "0x6BCFBF0", VA = "0x186BD11F0")]
		internal bool IBOIOOKDHJH(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct EAFPOENPCEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public OOGIBKAOAMC args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF560", Offset = "0x6BCDF60", VA = "0x186BCF560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFA90", Offset = "0x6BCE490", VA = "0x186BCFA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct FOGPLEBFFFE : IAsyncStateMachine
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
		public DNHBBPBJEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6BCFF40", Offset = "0x6BCE940", VA = "0x186BCFF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6BD01D0", Offset = "0x6BCEBD0", VA = "0x186BD01D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime PFFCPCIPINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AOAIOMGGAGK KMCJMCOFEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GKBBGNIMEAC AAPJIFBNFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FIHMPDGHBMG HHLEEJIKOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LDDGAOBCDMN EPFPJJAGEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HGIEGEHKIOH NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OOFCEBGJFEI FEAEOIEBCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HAMCOKMBKOP FKPPAPHNOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CDFOBAKOGLB KOFLOFNGPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BEEJKOILHGG PKGKJAECJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FDMOADBLFJJ MDFAMKPOGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PKEDFGGABEH FLGFHBMFDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BDEABIPJBIG GLFMDJIILFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MMGJGPBOBAP FDJJLMDEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HIMJLHGHAJA DONCNEAGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IHFBNHEJBAF<KeepsakesConfig.KeepsakesOptions> JIEJKJIJPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OKLMGPLPKNE KGEAHMJPFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> NMIKLJEBCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> DEMBAAOFHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> DPADLFEGGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<GAPPDCPCNCP, int> BPNBJJJNABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> FFCLFPNKACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable FCOEPEPELIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task EJJONMHNHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private HABLMKCEIGL<Guid> MEJNKHBJPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? GIFKLAKHFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO HMDHBOEKLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HABLMKCEIGL<KeepsakeProgressionEventInstancesDTO> FIFJCBLGOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<GAPPDCPCNCP, KeepsakeCategoryConfigDTO> NBDMFEJMCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO LACKDKJJMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> DACKNBMNOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> DCMOKEALFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> HDBEMIDFAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> FMKMMHKOACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> OCFBNJBGKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> EMBLHIAKEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> LHGCPKMPKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> NPOEJLEBEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> HCDNJLEBIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MOEBGJIBMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> KEMCNGINJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> AHDALJCONMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime KKPDELMHHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable NCBLIFNMOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, GAPPDCPCNCP> KCOBLPEKMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<GAPPDCPCNCP, int> PNCIFOIJCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> CNJBBMFICPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IPNGCELDDMC CBIDNPNEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool JKIEFECEHIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MLHPCCPLBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC320D0", Offset = "0xC30AD0", VA = "0x180C320D0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD12ED0", Offset = "0xD118D0", VA = "0x180D12ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ADCGBPHMIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAAB0", Offset = "0x6BC94B0", VA = "0x186BCAAB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DAPADKGACMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9740", Offset = "0x6BC8140", VA = "0x186BC9740", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long BAIEDPBBLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA630", Offset = "0x6BC9030", VA = "0x186BCA630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? CLFMCIOCEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7BD0", Offset = "0x6BC65D0", VA = "0x186BC7BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PNCBFFHIPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD840", Offset = "0x6BCC240", VA = "0x186BCD840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> ANGLFICIAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E30", Offset = "0x9F7830", VA = "0x1809F8E30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DAAAIMEHMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9839C0", Offset = "0x9823C0", VA = "0x1809839C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> LHHCHMPHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x981670", Offset = "0x980070", VA = "0x180981670", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> JAAGIGFHJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x981260", Offset = "0x97FC60", VA = "0x180981260", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool OFHGEONIHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1B1ACA0", Offset = "0x1B196A0", VA = "0x181B1ACA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JNIOHCECEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3FC0", Offset = "0x6BC29C0", VA = "0x186BC3FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC1630", Offset = "0x6BC0030", VA = "0x186BC1630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FGNOOGICBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAFC0", Offset = "0x6BC99C0", VA = "0x186BCAFC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCD60", Offset = "0x6BCB760", VA = "0x186BCCD60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BBLALOIGCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2EE0", Offset = "0x6BC18E0", VA = "0x186BC2EE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCE00", Offset = "0x6BCB800", VA = "0x186BCCE00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDFE0", Offset = "0x6BCC9E0", VA = "0x186BCDFE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DNHBBPBJEAC([LKKACOOMNBP(null)][NotNull] AOAIOMGGAGK KMCJMCOFEAM, [NotNull][LKKACOOMNBP(null)] JJCIGAIBDGK CBMAPDKFDGE, [NotNull][LKKACOOMNBP(null)] GKBBGNIMEAC AAPJIFBNFLA, [NotNull][LKKACOOMNBP(null)] FIHMPDGHBMG HHLEEJIKOIO, [LKKACOOMNBP(null)][NotNull] LDDGAOBCDMN EPFPJJAGEKG, [LKKACOOMNBP(null)][NotNull] HGIEGEHKIOH NCAFNAHMGMF, [LKKACOOMNBP(null)][NotNull] OOFCEBGJFEI FEAEOIEBCLC, [NotNull][LKKACOOMNBP(null)] HAMCOKMBKOP FKPPAPHNOEF, [NotNull][LKKACOOMNBP(null)] MMHLBANLMND NHPIKOHJFBH, [NotNull][LKKACOOMNBP(null)] NHCFNKCLJCG FLHHBNFHCGL, [NotNull][LKKACOOMNBP(null)] CDFOBAKOGLB KOFLOFNGPLI, [NotNull][LKKACOOMNBP(null)] BEEJKOILHGG PKGKJAECJNO, [NotNull][LKKACOOMNBP(null)] FDMOADBLFJJ MDFAMKPOGBA, [NotNull][LKKACOOMNBP(null)] PKEDFGGABEH FLGFHBMFDCL, [LKKACOOMNBP(null)][NotNull] BDEABIPJBIG GLFMDJIILFC, [LKKACOOMNBP(null)][NotNull] MMGJGPBOBAP FDJJLMDEEDH, [NotNull][LKKACOOMNBP(null)] HIMJLHGHAJA DONCNEAGOEE, [LKKACOOMNBP(null)][NotNull] IHFBNHEJBAF<KeepsakesConfig.KeepsakesOptions> JIEJKJIJPFC, [NotNull][LKKACOOMNBP(null)] OKLMGPLPKNE KGEAHMJPFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3020", Offset = "0x6BC1A20", VA = "0x186BC3020", Slot = "15")]
	public bool BDJBEIFAPOM(List<string> PAPHIOMHALE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD230", Offset = "0x6BCBC30", VA = "0x186BCD230", Slot = "16")]
	public HABLMKCEIGL<Guid> OGHBPDGIHOH(GAPPDCPCNCP DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4070", Offset = "0x6BC2A70", VA = "0x186BC4070", Slot = "17")]
	public KGIOENCPIOK CPNMLJIIGNI(Guid PFKGIENKOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCEA0", Offset = "0x6BCB8A0", VA = "0x186BCCEA0", Slot = "18")]
	public KGIOENCPIOK OFNAHNHJDBM(Guid PFKGIENKOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3AC0", Offset = "0x6BC24C0", VA = "0x186BC3AC0", Slot = "19")]
	public bool BPMBLKOJFLH(Guid PFKGIENKOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3A90", Offset = "0x6BC2490", VA = "0x186BC3A90", Slot = "20")]
	public bool BLIHKOLHNOK(Guid PFKGIENKOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBF00", Offset = "0x6BCA900", VA = "0x186BCBF00")]
	public KeepsakeTheme MLKLLMBMNJF(Guid PFKGIENKOJN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1A80", Offset = "0x6BC0480", VA = "0x186BC1A80")]
	public bool ABGOGMAAJGK(GAPPDCPCNCP DLBPCHBONCJ, [Out] KeepsakeTheme FFPPAOEFLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA700", Offset = "0x6BC9100", VA = "0x186BCA700")]
	public List<KeepsakeTheme> KGFLODBFIEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6730", Offset = "0x6BC5130", VA = "0x186BC6730")]
	public int EPGKONLNIEL(GAPPDCPCNCP DLBPCHBONCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC810", Offset = "0x6BCB210", VA = "0x186BCC810")]
	public GAPPDCPCNCP NHPMLBAPOPB(Guid PFKGIENKOJN)
	{
		return default(GAPPDCPCNCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5390", Offset = "0x6BC3D90", VA = "0x186BC5390", Slot = "34")]
	public List<GAPPDCPCNCP> DINPJDAFIHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBA70", Offset = "0x6BCA470", VA = "0x186BCBA70", Slot = "35")]
	public IComparer<GAPPDCPCNCP> LOHMLEOPHAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD9B0", Offset = "0x6BCC3B0", VA = "0x186BCD9B0", Slot = "32")]
	public string PAMDGOGHDPE(GAPPDCPCNCP DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2D60", Offset = "0x6BC1760", VA = "0x186BC2D60", Slot = "33")]
	public string APNBNEKCABF(GAPPDCPCNCP DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7F20", Offset = "0x6BC6920", VA = "0x186BC7F20", Slot = "21")]
	public bool HKFGCGOFGPO(Guid PFKGIENKOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2CC0", Offset = "0x6BC16C0", VA = "0x186BC2CC0", Slot = "22")]
	public void AMDINFMBHFC(Guid PFKGIENKOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDB30", Offset = "0x6BCC530", VA = "0x186BCDB30", Slot = "23")]
	public void PGBPBCMJCBK(GAPPDCPCNCP DLBPCHBONCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC81B0", Offset = "0x6BC6BB0", VA = "0x186BC81B0", Slot = "24")]
	public void HPEJIGDOEEJ(Guid PFKGIENKOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BC46A0", Offset = "0x6BC30A0", VA = "0x186BC46A0", Slot = "25")]
	public int DEJGJBGLGBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6980", Offset = "0x6BC5380", VA = "0x186BC6980", Slot = "31")]
	public HABLMKCEIGL<IEnumerable<Guid>> FHGEOPJMGHI(long MOEKPKHCJHD, long KBAIBDCGCPD, GAPPDCPCNCP? DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4500", Offset = "0x6BC2F00", VA = "0x186BC4500", Slot = "30")]
	public HABLMKCEIGL<IEnumerable<Guid>> DDHNGMCDEBN(long MOEKPKHCJHD, long KBAIBDCGCPD, GAPPDCPCNCP? DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4FE0", Offset = "0x6BC39E0", VA = "0x186BC4FE0", Slot = "54")]
	public HABLMKCEIGL<Dictionary<Guid, GAPPDCPCNCP>> DGHDKGNMKEF(long MOEKPKHCJHD, long KBAIBDCGCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDE50", Offset = "0x6BCC850", VA = "0x186BCDE50", Slot = "55")]
	public HABLMKCEIGL<Dictionary<Guid, GAPPDCPCNCP>> POCOAKHKCKO(long MOEKPKHCJHD, long KBAIBDCGCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA240", Offset = "0x6BC8C40", VA = "0x186BCA240", Slot = "26")]
	public HABLMKCEIGL<int> KBEDMPHLGDI(long MOEKPKHCJHD, long KBAIBDCGCPD, GAPPDCPCNCP? DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BC65E0", Offset = "0x6BC4FE0", VA = "0x186BC65E0", Slot = "27")]
	public HABLMKCEIGL<int> EKBEOFAKMHM(long MOEKPKHCJHD, long KBAIBDCGCPD, GAPPDCPCNCP? DLBPCHBONCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBCF0", Offset = "0x6BCA6F0", VA = "0x186BCBCF0", Slot = "28")]
	public HABLMKCEIGL<Dictionary<GAPPDCPCNCP, int>> MFGLCPKGHNK(long MOEKPKHCJHD, long KBAIBDCGCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9680", Offset = "0x6BC8080", VA = "0x186BC9680", Slot = "29")]
	public HABLMKCEIGL<Dictionary<GAPPDCPCNCP, int>> JFKGOIEGHNP(long MOEKPKHCJHD, long KBAIBDCGCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC7B0", Offset = "0x6BCB1B0", VA = "0x186BCC7B0", Slot = "37")]
	public bool NGDHODIKBML(long MOEKPKHCJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2C60", Offset = "0x6BC1660", VA = "0x186BC2C60", Slot = "56")]
	public bool ALOLJMKIBIF(long MOEKPKHCJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2F80", Offset = "0x6BC1980", VA = "0x186BC2F80", Slot = "38")]
	public bool BBLKCJKJMFB(long MOEKPKHCJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC040", Offset = "0x6BCAA40", VA = "0x186BCC040", Slot = "57")]
	public bool MMAIELIGFNB(long MOEKPKHCJHD, [Out] KMCJFBPIHPO ACJBKADFAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD870", Offset = "0x6BCC270", VA = "0x186BCD870", Slot = "39")]
	public bool OJFOAEGPKAB(long LKLEPPPOAOH, [Out] DateTime KBAPOBMINAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC70D0", Offset = "0x6BC5AD0", VA = "0x186BC70D0", Slot = "40")]
	public long GIKFIBNLLPA(long LKLEPPPOAOH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6D90", Offset = "0x6BC5790", VA = "0x186BC6D90", Slot = "41")]
	public long GADPFBGCAPF(long MOEKPKHCJHD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9BB0", Offset = "0x6BC85B0", VA = "0x186BC9BB0", Slot = "42")]
	public int JJIHEOFGLMF(long LKLEPPPOAOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9180", Offset = "0x6BC7B80", VA = "0x186BC9180", Slot = "43")]
	public bool IMFIEKPBODD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7C60", Offset = "0x6BC6660", VA = "0x186BC7C60", Slot = "44")]
	public bool HGIEBLIDPOP(long LKLEPPPOAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB060", Offset = "0x6BC9A60", VA = "0x186BCB060", Slot = "45")]
	public IEnumerable<long> LGLHOGNDFLO(long LKLEPPPOAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BCAB00", Offset = "0x6BC9500", VA = "0x186BCAB00", Slot = "46")]
	public int KKKELLCAHGI(long LKLEPPPOAOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC970", Offset = "0x6BCB370", VA = "0x186BCC970", Slot = "50")]
	public long NKJGLLHGOHL(long EJDOICMPDFF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB610", Offset = "0x6BCA010", VA = "0x186BCB610", Slot = "51")]
	public GAPPDCPCNCP LLFNEAGKLNO()
	{
		return default(GAPPDCPCNCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3C20", Offset = "0x6BC2620", VA = "0x186BC3C20")]
	private bool CJKJLMKJEGF(Guid PFKGIENKOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9D90", Offset = "0x6BC8790", VA = "0x186BC9D90")]
	private void KANEMPIJKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9260", Offset = "0x6BC7C60", VA = "0x186BC9260")]
	private GAPPDCPCNCP JBMFDPONJHI()
	{
		return default(GAPPDCPCNCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5E00", Offset = "0x6BC4800", VA = "0x186BC5E00")]
	private void EGJCOODMIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6440", Offset = "0x6BC4E40", VA = "0x186BC6440")]
	private int EHPEJIJHCND(KeepsakeRoomListDTO AHOAIOLKNOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBB30", Offset = "0x6BCA530", VA = "0x186BCBB30")]
	private int MBKGPCJMPHJ(DateTime OMPINMMBILA, DateTime LPBHJKDHNMP, TimeSpan CDHCDAJBNNO, int ODBPLPDLGGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCABB0", Offset = "0x6BC95B0", VA = "0x186BCABB0")]
	private void KNIANDJCJHA(IEnumerable<KeepsakeInstanceDTO> NMIKLJEBCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC32B0", Offset = "0x6BC1CB0", VA = "0x186BC32B0")]
	private void BFGKNBHNBGL(IEnumerable<KeepsakeCollectionRecordDTO> CJEJJIKIHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBC90", Offset = "0x6BCA690", VA = "0x186BCBC90")]
	private void MEFDDPEFALB(IEnumerable<long> GHEEPNFFLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xCA31E0", Offset = "0xCA1BE0", VA = "0x180CA31E0")]
	private void JNPFCAKCEEF(KeepsakeGlobalConfigDTO LACKDKJJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BC83F0", Offset = "0x6BC6DF0", VA = "0x186BC83F0")]
	private bool ICMPFKKBMCM(GAPPDCPCNCP DLBPCHBONCJ, [Out] Guid EJCPGFPBJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3F20", Offset = "0x6BC2920", VA = "0x186BC3F20")]
	private bool COJDKINPLCP([Out] Guid EJCPGFPBJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7070", Offset = "0x6BC5A70", VA = "0x186BC7070")]
	private bool GCPOCCCHPGI(Guid PFKGIENKOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA4E0", Offset = "0x6BC8EE0", VA = "0x186BCA4E0")]
	private IEnumerable<Guid> KCBKHEAEJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BC79A0", Offset = "0x6BC63A0", VA = "0x186BC79A0")]
	private IEnumerable<KeepsakeInstanceDTO> GMDPEOLBBFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB9E0", Offset = "0x6BCA3E0", VA = "0x186BCB9E0")]
	private void LMIOAJJHMJJ(Guid PFKGIENKOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BC68D0", Offset = "0x6BC52D0", VA = "0x186BC68D0")]
	private bool FCLJDGLIDFE(Guid PFKGIENKOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDCB0", Offset = "0x6BCC6B0", VA = "0x186BCDCB0")]
	private void PNOBGCPNPBL(Guid PFKGIENKOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2B30", Offset = "0x6BC1530", VA = "0x186BC2B30")]
	private void AGPBJPCMNNF(GAPPDCPCNCP DDIOFMABBBG, int JIKHPCEJMNL, Dictionary<GAPPDCPCNCP, int> CJBMGNGHDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC77D0", Offset = "0x6BC61D0", VA = "0x186BC77D0")]
	private int GKFFBNHFEFM(GAPPDCPCNCP DLBPCHBONCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6EA0", Offset = "0x6BC58A0", VA = "0x186BC6EA0")]
	private void GBCFODDHPME(KeepsakeInstanceDTO PKIDAAAAAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC42F0", Offset = "0x6BC2CF0", VA = "0x186BC42F0")]
	private void CPPGEONOBGL(KeepsakeInstanceDTO PKIDAAAAAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB240", Offset = "0x6BC9C40", VA = "0x186BCB240")]
	private void LILBMGAOFOD(Guid PFKGIENKOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2D30", Offset = "0x6BC1730", VA = "0x186BC2D30")]
	private void EEOEENKANAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC3F0", Offset = "0x6BCADF0", VA = "0x186BCC3F0")]
	private void MPJHMKGGKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB970", Offset = "0x6BCA370", VA = "0x186BCB970")]
	private void LLMALMHEKMI(LBGEPNPLEJA MPDIMGMLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2D30", Offset = "0x6BC1730", VA = "0x186BC2D30")]
	private void EMMIIPKKMIP(MEKDCJEAFCK FHFDEAHMMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2D30", Offset = "0x6BC1730", VA = "0x186BC2D30")]
	private void AOJEHONLJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BC16E0", Offset = "0x6BC00E0", VA = "0x186BC16E0")]
	private void AADGGLGBNIK(float PJCCLBGHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BC34F0", Offset = "0x6BC1EF0", VA = "0x186BC34F0")]
	private void BKPJJKJIOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BC54D0", Offset = "0x6BC3ED0", VA = "0x186BC54D0")]
	private bool DLKNAGNCKLG(Guid PFKGIENKOJN, [Out] string PLNDNOAIDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3D50", Offset = "0x6BC2750", VA = "0x186BC3D50")]
	private bool CJMOGOIOKOA(Guid PFKGIENKOJN, [Out] KeepsakeCategoryConfigDTO DDIOFMABBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BC78C0", Offset = "0x6BC62C0", VA = "0x186BC78C0")]
	private void GLBJCJCELEH(string CMLOOAOLBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BC56D0", Offset = "0x6BC40D0", VA = "0x186BC56D0")]
	private bool DMPOMCKABII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC410", Offset = "0x6BCAE10", VA = "0x186BCC410")]
	private IEnumerable<long> NAFKBBKENEP(IEnumerable<KeepsakeRoomDTO> OPLNIBDELCG, IEnumerable<KeepsakeRoomListDTO> JGAKCLMABBD, long LKLEPPPOAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4AC0", Offset = "0x6BC34C0", VA = "0x186BC4AC0")]
	private bool DENIFAGMLJE(Guid PFKGIENKOJN, [Out] string EJIIMGEBDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBC30", Offset = "0x6BCA630", VA = "0x186BCBC30", Slot = "47")]
	public string MCMNEHEKMPH(ENEALBCGEMD ADKFLDCMKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8BB0", Offset = "0x6BC75B0", VA = "0x186BC8BB0", Slot = "49")]
	public string IFEPPBLMDAK(ENEALBCGEMD ADKFLDCMKMC, long MOEKPKHCJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC6C0", Offset = "0x6BCB0C0", VA = "0x186BCC6C0", Slot = "48")]
	public string NAPNJFLKHMK(ENEALBCGEMD ADKFLDCMKMC, int EEJEEMFNGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1C60", Offset = "0x6BC0660", VA = "0x186BC1C60")]
	private void AGAPAAKEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCAE30", Offset = "0x6BC9830", VA = "0x186BCAE30")]
	private void LCGFAACCFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD850", Offset = "0x6BCC250", VA = "0x186BCD850")]
	private ENEALBCGEMD OHHEIBLPHHB(MNGNOAOKDBD CHJJLBEIMOF)
	{
		return default(ENEALBCGEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9160", Offset = "0x6BC7B60", VA = "0x186BC9160")]
	private ENEALBCGEMD IKGPLPIHNGM(MNGNOAOKDBD CHJJLBEIMOF)
	{
		return default(ENEALBCGEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BC89D0", Offset = "0x6BC73D0", VA = "0x186BC89D0")]
	internal static string IFBAEFMGMFK(FDHLBFMKGCO KKGHEGBIBGL, string CBIMLKHPJPC, bool DLKBNEMKCCM, int IDKIJLNOPEH, int ACGCPHLBIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BC59A0", Offset = "0x6BC43A0", VA = "0x186BC59A0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9600", Offset = "0x6BC8000", VA = "0x186BC9600")]
	private AKHLLPJOLIM JDFGJFPOAHM(ICGGIJDMFMC AJKAAPEBLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BC57E0", Offset = "0x6BC41E0", VA = "0x186BC57E0")]
	private NKCJHNHKDGB DPOMKFMAEJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9800", Offset = "0x6BC8200", VA = "0x186BC9800")]
	private Task JHIGGDPDELG(OOGIBKAOAMC BBLLNFBCDFH, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8650", Offset = "0x6BC7050", VA = "0x186BC8650")]
	[AsyncStateMachine(typeof(EAFPOENPCEK))]
	private Task IEHHGNEIJLB(OOGIBKAOAMC BBLLNFBCDFH, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9530", Offset = "0x6BC7F30", VA = "0x186BC9530")]
	private Task JBPBNOAILOI(OOGIBKAOAMC BBLLNFBCDFH, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDB80", Offset = "0x6BCC580", VA = "0x186BCDB80")]
	[AsyncStateMachine(typeof(FOGPLEBFFFE))]
	private Task PHOPDALJBGC(string BBDGOIMNDJI, TimeSpan EIKADNJKAMO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC790", Offset = "0x6BCB190", VA = "0x186BCC790")]
	[CompilerGenerated]
	private void NDDAEFIABFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2C10", Offset = "0x6BC1610", VA = "0x186BC2C10")]
	[CompilerGenerated]
	private void AJPIBBDABBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC88D0", Offset = "0x6BC72D0", VA = "0x186BC88D0")]
	[CompilerGenerated]
	private bool IELMEBJFDFD(KeepsakeInstanceDTO OFCNMBDJPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7A60", Offset = "0x6BC6460", VA = "0x186BC7A60")]
	[CompilerGenerated]
	private HABLMKCEIGL<Dictionary<GAPPDCPCNCP, int>> GNDJLLHOCJM(Dictionary<Guid, GAPPDCPCNCP> JMKJLEFCFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8760", Offset = "0x6BC7160", VA = "0x186BC8760")]
	[CompilerGenerated]
	private HABLMKCEIGL<Dictionary<GAPPDCPCNCP, int>> IELDGPOJFLE(Dictionary<Guid, GAPPDCPCNCP> JMKJLEFCFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC68B0", Offset = "0x6BC52B0", VA = "0x186BC68B0")]
	[CompilerGenerated]
	private bool FBIGENDNMKP(KeepsakeRoomListDTO OFCNMBDJPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCC30", Offset = "0x6BCB630", VA = "0x186BCCC30")]
	[CompilerGenerated]
	private bool NLEFHPNCKOI(KeepsakeInstanceDTO OFCNMBDJPHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8FD0", Offset = "0x6BC79D0", VA = "0x186BC8FD0")]
	[CompilerGenerated]
	private void IIINHKJEHIA(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<GAPPDCPCNCP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> KDEIPJICKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6D30", Offset = "0x6BC5730", VA = "0x186BC6D30")]
	[CompilerGenerated]
	private void GACGJELDBDG(string EJIIMGEBDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7610", Offset = "0x6BC6010", VA = "0x186BC7610")]
	[CompilerGenerated]
	private Task GIMGCHNEPLL(CancellationToken MNPPKNOLLHH)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, IHFBNHEJBAF<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class HMCALIEBLAO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
				public HMCALIEBLAO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6BD0780", Offset = "0x6BCF180", VA = "0x186BD0780")]
				internal bool DOJAJACADIJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6BD0780", Offset = "0x6BCF180", VA = "0x186BD0780")]
				internal bool OJILLPDJOOJ(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6BD1440", Offset = "0x6BCFE40", VA = "0x186BD1440")]
			public bool NCLLIDFOMDL(string MDFBIIACEHC, [Out] KeepsakeTheme FFPPAOEFLMI)
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BD13C0", Offset = "0x6BCFDC0", VA = "0x186BD13C0")]
		[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
		internal static void CNFNMOPOGFM(FNNNJBMCDDC NKDOKEFKKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
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
