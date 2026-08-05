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
public class LJBACODKBLP : GOFILILCCIB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCD28D0", Offset = "0xCD14D0", VA = "0x180CD28D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D2F0", Offset = "0x7F6BEF0", VA = "0x187F6D2F0", Slot = "36")]
	protected override Vector3 IHEDANNNKDB(float[] OKFGGFMLPHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D270", Offset = "0x7F6BE70", VA = "0x187F6D270", Slot = "37")]
	protected override float[] CLDFJMLAOLG(Vector3 BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D340", Offset = "0x7F6BF40", VA = "0x187F6D340")]
	public LJBACODKBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JKJFFJCAELM : GOFILILCCIB<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCE4D80", Offset = "0xCE3980", VA = "0x180CE4D80", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CEC0", Offset = "0x7F6BAC0", VA = "0x187F6CEC0", Slot = "36")]
	protected override Vector2 IHEDANNNKDB(float[] OKFGGFMLPHB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE50", Offset = "0x7F6BA50", VA = "0x187F6CE50", Slot = "37")]
	protected override float[] CLDFJMLAOLG(Vector2 BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CF00", Offset = "0x7F6BB00", VA = "0x187F6CF00")]
	public JKJFFJCAELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FLJDHECEPMK : GOFILILCCIB<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB4AC00", Offset = "0xB49800", VA = "0x180B4AC00", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B0F0", Offset = "0x7F69CF0", VA = "0x187F6B0F0", Slot = "36")]
	protected override Quaternion IHEDANNNKDB(float[] OKFGGFMLPHB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B060", Offset = "0x7F69C60", VA = "0x187F6B060", Slot = "37")]
	protected override float[] CLDFJMLAOLG(Quaternion BKMPCFIAHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B150", Offset = "0x7F69D50", VA = "0x187F6B150")]
	public FLJDHECEPMK()
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
		public enum BMAHHLJFKDM
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
		public BMAHHLJFKDM Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
			[CompilerGenerated]
			get
			{
				return default(BMAHHLJFKDM);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F684F0", Offset = "0x7F670F0", VA = "0x187F684F0", Slot = "0")]
		public override bool Equals(object IIOGPDPGOLB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F683F0", Offset = "0x7F66FF0", VA = "0x187F683F0")]
		public static bool CDGFDPOPEPC(AvatarItemDownloadableConfig ODBANBBPCIA, AvatarItemDownloadableConfig FMNHBACBGIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F68620", Offset = "0x7F67220", VA = "0x187F68620", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F686F0", Offset = "0x7F672F0", VA = "0x187F686F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1017660", Offset = "0x1016260", VA = "0x181017660")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, CIMNPCOKFON, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7F6EAD0", Offset = "0x7F6D6D0", VA = "0x187F6EAD0")]
		private void NLGGMLBKLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E950", Offset = "0x7F6D550", VA = "0x187F6E950", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E9D0", Offset = "0x7F6D5D0", VA = "0x187F6E9D0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAD0", Offset = "0x7F6D6D0", VA = "0x187F6EAD0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EB40", Offset = "0x7F6D740", VA = "0x187F6EB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DGHCPEEEBGP : FIDLINEMCBP<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IAEICNELKNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IAEICNELKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CA50", Offset = "0x7F6B650", VA = "0x187F6CA50")]
		internal void GCLOEGGLPCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C9A0", Offset = "0x7F6B5A0", VA = "0x187F6C9A0")]
		internal void EMNOCNAOHFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C8F0", Offset = "0x7F6B4F0", VA = "0x187F6C8F0")]
		internal void CGOELOEOCHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CDA0", Offset = "0x7F6B9A0", VA = "0x187F6CDA0")]
		internal void PKHPDCLDJDP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CC50", Offset = "0x7F6B850", VA = "0x187F6CC50")]
		internal void MCJAEPCAOGF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CBA0", Offset = "0x7F6B7A0", VA = "0x187F6CBA0")]
		internal void LBHPDBAOGKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C840", Offset = "0x7F6B440", VA = "0x187F6C840")]
		internal void CCMNPHIALBE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C790", Offset = "0x7F6B390", VA = "0x187F6C790")]
		internal void AKEKMHGFOCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CD00", Offset = "0x7F6B900", VA = "0x187F6CD00")]
		internal void MHPKJIFOLBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CB00", Offset = "0x7F6B700", VA = "0x187F6CB00")]
		internal void JCCPLLODEHN(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NODGJBCNLPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F69E30", Offset = "0x7F68A30", VA = "0x187F69E30", Slot = "35")]
	public override void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, AnchorParamsRestrictions BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A350", Offset = "0x7F68F50", VA = "0x187F6A350", Slot = "36")]
	public override void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, AnchorParamsRestrictions BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A7F0", Offset = "0x7F693F0", VA = "0x187F6A7F0")]
	public DGHCPEEEBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C820", Offset = "0x3A8B420", VA = "0x183A8C820")]
	[CompilerGenerated]
	internal static void MJNEEEHEIGC<T>(string BABLEGNKCCH, T PINMHDANIAH, T IMMGKAMOJHP, NODGJBCNLPL P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GBLEJNLHKDN : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void OFPHMJLAOGA(Utf8JsonReader KFNDMAAELJD);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CKMKCBEOPOC
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
		public GBLEJNLHKDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public OFPHMJLAOGA <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OFPHMJLAOGA <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public OFPHMJLAOGA <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OFPHMJLAOGA <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OFPHMJLAOGA <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OFPHMJLAOGA <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OFPHMJLAOGA <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OFPHMJLAOGA <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OFPHMJLAOGA <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OFPHMJLAOGA <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OFPHMJLAOGA <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CKMKCBEOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F697E0", Offset = "0x7F683E0", VA = "0x187F697E0")]
		internal void APBFKDICCOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F69BF0", Offset = "0x7F687F0", VA = "0x187F69BF0")]
		internal void IPPBNGNPLDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F699E0", Offset = "0x7F685E0", VA = "0x187F699E0")]
		internal void EGKJOPFJIDO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F69D50", Offset = "0x7F68950", VA = "0x187F69D50")]
		internal void LKILIFKONKN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F69CA0", Offset = "0x7F688A0", VA = "0x187F69CA0")]
		internal void KNMAACGCCOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F69E00", Offset = "0x7F68A00", VA = "0x187F69E00")]
		internal void PGHFFGILHBN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F69B70", Offset = "0x7F68770", VA = "0x187F69B70")]
		internal void IOFODDPEDPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69A90", Offset = "0x7F68690", VA = "0x187F69A90")]
		internal void FIPACACJPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F697A0", Offset = "0x7F683A0", VA = "0x187F697A0")]
		internal void ALEDFDPFPON(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F69700", Offset = "0x7F68300", VA = "0x187F69700")]
		internal void AHLCEKHCPGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F69820", Offset = "0x7F68420", VA = "0x187F69820")]
		internal void EDMHKDMAPCC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GGFLDLHKGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GGFLDLHKGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C410", Offset = "0x7F6B010", VA = "0x187F6C410")]
		internal void FEPEIECHDDL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B350", Offset = "0x7F69F50", VA = "0x187F6B350", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F6BF50", Offset = "0x7F6AB50", VA = "0x187F6BF50", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, SerializedAvatarItemData BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B190", Offset = "0x7F69D90", VA = "0x187F6B190")]
	private AdditionalOutfitTypeData CBBAIHIJKJG(Utf8JsonReader NOIAIJBDKGG, OutfitType MDCDODCGNEK, JsonSerializerOptions ENJHAFMCLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C390", Offset = "0x7F6AF90", VA = "0x187F6C390")]
	public GBLEJNLHKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NODGCJLAIHI : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DBB0", Offset = "0x7F6C7B0", VA = "0x187F6DBB0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader NOIAIJBDKGG, Type LBIMBFLANBF, JsonSerializerOptions ENJHAFMCLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DF40", Offset = "0x7F6CB40", VA = "0x187F6DF40", Slot = "28")]
	public override void Write(Utf8JsonWriter HDDCOPOMJML, AvatarItemDownloadableConfig BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E070", Offset = "0x7F6CC70", VA = "0x187F6E070")]
	public NODGCJLAIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PAIIIELKKBE : FIDLINEMCBP<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E1C0", Offset = "0x7F6CDC0", VA = "0x187F6E1C0", Slot = "35")]
	public override void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, BeardData BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E360", Offset = "0x7F6CF60", VA = "0x187F6E360", Slot = "36")]
	public override void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, BeardData BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E420", Offset = "0x7F6D020", VA = "0x187F6E420")]
	public PAIIIELKKBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NNIDCPAEFJF : MFPDFJOHFOG<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DB70", Offset = "0x7F6C770", VA = "0x187F6DB70")]
	public NNIDCPAEFJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GFDMKPFIBGN : MFPDFJOHFOG<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C3D0", Offset = "0x7F6AFD0", VA = "0x187F6C3D0")]
	public GFDMKPFIBGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HIBGEMGFHBI : MFPDFJOHFOG<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C750", Offset = "0x7F6B350", VA = "0x187F6C750")]
	public HIBGEMGFHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EBMLNPOJFNL : GLKPEHOPLMI<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A830", Offset = "0x7F69430", VA = "0x187F6A830")]
	public EBMLNPOJFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HBJCAHNJALG : FIDLINEMCBP<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NPBDDPOOOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NPBDDPOOOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D380", Offset = "0x7F6BF80", VA = "0x187F6D380")]
		internal void GCLOEGGLPCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E190", Offset = "0x7F6CD90", VA = "0x187F6E190")]
		internal void EMNOCNAOHFM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C4B0", Offset = "0x7F6B0B0", VA = "0x187F6C4B0", Slot = "35")]
	public override void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, AdditionalFeetData BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C640", Offset = "0x7F6B240", VA = "0x187F6C640", Slot = "36")]
	public override void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, AdditionalFeetData BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C710", Offset = "0x7F6B310", VA = "0x187F6C710")]
	public HBJCAHNJALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CJALFAIDNOG : FIDLINEMCBP<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LLJKEJJJABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LLJKEJJJABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D410", Offset = "0x7F6C010", VA = "0x187F6D410")]
		internal void GCLOEGGLPCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D3E0", Offset = "0x7F6BFE0", VA = "0x187F6D3E0")]
		internal void EMNOCNAOHFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D3B0", Offset = "0x7F6BFB0", VA = "0x187F6D3B0")]
		internal void CGOELOEOCHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D600", Offset = "0x7F6C200", VA = "0x187F6D600")]
		internal void PKHPDCLDJDP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D560", Offset = "0x7F6C160", VA = "0x187F6D560")]
		internal void MCJAEPCAOGF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D4C0", Offset = "0x7F6C0C0", VA = "0x187F6D4C0")]
		internal void LBHPDBAOGKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D380", Offset = "0x7F6BF80", VA = "0x187F6D380")]
		internal void CCMNPHIALBE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F68FF0", Offset = "0x7F67BF0", VA = "0x187F68FF0", Slot = "35")]
	public override void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, HairData BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F693E0", Offset = "0x7F67FE0", VA = "0x187F693E0", Slot = "36")]
	public override void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, HairData BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F696C0", Offset = "0x7F682C0", VA = "0x187F696C0")]
	public CJALFAIDNOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EIOOENAMHHO : FIDLINEMCBP<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NLIKKAKDECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NLIKKAKDECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D940", Offset = "0x7F6C540", VA = "0x187F6D940")]
		internal void GCLOEGGLPCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D890", Offset = "0x7F6C490", VA = "0x187F6D890")]
		internal void EMNOCNAOHFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D7E0", Offset = "0x7F6C3E0", VA = "0x187F6D7E0")]
		internal void CGOELOEOCHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DAC0", Offset = "0x7F6C6C0", VA = "0x187F6DAC0")]
		internal void PKHPDCLDJDP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DA10", Offset = "0x7F6C610", VA = "0x187F6DA10")]
		internal void MCJAEPCAOGF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D970", Offset = "0x7F6C570", VA = "0x187F6D970")]
		internal void LBHPDBAOGKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D740", Offset = "0x7F6C340", VA = "0x187F6D740")]
		internal void CCMNPHIALBE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D6A0", Offset = "0x7F6C2A0", VA = "0x187F6D6A0")]
		internal void AKEKMHGFOCJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A870", Offset = "0x7F69470", VA = "0x187F6A870", Slot = "35")]
	public override void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, AdditionalHatData BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F6ACD0", Offset = "0x7F698D0", VA = "0x187F6ACD0", Slot = "36")]
	public override void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, AdditionalHatData BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B020", Offset = "0x7F69C20", VA = "0x187F6B020")]
	public EIOOENAMHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KJJDCAMKIOL : FIDLINEMCBP<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NOICDEJGPJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NOICDEJGPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CA50", Offset = "0x7F6B650", VA = "0x187F6CA50")]
		internal void GCLOEGGLPCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E150", Offset = "0x7F6CD50", VA = "0x187F6E150")]
		internal void EMNOCNAOHFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E0B0", Offset = "0x7F6CCB0", VA = "0x187F6E0B0")]
		internal void CGOELOEOCHL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CF40", Offset = "0x7F6BB40", VA = "0x187F6CF40", Slot = "35")]
	public override void JLHIOODMPMC(Utf8JsonReader NOIAIJBDKGG, JsonSerializerOptions ENJHAFMCLFP, string BABLEGNKCCH, RoomieHatData BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D130", Offset = "0x7F6BD30", VA = "0x187F6D130", Slot = "36")]
	public override void KFKEOJGPMGB(Utf8JsonWriter HDDCOPOMJML, RoomieHatData BKMPCFIAHIG, JsonSerializerOptions ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D230", Offset = "0x7F6BE30", VA = "0x187F6D230")]
	public KJJDCAMKIOL()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0880", Offset = "0xABF480", VA = "0x180AC0880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xEF3540", Offset = "0xEF2140", VA = "0x180EF3540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xEF3530", Offset = "0xEF2130", VA = "0x180EF3530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1050DC0", Offset = "0x104F9C0", VA = "0x181050DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1050D70", Offset = "0x104F970", VA = "0x181050D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x21EE980", Offset = "0x21ED580", VA = "0x1821EE980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E920", Offset = "0x7F6D520", VA = "0x187F6E920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2E442C0", Offset = "0x2E42EC0", VA = "0x182E442C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2E44290", Offset = "0x2E42E90", VA = "0x182E44290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAA9DD0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1E0", Offset = "0xAA9DE0", VA = "0x180AAB1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NHDGALDIFDN.IAHAFMDMEMA ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
			[CompilerGenerated]
			get
			{
				return default(NHDGALDIFDN.IAHAFMDMEMA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x13462C0", Offset = "0x1344EC0", VA = "0x1813462C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B580", Offset = "0xA5A180", VA = "0x180A5B580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E480", Offset = "0x7F6D080", VA = "0x187F6E480", Slot = "0")]
		public override bool Equals(object IIOGPDPGOLB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E460", Offset = "0x7F6D060", VA = "0x187F6E460")]
		public static bool CDGFDPOPEPC(SerializedAvatarItemData ODBANBBPCIA, SerializedAvatarItemData FMNHBACBGIN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E8F0", Offset = "0x7F6D4F0", VA = "0x187F6E8F0")]
		public static bool IECKAGJENEB(SerializedAvatarItemData ODBANBBPCIA, SerializedAvatarItemData FMNHBACBGIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E500", Offset = "0x7F6D100", VA = "0x187F6E500", Slot = "4")]
		public bool Equals(SerializedAvatarItemData IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E820", Offset = "0x7F6D420", VA = "0x187F6E820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
