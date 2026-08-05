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
public class LAGAKPECPLM : HJKPDOCLIAB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC51020", Offset = "0xC4FA20", VA = "0x180C51020", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5010", Offset = "0x7BC3A10", VA = "0x187BC5010", Slot = "36")]
	protected override Vector3 MCDIGFGLPFI(float[] OKEIIBNBBOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F90", Offset = "0x7BC3990", VA = "0x187BC4F90", Slot = "37")]
	protected override float[] GHLGFMMOBOL(Vector3 PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5060", Offset = "0x7BC3A60", VA = "0x187BC5060")]
	public LAGAKPECPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FKHKDNIGNBA : HJKPDOCLIAB<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC63550", Offset = "0xC61F50", VA = "0x180C63550", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3AA0", Offset = "0x7BC24A0", VA = "0x187BC3AA0", Slot = "36")]
	protected override Vector2 MCDIGFGLPFI(float[] OKEIIBNBBOL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3A30", Offset = "0x7BC2430", VA = "0x187BC3A30", Slot = "37")]
	protected override float[] GHLGFMMOBOL(Vector2 PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3AE0", Offset = "0x7BC24E0", VA = "0x187BC3AE0")]
	public FKHKDNIGNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IOIAFLEKMMB : HJKPDOCLIAB<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC8220", Offset = "0xAC6C20", VA = "0x180AC8220", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC44D0", Offset = "0x7BC2ED0", VA = "0x187BC44D0", Slot = "36")]
	protected override Quaternion MCDIGFGLPFI(float[] OKEIIBNBBOL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4440", Offset = "0x7BC2E40", VA = "0x187BC4440", Slot = "37")]
	protected override float[] GHLGFMMOBOL(Quaternion PCDAHJCDHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4530", Offset = "0x7BC2F30", VA = "0x187BC4530")]
	public IOIAFLEKMMB()
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
		public enum IDOOOLOGDOC
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
		public IDOOOLOGDOC Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
			[CompilerGenerated]
			get
			{
				return default(IDOOOLOGDOC);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1650", Offset = "0x7BC0050", VA = "0x187BC1650", Slot = "0")]
		public override bool Equals(object NDNHELJMDCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BC18C0", Offset = "0x7BC02C0", VA = "0x187BC18C0")]
		public static bool IDFALDDOLDN(AvatarItemDownloadableConfig OCPABDEGAMF, AvatarItemDownloadableConfig MAMEIEKFKPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1780", Offset = "0x7BC0180", VA = "0x187BC1780", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1850", Offset = "0x7BC0250", VA = "0x187BC1850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF7BBA0", Offset = "0xF7A5A0", VA = "0x180F7BBA0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, OHCFANIPIDE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7BC7110", Offset = "0x7BC5B10", VA = "0x187BC7110")]
		private void PLBIPIAEJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6F90", Offset = "0x7BC5990", VA = "0x187BC6F90", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7010", Offset = "0x7BC5A10", VA = "0x187BC7010", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7100", Offset = "0x7BC5B00", VA = "0x187BC7100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6F70", Offset = "0x7BC5970", VA = "0x187BC6F70", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection NDNHELJMDCG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
		public Guid CLBPGDDMFNE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7110", Offset = "0x7BC5B10", VA = "0x187BC7110", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7180", Offset = "0x7BC5B80", VA = "0x187BC7180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CGEJNNPLMPG : NILCKJFPBBA<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AHJONFPMGNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AHJONFPMGNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0F90", Offset = "0x7BBF990", VA = "0x187BC0F90")]
		internal void CCNLEJMOBFD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1250", Offset = "0x7BBFC50", VA = "0x187BC1250")]
		internal void JAGAEBCLHFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BC10F0", Offset = "0x7BBFAF0", VA = "0x187BC10F0")]
		internal void GKKCJJMCIHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BC15A0", Offset = "0x7BBFFA0", VA = "0x187BC15A0")]
		internal void NACGLLELHCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1450", Offset = "0x7BBFE50", VA = "0x187BC1450")]
		internal void LCNKCJJNEML(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC11A0", Offset = "0x7BBFBA0", VA = "0x187BC11A0")]
		internal void IKEKBMLMNCL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1040", Offset = "0x7BBFA40", VA = "0x187BC1040")]
		internal void CLODEANIKOK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1300", Offset = "0x7BBFD00", VA = "0x187BC1300")]
		internal void KBMBFJEOIFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1500", Offset = "0x7BBFF00", VA = "0x187BC1500")]
		internal void MKELELLAIAB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC13B0", Offset = "0x7BBFDB0", VA = "0x187BC13B0")]
		internal void KLCMCBFFABC(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OKNGBMCOKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2670", Offset = "0x7BC1070", VA = "0x187BC2670", Slot = "35")]
	public override void OCFJDMKDCAO(Utf8JsonReader LJMOCEGEAFH, JsonSerializerOptions LCCNAOLCHEE, string NJOLLKLCOEF, AnchorParamsRestrictions HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BC21E0", Offset = "0x7BC0BE0", VA = "0x187BC21E0", Slot = "36")]
	public override void NNJCMOBICLJ(Utf8JsonWriter EDJIMCINKFD, AnchorParamsRestrictions PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2B90", Offset = "0x7BC1590", VA = "0x187BC2B90")]
	public CGEJNNPLMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3850170", Offset = "0x384EB70", VA = "0x183850170")]
	[CompilerGenerated]
	internal static void EGBDLJFJOFK<T>(string NJOLLKLCOEF, T KPILPFEAJHA, T FKEKJBIOLAB, OKNGBMCOKEB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OAEHDIBEFHB : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void HCHGDCJIHEO(Utf8JsonReader FGEFHKAEIPE);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EIALALFNCKD
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
		public OAEHDIBEFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public HCHGDCJIHEO <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HCHGDCJIHEO <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HCHGDCJIHEO <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HCHGDCJIHEO <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HCHGDCJIHEO <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HCHGDCJIHEO <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HCHGDCJIHEO <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HCHGDCJIHEO <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HCHGDCJIHEO <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HCHGDCJIHEO <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HCHGDCJIHEO <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EIALALFNCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3340", Offset = "0x7BC1D40", VA = "0x187BC3340")]
		internal void DAMNKAHJHCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BC34E0", Offset = "0x7BC1EE0", VA = "0x187BC34E0")]
		internal void HBPEPMOCGEC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3640", Offset = "0x7BC2040", VA = "0x187BC3640")]
		internal void MFNFJHFPFJN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3590", Offset = "0x7BC1F90", VA = "0x187BC3590")]
		internal void LCLJEGOEIHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC33B0", Offset = "0x7BC1DB0", VA = "0x187BC33B0")]
		internal void GCALMHOOMEC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3380", Offset = "0x7BC1D80", VA = "0x187BC3380")]
		internal void FEDEDHIHKBN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3460", Offset = "0x7BC1E60", VA = "0x187BC3460")]
		internal void GJGMOJJCHOJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC36F0", Offset = "0x7BC20F0", VA = "0x187BC36F0")]
		internal void MLLONCMCHOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC37D0", Offset = "0x7BC21D0", VA = "0x187BC37D0")]
		internal void MNANFOGEMHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3990", Offset = "0x7BC2390", VA = "0x187BC3990")]
		internal void POKDJPKPEHD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3810", Offset = "0x7BC2210", VA = "0x187BC3810")]
		internal void OJKJBOLANDC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GFJEHEGLCKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GFJEHEGLCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3B20", Offset = "0x7BC2520", VA = "0x187BC3B20")]
		internal void DLDAEKBPOIL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5A40", Offset = "0x7BC4440", VA = "0x187BC5A40", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6620", Offset = "0x7BC5020", VA = "0x187BC6620", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, SerializedAvatarItemData PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BC58D0", Offset = "0x7BC42D0", VA = "0x187BC58D0")]
	private AdditionalOutfitTypeData JFAADBLLHCB(Utf8JsonReader LJMOCEGEAFH, OutfitType HHCAOFMCNLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6A60", Offset = "0x7BC5460", VA = "0x187BC6A60")]
	public OAEHDIBEFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LNGOAENCAGC : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BC50E0", Offset = "0x7BC3AE0", VA = "0x187BC50E0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader LJMOCEGEAFH, Type NOJGMMNNMLG, JsonSerializerOptions LCCNAOLCHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5470", Offset = "0x7BC3E70", VA = "0x187BC5470", Slot = "28")]
	public override void Write(Utf8JsonWriter EDJIMCINKFD, AvatarItemDownloadableConfig PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC55A0", Offset = "0x7BC3FA0", VA = "0x187BC55A0")]
	public LNGOAENCAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DPMCBAICEFN : NILCKJFPBBA<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3160", Offset = "0x7BC1B60", VA = "0x187BC3160", Slot = "35")]
	public override void OCFJDMKDCAO(Utf8JsonReader LJMOCEGEAFH, JsonSerializerOptions LCCNAOLCHEE, string NJOLLKLCOEF, BeardData HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC30A0", Offset = "0x7BC1AA0", VA = "0x187BC30A0", Slot = "36")]
	public override void NNJCMOBICLJ(Utf8JsonWriter EDJIMCINKFD, BeardData PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3300", Offset = "0x7BC1D00", VA = "0x187BC3300")]
	public DPMCBAICEFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LCBJFDDABCL : HBGJMDKEBHK<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC50A0", Offset = "0x7BC3AA0", VA = "0x187BC50A0")]
	public LCBJFDDABCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JGNPBFFOLKH : HBGJMDKEBHK<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4570", Offset = "0x7BC2F70", VA = "0x187BC4570")]
	public JGNPBFFOLKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KKLKDMNABPB : HBGJMDKEBHK<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F50", Offset = "0x7BC3950", VA = "0x187BC4F50")]
	public KKLKDMNABPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GMGAJLABMEH : BJDGFIEJLAG<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BC43A0", Offset = "0x7BC2DA0", VA = "0x187BC43A0")]
	public GMGAJLABMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KEPKOCMJIBD : NILCKJFPBBA<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IMHJLPGDANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IMHJLPGDANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BC43E0", Offset = "0x7BC2DE0", VA = "0x187BC43E0")]
		internal void CCNLEJMOBFD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4410", Offset = "0x7BC2E10", VA = "0x187BC4410")]
		internal void JAGAEBCLHFL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4D80", Offset = "0x7BC3780", VA = "0x187BC4D80", Slot = "35")]
	public override void OCFJDMKDCAO(Utf8JsonReader LJMOCEGEAFH, JsonSerializerOptions LCCNAOLCHEE, string NJOLLKLCOEF, AdditionalFeetData HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4CB0", Offset = "0x7BC36B0", VA = "0x187BC4CB0", Slot = "36")]
	public override void NNJCMOBICLJ(Utf8JsonWriter EDJIMCINKFD, AdditionalFeetData PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F10", Offset = "0x7BC3910", VA = "0x187BC4F10")]
	public KEPKOCMJIBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KCDDLHOGNFM : NILCKJFPBBA<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class NJMENBDMBLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NJMENBDMBLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC55E0", Offset = "0x7BC3FE0", VA = "0x187BC55E0")]
		internal void CCNLEJMOBFD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5760", Offset = "0x7BC4160", VA = "0x187BC5760")]
		internal void JAGAEBCLHFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5690", Offset = "0x7BC4090", VA = "0x187BC5690")]
		internal void GKKCJJMCIHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5830", Offset = "0x7BC4230", VA = "0x187BC5830")]
		internal void NACGLLELHCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5790", Offset = "0x7BC4190", VA = "0x187BC5790")]
		internal void LCNKCJJNEML(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BC56C0", Offset = "0x7BC40C0", VA = "0x187BC56C0")]
		internal void IKEKBMLMNCL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BC43E0", Offset = "0x7BC2DE0", VA = "0x187BC43E0")]
		internal void CLODEANIKOK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4880", Offset = "0x7BC3280", VA = "0x187BC4880", Slot = "35")]
	public override void OCFJDMKDCAO(Utf8JsonReader LJMOCEGEAFH, JsonSerializerOptions LCCNAOLCHEE, string NJOLLKLCOEF, HairData HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BC45B0", Offset = "0x7BC2FB0", VA = "0x187BC45B0", Slot = "36")]
	public override void NNJCMOBICLJ(Utf8JsonWriter EDJIMCINKFD, HairData PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4C70", Offset = "0x7BC3670", VA = "0x187BC4C70")]
	public KCDDLHOGNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GGGOKGPBOHF : NILCKJFPBBA<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CKOINOEICOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CKOINOEICOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2BD0", Offset = "0x7BC15D0", VA = "0x187BC2BD0")]
		internal void CCNLEJMOBFD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2DF0", Offset = "0x7BC17F0", VA = "0x187BC2DF0")]
		internal void JAGAEBCLHFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2CA0", Offset = "0x7BC16A0", VA = "0x187BC2CA0")]
		internal void GKKCJJMCIHN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2FF0", Offset = "0x7BC19F0", VA = "0x187BC2FF0")]
		internal void NACGLLELHCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2F40", Offset = "0x7BC1940", VA = "0x187BC2F40")]
		internal void LCNKCJJNEML(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2D50", Offset = "0x7BC1750", VA = "0x187BC2D50")]
		internal void IKEKBMLMNCL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2C00", Offset = "0x7BC1600", VA = "0x187BC2C00")]
		internal void CLODEANIKOK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2EA0", Offset = "0x7BC18A0", VA = "0x187BC2EA0")]
		internal void KBMBFJEOIFA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3F00", Offset = "0x7BC2900", VA = "0x187BC3F00", Slot = "35")]
	public override void OCFJDMKDCAO(Utf8JsonReader LJMOCEGEAFH, JsonSerializerOptions LCCNAOLCHEE, string NJOLLKLCOEF, AdditionalHatData HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3BC0", Offset = "0x7BC25C0", VA = "0x187BC3BC0", Slot = "36")]
	public override void NNJCMOBICLJ(Utf8JsonWriter EDJIMCINKFD, AdditionalHatData PCDAHJCDHHF, JsonSerializerOptions LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4360", Offset = "0x7BC2D60", VA = "0x187BC4360")]
	public GGGOKGPBOHF()
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
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7D0", Offset = "0xA6D1D0", VA = "0x180A6E7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE384B0", Offset = "0xE36EB0", VA = "0x180E384B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xE384C0", Offset = "0xE36EC0", VA = "0x180E384C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF87180", Offset = "0xF85B80", VA = "0x180F87180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF872C0", Offset = "0xF85CC0", VA = "0x180F872C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x12E3A10", Offset = "0x12E2410", VA = "0x1812E3A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x12E3AF0", Offset = "0x12E24F0", VA = "0x1812E3AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2CF3200", Offset = "0x2CF1C00", VA = "0x182CF3200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2FB0", Offset = "0x2CF19B0", VA = "0x182CF2FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA58C20", Offset = "0xA57620", VA = "0x180A58C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA58C30", Offset = "0xA57630", VA = "0x180A58C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public PNNNJKDMBBI.KEKJLMIKOAG ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
			[CompilerGenerated]
			get
			{
				return default(PNNNJKDMBBI.KEKJLMIKOAG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6F81DD0", Offset = "0x6F807D0", VA = "0x186F81DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6AA0", Offset = "0x7BC54A0", VA = "0x187BC6AA0", Slot = "0")]
		public override bool Equals(object NDNHELJMDCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6F20", Offset = "0x7BC5920", VA = "0x187BC6F20")]
		public static bool IDFALDDOLDN(SerializedAvatarItemData OCPABDEGAMF, SerializedAvatarItemData MAMEIEKFKPM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6F40", Offset = "0x7BC5940", VA = "0x187BC6F40")]
		public static bool JAIBCELPAPH(SerializedAvatarItemData OCPABDEGAMF, SerializedAvatarItemData MAMEIEKFKPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6B30", Offset = "0x7BC5530", VA = "0x187BC6B30", Slot = "4")]
		public bool Equals(SerializedAvatarItemData NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6E50", Offset = "0x7BC5850", VA = "0x187BC6E50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
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
