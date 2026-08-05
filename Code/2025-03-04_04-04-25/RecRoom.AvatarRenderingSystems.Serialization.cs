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
public class HOFCNJEPLEB : MLFHGJIKKIA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA57410", Offset = "0xA55A10", VA = "0x180A57410", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x738D7D0", Offset = "0x738BDD0", VA = "0x18738D7D0", Slot = "36")]
	protected override Vector3 JMNOLPHHGGE(float[] BMKDAHEBDHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x738D820", Offset = "0x738BE20", VA = "0x18738D820", Slot = "37")]
	protected override float[] OMBEABDDNID(Vector3 KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x738D8A0", Offset = "0x738BEA0", VA = "0x18738D8A0")]
	public HOFCNJEPLEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DLLKBKBKFLE : MLFHGJIKKIA<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6D0", Offset = "0xA6DCD0", VA = "0x180A6F6D0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x738B3B0", Offset = "0x73899B0", VA = "0x18738B3B0", Slot = "36")]
	protected override Vector2 JMNOLPHHGGE(float[] BMKDAHEBDHE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x738B3F0", Offset = "0x73899F0", VA = "0x18738B3F0", Slot = "37")]
	protected override float[] OMBEABDDNID(Vector2 KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x738B460", Offset = "0x7389A60", VA = "0x18738B460")]
	public DLLKBKBKFLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MOAMBJDLMID : MLFHGJIKKIA<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA69000", Offset = "0xA67600", VA = "0x180A69000", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x738E440", Offset = "0x738CA40", VA = "0x18738E440", Slot = "36")]
	protected override Quaternion JMNOLPHHGGE(float[] BMKDAHEBDHE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x738E4A0", Offset = "0x738CAA0", VA = "0x18738E4A0", Slot = "37")]
	protected override float[] OMBEABDDNID(Quaternion KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x738E530", Offset = "0x738CB30", VA = "0x18738E530")]
	public MOAMBJDLMID()
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
		public enum ENLEBEFNIPL
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
		public ENLEBEFNIPL Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
			[CompilerGenerated]
			get
			{
				return default(ENLEBEFNIPL);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x738A130", Offset = "0x7388730", VA = "0x18738A130", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x738A030", Offset = "0x7388630", VA = "0x18738A030")]
		public static bool BFIJCNNIIMH(AvatarItemDownloadableConfig HJGDMEAJFEI, AvatarItemDownloadableConfig OHAJMMPIMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x738A260", Offset = "0x7388860", VA = "0x18738A260", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x738A330", Offset = "0x7388930", VA = "0x18738A330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD59440", Offset = "0xD57A40", VA = "0x180D59440")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, IFCLNAHLMPM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x738FEF0", Offset = "0x738E4F0", VA = "0x18738FEF0")]
		private void NHEBEOBCINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x738FD70", Offset = "0x738E370", VA = "0x18738FD70", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x738FDF0", Offset = "0x738E3F0", VA = "0x18738FDF0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x738FEE0", Offset = "0x738E4E0", VA = "0x18738FEE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x738FD50", Offset = "0x738E350", VA = "0x18738FD50", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x738FEF0", Offset = "0x738E4F0", VA = "0x18738FEF0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x738FF60", Offset = "0x738E560", VA = "0x18738FF60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HJMLBKNLPCB : MCKNLIHMKLH<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ELPPMOEABCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ELPPMOEABCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x738B550", Offset = "0x7389B50", VA = "0x18738B550")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x738B800", Offset = "0x7389E00", VA = "0x18738B800")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x738B960", Offset = "0x7389F60", VA = "0x18738B960")]
		internal void LCFOAMMGFNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x738B4A0", Offset = "0x7389AA0", VA = "0x18738B4A0")]
		internal void CHHIEKADCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x738B6A0", Offset = "0x7389CA0", VA = "0x18738B6A0")]
		internal void IAIPADFKIPI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x738B8B0", Offset = "0x7389EB0", VA = "0x18738B8B0")]
		internal void KOIDJBGFILB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x738B750", Offset = "0x7389D50", VA = "0x18738B750")]
		internal void JGIEFKGKFHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x738BA10", Offset = "0x738A010", VA = "0x18738BA10")]
		internal void NLKOFMFFJBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x738B600", Offset = "0x7389C00", VA = "0x18738B600")]
		internal void GOJNEGKKBEG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x738BAC0", Offset = "0x738A0C0", VA = "0x18738BAC0")]
		internal void PLGKEBBOBHE(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DJECDMLLIDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x738D270", Offset = "0x738B870", VA = "0x18738D270", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, AnchorParamsRestrictions MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x738CDD0", Offset = "0x738B3D0", VA = "0x18738CDD0", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, AnchorParamsRestrictions KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x738D790", Offset = "0x738BD90", VA = "0x18738D790")]
	public HJMLBKNLPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33ED510", Offset = "0x33EBB10", VA = "0x1833ED510")]
	[CompilerGenerated]
	internal static void FPICNPKEEHA<T>(string BPEJALFMHHI, T DGOEGFOLJJL, T PLLGKDEGIEI, DJECDMLLIDK P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HCDFDIAFGOG : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void LJECNOHOILP(Utf8JsonReader FBIKENCMLKN);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MOFADHKHNAH
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
		public HCDFDIAFGOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LJECNOHOILP <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LJECNOHOILP <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LJECNOHOILP <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LJECNOHOILP <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LJECNOHOILP <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LJECNOHOILP <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LJECNOHOILP <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LJECNOHOILP <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LJECNOHOILP <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public LJECNOHOILP <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LJECNOHOILP <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MOFADHKHNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x738E9F0", Offset = "0x738CFF0", VA = "0x18738E9F0")]
		internal void KIEJONJJMJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x738E6D0", Offset = "0x738CCD0", VA = "0x18738E6D0")]
		internal void CCNBFJEBMCG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x738E8A0", Offset = "0x738CEA0", VA = "0x18738E8A0")]
		internal void HAFLACJDHPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x738EA30", Offset = "0x738D030", VA = "0x18738EA30")]
		internal void KNLKMPJLJCE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x738E7B0", Offset = "0x738CDB0", VA = "0x18738E7B0")]
		internal void DEBKDDBGHJB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x738E780", Offset = "0x738CD80", VA = "0x18738E780")]
		internal void CMAIEEPBPJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x738E570", Offset = "0x738CB70", VA = "0x18738E570")]
		internal void AHNMLGDAANI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x738E5F0", Offset = "0x738CBF0", VA = "0x18738E5F0")]
		internal void CACJJBGABEG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x738E860", Offset = "0x738CE60", VA = "0x18738E860")]
		internal void GKGBIDMENEF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x738E950", Offset = "0x738CF50", VA = "0x18738E950")]
		internal void JMHAKCPDPLD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x738EAE0", Offset = "0x738D0E0", VA = "0x18738EAE0")]
		internal void MHOKPGKCFCL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IOHAHDLEKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IOHAHDLEKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x738D920", Offset = "0x738BF20", VA = "0x18738D920")]
		internal void BEHCJDBBJDB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x738BD50", Offset = "0x738A350", VA = "0x18738BD50", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x738C950", Offset = "0x738AF50", VA = "0x18738C950", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, SerializedAvatarItemData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x738BBE0", Offset = "0x738A1E0", VA = "0x18738BBE0")]
	private AdditionalOutfitTypeData AJFMLEFMIPP(Utf8JsonReader AJLILPPHPPH, OutfitType BMIPLDLMPCD, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x738CD90", Offset = "0x738B390", VA = "0x18738CD90")]
	public HCDFDIAFGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JLDHOFLKJMH : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x738D9C0", Offset = "0x738BFC0", VA = "0x18738D9C0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x738DD50", Offset = "0x738C350", VA = "0x18738DD50", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, AvatarItemDownloadableConfig KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x738DE80", Offset = "0x738C480", VA = "0x18738DE80")]
	public JLDHOFLKJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MHKFBKHMKDG : MCKNLIHMKLH<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x738DFC0", Offset = "0x738C5C0", VA = "0x18738DFC0", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, BeardData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x738DF00", Offset = "0x738C500", VA = "0x18738DF00", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, BeardData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x738E160", Offset = "0x738C760", VA = "0x18738E160")]
	public MHKFBKHMKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GLLOJHGHPIA : CLJFMOCFBOB<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x738BBA0", Offset = "0x738A1A0", VA = "0x18738BBA0")]
	public GLLOJHGHPIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EOAFAJOBEJF : CLJFMOCFBOB<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x738BB60", Offset = "0x738A160", VA = "0x18738BB60")]
	public EOAFAJOBEJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KAIKPLIMHGP : CLJFMOCFBOB<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x738DEC0", Offset = "0x738C4C0", VA = "0x18738DEC0")]
	public KAIKPLIMHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IIIPDDBHDDA : MPEPLCFNKMJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x738D8E0", Offset = "0x738BEE0", VA = "0x18738D8E0")]
	public IIIPDDBHDDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MMIILCJIPJI : MCKNLIHMKLH<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MPIOOOJKPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MPIOOOJKPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7389F00", Offset = "0x7388500", VA = "0x187389F00")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x738EC60", Offset = "0x738D260", VA = "0x18738EC60")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x738E270", Offset = "0x738C870", VA = "0x18738E270", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, AdditionalFeetData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x738E1A0", Offset = "0x738C7A0", VA = "0x18738E1A0", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, AdditionalFeetData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x738E400", Offset = "0x738CA00", VA = "0x18738E400")]
	public MMIILCJIPJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NLOIMOLGENL : MCKNLIHMKLH<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AIDAACFJPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AIDAACFJPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7389DB0", Offset = "0x73883B0", VA = "0x187389DB0")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7389F30", Offset = "0x7388530", VA = "0x187389F30")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x738A000", Offset = "0x7388600", VA = "0x18738A000")]
		internal void LCFOAMMGFNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7389D10", Offset = "0x7388310", VA = "0x187389D10")]
		internal void CHHIEKADCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7389E60", Offset = "0x7388460", VA = "0x187389E60")]
		internal void IAIPADFKIPI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7389F60", Offset = "0x7388560", VA = "0x187389F60")]
		internal void KOIDJBGFILB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7389F00", Offset = "0x7388500", VA = "0x187389F00")]
		internal void JGIEFKGKFHB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x738F440", Offset = "0x738DA40", VA = "0x18738F440", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, HairData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x738F160", Offset = "0x738D760", VA = "0x18738F160", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, HairData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x738F830", Offset = "0x738DE30", VA = "0x18738F830")]
	public NLOIMOLGENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CMGAPODAJPJ : MCKNLIHMKLH<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NEKNKKGPIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NEKNKKGPIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x738ED40", Offset = "0x738D340", VA = "0x18738ED40")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x738EEC0", Offset = "0x738D4C0", VA = "0x18738EEC0")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x738F010", Offset = "0x738D610", VA = "0x18738F010")]
		internal void LCFOAMMGFNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x738EC90", Offset = "0x738D290", VA = "0x18738EC90")]
		internal void CHHIEKADCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x738ED70", Offset = "0x738D370", VA = "0x18738ED70")]
		internal void IAIPADFKIPI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x738EF70", Offset = "0x738D570", VA = "0x18738EF70")]
		internal void KOIDJBGFILB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x738EE20", Offset = "0x738D420", VA = "0x18738EE20")]
		internal void JGIEFKGKFHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x738F0C0", Offset = "0x738D6C0", VA = "0x18738F0C0")]
		internal void NLKOFMFFJBG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x738AF10", Offset = "0x7389510", VA = "0x18738AF10", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, AdditionalHatData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x738ABC0", Offset = "0x73891C0", VA = "0x18738ABC0", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, AdditionalHatData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x738B370", Offset = "0x7389970", VA = "0x18738B370")]
	public CMGAPODAJPJ()
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x954450", Offset = "0x952A50", VA = "0x180954450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC9DCD0", Offset = "0xC9C2D0", VA = "0x180C9DCD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC9DDF0", Offset = "0xC9C3F0", VA = "0x180C9DDF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xC9DCE0", Offset = "0xC9C2E0", VA = "0x180C9DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD69900", Offset = "0xD67F00", VA = "0x180D69900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD69830", Offset = "0xD67E30", VA = "0x180D69830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1D14B90", Offset = "0x1D13190", VA = "0x181D14B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x738FD40", Offset = "0x738E340", VA = "0x18738FD40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x29355A0", Offset = "0x2933BA0", VA = "0x1829355A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x29354D0", Offset = "0x2933AD0", VA = "0x1829354D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB65920", Offset = "0xB63F20", VA = "0x180B65920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB65970", Offset = "0xB63F70", VA = "0x180B65970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KBAIGJMAONF.FALICHFPADL ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
			[CompilerGenerated]
			get
			{
				return default(KBAIGJMAONF.FALICHFPADL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x680BEC0", Offset = "0x680A4C0", VA = "0x18680BEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x956B10", Offset = "0x955110", VA = "0x180956B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x738F890", Offset = "0x738DE90", VA = "0x18738F890", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x738F870", Offset = "0x738DE70", VA = "0x18738F870")]
		public static bool BFIJCNNIIMH(SerializedAvatarItemData HJGDMEAJFEI, SerializedAvatarItemData OHAJMMPIMHB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x738FD10", Offset = "0x738E310", VA = "0x18738FD10")]
		public static bool HKDAGECLGLD(SerializedAvatarItemData HJGDMEAJFEI, SerializedAvatarItemData OHAJMMPIMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x738F920", Offset = "0x738DF20", VA = "0x18738F920", Slot = "4")]
		public bool Equals(SerializedAvatarItemData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x738FC40", Offset = "0x738E240", VA = "0x18738FC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
