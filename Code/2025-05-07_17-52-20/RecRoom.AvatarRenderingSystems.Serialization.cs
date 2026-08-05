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
		[Cpp2IlInjected.Address(RVA = "0xB83650", Offset = "0xB82650", VA = "0x180B83650", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1CD0", Offset = "0x7AE0CD0", VA = "0x187AE1CD0", Slot = "36")]
	protected override Vector3 NBGNNKLAJOA(float[] DHLGAIMCINE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1C50", Offset = "0x7AE0C50", VA = "0x187AE1C50", Slot = "37")]
	protected override float[] HGAAFLBNLDD(Vector3 OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1D20", Offset = "0x7AE0D20", VA = "0x187AE1D20")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCB9B0", Offset = "0xBCA9B0", VA = "0x180BCB9B0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFA70", Offset = "0x7ADEA70", VA = "0x187ADFA70", Slot = "36")]
	protected override Vector2 NBGNNKLAJOA(float[] DHLGAIMCINE)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFA00", Offset = "0x7ADEA00", VA = "0x187ADFA00", Slot = "37")]
	protected override float[] HGAAFLBNLDD(Vector2 OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFAB0", Offset = "0x7ADEAB0", VA = "0x187ADFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCAD30", Offset = "0xBC9D30", VA = "0x180BCAD30", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE09C0", Offset = "0x7ADF9C0", VA = "0x187AE09C0", Slot = "36")]
	protected override Quaternion NBGNNKLAJOA(float[] DHLGAIMCINE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0930", Offset = "0x7ADF930", VA = "0x187AE0930", Slot = "37")]
	protected override float[] HGAAFLBNLDD(Quaternion OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0A20", Offset = "0x7ADFA20", VA = "0x187AE0A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(FBEAGKIKGHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD0E0", Offset = "0x7ADC0E0", VA = "0x187ADD0E0", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD350", Offset = "0x7ADC350", VA = "0x187ADD350")]
		public static bool MMJMCICIDNJ(AvatarItemDownloadableConfig JOOBCOFNIAM, AvatarItemDownloadableConfig MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD210", Offset = "0x7ADC210", VA = "0x187ADD210", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD2E0", Offset = "0x7ADC2E0", VA = "0x187ADD2E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF0F080", Offset = "0xF0E080", VA = "0x180F0F080")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE2BB0", Offset = "0x7AE1BB0", VA = "0x187AE2BB0")]
		private void JDHKIODJHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A30", Offset = "0x7AE1A30", VA = "0x187AE2A30", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2AB0", Offset = "0x7AE1AB0", VA = "0x187AE2AB0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BB0", Offset = "0x7AE1BB0", VA = "0x187AE2BB0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2C20", Offset = "0x7AE1C20", VA = "0x187AE2C20", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JKPFBCFAEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AE07A0", Offset = "0x7ADF7A0", VA = "0x187AE07A0")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0650", Offset = "0x7ADF650", VA = "0x187AE0650")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0850", Offset = "0x7ADF850", VA = "0x187AE0850")]
		internal void PJPNACDGCDJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0450", Offset = "0x7ADF450", VA = "0x187AE0450")]
		internal void IKOLDLGFEJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AE02F0", Offset = "0x7ADF2F0", VA = "0x187AE02F0")]
		internal void CCKANCKJBNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0240", Offset = "0x7ADF240", VA = "0x187AE0240")]
		internal void AOEGIMLJELL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE03A0", Offset = "0x7ADF3A0", VA = "0x187AE03A0")]
		internal void EPNPHCKHDHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE05A0", Offset = "0x7ADF5A0", VA = "0x187AE05A0")]
		internal void NAIBMGENPEC(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0700", Offset = "0x7ADF700", VA = "0x187AE0700")]
		internal void NPIDNCCPHEM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0500", Offset = "0x7ADF500", VA = "0x187AE0500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7ADECE0", Offset = "0x7ADDCE0", VA = "0x187ADECE0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, AnchorParamsRestrictions HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7ADF200", Offset = "0x7ADE200", VA = "0x187ADF200", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, AnchorParamsRestrictions OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7ADF6A0", Offset = "0x7ADE6A0", VA = "0x187ADF6A0")]
	public HGOAGGAFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38684C0", Offset = "0x38674C0", VA = "0x1838684C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AKPKGGEJGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC9F0", Offset = "0x7ADB9F0", VA = "0x187ADC9F0")]
		internal void BBNLMAAOEBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCE00", Offset = "0x7ADBE00", VA = "0x187ADCE00")]
		internal void JAKFOGBJDBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD000", Offset = "0x7ADC000", VA = "0x187ADD000")]
		internal void KBEHEFANOIM(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCEB0", Offset = "0x7ADBEB0", VA = "0x187ADCEB0")]
		internal void JBHPFAONLBI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCA30", Offset = "0x7ADBA30", VA = "0x187ADCA30")]
		internal void BIIPNOIIPHB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD0B0", Offset = "0x7ADC0B0", VA = "0x187ADD0B0")]
		internal void ONMIHIGAPBP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCAE0", Offset = "0x7ADBAE0", VA = "0x187ADCAE0")]
		internal void CBDAKCDCHIN(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCB60", Offset = "0x7ADBB60", VA = "0x187ADCB60")]
		internal void DFPLPFNPELD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCC40", Offset = "0x7ADBC40", VA = "0x187ADCC40")]
		internal void FJKJGCDCILG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCF60", Offset = "0x7ADBF60", VA = "0x187ADCF60")]
		internal void JKAGOMLODNE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCC80", Offset = "0x7ADBC80", VA = "0x187ADCC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ECHAHJAKKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE740", Offset = "0x7ADD740", VA = "0x187ADE740")]
		internal void BBANHIGGHKJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0BD0", Offset = "0x7ADFBD0", VA = "0x187AE0BD0", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7AE17D0", Offset = "0x7AE07D0", VA = "0x187AE17D0", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, SerializedAvatarItemData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0A60", Offset = "0x7ADFA60", VA = "0x187AE0A60")]
	private AdditionalOutfitTypeData EKANPIBKGGN(Utf8JsonReader HBMFONPEIJC, OutfitType MLCOGCMJLBB, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1C10", Offset = "0x7AE0C10", VA = "0x187AE1C10")]
	public LNBHLMIGINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GIAICPKPGJP : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7ADE7E0", Offset = "0x7ADD7E0", VA = "0x187ADE7E0", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader HBMFONPEIJC, Type EIOEBCMGCLO, JsonSerializerOptions BFEGEHMOFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7ADEB70", Offset = "0x7ADDB70", VA = "0x187ADEB70", Slot = "28")]
	public override void Write(Utf8JsonWriter NFOCFJIIPHM, AvatarItemDownloadableConfig OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7ADECA0", Offset = "0x7ADDCA0", VA = "0x187ADECA0")]
	public GIAICPKPGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BCMLCFOFGAG : JHCFECAIPCG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDCB0", Offset = "0x7ADCCB0", VA = "0x187ADDCB0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, BeardData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDE50", Offset = "0x7ADCE50", VA = "0x187ADDE50", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, BeardData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDF10", Offset = "0x7ADCF10", VA = "0x187ADDF10")]
	public BCMLCFOFGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BFADDMNFKGM : HGCPLADBHNC<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDF50", Offset = "0x7ADCF50", VA = "0x187ADDF50")]
	public BFADDMNFKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BBGNJPMIDJK : HGCPLADBHNC<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDC70", Offset = "0x7ADCC70", VA = "0x187ADDC70")]
	public BBGNJPMIDJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BJGIGCDEANP : HGCPLADBHNC<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDF90", Offset = "0x7ADCF90", VA = "0x187ADDF90")]
	public BJGIGCDEANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JCFOGCNIGDG : HBIAAJEKFLM<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0200", Offset = "0x7ADF200", VA = "0x187AE0200")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KCFJFAPPFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF820", Offset = "0x7ADE820", VA = "0x187ADF820")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0900", Offset = "0x7ADF900", VA = "0x187AE0900")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7ADDFD0", Offset = "0x7ADCFD0", VA = "0x187ADDFD0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, AdditionalFeetData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7ADE160", Offset = "0x7ADD160", VA = "0x187ADE160", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, AdditionalFeetData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7ADE230", Offset = "0x7ADD230", VA = "0x187ADE230")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public HPKCJIPOKIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF920", Offset = "0x7ADE920", VA = "0x187ADF920")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF8F0", Offset = "0x7ADE8F0", VA = "0x187ADF8F0")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF9D0", Offset = "0x7ADE9D0", VA = "0x187ADF9D0")]
		internal void PJPNACDGCDJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF850", Offset = "0x7ADE850", VA = "0x187ADF850")]
		internal void IKOLDLGFEJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF780", Offset = "0x7ADE780", VA = "0x187ADF780")]
		internal void CCKANCKJBNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF6E0", Offset = "0x7ADE6E0", VA = "0x187ADF6E0")]
		internal void AOEGIMLJELL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF820", Offset = "0x7ADE820", VA = "0x187ADF820")]
		internal void EPNPHCKHDHL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFAF0", Offset = "0x7ADEAF0", VA = "0x187ADFAF0", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, HairData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFEE0", Offset = "0x7ADEEE0", VA = "0x187ADFEE0", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, HairData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE01C0", Offset = "0x7ADF1C0", VA = "0x187AE01C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DKNNFKBFLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE660", Offset = "0x7ADD660", VA = "0x187ADE660")]
		internal void OMEJEEAJIGA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE5B0", Offset = "0x7ADD5B0", VA = "0x187ADE5B0")]
		internal void NCJBKHJCFLP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE690", Offset = "0x7ADD690", VA = "0x187ADE690")]
		internal void PJPNACDGCDJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE460", Offset = "0x7ADD460", VA = "0x187ADE460")]
		internal void IKOLDLGFEJJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE310", Offset = "0x7ADD310", VA = "0x187ADE310")]
		internal void CCKANCKJBNF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE270", Offset = "0x7ADD270", VA = "0x187ADE270")]
		internal void AOEGIMLJELL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE3C0", Offset = "0x7ADD3C0", VA = "0x187ADE3C0")]
		internal void EPNPHCKHDHL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE510", Offset = "0x7ADD510", VA = "0x187ADE510")]
		internal void NAIBMGENPEC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1D60", Offset = "0x7AE0D60", VA = "0x187AE1D60", Slot = "35")]
	public override void CCFNMKLDOFC(Utf8JsonReader HBMFONPEIJC, JsonSerializerOptions BFEGEHMOFBB, string DEMJFJNLMJF, AdditionalHatData HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7AE21C0", Offset = "0x7AE11C0", VA = "0x187AE21C0", Slot = "36")]
	public override void DDALCCDEBAL(Utf8JsonWriter NFOCFJIIPHM, AdditionalHatData OHLIHBDBKCE, JsonSerializerOptions BFEGEHMOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AE2510", Offset = "0x7AE1510", VA = "0x187AE2510")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA92FB0", Offset = "0xA91FB0", VA = "0x180A92FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xDA9870", Offset = "0xDA8870", VA = "0x180DA9870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xDA98A0", Offset = "0xDA88A0", VA = "0x180DA98A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF2AA40", Offset = "0xF29A40", VA = "0x180F2AA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF2A6C0", Offset = "0xF296C0", VA = "0x180F2A6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xF474B0", Offset = "0xF464B0", VA = "0x180F474B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xF47670", Offset = "0xF46670", VA = "0x180F47670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B43F40", Offset = "0x2B42F40", VA = "0x182B43F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2B43F30", Offset = "0x2B42F30", VA = "0x182B43F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC8C940", Offset = "0xC8B940", VA = "0x180C8C940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xC8C990", Offset = "0xC8B990", VA = "0x180C8C990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DJMKKMKOHOE.KHMINOCKMDE ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
			[CompilerGenerated]
			get
			{
				return default(DJMKKMKOHOE.KHMINOCKMDE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2580", Offset = "0x7AE1580", VA = "0x187AE2580", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7AE29F0", Offset = "0x7AE19F0", VA = "0x187AE29F0")]
		public static bool MMJMCICIDNJ(SerializedAvatarItemData JOOBCOFNIAM, SerializedAvatarItemData MCIIEEEAOOL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2550", Offset = "0x7AE1550", VA = "0x187AE2550")]
		public static bool DIKHMNDIIDO(SerializedAvatarItemData JOOBCOFNIAM, SerializedAvatarItemData MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2600", Offset = "0x7AE1600", VA = "0x187AE2600", Slot = "4")]
		public bool Equals(SerializedAvatarItemData MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2920", Offset = "0x7AE1920", VA = "0x187AE2920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
