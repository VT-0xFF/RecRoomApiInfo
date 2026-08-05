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
public class MENFIHAOHHF : NMFHLILIFGK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9AA090", Offset = "0x9A9090", VA = "0x1809AA090", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6827E60", Offset = "0x6826E60", VA = "0x186827E60", Slot = "36")]
	protected override Vector3 APMFLAKFFKN(float[] ADLAOOMHAPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6827EB0", Offset = "0x6826EB0", VA = "0x186827EB0", Slot = "37")]
	protected override float[] DGKGANFODBM(Vector3 JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6827F30", Offset = "0x6826F30", VA = "0x186827F30")]
	public MENFIHAOHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DCPIONOIGGL : NMFHLILIFGK<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected override int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A6590", Offset = "0x9A5590", VA = "0x1809A6590", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6825C60", Offset = "0x6824C60", VA = "0x186825C60", Slot = "36")]
	protected override Vector2 APMFLAKFFKN(float[] ADLAOOMHAPB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6825CA0", Offset = "0x6824CA0", VA = "0x186825CA0", Slot = "37")]
	protected override float[] DGKGANFODBM(Vector2 JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6825D10", Offset = "0x6824D10", VA = "0x186825D10")]
	public DCPIONOIGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DNBIDIOECGA : NMFHLILIFGK<Quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected override int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AF190", Offset = "0x9AE190", VA = "0x1809AF190", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6825D50", Offset = "0x6824D50", VA = "0x186825D50", Slot = "36")]
	protected override Quaternion APMFLAKFFKN(float[] ADLAOOMHAPB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6825DB0", Offset = "0x6824DB0", VA = "0x186825DB0", Slot = "37")]
	protected override float[] DGKGANFODBM(Quaternion JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6825E40", Offset = "0x6824E40", VA = "0x186825E40")]
	public DNBIDIOECGA()
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
		public enum PNCAFCBCGCM
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
		public PNCAFCBCGCM Version
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
			[CompilerGenerated]
			get
			{
				return default(PNCAFCBCGCM);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SerializedAvatarItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F2A50", Offset = "0x9F1A50", VA = "0x1809F2A50")]
		public AvatarItemDownloadableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DBAOGPEJGIJ : BCCMKHDNANG<AnchorParamsRestrictions>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FLOMOEECLNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnchorParamsRestrictions item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FLOMOEECLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6826450", Offset = "0x6825450", VA = "0x186826450")]
		internal void ECMHPLGJKNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68262F0", Offset = "0x68252F0", VA = "0x1868262F0")]
		internal void CGHBHMNACEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68265A0", Offset = "0x68255A0", VA = "0x1868265A0")]
		internal void HONOLDDMLCG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68261A0", Offset = "0x68251A0", VA = "0x1868261A0")]
		internal void AHPBAOFCCHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68263A0", Offset = "0x68253A0", VA = "0x1868263A0")]
		internal void DMCIGFCGENP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68267B0", Offset = "0x68257B0", VA = "0x1868267B0")]
		internal void OCBPMGPICGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6826650", Offset = "0x6825650", VA = "0x186826650")]
		internal void JNHOAENHBPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6826700", Offset = "0x6825700", VA = "0x186826700")]
		internal void LKMDBEELFPD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6826250", Offset = "0x6825250", VA = "0x186826250")]
		internal void ANMKLLPIHIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6826500", Offset = "0x6825500", VA = "0x186826500")]
		internal void HOCCHOLJFDB(Utf8JsonReader r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IAILGFFCLGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Utf8JsonWriter writer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JsonSerializerOptions options;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6825700", Offset = "0x6824700", VA = "0x186825700", Slot = "35")]
	public override void LBNJAACLDOK(Utf8JsonReader JBMHGCNDNMN, JsonSerializerOptions OLBNLJKBNFE, string BGJCPPOHOEL, AnchorParamsRestrictions LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6825260", Offset = "0x6824260", VA = "0x186825260", Slot = "36")]
	public override void IJJMPHCONDO(Utf8JsonWriter KOHNEKCBPBH, AnchorParamsRestrictions JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6825C20", Offset = "0x6824C20", VA = "0x186825C20")]
	public DBAOGPEJGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29FC4E0", Offset = "0x29FB4E0", VA = "0x1829FC4E0")]
	[CompilerGenerated]
	internal static void EKJHAGKCKKK<T>(string BGJCPPOHOEL, T AAINAOCHJJJ, T EFLODNAHHNN, IAILGFFCLGI P_3) where T : IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MFHOLPNIHED : JsonConverter<SerializedAvatarItemData>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private delegate void ANEMLFDPNPK(Utf8JsonReader IELHIIDGIMN);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GOCKLDACHFD
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
		public MFHOLPNIHED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public ANEMLFDPNPK <>9__0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ANEMLFDPNPK <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public ANEMLFDPNPK <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public ANEMLFDPNPK <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ANEMLFDPNPK <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ANEMLFDPNPK <>9__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ANEMLFDPNPK <>9__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ANEMLFDPNPK <>9__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ANEMLFDPNPK <>9__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ANEMLFDPNPK <>9__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ANEMLFDPNPK <>9__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ANEMLFDPNPK <>9__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ANEMLFDPNPK <>9__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ANEMLFDPNPK <>9__13;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public GOCKLDACHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68272F0", Offset = "0x68262F0", VA = "0x1868272F0")]
		internal void FODADFCBCLG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68260A0", Offset = "0x68250A0", VA = "0x1868260A0")]
		internal void MCDMPCLCNMI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6827410", Offset = "0x6826410", VA = "0x186827410")]
		internal void IPGHJJFPCDE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6827030", Offset = "0x6826030", VA = "0x186827030")]
		internal void ALMJAMFDNCD(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68270E0", Offset = "0x68260E0", VA = "0x1868270E0")]
		internal void ANCDGNCJKNB(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6827600", Offset = "0x6826600", VA = "0x186827600")]
		internal void PGHFLNELLOH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68274C0", Offset = "0x68264C0", VA = "0x1868274C0")]
		internal void JNENHNODMCE(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68275D0", Offset = "0x68265D0", VA = "0x1868275D0")]
		internal void OIGAELIICPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68272C0", Offset = "0x68262C0", VA = "0x1868272C0")]
		internal void EMJCMLFJNDF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6826FB0", Offset = "0x6825FB0", VA = "0x186826FB0")]
		internal void AHEFOFKFLKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6827330", Offset = "0x6826330", VA = "0x186827330")]
		internal void GCOCCOOABIH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6827590", Offset = "0x6826590", VA = "0x186827590")]
		internal void NIJADBOJEKF(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68274F0", Offset = "0x68264F0", VA = "0x1868274F0")]
		internal void KFGHHIKLIDH(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6827190", Offset = "0x6826190", VA = "0x186827190")]
		internal void BLALGHPEDEC(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6828090", Offset = "0x6827090", VA = "0x186828090", Slot = "27")]
	public override SerializedAvatarItemData Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6828AF0", Offset = "0x6827AF0", VA = "0x186828AF0", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, SerializedAvatarItemData JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6827F70", Offset = "0x6826F70", VA = "0x186827F70")]
	private AdditionalOutfitTypeData MBMNHIADHLP(Utf8JsonReader JBMHGCNDNMN, OutfitType HNGLFCFOHLI, JsonSerializerOptions OLBNLJKBNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6828FA0", Offset = "0x6827FA0", VA = "0x186828FA0")]
	public MFHOLPNIHED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OGFCNOKLEOC : JsonConverter<AvatarItemDownloadableConfig>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6829020", Offset = "0x6828020", VA = "0x186829020", Slot = "27")]
	public override AvatarItemDownloadableConfig Read(Utf8JsonReader JBMHGCNDNMN, Type EMJCDFPIDEK, JsonSerializerOptions OLBNLJKBNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6829390", Offset = "0x6828390", VA = "0x186829390", Slot = "28")]
	public override void Write(Utf8JsonWriter KOHNEKCBPBH, AvatarItemDownloadableConfig JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6829480", Offset = "0x6828480", VA = "0x186829480")]
	public OGFCNOKLEOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HGGAJIMPJBG : BCCMKHDNANG<BeardData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6827770", Offset = "0x6826770", VA = "0x186827770", Slot = "35")]
	public override void LBNJAACLDOK(Utf8JsonReader JBMHGCNDNMN, JsonSerializerOptions OLBNLJKBNFE, string BGJCPPOHOEL, BeardData LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68276B0", Offset = "0x68266B0", VA = "0x1868276B0", Slot = "36")]
	public override void IJJMPHCONDO(Utf8JsonWriter KOHNEKCBPBH, BeardData JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6827910", Offset = "0x6826910", VA = "0x186827910")]
	public HGGAJIMPJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GLCCOEAGKGB : KODFLIIKOMN<GKBILINBDHG>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6826F70", Offset = "0x6825F70", VA = "0x186826F70")]
	public GLCCOEAGKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LEKMCPEFBKG : KODFLIIKOMN<GNNPFKCNMDF>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6827E20", Offset = "0x6826E20", VA = "0x186827E20")]
	public LEKMCPEFBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BKEBELAJJGL : KODFLIIKOMN<MFJFKOLHJGJ>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6824A30", Offset = "0x6823A30", VA = "0x186824A30")]
	public BKEBELAJJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NLDENKPMCIK : DHPIHIDKBFD<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6828FE0", Offset = "0x6827FE0", VA = "0x186828FE0")]
	public NLDENKPMCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GBPCKHJEIDH : BCCMKHDNANG<HairData>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EMNIHGNNKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HairData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public EMNIHGNNKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6825FF0", Offset = "0x6824FF0", VA = "0x186825FF0")]
		internal void ECMHPLGJKNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6825F20", Offset = "0x6824F20", VA = "0x186825F20")]
		internal void CGHBHMNACEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68260A0", Offset = "0x68250A0", VA = "0x1868260A0")]
		internal void HONOLDDMLCG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6825E80", Offset = "0x6824E80", VA = "0x186825E80")]
		internal void AHPBAOFCCHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6825F50", Offset = "0x6824F50", VA = "0x186825F50")]
		internal void DMCIGFCGENP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6826100", Offset = "0x6825100", VA = "0x186826100")]
		internal void OCBPMGPICGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68260D0", Offset = "0x68250D0", VA = "0x1868260D0")]
		internal void JNHOAENHBPL(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6826B40", Offset = "0x6825B40", VA = "0x186826B40", Slot = "35")]
	public override void LBNJAACLDOK(Utf8JsonReader JBMHGCNDNMN, JsonSerializerOptions OLBNLJKBNFE, string BGJCPPOHOEL, HairData LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6826860", Offset = "0x6825860", VA = "0x186826860", Slot = "36")]
	public override void IJJMPHCONDO(Utf8JsonWriter KOHNEKCBPBH, HairData JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6826F30", Offset = "0x6825F30", VA = "0x186826F30")]
	public GBPCKHJEIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CGBGCGMCOGC : BCCMKHDNANG<AdditionalHatData>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KADGBHINAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AdditionalHatData item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JsonSerializerOptions options;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KADGBHINAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6827B60", Offset = "0x6826B60", VA = "0x186827B60")]
		internal void ECMHPLGJKNI(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6827A00", Offset = "0x6826A00", VA = "0x186827A00")]
		internal void CGHBHMNACEJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6827B90", Offset = "0x6826B90", VA = "0x186827B90")]
		internal void HONOLDDMLCG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6827950", Offset = "0x6826950", VA = "0x186827950")]
		internal void AHPBAOFCCHJ(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6827AB0", Offset = "0x6826AB0", VA = "0x186827AB0")]
		internal void DMCIGFCGENP(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6827D80", Offset = "0x6826D80", VA = "0x186827D80")]
		internal void OCBPMGPICGG(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6827C40", Offset = "0x6826C40", VA = "0x186827C40")]
		internal void JNHOAENHBPL(Utf8JsonReader r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6827CE0", Offset = "0x6826CE0", VA = "0x186827CE0")]
		internal void LKMDBEELFPD(Utf8JsonReader r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6824DC0", Offset = "0x6823DC0", VA = "0x186824DC0", Slot = "35")]
	public override void LBNJAACLDOK(Utf8JsonReader JBMHGCNDNMN, JsonSerializerOptions OLBNLJKBNFE, string BGJCPPOHOEL, AdditionalHatData LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6824A70", Offset = "0x6823A70", VA = "0x186824A70", Slot = "36")]
	public override void IJJMPHCONDO(Utf8JsonWriter KOHNEKCBPBH, AdditionalHatData JJCEIJMGOAB, JsonSerializerOptions OLBNLJKBNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6825220", Offset = "0x6824220", VA = "0x186825220")]
	public CGBGCGMCOGC()
	{
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85BDC0", Offset = "0x85ADC0", VA = "0x18085BDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49400", VA = "0x180B4A400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xC42BC0", Offset = "0xC41BC0", VA = "0x180C42BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xED2AA0", Offset = "0xED1AA0", VA = "0x180ED2AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xED3F30", Offset = "0xED2F30", VA = "0x180ED3F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1F0ADA0", Offset = "0x1F09DA0", VA = "0x181F0ADA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1F0ADB0", Offset = "0x1F09DB0", VA = "0x181F0ADB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x14F2600", Offset = "0x14F1600", VA = "0x1814F2600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x68294C0", Offset = "0x68284C0", VA = "0x1868294C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2355300", Offset = "0x2354300", VA = "0x182355300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x23552D0", Offset = "0x23542D0", VA = "0x1823552D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1C32610", Offset = "0x1C31610", VA = "0x181C32610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1C32620", Offset = "0x1C31620", VA = "0x181C32620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CLDHMGFCKEM ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBFF640", Offset = "0xBFE640", VA = "0x180BFF640")]
			[CompilerGenerated]
			get
			{
				return default(CLDHMGFCKEM);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBFEC30", Offset = "0xBFDC30", VA = "0x180BFEC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PMDMGKIOLAB.NJCPOFDIECP ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2000", Offset = "0x9F1000", VA = "0x1809F2000")]
			[CompilerGenerated]
			get
			{
				return default(PMDMGKIOLAB.NJCPOFDIECP);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBFEF00", Offset = "0xBFDF00", VA = "0x180BFEF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8518B0", Offset = "0x8508B0", VA = "0x1808518B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9897E0", Offset = "0x9887E0", VA = "0x1809897E0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x987510", Offset = "0x986510", VA = "0x180987510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1139FC0", Offset = "0x1138FC0", VA = "0x181139FC0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3D87840", Offset = "0x3D86840", VA = "0x183D87840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
