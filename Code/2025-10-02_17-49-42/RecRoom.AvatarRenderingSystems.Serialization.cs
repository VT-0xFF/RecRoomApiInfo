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
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x835E5A0", Offset = "0x835CFA0", VA = "0x18835E5A0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AFKJOLALBCP : BDLAEIDBOPF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD419C0", Offset = "0xD403C0", VA = "0x180D419C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8357FB0", Offset = "0x83569B0", VA = "0x188357FB0", Slot = "36")]
	protected override Vector3 GNFEFGCNELH(float[] FDOLNIMJMJM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8357F30", Offset = "0x8356930", VA = "0x188357F30", Slot = "37")]
	protected override float[] ABAGCAMAMIA(Vector3 KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8358000", Offset = "0x8356A00", VA = "0x188358000")]
	public AFKJOLALBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KCDBHILJKLO : BDLAEIDBOPF<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x835DD80", Offset = "0x835C780", VA = "0x18835DD80", Slot = "36")]
	protected override Vector2 GNFEFGCNELH(float[] FDOLNIMJMJM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x835DD10", Offset = "0x835C710", VA = "0x18835DD10", Slot = "37")]
	protected override float[] ABAGCAMAMIA(Vector2 KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x835DDC0", Offset = "0x835C7C0", VA = "0x18835DDC0")]
	public KCDBHILJKLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GOJFCBMGJNB : BDLAEIDBOPF<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBBC080", Offset = "0xBBAA80", VA = "0x180BBC080", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x835BFF0", Offset = "0x835A9F0", VA = "0x18835BFF0", Slot = "36")]
	protected override Quaternion GNFEFGCNELH(float[] FDOLNIMJMJM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x835BF60", Offset = "0x835A960", VA = "0x18835BF60", Slot = "37")]
	protected override float[] ABAGCAMAMIA(Quaternion KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x835C050", Offset = "0x835AA50", VA = "0x18835C050")]
	public GOJFCBMGJNB()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarItemDownloadableConfig : IEquatable<AvatarItemDownloadableConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum AOIGIDBMCIJ
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
		public AOIGIDBMCIJ Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
			[CompilerGenerated]
			get
			{
				return default(AOIGIDBMCIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83582E0", Offset = "0x8356CE0", VA = "0x1883582E0", Slot = "0")]
		public override bool Equals(object GOCNHGEHNFD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8358550", Offset = "0x8356F50", VA = "0x188358550")]
		public static bool NOPNAEDOCOI(AvatarItemDownloadableConfig IIIICGAEODJ, AvatarItemDownloadableConfig ELBIKJBAIEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8358410", Offset = "0x8356E10", VA = "0x188358410", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83584E0", Offset = "0x8356EE0", VA = "0x1883584E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x10C6480", Offset = "0x10C4E80", VA = "0x1810C6480")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, CNAKNBPLFLB, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x835F030", Offset = "0x835DA30", VA = "0x18835F030")]
		private void OKOIEDJPLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x835EEB0", Offset = "0x835D8B0", VA = "0x18835EEB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x835EF30", Offset = "0x835D930", VA = "0x18835EF30", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x835F030", Offset = "0x835DA30", VA = "0x18835F030", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x835F0A0", Offset = "0x835DAA0", VA = "0x18835F0A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HKMEMMAJEDP : AFBFFIIEDDJ<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CLLJHGGOCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CLLJHGGOCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x835AA10", Offset = "0x8359410", VA = "0x18835AA10")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x835AC50", Offset = "0x8359650", VA = "0x18835AC50")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x835B050", Offset = "0x8359A50", VA = "0x18835B050")]
		internal void OOOHENADHEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x835AAF0", Offset = "0x83594F0", VA = "0x18835AAF0")]
		internal void AFNIJBKPGGF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x835AE50", Offset = "0x8359850", VA = "0x18835AE50")]
		internal void KBEIFJPCBBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x835ABA0", Offset = "0x83595A0", VA = "0x18835ABA0")]
		internal void BKMCGABCFFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x835ADA0", Offset = "0x83597A0", VA = "0x18835ADA0")]
		internal void KAGPHNDDHBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x835AF00", Offset = "0x8359900", VA = "0x18835AF00")]
		internal void KECLEFKOLNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x835AD00", Offset = "0x8359700", VA = "0x18835AD00")]
		internal void DNBJICKCHPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x835AFB0", Offset = "0x83599B0", VA = "0x18835AFB0")]
		internal void MMHHFGIJLEF(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MAMLNIDGIOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x835C890", Offset = "0x835B290", VA = "0x18835C890", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, AnchorParamsRestrictions EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x835C3F0", Offset = "0x835ADF0", VA = "0x18835C3F0", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, AnchorParamsRestrictions KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x835CDB0", Offset = "0x835B7B0", VA = "0x18835CDB0")]
	public HKMEMMAJEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE4B0", Offset = "0x3DCCEB0", VA = "0x183DCE4B0")]
	[CompilerGenerated]
	internal static void DKKIDKKMCIF<T>(string BIHHMEFECFM, T MKDEBCJNKCE, T PNCJLBECKOB, MAMLNIDGIOI P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BINEGNBCIBE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private delegate void FFGIHEJNLAM(Utf8JsonReader OLMEHKPIJHD);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BGEDJNAOGHG
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
		public BINEGNBCIBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FFGIHEJNLAM <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FFGIHEJNLAM <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FFGIHEJNLAM <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FFGIHEJNLAM <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FFGIHEJNLAM <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FFGIHEJNLAM <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FFGIHEJNLAM <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FFGIHEJNLAM <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FFGIHEJNLAM <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FFGIHEJNLAM <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FFGIHEJNLAM <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BGEDJNAOGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8359280", Offset = "0x8357C80", VA = "0x188359280")]
		internal void GLIBPIPNEGB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8359470", Offset = "0x8357E70", VA = "0x188359470")]
		internal void LGNEEDLBFFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83593C0", Offset = "0x8357DC0", VA = "0x1883593C0")]
		internal void KBGCJJPHLBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83591D0", Offset = "0x8357BD0", VA = "0x1883591D0")]
		internal void EMMPNCABPPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83592C0", Offset = "0x8357CC0", VA = "0x1883592C0")]
		internal void IODOIMJKLJP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8359560", Offset = "0x8357F60", VA = "0x188359560")]
		internal void ODKLPKGEBMO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8359150", Offset = "0x8357B50", VA = "0x188359150")]
		internal void EFDHJPOPHED(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8359590", Offset = "0x8357F90", VA = "0x188359590")]
		internal void PLAFNDAGIEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8359520", Offset = "0x8357F20", VA = "0x188359520")]
		internal void LGOAOBOHEFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83590B0", Offset = "0x8357AB0", VA = "0x1883590B0")]
		internal void DMMKOKHNAOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8359370", Offset = "0x8357D70", VA = "0x188359370")]
		internal void JNIDLEGKIGC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JHBHOBLPLLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JHBHOBLPLLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x835DC70", Offset = "0x835C670", VA = "0x18835DC70")]
		internal void KIFEGBBPKCI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8359950", Offset = "0x8358350", VA = "0x188359950", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x835A550", Offset = "0x8358F50", VA = "0x18835A550", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, SerializedAvatarItemData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8359670", Offset = "0x8358070", VA = "0x188359670")]
	private AdditionalOutfitTypeData CJJKANOLONB(Utf8JsonReader DIKMKPGIBMB, OutfitType DGNODDPLLPC, JsonSerializerOptions ALFCEIKBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x835A990", Offset = "0x8359390", VA = "0x18835A990")]
	public BINEGNBCIBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LEMPLKMLIEH : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x835E0A0", Offset = "0x835CAA0", VA = "0x18835E0A0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DIKMKPGIBMB, Type INNODLOAIOD, JsonSerializerOptions ALFCEIKBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x835E430", Offset = "0x835CE30", VA = "0x18835E430", Slot = "28")]
	public override void Write(Utf8JsonWriter EAPDKLFLMNB, AvatarItemDownloadableConfig KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x835E560", Offset = "0x835CF60", VA = "0x18835E560")]
	public LEMPLKMLIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ALBGGEKIMKO : AFBFFIIEDDJ<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8358100", Offset = "0x8356B00", VA = "0x188358100", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, BeardData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8358040", Offset = "0x8356A40", VA = "0x188358040", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, BeardData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83582A0", Offset = "0x8356CA0", VA = "0x1883582A0")]
	public ALBGGEKIMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MDMIKGLEPMN : KKBJCOMPDIJ<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x835E630", Offset = "0x835D030", VA = "0x18835E630")]
	public MDMIKGLEPMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HNENCFDCGDE : KKBJCOMPDIJ<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x835CDF0", Offset = "0x835B7F0", VA = "0x18835CDF0")]
	public HNENCFDCGDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EFIBJMJOPCO : KKBJCOMPDIJ<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x835B360", Offset = "0x8359D60", VA = "0x18835B360")]
	public EFIBJMJOPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HJMJCPBHHCB : PJBJGPFNOCA<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x835C3B0", Offset = "0x835ADB0", VA = "0x18835C3B0")]
	public HJMJCPBHHCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KFEDDDKOBBB : AFBFFIIEDDJ<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HPKOFKEPIIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HPKOFKEPIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x835C2B0", Offset = "0x835ACB0", VA = "0x18835C2B0")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x835CE30", Offset = "0x835B830", VA = "0x18835CE30")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x835DED0", Offset = "0x835C8D0", VA = "0x18835DED0", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, AdditionalFeetData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x835DE00", Offset = "0x835C800", VA = "0x18835DE00", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, AdditionalFeetData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x835E060", Offset = "0x835CA60", VA = "0x18835E060")]
	public KFEDDDKOBBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IECKCOEEFPA : AFBFFIIEDDJ<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HJMIJHOCMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HJMIJHOCMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x835C200", Offset = "0x835AC00", VA = "0x18835C200")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x835C1D0", Offset = "0x835ABD0", VA = "0x18835C1D0")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x835C380", Offset = "0x835AD80", VA = "0x18835C380")]
		internal void OOOHENADHEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x835C090", Offset = "0x835AA90", VA = "0x18835C090")]
		internal void AFNIJBKPGGF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x835C2E0", Offset = "0x835ACE0", VA = "0x18835C2E0")]
		internal void KBEIFJPCBBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x835C130", Offset = "0x835AB30", VA = "0x18835C130")]
		internal void BKMCGABCFFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x835C2B0", Offset = "0x835ACB0", VA = "0x18835C2B0")]
		internal void KAGPHNDDHBI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x835D140", Offset = "0x835BB40", VA = "0x18835D140", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, HairData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x835CE60", Offset = "0x835B860", VA = "0x18835CE60", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, HairData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x835D530", Offset = "0x835BF30", VA = "0x18835D530")]
	public IECKCOEEFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EHGIHDMBMEO : AFBFFIIEDDJ<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IICEALGJHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IICEALGJHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x835AAC0", Offset = "0x83594C0", VA = "0x18835AAC0")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x835D920", Offset = "0x835C320", VA = "0x18835D920")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x835DBC0", Offset = "0x835C5C0", VA = "0x18835DBC0")]
		internal void OOOHENADHEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x835D7D0", Offset = "0x835C1D0", VA = "0x18835D7D0")]
		internal void AFNIJBKPGGF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x835DA70", Offset = "0x835C470", VA = "0x18835DA70")]
		internal void KBEIFJPCBBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x835D880", Offset = "0x835C280", VA = "0x18835D880")]
		internal void BKMCGABCFFK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x835D9D0", Offset = "0x835C3D0", VA = "0x18835D9D0")]
		internal void KAGPHNDDHBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x835DB20", Offset = "0x835C520", VA = "0x18835DB20")]
		internal void KECLEFKOLNF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x835B6F0", Offset = "0x835A0F0", VA = "0x18835B6F0", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, AdditionalHatData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x835B3A0", Offset = "0x8359DA0", VA = "0x18835B3A0", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, AdditionalHatData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x835BB50", Offset = "0x835A550", VA = "0x18835BB50")]
	public EHGIHDMBMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MJACJIPFJBD : AFBFFIIEDDJ<RoomieEquipmentData>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BOCPHHKPINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieEquipmentData item;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BOCPHHKPINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x835AAC0", Offset = "0x83594C0", VA = "0x18835AAC0")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x835E670", Offset = "0x835D070", VA = "0x18835E670", Slot = "35")]
	protected override void EEPDCJGOOBD(RoomieEquipmentData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x835E7B0", Offset = "0x835D1B0", VA = "0x18835E7B0", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, RoomieEquipmentData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x835E720", Offset = "0x835D120", VA = "0x18835E720", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, RoomieEquipmentData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x835E980", Offset = "0x835D380", VA = "0x18835E980")]
	public MJACJIPFJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AFGOKIFPIPJ : AFBFFIIEDDJ<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OLEKNGHPLKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OLEKNGHPLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x835AA10", Offset = "0x8359410", VA = "0x18835AA10")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x835A9D0", Offset = "0x83593D0", VA = "0x18835A9D0")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8357D60", Offset = "0x8356760", VA = "0x188357D60", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, RoomieEyeData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8357CD0", Offset = "0x83566D0", VA = "0x188357CD0", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, RoomieEyeData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8357EF0", Offset = "0x83568F0", VA = "0x188357EF0")]
	public AFGOKIFPIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EJKIMDFLCOM : AFBFFIIEDDJ<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FFDHBBJJAID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FFDHBBJJAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x835AA10", Offset = "0x8359410", VA = "0x18835AA10")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x835A9D0", Offset = "0x83593D0", VA = "0x18835A9D0")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x835BEC0", Offset = "0x835A8C0", VA = "0x18835BEC0")]
		internal void OOOHENADHEB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x835BC90", Offset = "0x835A690", VA = "0x18835BC90", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, RoomieHatData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x835BB90", Offset = "0x835A590", VA = "0x18835BB90", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, RoomieHatData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x835BE80", Offset = "0x835A880", VA = "0x18835BE80")]
	public EJKIMDFLCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DEEKEFILJHP : AFBFFIIEDDJ<RoomieMouthData>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BNAHIAOAOFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public RoomieMouthData item;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BNAHIAOAOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x835AA10", Offset = "0x8359410", VA = "0x18835AA10")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x835A9D0", Offset = "0x83593D0", VA = "0x18835A9D0")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x835B190", Offset = "0x8359B90", VA = "0x18835B190", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, RoomieMouthData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x835B100", Offset = "0x8359B00", VA = "0x18835B100", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, RoomieMouthData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x835B320", Offset = "0x8359D20", VA = "0x18835B320")]
	public DEEKEFILJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IGJJNOKGNGL : AFBFFIIEDDJ<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class COFAMFEPMPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public COFAMFEPMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x835AA10", Offset = "0x8359410", VA = "0x18835AA10")]
		internal void IEGFEIPFLJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x835A9D0", Offset = "0x83593D0", VA = "0x18835A9D0")]
		internal void COGLLKLNPFF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x835D600", Offset = "0x835C000", VA = "0x18835D600", Slot = "37")]
	public override void NAPCMPLIHCP(Utf8JsonReader DIKMKPGIBMB, JsonSerializerOptions ALFCEIKBPNG, string BIHHMEFECFM, RoomieWaistData EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x835D570", Offset = "0x835BF70", VA = "0x18835D570", Slot = "38")]
	public override void JBEGEHILINA(Utf8JsonWriter EAPDKLFLMNB, RoomieWaistData KMAFNKGMDCF, JsonSerializerOptions ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x835D790", Offset = "0x835C190", VA = "0x18835D790")]
	public IGJJNOKGNGL()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xF915E0", Offset = "0xF8FFE0", VA = "0x180F915E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF915F0", Offset = "0xF8FFF0", VA = "0x180F915F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C80", Offset = "0x10D3680", VA = "0x1810D4C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x10D4BF0", Offset = "0x10D35F0", VA = "0x1810D4BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x22ED140", Offset = "0x22EBB40", VA = "0x1822ED140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x835EE80", Offset = "0x835D880", VA = "0x18835EE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2FC87E0", Offset = "0x2FC71E0", VA = "0x182FC87E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2FC8660", Offset = "0x2FC7060", VA = "0x182FC8660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAFBBF0", Offset = "0xAFA5F0", VA = "0x180AFBBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAFBC00", Offset = "0xAFA600", VA = "0x180AFBC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HLHFIFHEPCK.LFIDLNGOLDF ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			[CompilerGenerated]
			get
			{
				return default(HLHFIFHEPCK.LFIDLNGOLDF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x835E9F0", Offset = "0x835D3F0", VA = "0x18835E9F0", Slot = "0")]
		public override bool Equals(object GOCNHGEHNFD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x835EE60", Offset = "0x835D860", VA = "0x18835EE60")]
		public static bool NOPNAEDOCOI(SerializedAvatarItemData IIIICGAEODJ, SerializedAvatarItemData ELBIKJBAIEA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x835E9C0", Offset = "0x835D3C0", VA = "0x18835E9C0")]
		public static bool DFNINOIAFHB(SerializedAvatarItemData IIIICGAEODJ, SerializedAvatarItemData ELBIKJBAIEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x835EA70", Offset = "0x835D470", VA = "0x18835EA70", Slot = "4")]
		public bool Equals(SerializedAvatarItemData GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x835ED90", Offset = "0x835D790", VA = "0x18835ED90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
