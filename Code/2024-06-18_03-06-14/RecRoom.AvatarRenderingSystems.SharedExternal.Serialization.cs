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
public class LFDADHKNFLL : KCAFIDIBNAP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C5180", Offset = "0x8C3B80", VA = "0x1808C5180", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67791D0", Offset = "0x6777BD0", VA = "0x1867791D0", Slot = "36")]
	protected override Vector3 LBMAAAIEHNB(float[] AHBFNFFEMPG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6779220", Offset = "0x6777C20", VA = "0x186779220", Slot = "37")]
	protected override float[] MEAGOHACMGM(Vector3 DBOBEHLEAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67792A0", Offset = "0x6777CA0", VA = "0x1867792A0")]
	public LFDADHKNFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ENMCGMCABFL : KCAFIDIBNAP<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4A0", Offset = "0x8BDEA0", VA = "0x1808BF4A0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6777450", Offset = "0x6775E50", VA = "0x186777450", Slot = "36")]
	protected override Vector2 LBMAAAIEHNB(float[] AHBFNFFEMPG)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6777490", Offset = "0x6775E90", VA = "0x186777490", Slot = "37")]
	protected override float[] MEAGOHACMGM(Vector2 DBOBEHLEAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6777500", Offset = "0x6775F00", VA = "0x186777500")]
	public ENMCGMCABFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FLNGGLMAOOK : KCAFIDIBNAP<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B6E80", Offset = "0x8B5880", VA = "0x1808B6E80", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6777540", Offset = "0x6775F40", VA = "0x186777540", Slot = "36")]
	protected override Quaternion LBMAAAIEHNB(float[] AHBFNFFEMPG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67775A0", Offset = "0x6775FA0", VA = "0x1867775A0", Slot = "37")]
	protected override float[] MEAGOHACMGM(Quaternion DBOBEHLEAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6777630", Offset = "0x6776030", VA = "0x186777630")]
	public FLNGGLMAOOK()
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
		public enum AAAGGCAGLAJ
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
		public AAAGGCAGLAJ Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0")]
			[CompilerGenerated]
			get
			{
				return default(AAAGGCAGLAJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x856690", Offset = "0x855090", VA = "0x180856690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x915D60", Offset = "0x914760", VA = "0x180915D60")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MMOIJICNJCM : JFAIJMADLEC<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NDPDBFMCMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public NDPDBFMCMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x677A290", Offset = "0x6778C90", VA = "0x18677A290")]
		internal void NLNHMPGPEOD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x677A080", Offset = "0x6778A80", VA = "0x18677A080")]
		internal void MKOAKNBIJFI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6779F20", Offset = "0x6778920", VA = "0x186779F20")]
		internal void HGOFFMNHFEL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x677A1E0", Offset = "0x6778BE0", VA = "0x18677A1E0")]
		internal void MNBBDICIOHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x677A130", Offset = "0x6778B30", VA = "0x18677A130")]
		internal void MLPLBNADDOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6779DD0", Offset = "0x67787D0", VA = "0x186779DD0")]
		internal void CPMEKNFDHDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6779D20", Offset = "0x6778720", VA = "0x186779D20")]
		internal void ACCHEHKLFMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6779FD0", Offset = "0x67789D0", VA = "0x186779FD0")]
		internal void LAEBBIHIHBN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6779E80", Offset = "0x6778880", VA = "0x186779E80")]
		internal void FKHCJDLNOMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x677A340", Offset = "0x6778D40", VA = "0x18677A340")]
		internal void OPKOPAOBCFG(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LFAMGIJGBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6779780", Offset = "0x6778180", VA = "0x186779780", Slot = "35")]
	public override void NPAJABCOLMK(Utf8JsonReader DGAMLJBEAIK, JsonSerializerOptions FKJNBGBCACC, string NBNDOLIHNCP, AnchorParamsRestrictions IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67792E0", Offset = "0x6777CE0", VA = "0x1867792E0", Slot = "36")]
	public override void BGPANCLAELF(Utf8JsonWriter AACOMNCLNFJ, AnchorParamsRestrictions DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6779CA0", Offset = "0x67786A0", VA = "0x186779CA0")]
	public MMOIJICNJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FDA0", Offset = "0x2C0E7A0", VA = "0x182C0FDA0")]
	[CompilerGenerated]
	internal static void LADDNOPMHMJ<T>(string NBNDOLIHNCP, T EHIEOLDDJEB, T PDHAEMLJEFL, LFAMGIJGBCO P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JBMHCNIJGIC : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void ILPCODGDNNG(Utf8JsonReader OFMNIPCGFAG);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OPFIPKCJCFM
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
		public JBMHCNIJGIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public ILPCODGDNNG <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ILPCODGDNNG <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public ILPCODGDNNG <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public ILPCODGDNNG <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ILPCODGDNNG <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ILPCODGDNNG <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ILPCODGDNNG <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ILPCODGDNNG <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ILPCODGDNNG <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ILPCODGDNNG <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ILPCODGDNNG <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ILPCODGDNNG <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ILPCODGDNNG <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ILPCODGDNNG <>9__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ILPCODGDNNG <>9__14;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public OPFIPKCJCFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x677AFA0", Offset = "0x67799A0", VA = "0x18677AFA0")]
		internal void HICIIAIIEAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x677B3C0", Offset = "0x6779DC0", VA = "0x18677B3C0")]
		internal void OIOMHGHNAGM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x677B310", Offset = "0x6779D10", VA = "0x18677B310")]
		internal void OIFPOHHAIOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x677AE20", Offset = "0x6779820", VA = "0x18677AE20")]
		internal void BAONFMBHCCB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x677AFE0", Offset = "0x67799E0", VA = "0x18677AFE0")]
		internal void JMHKBPECPCM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x677B090", Offset = "0x6779A90", VA = "0x18677B090")]
		internal void KFENOEFHOHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x677B260", Offset = "0x6779C60", VA = "0x18677B260")]
		internal void NGHEOEBFGGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x677B230", Offset = "0x6779C30", VA = "0x18677B230")]
		internal void MKJCFFHGJDH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x677B200", Offset = "0x6779C00", VA = "0x18677B200")]
		internal void MFFAKHMBEAB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x677AF70", Offset = "0x6779970", VA = "0x18677AF70")]
		internal void DJEOBEGIDNJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x677B140", Offset = "0x6779B40", VA = "0x18677B140")]
		internal void KLBOPCGAIDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x677AD40", Offset = "0x6779740", VA = "0x18677AD40")]
		internal void AMOMPJKBGGK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x677B1C0", Offset = "0x6779BC0", VA = "0x18677B1C0")]
		internal void LEIKLICLOOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x677AED0", Offset = "0x67798D0", VA = "0x18677AED0")]
		internal void CAGNIBIBPKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x677AC10", Offset = "0x6779610", VA = "0x18677AC10")]
		internal void AGDBFBKBNCI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6777A70", Offset = "0x6776470", VA = "0x186777A70", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6778570", Offset = "0x6776F70", VA = "0x186778570", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, SerializedAvatarItemData DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6777950", Offset = "0x6776350", VA = "0x186777950")]
	private AdditionalOutfitTypeData MPOCONKJPPO(Utf8JsonReader DGAMLJBEAIK, OutfitType ADDOHDGDFOD, JsonSerializerOptions FKJNBGBCACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6778A40", Offset = "0x6777440", VA = "0x186778A40")]
	public JBMHCNIJGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DIJEFDPOHLJ : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6776FB0", Offset = "0x67759B0", VA = "0x186776FB0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DGAMLJBEAIK, Type BOBBLNKFPEA, JsonSerializerOptions FKJNBGBCACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6777320", Offset = "0x6775D20", VA = "0x186777320", Slot = "28")]
	public override void Write(Utf8JsonWriter AACOMNCLNFJ, AvatarItemDownloadableConfig DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6777410", Offset = "0x6775E10", VA = "0x186777410")]
	public DIJEFDPOHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GCBKKBAHPKP : JFAIJMADLEC<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6777770", Offset = "0x6776170", VA = "0x186777770", Slot = "35")]
	public override void NPAJABCOLMK(Utf8JsonReader DGAMLJBEAIK, JsonSerializerOptions FKJNBGBCACC, string NBNDOLIHNCP, BeardData IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67776B0", Offset = "0x67760B0", VA = "0x1867776B0", Slot = "36")]
	public override void BGPANCLAELF(Utf8JsonWriter AACOMNCLNFJ, BeardData DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6777910", Offset = "0x6776310", VA = "0x186777910")]
	public GCBKKBAHPKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JMDPFONDFGB : NNAEDBDNBCJ<FLPIHNCAELJ>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6779190", Offset = "0x6777B90", VA = "0x186779190")]
	public JMDPFONDFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FMKNBLEMPPB : NNAEDBDNBCJ<JJBJAEPFFGE>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6777670", Offset = "0x6776070", VA = "0x186777670")]
	public FMKNBLEMPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OGDFBHBGBEE : NNAEDBDNBCJ<LHEKCEJGKIK>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x677ABD0", Offset = "0x67795D0", VA = "0x18677ABD0")]
	public OGDFBHBGBEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NBFMKIFFIPK : GDOFOCGEDDD<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6779CE0", Offset = "0x67786E0", VA = "0x186779CE0")]
	public NBFMKIFFIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JJDAPBGBGAF : JFAIJMADLEC<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DIAEDFKPGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DIAEDFKPGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6776F00", Offset = "0x6775900", VA = "0x186776F00")]
		internal void NLNHMPGPEOD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6776D90", Offset = "0x6775790", VA = "0x186776D90")]
		internal void MKOAKNBIJFI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6776D60", Offset = "0x6775760", VA = "0x186776D60")]
		internal void HGOFFMNHFEL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6776E60", Offset = "0x6775860", VA = "0x186776E60")]
		internal void MNBBDICIOHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6776DC0", Offset = "0x67757C0", VA = "0x186776DC0")]
		internal void MLPLBNADDOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6776CC0", Offset = "0x67756C0", VA = "0x186776CC0")]
		internal void CPMEKNFDHDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6776C90", Offset = "0x6775690", VA = "0x186776C90")]
		internal void ACCHEHKLFMK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6778D60", Offset = "0x6777760", VA = "0x186778D60", Slot = "35")]
	public override void NPAJABCOLMK(Utf8JsonReader DGAMLJBEAIK, JsonSerializerOptions FKJNBGBCACC, string NBNDOLIHNCP, HairData IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6778A80", Offset = "0x6777480", VA = "0x186778A80", Slot = "36")]
	public override void BGPANCLAELF(Utf8JsonWriter AACOMNCLNFJ, HairData DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6779150", Offset = "0x6777B50", VA = "0x186779150")]
	public JJDAPBGBGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OBNLPMDAECK : JFAIJMADLEC<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BBNJPADPNAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public BBNJPADPNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6776C60", Offset = "0x6775660", VA = "0x186776C60")]
		internal void NLNHMPGPEOD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6776A50", Offset = "0x6775450", VA = "0x186776A50")]
		internal void MKOAKNBIJFI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6776900", Offset = "0x6775300", VA = "0x186776900")]
		internal void HGOFFMNHFEL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6776BB0", Offset = "0x67755B0", VA = "0x186776BB0")]
		internal void MNBBDICIOHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6776B00", Offset = "0x6775500", VA = "0x186776B00")]
		internal void MLPLBNADDOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6776860", Offset = "0x6775260", VA = "0x186776860")]
		internal void CPMEKNFDHDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67767C0", Offset = "0x67751C0", VA = "0x1867767C0")]
		internal void ACCHEHKLFMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67769B0", Offset = "0x67753B0", VA = "0x1867769B0")]
		internal void LAEBBIHIHBN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x677A730", Offset = "0x6779130", VA = "0x18677A730", Slot = "35")]
	public override void NPAJABCOLMK(Utf8JsonReader DGAMLJBEAIK, JsonSerializerOptions FKJNBGBCACC, string NBNDOLIHNCP, AdditionalHatData IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x677A3E0", Offset = "0x6778DE0", VA = "0x18677A3E0", Slot = "36")]
	public override void BGPANCLAELF(Utf8JsonWriter AACOMNCLNFJ, AdditionalHatData DBOBEHLEAAE, JsonSerializerOptions FKJNBGBCACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x677AB90", Offset = "0x6779590", VA = "0x18677AB90")]
	public OBNLPMDAECK()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x857570", Offset = "0x855F70", VA = "0x180857570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA659B0", Offset = "0xA643B0", VA = "0x180A659B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB36070", Offset = "0xB34A70", VA = "0x180B36070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xDC6C50", Offset = "0xDC5650", VA = "0x180DC6C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDC4D10", Offset = "0xDC3710", VA = "0x180DC4D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EA8330", Offset = "0x1EA6D30", VA = "0x181EA8330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1EA8340", Offset = "0x1EA6D40", VA = "0x181EA8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x13D2770", Offset = "0x13D1170", VA = "0x1813D2770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x677B3F0", Offset = "0x6779DF0", VA = "0x18677B3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x22F3750", Offset = "0x22F2150", VA = "0x1822F3750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x22F3AD0", Offset = "0x22F24D0", VA = "0x1822F3AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B19B70", Offset = "0x1B18570", VA = "0x181B19B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B19BA0", Offset = "0x1B185A0", VA = "0x181B19BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDBFCF0", Offset = "0xDBE6F0", VA = "0x180DBFCF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDC3970", Offset = "0xDC2370", VA = "0x180DC3970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DDCBHILCHIF ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x915300", Offset = "0x913D00", VA = "0x180915300")]
			[CompilerGenerated]
			get
			{
				return default(DDCBHILCHIF);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAF4930", Offset = "0xAF3330", VA = "0x180AF4930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BFJEAAGLFCO.DNAKBNCOFJG ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAF4E00", Offset = "0xAF3800", VA = "0x180AF4E00")]
			[CompilerGenerated]
			get
			{
				return default(BFJEAAGLFCO.DNAKBNCOFJG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x144C9D0", Offset = "0x144B3D0", VA = "0x18144C9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x84FCE0", Offset = "0x84E6E0", VA = "0x18084FCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84FE60", Offset = "0x84E860", VA = "0x18084FE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC2A060", Offset = "0xC28A60", VA = "0x180C2A060")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x13432E0", Offset = "0x1341CE0", VA = "0x1813432E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1042990", Offset = "0x1041390", VA = "0x181042990")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x41881E0", Offset = "0x4186BE0", VA = "0x1841881E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
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
