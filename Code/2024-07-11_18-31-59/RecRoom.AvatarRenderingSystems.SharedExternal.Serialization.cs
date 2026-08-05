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
		[Cpp2IlInjected.Address(RVA = "0x8CB410", Offset = "0x8C9E10", VA = "0x1808CB410", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6788E30", Offset = "0x6787830", VA = "0x186788E30", Slot = "36")]
	protected override Vector3 KKPICIHMFNP(float[] MNHECFLLMJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6788E80", Offset = "0x6787880", VA = "0x186788E80", Slot = "37")]
	protected override float[] MCENKMDFCLO(Vector3 JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6788F00", Offset = "0x6787900", VA = "0x186788F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CA1D0", Offset = "0x8C8BD0", VA = "0x1808CA1D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6787EA0", Offset = "0x67868A0", VA = "0x186787EA0", Slot = "36")]
	protected override Vector2 KKPICIHMFNP(float[] MNHECFLLMJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6787EE0", Offset = "0x67868E0", VA = "0x186787EE0", Slot = "37")]
	protected override float[] MCENKMDFCLO(Vector2 JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6787F50", Offset = "0x6786950", VA = "0x186787F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CAF10", Offset = "0x8C9910", VA = "0x1808CAF10", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6788D00", Offset = "0x6787700", VA = "0x186788D00", Slot = "36")]
	protected override Quaternion KKPICIHMFNP(float[] MNHECFLLMJH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6788D60", Offset = "0x6787760", VA = "0x186788D60", Slot = "37")]
	protected override float[] MCENKMDFCLO(Quaternion JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6788DF0", Offset = "0x67877F0", VA = "0x186788DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
			[CompilerGenerated]
			get
			{
				return default(OGMCLJGANHN);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x91FD90", Offset = "0x91E790", VA = "0x18091FD90")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public FJAJHKBKCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6787DB0", Offset = "0x67867B0", VA = "0x186787DB0")]
		internal void OCALIDCPPMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6787850", Offset = "0x6786250", VA = "0x186787850")]
		internal void BNJCAPAPMOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67877A0", Offset = "0x67861A0", VA = "0x1867877A0")]
		internal void ADHGIOCKEJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6787900", Offset = "0x6786300", VA = "0x186787900")]
		internal void CKIFOPHBHBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6787B00", Offset = "0x6786500", VA = "0x186787B00")]
		internal void GMLJJNGJHOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67879B0", Offset = "0x67863B0", VA = "0x1867879B0")]
		internal void FNCLIIDCKJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6787BB0", Offset = "0x67865B0", VA = "0x186787BB0")]
		internal void JBBIDOIDDLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6787D00", Offset = "0x6786700", VA = "0x186787D00")]
		internal void NCGEMEIBAFM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6787C60", Offset = "0x6786660", VA = "0x186787C60")]
		internal void JNCEKICKPIG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6787A60", Offset = "0x6786460", VA = "0x186787A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6786370", Offset = "0x6784D70", VA = "0x186786370", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, AnchorParamsRestrictions JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6786890", Offset = "0x6785290", VA = "0x186786890", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, AnchorParamsRestrictions JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6786D30", Offset = "0x6785730", VA = "0x186786D30")]
	public DOKIGBEJODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x297FB60", Offset = "0x297E560", VA = "0x18297FB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IHMKOENFCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6788380", Offset = "0x6786D80", VA = "0x186788380")]
		internal void HCKJIDACNCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6787FD0", Offset = "0x67869D0", VA = "0x186787FD0")]
		internal void AFPLKFIFNCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6788700", Offset = "0x6787100", VA = "0x186788700")]
		internal void OOKFLLJHMCL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6788070", Offset = "0x6786A70", VA = "0x186788070")]
		internal void DEKICBCKKPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6788620", Offset = "0x6787020", VA = "0x186788620")]
		internal void LLMPHBPJKEE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6788570", Offset = "0x6786F70", VA = "0x186788570")]
		internal void LCIKIPMAHDB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6788230", Offset = "0x6786C30", VA = "0x186788230")]
		internal void GFAJLAHJAEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6788000", Offset = "0x6786A00", VA = "0x186788000")]
		internal void AKOFPOADBPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6788120", Offset = "0x6786B20", VA = "0x186788120")]
		internal void DEPCDAGHPOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67886D0", Offset = "0x67870D0", VA = "0x1867886D0")]
		internal void MDJNPFHBEOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67883C0", Offset = "0x6786DC0", VA = "0x1867883C0")]
		internal void HPCDOCJOCOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6788150", Offset = "0x6786B50", VA = "0x186788150")]
		internal void FBDKNJEPNHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6788030", Offset = "0x6786A30", VA = "0x186788030")]
		internal void CHFGGFHBJLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67882E0", Offset = "0x6786CE0", VA = "0x1867882E0")]
		internal void GFPNKJNEGAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6788440", Offset = "0x6786E40", VA = "0x186788440")]
		internal void JNPFJMIFFLH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6785360", Offset = "0x6783D60", VA = "0x186785360", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6785E60", Offset = "0x6784860", VA = "0x186785E60", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, SerializedAvatarItemData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6785240", Offset = "0x6783C40", VA = "0x186785240")]
	private AdditionalOutfitTypeData MPFFMHGNANA(Utf8JsonReader ELOKBGPKALP, OutfitType NCMHJNKFAGH, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6786330", Offset = "0x6784D30", VA = "0x186786330")]
	public CJACGMHJKCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PCCBEMGLCMK : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6789730", Offset = "0x6788130", VA = "0x186789730", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader ELOKBGPKALP, Type EHKFBNAKPCM, JsonSerializerOptions FDGBBGJEJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6789AA0", Offset = "0x67884A0", VA = "0x186789AA0", Slot = "28")]
	public override void Write(Utf8JsonWriter JLIOPEDCMBE, AvatarItemDownloadableConfig JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6789B90", Offset = "0x6788590", VA = "0x186789B90")]
	public PCCBEMGLCMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CEICPFKOFLP : FNDCECLGCKD<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6784FA0", Offset = "0x67839A0", VA = "0x186784FA0", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, BeardData JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6785140", Offset = "0x6783B40", VA = "0x186785140", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, BeardData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6785200", Offset = "0x6783C00", VA = "0x186785200")]
	public CEICPFKOFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IFPLOPPDBBO : GJEBJFOHKBB<IDDBFDIIBIC>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6787F90", Offset = "0x6786990", VA = "0x186787F90")]
	public IFPLOPPDBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HDMJFNACDGE : GJEBJFOHKBB<NEPMABKJNOA>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6787E60", Offset = "0x6786860", VA = "0x186787E60")]
	public HDMJFNACDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGJLEKJHCOM : GJEBJFOHKBB<DOLODLAIBPC>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6788CC0", Offset = "0x67876C0", VA = "0x186788CC0")]
	public LGJLEKJHCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KHKHPOHEJAJ : HLIGMJABDBM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6788C80", Offset = "0x6787680", VA = "0x186788C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public FFBLLDNKOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67876F0", Offset = "0x67860F0", VA = "0x1867876F0")]
		internal void OCALIDCPPMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67874B0", Offset = "0x6785EB0", VA = "0x1867874B0")]
		internal void BNJCAPAPMOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6787480", Offset = "0x6785E80", VA = "0x186787480")]
		internal void ADHGIOCKEJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67874E0", Offset = "0x6785EE0", VA = "0x1867874E0")]
		internal void CKIFOPHBHBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6787620", Offset = "0x6786020", VA = "0x186787620")]
		internal void GMLJJNGJHOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6787580", Offset = "0x6785F80", VA = "0x186787580")]
		internal void FNCLIIDCKJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67876C0", Offset = "0x67860C0", VA = "0x1867876C0")]
		internal void JBBIDOIDDLI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6786D70", Offset = "0x6785770", VA = "0x186786D70", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, HairData JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6787160", Offset = "0x6785B60", VA = "0x186787160", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, HairData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6787440", Offset = "0x6785E40", VA = "0x186787440")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JJNBNLFPOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6788C50", Offset = "0x6787650", VA = "0x186788C50")]
		internal void OCALIDCPPMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6788860", Offset = "0x6787260", VA = "0x186788860")]
		internal void BNJCAPAPMOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67887B0", Offset = "0x67871B0", VA = "0x1867887B0")]
		internal void ADHGIOCKEJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6788910", Offset = "0x6787310", VA = "0x186788910")]
		internal void CKIFOPHBHBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6788A60", Offset = "0x6787460", VA = "0x186788A60")]
		internal void GMLJJNGJHOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67889C0", Offset = "0x67873C0", VA = "0x1867889C0")]
		internal void FNCLIIDCKJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6788B10", Offset = "0x6787510", VA = "0x186788B10")]
		internal void JBBIDOIDDLI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6788BB0", Offset = "0x67875B0", VA = "0x186788BB0")]
		internal void NCGEMEIBAFM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6788F40", Offset = "0x6787940", VA = "0x186788F40", Slot = "35")]
	public override void MLNALIKJNEL(Utf8JsonReader ELOKBGPKALP, JsonSerializerOptions FDGBBGJEJMA, string LMFCCDBJMHJ, AdditionalHatData JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67893A0", Offset = "0x6787DA0", VA = "0x1867893A0", Slot = "36")]
	public override void NFMHMOCPMGO(Utf8JsonWriter JLIOPEDCMBE, AdditionalHatData JMDCGOKJIDA, JsonSerializerOptions FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67896F0", Offset = "0x67880F0", VA = "0x1867896F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x85F950", VA = "0x180860F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BF60", VA = "0x180A6D560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB42340", Offset = "0xB40D40", VA = "0x180B42340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xDDAB40", Offset = "0xDD9540", VA = "0x180DDAB40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDD9820", Offset = "0xDD8220", VA = "0x180DD9820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EC6710", Offset = "0x1EC5110", VA = "0x181EC6710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1EC6720", Offset = "0x1EC5120", VA = "0x181EC6720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x13E8830", Offset = "0x13E7230", VA = "0x1813E8830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6789BD0", Offset = "0x67885D0", VA = "0x186789BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x22FB4D0", Offset = "0x22F9ED0", VA = "0x1822FB4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x22FB410", Offset = "0x22F9E10", VA = "0x1822FB410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B1DA60", Offset = "0x1B1C460", VA = "0x181B1DA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B1DA90", Offset = "0x1B1C490", VA = "0x181B1DA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDBA500", Offset = "0xDB8F00", VA = "0x180DBA500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDDD410", Offset = "0xDDBE10", VA = "0x180DDD410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GPNFJCLHKIK ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x91F330", Offset = "0x91DD30", VA = "0x18091F330")]
			[CompilerGenerated]
			get
			{
				return default(GPNFJCLHKIK);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAFFDD0", Offset = "0xAFE7D0", VA = "0x180AFFDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DPBKAJAMMON.JBNKIJKKBDP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB003D0", Offset = "0xAFEDD0", VA = "0x180B003D0")]
			[CompilerGenerated]
			get
			{
				return default(DPBKAJAMMON.JBNKIJKKBDP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1461B80", Offset = "0x1460580", VA = "0x181461B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854D00", VA = "0x180856300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x854CF0", VA = "0x1808562F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC358B0", Offset = "0xC342B0", VA = "0x180C358B0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1359150", Offset = "0x1357B50", VA = "0x181359150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1051EB0", Offset = "0x10508B0", VA = "0x181051EB0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4136AB0", Offset = "0x41354B0", VA = "0x184136AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
