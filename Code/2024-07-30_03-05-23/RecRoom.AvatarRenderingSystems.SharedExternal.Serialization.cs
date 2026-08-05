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
public class NANMKICODEJ : FEECAKGAMOM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8FC7E0", Offset = "0x8FADE0", VA = "0x1808FC7E0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68B6F30", Offset = "0x68B5530", VA = "0x1868B6F30", Slot = "36")]
	protected override Vector3 GJOCMGCACIL(float[] EJHPODPBOEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68B6F80", Offset = "0x68B5580", VA = "0x1868B6F80", Slot = "37")]
	protected override float[] HPKFMOENKFN(Vector3 DMNGPNKHPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68B7000", Offset = "0x68B5600", VA = "0x1868B7000")]
	public NANMKICODEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCGFNBGOFMA : FEECAKGAMOM<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F6240", Offset = "0x8F4840", VA = "0x1808F6240", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68B53A0", Offset = "0x68B39A0", VA = "0x1868B53A0", Slot = "36")]
	protected override Vector2 GJOCMGCACIL(float[] EJHPODPBOEP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68B53E0", Offset = "0x68B39E0", VA = "0x1868B53E0", Slot = "37")]
	protected override float[] HPKFMOENKFN(Vector2 DMNGPNKHPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68B5450", Offset = "0x68B3A50", VA = "0x1868B5450")]
	public GCGFNBGOFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HPFFPKPOAMP : FEECAKGAMOM<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8FF710", Offset = "0x8FDD10", VA = "0x1808FF710", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68B54D0", Offset = "0x68B3AD0", VA = "0x1868B54D0", Slot = "36")]
	protected override Quaternion GJOCMGCACIL(float[] EJHPODPBOEP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68B5530", Offset = "0x68B3B30", VA = "0x1868B5530", Slot = "37")]
	protected override float[] HPKFMOENKFN(Quaternion DMNGPNKHPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68B55C0", Offset = "0x68B3BC0", VA = "0x1868B55C0")]
	public HPFFPKPOAMP()
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
		public enum ALDPANCIANO
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
		public ALDPANCIANO Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
			[CompilerGenerated]
			get
			{
				return default(ALDPANCIANO);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x950D20", Offset = "0x94F320", VA = "0x180950D20")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EKAEOGMIHIC : GFPBNIPJNCM<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JFBBNLOGMNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JFBBNLOGMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68B5B60", Offset = "0x68B4160", VA = "0x1868B5B60")]
		internal void OBACCGGIIKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68B5C10", Offset = "0x68B4210", VA = "0x1868B5C10")]
		internal void OCHINECBKMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68B5950", Offset = "0x68B3F50", VA = "0x1868B5950")]
		internal void GFLFHJMPGOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68B5A00", Offset = "0x68B4000", VA = "0x1868B5A00")]
		internal void LNMINLLGANN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68B58A0", Offset = "0x68B3EA0", VA = "0x1868B58A0")]
		internal void EOCDJAEJEOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68B5600", Offset = "0x68B3C00", VA = "0x1868B5600")]
		internal void ADKMCJNCADN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68B57F0", Offset = "0x68B3DF0", VA = "0x1868B57F0")]
		internal void DHJPHJNMLKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68B5AB0", Offset = "0x68B40B0", VA = "0x1868B5AB0")]
		internal void NIBIBBABICH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68B5750", Offset = "0x68B3D50", VA = "0x1868B5750")]
		internal void CKGMINLJPAK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68B56B0", Offset = "0x68B3CB0", VA = "0x1868B56B0")]
		internal void BFANFPKOLJP(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PFKCKFIOGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68B3DF0", Offset = "0x68B23F0", VA = "0x1868B3DF0", Slot = "35")]
	public override void AGAFFGCJPBN(Utf8JsonReader MMDEOFGAFEK, JsonSerializerOptions EFDCDFNAODA, string BHPJGALIOMC, AnchorParamsRestrictions JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68B4310", Offset = "0x68B2910", VA = "0x1868B4310", Slot = "36")]
	public override void LOAPPJDDFGA(Utf8JsonWriter JFIDOOOHFIL, AnchorParamsRestrictions DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68B47B0", Offset = "0x68B2DB0", VA = "0x1868B47B0")]
	public EKAEOGMIHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B160", Offset = "0x2A39760", VA = "0x182A3B160")]
	[CompilerGenerated]
	internal static void LODBEJBNEKB<T>(string BHPJGALIOMC, T KPJDKHEOHPO, T JEPMEOKEDGK, PFKCKFIOGJN P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CKGMFFDOGNB : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void GALNHLIMCGE(Utf8JsonReader JPKMILJIBCP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LMLGIHIGOEN
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
		public CKGMFFDOGNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public GALNHLIMCGE <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GALNHLIMCGE <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GALNHLIMCGE <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GALNHLIMCGE <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GALNHLIMCGE <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GALNHLIMCGE <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public GALNHLIMCGE <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GALNHLIMCGE <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GALNHLIMCGE <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GALNHLIMCGE <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GALNHLIMCGE <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GALNHLIMCGE <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GALNHLIMCGE <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GALNHLIMCGE <>9__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GALNHLIMCGE <>9__14;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LMLGIHIGOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68B6880", Offset = "0x68B4E80", VA = "0x1868B6880")]
		internal void FMKGGKLKELO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68B6F00", Offset = "0x68B5500", VA = "0x1868B6F00")]
		internal void PHONFABBPBM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68B6D70", Offset = "0x68B5370", VA = "0x1868B6D70")]
		internal void MLFNFFMCLLG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68B6BE0", Offset = "0x68B51E0", VA = "0x1868B6BE0")]
		internal void LMHFMCFLJEH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68B69F0", Offset = "0x68B4FF0", VA = "0x1868B69F0")]
		internal void KENLECABJFC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68B6C90", Offset = "0x68B5290", VA = "0x1868B6C90")]
		internal void MECEJIPPPFE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68B68C0", Offset = "0x68B4EC0", VA = "0x1868B68C0")]
		internal void HIALJHOAEBH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68B6BB0", Offset = "0x68B51B0", VA = "0x1868B6BB0")]
		internal void LMDHFLLKBLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68B6B80", Offset = "0x68B5180", VA = "0x1868B6B80")]
		internal void LKDEPJDEHNN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68B6D40", Offset = "0x68B5340", VA = "0x1868B6D40")]
		internal void MJPEEBONMPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68B6970", Offset = "0x68B4F70", VA = "0x1868B6970")]
		internal void JLDJIPJPFPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68B6AA0", Offset = "0x68B50A0", VA = "0x1868B6AA0")]
		internal void LGJEIMFAPAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68B6EC0", Offset = "0x68B54C0", VA = "0x1868B6EC0")]
		internal void OGHPGMNOELH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68B6E20", Offset = "0x68B5420", VA = "0x1868B6E20")]
		internal void ODGHNLDAKJB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68B6750", Offset = "0x68B4D50", VA = "0x1868B6750")]
		internal void FIOPOIPOJKF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68B2A40", Offset = "0x68B1040", VA = "0x1868B2A40", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68B3540", Offset = "0x68B1B40", VA = "0x1868B3540", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, SerializedAvatarItemData DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68B2920", Offset = "0x68B0F20", VA = "0x1868B2920")]
	private AdditionalOutfitTypeData NOABGDFGOLF(Utf8JsonReader MMDEOFGAFEK, OutfitType GOAECDHCJMK, JsonSerializerOptions EFDCDFNAODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68B3A10", Offset = "0x68B2010", VA = "0x1868B3A10")]
	public CKGMFFDOGNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FLDGEBLFGKB : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68B47F0", Offset = "0x68B2DF0", VA = "0x1868B47F0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68B4B60", Offset = "0x68B3160", VA = "0x1868B4B60", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, AvatarItemDownloadableConfig DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68B4C50", Offset = "0x68B3250", VA = "0x1868B4C50")]
	public FLDGEBLFGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LKHHMIOBMDA : GFPBNIPJNCM<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68B64B0", Offset = "0x68B4AB0", VA = "0x1868B64B0", Slot = "35")]
	public override void AGAFFGCJPBN(Utf8JsonReader MMDEOFGAFEK, JsonSerializerOptions EFDCDFNAODA, string BHPJGALIOMC, BeardData JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68B6650", Offset = "0x68B4C50", VA = "0x1868B6650", Slot = "36")]
	public override void LOAPPJDDFGA(Utf8JsonWriter JFIDOOOHFIL, BeardData DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68B6710", Offset = "0x68B4D10", VA = "0x1868B6710")]
	public LKHHMIOBMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HBFCNGJFNGM : FGPMNMJNENL<APKJKFONDPN>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68B5490", Offset = "0x68B3A90", VA = "0x1868B5490")]
	public HBFCNGJFNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AGHCHGMNCIM : FGPMNMJNENL<DBKFDKCGNDL>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68B2130", Offset = "0x68B0730", VA = "0x1868B2130")]
	public AGHCHGMNCIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DMBCEDBKMKC : FGPMNMJNENL<IKLOOCOPKBL>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68B3DB0", Offset = "0x68B23B0", VA = "0x1868B3DB0")]
	public DMBCEDBKMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DHOCMDMLDGI : KKPECMIEHBA<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68B3D70", Offset = "0x68B2370", VA = "0x1868B3D70")]
	public DHOCMDMLDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FOPPILMFOHL : GFPBNIPJNCM<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DHNGIAMNGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public DHNGIAMNGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68B3C90", Offset = "0x68B2290", VA = "0x1868B3C90")]
		internal void OBACCGGIIKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68B3D40", Offset = "0x68B2340", VA = "0x1868B3D40")]
		internal void OCHINECBKMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68B3BC0", Offset = "0x68B21C0", VA = "0x1868B3BC0")]
		internal void GFLFHJMPGOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68B3BF0", Offset = "0x68B21F0", VA = "0x1868B3BF0")]
		internal void LNMINLLGANN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68B3B20", Offset = "0x68B2120", VA = "0x1868B3B20")]
		internal void EOCDJAEJEOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68B3A50", Offset = "0x68B2050", VA = "0x1868B3A50")]
		internal void ADKMCJNCADN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68B3AF0", Offset = "0x68B20F0", VA = "0x1868B3AF0")]
		internal void DHJPHJNMLKJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68B4C90", Offset = "0x68B3290", VA = "0x1868B4C90", Slot = "35")]
	public override void AGAFFGCJPBN(Utf8JsonReader MMDEOFGAFEK, JsonSerializerOptions EFDCDFNAODA, string BHPJGALIOMC, HairData JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68B5080", Offset = "0x68B3680", VA = "0x1868B5080", Slot = "36")]
	public override void LOAPPJDDFGA(Utf8JsonWriter JFIDOOOHFIL, HairData DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68B5360", Offset = "0x68B3960", VA = "0x1868B5360")]
	public FOPPILMFOHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LDJCPFADHEE : GFPBNIPJNCM<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NHNNDPBKAOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public NHNNDPBKAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68B7430", Offset = "0x68B5A30", VA = "0x1868B7430")]
		internal void OBACCGGIIKD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68B7460", Offset = "0x68B5A60", VA = "0x1868B7460")]
		internal void OCHINECBKMB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68B7230", Offset = "0x68B5830", VA = "0x1868B7230")]
		internal void GFLFHJMPGOO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68B72E0", Offset = "0x68B58E0", VA = "0x1868B72E0")]
		internal void LNMINLLGANN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x68B7180", Offset = "0x68B5780", VA = "0x1868B7180")]
		internal void EOCDJAEJEOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68B7040", Offset = "0x68B5640", VA = "0x1868B7040")]
		internal void ADKMCJNCADN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68B70E0", Offset = "0x68B56E0", VA = "0x1868B70E0")]
		internal void DHJPHJNMLKJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68B7390", Offset = "0x68B5990", VA = "0x1868B7390")]
		internal void NIBIBBABICH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68B5CC0", Offset = "0x68B42C0", VA = "0x1868B5CC0", Slot = "35")]
	public override void AGAFFGCJPBN(Utf8JsonReader MMDEOFGAFEK, JsonSerializerOptions EFDCDFNAODA, string BHPJGALIOMC, AdditionalHatData JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68B6120", Offset = "0x68B4720", VA = "0x1868B6120", Slot = "36")]
	public override void LOAPPJDDFGA(Utf8JsonWriter JFIDOOOHFIL, AdditionalHatData DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68B6470", Offset = "0x68B4A70", VA = "0x1868B6470")]
	public LDJCPFADHEE()
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
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x86E8E0", Offset = "0x86CEE0", VA = "0x18086E8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5760", Offset = "0xAA3D60", VA = "0x180AA5760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB9CB80", Offset = "0xB9B180", VA = "0x180B9CB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xE02960", Offset = "0xE00F60", VA = "0x180E02960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xE02820", Offset = "0xE00E20", VA = "0x180E02820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF140", Offset = "0x1EFD740", VA = "0x181EFF140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF150", Offset = "0x1EFD750", VA = "0x181EFF150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x143F3B0", Offset = "0x143D9B0", VA = "0x18143F3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x68B7510", Offset = "0x68B5B10", VA = "0x1868B7510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x23526A0", Offset = "0x2350CA0", VA = "0x1823526A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2352990", Offset = "0x2350F90", VA = "0x182352990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B875C0", Offset = "0x1B85BC0", VA = "0x181B875C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1B875F0", Offset = "0x1B85BF0", VA = "0x181B875F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xDF92D0", Offset = "0xDF78D0", VA = "0x180DF92D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE00F50", Offset = "0xDFF550", VA = "0x180E00F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NPCIOKELEOD ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9502D0", Offset = "0x94E8D0", VA = "0x1809502D0")]
			[CompilerGenerated]
			get
			{
				return default(NPCIOKELEOD);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB3DD80", Offset = "0xB3C380", VA = "0x180B3DD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MCHDNMDHAEL.INMFOKLKEDE ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB3E5D0", Offset = "0xB3CBD0", VA = "0x180B3E5D0")]
			[CompilerGenerated]
			get
			{
				return default(MCHDNMDHAEL.INMFOKLKEDE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x149D230", Offset = "0x149B830", VA = "0x18149D230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x86ADF0", Offset = "0x8693F0", VA = "0x18086ADF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x86AE00", Offset = "0x869400", VA = "0x18086AE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8E5AF0", Offset = "0x8E40F0", VA = "0x1808E5AF0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8E3480", Offset = "0x8E1A80", VA = "0x1808E3480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1091150", Offset = "0x108F750", VA = "0x181091150")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4098BB0", Offset = "0x40971B0", VA = "0x184098BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
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
