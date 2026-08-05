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
public class MOFKKKECMKJ : PKKIHAOBEAH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x915820", Offset = "0x914C20", VA = "0x180915820", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C82F10", Offset = "0x6C82310", VA = "0x186C82F10", Slot = "36")]
	protected override Vector3 BPAOEELBMMH(float[] BIHDACIMKFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C82F60", Offset = "0x6C82360", VA = "0x186C82F60", Slot = "37")]
	protected override float[] KDAGEAEPDAP(Vector3 LIHHDPOHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C82FE0", Offset = "0x6C823E0", VA = "0x186C82FE0")]
	public MOFKKKECMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FOHILAFLODE : PKKIHAOBEAH<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x912E20", Offset = "0x912220", VA = "0x180912E20", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C81280", Offset = "0x6C80680", VA = "0x186C81280", Slot = "36")]
	protected override Vector2 BPAOEELBMMH(float[] BIHDACIMKFK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C812C0", Offset = "0x6C806C0", VA = "0x186C812C0", Slot = "37")]
	protected override float[] KDAGEAEPDAP(Vector2 LIHHDPOHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C81330", Offset = "0x6C80730", VA = "0x186C81330")]
	public FOHILAFLODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FGLLHCFKEIO : PKKIHAOBEAH<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x916370", Offset = "0x915770", VA = "0x180916370", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C81150", Offset = "0x6C80550", VA = "0x186C81150", Slot = "36")]
	protected override Quaternion BPAOEELBMMH(float[] BIHDACIMKFK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C811B0", Offset = "0x6C805B0", VA = "0x186C811B0", Slot = "37")]
	protected override float[] KDAGEAEPDAP(Quaternion LIHHDPOHLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C81240", Offset = "0x6C80640", VA = "0x186C81240")]
	public FGLLHCFKEIO()
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
		public enum HAPFADKJANA
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
		public HAPFADKJANA Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0")]
			[CompilerGenerated]
			get
			{
				return default(HAPFADKJANA);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B5800", Offset = "0x8B4C00", VA = "0x1808B5800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA7A590", Offset = "0xA79990", VA = "0x180A7A590")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NIGDPMPDNJD : IDKHCCKBMBP<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HNCJBINIOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HNCJBINIOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C81870", Offset = "0x6C80C70", VA = "0x186C81870")]
		internal void NKIKEMMGJFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C81660", Offset = "0x6C80A60", VA = "0x186C81660")]
		internal void KPCPKMHGGFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C819C0", Offset = "0x6C80DC0", VA = "0x186C819C0")]
		internal void PNHEEIENCKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C813B0", Offset = "0x6C807B0", VA = "0x186C813B0")]
		internal void DIJPAKDLMFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C815B0", Offset = "0x6C809B0", VA = "0x186C815B0")]
		internal void KFJDFJEONMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C81500", Offset = "0x6C80900", VA = "0x186C81500")]
		internal void GJNDNHOHPAH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C817C0", Offset = "0x6C80BC0", VA = "0x186C817C0")]
		internal void NJFPEIMFNIC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C81710", Offset = "0x6C80B10", VA = "0x186C81710")]
		internal void LGKLEPBNCNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C81460", Offset = "0x6C80860", VA = "0x186C81460")]
		internal void FPHEEKNCACM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C81920", Offset = "0x6C80D20", VA = "0x186C81920")]
		internal void OBGMLNIPMEN(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PLHAKFELBOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C83750", Offset = "0x6C82B50", VA = "0x186C83750", Slot = "35")]
	public override void IHFFJMLILDC(Utf8JsonReader OJMAIJPBMNC, JsonSerializerOptions AHOANCKGKEN, string IANCENADCFM, AnchorParamsRestrictions BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C832C0", Offset = "0x6C826C0", VA = "0x186C832C0", Slot = "36")]
	public override void ALDJONEEECH(Utf8JsonWriter NPFBBELPJIH, AnchorParamsRestrictions LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C83C70", Offset = "0x6C83070", VA = "0x186C83C70")]
	public NIGDPMPDNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7F50", Offset = "0x2FC7350", VA = "0x182FC7F50")]
	[CompilerGenerated]
	internal static void KJOGHLDHIIK<T>(string IANCENADCFM, T HMBPNLCBEEJ, T NAMMODIDCFJ, PLHAKFELBOC P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EOHFNLKBIDA : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void CCLBJGIMPLD(Utf8JsonReader CMEHKBHKHFB);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KGHDJDCJKLD
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
		public EOHFNLKBIDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CCLBJGIMPLD <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CCLBJGIMPLD <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CCLBJGIMPLD <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CCLBJGIMPLD <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CCLBJGIMPLD <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CCLBJGIMPLD <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CCLBJGIMPLD <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CCLBJGIMPLD <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CCLBJGIMPLD <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CCLBJGIMPLD <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CCLBJGIMPLD <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CCLBJGIMPLD <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CCLBJGIMPLD <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CCLBJGIMPLD <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KGHDJDCJKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C82050", Offset = "0x6C81450", VA = "0x186C82050")]
		internal void EILLOCBIGCM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C81D60", Offset = "0x6C81160", VA = "0x186C81D60")]
		internal void CIEPCACEJBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C820C0", Offset = "0x6C814C0", VA = "0x186C820C0")]
		internal void GOCBNENANLK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C81FA0", Offset = "0x6C813A0", VA = "0x186C81FA0")]
		internal void EILFFDOMPIO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C82220", Offset = "0x6C81620", VA = "0x186C82220")]
		internal void JAMLDIMGIIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C82170", Offset = "0x6C81570", VA = "0x186C82170")]
		internal void IMBCJCLOGAF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C822D0", Offset = "0x6C816D0", VA = "0x186C822D0")]
		internal void LGIJEIBMBCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C82090", Offset = "0x6C81490", VA = "0x186C82090")]
		internal void FPLKHHNECIO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C82520", Offset = "0x6C81920", VA = "0x186C82520")]
		internal void PIGJPHMBHFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C81E40", Offset = "0x6C81240", VA = "0x186C81E40")]
		internal void BFGDPKDPLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C81EC0", Offset = "0x6C812C0", VA = "0x186C81EC0")]
		internal void EECKHDPINKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C81E00", Offset = "0x6C81200", VA = "0x186C81E00")]
		internal void BCLFGEJGPFJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C82480", Offset = "0x6C81880", VA = "0x186C82480")]
		internal void OGGNNFAEBLL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C82300", Offset = "0x6C81700", VA = "0x186C82300")]
		internal void LJLDBNDNOHH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C801E0", Offset = "0x6C7F5E0", VA = "0x186C801E0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C80C60", Offset = "0x6C80060", VA = "0x186C80C60", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, SerializedAvatarItemData LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C80070", Offset = "0x6C7F470", VA = "0x186C80070")]
	private AdditionalOutfitTypeData JOFLNOFPGHI(Utf8JsonReader OJMAIJPBMNC, OutfitType LGJDMOCCBDP, JsonSerializerOptions AHOANCKGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C81110", Offset = "0x6C80510", VA = "0x186C81110")]
	public EOHFNLKBIDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MFFCBGHLNCO : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C82A20", Offset = "0x6C81E20", VA = "0x186C82A20", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader OJMAIJPBMNC, Type JHLMNODJIJH, JsonSerializerOptions AHOANCKGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C82DB0", Offset = "0x6C821B0", VA = "0x186C82DB0", Slot = "28")]
	public override void Write(Utf8JsonWriter NPFBBELPJIH, AvatarItemDownloadableConfig LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C82ED0", Offset = "0x6C822D0", VA = "0x186C82ED0")]
	public MFFCBGHLNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NAFPOBGPGBG : IDKHCCKBMBP<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C830E0", Offset = "0x6C824E0", VA = "0x186C830E0", Slot = "35")]
	public override void IHFFJMLILDC(Utf8JsonReader OJMAIJPBMNC, JsonSerializerOptions AHOANCKGKEN, string IANCENADCFM, BeardData BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C83020", Offset = "0x6C82420", VA = "0x186C83020", Slot = "36")]
	public override void ALDJONEEECH(Utf8JsonWriter NPFBBELPJIH, BeardData LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C83280", Offset = "0x6C82680", VA = "0x186C83280")]
	public NAFPOBGPGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NOAMONKPAEN : POACIPOHDFN<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C83CB0", Offset = "0x6C830B0", VA = "0x186C83CB0")]
	public NOAMONKPAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IOAFLPDMDEL : POACIPOHDFN<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81D90", Offset = "0x6C81190", VA = "0x186C81D90")]
	public IOAFLPDMDEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GOMPJMNAJBA : POACIPOHDFN<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C81370", Offset = "0x6C80770", VA = "0x186C81370")]
	public GOMPJMNAJBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DKENHJPPHMK : OGMKMBGLJOJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C80030", Offset = "0x6C7F430", VA = "0x186C80030")]
	public DKENHJPPHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CFPILPMPNAP : IDKHCCKBMBP<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JAPMNMCHGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JAPMNMCHGKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C81C80", Offset = "0x6C81080", VA = "0x186C81C80")]
		internal void NKIKEMMGJFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C81DD0", Offset = "0x6C811D0", VA = "0x186C81DD0")]
		internal void KPCPKMHGGFO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FE60", Offset = "0x6C7F260", VA = "0x186C7FE60", Slot = "35")]
	public override void IHFFJMLILDC(Utf8JsonReader OJMAIJPBMNC, JsonSerializerOptions AHOANCKGKEN, string IANCENADCFM, AdditionalFeetData BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FD90", Offset = "0x6C7F190", VA = "0x186C7FD90", Slot = "36")]
	public override void ALDJONEEECH(Utf8JsonWriter NPFBBELPJIH, AdditionalFeetData LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FFF0", Offset = "0x6C7F3F0", VA = "0x186C7FFF0")]
	public CFPILPMPNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OKDFPFLKFMC : IDKHCCKBMBP<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IHGHGLEOBID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IHGHGLEOBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C81CB0", Offset = "0x6C810B0", VA = "0x186C81CB0")]
		internal void NKIKEMMGJFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C81C50", Offset = "0x6C81050", VA = "0x186C81C50")]
		internal void KPCPKMHGGFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C81D60", Offset = "0x6C81160", VA = "0x186C81D60")]
		internal void PNHEEIENCKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C81A70", Offset = "0x6C80E70", VA = "0x186C81A70")]
		internal void DIJPAKDLMFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C81BB0", Offset = "0x6C80FB0", VA = "0x186C81BB0")]
		internal void KFJDFJEONMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C81B10", Offset = "0x6C80F10", VA = "0x186C81B10")]
		internal void GJNDNHOHPAH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C81C80", Offset = "0x6C81080", VA = "0x186C81C80")]
		internal void NJFPEIMFNIC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C83FC0", Offset = "0x6C833C0", VA = "0x186C83FC0", Slot = "35")]
	public override void IHFFJMLILDC(Utf8JsonReader OJMAIJPBMNC, JsonSerializerOptions AHOANCKGKEN, string IANCENADCFM, HairData BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C83CF0", Offset = "0x6C830F0", VA = "0x186C83CF0", Slot = "36")]
	public override void ALDJONEEECH(Utf8JsonWriter NPFBBELPJIH, HairData LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C843B0", Offset = "0x6C837B0", VA = "0x186C843B0")]
	public OKDFPFLKFMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PDJJIGDEFCI : IDKHCCKBMBP<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KIDJGEDHHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KIDJGEDHHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C82940", Offset = "0x6C81D40", VA = "0x186C82940")]
		internal void NKIKEMMGJFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C82750", Offset = "0x6C81B50", VA = "0x186C82750")]
		internal void KPCPKMHGGFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C82970", Offset = "0x6C81D70", VA = "0x186C82970")]
		internal void PNHEEIENCKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C82550", Offset = "0x6C81950", VA = "0x186C82550")]
		internal void DIJPAKDLMFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C826A0", Offset = "0x6C81AA0", VA = "0x186C826A0")]
		internal void KFJDFJEONMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C82600", Offset = "0x6C81A00", VA = "0x186C82600")]
		internal void GJNDNHOHPAH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C828A0", Offset = "0x6C81CA0", VA = "0x186C828A0")]
		internal void NJFPEIMFNIC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C82800", Offset = "0x6C81C00", VA = "0x186C82800")]
		internal void LGKLEPBNCNL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C84730", Offset = "0x6C83B30", VA = "0x186C84730", Slot = "35")]
	public override void IHFFJMLILDC(Utf8JsonReader OJMAIJPBMNC, JsonSerializerOptions AHOANCKGKEN, string IANCENADCFM, AdditionalHatData BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C843F0", Offset = "0x6C837F0", VA = "0x186C843F0", Slot = "36")]
	public override void ALDJONEEECH(Utf8JsonWriter NPFBBELPJIH, AdditionalHatData LIHHDPOHLDK, JsonSerializerOptions AHOANCKGKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C84B90", Offset = "0x6C83F90", VA = "0x186C84B90")]
	public PDJJIGDEFCI()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8AE520", Offset = "0x8AD920", VA = "0x1808AE520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x982980", Offset = "0x981D80", VA = "0x180982980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x982840", Offset = "0x981C40", VA = "0x180982840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x982990", Offset = "0x981D90", VA = "0x180982990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x982880", Offset = "0x981C80", VA = "0x180982880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1218790", Offset = "0x1217B90", VA = "0x181218790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x12187A0", Offset = "0x1217BA0", VA = "0x1812187A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x18BEE50", Offset = "0x18BE250", VA = "0x1818BEE50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6C84BD0", Offset = "0x6C83FD0", VA = "0x186C84BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x257C0D0", Offset = "0x257B4D0", VA = "0x18257C0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x257C0C0", Offset = "0x257B4C0", VA = "0x18257C0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1E408E0", Offset = "0x1E3FCE0", VA = "0x181E408E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1E408F0", Offset = "0x1E3FCF0", VA = "0x181E408F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AvatarItemBodyType ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9F06C0", Offset = "0x9EFAC0", VA = "0x1809F06C0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9EFD60", Offset = "0x9EF160", VA = "0x1809EFD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CLCNDMDBJIL.ACBJNAIFGMN ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9BE9C0", Offset = "0x9BDDC0", VA = "0x1809BE9C0")]
			[CompilerGenerated]
			get
			{
				return default(CLCNDMDBJIL.ACBJNAIFGMN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEC0", Offset = "0x9BC2C0", VA = "0x1809BCEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB90", Offset = "0x8ACF90", VA = "0x1808ADB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xBB1B50", Offset = "0xBB0F50", VA = "0x180BB1B50")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBAF2D0", Offset = "0xBAE6D0", VA = "0x180BAF2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x137E1F0", Offset = "0x137D5F0", VA = "0x18137E1F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x44DD6E0", Offset = "0x44DCAE0", VA = "0x1844DD6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
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
