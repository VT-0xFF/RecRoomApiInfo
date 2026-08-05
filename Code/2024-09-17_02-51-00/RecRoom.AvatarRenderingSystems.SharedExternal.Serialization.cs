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
		[Cpp2IlInjected.Address(RVA = "0x991A90", Offset = "0x990490", VA = "0x180991A90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD040", Offset = "0x6AFBA40", VA = "0x186AFD040", Slot = "36")]
	protected override Vector3 AHOFIDLNAIF(float[] ICLOFOKMOJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD090", Offset = "0x6AFBA90", VA = "0x186AFD090", Slot = "37")]
	protected override float[] DAJAPAGKKGO(Vector3 KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD110", Offset = "0x6AFBB10", VA = "0x186AFD110")]
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
		[Cpp2IlInjected.Address(RVA = "0x98E810", Offset = "0x98D210", VA = "0x18098E810", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD280", Offset = "0x6AFBC80", VA = "0x186AFD280", Slot = "36")]
	protected override Vector2 AHOFIDLNAIF(float[] ICLOFOKMOJF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD2C0", Offset = "0x6AFBCC0", VA = "0x186AFD2C0", Slot = "37")]
	protected override float[] DAJAPAGKKGO(Vector2 KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD330", Offset = "0x6AFBD30", VA = "0x186AFD330")]
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
		[Cpp2IlInjected.Address(RVA = "0xB2EB80", Offset = "0xB2D580", VA = "0x180B2EB80", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD150", Offset = "0x6AFBB50", VA = "0x186AFD150", Slot = "36")]
	protected override Quaternion AHOFIDLNAIF(float[] ICLOFOKMOJF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD1B0", Offset = "0x6AFBBB0", VA = "0x186AFD1B0", Slot = "37")]
	protected override float[] DAJAPAGKKGO(Quaternion KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD240", Offset = "0x6AFBC40", VA = "0x186AFD240")]
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
			[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0")]
			[CompilerGenerated]
			get
			{
				return default(ONCCLNHMFCB);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x899070", Offset = "0x897A70", VA = "0x180899070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD40", Offset = "0x9AA740", VA = "0x1809ABD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MEHAJEDECIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCAD0", Offset = "0x6AFB4D0", VA = "0x186AFCAD0")]
		internal void CLLAELACCMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCD90", Offset = "0x6AFB790", VA = "0x186AFCD90")]
		internal void IMFDGIIONKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCC30", Offset = "0x6AFB630", VA = "0x186AFCC30")]
		internal void GBGJBCPMICK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCEE0", Offset = "0x6AFB8E0", VA = "0x186AFCEE0")]
		internal void PHIODAMBLHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCB80", Offset = "0x6AFB580", VA = "0x186AFCB80")]
		internal void EBHALKOOIIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCA20", Offset = "0x6AFB420", VA = "0x186AFCA20")]
		internal void BOMEMOACJNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCF90", Offset = "0x6AFB990", VA = "0x186AFCF90")]
		internal void POBHFBGKCBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCCE0", Offset = "0x6AFB6E0", VA = "0x186AFCCE0")]
		internal void HCKNCKGFJPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AFC980", Offset = "0x6AFB380", VA = "0x186AFC980")]
		internal void BFDAOEHGILN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCE40", Offset = "0x6AFB840", VA = "0x186AFCE40")]
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
	[Cpp2IlInjected.Address(RVA = "0x6AFA5E0", Offset = "0x6AF8FE0", VA = "0x186AFA5E0", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, AnchorParamsRestrictions IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA150", Offset = "0x6AF8B50", VA = "0x186AFA150", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, AnchorParamsRestrictions KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAB00", Offset = "0x6AF9500", VA = "0x186AFAB00")]
	public HHPABFBJKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2DD85E0", Offset = "0x2DD6FE0", VA = "0x182DD85E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EMAFDPINCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9A10", Offset = "0x6AF8410", VA = "0x186AF9A10")]
		internal void EGCKLEOLANL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9F00", Offset = "0x6AF8900", VA = "0x186AF9F00")]
		internal void OBMIAFGACCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9C10", Offset = "0x6AF8610", VA = "0x186AF9C10")]
		internal void KDJGEOALFJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9FB0", Offset = "0x6AF89B0", VA = "0x186AF9FB0")]
		internal void PLPDPFDJIAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA060", Offset = "0x6AF8A60", VA = "0x186AFA060")]
		internal void PPCEBFKEEPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9A80", Offset = "0x6AF8480", VA = "0x186AF9A80")]
		internal void FLMFOPGGNFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF99E0", Offset = "0x6AF83E0", VA = "0x186AF99E0")]
		internal void CPIFIOBOGEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9CC0", Offset = "0x6AF86C0", VA = "0x186AF9CC0")]
		internal void KIHABKMKIPJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9A50", Offset = "0x6AF8450", VA = "0x186AF9A50")]
		internal void ELEDGCODGHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9F30", Offset = "0x6AF8930", VA = "0x186AF9F30")]
		internal void OMHEKMLJKIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9CF0", Offset = "0x6AF86F0", VA = "0x186AF9CF0")]
		internal void KNPPMHKKNOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9B30", Offset = "0x6AF8530", VA = "0x186AF9B30")]
		internal void GCCNCJJOJKL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9B70", Offset = "0x6AF8570", VA = "0x186AF9B70")]
		internal void IHCPBINDNIG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9DD0", Offset = "0x6AF87D0", VA = "0x186AF9DD0")]
		internal void NLHPCEJBBCK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBA10", Offset = "0x6AFA410", VA = "0x186AFBA10", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC490", Offset = "0x6AFAE90", VA = "0x186AFC490", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, SerializedAvatarItemData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB8F0", Offset = "0x6AFA2F0", VA = "0x186AFB8F0")]
	private AdditionalOutfitTypeData OOMHALJPBLN(Utf8JsonReader JEAKAGANOAM, OutfitType JLAAKHANEHC, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC940", Offset = "0x6AFB340", VA = "0x186AFC940")]
	public MBPMDMGOLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PFGNOCEMICP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD370", Offset = "0x6AFBD70", VA = "0x186AFD370", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader JEAKAGANOAM, Type NMMHBEHHPEH, JsonSerializerOptions CLJCAFMAPFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD700", Offset = "0x6AFC100", VA = "0x186AFD700", Slot = "28")]
	public override void Write(Utf8JsonWriter NFLODIHODLH, AvatarItemDownloadableConfig KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD820", Offset = "0x6AFC220", VA = "0x186AFD820")]
	public PFGNOCEMICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JABHOBAJEEL : HIGAGHHDLLN<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAC00", Offset = "0x6AF9600", VA = "0x186AFAC00", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, BeardData IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAB40", Offset = "0x6AF9540", VA = "0x186AFAB40", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, BeardData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AFADA0", Offset = "0x6AF97A0", VA = "0x186AFADA0")]
	public JABHOBAJEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FGKNBJFKOEK : OHBLNCDIFCM<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA110", Offset = "0x6AF8B10", VA = "0x186AFA110")]
	public FGKNBJFKOEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CKMNOELHKEG : OHBLNCDIFCM<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9960", Offset = "0x6AF8360", VA = "0x186AF9960")]
	public CKMNOELHKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ELOGHIANGIM : OHBLNCDIFCM<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF99A0", Offset = "0x6AF83A0", VA = "0x186AF99A0")]
	public ELOGHIANGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JBIOILBADIL : HJJMIBBJHEM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6AFADE0", Offset = "0x6AF97E0", VA = "0x186AFADE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LKECGMEEMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB6A0", Offset = "0x6AFA0A0", VA = "0x186AFB6A0")]
		internal void CLLAELACCMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB7F0", Offset = "0x6AFA1F0", VA = "0x186AFB7F0")]
		internal void IMFDGIIONKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9F00", Offset = "0x6AF8900", VA = "0x186AF9F00")]
		internal void GBGJBCPMICK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB820", Offset = "0x6AFA220", VA = "0x186AFB820")]
		internal void PHIODAMBLHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB750", Offset = "0x6AFA150", VA = "0x186AFB750")]
		internal void EBHALKOOIIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB600", Offset = "0x6AFA000", VA = "0x186AFB600")]
		internal void BOMEMOACJNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB8C0", Offset = "0x6AFA2C0", VA = "0x186AFB8C0")]
		internal void POBHFBGKCBA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9530", Offset = "0x6AF7F30", VA = "0x186AF9530", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, HairData IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9260", Offset = "0x6AF7C60", VA = "0x186AF9260", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, HairData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9920", Offset = "0x6AF8320", VA = "0x186AF9920")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AOKLEBHMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8690", Offset = "0x6AF7090", VA = "0x186AF8690")]
		internal void CLLAELACCMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6AF88C0", Offset = "0x6AF72C0", VA = "0x186AF88C0")]
		internal void IMFDGIIONKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8770", Offset = "0x6AF7170", VA = "0x186AF8770")]
		internal void GBGJBCPMICK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8970", Offset = "0x6AF7370", VA = "0x186AF8970")]
		internal void PHIODAMBLHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6AF86C0", Offset = "0x6AF70C0", VA = "0x186AF86C0")]
		internal void EBHALKOOIIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6AF85F0", Offset = "0x6AF6FF0", VA = "0x186AF85F0")]
		internal void BOMEMOACJNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8A20", Offset = "0x6AF7420", VA = "0x186AF8A20")]
		internal void POBHFBGKCBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8820", Offset = "0x6AF7220", VA = "0x186AF8820")]
		internal void HCKNCKGFJPC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB160", Offset = "0x6AF9B60", VA = "0x186AFB160", Slot = "35")]
	public override void MOOGHMPJCPP(Utf8JsonReader JEAKAGANOAM, JsonSerializerOptions CLJCAFMAPFP, string NJIGKJGJPBF, AdditionalHatData IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAE20", Offset = "0x6AF9820", VA = "0x186AFAE20", Slot = "36")]
	public override void FIFDMBEALBF(Utf8JsonWriter NFLODIHODLH, AdditionalHatData KLABJGGMBGH, JsonSerializerOptions CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB5C0", Offset = "0x6AF9FC0", VA = "0x186AFB5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2AC0", VA = "0x1808A40C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9C3C00", Offset = "0x9C2600", VA = "0x1809C3C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xDBB870", Offset = "0xDBA270", VA = "0x180DBB870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1064F70", Offset = "0x1063970", VA = "0x181064F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1064F60", Offset = "0x1063960", VA = "0x181064F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x114C3A0", Offset = "0x114ADA0", VA = "0x18114C3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x114C3B0", Offset = "0x114ADB0", VA = "0x18114C3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1759860", Offset = "0x1758260", VA = "0x181759860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6AFD860", Offset = "0x6AFC260", VA = "0x186AFD860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x249F340", Offset = "0x249DD40", VA = "0x18249F340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x249F4B0", Offset = "0x249DEB0", VA = "0x18249F4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1D67B70", Offset = "0x1D66570", VA = "0x181D67B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1D67B80", Offset = "0x1D66580", VA = "0x181D67B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AvatarItemBodyType ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x928A90", Offset = "0x927490", VA = "0x180928A90")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x928820", Offset = "0x927220", VA = "0x180928820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JAKMGBMNCCH.MGOIBKLDNOG ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x90B290", Offset = "0x909C90", VA = "0x18090B290")]
			[CompilerGenerated]
			get
			{
				return default(JAKMGBMNCCH.MGOIBKLDNOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x90C330", Offset = "0x90AD30", VA = "0x18090C330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xADE180", Offset = "0xADCB80", VA = "0x180ADE180")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xADBBF0", Offset = "0xADA5F0", VA = "0x180ADBBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x12A7820", Offset = "0x12A6220", VA = "0x1812A7820")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3E8DE80", Offset = "0x3E8C880", VA = "0x183E8DE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
