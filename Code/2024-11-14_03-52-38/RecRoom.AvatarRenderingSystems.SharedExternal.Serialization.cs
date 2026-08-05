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
public class HJABPGKCDCG : HMAPNJNJCLH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x931180", Offset = "0x930580", VA = "0x180931180", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5790", Offset = "0x6BE4B90", VA = "0x186BE5790", Slot = "36")]
	protected override Vector3 MKGHLAJCNAG(float[] MHFHLBKJCIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BE57E0", Offset = "0x6BE4BE0", VA = "0x186BE57E0", Slot = "37")]
	protected override float[] PHBKKJCGHEL(Vector3 PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5860", Offset = "0x6BE4C60", VA = "0x186BE5860")]
	public HJABPGKCDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CIFOHABBGJC : HMAPNJNJCLH<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x924F10", Offset = "0x924310", VA = "0x180924F10", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3E80", Offset = "0x6BE3280", VA = "0x186BE3E80", Slot = "36")]
	protected override Vector2 MKGHLAJCNAG(float[] MHFHLBKJCIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3EC0", Offset = "0x6BE32C0", VA = "0x186BE3EC0", Slot = "37")]
	protected override float[] PHBKKJCGHEL(Vector2 PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3F30", Offset = "0x6BE3330", VA = "0x186BE3F30")]
	public CIFOHABBGJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LIANCLCJLFE : HMAPNJNJCLH<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9281B0", Offset = "0x9275B0", VA = "0x1809281B0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6370", Offset = "0x6BE5770", VA = "0x186BE6370", Slot = "36")]
	protected override Quaternion MKGHLAJCNAG(float[] MHFHLBKJCIO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE63D0", Offset = "0x6BE57D0", VA = "0x186BE63D0", Slot = "37")]
	protected override float[] PHBKKJCGHEL(Quaternion PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6460", Offset = "0x6BE5860", VA = "0x186BE6460")]
	public LIANCLCJLFE()
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
		public enum FBGOHGDPEKC
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
		public FBGOHGDPEKC Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
			[CompilerGenerated]
			get
			{
				return default(FBGOHGDPEKC);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA8E540", Offset = "0xA8D940", VA = "0x180A8E540")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MAHJHJLKEEA : NKEIAHECAGE<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MEBLPEFNEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MEBLPEFNEFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7760", Offset = "0x6BE6B60", VA = "0x186BE7760")]
		internal void EJCDIJLHOAM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7610", Offset = "0x6BE6A10", VA = "0x186BE7610")]
		internal void BPIPECNOMNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7810", Offset = "0x6BE6C10", VA = "0x186BE7810")]
		internal void FECADODFPHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE78C0", Offset = "0x6BE6CC0", VA = "0x186BE78C0")]
		internal void FGLIJFKMKNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7560", Offset = "0x6BE6960", VA = "0x186BE7560")]
		internal void BIDDOCAIGEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7970", Offset = "0x6BE6D70", VA = "0x186BE7970")]
		internal void FKCKCBNGAMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7AC0", Offset = "0x6BE6EC0", VA = "0x186BE7AC0")]
		internal void KFBOHIGDMPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7B70", Offset = "0x6BE6F70", VA = "0x186BE7B70")]
		internal void LGPMNDFBMMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7A20", Offset = "0x6BE6E20", VA = "0x186BE7A20")]
		internal void JGDLMKJAKEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BE76C0", Offset = "0x6BE6AC0", VA = "0x186BE76C0")]
		internal void CIAPHNLMOHF(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IFBFABIMGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7000", Offset = "0x6BE6400", VA = "0x186BE7000", Slot = "35")]
	public override void HAEAGGLGFOL(Utf8JsonReader ILEMOHLPHEC, JsonSerializerOptions POLCFNEEHMO, string CIOJHADPGDL, AnchorParamsRestrictions DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6B60", Offset = "0x6BE5F60", VA = "0x186BE6B60", Slot = "36")]
	public override void FOELCBDALIG(Utf8JsonWriter FJOPPBPMLFL, AnchorParamsRestrictions PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7520", Offset = "0x6BE6920", VA = "0x186BE7520")]
	public MAHJHJLKEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2FBB170", Offset = "0x2FBA570", VA = "0x182FBB170")]
	[CompilerGenerated]
	internal static void MBDFKIKABNB<T>(string CIOJHADPGDL, T KCIHDEINMKL, T ANMBOIKIGAK, IFBFABIMGKG P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HEMACFIMCMB : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void EGANKGFHHDB(Utf8JsonReader AKMABNIDADH);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LKIMCHDLBMA
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
		public HEMACFIMCMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EGANKGFHHDB <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EGANKGFHHDB <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EGANKGFHHDB <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EGANKGFHHDB <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EGANKGFHHDB <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EGANKGFHHDB <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public EGANKGFHHDB <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EGANKGFHHDB <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EGANKGFHHDB <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EGANKGFHHDB <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EGANKGFHHDB <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LKIMCHDLBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BE67A0", Offset = "0x6BE5BA0", VA = "0x186BE67A0")]
		internal void DMHKJIMPBLM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6940", Offset = "0x6BE5D40", VA = "0x186BE6940")]
		internal void FKDJCHPOFBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE69F0", Offset = "0x6BE5DF0", VA = "0x186BE69F0")]
		internal void ICPDPHEDOBB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6890", Offset = "0x6BE5C90", VA = "0x186BE6890")]
		internal void FFBABJAKPBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE67E0", Offset = "0x6BE5BE0", VA = "0x186BE67E0")]
		internal void EOJENINKHDP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE40F0", Offset = "0x6BE34F0", VA = "0x186BE40F0")]
		internal void KHCHBLJAGMG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6AA0", Offset = "0x6BE5EA0", VA = "0x186BE6AA0")]
		internal void JEIHKOKHFPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6620", Offset = "0x6BE5A20", VA = "0x186BE6620")]
		internal void CGMLIBAFPKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6B20", Offset = "0x6BE5F20", VA = "0x186BE6B20")]
		internal void KIIJGBKPNKL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6700", Offset = "0x6BE5B00", VA = "0x186BE6700")]
		internal void CHNELPPDMFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BE64A0", Offset = "0x6BE58A0", VA = "0x186BE64A0")]
		internal void BGMHKDJIACI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OBIHCPNIHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OBIHCPNIHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8850", Offset = "0x6BE7C50", VA = "0x186BE8850")]
		internal void AMJIMMHHAPF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4720", Offset = "0x6BE3B20", VA = "0x186BE4720", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5320", Offset = "0x6BE4720", VA = "0x186BE5320", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, SerializedAvatarItemData PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BE45B0", Offset = "0x6BE39B0", VA = "0x186BE45B0")]
	private AdditionalOutfitTypeData JHDPAMACECP(Utf8JsonReader ILEMOHLPHEC, OutfitType EKNPHEPNHJD, JsonSerializerOptions POLCFNEEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5750", Offset = "0x6BE4B50", VA = "0x186BE5750")]
	public HEMACFIMCMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NBEINOLPGLN : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8330", Offset = "0x6BE7730", VA = "0x186BE8330", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader ILEMOHLPHEC, Type ALOADOBKPCM, JsonSerializerOptions POLCFNEEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE86C0", Offset = "0x6BE7AC0", VA = "0x186BE86C0", Slot = "28")]
	public override void Write(Utf8JsonWriter FJOPPBPMLFL, AvatarItemDownloadableConfig PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE87E0", Offset = "0x6BE7BE0", VA = "0x186BE87E0")]
	public NBEINOLPGLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IIMPFCHBPPN : NKEIAHECAGE<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5960", Offset = "0x6BE4D60", VA = "0x186BE5960", Slot = "35")]
	public override void HAEAGGLGFOL(Utf8JsonReader ILEMOHLPHEC, JsonSerializerOptions POLCFNEEHMO, string CIOJHADPGDL, BeardData DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE58A0", Offset = "0x6BE4CA0", VA = "0x186BE58A0", Slot = "36")]
	public override void FOELCBDALIG(Utf8JsonWriter FJOPPBPMLFL, BeardData PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5B00", Offset = "0x6BE4F00", VA = "0x186BE5B00")]
	public IIMPFCHBPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GPEIILKLIHP : OABGGDPGGEN<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4570", Offset = "0x6BE3970", VA = "0x186BE4570")]
	public GPEIILKLIHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CDFKFEBOFAB : OABGGDPGGEN<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3E40", Offset = "0x6BE3240", VA = "0x186BE3E40")]
	public CDFKFEBOFAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JBDOAKLLEMI : OABGGDPGGEN<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5B40", Offset = "0x6BE4F40", VA = "0x186BE5B40")]
	public JBDOAKLLEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GMELFNPEMBA : JIPOPCFHFGN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4290", Offset = "0x6BE3690", VA = "0x186BE4290")]
	public GMELFNPEMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GOBEIJAHBPK : NKEIAHECAGE<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NMJIFIGGKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NMJIFIGGKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4260", Offset = "0x6BE3660", VA = "0x186BE4260")]
		internal void EJCDIJLHOAM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8820", Offset = "0x6BE7C20", VA = "0x186BE8820")]
		internal void BPIPECNOMNL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BE43A0", Offset = "0x6BE37A0", VA = "0x186BE43A0", Slot = "35")]
	public override void HAEAGGLGFOL(Utf8JsonReader ILEMOHLPHEC, JsonSerializerOptions POLCFNEEHMO, string CIOJHADPGDL, AdditionalFeetData DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BE42D0", Offset = "0x6BE36D0", VA = "0x186BE42D0", Slot = "36")]
	public override void FOELCBDALIG(Utf8JsonWriter FJOPPBPMLFL, AdditionalFeetData PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4530", Offset = "0x6BE3930", VA = "0x186BE4530")]
	public GOBEIJAHBPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MKEIEKKHDDF : NKEIAHECAGE<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class DEGMOJDBBAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public DEGMOJDBBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4040", Offset = "0x6BE3440", VA = "0x186BE4040")]
		internal void EJCDIJLHOAM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4010", Offset = "0x6BE3410", VA = "0x186BE4010")]
		internal void BPIPECNOMNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BE40F0", Offset = "0x6BE34F0", VA = "0x186BE40F0")]
		internal void FECADODFPHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4120", Offset = "0x6BE3520", VA = "0x186BE4120")]
		internal void FGLIJFKMKNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3F70", Offset = "0x6BE3370", VA = "0x186BE3F70")]
		internal void BIDDOCAIGEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BE41C0", Offset = "0x6BE35C0", VA = "0x186BE41C0")]
		internal void FKCKCBNGAMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4260", Offset = "0x6BE3660", VA = "0x186BE4260")]
		internal void KFBOHIGDMPO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7F00", Offset = "0x6BE7300", VA = "0x186BE7F00", Slot = "35")]
	public override void HAEAGGLGFOL(Utf8JsonReader ILEMOHLPHEC, JsonSerializerOptions POLCFNEEHMO, string CIOJHADPGDL, HairData DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7C20", Offset = "0x6BE7020", VA = "0x186BE7C20", Slot = "36")]
	public override void FOELCBDALIG(Utf8JsonWriter FJOPPBPMLFL, HairData PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE82F0", Offset = "0x6BE76F0", VA = "0x186BE82F0")]
	public MKEIEKKHDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LGIKCDFLICP : NKEIAHECAGE<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OMHEMOBMGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OMHEMOBMGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8A50", Offset = "0x6BE7E50", VA = "0x186BE8A50")]
		internal void EJCDIJLHOAM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE89A0", Offset = "0x6BE7DA0", VA = "0x186BE89A0")]
		internal void BPIPECNOMNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8A80", Offset = "0x6BE7E80", VA = "0x186BE8A80")]
		internal void FECADODFPHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8B30", Offset = "0x6BE7F30", VA = "0x186BE8B30")]
		internal void FGLIJFKMKNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE88F0", Offset = "0x6BE7CF0", VA = "0x186BE88F0")]
		internal void BIDDOCAIGEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8BE0", Offset = "0x6BE7FE0", VA = "0x186BE8BE0")]
		internal void FKCKCBNGAMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8C80", Offset = "0x6BE8080", VA = "0x186BE8C80")]
		internal void KFBOHIGDMPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8D20", Offset = "0x6BE8120", VA = "0x186BE8D20")]
		internal void LGPMNDFBMMD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5ED0", Offset = "0x6BE52D0", VA = "0x186BE5ED0", Slot = "35")]
	public override void HAEAGGLGFOL(Utf8JsonReader ILEMOHLPHEC, JsonSerializerOptions POLCFNEEHMO, string CIOJHADPGDL, AdditionalHatData DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5B80", Offset = "0x6BE4F80", VA = "0x186BE5B80", Slot = "36")]
	public override void FOELCBDALIG(Utf8JsonWriter FJOPPBPMLFL, AdditionalHatData PFKKDHPJFEH, JsonSerializerOptions POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6330", Offset = "0x6BE5730", VA = "0x186BE6330")]
	public LGIKCDFLICP()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8A7060", Offset = "0x8A6460", VA = "0x1808A7060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x983FC0", Offset = "0x9833C0", VA = "0x180983FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x983EB0", Offset = "0x9832B0", VA = "0x180983EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x983FD0", Offset = "0x9833D0", VA = "0x180983FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x983EC0", Offset = "0x9832C0", VA = "0x180983EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xABACB0", Offset = "0xABA0B0", VA = "0x180ABACB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xABAD00", Offset = "0xABA100", VA = "0x180ABAD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1874DB0", Offset = "0x18741B0", VA = "0x181874DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6BE8DC0", Offset = "0x6BE81C0", VA = "0x186BE8DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x25B8DD0", Offset = "0x25B81D0", VA = "0x1825B8DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x25B8D10", Offset = "0x25B8110", VA = "0x1825B8D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1E80920", Offset = "0x1E7FD20", VA = "0x181E80920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1E80930", Offset = "0x1E7FD30", VA = "0x181E80930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MNFPGDBOOJI.NOHJIBHJCAM ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA021D0", Offset = "0xA015D0", VA = "0x180A021D0")]
			[CompilerGenerated]
			get
			{
				return default(MNFPGDBOOJI.NOHJIBHJCAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA01E90", Offset = "0xA01290", VA = "0x180A01E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x89FBE0", Offset = "0x89EFE0", VA = "0x18089FBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
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
