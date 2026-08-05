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
public class CCFONBDOOPJ : LALLFLLFHHM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x92C8E0", Offset = "0x92BCE0", VA = "0x18092C8E0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E92AD0", Offset = "0x6E91ED0", VA = "0x186E92AD0", Slot = "36")]
	protected override Vector3 GIKNPLOBEMO(float[] KLODBELJCDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E92B20", Offset = "0x6E91F20", VA = "0x186E92B20", Slot = "37")]
	protected override float[] GPFELNBEICA(Vector3 HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E92BA0", Offset = "0x6E91FA0", VA = "0x186E92BA0")]
	public CCFONBDOOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CHILPBLNGCK : LALLFLLFHHM<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x935560", Offset = "0x934960", VA = "0x180935560", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E92BE0", Offset = "0x6E91FE0", VA = "0x186E92BE0", Slot = "36")]
	protected override Vector2 GIKNPLOBEMO(float[] KLODBELJCDF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E92C20", Offset = "0x6E92020", VA = "0x186E92C20", Slot = "37")]
	protected override float[] GPFELNBEICA(Vector2 HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E92C90", Offset = "0x6E92090", VA = "0x186E92C90")]
	public CHILPBLNGCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HLEHHPEKAEE : LALLFLLFHHM<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A6540", Offset = "0x9A5940", VA = "0x1809A6540", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E939B0", Offset = "0x6E92DB0", VA = "0x186E939B0", Slot = "36")]
	protected override Quaternion GIKNPLOBEMO(float[] KLODBELJCDF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E93A10", Offset = "0x6E92E10", VA = "0x186E93A10", Slot = "37")]
	protected override float[] GPFELNBEICA(Quaternion HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E93AA0", Offset = "0x6E92EA0", VA = "0x186E93AA0")]
	public HLEHHPEKAEE()
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
		public enum KPKMMJGCHFG
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
		public KPKMMJGCHFG Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
			[CompilerGenerated]
			get
			{
				return default(KPKMMJGCHFG);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E91830", Offset = "0x6E90C30", VA = "0x186E91830", Slot = "0")]
		public override bool Equals(object BMKPAKCEMFK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E91960", Offset = "0x6E90D60", VA = "0x186E91960")]
		public static bool FANHDJJNLED(AvatarItemDownloadableConfig KLFFMNNBENE, AvatarItemDownloadableConfig EHNIKEHCICN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E91760", Offset = "0x6E90B60", VA = "0x186E91760", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E91A60", Offset = "0x6E90E60", VA = "0x186E91A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAF4E80", Offset = "0xAF4280", VA = "0x180AF4E80")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, MDKKLDNPMCM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6E97980", Offset = "0x6E96D80", VA = "0x186E97980")]
		public SerializedAvatarItemSelection(HHDIOAFENPE IBLIBCIEMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E97720", Offset = "0x6E96B20", VA = "0x186E97720")]
		private void EDPBPHPMHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E97790", Offset = "0x6E96B90", VA = "0x186E97790", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E97810", Offset = "0x6E96C10", VA = "0x186E97810", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E97720", Offset = "0x6E96B20", VA = "0x186E97720", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E97910", Offset = "0x6E96D10", VA = "0x186E97910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HLEKCDJIOKL : LBAFJCNIFAL<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JLNHBJHKJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JLNHBJHKJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E94920", Offset = "0x6E93D20", VA = "0x186E94920")]
		internal void CGBGMJGADIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E94A80", Offset = "0x6E93E80", VA = "0x186E94A80")]
		internal void DDFFOLAKAFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E947C0", Offset = "0x6E93BC0", VA = "0x186E947C0")]
		internal void AFCKGEDGKNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E94C90", Offset = "0x6E94090", VA = "0x186E94C90")]
		internal void HJDCKIFDJBO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E949D0", Offset = "0x6E93DD0", VA = "0x186E949D0")]
		internal void DCMKEHFIDOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E94B30", Offset = "0x6E93F30", VA = "0x186E94B30")]
		internal void DKGEHLCILDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E94BE0", Offset = "0x6E93FE0", VA = "0x186E94BE0")]
		internal void GEKEJBLIOMI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E94870", Offset = "0x6E93C70", VA = "0x186E94870")]
		internal void ALACOGKDANP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E94DE0", Offset = "0x6E941E0", VA = "0x186E94DE0")]
		internal void JAHOLAMDOAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E94D40", Offset = "0x6E94140", VA = "0x186E94D40")]
		internal void IALLCKKNDBO(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CAOCLCPCGNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E93AE0", Offset = "0x6E92EE0", VA = "0x186E93AE0", Slot = "35")]
	public override void DBIFBBKNPKJ(Utf8JsonReader IEMPDPINHLH, JsonSerializerOptions MFKLHLPHDGD, string NHHEMHBDHEB, AnchorParamsRestrictions FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E94000", Offset = "0x6E93400", VA = "0x186E94000", Slot = "36")]
	public override void IFIHNDEFPII(Utf8JsonWriter EEKKIBDAGAJ, AnchorParamsRestrictions HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E94490", Offset = "0x6E93890", VA = "0x186E94490")]
	public HLEKCDJIOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3081810", Offset = "0x3080C10", VA = "0x183081810")]
	[CompilerGenerated]
	internal static void BGLPMGIIMFF<T>(string NHHEMHBDHEB, T BBFFJMPBBGO, T BPMEEKFEKMC, CAOCLCPCGNI P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KHPLGEICLGO : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void ACGMFCFDICK(Utf8JsonReader NOMFBHAJODM);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NKMJJDBJEKE
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
		public KHPLGEICLGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public ACGMFCFDICK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ACGMFCFDICK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ACGMFCFDICK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ACGMFCFDICK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ACGMFCFDICK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ACGMFCFDICK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ACGMFCFDICK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ACGMFCFDICK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ACGMFCFDICK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ACGMFCFDICK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ACGMFCFDICK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NKMJJDBJEKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E96C00", Offset = "0x6E96000", VA = "0x186E96C00")]
		internal void CFAFIIJGJDN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E96C40", Offset = "0x6E96040", VA = "0x186E96C40")]
		internal void CPPLGJDHHEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E96CF0", Offset = "0x6E960F0", VA = "0x186E96CF0")]
		internal void DMFMAFDHKIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E96B50", Offset = "0x6E95F50", VA = "0x186E96B50")]
		internal void BGIBNJILFNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6E96DA0", Offset = "0x6E961A0", VA = "0x186E96DA0")]
		internal void IKCLCPMLLOJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E944D0", Offset = "0x6E938D0", VA = "0x186E944D0")]
		internal void MNPCHEIJBKN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6E96AD0", Offset = "0x6E95ED0", VA = "0x186E96AD0")]
		internal void BAOKDBKOMEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E96E90", Offset = "0x6E96290", VA = "0x186E96E90")]
		internal void LCJLDBCHLEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E96E50", Offset = "0x6E96250", VA = "0x186E96E50")]
		internal void JGDDNNDGBJI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E970F0", Offset = "0x6E964F0", VA = "0x186E970F0")]
		internal void PMGBFAIGLMM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E96F70", Offset = "0x6E96370", VA = "0x186E96F70")]
		internal void NBHEDMEAEFE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PFNACNJCEJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PFNACNJCEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E97190", Offset = "0x6E96590", VA = "0x186E97190")]
		internal void EBKDLFNPCLD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E95070", Offset = "0x6E94470", VA = "0x186E95070", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E95C50", Offset = "0x6E95050", VA = "0x186E95C50", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, SerializedAvatarItemData HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E94F00", Offset = "0x6E94300", VA = "0x186E94F00")]
	private AdditionalOutfitTypeData CGMJHNKLAKA(Utf8JsonReader IEMPDPINHLH, OutfitType IFBDJLKPHIG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E96080", Offset = "0x6E95480", VA = "0x186E96080")]
	public KHPLGEICLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NFGAKPJHKHC : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E96100", Offset = "0x6E95500", VA = "0x186E96100", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E96490", Offset = "0x6E95890", VA = "0x186E96490", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, AvatarItemDownloadableConfig HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E965C0", Offset = "0x6E959C0", VA = "0x186E965C0")]
	public NFGAKPJHKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ECGOPHLHIAF : LBAFJCNIFAL<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E92CD0", Offset = "0x6E920D0", VA = "0x186E92CD0", Slot = "35")]
	public override void DBIFBBKNPKJ(Utf8JsonReader IEMPDPINHLH, JsonSerializerOptions MFKLHLPHDGD, string NHHEMHBDHEB, BeardData FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E92E70", Offset = "0x6E92270", VA = "0x186E92E70", Slot = "36")]
	public override void IFIHNDEFPII(Utf8JsonWriter EEKKIBDAGAJ, BeardData HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E92F30", Offset = "0x6E92330", VA = "0x186E92F30")]
	public ECGOPHLHIAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ENKIBEPPIPM : GPKGMJFJAPL<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E93270", Offset = "0x6E92670", VA = "0x186E93270")]
	public ENKIBEPPIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KHKPFNGBPCG : GPKGMJFJAPL<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E94EC0", Offset = "0x6E942C0", VA = "0x186E94EC0")]
	public KHKPFNGBPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JOGPKFLAIFJ : GPKGMJFJAPL<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E94E80", Offset = "0x6E94280", VA = "0x186E94E80")]
	public JOGPKFLAIFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MFPOOFAIMHM : CGGJHBBCHJJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E960C0", Offset = "0x6E954C0", VA = "0x186E960C0")]
	public MFPOOFAIMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ENDFHFLJBKM : LBAFJCNIFAL<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ELBHIMIMDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ELBHIMIMDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E92F70", Offset = "0x6E92370", VA = "0x186E92F70")]
		internal void CGBGMJGADIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E92FA0", Offset = "0x6E923A0", VA = "0x186E92FA0")]
		internal void DDFFOLAKAFA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E92FD0", Offset = "0x6E923D0", VA = "0x186E92FD0", Slot = "35")]
	public override void DBIFBBKNPKJ(Utf8JsonReader IEMPDPINHLH, JsonSerializerOptions MFKLHLPHDGD, string NHHEMHBDHEB, AdditionalFeetData FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E93160", Offset = "0x6E92560", VA = "0x186E93160", Slot = "36")]
	public override void IFIHNDEFPII(Utf8JsonWriter EEKKIBDAGAJ, AdditionalFeetData HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E93230", Offset = "0x6E92630", VA = "0x186E93230")]
	public ENDFHFLJBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GJOANHGLKNL : LBAFJCNIFAL<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JBIODFCHHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JBIODFCHHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E94500", Offset = "0x6E93900", VA = "0x186E94500")]
		internal void CGBGMJGADIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E94650", Offset = "0x6E93A50", VA = "0x186E94650")]
		internal void DDFFOLAKAFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E944D0", Offset = "0x6E938D0", VA = "0x186E944D0")]
		internal void AFCKGEDGKNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E94720", Offset = "0x6E93B20", VA = "0x186E94720")]
		internal void HJDCKIFDJBO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6E945B0", Offset = "0x6E939B0", VA = "0x186E945B0")]
		internal void DCMKEHFIDOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E94680", Offset = "0x6E93A80", VA = "0x186E94680")]
		internal void DKGEHLCILDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E92F70", Offset = "0x6E92370", VA = "0x186E92F70")]
		internal void GEKEJBLIOMI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E932B0", Offset = "0x6E926B0", VA = "0x186E932B0", Slot = "35")]
	public override void DBIFBBKNPKJ(Utf8JsonReader IEMPDPINHLH, JsonSerializerOptions MFKLHLPHDGD, string NHHEMHBDHEB, HairData FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E936A0", Offset = "0x6E92AA0", VA = "0x186E936A0", Slot = "36")]
	public override void IFIHNDEFPII(Utf8JsonWriter EEKKIBDAGAJ, HairData HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E93970", Offset = "0x6E92D70", VA = "0x186E93970")]
	public GJOANHGLKNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BENDDCIKCPL : LBAFJCNIFAL<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NJIINFENNHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NJIINFENNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E96750", Offset = "0x6E95B50", VA = "0x186E96750")]
		internal void CGBGMJGADIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E96830", Offset = "0x6E95C30", VA = "0x186E96830")]
		internal void DDFFOLAKAFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E96600", Offset = "0x6E95A00", VA = "0x186E96600")]
		internal void AFCKGEDGKNO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E96A20", Offset = "0x6E95E20", VA = "0x186E96A20")]
		internal void HJDCKIFDJBO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E96780", Offset = "0x6E95B80", VA = "0x186E96780")]
		internal void DCMKEHFIDOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E968E0", Offset = "0x6E95CE0", VA = "0x186E968E0")]
		internal void DKGEHLCILDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E96980", Offset = "0x6E95D80", VA = "0x186E96980")]
		internal void GEKEJBLIOMI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E966B0", Offset = "0x6E95AB0", VA = "0x186E966B0")]
		internal void ALACOGKDANP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E922F0", Offset = "0x6E916F0", VA = "0x186E922F0", Slot = "35")]
	public override void DBIFBBKNPKJ(Utf8JsonReader IEMPDPINHLH, JsonSerializerOptions MFKLHLPHDGD, string NHHEMHBDHEB, AdditionalHatData FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E92750", Offset = "0x6E91B50", VA = "0x186E92750", Slot = "36")]
	public override void IFIHNDEFPII(Utf8JsonWriter EEKKIBDAGAJ, AdditionalHatData HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E92A90", Offset = "0x6E91E90", VA = "0x186E92A90")]
	public BENDDCIKCPL()
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
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C60", Offset = "0x8C8060", VA = "0x1808C8C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA02880", Offset = "0xA01C80", VA = "0x180A02880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA02750", Offset = "0xA01B50", VA = "0x180A02750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA02890", Offset = "0xA01C90", VA = "0x180A02890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA02740", Offset = "0xA01B40", VA = "0x180A02740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB0E700", Offset = "0xB0DB00", VA = "0x180B0E700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xB0E6F0", Offset = "0xB0DAF0", VA = "0x180B0E6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1937CD0", Offset = "0x19370D0", VA = "0x181937CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6E976F0", Offset = "0x6E96AF0", VA = "0x186E976F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x26AEB30", Offset = "0x26ADF30", VA = "0x1826AEB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x26AEB40", Offset = "0x26ADF40", VA = "0x1826AEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1F112D0", Offset = "0x1F106D0", VA = "0x181F112D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1F112E0", Offset = "0x1F106E0", VA = "0x181F112E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IBBAPAKLKFF.JPAHGGFNNNL ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x96EF30", Offset = "0x96E330", VA = "0x18096EF30")]
			[CompilerGenerated]
			get
			{
				return default(IBBAPAKLKFF.JPAHGGFNNNL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA95CF0", Offset = "0xA950F0", VA = "0x180A95CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA40", Offset = "0x8CEE40", VA = "0x1808CFA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E97550", Offset = "0x6E96950", VA = "0x186E97550", Slot = "0")]
		public override bool Equals(object BMKPAKCEMFK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E975D0", Offset = "0x6E969D0", VA = "0x186E975D0")]
		public static bool FANHDJJNLED(SerializedAvatarItemData KLFFMNNBENE, SerializedAvatarItemData EHNIKEHCICN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E976C0", Offset = "0x6E96AC0", VA = "0x186E976C0")]
		public static bool KNIDLJBALLO(SerializedAvatarItemData KLFFMNNBENE, SerializedAvatarItemData EHNIKEHCICN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E97230", Offset = "0x6E96630", VA = "0x186E97230", Slot = "4")]
		public bool Equals(SerializedAvatarItemData BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E975F0", Offset = "0x6E969F0", VA = "0x186E975F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
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
