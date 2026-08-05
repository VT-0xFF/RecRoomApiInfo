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
public class OECBDBKBBBE : LKGEIDDIFOA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC74860", Offset = "0xC72E60", VA = "0x180C74860", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E231E0", Offset = "0x7E217E0", VA = "0x187E231E0", Slot = "36")]
	protected override Vector3 AOMMIPJHIMA(float[] NIJLHKNCLKB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E23230", Offset = "0x7E21830", VA = "0x187E23230", Slot = "37")]
	protected override float[] DCHHGDINECP(Vector3 KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E232B0", Offset = "0x7E218B0", VA = "0x187E232B0")]
	public OECBDBKBBBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCMNFDAELFM : LKGEIDDIFOA<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC8CD50", Offset = "0xC8B350", VA = "0x180C8CD50", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E204E0", Offset = "0x7E1EAE0", VA = "0x187E204E0", Slot = "36")]
	protected override Vector2 AOMMIPJHIMA(float[] NIJLHKNCLKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E20520", Offset = "0x7E1EB20", VA = "0x187E20520", Slot = "37")]
	protected override float[] DCHHGDINECP(Vector2 KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E20590", Offset = "0x7E1EB90", VA = "0x187E20590")]
	public GCMNFDAELFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IGCKMENNNJA : LKGEIDDIFOA<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAED9C0", Offset = "0xAEBFC0", VA = "0x180AED9C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E20FD0", Offset = "0x7E1F5D0", VA = "0x187E20FD0", Slot = "36")]
	protected override Quaternion AOMMIPJHIMA(float[] NIJLHKNCLKB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E21030", Offset = "0x7E1F630", VA = "0x187E21030", Slot = "37")]
	protected override float[] DCHHGDINECP(Quaternion KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E210C0", Offset = "0x7E1F6C0", VA = "0x187E210C0")]
	public IGCKMENNNJA()
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
		public enum KDJMIJJMOOC
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
		public KDJMIJJMOOC Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
			[CompilerGenerated]
			get
			{
				return default(KDJMIJJMOOC);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F080", Offset = "0x7E1D680", VA = "0x187E1F080", Slot = "0")]
		public override bool Equals(object HOPHFOOKMCC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F2F0", Offset = "0x7E1D8F0", VA = "0x187E1F2F0")]
		public static bool JKIBMILPCGE(AvatarItemDownloadableConfig DBDIOGELIIH, AvatarItemDownloadableConfig LHANOGJMGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F1B0", Offset = "0x7E1D7B0", VA = "0x187E1F1B0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F280", Offset = "0x7E1D880", VA = "0x187E1F280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xFADBB0", Offset = "0xFAC1B0", VA = "0x180FADBB0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, FOAALLIHHLC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7E24BC0", Offset = "0x7E231C0", VA = "0x187E24BC0")]
		private void CEDNCDOPGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C50", Offset = "0x7E23250", VA = "0x187E24C50", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E24CD0", Offset = "0x7E232D0", VA = "0x187E24CD0", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E24BC0", Offset = "0x7E231C0", VA = "0x187E24BC0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DD0", Offset = "0x7E233D0", VA = "0x187E24DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GNDDDBDFMNP : LPPGONGBJCO<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JCLFNLGJDCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JCLFNLGJDCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E21460", Offset = "0x7E1FA60", VA = "0x187E21460")]
		internal void LIBEJBEDNGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E21300", Offset = "0x7E1F900", VA = "0x187E21300")]
		internal void KELCMDCIJPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E213B0", Offset = "0x7E1F9B0", VA = "0x187E213B0")]
		internal void KKOAMKOFLFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E21250", Offset = "0x7E1F850", VA = "0x187E21250")]
		internal void GPCEBIPMOJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E215B0", Offset = "0x7E1FBB0", VA = "0x187E215B0")]
		internal void NCGHKMAJHPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E21710", Offset = "0x7E1FD10", VA = "0x187E21710")]
		internal void PPPLAOFPOIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E211A0", Offset = "0x7E1F7A0", VA = "0x187E211A0")]
		internal void GIAJCOLANDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E21660", Offset = "0x7E1FC60", VA = "0x187E21660")]
		internal void PHFMCLKAEID(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E21510", Offset = "0x7E1FB10", VA = "0x187E21510")]
		internal void MCDHPALEOFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E21100", Offset = "0x7E1F700", VA = "0x187E21100")]
		internal void FKJJKGGMMLO(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PJHILMLEFFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E205D0", Offset = "0x7E1EBD0", VA = "0x187E205D0", Slot = "35")]
	public override void CMDBACILNBC(Utf8JsonReader KMBIKKJCMFN, JsonSerializerOptions PANLLLBJFBB, string ALIOJODOECN, AnchorParamsRestrictions GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E20AF0", Offset = "0x7E1F0F0", VA = "0x187E20AF0", Slot = "36")]
	public override void DIDJPEEPPFE(Utf8JsonWriter DCGAFNKBAGF, AnchorParamsRestrictions KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E20F90", Offset = "0x7E1F590", VA = "0x187E20F90")]
	public GNDDDBDFMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B56730", Offset = "0x3B54D30", VA = "0x183B56730")]
	[CompilerGenerated]
	internal static void GAIAKAFIHNB<T>(string ALIOJODOECN, T FADBOFNILPL, T KABEHHHCHDA, PJHILMLEFFB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NDHANCLDCHO : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void LEMGJKADHMP(Utf8JsonReader GBHEJJJMLLO);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OEGDFNOLCHH
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
		public NDHANCLDCHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LEMGJKADHMP <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LEMGJKADHMP <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LEMGJKADHMP <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LEMGJKADHMP <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LEMGJKADHMP <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LEMGJKADHMP <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LEMGJKADHMP <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LEMGJKADHMP <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LEMGJKADHMP <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public LEMGJKADHMP <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LEMGJKADHMP <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OEGDFNOLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E238B0", Offset = "0x7E21EB0", VA = "0x187E238B0")]
		internal void KNJDABCKBJF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E23720", Offset = "0x7E21D20", VA = "0x187E23720")]
		internal void JELKNGFCPJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E23410", Offset = "0x7E21A10", VA = "0x187E23410")]
		internal void FGMPAEPBDKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E234C0", Offset = "0x7E21AC0", VA = "0x187E234C0")]
		internal void FHGEJLJFAKI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E23930", Offset = "0x7E21F30", VA = "0x187E23930")]
		internal void MKKKLHPANPG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E23570", Offset = "0x7E21B70", VA = "0x187E23570")]
		internal void FKHAHPHCOFE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E23390", Offset = "0x7E21990", VA = "0x187E23390")]
		internal void FEBKDKOFMJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E237D0", Offset = "0x7E21DD0", VA = "0x187E237D0")]
		internal void KBJHHELPKBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E238F0", Offset = "0x7E21EF0", VA = "0x187E238F0")]
		internal void LKHHHFJKHIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E232F0", Offset = "0x7E218F0", VA = "0x187E232F0")]
		internal void EGMEJFOILJD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E235A0", Offset = "0x7E21BA0", VA = "0x187E235A0")]
		internal void IDABAKBEMAG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MCJMEEDGKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public MCJMEEDGKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E21840", Offset = "0x7E1FE40", VA = "0x187E21840")]
		internal void CFNAKDLNLLA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E21A50", Offset = "0x7E20050", VA = "0x187E21A50", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E22650", Offset = "0x7E20C50", VA = "0x187E22650", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, SerializedAvatarItemData KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E218E0", Offset = "0x7E1FEE0", VA = "0x187E218E0")]
	private AdditionalOutfitTypeData OAMLOKNEOGN(Utf8JsonReader KMBIKKJCMFN, OutfitType JLPANLJHHFI, JsonSerializerOptions PANLLLBJFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E22A90", Offset = "0x7E21090", VA = "0x187E22A90")]
	public NDHANCLDCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AGEHFHALJGM : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EB80", Offset = "0x7E1D180", VA = "0x187E1EB80", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader KMBIKKJCMFN, Type OAJKAHMGCDM, JsonSerializerOptions PANLLLBJFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EF10", Offset = "0x7E1D510", VA = "0x187E1EF10", Slot = "28")]
	public override void Write(Utf8JsonWriter DCGAFNKBAGF, AvatarItemDownloadableConfig KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F040", Offset = "0x7E1D640", VA = "0x187E1F040")]
	public AGEHFHALJGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DNFPNNJGDGG : LPPGONGBJCO<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FFA0", Offset = "0x7E1E5A0", VA = "0x187E1FFA0", Slot = "35")]
	public override void CMDBACILNBC(Utf8JsonReader KMBIKKJCMFN, JsonSerializerOptions PANLLLBJFBB, string ALIOJODOECN, BeardData GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E20140", Offset = "0x7E1E740", VA = "0x187E20140", Slot = "36")]
	public override void DIDJPEEPPFE(Utf8JsonWriter DCGAFNKBAGF, BeardData KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E20200", Offset = "0x7E1E800", VA = "0x187E20200")]
	public DNFPNNJGDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JLFPNFPPOFK : KLHDJOLHMMG<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E217C0", Offset = "0x7E1FDC0", VA = "0x187E217C0")]
	public JLFPNFPPOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OEOMFDIIBLC : KLHDJOLHMMG<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E239E0", Offset = "0x7E21FE0", VA = "0x187E239E0")]
	public OEOMFDIIBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CDGAPNOEBNM : KLHDJOLHMMG<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FC10", Offset = "0x7E1E210", VA = "0x187E1FC10")]
	public CDGAPNOEBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LLOAKHGIFPA : HCIDKGLAJGD<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E21800", Offset = "0x7E1FE00", VA = "0x187E21800")]
	public LLOAKHGIFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FOKJHDKAALK : LPPGONGBJCO<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DHPIABPLJNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DHPIABPLJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FC50", Offset = "0x7E1E250", VA = "0x187E1FC50")]
		internal void LIBEJBEDNGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FF70", Offset = "0x7E1E570", VA = "0x187E1FF70")]
		internal void KELCMDCIJPA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E20240", Offset = "0x7E1E840", VA = "0x187E20240", Slot = "35")]
	public override void CMDBACILNBC(Utf8JsonReader KMBIKKJCMFN, JsonSerializerOptions PANLLLBJFBB, string ALIOJODOECN, AdditionalFeetData GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E203D0", Offset = "0x7E1E9D0", VA = "0x187E203D0", Slot = "36")]
	public override void DIDJPEEPPFE(Utf8JsonWriter DCGAFNKBAGF, AdditionalFeetData KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E204A0", Offset = "0x7E1EAA0", VA = "0x187E204A0")]
	public FOKJHDKAALK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OCGBJHHKPIM : LPPGONGBJCO<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DFCKKLPNPEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DFCKKLPNPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FD80", Offset = "0x7E1E380", VA = "0x187E1FD80")]
		internal void LIBEJBEDNGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FD20", Offset = "0x7E1E320", VA = "0x187E1FD20")]
		internal void KELCMDCIJPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FD50", Offset = "0x7E1E350", VA = "0x187E1FD50")]
		internal void KKOAMKOFLFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FC80", Offset = "0x7E1E280", VA = "0x187E1FC80")]
		internal void GPCEBIPMOJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FE30", Offset = "0x7E1E430", VA = "0x187E1FE30")]
		internal void NCGHKMAJHPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FED0", Offset = "0x7E1E4D0", VA = "0x187E1FED0")]
		internal void PPPLAOFPOIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E1FC50", Offset = "0x7E1E250", VA = "0x187E1FC50")]
		internal void GIAJCOLANDI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E22AD0", Offset = "0x7E210D0", VA = "0x187E22AD0", Slot = "35")]
	public override void CMDBACILNBC(Utf8JsonReader KMBIKKJCMFN, JsonSerializerOptions PANLLLBJFBB, string ALIOJODOECN, HairData GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E22EC0", Offset = "0x7E214C0", VA = "0x187E22EC0", Slot = "36")]
	public override void DIDJPEEPPFE(Utf8JsonWriter DCGAFNKBAGF, HairData KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E231A0", Offset = "0x7E217A0", VA = "0x187E231A0")]
	public OCGBJHHKPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PKNKGLHOJOD : LPPGONGBJCO<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OLIIAPLGPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OLIIAPLGPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E23CD0", Offset = "0x7E222D0", VA = "0x187E23CD0")]
		internal void LIBEJBEDNGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E23B70", Offset = "0x7E22170", VA = "0x187E23B70")]
		internal void KELCMDCIJPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E23C20", Offset = "0x7E22220", VA = "0x187E23C20")]
		internal void KKOAMKOFLFN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E23AC0", Offset = "0x7E220C0", VA = "0x187E23AC0")]
		internal void GPCEBIPMOJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E23D00", Offset = "0x7E22300", VA = "0x187E23D00")]
		internal void NCGHKMAJHPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E23E50", Offset = "0x7E22450", VA = "0x187E23E50")]
		internal void PPPLAOFPOIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E23A20", Offset = "0x7E22020", VA = "0x187E23A20")]
		internal void GIAJCOLANDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E23DB0", Offset = "0x7E223B0", VA = "0x187E23DB0")]
		internal void PHFMCLKAEID(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E23EF0", Offset = "0x7E224F0", VA = "0x187E23EF0", Slot = "35")]
	public override void CMDBACILNBC(Utf8JsonReader KMBIKKJCMFN, JsonSerializerOptions PANLLLBJFBB, string ALIOJODOECN, AdditionalHatData GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E24350", Offset = "0x7E22950", VA = "0x187E24350", Slot = "36")]
	public override void DIDJPEEPPFE(Utf8JsonWriter DCGAFNKBAGF, AdditionalHatData KKGBKLFKCPO, JsonSerializerOptions PANLLLBJFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E246A0", Offset = "0x7E22CA0", VA = "0x187E246A0")]
	public PKNKGLHOJOD()
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
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE792B0", Offset = "0xE778B0", VA = "0x180E792B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xE792E0", Offset = "0xE778E0", VA = "0x180E792E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFC4E40", Offset = "0xFC3440", VA = "0x180FC4E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xFC4E90", Offset = "0xFC3490", VA = "0x180FC4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2135980", Offset = "0x2133F80", VA = "0x182135980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7E24BB0", Offset = "0x7E231B0", VA = "0x187E24BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CE20", Offset = "0x2D9B420", VA = "0x182D9CE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CE30", Offset = "0x2D9B430", VA = "0x182D9CE30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA924E0", Offset = "0xA90AE0", VA = "0x180A924E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA924F0", Offset = "0xA90AF0", VA = "0x180A924F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OBJIGDJGKHB.MAHMKAHBAAB ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
			[CompilerGenerated]
			get
			{
				return default(OBJIGDJGKHB.MAHMKAHBAAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x71C8CF0", Offset = "0x71C72F0", VA = "0x1871C8CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E246E0", Offset = "0x7E22CE0", VA = "0x187E246E0", Slot = "0")]
		public override bool Equals(object HOPHFOOKMCC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E24B90", Offset = "0x7E23190", VA = "0x187E24B90")]
		public static bool JKIBMILPCGE(SerializedAvatarItemData DBDIOGELIIH, SerializedAvatarItemData LHANOGJMGBN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E24A90", Offset = "0x7E23090", VA = "0x187E24A90")]
		public static bool FLMCEAOBGCC(SerializedAvatarItemData DBDIOGELIIH, SerializedAvatarItemData LHANOGJMGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E24770", Offset = "0x7E22D70", VA = "0x187E24770", Slot = "4")]
		public bool Equals(SerializedAvatarItemData HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E24AC0", Offset = "0x7E230C0", VA = "0x187E24AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
