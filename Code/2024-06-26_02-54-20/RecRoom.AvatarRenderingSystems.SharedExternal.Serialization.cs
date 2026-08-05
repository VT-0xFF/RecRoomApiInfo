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
		[Cpp2IlInjected.Address(RVA = "0x8CC510", Offset = "0x8CAB10", VA = "0x1808CC510", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67F7F30", Offset = "0x67F6530", VA = "0x1867F7F30", Slot = "36")]
	protected override Vector3 FLABPMGGCIJ(float[] CNNODMDOLAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67F7F80", Offset = "0x67F6580", VA = "0x1867F7F80", Slot = "37")]
	protected override float[] JNKPEPBDKEI(Vector3 CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67F8000", Offset = "0x67F6600", VA = "0x1867F8000")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D95E0", Offset = "0x8D7BE0", VA = "0x1808D95E0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67F3450", Offset = "0x67F1A50", VA = "0x1867F3450", Slot = "36")]
	protected override Vector2 FLABPMGGCIJ(float[] CNNODMDOLAC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67F3490", Offset = "0x67F1A90", VA = "0x1867F3490", Slot = "37")]
	protected override float[] JNKPEPBDKEI(Vector2 CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67F3500", Offset = "0x67F1B00", VA = "0x1867F3500")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D3060", Offset = "0x8D1660", VA = "0x1808D3060", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67F35C0", Offset = "0x67F1BC0", VA = "0x1867F35C0", Slot = "36")]
	protected override Quaternion FLABPMGGCIJ(float[] CNNODMDOLAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67F3620", Offset = "0x67F1C20", VA = "0x1867F3620", Slot = "37")]
	protected override float[] JNKPEPBDKEI(Quaternion CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67F36B0", Offset = "0x67F1CB0", VA = "0x1867F36B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0")]
			[CompilerGenerated]
			get
			{
				return default(BJMEENDDPMP);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x867850", Offset = "0x865E50", VA = "0x180867850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x92FC90", Offset = "0x92E290", VA = "0x18092FC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public IBGKOLPKEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67F48B0", Offset = "0x67F2EB0", VA = "0x1867F48B0")]
		internal void POIELAHCNJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67F45F0", Offset = "0x67F2BF0", VA = "0x1867F45F0")]
		internal void MCEJEELPEOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67F4800", Offset = "0x67F2E00", VA = "0x1867F4800")]
		internal void OCPBHBAFGBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67F4350", Offset = "0x67F2950", VA = "0x1867F4350")]
		internal void BHNKIAIIKPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67F46A0", Offset = "0x67F2CA0", VA = "0x1867F46A0")]
		internal void MNHCFJGAHPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67F42A0", Offset = "0x67F28A0", VA = "0x1867F42A0")]
		internal void AFCALACMGHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67F4750", Offset = "0x67F2D50", VA = "0x1867F4750")]
		internal void NBDMEPOBPNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67F4400", Offset = "0x67F2A00", VA = "0x1867F4400")]
		internal void EDMLLGEIGOK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67F4550", Offset = "0x67F2B50", VA = "0x1867F4550")]
		internal void KCFGOJPGBJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67F44B0", Offset = "0x67F2AB0", VA = "0x1867F44B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x67F6240", Offset = "0x67F4840", VA = "0x1867F6240", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, AnchorParamsRestrictions OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67F6760", Offset = "0x67F4D60", VA = "0x1867F6760", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, AnchorParamsRestrictions CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67F6C00", Offset = "0x67F5200", VA = "0x1867F6C00")]
	public LNNIDOBAHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2BE81A0", Offset = "0x2BE67A0", VA = "0x182BE81A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OBADHGODPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67F7AB0", Offset = "0x67F60B0", VA = "0x1867F7AB0")]
		internal void JAJCAGBDILO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67F7ED0", Offset = "0x67F64D0", VA = "0x1867F7ED0")]
		internal void NKHAJKKJJHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67F7A00", Offset = "0x67F6000", VA = "0x1867F7A00")]
		internal void ICNIEMIOGEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67F7750", Offset = "0x67F5D50", VA = "0x1867F7750")]
		internal void DHEAJEIOKBB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67F7C80", Offset = "0x67F6280", VA = "0x1867F7C80")]
		internal void KEPFOLHECJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67F7BD0", Offset = "0x67F61D0", VA = "0x1867F7BD0")]
		internal void JGHLHAGOLIK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67F78D0", Offset = "0x67F5ED0", VA = "0x1867F78D0")]
		internal void GOCDJMJAECN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67F7F00", Offset = "0x67F6500", VA = "0x1867F7F00")]
		internal void NPNHANEOFNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67F7D30", Offset = "0x67F6330", VA = "0x1867F7D30")]
		internal void LCGMFEKOIBJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67F78A0", Offset = "0x67F5EA0", VA = "0x1867F78A0")]
		internal void GGAJHNCPNEG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67F7980", Offset = "0x67F5F80", VA = "0x1867F7980")]
		internal void HIPOGONFFEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67F7AF0", Offset = "0x67F60F0", VA = "0x1867F7AF0")]
		internal void JCLIPGPBEFP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67F7E90", Offset = "0x67F6490", VA = "0x1867F7E90")]
		internal void NAHIOHLHIBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67F7800", Offset = "0x67F5E00", VA = "0x1867F7800")]
		internal void ENLJPMNIGLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67F7D60", Offset = "0x67F6360", VA = "0x1867F7D60")]
		internal void MGNDIPPAHLB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67F4D20", Offset = "0x67F3320", VA = "0x1867F4D20", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67F5820", Offset = "0x67F3E20", VA = "0x1867F5820", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, SerializedAvatarItemData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67F4C00", Offset = "0x67F3200", VA = "0x1867F4C00")]
	private AdditionalOutfitTypeData CAFGAMFKFPP(Utf8JsonReader DHKLMNOOPAJ, OutfitType PBLNJHEPKAE, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67F5CF0", Offset = "0x67F42F0", VA = "0x1867F5CF0")]
	public IKEDMMKJACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GEJMIPLFBGE : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67F36F0", Offset = "0x67F1CF0", VA = "0x1867F36F0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DHKLMNOOPAJ, Type LBFJJIFKEEA, JsonSerializerOptions HEBGDGGBJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67F3A60", Offset = "0x67F2060", VA = "0x1867F3A60", Slot = "28")]
	public override void Write(Utf8JsonWriter OGONFGJBIBI, AvatarItemDownloadableConfig CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67F3B50", Offset = "0x67F2150", VA = "0x1867F3B50")]
	public GEJMIPLFBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IHENFOCFIOH : ECGGJBINPCP<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67F4960", Offset = "0x67F2F60", VA = "0x1867F4960", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, BeardData OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67F4B00", Offset = "0x67F3100", VA = "0x1867F4B00", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, BeardData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67F4BC0", Offset = "0x67F31C0", VA = "0x1867F4BC0")]
	public IHENFOCFIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BNFGHBGHPHI : PDBMCPLDGHC<FPDBCNOHKKM>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67F3410", Offset = "0x67F1A10", VA = "0x1867F3410")]
	public BNFGHBGHPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKKBNLDIDGM : PDBMCPLDGHC<AHBOGPIGBGE>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67F6200", Offset = "0x67F4800", VA = "0x1867F6200")]
	public JKKBNLDIDGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EOOHOHBIPMM : PDBMCPLDGHC<HAGIKPAIDHM>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67F3540", Offset = "0x67F1B40", VA = "0x1867F3540")]
	public EOOHOHBIPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FLBBHCIGAFB : IHJPOFOPHLN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67F3580", Offset = "0x67F1B80", VA = "0x1867F3580")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public NFMCPEOFPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67F6EB0", Offset = "0x67F54B0", VA = "0x1867F6EB0")]
		internal void POIELAHCNJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67F6D80", Offset = "0x67F5380", VA = "0x1867F6D80")]
		internal void MCEJEELPEOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67F6E80", Offset = "0x67F5480", VA = "0x1867F6E80")]
		internal void OCPBHBAFGBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67F6CE0", Offset = "0x67F52E0", VA = "0x1867F6CE0")]
		internal void BHNKIAIIKPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67F6DB0", Offset = "0x67F53B0", VA = "0x1867F6DB0")]
		internal void MNHCFJGAHPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67F6C40", Offset = "0x67F5240", VA = "0x1867F6C40")]
		internal void AFCALACMGHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67F6E50", Offset = "0x67F5450", VA = "0x1867F6E50")]
		internal void NBDMEPOBPNF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67F3B90", Offset = "0x67F2190", VA = "0x1867F3B90", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, HairData OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67F3F80", Offset = "0x67F2580", VA = "0x1867F3F80", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, HairData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67F4260", Offset = "0x67F2860", VA = "0x1867F4260")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public INDMFCFPNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67F61D0", Offset = "0x67F47D0", VA = "0x1867F61D0")]
		internal void POIELAHCNJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67F5F20", Offset = "0x67F4520", VA = "0x1867F5F20")]
		internal void MCEJEELPEOG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67F6120", Offset = "0x67F4720", VA = "0x1867F6120")]
		internal void OCPBHBAFGBD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x67F5DD0", Offset = "0x67F43D0", VA = "0x1867F5DD0")]
		internal void BHNKIAIIKPH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67F5FD0", Offset = "0x67F45D0", VA = "0x1867F5FD0")]
		internal void MNHCFJGAHPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67F5D30", Offset = "0x67F4330", VA = "0x1867F5D30")]
		internal void AFCALACMGHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67F6080", Offset = "0x67F4680", VA = "0x1867F6080")]
		internal void NBDMEPOBPNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x67F5E80", Offset = "0x67F4480", VA = "0x1867F5E80")]
		internal void EDMLLGEIGOK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67F6F60", Offset = "0x67F5560", VA = "0x1867F6F60", Slot = "35")]
	public override void ADHECIJCDJN(Utf8JsonReader DHKLMNOOPAJ, JsonSerializerOptions HEBGDGGBJPN, string IJNPKFDDGPP, AdditionalHatData OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67F73C0", Offset = "0x67F59C0", VA = "0x1867F73C0", Slot = "36")]
	public override void MAHEPHCMIHP(Utf8JsonWriter OGONFGJBIBI, AdditionalHatData CBAEIEAPLIH, JsonSerializerOptions HEBGDGGBJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67F7710", Offset = "0x67F5D10", VA = "0x1867F7710")]
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
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x865080", Offset = "0x863680", VA = "0x180865080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA774A0", Offset = "0xA75AA0", VA = "0x180A774A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB50", Offset = "0xB49150", VA = "0x180B4AB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xDF21E0", Offset = "0xDF07E0", VA = "0x180DF21E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDF1400", Offset = "0xDEFA00", VA = "0x180DF1400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EBC4A0", Offset = "0x1EBAAA0", VA = "0x181EBC4A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1EBC4B0", Offset = "0x1EBAAB0", VA = "0x181EBC4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x13ECA60", Offset = "0x13EB060", VA = "0x1813ECA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67F8040", Offset = "0x67F6640", VA = "0x1867F8040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x22F0350", Offset = "0x22EE950", VA = "0x1822F0350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x22F04C0", Offset = "0x22EEAC0", VA = "0x1822F04C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B2BA30", Offset = "0x1B2A030", VA = "0x181B2BA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B2BA60", Offset = "0x1B2A060", VA = "0x181B2BA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDD5570", Offset = "0xDD3B70", VA = "0x180DD5570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDD9F90", Offset = "0xDD8590", VA = "0x180DD9F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FLHLKBBPLLO ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x92F230", Offset = "0x92D830", VA = "0x18092F230")]
			[CompilerGenerated]
			get
			{
				return default(FLHLKBBPLLO);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB0AF80", Offset = "0xB09580", VA = "0x180B0AF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BIMEIEHNBAC.FNGDOONFPID ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB0B840", Offset = "0xB09E40", VA = "0x180B0B840")]
			[CompilerGenerated]
			get
			{
				return default(BIMEIEHNBAC.FNGDOONFPID);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x14669D0", Offset = "0x1464FD0", VA = "0x1814669D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x863DF0", Offset = "0x8623F0", VA = "0x180863DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x863DC0", Offset = "0x8623C0", VA = "0x180863DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC3DD20", Offset = "0xC3C320", VA = "0x180C3DD20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135C0C0", VA = "0x18135DAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1058CB0", Offset = "0x10572B0", VA = "0x181058CB0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x41A3000", Offset = "0x41A1600", VA = "0x1841A3000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
