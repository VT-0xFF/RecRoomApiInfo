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
public class EEEKKCPGGCG : DCAPDBPOKHG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA68120", Offset = "0xA66F20", VA = "0x180A68120", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7113AB0", Offset = "0x71128B0", VA = "0x187113AB0", Slot = "36")]
	protected override Vector3 MKDBDOHFNGI(float[] DCFFMJLJGJB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7113B00", Offset = "0x7112900", VA = "0x187113B00", Slot = "37")]
	protected override float[] OBAGPKOJJNI(Vector3 IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7113B80", Offset = "0x7112980", VA = "0x187113B80")]
	public EEEKKCPGGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BINJAMIEHBC : DCAPDBPOKHG<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA9B090", Offset = "0xA99E90", VA = "0x180A9B090", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7111B20", Offset = "0x7110920", VA = "0x187111B20", Slot = "36")]
	protected override Vector2 MKDBDOHFNGI(float[] DCFFMJLJGJB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7111B60", Offset = "0x7110960", VA = "0x187111B60", Slot = "37")]
	protected override float[] OBAGPKOJJNI(Vector2 IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7111BD0", Offset = "0x71109D0", VA = "0x187111BD0")]
	public BINJAMIEHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BBPFPFDHGNE : DCAPDBPOKHG<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA9A320", Offset = "0xA99120", VA = "0x180A9A320", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7111700", Offset = "0x7110500", VA = "0x187111700", Slot = "36")]
	protected override Quaternion MKDBDOHFNGI(float[] DCFFMJLJGJB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7111760", Offset = "0x7110560", VA = "0x187111760", Slot = "37")]
	protected override float[] OBAGPKOJJNI(Quaternion IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71117F0", Offset = "0x71105F0", VA = "0x1871117F0")]
	public BBPFPFDHGNE()
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
		public enum HFAIMFNGAPB
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
		public HFAIMFNGAPB Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0")]
			[CompilerGenerated]
			get
			{
				return default(HFAIMFNGAPB);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7110C70", Offset = "0x710FA70", VA = "0x187110C70", Slot = "0")]
		public override bool Equals(object LHMPMCLNOPG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7110B70", Offset = "0x710F970", VA = "0x187110B70")]
		public static bool BHDCHHANDIG(AvatarItemDownloadableConfig PMKFIDCMLAN, AvatarItemDownloadableConfig BFOIKIBAAFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7110DA0", Offset = "0x710FBA0", VA = "0x187110DA0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7110E70", Offset = "0x710FC70", VA = "0x187110E70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD6BBE0", Offset = "0xD6A9E0", VA = "0x180D6BBE0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, OOGFPHLFINK, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7116B20", Offset = "0x7115920", VA = "0x187116B20")]
		private void DOIJCKKAPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7116B90", Offset = "0x7115990", VA = "0x187116B90", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7116C10", Offset = "0x7115A10", VA = "0x187116C10", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7116B20", Offset = "0x7115920", VA = "0x187116B20", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7116D10", Offset = "0x7115B10", VA = "0x187116D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MFLKLFGIMPN : ILEBALKLPGO<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MDCAGGHEAIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MDCAGGHEAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71152B0", Offset = "0x71140B0", VA = "0x1871152B0")]
		internal void HKAADCIABJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71150A0", Offset = "0x7113EA0", VA = "0x1871150A0")]
		internal void EAMICAOMIHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7115150", Offset = "0x7113F50", VA = "0x187115150")]
		internal void FDPJJDFLALB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7114DE0", Offset = "0x7113BE0", VA = "0x187114DE0")]
		internal void BBCDJGCDOOJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7114FF0", Offset = "0x7113DF0", VA = "0x187114FF0")]
		internal void DODGLACJDCP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7114F40", Offset = "0x7113D40", VA = "0x187114F40")]
		internal void DIDLLGJJMCB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7115200", Offset = "0x7114000", VA = "0x187115200")]
		internal void HCHIAAMLILC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7114E90", Offset = "0x7113C90", VA = "0x187114E90")]
		internal void BEPGKEMAIPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7115360", Offset = "0x7114160", VA = "0x187115360")]
		internal void JNDECMDGNAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7115400", Offset = "0x7114200", VA = "0x187115400")]
		internal void LKKHGPAABID(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NCPDJPGIKPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x71154A0", Offset = "0x71142A0", VA = "0x1871154A0", Slot = "35")]
	public override void EMPDMAIKEOB(Utf8JsonReader GGBMOFKDHMN, JsonSerializerOptions IDEGCFOPFGC, string FINLDKJJAEK, AnchorParamsRestrictions MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x71159C0", Offset = "0x71147C0", VA = "0x1871159C0", Slot = "36")]
	public override void NHOBLPONFPM(Utf8JsonWriter FEBAHPCKNJP, AnchorParamsRestrictions IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7115E60", Offset = "0x7114C60", VA = "0x187115E60")]
	public MFLKLFGIMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33C6B50", Offset = "0x33C5950", VA = "0x1833C6B50")]
	[CompilerGenerated]
	internal static void BDKKEAIAFML<T>(string FINLDKJJAEK, T OAJCPHOOFGC, T JIPHPJFBLGH, NCPDJPGIKPN P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CNOJEFKMBDM : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void FCNCPMCOMPK(Utf8JsonReader MLFMLAODHNL);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JOJMKHPMMNI
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
		public CNOJEFKMBDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FCNCPMCOMPK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FCNCPMCOMPK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FCNCPMCOMPK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FCNCPMCOMPK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FCNCPMCOMPK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FCNCPMCOMPK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FCNCPMCOMPK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FCNCPMCOMPK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FCNCPMCOMPK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FCNCPMCOMPK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FCNCPMCOMPK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JOJMKHPMMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7114C70", Offset = "0x7113A70", VA = "0x187114C70")]
		internal void GHCJEMKIKEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7114BC0", Offset = "0x71139C0", VA = "0x187114BC0")]
		internal void GFJMJIDDLJI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7114940", Offset = "0x7113740", VA = "0x187114940")]
		internal void EDFAGFOMONK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7114D30", Offset = "0x7113B30", VA = "0x187114D30")]
		internal void KGHDPIFOILN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7114B10", Offset = "0x7113910", VA = "0x187114B10")]
		internal void GDIJOEIMHIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7111A40", Offset = "0x7110840", VA = "0x187111A40")]
		internal void OAPFGJMIKHP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7114CB0", Offset = "0x7113AB0", VA = "0x187114CB0")]
		internal void INHNACNOEOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71149F0", Offset = "0x71137F0", VA = "0x1871149F0")]
		internal void FDAGLPJGNJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7114AD0", Offset = "0x71138D0", VA = "0x187114AD0")]
		internal void FJJHNEGLGCH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7114720", Offset = "0x7113520", VA = "0x187114720")]
		internal void BPPBEHPNGPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71147C0", Offset = "0x71135C0", VA = "0x1871147C0")]
		internal void COCPOHEGPGI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FFMKOMLOEDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FFMKOMLOEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7113E60", Offset = "0x7112C60", VA = "0x187113E60")]
		internal void FEDAMBMMHKN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7111D80", Offset = "0x7110B80", VA = "0x187111D80", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7112980", Offset = "0x7111780", VA = "0x187112980", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, SerializedAvatarItemData IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7111C10", Offset = "0x7110A10", VA = "0x187111C10")]
	private AdditionalOutfitTypeData KIBBNABEILK(Utf8JsonReader GGBMOFKDHMN, OutfitType OBDHBADPJNM, JsonSerializerOptions IDEGCFOPFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7112DB0", Offset = "0x7111BB0", VA = "0x187112DB0")]
	public CNOJEFKMBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HBOCOEHFGJG : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7113F40", Offset = "0x7112D40", VA = "0x187113F40", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader GGBMOFKDHMN, Type CPPCGHOOAKJ, JsonSerializerOptions IDEGCFOPFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x71142D0", Offset = "0x71130D0", VA = "0x1871142D0", Slot = "28")]
	public override void Write(Utf8JsonWriter FEBAHPCKNJP, AvatarItemDownloadableConfig IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7114400", Offset = "0x7113200", VA = "0x187114400")]
	public HBOCOEHFGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FBHBAOBFNGL : ILEBALKLPGO<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7113BC0", Offset = "0x71129C0", VA = "0x187113BC0", Slot = "35")]
	public override void EMPDMAIKEOB(Utf8JsonReader GGBMOFKDHMN, JsonSerializerOptions IDEGCFOPFGC, string FINLDKJJAEK, BeardData MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7113D60", Offset = "0x7112B60", VA = "0x187113D60", Slot = "36")]
	public override void NHOBLPONFPM(Utf8JsonWriter FEBAHPCKNJP, BeardData IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7113E20", Offset = "0x7112C20", VA = "0x187113E20")]
	public FBHBAOBFNGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MGKCLODKANF : JHHFCJEGLAG<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7115EA0", Offset = "0x7114CA0", VA = "0x187115EA0")]
	public MGKCLODKANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JFEECGJDJOC : JHHFCJEGLAG<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x71146E0", Offset = "0x71134E0", VA = "0x1871146E0")]
	public JFEECGJDJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HBFDMFCPCJH : JHHFCJEGLAG<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7113F00", Offset = "0x7112D00", VA = "0x187113F00")]
	public HBFDMFCPCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OAPDDONACFP : OJBMIAAMGIC<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x71165F0", Offset = "0x71153F0", VA = "0x1871165F0")]
	public OAPDDONACFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HDEDDKGJPBN : ILEBALKLPGO<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ABMOFMJJJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ABMOFMJJJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7110B40", Offset = "0x710F940", VA = "0x187110B40")]
		internal void HKAADCIABJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7110B10", Offset = "0x710F910", VA = "0x187110B10")]
		internal void EAMICAOMIHO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7114440", Offset = "0x7113240", VA = "0x187114440", Slot = "35")]
	public override void EMPDMAIKEOB(Utf8JsonReader GGBMOFKDHMN, JsonSerializerOptions IDEGCFOPFGC, string FINLDKJJAEK, AdditionalFeetData MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x71145D0", Offset = "0x71133D0", VA = "0x1871145D0", Slot = "36")]
	public override void NHOBLPONFPM(Utf8JsonWriter FEBAHPCKNJP, AdditionalFeetData IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x71146A0", Offset = "0x71134A0", VA = "0x1871146A0")]
	public HDEDDKGJPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MLLBKNEDPHA : ILEBALKLPGO<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BEJIJPKOLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BEJIJPKOLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7111A70", Offset = "0x7110870", VA = "0x187111A70")]
		internal void HKAADCIABJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7111A10", Offset = "0x7110810", VA = "0x187111A10")]
		internal void EAMICAOMIHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7111A40", Offset = "0x7110840", VA = "0x187111A40")]
		internal void FDPJJDFLALB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7111830", Offset = "0x7110630", VA = "0x187111830")]
		internal void BBCDJGCDOOJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7111970", Offset = "0x7110770", VA = "0x187111970")]
		internal void DODGLACJDCP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x71118D0", Offset = "0x71106D0", VA = "0x1871118D0")]
		internal void DIDLLGJJMCB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7110B40", Offset = "0x710F940", VA = "0x187110B40")]
		internal void HCHIAAMLILC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7115EE0", Offset = "0x7114CE0", VA = "0x187115EE0", Slot = "35")]
	public override void EMPDMAIKEOB(Utf8JsonReader GGBMOFKDHMN, JsonSerializerOptions IDEGCFOPFGC, string FINLDKJJAEK, HairData MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71162D0", Offset = "0x71150D0", VA = "0x1871162D0", Slot = "36")]
	public override void NHOBLPONFPM(Utf8JsonWriter FEBAHPCKNJP, HairData IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x71165B0", Offset = "0x71153B0", VA = "0x1871165B0")]
	public MLLBKNEDPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DBBBHKHICEF : ILEBALKLPGO<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EALLJMBKAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EALLJMBKAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7113A80", Offset = "0x7112880", VA = "0x187113A80")]
		internal void HKAADCIABJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7113880", Offset = "0x7112680", VA = "0x187113880")]
		internal void EAMICAOMIHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7113930", Offset = "0x7112730", VA = "0x187113930")]
		internal void FDPJJDFLALB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x71135E0", Offset = "0x71123E0", VA = "0x1871135E0")]
		internal void BBCDJGCDOOJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x71137D0", Offset = "0x71125D0", VA = "0x1871137D0")]
		internal void DODGLACJDCP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7113730", Offset = "0x7112530", VA = "0x187113730")]
		internal void DIDLLGJJMCB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x71139E0", Offset = "0x71127E0", VA = "0x1871139E0")]
		internal void HCHIAAMLILC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7113690", Offset = "0x7112490", VA = "0x187113690")]
		internal void BEPGKEMAIPH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7112DF0", Offset = "0x7111BF0", VA = "0x187112DF0", Slot = "35")]
	public override void EMPDMAIKEOB(Utf8JsonReader GGBMOFKDHMN, JsonSerializerOptions IDEGCFOPFGC, string FINLDKJJAEK, AdditionalHatData MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7113250", Offset = "0x7112050", VA = "0x187113250", Slot = "36")]
	public override void NHOBLPONFPM(Utf8JsonWriter FEBAHPCKNJP, AdditionalHatData IPHILEOFJLB, JsonSerializerOptions IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71135A0", Offset = "0x71123A0", VA = "0x1871135A0")]
	public DBBBHKHICEF()
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
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8FAE10", Offset = "0x8F9C10", VA = "0x1808FAE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCA1EC0", Offset = "0xCA0CC0", VA = "0x180CA1EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCA2010", Offset = "0xCA0E10", VA = "0x180CA2010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCA1ED0", Offset = "0xCA0CD0", VA = "0x180CA1ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD973C0", Offset = "0xD961C0", VA = "0x180D973C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD973D0", Offset = "0xD961D0", VA = "0x180D973D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1CFA880", Offset = "0x1CF9680", VA = "0x181CFA880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7116AF0", Offset = "0x71158F0", VA = "0x187116AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x28DDF80", Offset = "0x28DCD80", VA = "0x1828DDF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x28DDF70", Offset = "0x28DCD70", VA = "0x1828DDF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB725C0", Offset = "0xB713C0", VA = "0x180B725C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB72610", Offset = "0xB71410", VA = "0x180B72610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HFBLFLDOFLG.KLFEKKPPLNK ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAA79C0", Offset = "0xAA67C0", VA = "0x180AA79C0")]
			[CompilerGenerated]
			get
			{
				return default(HFBLFLDOFLG.KLFEKKPPLNK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAA79A0", Offset = "0xAA67A0", VA = "0x180AA79A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8F4280", Offset = "0x8F3080", VA = "0x1808F4280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7116650", Offset = "0x7115450", VA = "0x187116650", Slot = "0")]
		public override bool Equals(object LHMPMCLNOPG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7116630", Offset = "0x7115430", VA = "0x187116630")]
		public static bool BHDCHHANDIG(SerializedAvatarItemData PMKFIDCMLAN, SerializedAvatarItemData BFOIKIBAAFG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7116AC0", Offset = "0x71158C0", VA = "0x187116AC0")]
		public static bool HGMDHININLF(SerializedAvatarItemData PMKFIDCMLAN, SerializedAvatarItemData BFOIKIBAAFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71166D0", Offset = "0x71154D0", VA = "0x1871166D0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71169F0", Offset = "0x71157F0", VA = "0x1871169F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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
