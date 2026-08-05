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
		[Cpp2IlInjected.Address(RVA = "0xA4F470", Offset = "0xA4E870", VA = "0x180A4F470", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72F3D90", Offset = "0x72F3190", VA = "0x1872F3D90", Slot = "36")]
	protected override Vector3 JMNOLPHHGGE(float[] BMKDAHEBDHE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72F3DE0", Offset = "0x72F31E0", VA = "0x1872F3DE0", Slot = "37")]
	protected override float[] OMBEABDDNID(Vector3 KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72F3E60", Offset = "0x72F3260", VA = "0x1872F3E60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72F1980", Offset = "0x72F0D80", VA = "0x1872F1980", Slot = "36")]
	protected override Vector2 JMNOLPHHGGE(float[] BMKDAHEBDHE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72F19C0", Offset = "0x72F0DC0", VA = "0x1872F19C0", Slot = "37")]
	protected override float[] OMBEABDDNID(Vector2 KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72F1A30", Offset = "0x72F0E30", VA = "0x1872F1A30")]
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
		[Cpp2IlInjected.Address(RVA = "0xA608F0", Offset = "0xA5FCF0", VA = "0x180A608F0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72F4A00", Offset = "0x72F3E00", VA = "0x1872F4A00", Slot = "36")]
	protected override Quaternion JMNOLPHHGGE(float[] BMKDAHEBDHE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72F4A60", Offset = "0x72F3E60", VA = "0x1872F4A60", Slot = "37")]
	protected override float[] OMBEABDDNID(Quaternion KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72F4AF0", Offset = "0x72F3EF0", VA = "0x1872F4AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0")]
			[CompilerGenerated]
			get
			{
				return default(ENLEBEFNIPL);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x952480", Offset = "0x951880", VA = "0x180952480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72F0700", Offset = "0x72EFB00", VA = "0x1872F0700", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72F0600", Offset = "0x72EFA00", VA = "0x1872F0600")]
		public static bool BFIJCNNIIMH(AvatarItemDownloadableConfig HJGDMEAJFEI, AvatarItemDownloadableConfig OHAJMMPIMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72F0830", Offset = "0x72EFC30", VA = "0x1872F0830", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72F0900", Offset = "0x72EFD00", VA = "0x1872F0900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD4B5B0", Offset = "0xD4A9B0", VA = "0x180D4B5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F6480", Offset = "0x72F5880", VA = "0x1872F6480")]
		private void NHEBEOBCINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72F6300", Offset = "0x72F5700", VA = "0x1872F6300", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72F6380", Offset = "0x72F5780", VA = "0x1872F6380", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72F6480", Offset = "0x72F5880", VA = "0x1872F6480", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72F64F0", Offset = "0x72F58F0", VA = "0x1872F64F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ELPPMOEABCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72F1B20", Offset = "0x72F0F20", VA = "0x1872F1B20")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72F1DD0", Offset = "0x72F11D0", VA = "0x1872F1DD0")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72F1F30", Offset = "0x72F1330", VA = "0x1872F1F30")]
		internal void LCFOAMMGFNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72F1A70", Offset = "0x72F0E70", VA = "0x1872F1A70")]
		internal void CHHIEKADCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72F1C70", Offset = "0x72F1070", VA = "0x1872F1C70")]
		internal void IAIPADFKIPI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72F1E80", Offset = "0x72F1280", VA = "0x1872F1E80")]
		internal void KOIDJBGFILB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72F1D20", Offset = "0x72F1120", VA = "0x1872F1D20")]
		internal void JGIEFKGKFHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72F1FE0", Offset = "0x72F13E0", VA = "0x1872F1FE0")]
		internal void NLKOFMFFJBG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72F1BD0", Offset = "0x72F0FD0", VA = "0x1872F1BD0")]
		internal void GOJNEGKKBEG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72F2090", Offset = "0x72F1490", VA = "0x1872F2090")]
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
	[Cpp2IlInjected.Address(RVA = "0x72F3830", Offset = "0x72F2C30", VA = "0x1872F3830", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, AnchorParamsRestrictions MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72F3390", Offset = "0x72F2790", VA = "0x1872F3390", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, AnchorParamsRestrictions KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72F3D50", Offset = "0x72F3150", VA = "0x1872F3D50")]
	public HJMLBKNLPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33A8BB0", Offset = "0x33A7FB0", VA = "0x1833A8BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MOFADHKHNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72F4F80", Offset = "0x72F4380", VA = "0x1872F4F80")]
		internal void KIEJONJJMJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72F4C90", Offset = "0x72F4090", VA = "0x1872F4C90")]
		internal void CCNBFJEBMCG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72F4E30", Offset = "0x72F4230", VA = "0x1872F4E30")]
		internal void HAFLACJDHPE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72F4FC0", Offset = "0x72F43C0", VA = "0x1872F4FC0")]
		internal void KNLKMPJLJCE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72F4D40", Offset = "0x72F4140", VA = "0x1872F4D40")]
		internal void DEBKDDBGHJB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72F05D0", Offset = "0x72EF9D0", VA = "0x1872F05D0")]
		internal void CMAIEEPBPJL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72F4B30", Offset = "0x72F3F30", VA = "0x1872F4B30")]
		internal void AHNMLGDAANI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72F4BB0", Offset = "0x72F3FB0", VA = "0x1872F4BB0")]
		internal void CACJJBGABEG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72F4DF0", Offset = "0x72F41F0", VA = "0x1872F4DF0")]
		internal void GKGBIDMENEF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72F4EE0", Offset = "0x72F42E0", VA = "0x1872F4EE0")]
		internal void JMHAKCPDPLD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72F5070", Offset = "0x72F4470", VA = "0x1872F5070")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IOHAHDLEKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72F3EE0", Offset = "0x72F32E0", VA = "0x1872F3EE0")]
		internal void BEHCJDBBJDB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72F2320", Offset = "0x72F1720", VA = "0x1872F2320", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72F2F20", Offset = "0x72F2320", VA = "0x1872F2F20", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, SerializedAvatarItemData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72F21B0", Offset = "0x72F15B0", VA = "0x1872F21B0")]
	private AdditionalOutfitTypeData AJFMLEFMIPP(Utf8JsonReader AJLILPPHPPH, OutfitType BMIPLDLMPCD, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72F3350", Offset = "0x72F2750", VA = "0x1872F3350")]
	public HCDFDIAFGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JLDHOFLKJMH : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72F3F80", Offset = "0x72F3380", VA = "0x1872F3F80", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader AJLILPPHPPH, Type GPDDFIKPIMP, JsonSerializerOptions DCEHMKPFEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72F4310", Offset = "0x72F3710", VA = "0x1872F4310", Slot = "28")]
	public override void Write(Utf8JsonWriter BMEAHINCLAG, AvatarItemDownloadableConfig KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72F4440", Offset = "0x72F3840", VA = "0x1872F4440")]
	public JLDHOFLKJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MHKFBKHMKDG : MCKNLIHMKLH<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72F4580", Offset = "0x72F3980", VA = "0x1872F4580", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, BeardData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72F44C0", Offset = "0x72F38C0", VA = "0x1872F44C0", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, BeardData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72F4720", Offset = "0x72F3B20", VA = "0x1872F4720")]
	public MHKFBKHMKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GLLOJHGHPIA : CLJFMOCFBOB<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72F2170", Offset = "0x72F1570", VA = "0x1872F2170")]
	public GLLOJHGHPIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EOAFAJOBEJF : CLJFMOCFBOB<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72F2130", Offset = "0x72F1530", VA = "0x1872F2130")]
	public EOAFAJOBEJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KAIKPLIMHGP : CLJFMOCFBOB<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72F4480", Offset = "0x72F3880", VA = "0x1872F4480")]
	public KAIKPLIMHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IIIPDDBHDDA : MPEPLCFNKMJ<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72F3EA0", Offset = "0x72F32A0", VA = "0x1872F3EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MPIOOOJKPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72F04D0", Offset = "0x72EF8D0", VA = "0x1872F04D0")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72F51F0", Offset = "0x72F45F0", VA = "0x1872F51F0")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72F4830", Offset = "0x72F3C30", VA = "0x1872F4830", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, AdditionalFeetData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72F4760", Offset = "0x72F3B60", VA = "0x1872F4760", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, AdditionalFeetData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72F49C0", Offset = "0x72F3DC0", VA = "0x1872F49C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AIDAACFJPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x72F0380", Offset = "0x72EF780", VA = "0x1872F0380")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72F0500", Offset = "0x72EF900", VA = "0x1872F0500")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x72F05D0", Offset = "0x72EF9D0", VA = "0x1872F05D0")]
		internal void LCFOAMMGFNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x72F02E0", Offset = "0x72EF6E0", VA = "0x1872F02E0")]
		internal void CHHIEKADCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x72F0430", Offset = "0x72EF830", VA = "0x1872F0430")]
		internal void IAIPADFKIPI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x72F0530", Offset = "0x72EF930", VA = "0x1872F0530")]
		internal void KOIDJBGFILB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72F04D0", Offset = "0x72EF8D0", VA = "0x1872F04D0")]
		internal void JGIEFKGKFHB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72F59D0", Offset = "0x72F4DD0", VA = "0x1872F59D0", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, HairData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72F56F0", Offset = "0x72F4AF0", VA = "0x1872F56F0", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, HairData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72F5DC0", Offset = "0x72F51C0", VA = "0x1872F5DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NEKNKKGPIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72F52D0", Offset = "0x72F46D0", VA = "0x1872F52D0")]
		internal void FCMEFMFLABN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72F5450", Offset = "0x72F4850", VA = "0x1872F5450")]
		internal void JHIELMGKAAD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72F55A0", Offset = "0x72F49A0", VA = "0x1872F55A0")]
		internal void LCFOAMMGFNM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72F5220", Offset = "0x72F4620", VA = "0x1872F5220")]
		internal void CHHIEKADCOP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72F5300", Offset = "0x72F4700", VA = "0x1872F5300")]
		internal void IAIPADFKIPI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72F5500", Offset = "0x72F4900", VA = "0x1872F5500")]
		internal void KOIDJBGFILB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x72F53B0", Offset = "0x72F47B0", VA = "0x1872F53B0")]
		internal void JGIEFKGKFHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72F5650", Offset = "0x72F4A50", VA = "0x1872F5650")]
		internal void NLKOFMFFJBG(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72F14E0", Offset = "0x72F08E0", VA = "0x1872F14E0", Slot = "35")]
	public override void GCKLODIDDLF(Utf8JsonReader AJLILPPHPPH, JsonSerializerOptions DCEHMKPFEJH, string BPEJALFMHHI, AdditionalHatData MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72F1190", Offset = "0x72F0590", VA = "0x1872F1190", Slot = "36")]
	public override void AABBHPHEABM(Utf8JsonWriter BMEAHINCLAG, AdditionalHatData KBGCCIOIGBD, JsonSerializerOptions DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72F1940", Offset = "0x72F0D40", VA = "0x1872F1940")]
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
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x94D450", Offset = "0x94C850", VA = "0x18094D450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC81E50", Offset = "0xC81250", VA = "0x180C81E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC81F70", Offset = "0xC81370", VA = "0x180C81F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xC81E60", Offset = "0xC81260", VA = "0x180C81E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD5BC40", Offset = "0xD5B040", VA = "0x180D5BC40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD5BB70", Offset = "0xD5AF70", VA = "0x180D5BB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1CF3700", Offset = "0x1CF2B00", VA = "0x181CF3700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x72F62D0", Offset = "0x72F56D0", VA = "0x1872F62D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2901780", Offset = "0x2900B80", VA = "0x182901780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x29016B0", Offset = "0x2900AB0", VA = "0x1829016B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB3C410", Offset = "0xB3B810", VA = "0x180B3C410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB3C460", Offset = "0xB3B860", VA = "0x180B3C460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KBAIGJMAONF.FALICHFPADL ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA681C0", Offset = "0xA675C0", VA = "0x180A681C0")]
			[CompilerGenerated]
			get
			{
				return default(KBAIGJMAONF.FALICHFPADL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA681D0", Offset = "0xA675D0", VA = "0x180A681D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x94FB20", Offset = "0x94EF20", VA = "0x18094FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72F5E20", Offset = "0x72F5220", VA = "0x1872F5E20", Slot = "0")]
		public override bool Equals(object OKCHLIEAIJP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72F5E00", Offset = "0x72F5200", VA = "0x1872F5E00")]
		public static bool BFIJCNNIIMH(SerializedAvatarItemData HJGDMEAJFEI, SerializedAvatarItemData OHAJMMPIMHB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72F62A0", Offset = "0x72F56A0", VA = "0x1872F62A0")]
		public static bool HKDAGECLGLD(SerializedAvatarItemData HJGDMEAJFEI, SerializedAvatarItemData OHAJMMPIMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72F5EB0", Offset = "0x72F52B0", VA = "0x1872F5EB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72F61D0", Offset = "0x72F55D0", VA = "0x1872F61D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
