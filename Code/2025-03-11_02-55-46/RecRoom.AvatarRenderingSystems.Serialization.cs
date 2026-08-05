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
public class BJJIMCHEKFO : MJCIJDHCKNN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAB2660", Offset = "0xAB1A60", VA = "0x180AB2660", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74732A0", Offset = "0x74726A0", VA = "0x1874732A0", Slot = "36")]
	protected override Vector3 CLDHNAJNEDB(float[] JPGIMCGBJEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74732F0", Offset = "0x74726F0", VA = "0x1874732F0", Slot = "37")]
	protected override float[] PGFHNJLOBFL(Vector3 PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7473370", Offset = "0x7472770", VA = "0x187473370")]
	public BJJIMCHEKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OOODEBONLIB : MJCIJDHCKNN<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACB320", Offset = "0xACA720", VA = "0x180ACB320", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7476790", Offset = "0x7475B90", VA = "0x187476790", Slot = "36")]
	protected override Vector2 CLDHNAJNEDB(float[] JPGIMCGBJEJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74767D0", Offset = "0x7475BD0", VA = "0x1874767D0", Slot = "37")]
	protected override float[] PGFHNJLOBFL(Vector2 PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7476840", Offset = "0x7475C40", VA = "0x187476840")]
	public OOODEBONLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IOIOIGHHLGG : MJCIJDHCKNN<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC50C0", Offset = "0xAC44C0", VA = "0x180AC50C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7474490", Offset = "0x7473890", VA = "0x187474490", Slot = "36")]
	protected override Quaternion CLDHNAJNEDB(float[] JPGIMCGBJEJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74744F0", Offset = "0x74738F0", VA = "0x1874744F0", Slot = "37")]
	protected override float[] PGFHNJLOBFL(Quaternion PEBNJNGMMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7474580", Offset = "0x7473980", VA = "0x187474580")]
	public IOIOIGHHLGG()
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
		public enum MJEJPGMMBCJ
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
		public MJEJPGMMBCJ Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
			[CompilerGenerated]
			get
			{
				return default(MJEJPGMMBCJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7472710", Offset = "0x7471B10", VA = "0x187472710", Slot = "0")]
		public override bool Equals(object MNALNBMKJLK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7472980", Offset = "0x7471D80", VA = "0x187472980")]
		public static bool JECEAGOPPKI(AvatarItemDownloadableConfig BBGKOKBOEGA, AvatarItemDownloadableConfig NBNHMPFPBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7472840", Offset = "0x7471C40", VA = "0x187472840", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7472910", Offset = "0x7471D10", VA = "0x187472910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDB59E0", Offset = "0xDB4DE0", VA = "0x180DB59E0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, COENILANACJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x74776D0", Offset = "0x7476AD0", VA = "0x1874776D0")]
		private void PLINAIICHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7477550", Offset = "0x7476950", VA = "0x187477550", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74775D0", Offset = "0x74769D0", VA = "0x1874775D0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74776D0", Offset = "0x7476AD0", VA = "0x1874776D0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7477740", Offset = "0x7476B40", VA = "0x187477740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AABKOGBIFLO : DKCAHGIKGPD<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HGICFIKPPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HGICFIKPPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7473780", Offset = "0x7472B80", VA = "0x187473780")]
		internal void AHIAMHCHPOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7473C30", Offset = "0x7473030", VA = "0x187473C30")]
		internal void LDNMJKFBDIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74736D0", Offset = "0x7472AD0", VA = "0x1874736D0")]
		internal void ACGLHCPGOAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7473830", Offset = "0x7472C30", VA = "0x187473830")]
		internal void AICNDGJGALE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7473CE0", Offset = "0x74730E0", VA = "0x187473CE0")]
		internal void NKODACNMAOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7473980", Offset = "0x7472D80", VA = "0x187473980")]
		internal void CGENKHAFJFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7473AE0", Offset = "0x7472EE0", VA = "0x187473AE0")]
		internal void KHPIGHCHADM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7473A30", Offset = "0x7472E30", VA = "0x187473A30")]
		internal void FCLPLFBIDPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7473B90", Offset = "0x7472F90", VA = "0x187473B90")]
		internal void LDLLAKALJNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74738E0", Offset = "0x7472CE0", VA = "0x1874738E0")]
		internal void BOOBAENIBGD(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BJEBHNIJKHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74719D0", Offset = "0x7470DD0", VA = "0x1874719D0", Slot = "35")]
	public override void LAFCDDNLBFK(Utf8JsonReader AENCLAHFBDP, JsonSerializerOptions OMCEIGOCOKM, string KIPNKJLFPED, AnchorParamsRestrictions BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7471540", Offset = "0x7470940", VA = "0x187471540", Slot = "36")]
	public override void CAKFIPEKMMJ(Utf8JsonWriter MGKMPBCECKN, AnchorParamsRestrictions PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7471EF0", Offset = "0x74712F0", VA = "0x187471EF0")]
	public AABKOGBIFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5AB0", Offset = "0x3BB4EB0", VA = "0x183BB5AB0")]
	[CompilerGenerated]
	internal static void HAGDCBMAGCG<T>(string KIPNKJLFPED, T GHFLHNCPIIL, T OPPGOIOMPCE, BJEBHNIJKHE P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OMEHFFDBAIE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void FOKGKJMFICN(Utf8JsonReader NPJNBFDHKLI);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KHIMKDBIJAA
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
		public OMEHFFDBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FOKGKJMFICN <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FOKGKJMFICN <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FOKGKJMFICN <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FOKGKJMFICN <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FOKGKJMFICN <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FOKGKJMFICN <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FOKGKJMFICN <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FOKGKJMFICN <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FOKGKJMFICN <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FOKGKJMFICN <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FOKGKJMFICN <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KHIMKDBIJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7474D10", Offset = "0x7474110", VA = "0x187474D10")]
		internal void GHOINMDDCKA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74750E0", Offset = "0x74744E0", VA = "0x1874750E0")]
		internal void MOFMEOFBKPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7474C60", Offset = "0x7474060", VA = "0x187474C60")]
		internal void FBNJGEOFFDB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7474FB0", Offset = "0x74743B0", VA = "0x187474FB0")]
		internal void KNHLEDIIPGB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7474AD0", Offset = "0x7473ED0", VA = "0x187474AD0")]
		internal void DCMLDFHBOGP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7475190", Offset = "0x7474590", VA = "0x187475190")]
		internal void OPOBBBOIOGH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7475060", Offset = "0x7474460", VA = "0x187475060")]
		internal void LHDMBAFAJPG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7474B80", Offset = "0x7473F80", VA = "0x187474B80")]
		internal void EMFEBMLFJEO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7474ED0", Offset = "0x74742D0", VA = "0x187474ED0")]
		internal void INJMFGLNIII(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7474F10", Offset = "0x7474310", VA = "0x187474F10")]
		internal void KGKIKOLKCOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7474D50", Offset = "0x7474150", VA = "0x187474D50")]
		internal void GMKNKCLMDPD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MGEFFECBBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MGEFFECBBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7475520", Offset = "0x7474920", VA = "0x187475520")]
		internal void CBAPJAFILBB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7475730", Offset = "0x7474B30", VA = "0x187475730", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7476310", Offset = "0x7475710", VA = "0x187476310", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, SerializedAvatarItemData PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74755C0", Offset = "0x74749C0", VA = "0x1874755C0")]
	private AdditionalOutfitTypeData JHCBAANCCAN(Utf8JsonReader AENCLAHFBDP, OutfitType ANONBNLNHHL, JsonSerializerOptions OMCEIGOCOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7476750", Offset = "0x7475B50", VA = "0x187476750")]
	public OMEHFFDBAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PPKHCEHAEEA : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7476B50", Offset = "0x7475F50", VA = "0x187476B50", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader AENCLAHFBDP, Type AOKJHOCMECN, JsonSerializerOptions OMCEIGOCOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7476EE0", Offset = "0x74762E0", VA = "0x187476EE0", Slot = "28")]
	public override void Write(Utf8JsonWriter MGKMPBCECKN, AvatarItemDownloadableConfig PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7477010", Offset = "0x7476410", VA = "0x187477010")]
	public PPKHCEHAEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FCNFGONCMFM : DKCAHGIKGPD<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7473470", Offset = "0x7472870", VA = "0x187473470", Slot = "35")]
	public override void LAFCDDNLBFK(Utf8JsonReader AENCLAHFBDP, JsonSerializerOptions OMCEIGOCOKM, string KIPNKJLFPED, BeardData BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74733B0", Offset = "0x74727B0", VA = "0x1874733B0", Slot = "36")]
	public override void CAKFIPEKMMJ(Utf8JsonWriter MGKMPBCECKN, BeardData PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7473610", Offset = "0x7472A10", VA = "0x187473610")]
	public FCNFGONCMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDLAMEFGIEN : CMMNMMOGFFJ<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7473650", Offset = "0x7472A50", VA = "0x187473650")]
	public HDLAMEFGIEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JNEOMPLDADP : CMMNMMOGFFJ<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74745C0", Offset = "0x74739C0", VA = "0x1874745C0")]
	public JNEOMPLDADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KMFKKMGBKFG : CMMNMMOGFFJ<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74751C0", Offset = "0x74745C0", VA = "0x1874751C0")]
	public KMFKKMGBKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HGFBIEIKBKH : GKMFOALNJPK<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7473690", Offset = "0x7472A90", VA = "0x187473690")]
	public HGFBIEIKBKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLJEIGMBEBM : DKCAHGIKGPD<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PLLEHOELEFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PLLEHOELEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7475420", Offset = "0x7474820", VA = "0x187475420")]
		internal void AHIAMHCHPOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7476B20", Offset = "0x7475F20", VA = "0x187476B20")]
		internal void LDNMJKFBDIP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7476950", Offset = "0x7475D50", VA = "0x187476950", Slot = "35")]
	public override void LAFCDDNLBFK(Utf8JsonReader AENCLAHFBDP, JsonSerializerOptions OMCEIGOCOKM, string KIPNKJLFPED, AdditionalFeetData BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7476880", Offset = "0x7475C80", VA = "0x187476880", Slot = "36")]
	public override void CAKFIPEKMMJ(Utf8JsonWriter MGKMPBCECKN, AdditionalFeetData PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7476AE0", Offset = "0x7475EE0", VA = "0x187476AE0")]
	public PLJEIGMBEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IHFBEBJPFHK : DKCAHGIKGPD<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LGGGFCAIDIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LGGGFCAIDIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7475230", Offset = "0x7474630", VA = "0x187475230")]
		internal void AHIAMHCHPOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7475450", Offset = "0x7474850", VA = "0x187475450")]
		internal void LDNMJKFBDIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7475200", Offset = "0x7474600", VA = "0x187475200")]
		internal void ACGLHCPGOAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74752E0", Offset = "0x74746E0", VA = "0x1874752E0")]
		internal void AICNDGJGALE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7475480", Offset = "0x7474880", VA = "0x187475480")]
		internal void NKODACNMAOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7475380", Offset = "0x7474780", VA = "0x187475380")]
		internal void CGENKHAFJFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7475420", Offset = "0x7474820", VA = "0x187475420")]
		internal void KHPIGHCHADM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7474060", Offset = "0x7473460", VA = "0x187474060", Slot = "35")]
	public override void LAFCDDNLBFK(Utf8JsonReader AENCLAHFBDP, JsonSerializerOptions OMCEIGOCOKM, string KIPNKJLFPED, HairData BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7473D90", Offset = "0x7473190", VA = "0x187473D90", Slot = "36")]
	public override void CAKFIPEKMMJ(Utf8JsonWriter MGKMPBCECKN, HairData PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7474450", Offset = "0x7473850", VA = "0x187474450")]
	public IHFBEBJPFHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AIJAKBHHPJI : DKCAHGIKGPD<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JODBGKMPCGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JODBGKMPCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74746B0", Offset = "0x7473AB0", VA = "0x1874746B0")]
		internal void AHIAMHCHPOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7474970", Offset = "0x7473D70", VA = "0x187474970")]
		internal void LDNMJKFBDIP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7474600", Offset = "0x7473A00", VA = "0x187474600")]
		internal void ACGLHCPGOAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74746E0", Offset = "0x7473AE0", VA = "0x1874746E0")]
		internal void AICNDGJGALE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7474A20", Offset = "0x7473E20", VA = "0x187474A20")]
		internal void NKODACNMAOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7474790", Offset = "0x7473B90", VA = "0x187474790")]
		internal void CGENKHAFJFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x74748D0", Offset = "0x7473CD0", VA = "0x1874748D0")]
		internal void KHPIGHCHADM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7474830", Offset = "0x7473C30", VA = "0x187474830")]
		internal void FCLPLFBIDPC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7472270", Offset = "0x7471670", VA = "0x187472270", Slot = "35")]
	public override void LAFCDDNLBFK(Utf8JsonReader AENCLAHFBDP, JsonSerializerOptions OMCEIGOCOKM, string KIPNKJLFPED, AdditionalHatData BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7471F30", Offset = "0x7471330", VA = "0x187471F30", Slot = "36")]
	public override void CAKFIPEKMMJ(Utf8JsonWriter MGKMPBCECKN, AdditionalHatData PEBNJNGMMHE, JsonSerializerOptions OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74726D0", Offset = "0x7471AD0", VA = "0x1874726D0")]
	public AIJAKBHHPJI()
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
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x973060", Offset = "0x972460", VA = "0x180973060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCEB250", Offset = "0xCEA650", VA = "0x180CEB250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCEB370", Offset = "0xCEA770", VA = "0x180CEB370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCEB260", Offset = "0xCEA660", VA = "0x180CEB260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xDEDD30", Offset = "0xDED130", VA = "0x180DEDD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xDEDCE0", Offset = "0xDED0E0", VA = "0x180DEDCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1D747F0", Offset = "0x1D73BF0", VA = "0x181D747F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7477520", Offset = "0x7476920", VA = "0x187477520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2966460", Offset = "0x2965860", VA = "0x182966460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x29663B0", Offset = "0x29657B0", VA = "0x1829663B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBB5B40", Offset = "0xBB4F40", VA = "0x180BB5B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xBB5B90", Offset = "0xBB4F90", VA = "0x180BB5B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JEMKHCHMBLO.IFCJAEMECIM ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
			[CompilerGenerated]
			get
			{
				return default(JEMKHCHMBLO.IFCJAEMECIM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x68FE7A0", Offset = "0x68FDBA0", VA = "0x1868FE7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9642D0", Offset = "0x9636D0", VA = "0x1809642D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7477050", Offset = "0x7476450", VA = "0x187477050", Slot = "0")]
		public override bool Equals(object MNALNBMKJLK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74774D0", Offset = "0x74768D0", VA = "0x1874774D0")]
		public static bool JECEAGOPPKI(SerializedAvatarItemData BBGKOKBOEGA, SerializedAvatarItemData NBNHMPFPBPM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74774F0", Offset = "0x74768F0", VA = "0x1874774F0")]
		public static bool NEBBLIKBPGD(SerializedAvatarItemData BBGKOKBOEGA, SerializedAvatarItemData NBNHMPFPBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74770E0", Offset = "0x74764E0", VA = "0x1874770E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7477400", Offset = "0x7476800", VA = "0x187477400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
