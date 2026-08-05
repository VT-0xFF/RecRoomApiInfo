using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A88F60", Offset = "0x7A88360", VA = "0x187A88F60", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AA20", Offset = "0x1F49E20", VA = "0x181F4AA20", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A90C20", Offset = "0x7A90020", VA = "0x187A90C20")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A911B0", Offset = "0x7A905B0", VA = "0x187A911B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A91210", Offset = "0x7A90610", VA = "0x187A91210")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FHIFCGAGECE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A779E0", Offset = "0x7A76DE0", VA = "0x187A779E0")]
	public static Quaternion KDOHGNIDMMF([In] this KJFDPPPADNF DGNGPICABGM, [In] Vector3 GOMJGIJPEPD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CEDIMEONMJK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A751D0", Offset = "0x7A745D0", VA = "0x187A751D0")]
	public static bool KMNOOHGIDEL(this DEPCJKEDPJM FNFDDMEMDEJ, AEPLEEMHJAE JKBGMEDEBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7A75210", Offset = "0x7A74610", VA = "0x187A75210")]
	public static bool MBAHOEJPKOG(this DEPCJKEDPJM FNFDDMEMDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A75240", Offset = "0x7A74640", VA = "0x187A75240")]
	public static bool PHMEIKOFIMK(this DEPCJKEDPJM FNFDDMEMDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A74E80", Offset = "0x7A74280", VA = "0x187A74E80")]
	public static void KBKDKKHMNND(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 NCHJEPMMCKG, Quaternion ABKEKEABNGD, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A73C50", Offset = "0x7A73050", VA = "0x187A73C50")]
	public static void HGADFLPKNEF(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 NCHJEPMMCKG, Quaternion ABKEKEABNGD, float JAINCGFCEKN, int CFJEFFNMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A73ED0", Offset = "0x7A732D0", VA = "0x187A73ED0")]
	public static void HGEIBABFDAD(this DEPCJKEDPJM FNFDDMEMDEJ, int CFJEFFNMBCH, Vector3 NCHJEPMMCKG, Quaternion ABKEKEABNGD, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A74E30", Offset = "0x7A74230", VA = "0x187A74E30")]
	public static void JDCNMKIPLOL(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 GCJHJJNNDBO, Quaternion EGDLCIMPLDH, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A73FF0", Offset = "0x7A733F0", VA = "0x187A73FF0")]
	private static void HHHJABJBOBH(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A734F0", Offset = "0x7A728F0", VA = "0x187A734F0")]
	private static void CALDNHFONCM(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float CKJPKNDPHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A737B0", Offset = "0x7A72BB0", VA = "0x187A737B0")]
	private static void DCBBLGCIKHO(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float CKJPKNDPHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A73990", Offset = "0x7A72D90", VA = "0x187A73990")]
	private static bool DOHBBEDOPEE(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A739C0", Offset = "0x7A72DC0", VA = "0x187A739C0")]
	private static void HCGNCIKBIDL(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float CKJPKNDPHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A74940", Offset = "0x7A73D40", VA = "0x187A74940")]
	public static Vector3 IPEFFBBKKMK(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A736A0", Offset = "0x7A72AA0", VA = "0x187A736A0")]
	public static Quaternion CDFPEKNOFOE(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A74FB0", Offset = "0x7A743B0", VA = "0x187A74FB0")]
	public static Vector3 KCPOEAKFAAK(AEPLEEMHJAE KHCEBCMPDGO, Vector3 INHMOEHIHAJ, Vector3? FHNCCNDNJMA, Vector3 EMIHCEDDDNG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface LALNCPAGEKP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface AJHKGOLCOLK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType GBAAJDLPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class KIMFFPKKEJP : LALNCPAGEKP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A87D70", Offset = "0x7A87170", VA = "0x187A87D70", Slot = "4")]
	public void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KIMFFPKKEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class FFLPACCLOMK : LALNCPAGEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GPFFCLEGEBK DPGMLKFBPHP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
	public FFLPACCLOMK(GPFFCLEGEBK DPGMLKFBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A77890", Offset = "0x7A76C90", VA = "0x187A77890", Slot = "4")]
	public void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class FNKHBGFNKOA : LALNCPAGEKP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A77AC0", Offset = "0x7A76EC0", VA = "0x187A77AC0", Slot = "4")]
	public void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FNKHBGFNKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OGFEDDFIHOI : AJHKGOLCOLK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType GBAAJDLPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C540", Offset = "0x7A8B940", VA = "0x187A8C540", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C5C0", Offset = "0x7A8B9C0", VA = "0x187A8C5C0", Slot = "5")]
	public void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C2C0", Offset = "0x7A8B6C0", VA = "0x187A8C2C0", Slot = "6")]
	public void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C570", Offset = "0x7A8B970", VA = "0x187A8C570", Slot = "7")]
	public void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public OGFEDDFIHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DIEHLHPFLGD : AJHKGOLCOLK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType GBAAJDLPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7A76CE0", Offset = "0x7A760E0", VA = "0x187A76CE0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A76D60", Offset = "0x7A76160", VA = "0x187A76D60", Slot = "5")]
	public void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A76A60", Offset = "0x7A75E60", VA = "0x187A76A60", Slot = "6")]
	public void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A76D10", Offset = "0x7A76110", VA = "0x187A76D10", Slot = "7")]
	public void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public DIEHLHPFLGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IODJAMAECKF : AJHKGOLCOLK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType GBAAJDLPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A829D0", Offset = "0x7A81DD0", VA = "0x187A829D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A82A50", Offset = "0x7A81E50", VA = "0x187A82A50", Slot = "5")]
	public void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A82750", Offset = "0x7A81B50", VA = "0x187A82750", Slot = "6")]
	public void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A82A00", Offset = "0x7A81E00", VA = "0x187A82A00", Slot = "7")]
	public void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public IODJAMAECKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class CJDFBFIIGHL : CPCJJCHJEHO, NOIGPCCMOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AKEIGEGKEAD CJADGLGGCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JLMEEIFAJDN KDOOJEDNFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BGHAFNKMMBO MBNJNBHHLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, LALNCPAGEKP adapter)> JPNAAKGHMIG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A75BD0", Offset = "0x7A74FD0", VA = "0x187A75BD0", Slot = "15")]
	public virtual void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A75C60", Offset = "0x7A75060", VA = "0x187A75C60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A60", Offset = "0x7A74E60", VA = "0x187A75A60")]
	private void ILGLDFCMIBD(EntityQueryDesc LEEGMHDKJLE, LALNCPAGEKP EOLHBGPOHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A75E90", Offset = "0x7A75290", VA = "0x187A75E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
	public CJDFBFIIGHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class CCIMJAFDHNK : CPCJJCHJEHO, NOIGPCCMOKP
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class LIIEKFGADJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery HINCDBBCPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery HENPNEECGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery NHEAJBMDJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery MIDDNGMOJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery PICMGLFABDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery DBCMPOKPONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery CDOLGHHOBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AJHKGOLCOLK PLNHAFIHCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType FCAANBFFDFK;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LIIEKFGADJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AKEIGEGKEAD CJADGLGGCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BGHAFNKMMBO MBNJNBHHLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JLMEEIFAJDN KDOOJEDNFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<LIIEKFGADJG> JPNAAKGHMIG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A73050", Offset = "0x7A72450", VA = "0x187A73050", Slot = "14")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A730E0", Offset = "0x7A724E0", VA = "0x187A730E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A73260", Offset = "0x7A72660", VA = "0x187A73260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A724C0", Offset = "0x7A718C0", VA = "0x187A724C0")]
	private void HKCLDCJKHGF(LIIEKFGADJG JFFLKKNAOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A72910", Offset = "0x7A71D10", VA = "0x187A72910")]
	private void ILGLDFCMIBD(AJHKGOLCOLK PLNHAFIHCMN, ComponentType CBAHMAMKNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
	public CCIMJAFDHNK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct LGPAFKLNMIE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct JICLHHJKDAO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct DOBJNMBFCEH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(BGHAFNKMMBO), new string[] { })]
public class PHHGGEACNBE : BGHAFNKMMBO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NIBPFMHDCCB GFJHHCLMBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NIBPFMHDCCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public PHHGGEACNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(PMFKHGPHHMA), new string[] { })]
public class IBGAFDIOOCE : PMFKHGPHHMA, IFIGABCBEHK, KKLCFFMBMBE, KKJGFIPLMOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private OMJPGNMJFJE AGLNINADJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private AKEIGEGKEAD CJADGLGGCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private FFMBAKBAEBH OIOENLJBCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity JGANOKIEFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private OIICOGMNAJO NNFNEEILBDC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FDF0", Offset = "0x7A7F1F0", VA = "0x187A7FDF0", Slot = "4")]
	public bool BDFAPKAEADC(ENLBBCIDMLB KJCJJFGLKEE, MMCAHBLJMAC FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FED0", Offset = "0x7A7F2D0", VA = "0x187A7FED0", Slot = "5")]
	public OIICOGMNAJO HEAPJCGBDMK()
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A80190", Offset = "0x7A7F590", VA = "0x187A80190", Slot = "6")]
	public void PMEHGNAODFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FD60", Offset = "0x7A7F160", VA = "0x187A7FD60", Slot = "7")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1088290", Offset = "0x1087690", VA = "0x181088290", Slot = "8")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public IBGAFDIOOCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(PDKFKKEFBFF), new string[] { })]
public class GONGPAPOBBK : PDKFKKEFBFF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A310", Offset = "0x7A79710", VA = "0x187A7A310", Slot = "4")]
	public void CBEDDHEFHON(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A570", Offset = "0x7A79970", VA = "0x187A7A570", Slot = "5")]
	public void MJEJMCFOGGO(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A460", Offset = "0x7A79860", VA = "0x187A7A460", Slot = "6")]
	public ComponentSystemBase EKNDCMKBKCM(World AGLNINADJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A400", Offset = "0x7A79800", VA = "0x187A7A400", Slot = "7")]
	public void EIDBIBJCLNF(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A4B0", Offset = "0x7A798B0", VA = "0x187A7A4B0", Slot = "8")]
	public void IPHNGDBJAOC(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A510", Offset = "0x7A79910", VA = "0x187A7A510", Slot = "9")]
	public void LGFILKFPCIO(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A390", Offset = "0x7A79790", VA = "0x187A7A390", Slot = "10")]
	public void DLPJJEPKDMC(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A79B10", Offset = "0x7A78F10", VA = "0x187A79B10", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> BCOFFAEBDIF()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GONGPAPOBBK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct BAJJMPHKCEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct PFGFPJBFDEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DIBNEGMHILF : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKEFCPMGAAL BEJLBFGPDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A76A10", Offset = "0x7A75E10", VA = "0x187A76A10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A769A0", Offset = "0x7A75DA0", VA = "0x187A769A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public DIBNEGMHILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct HINNAMACAJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OIICOGMNAJO BFGCMIGMIPH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static HINNAMACAJL CLMIANKGGAM(OIICOGMNAJO GGBKPDHLOJF)
	{
		return default(HINNAMACAJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CLOJCNCJEOF : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AAMGODPHIMC BAOFPGCHLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A76080", Offset = "0x7A75480", VA = "0x187A76080", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CLOJCNCJEOF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct DPBOJJEIECG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct DAGKGHEOHKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LCIMFKFFNPO BCDCMHANCLK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static DAGKGHEOHKI CLMIANKGGAM(LCIMFKFFNPO GGBKPDHLOJF)
	{
		return default(DAGKGHEOHKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct MACJCLGOPKL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OIICOGMNAJO BFGCMIGMIPH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static MACJCLGOPKL CLMIANKGGAM(OIICOGMNAJO GGBKPDHLOJF)
	{
		return default(MACJCLGOPKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IIMKNJOCBLN : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CAJIMFNGHMB KIPDCCMIOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A807D0", Offset = "0x7A7FBD0", VA = "0x187A807D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A80760", Offset = "0x7A7FB60", VA = "0x187A80760", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public IIMKNJOCBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HIONMKHHNAE : IBGHKANAKPN, JKEFCPMGAAL, HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NANCINDJPCK NBDCOHDLODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC76980", Offset = "0xC75D80", VA = "0x180C76980", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(NANCINDJPCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HPKGHNAEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB52420", Offset = "0xB51820", VA = "0x180B52420", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 IGDJHJNCEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xFBE1A0", Offset = "0xFBD5A0", VA = "0x180FBE1A0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F070", Offset = "0x7A7E470", VA = "0x187A7F070")]
	public HIONMKHHNAE(UniformTRS CBDJEGLJELC, GNCDNFKLNJM KLDFHLFOOFN, float DFDHCIFLIEL, float3 JBLCFMEMICC, HHGCLPMBJBD OMKFPHEGFHH, PDDOBMNCGIK CBFMFDPEENL, NANCINDJPCK NHIHPDFILIL, float3 JAIPPEBDKDH, bool BFOBKNHDOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F020", Offset = "0x7A7E420", VA = "0x187A7F020", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ONNDNADDBKC : IBGHKANAKPN, CAJIMFNGHMB, HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<NPAMCAHKLLB> BHJAABGCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AEKEOCGFHPH MHBNBGGMEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float GKKGJNHJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int OEHJNPNNGLB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NJFNLKGAPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C9B0", Offset = "0x7A8BDB0", VA = "0x187A8C9B0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CIPMINOOIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C9D0", Offset = "0x7A8BDD0", VA = "0x187A8C9D0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MNIKIPNBOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C9C0", Offset = "0x7A8BDC0", VA = "0x187A8C9C0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MPCKDJKFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xCC4190", Offset = "0xCC3590", VA = "0x180CC4190", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MMIPFNDLNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBEA320", Offset = "0xBE9720", VA = "0x180BEA320", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ANDHONEAKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE62A20", Offset = "0xE61E20", VA = "0x180E62A20", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C900", Offset = "0x7A8BD00", VA = "0x187A8C900")]
	public ONNDNADDBKC(UniformTRS CBDJEGLJELC, GNCDNFKLNJM KLDFHLFOOFN, float DFDHCIFLIEL, float3 JBLCFMEMICC, HHGCLPMBJBD OMKFPHEGFHH, PDDOBMNCGIK CBFMFDPEENL, AEKEOCGFHPH MHBNBGGMEBA, float GKKGJNHJJOM, int OEHJNPNNGLB, NativeArray<NPAMCAHKLLB> BHJAABGCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xFD6E80", Offset = "0xFD6280", VA = "0x180FD6E80", Slot = "33")]
	public NativeArray<NPAMCAHKLLB> GetNativeCurvePoints()
	{
		return default(NativeArray<NPAMCAHKLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C840", Offset = "0x7A8BC40", VA = "0x187A8C840", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DCNCPLNAHJG : DCNEGHKEHPH, JKEFCPMGAAL, HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<OGALGCNMGJH, NANCINDJPCK> FECPOEAJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private NANCINDJPCK NHIHPDFILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BFOBKNHDOHK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NANCINDJPCK OGIKHJOBCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9C86A0", Offset = "0x9C7AA0", VA = "0x1809C86A0", Slot = "28")]
		get
		{
			return default(NANCINDJPCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool MKGHPDMLNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD81720", Offset = "0xD80B20", VA = "0x180D81720", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 IGDJHJNCEHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7A768D0", Offset = "0x7A75CD0", VA = "0x187A768D0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7A768B0", Offset = "0x7A75CB0", VA = "0x187A768B0")]
	public DCNCPLNAHJG(ENLBBCIDMLB BMDNKFOGKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A76230", Offset = "0x7A75630", VA = "0x187A76230", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A76280", Offset = "0x7A75680", VA = "0x187A76280", Slot = "26")]
	public override void ODNOMLGNGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EOMCKKMGMON : INFIJFJHPJM, AAMGODPHIMC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject CNHEJODLIHN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject ANCELBFINAL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7A772C0", Offset = "0x7A766C0", VA = "0x187A772C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FGCPOOOBBED IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7A77350", Offset = "0x7A76750", VA = "0x187A77350", Slot = "15")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MIOMDMDHLED DAAEMKJBPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7A77730", Offset = "0x7A76B30", VA = "0x187A77730", Slot = "16")]
		get
		{
			return default(MIOMDMDHLED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A775E0", Offset = "0x7A769E0", VA = "0x187A775E0")]
	public EOMCKKMGMON(ENLBBCIDMLB KJCJJFGLKEE, bool PLKIBKPEIMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A77450", Offset = "0x7A76850", VA = "0x187A77450")]
	public void PKBMGCEHLEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A77350", Offset = "0x7A76750", VA = "0x187A77350")]
	protected FGCPOOOBBED MPNBKLHNMPH()
	{
		return default(FGCPOOOBBED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A77140", Offset = "0x7A76540", VA = "0x187A77140")]
	private static bool AJGAKKAJBEE(ENLBBCIDMLB LNKAJOLIAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7A77290", Offset = "0x7A76690", VA = "0x187A77290", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FOEHONKLPAC : DCNEGHKEHPH, CAJIMFNGHMB, HNHLMEHDPNB, IDisposable, MGEJOGHOFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<NPAMCAHKLLB> BHJAABGCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool DOGLHCHHMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool MMCAMDIPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float GKKGJNHJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int OEHJNPNNGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool MEPPEBLBCAK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool CNDOMCCNJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB5F7F0", Offset = "0xB5EBF0", VA = "0x180B5F7F0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool OOPOOEJDBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6560", Offset = "0x9F5960", VA = "0x1809F6560", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float PHANEAGKFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xF68650", Offset = "0xF67A50", VA = "0x180F68650", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int JEEPNIFBAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC76980", Offset = "0xC75D80", VA = "0x180C76980", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DFBJLGLMHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB52420", Offset = "0xB51820", VA = "0x180B52420", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int BKEAFFCGLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A77C00", Offset = "0x7A77000", VA = "0x187A77C00", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int APMABDPAOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A77EC0", Offset = "0x7A772C0", VA = "0x187A77EC0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7A784F0", Offset = "0x7A778F0", VA = "0x187A784F0")]
	public FOEHONKLPAC(ENLBBCIDMLB BMDNKFOGKPH, [Optional] NativeList<NPAMCAHKLLB> BHJAABGCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7A78410", Offset = "0x7A77810", VA = "0x187A78410", Slot = "26")]
	public override void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7A77DD0", Offset = "0x7A771D0", VA = "0x187A77DD0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7A77FB0", Offset = "0x7A773B0", VA = "0x187A77FB0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A77D70", Offset = "0x7A77170", VA = "0x187A77D70")]
	public void CJLAFBGEEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A781A0", Offset = "0x7A775A0", VA = "0x187A781A0", Slot = "34")]
	public NativeArray<NPAMCAHKLLB> GetNativeCurvePoints()
	{
		return default(NativeArray<NPAMCAHKLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A77C20", Offset = "0x7A77020", VA = "0x187A77C20", Slot = "35")]
	private Vector3 CFJDBBPBFEK(int NMAOAJDPHDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A78370", Offset = "0x7A77770", VA = "0x187A78370", Slot = "36")]
	private Quaternion ICBLKOOACBN(int NMAOAJDPHDG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A78010", Offset = "0x7A77410", VA = "0x187A78010", Slot = "37")]
	private float EOAIIEEKAGK(int NMAOAJDPHDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A783A0", Offset = "0x7A777A0", VA = "0x187A783A0")]
	private NativeArray<Entity> JPIDHADOEDL()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class BEOOMOLHALG : JFFLOKHEAII
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A71E50", Offset = "0x7A71250", VA = "0x187A71E50", Slot = "15")]
	protected override ComponentSystemBase BPAGNBAPCJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7A72260", Offset = "0x7A71660", VA = "0x187A72260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A72270", Offset = "0x7A71670", VA = "0x187A72270")]
	public BEOOMOLHALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PFAGOJMNAEO]
public sealed class LKJIJJMKNLF : DOJMHIHKINF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery GPCLLEKDGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery AALNMDKAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery BMHKCEHNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery PBFIEOGGKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery IIFADPMHCEE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A88760", Offset = "0x7A87B60", VA = "0x187A88760", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A88AC0", Offset = "0x7A87EC0", VA = "0x187A88AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7A87F70", Offset = "0x7A87370", VA = "0x187A87F70")]
	private void BOMPGMGDNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A88490", Offset = "0x7A87890", VA = "0x187A88490")]
	private void JMGDOFBHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7A882B0", Offset = "0x7A876B0", VA = "0x187A882B0")]
	private void FAFADCNKGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A88600", Offset = "0x7A87A00", VA = "0x187A88600")]
	private void NPHCNGIJIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A881B0", Offset = "0x7A875B0", VA = "0x187A881B0")]
	private void EAIEJONFKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A88700", Offset = "0x7A87B00", VA = "0x187A88700")]
	private NativeList<Entity> OMGJOEOCPDF(NativeArray<Entity> MGNIPLBHEJL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A885A0", Offset = "0x7A879A0", VA = "0x187A885A0")]
	private NativeList<Entity> NCMFMDJPKMF(NativeArray<Entity> MGNIPLBHEJL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A88150", Offset = "0x7A87550", VA = "0x187A88150")]
	private void CIFDBMDPKJK(NativeArray<Entity> MGNIPLBHEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public LKJIJJMKNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PFAGOJMNAEO]
public sealed class GGDMHPGNPGO : DOJMHIHKINF, NOIGPCCMOKP
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery CFPHKNHENJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery CNBMPLHCHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery NHEAJBMDJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PMFKHGPHHMA FOHPJFNJDLG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A79890", Offset = "0x7A78C90", VA = "0x187A79890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A78D50", Offset = "0x7A78150", VA = "0x187A78D50", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A79A60", Offset = "0x7A78E60", VA = "0x187A79A60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A79210", Offset = "0x7A78610", VA = "0x187A79210")]
	private void MFAFKAOEOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A786D0", Offset = "0x7A77AD0", VA = "0x187A786D0")]
	private void CJAADLJGPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A78DB0", Offset = "0x7A781B0", VA = "0x187A78DB0")]
	private void KAIJHALLICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A79170", Offset = "0x7A78570", VA = "0x187A79170")]
	private bool KHFDNGBDFDF(Entity GJIBJHOJMIG, [Out] OIICOGMNAJO BFGCMIGMIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A78520", Offset = "0x7A77920", VA = "0x187A78520")]
	private bool CDMMPNGKLAI(Entity GJIBJHOJMIG, [Out] OIICOGMNAJO BFGCMIGMIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public GGDMHPGNPGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PFAGOJMNAEO]
public sealed class CEFAFJLMLDM : DOJMHIHKINF
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery GOGAPOKJLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery HOAPIBJOOJI;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A75860", Offset = "0x7A74C60", VA = "0x187A75860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A759B0", Offset = "0x7A74DB0", VA = "0x187A759B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A75560", Offset = "0x7A74960", VA = "0x187A75560")]
	private void MFAFKAOEOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A75270", Offset = "0x7A74670", VA = "0x187A75270")]
	private void CJAADLJGPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public CEFAFJLMLDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MGBIKDCMNGB : DOJMHIHKINF, NOIGPCCMOKP
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct EEJEANJCCBC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob JKHNAJMNAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob ANCMLLOKHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob AIOINBCMBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob BFLHFJIGEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle DJJPHNMMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<MACJCLGOPKL> DGDHAFJENHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> IEMJBGJKBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> BJNGNFFADMJ;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A770C0", Offset = "0x7A764C0", VA = "0x187A770C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A76FE0", Offset = "0x7A763E0", VA = "0x187A76FE0")]
		private void BKNLJLGDPKK(EntityQueryInJob CNBDJCPJLHG, NativeList<Entity> OEFHFIPKOMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct IBPEJNDNHLN : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle DJJPHNMMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<MACJCLGOPKL> DGDHAFJENHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> OEFHFIPKOMA;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A804A0", Offset = "0x7A7F8A0", VA = "0x187A804A0", Slot = "4")]
		public void Execute(ArchetypeChunk MPEDPGOPDGN, int AKEIKCLPAEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct AKMPOLDBNCO : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle DJJPHNMMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> LKKOIJMCMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<DAGKGHEOHKI> ONLJKLIGCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<HINNAMACAJL> NCAGCGAIKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<MACJCLGOPKL> DBMJBGCHGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> AJFCLKNEHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<DAGKGHEOHKI> NKOKHAHODLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<OIICOGMNAJO> IDEAKNDFBKD;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A71B20", Offset = "0x7A70F20", VA = "0x187A71B20", Slot = "4")]
		public void Execute(ArchetypeChunk MPEDPGOPDGN, int AKEIKCLPAEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery JKHNAJMNAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery ANCMLLOKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery AIOINBCMBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery BFLHFJIGEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery KCDDILEGPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery FFHPKFMDDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery LJFCMANELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PMFKHGPHHMA LMOIJBEBEHO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A710", Offset = "0x7A89B10", VA = "0x187A8A710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A0B0", Offset = "0x7A894B0", VA = "0x187A8A0B0", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A8AC90", Offset = "0x7A8A090", VA = "0x187A8AC90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A892E0", Offset = "0x7A886E0", VA = "0x187A892E0")]
	private void CCBELHLMCDC(NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC, int PMLBOABNEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A110", Offset = "0x7A89510", VA = "0x187A8A110")]
	private void KFCIKNEJKHK(NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC, int ILGHELCHEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A89C70", Offset = "0x7A89070", VA = "0x187A89C70")]
	private void GKGLAAJFBII(NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC, int NELIJDAFAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A898E0", Offset = "0x7A88CE0", VA = "0x187A898E0")]
	private void FEBEMEIJHLH(NativeParallelHashSet<OIICOGMNAJO> NGAKCHNEECE, int LGPOEPKCFLF, int NDECLKFKMLA, int BBDMLJGBDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A560", Offset = "0x7A89960", VA = "0x187A8A560")]
	private void NPIJOEBOLNJ(Entity NOJEANLGDHM, LCIMFKFFNPO MLIJBDKMILB, OIICOGMNAJO BFGCMIGMIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public MGBIKDCMNGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class NFMAFMLFFJE : DOJMHIHKINF
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery PCECIFPLKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery BIOADMDIFPA;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B790", Offset = "0x7A8AB90", VA = "0x187A8B790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B9C0", Offset = "0x7A8ADC0", VA = "0x187A8B9C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public NFMAFMLFFJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NEPCLPKDMHP : DOJMHIHKINF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct KCDIJGIAFMA : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery BHIDJCFLKEO;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B420", Offset = "0x7A8A820", VA = "0x187A8B420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A8B560", Offset = "0x7A8A960", VA = "0x187A8B560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public NEPCLPKDMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PFAGOJMNAEO]
internal class HPNDNLBMHDL : DOJMHIHKINF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class DIPDFGOCFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery PKPKGDGFFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery LDCBJKFHFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LKIKPJPKFJI HLNBMJNKMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType CECGKDCMLCM;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DIPDFGOCFNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void LKIKPJPKFJI(NativeArray<LCIMFKFFNPO> GGBKPDHLOJF, NGAIKMOOEAO JKLGAFJECFN);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<DIPDFGOCFNN> JPNAAKGHMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private JLMEEIFAJDN KDOOJEDNFMI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F2B0", Offset = "0x7A7E6B0", VA = "0x187A7F2B0", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F650", Offset = "0x7A7EA50", VA = "0x187A7F650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F7E0", Offset = "0x7A7EBE0", VA = "0x187A7F7E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3649DD0", Offset = "0x36491D0", VA = "0x183649DD0")]
	private void ILGLDFCMIBD<T>(LKIKPJPKFJI HLNBMJNKMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F310", Offset = "0x7A7E710", VA = "0x187A7F310")]
	private static void LPNLGMCGBLB(NativeArray<LCIMFKFFNPO> JGEIDAMJLAD, NGAIKMOOEAO PJMAPBNCCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F4B0", Offset = "0x7A7E8B0", VA = "0x187A7F4B0")]
	private static void OMFGNCCJHMM(NativeArray<LCIMFKFFNPO> JGEIDAMJLAD, NGAIKMOOEAO PJMAPBNCCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F110", Offset = "0x7A7E510", VA = "0x187A7F110")]
	private static void CEMLFMOLPPD(NativeArray<LCIMFKFFNPO> JGEIDAMJLAD, NGAIKMOOEAO PJMAPBNCCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public HPNDNLBMHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PFAGOJMNAEO]
public sealed class PJNJLHDOJMF : DOJMHIHKINF
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery CNBDJCPJLHG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A8C9E0", Offset = "0x7A8BDE0", VA = "0x187A8C9E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct PHNAPJNLONP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS CBDJEGLJELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData MJEGEINBKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NANCINDJPCK NHIHPDFILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 JAIPPEBDKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool BFOBKNHDOHK;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PNECEGLDNFL(Lifetime.LoadInstance)]
public struct JCMAPCLELBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity GMKDGAGFJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> BJDDDCDIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> ONOILFKPNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<PHNAPJNLONP> GDHGHDPELKB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A82CD0", Offset = "0x7A820D0", VA = "0x187A82CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(IKKKGOCGBMJ), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class IKKKGOCGBMJ : NOIGPCCMOKP, PIEEAAJKAEB, KKLCFFMBMBE, KKJGFIPLMOM
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct MJPOOOCGELA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly IKKKGOCGBMJ KLDFHLFOOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool PCKPEJNLGIG;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x16A7E70", Offset = "0x16A7270", VA = "0x1816A7E70")]
		public MJPOOOCGELA(IKKKGOCGBMJ KLDFHLFOOFN, bool PCKPEJNLGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B020", Offset = "0x7A8A420", VA = "0x187A8B020")]
		public Queue<ILGKFLJPBNI>.Enumerator DBEEDGEHMMA()
		{
			return default(Queue<ILGKFLJPBNI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8B0E0", Offset = "0x7A8A4E0", VA = "0x187A8B0E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private FFMBAKBAEBH MOMEMDPHLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private PDICBNNGLMJ LMGACBCLJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<NPAMCAHKLLB>> EKMCCIJLEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> CHHLBICCGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<LCIMFKFFNPO> HHDKAPJAPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private OCKHMABGIBG<ILGKFLJPBNI> GJONEJPHNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OCKHMABGIBG<JCMAPCLELBC> BMHKAFBOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private OCKHMABGIBG<LLFANDOGFEF> EHDJKELMDLO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A80BE0", Offset = "0x7A7FFE0", VA = "0x187A80BE0", Slot = "4")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A80DE0", Offset = "0x7A801E0", VA = "0x187A80DE0")]
	public void JKIIPIFEDJO(NativeList<NPAMCAHKLLB> NKAMAGDGADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A817B0", Offset = "0x7A80BB0", VA = "0x187A817B0")]
	public void OININFKLLJE(Entity KLDFHLFOOFN, [In] LEHDJFKJBJH<GameObject> DCJPAHNKGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A808E0", Offset = "0x7A7FCE0", VA = "0x187A808E0")]
	public void CAADFKGLJNO(NativeList<LCIMFKFFNPO> JGEIDAMJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A80EB0", Offset = "0x7A802B0", VA = "0x187A80EB0")]
	public void LGFILKFPCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A81300", Offset = "0x7A80700", VA = "0x187A81300")]
	public void OBJDIHJDPFC(BCDHLHGCIBM HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A81180", Offset = "0x7A80580", VA = "0x187A81180")]
	public JobHandle MGJFKJEFHHK([In] ILGKFLJPBNI DAMFJFKKFBI, JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A810E0", Offset = "0x7A804E0", VA = "0x187A810E0")]
	public JobHandle MGJFKJEFHHK([In] JCMAPCLELBC DAMFJFKKFBI, JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x77674D0", Offset = "0x77668D0", VA = "0x1877674D0")]
	public MJPOOOCGELA LEFNDJLOGOO(bool PCKPEJNLGIG)
	{
		return default(MJPOOOCGELA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A80820", Offset = "0x7A7FC20", VA = "0x187A80820")]
	public JJCLFLALNEJ<JCMAPCLELBC> ABFNBPIOJPE()
	{
		return default(JJCLFLALNEJ<JCMAPCLELBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A80B90", Offset = "0x7A7FF90", VA = "0x187A80B90")]
	public JJCLFLALNEJ<LLFANDOGFEF> HFAFDDCJLKM()
	{
		return default(JJCLFLALNEJ<LLFANDOGFEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A80970", Offset = "0x7A7FD70", VA = "0x187A80970")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A81220", Offset = "0x7A80620", VA = "0x187A81220", Slot = "5")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A80870", Offset = "0x7A7FC70", VA = "0x187A80870", Slot = "6")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x109A090", Offset = "0x1099490", VA = "0x18109A090", Slot = "7")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public IKKKGOCGBMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct DKDBDGDLMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS CBDJEGLJELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData MJEGEINBKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public OFDKKEMCEOC MHBNBGGMEBA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PNECEGLDNFL(Lifetime.LoadInstance)]
public struct ILGKFLJPBNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity GMKDGAGFJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> BJDDDCDIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> ONOILFKPNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<GIEALLIDLLC> CNKJJBIPPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<NPAMCAHKLLB> NKAMAGDGADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<DKDBDGDLMLP> NPNFOCIKPNN;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A81990", Offset = "0x7A80D90", VA = "0x187A81990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A819A0", Offset = "0x7A80DA0", VA = "0x187A819A0")]
	public void LIPICMLEJBD(bool PCKPEJNLGIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(IGJMGOEJBKF), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class IGJMGOEJBKF : JAGCLNMGMKE, KKLCFFMBMBE, KKJGFIPLMOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private IKKKGOCGBMJ EMENHLPDCOC;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7A80740", Offset = "0x7A7FB40", VA = "0x187A80740", Slot = "4")]
	public void IEPBOELKOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7A806F0", Offset = "0x7A7FAF0", VA = "0x187A806F0", Slot = "5")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1047140", Offset = "0x1046540", VA = "0x181047140", Slot = "6")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public IGJMGOEJBKF()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : DOJMHIHKINF, NOIGPCCMOKP
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			[ReadOnly]
			public NativeParallelHashMap<int, NANCINDJPCK> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<PHNAPJNLONP> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7A7A5C0", Offset = "0x7A799C0", VA = "0x187A7A5C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[ReadOnly]
			public NativeArray<NPAMCAHKLLB> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<GIEALLIDLLC> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<DKDBDGDLMLP> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7A7A960", Offset = "0x7A79D60", VA = "0x187A7A960", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7A760F0", Offset = "0x7A754F0", VA = "0x187A760F0", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x7A8CE70", Offset = "0x7A8C270", VA = "0x187A8CE70")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x7A8CE20", Offset = "0x7A8C220", VA = "0x187A8CE20")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 LIJHIODFCEB(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x7A88B80", Offset = "0x7A87F80", VA = "0x187A88B80", Slot = "5")]
				public float3 IBIJCMHOBMH(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7A88F20", Offset = "0x7A88320", VA = "0x187A88F20", Slot = "4")]
				public float3 LIJHIODFCEB(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7A8BFA0", Offset = "0x7A8B3A0", VA = "0x187A8BFA0", Slot = "4")]
				public float3 LIJHIODFCEB(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NativeArray<GIEALLIDLLC> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<NPAMCAHKLLB> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7A7B650", Offset = "0x7A7AA50", VA = "0x187A7B650", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7A7E0B0", Offset = "0x7A7D4B0", VA = "0x187A7E0B0")]
			private void PNCFCGGOMEK(NativeList<PointSrcData> srcData, NativeList<NPAMCAHKLLB> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7A7D690", Offset = "0x7A7CA90", VA = "0x187A7D690")]
			public static Vector3 LKLDNKHHKNC(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7A7DFA0", Offset = "0x7A7D3A0", VA = "0x187A7DFA0")]
			public static quaternion NDICAGILEBN(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7A7D460", Offset = "0x7A7C860", VA = "0x187A7D460")]
			private static quaternion KICMBLGHCPP(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7A7D040", Offset = "0x7A7C440", VA = "0x187A7D040")]
			private static float3 IOBFGKJPENE(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7A7E020", Offset = "0x7A7D420", VA = "0x187A7E020")]
			private static quaternion PMGNHBELGGB(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7A7B080", Offset = "0x7A7A480", VA = "0x187A7B080")]
			private static NPAMCAHKLLB BFLDCPGMONF(int idx, NativeList<PointSrcData> srcData)
			{
				return default(NPAMCAHKLLB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x3D287D0", Offset = "0x3D27BD0", VA = "0x183D287D0")]
			private void BEHAKEOEIMA<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7A7BCB0", Offset = "0x7A7B0B0", VA = "0x187A7BCB0")]
			private void FGLPFGEFDCA(NativeList<PointSrcData> sourcePoints, NativeList<NPAMCAHKLLB> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7A7D2E0", Offset = "0x7A7C6E0", VA = "0x187A7D2E0")]
			public static float KCOHMFGNIEK(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7A7CAC0", Offset = "0x7A7BEC0", VA = "0x187A7CAC0")]
			private static quaternion GNMBHFCFELH(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7A7B4A0", Offset = "0x7A7A8A0", VA = "0x187A7B4A0")]
			private static NPAMCAHKLLB ELJGBOAEMPJ(PointSrcData point)
			{
				return default(NPAMCAHKLLB);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7A7B5C0", Offset = "0x7A7A9C0", VA = "0x187A7B5C0")]
			private static NPAMCAHKLLB ELJGBOAEMPJ(float3 pos, quaternion rot, float radius)
			{
				return default(NPAMCAHKLLB);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7A7DF00", Offset = "0x7A7D300", VA = "0x187A7DF00")]
			private static bool MOEFACEPGCP(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7A7D210", Offset = "0x7A7C610", VA = "0x187A7D210")]
			private static float3 JNFBKPHIOGJ(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7A7B2F0", Offset = "0x7A7A6F0", VA = "0x187A7B2F0")]
			public static float3 BMGEHMKEFPE(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7A7CE90", Offset = "0x7A7C290", VA = "0x187A7CE90")]
			public static float3 IBIJCMHOBMH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7A7DAA0", Offset = "0x7A7CEA0", VA = "0x187A7DAA0")]
			private static quaternion LLINDPGKHJD(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7A7CCB0", Offset = "0x7A7C0B0", VA = "0x187A7CCB0")]
			private static float HACCOHLENFK(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7A8FA80", Offset = "0x7A8EE80", VA = "0x187A8FA80")]
			private void BGFDDGIIPDI(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7A8FB60", Offset = "0x7A8EF60", VA = "0x187A8FB60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<NPAMCAHKLLB> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7A90840", Offset = "0x7A8FC40", VA = "0x187A90840")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7A908A0", Offset = "0x7A8FCA0", VA = "0x187A908A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NativeList<NPAMCAHKLLB> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7A907E0", Offset = "0x7A8FBE0", VA = "0x187A907E0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7A90830", Offset = "0x7A8FC30", VA = "0x187A90830", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NativeList<PHNAPJNLONP> data;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7A7ACA0", Offset = "0x7A7A0A0", VA = "0x187A7ACA0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7A7AE60", Offset = "0x7A7A260", VA = "0x187A7AE60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public NativeList<GIEALLIDLLC> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<DKDBDGDLMLP> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7A7AE70", Offset = "0x7A7A270", VA = "0x187A7AE70")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7A7B070", Offset = "0x7A7A470", VA = "0x187A7B070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7A903B0", Offset = "0x7A8F7B0", VA = "0x187A903B0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7A907D0", Offset = "0x7A8FBD0", VA = "0x187A907D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly GBHBOJAPDOA log;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NDPEBAHJHDP replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private FFMBAKBAEBH objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IKKKGOCGBMJ bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private CPAFPNLKBOK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F3F0", Offset = "0x7A8E7F0", VA = "0x187A8F3F0", Slot = "15")]
		public override void InitReferences(BJMEEALALCJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A90070", Offset = "0x7A8F470", VA = "0x187A90070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A90160", Offset = "0x7A8F560", VA = "0x187A90160", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A901C0", Offset = "0x7A8F5C0", VA = "0x187A901C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D920", Offset = "0x7A8CD20", VA = "0x187A8D920")]
		private JobHandle DILMLGFIMHE(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E400", Offset = "0x7A8D800", VA = "0x187A8E400")]
		private JobHandle GHMAKFONIFM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CE90", Offset = "0x7A8C290", VA = "0x187A8CE90")]
		private JobHandle BILCFMMGCMO(NativeArray<int> pointCount, NativeList<NPAMCAHKLLB> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E360", Offset = "0x7A8D760", VA = "0x187A8E360")]
		private JobHandle HMOBEEMCGNH(NativeList<NPAMCAHKLLB> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F5B0", Offset = "0x7A8E9B0", VA = "0x187A8F5B0")]
		private JobHandle LOMKEONGFFJ(EntityQuery query, NativeList<GIEALLIDLLC> splinePointRanges, NativeList<NPAMCAHKLLB> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F490", Offset = "0x7A8E890", VA = "0x187A8F490")]
		private JobHandle KKCELLPPFCF(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E0F0", Offset = "0x7A8D4F0", VA = "0x187A8E0F0")]
		private JobHandle EHLALBMKDAD(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D1F0", Offset = "0x7A8C5F0", VA = "0x187A8D1F0")]
		private JobHandle DAKOBMKDHDF(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<PHNAPJNLONP> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CF30", Offset = "0x7A8C330", VA = "0x187A8CF30")]
		private JobHandle CKJKHCHOHMJ(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<GIEALLIDLLC> splinePointRanges, [Out] NativeList<DKDBDGDLMLP> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D490", Offset = "0x7A8C890", VA = "0x187A8D490")]
		private JobHandle DCJNIFOFFBB(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EAC0", Offset = "0x7A8DEC0", VA = "0x187A8EAC0")]
		private JobHandle HJKDMDFBFJE(EntityQuery query, NativeList<PHNAPJNLONP> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7A8EFD0", Offset = "0x7A8E3D0", VA = "0x187A8EFD0")]
		private static NativeParallelHashMap<int, NANCINDJPCK> IKADDLENIIH()
		{
			return default(NativeParallelHashMap<int, NANCINDJPCK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DC60", Offset = "0x7A8D060", VA = "0x187A8DC60")]
		private JobHandle DJCKFEHANLI(EntityQuery query, NativeList<GIEALLIDLLC> splinePointRanges, NativeList<NPAMCAHKLLB> splinePointData, NativeList<DKDBDGDLMLP> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FC50", Offset = "0x7A8F050", VA = "0x187A8FC50")]
		private JobHandle NAIFNLKFFNC(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CE90", Offset = "0x7A8C290", VA = "0x187A8CE90")]
		private JobHandle ACOOIIDFCDO(NativeArray<int> pointCount, NativeList<NPAMCAHKLLB> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E360", Offset = "0x7A8D760", VA = "0x187A8E360")]
		private JobHandle GFLHNLLHDFK(NativeList<NPAMCAHKLLB> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E000", Offset = "0x7A8D400", VA = "0x187A8E000")]
		private JobHandle EFGPKHPGNAO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<PHNAPJNLONP> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7A8D810", Offset = "0x7A8CC10", VA = "0x187A8D810")]
		private JobHandle DDGBKALLFBA(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<GIEALLIDLLC> ranges, NativeList<DKDBDGDLMLP> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7A8E210", Offset = "0x7A8D610", VA = "0x187A8E210")]
		private JobHandle FNMGEOIOHBG(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7A8FD30", Offset = "0x7A8F130", VA = "0x187A8FD30", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class NONDENKLOIN : CPCJJCHJEHO, NOIGPCCMOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private IKKKGOCGBMJ EMENHLPDCOC;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BF30", Offset = "0x7A8B330", VA = "0x187A8BF30", Slot = "14")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7A8BF80", Offset = "0x7A8B380", VA = "0x187A8BF80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
	public NONDENKLOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class JJDIOALAJFN : DOJMHIHKINF, NOIGPCCMOKP
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct CALOLHJANKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager MPNJFPGMBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private BPDAEJGOKNH<T> MCJEECOKCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x62F4270", Offset = "0x62F3670", VA = "0x1862F4270")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x62F4990", Offset = "0x62F3D90", VA = "0x1862F4990")]
		public CALOLHJANKO(EntityManager MPNJFPGMBFH, BPDAEJGOKNH<T> MCJEECOKCKE, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x43979D0", Offset = "0x4396DD0", VA = "0x1843979D0")]
		public CALOLHJANKO<T> DBEEDGEHMMA()
		{
			return default(CALOLHJANKO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x62F3F50", Offset = "0x62F3350", VA = "0x1862F3F50")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly GBHBOJAPDOA DALHPECFLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PDICBNNGLMJ LMGACBCLJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IKKKGOCGBMJ EMENHLPDCOC;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7A852D0", Offset = "0x7A846D0", VA = "0x187A852D0", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7A82F70", Offset = "0x7A82370", VA = "0x187A82F70")]
	public void DLPJJEPKDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7A86740", Offset = "0x7A85B40", VA = "0x187A86740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7A83860", Offset = "0x7A82C60", VA = "0x187A83860")]
	private void FJBCLDKAOPG(LLFANDOGFEF DAMFJFKKFBI, Mesh[] CIJMELELIGD, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x368F3C0", Offset = "0x368E7C0", VA = "0x18368F3C0")]
	private CALOLHJANKO<T> ONFOLIJBAAM<T>(BPDAEJGOKNH<T> MCJEECOKCKE, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG) where T : struct
	{
		return default(CALOLHJANKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7A85350", Offset = "0x7A84750", VA = "0x187A85350")]
	private void JADIBGMAOLA(Transform KLDFHLFOOFN, NativeArray<LMBNGOIEFEG> NJLOOJPPMDC, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7A82FA0", Offset = "0x7A823A0", VA = "0x187A82FA0")]
	private void EPKIMEJEDMP(Transform KLDFHLFOOFN, NativeArray<PLIBBGAMDFG> CNLGLMOHDHK, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7A83470", Offset = "0x7A82870", VA = "0x187A83470")]
	private void FBFBLGNNKAO(Transform KLDFHLFOOFN, NativeArray<NLAGLBIANPH> DJCGAHAAGIK, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7A84E90", Offset = "0x7A84290", VA = "0x187A84E90")]
	private void IBEDNHFJHBB(Transform KLDFHLFOOFN, NativeArray<HGLPLIFAFDI> CIJMELELIGD, Mesh[] BPMFKMANJPG, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7A82E20", Offset = "0x7A82220", VA = "0x187A82E20")]
	private static void CFBBPKMFKPE(NativeParallelHashSet<Entity> MGNIPLBHEJL, NativeParallelHashSet<Entity> IHMJBCEDPOB, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A82D60", Offset = "0x7A82160", VA = "0x187A82D60")]
	private static void AKHMIPIDNEF(NativeList<Entity> CEFIHBLEFNG, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7A857E0", Offset = "0x7A84BE0", VA = "0x187A857E0")]
	private NativeParallelHashMap<Entity, HINNAMACAJL> KLNLKAFNKKN(IKKKGOCGBMJ.MJPOOOCGELA BIPMFPNBIFM, JJCLFLALNEJ<JCMAPCLELBC> CNOBJIBBGLL, List<GameObject> NPBMKDFNJDI)
	{
		return default(NativeParallelHashMap<Entity, HINNAMACAJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7A856E0", Offset = "0x7A84AE0", VA = "0x187A856E0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JBHFGAGLFAO(Entity IIKPCHAEFMH)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7A84940", Offset = "0x7A83D40", VA = "0x187A84940")]
	private void HFPKFAHGNMB(NativeList<Entity> PEPFJGFANGJ, NativeList<Entity> ICGPDCKPPKE, NativeParallelHashMap<Entity, HINNAMACAJL> AOHPLKBFKOM, NativeList<GIEALLIDLLC> ANAKKIFFPMF, NativeList<NPAMCAHKLLB> EPNCABJBFLK, NativeList<DKDBDGDLMLP> EKMCCIJLEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7A86350", Offset = "0x7A85750", VA = "0x187A86350")]
	private void OIGOBHONHBB(NativeList<Entity> MGNIPLBHEJL, NativeList<Entity> BJDDDCDIDOP, NativeParallelHashMap<Entity, HINNAMACAJL> AOHPLKBFKOM, NativeList<PHNAPJNLONP> GDHGHDPELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7A75A50", Offset = "0x7A74E50", VA = "0x187A75A50")]
	public JJDIOALAJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class JOCBILJMKLD : MPBAFGGKFGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS CBDJEGLJELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly GNCDNFKLNJM KLDFHLFOOFN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject FAEODDGLMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS PFGIMHAADBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7A87B50", Offset = "0x7A86F50", VA = "0x187A87B50", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 JECDDBPEAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7A87A10", Offset = "0x7A86E10", VA = "0x187A87A10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 GHPHEIBOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7A87C80", Offset = "0x7A87080", VA = "0x187A87C80", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 BCFLNFALNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7A87A60", Offset = "0x7A86E60", VA = "0x187A87A60", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7A87C30", Offset = "0x7A87030", VA = "0x187A87C30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion LHEAMBFMKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7A87CD0", Offset = "0x7A870D0", VA = "0x187A87CD0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7A879C0", Offset = "0x7A86DC0", VA = "0x187A879C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 FJKGICMEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7A87B00", Offset = "0x7A86F00", VA = "0x187A87B00", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 AJGLFHJNIII
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7A87AB0", Offset = "0x7A86EB0", VA = "0x187A87AB0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 FONICMJLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7A87970", Offset = "0x7A86D70", VA = "0x187A87970", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A87D20", Offset = "0x7A87120", VA = "0x187A87D20")]
	public JOCBILJMKLD(UniformTRS CBDJEGLJELC, GNCDNFKLNJM KLDFHLFOOFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IBGHKANAKPN : JOCBILJMKLD, HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float DFDHCIFLIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 JBLCFMEMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly HHGCLPMBJBD OMKFPHEGFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly PDDOBMNCGIK CBFMFDPEENL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private FGCPOOOBBED CJPIGDLPEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7A803D0", Offset = "0x7A7F7D0", VA = "0x187A803D0", Slot = "17")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS HNACCOKCBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7A802A0", Offset = "0x7A7F6A0", VA = "0x187A802A0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float PNBOKOFDDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xB4D100", Offset = "0xB4C500", VA = "0x180B4D100", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 IFFCHLPIOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7A80380", Offset = "0x7A7F780", VA = "0x187A80380", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HHGCLPMBJBD AMKNNNJBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD9F9D0", Offset = "0xD9EDD0", VA = "0x180D9F9D0", Slot = "21")]
		get
		{
			return default(HHGCLPMBJBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private PDDOBMNCGIK AIDCFMKKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1254F50", Offset = "0x1254350", VA = "0x181254F50", Slot = "22")]
		get
		{
			return default(PDDOBMNCGIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool KEIJKIAJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MDHENJMFLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A80420", Offset = "0x7A7F820", VA = "0x187A80420")]
	protected IBGHKANAKPN(UniformTRS CBDJEGLJELC, GNCDNFKLNJM KLDFHLFOOFN, float DFDHCIFLIEL, float3 JBLCFMEMICC, HHGCLPMBJBD OMKFPHEGFHH, PDDOBMNCGIK CBFMFDPEENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class INFIJFJHPJM : MPBAFGGKFGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly ENLBBCIDMLB DAIIJGMPMAD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected GNCDNFKLNJM FBCEIDKHADO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x105F8E0", Offset = "0x105ECE0", VA = "0x18105F8E0")]
		get
		{
			return default(GNCDNFKLNJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity LPLOADAFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7A822D0", Offset = "0x7A816D0", VA = "0x187A822D0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected FFMBAKBAEBH KDKOHJBGCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7A82740", Offset = "0x7A81B40", VA = "0x187A82740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected CPKBNAFDHFF KHDICCDPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7A82430", Offset = "0x7A81830", VA = "0x187A82430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected PFILDGPEHDE OHDPAGFBDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A82150", Offset = "0x7A81550", VA = "0x187A82150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject FAEODDGLMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7A822F0", Offset = "0x7A816F0", VA = "0x187A822F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS PFGIMHAADBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x106B5C0", Offset = "0x106A9C0", VA = "0x18106B5C0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 JECDDBPEAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D40", Offset = "0x7A81140", VA = "0x187A81D40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 GHPHEIBOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7A82490", Offset = "0x7A81890", VA = "0x187A82490", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 BCFLNFALNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E30", Offset = "0x7A81230", VA = "0x187A81E30", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7A82320", Offset = "0x7A81720", VA = "0x187A82320", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion LHEAMBFMKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7A82620", Offset = "0x7A81A20", VA = "0x187A82620", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C30", Offset = "0x7A81030", VA = "0x187A81C30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 FJKGICMEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7A821E0", Offset = "0x7A815E0", VA = "0x187A821E0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 AJGLFHJNIII
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F90", Offset = "0x7A81390", VA = "0x187A81F90", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 FONICMJLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A70", Offset = "0x7A80E70", VA = "0x187A81A70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xD4E750", Offset = "0xD4DB50", VA = "0x180D4E750")]
	protected INFIJFJHPJM(ENLBBCIDMLB BMDNKFOGKPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7A81F60", Offset = "0x7A81360", VA = "0x187A81F60")]
	public static FGCPOOOBBED CLMIANKGGAM(INFIJFJHPJM OOLNPDLPIEB)
	{
		return default(FGCPOOOBBED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BHOEFHBFCAN
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7A72280", Offset = "0x7A71680", VA = "0x187A72280")]
	public static void DENGPINMFAB(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AIBKEKFPIIM
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7A71130", Offset = "0x7A70530", VA = "0x187A71130")]
	public static void IAEDFMFCNAB(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH, BCDHLHGCIBM PMDHHNHNPNG, FFMBAKBAEBH OIOENLJBCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7A71530", Offset = "0x7A70930", VA = "0x187A71530")]
	public static void MNMCIDGGFKD(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH, BCDHLHGCIBM PMDHHNHNPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7A71840", Offset = "0x7A70C40", VA = "0x187A71840")]
	public static NativeList<Entity> NCMFMDJPKMF(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7A71AE0", Offset = "0x7A70EE0", VA = "0x187A71AE0")]
	public static NativeList<Entity> OMGJOEOCPDF(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7A71880", Offset = "0x7A70C80", VA = "0x187A71880")]
	private static NativeList<Entity> NCMFMDJPKMF(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH, bool MFMDAEGCJMG)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class DCNEGHKEHPH : INFIJFJHPJM, HNHLMEHDPNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float DFDHCIFLIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 JBLCFMEMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private HHGCLPMBJBD OMKFPHEGFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private PDDOBMNCGIK CBFMFDPEENL;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager KNBPBBAEFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7A914F0", Offset = "0x7A908F0", VA = "0x187A914F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected OMJPGNMJFJE FGABMCEKFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7A913A0", Offset = "0x7A907A0", VA = "0x187A913A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData FGMIKJNLPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7A91400", Offset = "0x7A90800", VA = "0x187A91400")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private FGCPOOOBBED CJPIGDLPEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F60", Offset = "0x7A81360", VA = "0x187A81F60", Slot = "17")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PNBOKOFDDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xE36A60", Offset = "0xE35E60", VA = "0x180E36A60", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 IFFCHLPIOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x14D25F0", Offset = "0x14D19F0", VA = "0x1814D25F0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HHGCLPMBJBD AMKNNNJBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9A9220", Offset = "0x9A8620", VA = "0x1809A9220", Slot = "21")]
		get
		{
			return default(HHGCLPMBJBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private PDDOBMNCGIK AIDCFMKKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xBBE5D0", Offset = "0xBBD9D0", VA = "0x180BBE5D0", Slot = "22")]
		get
		{
			return default(PDDOBMNCGIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS HNACCOKCBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7A91370", Offset = "0x7A90770", VA = "0x187A91370", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MDHENJMFLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9D7F20", Offset = "0x9D7320", VA = "0x1809D7F20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9D7D40", Offset = "0x9D7140", VA = "0x1809D7D40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool KEIJKIAJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7A91710", Offset = "0x7A90B10", VA = "0x187A91710")]
	protected DCNEGHKEHPH(ENLBBCIDMLB BMDNKFOGKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A91580", Offset = "0x7A90980", VA = "0x187A91580", Slot = "26")]
	public virtual void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class DOJMHIHKINF : CPCJJCHJEHO, NOIGPCCMOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected FFMBAKBAEBH OIOENLJBCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private AKEIGEGKEAD CJADGLGGCKK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected BCDHLHGCIBM KFJCAENHDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7A91790", Offset = "0x7A90B90", VA = "0x187A91790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected NGAIKMOOEAO AHHKBDBKFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7A91740", Offset = "0x7A90B40", VA = "0x187A91740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool KDFLIOGIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7A917E0", Offset = "0x7A90BE0", VA = "0x187A917E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7A918A0", Offset = "0x7A90CA0", VA = "0x187A918A0", Slot = "15")]
	public virtual void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
	protected DOJMHIHKINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HLMJDFCNLOI
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7A91970", Offset = "0x7A90D70", VA = "0x187A91970")]
	public static void IEPAIAJIBJM(NativeArray<Entity> PEPFJGFANGJ, EntityManager MPNJFPGMBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1223169271
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7A91DE0", Offset = "0x7A911E0", VA = "0x187A91DE0")]
	public static void MNMBNDKFEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7A91DD0", Offset = "0x7A911D0", VA = "0x187A91DD0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class HKIKPNNOLIB : ContainerPropertyBag<DIBNEGMHILF>
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7A91910", Offset = "0x7A90D10", VA = "0x187A91910")]
	public HKIKPNNOLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class ADOKCBGAION : ContainerPropertyBag<CLOJCNCJEOF>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7A91310", Offset = "0x7A90710", VA = "0x187A91310")]
	public ADOKCBGAION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class OAGNLNLNJGN : ContainerPropertyBag<IIMKNJOCBLN>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7A91BB0", Offset = "0x7A90FB0", VA = "0x187A91BB0")]
	public OAGNLNLNJGN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7A91C10", Offset = "0x7A91010", VA = "0x187A91C10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
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
