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
public class DOLJDALFPPE : JIDHCBOMFAE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x975850", Offset = "0x974250", VA = "0x180975850", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E7C0", Offset = "0x6A3D1C0", VA = "0x186A3E7C0", Slot = "36")]
	protected override Vector3 FKPGHHJGCLC(float[] KIAGDMGGGNM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E810", Offset = "0x6A3D210", VA = "0x186A3E810", Slot = "37")]
	protected override float[] OPHIMHIMIKB(Vector3 IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E890", Offset = "0x6A3D290", VA = "0x186A3E890")]
	public DOLJDALFPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OOPIJJFLGML : JIDHCBOMFAE<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x975980", Offset = "0x974380", VA = "0x180975980", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A41D20", Offset = "0x6A40720", VA = "0x186A41D20", Slot = "36")]
	protected override Vector2 FKPGHHJGCLC(float[] KIAGDMGGGNM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A41D60", Offset = "0x6A40760", VA = "0x186A41D60", Slot = "37")]
	protected override float[] OPHIMHIMIKB(Vector2 IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A41DD0", Offset = "0x6A407D0", VA = "0x186A41DD0")]
	public OOPIJJFLGML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GJEGAJNFIIB : JIDHCBOMFAE<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB21460", Offset = "0xB1FE60", VA = "0x180B21460", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F4A0", Offset = "0x6A3DEA0", VA = "0x186A3F4A0", Slot = "36")]
	protected override Quaternion FKPGHHJGCLC(float[] KIAGDMGGGNM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F500", Offset = "0x6A3DF00", VA = "0x186A3F500", Slot = "37")]
	protected override float[] OPHIMHIMIKB(Quaternion IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F590", Offset = "0x6A3DF90", VA = "0x186A3F590")]
	public GJEGAJNFIIB()
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
		public enum JMMDOOEHEJO
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
		public JMMDOOEHEJO Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
			[CompilerGenerated]
			get
			{
				return default(JMMDOOEHEJO);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x889F40", Offset = "0x888940", VA = "0x180889F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9954A0", Offset = "0x993EA0", VA = "0x1809954A0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NLBCIFKKOIL : BHBKCEKEBDB<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MEIFFLBDKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MEIFFLBDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FB00", Offset = "0x6A3E500", VA = "0x186A3FB00")]
		internal void DFBGMPHCKFE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F9A0", Offset = "0x6A3E3A0", VA = "0x186A3F9A0")]
		internal void CGCJFBNFDJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F8F0", Offset = "0x6A3E2F0", VA = "0x186A3F8F0")]
		internal void ACJILEODABO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FF00", Offset = "0x6A3E900", VA = "0x186A3FF00")]
		internal void NJAMCADDDEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FE50", Offset = "0x6A3E850", VA = "0x186A3FE50")]
		internal void JOBPCLLGMOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FDA0", Offset = "0x6A3E7A0", VA = "0x186A3FDA0")]
		internal void HPKIDIIIIIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FCF0", Offset = "0x6A3E6F0", VA = "0x186A3FCF0")]
		internal void HDFHHDIIJME(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FA50", Offset = "0x6A3E450", VA = "0x186A3FA50")]
		internal void DCJKPBAFKIC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FBB0", Offset = "0x6A3E5B0", VA = "0x186A3FBB0")]
		internal void FLFAONPDICP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FC50", Offset = "0x6A3E650", VA = "0x186A3FC50")]
		internal void FNJEPFCDEAL(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BLLIOOOJECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A402A0", Offset = "0x6A3ECA0", VA = "0x186A402A0", Slot = "35")]
	public override void DEOHLMKMJOA(Utf8JsonReader BPJDDKOBEGL, JsonSerializerOptions JIEJKJIJPFC, string PCFKMOBOMBL, AnchorParamsRestrictions LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A407C0", Offset = "0x6A3F1C0", VA = "0x186A407C0", Slot = "36")]
	public override void NMHFLKAFACB(Utf8JsonWriter HJIMDHLCBKF, AnchorParamsRestrictions IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C50", Offset = "0x6A3F650", VA = "0x186A40C50")]
	public NLBCIFKKOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2ED97E0", Offset = "0x2ED81E0", VA = "0x182ED97E0")]
	[CompilerGenerated]
	internal static void NEKDLAJKCJA<T>(string PCFKMOBOMBL, T POCLHBJGKBH, T IAELDMKMACP, BLLIOOOJECM P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ONCLEKHNMLE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void CGOHPJCKJDN(Utf8JsonReader CLCPGILFJHI);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CGNKONGEOMM
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
		public ONCLEKHNMLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CGOHPJCKJDN <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CGOHPJCKJDN <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CGOHPJCKJDN <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CGOHPJCKJDN <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CGOHPJCKJDN <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CGOHPJCKJDN <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CGOHPJCKJDN <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CGOHPJCKJDN <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CGOHPJCKJDN <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CGOHPJCKJDN <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CGOHPJCKJDN <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CGOHPJCKJDN <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CGOHPJCKJDN <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CGOHPJCKJDN <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CGNKONGEOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DBF0", Offset = "0x6A3C5F0", VA = "0x186A3DBF0")]
		internal void GGKALMFJIKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD10", Offset = "0x6A3C710", VA = "0x186A3DD10")]
		internal void HPCCLAMMENF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D990", Offset = "0x6A3C390", VA = "0x186A3D990")]
		internal void AMBNMDAEJHH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DAE0", Offset = "0x6A3C4E0", VA = "0x186A3DAE0")]
		internal void DBONJPFDCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD40", Offset = "0x6A3C740", VA = "0x186A3DD40")]
		internal void HPIMBFOJFKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DC30", Offset = "0x6A3C630", VA = "0x186A3DC30")]
		internal void HIDDNLLPCDK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DCE0", Offset = "0x6A3C6E0", VA = "0x186A3DCE0")]
		internal void HOENJCMGGMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DB90", Offset = "0x6A3C590", VA = "0x186A3DB90")]
		internal void FNDDACCKBOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DBC0", Offset = "0x6A3C5C0", VA = "0x186A3DBC0")]
		internal void GBEHPHKEEOJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DDF0", Offset = "0x6A3C7F0", VA = "0x186A3DDF0")]
		internal void JOLMMJBMJJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D8B0", Offset = "0x6A3C2B0", VA = "0x186A3D8B0")]
		internal void AAOOCHJJJOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D870", Offset = "0x6A3C270", VA = "0x186A3D870")]
		internal void AAJPAEKBBDF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DA40", Offset = "0x6A3C440", VA = "0x186A3DA40")]
		internal void CGDOEBMNJLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DE70", Offset = "0x6A3C870", VA = "0x186A3DE70")]
		internal void KADJENLEHIG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A40DB0", Offset = "0x6A3F7B0", VA = "0x186A40DB0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A41830", Offset = "0x6A40230", VA = "0x186A41830", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, SerializedAvatarItemData IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C90", Offset = "0x6A3F690", VA = "0x186A40C90")]
	private AdditionalOutfitTypeData IKLPJIKGOHL(Utf8JsonReader BPJDDKOBEGL, OutfitType AOGCIMANLIJ, JsonSerializerOptions JIEJKJIJPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A41CE0", Offset = "0x6A406E0", VA = "0x186A41CE0")]
	public ONCLEKHNMLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CGBPNFCDIDB : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D380", Offset = "0x6A3BD80", VA = "0x186A3D380", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader BPJDDKOBEGL, Type LDKIIDHBEKA, JsonSerializerOptions JIEJKJIJPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D710", Offset = "0x6A3C110", VA = "0x186A3D710", Slot = "28")]
	public override void Write(Utf8JsonWriter HJIMDHLCBKF, AvatarItemDownloadableConfig IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D830", Offset = "0x6A3C230", VA = "0x186A3D830")]
	public CGBPNFCDIDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HJIMNFFCDOI : BHBKCEKEBDB<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F650", Offset = "0x6A3E050", VA = "0x186A3F650", Slot = "35")]
	public override void DEOHLMKMJOA(Utf8JsonReader BPJDDKOBEGL, JsonSerializerOptions JIEJKJIJPFC, string PCFKMOBOMBL, BeardData LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F7F0", Offset = "0x6A3E1F0", VA = "0x186A3F7F0", Slot = "36")]
	public override void NMHFLKAFACB(Utf8JsonWriter HJIMDHLCBKF, BeardData IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F8B0", Offset = "0x6A3E2B0", VA = "0x186A3F8B0")]
	public HJIMNFFCDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PNJPEKJDECI : BDHNBMIEELD<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A41E10", Offset = "0x6A40810", VA = "0x186A41E10")]
	public PNJPEKJDECI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DGMHJEIOGPP : BDHNBMIEELD<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E780", Offset = "0x6A3D180", VA = "0x186A3E780")]
	public DGMHJEIOGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GMHBMPOFIEK : BDHNBMIEELD<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F5D0", Offset = "0x6A3DFD0", VA = "0x186A3F5D0")]
	public GMHBMPOFIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HEPICOOJBCD : CLDMALMKIAL<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F610", Offset = "0x6A3E010", VA = "0x186A3F610")]
	public HEPICOOJBCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EFPHGEFALEO : BHBKCEKEBDB<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NAHHNNPCNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public NAHHNNPCNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FFE0", Offset = "0x6A3E9E0", VA = "0x186A3FFE0")]
		internal void DFBGMPHCKFE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A3FFB0", Offset = "0x6A3E9B0", VA = "0x186A3FFB0")]
		internal void CGCJFBNFDJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD10", Offset = "0x6A3C710", VA = "0x186A3DD10")]
		internal void ACJILEODABO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A40200", Offset = "0x6A3EC00", VA = "0x186A40200")]
		internal void NJAMCADDDEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A40160", Offset = "0x6A3EB60", VA = "0x186A40160")]
		internal void JOBPCLLGMOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A400C0", Offset = "0x6A3EAC0", VA = "0x186A400C0")]
		internal void HPKIDIIIIIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A40090", Offset = "0x6A3EA90", VA = "0x186A40090")]
		internal void HDFHHDIIJME(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E8D0", Offset = "0x6A3D2D0", VA = "0x186A3E8D0", Slot = "35")]
	public override void DEOHLMKMJOA(Utf8JsonReader BPJDDKOBEGL, JsonSerializerOptions JIEJKJIJPFC, string PCFKMOBOMBL, HairData LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ECC0", Offset = "0x6A3D6C0", VA = "0x186A3ECC0", Slot = "36")]
	public override void NMHFLKAFACB(Utf8JsonWriter HJIMDHLCBKF, HairData IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EF90", Offset = "0x6A3D990", VA = "0x186A3EF90")]
	public EFPHGEFALEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CPHDOHIMDPM : BHBKCEKEBDB<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EGPONJCPMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EGPONJCPMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F1D0", Offset = "0x6A3DBD0", VA = "0x186A3F1D0")]
		internal void DFBGMPHCKFE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F080", Offset = "0x6A3DA80", VA = "0x186A3F080")]
		internal void CGCJFBNFDJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EFD0", Offset = "0x6A3D9D0", VA = "0x186A3EFD0")]
		internal void ACJILEODABO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F3F0", Offset = "0x6A3DDF0", VA = "0x186A3F3F0")]
		internal void NJAMCADDDEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F340", Offset = "0x6A3DD40", VA = "0x186A3F340")]
		internal void JOBPCLLGMOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F2A0", Offset = "0x6A3DCA0", VA = "0x186A3F2A0")]
		internal void HPKIDIIIIIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F200", Offset = "0x6A3DC00", VA = "0x186A3F200")]
		internal void HDFHHDIIJME(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F130", Offset = "0x6A3DB30", VA = "0x186A3F130")]
		internal void DCJKPBAFKIC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DFA0", Offset = "0x6A3C9A0", VA = "0x186A3DFA0", Slot = "35")]
	public override void DEOHLMKMJOA(Utf8JsonReader BPJDDKOBEGL, JsonSerializerOptions JIEJKJIJPFC, string PCFKMOBOMBL, AdditionalHatData LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E400", Offset = "0x6A3CE00", VA = "0x186A3E400", Slot = "36")]
	public override void NMHFLKAFACB(Utf8JsonWriter HJIMDHLCBKF, AdditionalHatData IPHMAHBENGI, JsonSerializerOptions JIEJKJIJPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E740", Offset = "0x6A3D140", VA = "0x186A3E740")]
	public CPHDOHIMDPM()
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
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x885600", Offset = "0x884000", VA = "0x180885600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9A6B00", Offset = "0x9A5500", VA = "0x1809A6B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xDA7090", Offset = "0xDA5A90", VA = "0x180DA7090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x103E070", Offset = "0x103CA70", VA = "0x18103E070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x103D5F0", Offset = "0x103BFF0", VA = "0x18103D5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1137480", Offset = "0x1135E80", VA = "0x181137480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1137490", Offset = "0x1135E90", VA = "0x181137490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1744040", Offset = "0x1742A40", VA = "0x181744040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A41E50", Offset = "0x6A40850", VA = "0x186A41E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2480B10", Offset = "0x247F510", VA = "0x182480B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x24809A0", Offset = "0x247F3A0", VA = "0x1824809A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1D508C0", Offset = "0x1D4F2C0", VA = "0x181D508C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1D508D0", Offset = "0x1D4F2D0", VA = "0x181D508D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AvatarItemBodyType ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x90FDC0", Offset = "0x90E7C0", VA = "0x18090FDC0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x90FA60", Offset = "0x90E460", VA = "0x18090FA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PCNNDLGLKGM.MLOLFLCAEKK ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FDDD0", Offset = "0x8FC7D0", VA = "0x1808FDDD0")]
			[CompilerGenerated]
			get
			{
				return default(PCNNDLGLKGM.MLOLFLCAEKK);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x900260", Offset = "0x8FEC60", VA = "0x180900260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x88B2A0", Offset = "0x889CA0", VA = "0x18088B2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xACB440", Offset = "0xAC9E40", VA = "0x180ACB440")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAC8F20", Offset = "0xAC7920", VA = "0x180AC8F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1292BB0", Offset = "0x12915B0", VA = "0x181292BB0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4392F80", Offset = "0x4391980", VA = "0x184392F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
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
