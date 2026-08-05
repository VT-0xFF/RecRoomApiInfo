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
public class CGEOCGNEGCM : KCKIEAHOBFH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCDEFF0", Offset = "0xCDE3F0", VA = "0x180CDEFF0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81150C0", Offset = "0x81144C0", VA = "0x1881150C0", Slot = "36")]
	protected override Vector3 KCAKILMPLEO(float[] EJCCOPPBIIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8115040", Offset = "0x8114440", VA = "0x188115040", Slot = "37")]
	protected override float[] GGJDOCMICNI(Vector3 CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8115110", Offset = "0x8114510", VA = "0x188115110")]
	public CGEOCGNEGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JDPDHJOFEPD : KCKIEAHOBFH<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC93A0", Offset = "0xAC87A0", VA = "0x180AC93A0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8117C80", Offset = "0x8117080", VA = "0x188117C80", Slot = "36")]
	protected override Vector2 KCAKILMPLEO(float[] EJCCOPPBIIG)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8117C10", Offset = "0x8117010", VA = "0x188117C10", Slot = "37")]
	protected override float[] GGJDOCMICNI(Vector2 CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8117CC0", Offset = "0x81170C0", VA = "0x188117CC0")]
	public JDPDHJOFEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NDEIJHIPOAC : KCKIEAHOBFH<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB63C20", Offset = "0xB63020", VA = "0x180B63C20", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8119DB0", Offset = "0x81191B0", VA = "0x188119DB0", Slot = "36")]
	protected override Quaternion KCAKILMPLEO(float[] EJCCOPPBIIG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8119D20", Offset = "0x8119120", VA = "0x188119D20", Slot = "37")]
	protected override float[] GGJDOCMICNI(Quaternion CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8119E10", Offset = "0x8119210", VA = "0x188119E10")]
	public NDEIJHIPOAC()
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
		public enum IMBDAEKLNML
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
		public IMBDAEKLNML Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
			[CompilerGenerated]
			get
			{
				return default(IMBDAEKLNML);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8113DA0", Offset = "0x81131A0", VA = "0x188113DA0", Slot = "0")]
		public override bool Equals(object LHDOHAKINKP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8114010", Offset = "0x8113410", VA = "0x188114010")]
		public static bool ILMCFLMCOJH(AvatarItemDownloadableConfig JLJHECODIOL, AvatarItemDownloadableConfig DABLONGJEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8113ED0", Offset = "0x81132D0", VA = "0x188113ED0", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8113FA0", Offset = "0x81133A0", VA = "0x188113FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x104FEA0", Offset = "0x104F2A0", VA = "0x18104FEA0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, PIKPFPHMMFH, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x811AA50", Offset = "0x8119E50", VA = "0x18811AA50")]
		private void GBMFBHCDGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x811A8E0", Offset = "0x8119CE0", VA = "0x18811A8E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x811A960", Offset = "0x8119D60", VA = "0x18811A960", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x811AA50", Offset = "0x8119E50", VA = "0x18811AA50", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x811AAD0", Offset = "0x8119ED0", VA = "0x18811AAD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HJCLAEMHGPJ : CFPFFAGKCFA<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JAEINGNPCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JAEINGNPCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8115190", Offset = "0x8114590", VA = "0x188115190")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8117760", Offset = "0x8116B60", VA = "0x188117760")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8117960", Offset = "0x8116D60", VA = "0x188117960")]
		internal void KJKANAADFDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8117600", Offset = "0x8116A00", VA = "0x188117600")]
		internal void AAJNFHMGNNE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8117B60", Offset = "0x8116F60", VA = "0x188117B60")]
		internal void PHLJJAPAJOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81178B0", Offset = "0x8116CB0", VA = "0x1881178B0")]
		internal void KFDBMGEALNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81176B0", Offset = "0x8116AB0", VA = "0x1881176B0")]
		internal void BFNFHLLLHHK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8117AB0", Offset = "0x8116EB0", VA = "0x188117AB0")]
		internal void OCKKAGHPIMG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8117A10", Offset = "0x8116E10", VA = "0x188117A10")]
		internal void LBNBELBKFIO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8117810", Offset = "0x8116C10", VA = "0x188117810")]
		internal void IILMAEPCEEM(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KMABEHKLJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8116BC0", Offset = "0x8115FC0", VA = "0x188116BC0", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, AnchorParamsRestrictions GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81170E0", Offset = "0x81164E0", VA = "0x1881170E0", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, AnchorParamsRestrictions CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8117580", Offset = "0x8116980", VA = "0x188117580")]
	public HJCLAEMHGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4ED0", Offset = "0x3CC42D0", VA = "0x183CC4ED0")]
	[CompilerGenerated]
	internal static void IHOGIPKFDCM<T>(string MDDEFFMKGMP, T DIMKOEFIKCH, T PMDAAOANKGH, KMABEHKLJMM P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JIEOBKMCEHE : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void JGDEEBFBMOI(Utf8JsonReader GDOMDKGJNLG);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FGOCNCPOLIJ
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
		public JIEOBKMCEHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public JGDEEBFBMOI <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JGDEEBFBMOI <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JGDEEBFBMOI <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public JGDEEBFBMOI <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JGDEEBFBMOI <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JGDEEBFBMOI <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JGDEEBFBMOI <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JGDEEBFBMOI <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JGDEEBFBMOI <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JGDEEBFBMOI <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JGDEEBFBMOI <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FGOCNCPOLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81156B0", Offset = "0x8114AB0", VA = "0x1881156B0")]
		internal void NCLJDHNNKMP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8115600", Offset = "0x8114A00", VA = "0x188115600")]
		internal void MNBMGFPBELO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8115360", Offset = "0x8114760", VA = "0x188115360")]
		internal void BLJCDBJJGDL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8115550", Offset = "0x8114950", VA = "0x188115550")]
		internal void ICBHIKMNIDF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8115870", Offset = "0x8114C70", VA = "0x188115870")]
		internal void PCEDJAIHMJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81154E0", Offset = "0x81148E0", VA = "0x1881154E0")]
		internal void ENAANLKOPHE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8115410", Offset = "0x8114810", VA = "0x188115410")]
		internal void CPINFKICOKC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8115790", Offset = "0x8114B90", VA = "0x188115790")]
		internal void OKPNDCGFCDH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8115510", Offset = "0x8114910", VA = "0x188115510")]
		internal void GHIILHPJOOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81156F0", Offset = "0x8114AF0", VA = "0x1881156F0")]
		internal void OCDMFEPGGPK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8115490", Offset = "0x8114890", VA = "0x188115490")]
		internal void ELBFEHIGFIH(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GLNGNBJNAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GLNGNBJNAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81168C0", Offset = "0x8115CC0", VA = "0x1881168C0")]
		internal void OFANLOGLGKE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81182D0", Offset = "0x81176D0", VA = "0x1881182D0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8118ED0", Offset = "0x81182D0", VA = "0x188118ED0", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, SerializedAvatarItemData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8117FF0", Offset = "0x81173F0", VA = "0x188117FF0")]
	private AdditionalOutfitTypeData CKDBBKNJCPC(Utf8JsonReader BPCOJLPPMNI, OutfitType IIHAKBEOLJD, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8119310", Offset = "0x8118710", VA = "0x188119310")]
	public JIEOBKMCEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KELHNPEIOLP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8119820", Offset = "0x8118C20", VA = "0x188119820", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader BPCOJLPPMNI, Type FONOGBJILNL, JsonSerializerOptions LFFPIIDBFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8119BB0", Offset = "0x8118FB0", VA = "0x188119BB0", Slot = "28")]
	public override void Write(Utf8JsonWriter HNNLPFDFOLO, AvatarItemDownloadableConfig CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8119CE0", Offset = "0x81190E0", VA = "0x188119CE0")]
	public KELHNPEIOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BHICHHFJEAB : CFPFFAGKCFA<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8114DA0", Offset = "0x81141A0", VA = "0x188114DA0", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, BeardData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8114F40", Offset = "0x8114340", VA = "0x188114F40", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, BeardData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8115000", Offset = "0x8114400", VA = "0x188115000")]
	public BHICHHFJEAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IGKJIHIBALH : KFMEIOFBEKB<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81175C0", Offset = "0x81169C0", VA = "0x1881175C0")]
	public IGKJIHIBALH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EOJJJAIECEP : KFMEIOFBEKB<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81152A0", Offset = "0x81146A0", VA = "0x1881152A0")]
	public EOJJJAIECEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FCMBCCIDMGO : KFMEIOFBEKB<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81152E0", Offset = "0x81146E0", VA = "0x1881152E0")]
	public FCMBCCIDMGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FDNOJAJJELJ : NHBDHGGCMAJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8115320", Offset = "0x8114720", VA = "0x188115320")]
	public FDNOJAJJELJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BEDCCPODBMF : CFPFFAGKCFA<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DIKACBOMJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DIKACBOMJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8115270", Offset = "0x8114670", VA = "0x188115270")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8115240", Offset = "0x8114640", VA = "0x188115240")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8114B00", Offset = "0x8113F00", VA = "0x188114B00", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, AdditionalFeetData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8114C90", Offset = "0x8114090", VA = "0x188114C90", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, AdditionalFeetData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8114D60", Offset = "0x8114160", VA = "0x188114D60")]
	public BEDCCPODBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FOFBHPADNFK : CFPFFAGKCFA<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JIBGDFCOANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JIBGDFCOANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8117EA0", Offset = "0x81172A0", VA = "0x188117EA0")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8117DA0", Offset = "0x81171A0", VA = "0x188117DA0")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8117E70", Offset = "0x8117270", VA = "0x188117E70")]
		internal void KJKANAADFDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8117D00", Offset = "0x8117100", VA = "0x188117D00")]
		internal void AAJNFHMGNNE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8117F50", Offset = "0x8117350", VA = "0x188117F50")]
		internal void PHLJJAPAJOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8117DD0", Offset = "0x81171D0", VA = "0x188117DD0")]
		internal void KFDBMGEALNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8115270", Offset = "0x8114670", VA = "0x188115270")]
		internal void BFNFHLLLHHK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8115920", Offset = "0x8114D20", VA = "0x188115920", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, HairData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8115D10", Offset = "0x8115110", VA = "0x188115D10", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, HairData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8115FF0", Offset = "0x81153F0", VA = "0x188115FF0")]
	public FOFBHPADNFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GFFEDACJNCM : CFPFFAGKCFA<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KCEJJDDHODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KCEJJDDHODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x81196A0", Offset = "0x8118AA0", VA = "0x1881196A0")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81194A0", Offset = "0x81188A0", VA = "0x1881194A0")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81195F0", Offset = "0x81189F0", VA = "0x1881195F0")]
		internal void KJKANAADFDM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8119350", Offset = "0x8118750", VA = "0x188119350")]
		internal void AAJNFHMGNNE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8119770", Offset = "0x8118B70", VA = "0x188119770")]
		internal void PHLJJAPAJOM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8119550", Offset = "0x8118950", VA = "0x188119550")]
		internal void KFDBMGEALNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8119400", Offset = "0x8118800", VA = "0x188119400")]
		internal void BFNFHLLLHHK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81196D0", Offset = "0x8118AD0", VA = "0x1881196D0")]
		internal void OCKKAGHPIMG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8116030", Offset = "0x8115430", VA = "0x188116030", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, AdditionalHatData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8116490", Offset = "0x8115890", VA = "0x188116490", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, AdditionalHatData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81167E0", Offset = "0x8115BE0", VA = "0x1881167E0")]
	public GFFEDACJNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OHPLOMELBDM : CFPFFAGKCFA<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KLOFBKBHHPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KLOFBKBHHPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8115190", Offset = "0x8114590", VA = "0x188115190")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8115150", Offset = "0x8114550", VA = "0x188115150")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8119E50", Offset = "0x8119250", VA = "0x188119E50", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, RoomieEyeData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8119FE0", Offset = "0x81193E0", VA = "0x188119FE0", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, RoomieEyeData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x811A070", Offset = "0x8119470", VA = "0x18811A070")]
	public OHPLOMELBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PIJFNCBMHID : CFPFFAGKCFA<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GLLEMDKHANO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GLLEMDKHANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8115190", Offset = "0x8114590", VA = "0x188115190")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8115150", Offset = "0x8114550", VA = "0x188115150")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8116820", Offset = "0x8115C20", VA = "0x188116820")]
		internal void KJKANAADFDM(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x811A0B0", Offset = "0x81194B0", VA = "0x18811A0B0", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, RoomieHatData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x811A2A0", Offset = "0x81196A0", VA = "0x18811A2A0", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, RoomieHatData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x811A3A0", Offset = "0x81197A0", VA = "0x18811A3A0")]
	public PIJFNCBMHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AOOHONDIOND : CFPFFAGKCFA<RoomieMouthData>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JLHHPJDJEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public RoomieMouthData item;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JLHHPJDJEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8115190", Offset = "0x8114590", VA = "0x188115190")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8115150", Offset = "0x8114550", VA = "0x188115150")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8113B40", Offset = "0x8112F40", VA = "0x188113B40", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, RoomieMouthData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8113CD0", Offset = "0x81130D0", VA = "0x188113CD0", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, RoomieMouthData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8113D60", Offset = "0x8113160", VA = "0x188113D60")]
	public AOOHONDIOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HHLJAONJMKD : CFPFFAGKCFA<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DEOFEHNKFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DEOFEHNKFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8115190", Offset = "0x8114590", VA = "0x188115190")]
		internal void MHLJHCNHPND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8115150", Offset = "0x8114550", VA = "0x188115150")]
		internal void DLLGBIPDHAE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8116960", Offset = "0x8115D60", VA = "0x188116960", Slot = "35")]
	public override void FJAICCLJLEE(Utf8JsonReader BPCOJLPPMNI, JsonSerializerOptions LFFPIIDBFOJ, string MDDEFFMKGMP, RoomieWaistData GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8116AF0", Offset = "0x8115EF0", VA = "0x188116AF0", Slot = "36")]
	public override void LAPLCDHMENI(Utf8JsonWriter HNNLPFDFOLO, RoomieWaistData CBMEHPPMEEA, JsonSerializerOptions LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8116B80", Offset = "0x8115F80", VA = "0x188116B80")]
	public HHLJAONJMKD()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xF1F450", Offset = "0xF1E850", VA = "0x180F1F450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xF1F460", Offset = "0xF1E860", VA = "0x180F1F460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1063B80", Offset = "0x1062F80", VA = "0x181063B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1063B70", Offset = "0x1062F70", VA = "0x181063B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2248F40", Offset = "0x2248340", VA = "0x182248F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x811A8B0", Offset = "0x8119CB0", VA = "0x18811A8B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7FE0", Offset = "0x2EC73E0", VA = "0x182EC7FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7E90", Offset = "0x2EC7290", VA = "0x182EC7E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xABD750", Offset = "0xABCB50", VA = "0x180ABD750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xABD760", Offset = "0xABCB60", VA = "0x180ABD760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LFDPDKBANDC.JGFNEKKJIOP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			[CompilerGenerated]
			get
			{
				return default(LFDPDKBANDC.JGFNEKKJIOP);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x811A410", Offset = "0x8119810", VA = "0x18811A410", Slot = "0")]
		public override bool Equals(object LHDOHAKINKP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x811A890", Offset = "0x8119C90", VA = "0x18811A890")]
		public static bool ILMCFLMCOJH(SerializedAvatarItemData JLJHECODIOL, SerializedAvatarItemData DABLONGJEGN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x811A3E0", Offset = "0x81197E0", VA = "0x18811A3E0")]
		public static bool AMDBHCBNEEF(SerializedAvatarItemData JLJHECODIOL, SerializedAvatarItemData DABLONGJEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x811A4A0", Offset = "0x81198A0", VA = "0x18811A4A0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x811A7C0", Offset = "0x8119BC0", VA = "0x18811A7C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
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
