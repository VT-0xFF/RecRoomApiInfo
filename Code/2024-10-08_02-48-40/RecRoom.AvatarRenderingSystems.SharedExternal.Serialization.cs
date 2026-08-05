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
public class IJJDJNOOAEH : NKDABMHPGHM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9FADB0", Offset = "0x9F9FB0", VA = "0x1809FADB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B03B10", Offset = "0x6B02D10", VA = "0x186B03B10", Slot = "36")]
	protected override Vector3 FDHDHNOIOIH(float[] JFBMKPGOEFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B03B60", Offset = "0x6B02D60", VA = "0x186B03B60", Slot = "37")]
	protected override float[] KEDDAKPCPDO(Vector3 JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B03BE0", Offset = "0x6B02DE0", VA = "0x186B03BE0")]
	public IJJDJNOOAEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EIGDDIPFDNF : NKDABMHPGHM<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9CE470", Offset = "0x9CD670", VA = "0x1809CE470", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B02150", Offset = "0x6B01350", VA = "0x186B02150", Slot = "36")]
	protected override Vector2 FDHDHNOIOIH(float[] JFBMKPGOEFO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B02190", Offset = "0x6B01390", VA = "0x186B02190", Slot = "37")]
	protected override float[] KEDDAKPCPDO(Vector2 JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B02200", Offset = "0x6B01400", VA = "0x186B02200")]
	public EIGDDIPFDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JOJDPNDBCKP : NKDABMHPGHM<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB6DF20", Offset = "0xB6D120", VA = "0x180B6DF20", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B03C20", Offset = "0x6B02E20", VA = "0x186B03C20", Slot = "36")]
	protected override Quaternion FDHDHNOIOIH(float[] JFBMKPGOEFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B03C80", Offset = "0x6B02E80", VA = "0x186B03C80", Slot = "37")]
	protected override float[] KEDDAKPCPDO(Quaternion JECHHBGMFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B03D10", Offset = "0x6B02F10", VA = "0x186B03D10")]
	public JOJDPNDBCKP()
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
		public enum POPHEHPFJFF
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
		public POPHEHPFJFF Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
			[CompilerGenerated]
			get
			{
				return default(POPHEHPFJFF);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0FBC0", Offset = "0xA0EDC0", VA = "0x180A0FBC0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KNGEFNGEGFE : BIOABCFDIOG<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AEJKOAFGNLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AEJKOAFGNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B00800", Offset = "0x6AFFA00", VA = "0x186B00800")]
		internal void BHAEFPCPCGC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B00B50", Offset = "0x6AFFD50", VA = "0x186B00B50")]
		internal void NNPHNBNDFCM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B00750", Offset = "0x6AFF950", VA = "0x186B00750")]
		internal void ANCLBHGMODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B00950", Offset = "0x6AFFB50", VA = "0x186B00950")]
		internal void GCLNBILJDLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B00A00", Offset = "0x6AFFC00", VA = "0x186B00A00")]
		internal void HEMCHMHDGDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B00C00", Offset = "0x6AFFE00", VA = "0x186B00C00")]
		internal void OANAMONKLEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B00CB0", Offset = "0x6AFFEB0", VA = "0x186B00CB0")]
		internal void OENIOOPHNIK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B00D60", Offset = "0x6AFFF60", VA = "0x186B00D60")]
		internal void PBGFGKBCJKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B008B0", Offset = "0x6AFFAB0", VA = "0x186B008B0")]
		internal void ENOJPELPCND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B00AB0", Offset = "0x6AFFCB0", VA = "0x186B00AB0")]
		internal void IOAJOHCDKDI(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GIFBIBGKMDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B044D0", Offset = "0x6B036D0", VA = "0x186B044D0", Slot = "35")]
	public override void OLGKLOHBDJG(Utf8JsonReader IDGMLEGKFGC, JsonSerializerOptions PCHCKDDGLBA, string AHFDEHOMLEN, AnchorParamsRestrictions LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B04040", Offset = "0x6B03240", VA = "0x186B04040", Slot = "36")]
	public override void BIMKDIDKGKA(Utf8JsonWriter MIOAACOLOAF, AnchorParamsRestrictions JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B049F0", Offset = "0x6B03BF0", VA = "0x186B049F0")]
	public KNGEFNGEGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2EE5B40", Offset = "0x2EE4D40", VA = "0x182EE5B40")]
	[CompilerGenerated]
	internal static void GEOKDKGDNPD<T>(string AHFDEHOMLEN, T MIOIFIAKEJG, T ACPDMCOMANC, GIFBIBGKMDK P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GFCKFBPNHLE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void KJBAGJGJGEO(Utf8JsonReader KHFLFLECNEB);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NOOMFEPNHJG
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
		public GFCKFBPNHLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KJBAGJGJGEO <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KJBAGJGJGEO <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KJBAGJGJGEO <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KJBAGJGJGEO <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KJBAGJGJGEO <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KJBAGJGJGEO <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KJBAGJGJGEO <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KJBAGJGJGEO <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KJBAGJGJGEO <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KJBAGJGJGEO <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KJBAGJGJGEO <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KJBAGJGJGEO <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KJBAGJGJGEO <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KJBAGJGJGEO <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NOOMFEPNHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B05630", Offset = "0x6B04830", VA = "0x186B05630")]
		internal void JFNOLAHLICE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B03D50", Offset = "0x6B02F50", VA = "0x186B03D50")]
		internal void HJPDEKOCFFD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B05360", Offset = "0x6B04560", VA = "0x186B05360")]
		internal void HMEMLFHEAAB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B057D0", Offset = "0x6B049D0", VA = "0x186B057D0")]
		internal void OIIKADIMDFI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6B05130", Offset = "0x6B04330", VA = "0x186B05130")]
		internal void AGJNMNANJEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6B05220", Offset = "0x6B04420", VA = "0x186B05220")]
		internal void DPOJDHNGBCL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6B052D0", Offset = "0x6B044D0", VA = "0x186B052D0")]
		internal void GJDLDJOEFNH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B05330", Offset = "0x6B04530", VA = "0x186B05330")]
		internal void HMDLKHNPKJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B05300", Offset = "0x6B04500", VA = "0x186B05300")]
		internal void HACFGBFMLHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B05750", Offset = "0x6B04950", VA = "0x186B05750")]
		internal void OGOCFNCCHKP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B05670", Offset = "0x6B04870", VA = "0x186B05670")]
		internal void OGHBCCCIPOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B051E0", Offset = "0x6B043E0", VA = "0x186B051E0")]
		internal void DCHCGKAFMJI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B05410", Offset = "0x6B04610", VA = "0x186B05410")]
		internal void IECFGHDDNIF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B054B0", Offset = "0x6B046B0", VA = "0x186B054B0")]
		internal void JCGLBOCPHCE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B028C0", Offset = "0x6B01AC0", VA = "0x186B028C0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B03340", Offset = "0x6B02540", VA = "0x186B03340", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, SerializedAvatarItemData JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B02750", Offset = "0x6B01950", VA = "0x186B02750")]
	private AdditionalOutfitTypeData GHFIHBGEGFD(Utf8JsonReader IDGMLEGKFGC, OutfitType EIHDAHDDDEG, JsonSerializerOptions PCHCKDDGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B037F0", Offset = "0x6B029F0", VA = "0x186B037F0")]
	public GFCKFBPNHLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PCBOKLFMNOI : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B058C0", Offset = "0x6B04AC0", VA = "0x186B058C0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader IDGMLEGKFGC, Type FBMBKANFAJC, JsonSerializerOptions PCHCKDDGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B05C50", Offset = "0x6B04E50", VA = "0x186B05C50", Slot = "28")]
	public override void Write(Utf8JsonWriter MIOAACOLOAF, AvatarItemDownloadableConfig JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B05D70", Offset = "0x6B04F70", VA = "0x186B05D70")]
	public PCBOKLFMNOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HDMIMHPNHIA : BIOABCFDIOG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B038F0", Offset = "0x6B02AF0", VA = "0x186B038F0", Slot = "35")]
	public override void OLGKLOHBDJG(Utf8JsonReader IDGMLEGKFGC, JsonSerializerOptions PCHCKDDGLBA, string AHFDEHOMLEN, BeardData LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B03830", Offset = "0x6B02A30", VA = "0x186B03830", Slot = "36")]
	public override void BIMKDIDKGKA(Utf8JsonWriter MIOAACOLOAF, BeardData JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B03A90", Offset = "0x6B02C90", VA = "0x186B03A90")]
	public HDMIMHPNHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OJOILGIIPLB : EMPONKEMAHP<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B05880", Offset = "0x6B04A80", VA = "0x186B05880")]
	public OJOILGIIPLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BLMMELMKEKE : EMPONKEMAHP<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B01690", Offset = "0x6B00890", VA = "0x186B01690")]
	public BLMMELMKEKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FLHEMEHPKDH : EMPONKEMAHP<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B02710", Offset = "0x6B01910", VA = "0x186B02710")]
	public FLHEMEHPKDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HIAFKJPFIPI : NFFMCDDEIJG<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B03AD0", Offset = "0x6B02CD0", VA = "0x186B03AD0")]
	public HIAFKJPFIPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DNOOEHNOBCM : BIOABCFDIOG<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BDPKFDLKPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public BDPKFDLKPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B01630", Offset = "0x6B00830", VA = "0x186B01630")]
		internal void BHAEFPCPCGC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B01660", Offset = "0x6B00860", VA = "0x186B01660")]
		internal void NNPHNBNDFCM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B017A0", Offset = "0x6B009A0", VA = "0x186B017A0", Slot = "35")]
	public override void OLGKLOHBDJG(Utf8JsonReader IDGMLEGKFGC, JsonSerializerOptions PCHCKDDGLBA, string AHFDEHOMLEN, AdditionalFeetData LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B016D0", Offset = "0x6B008D0", VA = "0x186B016D0", Slot = "36")]
	public override void BIMKDIDKGKA(Utf8JsonWriter MIOAACOLOAF, AdditionalFeetData JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B01930", Offset = "0x6B00B30", VA = "0x186B01930")]
	public DNOOEHNOBCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MMAJKBMDNIO : BIOABCFDIOG<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KDIGCNGCMJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public KDIGCNGCMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B03D80", Offset = "0x6B02F80", VA = "0x186B03D80")]
		internal void BHAEFPCPCGC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B03F70", Offset = "0x6B03170", VA = "0x186B03F70")]
		internal void NNPHNBNDFCM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B03D50", Offset = "0x6B02F50", VA = "0x186B03D50")]
		internal void ANCLBHGMODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6B03E30", Offset = "0x6B03030", VA = "0x186B03E30")]
		internal void GCLNBILJDLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B03ED0", Offset = "0x6B030D0", VA = "0x186B03ED0")]
		internal void HEMCHMHDGDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B03FA0", Offset = "0x6B031A0", VA = "0x186B03FA0")]
		internal void OANAMONKLEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B01630", Offset = "0x6B00830", VA = "0x186B01630")]
		internal void OENIOOPHNIK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B04D00", Offset = "0x6B03F00", VA = "0x186B04D00", Slot = "35")]
	public override void OLGKLOHBDJG(Utf8JsonReader IDGMLEGKFGC, JsonSerializerOptions PCHCKDDGLBA, string AHFDEHOMLEN, HairData LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B04A30", Offset = "0x6B03C30", VA = "0x186B04A30", Slot = "36")]
	public override void BIMKDIDKGKA(Utf8JsonWriter MIOAACOLOAF, HairData JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6B050F0", Offset = "0x6B042F0", VA = "0x186B050F0")]
	public MMAJKBMDNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DPKPENIBNKH : BIOABCFDIOG<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FIPPILEJAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public FIPPILEJAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B022F0", Offset = "0x6B014F0", VA = "0x186B022F0")]
		internal void BHAEFPCPCGC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6B02480", Offset = "0x6B01680", VA = "0x186B02480")]
		internal void NNPHNBNDFCM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B02240", Offset = "0x6B01440", VA = "0x186B02240")]
		internal void ANCLBHGMODO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B02320", Offset = "0x6B01520", VA = "0x186B02320")]
		internal void GCLNBILJDLC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B023D0", Offset = "0x6B015D0", VA = "0x186B023D0")]
		internal void HEMCHMHDGDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6B02530", Offset = "0x6B01730", VA = "0x186B02530")]
		internal void OANAMONKLEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B025D0", Offset = "0x6B017D0", VA = "0x186B025D0")]
		internal void OENIOOPHNIK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B02670", Offset = "0x6B01870", VA = "0x186B02670")]
		internal void PBGFGKBCJKA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B01CB0", Offset = "0x6B00EB0", VA = "0x186B01CB0", Slot = "35")]
	public override void OLGKLOHBDJG(Utf8JsonReader IDGMLEGKFGC, JsonSerializerOptions PCHCKDDGLBA, string AHFDEHOMLEN, AdditionalHatData LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B01970", Offset = "0x6B00B70", VA = "0x186B01970", Slot = "36")]
	public override void BIMKDIDKGKA(Utf8JsonWriter MIOAACOLOAF, AdditionalHatData JECHHBGMFLN, JsonSerializerOptions PCHCKDDGLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6B02110", Offset = "0x6B01310", VA = "0x186B02110")]
	public DPKPENIBNKH()
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
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x89A5C0", Offset = "0x8997C0", VA = "0x18089A5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x931B30", Offset = "0x930D30", VA = "0x180931B30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9319F0", Offset = "0x930BF0", VA = "0x1809319F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x931B40", Offset = "0x930D40", VA = "0x180931B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x931A00", Offset = "0x930C00", VA = "0x180931A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA2C0D0", Offset = "0xA2B2D0", VA = "0x180A2C0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA2C290", Offset = "0xA2B490", VA = "0x180A2C290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x186C350", Offset = "0x186B550", VA = "0x18186C350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6B05DB0", Offset = "0x6B04FB0", VA = "0x186B05DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2542AF0", Offset = "0x2541CF0", VA = "0x182542AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2542A40", Offset = "0x2541C40", VA = "0x182542A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1DF7D60", Offset = "0x1DF6F60", VA = "0x181DF7D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1DF7D70", Offset = "0x1DF6F70", VA = "0x181DF7D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AvatarItemBodyType ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98D7B0", Offset = "0x98C9B0", VA = "0x18098D7B0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98D7A0", Offset = "0x98C9A0", VA = "0x18098D7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BNHBDMOEGLN.PAEIABBACMD ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x96D780", Offset = "0x96C980", VA = "0x18096D780")]
			[CompilerGenerated]
			get
			{
				return default(BNHBDMOEGLN.PAEIABBACMD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x96BB50", Offset = "0x96AD50", VA = "0x18096BB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x894430", Offset = "0x893630", VA = "0x180894430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB61690", Offset = "0xB60890", VA = "0x180B61690")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB5F840", Offset = "0xB5EA40", VA = "0x180B5F840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x132BE00", Offset = "0x132B000", VA = "0x18132BE00")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x443B1F0", Offset = "0x443A3F0", VA = "0x18443B1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
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
