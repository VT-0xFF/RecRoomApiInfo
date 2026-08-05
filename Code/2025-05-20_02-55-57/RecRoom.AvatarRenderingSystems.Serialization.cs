using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EOOLCDMNEBC : MKJPOOLKMMK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xBC9F20", Offset = "0xBC9120", VA = "0x180BC9F20", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B15120", Offset = "0x7B14320", VA = "0x187B15120", Slot = "36")]
	protected override Vector3 CHDGMGDGCFH(float[] CPMBLPBIGIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B15170", Offset = "0x7B14370", VA = "0x187B15170", Slot = "37")]
	protected override float[] EKNHBOFPBHM(Vector3 MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B151F0", Offset = "0x7B143F0", VA = "0x187B151F0")]
	public EOOLCDMNEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FCAHLMCCGEA : MKJPOOLKMMK<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBE5C50", Offset = "0xBE4E50", VA = "0x180BE5C50", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B15230", Offset = "0x7B14430", VA = "0x187B15230", Slot = "36")]
	protected override Vector2 CHDGMGDGCFH(float[] CPMBLPBIGIH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B15270", Offset = "0x7B14470", VA = "0x187B15270", Slot = "37")]
	protected override float[] EKNHBOFPBHM(Vector2 MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B152E0", Offset = "0x7B144E0", VA = "0x187B152E0")]
	public FCAHLMCCGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ACPFKFOPMOC : MKJPOOLKMMK<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBDBAC0", Offset = "0xBDACC0", VA = "0x180BDBAC0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B13450", Offset = "0x7B12650", VA = "0x187B13450", Slot = "36")]
	protected override Quaternion CHDGMGDGCFH(float[] CPMBLPBIGIH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B134B0", Offset = "0x7B126B0", VA = "0x187B134B0", Slot = "37")]
	protected override float[] EKNHBOFPBHM(Quaternion MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B13540", Offset = "0x7B12740", VA = "0x187B13540")]
	public ACPFKFOPMOC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum PELGPNMNJBM
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
		public PELGPNMNJBM Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(PELGPNMNJBM);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B13F50", Offset = "0x7B13150", VA = "0x187B13F50", Slot = "0")]
		public override bool Equals(object FNJGMJGALLH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B141C0", Offset = "0x7B133C0", VA = "0x187B141C0")]
		public static bool NDBPPCEOMJH(AvatarItemDownloadableConfig MHEJPNNFCGC, AvatarItemDownloadableConfig BGMAPCGDHFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B14080", Offset = "0x7B13280", VA = "0x187B14080", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B14150", Offset = "0x7B13350", VA = "0x187B14150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF2ADB0", Offset = "0xF29FB0", VA = "0x180F2ADB0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, FDEINOGEHIH, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SerializedAvatarItemId AvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SerializedCombinationId CombinationId;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B19440", Offset = "0x7B18640", VA = "0x187B19440")]
		private void BHNPLFKPIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B194D0", Offset = "0x7B186D0", VA = "0x187B194D0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B19550", Offset = "0x7B18750", VA = "0x187B19550", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B19440", Offset = "0x7B18640", VA = "0x187B19440", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B19650", Offset = "0x7B18850", VA = "0x187B19650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FOAHBJAGCCB : CBLLCDFAJDF<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HAAJHKKFOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HAAJHKKFOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B16270", Offset = "0x7B15470", VA = "0x187B16270")]
		internal void OCEDCJIHKDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B15F10", Offset = "0x7B15110", VA = "0x187B15F10")]
		internal void DMOEJCMDBFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B15FC0", Offset = "0x7B151C0", VA = "0x187B15FC0")]
		internal void DNMPOPGANBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B16070", Offset = "0x7B15270", VA = "0x187B16070")]
		internal void HBJGGFADFJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B15D10", Offset = "0x7B14F10", VA = "0x187B15D10")]
		internal void BELNLJKJFLH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B16320", Offset = "0x7B15520", VA = "0x187B16320")]
		internal void OODODEAOMGJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B15DC0", Offset = "0x7B14FC0", VA = "0x187B15DC0")]
		internal void BFFHGGMHAGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B161C0", Offset = "0x7B153C0", VA = "0x187B161C0")]
		internal void MNFDHNEAOPN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B16120", Offset = "0x7B15320", VA = "0x187B16120")]
		internal void KBKMHDKNHAF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B15E70", Offset = "0x7B15070", VA = "0x187B15E70")]
		internal void BOJPKBDFLGG(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GKJGDKLGDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B15320", Offset = "0x7B14520", VA = "0x187B15320", Slot = "35")]
	public override void ICOBFJCILBI(Utf8JsonReader OHHBENOLPAE, JsonSerializerOptions KDLGPMFPDII, string LGOOKHKOCFM, AnchorParamsRestrictions CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B15840", Offset = "0x7B14A40", VA = "0x187B15840", Slot = "36")]
	public override void MMEIHCMCFBN(Utf8JsonWriter GDEDILINNBI, AnchorParamsRestrictions MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B15CD0", Offset = "0x7B14ED0", VA = "0x187B15CD0")]
	public FOAHBJAGCCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3807960", Offset = "0x3806B60", VA = "0x183807960")]
	[CompilerGenerated]
	internal static void LPILNLFGMNJ<T>(string LGOOKHKOCFM, T KFEGNKODPFP, T MFACCPCFPBK, GKJGDKLGDBK P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LDADJDDMNJL : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void PCIPAHPFIND(Utf8JsonReader DENDMCHJGLJ);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NCENNABMFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public SerializedAvatarItemData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public bool hasReadOutfitType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LDADJDDMNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public PCIPAHPFIND <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PCIPAHPFIND <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PCIPAHPFIND <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public PCIPAHPFIND <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public PCIPAHPFIND <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PCIPAHPFIND <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PCIPAHPFIND <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PCIPAHPFIND <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PCIPAHPFIND <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PCIPAHPFIND <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PCIPAHPFIND <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NCENNABMFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B187E0", Offset = "0x7B179E0", VA = "0x187B187E0")]
		internal void EMPNFJEPIJN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B18C10", Offset = "0x7B17E10", VA = "0x187B18C10")]
		internal void OLGGCFHJHEA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B18820", Offset = "0x7B17A20", VA = "0x187B18820")]
		internal void GIHNGAGDIIO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B18A50", Offset = "0x7B17C50", VA = "0x187B18A50")]
		internal void KCKCDNHPHBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B185D0", Offset = "0x7B177D0", VA = "0x187B185D0")]
		internal void CMJFBDHKGAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B18BE0", Offset = "0x7B17DE0", VA = "0x187B18BE0")]
		internal void NAEAMHMHJKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B18720", Offset = "0x7B17920", VA = "0x187B18720")]
		internal void EDNEGCLHDMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B18B00", Offset = "0x7B17D00", VA = "0x187B18B00")]
		internal void NAAOINHGLIG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B187A0", Offset = "0x7B179A0", VA = "0x187B187A0")]
		internal void EFIJBNHKHFG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B18680", Offset = "0x7B17880", VA = "0x187B18680")]
		internal void DJPIDHFFAJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B188D0", Offset = "0x7B17AD0", VA = "0x187B188D0")]
		internal void GMLBFFPJKPA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MIHAGAGIPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MIHAGAGIPHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B18530", Offset = "0x7B17730", VA = "0x187B18530")]
		internal void DKEEADBNHML(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B174A0", Offset = "0x7B166A0", VA = "0x187B174A0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B18080", Offset = "0x7B17280", VA = "0x187B18080", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, SerializedAvatarItemData MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B17330", Offset = "0x7B16530", VA = "0x187B17330")]
	private AdditionalOutfitTypeData FJBLEPKHCKI(Utf8JsonReader OHHBENOLPAE, OutfitType EDLOHJEBKFM, JsonSerializerOptions KDLGPMFPDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B184C0", Offset = "0x7B176C0", VA = "0x187B184C0")]
	public LDADJDDMNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AMAAIDNOMLJ : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B13580", Offset = "0x7B12780", VA = "0x187B13580", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader OHHBENOLPAE, Type HJKECCGFFIB, JsonSerializerOptions KDLGPMFPDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B13910", Offset = "0x7B12B10", VA = "0x187B13910", Slot = "28")]
	public override void Write(Utf8JsonWriter GDEDILINNBI, AvatarItemDownloadableConfig MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B13A40", Offset = "0x7B12C40", VA = "0x187B13A40")]
	public AMAAIDNOMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PLHIGHPMLNI : CBLLCDFAJDF<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B18CC0", Offset = "0x7B17EC0", VA = "0x187B18CC0", Slot = "35")]
	public override void ICOBFJCILBI(Utf8JsonReader OHHBENOLPAE, JsonSerializerOptions KDLGPMFPDII, string LGOOKHKOCFM, BeardData CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B18E60", Offset = "0x7B18060", VA = "0x187B18E60", Slot = "36")]
	public override void MMEIHCMCFBN(Utf8JsonWriter GDEDILINNBI, BeardData MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B18F20", Offset = "0x7B18120", VA = "0x187B18F20")]
	public PLHIGHPMLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BKIEGHJIAII : GNPPMNFJAAP<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B14AE0", Offset = "0x7B13CE0", VA = "0x187B14AE0")]
	public BKIEGHJIAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KOFMGEFJILE : GNPPMNFJAAP<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B172F0", Offset = "0x7B164F0", VA = "0x187B172F0")]
	public KOFMGEFJILE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CLEAMKAGEEL : GNPPMNFJAAP<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B14B20", Offset = "0x7B13D20", VA = "0x187B14B20")]
	public CLEAMKAGEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KKLBOHPPFPE : JOLGDGIKBLN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B172B0", Offset = "0x7B164B0", VA = "0x187B172B0")]
	public KKLBOHPPFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DAAKIHGMDDK : CBLLCDFAJDF<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LPDGBIPAADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LPDGBIPAADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B14EA0", Offset = "0x7B140A0", VA = "0x187B14EA0")]
		internal void OCEDCJIHKDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B18500", Offset = "0x7B17700", VA = "0x187B18500")]
		internal void DMOEJCMDBFK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B14B60", Offset = "0x7B13D60", VA = "0x187B14B60", Slot = "35")]
	public override void ICOBFJCILBI(Utf8JsonReader OHHBENOLPAE, JsonSerializerOptions KDLGPMFPDII, string LGOOKHKOCFM, AdditionalFeetData CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B14CF0", Offset = "0x7B13EF0", VA = "0x187B14CF0", Slot = "36")]
	public override void MMEIHCMCFBN(Utf8JsonWriter GDEDILINNBI, AdditionalFeetData MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7B14DC0", Offset = "0x7B13FC0", VA = "0x187B14DC0")]
	public DAAKIHGMDDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HNLEMBPNOPG : CBLLCDFAJDF<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EDDKELOPIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EDDKELOPIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B14FD0", Offset = "0x7B141D0", VA = "0x187B14FD0")]
		internal void OCEDCJIHKDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B14ED0", Offset = "0x7B140D0", VA = "0x187B14ED0")]
		internal void DMOEJCMDBFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B14F00", Offset = "0x7B14100", VA = "0x187B14F00")]
		internal void DNMPOPGANBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B14F30", Offset = "0x7B14130", VA = "0x187B14F30")]
		internal void HBJGGFADFJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B14E00", Offset = "0x7B14000", VA = "0x187B14E00")]
		internal void BELNLJKJFLH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B15080", Offset = "0x7B14280", VA = "0x187B15080")]
		internal void OODODEAOMGJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B14EA0", Offset = "0x7B140A0", VA = "0x187B14EA0")]
		internal void BFFHGGMHAGE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B163D0", Offset = "0x7B155D0", VA = "0x187B163D0", Slot = "35")]
	public override void ICOBFJCILBI(Utf8JsonReader OHHBENOLPAE, JsonSerializerOptions KDLGPMFPDII, string LGOOKHKOCFM, HairData CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B167C0", Offset = "0x7B159C0", VA = "0x187B167C0", Slot = "36")]
	public override void MMEIHCMCFBN(Utf8JsonWriter GDEDILINNBI, HairData MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B16A90", Offset = "0x7B15C90", VA = "0x187B16A90")]
	public HNLEMBPNOPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KAGLHANMJNE : CBLLCDFAJDF<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AOELCLDKDBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AOELCLDKDBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B13E80", Offset = "0x7B13080", VA = "0x187B13E80")]
		internal void OCEDCJIHKDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B13BD0", Offset = "0x7B12DD0", VA = "0x187B13BD0")]
		internal void DMOEJCMDBFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B13C80", Offset = "0x7B12E80", VA = "0x187B13C80")]
		internal void DNMPOPGANBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B13D30", Offset = "0x7B12F30", VA = "0x187B13D30")]
		internal void HBJGGFADFJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B13A80", Offset = "0x7B12C80", VA = "0x187B13A80")]
		internal void BELNLJKJFLH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B13EB0", Offset = "0x7B130B0", VA = "0x187B13EB0")]
		internal void OODODEAOMGJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B13B30", Offset = "0x7B12D30", VA = "0x187B13B30")]
		internal void BFFHGGMHAGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B13DE0", Offset = "0x7B12FE0", VA = "0x187B13DE0")]
		internal void MNFDHNEAOPN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B16AD0", Offset = "0x7B15CD0", VA = "0x187B16AD0", Slot = "35")]
	public override void ICOBFJCILBI(Utf8JsonReader OHHBENOLPAE, JsonSerializerOptions KDLGPMFPDII, string LGOOKHKOCFM, AdditionalHatData CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7B16F30", Offset = "0x7B16130", VA = "0x187B16F30", Slot = "36")]
	public override void MMEIHCMCFBN(Utf8JsonWriter GDEDILINNBI, AdditionalHatData MLCDCHNOCFI, JsonSerializerOptions KDLGPMFPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B17270", Offset = "0x7B16470", VA = "0x187B17270")]
	public KAGLHANMJNE()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xDC4270", Offset = "0xDC3470", VA = "0x180DC4270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xDC4280", Offset = "0xDC3480", VA = "0x180DC4280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF45120", Offset = "0xF44320", VA = "0x180F45120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF45010", Offset = "0xF44210", VA = "0x180F45010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1F67E70", Offset = "0x1F67070", VA = "0x181F67E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7B19430", Offset = "0x7B18630", VA = "0x187B19430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B940A0", Offset = "0x2B932A0", VA = "0x182B940A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B940B0", Offset = "0x2B932B0", VA = "0x182B940B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCBAC40", Offset = "0xCB9E40", VA = "0x180CBAC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCBAC90", Offset = "0xCB9E90", VA = "0x180CBAC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JHAAOOMONHE.GKJIKMBGLPD ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			[CompilerGenerated]
			get
			{
				return default(JHAAOOMONHE.GKJIKMBGLPD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6F03C40", Offset = "0x6F02E40", VA = "0x186F03C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B18F90", Offset = "0x7B18190", VA = "0x187B18F90", Slot = "0")]
		public override bool Equals(object FNJGMJGALLH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B19410", Offset = "0x7B18610", VA = "0x187B19410")]
		public static bool NDBPPCEOMJH(SerializedAvatarItemData MHEJPNNFCGC, SerializedAvatarItemData BGMAPCGDHFK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B18F60", Offset = "0x7B18160", VA = "0x187B18F60")]
		public static bool EFJOOJHLAGB(SerializedAvatarItemData MHEJPNNFCGC, SerializedAvatarItemData BGMAPCGDHFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B19020", Offset = "0x7B18220", VA = "0x187B19020", Slot = "4")]
		public bool Equals(SerializedAvatarItemData FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B19340", Offset = "0x7B18540", VA = "0x187B19340", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
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
