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
public class MFBHDKELFMI : HLCMFNOIKAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCD1CF0", Offset = "0xCD0CF0", VA = "0x180CD1CF0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEF30", Offset = "0x7FDDF30", VA = "0x187FDEF30", Slot = "36")]
	protected override Vector3 BOCAPBDHLOM(float[] NCIPNLHDHEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEF80", Offset = "0x7FDDF80", VA = "0x187FDEF80", Slot = "37")]
	protected override float[] OLMNNADJINC(Vector3 IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF000", Offset = "0x7FDE000", VA = "0x187FDF000")]
	public MFBHDKELFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ECMKBABHOOF : HLCMFNOIKAG<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCE95F0", Offset = "0xCE85F0", VA = "0x180CE95F0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD280", Offset = "0x7FDC280", VA = "0x187FDD280", Slot = "36")]
	protected override Vector2 BOCAPBDHLOM(float[] NCIPNLHDHEI)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD2C0", Offset = "0x7FDC2C0", VA = "0x187FDD2C0", Slot = "37")]
	protected override float[] OLMNNADJINC(Vector2 IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD330", Offset = "0x7FDC330", VA = "0x187FDD330")]
	public ECMKBABHOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LDJLFAOLJCA : HLCMFNOIKAG<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB52230", Offset = "0xB51230", VA = "0x180B52230", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDED60", Offset = "0x7FDDD60", VA = "0x187FDED60", Slot = "36")]
	protected override Quaternion BOCAPBDHLOM(float[] NCIPNLHDHEI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEDC0", Offset = "0x7FDDDC0", VA = "0x187FDEDC0", Slot = "37")]
	protected override float[] OLMNNADJINC(Quaternion IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEE50", Offset = "0x7FDDE50", VA = "0x187FDEE50")]
	public LDJLFAOLJCA()
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
		public enum EOCABIJHIFK
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
		public EOCABIJHIFK Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
			[CompilerGenerated]
			get
			{
				return default(EOCABIJHIFK);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB300", Offset = "0x7FDA300", VA = "0x187FDB300", Slot = "0")]
		public override bool Equals(object EDJHHGMLKFA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB570", Offset = "0x7FDA570", VA = "0x187FDB570")]
		public static bool PHGIAKEDBEK(AvatarItemDownloadableConfig AKPAAKDLPCB, AvatarItemDownloadableConfig AIKJCCNDBKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB430", Offset = "0x7FDA430", VA = "0x187FDB430", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB500", Offset = "0x7FDA500", VA = "0x187FDB500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1035500", Offset = "0x1034500", VA = "0x181035500")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, HLNHJFLKOLN, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7FE1C20", Offset = "0x7FE0C20", VA = "0x187FE1C20")]
		private void CNAIGIFDJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1CB0", Offset = "0x7FE0CB0", VA = "0x187FE1CB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1D30", Offset = "0x7FE0D30", VA = "0x187FE1D30", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C20", Offset = "0x7FE0C20", VA = "0x187FE1C20", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E30", Offset = "0x7FE0E30", VA = "0x187FE1E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JECGHJFPGLB : GLCOHBJJKID<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MJMBPGKFCOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MJMBPGKFCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB210", Offset = "0x7FDA210", VA = "0x187FDB210")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF4F0", Offset = "0x7FDE4F0", VA = "0x187FDF4F0")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF2F0", Offset = "0x7FDE2F0", VA = "0x187FDF2F0")]
		internal void KGHKAHHAEKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF040", Offset = "0x7FDE040", VA = "0x187FDF040")]
		internal void BFNKNGIPFMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF0F0", Offset = "0x7FDE0F0", VA = "0x187FDF0F0")]
		internal void BIDEEAOLCLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF440", Offset = "0x7FDE440", VA = "0x187FDF440")]
		internal void KHCGGILNBJN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF240", Offset = "0x7FDE240", VA = "0x187FDF240")]
		internal void IFFKGPLCLKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF5A0", Offset = "0x7FDE5A0", VA = "0x187FDF5A0")]
		internal void PADAFOCEECN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF3A0", Offset = "0x7FDE3A0", VA = "0x187FDF3A0")]
		internal void KGPGOPDODDF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF1A0", Offset = "0x7FDE1A0", VA = "0x187FDF1A0")]
		internal void GAIJPIMDONP(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PDLGAMDBIBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE280", Offset = "0x7FDD280", VA = "0x187FDE280", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, AnchorParamsRestrictions ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE7A0", Offset = "0x7FDD7A0", VA = "0x187FDE7A0", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, AnchorParamsRestrictions IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEC40", Offset = "0x7FDDC40", VA = "0x187FDEC40")]
	public JECGHJFPGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5AF0", Offset = "0x3CE4AF0", VA = "0x183CE5AF0")]
	[CompilerGenerated]
	internal static void ILKJNINNOJM<T>(string JFNKBOFNMLM, T GHNFCHHGJAG, T DCAJOHGIJAK, PDLGAMDBIBH P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MOKHEJDGGCL : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void DMJKGNIFMLK(Utf8JsonReader AEJLPHJDEHN);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OEGIHLNEONH
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
		public MOKHEJDGGCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public DMJKGNIFMLK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public DMJKGNIFMLK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DMJKGNIFMLK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DMJKGNIFMLK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DMJKGNIFMLK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DMJKGNIFMLK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DMJKGNIFMLK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DMJKGNIFMLK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DMJKGNIFMLK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public DMJKGNIFMLK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DMJKGNIFMLK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OEGIHLNEONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1010", Offset = "0x7FE0010", VA = "0x187FE1010")]
		internal void JGJNNBEDOJG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0F60", Offset = "0x7FDFF60", VA = "0x187FE0F60")]
		internal void EJJNOHLHKBF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1330", Offset = "0x7FE0330", VA = "0x187FE1330")]
		internal void OOOIMJHAOJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1280", Offset = "0x7FE0280", VA = "0x187FE1280")]
		internal void NHMAMIKAOFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0E20", Offset = "0x7FDFE20", VA = "0x187FE0E20")]
		internal void AFFHANCGANI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1050", Offset = "0x7FE0050", VA = "0x187FE1050")]
		internal void KALOPMMCJFF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1080", Offset = "0x7FE0080", VA = "0x187FE1080")]
		internal void KKLCKIBNOPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1100", Offset = "0x7FE0100", VA = "0x187FE1100")]
		internal void MAADLNDHJMI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0F20", Offset = "0x7FDFF20", VA = "0x187FE0F20")]
		internal void CLOMCDONGIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE11E0", Offset = "0x7FE01E0", VA = "0x187FE11E0")]
		internal void MJFLDKAJEIK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0ED0", Offset = "0x7FDFED0", VA = "0x187FE0ED0")]
		internal void CDJEEANCIDI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KPFEEOOFCPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KPFEEOOFCPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FDECC0", Offset = "0x7FDDCC0", VA = "0x187FDECC0")]
		internal void OKLCGECJAID(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFB00", Offset = "0x7FDEB00", VA = "0x187FDFB00", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0700", Offset = "0x7FDF700", VA = "0x187FE0700", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, SerializedAvatarItemData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF8B0", Offset = "0x7FDE8B0", VA = "0x187FDF8B0")]
	private AdditionalOutfitTypeData DPMIEJCIPOF(Utf8JsonReader AMPJMGIAGBB, OutfitType BJLNCBFOGNL, JsonSerializerOptions EGBMNBJEHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0B40", Offset = "0x7FDFB40", VA = "0x187FE0B40")]
	public MOKHEJDGGCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HJLPCNDNKEA : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDAA0", Offset = "0x7FDCAA0", VA = "0x187FDDAA0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader AMPJMGIAGBB, Type GPLIAMMNPOC, JsonSerializerOptions EGBMNBJEHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDE30", Offset = "0x7FDCE30", VA = "0x187FDDE30", Slot = "28")]
	public override void Write(Utf8JsonWriter NMCAGOGLPLD, AvatarItemDownloadableConfig IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDF60", Offset = "0x7FDCF60", VA = "0x187FDDF60")]
	public HJLPCNDNKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HNAJPKJLGNC : GLCOHBJJKID<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDFA0", Offset = "0x7FDCFA0", VA = "0x187FDDFA0", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, BeardData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE140", Offset = "0x7FDD140", VA = "0x187FDE140", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, BeardData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE200", Offset = "0x7FDD200", VA = "0x187FDE200")]
	public HNAJPKJLGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KJEEFIPGHCJ : FAFECMDBJCL<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEC80", Offset = "0x7FDDC80", VA = "0x187FDEC80")]
	public KJEEFIPGHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IDLCEILBLMG : FAFECMDBJCL<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE240", Offset = "0x7FDD240", VA = "0x187FDE240")]
	public IDLCEILBLMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PEKHIFDFGFA : FAFECMDBJCL<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1710", Offset = "0x7FE0710", VA = "0x187FE1710")]
	public PEKHIFDFGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DMABLJGJPEL : PNOKOIDNBAN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD240", Offset = "0x7FDC240", VA = "0x187FDD240")]
	public DMABLJGJPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NONEJOPFJMK : GLCOHBJJKID<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DFMCGPIDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DFMCGPIDOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCEF0", Offset = "0x7FDBEF0", VA = "0x187FDCEF0")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCF20", Offset = "0x7FDBF20", VA = "0x187FDCF20")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0B80", Offset = "0x7FDFB80", VA = "0x187FE0B80", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, AdditionalFeetData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0D10", Offset = "0x7FDFD10", VA = "0x187FE0D10", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, AdditionalFeetData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0DE0", Offset = "0x7FDFDE0", VA = "0x187FE0DE0")]
	public NONEJOPFJMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CHAEGJNHOMP : GLCOHBJJKID<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DGEEOOEPNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DGEEOOEPNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD090", Offset = "0x7FDC090", VA = "0x187FDD090")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD210", Offset = "0x7FDC210", VA = "0x187FDD210")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD140", Offset = "0x7FDC140", VA = "0x187FDD140")]
		internal void KGHKAHHAEKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCF50", Offset = "0x7FDBF50", VA = "0x187FDCF50")]
		internal void BFNKNGIPFMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCFF0", Offset = "0x7FDBFF0", VA = "0x187FDCFF0")]
		internal void BIDEEAOLCLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD170", Offset = "0x7FDC170", VA = "0x187FDD170")]
		internal void KHCGGILNBJN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCEF0", Offset = "0x7FDBEF0", VA = "0x187FDCEF0")]
		internal void IFFKGPLCLKM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBFF0", Offset = "0x7FDAFF0", VA = "0x187FDBFF0", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, HairData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC3E0", Offset = "0x7FDB3E0", VA = "0x187FDC3E0", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, HairData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC6C0", Offset = "0x7FDB6C0", VA = "0x187FDC6C0")]
	public CHAEGJNHOMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CPGBKAANLEE : GLCOHBJJKID<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GEAOOOOLFMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GEAOOOOLFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD570", Offset = "0x7FDC570", VA = "0x187FDD570")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD6F0", Offset = "0x7FDC6F0", VA = "0x187FDD6F0")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD5A0", Offset = "0x7FDC5A0", VA = "0x187FDD5A0")]
		internal void KGHKAHHAEKG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD370", Offset = "0x7FDC370", VA = "0x187FDD370")]
		internal void BFNKNGIPFMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD420", Offset = "0x7FDC420", VA = "0x187FDD420")]
		internal void BIDEEAOLCLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD650", Offset = "0x7FDC650", VA = "0x187FDD650")]
		internal void KHCGGILNBJN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD4D0", Offset = "0x7FDC4D0", VA = "0x187FDD4D0")]
		internal void IFFKGPLCLKM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD7A0", Offset = "0x7FDC7A0", VA = "0x187FDD7A0")]
		internal void PADAFOCEECN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC700", Offset = "0x7FDB700", VA = "0x187FDC700", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, AdditionalHatData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCB60", Offset = "0x7FDBB60", VA = "0x187FDCB60", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, AdditionalHatData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCEB0", Offset = "0x7FDBEB0", VA = "0x187FDCEB0")]
	public CPGBKAANLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GHICMFCBPBA : GLCOHBJJKID<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ACPHANDGEAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ACPHANDGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB210", Offset = "0x7FDA210", VA = "0x187FDB210")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB2C0", Offset = "0x7FDA2C0", VA = "0x187FDB2C0")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD840", Offset = "0x7FDC840", VA = "0x187FDD840", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, RoomieEyeData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD9D0", Offset = "0x7FDC9D0", VA = "0x187FDD9D0", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, RoomieEyeData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDA60", Offset = "0x7FDCA60", VA = "0x187FDDA60")]
	public GHICMFCBPBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OEKIIOPPAAA : GLCOHBJJKID<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MALPHJMKINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MALPHJMKINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB210", Offset = "0x7FDA210", VA = "0x187FDB210")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB2C0", Offset = "0x7FDA2C0", VA = "0x187FDB2C0")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEE90", Offset = "0x7FDDE90", VA = "0x187FDEE90")]
		internal void KGHKAHHAEKG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FE13E0", Offset = "0x7FE03E0", VA = "0x187FE13E0", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, RoomieHatData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FE15D0", Offset = "0x7FE05D0", VA = "0x187FE15D0", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, RoomieHatData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FE16D0", Offset = "0x7FE06D0", VA = "0x187FE16D0")]
	public OEKIIOPPAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MKIHFDPADOG : GLCOHBJJKID<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LAEPOCLLAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LAEPOCLLAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB210", Offset = "0x7FDA210", VA = "0x187FDB210")]
		internal void IMDDLGIPPLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB2C0", Offset = "0x7FDA2C0", VA = "0x187FDB2C0")]
		internal void KKKJNDADPJC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF650", Offset = "0x7FDE650", VA = "0x187FDF650", Slot = "35")]
	public override void MBNEHHJCIDI(Utf8JsonReader AMPJMGIAGBB, JsonSerializerOptions EGBMNBJEHHO, string JFNKBOFNMLM, RoomieWaistData ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF7E0", Offset = "0x7FDE7E0", VA = "0x187FDF7E0", Slot = "36")]
	public override void MGJLCHMOECO(Utf8JsonWriter NMCAGOGLPLD, RoomieWaistData IOALKPFEKEK, JsonSerializerOptions EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF870", Offset = "0x7FDE870", VA = "0x187FDF870")]
	public MKIHFDPADOG()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xEFF8E0", Offset = "0xEFE8E0", VA = "0x180EFF8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xEFF8D0", Offset = "0xEFE8D0", VA = "0x180EFF8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x105AB60", Offset = "0x1059B60", VA = "0x18105AB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x105AAD0", Offset = "0x1059AD0", VA = "0x18105AAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x220B6B0", Offset = "0x220A6B0", VA = "0x18220B6B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE1C10", Offset = "0x7FE0C10", VA = "0x187FE1C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2E693A0", Offset = "0x2E683A0", VA = "0x182E693A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2E69020", Offset = "0x2E68020", VA = "0x182E69020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB01F0", Offset = "0xAAF1F0", VA = "0x180AB01F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB0200", Offset = "0xAAF200", VA = "0x180AB0200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GJIEMCFIFPN.OHDBKEAJCKP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
			[CompilerGenerated]
			get
			{
				return default(GJIEMCFIFPN.OHDBKEAJCKP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1780", Offset = "0x7FE0780", VA = "0x187FE1780", Slot = "0")]
		public override bool Equals(object EDJHHGMLKFA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1BF0", Offset = "0x7FE0BF0", VA = "0x187FE1BF0")]
		public static bool PHGIAKEDBEK(SerializedAvatarItemData AKPAAKDLPCB, SerializedAvatarItemData AIKJCCNDBKF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1750", Offset = "0x7FE0750", VA = "0x187FE1750")]
		public static bool BDCEBPMLGHE(SerializedAvatarItemData AKPAAKDLPCB, SerializedAvatarItemData AIKJCCNDBKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1800", Offset = "0x7FE0800", VA = "0x187FE1800", Slot = "4")]
		public bool Equals(SerializedAvatarItemData EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1B20", Offset = "0x7FE0B20", VA = "0x187FE1B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
