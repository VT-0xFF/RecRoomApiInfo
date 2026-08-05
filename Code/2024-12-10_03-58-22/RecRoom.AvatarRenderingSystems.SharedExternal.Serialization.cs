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
public class HNMFBMKAPDI : BPOCLIJIKEF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA69BA0", Offset = "0xA687A0", VA = "0x180A69BA0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2780", Offset = "0x6AE1380", VA = "0x186AE2780", Slot = "36")]
	protected override Vector3 BIACDEHNKOG(float[] ILAABJMNJPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AE27D0", Offset = "0x6AE13D0", VA = "0x186AE27D0", Slot = "37")]
	protected override float[] GAPKACFFPLK(Vector3 CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2850", Offset = "0x6AE1450", VA = "0x186AE2850")]
	public HNMFBMKAPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HCLLDDCMCMA : BPOCLIJIKEF<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F6D0", VA = "0x180910AD0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2660", Offset = "0x6AE1260", VA = "0x186AE2660", Slot = "36")]
	protected override Vector2 BIACDEHNKOG(float[] ILAABJMNJPL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AE26A0", Offset = "0x6AE12A0", VA = "0x186AE26A0", Slot = "37")]
	protected override float[] GAPKACFFPLK(Vector2 CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2710", Offset = "0x6AE1310", VA = "0x186AE2710")]
	public HCLLDDCMCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GEIBNKALMBH : BPOCLIJIKEF<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA70300", Offset = "0xA6EF00", VA = "0x180A70300", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE24B0", Offset = "0x6AE10B0", VA = "0x186AE24B0", Slot = "36")]
	protected override Quaternion BIACDEHNKOG(float[] ILAABJMNJPL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2510", Offset = "0x6AE1110", VA = "0x186AE2510", Slot = "37")]
	protected override float[] GAPKACFFPLK(Quaternion CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE25A0", Offset = "0x6AE11A0", VA = "0x186AE25A0")]
	public GEIBNKALMBH()
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
		public enum KCGBIFBEKOH
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
		public KCGBIFBEKOH Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0")]
			[CompilerGenerated]
			get
			{
				return default(KCGBIFBEKOH);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x88FB90", Offset = "0x88E790", VA = "0x18088FB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F8E70", Offset = "0x8F7A70", VA = "0x1808F8E70")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, FABBPMKDCKI, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6440", Offset = "0x6AE5040", VA = "0x186AE6440")]
		public SerializedAvatarItemSelection(DMMPCDIHBGH LFNBHNHHMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6350", Offset = "0x6AE4F50", VA = "0x186AE6350")]
		private void FIAJKGNCNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61E0", Offset = "0x6AE4DE0", VA = "0x186AE61E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6260", Offset = "0x6AE4E60", VA = "0x186AE6260", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6350", Offset = "0x6AE4F50", VA = "0x186AE6350", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63D0", Offset = "0x6AE4FD0", VA = "0x186AE63D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PFKHDDEDFBK : ONEMIHCAHBB<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JJAGLILBELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JJAGLILBELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2C20", Offset = "0x6AE1820", VA = "0x186AE2C20")]
		internal void NOGECGIFFBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2AC0", Offset = "0x6AE16C0", VA = "0x186AE2AC0")]
		internal void MGNEGLAKNFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2CD0", Offset = "0x6AE18D0", VA = "0x186AE2CD0")]
		internal void NPFJMIGEKBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2D80", Offset = "0x6AE1980", VA = "0x186AE2D80")]
		internal void OAOLNPNOKPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2EE0", Offset = "0x6AE1AE0", VA = "0x186AE2EE0")]
		internal void PPGLMDLFJNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2B70", Offset = "0x6AE1770", VA = "0x186AE2B70")]
		internal void NABKAHCHDEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2E30", Offset = "0x6AE1A30", VA = "0x186AE2E30")]
		internal void PBHIPBANGMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2A10", Offset = "0x6AE1610", VA = "0x186AE2A10")]
		internal void MBADANNPCIE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE28D0", Offset = "0x6AE14D0", VA = "0x186AE28D0")]
		internal void AHAJAIKKLPG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2970", Offset = "0x6AE1570", VA = "0x186AE2970")]
		internal void EIEPFLDNIGC(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CCGEEJKKAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5C50", Offset = "0x6AE4850", VA = "0x186AE5C50", Slot = "35")]
	public override void POGBHJBKHLK(Utf8JsonReader DMECMNHFOBP, JsonSerializerOptions OGIKBJOPPCP, string NMDOFAJBOFG, AnchorParamsRestrictions ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE57C0", Offset = "0x6AE43C0", VA = "0x186AE57C0", Slot = "36")]
	public override void LJCEODACPDA(Utf8JsonWriter CDCPEBLNAND, AnchorParamsRestrictions CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6170", Offset = "0x6AE4D70", VA = "0x186AE6170")]
	public PFKHDDEDFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2FD72B0", Offset = "0x2FD5EB0", VA = "0x182FD72B0")]
	[CompilerGenerated]
	internal static void IEKBFKPIIHI<T>(string NMDOFAJBOFG, T JEODFFDGHHF, T BDKCBCJLLEC, CCGEEJKKAKG P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LDLGHBBMKJA : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void BDIFJFFCNON(Utf8JsonReader LNOMDCGJNHN);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PDIKNGMAFHA
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
		public LDLGHBBMKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BDIFJFFCNON <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BDIFJFFCNON <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BDIFJFFCNON <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public BDIFJFFCNON <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BDIFJFFCNON <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BDIFJFFCNON <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BDIFJFFCNON <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BDIFJFFCNON <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BDIFJFFCNON <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BDIFJFFCNON <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BDIFJFFCNON <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public PDIKNGMAFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5620", Offset = "0x6AE4220", VA = "0x186AE5620")]
		internal void KANHNGPJPGL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5660", Offset = "0x6AE4260", VA = "0x186AE5660")]
		internal void OMDJABNPICE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5710", Offset = "0x6AE4310", VA = "0x186AE5710")]
		internal void PGNDLEHJJOD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5100", Offset = "0x6AE3D00", VA = "0x186AE5100")]
		internal void BCGIMKFFCLL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5490", Offset = "0x6AE4090", VA = "0x186AE5490")]
		internal void FPNNHHGECPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1970", Offset = "0x6AE0570", VA = "0x186AE1970")]
		internal void KJOJPFODCOB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AE51B0", Offset = "0x6AE3DB0", VA = "0x186AE51B0")]
		internal void DJJJFPDMGJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5230", Offset = "0x6AE3E30", VA = "0x186AE5230")]
		internal void DJMFLINCAPP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE55E0", Offset = "0x6AE41E0", VA = "0x186AE55E0")]
		internal void HIJDACLGGPB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5540", Offset = "0x6AE4140", VA = "0x186AE5540")]
		internal void GAOGPEPDMHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5310", Offset = "0x6AE3F10", VA = "0x186AE5310")]
		internal void FKAPAELHJHG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ABBDIMJGPLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ABBDIMJGPLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0A60", Offset = "0x6ADF660", VA = "0x186AE0A60")]
		internal void PEHOPOHLKDF(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3890", Offset = "0x6AE2490", VA = "0x186AE3890", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4470", Offset = "0x6AE3070", VA = "0x186AE4470", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, SerializedAvatarItemData CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3720", Offset = "0x6AE2320", VA = "0x186AE3720")]
	private AdditionalOutfitTypeData JKBJGKNMFPP(Utf8JsonReader DMECMNHFOBP, OutfitType FIFJJNIIAPF, JsonSerializerOptions OGIKBJOPPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE48A0", Offset = "0x6AE34A0", VA = "0x186AE48A0")]
	public LDLGHBBMKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JNDOMGPANCI : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3230", Offset = "0x6AE1E30", VA = "0x186AE3230", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader DMECMNHFOBP, Type JDCBADJPEPC, JsonSerializerOptions OGIKBJOPPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6AE35C0", Offset = "0x6AE21C0", VA = "0x186AE35C0", Slot = "28")]
	public override void Write(Utf8JsonWriter CDCPEBLNAND, AvatarItemDownloadableConfig CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AE36E0", Offset = "0x6AE22E0", VA = "0x186AE36E0")]
	public JNDOMGPANCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GCJHANLJIDN : ONEMIHCAHBB<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AE22D0", Offset = "0x6AE0ED0", VA = "0x186AE22D0", Slot = "35")]
	public override void POGBHJBKHLK(Utf8JsonReader DMECMNHFOBP, JsonSerializerOptions OGIKBJOPPCP, string NMDOFAJBOFG, BeardData ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2210", Offset = "0x6AE0E10", VA = "0x186AE2210", Slot = "36")]
	public override void LJCEODACPDA(Utf8JsonWriter CDCPEBLNAND, BeardData CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2470", Offset = "0x6AE1070", VA = "0x186AE2470")]
	public GCJHANLJIDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class INMDIDBMDLO : NDCIELLONGP<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2890", Offset = "0x6AE1490", VA = "0x186AE2890")]
	public INMDIDBMDLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GIJPKPKFLDC : NDCIELLONGP<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE25E0", Offset = "0x6AE11E0", VA = "0x186AE25E0")]
	public GIJPKPKFLDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LKNPLPKHBFJ : NDCIELLONGP<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE48E0", Offset = "0x6AE34E0", VA = "0x186AE48E0")]
	public LKNPLPKHBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GJCOADBIGGE : ANOBNMLLACN<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2620", Offset = "0x6AE1220", VA = "0x186AE2620")]
	public GJCOADBIGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JKHLOONEIAG : ONEMIHCAHBB<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HMKLGFDGMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public HMKLGFDGMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1A40", Offset = "0x6AE0640", VA = "0x186AE1A40")]
		internal void NOGECGIFFBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2750", Offset = "0x6AE1350", VA = "0x186AE2750")]
		internal void MGNEGLAKNFO(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3060", Offset = "0x6AE1C60", VA = "0x186AE3060", Slot = "35")]
	public override void POGBHJBKHLK(Utf8JsonReader DMECMNHFOBP, JsonSerializerOptions OGIKBJOPPCP, string NMDOFAJBOFG, AdditionalFeetData ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2F90", Offset = "0x6AE1B90", VA = "0x186AE2F90", Slot = "36")]
	public override void LJCEODACPDA(Utf8JsonWriter CDCPEBLNAND, AdditionalFeetData CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6AE31F0", Offset = "0x6AE1DF0", VA = "0x186AE31F0")]
	public JKHLOONEIAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FMBCFDJJIND : ONEMIHCAHBB<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DHEPOLEDING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DHEPOLEDING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6AE18C0", Offset = "0x6AE04C0", VA = "0x186AE18C0")]
		internal void NOGECGIFFBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE17F0", Offset = "0x6AE03F0", VA = "0x186AE17F0")]
		internal void MGNEGLAKNFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1970", Offset = "0x6AE0570", VA = "0x186AE1970")]
		internal void NPFJMIGEKBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE19A0", Offset = "0x6AE05A0", VA = "0x186AE19A0")]
		internal void OAOLNPNOKPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1A70", Offset = "0x6AE0670", VA = "0x186AE1A70")]
		internal void PPGLMDLFJNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1820", Offset = "0x6AE0420", VA = "0x186AE1820")]
		internal void NABKAHCHDEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1A40", Offset = "0x6AE0640", VA = "0x186AE1A40")]
		internal void PBHIPBANGMK(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1DE0", Offset = "0x6AE09E0", VA = "0x186AE1DE0", Slot = "35")]
	public override void POGBHJBKHLK(Utf8JsonReader DMECMNHFOBP, JsonSerializerOptions OGIKBJOPPCP, string NMDOFAJBOFG, HairData ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1B10", Offset = "0x6AE0710", VA = "0x186AE1B10", Slot = "36")]
	public override void LJCEODACPDA(Utf8JsonWriter CDCPEBLNAND, HairData CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AE21D0", Offset = "0x6AE0DD0", VA = "0x186AE21D0")]
	public FMBCFDJJIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LOOBOOFAJEI : ONEMIHCAHBB<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ALECGKMLJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ALECGKMLJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0CF0", Offset = "0x6ADF8F0", VA = "0x186AE0CF0")]
		internal void NOGECGIFFBC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0BA0", Offset = "0x6ADF7A0", VA = "0x186AE0BA0")]
		internal void MGNEGLAKNFO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0D20", Offset = "0x6ADF920", VA = "0x186AE0D20")]
		internal void NPFJMIGEKBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0DD0", Offset = "0x6ADF9D0", VA = "0x186AE0DD0")]
		internal void OAOLNPNOKPM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0F20", Offset = "0x6ADFB20", VA = "0x186AE0F20")]
		internal void PPGLMDLFJNL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0C50", Offset = "0x6ADF850", VA = "0x186AE0C50")]
		internal void NABKAHCHDEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0E80", Offset = "0x6ADFA80", VA = "0x186AE0E80")]
		internal void PBHIPBANGMK(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0B00", Offset = "0x6ADF700", VA = "0x186AE0B00")]
		internal void MBADANNPCIE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4C60", Offset = "0x6AE3860", VA = "0x186AE4C60", Slot = "35")]
	public override void POGBHJBKHLK(Utf8JsonReader DMECMNHFOBP, JsonSerializerOptions OGIKBJOPPCP, string NMDOFAJBOFG, AdditionalHatData ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4920", Offset = "0x6AE3520", VA = "0x186AE4920", Slot = "36")]
	public override void LJCEODACPDA(Utf8JsonWriter CDCPEBLNAND, AdditionalHatData CABLCDOIFFL, JsonSerializerOptions OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AE50C0", Offset = "0x6AE3CC0", VA = "0x186AE50C0")]
	public LOOBOOFAJEI()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x887AD0", Offset = "0x8866D0", VA = "0x180887AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD13460", Offset = "0xD12060", VA = "0x180D13460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x108B170", Offset = "0x1089D70", VA = "0x18108B170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x10CF720", Offset = "0x10CE320", VA = "0x1810CF720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9145B0", Offset = "0x9131B0", VA = "0x1809145B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x914520", Offset = "0x913120", VA = "0x180914520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1645750", Offset = "0x1644350", VA = "0x181645750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6AE61B0", Offset = "0x6AE4DB0", VA = "0x186AE61B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x24D5730", Offset = "0x24D4330", VA = "0x1824D5730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x24D5AB0", Offset = "0x24D46B0", VA = "0x1824D5AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1D5AF70", Offset = "0x1D59B70", VA = "0x181D5AF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1D5AF80", Offset = "0x1D59B80", VA = "0x181D5AF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HDFJPOEIMPO.CLDPEDONPKD ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCDF830", Offset = "0xCDE430", VA = "0x180CDF830")]
			[CompilerGenerated]
			get
			{
				return default(HDFJPOEIMPO.CLDPEDONPKD);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCDF440", Offset = "0xCDE040", VA = "0x180CDF440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x88C4B0", Offset = "0x88B0B0", VA = "0x18088C4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
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
