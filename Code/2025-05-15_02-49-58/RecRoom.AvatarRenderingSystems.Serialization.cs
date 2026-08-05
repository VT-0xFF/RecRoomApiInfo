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
public class MFIKLJCINBG : GCEODINLLMC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xBC1A20", Offset = "0xBC0020", VA = "0x180BC1A20", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7AB13A0", Offset = "0x7AAF9A0", VA = "0x187AB13A0", Slot = "36")]
	protected override Vector3 NBGNNKLAJOA(float[] DHLGAIMCINE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1320", Offset = "0x7AAF920", VA = "0x187AB1320", Slot = "37")]
	protected override float[] HGAAFLBNLDD(Vector3 OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7AB13F0", Offset = "0x7AAF9F0", VA = "0x187AB13F0")]
	public MFIKLJCINBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IDLJECIGJHO : GCEODINLLMC<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBD6DF0", Offset = "0xBD53F0", VA = "0x180BD6DF0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF170", Offset = "0x7AAD770", VA = "0x187AAF170", Slot = "36")]
	protected override Vector2 NBGNNKLAJOA(float[] DHLGAIMCINE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF100", Offset = "0x7AAD700", VA = "0x187AAF100", Slot = "37")]
	protected override float[] HGAAFLBNLDD(Vector2 OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF1B0", Offset = "0x7AAD7B0", VA = "0x187AAF1B0")]
	public IDLJECIGJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LIIAOGIHPPL : GCEODINLLMC<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBD62C0", Offset = "0xBD48C0", VA = "0x180BD62C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB00B0", Offset = "0x7AAE6B0", VA = "0x187AB00B0", Slot = "36")]
	protected override Quaternion NBGNNKLAJOA(float[] DHLGAIMCINE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0020", Offset = "0x7AAE620", VA = "0x187AB0020", Slot = "37")]
	protected override float[] HGAAFLBNLDD(Quaternion OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0110", Offset = "0x7AAE710", VA = "0x187AB0110")]
	public LIIAOGIHPPL()
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
		public enum FBEAGKIKGHJ
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
		public FBEAGKIKGHJ Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
			[CompilerGenerated]
			get
			{
				return default(FBEAGKIKGHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC7F0", Offset = "0x7AAADF0", VA = "0x187AAC7F0", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AACA60", Offset = "0x7AAB060", VA = "0x187AACA60")]
		public static bool MMJMCICIDNJ(AvatarItemDownloadableConfig JOOBCOFNIAM, AvatarItemDownloadableConfig MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC920", Offset = "0x7AAAF20", VA = "0x187AAC920", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC9F0", Offset = "0x7AAAFF0", VA = "0x187AAC9F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF209A0", Offset = "0xF1EFA0", VA = "0x180F209A0")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, AKFPMLPANDI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7AB2290", Offset = "0x7AB0890", VA = "0x187AB2290")]
		private void JDHKIODJHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2110", Offset = "0x7AB0710", VA = "0x187AB2110", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2190", Offset = "0x7AB0790", VA = "0x187AB2190", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2290", Offset = "0x7AB0890", VA = "0x187AB2290", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2300", Offset = "0x7AB0900", VA = "0x187AB2300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HGOAGGAFHJN : JHCFECAIPCG<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JKPFBCFAEDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JKPFBCFAEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFE90", Offset = "0x7AAE490", VA = "0x187AAFE90")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFD40", Offset = "0x7AAE340", VA = "0x187AAFD40")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFF40", Offset = "0x7AAE540", VA = "0x187AAFF40")]
		internal void PJPNACDGCDJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFB40", Offset = "0x7AAE140", VA = "0x187AAFB40")]
		internal void IKOLDLGFEJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF9E0", Offset = "0x7AADFE0", VA = "0x187AAF9E0")]
		internal void CCKANCKJBNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF930", Offset = "0x7AADF30", VA = "0x187AAF930")]
		internal void AOEGIMLJELL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFA90", Offset = "0x7AAE090", VA = "0x187AAFA90")]
		internal void EPNPHCKHDHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFC90", Offset = "0x7AAE290", VA = "0x187AAFC90")]
		internal void NAIBMGENPEC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFDF0", Offset = "0x7AAE3F0", VA = "0x187AAFDF0")]
		internal void NPIDNCCPHEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFBF0", Offset = "0x7AAE1F0", VA = "0x187AAFBF0")]
		internal void LIKPCIPPDMM(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LFFHMFOFEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE3F0", Offset = "0x7AAC9F0", VA = "0x187AAE3F0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, AnchorParamsRestrictions HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE910", Offset = "0x7AACF10", VA = "0x187AAE910", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, AnchorParamsRestrictions OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7AAEDA0", Offset = "0x7AAD3A0", VA = "0x187AAEDA0")]
	public HGOAGGAFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38866F0", Offset = "0x3884CF0", VA = "0x1838866F0")]
	[CompilerGenerated]
	internal static void BCKIEOAJJOC<T>(string DEMJFJNLMJF, T GCDAJLDGOIF, T OALLDCKDILO, LFFHMFOFEHC P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LNBHLMIGINA : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void JHGHJNBGNFI(Utf8JsonReader NFFBJCCKPJF);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AKPKGGEJGCB
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
		public LNBHLMIGINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public JHGHJNBGNFI <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JHGHJNBGNFI <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JHGHJNBGNFI <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public JHGHJNBGNFI <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JHGHJNBGNFI <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JHGHJNBGNFI <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JHGHJNBGNFI <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JHGHJNBGNFI <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JHGHJNBGNFI <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JHGHJNBGNFI <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JHGHJNBGNFI <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AKPKGGEJGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC100", Offset = "0x7AAA700", VA = "0x187AAC100")]
		internal void BBNLMAAOEBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC510", Offset = "0x7AAAB10", VA = "0x187AAC510")]
		internal void JAKFOGBJDBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC710", Offset = "0x7AAAD10", VA = "0x187AAC710")]
		internal void KBEHEFANOIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC5C0", Offset = "0x7AAABC0", VA = "0x187AAC5C0")]
		internal void JBHPFAONLBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC140", Offset = "0x7AAA740", VA = "0x187AAC140")]
		internal void BIIPNOIIPHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC7C0", Offset = "0x7AAADC0", VA = "0x187AAC7C0")]
		internal void ONMIHIGAPBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC1F0", Offset = "0x7AAA7F0", VA = "0x187AAC1F0")]
		internal void CBDAKCDCHIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC270", Offset = "0x7AAA870", VA = "0x187AAC270")]
		internal void DFPLPFNPELD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC350", Offset = "0x7AAA950", VA = "0x187AAC350")]
		internal void FJKJGCDCILG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC670", Offset = "0x7AAAC70", VA = "0x187AAC670")]
		internal void JKAGOMLODNE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC390", Offset = "0x7AAA990", VA = "0x187AAC390")]
		internal void GOJBALOMHDE(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ECHAHJAKKNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ECHAHJAKKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AADE50", Offset = "0x7AAC450", VA = "0x187AADE50")]
		internal void BBANHIGGHKJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB02C0", Offset = "0x7AAE8C0", VA = "0x187AB02C0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0EA0", Offset = "0x7AAF4A0", VA = "0x187AB0EA0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, SerializedAvatarItemData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0150", Offset = "0x7AAE750", VA = "0x187AB0150")]
	private AdditionalOutfitTypeData EKANPIBKGGN(Utf8JsonReader HBMFONPEIJC, OutfitType MLCOGCMJLBB, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7AB12E0", Offset = "0x7AAF8E0", VA = "0x187AB12E0")]
	public LNBHLMIGINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GIAICPKPGJP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AADEF0", Offset = "0x7AAC4F0", VA = "0x187AADEF0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE280", Offset = "0x7AAC880", VA = "0x187AAE280", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, AvatarItemDownloadableConfig OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE3B0", Offset = "0x7AAC9B0", VA = "0x187AAE3B0")]
	public GIAICPKPGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BCMLCFOFGAG : JHCFECAIPCG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD3C0", Offset = "0x7AAB9C0", VA = "0x187AAD3C0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, BeardData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD560", Offset = "0x7AABB60", VA = "0x187AAD560", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, BeardData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD620", Offset = "0x7AABC20", VA = "0x187AAD620")]
	public BCMLCFOFGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BFADDMNFKGM : HGCPLADBHNC<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD660", Offset = "0x7AABC60", VA = "0x187AAD660")]
	public BFADDMNFKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BBGNJPMIDJK : HGCPLADBHNC<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD380", Offset = "0x7AAB980", VA = "0x187AAD380")]
	public BBGNJPMIDJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BJGIGCDEANP : HGCPLADBHNC<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD6A0", Offset = "0x7AABCA0", VA = "0x187AAD6A0")]
	public BJGIGCDEANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JCFOGCNIGDG : HBIAAJEKFLM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF8F0", Offset = "0x7AADEF0", VA = "0x187AAF8F0")]
	public JCFOGCNIGDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CACJGGENAEO : JHCFECAIPCG<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KCFJFAPPFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KCFJFAPPFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEF20", Offset = "0x7AAD520", VA = "0x187AAEF20")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFFF0", Offset = "0x7AAE5F0", VA = "0x187AAFFF0")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD6E0", Offset = "0x7AABCE0", VA = "0x187AAD6E0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, AdditionalFeetData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD870", Offset = "0x7AABE70", VA = "0x187AAD870", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, AdditionalFeetData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD940", Offset = "0x7AABF40", VA = "0x187AAD940")]
	public CACJGGENAEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IJAOFJCFAAO : JHCFECAIPCG<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HPKCJIPOKIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HPKCJIPOKIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF020", Offset = "0x7AAD620", VA = "0x187AAF020")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEFF0", Offset = "0x7AAD5F0", VA = "0x187AAEFF0")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF0D0", Offset = "0x7AAD6D0", VA = "0x187AAF0D0")]
		internal void PJPNACDGCDJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEF50", Offset = "0x7AAD550", VA = "0x187AAEF50")]
		internal void IKOLDLGFEJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEE80", Offset = "0x7AAD480", VA = "0x187AAEE80")]
		internal void CCKANCKJBNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEDE0", Offset = "0x7AAD3E0", VA = "0x187AAEDE0")]
		internal void AOEGIMLJELL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEF20", Offset = "0x7AAD520", VA = "0x187AAEF20")]
		internal void EPNPHCKHDHL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF1F0", Offset = "0x7AAD7F0", VA = "0x187AAF1F0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, HairData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF5E0", Offset = "0x7AADBE0", VA = "0x187AAF5E0", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, HairData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF8B0", Offset = "0x7AADEB0", VA = "0x187AAF8B0")]
	public IJAOFJCFAAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NMLEOGAEEFG : JHCFECAIPCG<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DKNNFKBFLNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DKNNFKBFLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7AADD70", Offset = "0x7AAC370", VA = "0x187AADD70")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AADCC0", Offset = "0x7AAC2C0", VA = "0x187AADCC0")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AADDA0", Offset = "0x7AAC3A0", VA = "0x187AADDA0")]
		internal void PJPNACDGCDJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AADB70", Offset = "0x7AAC170", VA = "0x187AADB70")]
		internal void IKOLDLGFEJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AADA20", Offset = "0x7AAC020", VA = "0x187AADA20")]
		internal void CCKANCKJBNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD980", Offset = "0x7AABF80", VA = "0x187AAD980")]
		internal void AOEGIMLJELL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7AADAD0", Offset = "0x7AAC0D0", VA = "0x187AADAD0")]
		internal void EPNPHCKHDHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AADC20", Offset = "0x7AAC220", VA = "0x187AADC20")]
		internal void NAIBMGENPEC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1430", Offset = "0x7AAFA30", VA = "0x187AB1430", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, AdditionalHatData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1890", Offset = "0x7AAFE90", VA = "0x187AB1890", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, AdditionalHatData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1BD0", Offset = "0x7AB01D0", VA = "0x187AB1BD0")]
	public NMLEOGAEEFG()
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
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFA0", Offset = "0xDBA5A0", VA = "0x180DBBFA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFD0", Offset = "0xDBA5D0", VA = "0x180DBBFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF3C0C0", Offset = "0xF3A6C0", VA = "0x180F3C0C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF3BD60", Offset = "0xF3A360", VA = "0x180F3BD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1F47120", Offset = "0x1F45720", VA = "0x181F47120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB20E0", Offset = "0x7AB06E0", VA = "0x187AB20E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B454B0", Offset = "0x2B43AB0", VA = "0x182B454B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B454A0", Offset = "0x2B43AA0", VA = "0x182B454A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B40", Offset = "0xCB0140", VA = "0x180CB1B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0190", VA = "0x180CB1B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DJMKKMKOHOE.KHMINOCKMDE ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			[CompilerGenerated]
			get
			{
				return default(DJMKKMKOHOE.KHMINOCKMDE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1C40", Offset = "0x7AB0240", VA = "0x187AB1C40", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20C0", Offset = "0x7AB06C0", VA = "0x187AB20C0")]
		public static bool MMJMCICIDNJ(SerializedAvatarItemData JOOBCOFNIAM, SerializedAvatarItemData MCIIEEEAOOL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1C10", Offset = "0x7AB0210", VA = "0x187AB1C10")]
		public static bool DIKHMNDIIDO(SerializedAvatarItemData JOOBCOFNIAM, SerializedAvatarItemData MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1CD0", Offset = "0x7AB02D0", VA = "0x187AB1CD0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1FF0", Offset = "0x7AB05F0", VA = "0x187AB1FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
