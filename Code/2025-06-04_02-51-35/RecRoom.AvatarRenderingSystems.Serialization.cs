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
public class OIGAFPONDAA : GEAHDMLOABK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC45D10", Offset = "0xC44510", VA = "0x180C45D10", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E208D0", Offset = "0x7E1F0D0", VA = "0x187E208D0", Slot = "36")]
	protected override Vector3 IKPJLBNBOMO(float[] IFMNLKCJNMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E20850", Offset = "0x7E1F050", VA = "0x187E20850", Slot = "37")]
	protected override float[] FJIGKPPDAMG(Vector3 MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E20920", Offset = "0x7E1F120", VA = "0x187E20920")]
	public OIGAFPONDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AOCEBIDOGAG : GEAHDMLOABK<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC5FA30", Offset = "0xC5E230", VA = "0x180C5FA30", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B290", Offset = "0x7E19A90", VA = "0x187E1B290", Slot = "36")]
	protected override Vector2 IKPJLBNBOMO(float[] IFMNLKCJNMD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B220", Offset = "0x7E19A20", VA = "0x187E1B220", Slot = "37")]
	protected override float[] FJIGKPPDAMG(Vector2 MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B2D0", Offset = "0x7E19AD0", VA = "0x187E1B2D0")]
	public AOCEBIDOGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AIFHKNEJABG : GEAHDMLOABK<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACD380", VA = "0x180ACEB80", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B180", Offset = "0x7E19980", VA = "0x187E1B180", Slot = "36")]
	protected override Quaternion IKPJLBNBOMO(float[] IFMNLKCJNMD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B0F0", Offset = "0x7E198F0", VA = "0x187E1B0F0", Slot = "37")]
	protected override float[] FJIGKPPDAMG(Quaternion MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B1E0", Offset = "0x7E199E0", VA = "0x187E1B1E0")]
	public AIFHKNEJABG()
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
		public enum IOCAAJDOHPJ
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
		public IOCAAJDOHPJ Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
			[CompilerGenerated]
			get
			{
				return default(IOCAAJDOHPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B310", Offset = "0x7E19B10", VA = "0x187E1B310", Slot = "0")]
		public override bool Equals(object KEKEFPAJGHD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B580", Offset = "0x7E19D80", VA = "0x187E1B580")]
		public static bool NALNDDPCEFD(AvatarItemDownloadableConfig HGBNKPCDEON, AvatarItemDownloadableConfig DPOCHOAKFKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B440", Offset = "0x7E19C40", VA = "0x187E1B440", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B510", Offset = "0x7E19D10", VA = "0x187E1B510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF65EB0", Offset = "0xF646B0", VA = "0x180F65EB0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, ODFIDMKBKKG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7E21270", Offset = "0x7E1FA70", VA = "0x187E21270")]
		private void IDGIBDDBEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7E210F0", Offset = "0x7E1F8F0", VA = "0x187E210F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E21170", Offset = "0x7E1F970", VA = "0x187E21170", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E21260", Offset = "0x7E1FA60", VA = "0x187E21260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E210D0", Offset = "0x7E1F8D0", VA = "0x187E210D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection KEKEFPAJGHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
		public Guid BHIOJGJBPAC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E21270", Offset = "0x7E1FA70", VA = "0x187E21270", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E212E0", Offset = "0x7E1FAE0", VA = "0x187E212E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DEDFNGOAKAG : BDDNLIMCNOC<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EKFFLELILCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EKFFLELILCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CE50", Offset = "0x7E1B650", VA = "0x187E1CE50")]
		internal void FDDKDCEONMO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D3B0", Offset = "0x7E1BBB0", VA = "0x187E1D3B0")]
		internal void PGAHHNAJNPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D050", Offset = "0x7E1B850", VA = "0x187E1D050")]
		internal void IJGKDBOCPGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CF00", Offset = "0x7E1B700", VA = "0x187E1CF00")]
		internal void HGPJHGOBFHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D100", Offset = "0x7E1B900", VA = "0x187E1D100")]
		internal void JDOFBMIMKOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D260", Offset = "0x7E1BA60", VA = "0x187E1D260")]
		internal void MDJBLIDIGDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CDA0", Offset = "0x7E1B5A0", VA = "0x187E1CDA0")]
		internal void DAKLEFKICGN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D1B0", Offset = "0x7E1B9B0", VA = "0x187E1D1B0")]
		internal void JOHHOCFAMHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BB10", VA = "0x187E1D310")]
		internal void NDGIDDCDJHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CFB0", Offset = "0x7E1B7B0", VA = "0x187E1CFB0")]
		internal void HLDJHGEKEOP(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HAMALHDNMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C840", Offset = "0x7E1B040", VA = "0x187E1C840", Slot = "35")]
	public override void KMKGHPILDNA(Utf8JsonReader JEPFPDOKDAD, JsonSerializerOptions OJJIDCCJBBN, string EMGNLEIBFNM, AnchorParamsRestrictions NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C3B0", Offset = "0x7E1ABB0", VA = "0x187E1C3B0", Slot = "36")]
	public override void FMFGIHEADPF(Utf8JsonWriter LFDMHEHCHCC, AnchorParamsRestrictions MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E1CD60", Offset = "0x7E1B560", VA = "0x187E1CD60")]
	public DEDFNGOAKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37F5AA0", Offset = "0x37F42A0", VA = "0x1837F5AA0")]
	[CompilerGenerated]
	internal static void CMMFDMDDELH<T>(string EMGNLEIBFNM, T AMJBMFFPJLL, T IHBFPICDFEB, HAMALHDNMIH P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FAOMFICFAOG : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void HMDFDJLKOBG(Utf8JsonReader NLCEHLDPLPE);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OEEMIDBAAIE
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
		public FAOMFICFAOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public HMDFDJLKOBG <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HMDFDJLKOBG <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HMDFDJLKOBG <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HMDFDJLKOBG <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HMDFDJLKOBG <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HMDFDJLKOBG <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HMDFDJLKOBG <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HMDFDJLKOBG <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HMDFDJLKOBG <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HMDFDJLKOBG <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HMDFDJLKOBG <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OEEMIDBAAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E205B0", Offset = "0x7E1EDB0", VA = "0x187E205B0")]
		internal void KHOHPDBEFEB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E20380", Offset = "0x7E1EB80", VA = "0x187E20380")]
		internal void FADJKHLNJLN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E20500", Offset = "0x7E1ED00", VA = "0x187E20500")]
		internal void IPDCCDBEMND(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E20160", Offset = "0x7E1E960", VA = "0x187E20160")]
		internal void AMDDOHFOKGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E20290", Offset = "0x7E1EA90", VA = "0x187E20290")]
		internal void DCBNBPJOFEL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E20430", Offset = "0x7E1EC30", VA = "0x187E20430")]
		internal void FBAPDIMINGM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E20210", Offset = "0x7E1EA10", VA = "0x187E20210")]
		internal void COAOCBHOCGO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E205F0", Offset = "0x7E1EDF0", VA = "0x187E205F0")]
		internal void KMMIBHPNPMD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E20340", Offset = "0x7E1EB40", VA = "0x187E20340")]
		internal void DGJGICALPDA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E20460", Offset = "0x7E1EC60", VA = "0x187E20460")]
		internal void GKJDCECGOAN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E206D0", Offset = "0x7E1EED0", VA = "0x187E206D0")]
		internal void LAFMNCGGIDN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LBJEANGJFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LBJEANGJFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E20080", Offset = "0x7E1E880", VA = "0x187E20080")]
		internal void LAONOGHPKBN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D8F0", Offset = "0x7E1C0F0", VA = "0x187E1D8F0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E4D0", Offset = "0x7E1CCD0", VA = "0x187E1E4D0", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, SerializedAvatarItemData MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D780", Offset = "0x7E1BF80", VA = "0x187E1D780")]
	private AdditionalOutfitTypeData JFPOBGPGFFC(Utf8JsonReader JEPFPDOKDAD, OutfitType CEPGAJKBPDM, JsonSerializerOptions OJJIDCCJBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E910", Offset = "0x7E1D110", VA = "0x187E1E910")]
	public FAOMFICFAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KHADHNDHOMM : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FB80", Offset = "0x7E1E380", VA = "0x187E1FB80", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader JEPFPDOKDAD, Type EOJKPDKKBGA, JsonSerializerOptions OJJIDCCJBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FF10", Offset = "0x7E1E710", VA = "0x187E1FF10", Slot = "28")]
	public override void Write(Utf8JsonWriter LFDMHEHCHCC, AvatarItemDownloadableConfig MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E20040", Offset = "0x7E1E840", VA = "0x187E20040")]
	public KHADHNDHOMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GFBBPOJHJBK : BDDNLIMCNOC<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F1F0", Offset = "0x7E1D9F0", VA = "0x187E1F1F0", Slot = "35")]
	public override void KMKGHPILDNA(Utf8JsonReader JEPFPDOKDAD, JsonSerializerOptions OJJIDCCJBBN, string EMGNLEIBFNM, BeardData NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F130", Offset = "0x7E1D930", VA = "0x187E1F130", Slot = "36")]
	public override void FMFGIHEADPF(Utf8JsonWriter LFDMHEHCHCC, BeardData MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F390", Offset = "0x7E1DB90", VA = "0x187E1F390")]
	public GFBBPOJHJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NFDBLCIOEFG : BEBMIAMBMOI<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E20120", Offset = "0x7E1E920", VA = "0x187E20120")]
	public NFDBLCIOEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JEAGPGLHCAN : BEBMIAMBMOI<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FB40", Offset = "0x7E1E340", VA = "0x187E1FB40")]
	public JEAGPGLHCAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HJNFNKNCMDP : BEBMIAMBMOI<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FB00", Offset = "0x7E1E300", VA = "0x187E1FB00")]
	public HJNFNKNCMDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BOHFIJKCNBC : PHDKKHLFCPM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C370", Offset = "0x7E1AB70", VA = "0x187E1C370")]
	public BOHFIJKCNBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class POGHMLOLNKN : BDDNLIMCNOC<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GOMGGEOHNNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GOMGGEOHNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D460", Offset = "0x7E1BC60", VA = "0x187E1D460")]
		internal void FDDKDCEONMO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F3D0", Offset = "0x7E1DBD0", VA = "0x187E1F3D0")]
		internal void PGAHHNAJNPC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A30", Offset = "0x7E1F230", VA = "0x187E20A30", Slot = "35")]
	public override void KMKGHPILDNA(Utf8JsonReader JEPFPDOKDAD, JsonSerializerOptions OJJIDCCJBBN, string EMGNLEIBFNM, AdditionalFeetData NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E20960", Offset = "0x7E1F160", VA = "0x187E20960", Slot = "36")]
	public override void FMFGIHEADPF(Utf8JsonWriter LFDMHEHCHCC, AdditionalFeetData MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E20BC0", Offset = "0x7E1F3C0", VA = "0x187E20BC0")]
	public POGHMLOLNKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HEDPBEIALDI : BDDNLIMCNOC<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EPGEOFKPJPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EPGEOFKPJPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D490", Offset = "0x7E1BC90", VA = "0x187E1D490")]
		internal void FDDKDCEONMO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D750", Offset = "0x7E1BF50", VA = "0x187E1D750")]
		internal void PGAHHNAJNPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D5E0", Offset = "0x7E1BDE0", VA = "0x187E1D5E0")]
		internal void IJGKDBOCPGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D540", Offset = "0x7E1BD40", VA = "0x187E1D540")]
		internal void HGPJHGOBFHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D610", Offset = "0x7E1BE10", VA = "0x187E1D610")]
		internal void JDOFBMIMKOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D6B0", Offset = "0x7E1BEB0", VA = "0x187E1D6B0")]
		internal void MDJBLIDIGDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D460", Offset = "0x7E1BC60", VA = "0x187E1D460")]
		internal void DAKLEFKICGN(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F6D0", Offset = "0x7E1DED0", VA = "0x187E1F6D0", Slot = "35")]
	public override void KMKGHPILDNA(Utf8JsonReader JEPFPDOKDAD, JsonSerializerOptions OJJIDCCJBBN, string EMGNLEIBFNM, HairData NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F400", Offset = "0x7E1DC00", VA = "0x187E1F400", Slot = "36")]
	public override void FMFGIHEADPF(Utf8JsonWriter LFDMHEHCHCC, HairData MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1FAC0", Offset = "0x7E1E2C0", VA = "0x187E1FAC0")]
	public HEDPBEIALDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GAMGFNNGNCI : BDDNLIMCNOC<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BINCANMKJKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BINCANMKJKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BF40", Offset = "0x7E1A740", VA = "0x187E1BF40")]
		internal void FDDKDCEONMO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C2C0", Offset = "0x7E1AAC0", VA = "0x187E1C2C0")]
		internal void PGAHHNAJNPC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C020", Offset = "0x7E1A820", VA = "0x187E1C020")]
		internal void IJGKDBOCPGI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BF70", Offset = "0x7E1A770", VA = "0x187E1BF70")]
		internal void HGPJHGOBFHC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C0D0", Offset = "0x7E1A8D0", VA = "0x187E1C0D0")]
		internal void JDOFBMIMKOC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C220", Offset = "0x7E1AA20", VA = "0x187E1C220")]
		internal void MDJBLIDIGDG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEA0", Offset = "0x7E1A6A0", VA = "0x187E1BEA0")]
		internal void DAKLEFKICGN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C180", Offset = "0x7E1A980", VA = "0x187E1C180")]
		internal void JOHHOCFAMHL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EC90", Offset = "0x7E1D490", VA = "0x187E1EC90", Slot = "35")]
	public override void KMKGHPILDNA(Utf8JsonReader JEPFPDOKDAD, JsonSerializerOptions OJJIDCCJBBN, string EMGNLEIBFNM, AdditionalHatData NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E950", Offset = "0x7E1D150", VA = "0x187E1E950", Slot = "36")]
	public override void FMFGIHEADPF(Utf8JsonWriter LFDMHEHCHCC, AdditionalHatData MGONBEDEDON, JsonSerializerOptions OJJIDCCJBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F0F0", Offset = "0x7E1D8F0", VA = "0x187E1F0F0")]
	public GAMGFNNGNCI()
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
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE3E930", Offset = "0xE3D130", VA = "0x180E3E930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xE3E920", Offset = "0xE3D120", VA = "0x180E3E920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF84940", Offset = "0xF83140", VA = "0x180F84940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF84DA0", Offset = "0xF835A0", VA = "0x180F84DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x20249F0", Offset = "0x20231F0", VA = "0x1820249F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7E210C0", Offset = "0x7E1F8C0", VA = "0x187E210C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2C9AD00", Offset = "0x2C99500", VA = "0x182C9AD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2C9ACD0", Offset = "0x2C994D0", VA = "0x182C9ACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD35DF0", Offset = "0xD345F0", VA = "0x180D35DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xD35E40", Offset = "0xD34640", VA = "0x180D35E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AFHHIDGAGFC.KICMKFFCOMP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return default(AFHHIDGAGFC.KICMKFFCOMP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E20C30", Offset = "0x7E1F430", VA = "0x187E20C30", Slot = "0")]
		public override bool Equals(object KEKEFPAJGHD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E210A0", Offset = "0x7E1F8A0", VA = "0x187E210A0")]
		public static bool NALNDDPCEFD(SerializedAvatarItemData HGBNKPCDEON, SerializedAvatarItemData DPOCHOAKFKE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E20C00", Offset = "0x7E1F400", VA = "0x187E20C00")]
		public static bool BLLMPNNLKNM(SerializedAvatarItemData HGBNKPCDEON, SerializedAvatarItemData DPOCHOAKFKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E20CB0", Offset = "0x7E1F4B0", VA = "0x187E20CB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E20FD0", Offset = "0x7E1F7D0", VA = "0x187E20FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
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
