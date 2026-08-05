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
public class KJKMKJJPPNC : KPGJKCFBMAC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D5890", Offset = "0x8D4490", VA = "0x1808D5890", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6881300", Offset = "0x687FF00", VA = "0x186881300", Slot = "36")]
	protected override Vector3 PFKBDLMLKNN(float[] COOBAOCKFHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6881280", Offset = "0x687FE80", VA = "0x186881280", Slot = "37")]
	protected override float[] MAOENEIBJNJ(Vector3 IIPLJLPCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6881350", Offset = "0x687FF50", VA = "0x186881350")]
	public KJKMKJJPPNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KGBFMBNJBGA : KPGJKCFBMAC<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E1570", Offset = "0x8E0170", VA = "0x1808E1570", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6881200", Offset = "0x687FE00", VA = "0x186881200", Slot = "36")]
	protected override Vector2 PFKBDLMLKNN(float[] COOBAOCKFHD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6881190", Offset = "0x687FD90", VA = "0x186881190", Slot = "37")]
	protected override float[] MAOENEIBJNJ(Vector2 IIPLJLPCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6881240", Offset = "0x687FE40", VA = "0x186881240")]
	public KGBFMBNJBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LJLNHCMBAJK : KPGJKCFBMAC<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B50", Offset = "0x8CF750", VA = "0x1808D0B50", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6881420", Offset = "0x6880020", VA = "0x186881420", Slot = "36")]
	protected override Quaternion PFKBDLMLKNN(float[] COOBAOCKFHD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6881390", Offset = "0x687FF90", VA = "0x186881390", Slot = "37")]
	protected override float[] MAOENEIBJNJ(Quaternion IIPLJLPCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6881480", Offset = "0x6880080", VA = "0x186881480")]
	public LJLNHCMBAJK()
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
		public enum NILACBGFKAE
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
		public NILACBGFKAE Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
			[CompilerGenerated]
			get
			{
				return default(NILACBGFKAE);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x933840", Offset = "0x932440", VA = "0x180933840")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DPHMNGPEEFM : BMOLGHCKPOG<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BFCIBIFJOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BFCIBIFJOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x687D6F0", Offset = "0x687C2F0", VA = "0x18687D6F0")]
		internal void CAANNKEFEIJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x687D7A0", Offset = "0x687C3A0", VA = "0x18687D7A0")]
		internal void CIDNPLOGPGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x687D8F0", Offset = "0x687C4F0", VA = "0x18687D8F0")]
		internal void FEIOKPHMDKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x687D4E0", Offset = "0x687C0E0", VA = "0x18687D4E0")]
		internal void AAFJDHKHAKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x687D590", Offset = "0x687C190", VA = "0x18687D590")]
		internal void BGHEAHJIEEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x687D640", Offset = "0x687C240", VA = "0x18687D640")]
		internal void BPFPMDNJAFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x687DAF0", Offset = "0x687C6F0", VA = "0x18687DAF0")]
		internal void OGBOPHOJGKN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x687DA40", Offset = "0x687C640", VA = "0x18687DA40")]
		internal void NBBNMHLPGFJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x687D9A0", Offset = "0x687C5A0", VA = "0x18687D9A0")]
		internal void HHCDBLKIJLL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x687D850", Offset = "0x687C450", VA = "0x18687D850")]
		internal void EDIKDGLMKND(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NOBHADGLPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x687E650", Offset = "0x687D250", VA = "0x18687E650", Slot = "35")]
	public override void CEJBOAHDLAI(Utf8JsonReader KLAPEMMBNLL, JsonSerializerOptions GAANPFIMDCL, string FNBFCLGAMDN, AnchorParamsRestrictions NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x687EB70", Offset = "0x687D770", VA = "0x18687EB70", Slot = "36")]
	public override void LCBCOLDFALB(Utf8JsonWriter PNCAPBLIAKM, AnchorParamsRestrictions IIPLJLPCLBC, JsonSerializerOptions GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x687F010", Offset = "0x687DC10", VA = "0x18687F010")]
	public DPHMNGPEEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29995A0", Offset = "0x29981A0", VA = "0x1829995A0")]
	[CompilerGenerated]
	internal static void FEBMNECKLCA<T>(string FNBFCLGAMDN, T BMEHNBDMOJG, T OILPCLEOFBN, NOBHADGLPHH P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GBKNBOEBGDN : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void CANJMCEAHEN(Utf8JsonReader GKPLDDEPNGI);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GLKDMBHFPIE
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
		public GBKNBOEBGDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CANJMCEAHEN <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CANJMCEAHEN <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CANJMCEAHEN <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CANJMCEAHEN <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CANJMCEAHEN <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CANJMCEAHEN <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public CANJMCEAHEN <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CANJMCEAHEN <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CANJMCEAHEN <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CANJMCEAHEN <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CANJMCEAHEN <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CANJMCEAHEN <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CANJMCEAHEN <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CANJMCEAHEN <>9__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CANJMCEAHEN <>9__14;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GLKDMBHFPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6880400", Offset = "0x687F000", VA = "0x186880400")]
		internal void GCAAKLGGDAB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68801C0", Offset = "0x687EDC0", VA = "0x1868801C0")]
		internal void CFIGFEBBNJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68805F0", Offset = "0x687F1F0", VA = "0x1868805F0")]
		internal void KBMBGECDAGN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68808B0", Offset = "0x687F4B0", VA = "0x1868808B0")]
		internal void PFAKCBGILLF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6880780", Offset = "0x687F380", VA = "0x186880780")]
		internal void NCOFPNNIJLM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6880350", Offset = "0x687EF50", VA = "0x186880350")]
		internal void FMJFAIBHKDI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68806D0", Offset = "0x687F2D0", VA = "0x1868806D0")]
		internal void MLLGFCNGFKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68806A0", Offset = "0x687F2A0", VA = "0x1868806A0")]
		internal void LDHJKPJIGCI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6880320", Offset = "0x687EF20", VA = "0x186880320")]
		internal void FINBJFLFFOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6880520", Offset = "0x687F120", VA = "0x186880520")]
		internal void IDHNFIEKMLA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6880830", Offset = "0x687F430", VA = "0x186880830")]
		internal void OEGAPGNGLGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6880440", Offset = "0x687F040", VA = "0x186880440")]
		internal void ICNMMJIJOKE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6880180", Offset = "0x687ED80", VA = "0x186880180")]
		internal void AGOHHDKJIMN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6880550", Offset = "0x687F150", VA = "0x186880550")]
		internal void JBOEDJCHOOE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68801F0", Offset = "0x687EDF0", VA = "0x1868801F0")]
		internal void EEKPFNBJIMJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x687F170", Offset = "0x687DD70", VA = "0x18687F170", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader KLAPEMMBNLL, Type GDGPOLOEODB, JsonSerializerOptions GAANPFIMDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x687FC70", Offset = "0x687E870", VA = "0x18687FC70", Slot = "28")]
	public override void Write(Utf8JsonWriter PNCAPBLIAKM, SerializedAvatarItemData IIPLJLPCLBC, JsonSerializerOptions GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x687F050", Offset = "0x687DC50", VA = "0x18687F050")]
	private AdditionalOutfitTypeData JOHOHFEPAHJ(Utf8JsonReader KLAPEMMBNLL, OutfitType HGPIKDLKBHO, JsonSerializerOptions GAANPFIMDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6880140", Offset = "0x687ED40", VA = "0x186880140")]
	public GBKNBOEBGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AFGHFFIFBII : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x687C890", Offset = "0x687B490", VA = "0x18687C890", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader KLAPEMMBNLL, Type GDGPOLOEODB, JsonSerializerOptions GAANPFIMDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x687CC00", Offset = "0x687B800", VA = "0x18687CC00", Slot = "28")]
	public override void Write(Utf8JsonWriter PNCAPBLIAKM, AvatarItemDownloadableConfig IIPLJLPCLBC, JsonSerializerOptions GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x687CCF0", Offset = "0x687B8F0", VA = "0x18687CCF0")]
	public AFGHFFIFBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NPBCLIKFDEO : BMOLGHCKPOG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6881990", Offset = "0x6880590", VA = "0x186881990", Slot = "35")]
	public override void CEJBOAHDLAI(Utf8JsonReader KLAPEMMBNLL, JsonSerializerOptions GAANPFIMDCL, string FNBFCLGAMDN, BeardData NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6881B30", Offset = "0x6880730", VA = "0x186881B30", Slot = "36")]
	public override void LCBCOLDFALB(Utf8JsonWriter PNCAPBLIAKM, BeardData IIPLJLPCLBC, JsonSerializerOptions GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6881BF0", Offset = "0x68807F0", VA = "0x186881BF0")]
	public NPBCLIKFDEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IFLBLPCFMIF : HCDHGIGFHHI<NAMGEKDMCNI>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6881150", Offset = "0x687FD50", VA = "0x186881150")]
	public IFLBLPCFMIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DHFJHCAPMAB : HCDHGIGFHHI<JGEMJCMHICA>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x687DF00", Offset = "0x687CB00", VA = "0x18687DF00")]
	public DHFJHCAPMAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OCCPGHJJNMI : HCDHGIGFHHI<JNFPLAMIGKC>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6881C30", Offset = "0x6880830", VA = "0x186881C30")]
	public OCCPGHJJNMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BFENMGLOGMF : CFHANDPKKPJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x687DBA0", Offset = "0x687C7A0", VA = "0x18687DBA0")]
	public BFENMGLOGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DLGDAFAFCKD : BMOLGHCKPOG<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BOIKGMLFMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BOIKGMLFMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x687DDC0", Offset = "0x687C9C0", VA = "0x18687DDC0")]
		internal void CAANNKEFEIJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x687DE70", Offset = "0x687CA70", VA = "0x18687DE70")]
		internal void CIDNPLOGPGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x687DEA0", Offset = "0x687CAA0", VA = "0x18687DEA0")]
		internal void FEIOKPHMDKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x687DBE0", Offset = "0x687C7E0", VA = "0x18687DBE0")]
		internal void AAFJDHKHAKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x687DC80", Offset = "0x687C880", VA = "0x18687DC80")]
		internal void BGHEAHJIEEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x687DD20", Offset = "0x687C920", VA = "0x18687DD20")]
		internal void BPFPMDNJAFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x687DED0", Offset = "0x687CAD0", VA = "0x18687DED0")]
		internal void OGBOPHOJGKN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x687DF40", Offset = "0x687CB40", VA = "0x18687DF40", Slot = "35")]
	public override void CEJBOAHDLAI(Utf8JsonReader KLAPEMMBNLL, JsonSerializerOptions GAANPFIMDCL, string FNBFCLGAMDN, HairData NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x687E330", Offset = "0x687CF30", VA = "0x18687E330", Slot = "36")]
	public override void LCBCOLDFALB(Utf8JsonWriter PNCAPBLIAKM, HairData IIPLJLPCLBC, JsonSerializerOptions GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x687E610", Offset = "0x687D210", VA = "0x18687E610")]
	public DLGDAFAFCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IELPCIFBNEC : BMOLGHCKPOG<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NMDKKJHBDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NMDKKJHBDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68816C0", Offset = "0x68802C0", VA = "0x1868816C0")]
		internal void CAANNKEFEIJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68816F0", Offset = "0x68802F0", VA = "0x1868816F0")]
		internal void CIDNPLOGPGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68817A0", Offset = "0x68803A0", VA = "0x1868817A0")]
		internal void FEIOKPHMDKB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68814C0", Offset = "0x68800C0", VA = "0x1868814C0")]
		internal void AAFJDHKHAKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6881570", Offset = "0x6880170", VA = "0x186881570")]
		internal void BGHEAHJIEEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6881620", Offset = "0x6880220", VA = "0x186881620")]
		internal void BPFPMDNJAFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68818F0", Offset = "0x68804F0", VA = "0x1868818F0")]
		internal void OGBOPHOJGKN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6881850", Offset = "0x6880450", VA = "0x186881850")]
		internal void NBBNMHLPGFJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6880960", Offset = "0x687F560", VA = "0x186880960", Slot = "35")]
	public override void CEJBOAHDLAI(Utf8JsonReader KLAPEMMBNLL, JsonSerializerOptions GAANPFIMDCL, string FNBFCLGAMDN, AdditionalHatData NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6880DC0", Offset = "0x687F9C0", VA = "0x186880DC0", Slot = "36")]
	public override void LCBCOLDFALB(Utf8JsonWriter PNCAPBLIAKM, AdditionalHatData IIPLJLPCLBC, JsonSerializerOptions GAANPFIMDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6881110", Offset = "0x687FD10", VA = "0x186881110")]
	public IELPCIFBNEC()
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
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x867D00", Offset = "0x866900", VA = "0x180867D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D6B0", VA = "0x180A7EAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB55D80", Offset = "0xB54980", VA = "0x180B55D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xDF29F0", Offset = "0xDF15F0", VA = "0x180DF29F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDF2750", Offset = "0xDF1350", VA = "0x180DF2750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1ED90E0", Offset = "0x1ED7CE0", VA = "0x181ED90E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1ED90F0", Offset = "0x1ED7CF0", VA = "0x181ED90F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x13FBE30", Offset = "0x13FAA30", VA = "0x1813FBE30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6881C70", Offset = "0x6880870", VA = "0x186881C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x230EDC0", Offset = "0x230D9C0", VA = "0x18230EDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x230ECE0", Offset = "0x230D8E0", VA = "0x18230ECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B31430", Offset = "0x1B30030", VA = "0x181B31430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B31460", Offset = "0x1B30060", VA = "0x181B31460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDCDD20", Offset = "0xDCC920", VA = "0x180DCDD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDD7E00", Offset = "0xDD6A00", VA = "0x180DD7E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HFBKCJFJOFO ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x932DE0", Offset = "0x9319E0", VA = "0x180932DE0")]
			[CompilerGenerated]
			get
			{
				return default(HFBKCJFJOFO);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB15C80", Offset = "0xB14880", VA = "0x180B15C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BOODGANOLPN.PIPFNOJLPFF ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB16290", Offset = "0xB14E90", VA = "0x180B16290")]
			[CompilerGenerated]
			get
			{
				return default(BOODGANOLPN.PIPFNOJLPFF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x14758F0", Offset = "0x14744F0", VA = "0x1814758F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x86B550", Offset = "0x86A150", VA = "0x18086B550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x86B4E0", Offset = "0x86A0E0", VA = "0x18086B4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC487F0", Offset = "0xC473F0", VA = "0x180C487F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x136C7E0", Offset = "0x136B3E0", VA = "0x18136C7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1065CB0", Offset = "0x10648B0", VA = "0x181065CB0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3D633A0", Offset = "0x3D61FA0", VA = "0x183D633A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
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
