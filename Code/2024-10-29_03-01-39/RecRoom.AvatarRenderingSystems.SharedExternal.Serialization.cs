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
public class NAJLCELKPKE : NIGHKGKCPAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x935310", Offset = "0x934310", VA = "0x180935310", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D48A30", Offset = "0x6D47A30", VA = "0x186D48A30", Slot = "36")]
	protected override Vector3 BNBIBPPNJLJ(float[] CMDOFHABOHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D48A80", Offset = "0x6D47A80", VA = "0x186D48A80", Slot = "37")]
	protected override float[] LKGOBMDPHFJ(Vector3 BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D48B00", Offset = "0x6D47B00", VA = "0x186D48B00")]
	public NAJLCELKPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FJOPFFKFBLD : NIGHKGKCPAG<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x941F20", Offset = "0x940F20", VA = "0x180941F20", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D452E0", Offset = "0x6D442E0", VA = "0x186D452E0", Slot = "36")]
	protected override Vector2 BNBIBPPNJLJ(float[] CMDOFHABOHN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D45320", Offset = "0x6D44320", VA = "0x186D45320", Slot = "37")]
	protected override float[] LKGOBMDPHFJ(Vector2 BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D45390", Offset = "0x6D44390", VA = "0x186D45390")]
	public FJOPFFKFBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LFMEHABNPPI : NIGHKGKCPAG<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x937EA0", Offset = "0x936EA0", VA = "0x180937EA0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D48240", Offset = "0x6D47240", VA = "0x186D48240", Slot = "36")]
	protected override Quaternion BNBIBPPNJLJ(float[] CMDOFHABOHN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D482A0", Offset = "0x6D472A0", VA = "0x186D482A0", Slot = "37")]
	protected override float[] LKGOBMDPHFJ(Quaternion BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D48330", Offset = "0x6D47330", VA = "0x186D48330")]
	public LFMEHABNPPI()
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
		public enum ELLBLPPBJNG
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
		public ELLBLPPBJNG Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
			[CompilerGenerated]
			get
			{
				return default(ELLBLPPBJNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5600", VA = "0x1808B6600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB31150", Offset = "0xB30150", VA = "0x180B31150")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HGIDNCJGHFN : OEBNCDGEMAM<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LFPFNHHHDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LFPFNHHHDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D48420", Offset = "0x6D47420", VA = "0x186D48420")]
		internal void FLMCMHMNIOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D48980", Offset = "0x6D47980", VA = "0x186D48980")]
		internal void OGNGPIOONCO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D48570", Offset = "0x6D47570", VA = "0x186D48570")]
		internal void GGCJJCHIHPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D488D0", Offset = "0x6D478D0", VA = "0x186D488D0")]
		internal void MEJMBEBIOHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D48620", Offset = "0x6D47620", VA = "0x186D48620")]
		internal void GIFOMAFEHAP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D48370", Offset = "0x6D47370", VA = "0x186D48370")]
		internal void FALCABILCHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D48820", Offset = "0x6D47820", VA = "0x186D48820")]
		internal void LCBPCLMEDGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D48770", Offset = "0x6D47770", VA = "0x186D48770")]
		internal void JMLOBGIDPHA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D486D0", Offset = "0x6D476D0", VA = "0x186D486D0")]
		internal void HAEPEEOPBMC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D484D0", Offset = "0x6D474D0", VA = "0x186D484D0")]
		internal void GDKMGNJKMAM(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HGOGAOOANBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D45A90", Offset = "0x6D44A90", VA = "0x186D45A90", Slot = "35")]
	public override void ABMCBADKGAH(Utf8JsonReader EEKHIEJPCBE, JsonSerializerOptions HKFJGLOCDGD, string ODFHIAEGOOC, AnchorParamsRestrictions KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D45FB0", Offset = "0x6D44FB0", VA = "0x186D45FB0", Slot = "36")]
	public override void EPJFEGONELN(Utf8JsonWriter FOJCOMJJHIM, AnchorParamsRestrictions BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D46440", Offset = "0x6D45440", VA = "0x186D46440")]
	public HGIDNCJGHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F90170", Offset = "0x2F8F170", VA = "0x182F90170")]
	[CompilerGenerated]
	internal static void EMDKMAEFOAK<T>(string ODFHIAEGOOC, T ADMAMDKLPIC, T GJOAKGBDOOO, HGOGAOOANBD P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JNJFCCMKJMA : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void JHCKEDJGDLG(Utf8JsonReader AAGDOBFBLJM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GKFFMLFHNEF
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
		public JNJFCCMKJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JHCKEDJGDLG <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JHCKEDJGDLG <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JHCKEDJGDLG <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public JHCKEDJGDLG <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JHCKEDJGDLG <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JHCKEDJGDLG <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public JHCKEDJGDLG <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JHCKEDJGDLG <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JHCKEDJGDLG <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JHCKEDJGDLG <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JHCKEDJGDLG <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GKFFMLFHNEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D45730", Offset = "0x6D44730", VA = "0x186D45730")]
		internal void IONBNKMBGDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D45450", Offset = "0x6D44450", VA = "0x186D45450")]
		internal void CIDKDGLDPGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D45770", Offset = "0x6D44770", VA = "0x186D45770")]
		internal void JOEAKJHCKLE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D455E0", Offset = "0x6D445E0", VA = "0x186D455E0")]
		internal void HIEAHOOLEGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D459A0", Offset = "0x6D449A0", VA = "0x186D459A0")]
		internal void MEENHFPMJDH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D43A30", Offset = "0x6D42A30", VA = "0x186D43A30")]
		internal void OCHIBGEPPKK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D453D0", Offset = "0x6D443D0", VA = "0x186D453D0")]
		internal void BMDJFKKFEBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D45500", Offset = "0x6D44500", VA = "0x186D45500")]
		internal void CLKMMIDLMDB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D45A50", Offset = "0x6D44A50", VA = "0x186D45A50")]
		internal void MIIDNFNCOJP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D45690", Offset = "0x6D44690", VA = "0x186D45690")]
		internal void HPKBDJHKNNH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D45820", Offset = "0x6D44820", VA = "0x186D45820")]
		internal void LLMDODLLDJO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ANOLKAOFNKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ANOLKAOFNKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D44140", Offset = "0x6D43140", VA = "0x186D44140")]
		internal void DNHBFFNMENH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D471C0", Offset = "0x6D461C0", VA = "0x186D471C0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D47DA0", Offset = "0x6D46DA0", VA = "0x186D47DA0", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, SerializedAvatarItemData BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D47050", Offset = "0x6D46050", VA = "0x186D47050")]
	private AdditionalOutfitTypeData OGDPBDMDPKL(Utf8JsonReader EEKHIEJPCBE, OutfitType PFCMGBLCCPJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D481D0", Offset = "0x6D471D0", VA = "0x186D481D0")]
	public JNJFCCMKJMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OEEEBKLEBDE : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D48B40", Offset = "0x6D47B40", VA = "0x186D48B40", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D48ED0", Offset = "0x6D47ED0", VA = "0x186D48ED0", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, AvatarItemDownloadableConfig BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D48FF0", Offset = "0x6D47FF0", VA = "0x186D48FF0")]
	public OEEEBKLEBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ALEPIMNPIMK : OEBNCDGEMAM<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D43EA0", Offset = "0x6D42EA0", VA = "0x186D43EA0", Slot = "35")]
	public override void ABMCBADKGAH(Utf8JsonReader EEKHIEJPCBE, JsonSerializerOptions HKFJGLOCDGD, string ODFHIAEGOOC, BeardData KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D44040", Offset = "0x6D43040", VA = "0x186D44040", Slot = "36")]
	public override void EPJFEGONELN(Utf8JsonWriter FOJCOMJJHIM, BeardData BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D44100", Offset = "0x6D43100", VA = "0x186D44100")]
	public ALEPIMNPIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BPAGPKPMCMA : MHNOGHKKEND<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D44A00", Offset = "0x6D43A00", VA = "0x186D44A00")]
	public BPAGPKPMCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CCIBNPJAHPG : MHNOGHKKEND<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D44A40", Offset = "0x6D43A40", VA = "0x186D44A40")]
	public CCIBNPJAHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DAHMGEIMLCM : MHNOGHKKEND<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D44A80", Offset = "0x6D43A80", VA = "0x186D44A80")]
	public DAHMGEIMLCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FBOGILJCOPJ : DAEEOIJLHGC<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D452A0", Offset = "0x6D442A0", VA = "0x186D452A0")]
	public FBOGILJCOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AHNDIKLKHLK : OEBNCDGEMAM<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KLHKBCCAENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KLHKBCCAENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D43B00", Offset = "0x6D42B00", VA = "0x186D43B00")]
		internal void FLMCMHMNIOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D48210", Offset = "0x6D47210", VA = "0x186D48210")]
		internal void OGNGPIOONCO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D43C00", Offset = "0x6D42C00", VA = "0x186D43C00", Slot = "35")]
	public override void ABMCBADKGAH(Utf8JsonReader EEKHIEJPCBE, JsonSerializerOptions HKFJGLOCDGD, string ODFHIAEGOOC, AdditionalFeetData KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D43D90", Offset = "0x6D42D90", VA = "0x186D43D90", Slot = "36")]
	public override void EPJFEGONELN(Utf8JsonWriter FOJCOMJJHIM, AdditionalFeetData BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D43E60", Offset = "0x6D42E60", VA = "0x186D43E60")]
	public AHNDIKLKHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JDFFENCMPAI : OEBNCDGEMAM<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AFOCMGGDNGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public AFOCMGGDNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D43980", Offset = "0x6D42980", VA = "0x186D43980")]
		internal void FLMCMHMNIOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D43BD0", Offset = "0x6D42BD0", VA = "0x186D43BD0")]
		internal void OGNGPIOONCO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D43A30", Offset = "0x6D42A30", VA = "0x186D43A30")]
		internal void GGCJJCHIHPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D43B30", Offset = "0x6D42B30", VA = "0x186D43B30")]
		internal void MEJMBEBIOHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D43A60", Offset = "0x6D42A60", VA = "0x186D43A60")]
		internal void GIFOMAFEHAP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D438E0", Offset = "0x6D428E0", VA = "0x186D438E0")]
		internal void FALCABILCHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D43B00", Offset = "0x6D42B00", VA = "0x186D43B00")]
		internal void LCBPCLMEDGL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D46950", Offset = "0x6D45950", VA = "0x186D46950", Slot = "35")]
	public override void ABMCBADKGAH(Utf8JsonReader EEKHIEJPCBE, JsonSerializerOptions HKFJGLOCDGD, string ODFHIAEGOOC, HairData KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D46D40", Offset = "0x6D45D40", VA = "0x186D46D40", Slot = "36")]
	public override void EPJFEGONELN(Utf8JsonWriter FOJCOMJJHIM, HairData BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D47010", Offset = "0x6D46010", VA = "0x186D47010")]
	public JDFFENCMPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ECEALPFENBG : OEBNCDGEMAM<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HNPPLHHKJKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HNPPLHHKJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D46520", Offset = "0x6D45520", VA = "0x186D46520")]
		internal void FLMCMHMNIOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D468A0", Offset = "0x6D458A0", VA = "0x186D468A0")]
		internal void OGNGPIOONCO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D46550", Offset = "0x6D45550", VA = "0x186D46550")]
		internal void GGCJJCHIHPA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D467F0", Offset = "0x6D457F0", VA = "0x186D467F0")]
		internal void MEJMBEBIOHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D46600", Offset = "0x6D45600", VA = "0x186D46600")]
		internal void GIFOMAFEHAP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D46480", Offset = "0x6D45480", VA = "0x186D46480")]
		internal void FALCABILCHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D46750", Offset = "0x6D45750", VA = "0x186D46750")]
		internal void LCBPCLMEDGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D466B0", Offset = "0x6D456B0", VA = "0x186D466B0")]
		internal void JMLOBGIDPHA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D44AC0", Offset = "0x6D43AC0", VA = "0x186D44AC0", Slot = "35")]
	public override void ABMCBADKGAH(Utf8JsonReader EEKHIEJPCBE, JsonSerializerOptions HKFJGLOCDGD, string ODFHIAEGOOC, AdditionalHatData KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D44F20", Offset = "0x6D43F20", VA = "0x186D44F20", Slot = "36")]
	public override void EPJFEGONELN(Utf8JsonWriter FOJCOMJJHIM, AdditionalHatData BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D45260", Offset = "0x6D44260", VA = "0x186D45260")]
	public ECEALPFENBG()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8C12F0", Offset = "0x8C02F0", VA = "0x1808C12F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA39CA0", Offset = "0xA38CA0", VA = "0x180A39CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA39BA0", Offset = "0xA38BA0", VA = "0x180A39BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA39CB0", Offset = "0xA38CB0", VA = "0x180A39CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA39B90", Offset = "0xA38B90", VA = "0x180A39B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB60B40", Offset = "0xB5FB40", VA = "0x180B60B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB60760", Offset = "0xB5F760", VA = "0x180B60760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x199FE30", Offset = "0x199EE30", VA = "0x18199FE30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6D49030", Offset = "0x6D48030", VA = "0x186D49030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2643280", Offset = "0x2642280", VA = "0x182643280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2643270", Offset = "0x2642270", VA = "0x182643270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x92B0A0", Offset = "0x92A0A0", VA = "0x18092B0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x92B0F0", Offset = "0x92A0F0", VA = "0x18092B0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ODJFHHHGCLI.EDMGMMBMGFC ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x991640", Offset = "0x990640", VA = "0x180991640")]
			[CompilerGenerated]
			get
			{
				return default(ODJFHHHGCLI.EDMGMMBMGFC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xABDBD0", Offset = "0xABCBD0", VA = "0x180ABDBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
