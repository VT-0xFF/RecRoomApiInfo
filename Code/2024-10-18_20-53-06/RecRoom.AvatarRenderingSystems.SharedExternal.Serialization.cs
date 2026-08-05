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
public class HAHNGHDEANE : DILCFNBHDLH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA16A60", Offset = "0xA15E60", VA = "0x180A16A60", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E3D0", Offset = "0x6C6D7D0", VA = "0x186C6E3D0", Slot = "36")]
	protected override Vector3 EJNAHOBOJHC(float[] BFAMJIIMLEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E420", Offset = "0x6C6D820", VA = "0x186C6E420", Slot = "37")]
	protected override float[] KHNNMIAFACK(Vector3 EEPLCHCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E4A0", Offset = "0x6C6D8A0", VA = "0x186C6E4A0")]
	public HAHNGHDEANE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CHIEOPEPMLD : DILCFNBHDLH<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9E9140", Offset = "0x9E8540", VA = "0x1809E9140", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C6DDD0", Offset = "0x6C6D1D0", VA = "0x186C6DDD0", Slot = "36")]
	protected override Vector2 EJNAHOBOJHC(float[] BFAMJIIMLEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C6DE10", Offset = "0x6C6D210", VA = "0x186C6DE10", Slot = "37")]
	protected override float[] KHNNMIAFACK(Vector2 EEPLCHCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C6DE80", Offset = "0x6C6D280", VA = "0x186C6DE80")]
	public CHIEOPEPMLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PFGKJDNMKGA : DILCFNBHDLH<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB83D00", Offset = "0xB83100", VA = "0x180B83D00", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C71CD0", Offset = "0x6C710D0", VA = "0x186C71CD0", Slot = "36")]
	protected override Quaternion EJNAHOBOJHC(float[] BFAMJIIMLEB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C71D30", Offset = "0x6C71130", VA = "0x186C71D30", Slot = "37")]
	protected override float[] KHNNMIAFACK(Quaternion EEPLCHCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C71DC0", Offset = "0x6C711C0", VA = "0x186C71DC0")]
	public PFGKJDNMKGA()
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
		public enum LMLHBFHMLHA
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
		public LMLHBFHMLHA Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
			[CompilerGenerated]
			get
			{
				return default(LMLHBFHMLHA);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA29600", Offset = "0xA28A00", VA = "0x180A29600")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NIPHFNKOLPK : GDLEBDKAKAC<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AIPBONNGCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AIPBONNGCDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D250", Offset = "0x6C6C650", VA = "0x186C6D250")]
		internal void KBFHMCKOGEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D300", Offset = "0x6C6C700", VA = "0x186C6D300")]
		internal void KOIKIFLCCNH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D1A0", Offset = "0x6C6C5A0", VA = "0x186C6D1A0")]
		internal void JAHJMLABCHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D3B0", Offset = "0x6C6C7B0", VA = "0x186C6D3B0")]
		internal void LCIFHALBGAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CEF0", Offset = "0x6C6C2F0", VA = "0x186C6CEF0")]
		internal void BGCAPNIJIOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CFA0", Offset = "0x6C6C3A0", VA = "0x186C6CFA0")]
		internal void GHHOGFHMBHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D500", Offset = "0x6C6C900", VA = "0x186C6D500")]
		internal void NHNMDDNEPHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D050", Offset = "0x6C6C450", VA = "0x186C6D050")]
		internal void IPBDFKFNEEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D100", Offset = "0x6C6C500", VA = "0x186C6D100")]
		internal void JACEANNOIHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D460", Offset = "0x6C6C860", VA = "0x186C6D460")]
		internal void MFIIAKJOOCE(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NCGKHBPIGLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C712E0", Offset = "0x6C706E0", VA = "0x186C712E0", Slot = "35")]
	public override void FDLIIDBIBGI(Utf8JsonReader GDCGEJPDKCM, JsonSerializerOptions ALOJIDNACGI, string BMAAJNANOMC, AnchorParamsRestrictions HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C71800", Offset = "0x6C70C00", VA = "0x186C71800", Slot = "36")]
	public override void GGBFJNKJJFL(Utf8JsonWriter HOKCJMCABPI, AnchorParamsRestrictions EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C71C90", Offset = "0x6C71090", VA = "0x186C71C90")]
	public NIPHFNKOLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9270", Offset = "0x2FB8670", VA = "0x182FB9270")]
	[CompilerGenerated]
	internal static void DILCELILJKJ<T>(string BMAAJNANOMC, T OAKJBMEGCLP, T DFPDJPIKCJA, NCGKHBPIGLB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JMMDBCJNEOL : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void LLOHNLOOAFA(Utf8JsonReader BHJLLDMOPFC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LNLEMHOMLMG
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
		public JMMDBCJNEOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LLOHNLOOAFA <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LLOHNLOOAFA <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LLOHNLOOAFA <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LLOHNLOOAFA <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LLOHNLOOAFA <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LLOHNLOOAFA <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LLOHNLOOAFA <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LLOHNLOOAFA <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LLOHNLOOAFA <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LLOHNLOOAFA <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LLOHNLOOAFA <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LNLEMHOMLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C70330", Offset = "0x6C6F730", VA = "0x186C70330")]
		internal void EBGEKIIIPEN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C70420", Offset = "0x6C6F820", VA = "0x186C70420")]
		internal void INKKICBCFNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C70370", Offset = "0x6C6F770", VA = "0x186C70370")]
		internal void IDLHGGFHFFD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C707A0", Offset = "0x6C6FBA0", VA = "0x186C707A0")]
		internal void ONGOBLEMKKL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C70160", Offset = "0x6C6F560", VA = "0x186C70160")]
		internal void AAGPJOJAGHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C706F0", Offset = "0x6C6FAF0", VA = "0x186C706F0")]
		internal void NKBACDBFEND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C70720", Offset = "0x6C6FB20", VA = "0x186C70720")]
		internal void NPMEIFKCIMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C70210", Offset = "0x6C6F610", VA = "0x186C70210")]
		internal void AFCDKODHFHH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C702F0", Offset = "0x6C6F6F0", VA = "0x186C702F0")]
		internal void CNMGHMJGAFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C704D0", Offset = "0x6C6F8D0", VA = "0x186C704D0")]
		internal void JMDLMJEIIGC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C70570", Offset = "0x6C6F970", VA = "0x186C70570")]
		internal void KEHJIOCDHFL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KJJCKFEEFFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KJJCKFEEFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F9C0", Offset = "0x6C6EDC0", VA = "0x186C6F9C0")]
		internal void GHHCLPFJLFI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E970", Offset = "0x6C6DD70", VA = "0x186C6E970", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F550", Offset = "0x6C6E950", VA = "0x186C6F550", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, SerializedAvatarItemData EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E800", Offset = "0x6C6DC00", VA = "0x186C6E800")]
	private AdditionalOutfitTypeData BEBFHGBBDFK(Utf8JsonReader GDCGEJPDKCM, OutfitType DPOLEDLIAMP, JsonSerializerOptions ALOJIDNACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F980", Offset = "0x6C6ED80", VA = "0x186C6F980")]
	public JMMDBCJNEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MBMHEFMAFBC : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C70850", Offset = "0x6C6FC50", VA = "0x186C70850", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader GDCGEJPDKCM, Type GLKOGOFNAAO, JsonSerializerOptions ALOJIDNACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C70BE0", Offset = "0x6C6FFE0", VA = "0x186C70BE0", Slot = "28")]
	public override void Write(Utf8JsonWriter HOKCJMCABPI, AvatarItemDownloadableConfig EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C70D00", Offset = "0x6C70100", VA = "0x186C70D00")]
	public MBMHEFMAFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IHJLANLNKIH : GDLEBDKAKAC<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E560", Offset = "0x6C6D960", VA = "0x186C6E560", Slot = "35")]
	public override void FDLIIDBIBGI(Utf8JsonReader GDCGEJPDKCM, JsonSerializerOptions ALOJIDNACGI, string BMAAJNANOMC, BeardData HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E700", Offset = "0x6C6DB00", VA = "0x186C6E700", Slot = "36")]
	public override void GGBFJNKJJFL(Utf8JsonWriter HOKCJMCABPI, BeardData EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E7C0", Offset = "0x6C6DBC0", VA = "0x186C6E7C0")]
	public IHJLANLNKIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MKGILGACHNB : LJMFMDJKMPO<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C71000", Offset = "0x6C70400", VA = "0x186C71000")]
	public MKGILGACHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HBDHFIKMDJB : LJMFMDJKMPO<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E4E0", Offset = "0x6C6D8E0", VA = "0x186C6E4E0")]
	public HBDHFIKMDJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GGBONHBKJHB : LJMFMDJKMPO<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E390", Offset = "0x6C6D790", VA = "0x186C6E390")]
	public GGBONHBKJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ICAEOGLJNMN : OFMMMKFGKCD<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E520", Offset = "0x6C6D920", VA = "0x186C6E520")]
	public ICAEOGLJNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NDNGDJJPIAH : GDLEBDKAKAC<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AGEKIOJEJKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AGEKIOJEJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CE90", Offset = "0x6C6C290", VA = "0x186C6CE90")]
		internal void KBFHMCKOGEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CEC0", Offset = "0x6C6C2C0", VA = "0x186C6CEC0")]
		internal void KOIKIFLCCNH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C71040", Offset = "0x6C70440", VA = "0x186C71040", Slot = "35")]
	public override void FDLIIDBIBGI(Utf8JsonReader GDCGEJPDKCM, JsonSerializerOptions ALOJIDNACGI, string BMAAJNANOMC, AdditionalFeetData HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C711D0", Offset = "0x6C705D0", VA = "0x186C711D0", Slot = "36")]
	public override void GGBFJNKJJFL(Utf8JsonWriter HOKCJMCABPI, AdditionalFeetData EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C712A0", Offset = "0x6C706A0", VA = "0x186C712A0")]
	public NDNGDJJPIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LDDGHPEOOAP : GDLEBDKAKAC<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MJOHECCDNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MJOHECCDNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C70E80", Offset = "0x6C70280", VA = "0x186C70E80")]
		internal void KBFHMCKOGEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C70F30", Offset = "0x6C70330", VA = "0x186C70F30")]
		internal void KOIKIFLCCNH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C706F0", Offset = "0x6C6FAF0", VA = "0x186C706F0")]
		internal void JAHJMLABCHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C70F60", Offset = "0x6C70360", VA = "0x186C70F60")]
		internal void LCIFHALBGAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C70D40", Offset = "0x6C70140", VA = "0x186C70D40")]
		internal void BGCAPNIJIOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C70DE0", Offset = "0x6C701E0", VA = "0x186C70DE0")]
		internal void GHHOGFHMBHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CE90", Offset = "0x6C6C290", VA = "0x186C6CE90")]
		internal void NHNMDDNEPHF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FA60", Offset = "0x6C6EE60", VA = "0x186C6FA60", Slot = "35")]
	public override void FDLIIDBIBGI(Utf8JsonReader GDCGEJPDKCM, JsonSerializerOptions ALOJIDNACGI, string BMAAJNANOMC, HairData HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FE50", Offset = "0x6C6F250", VA = "0x186C6FE50", Slot = "36")]
	public override void GGBFJNKJJFL(Utf8JsonWriter HOKCJMCABPI, HairData EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C70120", Offset = "0x6C6F520", VA = "0x186C70120")]
	public LDDGHPEOOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AAJLNKEDLGJ : GDLEBDKAKAC<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DMOGCDLCLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DMOGCDLCLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E160", Offset = "0x6C6D560", VA = "0x186C6E160")]
		internal void KBFHMCKOGEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E190", Offset = "0x6C6D590", VA = "0x186C6E190")]
		internal void KOIKIFLCCNH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E0B0", Offset = "0x6C6D4B0", VA = "0x186C6E0B0")]
		internal void JAHJMLABCHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E240", Offset = "0x6C6D640", VA = "0x186C6E240")]
		internal void LCIFHALBGAO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DEC0", Offset = "0x6C6D2C0", VA = "0x186C6DEC0")]
		internal void BGCAPNIJIOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DF70", Offset = "0x6C6D370", VA = "0x186C6DF70")]
		internal void GHHOGFHMBHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E2F0", Offset = "0x6C6D6F0", VA = "0x186C6E2F0")]
		internal void NHNMDDNEPHF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E010", Offset = "0x6C6D410", VA = "0x186C6E010")]
		internal void IPBDFKFNEEB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C6B0", Offset = "0x6C6BAB0", VA = "0x186C6C6B0", Slot = "35")]
	public override void FDLIIDBIBGI(Utf8JsonReader GDCGEJPDKCM, JsonSerializerOptions ALOJIDNACGI, string BMAAJNANOMC, AdditionalHatData HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C6CB10", Offset = "0x6C6BF10", VA = "0x186C6CB10", Slot = "36")]
	public override void GGBFJNKJJFL(Utf8JsonWriter HOKCJMCABPI, AdditionalHatData EEPLCHCGAIN, JsonSerializerOptions ALOJIDNACGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C6CE50", Offset = "0x6C6C250", VA = "0x186C6CE50")]
	public AAJLNKEDLGJ()
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
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8AACE0", Offset = "0x8AA0E0", VA = "0x1808AACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9439B0", Offset = "0x942DB0", VA = "0x1809439B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9438A0", Offset = "0x942CA0", VA = "0x1809438A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9439C0", Offset = "0x942DC0", VA = "0x1809439C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9438B0", Offset = "0x942CB0", VA = "0x1809438B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA50A90", Offset = "0xA4FE90", VA = "0x180A50A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA50A00", Offset = "0xA4FE00", VA = "0x180A50A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x188E380", Offset = "0x188D780", VA = "0x18188E380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6C71E00", Offset = "0x6C71200", VA = "0x186C71E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x257EB10", Offset = "0x257DF10", VA = "0x18257EB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x257ED50", Offset = "0x257E150", VA = "0x18257ED50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1E1D190", Offset = "0x1E1C590", VA = "0x181E1D190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1E1D1A0", Offset = "0x1E1C5A0", VA = "0x181E1D1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GKIFLDBNEKK.AOOMGKPMPMM ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B7610", Offset = "0x9B6A10", VA = "0x1809B7610")]
			[CompilerGenerated]
			get
			{
				return default(GKIFLDBNEKK.AOOMGKPMPMM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B78B0", Offset = "0x9B6CB0", VA = "0x1809B78B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB70", Offset = "0x8AEF70", VA = "0x1808AFB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
