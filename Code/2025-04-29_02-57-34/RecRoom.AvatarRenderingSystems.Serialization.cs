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
public class HGJCCAHDJBK : APJKMNIFPBM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB5D430", Offset = "0xB5C830", VA = "0x180B5D430", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x797B5B0", Offset = "0x797A9B0", VA = "0x18797B5B0", Slot = "36")]
	protected override Vector3 MKAEABMNCIG(float[] LMNAOMMMDJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x797B530", Offset = "0x797A930", VA = "0x18797B530", Slot = "37")]
	protected override float[] ECCHMOFPDMA(Vector3 OOEMJLHLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x797B600", Offset = "0x797AA00", VA = "0x18797B600")]
	public HGJCCAHDJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EBDMGLOBKHK : APJKMNIFPBM<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBA6200", Offset = "0xBA5600", VA = "0x180BA6200", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x797ACC0", Offset = "0x797A0C0", VA = "0x18797ACC0", Slot = "36")]
	protected override Vector2 MKAEABMNCIG(float[] LMNAOMMMDJP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x797AC50", Offset = "0x797A050", VA = "0x18797AC50", Slot = "37")]
	protected override float[] ECCHMOFPDMA(Vector2 OOEMJLHLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x797AD00", Offset = "0x797A100", VA = "0x18797AD00")]
	public EBDMGLOBKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BONPCNNHCAI : APJKMNIFPBM<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBA5E70", Offset = "0xBA5270", VA = "0x180BA5E70", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7978C60", Offset = "0x7978060", VA = "0x187978C60", Slot = "36")]
	protected override Quaternion MKAEABMNCIG(float[] LMNAOMMMDJP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7978BD0", Offset = "0x7977FD0", VA = "0x187978BD0", Slot = "37")]
	protected override float[] ECCHMOFPDMA(Quaternion OOEMJLHLIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7978CC0", Offset = "0x79780C0", VA = "0x187978CC0")]
	public BONPCNNHCAI()
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
		public enum DGFIEKLEDED
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
		public DGFIEKLEDED Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
			[CompilerGenerated]
			get
			{
				return default(DGFIEKLEDED);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7977950", Offset = "0x7976D50", VA = "0x187977950", Slot = "0")]
		public override bool Equals(object DMMBOHMLHLF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7977BC0", Offset = "0x7976FC0", VA = "0x187977BC0")]
		public static bool HGJBAFCOLON(AvatarItemDownloadableConfig BGDONNBGCJK, AvatarItemDownloadableConfig DKEKGDBAIOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7977A80", Offset = "0x7976E80", VA = "0x187977A80", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7977B50", Offset = "0x7976F50", VA = "0x187977B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEA1C60", Offset = "0xEA1060", VA = "0x180EA1C60")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, KGIFCIOKMHM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x797D880", Offset = "0x797CC80", VA = "0x18797D880")]
		private void KAODFIGDPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x797D700", Offset = "0x797CB00", VA = "0x18797D700", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x797D780", Offset = "0x797CB80", VA = "0x18797D780", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x797D880", Offset = "0x797CC80", VA = "0x18797D880", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x797D8F0", Offset = "0x797CCF0", VA = "0x18797D8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CPPJPAAPIMC : JJKENCPFCMM<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LILAEKKIJBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LILAEKKIJBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x797C240", Offset = "0x797B640", VA = "0x18797C240")]
		internal void LLCGHMKNLNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x797C440", Offset = "0x797B840", VA = "0x18797C440")]
		internal void OEFNOBEABGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x797C030", Offset = "0x797B430", VA = "0x18797C030")]
		internal void EJHFAKEPHIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x797C190", Offset = "0x797B590", VA = "0x18797C190")]
		internal void IBHEHODCEAC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x797C2F0", Offset = "0x797B6F0", VA = "0x18797C2F0")]
		internal void MJNCEGGIBIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x797C0E0", Offset = "0x797B4E0", VA = "0x18797C0E0")]
		internal void HAHCBEMOMFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x797BF80", Offset = "0x797B380", VA = "0x18797BF80")]
		internal void DHMCKOOHCOL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x797C4F0", Offset = "0x797B8F0", VA = "0x18797C4F0")]
		internal void OKNOBAPJIAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x797BEE0", Offset = "0x797B2E0", VA = "0x18797BEE0")]
		internal void BLBJCODDNOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x797C3A0", Offset = "0x797B7A0", VA = "0x18797C3A0")]
		internal void MOIMAHLALOB(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GKOIHCAMKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x797A390", Offset = "0x7979790", VA = "0x18797A390", Slot = "35")]
	public override void PBFKKEPNNDC(Utf8JsonReader PABEDPKBAJJ, JsonSerializerOptions EEANHGMNGAI, string PDAAGBJMEJF, AnchorParamsRestrictions NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7979EF0", Offset = "0x79792F0", VA = "0x187979EF0", Slot = "36")]
	public override void JKCPEOONCBG(Utf8JsonWriter CELBHBDDEKA, AnchorParamsRestrictions OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x797A8B0", Offset = "0x7979CB0", VA = "0x18797A8B0")]
	public CPPJPAAPIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34C7380", Offset = "0x34C6780", VA = "0x1834C7380")]
	[CompilerGenerated]
	internal static void DIKIAOAPOHE<T>(string PDAAGBJMEJF, T DBALGCNBEDK, T ELLHMCFIBOM, GKOIHCAMKJH P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CECJJCOMPEK : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void PPILOFEOFBO(Utf8JsonReader DEBKLEONCCD);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BHKMOECGNKH
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
		public CECJJCOMPEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public PPILOFEOFBO <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PPILOFEOFBO <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PPILOFEOFBO <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public PPILOFEOFBO <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public PPILOFEOFBO <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PPILOFEOFBO <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PPILOFEOFBO <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PPILOFEOFBO <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PPILOFEOFBO <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PPILOFEOFBO <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PPILOFEOFBO <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BHKMOECGNKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79787C0", Offset = "0x7977BC0", VA = "0x1879787C0")]
		internal void KJPGKPCKMFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79788A0", Offset = "0x7977CA0", VA = "0x1879788A0")]
		internal void MIOAKKMFGLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7978560", Offset = "0x7977960", VA = "0x187978560")]
		internal void GDBEOGJFNNH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7978950", Offset = "0x7977D50", VA = "0x187978950")]
		internal void MJBHMPDEOPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7978A00", Offset = "0x7977E00", VA = "0x187978A00")]
		internal void MJNGKDMFHIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7978610", Offset = "0x7977A10", VA = "0x187978610")]
		internal void GDOFODAILKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79784E0", Offset = "0x79778E0", VA = "0x1879784E0")]
		internal void CDPHIJCHEKC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7978AB0", Offset = "0x7977EB0", VA = "0x187978AB0")]
		internal void MPAJEOPHJHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7978B90", Offset = "0x7977F90", VA = "0x187978B90")]
		internal void NHNEAGLBBPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7978800", Offset = "0x7977C00", VA = "0x187978800")]
		internal void KKEIIKPJBFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7978640", Offset = "0x7977A40", VA = "0x187978640")]
		internal void JLCNKONKHNH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KAFNOFPBCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KAFNOFPBCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x797BD90", Offset = "0x797B190", VA = "0x18797BD90")]
		internal void PALBENMJLBP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7978E70", Offset = "0x7978270", VA = "0x187978E70", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7979A70", Offset = "0x7978E70", VA = "0x187979A70", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, SerializedAvatarItemData OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7978D00", Offset = "0x7978100", VA = "0x187978D00")]
	private AdditionalOutfitTypeData CGPKLPDEJGN(Utf8JsonReader PABEDPKBAJJ, OutfitType KHNCICOHHHJ, JsonSerializerOptions EEANHGMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7979EB0", Offset = "0x79792B0", VA = "0x187979EB0")]
	public CECJJCOMPEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LNGHNLJPFBC : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x797C5A0", Offset = "0x797B9A0", VA = "0x18797C5A0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader PABEDPKBAJJ, Type FEFILJPBGJM, JsonSerializerOptions EEANHGMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x797C930", Offset = "0x797BD30", VA = "0x18797C930", Slot = "28")]
	public override void Write(Utf8JsonWriter CELBHBDDEKA, AvatarItemDownloadableConfig OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x797CA60", Offset = "0x797BE60", VA = "0x18797CA60")]
	public LNGHNLJPFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NMHOHANDOCJ : JJKENCPFCMM<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x797D030", Offset = "0x797C430", VA = "0x18797D030", Slot = "35")]
	public override void PBFKKEPNNDC(Utf8JsonReader PABEDPKBAJJ, JsonSerializerOptions EEANHGMNGAI, string PDAAGBJMEJF, BeardData NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x797CF70", Offset = "0x797C370", VA = "0x18797CF70", Slot = "36")]
	public override void JKCPEOONCBG(Utf8JsonWriter CELBHBDDEKA, BeardData OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x797D1D0", Offset = "0x797C5D0", VA = "0x18797D1D0")]
	public NMHOHANDOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DHPJKKHFMLM : FOGEBIIHFEN<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x797AC10", Offset = "0x797A010", VA = "0x18797AC10")]
	public DHPJKKHFMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HPFPFHGBFJC : FOGEBIIHFEN<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x797B640", Offset = "0x797AA40", VA = "0x18797B640")]
	public HPFPFHGBFJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LBPIFPKDABI : FOGEBIIHFEN<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x797BEA0", Offset = "0x797B2A0", VA = "0x18797BEA0")]
	public LBPIFPKDABI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KEJDJEHMNOL : CIPINDPBDAA<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x797BE30", Offset = "0x797B230", VA = "0x18797BE30")]
	public KEJDJEHMNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class APMLPGADFPG : JJKENCPFCMM<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KKEOOEFLELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KKEOOEFLELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x797A8F0", Offset = "0x7979CF0", VA = "0x18797A8F0")]
		internal void LLCGHMKNLNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x797BE70", Offset = "0x797B270", VA = "0x18797BE70")]
		internal void OEFNOBEABGO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7977780", Offset = "0x7976B80", VA = "0x187977780", Slot = "35")]
	public override void PBFKKEPNNDC(Utf8JsonReader PABEDPKBAJJ, JsonSerializerOptions EEANHGMNGAI, string PDAAGBJMEJF, AdditionalFeetData NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79776B0", Offset = "0x7976AB0", VA = "0x1879776B0", Slot = "36")]
	public override void JKCPEOONCBG(Utf8JsonWriter CELBHBDDEKA, AdditionalFeetData OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7977910", Offset = "0x7976D10", VA = "0x187977910")]
	public APMLPGADFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JNPLBLHAHFC : JJKENCPFCMM<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DEECKBHIIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DEECKBHIIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x797AA90", Offset = "0x7979E90", VA = "0x18797AA90")]
		internal void LLCGHMKNLNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x797ABE0", Offset = "0x7979FE0", VA = "0x18797ABE0")]
		internal void OEFNOBEABGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x797A920", Offset = "0x7979D20", VA = "0x18797A920")]
		internal void EJHFAKEPHIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x797A9F0", Offset = "0x7979DF0", VA = "0x18797A9F0")]
		internal void IBHEHODCEAC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x797AB40", Offset = "0x7979F40", VA = "0x18797AB40")]
		internal void MJNCEGGIBIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x797A950", Offset = "0x7979D50", VA = "0x18797A950")]
		internal void HAHCBEMOMFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x797A8F0", Offset = "0x7979CF0", VA = "0x18797A8F0")]
		internal void DHMCKOOHCOL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x797B960", Offset = "0x797AD60", VA = "0x18797B960", Slot = "35")]
	public override void PBFKKEPNNDC(Utf8JsonReader PABEDPKBAJJ, JsonSerializerOptions EEANHGMNGAI, string PDAAGBJMEJF, HairData NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x797B680", Offset = "0x797AA80", VA = "0x18797B680", Slot = "36")]
	public override void JKCPEOONCBG(Utf8JsonWriter CELBHBDDEKA, HairData OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x797BD50", Offset = "0x797B150", VA = "0x18797BD50")]
	public JNPLBLHAHFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EIHGOIPDLII : JJKENCPFCMM<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MHFGJOBMOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MHFGJOBMOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x797CD40", Offset = "0x797C140", VA = "0x18797CD40")]
		internal void LLCGHMKNLNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x797CE20", Offset = "0x797C220", VA = "0x18797CE20")]
		internal void OEFNOBEABGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x797CB40", Offset = "0x797BF40", VA = "0x18797CB40")]
		internal void EJHFAKEPHIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x797CC90", Offset = "0x797C090", VA = "0x18797CC90")]
		internal void IBHEHODCEAC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x797CD70", Offset = "0x797C170", VA = "0x18797CD70")]
		internal void MJNCEGGIBIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x797CBF0", Offset = "0x797BFF0", VA = "0x18797CBF0")]
		internal void HAHCBEMOMFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x797CAA0", Offset = "0x797BEA0", VA = "0x18797CAA0")]
		internal void DHMCKOOHCOL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x797CED0", Offset = "0x797C2D0", VA = "0x18797CED0")]
		internal void OKNOBAPJIAD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x797B090", Offset = "0x797A490", VA = "0x18797B090", Slot = "35")]
	public override void PBFKKEPNNDC(Utf8JsonReader PABEDPKBAJJ, JsonSerializerOptions EEANHGMNGAI, string PDAAGBJMEJF, AdditionalHatData NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x797AD40", Offset = "0x797A140", VA = "0x18797AD40", Slot = "36")]
	public override void JKCPEOONCBG(Utf8JsonWriter CELBHBDDEKA, AdditionalHatData OOEMJLHLIHJ, JsonSerializerOptions EEANHGMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x797B4F0", Offset = "0x797A8F0", VA = "0x18797B4F0")]
	public EIHGOIPDLII()
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
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8A0", Offset = "0xA6CCA0", VA = "0x180A6D8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD74860", Offset = "0xD73C60", VA = "0x180D74860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD74850", Offset = "0xD73C50", VA = "0x180D74850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xEC7580", Offset = "0xEC6980", VA = "0x180EC7580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xEC7570", Offset = "0xEC6970", VA = "0x180EC7570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1EC4BC0", Offset = "0x1EC3FC0", VA = "0x181EC4BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x797D6D0", Offset = "0x797CAD0", VA = "0x18797D6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF310", Offset = "0x2AAE710", VA = "0x182AAF310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF470", Offset = "0x2AAE870", VA = "0x182AAF470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC628B0", Offset = "0xC61CB0", VA = "0x180C628B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC62900", Offset = "0xC61D00", VA = "0x180C62900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MOJPHFECLPK.JODCMICJPOD ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450")]
			[CompilerGenerated]
			get
			{
				return default(MOJPHFECLPK.JODCMICJPOD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6D73370", Offset = "0x6D72770", VA = "0x186D73370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9CD7E0", Offset = "0x9CCBE0", VA = "0x1809CD7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x797D210", Offset = "0x797C610", VA = "0x18797D210", Slot = "0")]
		public override bool Equals(object DMMBOHMLHLF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x797D680", Offset = "0x797CA80", VA = "0x18797D680")]
		public static bool HGJBAFCOLON(SerializedAvatarItemData BGDONNBGCJK, SerializedAvatarItemData DKEKGDBAIOE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x797D6A0", Offset = "0x797CAA0", VA = "0x18797D6A0")]
		public static bool PBNEENGPCHJ(SerializedAvatarItemData BGDONNBGCJK, SerializedAvatarItemData DKEKGDBAIOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x797D290", Offset = "0x797C690", VA = "0x18797D290", Slot = "4")]
		public bool Equals(SerializedAvatarItemData DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x797D5B0", Offset = "0x797C9B0", VA = "0x18797D5B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
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
