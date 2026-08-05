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
public class HAHBKPOIKKK : ICDHHLOFGEF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE90", Offset = "0xA5BA90", VA = "0x180A5CE90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7342180", Offset = "0x7340D80", VA = "0x187342180", Slot = "36")]
	protected override Vector3 MOHDGEOMNJO(float[] FKBJBKHIAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7342100", Offset = "0x7340D00", VA = "0x187342100", Slot = "37")]
	protected override float[] DLCEHOIGCOP(Vector3 MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73421D0", Offset = "0x7340DD0", VA = "0x1873421D0")]
	public HAHBKPOIKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GBELGLKGLBC : ICDHHLOFGEF<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA7F430", Offset = "0xA7E030", VA = "0x180A7F430", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7342080", Offset = "0x7340C80", VA = "0x187342080", Slot = "36")]
	protected override Vector2 MOHDGEOMNJO(float[] FKBJBKHIAAE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7342010", Offset = "0x7340C10", VA = "0x187342010", Slot = "37")]
	protected override float[] DLCEHOIGCOP(Vector2 MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73420C0", Offset = "0x7340CC0", VA = "0x1873420C0")]
	public GBELGLKGLBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KKCFPCHIOFK : ICDHHLOFGEF<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA6E220", Offset = "0xA6CE20", VA = "0x180A6E220", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73427F0", Offset = "0x73413F0", VA = "0x1873427F0", Slot = "36")]
	protected override Quaternion MOHDGEOMNJO(float[] FKBJBKHIAAE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7342760", Offset = "0x7341360", VA = "0x187342760", Slot = "37")]
	protected override float[] DLCEHOIGCOP(Quaternion MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7342850", Offset = "0x7341450", VA = "0x187342850")]
	public KKCFPCHIOFK()
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
		public enum MPNEHPNAPPG
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
		public MPNEHPNAPPG Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0")]
			[CompilerGenerated]
			get
			{
				return default(MPNEHPNAPPG);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x733E3E0", Offset = "0x733CFE0", VA = "0x18733E3E0", Slot = "0")]
		public override bool Equals(object PELBNOCGOOJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x733E650", Offset = "0x733D250", VA = "0x18733E650")]
		public static bool LBLECGDECIN(AvatarItemDownloadableConfig NFOAKNOEKCL, AvatarItemDownloadableConfig AFFPJGJMKFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x733E510", Offset = "0x733D110", VA = "0x18733E510", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x733E5E0", Offset = "0x733D1E0", VA = "0x18733E5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD4DF00", Offset = "0xD4CB00", VA = "0x180D4DF00")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, AECEOFBPHCP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7343760", Offset = "0x7342360", VA = "0x187343760")]
		private void NDFJDCOIFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73435E0", Offset = "0x73421E0", VA = "0x1873435E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7343660", Offset = "0x7342260", VA = "0x187343660", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7343760", Offset = "0x7342360", VA = "0x187343760", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x73437D0", Offset = "0x73423D0", VA = "0x1873437D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EINFNCPIPCL : OIBAMKIBCCD<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ABOGFFMACCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ABOGFFMACCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x733D8D0", Offset = "0x733C4D0", VA = "0x18733D8D0")]
		internal void EKGMBIFCOJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x733DA30", Offset = "0x733C630", VA = "0x18733DA30")]
		internal void FPEKGLHDNBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x733D820", Offset = "0x733C420", VA = "0x18733D820")]
		internal void DBADLEKMHGH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x733D770", Offset = "0x733C370", VA = "0x18733D770")]
		internal void CNBKKDNCNMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x733D980", Offset = "0x733C580", VA = "0x18733D980")]
		internal void FIAIIMELEOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x733DC30", Offset = "0x733C830", VA = "0x18733DC30")]
		internal void OCKFGBLPCAH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x733DAE0", Offset = "0x733C6E0", VA = "0x18733DAE0")]
		internal void GCLGJGNHMPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x733D6C0", Offset = "0x733C2C0", VA = "0x18733D6C0")]
		internal void CJLMHKHLEKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x733DB90", Offset = "0x733C790", VA = "0x18733DB90")]
		internal void JFFBKGKAHFJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x733D620", Offset = "0x733C220", VA = "0x18733D620")]
		internal void AKLDOCHPEIH(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GINBNEINKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7340BA0", Offset = "0x733F7A0", VA = "0x187340BA0", Slot = "35")]
	public override void MGHLIJGHDCD(Utf8JsonReader KLCLFHDKNAH, JsonSerializerOptions DAMABILEGII, string MFGAOHOJBEJ, AnchorParamsRestrictions HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73410C0", Offset = "0x733FCC0", VA = "0x1873410C0", Slot = "36")]
	public override void NNCKNFNCJNA(Utf8JsonWriter DGOPMEPLAFF, AnchorParamsRestrictions MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7341550", Offset = "0x7340150", VA = "0x187341550")]
	public EINFNCPIPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31ECB60", Offset = "0x31EB760", VA = "0x1831ECB60")]
	[CompilerGenerated]
	internal static void ALEBHIINGAN<T>(string MFGAOHOJBEJ, T ODFJOPDFEGP, T JNGDNDGIODI, GINBNEINKAI P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BEEGAFECILH : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void EJHHKJHDCGJ(Utf8JsonReader JLCBCLJGOML);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CFEPGBOJLPH
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
		public BEEGAFECILH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EJHHKJHDCGJ <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EJHHKJHDCGJ <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EJHHKJHDCGJ <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public EJHHKJHDCGJ <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EJHHKJHDCGJ <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EJHHKJHDCGJ <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EJHHKJHDCGJ <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EJHHKJHDCGJ <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EJHHKJHDCGJ <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EJHHKJHDCGJ <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EJHHKJHDCGJ <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CFEPGBOJLPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7340770", Offset = "0x733F370", VA = "0x187340770")]
		internal void MMBEHFDIMPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7340400", Offset = "0x733F000", VA = "0x187340400")]
		internal void DGNHKAPEHCN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73404B0", Offset = "0x733F0B0", VA = "0x1873404B0")]
		internal void DKLOPGDNIAB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x73401D0", Offset = "0x733EDD0", VA = "0x1873401D0")]
		internal void CAODFBJBBBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7340600", Offset = "0x733F200", VA = "0x187340600")]
		internal void JAMAFPOPDMN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7340890", Offset = "0x733F490", VA = "0x187340890")]
		internal void ODBAFOGIOFG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73406B0", Offset = "0x733F2B0", VA = "0x1873406B0")]
		internal void JFDGBDGJLIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73407B0", Offset = "0x733F3B0", VA = "0x1873407B0")]
		internal void NPKJHPCHINK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7340730", Offset = "0x733F330", VA = "0x187340730")]
		internal void KNEPLIPMCGN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7340560", Offset = "0x733F160", VA = "0x187340560")]
		internal void IHCAIJGEEMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7340280", Offset = "0x733EE80", VA = "0x187340280")]
		internal void CEGELMPNKPJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CBICOIIAOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CBICOIIAOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7340130", Offset = "0x733ED30", VA = "0x187340130")]
		internal void FHEDDHKBNKK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x733F0E0", Offset = "0x733DCE0", VA = "0x18733F0E0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x733FCC0", Offset = "0x733E8C0", VA = "0x18733FCC0", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, SerializedAvatarItemData MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x733EF70", Offset = "0x733DB70", VA = "0x18733EF70")]
	private AdditionalOutfitTypeData JKBJJDODDBM(Utf8JsonReader KLCLFHDKNAH, OutfitType ADFFEBFOCBD, JsonSerializerOptions DAMABILEGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73400F0", Offset = "0x733ECF0", VA = "0x1873400F0")]
	public BEEGAFECILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PLCHLGGKLAL : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7342BC0", Offset = "0x73417C0", VA = "0x187342BC0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader KLCLFHDKNAH, Type PINGKJOMFPB, JsonSerializerOptions DAMABILEGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7342F50", Offset = "0x7341B50", VA = "0x187342F50", Slot = "28")]
	public override void Write(Utf8JsonWriter DGOPMEPLAFF, AvatarItemDownloadableConfig MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7343080", Offset = "0x7341C80", VA = "0x187343080")]
	public PLCHLGGKLAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CMBICDMEFMM : OIBAMKIBCCD<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x73408C0", Offset = "0x733F4C0", VA = "0x1873408C0", Slot = "35")]
	public override void MGHLIJGHDCD(Utf8JsonReader KLCLFHDKNAH, JsonSerializerOptions DAMABILEGII, string MFGAOHOJBEJ, BeardData HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7340A60", Offset = "0x733F660", VA = "0x187340A60", Slot = "36")]
	public override void NNCKNFNCJNA(Utf8JsonWriter DGOPMEPLAFF, BeardData MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7340B20", Offset = "0x733F720", VA = "0x187340B20")]
	public CMBICDMEFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CMEPONDELEO : HMDAPEKOIMB<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7340B60", Offset = "0x733F760", VA = "0x187340B60")]
	public CMEPONDELEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IKDJGKABFHN : HMDAPEKOIMB<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73426E0", Offset = "0x73412E0", VA = "0x1873426E0")]
	public IKDJGKABFHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KCKFGKBICHJ : HMDAPEKOIMB<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7342720", Offset = "0x7341320", VA = "0x187342720")]
	public KCKFGKBICHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MEMGEDOHAGN : EONOLCFOFFJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7342890", Offset = "0x7341490", VA = "0x187342890")]
	public MEMGEDOHAGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FBKGLEOJJMA : OIBAMKIBCCD<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PODHNBOGFAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PODHNBOGFAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7342AF0", Offset = "0x73416F0", VA = "0x187342AF0")]
		internal void EKGMBIFCOJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73430C0", Offset = "0x7341CC0", VA = "0x1873430C0")]
		internal void FPEKGLHDNBA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7341D70", Offset = "0x7340970", VA = "0x187341D70", Slot = "35")]
	public override void MGHLIJGHDCD(Utf8JsonReader KLCLFHDKNAH, JsonSerializerOptions DAMABILEGII, string MFGAOHOJBEJ, AdditionalFeetData HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7341F00", Offset = "0x7340B00", VA = "0x187341F00", Slot = "36")]
	public override void NNCKNFNCJNA(Utf8JsonWriter DGOPMEPLAFF, AdditionalFeetData MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7341FD0", Offset = "0x7340BD0", VA = "0x187341FD0")]
	public FBKGLEOJJMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AGHMBBEBHMN : OIBAMKIBCCD<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PGCNGBJDMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PGCNGBJDMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7342970", Offset = "0x7341570", VA = "0x187342970")]
		internal void EKGMBIFCOJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7342AC0", Offset = "0x73416C0", VA = "0x187342AC0")]
		internal void FPEKGLHDNBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7340890", Offset = "0x733F490", VA = "0x187340890")]
		internal void DBADLEKMHGH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x73428D0", Offset = "0x73414D0", VA = "0x1873428D0")]
		internal void CNBKKDNCNMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7342A20", Offset = "0x7341620", VA = "0x187342A20")]
		internal void FIAIIMELEOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7342B20", Offset = "0x7341720", VA = "0x187342B20")]
		internal void OCKFGBLPCAH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7342AF0", Offset = "0x73416F0", VA = "0x187342AF0")]
		internal void GCLGJGNHMPE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x733DCE0", Offset = "0x733C8E0", VA = "0x18733DCE0", Slot = "35")]
	public override void MGHLIJGHDCD(Utf8JsonReader KLCLFHDKNAH, JsonSerializerOptions DAMABILEGII, string MFGAOHOJBEJ, HairData HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x733E0D0", Offset = "0x733CCD0", VA = "0x18733E0D0", Slot = "36")]
	public override void NNCKNFNCJNA(Utf8JsonWriter DGOPMEPLAFF, HairData MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x733E3A0", Offset = "0x733CFA0", VA = "0x18733E3A0")]
	public AGHMBBEBHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FAFCKOFJCOE : OIBAMKIBCCD<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HHBCPGJDKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public HHBCPGJDKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7342410", Offset = "0x7341010", VA = "0x187342410")]
		internal void EKGMBIFCOJE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73424F0", Offset = "0x73410F0", VA = "0x1873424F0")]
		internal void FPEKGLHDNBA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7342360", Offset = "0x7340F60", VA = "0x187342360")]
		internal void DBADLEKMHGH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73422B0", Offset = "0x7340EB0", VA = "0x1873422B0")]
		internal void CNBKKDNCNMF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7342440", Offset = "0x7341040", VA = "0x187342440")]
		internal void FIAIIMELEOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7342640", Offset = "0x7341240", VA = "0x187342640")]
		internal void OCKFGBLPCAH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73425A0", Offset = "0x73411A0", VA = "0x1873425A0")]
		internal void GCLGJGNHMPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7342210", Offset = "0x7340E10", VA = "0x187342210")]
		internal void CJLMHKHLEKD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7341590", Offset = "0x7340190", VA = "0x187341590", Slot = "35")]
	public override void MGHLIJGHDCD(Utf8JsonReader KLCLFHDKNAH, JsonSerializerOptions DAMABILEGII, string MFGAOHOJBEJ, AdditionalHatData HLGDOFMLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73419F0", Offset = "0x73405F0", VA = "0x1873419F0", Slot = "36")]
	public override void NNCKNFNCJNA(Utf8JsonWriter DGOPMEPLAFF, AdditionalHatData MPDLOLIOGJL, JsonSerializerOptions DAMABILEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7341D30", Offset = "0x7340930", VA = "0x187341D30")]
	public FAFCKOFJCOE()
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
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x95B860", Offset = "0x95A460", VA = "0x18095B860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC76640", Offset = "0xC75240", VA = "0x180C76640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xC76530", Offset = "0xC75130", VA = "0x180C76530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD6BFF0", Offset = "0xD6ABF0", VA = "0x180D6BFF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD6C350", Offset = "0xD6AF50", VA = "0x180D6C350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA4A0", Offset = "0x1CE90A0", VA = "0x181CEA4A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x73435B0", Offset = "0x73421B0", VA = "0x1873435B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x28D8230", Offset = "0x28D6E30", VA = "0x1828D8230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x28D8000", Offset = "0x28D6C00", VA = "0x1828D8000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB46D90", Offset = "0xB45990", VA = "0x180B46D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB46DE0", Offset = "0xB459E0", VA = "0x180B46DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AMLHELBFOLA.MCCCALMIAAN ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA862F0", Offset = "0xA84EF0", VA = "0x180A862F0")]
			[CompilerGenerated]
			get
			{
				return default(AMLHELBFOLA.MCCCALMIAAN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA862D0", Offset = "0xA84ED0", VA = "0x180A862D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x95D110", Offset = "0x95BD10", VA = "0x18095D110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7343120", Offset = "0x7341D20", VA = "0x187343120", Slot = "0")]
		public override bool Equals(object PELBNOCGOOJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7343590", Offset = "0x7342190", VA = "0x187343590")]
		public static bool LBLECGDECIN(SerializedAvatarItemData NFOAKNOEKCL, SerializedAvatarItemData AFFPJGJMKFP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73430F0", Offset = "0x7341CF0", VA = "0x1873430F0")]
		public static bool AIDLCBIJBIF(SerializedAvatarItemData NFOAKNOEKCL, SerializedAvatarItemData AFFPJGJMKFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x73431A0", Offset = "0x7341DA0", VA = "0x1873431A0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73434C0", Offset = "0x73420C0", VA = "0x1873434C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
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
