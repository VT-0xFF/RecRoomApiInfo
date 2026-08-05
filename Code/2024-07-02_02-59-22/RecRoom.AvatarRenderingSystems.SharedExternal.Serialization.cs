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
public class PHEBELFCAJI : AGMDFCHDNJC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CF510", Offset = "0x8CE510", VA = "0x1808CF510", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6827B70", Offset = "0x6826B70", VA = "0x186827B70", Slot = "36")]
	protected override Vector3 FLABPMGGCIJ(float[] CNNODMDOLAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6827BC0", Offset = "0x6826BC0", VA = "0x186827BC0", Slot = "37")]
	protected override float[] JNKPEPBDKEI(Vector3 CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6827C40", Offset = "0x6826C40", VA = "0x186827C40")]
	public PHEBELFCAJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BPIJCFNNBHB : AGMDFCHDNJC<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8DC330", Offset = "0x8DB330", VA = "0x1808DC330", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6823090", Offset = "0x6822090", VA = "0x186823090", Slot = "36")]
	protected override Vector2 FLABPMGGCIJ(float[] CNNODMDOLAC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68230D0", Offset = "0x68220D0", VA = "0x1868230D0", Slot = "37")]
	protected override float[] JNKPEPBDKEI(Vector2 CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6823140", Offset = "0x6822140", VA = "0x186823140")]
	public BPIJCFNNBHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GCBFDALCAMN : AGMDFCHDNJC<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DB0", Offset = "0x8D4DB0", VA = "0x1808D5DB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6823200", Offset = "0x6822200", VA = "0x186823200", Slot = "36")]
	protected override Quaternion FLABPMGGCIJ(float[] CNNODMDOLAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6823260", Offset = "0x6822260", VA = "0x186823260", Slot = "37")]
	protected override float[] JNKPEPBDKEI(Quaternion CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68232F0", Offset = "0x68222F0", VA = "0x1868232F0")]
	public GCBFDALCAMN()
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
		public enum BJMEENDDPMP
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
		public BJMEENDDPMP Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0")]
			[CompilerGenerated]
			get
			{
				return default(BJMEENDDPMP);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x86A850", Offset = "0x869850", VA = "0x18086A850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x932C20", Offset = "0x931C20", VA = "0x180932C20")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LNNIDOBAHLH : ECGGJBINPCP<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IBGKOLPKEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public IBGKOLPKEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68244F0", Offset = "0x68234F0", VA = "0x1868244F0")]
		internal void POIELAHCNJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6824230", Offset = "0x6823230", VA = "0x186824230")]
		internal void MCEJEELPEOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6824440", Offset = "0x6823440", VA = "0x186824440")]
		internal void OCPBHBAFGBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6823F90", Offset = "0x6822F90", VA = "0x186823F90")]
		internal void BHNKIAIIKPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68242E0", Offset = "0x68232E0", VA = "0x1868242E0")]
		internal void MNHCFJGAHPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6823EE0", Offset = "0x6822EE0", VA = "0x186823EE0")]
		internal void AFCALACMGHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6824390", Offset = "0x6823390", VA = "0x186824390")]
		internal void NBDMEPOBPNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6824040", Offset = "0x6823040", VA = "0x186824040")]
		internal void EDMLLGEIGOK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6824190", Offset = "0x6823190", VA = "0x186824190")]
		internal void KCFGOJPGBJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68240F0", Offset = "0x68230F0", VA = "0x1868240F0")]
		internal void KAPFECDKKPA(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EONMOOKGGKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6825E80", Offset = "0x6824E80", VA = "0x186825E80", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, AnchorParamsRestrictions OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68263A0", Offset = "0x68253A0", VA = "0x1868263A0", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, AnchorParamsRestrictions CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6826840", Offset = "0x6825840", VA = "0x186826840")]
	public LNNIDOBAHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2C00730", Offset = "0x2BFF730", VA = "0x182C00730")]
	[CompilerGenerated]
	internal static void CBFLMNFOBKP<T>(string IJNPKFDDGPP, T LECBAKCNNCK, T BAGGNPKNNDO, EONMOOKGGKB P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IKEDMMKJACL : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void KNMKHGLCDKH(Utf8JsonReader LJNBPEFJOFE);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OBADHGODPLH
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
		public IKEDMMKJACL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KNMKHGLCDKH <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KNMKHGLCDKH <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KNMKHGLCDKH <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KNMKHGLCDKH <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KNMKHGLCDKH <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KNMKHGLCDKH <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KNMKHGLCDKH <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KNMKHGLCDKH <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KNMKHGLCDKH <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KNMKHGLCDKH <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KNMKHGLCDKH <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KNMKHGLCDKH <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KNMKHGLCDKH <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KNMKHGLCDKH <>9__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KNMKHGLCDKH <>9__14;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public OBADHGODPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68276F0", Offset = "0x68266F0", VA = "0x1868276F0")]
		internal void JAJCAGBDILO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6827B10", Offset = "0x6826B10", VA = "0x186827B10")]
		internal void NKHAJKKJJHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6827640", Offset = "0x6826640", VA = "0x186827640")]
		internal void ICNIEMIOGEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6827390", Offset = "0x6826390", VA = "0x186827390")]
		internal void DHEAJEIOKBB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68278C0", Offset = "0x68268C0", VA = "0x1868278C0")]
		internal void KEPFOLHECJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6827810", Offset = "0x6826810", VA = "0x186827810")]
		internal void JGHLHAGOLIK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6827510", Offset = "0x6826510", VA = "0x186827510")]
		internal void GOCDJMJAECN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6827B40", Offset = "0x6826B40", VA = "0x186827B40")]
		internal void NPNHANEOFNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6827970", Offset = "0x6826970", VA = "0x186827970")]
		internal void LCGMFEKOIBJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68274E0", Offset = "0x68264E0", VA = "0x1868274E0")]
		internal void GGAJHNCPNEG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68275C0", Offset = "0x68265C0", VA = "0x1868275C0")]
		internal void HIPOGONFFEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6827730", Offset = "0x6826730", VA = "0x186827730")]
		internal void JCLIPGPBEFP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6827AD0", Offset = "0x6826AD0", VA = "0x186827AD0")]
		internal void NAHIOHLHIBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6827440", Offset = "0x6826440", VA = "0x186827440")]
		internal void ENLJPMNIGLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68279A0", Offset = "0x68269A0", VA = "0x1868279A0")]
		internal void MGNDIPPAHLB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6824960", Offset = "0x6823960", VA = "0x186824960", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6825460", Offset = "0x6824460", VA = "0x186825460", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, SerializedAvatarItemData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6824840", Offset = "0x6823840", VA = "0x186824840")]
	private AdditionalOutfitTypeData CAFGAMFKFPP(Utf8JsonReader DHKLMNOOPAJ, OutfitType PBLNJHEPKAE, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6825930", Offset = "0x6824930", VA = "0x186825930")]
	public IKEDMMKJACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GEJMIPLFBGE : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6823330", Offset = "0x6822330", VA = "0x186823330", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68236A0", Offset = "0x68226A0", VA = "0x1868236A0", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, AvatarItemDownloadableConfig CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6823790", Offset = "0x6822790", VA = "0x186823790")]
	public GEJMIPLFBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IHENFOCFIOH : ECGGJBINPCP<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68245A0", Offset = "0x68235A0", VA = "0x1868245A0", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, BeardData OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6824740", Offset = "0x6823740", VA = "0x186824740", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, BeardData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6824800", Offset = "0x6823800", VA = "0x186824800")]
	public IHENFOCFIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BNFGHBGHPHI : PDBMCPLDGHC<FPDBCNOHKKM>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6823050", Offset = "0x6822050", VA = "0x186823050")]
	public BNFGHBGHPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKKBNLDIDGM : PDBMCPLDGHC<AHBOGPIGBGE>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6825E40", Offset = "0x6824E40", VA = "0x186825E40")]
	public JKKBNLDIDGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EOOHOHBIPMM : PDBMCPLDGHC<HAGIKPAIDHM>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6823180", Offset = "0x6822180", VA = "0x186823180")]
	public EOOHOHBIPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FLBBHCIGAFB : IHJPOFOPHLN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68231C0", Offset = "0x68221C0", VA = "0x1868231C0")]
	public FLBBHCIGAFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HCKGDAIPHHA : ECGGJBINPCP<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NFMCPEOFPJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public NFMCPEOFPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6826AF0", Offset = "0x6825AF0", VA = "0x186826AF0")]
		internal void POIELAHCNJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68269C0", Offset = "0x68259C0", VA = "0x1868269C0")]
		internal void MCEJEELPEOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6826AC0", Offset = "0x6825AC0", VA = "0x186826AC0")]
		internal void OCPBHBAFGBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6826920", Offset = "0x6825920", VA = "0x186826920")]
		internal void BHNKIAIIKPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68269F0", Offset = "0x68259F0", VA = "0x1868269F0")]
		internal void MNHCFJGAHPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6826880", Offset = "0x6825880", VA = "0x186826880")]
		internal void AFCALACMGHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6826A90", Offset = "0x6825A90", VA = "0x186826A90")]
		internal void NBDMEPOBPNF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68237D0", Offset = "0x68227D0", VA = "0x1868237D0", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, HairData OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6823BC0", Offset = "0x6822BC0", VA = "0x186823BC0", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, HairData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6823EA0", Offset = "0x6822EA0", VA = "0x186823EA0")]
	public HCKGDAIPHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NIFMIHEMCJB : ECGGJBINPCP<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class INDMFCFPNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public INDMFCFPNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6825E10", Offset = "0x6824E10", VA = "0x186825E10")]
		internal void POIELAHCNJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6825B60", Offset = "0x6824B60", VA = "0x186825B60")]
		internal void MCEJEELPEOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6825D60", Offset = "0x6824D60", VA = "0x186825D60")]
		internal void OCPBHBAFGBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6825A10", Offset = "0x6824A10", VA = "0x186825A10")]
		internal void BHNKIAIIKPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6825C10", Offset = "0x6824C10", VA = "0x186825C10")]
		internal void MNHCFJGAHPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6825970", Offset = "0x6824970", VA = "0x186825970")]
		internal void AFCALACMGHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6825CC0", Offset = "0x6824CC0", VA = "0x186825CC0")]
		internal void NBDMEPOBPNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6825AC0", Offset = "0x6824AC0", VA = "0x186825AC0")]
		internal void EDMLLGEIGOK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6826BA0", Offset = "0x6825BA0", VA = "0x186826BA0", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, AdditionalHatData OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6827000", Offset = "0x6826000", VA = "0x186827000", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, AdditionalHatData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6827350", Offset = "0x6826350", VA = "0x186827350")]
	public NIFMIHEMCJB()
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
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x868080", Offset = "0x867080", VA = "0x180868080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA7BEE0", Offset = "0xA7AEE0", VA = "0x180A7BEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB508C0", Offset = "0xB4F8C0", VA = "0x180B508C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xDF2FF0", Offset = "0xDF1FF0", VA = "0x180DF2FF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDF2210", Offset = "0xDF1210", VA = "0x180DF2210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EC9E80", Offset = "0x1EC8E80", VA = "0x181EC9E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1EC9E90", Offset = "0x1EC8E90", VA = "0x181EC9E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x13F4A40", Offset = "0x13F3A40", VA = "0x1813F4A40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6827C80", Offset = "0x6826C80", VA = "0x186827C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x22FE240", Offset = "0x22FD240", VA = "0x1822FE240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x22FE3B0", Offset = "0x22FD3B0", VA = "0x1822FE3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B37F00", Offset = "0x1B36F00", VA = "0x181B37F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B37F30", Offset = "0x1B36F30", VA = "0x181B37F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDC9650", Offset = "0xDC8650", VA = "0x180DC9650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDD48E0", Offset = "0xDD38E0", VA = "0x180DD48E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FLHLKBBPLLO ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9321C0", Offset = "0x9311C0", VA = "0x1809321C0")]
			[CompilerGenerated]
			get
			{
				return default(FLHLKBBPLLO);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB11450", Offset = "0xB10450", VA = "0x180B11450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BIMEIEHNBAC.FNGDOONFPID ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB11D10", Offset = "0xB10D10", VA = "0x180B11D10")]
			[CompilerGenerated]
			get
			{
				return default(BIMEIEHNBAC.FNGDOONFPID);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x146E9D0", Offset = "0x146D9D0", VA = "0x18146E9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x866DF0", Offset = "0x865DF0", VA = "0x180866DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x866DC0", Offset = "0x865DC0", VA = "0x180866DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC43C00", Offset = "0xC42C00", VA = "0x180C43C00")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x13653F0", Offset = "0x13643F0", VA = "0x1813653F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x10612D0", Offset = "0x10602D0", VA = "0x1810612D0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x41BF5C0", Offset = "0x41BE5C0", VA = "0x1841BF5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
