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
public class NMFFKJELNDN : CKNIAACGDCF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAFEEC0", Offset = "0xAFE2C0", VA = "0x180AFEEC0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x769DE40", Offset = "0x769D240", VA = "0x18769DE40", Slot = "36")]
	protected override Vector3 NCCEDEPPPHA(float[] EDJBENPLFOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x769DDC0", Offset = "0x769D1C0", VA = "0x18769DDC0", Slot = "37")]
	protected override float[] ICFDPGCHGNH(Vector3 FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x769DE90", Offset = "0x769D290", VA = "0x18769DE90")]
	public NMFFKJELNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DMBEHLBBIEG : CKNIAACGDCF<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB1EC30", Offset = "0xB1E030", VA = "0x180B1EC30", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7699F30", Offset = "0x7699330", VA = "0x187699F30", Slot = "36")]
	protected override Vector2 NCCEDEPPPHA(float[] EDJBENPLFOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7699EC0", Offset = "0x76992C0", VA = "0x187699EC0", Slot = "37")]
	protected override float[] ICFDPGCHGNH(Vector2 FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7699F70", Offset = "0x7699370", VA = "0x187699F70")]
	public DMBEHLBBIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class COEBJKHCFLC : CKNIAACGDCF<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB16190", Offset = "0xB15590", VA = "0x180B16190", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7699590", Offset = "0x7698990", VA = "0x187699590", Slot = "36")]
	protected override Quaternion NCCEDEPPPHA(float[] EDJBENPLFOA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7699500", Offset = "0x7698900", VA = "0x187699500", Slot = "37")]
	protected override float[] ICFDPGCHGNH(Quaternion FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76995F0", Offset = "0x76989F0", VA = "0x1876995F0")]
	public COEBJKHCFLC()
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
		public enum FPKFLMBCHLN
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
		public FPKFLMBCHLN Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0")]
			[CompilerGenerated]
			get
			{
				return default(FPKFLMBCHLN);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76984A0", Offset = "0x76978A0", VA = "0x1876984A0", Slot = "0")]
		public override bool Equals(object JAPIEEBOJEA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7698710", Offset = "0x7697B10", VA = "0x187698710")]
		public static bool IGEKHAEJGKN(AvatarItemDownloadableConfig AJLPPHLPDOI, AvatarItemDownloadableConfig PODDNHBLFOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76985D0", Offset = "0x76979D0", VA = "0x1876985D0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76986A0", Offset = "0x7697AA0", VA = "0x1876986A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE2B670", Offset = "0xE2AA70", VA = "0x180E2B670")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, IECGHJIBGMC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x769E5B0", Offset = "0x769D9B0", VA = "0x18769E5B0")]
		private void GBJGIIKDBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x769E440", Offset = "0x769D840", VA = "0x18769E440", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x769E4C0", Offset = "0x769D8C0", VA = "0x18769E4C0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x769E5B0", Offset = "0x769D9B0", VA = "0x18769E5B0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x769E630", Offset = "0x769DA30", VA = "0x18769E630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LOHPKGFOEAB : GAKMPEJNGGB<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FLCNMCFFCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FLCNMCFFCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x769A3A0", Offset = "0x76997A0", VA = "0x18769A3A0")]
		internal void KHDOPNHMJDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x769A650", Offset = "0x7699A50", VA = "0x18769A650")]
		internal void NDCJHCAIENO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x769A7B0", Offset = "0x7699BB0", VA = "0x18769A7B0")]
		internal void OMHODAKELCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x769A4F0", Offset = "0x76998F0", VA = "0x18769A4F0")]
		internal void MJFEJGHBIND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x769A5A0", Offset = "0x76999A0", VA = "0x18769A5A0")]
		internal void NBEHIOIELAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x769A860", Offset = "0x7699C60", VA = "0x18769A860")]
		internal void PFPEDJDOEMA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x769A2F0", Offset = "0x76996F0", VA = "0x18769A2F0")]
		internal void EOKPNGOMHPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x769A700", Offset = "0x7699B00", VA = "0x18769A700")]
		internal void NHFGNPKIBGE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x769A250", Offset = "0x7699650", VA = "0x18769A250")]
		internal void ADKHDBIIBEA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x769A450", Offset = "0x7699850", VA = "0x18769A450")]
		internal void LJLLGAFJNIA(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DIICNAMEDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x769D5C0", Offset = "0x769C9C0", VA = "0x18769D5C0", Slot = "35")]
	public override void MIJEFDICLCI(Utf8JsonReader KILJCGGJECG, JsonSerializerOptions PJIJGMDDLKH, string CGIHFPMPHOC, AnchorParamsRestrictions DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x769D130", Offset = "0x769C530", VA = "0x18769D130", Slot = "36")]
	public override void IJFLMPCGHAA(Utf8JsonWriter NACIMEJMHHK, AnchorParamsRestrictions FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x769DAE0", Offset = "0x769CEE0", VA = "0x18769DAE0")]
	public LOHPKGFOEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36DA110", Offset = "0x36D9510", VA = "0x1836DA110")]
	[CompilerGenerated]
	internal static void JALILPMCAEB<T>(string CGIHFPMPHOC, T NMBONOELKFM, T ADFNCKOMLCE, DIICNAMEDDC P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LKMBOFLJBID : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void NBNDMALLFLK(Utf8JsonReader NAEIDONDAPA);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JHNENHHHOPB
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
		public LKMBOFLJBID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NBNDMALLFLK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NBNDMALLFLK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NBNDMALLFLK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NBNDMALLFLK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public NBNDMALLFLK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NBNDMALLFLK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NBNDMALLFLK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NBNDMALLFLK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NBNDMALLFLK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NBNDMALLFLK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NBNDMALLFLK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JHNENHHHOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x769BAA0", Offset = "0x769AEA0", VA = "0x18769BAA0")]
		internal void HNOMEMFFNON(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x769BC90", Offset = "0x769B090", VA = "0x18769BC90")]
		internal void JDLFNLMKLIC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x769B830", Offset = "0x769AC30", VA = "0x18769B830")]
		internal void BKFPKACNAML(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x769BE70", Offset = "0x769B270", VA = "0x18769BE70")]
		internal void PNNMMLNFBKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x769BDC0", Offset = "0x769B1C0", VA = "0x18769BDC0")]
		internal void ODLKHKHNLFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x769BC60", Offset = "0x769B060", VA = "0x18769BC60")]
		internal void IFPJCIGANMJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x769BD40", Offset = "0x769B140", VA = "0x18769BD40")]
		internal void KEBMIMLPPID(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x769B9C0", Offset = "0x769ADC0", VA = "0x18769B9C0")]
		internal void GCFFAPBCJLM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x769B8E0", Offset = "0x769ACE0", VA = "0x18769B8E0")]
		internal void CHHOIHMEHMI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x769B920", Offset = "0x769AD20", VA = "0x18769B920")]
		internal void CHKKFOFODPF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x769BAE0", Offset = "0x769AEE0", VA = "0x18769BAE0")]
		internal void IFLJEOGJFAL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DBBJIHOMFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DBBJIHOMFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7699630", Offset = "0x7698A30", VA = "0x187699630")]
		internal void ENMHGHONPKC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x769C090", Offset = "0x769B490", VA = "0x18769C090", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x769CC70", Offset = "0x769C070", VA = "0x18769CC70", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, SerializedAvatarItemData FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x769BF20", Offset = "0x769B320", VA = "0x18769BF20")]
	private AdditionalOutfitTypeData MEJIDMDDJBA(Utf8JsonReader KILJCGGJECG, OutfitType MAIGGPEPIHD, JsonSerializerOptions PJIJGMDDLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x769D0B0", Offset = "0x769C4B0", VA = "0x18769D0B0")]
	public LKMBOFLJBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DJIDCLBDFEK : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76999C0", Offset = "0x7698DC0", VA = "0x1876999C0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7699D50", Offset = "0x7699150", VA = "0x187699D50", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, AvatarItemDownloadableConfig FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7699E80", Offset = "0x7699280", VA = "0x187699E80")]
	public DJIDCLBDFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ENBDDBNHLGL : GAKMPEJNGGB<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x769A070", Offset = "0x7699470", VA = "0x18769A070", Slot = "35")]
	public override void MIJEFDICLCI(Utf8JsonReader KILJCGGJECG, JsonSerializerOptions PJIJGMDDLKH, string CGIHFPMPHOC, BeardData DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7699FB0", Offset = "0x76993B0", VA = "0x187699FB0", Slot = "36")]
	public override void IJFLMPCGHAA(Utf8JsonWriter NACIMEJMHHK, BeardData FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x769A210", Offset = "0x7699610", VA = "0x18769A210")]
	public ENBDDBNHLGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ONEPDOCAOAH : BDCINLOIEPD<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x769DF10", Offset = "0x769D310", VA = "0x18769DF10")]
	public ONEPDOCAOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HNAHKJMIMDG : BDCINLOIEPD<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x769B7F0", Offset = "0x769ABF0", VA = "0x18769B7F0")]
	public HNAHKJMIMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OGIJIJPIFGN : BDCINLOIEPD<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x769DED0", Offset = "0x769D2D0", VA = "0x18769DED0")]
	public OGIJIJPIFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LLAIDLGDMNC : ACIDIKDAFCJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x769D0F0", Offset = "0x769C4F0", VA = "0x18769D0F0")]
	public LLAIDLGDMNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NIIMFLNPIKB : GAKMPEJNGGB<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AAEJBAPOPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AAEJBAPOPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7698440", Offset = "0x7697840", VA = "0x187698440")]
		internal void KHDOPNHMJDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7698470", Offset = "0x7697870", VA = "0x187698470")]
		internal void NDCJHCAIENO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x769DBF0", Offset = "0x769CFF0", VA = "0x18769DBF0", Slot = "35")]
	public override void MIJEFDICLCI(Utf8JsonReader KILJCGGJECG, JsonSerializerOptions PJIJGMDDLKH, string CGIHFPMPHOC, AdditionalFeetData DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x769DB20", Offset = "0x769CF20", VA = "0x18769DB20", Slot = "36")]
	public override void IJFLMPCGHAA(Utf8JsonWriter NACIMEJMHHK, AdditionalFeetData FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x769DD80", Offset = "0x769D180", VA = "0x18769DD80")]
	public NIIMFLNPIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HHJBDDJDOFD : GAKMPEJNGGB<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DCJPNMCIDMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DCJPNMCIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x76996D0", Offset = "0x7698AD0", VA = "0x1876996D0")]
		internal void KHDOPNHMJDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x76998C0", Offset = "0x7698CC0", VA = "0x1876998C0")]
		internal void NDCJHCAIENO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76998F0", Offset = "0x7698CF0", VA = "0x1876998F0")]
		internal void OMHODAKELCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7699780", Offset = "0x7698B80", VA = "0x187699780")]
		internal void MJFEJGHBIND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7699820", Offset = "0x7698C20", VA = "0x187699820")]
		internal void NBEHIOIELAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7699920", Offset = "0x7698D20", VA = "0x187699920")]
		internal void PFPEDJDOEMA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7698440", Offset = "0x7697840", VA = "0x187698440")]
		internal void EOKPNGOMHPB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x769B3C0", Offset = "0x769A7C0", VA = "0x18769B3C0", Slot = "35")]
	public override void MIJEFDICLCI(Utf8JsonReader KILJCGGJECG, JsonSerializerOptions PJIJGMDDLKH, string CGIHFPMPHOC, HairData DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x769B0F0", Offset = "0x769A4F0", VA = "0x18769B0F0", Slot = "36")]
	public override void IJFLMPCGHAA(Utf8JsonWriter NACIMEJMHHK, HairData FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x769B7B0", Offset = "0x769ABB0", VA = "0x18769B7B0")]
	public HHJBDDJDOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GDHBDCIGJNC : GAKMPEJNGGB<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CKINGOLFIEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CKINGOLFIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x76990D0", Offset = "0x76984D0", VA = "0x1876990D0")]
		internal void KHDOPNHMJDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7699260", Offset = "0x7698660", VA = "0x187699260")]
		internal void NDCJHCAIENO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x76993B0", Offset = "0x76987B0", VA = "0x1876993B0")]
		internal void OMHODAKELCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7699100", Offset = "0x7698500", VA = "0x187699100")]
		internal void MJFEJGHBIND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76991B0", Offset = "0x76985B0", VA = "0x1876991B0")]
		internal void NBEHIOIELAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7699460", Offset = "0x7698860", VA = "0x187699460")]
		internal void PFPEDJDOEMA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7699030", Offset = "0x7698430", VA = "0x187699030")]
		internal void EOKPNGOMHPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7699310", Offset = "0x7698710", VA = "0x187699310")]
		internal void NHFGNPKIBGE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x769AC50", Offset = "0x769A050", VA = "0x18769AC50", Slot = "35")]
	public override void MIJEFDICLCI(Utf8JsonReader KILJCGGJECG, JsonSerializerOptions PJIJGMDDLKH, string CGIHFPMPHOC, AdditionalHatData DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x769A910", Offset = "0x7699D10", VA = "0x18769A910", Slot = "36")]
	public override void IJFLMPCGHAA(Utf8JsonWriter NACIMEJMHHK, AdditionalHatData FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x769B0B0", Offset = "0x769A4B0", VA = "0x18769B0B0")]
	public GDHBDCIGJNC()
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
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x992550", Offset = "0x991950", VA = "0x180992550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD13190", Offset = "0xD12590", VA = "0x180D13190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9FD930", Offset = "0x9FCD30", VA = "0x1809FD930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD131D0", Offset = "0xD125D0", VA = "0x180D131D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD131A0", Offset = "0xD125A0", VA = "0x180D131A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE49DC0", Offset = "0xE491C0", VA = "0x180E49DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xE4A160", Offset = "0xE49560", VA = "0x180E4A160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1E01400", Offset = "0x1E00800", VA = "0x181E01400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x769E410", Offset = "0x769D810", VA = "0x18769E410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x29F47A0", Offset = "0x29F3BA0", VA = "0x1829F47A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x29F47C0", Offset = "0x29F3BC0", VA = "0x1829F47C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC07130", Offset = "0xC06530", VA = "0x180C07130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC07180", Offset = "0xC06580", VA = "0x180C07180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LDBNJIFCKAL.HECKIELMCBP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
			[CompilerGenerated]
			get
			{
				return default(LDBNJIFCKAL.HECKIELMCBP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6AD8A60", Offset = "0x6AD7E60", VA = "0x186AD8A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9933A0", Offset = "0x9927A0", VA = "0x1809933A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x769DF50", Offset = "0x769D350", VA = "0x18769DF50", Slot = "0")]
		public override bool Equals(object JAPIEEBOJEA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x769E3C0", Offset = "0x769D7C0", VA = "0x18769E3C0")]
		public static bool IGEKHAEJGKN(SerializedAvatarItemData AJLPPHLPDOI, SerializedAvatarItemData PODDNHBLFOD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x769E3E0", Offset = "0x769D7E0", VA = "0x18769E3E0")]
		public static bool PIPJPONNKNK(SerializedAvatarItemData AJLPPHLPDOI, SerializedAvatarItemData PODDNHBLFOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x769DFD0", Offset = "0x769D3D0", VA = "0x18769DFD0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x769E2F0", Offset = "0x769D6F0", VA = "0x18769E2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
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
