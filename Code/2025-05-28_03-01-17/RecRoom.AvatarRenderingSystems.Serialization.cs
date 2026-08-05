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
public class PONHAFADENM : GDMMBAIPNKI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xBE3EC0", Offset = "0xBE2CC0", VA = "0x180BE3EC0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AD80", Offset = "0x7C19B80", VA = "0x187C1AD80", Slot = "36")]
	protected override Vector3 FGCIBHABPPJ(float[] BGBLHEHBHCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AD00", Offset = "0x7C19B00", VA = "0x187C1AD00", Slot = "37")]
	protected override float[] ABDKJFIDJKI(Vector3 OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C1ADD0", Offset = "0x7C19BD0", VA = "0x187C1ADD0")]
	public PONHAFADENM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IKJGKHNFAJC : GDMMBAIPNKI<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBFC230", Offset = "0xBFB030", VA = "0x180BFC230", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C19820", Offset = "0x7C18620", VA = "0x187C19820", Slot = "36")]
	protected override Vector2 FGCIBHABPPJ(float[] BGBLHEHBHCD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C197B0", Offset = "0x7C185B0", VA = "0x187C197B0", Slot = "37")]
	protected override float[] ABDKJFIDJKI(Vector2 OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C19860", Offset = "0x7C18660", VA = "0x187C19860")]
	public IKJGKHNFAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BNLHMDAKADB : GDMMBAIPNKI<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBF5C80", Offset = "0xBF4A80", VA = "0x180BF5C80", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C163A0", Offset = "0x7C151A0", VA = "0x187C163A0", Slot = "36")]
	protected override Quaternion FGCIBHABPPJ(float[] BGBLHEHBHCD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C16310", Offset = "0x7C15110", VA = "0x187C16310", Slot = "37")]
	protected override float[] ABDKJFIDJKI(Quaternion OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C16400", Offset = "0x7C15200", VA = "0x187C16400")]
	public BNLHMDAKADB()
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
		public enum NKKDBOBMLJB
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
		public NKKDBOBMLJB Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
			[CompilerGenerated]
			get
			{
				return default(NKKDBOBMLJB);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C15780", Offset = "0x7C14580", VA = "0x187C15780", Slot = "0")]
		public override bool Equals(object HBLONCAMFLG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C159F0", Offset = "0x7C147F0", VA = "0x187C159F0")]
		public static bool PBEBFPKJKLO(AvatarItemDownloadableConfig EFOOGHNHGNH, AvatarItemDownloadableConfig IFJAPBHAPEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C158B0", Offset = "0x7C146B0", VA = "0x187C158B0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C15980", Offset = "0x7C14780", VA = "0x187C15980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF5D240", Offset = "0xF5C040", VA = "0x180F5D240")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, DNDKCNAJEIA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7C1B480", Offset = "0x7C1A280", VA = "0x187C1B480")]
		private void LBJFPEIELEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B300", Offset = "0x7C1A100", VA = "0x187C1B300", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B380", Offset = "0x7C1A180", VA = "0x187C1B380", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B470", Offset = "0x7C1A270", VA = "0x187C1B470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B2E0", Offset = "0x7C1A0E0", VA = "0x187C1B2E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection HBLONCAMFLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x111AB20", Offset = "0x1119920", VA = "0x18111AB20", Slot = "6")]
		public Guid DAGIDHCNBOK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B480", Offset = "0x7C1A280", VA = "0x187C1B480", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B4F0", Offset = "0x7C1A2F0", VA = "0x187C1B4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MLAMHBLDLJL : LIEJLPJOBJK<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FKPCPIFOMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FKPCPIFOMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C18E50", Offset = "0x7C17C50", VA = "0x187C18E50")]
		internal void APHMDJEIAAI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C19260", Offset = "0x7C18060", VA = "0x187C19260")]
		internal void HHOKAACPJDC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C191B0", Offset = "0x7C17FB0", VA = "0x187C191B0")]
		internal void GIFJEAEAHJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C193C0", Offset = "0x7C181C0", VA = "0x187C193C0")]
		internal void NPKKBIEACBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C18F00", Offset = "0x7C17D00", VA = "0x187C18F00")]
		internal void CJMIDOMOFAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C19060", Offset = "0x7C17E60", VA = "0x187C19060")]
		internal void EMALNAAMIDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C19310", Offset = "0x7C18110", VA = "0x187C19310")]
		internal void JNKPLCNIBBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C18FB0", Offset = "0x7C17DB0", VA = "0x187C18FB0")]
		internal void DBBBADNCGEE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C19110", Offset = "0x7C17F10", VA = "0x187C19110")]
		internal void FCGHMLPLBLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C19470", Offset = "0x7C18270", VA = "0x187C19470")]
		internal void OFHEELGJIOE(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ACGLNLHHNJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C19DF0", Offset = "0x7C18BF0", VA = "0x187C19DF0", Slot = "35")]
	public override void GLAFLIPMFDF(Utf8JsonReader JFLBMHOJFED, JsonSerializerOptions FMKKHOLMGDF, string JDKAHLJOMHL, AnchorParamsRestrictions HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C19950", Offset = "0x7C18750", VA = "0x187C19950", Slot = "36")]
	public override void FHKLCNGMMBJ(Utf8JsonWriter KMFJBCLMGLE, AnchorParamsRestrictions OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A310", Offset = "0x7C19110", VA = "0x187C1A310")]
	public MLAMHBLDLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B770", Offset = "0x3A1A570", VA = "0x183A1B770")]
	[CompilerGenerated]
	internal static void EMEIABNJAOI<T>(string JDKAHLJOMHL, T AFBDJBIOHNP, T LJDGOEOEMHP, ACGLNLHHNJN P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FDJEOECKMBI : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void EJILFGHFMDP(Utf8JsonReader JGFHGJBECJA);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DLLLFEDJFBC
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
		public FDJEOECKMBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EJILFGHFMDP <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EJILFGHFMDP <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EJILFGHFMDP <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public EJILFGHFMDP <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EJILFGHFMDP <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EJILFGHFMDP <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EJILFGHFMDP <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EJILFGHFMDP <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EJILFGHFMDP <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EJILFGHFMDP <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EJILFGHFMDP <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DLLLFEDJFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C16480", Offset = "0x7C15280", VA = "0x187C16480")]
		internal void AHMOJNHGLEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C16650", Offset = "0x7C15450", VA = "0x187C16650")]
		internal void DEOIGDKLGGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C165A0", Offset = "0x7C153A0", VA = "0x187C165A0")]
		internal void CBNMALKHEHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C16700", Offset = "0x7C15500", VA = "0x187C16700")]
		internal void ENPGLFNEBAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C164C0", Offset = "0x7C152C0", VA = "0x187C164C0")]
		internal void BFAKJGKLHGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C16570", Offset = "0x7C15370", VA = "0x187C16570")]
		internal void BFLOJLEJHAM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C16AF0", Offset = "0x7C158F0", VA = "0x187C16AF0")]
		internal void PHJPGDHFKGD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C167F0", Offset = "0x7C155F0", VA = "0x187C167F0")]
		internal void GIONLJGOIID(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7C167B0", Offset = "0x7C155B0", VA = "0x187C167B0")]
		internal void FIAMEDOILPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C168D0", Offset = "0x7C156D0", VA = "0x187C168D0")]
		internal void HDPAPDLJDOK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C16970", Offset = "0x7C15770", VA = "0x187C16970")]
		internal void NNDGBPMFLMP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ENIGOMPMPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ENIGOMPMPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C176C0", Offset = "0x7C164C0", VA = "0x187C176C0")]
		internal void GIHLKIECKJE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C178D0", Offset = "0x7C166D0", VA = "0x187C178D0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C184D0", Offset = "0x7C172D0", VA = "0x187C184D0", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, SerializedAvatarItemData OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C17760", Offset = "0x7C16560", VA = "0x187C17760")]
	private AdditionalOutfitTypeData NPGNOIPKGJJ(Utf8JsonReader JFLBMHOJFED, OutfitType AAFMBEEMJAC, JsonSerializerOptions FMKKHOLMGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C18910", Offset = "0x7C17710", VA = "0x187C18910")]
	public FDJEOECKMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FJHHEDNPJNH : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C18950", Offset = "0x7C17750", VA = "0x187C18950", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader JFLBMHOJFED, Type MDJMHAPEKLA, JsonSerializerOptions FMKKHOLMGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C18CE0", Offset = "0x7C17AE0", VA = "0x187C18CE0", Slot = "28")]
	public override void Write(Utf8JsonWriter KMFJBCLMGLE, AvatarItemDownloadableConfig OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C18E10", Offset = "0x7C17C10", VA = "0x187C18E10")]
	public FJHHEDNPJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HHNDJGNFKHN : LIEJLPJOBJK<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C195D0", Offset = "0x7C183D0", VA = "0x187C195D0", Slot = "35")]
	public override void GLAFLIPMFDF(Utf8JsonReader JFLBMHOJFED, JsonSerializerOptions FMKKHOLMGDF, string JDKAHLJOMHL, BeardData HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C19510", Offset = "0x7C18310", VA = "0x187C19510", Slot = "36")]
	public override void FHKLCNGMMBJ(Utf8JsonWriter KMFJBCLMGLE, BeardData OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19770", Offset = "0x7C18570", VA = "0x187C19770")]
	public HHNDJGNFKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DOPFFDCOKEI : GEFFNLCGOJL<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C16B70", Offset = "0x7C15970", VA = "0x187C16B70")]
	public DOPFFDCOKEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JFCMDHKKEJF : GEFFNLCGOJL<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C19910", Offset = "0x7C18710", VA = "0x187C19910")]
	public JFCMDHKKEJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CEELNHOMBPN : GEFFNLCGOJL<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C16440", Offset = "0x7C15240", VA = "0x187C16440")]
	public CEELNHOMBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class INEGAOOPMJB : LAHAINGHPEB<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C198A0", Offset = "0x7C186A0", VA = "0x187C198A0")]
	public INEGAOOPMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OGKDHNJBMHN : LIEJLPJOBJK<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JCNLOHALNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JCNLOHALNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C16E00", Offset = "0x7C15C00", VA = "0x187C16E00")]
		internal void APHMDJEIAAI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7C198E0", Offset = "0x7C186E0", VA = "0x187C198E0")]
		internal void HHOKAACPJDC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AB30", Offset = "0x7C19930", VA = "0x187C1AB30", Slot = "35")]
	public override void GLAFLIPMFDF(Utf8JsonReader JFLBMHOJFED, JsonSerializerOptions FMKKHOLMGDF, string JDKAHLJOMHL, AdditionalFeetData HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AA60", Offset = "0x7C19860", VA = "0x187C1AA60", Slot = "36")]
	public override void FHKLCNGMMBJ(Utf8JsonWriter KMFJBCLMGLE, AdditionalFeetData OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C1ACC0", Offset = "0x7C19AC0", VA = "0x187C1ACC0")]
	public OGKDHNJBMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NLOOOOPCGJB : LIEJLPJOBJK<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EDAJAMCBGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EDAJAMCBGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C16BB0", Offset = "0x7C159B0", VA = "0x187C16BB0")]
		internal void APHMDJEIAAI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C16DD0", Offset = "0x7C15BD0", VA = "0x187C16DD0")]
		internal void HHOKAACPJDC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C16DA0", Offset = "0x7C15BA0", VA = "0x187C16DA0")]
		internal void GIFJEAEAHJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C16E30", Offset = "0x7C15C30", VA = "0x187C16E30")]
		internal void NPKKBIEACBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C16C60", Offset = "0x7C15A60", VA = "0x187C16C60")]
		internal void CJMIDOMOFAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C16D00", Offset = "0x7C15B00", VA = "0x187C16D00")]
		internal void EMALNAAMIDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C16E00", Offset = "0x7C15C00", VA = "0x187C16E00")]
		internal void JNKPLCNIBBL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A630", Offset = "0x7C19430", VA = "0x187C1A630", Slot = "35")]
	public override void GLAFLIPMFDF(Utf8JsonReader JFLBMHOJFED, JsonSerializerOptions FMKKHOLMGDF, string JDKAHLJOMHL, HairData HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A350", Offset = "0x7C19150", VA = "0x187C1A350", Slot = "36")]
	public override void FHKLCNGMMBJ(Utf8JsonWriter KMFJBCLMGLE, HairData OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AA20", Offset = "0x7C19820", VA = "0x187C1AA20")]
	public NLOOOOPCGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EKDDFBAGMPL : LIEJLPJOBJK<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AOHEJGHIDAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AOHEJGHIDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C152B0", Offset = "0x7C140B0", VA = "0x187C152B0")]
		internal void APHMDJEIAAI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C15580", Offset = "0x7C14380", VA = "0x187C15580")]
		internal void HHOKAACPJDC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C154D0", Offset = "0x7C142D0", VA = "0x187C154D0")]
		internal void GIFJEAEAHJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C156D0", Offset = "0x7C144D0", VA = "0x187C156D0")]
		internal void NPKKBIEACBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C152E0", Offset = "0x7C140E0", VA = "0x187C152E0")]
		internal void CJMIDOMOFAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C15430", Offset = "0x7C14230", VA = "0x187C15430")]
		internal void EMALNAAMIDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C15630", Offset = "0x7C14430", VA = "0x187C15630")]
		internal void JNKPLCNIBBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C15390", Offset = "0x7C14190", VA = "0x187C15390")]
		internal void DBBBADNCGEE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C17220", Offset = "0x7C16020", VA = "0x187C17220", Slot = "35")]
	public override void GLAFLIPMFDF(Utf8JsonReader JFLBMHOJFED, JsonSerializerOptions FMKKHOLMGDF, string JDKAHLJOMHL, AdditionalHatData HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C16ED0", Offset = "0x7C15CD0", VA = "0x187C16ED0", Slot = "36")]
	public override void FHKLCNGMMBJ(Utf8JsonWriter KMFJBCLMGLE, AdditionalHatData OAIIHELJHLG, JsonSerializerOptions FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C17680", Offset = "0x7C16480", VA = "0x187C17680")]
	public EKDDFBAGMPL()
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
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CA0", Offset = "0xDD7AA0", VA = "0x180DD8CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CB0", Offset = "0xDD7AB0", VA = "0x180DD8CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF6D2B0", Offset = "0xF6C0B0", VA = "0x180F6D2B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF6D300", Offset = "0xF6C100", VA = "0x180F6D300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB53A0", Offset = "0x1FB41A0", VA = "0x181FB53A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7C1B2D0", Offset = "0x7C1A0D0", VA = "0x187C1B2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2C1A510", Offset = "0x2C19310", VA = "0x182C1A510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2C1A360", Offset = "0x2C19160", VA = "0x182C1A360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F30", Offset = "0xCD4D30", VA = "0x180CD5F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F80", Offset = "0xCD4D80", VA = "0x180CD5F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JICHGCEFAAI.NNADHONNNIJ ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
			[CompilerGenerated]
			get
			{
				return default(JICHGCEFAAI.NNADHONNNIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AE10", Offset = "0x7C19C10", VA = "0x187C1AE10", Slot = "0")]
		public override bool Equals(object HBLONCAMFLG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B2B0", Offset = "0x7C1A0B0", VA = "0x187C1B2B0")]
		public static bool PBEBFPKJKLO(SerializedAvatarItemData EFOOGHNHGNH, SerializedAvatarItemData IFJAPBHAPEE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B280", Offset = "0x7C1A080", VA = "0x187C1B280")]
		public static bool INFPGDPCEAI(SerializedAvatarItemData EFOOGHNHGNH, SerializedAvatarItemData IFJAPBHAPEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AE90", Offset = "0x7C19C90", VA = "0x187C1AE90", Slot = "4")]
		public bool Equals(SerializedAvatarItemData HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B1B0", Offset = "0x7C19FB0", VA = "0x187C1B1B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
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
