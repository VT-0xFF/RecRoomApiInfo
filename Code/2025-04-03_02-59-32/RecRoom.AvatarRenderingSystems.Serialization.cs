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
public class DAFJDOFEJGL : NKIFMCNCECJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB01840", VA = "0x180B02440", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7705B10", Offset = "0x7704F10", VA = "0x187705B10", Slot = "36")]
	protected override Vector3 KGKMLPCLAEP(float[] JGMAGBDHLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7705A90", Offset = "0x7704E90", VA = "0x187705A90", Slot = "37")]
	protected override float[] CNGHJFEEEPF(Vector3 FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7705B60", Offset = "0x7704F60", VA = "0x187705B60")]
	public DAFJDOFEJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OGNGIKDGDAC : NKIFMCNCECJ<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB1A370", Offset = "0xB19770", VA = "0x180B1A370", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7708890", Offset = "0x7707C90", VA = "0x187708890", Slot = "36")]
	protected override Vector2 KGKMLPCLAEP(float[] JGMAGBDHLIF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7708820", Offset = "0x7707C20", VA = "0x187708820", Slot = "37")]
	protected override float[] CNGHJFEEEPF(Vector2 FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77088D0", Offset = "0x7707CD0", VA = "0x1877088D0")]
	public OGNGIKDGDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HEJEODANPOK : NKIFMCNCECJ<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB19990", Offset = "0xB18D90", VA = "0x180B19990", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7707500", Offset = "0x7706900", VA = "0x187707500", Slot = "36")]
	protected override Quaternion KGKMLPCLAEP(float[] JGMAGBDHLIF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7707470", Offset = "0x7706870", VA = "0x187707470", Slot = "37")]
	protected override float[] CNGHJFEEEPF(Quaternion FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7707560", Offset = "0x7706960", VA = "0x187707560")]
	public HEJEODANPOK()
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
		public enum CEMOACKCLEJ
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
		public CEMOACKCLEJ Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0")]
			[CompilerGenerated]
			get
			{
				return default(CEMOACKCLEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7703FE0", Offset = "0x77033E0", VA = "0x187703FE0", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7704250", Offset = "0x7703650", VA = "0x187704250")]
		public static bool PEOCKCCHEIN(AvatarItemDownloadableConfig KGCKEJLFPJB, AvatarItemDownloadableConfig HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7704110", Offset = "0x7703510", VA = "0x187704110", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77041E0", Offset = "0x77035E0", VA = "0x1877041E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE316C0", Offset = "0xE30AC0", VA = "0x180E316C0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, OOBOEDGJKIN, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7708DF0", Offset = "0x77081F0", VA = "0x187708DF0")]
		private void AODLCKOIALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7708E80", Offset = "0x7708280", VA = "0x187708E80", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7708F00", Offset = "0x7708300", VA = "0x187708F00", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7708DF0", Offset = "0x77081F0", VA = "0x187708DF0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7709000", Offset = "0x7708400", VA = "0x187709000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JIKOENOOKBO : GNKEGOAIBDC<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FBJBEHHDLAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FBJBEHHDLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77062E0", Offset = "0x77056E0", VA = "0x1877062E0")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7706850", Offset = "0x7705C50", VA = "0x187706850")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77067A0", Offset = "0x7705BA0", VA = "0x1877067A0")]
		internal void LNLNMACMLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77064F0", Offset = "0x77058F0", VA = "0x1877064F0")]
		internal void HGPEJLMKFCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7706390", Offset = "0x7705790", VA = "0x187706390")]
		internal void CGAMCKCPFJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77065A0", Offset = "0x77059A0", VA = "0x1877065A0")]
		internal void JFGEMGJENCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7706440", Offset = "0x7705840", VA = "0x187706440")]
		internal void FIDKAOJOFIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7706650", Offset = "0x7705A50", VA = "0x187706650")]
		internal void KCDIGNIGAAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7706700", Offset = "0x7705B00", VA = "0x187706700")]
		internal void LIOPHCIFMPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7706900", Offset = "0x7705D00", VA = "0x187706900")]
		internal void MPKIFDMIDGC(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ADDFBIFDBNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77075E0", Offset = "0x77069E0", VA = "0x1877075E0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, AnchorParamsRestrictions MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7707B00", Offset = "0x7706F00", VA = "0x187707B00", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, AnchorParamsRestrictions FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7707FA0", Offset = "0x77073A0", VA = "0x187707FA0")]
	public JIKOENOOKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x367B5F0", Offset = "0x367A9F0", VA = "0x18367B5F0")]
	[CompilerGenerated]
	internal static void NLEGFGCKOLM<T>(string MOIADMOIDPH, T PCJCDFNKKKE, T KFNAEGPBIND, ADDFBIFDBNP P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AMJKCMHGDHC : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void KDCPCGNKGAJ(Utf8JsonReader IEDBNFIMLNL);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CDJBMKDGPAJ
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
		public AMJKCMHGDHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KDCPCGNKGAJ <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KDCPCGNKGAJ <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KDCPCGNKGAJ <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KDCPCGNKGAJ <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KDCPCGNKGAJ <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KDCPCGNKGAJ <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KDCPCGNKGAJ <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KDCPCGNKGAJ <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KDCPCGNKGAJ <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KDCPCGNKGAJ <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KDCPCGNKGAJ <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CDJBMKDGPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7705680", Offset = "0x7704A80", VA = "0x187705680")]
		internal void ONCADNCPJIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7705520", Offset = "0x7704920", VA = "0x187705520")]
		internal void OBGPOEBAGNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77056C0", Offset = "0x7704AC0", VA = "0x1877056C0")]
		internal void PFCJDIOPGBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77055D0", Offset = "0x77049D0", VA = "0x1877055D0")]
		internal void OHECJCAICEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7705470", Offset = "0x7704870", VA = "0x187705470")]
		internal void MBPOBCLCDJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7705080", Offset = "0x7704480", VA = "0x187705080")]
		internal void AACJEKHBDLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7705230", Offset = "0x7704630", VA = "0x187705230")]
		internal void FGLMBELKNDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7705150", Offset = "0x7704550", VA = "0x187705150")]
		internal void DGJNIEDCMIJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x77052B0", Offset = "0x77046B0", VA = "0x1877052B0")]
		internal void LMKBINKALCH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77050B0", Offset = "0x77044B0", VA = "0x1877050B0")]
		internal void AEGIKKHJGPJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77052F0", Offset = "0x77046F0", VA = "0x1877052F0")]
		internal void MAIOBBJPIPK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LLPALHGLGBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LLPALHGLGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7708280", Offset = "0x7707680", VA = "0x187708280")]
		internal void MCDBMADMOHH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7702F60", Offset = "0x7702360", VA = "0x187702F60", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7703B60", Offset = "0x7702F60", VA = "0x187703B60", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, SerializedAvatarItemData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7702DF0", Offset = "0x77021F0", VA = "0x187702DF0")]
	private AdditionalOutfitTypeData ACIDOAMMJGH(Utf8JsonReader HGFGHNJEEAJ, OutfitType HAFNBBNOLPO, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7703FA0", Offset = "0x77033A0", VA = "0x187703FA0")]
	public AMJKCMHGDHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MGMFJDLLKGP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7708320", Offset = "0x7707720", VA = "0x187708320", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77086B0", Offset = "0x7707AB0", VA = "0x1877086B0", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, AvatarItemDownloadableConfig FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x77087E0", Offset = "0x7707BE0", VA = "0x1877087E0")]
	public MGMFJDLLKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FFMECBMKJEN : GNKEGOAIBDC<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77069A0", Offset = "0x7705DA0", VA = "0x1877069A0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, BeardData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7706B40", Offset = "0x7705F40", VA = "0x187706B40", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, BeardData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7706C00", Offset = "0x7706000", VA = "0x187706C00")]
	public FFMECBMKJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HCBKINHJHHO : ONJIGMEGOAE<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7707430", Offset = "0x7706830", VA = "0x187707430")]
	public HCBKINHJHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IFGNJAHGCIA : ONJIGMEGOAE<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77075A0", Offset = "0x77069A0", VA = "0x1877075A0")]
	public IFGNJAHGCIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AEIHNIOJEOP : ONJIGMEGOAE<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7702DB0", Offset = "0x77021B0", VA = "0x187702DB0")]
	public AEIHNIOJEOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BDDHFKAGOIA : NMFNFBPBDIM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7704B70", Offset = "0x7703F70", VA = "0x187704B70")]
	public BDDHFKAGOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JMKNMNFKJNL : GNKEGOAIBDC<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DKEAHCBGFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DKEAHCBGFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77058C0", Offset = "0x7704CC0", VA = "0x1877058C0")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7705BA0", Offset = "0x7704FA0", VA = "0x187705BA0")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7707FE0", Offset = "0x77073E0", VA = "0x187707FE0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, AdditionalFeetData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7708170", Offset = "0x7707570", VA = "0x187708170", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, AdditionalFeetData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7708240", Offset = "0x7707640", VA = "0x187708240")]
	public JMKNMNFKJNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EDKJBECGIID : GNKEGOAIBDC<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CDJMKLICOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CDJMKLICOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7705770", Offset = "0x7704B70", VA = "0x187705770")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7705A60", Offset = "0x7704E60", VA = "0x187705A60")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7705A30", Offset = "0x7704E30", VA = "0x187705A30")]
		internal void LNLNMACMLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77058F0", Offset = "0x7704CF0", VA = "0x1877058F0")]
		internal void HGPEJLMKFCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7705820", Offset = "0x7704C20", VA = "0x187705820")]
		internal void CGAMCKCPFJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7705990", Offset = "0x7704D90", VA = "0x187705990")]
		internal void JFGEMGJENCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77058C0", Offset = "0x7704CC0", VA = "0x1877058C0")]
		internal void FIDKAOJOFIA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7705BD0", Offset = "0x7704FD0", VA = "0x187705BD0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, HairData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7705FC0", Offset = "0x77053C0", VA = "0x187705FC0", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, HairData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x77062A0", Offset = "0x77056A0", VA = "0x1877062A0")]
	public EDKJBECGIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FOOLGGNBPJB : GNKEGOAIBDC<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BNCBIMMKPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BNCBIMMKPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7704BB0", Offset = "0x7703FB0", VA = "0x187704BB0")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7704FD0", Offset = "0x77043D0", VA = "0x187704FD0")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7704F20", Offset = "0x7704320", VA = "0x187704F20")]
		internal void LNLNMACMLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7704D30", Offset = "0x7704130", VA = "0x187704D30")]
		internal void HGPEJLMKFCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7704BE0", Offset = "0x7703FE0", VA = "0x187704BE0")]
		internal void CGAMCKCPFJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7704DE0", Offset = "0x77041E0", VA = "0x187704DE0")]
		internal void JFGEMGJENCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7704C90", Offset = "0x7704090", VA = "0x187704C90")]
		internal void FIDKAOJOFIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7704E80", Offset = "0x7704280", VA = "0x187704E80")]
		internal void KCDIGNIGAAG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7706C40", Offset = "0x7706040", VA = "0x187706C40", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, AdditionalHatData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77070A0", Offset = "0x77064A0", VA = "0x1877070A0", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, AdditionalHatData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77073F0", Offset = "0x77067F0", VA = "0x1877073F0")]
	public FOOLGGNBPJB()
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
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x99F360", Offset = "0x99E760", VA = "0x18099F360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD09A80", Offset = "0xD08E80", VA = "0x180D09A80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9FECE0", Offset = "0x9FE0E0", VA = "0x1809FECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD09A70", Offset = "0xD08E70", VA = "0x180D09A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD09A40", Offset = "0xD08E40", VA = "0x180D09A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE4B900", Offset = "0xE4AD00", VA = "0x180E4B900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xE4B990", Offset = "0xE4AD90", VA = "0x180E4B990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1E1DE60", Offset = "0x1E1D260", VA = "0x181E1DE60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7708DE0", Offset = "0x77081E0", VA = "0x187708DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2A1FF60", Offset = "0x2A1F360", VA = "0x182A1FF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2A201A0", Offset = "0x2A1F5A0", VA = "0x182A201A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC092F0", Offset = "0xC086F0", VA = "0x180C092F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC09340", Offset = "0xC08740", VA = "0x180C09340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JBHNNEJDMMC.KMAIJNBJDFP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0")]
			[CompilerGenerated]
			get
			{
				return default(JBHNNEJDMMC.KMAIJNBJDFP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6B26F00", Offset = "0x6B26300", VA = "0x186B26F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x993AD0", Offset = "0x992ED0", VA = "0x180993AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7708910", Offset = "0x7707D10", VA = "0x187708910", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7708DC0", Offset = "0x77081C0", VA = "0x187708DC0")]
		public static bool PEOCKCCHEIN(SerializedAvatarItemData KGCKEJLFPJB, SerializedAvatarItemData HKELKGIPNGP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7708D90", Offset = "0x7708190", VA = "0x187708D90")]
		public static bool OGMAAAEFFPP(SerializedAvatarItemData KGCKEJLFPJB, SerializedAvatarItemData HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x77089A0", Offset = "0x7707DA0", VA = "0x1877089A0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7708CC0", Offset = "0x77080C0", VA = "0x187708CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
