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
public class HPAAIKFAIBK : DDNAOLIBDMH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC64BF0", Offset = "0xC637F0", VA = "0x180C64BF0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C43E80", Offset = "0x7C42A80", VA = "0x187C43E80", Slot = "36")]
	protected override Vector3 MIBHOBGDAEB(float[] AIPJHMCGMIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C43E00", Offset = "0x7C42A00", VA = "0x187C43E00", Slot = "37")]
	protected override float[] DCHGJGHKDIF(Vector3 OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C43ED0", Offset = "0x7C42AD0", VA = "0x187C43ED0")]
	public HPAAIKFAIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BPIIEICBAJB : DDNAOLIBDMH<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC78550", Offset = "0xC77150", VA = "0x180C78550", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C40930", Offset = "0x7C3F530", VA = "0x187C40930", Slot = "36")]
	protected override Vector2 MIBHOBGDAEB(float[] AIPJHMCGMIB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C408C0", Offset = "0x7C3F4C0", VA = "0x187C408C0", Slot = "37")]
	protected override float[] DCHGJGHKDIF(Vector2 OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C40970", Offset = "0x7C3F570", VA = "0x187C40970")]
	public BPIIEICBAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class APABGKKKFCH : DDNAOLIBDMH<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xADBBB0", Offset = "0xADA7B0", VA = "0x180ADBBB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FB90", Offset = "0x7C3E790", VA = "0x187C3FB90", Slot = "36")]
	protected override Quaternion MIBHOBGDAEB(float[] AIPJHMCGMIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FB00", Offset = "0x7C3E700", VA = "0x187C3FB00", Slot = "37")]
	protected override float[] DCHGJGHKDIF(Quaternion OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FBF0", Offset = "0x7C3E7F0", VA = "0x187C3FBF0")]
	public APABGKKKFCH()
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
		public enum EFDJMMPNCGO
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
		public EFDJMMPNCGO Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
			[CompilerGenerated]
			get
			{
				return default(EFDJMMPNCGO);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C3FC30", Offset = "0x7C3E830", VA = "0x187C3FC30", Slot = "0")]
		public override bool Equals(object GMNGNCHKEBK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C3FEA0", Offset = "0x7C3EAA0", VA = "0x187C3FEA0")]
		public static bool JOHLOKGLNML(AvatarItemDownloadableConfig NAHMIIJKKEL, AvatarItemDownloadableConfig IJNKBHOINCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C3FD60", Offset = "0x7C3E960", VA = "0x187C3FD60", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C3FE30", Offset = "0x7C3EA30", VA = "0x187C3FE30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF8A0A0", Offset = "0xF88CA0", VA = "0x180F8A0A0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, BFLKHIBEHMF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7C45C80", Offset = "0x7C44880", VA = "0x187C45C80")]
		private void LDFFPCPFJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C45B00", Offset = "0x7C44700", VA = "0x187C45B00", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C45B80", Offset = "0x7C44780", VA = "0x187C45B80", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C80", Offset = "0x7C44880", VA = "0x187C45C80", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C45CF0", Offset = "0x7C448F0", VA = "0x187C45CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CDKFCPBENJD : KAOBLLBKEJN<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DKHOHIBBBHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DKHOHIBBBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C42C40", Offset = "0x7C41840", VA = "0x187C42C40")]
		internal void HBONFOEFGOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C42EF0", Offset = "0x7C41AF0", VA = "0x187C42EF0")]
		internal void NFNIKMJOBCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C42E40", Offset = "0x7C41A40", VA = "0x187C42E40")]
		internal void NFHHKPDNNEP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C42FA0", Offset = "0x7C41BA0", VA = "0x187C42FA0")]
		internal void OBLJMJMDHCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C42A40", Offset = "0x7C41640", VA = "0x187C42A40")]
		internal void BGDOLNFPBKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C42CF0", Offset = "0x7C418F0", VA = "0x187C42CF0")]
		internal void KEAHADJIBGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C42B90", Offset = "0x7C41790", VA = "0x187C42B90")]
		internal void GOODFOPJEEC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C43050", Offset = "0x7C41C50", VA = "0x187C43050")]
		internal void PMDECMFFCOA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C42DA0", Offset = "0x7C419A0", VA = "0x187C42DA0")]
		internal void MADMLDGDJKI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C42AF0", Offset = "0x7C416F0", VA = "0x187C42AF0")]
		internal void GCLFDGCPKJH(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HDHECPIKCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C409B0", Offset = "0x7C3F5B0", VA = "0x187C409B0", Slot = "35")]
	public override void JIAAMFBNKCF(Utf8JsonReader EENAIFHJAJK, JsonSerializerOptions LEKHKJDBHCI, string HGJNKBHNLKN, AnchorParamsRestrictions ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C40ED0", Offset = "0x7C3FAD0", VA = "0x187C40ED0", Slot = "36")]
	public override void LPNDGAKPJGL(Utf8JsonWriter JKKEKKKNJIN, AnchorParamsRestrictions OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C41360", Offset = "0x7C3FF60", VA = "0x187C41360")]
	public CDKFCPBENJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38960F0", Offset = "0x3894CF0", VA = "0x1838960F0")]
	[CompilerGenerated]
	internal static void GEMHLCFKAGN<T>(string HGJNKBHNLKN, T AGKJLFOJIKC, T LJDCGJPOMFP, HDHECPIKCGB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DIBJKACCAFF : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void KLAHCKHEFGA(Utf8JsonReader DGCKGHIBLHO);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GCFFFIAJKPL
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
		public DIBJKACCAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KLAHCKHEFGA <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KLAHCKHEFGA <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KLAHCKHEFGA <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KLAHCKHEFGA <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KLAHCKHEFGA <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KLAHCKHEFGA <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KLAHCKHEFGA <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KLAHCKHEFGA <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KLAHCKHEFGA <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KLAHCKHEFGA <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KLAHCKHEFGA <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GCFFFIAJKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C436C0", Offset = "0x7C422C0", VA = "0x187C436C0")]
		internal void LINCIMPOFJO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C432C0", Offset = "0x7C41EC0", VA = "0x187C432C0")]
		internal void CALBDIKAJNE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C43700", Offset = "0x7C42300", VA = "0x187C43700")]
		internal void MCJLDMJGKDP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C43560", Offset = "0x7C42160", VA = "0x187C43560")]
		internal void JGMNEBCMDKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C43610", Offset = "0x7C42210", VA = "0x187C43610")]
		internal void KCPGJBOBONB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C433B0", Offset = "0x7C41FB0", VA = "0x187C433B0")]
		internal void EBHEBDJANIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C437B0", Offset = "0x7C423B0", VA = "0x187C437B0")]
		internal void NJNIDAHADLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C43480", Offset = "0x7C42080", VA = "0x187C43480")]
		internal void IODJJANDAJI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7C43370", Offset = "0x7C41F70", VA = "0x187C43370")]
		internal void DPGMLDNCEBM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C433E0", Offset = "0x7C41FE0", VA = "0x187C433E0")]
		internal void FPJLCJILPNC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C43140", Offset = "0x7C41D40", VA = "0x187C43140")]
		internal void BLMHPBMJEOO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BELHNMIGGLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BELHNMIGGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C40820", Offset = "0x7C3F420", VA = "0x187C40820")]
		internal void IDDCIDMIIAI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C419E0", Offset = "0x7C405E0", VA = "0x187C419E0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C425C0", Offset = "0x7C411C0", VA = "0x187C425C0", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, SerializedAvatarItemData OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C41870", Offset = "0x7C40470", VA = "0x187C41870")]
	private AdditionalOutfitTypeData NGOJCCGHEMD(Utf8JsonReader EENAIFHJAJK, OutfitType OPOPAMPKKGD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C42A00", Offset = "0x7C41600", VA = "0x187C42A00")]
	public DIBJKACCAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MMPHFFEKCAB : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C44E70", Offset = "0x7C43A70", VA = "0x187C44E70", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader EENAIFHJAJK, Type ACECCBFELHD, JsonSerializerOptions LEKHKJDBHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C45200", Offset = "0x7C43E00", VA = "0x187C45200", Slot = "28")]
	public override void Write(Utf8JsonWriter JKKEKKKNJIN, AvatarItemDownloadableConfig OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C45330", Offset = "0x7C43F30", VA = "0x187C45330")]
	public MMPHFFEKCAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NCHODIHHGKB : KAOBLLBKEJN<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C45370", Offset = "0x7C43F70", VA = "0x187C45370", Slot = "35")]
	public override void JIAAMFBNKCF(Utf8JsonReader EENAIFHJAJK, JsonSerializerOptions LEKHKJDBHCI, string HGJNKBHNLKN, BeardData ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C45510", Offset = "0x7C44110", VA = "0x187C45510", Slot = "36")]
	public override void LPNDGAKPJGL(Utf8JsonWriter JKKEKKKNJIN, BeardData OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C455D0", Offset = "0x7C441D0", VA = "0x187C455D0")]
	public NCHODIHHGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MIKBBHDELNH : COECDCGMKKC<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C44E30", Offset = "0x7C43A30", VA = "0x187C44E30")]
	public MIKBBHDELNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LHNOHONJMLP : COECDCGMKKC<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C446F0", Offset = "0x7C432F0", VA = "0x187C446F0")]
	public LHNOHONJMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HBCAANNIFFI : COECDCGMKKC<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C43B20", Offset = "0x7C42720", VA = "0x187C43B20")]
	public HBCAANNIFFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DPEOMBFHJEM : MGFDGJINEOH<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C43100", Offset = "0x7C41D00", VA = "0x187C43100")]
	public DPEOMBFHJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HEFFNDEEPOG : KAOBLLBKEJN<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BCLEDGJGFHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BCLEDGJGFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C407C0", Offset = "0x7C3F3C0", VA = "0x187C407C0")]
		internal void HBONFOEFGOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7C407F0", Offset = "0x7C3F3F0", VA = "0x187C407F0")]
		internal void NFNIKMJOBCA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C43B60", Offset = "0x7C42760", VA = "0x187C43B60", Slot = "35")]
	public override void JIAAMFBNKCF(Utf8JsonReader EENAIFHJAJK, JsonSerializerOptions LEKHKJDBHCI, string HGJNKBHNLKN, AdditionalFeetData ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C43CF0", Offset = "0x7C428F0", VA = "0x187C43CF0", Slot = "36")]
	public override void LPNDGAKPJGL(Utf8JsonWriter JKKEKKKNJIN, AdditionalFeetData OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C43DC0", Offset = "0x7C429C0", VA = "0x187C43DC0")]
	public HEFFNDEEPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LIJMPLEHMJJ : KAOBLLBKEJN<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GJOHKCDHAJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GJOHKCDHAJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C438D0", Offset = "0x7C424D0", VA = "0x187C438D0")]
		internal void HBONFOEFGOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C43A50", Offset = "0x7C42650", VA = "0x187C43A50")]
		internal void NFNIKMJOBCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C43A20", Offset = "0x7C42620", VA = "0x187C43A20")]
		internal void NFHHKPDNNEP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C43A80", Offset = "0x7C42680", VA = "0x187C43A80")]
		internal void OBLJMJMDHCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C43830", Offset = "0x7C42430", VA = "0x187C43830")]
		internal void BGDOLNFPBKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C43980", Offset = "0x7C42580", VA = "0x187C43980")]
		internal void KEAHADJIBGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C407C0", Offset = "0x7C3F3C0", VA = "0x187C407C0")]
		internal void GOODFOPJEEC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C44730", Offset = "0x7C43330", VA = "0x187C44730", Slot = "35")]
	public override void JIAAMFBNKCF(Utf8JsonReader EENAIFHJAJK, JsonSerializerOptions LEKHKJDBHCI, string HGJNKBHNLKN, HairData ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C44B20", Offset = "0x7C43720", VA = "0x187C44B20", Slot = "36")]
	public override void LPNDGAKPJGL(Utf8JsonWriter JKKEKKKNJIN, HairData OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C44DF0", Offset = "0x7C439F0", VA = "0x187C44DF0")]
	public LIJMPLEHMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KODENLKDGEJ : KAOBLLBKEJN<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CNECDHDNOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CNECDHDNOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C414F0", Offset = "0x7C400F0", VA = "0x187C414F0")]
		internal void HBONFOEFGOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C41670", Offset = "0x7C40270", VA = "0x187C41670")]
		internal void NFNIKMJOBCA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C415C0", Offset = "0x7C401C0", VA = "0x187C415C0")]
		internal void NFHHKPDNNEP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C41720", Offset = "0x7C40320", VA = "0x187C41720")]
		internal void OBLJMJMDHCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C413A0", Offset = "0x7C3FFA0", VA = "0x187C413A0")]
		internal void BGDOLNFPBKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C41520", Offset = "0x7C40120", VA = "0x187C41520")]
		internal void KEAHADJIBGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C41450", Offset = "0x7C40050", VA = "0x187C41450")]
		internal void GOODFOPJEEC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C417D0", Offset = "0x7C403D0", VA = "0x187C417D0")]
		internal void PMDECMFFCOA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C43F10", Offset = "0x7C42B10", VA = "0x187C43F10", Slot = "35")]
	public override void JIAAMFBNKCF(Utf8JsonReader EENAIFHJAJK, JsonSerializerOptions LEKHKJDBHCI, string HGJNKBHNLKN, AdditionalHatData ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C44370", Offset = "0x7C42F70", VA = "0x187C44370", Slot = "36")]
	public override void LPNDGAKPJGL(Utf8JsonWriter JKKEKKKNJIN, AdditionalHatData OOHGFGHCOAJ, JsonSerializerOptions LEKHKJDBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C446B0", Offset = "0x7C432B0", VA = "0x187C446B0")]
	public KODENLKDGEJ()
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
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA21F20", Offset = "0xA20B20", VA = "0x180A21F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB3BA30", Offset = "0xB3A630", VA = "0x180B3BA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE5F8B0", Offset = "0xE5E4B0", VA = "0x180E5F8B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xE5F8C0", Offset = "0xE5E4C0", VA = "0x180E5F8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFA1F60", Offset = "0xFA0B60", VA = "0x180FA1F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xFA2290", Offset = "0xFA0E90", VA = "0x180FA2290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2100B00", Offset = "0x20FF700", VA = "0x182100B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7C45AD0", Offset = "0x7C446D0", VA = "0x187C45AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2D46A00", Offset = "0x2D45600", VA = "0x182D46A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2D46AB0", Offset = "0x2D456B0", VA = "0x182D46AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA00", Offset = "0xA6A600", VA = "0x180A6BA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA10", Offset = "0xA6A610", VA = "0x180A6BA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IONAMLJCLBI.EPMFDMLBDCD ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
			[CompilerGenerated]
			get
			{
				return default(IONAMLJCLBI.EPMFDMLBDCD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6FE8BB0", Offset = "0x6FE77B0", VA = "0x186FE8BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6D0", Offset = "0xA1B2D0", VA = "0x180A1C6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C45610", Offset = "0x7C44210", VA = "0x187C45610", Slot = "0")]
		public override bool Equals(object GMNGNCHKEBK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AB0", Offset = "0x7C446B0", VA = "0x187C45AB0")]
		public static bool JOHLOKGLNML(SerializedAvatarItemData NAHMIIJKKEL, SerializedAvatarItemData IJNKBHOINCA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C459B0", Offset = "0x7C445B0", VA = "0x187C459B0")]
		public static bool FOFOJFKGMNN(SerializedAvatarItemData NAHMIIJKKEL, SerializedAvatarItemData IJNKBHOINCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C45690", Offset = "0x7C44290", VA = "0x187C45690", Slot = "4")]
		public bool Equals(SerializedAvatarItemData GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C459E0", Offset = "0x7C445E0", VA = "0x187C459E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
