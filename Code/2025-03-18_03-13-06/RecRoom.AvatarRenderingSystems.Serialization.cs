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
public class FNCECHAIODH : EAGDLIHHJJL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9C0", Offset = "0xAAEBC0", VA = "0x180AAF9C0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7484D80", Offset = "0x7483F80", VA = "0x187484D80", Slot = "36")]
	protected override Vector3 FKGIIODNLPB(float[] ALKPNNHBNLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7484DD0", Offset = "0x7483FD0", VA = "0x187484DD0", Slot = "37")]
	protected override float[] GAFBHFGGNLH(Vector3 OMFJNFBDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7484E50", Offset = "0x7484050", VA = "0x187484E50")]
	public FNCECHAIODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IBFDICPFKDB : EAGDLIHHJJL<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC6460", Offset = "0xAC5660", VA = "0x180AC6460", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7485550", Offset = "0x7484750", VA = "0x187485550", Slot = "36")]
	protected override Vector2 FKGIIODNLPB(float[] ALKPNNHBNLO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7485590", Offset = "0x7484790", VA = "0x187485590", Slot = "37")]
	protected override float[] GAFBHFGGNLH(Vector2 OMFJNFBDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7485600", Offset = "0x7484800", VA = "0x187485600")]
	public IBFDICPFKDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KACDFLGDFBM : EAGDLIHHJJL<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC1520", Offset = "0xAC0720", VA = "0x180AC1520", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7485680", Offset = "0x7484880", VA = "0x187485680", Slot = "36")]
	protected override Quaternion FKGIIODNLPB(float[] ALKPNNHBNLO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74856E0", Offset = "0x74848E0", VA = "0x1874856E0", Slot = "37")]
	protected override float[] GAFBHFGGNLH(Quaternion OMFJNFBDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7485770", Offset = "0x7484970", VA = "0x187485770")]
	public KACDFLGDFBM()
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
		public enum OBHIMNLOGPH
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
		public OBHIMNLOGPH Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0")]
			[CompilerGenerated]
			get
			{
				return default(OBHIMNLOGPH);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7482330", Offset = "0x7481530", VA = "0x187482330", Slot = "0")]
		public override bool Equals(object LDKNLBHIGFL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7482530", Offset = "0x7481730", VA = "0x187482530")]
		public static bool GJNOMHNHJKL(AvatarItemDownloadableConfig MGBGOAGHGOJ, AvatarItemDownloadableConfig FCFMBBJABHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7482460", Offset = "0x7481660", VA = "0x187482460", Slot = "4")]
		public bool Equals(AvatarItemDownloadableConfig LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7482630", Offset = "0x7481830", VA = "0x187482630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDBB520", Offset = "0xDBA720", VA = "0x180DBB520")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedAvatarItemSelection : IEquatable<SerializedAvatarItemSelection>, IComparable<SerializedAvatarItemSelection>, AEJFKFOGKPI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7487100", Offset = "0x7486300", VA = "0x187487100")]
		private void AALEAKOOKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7487190", Offset = "0x7486390", VA = "0x187487190", Slot = "4")]
		public bool Equals(SerializedAvatarItemSelection LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7487210", Offset = "0x7486410", VA = "0x187487210", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedAvatarItemSelection LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7487100", Offset = "0x7486300", VA = "0x187487100", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7487310", Offset = "0x7486510", VA = "0x187487310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FDOIKHHFEMN : OGBPIIOBEFD<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GCFOCOOBNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GCFOCOOBNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x74852A0", Offset = "0x74844A0", VA = "0x1874852A0")]
		internal void IHLPHCGBNCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7484E90", Offset = "0x7484090", VA = "0x187484E90")]
		internal void BGIGECDMHBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7485140", Offset = "0x7484340", VA = "0x187485140")]
		internal void FOGIMLDDOPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7485090", Offset = "0x7484290", VA = "0x187485090")]
		internal void FCOPEHNHKPG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74851F0", Offset = "0x74843F0", VA = "0x1874851F0")]
		internal void GDPIIMONNAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7485350", Offset = "0x7484550", VA = "0x187485350")]
		internal void IIKBJNDILLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7484FE0", Offset = "0x74841E0", VA = "0x187484FE0")]
		internal void EOLFJEGIBNA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7485400", Offset = "0x7484600", VA = "0x187485400")]
		internal void LEOIBKJJDHI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7484F40", Offset = "0x7484140", VA = "0x187484F40")]
		internal void BOPPINKFJAL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74854B0", Offset = "0x74846B0", VA = "0x1874854B0")]
		internal void OGMGNOJDNCO(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CEOCCEPIBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7484820", Offset = "0x7483A20", VA = "0x187484820", Slot = "35")]
	public override void FNMEBBDMDJB(Utf8JsonReader KLIFEKFIIAG, JsonSerializerOptions ONCKKBCCJPH, string AMJCEKJIGLL, AnchorParamsRestrictions LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7484390", Offset = "0x7483590", VA = "0x187484390", Slot = "36")]
	public override void EBALPPJCBHM(Utf8JsonWriter DKHAABKGBIG, AnchorParamsRestrictions OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7484D40", Offset = "0x7483F40", VA = "0x187484D40")]
	public FDOIKHHFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x343B270", Offset = "0x343A470", VA = "0x18343B270")]
	[CompilerGenerated]
	internal static void EEJOCGKPBIB<T>(string AMJCEKJIGLL, T HBMPJOCKNNL, T PFKNNNAGPCF, CEOCCEPIBLG P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AAGKKKEGEKH : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private delegate void LJCHHMHEIDK(Utf8JsonReader LIBECIMLPKK);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CEBIELOIOFO
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
		public AAGKKKEGEKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LJCHHMHEIDK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LJCHHMHEIDK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LJCHHMHEIDK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LJCHHMHEIDK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LJCHHMHEIDK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LJCHHMHEIDK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LJCHHMHEIDK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LJCHHMHEIDK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LJCHHMHEIDK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public LJCHHMHEIDK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LJCHHMHEIDK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CEBIELOIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7483710", Offset = "0x7482910", VA = "0x187483710")]
		internal void BIJNFIGLPAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7483A40", Offset = "0x7482C40", VA = "0x187483A40")]
		internal void GLBIBNGOPPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7483990", Offset = "0x7482B90", VA = "0x187483990")]
		internal void GFIHGEFENOF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7483750", Offset = "0x7482950", VA = "0x187483750")]
		internal void BOFCEAHPGJH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7483800", Offset = "0x7482A00", VA = "0x187483800")]
		internal void BPGFHPLFGDF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74836E0", Offset = "0x74828E0", VA = "0x1874836E0")]
		internal void AKEALFMKAHD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7483AF0", Offset = "0x7482CF0", VA = "0x187483AF0")]
		internal void IABLOCHJHDP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7483CF0", Offset = "0x7482EF0", VA = "0x187483CF0")]
		internal void PDIHCEHGBLB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74838B0", Offset = "0x7482AB0", VA = "0x1874838B0")]
		internal void DDLFIMALMIJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74838F0", Offset = "0x7482AF0", VA = "0x1874838F0")]
		internal void FJCFAIGIKFA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7483B70", Offset = "0x7482D70", VA = "0x187483B70")]
		internal void IGNALKDPPGJ(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MICCFLHGADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string propertyName;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MICCFLHGADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7485AC0", Offset = "0x7484CC0", VA = "0x187485AC0")]
		internal void GJDPPDNHFGB(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7481290", Offset = "0x7480490", VA = "0x187481290", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7481E70", Offset = "0x7481070", VA = "0x187481E70", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, SerializedAvatarItemData OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7481120", Offset = "0x7480320", VA = "0x187481120")]
	private AdditionalOutfitTypeData ENAPAFFIAAH(Utf8JsonReader KLIFEKFIIAG, OutfitType NNILCBOLNDI, JsonSerializerOptions ONCKKBCCJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74822B0", Offset = "0x74814B0", VA = "0x1874822B0")]
	public AAGKKKEGEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NFLMCLIEOEF : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7485B60", Offset = "0x7484D60", VA = "0x187485B60", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader KLIFEKFIIAG, Type EANGNGDFNDB, JsonSerializerOptions ONCKKBCCJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7485EF0", Offset = "0x74850F0", VA = "0x187485EF0", Slot = "28")]
	public override void Write(Utf8JsonWriter DKHAABKGBIG, AvatarItemDownloadableConfig OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7486020", Offset = "0x7485220", VA = "0x187486020")]
	public NFLMCLIEOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EHPGEFHGLOF : OGBPIIOBEFD<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74841B0", Offset = "0x74833B0", VA = "0x1874841B0", Slot = "35")]
	public override void FNMEBBDMDJB(Utf8JsonReader KLIFEKFIIAG, JsonSerializerOptions ONCKKBCCJPH, string AMJCEKJIGLL, BeardData LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74840F0", Offset = "0x74832F0", VA = "0x1874840F0", Slot = "36")]
	public override void EBALPPJCBHM(Utf8JsonWriter DKHAABKGBIG, BeardData OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7484350", Offset = "0x7483550", VA = "0x187484350")]
	public EHPGEFHGLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BCBIKECKAGI : JGEAKEHOMLG<HelmetHairMode>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7482EC0", Offset = "0x74820C0", VA = "0x187482EC0")]
	public BCBIKECKAGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MDAJFMAOCLF : JGEAKEHOMLG<HelmetHairStyle>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7485A80", Offset = "0x7484C80", VA = "0x187485A80")]
	public MDAJFMAOCLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JNCPCBCBKIA : JGEAKEHOMLG<HairPatternStyle>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7485640", Offset = "0x7484840", VA = "0x187485640")]
	public JNCPCBCBKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AGFKCDJAOIG : JBKHBAPKHFE<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74822F0", Offset = "0x74814F0", VA = "0x1874822F0")]
	public AGFKCDJAOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KENOKIOKKNP : OGBPIIOBEFD<AdditionalFeetData>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KFGDBIFCPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AdditionalFeetData item;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KFGDBIFCPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7483E00", Offset = "0x7483000", VA = "0x187483E00")]
		internal void IHLPHCGBNCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7485A50", Offset = "0x7484C50", VA = "0x187485A50")]
		internal void BGIGECDMHBL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7485880", Offset = "0x7484A80", VA = "0x187485880", Slot = "35")]
	public override void FNMEBBDMDJB(Utf8JsonReader KLIFEKFIIAG, JsonSerializerOptions ONCKKBCCJPH, string AMJCEKJIGLL, AdditionalFeetData LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74857B0", Offset = "0x74849B0", VA = "0x1874857B0", Slot = "36")]
	public override void EBALPPJCBHM(Utf8JsonWriter DKHAABKGBIG, AdditionalFeetData OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7485A10", Offset = "0x7484C10", VA = "0x187485A10")]
	public KENOKIOKKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OHCBLJFDHCO : OGBPIIOBEFD<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DNPDFCOHIPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DNPDFCOHIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7483FA0", Offset = "0x74831A0", VA = "0x187483FA0")]
		internal void IHLPHCGBNCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7483DD0", Offset = "0x7482FD0", VA = "0x187483DD0")]
		internal void BGIGECDMHBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7483ED0", Offset = "0x74830D0", VA = "0x187483ED0")]
		internal void FOGIMLDDOPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7483E30", Offset = "0x7483030", VA = "0x187483E30")]
		internal void FCOPEHNHKPG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7483F00", Offset = "0x7483100", VA = "0x187483F00")]
		internal void GDPIIMONNAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7484050", Offset = "0x7483250", VA = "0x187484050")]
		internal void IIKBJNDILLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7483E00", Offset = "0x7483000", VA = "0x187483E00")]
		internal void EOLFJEGIBNA(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7486330", Offset = "0x7485530", VA = "0x187486330", Slot = "35")]
	public override void FNMEBBDMDJB(Utf8JsonReader KLIFEKFIIAG, JsonSerializerOptions ONCKKBCCJPH, string AMJCEKJIGLL, HairData LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7486060", Offset = "0x7485260", VA = "0x187486060", Slot = "36")]
	public override void EBALPPJCBHM(Utf8JsonWriter DKHAABKGBIG, HairData OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7486720", Offset = "0x7485920", VA = "0x187486720")]
	public OHCBLJFDHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BEIBNNAIAPC : OGBPIIOBEFD<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PODPDLHKFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PODPDLHKFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7486AC0", Offset = "0x7485CC0", VA = "0x187486AC0")]
		internal void IHLPHCGBNCF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7486760", Offset = "0x7485960", VA = "0x187486760")]
		internal void BGIGECDMHBL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7486960", Offset = "0x7485B60", VA = "0x187486960")]
		internal void FOGIMLDDOPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74868B0", Offset = "0x7485AB0", VA = "0x1874868B0")]
		internal void FCOPEHNHKPG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7486A10", Offset = "0x7485C10", VA = "0x187486A10")]
		internal void GDPIIMONNAJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7486AF0", Offset = "0x7485CF0", VA = "0x187486AF0")]
		internal void IIKBJNDILLO(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7486810", Offset = "0x7485A10", VA = "0x187486810")]
		internal void EOLFJEGIBNA(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7486B90", Offset = "0x7485D90", VA = "0x187486B90")]
		internal void LEOIBKJJDHI(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7483240", Offset = "0x7482440", VA = "0x187483240", Slot = "35")]
	public override void FNMEBBDMDJB(Utf8JsonReader KLIFEKFIIAG, JsonSerializerOptions ONCKKBCCJPH, string AMJCEKJIGLL, AdditionalHatData LOKFKJLCEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7482F00", Offset = "0x7482100", VA = "0x187482F00", Slot = "36")]
	public override void EBALPPJCBHM(Utf8JsonWriter DKHAABKGBIG, AdditionalHatData OMFJNFBDJCA, JsonSerializerOptions ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74836A0", Offset = "0x74828A0", VA = "0x1874836A0")]
	public BEIBNNAIAPC()
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
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x96C060", Offset = "0x96B260", VA = "0x18096C060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCE50A0", Offset = "0xCE42A0", VA = "0x180CE50A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCE51B0", Offset = "0xCE43B0", VA = "0x180CE51B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCE5060", Offset = "0xCE4260", VA = "0x180CE5060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xDEE640", Offset = "0xDED840", VA = "0x180DEE640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xDEE1E0", Offset = "0xDED3E0", VA = "0x180DEE1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1D75760", Offset = "0x1D74960", VA = "0x181D75760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x74870F0", Offset = "0x74862F0", VA = "0x1874870F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2957470", Offset = "0x2956670", VA = "0x182957470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x29576A0", Offset = "0x29568A0", VA = "0x1829576A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBB6110", Offset = "0xBB5310", VA = "0x180BB6110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xBB6160", Offset = "0xBB5360", VA = "0x180BB6160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LHOPHOECLDF.PDNJAPAFAJM ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
			[CompilerGenerated]
			get
			{
				return default(LHOPHOECLDF.PDNJAPAFAJM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x68FFF60", Offset = "0x68FF160", VA = "0x1868FFF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x961610", Offset = "0x960810", VA = "0x180961610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7486C30", Offset = "0x7485E30", VA = "0x187486C30", Slot = "0")]
		public override bool Equals(object LDKNLBHIGFL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7487000", Offset = "0x7486200", VA = "0x187487000")]
		public static bool GJNOMHNHJKL(SerializedAvatarItemData MGBGOAGHGOJ, SerializedAvatarItemData FCFMBBJABHD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7486FD0", Offset = "0x74861D0", VA = "0x187486FD0")]
		public static bool GHFFJAPPGNB(SerializedAvatarItemData MGBGOAGHGOJ, SerializedAvatarItemData FCFMBBJABHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7486CB0", Offset = "0x7485EB0", VA = "0x187486CB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemData LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7487020", Offset = "0x7486220", VA = "0x187487020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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
