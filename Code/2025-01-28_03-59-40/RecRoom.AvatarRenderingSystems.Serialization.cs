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
public class FOJPDOFJEDL : PAOGFDDEOIK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA48600", Offset = "0xA47800", VA = "0x180A48600", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x70B5060", Offset = "0x70B4260", VA = "0x1870B5060", Slot = "36")]
	protected override Vector3 MDPHKHCBBAN(float[] CJALOAIIOIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70B4FE0", Offset = "0x70B41E0", VA = "0x1870B4FE0", Slot = "37")]
	protected override float[] ECDJLKNEFPJ(Vector3 OMEFCJCOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70B50B0", Offset = "0x70B42B0", VA = "0x1870B50B0")]
	public FOJPDOFJEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OPJBJFNAJNA : PAOGFDDEOIK<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA79BB0", Offset = "0xA78DB0", VA = "0x180A79BB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x70B8A80", Offset = "0x70B7C80", VA = "0x1870B8A80", Slot = "36")]
	protected override Vector2 MDPHKHCBBAN(float[] CJALOAIIOIM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70B8A10", Offset = "0x70B7C10", VA = "0x1870B8A10", Slot = "37")]
	protected override float[] ECDJLKNEFPJ(Vector2 OMEFCJCOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70B8AC0", Offset = "0x70B7CC0", VA = "0x1870B8AC0")]
	public OPJBJFNAJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GFIOMMPBELJ : PAOGFDDEOIK<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA740D0", Offset = "0xA732D0", VA = "0x180A740D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70B6360", Offset = "0x70B5560", VA = "0x1870B6360", Slot = "36")]
	protected override Quaternion MDPHKHCBBAN(float[] CJALOAIIOIM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70B62D0", Offset = "0x70B54D0", VA = "0x1870B62D0", Slot = "37")]
	protected override float[] ECDJLKNEFPJ(Quaternion OMEFCJCOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70B63C0", Offset = "0x70B55C0", VA = "0x1870B63C0")]
	public GFIOMMPBELJ()
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
		public enum FIPBCHEILJE
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
		public FIPBCHEILJE Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0")]
			[CompilerGenerated]
			get
			{
				return default(FIPBCHEILJE);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70B35E0", Offset = "0x70B27E0", VA = "0x1870B35E0", Slot = "0")]
		public override bool Equals(object JAINJPLCLDO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70B34E0", Offset = "0x70B26E0", VA = "0x1870B34E0")]
		public static bool CCHBIHOFELC(AvatarItemDownloadableConfig LFOFDHEGDLC, AvatarItemDownloadableConfig KMPLOMOLJCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70B3710", Offset = "0x70B2910", VA = "0x1870B3710", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70B37E0", Offset = "0x70B29E0", VA = "0x1870B37E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD497D0", Offset = "0xD489D0", VA = "0x180D497D0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, GHLPHAHIDFB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x70B9670", Offset = "0x70B8870", VA = "0x1870B9670")]
		private void GGHBGCBLBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70B9500", Offset = "0x70B8700", VA = "0x1870B9500", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70B9580", Offset = "0x70B8780", VA = "0x1870B9580", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70B9670", Offset = "0x70B8870", VA = "0x1870B9670", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70B96F0", Offset = "0x70B88F0", VA = "0x1870B96F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OECAHEGKOME : ANCNMPOLBHF<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LGAIFLOEFKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LGAIFLOEFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70B7A00", Offset = "0x70B6C00", VA = "0x1870B7A00")]
		internal void JCAPLPIPMMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70B7C00", Offset = "0x70B6E00", VA = "0x1870B7C00")]
		internal void LCJJJBNJEIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70B7950", Offset = "0x70B6B50", VA = "0x1870B7950")]
		internal void BPHGMFJHFKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70B7EC0", Offset = "0x70B70C0", VA = "0x1870B7EC0")]
		internal void NGEEJOOJPEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70B7E10", Offset = "0x70B7010", VA = "0x1870B7E10")]
		internal void MMPFKNPFCNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70B7CB0", Offset = "0x70B6EB0", VA = "0x1870B7CB0")]
		internal void LHPBPHKEMEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70B7B50", Offset = "0x70B6D50", VA = "0x1870B7B50")]
		internal void KJBEPAAOKAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70B7D60", Offset = "0x70B6F60", VA = "0x1870B7D60")]
		internal void MIJEPGMNPOI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70B7F70", Offset = "0x70B7170", VA = "0x1870B7F70")]
		internal void NJFBBIJIDHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x70B7AB0", Offset = "0x70B6CB0", VA = "0x1870B7AB0")]
		internal void JKJKLLBFIKH(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HGCMKHIGJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x70B8010", Offset = "0x70B7210", VA = "0x1870B8010", Slot = "35")]
	public override void EIMLJGHKFLK(Utf8JsonReader NHPBIOODHLE, JsonSerializerOptions GPDCLNOGPJC, string LFNMBEJGJCH, AnchorParamsRestrictions OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70B8530", Offset = "0x70B7730", VA = "0x1870B8530", Slot = "36")]
	public override void OJOHCAOMGPM(Utf8JsonWriter JPECNBJOJNA, AnchorParamsRestrictions OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x70B89D0", Offset = "0x70B7BD0", VA = "0x1870B89D0")]
	public OECAHEGKOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3434180", Offset = "0x3433380", VA = "0x183434180")]
	[CompilerGenerated]
	internal static void EMDHLEEJNPK<T>(string LFNMBEJGJCH, T IAPIOFHOONE, T JFCGHDLACEG, HGCMKHIGJCO P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FONDGEIOFPG : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void IMJHOIGLAPG(Utf8JsonReader KBNPICMCGIJ);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IBNHELJHGIO
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
		public FONDGEIOFPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IMJHOIGLAPG <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IMJHOIGLAPG <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IMJHOIGLAPG <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public IMJHOIGLAPG <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IMJHOIGLAPG <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IMJHOIGLAPG <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IMJHOIGLAPG <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IMJHOIGLAPG <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IMJHOIGLAPG <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IMJHOIGLAPG <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IMJHOIGLAPG <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IBNHELJHGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70B6DF0", Offset = "0x70B5FF0", VA = "0x1870B6DF0")]
		internal void CHDOLHKCMHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70B71C0", Offset = "0x70B63C0", VA = "0x1870B71C0")]
		internal void LCNCLGEFACB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70B6EE0", Offset = "0x70B60E0", VA = "0x1870B6EE0")]
		internal void IMMOPIOAGEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70B6E30", Offset = "0x70B6030", VA = "0x1870B6E30")]
		internal void HCJLCLNIJCC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x70B6F90", Offset = "0x70B6190", VA = "0x1870B6F90")]
		internal void KCOEDCLIIIG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70B4070", Offset = "0x70B3270", VA = "0x1870B4070")]
		internal void MIJIHNBHKEF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70B7270", Offset = "0x70B6470", VA = "0x1870B7270")]
		internal void PGMLEAIELIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70B72F0", Offset = "0x70B64F0", VA = "0x1870B72F0")]
		internal void PMEJOOAAIAA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x70B6D10", Offset = "0x70B5F10", VA = "0x1870B6D10")]
		internal void BOCCGLBCNPN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70B6D50", Offset = "0x70B5F50", VA = "0x1870B6D50")]
		internal void CBBCPPJGNFP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70B7040", Offset = "0x70B6240", VA = "0x1870B7040")]
		internal void KJPAOKOGJMC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GJDPOEKHMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GJDPOEKHMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70B6400", Offset = "0x70B5600", VA = "0x1870B6400")]
		internal void DJONOKFDOOC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70B5260", Offset = "0x70B4460", VA = "0x1870B5260", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70B5E60", Offset = "0x70B5060", VA = "0x1870B5E60", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, SerializedAvatarItemData OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70B50F0", Offset = "0x70B42F0", VA = "0x1870B50F0")]
	private AdditionalOutfitTypeData DGMENCGABLM(Utf8JsonReader NHPBIOODHLE, OutfitType MDOOANEGCAH, JsonSerializerOptions GPDCLNOGPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70B6290", Offset = "0x70B5490", VA = "0x1870B6290")]
	public FONDGEIOFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DDNKIMKIPLM : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70B4AE0", Offset = "0x70B3CE0", VA = "0x1870B4AE0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x70B4E70", Offset = "0x70B4070", VA = "0x1870B4E70", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, AvatarItemDownloadableConfig OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70B4FA0", Offset = "0x70B41A0", VA = "0x1870B4FA0")]
	public DDNKIMKIPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KJIDJKKFHPM : ANCNMPOLBHF<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70B76B0", Offset = "0x70B68B0", VA = "0x1870B76B0", Slot = "35")]
	public override void EIMLJGHKFLK(Utf8JsonReader NHPBIOODHLE, JsonSerializerOptions GPDCLNOGPJC, string LFNMBEJGJCH, BeardData OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x70B7850", Offset = "0x70B6A50", VA = "0x1870B7850", Slot = "36")]
	public override void OJOHCAOMGPM(Utf8JsonWriter JPECNBJOJNA, BeardData OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x70B7910", Offset = "0x70B6B10", VA = "0x1870B7910")]
	public KJIDJKKFHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CMLPPHHGDMN : GOPAEMJAFEC<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x70B4AA0", Offset = "0x70B3CA0", VA = "0x1870B4AA0")]
	public CMLPPHHGDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JCANHICLFIJ : GOPAEMJAFEC<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x70B73D0", Offset = "0x70B65D0", VA = "0x1870B73D0")]
	public JCANHICLFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HNKBOMCKMIH : GOPAEMJAFEC<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70B64E0", Offset = "0x70B56E0", VA = "0x1870B64E0")]
	public HNKBOMCKMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HMFHMBBHLPM : BBCGIPPBLCE<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x70B64A0", Offset = "0x70B56A0", VA = "0x1870B64A0")]
	public HMFHMBBHLPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JPAMAACBKCB : ANCNMPOLBHF<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PNMOHKGBFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PNMOHKGBFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x70B4150", Offset = "0x70B3350", VA = "0x1870B4150")]
		internal void JCAPLPIPMMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x70B8FD0", Offset = "0x70B81D0", VA = "0x1870B8FD0")]
		internal void LCJJJBNJEIN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x70B7410", Offset = "0x70B6610", VA = "0x1870B7410", Slot = "35")]
	public override void EIMLJGHKFLK(Utf8JsonReader NHPBIOODHLE, JsonSerializerOptions GPDCLNOGPJC, string LFNMBEJGJCH, AdditionalFeetData OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70B75A0", Offset = "0x70B67A0", VA = "0x1870B75A0", Slot = "36")]
	public override void OJOHCAOMGPM(Utf8JsonWriter JPECNBJOJNA, AdditionalFeetData OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70B7670", Offset = "0x70B6870", VA = "0x1870B7670")]
	public JPAMAACBKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CFCIGAJEEFB : ANCNMPOLBHF<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BDGILFPGJOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BDGILFPGJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70B40A0", Offset = "0x70B32A0", VA = "0x1870B40A0")]
		internal void JCAPLPIPMMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70B4180", Offset = "0x70B3380", VA = "0x1870B4180")]
		internal void LCJJJBNJEIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x70B4070", Offset = "0x70B3270", VA = "0x1870B4070")]
		internal void BPHGMFJHFKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x70B42F0", Offset = "0x70B34F0", VA = "0x1870B42F0")]
		internal void NGEEJOOJPEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70B4250", Offset = "0x70B3450", VA = "0x1870B4250")]
		internal void MMPFKNPFCNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70B41B0", Offset = "0x70B33B0", VA = "0x1870B41B0")]
		internal void LHPBPHKEMEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x70B4150", Offset = "0x70B3350", VA = "0x1870B4150")]
		internal void KJBEPAAOKAJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70B4390", Offset = "0x70B3590", VA = "0x1870B4390", Slot = "35")]
	public override void EIMLJGHKFLK(Utf8JsonReader NHPBIOODHLE, JsonSerializerOptions GPDCLNOGPJC, string LFNMBEJGJCH, HairData OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70B4780", Offset = "0x70B3980", VA = "0x1870B4780", Slot = "36")]
	public override void OJOHCAOMGPM(Utf8JsonWriter JPECNBJOJNA, HairData OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70B4A60", Offset = "0x70B3C60", VA = "0x1870B4A60")]
	public CFCIGAJEEFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IAIGDKHHGHG : ANCNMPOLBHF<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PCNHGHACFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PCNHGHACFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x70B8BB0", Offset = "0x70B7DB0", VA = "0x1870B8BB0")]
		internal void JCAPLPIPMMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70B8C80", Offset = "0x70B7E80", VA = "0x1870B8C80")]
		internal void LCJJJBNJEIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70B8B00", Offset = "0x70B7D00", VA = "0x1870B8B00")]
		internal void BPHGMFJHFKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70B8F20", Offset = "0x70B8120", VA = "0x1870B8F20")]
		internal void NGEEJOOJPEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70B8E70", Offset = "0x70B8070", VA = "0x1870B8E70")]
		internal void MMPFKNPFCNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70B8D30", Offset = "0x70B7F30", VA = "0x1870B8D30")]
		internal void LHPBPHKEMEK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70B8BE0", Offset = "0x70B7DE0", VA = "0x1870B8BE0")]
		internal void KJBEPAAOKAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70B8DD0", Offset = "0x70B7FD0", VA = "0x1870B8DD0")]
		internal void MIJEPGMNPOI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70B6520", Offset = "0x70B5720", VA = "0x1870B6520", Slot = "35")]
	public override void EIMLJGHKFLK(Utf8JsonReader NHPBIOODHLE, JsonSerializerOptions GPDCLNOGPJC, string LFNMBEJGJCH, AdditionalHatData OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70B6980", Offset = "0x70B5B80", VA = "0x1870B6980", Slot = "36")]
	public override void OJOHCAOMGPM(Utf8JsonWriter JPECNBJOJNA, AdditionalHatData OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70B6CD0", Offset = "0x70B5ED0", VA = "0x1870B6CD0")]
	public IAIGDKHHGHG()
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
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8F54B0", Offset = "0x8F46B0", VA = "0x1808F54B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC896C0", Offset = "0xC888C0", VA = "0x180C896C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC897E0", Offset = "0xC889E0", VA = "0x180C897E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xC896D0", Offset = "0xC888D0", VA = "0x180C896D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD57430", Offset = "0xD56630", VA = "0x180D57430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD57530", Offset = "0xD56730", VA = "0x180D57530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1CCFE10", Offset = "0x1CCF010", VA = "0x181CCFE10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x70B94D0", Offset = "0x70B86D0", VA = "0x1870B94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x28AA110", Offset = "0x28A9310", VA = "0x1828AA110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x28AA2A0", Offset = "0x28A94A0", VA = "0x1828AA2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB50870", Offset = "0xB4FA70", VA = "0x180B50870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB508C0", Offset = "0xB4FAC0", VA = "0x180B508C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LJLGCMOEKHG.AMEKCHAHPFE ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA86BE0", Offset = "0xA85DE0", VA = "0x180A86BE0")]
			[CompilerGenerated]
			get
			{
				return default(LJLGCMOEKHG.AMEKCHAHPFE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA86BF0", Offset = "0xA85DF0", VA = "0x180A86BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8F9240", Offset = "0x8F8440", VA = "0x1808F9240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x70B9020", Offset = "0x70B8220", VA = "0x1870B9020", Slot = "0")]
		public override bool Equals(object JAINJPLCLDO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x70B9000", Offset = "0x70B8200", VA = "0x1870B9000")]
		public static bool CCHBIHOFELC(SerializedAvatarItemData LFOFDHEGDLC, SerializedAvatarItemData KMPLOMOLJCO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x70B94A0", Offset = "0x70B86A0", VA = "0x1870B94A0")]
		public static bool IMFBACMHPLD(SerializedAvatarItemData LFOFDHEGDLC, SerializedAvatarItemData KMPLOMOLJCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x70B90B0", Offset = "0x70B82B0", VA = "0x1870B90B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x70B93D0", Offset = "0x70B85D0", VA = "0x1870B93D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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
