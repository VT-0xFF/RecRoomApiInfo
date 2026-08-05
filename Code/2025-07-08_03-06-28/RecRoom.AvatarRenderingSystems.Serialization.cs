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
public class DEHDCHIEOGJ : OCPPGIBCIHD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCCD1A0", Offset = "0xCCBFA0", VA = "0x180CCD1A0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F319D0", Offset = "0x7F307D0", VA = "0x187F319D0", Slot = "36")]
	protected override Vector3 IOKAEMMHJOD(float[] FEBLBJIINOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F31A20", Offset = "0x7F30820", VA = "0x187F31A20", Slot = "37")]
	protected override float[] OOHJPFAIEAE(Vector3 BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F31AA0", Offset = "0x7F308A0", VA = "0x187F31AA0")]
	public DEHDCHIEOGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JODCHLIMOPE : OCPPGIBCIHD<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCDFFB0", Offset = "0xCDEDB0", VA = "0x180CDFFB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F33050", Offset = "0x7F31E50", VA = "0x187F33050", Slot = "36")]
	protected override Vector2 IOKAEMMHJOD(float[] FEBLBJIINOM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F33090", Offset = "0x7F31E90", VA = "0x187F33090", Slot = "37")]
	protected override float[] OOHJPFAIEAE(Vector2 BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F33100", Offset = "0x7F31F00", VA = "0x187F33100")]
	public JODCHLIMOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OLDDKDAJCMP : OCPPGIBCIHD<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB43420", Offset = "0xB42220", VA = "0x180B43420", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F34FC0", Offset = "0x7F33DC0", VA = "0x187F34FC0", Slot = "36")]
	protected override Quaternion IOKAEMMHJOD(float[] FEBLBJIINOM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F35020", Offset = "0x7F33E20", VA = "0x187F35020", Slot = "37")]
	protected override float[] OOHJPFAIEAE(Quaternion BNECONOIKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F350B0", Offset = "0x7F33EB0", VA = "0x187F350B0")]
	public OLDDKDAJCMP()
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
		public enum MJFOCNGFHJL
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
		public MJFOCNGFHJL Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
			[CompilerGenerated]
			get
			{
				return default(MJFOCNGFHJL);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FC90", Offset = "0x7F2EA90", VA = "0x187F2FC90", Slot = "0")]
		public override bool Equals(object LOKLFHKEJPC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FF00", Offset = "0x7F2ED00", VA = "0x187F2FF00")]
		public static bool HAHIHKOBLPE(AvatarItemDownloadableConfig EIECDDIBOHA, AvatarItemDownloadableConfig AFKLBECCDNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FDC0", Offset = "0x7F2EBC0", VA = "0x187F2FDC0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FE90", Offset = "0x7F2EC90", VA = "0x187F2FE90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1006F30", Offset = "0x1005D30", VA = "0x181006F30")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, BNCNHCPLOHA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7F357A0", Offset = "0x7F345A0", VA = "0x187F357A0")]
		private void OHIBOGJMKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F35620", Offset = "0x7F34420", VA = "0x187F35620", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F356A0", Offset = "0x7F344A0", VA = "0x187F356A0", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F35790", Offset = "0x7F34590", VA = "0x187F35790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F35600", Offset = "0x7F34400", VA = "0x187F35600", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection LOKLFHKEJPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
		public Guid MBFEDJCNAOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F357A0", Offset = "0x7F345A0", VA = "0x187F357A0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F35810", Offset = "0x7F34610", VA = "0x187F35810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CKFMMPPALEJ : HKJHPMCOGNL<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AKIOFCBJAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AKIOFCBJAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F9E0", Offset = "0x7F2E7E0", VA = "0x187F2F9E0")]
		internal void IJOGAIGJFFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F7E0", Offset = "0x7F2E5E0", VA = "0x187F2F7E0")]
		internal void FEOFIJBJMNP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FB40", Offset = "0x7F2E940", VA = "0x187F2FB40")]
		internal void MNAEJIACKGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F730", Offset = "0x7F2E530", VA = "0x187F2F730")]
		internal void FCGOCFJKAAA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F680", Offset = "0x7F2E480", VA = "0x187F2F680")]
		internal void CCMKAMIIKGJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F5D0", Offset = "0x7F2E3D0", VA = "0x187F2F5D0")]
		internal void AOGBLBCPBDO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F890", Offset = "0x7F2E690", VA = "0x187F2F890")]
		internal void FMNKALIFBAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FA90", Offset = "0x7F2E890", VA = "0x187F2FA90")]
		internal void LCEOOIMNFAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F940", Offset = "0x7F2E740", VA = "0x187F2F940")]
		internal void IHOMMOKPEAA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2FBF0", Offset = "0x7F2E9F0", VA = "0x187F2FBF0")]
		internal void NDHNEAGHCPO(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NAGIJMLKJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F30F90", Offset = "0x7F2FD90", VA = "0x187F30F90", Slot = "35")]
	public override void DIKGNFELLJL(Utf8JsonReader DGMHJDFFMEI, JsonSerializerOptions LHBNHKOPIFM, string EEMELICKMHH, AnchorParamsRestrictions EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F314B0", Offset = "0x7F302B0", VA = "0x187F314B0", Slot = "36")]
	public override void FADHNJNAHFI(Utf8JsonWriter JAIJDFCBLCH, AnchorParamsRestrictions BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F31950", Offset = "0x7F30750", VA = "0x187F31950")]
	public CKFMMPPALEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3997DF0", Offset = "0x3996BF0", VA = "0x183997DF0")]
	[CompilerGenerated]
	internal static void AOEJELLGCLC<T>(string EEMELICKMHH, T HBLCHHJHKAF, T BEPLKNEKLMF, NAGIJMLKJKA P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ODDIMMIBGJM : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void JOHDEAMKNGJ(Utf8JsonReader GCOEALJJGEI);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FMIKFJFOBKP
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
		public ODDIMMIBGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public JOHDEAMKNGJ <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JOHDEAMKNGJ <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JOHDEAMKNGJ <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public JOHDEAMKNGJ <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JOHDEAMKNGJ <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JOHDEAMKNGJ <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JOHDEAMKNGJ <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JOHDEAMKNGJ <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JOHDEAMKNGJ <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JOHDEAMKNGJ <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JOHDEAMKNGJ <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FMIKFJFOBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F32B60", Offset = "0x7F31960", VA = "0x187F32B60")]
		internal void EJELKCCACFL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F32DF0", Offset = "0x7F31BF0", VA = "0x187F32DF0")]
		internal void PGDMOKNGJCK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F32C90", Offset = "0x7F31A90", VA = "0x187F32C90")]
		internal void JKABOOLOJCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F32BE0", Offset = "0x7F319E0", VA = "0x187F32BE0")]
		internal void GDDDIHOEFDH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F32D40", Offset = "0x7F31B40", VA = "0x187F32D40")]
		internal void PBNNFIIKGAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F32B30", Offset = "0x7F31930", VA = "0x187F32B30")]
		internal void EFNMIHAJOIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F32A10", Offset = "0x7F31810", VA = "0x187F32A10")]
		internal void BEBMFKJMJAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F32EA0", Offset = "0x7F31CA0", VA = "0x187F32EA0")]
		internal void PHAIEPABLNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F32BA0", Offset = "0x7F319A0", VA = "0x187F32BA0")]
		internal void FIFKOEOKAPJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F32A90", Offset = "0x7F31890", VA = "0x187F32A90")]
		internal void BGBNOJDINIB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F32890", Offset = "0x7F31690", VA = "0x187F32890")]
		internal void AEDHJECILHK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GPPPKKJBJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GPPPKKJBJND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F32FB0", Offset = "0x7F31DB0", VA = "0x187F32FB0")]
		internal void IOMGIPBPBFD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F33A40", Offset = "0x7F32840", VA = "0x187F33A40", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F34640", Offset = "0x7F33440", VA = "0x187F34640", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, SerializedAvatarItemData BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F338D0", Offset = "0x7F326D0", VA = "0x187F338D0")]
	private AdditionalOutfitTypeData PAOJNCOHCFA(Utf8JsonReader DGMHJDFFMEI, OutfitType DGPNPBEKOOD, JsonSerializerOptions LHBNHKOPIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F34A80", Offset = "0x7F33880", VA = "0x187F34A80")]
	public ODDIMMIBGJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ODHACCMKGML : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F34AC0", Offset = "0x7F338C0", VA = "0x187F34AC0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DGMHJDFFMEI, Type PLCOPFFBAPF, JsonSerializerOptions LHBNHKOPIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F34E50", Offset = "0x7F33C50", VA = "0x187F34E50", Slot = "28")]
	public override void Write(Utf8JsonWriter JAIJDFCBLCH, AvatarItemDownloadableConfig BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F34F80", Offset = "0x7F33D80", VA = "0x187F34F80")]
	public ODHACCMKGML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EECGHBHMDEB : HKJHPMCOGNL<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F31E00", Offset = "0x7F30C00", VA = "0x187F31E00", Slot = "35")]
	public override void DIKGNFELLJL(Utf8JsonReader DGMHJDFFMEI, JsonSerializerOptions LHBNHKOPIFM, string EEMELICKMHH, BeardData EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F31FA0", Offset = "0x7F30DA0", VA = "0x187F31FA0", Slot = "36")]
	public override void FADHNJNAHFI(Utf8JsonWriter JAIJDFCBLCH, BeardData BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F32060", Offset = "0x7F30E60", VA = "0x187F32060")]
	public EECGHBHMDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class COKMCLDLFJK : OCEFDICIIHH<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F31990", Offset = "0x7F30790", VA = "0x187F31990")]
	public COKMCLDLFJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NIDGKLJODDD : OCEFDICIIHH<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F33890", Offset = "0x7F32690", VA = "0x187F33890")]
	public NIDGKLJODDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MBPOGHEBFNI : OCEFDICIIHH<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F33850", Offset = "0x7F32650", VA = "0x187F33850")]
	public MBPOGHEBFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PAEEMDAGEPE : GFIGDKLFCNH<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F350F0", Offset = "0x7F33EF0", VA = "0x187F350F0")]
	public PAEEMDAGEPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BHMJGMCFDLA : HKJHPMCOGNL<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FPEPDMDJHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FPEPDMDJHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F31CF0", Offset = "0x7F30AF0", VA = "0x187F31CF0")]
		internal void IJOGAIGJFFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F32F80", Offset = "0x7F31D80", VA = "0x187F32F80")]
		internal void FEOFIJBJMNP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F30CF0", Offset = "0x7F2FAF0", VA = "0x187F30CF0", Slot = "35")]
	public override void DIKGNFELLJL(Utf8JsonReader DGMHJDFFMEI, JsonSerializerOptions LHBNHKOPIFM, string EEMELICKMHH, AdditionalFeetData EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F30E80", Offset = "0x7F2FC80", VA = "0x187F30E80", Slot = "36")]
	public override void FADHNJNAHFI(Utf8JsonWriter JAIJDFCBLCH, AdditionalFeetData BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F30F50", Offset = "0x7F2FD50", VA = "0x187F30F50")]
	public BHMJGMCFDLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LBIGPLCJHGE : HKJHPMCOGNL<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EDDOPBINICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EDDOPBINICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F31D20", Offset = "0x7F30B20", VA = "0x187F31D20")]
		internal void IJOGAIGJFFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F31CC0", Offset = "0x7F30AC0", VA = "0x187F31CC0")]
		internal void FEOFIJBJMNP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F31DD0", Offset = "0x7F30BD0", VA = "0x187F31DD0")]
		internal void MNAEJIACKGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F31C20", Offset = "0x7F30A20", VA = "0x187F31C20")]
		internal void FCGOCFJKAAA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F31B80", Offset = "0x7F30980", VA = "0x187F31B80")]
		internal void CCMKAMIIKGJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F31AE0", Offset = "0x7F308E0", VA = "0x187F31AE0")]
		internal void AOGBLBCPBDO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F31CF0", Offset = "0x7F30AF0", VA = "0x187F31CF0")]
		internal void FMNKALIFBAG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F33140", Offset = "0x7F31F40", VA = "0x187F33140", Slot = "35")]
	public override void DIKGNFELLJL(Utf8JsonReader DGMHJDFFMEI, JsonSerializerOptions LHBNHKOPIFM, string EEMELICKMHH, HairData EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F33530", Offset = "0x7F32330", VA = "0x187F33530", Slot = "36")]
	public override void FADHNJNAHFI(Utf8JsonWriter JAIJDFCBLCH, HairData BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F33810", Offset = "0x7F32610", VA = "0x187F33810")]
	public LBIGPLCJHGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FGPOPAFIGFO : HKJHPMCOGNL<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BBHGMCGMKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BBHGMCGMKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F30B70", Offset = "0x7F2F970", VA = "0x187F30B70")]
		internal void IJOGAIGJFFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F30A20", Offset = "0x7F2F820", VA = "0x187F30A20")]
		internal void FEOFIJBJMNP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F30C40", Offset = "0x7F2FA40", VA = "0x187F30C40")]
		internal void MNAEJIACKGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F30970", Offset = "0x7F2F770", VA = "0x187F30970")]
		internal void FCGOCFJKAAA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F308C0", Offset = "0x7F2F6C0", VA = "0x187F308C0")]
		internal void CCMKAMIIKGJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F30820", Offset = "0x7F2F620", VA = "0x187F30820")]
		internal void AOGBLBCPBDO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F30AD0", Offset = "0x7F2F8D0", VA = "0x187F30AD0")]
		internal void FMNKALIFBAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F30BA0", Offset = "0x7F2F9A0", VA = "0x187F30BA0")]
		internal void LCEOOIMNFAE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F320A0", Offset = "0x7F30EA0", VA = "0x187F320A0", Slot = "35")]
	public override void DIKGNFELLJL(Utf8JsonReader DGMHJDFFMEI, JsonSerializerOptions LHBNHKOPIFM, string EEMELICKMHH, AdditionalHatData EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F32500", Offset = "0x7F31300", VA = "0x187F32500", Slot = "36")]
	public override void FADHNJNAHFI(Utf8JsonWriter JAIJDFCBLCH, AdditionalHatData BNECONOIKOE, JsonSerializerOptions LHBNHKOPIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F32850", Offset = "0x7F31650", VA = "0x187F32850")]
	public FGPOPAFIGFO()
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
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xEBA790", Offset = "0xEB9590", VA = "0x180EBA790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xEBA7C0", Offset = "0xEB95C0", VA = "0x180EBA7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1015810", Offset = "0x1014610", VA = "0x181015810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1015780", Offset = "0x1014580", VA = "0x181015780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x21B7770", Offset = "0x21B6570", VA = "0x1821B7770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7F355F0", Offset = "0x7F343F0", VA = "0x187F355F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DDEA40", Offset = "0x2DDD840", VA = "0x182DDEA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2DDEA70", Offset = "0x2DDD870", VA = "0x182DDEA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5780", Offset = "0xAA4580", VA = "0x180AA5780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAA5790", Offset = "0xAA4590", VA = "0x180AA5790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KIECLADILAP.NMBEIOMGMML ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
			[CompilerGenerated]
			get
			{
				return default(KIECLADILAP.NMBEIOMGMML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x72C3E80", Offset = "0x72C2C80", VA = "0x1872C3E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F35130", Offset = "0x7F33F30", VA = "0x187F35130", Slot = "0")]
		public override bool Equals(object LOKLFHKEJPC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F355A0", Offset = "0x7F343A0", VA = "0x187F355A0")]
		public static bool HAHIHKOBLPE(SerializedAvatarItemData EIECDDIBOHA, SerializedAvatarItemData AFKLBECCDNB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F355C0", Offset = "0x7F343C0", VA = "0x187F355C0")]
		public static bool KKINNKAIEFB(SerializedAvatarItemData EIECDDIBOHA, SerializedAvatarItemData AFKLBECCDNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F351B0", Offset = "0x7F33FB0", VA = "0x187F351B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F354D0", Offset = "0x7F342D0", VA = "0x187F354D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
