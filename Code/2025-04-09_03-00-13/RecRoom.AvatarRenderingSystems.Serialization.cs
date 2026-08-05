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
		[Cpp2IlInjected.Address(RVA = "0xB0A470", Offset = "0xB09870", VA = "0x180B0A470", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7752D20", Offset = "0x7752120", VA = "0x187752D20", Slot = "36")]
	protected override Vector3 KGKMLPCLAEP(float[] JGMAGBDHLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7752CA0", Offset = "0x77520A0", VA = "0x187752CA0", Slot = "37")]
	protected override float[] CNGHJFEEEPF(Vector3 FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7752D70", Offset = "0x7752170", VA = "0x187752D70")]
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
		[Cpp2IlInjected.Address(RVA = "0xB222B0", Offset = "0xB216B0", VA = "0x180B222B0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7755A70", Offset = "0x7754E70", VA = "0x187755A70", Slot = "36")]
	protected override Vector2 KGKMLPCLAEP(float[] JGMAGBDHLIF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7755A00", Offset = "0x7754E00", VA = "0x187755A00", Slot = "37")]
	protected override float[] CNGHJFEEEPF(Vector2 FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7755AB0", Offset = "0x7754EB0", VA = "0x187755AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB218D0", Offset = "0xB20CD0", VA = "0x180B218D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77546F0", Offset = "0x7753AF0", VA = "0x1877546F0", Slot = "36")]
	protected override Quaternion KGKMLPCLAEP(float[] JGMAGBDHLIF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7754660", Offset = "0x7753A60", VA = "0x187754660", Slot = "37")]
	protected override float[] CNGHJFEEEPF(Quaternion FFOEEMKIKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7754750", Offset = "0x7753B50", VA = "0x187754750")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
			[CompilerGenerated]
			get
			{
				return default(CEMOACKCLEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77511F0", Offset = "0x77505F0", VA = "0x1877511F0", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7751460", Offset = "0x7750860", VA = "0x187751460")]
		public static bool PEOCKCCHEIN(AvatarItemDownloadableConfig KGCKEJLFPJB, AvatarItemDownloadableConfig HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7751320", Offset = "0x7750720", VA = "0x187751320", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77513F0", Offset = "0x77507F0", VA = "0x1877513F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE35DF0", Offset = "0xE351F0", VA = "0x180E35DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7755FC0", Offset = "0x77553C0", VA = "0x187755FC0")]
		private void AODLCKOIALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7756050", Offset = "0x7755450", VA = "0x187756050", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77560D0", Offset = "0x77554D0", VA = "0x1877560D0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7755FC0", Offset = "0x77553C0", VA = "0x187755FC0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77561D0", Offset = "0x77555D0", VA = "0x1877561D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FBJBEHHDLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77534E0", Offset = "0x77528E0", VA = "0x1877534E0")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7753A50", Offset = "0x7752E50", VA = "0x187753A50")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77539A0", Offset = "0x7752DA0", VA = "0x1877539A0")]
		internal void LNLNMACMLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77536F0", Offset = "0x7752AF0", VA = "0x1877536F0")]
		internal void HGPEJLMKFCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7753590", Offset = "0x7752990", VA = "0x187753590")]
		internal void CGAMCKCPFJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77537A0", Offset = "0x7752BA0", VA = "0x1877537A0")]
		internal void JFGEMGJENCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7753640", Offset = "0x7752A40", VA = "0x187753640")]
		internal void FIDKAOJOFIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7753850", Offset = "0x7752C50", VA = "0x187753850")]
		internal void KCDIGNIGAAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7753900", Offset = "0x7752D00", VA = "0x187753900")]
		internal void LIOPHCIFMPO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7753B00", Offset = "0x7752F00", VA = "0x187753B00")]
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
	[Cpp2IlInjected.Address(RVA = "0x77547D0", Offset = "0x7753BD0", VA = "0x1877547D0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, AnchorParamsRestrictions MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7754CF0", Offset = "0x77540F0", VA = "0x187754CF0", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, AnchorParamsRestrictions FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7755180", Offset = "0x7754580", VA = "0x187755180")]
	public JIKOENOOKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x368E9B0", Offset = "0x368DDB0", VA = "0x18368E9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CDJBMKDGPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7752890", Offset = "0x7751C90", VA = "0x187752890")]
		internal void ONCADNCPJIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7752730", Offset = "0x7751B30", VA = "0x187752730")]
		internal void OBGPOEBAGNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77528D0", Offset = "0x7751CD0", VA = "0x1877528D0")]
		internal void PFCJDIOPGBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77527E0", Offset = "0x7751BE0", VA = "0x1877527E0")]
		internal void OHECJCAICEI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7752680", Offset = "0x7751A80", VA = "0x187752680")]
		internal void MBPOBCLCDJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7752290", Offset = "0x7751690", VA = "0x187752290")]
		internal void AACJEKHBDLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7752440", Offset = "0x7751840", VA = "0x187752440")]
		internal void FGLMBELKNDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7752360", Offset = "0x7751760", VA = "0x187752360")]
		internal void DGJNIEDCMIJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x77524C0", Offset = "0x77518C0", VA = "0x1877524C0")]
		internal void LMKBINKALCH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77522C0", Offset = "0x77516C0", VA = "0x1877522C0")]
		internal void AEGIKKHJGPJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7752500", Offset = "0x7751900", VA = "0x187752500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LLPALHGLGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7755460", Offset = "0x7754860", VA = "0x187755460")]
		internal void MCDBMADMOHH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7750190", Offset = "0x774F590", VA = "0x187750190", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7750D70", Offset = "0x7750170", VA = "0x187750D70", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, SerializedAvatarItemData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7750020", Offset = "0x774F420", VA = "0x187750020")]
	private AdditionalOutfitTypeData ACIDOAMMJGH(Utf8JsonReader HGFGHNJEEAJ, OutfitType HAFNBBNOLPO, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77511B0", Offset = "0x77505B0", VA = "0x1877511B0")]
	public AMJKCMHGDHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MGMFJDLLKGP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7755500", Offset = "0x7754900", VA = "0x187755500", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader HGFGHNJEEAJ, Type BAHMAABNKAJ, JsonSerializerOptions FBCMGOKFCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7755890", Offset = "0x7754C90", VA = "0x187755890", Slot = "28")]
	public override void Write(Utf8JsonWriter CEAJPINGICH, AvatarItemDownloadableConfig FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x77559C0", Offset = "0x7754DC0", VA = "0x1877559C0")]
	public MGMFJDLLKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FFMECBMKJEN : GNKEGOAIBDC<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7753BA0", Offset = "0x7752FA0", VA = "0x187753BA0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, BeardData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7753D40", Offset = "0x7753140", VA = "0x187753D40", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, BeardData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7753E00", Offset = "0x7753200", VA = "0x187753E00")]
	public FFMECBMKJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HCBKINHJHHO : ONJIGMEGOAE<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7754620", Offset = "0x7753A20", VA = "0x187754620")]
	public HCBKINHJHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IFGNJAHGCIA : ONJIGMEGOAE<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7754790", Offset = "0x7753B90", VA = "0x187754790")]
	public IFGNJAHGCIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AEIHNIOJEOP : ONJIGMEGOAE<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x774FFE0", Offset = "0x774F3E0", VA = "0x18774FFE0")]
	public AEIHNIOJEOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BDDHFKAGOIA : NMFNFBPBDIM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7751D80", Offset = "0x7751180", VA = "0x187751D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DKEAHCBGFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7752AD0", Offset = "0x7751ED0", VA = "0x187752AD0")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7752DB0", Offset = "0x77521B0", VA = "0x187752DB0")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77551C0", Offset = "0x77545C0", VA = "0x1877551C0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, AdditionalFeetData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7755350", Offset = "0x7754750", VA = "0x187755350", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, AdditionalFeetData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7755420", Offset = "0x7754820", VA = "0x187755420")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CDJMKLICOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7752980", Offset = "0x7751D80", VA = "0x187752980")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7752C70", Offset = "0x7752070", VA = "0x187752C70")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7752C40", Offset = "0x7752040", VA = "0x187752C40")]
		internal void LNLNMACMLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7752B00", Offset = "0x7751F00", VA = "0x187752B00")]
		internal void HGPEJLMKFCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7752A30", Offset = "0x7751E30", VA = "0x187752A30")]
		internal void CGAMCKCPFJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7752BA0", Offset = "0x7751FA0", VA = "0x187752BA0")]
		internal void JFGEMGJENCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7752AD0", Offset = "0x7751ED0", VA = "0x187752AD0")]
		internal void FIDKAOJOFIA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7752DE0", Offset = "0x77521E0", VA = "0x187752DE0", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, HairData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x77531D0", Offset = "0x77525D0", VA = "0x1877531D0", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, HairData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x77534A0", Offset = "0x77528A0", VA = "0x1877534A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BNCBIMMKPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7751DC0", Offset = "0x77511C0", VA = "0x187751DC0")]
		internal void ANDBHDBMINE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77521E0", Offset = "0x77515E0", VA = "0x1877521E0")]
		internal void MEFBFBFBPHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7752130", Offset = "0x7751530", VA = "0x187752130")]
		internal void LNLNMACMLJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7751F40", Offset = "0x7751340", VA = "0x187751F40")]
		internal void HGPEJLMKFCJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7751DF0", Offset = "0x77511F0", VA = "0x187751DF0")]
		internal void CGAMCKCPFJM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7751FF0", Offset = "0x77513F0", VA = "0x187751FF0")]
		internal void JFGEMGJENCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7751EA0", Offset = "0x77512A0", VA = "0x187751EA0")]
		internal void FIDKAOJOFIA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7752090", Offset = "0x7751490", VA = "0x187752090")]
		internal void KCDIGNIGAAG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7753E40", Offset = "0x7753240", VA = "0x187753E40", Slot = "35")]
	public override void GHEPAAHHJKI(Utf8JsonReader HGFGHNJEEAJ, JsonSerializerOptions FBCMGOKFCPJ, string MOIADMOIDPH, AdditionalHatData MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77542A0", Offset = "0x77536A0", VA = "0x1877542A0", Slot = "36")]
	public override void MJMKNDDBJFF(Utf8JsonWriter CEAJPINGICH, AdditionalHatData FFOEEMKIKJO, JsonSerializerOptions FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77545E0", Offset = "0x77539E0", VA = "0x1877545E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9B51D0", Offset = "0x9B45D0", VA = "0x1809B51D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA2A290", Offset = "0xA29690", VA = "0x180A2A290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7B0", Offset = "0xD0DBB0", VA = "0x180D0E7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD0E780", Offset = "0xD0DB80", VA = "0x180D0E780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE4F820", Offset = "0xE4EC20", VA = "0x180E4F820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xE4F8B0", Offset = "0xE4ECB0", VA = "0x180E4F8B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1E2DED0", Offset = "0x1E2D2D0", VA = "0x181E2DED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7755FB0", Offset = "0x77553B0", VA = "0x187755FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2A1E670", Offset = "0x2A1DA70", VA = "0x182A1E670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2A1E8A0", Offset = "0x2A1DCA0", VA = "0x182A1E8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC0FBE0", Offset = "0xC0EFE0", VA = "0x180C0FBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC0FC30", Offset = "0xC0F030", VA = "0x180C0FC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JBHNNEJDMMC.KMAIJNBJDFP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390")]
			[CompilerGenerated]
			get
			{
				return default(JBHNNEJDMMC.KMAIJNBJDFP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6B81730", Offset = "0x6B80B30", VA = "0x186B81730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9A9AC0", Offset = "0x9A8EC0", VA = "0x1809A9AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7755AF0", Offset = "0x7754EF0", VA = "0x187755AF0", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7755F90", Offset = "0x7755390", VA = "0x187755F90")]
		public static bool PEOCKCCHEIN(SerializedAvatarItemData KGCKEJLFPJB, SerializedAvatarItemData HKELKGIPNGP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7755F60", Offset = "0x7755360", VA = "0x187755F60")]
		public static bool OGMAAAEFFPP(SerializedAvatarItemData KGCKEJLFPJB, SerializedAvatarItemData HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7755B70", Offset = "0x7754F70", VA = "0x187755B70", Slot = "4")]
		public bool Equals(SerializedAvatarItemData KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7755E90", Offset = "0x7755290", VA = "0x187755E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
