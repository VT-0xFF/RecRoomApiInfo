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
public class CGFJNPKNDNA : DIKNOIDHBIM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCF7480", Offset = "0xCF5E80", VA = "0x180CF7480", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x816E570", Offset = "0x816CF70", VA = "0x18816E570", Slot = "36")]
	protected override Vector3 NLAPJHIELFO(float[] EJKNLPOFFNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x816E4F0", Offset = "0x816CEF0", VA = "0x18816E4F0", Slot = "37")]
	protected override float[] DGBABFIBOIC(Vector3 PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x816E5C0", Offset = "0x816CFC0", VA = "0x18816E5C0")]
	public CGFJNPKNDNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DLNJBHIFPOD : DIKNOIDHBIM<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD0FF90", Offset = "0xD0E990", VA = "0x180D0FF90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x816F270", Offset = "0x816DC70", VA = "0x18816F270", Slot = "36")]
	protected override Vector2 NLAPJHIELFO(float[] EJKNLPOFFNN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x816F200", Offset = "0x816DC00", VA = "0x18816F200", Slot = "37")]
	protected override float[] DGBABFIBOIC(Vector2 PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x816F2B0", Offset = "0x816DCB0", VA = "0x18816F2B0")]
	public DLNJBHIFPOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class POKOAEJEALE : DIKNOIDHBIM<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB74850", Offset = "0xB73250", VA = "0x180B74850", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81731B0", Offset = "0x8171BB0", VA = "0x1881731B0", Slot = "36")]
	protected override Quaternion NLAPJHIELFO(float[] EJKNLPOFFNN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8173120", Offset = "0x8171B20", VA = "0x188173120", Slot = "37")]
	protected override float[] DGBABFIBOIC(Quaternion PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8173210", Offset = "0x8171C10", VA = "0x188173210")]
	public POKOAEJEALE()
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
		public enum DJCNNBGJLPD
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
		public DJCNNBGJLPD Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
			[CompilerGenerated]
			get
			{
				return default(DJCNNBGJLPD);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x816D4E0", Offset = "0x816BEE0", VA = "0x18816D4E0", Slot = "0")]
		public override bool Equals(object EFNHKCDKOGH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x816D750", Offset = "0x816C150", VA = "0x18816D750")]
		public static bool JJNADAGGMDE(AvatarItemDownloadableConfig OKDCNKNEMHO, AvatarItemDownloadableConfig AAJFLFEAFBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x816D610", Offset = "0x816C010", VA = "0x18816D610", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x816D6E0", Offset = "0x816C0E0", VA = "0x18816D6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1068760", Offset = "0x1067160", VA = "0x181068760")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, GHCCIAMMCFG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8173730", Offset = "0x8172130", VA = "0x188173730")]
		private void BFGPKPKBFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81737C0", Offset = "0x81721C0", VA = "0x1881737C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8173840", Offset = "0x8172240", VA = "0x188173840", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8173730", Offset = "0x8172130", VA = "0x188173730", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8173940", Offset = "0x8172340", VA = "0x188173940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EFFFLFFJHKN : EJPKHNGHKON<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DAPBMNGDNJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DAPBMNGDNJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x816EB60", Offset = "0x816D560", VA = "0x18816EB60")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x816E800", Offset = "0x816D200", VA = "0x18816E800")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x816EC10", Offset = "0x816D610", VA = "0x18816EC10")]
		internal void OALMGPFMKCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x816EAB0", Offset = "0x816D4B0", VA = "0x18816EAB0")]
		internal void KGMFCAFFPLG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x816E750", Offset = "0x816D150", VA = "0x18816E750")]
		internal void DNHJLCKGKMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x816E950", Offset = "0x816D350", VA = "0x18816E950")]
		internal void GPNJJAGAIMC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x816EA00", Offset = "0x816D400", VA = "0x18816EA00")]
		internal void HJDCNPDOIIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x816E6A0", Offset = "0x816D0A0", VA = "0x18816E6A0")]
		internal void CHHGFGFKCHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x816E600", Offset = "0x816D000", VA = "0x18816E600")]
		internal void ACGKLAHCEEA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x816E8B0", Offset = "0x816D2B0", VA = "0x18816E8B0")]
		internal void FNKAKLBJBHN(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IAJDBPNIINH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x816FB00", Offset = "0x816E500", VA = "0x18816FB00", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, AnchorParamsRestrictions HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x816F660", Offset = "0x816E060", VA = "0x18816F660", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, AnchorParamsRestrictions PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8170020", Offset = "0x816EA20", VA = "0x188170020")]
	public EFFFLFFJHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFC50", Offset = "0x3ADE650", VA = "0x183ADFC50")]
	[CompilerGenerated]
	internal static void FFAMKFINLII<T>(string GGDGFENODPM, T BEAEDIJJJJI, T HNNMFJCLHKJ, IAJDBPNIINH P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MEIFEPHHBBL : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void OHEEADBBDFM(Utf8JsonReader PENFKHFIGID);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PHECFNHLJAI
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
		public MEIFEPHHBBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public OHEEADBBDFM <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OHEEADBBDFM <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public OHEEADBBDFM <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OHEEADBBDFM <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OHEEADBBDFM <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OHEEADBBDFM <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OHEEADBBDFM <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OHEEADBBDFM <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OHEEADBBDFM <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OHEEADBBDFM <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OHEEADBBDFM <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PHECFNHLJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8172F40", Offset = "0x8171940", VA = "0x188172F40")]
		internal void GIJPDONCCAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8172B90", Offset = "0x8171590", VA = "0x188172B90")]
		internal void DAHJGNDBPKH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8172CE0", Offset = "0x81716E0", VA = "0x188172CE0")]
		internal void DKBHJJGFMLM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8172E40", Offset = "0x8171840", VA = "0x188172E40")]
		internal void FCAOPONHLJN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8172D90", Offset = "0x8171790", VA = "0x188172D90")]
		internal void EMDHGKCPGJI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8172B60", Offset = "0x8171560", VA = "0x188172B60")]
		internal void ABPJNKAAGDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81730A0", Offset = "0x8171AA0", VA = "0x1881730A0")]
		internal void PGKAKJDPJKO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8172FC0", Offset = "0x81719C0", VA = "0x188172FC0")]
		internal void LHECEHLJEFI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8172F80", Offset = "0x8171980", VA = "0x188172F80")]
		internal void HEHCNBJGDPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8172C40", Offset = "0x8171640", VA = "0x188172C40")]
		internal void DHMPKLOPDMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8172EF0", Offset = "0x81718F0", VA = "0x188172EF0")]
		internal void FIHDHGGFJEO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AJLOMEOHONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AJLOMEOHONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x816CF70", Offset = "0x816B970", VA = "0x18816CF70")]
		internal void IONFAELLEGI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8171730", Offset = "0x8170130", VA = "0x188171730", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8172330", Offset = "0x8170D30", VA = "0x188172330", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, SerializedAvatarItemData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81714E0", Offset = "0x816FEE0", VA = "0x1881714E0")]
	private AdditionalOutfitTypeData OLEFBDPNDDI(Utf8JsonReader IOMONBOBJAC, OutfitType AEOGKDPPBBE, JsonSerializerOptions HHMKDMNANOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8172770", Offset = "0x8171170", VA = "0x188172770")]
	public MEIFEPHHBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DIKALHJDBCJ : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x816ED00", Offset = "0x816D700", VA = "0x18816ED00", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader IOMONBOBJAC, Type AGMDDAMPCMG, JsonSerializerOptions HHMKDMNANOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x816F090", Offset = "0x816DA90", VA = "0x18816F090", Slot = "28")]
	public override void Write(Utf8JsonWriter ADMHNJGGGLG, AvatarItemDownloadableConfig PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x816F1C0", Offset = "0x816DBC0", VA = "0x18816F1C0")]
	public DIKALHJDBCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NDKOAPFEKHN : EJPKHNGHKON<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81728B0", Offset = "0x81712B0", VA = "0x1881728B0", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, BeardData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81727F0", Offset = "0x81711F0", VA = "0x1881727F0", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, BeardData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8172A50", Offset = "0x8171450", VA = "0x188172A50")]
	public NDKOAPFEKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MEJLCNJBAAL : AHMDCBDPGAD<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81727B0", Offset = "0x81711B0", VA = "0x1881727B0")]
	public MEJLCNJBAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EODHEGEFCAB : AHMDCBDPGAD<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8170060", Offset = "0x816EA60", VA = "0x188170060")]
	public EODHEGEFCAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHBFPOJHDGO : AHMDCBDPGAD<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x816ECC0", Offset = "0x816D6C0", VA = "0x18816ECC0")]
	public DHBFPOJHDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FAIOMOGCJEK : HANBNBGDNHB<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81700A0", Offset = "0x816EAA0", VA = "0x1881700A0")]
	public FAIOMOGCJEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KHEEPFOGLMP : EJPKHNGHKON<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PAKFMGHJGCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PAKFMGHJGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x816E340", Offset = "0x816CD40", VA = "0x18816E340")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8172B30", Offset = "0x8171530", VA = "0x188172B30")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81710B0", Offset = "0x816FAB0", VA = "0x1881710B0", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, AdditionalFeetData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8170FE0", Offset = "0x816F9E0", VA = "0x188170FE0", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, AdditionalFeetData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8171240", Offset = "0x816FC40", VA = "0x188171240")]
	public KHEEPFOGLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HABHIEEAELK : EJPKHNGHKON<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BEBHINDFDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BEBHINDFDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x816E410", Offset = "0x816CE10", VA = "0x18816E410")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x816E270", Offset = "0x816CC70", VA = "0x18816E270")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x816E4C0", Offset = "0x816CEC0", VA = "0x18816E4C0")]
		internal void OALMGPFMKCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x816E370", Offset = "0x816CD70", VA = "0x18816E370")]
		internal void KGMFCAFFPLG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x816E1D0", Offset = "0x816CBD0", VA = "0x18816E1D0")]
		internal void DNHJLCKGKMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x816E2A0", Offset = "0x816CCA0", VA = "0x18816E2A0")]
		internal void GPNJJAGAIMC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x816E340", Offset = "0x816CD40", VA = "0x18816E340")]
		internal void HJDCNPDOIIE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x81703C0", Offset = "0x816EDC0", VA = "0x1881703C0", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, HairData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x81700E0", Offset = "0x816EAE0", VA = "0x1881700E0", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, HairData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81707B0", Offset = "0x816F1B0", VA = "0x1881707B0")]
	public HABHIEEAELK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IOEANHEJDHL : EJPKHNGHKON<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ALNENIBOONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ALNENIBOONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x816D400", Offset = "0x816BE00", VA = "0x18816D400")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x816D160", Offset = "0x816BB60", VA = "0x18816D160")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x816D430", Offset = "0x816BE30", VA = "0x18816D430")]
		internal void OALMGPFMKCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x816D350", Offset = "0x816BD50", VA = "0x18816D350")]
		internal void KGMFCAFFPLG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x816D0B0", Offset = "0x816BAB0", VA = "0x18816D0B0")]
		internal void DNHJLCKGKMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x816D210", Offset = "0x816BC10", VA = "0x18816D210")]
		internal void GPNJJAGAIMC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x816D2B0", Offset = "0x816BCB0", VA = "0x18816D2B0")]
		internal void HJDCNPDOIIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x816D010", Offset = "0x816BA10", VA = "0x18816D010")]
		internal void CHHGFGFKCHB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8170B40", Offset = "0x816F540", VA = "0x188170B40", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, AdditionalHatData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81707F0", Offset = "0x816F1F0", VA = "0x1881707F0", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, AdditionalHatData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8170FA0", Offset = "0x816F9A0", VA = "0x188170FA0")]
	public IOEANHEJDHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AFDKKLONIIC : EJPKHNGHKON<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GMFGKNDCHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GMFGKNDCHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x816EB60", Offset = "0x816D560", VA = "0x18816EB60")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x816F2F0", Offset = "0x816DCF0", VA = "0x18816F2F0")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x816CDA0", Offset = "0x816B7A0", VA = "0x18816CDA0", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, RoomieEyeData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x816CD10", Offset = "0x816B710", VA = "0x18816CD10", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, RoomieEyeData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x816CF30", Offset = "0x816B930", VA = "0x18816CF30")]
	public AFDKKLONIIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EEHKPBLBEDG : EJPKHNGHKON<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NICNPMGBHOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NICNPMGBHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x816EB60", Offset = "0x816D560", VA = "0x18816EB60")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x816F2F0", Offset = "0x816DCF0", VA = "0x18816F2F0")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8172A90", Offset = "0x8171490", VA = "0x188172A90")]
		internal void OALMGPFMKCI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x816F430", Offset = "0x816DE30", VA = "0x18816F430", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, RoomieHatData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x816F330", Offset = "0x816DD30", VA = "0x18816F330", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, RoomieHatData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x816F620", Offset = "0x816E020", VA = "0x18816F620")]
	public EEHKPBLBEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LEDEILNLJLK : EJPKHNGHKON<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EADBBKHCLBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EADBBKHCLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x816EB60", Offset = "0x816D560", VA = "0x18816EB60")]
		internal void LPOIMOOMOBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x816F2F0", Offset = "0x816DCF0", VA = "0x18816F2F0")]
		internal void DPICHMKNAMH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8171310", Offset = "0x816FD10", VA = "0x188171310", Slot = "35")]
	public override void OHKNCBMFCDL(Utf8JsonReader IOMONBOBJAC, JsonSerializerOptions HHMKDMNANOF, string GGDGFENODPM, RoomieWaistData HNLFGCKBFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8171280", Offset = "0x816FC80", VA = "0x188171280", Slot = "36")]
	public override void KJELEOLBOHB(Utf8JsonWriter ADMHNJGGGLG, RoomieWaistData PDKJBMPOMNC, JsonSerializerOptions HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81714A0", Offset = "0x816FEA0", VA = "0x1881714A0")]
	public LEDEILNLJLK()
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
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xF33880", Offset = "0xF32280", VA = "0x180F33880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xF33890", Offset = "0xF32290", VA = "0x180F33890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1081F40", Offset = "0x1080940", VA = "0x181081F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1081F90", Offset = "0x1080990", VA = "0x181081F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x223FB40", Offset = "0x223E540", VA = "0x18223FB40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8173720", Offset = "0x8172120", VA = "0x188173720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2E92EA0", Offset = "0x2E918A0", VA = "0x182E92EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2E92DE0", Offset = "0x2E917E0", VA = "0x182E92DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD4230", Offset = "0xAD2C30", VA = "0x180AD4230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAD4240", Offset = "0xAD2C40", VA = "0x180AD4240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EAIOHGIPLKL.BKMDKGNIEFL ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
			[CompilerGenerated]
			get
			{
				return default(EAIOHGIPLKL.BKMDKGNIEFL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x13AB4E0", Offset = "0x13A9EE0", VA = "0x1813AB4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8173280", Offset = "0x8171C80", VA = "0x188173280", Slot = "0")]
		public override bool Equals(object EFNHKCDKOGH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8173700", Offset = "0x8172100", VA = "0x188173700")]
		public static bool JJNADAGGMDE(SerializedAvatarItemData OKDCNKNEMHO, SerializedAvatarItemData AAJFLFEAFBA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8173250", Offset = "0x8171C50", VA = "0x188173250")]
		public static bool CNNLEBNJPBE(SerializedAvatarItemData OKDCNKNEMHO, SerializedAvatarItemData AAJFLFEAFBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8173310", Offset = "0x8171D10", VA = "0x188173310", Slot = "4")]
		public bool Equals(SerializedAvatarItemData EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8173630", Offset = "0x8172030", VA = "0x188173630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
