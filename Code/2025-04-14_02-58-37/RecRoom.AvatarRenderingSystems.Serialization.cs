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
public class AKNBNMGKHOO : MNINJHEOFEP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB20080", Offset = "0xB1EA80", VA = "0x180B20080", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7786E00", Offset = "0x7785800", VA = "0x187786E00", Slot = "36")]
	protected override Vector3 INNBGDIIMOA(float[] IOMEFCNHNJN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7786E50", Offset = "0x7785850", VA = "0x187786E50", Slot = "37")]
	protected override float[] OBPCLLMNCNO(Vector3 PPJFMHBDGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7786ED0", Offset = "0x77858D0", VA = "0x187786ED0")]
	public AKNBNMGKHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GOKEIGFIJJG : MNINJHEOFEP<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB540D0", Offset = "0xB52AD0", VA = "0x180B540D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x778A230", Offset = "0x7788C30", VA = "0x18778A230", Slot = "36")]
	protected override Vector2 INNBGDIIMOA(float[] IOMEFCNHNJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x778A270", Offset = "0x7788C70", VA = "0x18778A270", Slot = "37")]
	protected override float[] OBPCLLMNCNO(Vector2 PPJFMHBDGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x778A2E0", Offset = "0x7788CE0", VA = "0x18778A2E0")]
	public GOKEIGFIJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NKJONHGFLMP : MNINJHEOFEP<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB522F0", Offset = "0xB50CF0", VA = "0x180B522F0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x778C770", Offset = "0x778B170", VA = "0x18778C770", Slot = "36")]
	protected override Quaternion INNBGDIIMOA(float[] IOMEFCNHNJN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x778C7D0", Offset = "0x778B1D0", VA = "0x18778C7D0", Slot = "37")]
	protected override float[] OBPCLLMNCNO(Quaternion PPJFMHBDGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x778C860", Offset = "0x778B260", VA = "0x18778C860")]
	public NKJONHGFLMP()
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
		public enum NBBLNJGDFJO
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
		public NBBLNJGDFJO Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
			[CompilerGenerated]
			get
			{
				return default(NBBLNJGDFJO);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77871B0", Offset = "0x7785BB0", VA = "0x1877871B0", Slot = "0")]
		public override bool Equals(object OLKLGHOAKNE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7787420", Offset = "0x7785E20", VA = "0x187787420")]
		public static bool HFGMMLFJJJB(AvatarItemDownloadableConfig AKJAPDOPIOF, AvatarItemDownloadableConfig CPKHJEJFIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77872E0", Offset = "0x7785CE0", VA = "0x1877872E0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77873B0", Offset = "0x7785DB0", VA = "0x1877873B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE5F390", Offset = "0xE5DD90", VA = "0x180E5F390")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, NBFPJEEGCEI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x778CF80", Offset = "0x778B980", VA = "0x18778CF80")]
		private void MLCBNMGMPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x778CE00", Offset = "0x778B800", VA = "0x18778CE00", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x778CE80", Offset = "0x778B880", VA = "0x18778CE80", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x778CF80", Offset = "0x778B980", VA = "0x18778CF80", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x778CFF0", Offset = "0x778B9F0", VA = "0x18778CFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NHAPGBGLMJM : JJBCKBEFABL<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LHOPLJKJDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LHOPLJKJDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x778B6B0", Offset = "0x778A0B0", VA = "0x18778B6B0")]
		internal void KNOJCCMNGLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x778B1F0", Offset = "0x7789BF0", VA = "0x18778B1F0")]
		internal void DNLCKADDINI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x778B600", Offset = "0x778A000", VA = "0x18778B600")]
		internal void JDEJCDJEGMM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x778B2A0", Offset = "0x7789CA0", VA = "0x18778B2A0")]
		internal void DPLJAPAHEHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x778B760", Offset = "0x778A160", VA = "0x18778B760")]
		internal void NHPICJHAFAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x778B550", Offset = "0x7789F50", VA = "0x18778B550")]
		internal void JCLGJHHDFFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x778B4A0", Offset = "0x7789EA0", VA = "0x18778B4A0")]
		internal void IOOEFBPBNFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x778B3F0", Offset = "0x7789DF0", VA = "0x18778B3F0")]
		internal void HNLPNCGPHAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x778B350", Offset = "0x7789D50", VA = "0x18778B350")]
		internal void GAEADOAFLFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x778B810", Offset = "0x778A210", VA = "0x18778B810")]
		internal void PLNLEOEAJCJ(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EMABKHCPAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x778C210", Offset = "0x778AC10", VA = "0x18778C210", Slot = "35")]
	public override void OFDADIFMNJO(Utf8JsonReader BDHKEKKPKBC, JsonSerializerOptions LPHHENIAGIG, string JHOCOFAFAFH, AnchorParamsRestrictions OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x778BD80", Offset = "0x778A780", VA = "0x18778BD80", Slot = "36")]
	public override void OAHECBKBEHP(Utf8JsonWriter IFAFIMFGJBL, AnchorParamsRestrictions PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x778C730", Offset = "0x778B130", VA = "0x18778C730")]
	public NHAPGBGLMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37EC000", Offset = "0x37EAA00", VA = "0x1837EC000")]
	[CompilerGenerated]
	internal static void NEGDGMMNMLH<T>(string JHOCOFAFAFH, T OILNFPPOKDD, T CBHLIDJPBHC, EMABKHCPAIF P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DKNLEBKAMPO : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void PDNKJPPBGFM(Utf8JsonReader LIFAHFCIJCG);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IABAALCIMKO
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
		public DKNLEBKAMPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public PDNKJPPBGFM <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PDNKJPPBGFM <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PDNKJPPBGFM <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public PDNKJPPBGFM <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public PDNKJPPBGFM <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PDNKJPPBGFM <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PDNKJPPBGFM <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PDNKJPPBGFM <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PDNKJPPBGFM <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PDNKJPPBGFM <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PDNKJPPBGFM <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IABAALCIMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x778A870", Offset = "0x7789270", VA = "0x18778A870")]
		internal void MGFAJEHGNOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x778A960", Offset = "0x7789360", VA = "0x18778A960")]
		internal void PJMJMCHPPMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x778A4D0", Offset = "0x7788ED0", VA = "0x18778A4D0")]
		internal void CKBJBFKEFEO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x778A7C0", Offset = "0x77891C0", VA = "0x18778A7C0")]
		internal void LECHCKIMEJO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x778A8B0", Offset = "0x77892B0", VA = "0x18778A8B0")]
		internal void NOJPIFBNKON(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x778A400", Offset = "0x7788E00", VA = "0x18778A400")]
		internal void AIEDAGBPCBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x778A5C0", Offset = "0x7788FC0", VA = "0x18778A5C0")]
		internal void FHKNOJGFFGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x778A320", Offset = "0x7788D20", VA = "0x18778A320")]
		internal void ADMGKBFNOJF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x778A580", Offset = "0x7788F80", VA = "0x18778A580")]
		internal void EHDDLAPGNDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x778A430", Offset = "0x7788E30", VA = "0x18778A430")]
		internal void AKMEACHNMIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x778A640", Offset = "0x7789040", VA = "0x18778A640")]
		internal void GPFMFPGEJEL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JEKHDNMAFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JEKHDNMAFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x778AA10", Offset = "0x7789410", VA = "0x18778AA10")]
		internal void DCLDELLDAHM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7788BD0", Offset = "0x77875D0", VA = "0x187788BD0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77897B0", Offset = "0x77881B0", VA = "0x1877897B0", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, SerializedAvatarItemData PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7788A60", Offset = "0x7787460", VA = "0x187788A60")]
	private AdditionalOutfitTypeData FDLFPHKJGHI(Utf8JsonReader BDHKEKKPKBC, OutfitType OHCGINPDMEI, JsonSerializerOptions LPHHENIAGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7789BF0", Offset = "0x77885F0", VA = "0x187789BF0")]
	public DKNLEBKAMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DAFGPDLDHNG : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7788560", Offset = "0x7786F60", VA = "0x187788560", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader BDHKEKKPKBC, Type FPEAAJEDKKO, JsonSerializerOptions LPHHENIAGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77888F0", Offset = "0x77872F0", VA = "0x1877888F0", Slot = "28")]
	public override void Write(Utf8JsonWriter IFAFIMFGJBL, AvatarItemDownloadableConfig PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7788A20", Offset = "0x7787420", VA = "0x187788A20")]
	public DAFGPDLDHNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FPMADCHMOJG : JJBCKBEFABL<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7789D30", Offset = "0x7788730", VA = "0x187789D30", Slot = "35")]
	public override void OFDADIFMNJO(Utf8JsonReader BDHKEKKPKBC, JsonSerializerOptions LPHHENIAGIG, string JHOCOFAFAFH, BeardData OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7789C70", Offset = "0x7788670", VA = "0x187789C70", Slot = "36")]
	public override void OAHECBKBEHP(Utf8JsonWriter IFAFIMFGJBL, BeardData PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7789ED0", Offset = "0x77888D0", VA = "0x187789ED0")]
	public FPMADCHMOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CMIFNDMIBDB : NPCDPHCFCCP<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7788520", Offset = "0x7786F20", VA = "0x187788520")]
	public CMIFNDMIBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NOPKABHBMDD : NPCDPHCFCCP<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x778C8A0", Offset = "0x778B2A0", VA = "0x18778C8A0")]
	public NOPKABHBMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KICDAFFHLBP : NPCDPHCFCCP<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x778B1B0", Offset = "0x7789BB0", VA = "0x18778B1B0")]
	public KICDAFFHLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EODFEBCLNOC : PIPGHCHJAGC<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7789C30", Offset = "0x7788630", VA = "0x187789C30")]
	public EODFEBCLNOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class APMGGBMJEKJ : JJBCKBEFABL<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OGNLJJKEAHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OGNLJJKEAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7789FE0", Offset = "0x77889E0", VA = "0x187789FE0")]
		internal void KNOJCCMNGLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x778C8E0", Offset = "0x778B2E0", VA = "0x18778C8E0")]
		internal void DNLCKADDINI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7786FE0", Offset = "0x77859E0", VA = "0x187786FE0", Slot = "35")]
	public override void OFDADIFMNJO(Utf8JsonReader BDHKEKKPKBC, JsonSerializerOptions LPHHENIAGIG, string JHOCOFAFAFH, AdditionalFeetData OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7786F10", Offset = "0x7785910", VA = "0x187786F10", Slot = "36")]
	public override void OAHECBKBEHP(Utf8JsonWriter IFAFIMFGJBL, AdditionalFeetData PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7787170", Offset = "0x7785B70", VA = "0x187787170")]
	public APMGGBMJEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KENMOGDLKEE : JJBCKBEFABL<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GCBNCNFCIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GCBNCNFCIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x778A0E0", Offset = "0x7788AE0", VA = "0x18778A0E0")]
		internal void KNOJCCMNGLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7789F10", Offset = "0x7788910", VA = "0x187789F10")]
		internal void DNLCKADDINI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x778A0B0", Offset = "0x7788AB0", VA = "0x18778A0B0")]
		internal void JDEJCDJEGMM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7789F40", Offset = "0x7788940", VA = "0x187789F40")]
		internal void DPLJAPAHEHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x778A190", Offset = "0x7788B90", VA = "0x18778A190")]
		internal void NHPICJHAFAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x778A010", Offset = "0x7788A10", VA = "0x18778A010")]
		internal void JCLGJHHDFFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7789FE0", Offset = "0x77889E0", VA = "0x187789FE0")]
		internal void IOOEFBPBNFO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x778AD80", Offset = "0x7789780", VA = "0x18778AD80", Slot = "35")]
	public override void OFDADIFMNJO(Utf8JsonReader BDHKEKKPKBC, JsonSerializerOptions LPHHENIAGIG, string JHOCOFAFAFH, HairData OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x778AAB0", Offset = "0x77894B0", VA = "0x18778AAB0", Slot = "36")]
	public override void OAHECBKBEHP(Utf8JsonWriter IFAFIMFGJBL, HairData PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x778B170", Offset = "0x7789B70", VA = "0x18778B170")]
	public KENMOGDLKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BOPAEHCCECC : JJBCKBEFABL<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MHGDPCIIICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MHGDPCIIICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x778BCA0", Offset = "0x778A6A0", VA = "0x18778BCA0")]
		internal void KNOJCCMNGLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x778B8B0", Offset = "0x778A2B0", VA = "0x18778B8B0")]
		internal void DNLCKADDINI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x778BBF0", Offset = "0x778A5F0", VA = "0x18778BBF0")]
		internal void JDEJCDJEGMM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x778B960", Offset = "0x778A360", VA = "0x18778B960")]
		internal void DPLJAPAHEHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x778BCD0", Offset = "0x778A6D0", VA = "0x18778BCD0")]
		internal void NHPICJHAFAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x778BB50", Offset = "0x778A550", VA = "0x18778BB50")]
		internal void JCLGJHHDFFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x778BAB0", Offset = "0x778A4B0", VA = "0x18778BAB0")]
		internal void IOOEFBPBNFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x778BA10", Offset = "0x778A410", VA = "0x18778BA10")]
		internal void HNLPNCGPHAD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7788080", Offset = "0x7786A80", VA = "0x187788080", Slot = "35")]
	public override void OFDADIFMNJO(Utf8JsonReader BDHKEKKPKBC, JsonSerializerOptions LPHHENIAGIG, string JHOCOFAFAFH, AdditionalHatData OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7787D40", Offset = "0x7786740", VA = "0x187787D40", Slot = "36")]
	public override void OAHECBKBEHP(Utf8JsonWriter IFAFIMFGJBL, AdditionalHatData PPJFMHBDGNA, JsonSerializerOptions LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77884E0", Offset = "0x7786EE0", VA = "0x1877884E0")]
	public BOPAEHCCECC()
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
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9B5550", Offset = "0x9B3F50", VA = "0x1809B5550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA31440", Offset = "0xA2FE40", VA = "0x180A31440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33460", VA = "0x180D34A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD34A20", Offset = "0xD33420", VA = "0x180D34A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE81A20", Offset = "0xE80420", VA = "0x180E81A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xE81A30", Offset = "0xE80430", VA = "0x180E81A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1E61B10", Offset = "0x1E60510", VA = "0x181E61B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x778CDD0", Offset = "0x778B7D0", VA = "0x18778CDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2A403A0", Offset = "0x2A3EDA0", VA = "0x182A403A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2A400E0", Offset = "0x2A3EAE0", VA = "0x182A400E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC24620", Offset = "0xC23020", VA = "0x180C24620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC24670", Offset = "0xC23070", VA = "0x180C24670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FHMIHNFONJP.FMPAHPDMJAC ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0")]
			[CompilerGenerated]
			get
			{
				return default(FHMIHNFONJP.FMPAHPDMJAC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6BC6710", Offset = "0x6BC5110", VA = "0x186BC6710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4D0", Offset = "0x9AAED0", VA = "0x1809AC4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x778C940", Offset = "0x778B340", VA = "0x18778C940", Slot = "0")]
		public override bool Equals(object OLKLGHOAKNE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x778CDB0", Offset = "0x778B7B0", VA = "0x18778CDB0")]
		public static bool HFGMMLFJJJB(SerializedAvatarItemData AKJAPDOPIOF, SerializedAvatarItemData CPKHJEJFIJK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x778C910", Offset = "0x778B310", VA = "0x18778C910")]
		public static bool BDABLEIINAG(SerializedAvatarItemData AKJAPDOPIOF, SerializedAvatarItemData CPKHJEJFIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x778C9C0", Offset = "0x778B3C0", VA = "0x18778C9C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x778CCE0", Offset = "0x778B6E0", VA = "0x18778CCE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
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
