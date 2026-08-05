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
public class NEIAEPIPBKE : JFPEEGOPLEO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CB250", Offset = "0x8CA450", VA = "0x1808CB250", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67A2A40", Offset = "0x67A1C40", VA = "0x1867A2A40", Slot = "36")]
	protected override Vector3 KKPICIHMFNP(float[] MNHECFLLMJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67A2A90", Offset = "0x67A1C90", VA = "0x1867A2A90", Slot = "37")]
	protected override float[] MCENKMDFCLO(Vector3 JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67A2B10", Offset = "0x67A1D10", VA = "0x1867A2B10")]
	public NEIAEPIPBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HJIIGPLOBPF : JFPEEGOPLEO<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CA010", Offset = "0x8C9210", VA = "0x1808CA010", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67A1AB0", Offset = "0x67A0CB0", VA = "0x1867A1AB0", Slot = "36")]
	protected override Vector2 KKPICIHMFNP(float[] MNHECFLLMJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67A1AF0", Offset = "0x67A0CF0", VA = "0x1867A1AF0", Slot = "37")]
	protected override float[] MCENKMDFCLO(Vector2 JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67A1B60", Offset = "0x67A0D60", VA = "0x1867A1B60")]
	public HJIIGPLOBPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MMOAIDBMGDL : JFPEEGOPLEO<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD50", Offset = "0x8C9F50", VA = "0x1808CAD50", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67A2910", Offset = "0x67A1B10", VA = "0x1867A2910", Slot = "36")]
	protected override Quaternion KKPICIHMFNP(float[] MNHECFLLMJH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67A2970", Offset = "0x67A1B70", VA = "0x1867A2970", Slot = "37")]
	protected override float[] MCENKMDFCLO(Quaternion JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67A2A00", Offset = "0x67A1C00", VA = "0x1867A2A00")]
	public MMOAIDBMGDL()
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
		public enum OGMCLJGANHN
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
		public OGMCLJGANHN Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8513A0", VA = "0x1808521A0")]
			[CompilerGenerated]
			get
			{
				return default(OGMCLJGANHN);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851B10", VA = "0x180852910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851A90", VA = "0x180852890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x920B40", Offset = "0x91FD40", VA = "0x180920B40")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DOKIGBEJODG : FNDCECLGCKD<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FJAJHKBKCKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public FJAJHKBKCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67A19C0", Offset = "0x67A0BC0", VA = "0x1867A19C0")]
		internal void OCALIDCPPMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67A1460", Offset = "0x67A0660", VA = "0x1867A1460")]
		internal void BNJCAPAPMOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67A13B0", Offset = "0x67A05B0", VA = "0x1867A13B0")]
		internal void ADHGIOCKEJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67A1510", Offset = "0x67A0710", VA = "0x1867A1510")]
		internal void CKIFOPHBHBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67A1710", Offset = "0x67A0910", VA = "0x1867A1710")]
		internal void GMLJJNGJHOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67A15C0", Offset = "0x67A07C0", VA = "0x1867A15C0")]
		internal void FNCLIIDCKJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67A17C0", Offset = "0x67A09C0", VA = "0x1867A17C0")]
		internal void JBBIDOIDDLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67A1910", Offset = "0x67A0B10", VA = "0x1867A1910")]
		internal void NCGEMEIBAFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67A1870", Offset = "0x67A0A70", VA = "0x1867A1870")]
		internal void JNCEKICKPIG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67A1670", Offset = "0x67A0870", VA = "0x1867A1670")]
		internal void GAKOOLOCHLP(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LPABJFFBHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x679FF80", Offset = "0x679F180", VA = "0x18679FF80", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, AnchorParamsRestrictions JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67A04A0", Offset = "0x679F6A0", VA = "0x1867A04A0", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, AnchorParamsRestrictions JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67A0940", Offset = "0x679FB40", VA = "0x1867A0940")]
	public DOKIGBEJODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x298E150", Offset = "0x298D350", VA = "0x18298E150")]
	[CompilerGenerated]
	internal static void CMHHAIALNLO<T>(string LMFCCDBJMHJ, T GPBAFILNEOM, T EGNEHDMGCGA, LPABJFFBHPJ P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CJACGMHJKCE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void BNCFAKKEMMK(Utf8JsonReader DLFEHJOHIIJ);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IHMKOENFCED
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
		public CJACGMHJKCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BNCFAKKEMMK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BNCFAKKEMMK <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public BNCFAKKEMMK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BNCFAKKEMMK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BNCFAKKEMMK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BNCFAKKEMMK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public BNCFAKKEMMK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BNCFAKKEMMK <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BNCFAKKEMMK <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BNCFAKKEMMK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BNCFAKKEMMK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BNCFAKKEMMK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BNCFAKKEMMK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BNCFAKKEMMK <>9__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BNCFAKKEMMK <>9__14;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IHMKOENFCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67A1F90", Offset = "0x67A1190", VA = "0x1867A1F90")]
		internal void HCKJIDACNCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67A1BE0", Offset = "0x67A0DE0", VA = "0x1867A1BE0")]
		internal void AFPLKFIFNCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67A2310", Offset = "0x67A1510", VA = "0x1867A2310")]
		internal void OOKFLLJHMCL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67A1C80", Offset = "0x67A0E80", VA = "0x1867A1C80")]
		internal void DEKICBCKKPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67A2230", Offset = "0x67A1430", VA = "0x1867A2230")]
		internal void LLMPHBPJKEE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67A2180", Offset = "0x67A1380", VA = "0x1867A2180")]
		internal void LCIKIPMAHDB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67A1E40", Offset = "0x67A1040", VA = "0x1867A1E40")]
		internal void GFAJLAHJAEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67A1C10", Offset = "0x67A0E10", VA = "0x1867A1C10")]
		internal void AKOFPOADBPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67A1D30", Offset = "0x67A0F30", VA = "0x1867A1D30")]
		internal void DEPCDAGHPOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67A22E0", Offset = "0x67A14E0", VA = "0x1867A22E0")]
		internal void MDJNPFHBEOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67A1FD0", Offset = "0x67A11D0", VA = "0x1867A1FD0")]
		internal void HPCDOCJOCOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67A1D60", Offset = "0x67A0F60", VA = "0x1867A1D60")]
		internal void FBDKNJEPNHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67A1C40", Offset = "0x67A0E40", VA = "0x1867A1C40")]
		internal void CHFGGFHBJLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67A1EF0", Offset = "0x67A10F0", VA = "0x1867A1EF0")]
		internal void GFPNKJNEGAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67A2050", Offset = "0x67A1250", VA = "0x1867A2050")]
		internal void JNPFJMIFFLH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x679EF70", Offset = "0x679E170", VA = "0x18679EF70", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x679FA70", Offset = "0x679EC70", VA = "0x18679FA70", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, SerializedAvatarItemData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x679EE50", Offset = "0x679E050", VA = "0x18679EE50")]
	private AdditionalOutfitTypeData MPFFMHGNANA(Utf8JsonReader ELOKBGPKALP, OutfitType NCMHJNKFAGH, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x679FF40", Offset = "0x679F140", VA = "0x18679FF40")]
	public CJACGMHJKCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PCCBEMGLCMK : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67A3340", Offset = "0x67A2540", VA = "0x1867A3340", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67A36B0", Offset = "0x67A28B0", VA = "0x1867A36B0", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, AvatarItemDownloadableConfig JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67A37A0", Offset = "0x67A29A0", VA = "0x1867A37A0")]
	public PCCBEMGLCMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CEICPFKOFLP : FNDCECLGCKD<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x679EBB0", Offset = "0x679DDB0", VA = "0x18679EBB0", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, BeardData JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x679ED50", Offset = "0x679DF50", VA = "0x18679ED50", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, BeardData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x679EE10", Offset = "0x679E010", VA = "0x18679EE10")]
	public CEICPFKOFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IFPLOPPDBBO : GJEBJFOHKBB<IDDBFDIIBIC>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67A1BA0", Offset = "0x67A0DA0", VA = "0x1867A1BA0")]
	public IFPLOPPDBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HDMJFNACDGE : GJEBJFOHKBB<NEPMABKJNOA>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67A1A70", Offset = "0x67A0C70", VA = "0x1867A1A70")]
	public HDMJFNACDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGJLEKJHCOM : GJEBJFOHKBB<DOLODLAIBPC>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67A28D0", Offset = "0x67A1AD0", VA = "0x1867A28D0")]
	public LGJLEKJHCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KHKHPOHEJAJ : HLIGMJABDBM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67A2890", Offset = "0x67A1A90", VA = "0x1867A2890")]
	public KHKHPOHEJAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EGCMHFPGCNL : FNDCECLGCKD<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FFBLLDNKOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public FFBLLDNKOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67A1300", Offset = "0x67A0500", VA = "0x1867A1300")]
		internal void OCALIDCPPMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67A10C0", Offset = "0x67A02C0", VA = "0x1867A10C0")]
		internal void BNJCAPAPMOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67A1090", Offset = "0x67A0290", VA = "0x1867A1090")]
		internal void ADHGIOCKEJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67A10F0", Offset = "0x67A02F0", VA = "0x1867A10F0")]
		internal void CKIFOPHBHBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67A1230", Offset = "0x67A0430", VA = "0x1867A1230")]
		internal void GMLJJNGJHOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67A1190", Offset = "0x67A0390", VA = "0x1867A1190")]
		internal void FNCLIIDCKJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67A12D0", Offset = "0x67A04D0", VA = "0x1867A12D0")]
		internal void JBBIDOIDDLI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67A0980", Offset = "0x679FB80", VA = "0x1867A0980", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, HairData JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67A0D70", Offset = "0x679FF70", VA = "0x1867A0D70", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, HairData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67A1050", Offset = "0x67A0250", VA = "0x1867A1050")]
	public EGCMHFPGCNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OGJJNCNAAOA : FNDCECLGCKD<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JJNBNLFPOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JJNBNLFPOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67A2860", Offset = "0x67A1A60", VA = "0x1867A2860")]
		internal void OCALIDCPPMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67A2470", Offset = "0x67A1670", VA = "0x1867A2470")]
		internal void BNJCAPAPMOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67A23C0", Offset = "0x67A15C0", VA = "0x1867A23C0")]
		internal void ADHGIOCKEJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x67A2520", Offset = "0x67A1720", VA = "0x1867A2520")]
		internal void CKIFOPHBHBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67A2670", Offset = "0x67A1870", VA = "0x1867A2670")]
		internal void GMLJJNGJHOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67A25D0", Offset = "0x67A17D0", VA = "0x1867A25D0")]
		internal void FNCLIIDCKJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67A2720", Offset = "0x67A1920", VA = "0x1867A2720")]
		internal void JBBIDOIDDLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67A27C0", Offset = "0x67A19C0", VA = "0x1867A27C0")]
		internal void NCGEMEIBAFM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67A2B50", Offset = "0x67A1D50", VA = "0x1867A2B50", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, AdditionalHatData JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67A2FB0", Offset = "0x67A21B0", VA = "0x1867A2FB0", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, AdditionalHatData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67A3300", Offset = "0x67A2500", VA = "0x1867A3300")]
	public OGJJNCNAAOA()
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8522F0", VA = "0x1808530F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x860150", VA = "0x180860F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851A70", VA = "0x180852870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E540", Offset = "0xA6D740", VA = "0x180A6E540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB43490", Offset = "0xB42690", VA = "0x180B43490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xDDC420", Offset = "0xDDB620", VA = "0x180DDC420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDDB100", Offset = "0xDDA300", VA = "0x180DDB100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1ED16D0", Offset = "0x1ED08D0", VA = "0x181ED16D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1ED16E0", Offset = "0x1ED08E0", VA = "0x181ED16E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x14003F0", Offset = "0x13FF5F0", VA = "0x1814003F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67A37E0", Offset = "0x67A29E0", VA = "0x1867A37E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2307DA0", Offset = "0x2306FA0", VA = "0x182307DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2307CE0", Offset = "0x2306EE0", VA = "0x182307CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B27970", Offset = "0x1B26B70", VA = "0x181B27970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B279A0", Offset = "0x1B26BA0", VA = "0x181B279A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDBBDB0", Offset = "0xDBAFB0", VA = "0x180DBBDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDDECF0", Offset = "0xDDDEF0", VA = "0x180DDECF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GPNFJCLHKIK ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9200E0", Offset = "0x91F2E0", VA = "0x1809200E0")]
			[CompilerGenerated]
			get
			{
				return default(GPNFJCLHKIK);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB00E70", Offset = "0xB00070", VA = "0x180B00E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DPBKAJAMMON.JBNKIJKKBDP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB01470", Offset = "0xB00670", VA = "0x180B01470")]
			[CompilerGenerated]
			get
			{
				return default(DPBKAJAMMON.JBNKIJKKBDP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x145D3E0", Offset = "0x145C5E0", VA = "0x18145D3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x855500", VA = "0x180856300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x8554F0", VA = "0x1808562F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC36B40", Offset = "0xC35D40", VA = "0x180C36B40")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x138C180", Offset = "0x138B380", VA = "0x18138C180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1054680", Offset = "0x1053880", VA = "0x181054680")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x414C280", Offset = "0x414B480", VA = "0x18414C280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
