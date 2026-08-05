using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MNDOCIJJNFK : GGNCCNOHGHL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA64FD0", Offset = "0xA635D0", VA = "0x180A64FD0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A18710", Offset = "0x6A16D10", VA = "0x186A18710", Slot = "36")]
	protected override Vector3 AHOFIDLNAIF(float[] ICLOFOKMOJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A18760", Offset = "0x6A16D60", VA = "0x186A18760", Slot = "37")]
	protected override float[] DAJAPAGKKGO(Vector3 KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A187E0", Offset = "0x6A16DE0", VA = "0x186A187E0")]
	public MNDOCIJJNFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NPBCEPKLBND : GGNCCNOHGHL<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x91FD90", Offset = "0x91E390", VA = "0x18091FD90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A18950", Offset = "0x6A16F50", VA = "0x186A18950", Slot = "36")]
	protected override Vector2 AHOFIDLNAIF(float[] ICLOFOKMOJF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A18990", Offset = "0x6A16F90", VA = "0x186A18990", Slot = "37")]
	protected override float[] DAJAPAGKKGO(Vector2 KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A18A00", Offset = "0x6A17000", VA = "0x186A18A00")]
	public NPBCEPKLBND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MOCDHEMPCNJ : GGNCCNOHGHL<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDF0", Offset = "0xA5E3F0", VA = "0x180A5FDF0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A18820", Offset = "0x6A16E20", VA = "0x186A18820", Slot = "36")]
	protected override Quaternion AHOFIDLNAIF(float[] ICLOFOKMOJF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A18880", Offset = "0x6A16E80", VA = "0x186A18880", Slot = "37")]
	protected override float[] DAJAPAGKKGO(Quaternion KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A18910", Offset = "0x6A16F10", VA = "0x186A18910")]
	public MOCDHEMPCNJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarItemDownloadableConfig
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum ONCCLNHMFCB
		{
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			Prerelease = 0,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			InitialRelease = 1,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			CurrentPlusOne = 2,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Current = 1
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static JsonSerializerOptions Options;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ONCCLNHMFCB Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0")]
			[CompilerGenerated]
			get
			{
				return default(ONCCLNHMFCB);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x887070", Offset = "0x885670", VA = "0x180887070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x907A60", Offset = "0x906060", VA = "0x180907A60")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HHPABFBJKKA : HIGAGHHDLLN<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MEHAJEDECIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public MEHAJEDECIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A181A0", Offset = "0x6A167A0", VA = "0x186A181A0")]
		internal void CLLAELACCMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A18460", Offset = "0x6A16A60", VA = "0x186A18460")]
		internal void IMFDGIIONKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A18300", Offset = "0x6A16900", VA = "0x186A18300")]
		internal void GBGJBCPMICK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A185B0", Offset = "0x6A16BB0", VA = "0x186A185B0")]
		internal void PHIODAMBLHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A18250", Offset = "0x6A16850", VA = "0x186A18250")]
		internal void EBHALKOOIIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A180F0", Offset = "0x6A166F0", VA = "0x186A180F0")]
		internal void BOMEMOACJNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A18660", Offset = "0x6A16C60", VA = "0x186A18660")]
		internal void POBHFBGKCBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A183B0", Offset = "0x6A169B0", VA = "0x186A183B0")]
		internal void HCKNCKGFJPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A18050", Offset = "0x6A16650", VA = "0x186A18050")]
		internal void BFDAOEHGILN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A18510", Offset = "0x6A16B10", VA = "0x186A18510")]
		internal void JHGPGNLHBKO(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GPJFJGABDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A15CB0", Offset = "0x6A142B0", VA = "0x186A15CB0", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, AnchorParamsRestrictions IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A15830", Offset = "0x6A13E30", VA = "0x186A15830", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, AnchorParamsRestrictions KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A161D0", Offset = "0x6A147D0", VA = "0x186A161D0")]
	public HHPABFBJKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8FA0", Offset = "0x2CF75A0", VA = "0x182CF8FA0")]
	[CompilerGenerated]
	internal static void CDJKPDDGFAG<T>(string NJIGKJGJPBF, T AAJFAHDADNL, T EDJAAJOEMFL, GPJFJGABDDL P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MBPMDMGOLBF : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void KOACHHDOANP(Utf8JsonReader CGJIPKMEOFC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EMAFDPINCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public SerializedAvatarItemData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool hasReadOutfitType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MBPMDMGOLBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KOACHHDOANP <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KOACHHDOANP <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KOACHHDOANP <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KOACHHDOANP <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KOACHHDOANP <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KOACHHDOANP <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KOACHHDOANP <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KOACHHDOANP <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KOACHHDOANP <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KOACHHDOANP <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KOACHHDOANP <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KOACHHDOANP <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KOACHHDOANP <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KOACHHDOANP <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EMAFDPINCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A150F0", Offset = "0x6A136F0", VA = "0x186A150F0")]
		internal void EGCKLEOLANL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A155E0", Offset = "0x6A13BE0", VA = "0x186A155E0")]
		internal void OBMIAFGACCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A152F0", Offset = "0x6A138F0", VA = "0x186A152F0")]
		internal void KDJGEOALFJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A15690", Offset = "0x6A13C90", VA = "0x186A15690")]
		internal void PLPDPFDJIAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A15740", Offset = "0x6A13D40", VA = "0x186A15740")]
		internal void PPCEBFKEEPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A15160", Offset = "0x6A13760", VA = "0x186A15160")]
		internal void FLMFOPGGNFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A150C0", Offset = "0x6A136C0", VA = "0x186A150C0")]
		internal void CPIFIOBOGEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A153A0", Offset = "0x6A139A0", VA = "0x186A153A0")]
		internal void KIHABKMKIPJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A15130", Offset = "0x6A13730", VA = "0x186A15130")]
		internal void ELEDGCODGHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A15610", Offset = "0x6A13C10", VA = "0x186A15610")]
		internal void OMHEKMLJKIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A153D0", Offset = "0x6A139D0", VA = "0x186A153D0")]
		internal void KNPPMHKKNOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A15210", Offset = "0x6A13810", VA = "0x186A15210")]
		internal void GCCNCJJOJKL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A15250", Offset = "0x6A13850", VA = "0x186A15250")]
		internal void IHCPBINDNIG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A154B0", Offset = "0x6A13AB0", VA = "0x186A154B0")]
		internal void NLHPCEJBBCK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A170E0", Offset = "0x6A156E0", VA = "0x186A170E0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A17B60", Offset = "0x6A16160", VA = "0x186A17B60", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, SerializedAvatarItemData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A16FC0", Offset = "0x6A155C0", VA = "0x186A16FC0")]
	private AdditionalOutfitTypeData OOMHALJPBLN(Utf8JsonReader JEAKAGANOAM, OutfitType JLAAKHANEHC, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A18010", Offset = "0x6A16610", VA = "0x186A18010")]
	public MBPMDMGOLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PFGNOCEMICP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A18A40", Offset = "0x6A17040", VA = "0x186A18A40", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A18DD0", Offset = "0x6A173D0", VA = "0x186A18DD0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, AvatarItemDownloadableConfig KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A18EF0", Offset = "0x6A174F0", VA = "0x186A18EF0")]
	public PFGNOCEMICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JABHOBAJEEL : HIGAGHHDLLN<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A162D0", Offset = "0x6A148D0", VA = "0x186A162D0", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, BeardData IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A16210", Offset = "0x6A14810", VA = "0x186A16210", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, BeardData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A16470", Offset = "0x6A14A70", VA = "0x186A16470")]
	public JABHOBAJEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FGKNBJFKOEK : OHBLNCDIFCM<MCGGHHINOAF>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A157F0", Offset = "0x6A13DF0", VA = "0x186A157F0")]
	public FGKNBJFKOEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CKMNOELHKEG : OHBLNCDIFCM<OMNFECBJHMM>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A15040", Offset = "0x6A13640", VA = "0x186A15040")]
	public CKMNOELHKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ELOGHIANGIM : OHBLNCDIFCM<LDMPKENIKGE>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A15080", Offset = "0x6A13680", VA = "0x186A15080")]
	public ELOGHIANGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JBIOILBADIL : HJJMIBBJHEM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A164B0", Offset = "0x6A14AB0", VA = "0x186A164B0")]
	public JBIOILBADIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CIMMEAHMEME : HIGAGHHDLLN<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LKECGMEEMAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public LKECGMEEMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A16D70", Offset = "0x6A15370", VA = "0x186A16D70")]
		internal void CLLAELACCMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A16EC0", Offset = "0x6A154C0", VA = "0x186A16EC0")]
		internal void IMFDGIIONKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A155E0", Offset = "0x6A13BE0", VA = "0x186A155E0")]
		internal void GBGJBCPMICK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A16EF0", Offset = "0x6A154F0", VA = "0x186A16EF0")]
		internal void PHIODAMBLHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A16E20", Offset = "0x6A15420", VA = "0x186A16E20")]
		internal void EBHALKOOIIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A16CD0", Offset = "0x6A152D0", VA = "0x186A16CD0")]
		internal void BOMEMOACJNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A16F90", Offset = "0x6A15590", VA = "0x186A16F90")]
		internal void POBHFBGKCBA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A14C10", Offset = "0x6A13210", VA = "0x186A14C10", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, HairData IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A14940", Offset = "0x6A12F40", VA = "0x186A14940", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, HairData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A15000", Offset = "0x6A13600", VA = "0x186A15000")]
	public CIMMEAHMEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KPLBMMPPJBN : HIGAGHHDLLN<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AOKLEBHMKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AOKLEBHMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6A13D70", Offset = "0x6A12370", VA = "0x186A13D70")]
		internal void CLLAELACCMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A13FA0", Offset = "0x6A125A0", VA = "0x186A13FA0")]
		internal void IMFDGIIONKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A13E50", Offset = "0x6A12450", VA = "0x186A13E50")]
		internal void GBGJBCPMICK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A14050", Offset = "0x6A12650", VA = "0x186A14050")]
		internal void PHIODAMBLHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A13DA0", Offset = "0x6A123A0", VA = "0x186A13DA0")]
		internal void EBHALKOOIIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A13CD0", Offset = "0x6A122D0", VA = "0x186A13CD0")]
		internal void BOMEMOACJNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A14100", Offset = "0x6A12700", VA = "0x186A14100")]
		internal void POBHFBGKCBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A13F00", Offset = "0x6A12500", VA = "0x186A13F00")]
		internal void HCKNCKGFJPC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A16830", Offset = "0x6A14E30", VA = "0x186A16830", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, AdditionalHatData IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A164F0", Offset = "0x6A14AF0", VA = "0x186A164F0", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, AdditionalHatData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A16C90", Offset = "0x6A15290", VA = "0x186A16C90")]
	public KPLBMMPPJBN()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8920C0", Offset = "0x8906C0", VA = "0x1808920C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x901400", Offset = "0x8FFA00", VA = "0x180901400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCE9A00", Offset = "0xCE8000", VA = "0x180CE9A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xF95180", Offset = "0xF93780", VA = "0x180F95180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF95170", Offset = "0xF93770", VA = "0x180F95170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x10972E0", Offset = "0x10958E0", VA = "0x1810972E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x10972F0", Offset = "0x10958F0", VA = "0x1810972F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x16144B0", Offset = "0x1612AB0", VA = "0x1816144B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A18F30", Offset = "0x6A17530", VA = "0x186A18F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x23FC620", Offset = "0x23FAC20", VA = "0x1823FC620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x23FC790", Offset = "0x23FAD90", VA = "0x1823FC790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1CDA8E0", Offset = "0x1CD8EE0", VA = "0x181CDA8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CDA8F0", Offset = "0x1CD8EF0", VA = "0x181CDA8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FNMAPJHHAKI ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCB09D0", Offset = "0xCAEFD0", VA = "0x180CB09D0")]
			[CompilerGenerated]
			get
			{
				return default(FNMAPJHHAKI);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCB0570", Offset = "0xCAEB70", VA = "0x180CB0570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JAKMGBMNCCH.MGOIBKLDNOG ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAC9600", Offset = "0xAC7C00", VA = "0x180AC9600")]
			[CompilerGenerated]
			get
			{
				return default(JAKMGBMNCCH.MGOIBKLDNOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCB0600", Offset = "0xCAEC00", VA = "0x180CB0600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8868B0", Offset = "0x884EB0", VA = "0x1808868B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x886880", Offset = "0x884E80", VA = "0x180886880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA0F580", Offset = "0xA0DB80", VA = "0x180A0F580")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0B610", VA = "0x180A0D010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x11F5E60", Offset = "0x11F4460", VA = "0x1811F5E60")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3DB8510", Offset = "0x3DB6B10", VA = "0x183DB8510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public SerializedAvatarItemData()
		{
		}
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
