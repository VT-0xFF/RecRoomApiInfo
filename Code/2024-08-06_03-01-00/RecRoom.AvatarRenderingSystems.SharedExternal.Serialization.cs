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
public class GDBPJEEOBBJ : NANCNCNLECN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9A2250", Offset = "0x9A0850", VA = "0x1809A2250", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6860610", Offset = "0x685EC10", VA = "0x186860610", Slot = "36")]
	protected override Vector3 MPNPLBKLIFJ(float[] EGCOBBLGNBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6860590", Offset = "0x685EB90", VA = "0x186860590", Slot = "37")]
	protected override float[] AAHIFJHBHEG(Vector3 FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6860660", Offset = "0x685EC60", VA = "0x186860660")]
	public GDBPJEEOBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NEAKBIPEPEM : NANCNCNLECN<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C0200", Offset = "0x9BE800", VA = "0x1809C0200", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6861E60", Offset = "0x6860460", VA = "0x186861E60", Slot = "36")]
	protected override Vector2 MPNPLBKLIFJ(float[] EGCOBBLGNBO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6861DF0", Offset = "0x68603F0", VA = "0x186861DF0", Slot = "37")]
	protected override float[] AAHIFJHBHEG(Vector2 FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6861EA0", Offset = "0x68604A0", VA = "0x186861EA0")]
	public NEAKBIPEPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FOBJLPBNFAO : NANCNCNLECN<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AB850", Offset = "0x9A9E50", VA = "0x1809AB850", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68604F0", Offset = "0x685EAF0", VA = "0x1868604F0", Slot = "36")]
	protected override Quaternion MPNPLBKLIFJ(float[] EGCOBBLGNBO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6860460", Offset = "0x685EA60", VA = "0x186860460", Slot = "37")]
	protected override float[] AAHIFJHBHEG(Quaternion FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6860550", Offset = "0x685EB50", VA = "0x186860550")]
	public FOBJLPBNFAO()
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
		public enum HBOLHDHMILG
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
		public HBOLHDHMILG Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0")]
			[CompilerGenerated]
			get
			{
				return default(HBOLHDHMILG);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85F4A0", Offset = "0x85DAA0", VA = "0x18085F4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA08B10", Offset = "0xA07110", VA = "0x180A08B10")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NFGKBHCNFIC : LMEJNNMKODG<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FNPNBHHPHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FNPNBHHPHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x685FDA0", Offset = "0x685E3A0", VA = "0x18685FDA0")]
		internal void DBMCOPLMBGD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68603B0", Offset = "0x685E9B0", VA = "0x1868603B0")]
		internal void OOEAGENECNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6860300", Offset = "0x685E900", VA = "0x186860300")]
		internal void OEMBNACPAPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6860100", Offset = "0x685E700", VA = "0x186860100")]
		internal void IIMGNJLIJHK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6860050", Offset = "0x685E650", VA = "0x186860050")]
		internal void HACODOKMOHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68601B0", Offset = "0x685E7B0", VA = "0x1868601B0")]
		internal void KDAHOFMBCHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x685FE50", Offset = "0x685E450", VA = "0x18685FE50")]
		internal void DPFIOHBECDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x685FF00", Offset = "0x685E500", VA = "0x18685FF00")]
		internal void GCHLKKBOFEE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6860260", Offset = "0x685E860", VA = "0x186860260")]
		internal void ODHDPEKIIBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x685FFB0", Offset = "0x685E5B0", VA = "0x18685FFB0")]
		internal void GLIPALKMHEC(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BNGEFEKLPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6862360", Offset = "0x6860960", VA = "0x186862360", Slot = "35")]
	public override void IPBIFDBOCPN(Utf8JsonReader NOHOKOEFICC, JsonSerializerOptions KMKBHLMADIH, string LOPDMJPKEBC, AnchorParamsRestrictions OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6861EE0", Offset = "0x68604E0", VA = "0x186861EE0", Slot = "36")]
	public override void FENAJLLICCN(Utf8JsonWriter PLACLKJNIBM, AnchorParamsRestrictions FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6862880", Offset = "0x6860E80", VA = "0x186862880")]
	public NFGKBHCNFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD110", Offset = "0x2CBB710", VA = "0x182CBD110")]
	[CompilerGenerated]
	internal static void OCBALJFOAOD<T>(string LOPDMJPKEBC, T GAELHANIPAM, T BFGENNACDPD, BNGEFEKLPHN P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NPCOBDNOLFE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void MOPPOLEFGBL(Utf8JsonReader IIMGHHPJFMO);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GJOPCLDJOBE
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
		public NPCOBDNOLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MOPPOLEFGBL <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MOPPOLEFGBL <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public MOPPOLEFGBL <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public MOPPOLEFGBL <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MOPPOLEFGBL <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MOPPOLEFGBL <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public MOPPOLEFGBL <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MOPPOLEFGBL <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MOPPOLEFGBL <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MOPPOLEFGBL <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public MOPPOLEFGBL <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MOPPOLEFGBL <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MOPPOLEFGBL <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MOPPOLEFGBL <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GJOPCLDJOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6860BD0", Offset = "0x685F1D0", VA = "0x186860BD0")]
		internal void NCDPNDDCFJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6860BA0", Offset = "0x685F1A0", VA = "0x186860BA0")]
		internal void LKDMINHCMJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6860C70", Offset = "0x685F270", VA = "0x186860C70")]
		internal void ONHJIKMGJLD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6860740", Offset = "0x685ED40", VA = "0x186860740")]
		internal void FDLKNPHJBNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6860AC0", Offset = "0x685F0C0", VA = "0x186860AC0")]
		internal void KFOFBFHEPBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6860D20", Offset = "0x685F320", VA = "0x186860D20")]
		internal void OPOMDBHDFAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6860B70", Offset = "0x685F170", VA = "0x186860B70")]
		internal void LIDDHICMBMM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6860C10", Offset = "0x685F210", VA = "0x186860C10")]
		internal void NDAMNJNELBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6860C40", Offset = "0x685F240", VA = "0x186860C40")]
		internal void NKLHEIPLEOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68607F0", Offset = "0x685EDF0", VA = "0x1868607F0")]
		internal void GDHELHNHHGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6860870", Offset = "0x685EE70", VA = "0x186860870")]
		internal void HABIGBKAMBB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6860950", Offset = "0x685EF50", VA = "0x186860950")]
		internal void HCFJCCHGCCB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68606A0", Offset = "0x685ECA0", VA = "0x1868606A0")]
		internal void EJEBDDHOOBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6860990", Offset = "0x685EF90", VA = "0x186860990")]
		internal void JOKEHOEPOEL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68629E0", Offset = "0x6860FE0", VA = "0x1868629E0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6863440", Offset = "0x6861A40", VA = "0x186863440", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, SerializedAvatarItemData FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68628C0", Offset = "0x6860EC0", VA = "0x1868628C0")]
	private AdditionalOutfitTypeData BFJLBIPIKDI(Utf8JsonReader NOHOKOEFICC, OutfitType BDKLEMDNAFL, JsonSerializerOptions KMKBHLMADIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68638F0", Offset = "0x6861EF0", VA = "0x1868638F0")]
	public NPCOBDNOLFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OKHNDLNFABD : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6863930", Offset = "0x6861F30", VA = "0x186863930", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader NOHOKOEFICC, Type FIEKCJDILDC, JsonSerializerOptions KMKBHLMADIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6863CA0", Offset = "0x68622A0", VA = "0x186863CA0", Slot = "28")]
	public override void Write(Utf8JsonWriter PLACLKJNIBM, AvatarItemDownloadableConfig FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6863D90", Offset = "0x6862390", VA = "0x186863D90")]
	public OKHNDLNFABD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AMECAKBIDFA : LMEJNNMKODG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x685ECA0", Offset = "0x685D2A0", VA = "0x18685ECA0", Slot = "35")]
	public override void IPBIFDBOCPN(Utf8JsonReader NOHOKOEFICC, JsonSerializerOptions KMKBHLMADIH, string LOPDMJPKEBC, BeardData OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x685EBE0", Offset = "0x685D1E0", VA = "0x18685EBE0", Slot = "36")]
	public override void FENAJLLICCN(Utf8JsonWriter PLACLKJNIBM, BeardData FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x685EE40", Offset = "0x685D440", VA = "0x18685EE40")]
	public AMECAKBIDFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DDIAAAGKLBE : HBGAFLKEMAG<NLLAHDIKCLL>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x685F620", Offset = "0x685DC20", VA = "0x18685F620")]
	public DDIAAAGKLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KHJJGLPPBHD : HBGAFLKEMAG<DNMEALPJKPD>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68615F0", Offset = "0x685FBF0", VA = "0x1868615F0")]
	public KHJJGLPPBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HCCIKPALLAC : HBGAFLKEMAG<DDLGGLOMBAN>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6860DD0", Offset = "0x685F3D0", VA = "0x186860DD0")]
	public HCCIKPALLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EMPPFLLFDIL : LNHMBIMLCKJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x685FD60", Offset = "0x685E360", VA = "0x18685FD60")]
	public EMPPFLLFDIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EEGKELMGPOA : LMEJNNMKODG<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MIBJGEPDCGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MIBJGEPDCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6861B00", Offset = "0x6860100", VA = "0x186861B00")]
		internal void DBMCOPLMBGD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6861DC0", Offset = "0x68603C0", VA = "0x186861DC0")]
		internal void OOEAGENECNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6860BA0", Offset = "0x685F1A0", VA = "0x186860BA0")]
		internal void OEMBNACPAPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6861C80", Offset = "0x6860280", VA = "0x186861C80")]
		internal void IIMGNJLIJHK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6861BE0", Offset = "0x68601E0", VA = "0x186861BE0")]
		internal void HACODOKMOHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6861D20", Offset = "0x6860320", VA = "0x186861D20")]
		internal void KDAHOFMBCHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6861BB0", Offset = "0x68601B0", VA = "0x186861BB0")]
		internal void DPFIOHBECDA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x685F930", Offset = "0x685DF30", VA = "0x18685F930", Slot = "35")]
	public override void IPBIFDBOCPN(Utf8JsonReader NOHOKOEFICC, JsonSerializerOptions KMKBHLMADIH, string LOPDMJPKEBC, HairData OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x685F660", Offset = "0x685DC60", VA = "0x18685F660", Slot = "36")]
	public override void FENAJLLICCN(Utf8JsonWriter PLACLKJNIBM, HairData FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x685FD20", Offset = "0x685E320", VA = "0x18685FD20")]
	public EEGKELMGPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HFJIKACFMGA : LMEJNNMKODG<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class LKMGBOBFGJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LKMGBOBFGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6861630", Offset = "0x685FC30", VA = "0x186861630")]
		internal void DBMCOPLMBGD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6861A50", Offset = "0x6860050", VA = "0x186861A50")]
		internal void OOEAGENECNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68619A0", Offset = "0x685FFA0", VA = "0x1868619A0")]
		internal void OEMBNACPAPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6861850", Offset = "0x685FE50", VA = "0x186861850")]
		internal void IIMGNJLIJHK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68617A0", Offset = "0x685FDA0", VA = "0x1868617A0")]
		internal void HACODOKMOHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6861900", Offset = "0x685FF00", VA = "0x186861900")]
		internal void KDAHOFMBCHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6861660", Offset = "0x685FC60", VA = "0x186861660")]
		internal void DPFIOHBECDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6861700", Offset = "0x685FD00", VA = "0x186861700")]
		internal void GCHLKKBOFEE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6861150", Offset = "0x685F750", VA = "0x186861150", Slot = "35")]
	public override void IPBIFDBOCPN(Utf8JsonReader NOHOKOEFICC, JsonSerializerOptions KMKBHLMADIH, string LOPDMJPKEBC, AdditionalHatData OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6860E10", Offset = "0x685F410", VA = "0x186860E10", Slot = "36")]
	public override void FENAJLLICCN(Utf8JsonWriter PLACLKJNIBM, AdditionalHatData FEBGGALLBNN, JsonSerializerOptions KMKBHLMADIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68615B0", Offset = "0x685FBB0", VA = "0x1868615B0")]
	public HFJIKACFMGA()
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
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x869B50", Offset = "0x868150", VA = "0x180869B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB4FA90", Offset = "0xB4E090", VA = "0x180B4FA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xC419D0", Offset = "0xC3FFD0", VA = "0x180C419D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xED2BC0", Offset = "0xED11C0", VA = "0x180ED2BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xED3430", Offset = "0xED1A30", VA = "0x180ED3430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1EE72E0", Offset = "0x1EE58E0", VA = "0x181EE72E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EE72F0", Offset = "0x1EE58F0", VA = "0x181EE72F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x14E1A90", Offset = "0x14E0090", VA = "0x1814E1A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6863DD0", Offset = "0x68623D0", VA = "0x186863DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2334D00", Offset = "0x2333300", VA = "0x182334D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2334A40", Offset = "0x2333040", VA = "0x182334A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1C15150", Offset = "0x1C13750", VA = "0x181C15150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1C15160", Offset = "0x1C13760", VA = "0x181C15160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CMBCMCPLEOA ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBFEF50", Offset = "0xBFD550", VA = "0x180BFEF50")]
			[CompilerGenerated]
			get
			{
				return default(CMBCMCPLEOA);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBFEA40", Offset = "0xBFD040", VA = "0x180BFEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LIBDCJLAIAP.JPKJJHCECFA ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA080C0", Offset = "0xA066C0", VA = "0x180A080C0")]
			[CompilerGenerated]
			get
			{
				return default(LIBDCJLAIAP.JPKJJHCECFA);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBFE6A0", Offset = "0xBFCCA0", VA = "0x180BFE6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x861730", Offset = "0x85FD30", VA = "0x180861730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x967280", Offset = "0x965880", VA = "0x180967280")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x965040", Offset = "0x963640", VA = "0x180965040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1131DD0", Offset = "0x11303D0", VA = "0x181131DD0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x417FFE0", Offset = "0x417E5E0", VA = "0x18417FFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
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
