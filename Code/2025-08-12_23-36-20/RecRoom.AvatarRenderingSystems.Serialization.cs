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
public class LPKDNAJMCEJ : PJAEBIFOHDB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1C340", Offset = "0xD1B140", VA = "0x180D1C340", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81F86A0", Offset = "0x81F74A0", VA = "0x1881F86A0", Slot = "36")]
	protected override Vector3 LFLGOBPLNLF(float[] OOFDDMCKJPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81F8620", Offset = "0x81F7420", VA = "0x1881F8620", Slot = "37")]
	protected override float[] EKFIPPAFKPM(Vector3 HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81F86F0", Offset = "0x81F74F0", VA = "0x1881F86F0")]
	public LPKDNAJMCEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NPPANLIMMPP : PJAEBIFOHDB<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAEE190", Offset = "0xAECF90", VA = "0x180AEE190", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81F8DB0", Offset = "0x81F7BB0", VA = "0x1881F8DB0", Slot = "36")]
	protected override Vector2 LFLGOBPLNLF(float[] OOFDDMCKJPA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81F8D40", Offset = "0x81F7B40", VA = "0x1881F8D40", Slot = "37")]
	protected override float[] EKFIPPAFKPM(Vector2 HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81F8DF0", Offset = "0x81F7BF0", VA = "0x1881F8DF0")]
	public NPPANLIMMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GMCHPFGHIKH : PJAEBIFOHDB<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB9FFF0", Offset = "0xB9EDF0", VA = "0x180B9FFF0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81F7D60", Offset = "0x81F6B60", VA = "0x1881F7D60", Slot = "36")]
	protected override Quaternion LFLGOBPLNLF(float[] OOFDDMCKJPA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81F7CD0", Offset = "0x81F6AD0", VA = "0x1881F7CD0", Slot = "37")]
	protected override float[] EKFIPPAFKPM(Quaternion HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81F7DC0", Offset = "0x81F6BC0", VA = "0x1881F7DC0")]
	public GMCHPFGHIKH()
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
		public enum MPLLJLKNFKB
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
		public MPLLJLKNFKB Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
			[CompilerGenerated]
			get
			{
				return default(MPLLJLKNFKB);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81F49D0", Offset = "0x81F37D0", VA = "0x1881F49D0", Slot = "0")]
		public override bool Equals(object FGAEAFBDBPK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81F4C40", Offset = "0x81F3A40", VA = "0x1881F4C40")]
		public static bool IKIADGFKNFC(AvatarItemDownloadableConfig NNEMEIEKIAF, AvatarItemDownloadableConfig JOGLOLMOJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81F4B00", Offset = "0x81F3900", VA = "0x1881F4B00", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81F4BD0", Offset = "0x81F39D0", VA = "0x1881F4BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x108B900", Offset = "0x108A700", VA = "0x18108B900")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, CCCADGGIHHO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x81FAA30", Offset = "0x81F9830", VA = "0x1881FAA30")]
		private void OKDOMHELINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81FA8B0", Offset = "0x81F96B0", VA = "0x1881FA8B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81FA930", Offset = "0x81F9730", VA = "0x1881FA930", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA30", Offset = "0x81F9830", VA = "0x1881FAA30", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81FAAA0", Offset = "0x81F98A0", VA = "0x1881FAAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ALHEENFJFOA : OPGIDGAGAID<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NNKJCLPAGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NNKJCLPAGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81F7580", Offset = "0x81F6380", VA = "0x1881F7580")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81F8BE0", Offset = "0x81F79E0", VA = "0x1881F8BE0")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81F8C90", Offset = "0x81F7A90", VA = "0x1881F8C90")]
		internal void PPFGKGKLDME(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81F89E0", Offset = "0x81F77E0", VA = "0x1881F89E0")]
		internal void GLJDDLIAKEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81F87D0", Offset = "0x81F75D0", VA = "0x1881F87D0")]
		internal void BJDBGNNKEPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81F8930", Offset = "0x81F7730", VA = "0x1881F8930")]
		internal void GADPAGPKNJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81F8A90", Offset = "0x81F7890", VA = "0x1881F8A90")]
		internal void IBMKJECHJGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81F8880", Offset = "0x81F7680", VA = "0x1881F8880")]
		internal void EPFGIBCAEHO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81F8730", Offset = "0x81F7530", VA = "0x1881F8730")]
		internal void APMEHADAPHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81F8B40", Offset = "0x81F7940", VA = "0x1881F8B40")]
		internal void PDOOICGADDC(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JFAANIBCDFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81F3FE0", Offset = "0x81F2DE0", VA = "0x1881F3FE0", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, AnchorParamsRestrictions IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81F4500", Offset = "0x81F3300", VA = "0x1881F4500", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, AnchorParamsRestrictions HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81F4990", Offset = "0x81F3790", VA = "0x1881F4990")]
	public ALHEENFJFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3255BB0", Offset = "0x32549B0", VA = "0x183255BB0")]
	[CompilerGenerated]
	internal static void MAAIJIPDCPD<T>(string BPCKHCGHBJN, T DOMECMGKIBN, T DAAJIEJNDCF, JFAANIBCDFF P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OGBIBDBHCCJ : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void AJJPGFGLFOK(Utf8JsonReader BIHPDMNFJGD);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GDOLKKBMOPF
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
		public OGBIBDBHCCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AJJPGFGLFOK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AJJPGFGLFOK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AJJPGFGLFOK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AJJPGFGLFOK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AJJPGFGLFOK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AJJPGFGLFOK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AJJPGFGLFOK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AJJPGFGLFOK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AJJPGFGLFOK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AJJPGFGLFOK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AJJPGFGLFOK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GDOLKKBMOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81F78F0", Offset = "0x81F66F0", VA = "0x1881F78F0")]
		internal void HEKCPAIJLME(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81F7B70", Offset = "0x81F6970", VA = "0x1881F7B70")]
		internal void OGMFPNEMEAG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81F7710", Offset = "0x81F6510", VA = "0x1881F7710")]
		internal void AOEOOFGGFCB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81F77C0", Offset = "0x81F65C0", VA = "0x1881F77C0")]
		internal void BPCAJONHMCH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81F7C20", Offset = "0x81F6A20", VA = "0x1881F7C20")]
		internal void OPPIDENDNCE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81F79D0", Offset = "0x81F67D0", VA = "0x1881F79D0")]
		internal void KDCBEOEBNLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81F7870", Offset = "0x81F6670", VA = "0x1881F7870")]
		internal void FEANKCELFEE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81F7A00", Offset = "0x81F6800", VA = "0x1881F7A00")]
		internal void KMNNLJDCGCP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81F7B30", Offset = "0x81F6930", VA = "0x1881F7B30")]
		internal void OCLICINFDEA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81F7930", Offset = "0x81F6730", VA = "0x1881F7930")]
		internal void KCNKKGOOJFH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81F7AE0", Offset = "0x81F68E0", VA = "0x1881F7AE0")]
		internal void LADJNBMGDEP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AAOCKBIKBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AAOCKBIKBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81F38F0", Offset = "0x81F26F0", VA = "0x1881F38F0")]
		internal void LHDFAIEEOPD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81F9150", Offset = "0x81F7F50", VA = "0x1881F9150", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81F9D30", Offset = "0x81F8B30", VA = "0x1881F9D30", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, SerializedAvatarItemData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81F8E70", Offset = "0x81F7C70", VA = "0x1881F8E70")]
	private AdditionalOutfitTypeData KPNENECOMEL(Utf8JsonReader CCOEJPOOOPD, OutfitType ADGMECOLKNH, JsonSerializerOptions PMEODJMCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81FA170", Offset = "0x81F8F70", VA = "0x1881FA170")]
	public OGBIBDBHCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BMOEJINBMMI : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x81F5A00", Offset = "0x81F4800", VA = "0x1881F5A00", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x81F5D90", Offset = "0x81F4B90", VA = "0x1881F5D90", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, AvatarItemDownloadableConfig HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x81F5EC0", Offset = "0x81F4CC0", VA = "0x1881F5EC0")]
	public BMOEJINBMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JDLELFHDGLP : OPGIDGAGAID<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81F7EA0", Offset = "0x81F6CA0", VA = "0x1881F7EA0", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, BeardData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81F8040", Offset = "0x81F6E40", VA = "0x1881F8040", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, BeardData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81F8100", Offset = "0x81F6F00", VA = "0x1881F8100")]
	public JDLELFHDGLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FAIAGCPLDEJ : CNPIKEMDMMH<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81F7540", Offset = "0x81F6340", VA = "0x1881F7540")]
	public FAIAGCPLDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class INKNLMNFMAG : CNPIKEMDMMH<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81F7E30", Offset = "0x81F6C30", VA = "0x1881F7E30")]
	public INKNLMNFMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LBIEHAOECEP : CNPIKEMDMMH<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81F85E0", Offset = "0x81F73E0", VA = "0x1881F85E0")]
	public LBIEHAOECEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OBLDHPOPFFP : LBPGFKLMCEP<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81F8E30", Offset = "0x81F7C30", VA = "0x1881F8E30")]
	public OBLDHPOPFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CEFBEONJKIO : OPGIDGAGAID<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IADBNMENECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IADBNMENECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81F3F50", Offset = "0x81F2D50", VA = "0x1881F3F50")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E00", Offset = "0x81F6C00", VA = "0x1881F7E00")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81F6160", Offset = "0x81F4F60", VA = "0x1881F6160", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, AdditionalFeetData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81F62F0", Offset = "0x81F50F0", VA = "0x1881F62F0", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, AdditionalFeetData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81F63C0", Offset = "0x81F51C0", VA = "0x1881F63C0")]
	public CEFBEONJKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EDHIOMFFCIL : OPGIDGAGAID<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AGCADFJKCGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AGCADFJKCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81F3D60", Offset = "0x81F2B60", VA = "0x1881F3D60")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81F3F80", Offset = "0x81F2D80", VA = "0x1881F3F80")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81F3FB0", Offset = "0x81F2DB0", VA = "0x1881F3FB0")]
		internal void PPFGKGKLDME(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x81F3EB0", Offset = "0x81F2CB0", VA = "0x1881F3EB0")]
		internal void GLJDDLIAKEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81F3CC0", Offset = "0x81F2AC0", VA = "0x1881F3CC0")]
		internal void BJDBGNNKEPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x81F3E10", Offset = "0x81F2C10", VA = "0x1881F3E10")]
		internal void GADPAGPKNJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x81F3F50", Offset = "0x81F2D50", VA = "0x1881F3F50")]
		internal void IBMKJECHJGO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x81F6400", Offset = "0x81F5200", VA = "0x1881F6400", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, HairData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x81F67F0", Offset = "0x81F55F0", VA = "0x1881F67F0", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, HairData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x81F6AC0", Offset = "0x81F58C0", VA = "0x1881F6AC0")]
	public EDHIOMFFCIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EFNMMPOIPBL : OPGIDGAGAID<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KDAIFFBCGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KDAIFFBCGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E70", Offset = "0x81F6C70", VA = "0x1881F7E70")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81F8480", Offset = "0x81F7280", VA = "0x1881F8480")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81F8530", Offset = "0x81F7330", VA = "0x1881F8530")]
		internal void PPFGKGKLDME(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81F8330", Offset = "0x81F7130", VA = "0x1881F8330")]
		internal void GLJDDLIAKEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81F8140", Offset = "0x81F6F40", VA = "0x1881F8140")]
		internal void BJDBGNNKEPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81F8290", Offset = "0x81F7090", VA = "0x1881F8290")]
		internal void GADPAGPKNJA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81F83E0", Offset = "0x81F71E0", VA = "0x1881F83E0")]
		internal void IBMKJECHJGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81F81F0", Offset = "0x81F6FF0", VA = "0x1881F81F0")]
		internal void EPFGIBCAEHO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81F6B00", Offset = "0x81F5900", VA = "0x1881F6B00", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, AdditionalHatData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81F6F60", Offset = "0x81F5D60", VA = "0x1881F6F60", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, AdditionalHatData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81F72A0", Offset = "0x81F60A0", VA = "0x1881F72A0")]
	public EFNMMPOIPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PJILAKBLMCO : OPGIDGAGAID<RoomieEquipmentData>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IPMLBKCOONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public RoomieEquipmentData item;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IPMLBKCOONC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E70", Offset = "0x81F6C70", VA = "0x1881F7E70")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x81FA1B0", Offset = "0x81F8FB0", VA = "0x1881FA1B0", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, RoomieEquipmentData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x81FA2F0", Offset = "0x81F90F0", VA = "0x1881FA2F0", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, RoomieEquipmentData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x81FA380", Offset = "0x81F9180", VA = "0x1881FA380")]
	public PJILAKBLMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BHAGGJFLFLO : OPGIDGAGAID<RoomieEyeData>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LDEGGCFENCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public RoomieEyeData item;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LDEGGCFENCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81F7580", Offset = "0x81F6380", VA = "0x1881F7580")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x81F7630", Offset = "0x81F6430", VA = "0x1881F7630")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81F57A0", Offset = "0x81F45A0", VA = "0x1881F57A0", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, RoomieEyeData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81F5930", Offset = "0x81F4730", VA = "0x1881F5930", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, RoomieEyeData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81F59C0", Offset = "0x81F47C0", VA = "0x1881F59C0")]
	public BHAGGJFLFLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ACPLGMEFKJB : OPGIDGAGAID<RoomieHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FKFALNBLBKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public RoomieHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FKFALNBLBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81F7580", Offset = "0x81F6380", VA = "0x1881F7580")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81F7630", Offset = "0x81F6430", VA = "0x1881F7630")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81F7670", Offset = "0x81F6470", VA = "0x1881F7670")]
		internal void PPFGKGKLDME(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81F3990", Offset = "0x81F2790", VA = "0x1881F3990", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, RoomieHatData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81F3B80", Offset = "0x81F2980", VA = "0x1881F3B80", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, RoomieHatData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81F3C80", Offset = "0x81F2A80", VA = "0x1881F3C80")]
	public ACPLGMEFKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EMMGKFGGPAC : OPGIDGAGAID<RoomieMouthData>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IHHOMMMDGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public RoomieMouthData item;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IHHOMMMDGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81F7580", Offset = "0x81F6380", VA = "0x1881F7580")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81F7630", Offset = "0x81F6430", VA = "0x1881F7630")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81F72E0", Offset = "0x81F60E0", VA = "0x1881F72E0", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, RoomieMouthData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x81F7470", Offset = "0x81F6270", VA = "0x1881F7470", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, RoomieMouthData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81F7500", Offset = "0x81F6300", VA = "0x1881F7500")]
	public EMMGKFGGPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CBHELMDGLCJ : OPGIDGAGAID<RoomieWaistData>
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FKNABPFNIGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public RoomieWaistData item;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FKNABPFNIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81F7580", Offset = "0x81F6380", VA = "0x1881F7580")]
		internal void CCNLPOOJHKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81F7630", Offset = "0x81F6430", VA = "0x1881F7630")]
		internal void PHNNPJFNDJP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x81F5F00", Offset = "0x81F4D00", VA = "0x1881F5F00", Slot = "35")]
	public override void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, RoomieWaistData IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x81F6090", Offset = "0x81F4E90", VA = "0x1881F6090", Slot = "36")]
	public override void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, RoomieWaistData HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81F6120", Offset = "0x81F4F20", VA = "0x1881F6120")]
	public CBHELMDGLCJ()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SerializedAvatarItemData : IEquatable<SerializedAvatarItemData>
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xF5C830", Offset = "0xF5B630", VA = "0x180F5C830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xF5C840", Offset = "0xF5B640", VA = "0x180F5C840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1098210", Offset = "0x1097010", VA = "0x181098210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1098180", Offset = "0x1096F80", VA = "0x181098180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x227A7A0", Offset = "0x22795A0", VA = "0x18227A7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x81FA880", Offset = "0x81F9680", VA = "0x1881FA880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2F08A00", Offset = "0x2F07800", VA = "0x182F08A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2F08CB0", Offset = "0x2F07AB0", VA = "0x182F08CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAE2C00", Offset = "0xAE1A00", VA = "0x180AE2C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAE2C10", Offset = "0xAE1A10", VA = "0x180AE2C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BCIIDHEJBAB.MMBHHGOHKAA ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
			[CompilerGenerated]
			get
			{
				return default(BCIIDHEJBAB.MMBHHGOHKAA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81FA3C0", Offset = "0x81F91C0", VA = "0x1881FA3C0", Slot = "0")]
		public override bool Equals(object FGAEAFBDBPK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81FA860", Offset = "0x81F9660", VA = "0x1881FA860")]
		public static bool IKIADGFKNFC(SerializedAvatarItemData NNEMEIEKIAF, SerializedAvatarItemData JOGLOLMOJGN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81FA760", Offset = "0x81F9560", VA = "0x1881FA760")]
		public static bool GFAFFKCBFKA(SerializedAvatarItemData NNEMEIEKIAF, SerializedAvatarItemData JOGLOLMOJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81FA440", Offset = "0x81F9240", VA = "0x1881FA440", Slot = "4")]
		public bool Equals(SerializedAvatarItemData FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81FA790", Offset = "0x81F9590", VA = "0x1881FA790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
