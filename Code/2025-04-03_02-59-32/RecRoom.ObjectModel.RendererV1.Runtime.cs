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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A3C1F0", Offset = "0x7A3B5F0", VA = "0x187A3C1F0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F3DA80", Offset = "0x1F3CE80", VA = "0x181F3DA80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A43F10", Offset = "0x7A43310", VA = "0x187A43F10")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A444B0", Offset = "0x7A438B0", VA = "0x187A444B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A44510", Offset = "0x7A43910", VA = "0x187A44510")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FHIFCGAGECE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2ABA0", Offset = "0x7A29FA0", VA = "0x187A2ABA0")]
	public static Quaternion KDOHGNIDMMF([In] this KJFDPPPADNF DGNGPICABGM, [In] Vector3 GOMJGIJPEPD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CEDIMEONMJK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A28370", Offset = "0x7A27770", VA = "0x187A28370")]
	public static bool KMNOOHGIDEL(this DEPCJKEDPJM FNFDDMEMDEJ, AEPLEEMHJAE JKBGMEDEBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7A283B0", Offset = "0x7A277B0", VA = "0x187A283B0")]
	public static bool MBAHOEJPKOG(this DEPCJKEDPJM FNFDDMEMDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A283E0", Offset = "0x7A277E0", VA = "0x187A283E0")]
	public static bool PHMEIKOFIMK(this DEPCJKEDPJM FNFDDMEMDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A28020", Offset = "0x7A27420", VA = "0x187A28020")]
	public static void KBKDKKHMNND(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 NCHJEPMMCKG, Quaternion ABKEKEABNGD, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A26DD0", Offset = "0x7A261D0", VA = "0x187A26DD0")]
	public static void HGADFLPKNEF(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 NCHJEPMMCKG, Quaternion ABKEKEABNGD, float JAINCGFCEKN, int CFJEFFNMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A27060", Offset = "0x7A26460", VA = "0x187A27060")]
	public static void HGEIBABFDAD(this DEPCJKEDPJM FNFDDMEMDEJ, int CFJEFFNMBCH, Vector3 NCHJEPMMCKG, Quaternion ABKEKEABNGD, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A27FD0", Offset = "0x7A273D0", VA = "0x187A27FD0")]
	public static void JDCNMKIPLOL(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 GCJHJJNNDBO, Quaternion EGDLCIMPLDH, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A27180", Offset = "0x7A26580", VA = "0x187A27180")]
	private static void HHHJABJBOBH(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A26640", Offset = "0x7A25A40", VA = "0x187A26640")]
	private static void CALDNHFONCM(this DEPCJKEDPJM FNFDDMEMDEJ, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float CKJPKNDPHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A26910", Offset = "0x7A25D10", VA = "0x187A26910")]
	private static void DCBBLGCIKHO(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float CKJPKNDPHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A26B00", Offset = "0x7A25F00", VA = "0x187A26B00")]
	private static bool DOHBBEDOPEE(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A26B30", Offset = "0x7A25F30", VA = "0x187A26B30")]
	private static void HCGNCIKBIDL(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, float CKJPKNDPHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A27AE0", Offset = "0x7A26EE0", VA = "0x187A27AE0")]
	public static Vector3 IPEFFBBKKMK(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A26800", Offset = "0x7A25C00", VA = "0x187A26800")]
	public static Quaternion CDFPEKNOFOE(this DEPCJKEDPJM FNFDDMEMDEJ, int CJFNAFNJJLB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A28150", Offset = "0x7A27550", VA = "0x187A28150")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3AFD0", Offset = "0x7A3A3D0", VA = "0x187A3AFD0", Slot = "4")]
	public void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
	public FFLPACCLOMK(GPFFCLEGEBK DPGMLKFBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AA50", Offset = "0x7A29E50", VA = "0x187A2AA50", Slot = "4")]
	public void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class FNKHBGFNKOA : LALNCPAGEKP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AC80", Offset = "0x7A2A080", VA = "0x187A2AC80", Slot = "4")]
	public void ICAPENMGKHL(EntityQuery CNBDJCPJLHG, EntityManager MPNJFPGMBFH, AKEIGEGKEAD CJADGLGGCKK, BGHAFNKMMBO MBNJNBHHLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A3F800", Offset = "0x7A3EC00", VA = "0x187A3F800", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A3F880", Offset = "0x7A3EC80", VA = "0x187A3F880", Slot = "5")]
	public void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A3F580", Offset = "0x7A3E980", VA = "0x187A3F580", Slot = "6")]
	public void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A3F830", Offset = "0x7A3EC30", VA = "0x187A3F830", Slot = "7")]
	public void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A29EA0", Offset = "0x7A292A0", VA = "0x187A29EA0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A29F20", Offset = "0x7A29320", VA = "0x187A29F20", Slot = "5")]
	public void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A29C20", Offset = "0x7A29020", VA = "0x187A29C20", Slot = "6")]
	public void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A29ED0", Offset = "0x7A292D0", VA = "0x187A29ED0", Slot = "7")]
	public void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A35BD0", Offset = "0x7A34FD0", VA = "0x187A35BD0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A35C50", Offset = "0x7A35050", VA = "0x187A35C50", Slot = "5")]
	public void NMHDHGCNIPK(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A35950", Offset = "0x7A34D50", VA = "0x187A35950", Slot = "6")]
	public void AADACJNEODG(EntityQuery CNBDJCPJLHG, NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A35C00", Offset = "0x7A35000", VA = "0x187A35C00", Slot = "7")]
	public void NMAODHIMIKN(NGAIKMOOEAO JKLGAFJECFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A28D80", Offset = "0x7A28180", VA = "0x187A28D80", Slot = "15")]
	public virtual void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A28E10", Offset = "0x7A28210", VA = "0x187A28E10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C10", Offset = "0x7A28010", VA = "0x187A28C10")]
	private void ILGLDFCMIBD(EntityQueryDesc LEEGMHDKJLE, LALNCPAGEKP EOLHBGPOHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A29040", Offset = "0x7A28440", VA = "0x187A29040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A26190", Offset = "0x7A25590", VA = "0x187A26190", Slot = "14")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A26220", Offset = "0x7A25620", VA = "0x187A26220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A263A0", Offset = "0x7A257A0", VA = "0x187A263A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A25600", Offset = "0x7A24A00", VA = "0x187A25600")]
	private void HKCLDCJKHGF(LIIEKFGADJG JFFLKKNAOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A25A50", Offset = "0x7A24E50", VA = "0x187A25A50")]
	private void ILGLDFCMIBD(AJHKGOLCOLK PLNHAFIHCMN, ComponentType CBAHMAMKNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NIBPFMHDCCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A32FE0", Offset = "0x7A323E0", VA = "0x187A32FE0", Slot = "4")]
	public bool BDFAPKAEADC(ENLBBCIDMLB KJCJJFGLKEE, MMCAHBLJMAC FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A330C0", Offset = "0x7A324C0", VA = "0x187A330C0", Slot = "5")]
	public OIICOGMNAJO HEAPJCGBDMK()
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A33380", Offset = "0x7A32780", VA = "0x187A33380", Slot = "6")]
	public void PMEHGNAODFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A32F50", Offset = "0x7A32350", VA = "0x187A32F50", Slot = "7")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x107A190", Offset = "0x1079590", VA = "0x18107A190", Slot = "8")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public IBGAFDIOOCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(PDKFKKEFBFF), new string[] { })]
public class GONGPAPOBBK : PDKFKKEFBFF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D4F0", Offset = "0x7A2C8F0", VA = "0x187A2D4F0", Slot = "4")]
	public void CBEDDHEFHON(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D750", Offset = "0x7A2CB50", VA = "0x187A2D750", Slot = "5")]
	public void MJEJMCFOGGO(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D640", Offset = "0x7A2CA40", VA = "0x187A2D640", Slot = "6")]
	public ComponentSystemBase EKNDCMKBKCM(World AGLNINADJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D5E0", Offset = "0x7A2C9E0", VA = "0x187A2D5E0", Slot = "7")]
	public void EIDBIBJCLNF(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D690", Offset = "0x7A2CA90", VA = "0x187A2D690", Slot = "8")]
	public void IPHNGDBJAOC(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D6F0", Offset = "0x7A2CAF0", VA = "0x187A2D6F0", Slot = "9")]
	public void LGFILKFPCIO(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D570", Offset = "0x7A2C970", VA = "0x187A2D570", Slot = "10")]
	public void DLPJJEPKDMC(World AGLNINADJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CCF0", Offset = "0x7A2C0F0", VA = "0x187A2CCF0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> BCOFFAEBDIF()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A29BD0", Offset = "0x7A28FD0", VA = "0x187A29BD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A29B60", Offset = "0x7A28F60", VA = "0x187A29B60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A29230", Offset = "0x7A28630", VA = "0x187A29230", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A339C0", Offset = "0x7A32DC0", VA = "0x187A339C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A33950", Offset = "0x7A32D50", VA = "0x187A33950", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
		[Cpp2IlInjected.Address(RVA = "0xC71540", Offset = "0xC70940", VA = "0x180C71540", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0xB4AEB0", Offset = "0xB4A2B0", VA = "0x180B4AEB0", Slot = "28")]
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
		[Cpp2IlInjected.Address(RVA = "0xFAB0E0", Offset = "0xFAA4E0", VA = "0x180FAB0E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A32250", Offset = "0x7A31650", VA = "0x187A32250")]
	public HIONMKHHNAE(UniformTRS CBDJEGLJELC, GNCDNFKLNJM KLDFHLFOOFN, float DFDHCIFLIEL, float3 JBLCFMEMICC, HHGCLPMBJBD OMKFPHEGFHH, PDDOBMNCGIK CBFMFDPEENL, NANCINDJPCK NHIHPDFILIL, float3 JAIPPEBDKDH, bool BFOBKNHDOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A32200", Offset = "0x7A31600", VA = "0x187A32200", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A3FC70", Offset = "0x7A3F070", VA = "0x187A3FC70", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CIPMINOOIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A3FC90", Offset = "0x7A3F090", VA = "0x187A3FC90", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MNIKIPNBOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7A3FC80", Offset = "0x7A3F080", VA = "0x187A3FC80", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MPCKDJKFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xCDA490", Offset = "0xCD9890", VA = "0x180CDA490", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MMIPFNDLNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBE35E0", Offset = "0xBE29E0", VA = "0x180BE35E0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ANDHONEAKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE5EBC0", Offset = "0xE5DFC0", VA = "0x180E5EBC0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3FBC0", Offset = "0x7A3EFC0", VA = "0x187A3FBC0")]
	public ONNDNADDBKC(UniformTRS CBDJEGLJELC, GNCDNFKLNJM KLDFHLFOOFN, float DFDHCIFLIEL, float3 JBLCFMEMICC, HHGCLPMBJBD OMKFPHEGFHH, PDDOBMNCGIK CBFMFDPEENL, AEKEOCGFHPH MHBNBGGMEBA, float GKKGJNHJJOM, int OEHJNPNNGLB, NativeArray<NPAMCAHKLLB> BHJAABGCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xFC20A0", Offset = "0xFC14A0", VA = "0x180FC20A0", Slot = "33")]
	public NativeArray<NPAMCAHKLLB> GetNativeCurvePoints()
	{
		return default(NativeArray<NPAMCAHKLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7A3FB00", Offset = "0x7A3EF00", VA = "0x187A3FB00", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B27B0", Offset = "0x9B1BB0", VA = "0x1809B27B0", Slot = "28")]
		get
		{
			return default(NANCINDJPCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool MKGHPDMLNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD7CFA0", Offset = "0xD7C3A0", VA = "0x180D7CFA0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 IGDJHJNCEHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7A29A90", Offset = "0x7A28E90", VA = "0x187A29A90", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7A29A70", Offset = "0x7A28E70", VA = "0x187A29A70")]
	public DCNCPLNAHJG(ENLBBCIDMLB BMDNKFOGKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A293E0", Offset = "0x7A287E0", VA = "0x187A293E0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A29430", Offset = "0x7A28830", VA = "0x187A29430", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A2A480", Offset = "0x7A29880", VA = "0x187A2A480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FGCPOOOBBED IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A510", Offset = "0x7A29910", VA = "0x187A2A510", Slot = "15")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MIOMDMDHLED DAAEMKJBPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A8F0", Offset = "0x7A29CF0", VA = "0x187A2A8F0", Slot = "16")]
		get
		{
			return default(MIOMDMDHLED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A7A0", Offset = "0x7A29BA0", VA = "0x187A2A7A0")]
	public EOMCKKMGMON(ENLBBCIDMLB KJCJJFGLKEE, bool PLKIBKPEIMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A610", Offset = "0x7A29A10", VA = "0x187A2A610")]
	public void PKBMGCEHLEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A510", Offset = "0x7A29910", VA = "0x187A2A510")]
	protected FGCPOOOBBED MPNBKLHNMPH()
	{
		return default(FGCPOOOBBED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A300", Offset = "0x7A29700", VA = "0x187A2A300")]
	private static bool AJGAKKAJBEE(ENLBBCIDMLB LNKAJOLIAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A450", Offset = "0x7A29850", VA = "0x187A2A450", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xB583D0", Offset = "0xB577D0", VA = "0x180B583D0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool OOPOOEJDBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9E03C0", Offset = "0x9DF7C0", VA = "0x1809E03C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float PHANEAGKFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xF6EB50", Offset = "0xF6DF50", VA = "0x180F6EB50", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int JEEPNIFBAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC71540", Offset = "0xC70940", VA = "0x180C71540", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DFBJLGLMHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB4AEB0", Offset = "0xB4A2B0", VA = "0x180B4AEB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int BKEAFFCGLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2ADC0", Offset = "0x7A2A1C0", VA = "0x187A2ADC0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int APMABDPAOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B080", Offset = "0x7A2A480", VA = "0x187A2B080", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B6C0", Offset = "0x7A2AAC0", VA = "0x187A2B6C0")]
	public FOEHONKLPAC(ENLBBCIDMLB BMDNKFOGKPH, [Optional] NativeList<NPAMCAHKLLB> BHJAABGCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B5E0", Offset = "0x7A2A9E0", VA = "0x187A2B5E0", Slot = "26")]
	public override void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AF90", Offset = "0x7A2A390", VA = "0x187A2AF90", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B170", Offset = "0x7A2A570", VA = "0x187A2B170", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AF30", Offset = "0x7A2A330", VA = "0x187A2AF30")]
	public void CJLAFBGEEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B370", Offset = "0x7A2A770", VA = "0x187A2B370", Slot = "34")]
	public NativeArray<NPAMCAHKLLB> GetNativeCurvePoints()
	{
		return default(NativeArray<NPAMCAHKLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A2ADE0", Offset = "0x7A2A1E0", VA = "0x187A2ADE0", Slot = "35")]
	private Vector3 CFJDBBPBFEK(int NMAOAJDPHDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B540", Offset = "0x7A2A940", VA = "0x187A2B540", Slot = "36")]
	private Quaternion ICBLKOOACBN(int NMAOAJDPHDG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B1D0", Offset = "0x7A2A5D0", VA = "0x187A2B1D0", Slot = "37")]
	private float EOAIIEEKAGK(int NMAOAJDPHDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B570", Offset = "0x7A2A970", VA = "0x187A2B570")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A24F90", Offset = "0x7A24390", VA = "0x187A24F90", Slot = "15")]
	protected override ComponentSystemBase BPAGNBAPCJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7A253A0", Offset = "0x7A247A0", VA = "0x187A253A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A253B0", Offset = "0x7A247B0", VA = "0x187A253B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3B9D0", Offset = "0x7A3ADD0", VA = "0x187A3B9D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BD30", Offset = "0x7A3B130", VA = "0x187A3BD30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B1E0", Offset = "0x7A3A5E0", VA = "0x187A3B1E0")]
	private void BOMPGMGDNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B700", Offset = "0x7A3AB00", VA = "0x187A3B700")]
	private void JMGDOFBHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B520", Offset = "0x7A3A920", VA = "0x187A3B520")]
	private void FAFADCNKGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B870", Offset = "0x7A3AC70", VA = "0x187A3B870")]
	private void NPHCNGIJIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B420", Offset = "0x7A3A820", VA = "0x187A3B420")]
	private void EAIEJONFKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B970", Offset = "0x7A3AD70", VA = "0x187A3B970")]
	private NativeList<Entity> OMGJOEOCPDF(NativeArray<Entity> MGNIPLBHEJL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B810", Offset = "0x7A3AC10", VA = "0x187A3B810")]
	private NativeList<Entity> NCMFMDJPKMF(NativeArray<Entity> MGNIPLBHEJL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B3C0", Offset = "0x7A3A7C0", VA = "0x187A3B3C0")]
	private void CIFDBMDPKJK(NativeArray<Entity> MGNIPLBHEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A2CA60", Offset = "0x7A2BE60", VA = "0x187A2CA60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BF20", Offset = "0x7A2B320", VA = "0x187A2BF20", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CC30", Offset = "0x7A2C030", VA = "0x187A2CC30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C3E0", Offset = "0x7A2B7E0", VA = "0x187A2C3E0")]
	private void MFAFKAOEOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B8A0", Offset = "0x7A2ACA0", VA = "0x187A2B8A0")]
	private void CJAADLJGPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BF80", Offset = "0x7A2B380", VA = "0x187A2BF80")]
	private void KAIJHALLICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C340", Offset = "0x7A2B740", VA = "0x187A2C340")]
	private bool KHFDNGBDFDF(Entity GJIBJHOJMIG, [Out] OIICOGMNAJO BFGCMIGMIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B6F0", Offset = "0x7A2AAF0", VA = "0x187A2B6F0")]
	private bool CDMMPNGKLAI(Entity GJIBJHOJMIG, [Out] OIICOGMNAJO BFGCMIGMIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A28A00", Offset = "0x7A27E00", VA = "0x187A28A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A28B50", Offset = "0x7A27F50", VA = "0x187A28B50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A28700", Offset = "0x7A27B00", VA = "0x187A28700")]
	private void MFAFKAOEOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7A28410", Offset = "0x7A27810", VA = "0x187A28410")]
	private void CJAADLJGPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A2A280", Offset = "0x7A29680", VA = "0x187A2A280", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A1A0", Offset = "0x7A295A0", VA = "0x187A2A1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A33690", Offset = "0x7A32A90", VA = "0x187A33690", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A24C60", Offset = "0x7A24060", VA = "0x187A24C60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3D9A0", Offset = "0x7A3CDA0", VA = "0x187A3D9A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D340", Offset = "0x7A3C740", VA = "0x187A3D340", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A3DF20", Offset = "0x7A3D320", VA = "0x187A3DF20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C570", Offset = "0x7A3B970", VA = "0x187A3C570")]
	private void CCBELHLMCDC(NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC, int PMLBOABNEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D3A0", Offset = "0x7A3C7A0", VA = "0x187A3D3A0")]
	private void KFCIKNEJKHK(NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC, int ILGHELCHEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CF00", Offset = "0x7A3C300", VA = "0x187A3CF00")]
	private void GKGLAAJFBII(NativeParallelHashSet<OIICOGMNAJO> OGNDJEGLMJC, int NELIJDAFAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CB70", Offset = "0x7A3BF70", VA = "0x187A3CB70")]
	private void FEBEMEIJHLH(NativeParallelHashSet<OIICOGMNAJO> NGAKCHNEECE, int LGPOEPKCFLF, int NDECLKFKMLA, int BBDMLJGBDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A3D7F0", Offset = "0x7A3CBF0", VA = "0x187A3D7F0")]
	private void NPIJOEBOLNJ(Entity NOJEANLGDHM, LCIMFKFFNPO MLIJBDKMILB, OIICOGMNAJO BFGCMIGMIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3EA20", Offset = "0x7A3DE20", VA = "0x187A3EA20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7A3EC50", Offset = "0x7A3E050", VA = "0x187A3EC50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3E6B0", Offset = "0x7A3DAB0", VA = "0x187A3E6B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A3E7F0", Offset = "0x7A3DBF0", VA = "0x187A3E7F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A32490", Offset = "0x7A31890", VA = "0x187A32490", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A32830", Offset = "0x7A31C30", VA = "0x187A32830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A329C0", Offset = "0x7A31DC0", VA = "0x187A329C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x35FD170", Offset = "0x35FC570", VA = "0x1835FD170")]
	private void ILGLDFCMIBD<T>(LKIKPJPKFJI HLNBMJNKMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A324F0", Offset = "0x7A318F0", VA = "0x187A324F0")]
	private static void LPNLGMCGBLB(NativeArray<LCIMFKFFNPO> JGEIDAMJLAD, NGAIKMOOEAO PJMAPBNCCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A32690", Offset = "0x7A31A90", VA = "0x187A32690")]
	private static void OMFGNCCJHMM(NativeArray<LCIMFKFFNPO> JGEIDAMJLAD, NGAIKMOOEAO PJMAPBNCCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A322F0", Offset = "0x7A316F0", VA = "0x187A322F0")]
	private static void CEMLFMOLPPD(NativeArray<LCIMFKFFNPO> JGEIDAMJLAD, NGAIKMOOEAO PJMAPBNCCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3FCA0", Offset = "0x7A3F0A0", VA = "0x187A3FCA0", Slot = "13")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A35ED0", Offset = "0x7A352D0", VA = "0x187A35ED0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1692140", Offset = "0x1691540", VA = "0x181692140")]
		public MJPOOOCGELA(IKKKGOCGBMJ KLDFHLFOOFN, bool PCKPEJNLGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A3E2B0", Offset = "0x7A3D6B0", VA = "0x187A3E2B0")]
		public Queue<ILGKFLJPBNI>.Enumerator DBEEDGEHMMA()
		{
			return default(Queue<ILGKFLJPBNI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A3E370", Offset = "0x7A3D770", VA = "0x187A3E370", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A33DD0", Offset = "0x7A331D0", VA = "0x187A33DD0", Slot = "4")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A33FD0", Offset = "0x7A333D0", VA = "0x187A33FD0")]
	public void JKIIPIFEDJO(NativeList<NPAMCAHKLLB> NKAMAGDGADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A349A0", Offset = "0x7A33DA0", VA = "0x187A349A0")]
	public void OININFKLLJE(Entity KLDFHLFOOFN, [In] LEHDJFKJBJH<GameObject> DCJPAHNKGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A33AD0", Offset = "0x7A32ED0", VA = "0x187A33AD0")]
	public void CAADFKGLJNO(NativeList<LCIMFKFFNPO> JGEIDAMJLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A340A0", Offset = "0x7A334A0", VA = "0x187A340A0")]
	public void LGFILKFPCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A344F0", Offset = "0x7A338F0", VA = "0x187A344F0")]
	public void OBJDIHJDPFC(BCDHLHGCIBM HEKFIEJNOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A34370", Offset = "0x7A33770", VA = "0x187A34370")]
	public JobHandle MGJFKJEFHHK([In] ILGKFLJPBNI DAMFJFKKFBI, JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A342D0", Offset = "0x7A336D0", VA = "0x187A342D0")]
	public JobHandle MGJFKJEFHHK([In] JCMAPCLELBC DAMFJFKKFBI, JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x771A520", Offset = "0x7719920", VA = "0x18771A520")]
	public MJPOOOCGELA LEFNDJLOGOO(bool PCKPEJNLGIG)
	{
		return default(MJPOOOCGELA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A33A10", Offset = "0x7A32E10", VA = "0x187A33A10")]
	public JJCLFLALNEJ<JCMAPCLELBC> ABFNBPIOJPE()
	{
		return default(JJCLFLALNEJ<JCMAPCLELBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A33D80", Offset = "0x7A33180", VA = "0x187A33D80")]
	public JJCLFLALNEJ<LLFANDOGFEF> HFAFDDCJLKM()
	{
		return default(JJCLFLALNEJ<LLFANDOGFEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A33B60", Offset = "0x7A32F60", VA = "0x187A33B60")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A34410", Offset = "0x7A33810", VA = "0x187A34410", Slot = "5")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A33A60", Offset = "0x7A32E60", VA = "0x187A33A60", Slot = "6")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1087910", Offset = "0x1086D10", VA = "0x181087910", Slot = "7")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A34B90", Offset = "0x7A33F90", VA = "0x187A34B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A34BA0", Offset = "0x7A33FA0", VA = "0x187A34BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A33930", Offset = "0x7A32D30", VA = "0x187A33930", Slot = "4")]
	public void IEPBOELKOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7A338E0", Offset = "0x7A32CE0", VA = "0x187A338E0", Slot = "5")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1053D90", Offset = "0x1053190", VA = "0x181053D90", Slot = "6")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2D7A0", Offset = "0x7A2CBA0", VA = "0x187A2D7A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2DB40", Offset = "0x7A2CF40", VA = "0x187A2DB40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A292A0", Offset = "0x7A286A0", VA = "0x187A292A0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7A40140", Offset = "0x7A3F540", VA = "0x187A40140")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x7A400F0", Offset = "0x7A3F4F0", VA = "0x187A400F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A3BE00", Offset = "0x7A3B200", VA = "0x187A3BE00", Slot = "5")]
				public float3 IBIJCMHOBMH(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7A3C1B0", Offset = "0x7A3B5B0", VA = "0x187A3C1B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A3F250", Offset = "0x7A3E650", VA = "0x187A3F250", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2E830", Offset = "0x7A2DC30", VA = "0x187A2E830", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7A31290", Offset = "0x7A30690", VA = "0x187A31290")]
			private void PNCFCGGOMEK(NativeList<PointSrcData> srcData, NativeList<NPAMCAHKLLB> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7A30870", Offset = "0x7A2FC70", VA = "0x187A30870")]
			public static Vector3 LKLDNKHHKNC(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7A31180", Offset = "0x7A30580", VA = "0x187A31180")]
			public static quaternion NDICAGILEBN(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7A30640", Offset = "0x7A2FA40", VA = "0x187A30640")]
			private static quaternion KICMBLGHCPP(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7A30220", Offset = "0x7A2F620", VA = "0x187A30220")]
			private static float3 IOBFGKJPENE(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7A31200", Offset = "0x7A30600", VA = "0x187A31200")]
			private static quaternion PMGNHBELGGB(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7A2E260", Offset = "0x7A2D660", VA = "0x187A2E260")]
			private static NPAMCAHKLLB BFLDCPGMONF(int idx, NativeList<PointSrcData> srcData)
			{
				return default(NPAMCAHKLLB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x3D15410", Offset = "0x3D14810", VA = "0x183D15410")]
			private void BEHAKEOEIMA<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7A2EE90", Offset = "0x7A2E290", VA = "0x187A2EE90")]
			private void FGLPFGEFDCA(NativeList<PointSrcData> sourcePoints, NativeList<NPAMCAHKLLB> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7A304C0", Offset = "0x7A2F8C0", VA = "0x187A304C0")]
			public static float KCOHMFGNIEK(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7A2FCA0", Offset = "0x7A2F0A0", VA = "0x187A2FCA0")]
			private static quaternion GNMBHFCFELH(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7A2E680", Offset = "0x7A2DA80", VA = "0x187A2E680")]
			private static NPAMCAHKLLB ELJGBOAEMPJ(PointSrcData point)
			{
				return default(NPAMCAHKLLB);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2E7A0", Offset = "0x7A2DBA0", VA = "0x187A2E7A0")]
			private static NPAMCAHKLLB ELJGBOAEMPJ(float3 pos, quaternion rot, float radius)
			{
				return default(NPAMCAHKLLB);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7A310E0", Offset = "0x7A304E0", VA = "0x187A310E0")]
			private static bool MOEFACEPGCP(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7A303F0", Offset = "0x7A2F7F0", VA = "0x187A303F0")]
			private static float3 JNFBKPHIOGJ(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7A2E4D0", Offset = "0x7A2D8D0", VA = "0x187A2E4D0")]
			public static float3 BMGEHMKEFPE(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7A30070", Offset = "0x7A2F470", VA = "0x187A30070")]
			public static float3 IBIJCMHOBMH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7A30C80", Offset = "0x7A30080", VA = "0x187A30C80")]
			private static quaternion LLINDPGKHJD(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7A2FE90", Offset = "0x7A2F290", VA = "0x187A2FE90")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A42D50", Offset = "0x7A42150", VA = "0x187A42D50")]
			private void BGFDDGIIPDI(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7A42E30", Offset = "0x7A42230", VA = "0x187A42E30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A43B20", Offset = "0x7A42F20", VA = "0x187A43B20")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7A43B80", Offset = "0x7A42F80", VA = "0x187A43B80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A43AC0", Offset = "0x7A42EC0", VA = "0x187A43AC0")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7A43B10", Offset = "0x7A42F10", VA = "0x187A43B10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2DE80", Offset = "0x7A2D280", VA = "0x187A2DE80")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7A2E040", Offset = "0x7A2D440", VA = "0x187A2E040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2E050", Offset = "0x7A2D450", VA = "0x187A2E050")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7A2E250", Offset = "0x7A2D650", VA = "0x187A2E250", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A43690", Offset = "0x7A42A90", VA = "0x187A43690")]
			private void BGFDDGIIPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7A43AB0", Offset = "0x7A42EB0", VA = "0x187A43AB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A426C0", Offset = "0x7A41AC0", VA = "0x187A426C0", Slot = "15")]
		public override void InitReferences(BJMEEALALCJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A43340", Offset = "0x7A42740", VA = "0x187A43340", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A43430", Offset = "0x7A42830", VA = "0x187A43430", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A43490", Offset = "0x7A42890", VA = "0x187A43490", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A40BF0", Offset = "0x7A3FFF0", VA = "0x187A40BF0")]
		private JobHandle DILMLGFIMHE(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A416D0", Offset = "0x7A40AD0", VA = "0x187A416D0")]
		private JobHandle GHMAKFONIFM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A40160", Offset = "0x7A3F560", VA = "0x187A40160")]
		private JobHandle BILCFMMGCMO(NativeArray<int> pointCount, NativeList<NPAMCAHKLLB> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A41630", Offset = "0x7A40A30", VA = "0x187A41630")]
		private JobHandle HMOBEEMCGNH(NativeList<NPAMCAHKLLB> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A42880", Offset = "0x7A41C80", VA = "0x187A42880")]
		private JobHandle LOMKEONGFFJ(EntityQuery query, NativeList<GIEALLIDLLC> splinePointRanges, NativeList<NPAMCAHKLLB> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A42760", Offset = "0x7A41B60", VA = "0x187A42760")]
		private JobHandle KKCELLPPFCF(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A413C0", Offset = "0x7A407C0", VA = "0x187A413C0")]
		private JobHandle EHLALBMKDAD(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A404C0", Offset = "0x7A3F8C0", VA = "0x187A404C0")]
		private JobHandle DAKOBMKDHDF(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<PHNAPJNLONP> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A40200", Offset = "0x7A3F600", VA = "0x187A40200")]
		private JobHandle CKJKHCHOHMJ(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<GIEALLIDLLC> splinePointRanges, [Out] NativeList<DKDBDGDLMLP> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A40760", Offset = "0x7A3FB60", VA = "0x187A40760")]
		private JobHandle DCJNIFOFFBB(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A41D90", Offset = "0x7A41190", VA = "0x187A41D90")]
		private JobHandle HJKDMDFBFJE(EntityQuery query, NativeList<PHNAPJNLONP> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7A422A0", Offset = "0x7A416A0", VA = "0x187A422A0")]
		private static NativeParallelHashMap<int, NANCINDJPCK> IKADDLENIIH()
		{
			return default(NativeParallelHashMap<int, NANCINDJPCK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7A40F30", Offset = "0x7A40330", VA = "0x187A40F30")]
		private JobHandle DJCKFEHANLI(EntityQuery query, NativeList<GIEALLIDLLC> splinePointRanges, NativeList<NPAMCAHKLLB> splinePointData, NativeList<DKDBDGDLMLP> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7A42F20", Offset = "0x7A42320", VA = "0x187A42F20")]
		private JobHandle NAIFNLKFFNC(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A40160", Offset = "0x7A3F560", VA = "0x187A40160")]
		private JobHandle ACOOIIDFCDO(NativeArray<int> pointCount, NativeList<NPAMCAHKLLB> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7A41630", Offset = "0x7A40A30", VA = "0x187A41630")]
		private JobHandle GFLHNLLHDFK(NativeList<NPAMCAHKLLB> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7A412D0", Offset = "0x7A406D0", VA = "0x187A412D0")]
		private JobHandle EFGPKHPGNAO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<PHNAPJNLONP> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7A40AE0", Offset = "0x7A3FEE0", VA = "0x187A40AE0")]
		private JobHandle DDGBKALLFBA(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<GIEALLIDLLC> ranges, NativeList<DKDBDGDLMLP> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7A414E0", Offset = "0x7A408E0", VA = "0x187A414E0")]
		private JobHandle FNMGEOIOHBG(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7A43000", Offset = "0x7A42400", VA = "0x187A43000", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A3F1E0", Offset = "0x7A3E5E0", VA = "0x187A3F1E0", Slot = "14")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7A3F230", Offset = "0x7A3E630", VA = "0x187A3F230", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
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
			[Cpp2IlInjected.Address(RVA = "0x62FF1F0", Offset = "0x62FE5F0", VA = "0x1862FF1F0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x62FF910", Offset = "0x62FED10", VA = "0x1862FF910")]
		public CALOLHJANKO(EntityManager MPNJFPGMBFH, BPDAEJGOKNH<T> MCJEECOKCKE, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x437F830", Offset = "0x437EC30", VA = "0x18437F830")]
		public CALOLHJANKO<T> DBEEDGEHMMA()
		{
			return default(CALOLHJANKO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x62FEED0", Offset = "0x62FE2D0", VA = "0x1862FEED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A38510", Offset = "0x7A37910", VA = "0x187A38510", Slot = "15")]
	public override void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7A36170", Offset = "0x7A35570", VA = "0x187A36170")]
	public void DLPJJEPKDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7A39990", Offset = "0x7A38D90", VA = "0x187A39990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7A36A60", Offset = "0x7A35E60", VA = "0x187A36A60")]
	private void FJBCLDKAOPG(LLFANDOGFEF DAMFJFKKFBI, Mesh[] CIJMELELIGD, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x367BFA0", Offset = "0x367B3A0", VA = "0x18367BFA0")]
	private CALOLHJANKO<T> ONFOLIJBAAM<T>(BPDAEJGOKNH<T> MCJEECOKCKE, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG) where T : struct
	{
		return default(CALOLHJANKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7A38590", Offset = "0x7A37990", VA = "0x187A38590")]
	private void JADIBGMAOLA(Transform KLDFHLFOOFN, NativeArray<LMBNGOIEFEG> NJLOOJPPMDC, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7A361A0", Offset = "0x7A355A0", VA = "0x187A361A0")]
	private void EPKIMEJEDMP(Transform KLDFHLFOOFN, NativeArray<PLIBBGAMDFG> CNLGLMOHDHK, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7A36670", Offset = "0x7A35A70", VA = "0x187A36670")]
	private void FBFBLGNNKAO(Transform KLDFHLFOOFN, NativeArray<NLAGLBIANPH> DJCGAHAAGIK, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7A380D0", Offset = "0x7A374D0", VA = "0x187A380D0")]
	private void IBEDNHFJHBB(Transform KLDFHLFOOFN, NativeArray<HGLPLIFAFDI> CIJMELELIGD, Mesh[] BPMFKMANJPG, LEHDJFKJBJH<GameObject> NPBMKDFNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7A36020", Offset = "0x7A35420", VA = "0x187A36020")]
	private static void CFBBPKMFKPE(NativeParallelHashSet<Entity> MGNIPLBHEJL, NativeParallelHashSet<Entity> IHMJBCEDPOB, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A35F60", Offset = "0x7A35360", VA = "0x187A35F60")]
	private static void AKHMIPIDNEF(NativeList<Entity> CEFIHBLEFNG, NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7A38A30", Offset = "0x7A37E30", VA = "0x187A38A30")]
	private NativeParallelHashMap<Entity, HINNAMACAJL> KLNLKAFNKKN(IKKKGOCGBMJ.MJPOOOCGELA BIPMFPNBIFM, JJCLFLALNEJ<JCMAPCLELBC> CNOBJIBBGLL, List<GameObject> NPBMKDFNJDI)
	{
		return default(NativeParallelHashMap<Entity, HINNAMACAJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7A38930", Offset = "0x7A37D30", VA = "0x187A38930")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JBHFGAGLFAO(Entity IIKPCHAEFMH)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7A37B80", Offset = "0x7A36F80", VA = "0x187A37B80")]
	private void HFPKFAHGNMB(NativeList<Entity> PEPFJGFANGJ, NativeList<Entity> ICGPDCKPPKE, NativeParallelHashMap<Entity, HINNAMACAJL> AOHPLKBFKOM, NativeList<GIEALLIDLLC> ANAKKIFFPMF, NativeList<NPAMCAHKLLB> EPNCABJBFLK, NativeList<DKDBDGDLMLP> EKMCCIJLEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7A395A0", Offset = "0x7A389A0", VA = "0x187A395A0")]
	private void OIGOBHONHBB(NativeList<Entity> MGNIPLBHEJL, NativeList<Entity> BJDDDCDIDOP, NativeParallelHashMap<Entity, HINNAMACAJL> AOHPLKBFKOM, NativeList<PHNAPJNLONP> GDHGHDPELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C00", Offset = "0x7A28000", VA = "0x187A28C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS PFGIMHAADBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7A3ADB0", Offset = "0x7A3A1B0", VA = "0x187A3ADB0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 JECDDBPEAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AC70", Offset = "0x7A3A070", VA = "0x187A3AC70", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 GHPHEIBOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AEE0", Offset = "0x7A3A2E0", VA = "0x187A3AEE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 BCFLNFALNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7A3ACC0", Offset = "0x7A3A0C0", VA = "0x187A3ACC0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AE90", Offset = "0x7A3A290", VA = "0x187A3AE90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion LHEAMBFMKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AF30", Offset = "0x7A3A330", VA = "0x187A3AF30", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AC20", Offset = "0x7A3A020", VA = "0x187A3AC20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 FJKGICMEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AD60", Offset = "0x7A3A160", VA = "0x187A3AD60", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 AJGLFHJNIII
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AD10", Offset = "0x7A3A110", VA = "0x187A3AD10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 FONICMJLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7A3ABD0", Offset = "0x7A39FD0", VA = "0x187A3ABD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AF80", Offset = "0x7A3A380", VA = "0x187A3AF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A335C0", Offset = "0x7A329C0", VA = "0x187A335C0", Slot = "17")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS HNACCOKCBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7A33490", Offset = "0x7A32890", VA = "0x187A33490", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float PNBOKOFDDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xB45BB0", Offset = "0xB44FB0", VA = "0x180B45BB0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 IFFCHLPIOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7A33570", Offset = "0x7A32970", VA = "0x187A33570", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HHGCLPMBJBD AMKNNNJBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD9B050", Offset = "0xD9A450", VA = "0x180D9B050", Slot = "21")]
		get
		{
			return default(HHGCLPMBJBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private PDDOBMNCGIK AIDCFMKKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE63400", Offset = "0xE62800", VA = "0x180E63400", Slot = "22")]
		get
		{
			return default(PDDOBMNCGIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool KEIJKIAJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MDHENJMFLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A33610", Offset = "0x7A32A10", VA = "0x187A33610")]
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
		[Cpp2IlInjected.Address(RVA = "0x1056AE0", Offset = "0x1055EE0", VA = "0x181056AE0")]
		get
		{
			return default(GNCDNFKLNJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity LPLOADAFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7A354D0", Offset = "0x7A348D0", VA = "0x187A354D0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected FFMBAKBAEBH KDKOHJBGCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7A35940", Offset = "0x7A34D40", VA = "0x187A35940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected CPKBNAFDHFF KHDICCDPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7A35630", Offset = "0x7A34A30", VA = "0x187A35630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected PFILDGPEHDE OHDPAGFBDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A35350", Offset = "0x7A34750", VA = "0x187A35350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject FAEODDGLMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7A354F0", Offset = "0x7A348F0", VA = "0x187A354F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS PFGIMHAADBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x107D030", Offset = "0x107C430", VA = "0x18107D030", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 JECDDBPEAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7A34F40", Offset = "0x7A34340", VA = "0x187A34F40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 GHPHEIBOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7A35690", Offset = "0x7A34A90", VA = "0x187A35690", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 BCFLNFALNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7A35030", Offset = "0x7A34430", VA = "0x187A35030", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7A35520", Offset = "0x7A34920", VA = "0x187A35520", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion LHEAMBFMKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7A35820", Offset = "0x7A34C20", VA = "0x187A35820", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7A34E30", Offset = "0x7A34230", VA = "0x187A34E30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 FJKGICMEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7A353E0", Offset = "0x7A347E0", VA = "0x187A353E0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 AJGLFHJNIII
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7A35190", Offset = "0x7A34590", VA = "0x187A35190", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 FONICMJLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7A34C70", Offset = "0x7A34070", VA = "0x187A34C70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xD49A10", Offset = "0xD48E10", VA = "0x180D49A10")]
	protected INFIJFJHPJM(ENLBBCIDMLB BMDNKFOGKPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7A35160", Offset = "0x7A34560", VA = "0x187A35160")]
	public static FGCPOOOBBED CLMIANKGGAM(INFIJFJHPJM OOLNPDLPIEB)
	{
		return default(FGCPOOOBBED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BHOEFHBFCAN
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7A253C0", Offset = "0x7A247C0", VA = "0x187A253C0")]
	public static void DENGPINMFAB(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AIBKEKFPIIM
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7A24270", Offset = "0x7A23670", VA = "0x187A24270")]
	public static void IAEDFMFCNAB(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH, BCDHLHGCIBM PMDHHNHNPNG, FFMBAKBAEBH OIOENLJBCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7A24670", Offset = "0x7A23A70", VA = "0x187A24670")]
	public static void MNMCIDGGFKD(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH, BCDHLHGCIBM PMDHHNHNPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7A24980", Offset = "0x7A23D80", VA = "0x187A24980")]
	public static NativeList<Entity> NCMFMDJPKMF(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7A24C20", Offset = "0x7A24020", VA = "0x187A24C20")]
	public static NativeList<Entity> OMGJOEOCPDF(NativeArray<Entity> MGNIPLBHEJL, EntityManager MPNJFPGMBFH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7A249C0", Offset = "0x7A23DC0", VA = "0x187A249C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A447F0", Offset = "0x7A43BF0", VA = "0x187A447F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected OMJPGNMJFJE FGABMCEKFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7A446A0", Offset = "0x7A43AA0", VA = "0x187A446A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData FGMIKJNLPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7A44700", Offset = "0x7A43B00", VA = "0x187A44700")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private FGCPOOOBBED CJPIGDLPEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7A35160", Offset = "0x7A34560", VA = "0x187A35160", Slot = "17")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PNBOKOFDDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xE322F0", Offset = "0xE316F0", VA = "0x180E322F0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 IFFCHLPIOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x14B4320", Offset = "0x14B3720", VA = "0x1814B4320", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HHGCLPMBJBD AMKNNNJBMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x993220", Offset = "0x992620", VA = "0x180993220", Slot = "21")]
		get
		{
			return default(HHGCLPMBJBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private PDDOBMNCGIK AIDCFMKKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xBB7280", Offset = "0xBB6680", VA = "0x180BB7280", Slot = "22")]
		get
		{
			return default(PDDOBMNCGIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS HNACCOKCBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7A44670", Offset = "0x7A43A70", VA = "0x187A44670", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MDHENJMFLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9C1F60", Offset = "0x9C1360", VA = "0x1809C1F60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D80", Offset = "0x9C1180", VA = "0x1809C1D80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool KEIJKIAJHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7A44A10", Offset = "0x7A43E10", VA = "0x187A44A10")]
	protected DCNEGHKEHPH(ENLBBCIDMLB BMDNKFOGKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A44880", Offset = "0x7A43C80", VA = "0x187A44880", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A44A90", Offset = "0x7A43E90", VA = "0x187A44A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected NGAIKMOOEAO AHHKBDBKFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7A44A40", Offset = "0x7A43E40", VA = "0x187A44A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool KDFLIOGIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7A44AE0", Offset = "0x7A43EE0", VA = "0x187A44AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7A44BA0", Offset = "0x7A43FA0", VA = "0x187A44BA0", Slot = "15")]
	public virtual void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
	protected DOJMHIHKINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HLMJDFCNLOI
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7A44C70", Offset = "0x7A44070", VA = "0x187A44C70")]
	public static void IEPAIAJIBJM(NativeArray<Entity> PEPFJGFANGJ, EntityManager MPNJFPGMBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1248356613
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7A450E0", Offset = "0x7A444E0", VA = "0x187A450E0")]
	public static void MNMBNDKFEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7A450D0", Offset = "0x7A444D0", VA = "0x187A450D0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class HKIKPNNOLIB : ContainerPropertyBag<DIBNEGMHILF>
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7A44C10", Offset = "0x7A44010", VA = "0x187A44C10")]
	public HKIKPNNOLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class ADOKCBGAION : ContainerPropertyBag<CLOJCNCJEOF>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7A44610", Offset = "0x7A43A10", VA = "0x187A44610")]
	public ADOKCBGAION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class OAGNLNLNJGN : ContainerPropertyBag<IIMKNJOCBLN>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7A44EB0", Offset = "0x7A442B0", VA = "0x187A44EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A44F10", Offset = "0x7A44310", VA = "0x187A44F10")]
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
