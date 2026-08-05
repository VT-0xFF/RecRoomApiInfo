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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81AD4B0", Offset = "0x81ABAB0", VA = "0x1881AD4B0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8166190", Offset = "0x8164790", VA = "0x188166190", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81BC640", Offset = "0x81BAC40", VA = "0x1881BC640")]
		private void FKDKBEPAOOM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81BCBD0", Offset = "0x81BB1D0", VA = "0x1881BCBD0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC30", Offset = "0x81BB230", VA = "0x1881BCC30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IBDIFABFODN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81A7640", Offset = "0x81A5C40", VA = "0x1881A7640")]
	public static Quaternion IJOLOHGJPAP([In] this HMOFNAAGPNJ HNBFFELCEIN, [In] Vector3 GJGHBLDDKFD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KKPLDIPJLEF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81A9720", Offset = "0x81A7D20", VA = "0x1881A9720")]
	public static bool CFODACCEBFM(this KJHAHBCOJIM HPDPKHBCCGD, PMDGEEGMAGC MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81AA6E0", Offset = "0x81A8CE0", VA = "0x1881AA6E0")]
	public static bool KIPALPGNGNC(this KJHAHBCOJIM HPDPKHBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81AA2E0", Offset = "0x81A88E0", VA = "0x1881AA2E0")]
	public static bool JIFLGKOHGJE(this KJHAHBCOJIM HPDPKHBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x81AA5B0", Offset = "0x81A8BB0", VA = "0x1881AA5B0")]
	public static void KABLEKADLNO(this KJHAHBCOJIM HPDPKHBCCGD, Vector3 JGKLAIMLLDP, Quaternion OINPBPGDPBB, float OFCEKCJNBGJ, bool LFFGHPJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x81AA8D0", Offset = "0x81A8ED0", VA = "0x1881AA8D0")]
	public static void OAFFGGIHLMM(this KJHAHBCOJIM HPDPKHBCCGD, Vector3 JGKLAIMLLDP, Quaternion OINPBPGDPBB, float OFCEKCJNBGJ, int OKFKJJIDJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81AAB60", Offset = "0x81A9160", VA = "0x1881AAB60")]
	public static void OHPDEAENEDK(this KJHAHBCOJIM HPDPKHBCCGD, int OKFKJJIDJJE, Vector3 JGKLAIMLLDP, Quaternion OINPBPGDPBB, float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x81A94B0", Offset = "0x81A7AB0", VA = "0x1881A94B0")]
	public static void AEFPPDDAJMI(this KJHAHBCOJIM HPDPKHBCCGD, Vector3 NAJEGELKMGJ, Quaternion ONPIOODBBPJ, float OFCEKCJNBGJ, bool LFFGHPJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81A9760", Offset = "0x81A7D60", VA = "0x1881A9760")]
	private static void FOFNIMEPKHD(this KJHAHBCOJIM HPDPKHBCCGD, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float OFCEKCJNBGJ, bool LFFGHPJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81AA710", Offset = "0x81A8D10", VA = "0x1881AA710")]
	private static void NEJCICOHLPL(this KJHAHBCOJIM HPDPKHBCCGD, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII, float MDGGGOBDBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81AA0F0", Offset = "0x81A86F0", VA = "0x1881AA0F0")]
	private static void INGHMDMMPOD(this KJHAHBCOJIM HPDPKHBCCGD, int KHMHPNKMLMD, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII, float MDGGGOBDBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81AA0C0", Offset = "0x81A86C0", VA = "0x1881AA0C0")]
	private static bool GAGFCACOMON(this KJHAHBCOJIM HPDPKHBCCGD, int KHMHPNKMLMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81AA310", Offset = "0x81A8910", VA = "0x1881AA310")]
	private static void JKNKCLCHDFO(this KJHAHBCOJIM HPDPKHBCCGD, int KHMHPNKMLMD, Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII, float MDGGGOBDBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81AAC80", Offset = "0x81A9280", VA = "0x1881AAC80")]
	public static Vector3 OPOKOKODNJK(this KJHAHBCOJIM HPDPKHBCCGD, int KHMHPNKMLMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81AB170", Offset = "0x81A9770", VA = "0x1881AB170")]
	public static Quaternion PMCOOJCDFAF(this KJHAHBCOJIM HPDPKHBCCGD, int KHMHPNKMLMD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81A9500", Offset = "0x81A7B00", VA = "0x1881A9500")]
	public static Vector3 CEMPMAIBAKJ(PMDGEEGMAGC ENCLHPAOMCM, Vector3 NHLFNDFGAHK, Vector3? FNGFNNLOHBC, Vector3 KCINGJPCGAK)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface LNGEBEOOLKH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGAJKDMONCC(EntityQuery GBEHOCFFBIL, EntityManager MAHCJNEKFMD, CDNLMHPNODP ILIOCACLGDN, CCMHHMMNBHB OENGCLBNANI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface AIFGBJKMGJA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType NLOFCKEDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAMDDGNNOGB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EONMMHDGELB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CLKFHDIGEFC(GIELKEINIAC IDOJBJFNNFA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OJLGAIKKIOF : LNGEBEOOLKH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81B7DB0", Offset = "0x81B63B0", VA = "0x1881B7DB0", Slot = "4")]
	public void GGAJKDMONCC(EntityQuery GBEHOCFFBIL, EntityManager MAHCJNEKFMD, CDNLMHPNODP ILIOCACLGDN, CCMHHMMNBHB OENGCLBNANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OJLGAIKKIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class HFFLFDHKGGL : LNGEBEOOLKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MNGEOBFFJGB BIHFHFIFIHD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
	public HFFLFDHKGGL(MNGEOBFFJGB BIHFHFIFIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81A6ED0", Offset = "0x81A54D0", VA = "0x1881A6ED0", Slot = "4")]
	public void GGAJKDMONCC(EntityQuery GBEHOCFFBIL, EntityManager MAHCJNEKFMD, CDNLMHPNODP ILIOCACLGDN, CCMHHMMNBHB OENGCLBNANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class HNDEEKMGNFF : LNGEBEOOLKH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81A7500", Offset = "0x81A5B00", VA = "0x1881A7500", Slot = "4")]
	public void GGAJKDMONCC(EntityQuery GBEHOCFFBIL, EntityManager MAHCJNEKFMD, CDNLMHPNODP ILIOCACLGDN, CCMHHMMNBHB OENGCLBNANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HNDEEKMGNFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OAFMOCHFMOE : AIFGBJKMGJA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType NLOFCKEDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81B3160", Offset = "0x81B1760", VA = "0x1881B3160", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81B2C10", Offset = "0x81B1210", VA = "0x1881B2C10", Slot = "5")]
	public void BAMDDGNNOGB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81B2EE0", Offset = "0x81B14E0", VA = "0x1881B2EE0", Slot = "6")]
	public void EONMMHDGELB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81B2E90", Offset = "0x81B1490", VA = "0x1881B2E90", Slot = "7")]
	public void CLKFHDIGEFC(GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OAFMOCHFMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GBHPLBKBFAA : AIFGBJKMGJA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType NLOFCKEDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81A21A0", Offset = "0x81A07A0", VA = "0x1881A21A0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81A1C50", Offset = "0x81A0250", VA = "0x1881A1C50", Slot = "5")]
	public void BAMDDGNNOGB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81A1F20", Offset = "0x81A0520", VA = "0x1881A1F20", Slot = "6")]
	public void EONMMHDGELB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81A1ED0", Offset = "0x81A04D0", VA = "0x1881A1ED0", Slot = "7")]
	public void CLKFHDIGEFC(GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GBHPLBKBFAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ELODNOMDPHD : AIFGBJKMGJA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType NLOFCKEDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81A0CB0", Offset = "0x819F2B0", VA = "0x1881A0CB0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81A0760", Offset = "0x819ED60", VA = "0x1881A0760", Slot = "5")]
	public void BAMDDGNNOGB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81A0A30", Offset = "0x819F030", VA = "0x1881A0A30", Slot = "6")]
	public void EONMMHDGELB(EntityQuery GBEHOCFFBIL, GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81A09E0", Offset = "0x819EFE0", VA = "0x1881A09E0", Slot = "7")]
	public void CLKFHDIGEFC(GIELKEINIAC IDOJBJFNNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ELODNOMDPHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FODACNPCMHC : JBGFFILIMFO, JPODKHCGMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CDNLMHPNODP ILIOCACLGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LGFOOLKGBCJ OEBPBHJCADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CCMHHMMNBHB OENGCLBNANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, LNGEBEOOLKH adapter)> EDHLLPPFEJJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81A0CE0", Offset = "0x819F2E0", VA = "0x1881A0CE0", Slot = "15")]
	public virtual void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81A0ED0", Offset = "0x819F4D0", VA = "0x1881A0ED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81A0D70", Offset = "0x819F370", VA = "0x1881A0D70")]
	private void JNAMGGOKKNP(EntityQueryDesc NFECJEGEHFA, LNGEBEOOLKH FNAIEELFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81A1100", Offset = "0x819F700", VA = "0x1881A1100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
	public FODACNPCMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class BNFDPKGIJBF : JBGFFILIMFO, JPODKHCGMPE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class JKMHGNKANJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery FJEHMHCFNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery JKCBCJPIBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery OGLGFKDHBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery EBDDCDCJFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery KGDFDEFMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery IIADMHHEEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery DOCEHMELJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AIFGBJKMGJA PAJPKIGAGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType HOJHEOPFGIO;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JKMHGNKANJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CDNLMHPNODP ILIOCACLGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CCMHHMMNBHB OENGCLBNANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private LGFOOLKGBCJ OEBPBHJCADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<JKMHGNKANJN> EDHLLPPFEJJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x819F620", Offset = "0x819DC20", VA = "0x18819F620", Slot = "14")]
	public void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x819FDF0", Offset = "0x819E3F0", VA = "0x18819FDF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x819FF70", Offset = "0x819E570", VA = "0x18819FF70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x819F1D0", Offset = "0x819D7D0", VA = "0x18819F1D0")]
	private void GOHLNLALJJH(JKMHGNKANJN EMCGJDAMKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x819F6B0", Offset = "0x819DCB0", VA = "0x18819F6B0")]
	private void JNAMGGOKKNP(AIFGBJKMGJA PAJPKIGAGJA, ComponentType NPFPKLACFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
	public BNFDPKGIJBF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct DGANAPLFEBE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct CKDPFHHIPGN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct LPNOGEFBDNA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(CCMHHMMNBHB), new string[] { })]
public class CPOIGDFHMMG : CCMHHMMNBHB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CPCDDMBJLPC PENKEHCAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CPCDDMBJLPC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CPOIGDFHMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(PAODCFCHNKD), new string[] { })]
public class MOKMLGCMBPM : PAODCFCHNKD, KKCPJDIALJD, IJNPAMHNAJF, IELEAPKDCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private MCNADDNPOAH JLOAJOGDOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private CDNLMHPNODP ILIOCACLGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private NNEPMGCDLOI LONKPMILJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity LNIOONFJCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private OMKHNGNFNIM DNMJJLEMILG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x81AFEE0", Offset = "0x81AE4E0", VA = "0x1881AFEE0", Slot = "4")]
	public bool FCNMACGPLBD(DAHJHHJGHIB OHGBPBLOAKN, BPPBNOIINPP KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x81B0050", Offset = "0x81AE650", VA = "0x1881B0050", Slot = "5")]
	public OMKHNGNFNIM HFNBFENMEBO()
	{
		return default(OMKHNGNFNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x81B0310", Offset = "0x81AE910", VA = "0x1881B0310", Slot = "6")]
	public void OBGIKBGDGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x81AFFC0", Offset = "0x81AE5C0", VA = "0x1881AFFC0", Slot = "7")]
	private void FNAOMNCODMK(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x124D5B0", Offset = "0x124BBB0", VA = "0x18124D5B0", Slot = "8")]
	private void MPJIHLCOJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MOKMLGCMBPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(GIMNLGKEBAI), new string[] { })]
public class LHAILGIDGJO : GIMNLGKEBAI
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81ABFE0", Offset = "0x81AA5E0", VA = "0x1881ABFE0", Slot = "4")]
	public void GCGGKGBDFIP(World JLOAJOGDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81AB640", Offset = "0x81A9C40", VA = "0x1881AB640", Slot = "5")]
	public void CGCOMDBCKFI(World JLOAJOGDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81AB5F0", Offset = "0x81A9BF0", VA = "0x1881AB5F0", Slot = "6")]
	public ComponentSystemBase AGDEBKFIGIM(World JLOAJOGDOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81ABF20", Offset = "0x81AA520", VA = "0x1881ABF20", Slot = "7")]
	public void FBFLMKFIEEC(World JLOAJOGDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81ABF80", Offset = "0x81AA580", VA = "0x1881ABF80", Slot = "8")]
	public void GBECOJEEPMH(World JLOAJOGDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81ABEC0", Offset = "0x81AA4C0", VA = "0x1881ABEC0", Slot = "9")]
	public void EKOIMPLPGKD(World JLOAJOGDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81AC060", Offset = "0x81AA660", VA = "0x1881AC060", Slot = "10")]
	public void KIMHLNGOGFM(World JLOAJOGDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81AB690", Offset = "0x81A9C90", VA = "0x1881AB690", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> EDMGHCMEOPL()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LHAILGIDGJO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct JGHHEAEMBAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct CMELKAJNLOG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IBHBFJGECJL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HLGMNJHBLBJ FPAAJJOILIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81A7790", Offset = "0x81A5D90", VA = "0x1881A7790", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81A7720", Offset = "0x81A5D20", VA = "0x1881A7720", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IBHBFJGECJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct EKAEAEHFGAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OMKHNGNFNIM BIGFNMKLPPC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static EKAEAEHFGAK EIMKEBEILPD(OMKHNGNFNIM MNCGAKBHIPL)
	{
		return default(EKAEAEHFGAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EGOJLCJCMPB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BJELADJEHBH AMDBPNDKEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x81A0680", Offset = "0x819EC80", VA = "0x1881A0680", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EGOJLCJCMPB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct AINGBKPGDDL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct FHCBLAKNFAB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public FINIDNMFGON ELCDKFPIKKI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static FHCBLAKNFAB EIMKEBEILPD(FINIDNMFGON MNCGAKBHIPL)
	{
		return default(FHCBLAKNFAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct LBKELNAJHHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OMKHNGNFNIM BIGFNMKLPPC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static LBKELNAJHHK EIMKEBEILPD(OMKHNGNFNIM MNCGAKBHIPL)
	{
		return default(LBKELNAJHHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MDCFOJGGMEC : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MGNNCINACHN CGGMNFHDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81AD8A0", Offset = "0x81ABEA0", VA = "0x1881AD8A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81AD830", Offset = "0x81ABE30", VA = "0x1881AD830", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MDCFOJGGMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BBEDDCFFGBM : GLODIFGJKFO, HLGMNJHBLBJ, EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ACIKMAHKONI LEGCMAEMLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xDF43F0", Offset = "0xDF29F0", VA = "0x180DF43F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(ACIKMAHKONI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FFCDDOFMKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xCBDA20", Offset = "0xCBC020", VA = "0x180CBDA20", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 PEIMCNIPOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1181360", Offset = "0x117F960", VA = "0x181181360", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x819EBD0", Offset = "0x819D1D0", VA = "0x18819EBD0")]
	public BBEDDCFFGBM(UniformTRS MBJBMIJGMFK, MFPEINJHCFE NBIJLPJHNNE, float NACCPECNNNM, float3 LLGLGHLLEKA, NGNKOEFODLB AIEJDPLDOCH, FFLLKLIPNGD BEOLCFMBDBJ, ACIKMAHKONI FBOFKEOBJPN, float3 GOACPAIEJHO, bool BNPDDPNHOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x819EB80", Offset = "0x819D180", VA = "0x18819EB80", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FPDLILOEFBM : GLODIFGJKFO, MGNNCINACHN, EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<FEALKEEJBEM> KFFBHNPIBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KMBJIMLIGNC MJNKOFMOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float CDLAHGBCNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int BKDJHBCCJGN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IOLHOBJHBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81A1460", Offset = "0x819FA60", VA = "0x1881A1460", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GPBMBDPKACB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81A1480", Offset = "0x819FA80", VA = "0x1881A1480", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EMGMDDLMAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81A1470", Offset = "0x819FA70", VA = "0x1881A1470", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HIHNMLDEPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9EE0", Offset = "0xAA84E0", VA = "0x180AA9EE0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float IELNLCHONJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD384E0", Offset = "0xD36AE0", VA = "0x180D384E0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JIAHFAHKPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xFCE110", Offset = "0xFCC710", VA = "0x180FCE110", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81A13B0", Offset = "0x819F9B0", VA = "0x1881A13B0")]
	public FPDLILOEFBM(UniformTRS MBJBMIJGMFK, MFPEINJHCFE NBIJLPJHNNE, float NACCPECNNNM, float3 LLGLGHLLEKA, NGNKOEFODLB AIEJDPLDOCH, FFLLKLIPNGD BEOLCFMBDBJ, KMBJIMLIGNC MJNKOFMOBDK, float CDLAHGBCNJB, int BKDJHBCCJGN, NativeArray<FEALKEEJBEM> KFFBHNPIBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x11B8200", Offset = "0x11B6800", VA = "0x1811B8200", Slot = "33")]
	public NativeArray<FEALKEEJBEM> GetNativeCurvePoints()
	{
		return default(NativeArray<FEALKEEJBEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x81A12F0", Offset = "0x819F8F0", VA = "0x1881A12F0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NGGPNHNECJH : IOIOBIJDEPK, HLGMNJHBLBJ, EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<NKGGCFMEFLF, ACIKMAHKONI> CJBBMJCIGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private ACIKMAHKONI FBOFKEOBJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BNPDDPNHOOA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private ACIKMAHKONI DKDFEEJLDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0", Slot = "28")]
		get
		{
			return default(ACIKMAHKONI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JJOACAELPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xF03940", Offset = "0xF01F40", VA = "0x180F03940", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 PEIMCNIPOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81B2810", Offset = "0x81B0E10", VA = "0x1881B2810", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81B27F0", Offset = "0x81B0DF0", VA = "0x1881B27F0")]
	public NGGPNHNECJH(DAHJHHJGHIB ABGLFCMHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81B2160", Offset = "0x81B0760", VA = "0x1881B2160", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81B21B0", Offset = "0x81B07B0", VA = "0x1881B21B0", Slot = "26")]
	public override void IEMAIHNOLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class APONCMBIIFH : MHHNBBPKPCP, BJELADJEHBH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject EEDAANAGNLH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject IOJHMLDNPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x819E430", Offset = "0x819CA30", VA = "0x18819E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MBBBIPMPPEE BDBOCHCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x819E7D0", Offset = "0x819CDD0", VA = "0x18819E7D0", Slot = "15")]
		get
		{
			return default(MBBBIPMPPEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ABILOJFBKNO FOPIFNDFHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x819EA20", Offset = "0x819D020", VA = "0x18819EA20", Slot = "16")]
		get
		{
			return default(ABILOJFBKNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x819E8D0", Offset = "0x819CED0", VA = "0x18819E8D0")]
	public APONCMBIIFH(DAHJHHJGHIB OHGBPBLOAKN, bool LLALFJEPODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x819E4F0", Offset = "0x819CAF0", VA = "0x18819E4F0")]
	public void GCIONGJMLBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x819E7D0", Offset = "0x819CDD0", VA = "0x18819E7D0")]
	protected MBBBIPMPPEE MGMBFBFIKJF()
	{
		return default(MBBBIPMPPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x819E680", Offset = "0x819CC80", VA = "0x18819E680")]
	private static bool JCKOCCIGOJK(DAHJHHJGHIB GJGNFMBHFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x819E4C0", Offset = "0x819CAC0", VA = "0x18819E4C0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JABOJINACBO : IOIOBIJDEPK, MGNNCINACHN, EEMKIJGFKJC, IDisposable, CGAFCLPGFCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<FEALKEEJBEM> KFFBHNPIBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool KDLLIHJCNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LEGMOOIGHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float CDLAHGBCNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int BKDJHBCCJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool NFCPIIGFIDF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool NCBJADGMLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xCCADB0", Offset = "0xCC93B0", VA = "0x180CCADB0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool NFENJHLPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA920F0", Offset = "0xA906F0", VA = "0x180A920F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float MIJIPPNBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE40EB0", Offset = "0xE3F4B0", VA = "0x180E40EB0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int MNMFNOKAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xDF43F0", Offset = "0xDF29F0", VA = "0x180DF43F0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool ABCCPPIFPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCBDA20", Offset = "0xCBC020", VA = "0x180CBDA20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int OKGKCCBCEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x81A7990", Offset = "0x81A5F90", VA = "0x1881A7990", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int KAFLCPHNKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x81A7FF0", Offset = "0x81A65F0", VA = "0x1881A7FF0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x81A80E0", Offset = "0x81A66E0", VA = "0x1881A80E0")]
	public JABOJINACBO(DAHJHHJGHIB ABGLFCMHAJA, [Optional] NativeList<FEALKEEJBEM> KFFBHNPIBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x81A7BB0", Offset = "0x81A61B0", VA = "0x1881A7BB0", Slot = "26")]
	public override void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81A7840", Offset = "0x81A5E40", VA = "0x1881A7840", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x81A7930", Offset = "0x81A5F30", VA = "0x1881A7930", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x81A77E0", Offset = "0x81A5DE0", VA = "0x1881A77E0")]
	public void CKLOJADLBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81A79E0", Offset = "0x81A5FE0", VA = "0x1881A79E0", Slot = "34")]
	public NativeArray<FEALKEEJBEM> GetNativeCurvePoints()
	{
		return default(NativeArray<FEALKEEJBEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x81A7EA0", Offset = "0x81A64A0", VA = "0x1881A7EA0", Slot = "35")]
	private Vector3 MCNOGDLKLMN(int JAENDMHBLHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x81A79B0", Offset = "0x81A5FB0", VA = "0x1881A79B0", Slot = "36")]
	private Quaternion GHKOOBJKJDJ(int JAENDMHBLHP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x81A7D00", Offset = "0x81A6300", VA = "0x1881A7D00", Slot = "37")]
	private float LEIEGDHKHBN(int JAENDMHBLHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x81A7C90", Offset = "0x81A6290", VA = "0x1881A7C90")]
	private NativeArray<Entity> KMPCPILPDNJ()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class AIGLOHBFDKC : OMHJHHNPHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x819D390", Offset = "0x819B990", VA = "0x18819D390", Slot = "15")]
	protected override ComponentSystemBase NAIPGBJNBAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x819D7A0", Offset = "0x819BDA0", VA = "0x18819D7A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x819D7B0", Offset = "0x819BDB0", VA = "0x18819D7B0")]
	public AIGLOHBFDKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[MKAIFECAAGF]
public sealed class LJGFHHDHGCF : KJDHOIOHJEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery BIMBCDHEMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery FCOLGFFKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery AHINPFALMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery JHFAGOFKFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery AAHPHDCLGFP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x81AC840", Offset = "0x81AAE40", VA = "0x1881AC840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x81ACBA0", Offset = "0x81AB1A0", VA = "0x1881ACBA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x81AC400", Offset = "0x81AAA00", VA = "0x1881AC400")]
	private void JHLEGDHCDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x81AC5E0", Offset = "0x81AABE0", VA = "0x1881AC5E0")]
	private void JNHNJFBPOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x81AC1D0", Offset = "0x81AA7D0", VA = "0x1881AC1D0")]
	private void BAJCHFIGHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x81AC0D0", Offset = "0x81AA6D0", VA = "0x1881AC0D0")]
	private void AJGODIOLNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x81AC740", Offset = "0x81AAD40", VA = "0x1881AC740")]
	private void NGAABPBOPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81ACBE0", Offset = "0x81AB1E0", VA = "0x1881ACBE0")]
	private NativeList<Entity> PGEDCDDHCFD(NativeArray<Entity> DCGEKCKMHBF)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x81AC6F0", Offset = "0x81AACF0", VA = "0x1881AC6F0")]
	private NativeList<Entity> JPCKBCKJHFF(NativeArray<Entity> DCGEKCKMHBF)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x81AC3A0", Offset = "0x81AA9A0", VA = "0x1881AC3A0")]
	private void GAKNFCFPLKF(NativeArray<Entity> DCGEKCKMHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public LJGFHHDHGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[MKAIFECAAGF]
public sealed class MGFONPPBIIH : KJDHOIOHJEJ, JPODKHCGMPE
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery PKHOLBNDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery AEAMAHPOKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery OGLGFKDHBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PAODCFCHNKD EDPJFCPDBIN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x81AEFA0", Offset = "0x81AD5A0", VA = "0x1881AEFA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x81AE340", Offset = "0x81AC940", VA = "0x1881AE340", Slot = "15")]
	public override void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x81AF170", Offset = "0x81AD770", VA = "0x1881AF170", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x81AEC80", Offset = "0x81AD280", VA = "0x1881AEC80")]
	private void NIIDEAOJKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81AE3A0", Offset = "0x81AC9A0", VA = "0x1881AE3A0")]
	private void LMAAEDLANEF(NativeParallelHashSet<OMKHNGNFNIM> CJFPGECPEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x81AD8F0", Offset = "0x81ABEF0", VA = "0x1881AD8F0")]
	private void AJFFNCEJEDC(NativeParallelHashSet<OMKHNGNFNIM> CJFPGECPEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81ADF80", Offset = "0x81AC580", VA = "0x1881ADF80")]
	private void HDKEKJIHEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81AEA30", Offset = "0x81AD030", VA = "0x1881AEA30")]
	private bool MMFLNCPNCNB(Entity DFPJIKCEODG, [Out] OMKHNGNFNIM BIGFNMKLPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81AEAD0", Offset = "0x81AD0D0", VA = "0x1881AEAD0")]
	private bool MPIJJMLFJKD(Entity DFPJIKCEODG, [Out] OMKHNGNFNIM BIGFNMKLPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public MGFONPPBIIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[MKAIFECAAGF]
public sealed class PPBKPPNHHPB : KJDHOIOHJEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery ACDOCDLHMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery GPLELGIGCME;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81B8620", Offset = "0x81B6C20", VA = "0x1881B8620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81B8770", Offset = "0x81B6D70", VA = "0x1881B8770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81B8320", Offset = "0x81B6920", VA = "0x1881B8320")]
	private void LMAAEDLANEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81B8030", Offset = "0x81B6630", VA = "0x1881B8030")]
	private void AJFFNCEJEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public PPBKPPNHHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NAAGFHDBNBM : KJDHOIOHJEJ, JPODKHCGMPE
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct BKAIDIJHIFJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob EHHOFOKMPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob FFLAINLMNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob LNNEJAJINEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob KCINOMNODME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle BDPIELIPBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<LBKELNAJHHK> FIGDCIBPKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<OMKHNGNFNIM> BHGLPNKEKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> EJLIJCLHHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> EFEJDMDNJDN;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x819F070", Offset = "0x819D670", VA = "0x18819F070", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x819F0F0", Offset = "0x819D6F0", VA = "0x18819F0F0")]
		private void GFDNADJOGPA(EntityQueryInJob GBEHOCFFBIL, NativeList<Entity> GGDDNEMBLNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct JEOPLDHALAA : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle BDPIELIPBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<LBKELNAJHHK> FIGDCIBPKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<OMKHNGNFNIM> BHGLPNKEKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> GGDDNEMBLNC;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x81A8110", Offset = "0x81A6710", VA = "0x1881A8110", Slot = "4")]
		public void Execute(ArchetypeChunk GNLMMKEONNF, int NMMDLDPPBNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct DPDKPMECLEE : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle BDPIELIPBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> IKFNNIDCILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<FHCBLAKNFAB> DCDBMIHCMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<EKAEAEHFGAK> BJPPKNANHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<LBKELNAJHHK> FLADMADGMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<OMKHNGNFNIM> BHGLPNKEKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> GNEIHDFGGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<FHCBLAKNFAB> EJCLJAPGDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<OMKHNGNFNIM> PINOGPDMOOM;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x81A0350", Offset = "0x819E950", VA = "0x1881A0350", Slot = "4")]
		public void Execute(ArchetypeChunk GNLMMKEONNF, int NMMDLDPPBNO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery EHHOFOKMPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery FFLAINLMNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery LNNEJAJINEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery KCINOMNODME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery MGOFPIJJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery AHDPKMAMCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery NEBJPLNFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PAODCFCHNKD EBKGAKLCBKI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x81B1850", Offset = "0x81AFE50", VA = "0x1881B1850", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x81B0C00", Offset = "0x81AF200", VA = "0x1881B0C00", Slot = "15")]
	public override void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81B1DD0", Offset = "0x81B03D0", VA = "0x1881B1DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x81B1250", Offset = "0x81AF850", VA = "0x1881B1250")]
	private void OGDDEHEIGOF(NativeParallelHashSet<OMKHNGNFNIM> BHGLPNKEKGB, int DPKKBPBFFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x81B0420", Offset = "0x81AEA20", VA = "0x1881B0420")]
	private void BLDEENLMHFD(NativeParallelHashSet<OMKHNGNFNIM> BHGLPNKEKGB, int JIAPBMAIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81B0E10", Offset = "0x81AF410", VA = "0x1881B0E10")]
	private void NHCNLHPHGCC(NativeParallelHashSet<OMKHNGNFNIM> BHGLPNKEKGB, int NFCNAPPIKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x81B0870", Offset = "0x81AEE70", VA = "0x1881B0870")]
	private void DLBFGCOIMMH(NativeParallelHashSet<OMKHNGNFNIM> CJFPGECPEKL, int OGMPPIADDGK, int GOHHADHJCCC, int KDFCIPDLCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81B0C60", Offset = "0x81AF260", VA = "0x1881B0C60")]
	private void LLCAJHBOOFF(Entity BKDCANGNNKG, FINIDNMFGON OLOCBODPKAN, OMKHNGNFNIM BIGFNMKLPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public NAAGFHDBNBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GAOLNJFIAJD : KJDHOIOHJEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery BEFDCCBHHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery APMACMLCCGL;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81A1490", Offset = "0x819FA90", VA = "0x1881A1490", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81A16C0", Offset = "0x819FCC0", VA = "0x1881A16C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public GAOLNJFIAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LDHKDAJFDCP : KJDHOIOHJEJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct CGNOPKMKEJO : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery JLNMMHNAFPL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81AB280", Offset = "0x81A9880", VA = "0x1881AB280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x81AB3C0", Offset = "0x81A99C0", VA = "0x1881AB3C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public LDHKDAJFDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[MKAIFECAAGF]
internal class AMJLBPJMMGP : KJDHOIOHJEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class ANKAODOLKNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery KDPBMECEBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery JPNKAIJNJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public BPLFDFNFGEG LDDPIHIBONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType CGBMAIOIJCK;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ANKAODOLKNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void BPLFDFNFGEG(NativeArray<FINIDNMFGON> MNCGAKBHIPL, GIELKEINIAC IDOJBJFNNFA);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<ANKAODOLKNM> EDHLLPPFEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private LGFOOLKGBCJ OEBPBHJCADJ;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x819D960", Offset = "0x819BF60", VA = "0x18819D960", Slot = "15")]
	public override void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x819DD00", Offset = "0x819C300", VA = "0x18819DD00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x819DE90", Offset = "0x819C490", VA = "0x18819DE90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x30BC360", Offset = "0x30BA960", VA = "0x1830BC360")]
	private void JNAMGGOKKNP<T>(BPLFDFNFGEG LDDPIHIBONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x819DB60", Offset = "0x819C160", VA = "0x18819DB60")]
	private static void KNEMCGKIJAN(NativeArray<FINIDNMFGON> HKOOIOCCCHM, GIELKEINIAC DGLHJIKGJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x819D9C0", Offset = "0x819BFC0", VA = "0x18819D9C0")]
	private static void JOJKFMHIMBA(NativeArray<FINIDNMFGON> HKOOIOCCCHM, GIELKEINIAC DGLHJIKGJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x819D7C0", Offset = "0x819BDC0", VA = "0x18819D7C0")]
	private static void BKNDOLAANOO(NativeArray<FINIDNMFGON> HKOOIOCCCHM, GIELKEINIAC DGLHJIKGJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public AMJLBPJMMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[MKAIFECAAGF]
public sealed class HMOMKJGNKAO : KJDHOIOHJEJ
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery GBEHOCFFBIL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x81A70B0", Offset = "0x81A56B0", VA = "0x1881A70B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IPLPHGELKMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS MBJBMIJGMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData CHIHPGMDLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ACIKMAHKONI FBOFKEOBJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 GOACPAIEJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool BNPDDPNHOOA;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[AGHLCNBPGNJ(Lifetime.LoadInstance)]
public struct HHADOPNLKIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity EOECEDBNACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> PPMJKNEDFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> MGOFHGLEMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<IPLPHGELKMN> KIGAFAILCOC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81A7020", Offset = "0x81A5620", VA = "0x1881A7020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(JHJANFHILJK), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class JHJANFHILJK : JPODKHCGMPE, JFAKIPDGBHA, IJNPAMHNAJF, IELEAPKDCBK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct BCMBLMKKNFO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly JHJANFHILJK NBIJLPJHNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool DCKLPBNACKE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1983E90", Offset = "0x1982490", VA = "0x181983E90")]
		public BCMBLMKKNFO(JHJANFHILJK NBIJLPJHNNE, bool DCKLPBNACKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x819EC70", Offset = "0x819D270", VA = "0x18819EC70")]
		public Queue<HANBBMMABNB>.Enumerator DHKFMABLBKB()
		{
			return default(Queue<HANBBMMABNB>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x819ED30", Offset = "0x819D330", VA = "0x18819ED30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private NNEPMGCDLOI DMELKGHGJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private IDGBPCCJAGL AFEOENFKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<FEALKEEJBEM>> ELNNAEEBEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> AACAPBMNPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<FINIDNMFGON> KKHPFIFFKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private CJCDDDJINOC<HANBBMMABNB> JIFAILCLBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private CJCDDDJINOC<HHADOPNLKIK> DIGMNCMNABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private CJCDDDJINOC<CIKIHGFHIOC> EFLDFPCAHNM;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x81A8D10", Offset = "0x81A7310", VA = "0x1881A8D10", Slot = "4")]
	public void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x81A8FF0", Offset = "0x81A75F0", VA = "0x1881A8FF0")]
	public void KIJOPKJAINO(NativeList<FEALKEEJBEM> POGMDDCOHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x81A90B0", Offset = "0x81A76B0", VA = "0x1881A90B0")]
	public void KNBPNOOKMPL(Entity NBIJLPJHNNE, [In] POIJGDNEEOK<GameObject> NIEMMIKKHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x81A9390", Offset = "0x81A7990", VA = "0x1881A9390")]
	public void NPHJDDLPMBD(NativeList<FINIDNMFGON> HKOOIOCCCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x81A8350", Offset = "0x81A6950", VA = "0x1881A8350")]
	public void EKOIMPLPGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x81A8810", Offset = "0x81A6E10", VA = "0x1881A8810")]
	public void IAGJPHLMFJO(FCDPDINJFJB MIPDPIDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x81A92A0", Offset = "0x81A78A0", VA = "0x1881A92A0")]
	public JobHandle MEIIFEDCBKD([In] HANBBMMABNB CJIMOMNMAGD, JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x81A9200", Offset = "0x81A7800", VA = "0x1881A9200")]
	public JobHandle MEIIFEDCBKD([In] HHADOPNLKIK CJIMOMNMAGD, JobHandle NPGGKLEPILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D7E0", Offset = "0x7E3BDE0", VA = "0x187E3D7E0")]
	public BCMBLMKKNFO KEDPKPFHAEI(bool DCKLPBNACKE)
	{
		return default(BCMBLMKKNFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x81A9340", Offset = "0x81A7940", VA = "0x1881A9340")]
	public LOEGKJEKHDN<HHADOPNLKIK> NHCJJCJHKNH()
	{
		return default(LOEGKJEKHDN<HHADOPNLKIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x81A8CC0", Offset = "0x81A72C0", VA = "0x1881A8CC0")]
	public LOEGKJEKHDN<CIKIHGFHIOC> IFKIJNPEEEG()
	{
		return default(LOEGKJEKHDN<CIKIHGFHIOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x81A85F0", Offset = "0x81A6BF0", VA = "0x1881A85F0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x81A8F10", Offset = "0x81A7510", VA = "0x1881A8F10", Slot = "5")]
	public void KALGJOBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x81A8580", Offset = "0x81A6B80", VA = "0x1881A8580", Slot = "6")]
	private void FNAOMNCODMK(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x12593C0", Offset = "0x12579C0", VA = "0x1812593C0", Slot = "7")]
	private void MPJIHLCOJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JHJANFHILJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IFDJCGIDKBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS MBJBMIJGMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData CHIHPGMDLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public HNLOHAHCDNN MJNKOFMOBDK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[AGHLCNBPGNJ(Lifetime.LoadInstance)]
public struct HANBBMMABNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity EOECEDBNACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> DCGEKCKMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> PPMJKNEDFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> MGOFHGLEMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<HABDMPMOHEE> LJHJDLHIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<FEALKEEJBEM> POGMDDCOHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<IFDJCGIDKBH> EMLGIHGGHAB;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x81A6EC0", Offset = "0x81A54C0", VA = "0x1881A6EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x81A6DF0", Offset = "0x81A53F0", VA = "0x1881A6DF0")]
	public void DIGOPEEDGGN(bool DCKLPBNACKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(EJDHEBCAMIE), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class EJDHEBCAMIE : MENLGIBJDCM, IJNPAMHNAJF, IELEAPKDCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private JHJANFHILJK EOHMJEFDFNI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x81A0740", Offset = "0x819ED40", VA = "0x1881A0740", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x81A06F0", Offset = "0x819ECF0", VA = "0x1881A06F0", Slot = "5")]
	private void FNAOMNCODMK(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x121E280", Offset = "0x121C880", VA = "0x18121E280", Slot = "6")]
	private void MPJIHLCOJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EJDHEBCAMIE()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : KJDHOIOHJEJ, JPODKHCGMPE
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
			public NativeParallelHashMap<int, ACIKMAHKONI> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<IPLPHGELKMN> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x81A23D0", Offset = "0x81A09D0", VA = "0x1881A23D0", Slot = "4")]
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
			public NativeArray<FEALKEEJBEM> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<HABDMPMOHEE> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<IFDJCGIDKBH> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x81A2770", Offset = "0x81A0D70", VA = "0x1881A2770", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x81A0210", Offset = "0x819E810", VA = "0x1881A0210", Slot = "4")]
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
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x81B8870", Offset = "0x81B6E70", VA = "0x1881B8870")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x81B8820", Offset = "0x81B6E20", VA = "0x1881B8820")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 KFIKGMMJCNA(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x81AD0C0", Offset = "0x81AB6C0", VA = "0x1881AD0C0", Slot = "5")]
				public float3 HNJAHPLALAN(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x81AD470", Offset = "0x81ABA70", VA = "0x1881AD470", Slot = "4")]
				public float3 KFIKGMMJCNA(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x81B28E0", Offset = "0x81B0EE0", VA = "0x1881B28E0", Slot = "4")]
				public float3 KFIKGMMJCNA(quaternion rotation)
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
			public NativeArray<HABDMPMOHEE> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<FEALKEEJBEM> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x81A3FE0", Offset = "0x81A25E0", VA = "0x1881A3FE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x81A3100", Offset = "0x81A1700", VA = "0x1881A3100")]
			private void DOCKADIDDKL(NativeList<PointSrcData> srcData, NativeList<FEALKEEJBEM> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x81A60F0", Offset = "0x81A46F0", VA = "0x1881A60F0")]
			public static Vector3 NHGOFOLNGLC(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x81A2E90", Offset = "0x81A1490", VA = "0x1881A2E90")]
			public static quaternion ACNOPIBHIAP(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x81A6B30", Offset = "0x81A5130", VA = "0x1881A6B30")]
			private static quaternion PNNMFDKFNDI(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x81A6960", Offset = "0x81A4F60", VA = "0x1881A6960")]
			private static float3 PEJLDPDHOEP(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x81A55C0", Offset = "0x81A3BC0", VA = "0x1881A55C0")]
			private static quaternion IBPJILIDACL(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x81A5650", Offset = "0x81A3C50", VA = "0x1881A5650")]
			private static FEALKEEJBEM IIPCPPKICBL(int idx, NativeList<PointSrcData> srcData)
			{
				return default(FEALKEEJBEM);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x424BAA0", Offset = "0x424A0A0", VA = "0x18424BAA0")]
			private void AILNNGDMOHC<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x81A47B0", Offset = "0x81A2DB0", VA = "0x1881A47B0")]
			private void HOAHEDMIBJB(NativeList<PointSrcData> sourcePoints, NativeList<FEALKEEJBEM> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x81A5F70", Offset = "0x81A4570", VA = "0x1881A5F70")]
			public static float NAMBMNIGJIE(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x81A2F10", Offset = "0x81A1510", VA = "0x1881A2F10")]
			private static quaternion BCJBCCNODOA(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x81A5C50", Offset = "0x81A4250", VA = "0x1881A5C50")]
			private static FEALKEEJBEM LJKNDLLOKKH(PointSrcData point)
			{
				return default(FEALKEEJBEM);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x81A5D70", Offset = "0x81A4370", VA = "0x1881A5D70")]
			private static FEALKEEJBEM LJKNDLLOKKH(float3 pos, quaternion rot, float radius)
			{
				return default(FEALKEEJBEM);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x81A5ED0", Offset = "0x81A44D0", VA = "0x1881A5ED0")]
			private static bool MOJOKCGIDFO(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x81A5E00", Offset = "0x81A4400", VA = "0x1881A5E00")]
			private static float3 MMIGDMBNPHN(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x81A58C0", Offset = "0x81A3EC0", VA = "0x1881A58C0")]
			public static float3 IMDKMEGKEFI(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x81A4600", Offset = "0x81A2C00", VA = "0x1881A4600")]
			public static float3 HNJAHPLALAN(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x81A6500", Offset = "0x81A4B00", VA = "0x1881A6500")]
			private static quaternion OKBKCLPHFAE(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x81A5A70", Offset = "0x81A4070", VA = "0x1881A5A70")]
			private static float IMEDNGBJPLG(float3 from, float3 to)
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

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x81BA740", Offset = "0x81B8D40", VA = "0x1881BA740")]
			private void NLCPDOEBKCB(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x81BA650", Offset = "0x81B8C50", VA = "0x1881BA650", Slot = "4")]
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
			public NativeList<FEALKEEJBEM> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x81BC260", Offset = "0x81BA860", VA = "0x1881BC260")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x81BC250", Offset = "0x81BA850", VA = "0x1881BC250", Slot = "4")]
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
			public NativeList<FEALKEEJBEM> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x81BC200", Offset = "0x81BA800", VA = "0x1881BC200")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x81BC1F0", Offset = "0x81BA7F0", VA = "0x1881BC1F0", Slot = "4")]
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
			public NativeList<IPLPHGELKMN> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x81A2AC0", Offset = "0x81A10C0", VA = "0x1881A2AC0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x81A2AB0", Offset = "0x81A10B0", VA = "0x1881A2AB0", Slot = "4")]
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
			public NativeList<HABDMPMOHEE> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<IFDJCGIDKBH> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x81A2C90", Offset = "0x81A1290", VA = "0x1881A2C90")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x81A2C80", Offset = "0x81A1280", VA = "0x1881A2C80", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x81BBDD0", Offset = "0x81BA3D0", VA = "0x1881BBDD0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x81BBDC0", Offset = "0x81BA3C0", VA = "0x1881BBDC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly LHMKAIAPMBI log;

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
		private JKMOOHPMCJF replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NNEPMGCDLOI objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private JHJANFHILJK bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private JFNCAENPIHL ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81B9D00", Offset = "0x81B8300", VA = "0x1881B9D00", Slot = "15")]
		public override void InitReferences(MGPNAOEDNIM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x81BB180", Offset = "0x81B9780", VA = "0x1881BB180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x81BB270", Offset = "0x81B9870", VA = "0x1881BB270", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x81BB2D0", Offset = "0x81B98D0", VA = "0x1881BB2D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x81B99C0", Offset = "0x81B7FC0", VA = "0x1881B99C0")]
		private JobHandle FAAHCOCOPPN(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x81B8EC0", Offset = "0x81B74C0", VA = "0x1881B8EC0")]
		private JobHandle DIMDMNGPKMK(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x81B9580", Offset = "0x81B7B80", VA = "0x1881B9580")]
		private JobHandle DNDOEJJMBLC(NativeArray<int> pointCount, NativeList<FEALKEEJBEM> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x81B8E20", Offset = "0x81B7420", VA = "0x1881B8E20")]
		private JobHandle IGJMIEDJOAJ(NativeList<FEALKEEJBEM> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81BB860", Offset = "0x81B9E60", VA = "0x1881BB860")]
		private JobHandle PPKJFBDANHL(EntityQuery query, NativeList<HABDMPMOHEE> splinePointRanges, NativeList<FEALKEEJBEM> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x81B8890", Offset = "0x81B6E90", VA = "0x1881B8890")]
		private JobHandle AFHCEHDDDPJ(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x81BA140", Offset = "0x81B8740", VA = "0x1881BA140")]
		private JobHandle JLIJHAJIHGM(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x81BA260", Offset = "0x81B8860", VA = "0x1881BA260")]
		private JobHandle LCEFBHJGONA(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<IPLPHGELKMN> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x81B9DA0", Offset = "0x81B83A0", VA = "0x1881B9DA0")]
		private JobHandle JBDJNFEMNJM(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<HABDMPMOHEE> splinePointRanges, [Out] NativeList<IFDJCGIDKBH> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x81B89B0", Offset = "0x81B6FB0", VA = "0x1881B89B0")]
		private JobHandle CDHKHHJDGML(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x81BA820", Offset = "0x81B8E20", VA = "0x1881BA820")]
		private JobHandle MCPAIOGCAED(EntityQuery query, NativeList<IPLPHGELKMN> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81BB440", Offset = "0x81B9A40", VA = "0x1881BB440")]
		private static NativeParallelHashMap<int, ACIKMAHKONI> POEKIEONJKF()
		{
			return default(NativeParallelHashMap<int, ACIKMAHKONI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81B9620", Offset = "0x81B7C20", VA = "0x1881B9620")]
		private JobHandle EFPNEGNOBDJ(EntityQuery query, NativeList<HABDMPMOHEE> splinePointRanges, NativeList<FEALKEEJBEM> splinePointData, NativeList<IFDJCGIDKBH> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x81BA060", Offset = "0x81B8660", VA = "0x1881BA060")]
		private JobHandle JFCGHGOHDMC(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81B9580", Offset = "0x81B7B80", VA = "0x1881B9580")]
		private JobHandle LPMDMPFDJPO(NativeArray<int> pointCount, NativeList<FEALKEEJBEM> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x81B8E20", Offset = "0x81B7420", VA = "0x1881B8E20")]
		private JobHandle DAICLFEOMEI(NativeList<FEALKEEJBEM> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x81B8D30", Offset = "0x81B7330", VA = "0x1881B8D30")]
		private JobHandle CNKJLMKDIOG(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<IPLPHGELKMN> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x81BAD30", Offset = "0x81B9330", VA = "0x1881BAD30")]
		private JobHandle MKIGCGPENKI(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<HABDMPMOHEE> ranges, NativeList<IFDJCGIDKBH> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x81BA500", Offset = "0x81B8B00", VA = "0x1881BA500")]
		private JobHandle LMOPJNOCLJD(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x81BAE40", Offset = "0x81B9440", VA = "0x1881BAE40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PHPHGNLFLLP : JBGFFILIMFO, JPODKHCGMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private JHJANFHILJK EOHMJEFDFNI;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x81B7FC0", Offset = "0x81B65C0", VA = "0x1881B7FC0", Slot = "14")]
	public void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x81B8010", Offset = "0x81B6610", VA = "0x1881B8010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
	public PHPHGNLFLLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class OHFBOLOBHGE : KJDHOIOHJEJ, JPODKHCGMPE
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct LGNNLGEDFGD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager MAHCJNEKFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private BHDKIEOFOKJ<T> CCLKAJNHDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int KHMHPNKMLMD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x538AA70", Offset = "0x5389070", VA = "0x18538AA70")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x538AE50", Offset = "0x5389450", VA = "0x18538AE50")]
		public LGNNLGEDFGD(EntityManager MAHCJNEKFMD, BHDKIEOFOKJ<T> CCLKAJNHDME, NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x483ABB0", Offset = "0x48391B0", VA = "0x18483ABB0")]
		public LGNNLGEDFGD<T> DHKFMABLBKB()
		{
			return default(LGNNLGEDFGD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x538ADF0", Offset = "0x53893F0", VA = "0x18538ADF0")]
		public bool FBIFJHFEFCO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly LHMKAIAPMBI PIKDGPDLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private IDGBPCCJAGL AFEOENFKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JHJANFHILJK EOHMJEFDFNI;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x81B63D0", Offset = "0x81B49D0", VA = "0x1881B63D0", Slot = "15")]
	public override void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x81B6550", Offset = "0x81B4B50", VA = "0x1881B6550")]
	public void KIMHLNGOGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x81B6B80", Offset = "0x81B5180", VA = "0x1881B6B80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x81B52B0", Offset = "0x81B38B0", VA = "0x1881B52B0")]
	private void IPAAHOAENAN(CIKIHGFHIOC CJIMOMNMAGD, Mesh[] GPHJGCKMMMI, NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB9F0", Offset = "0x3CE9FF0", VA = "0x183CEB9F0")]
	private LGNNLGEDFGD<T> EELAAFOAPGF<T>(BHDKIEOFOKJ<T> CCLKAJNHDME, NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN) where T : struct
	{
		return default(LGNNLGEDFGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x81B4240", Offset = "0x81B2840", VA = "0x1881B4240")]
	private void ELHDGMJJAAK(Transform NBIJLPJHNNE, NativeArray<AAFEINAKODF> JAMKALCBLHI, POIJGDNEEOK<GameObject> BDPLFAFMGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x81B4DF0", Offset = "0x81B33F0", VA = "0x1881B4DF0")]
	private void IJGMHINLGIN(Transform NBIJLPJHNNE, NativeArray<LGJNAOOGOEF> ELJOBONABIA, POIJGDNEEOK<GameObject> BDPLFAFMGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x81B6580", Offset = "0x81B4B80", VA = "0x1881B6580")]
	private void KIOENPEPCBD(Transform NBIJLPJHNNE, NativeArray<NDBHLIBFHLA> NANANOCKLGL, POIJGDNEEOK<GameObject> BDPLFAFMGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x81B45D0", Offset = "0x81B2BD0", VA = "0x1881B45D0")]
	private void FHCONEJHJID(Transform NBIJLPJHNNE, NativeArray<ACHFIFHMODN> GPHJGCKMMMI, Mesh[] GNJLCDPEGNI, POIJGDNEEOK<GameObject> BDPLFAFMGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x81B6A30", Offset = "0x81B5030", VA = "0x1881B6A30")]
	private static void NNHMMKGEPIO(NativeParallelHashSet<Entity> DCGEKCKMHBF, NativeParallelHashSet<Entity> HPLFOKDOIGD, NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x81B6970", Offset = "0x81B4F70", VA = "0x1881B6970")]
	private static void KJAFCDGMHHL(NativeList<Entity> BGGFBGFNIID, NativeArray<EntityRemapUtility.EntityRemapInfo> GHDKPOFGKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81B36E0", Offset = "0x81B1CE0", VA = "0x1881B36E0")]
	private NativeParallelHashMap<Entity, EKAEAEHFGAK> CFEPKFAFJNP(JHJANFHILJK.BCMBLMKKNFO MLHGHBGGOKI, LOEGKJEKHDN<HHADOPNLKIK> FNMHGAPCMJE, List<GameObject> BDPLFAFMGBE)
	{
		return default(NativeParallelHashMap<Entity, EKAEAEHFGAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x81B6450", Offset = "0x81B4A50", VA = "0x1881B6450")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JFICFNHEMOF(Entity ILKJKAJFDDB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x81B3190", Offset = "0x81B1790", VA = "0x1881B3190")]
	private void BBBAJBFDKFK(NativeList<Entity> FMDKCCAJOOK, NativeList<Entity> MIFOPDHIPAD, NativeParallelHashMap<Entity, EKAEAEHFGAK> IKHCLDPBJEC, NativeList<HABDMPMOHEE> HBECOJEENLM, NativeList<FEALKEEJBEM> LNPLMHDGDCN, NativeList<IFDJCGIDKBH> ELNNAEEBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x81B4A00", Offset = "0x81B3000", VA = "0x1881B4A00")]
	private void GMLJJMCCEKN(NativeList<Entity> DCGEKCKMHBF, NativeList<Entity> PPMJKNEDFGP, NativeParallelHashMap<Entity, EKAEAEHFGAK> IKHCLDPBJEC, NativeList<IPLPHGELKMN> KIGAFAILCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x819E420", Offset = "0x819CA20", VA = "0x18819E420")]
	public OHFBOLOBHGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class LOJIKNDOPMD : CFGFLCNFDNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS MBJBMIJGMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly MFPEINJHCFE NBIJLPJHNNE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject JFJHLMGNADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS PJKLFNKLDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x81ACEF0", Offset = "0x81AB4F0", VA = "0x1881ACEF0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 GMOLCHDIEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x81ACDB0", Offset = "0x81AB3B0", VA = "0x1881ACDB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 GAOGFMAEFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x81ACCC0", Offset = "0x81AB2C0", VA = "0x1881ACCC0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 DJACHHCKKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x81ACD60", Offset = "0x81AB360", VA = "0x1881ACD60", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x81ACFD0", Offset = "0x81AB5D0", VA = "0x1881ACFD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion LBEACODFHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x81ACE00", Offset = "0x81AB400", VA = "0x1881ACE00", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x81ACEA0", Offset = "0x81AB4A0", VA = "0x1881ACEA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 CGGHNHJHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x81ACE50", Offset = "0x81AB450", VA = "0x1881ACE50", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 LOAMGFBEDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x81ACD10", Offset = "0x81AB310", VA = "0x1881ACD10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 HNFHOMGAKND
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x81AD020", Offset = "0x81AB620", VA = "0x1881AD020", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x81AD070", Offset = "0x81AB670", VA = "0x1881AD070")]
	public LOJIKNDOPMD(UniformTRS MBJBMIJGMFK, MFPEINJHCFE NBIJLPJHNNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class GLODIFGJKFO : LOJIKNDOPMD, EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float NACCPECNNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 LLGLGHLLEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly NGNKOEFODLB AIEJDPLDOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly FFLLKLIPNGD BEOLCFMBDBJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private MBBBIPMPPEE FAIGIBKNFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x81A21D0", Offset = "0x81A07D0", VA = "0x1881A21D0", Slot = "17")]
		get
		{
			return default(MBBBIPMPPEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS JANGEIAEIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x81A2270", Offset = "0x81A0870", VA = "0x1881A2270", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float DDHKIDJIOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA9FB60", Offset = "0xA9E160", VA = "0x180A9FB60", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 LICLGOLCICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x81A2220", Offset = "0x81A0820", VA = "0x1881A2220", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private NGNKOEFODLB OMFGOMPMODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xF2CD40", Offset = "0xF2B340", VA = "0x180F2CD40", Slot = "21")]
		get
		{
			return default(NGNKOEFODLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private FFLLKLIPNGD OGHANLAENBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x13A7320", Offset = "0x13A5920", VA = "0x1813A7320", Slot = "22")]
		get
		{
			return default(FFLLKLIPNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool EFLFFMKDOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CGJAJBOPFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x81A2350", Offset = "0x81A0950", VA = "0x1881A2350")]
	protected GLODIFGJKFO(UniformTRS MBJBMIJGMFK, MFPEINJHCFE NBIJLPJHNNE, float NACCPECNNNM, float3 LLGLGHLLEKA, NGNKOEFODLB AIEJDPLDOCH, FFLLKLIPNGD BEOLCFMBDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class MHHNBBPKPCP : CFGFLCNFDNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly DAHJHHJGHIB HJMEJBNHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected MFPEINJHCFE LIAPOAHCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x120F360", Offset = "0x120D960", VA = "0x18120F360")]
		get
		{
			return default(MFPEINJHCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity KFJKIONEHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x81AFBB0", Offset = "0x81AE1B0", VA = "0x1881AFBB0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected NNEPMGCDLOI LOJJBHPCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x81AFBD0", Offset = "0x81AE1D0", VA = "0x1881AFBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected FDLCNEOAOBH EBDGAJLIBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x81AF710", Offset = "0x81ADD10", VA = "0x1881AF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected HDFJJJHIDHC DBLADLOOKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x81AF550", Offset = "0x81ADB50", VA = "0x1881AF550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject JFJHLMGNADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x81AFCF0", Offset = "0x81AE2F0", VA = "0x1881AFCF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS PJKLFNKLDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12564E0", Offset = "0x1254AE0", VA = "0x1812564E0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 GMOLCHDIEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x81AF770", Offset = "0x81ADD70", VA = "0x1881AF770", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 GAOGFMAEFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x81AF220", Offset = "0x81AD820", VA = "0x1881AF220", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 DJACHHCKKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x81AF5E0", Offset = "0x81ADBE0", VA = "0x1881AF5E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x81AFBE0", Offset = "0x81AE1E0", VA = "0x1881AFBE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion LBEACODFHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x81AF860", Offset = "0x81ADE60", VA = "0x1881AF860", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x81AFAA0", Offset = "0x81AE0A0", VA = "0x1881AFAA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 CGGHNHJHNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x81AF9B0", Offset = "0x81ADFB0", VA = "0x1881AF9B0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 LOAMGFBEDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x81AF390", Offset = "0x81AD990", VA = "0x1881AF390", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 HNFHOMGAKND
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x81AFD20", Offset = "0x81AE320", VA = "0x1881AFD20", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xEA80B0", Offset = "0xEA66B0", VA = "0x180EA80B0")]
	protected MHHNBBPKPCP(DAHJHHJGHIB ABGLFCMHAJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x81AF980", Offset = "0x81ADF80", VA = "0x1881AF980")]
	public static MBBBIPMPPEE EIMKEBEILPD(MHHNBBPKPCP MMMCFFENLAH)
	{
		return default(MBBBIPMPPEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class CMGBLEIKANE
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x81BCF70", Offset = "0x81BB570", VA = "0x1881BCF70")]
	public static void IBMHHKAJGBP(NativeArray<Entity> DCGEKCKMHBF, EntityManager MAHCJNEKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HPDFCIPIINP
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x81BD7C0", Offset = "0x81BBDC0", VA = "0x1881BD7C0")]
	public static void LFHDMILOBBA(NativeArray<Entity> DCGEKCKMHBF, EntityManager MAHCJNEKFMD, FCDPDINJFJB FENHKIMEIPN, NNEPMGCDLOI LONKPMILJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x81BD210", Offset = "0x81BB810", VA = "0x1881BD210")]
	public static void AAGHNDCFNMA(NativeArray<Entity> DCGEKCKMHBF, EntityManager MAHCJNEKFMD, FCDPDINJFJB FENHKIMEIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x81BD780", Offset = "0x81BBD80", VA = "0x1881BD780")]
	public static NativeList<Entity> JPCKBCKJHFF(NativeArray<Entity> DCGEKCKMHBF, EntityManager MAHCJNEKFMD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x81BDBD0", Offset = "0x81BC1D0", VA = "0x1881BDBD0")]
	public static NativeList<Entity> PGEDCDDHCFD(NativeArray<Entity> DCGEKCKMHBF, EntityManager MAHCJNEKFMD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x81BD520", Offset = "0x81BBB20", VA = "0x1881BD520")]
	private static NativeList<Entity> JPCKBCKJHFF(NativeArray<Entity> DCGEKCKMHBF, EntityManager MAHCJNEKFMD, bool DHKJKIPMHOM)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class IOIOBIJDEPK : MHHNBBPKPCP, EEMKIJGFKJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float NACCPECNNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 LLGLGHLLEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NGNKOEFODLB AIEJDPLDOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FFLLKLIPNGD BEOLCFMBDBJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager OAIANGGCCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x81BDF20", Offset = "0x81BC520", VA = "0x1881BDF20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MCNADDNPOAH LMHIDNFMGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x81BDDA0", Offset = "0x81BC3A0", VA = "0x1881BDDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData FBEIDMBPCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x81BDE00", Offset = "0x81BC400", VA = "0x1881BDE00")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private MBBBIPMPPEE FAIGIBKNFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x81AF980", Offset = "0x81ADF80", VA = "0x1881AF980", Slot = "17")]
		get
		{
			return default(MBBBIPMPPEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float DDHKIDJIOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAA7CA0", Offset = "0xAA62A0", VA = "0x180AA7CA0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 LICLGOLCICL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x131AEB0", Offset = "0x13194B0", VA = "0x18131AEB0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private NGNKOEFODLB OMFGOMPMODI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0", Slot = "21")]
		get
		{
			return default(NGNKOEFODLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private FFLLKLIPNGD OGHANLAENBH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880", Slot = "22")]
		get
		{
			return default(FFLLKLIPNGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS JANGEIAEIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x81BDEF0", Offset = "0x81BC4F0", VA = "0x1881BDEF0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CGJAJBOPFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool EFLFFMKDOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x81BDFB0", Offset = "0x81BC5B0", VA = "0x1881BDFB0")]
	protected IOIOBIJDEPK(DAHJHHJGHIB ABGLFCMHAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x81BDC10", Offset = "0x81BC210", VA = "0x1881BDC10", Slot = "26")]
	public virtual void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class KJDHOIOHJEJ : JBGFFILIMFO, JPODKHCGMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected NNEPMGCDLOI LONKPMILJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private CDNLMHPNODP ILIOCACLGDN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected FCDPDINJFJB JNCKENNLFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x81BE0A0", Offset = "0x81BC6A0", VA = "0x1881BE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected GIELKEINIAC BDANMGKDCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x81BE0F0", Offset = "0x81BC6F0", VA = "0x1881BE0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool GJANBHOBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x81BDFE0", Offset = "0x81BC5E0", VA = "0x1881BDFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x81BE140", Offset = "0x81BC740", VA = "0x1881BE140", Slot = "15")]
	public virtual void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
	protected KJDHOIOHJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BCOODFKCLEL
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x81BCD30", Offset = "0x81BB330", VA = "0x1881BCD30")]
	public static void JDOJMLDJPPN(NativeArray<Entity> FMDKCCAJOOK, EntityManager MAHCJNEKFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__346314737
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x81BE440", Offset = "0x81BCA40", VA = "0x1881BE440")]
	public static void ICDPAFJOCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x81BE430", Offset = "0x81BCA30", VA = "0x1881BE430")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class PGEDFIIDONN : ContainerPropertyBag<IBHBFJGECJL>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x81BE210", Offset = "0x81BC810", VA = "0x1881BE210")]
	public PGEDFIIDONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class OJICLNJAJFD : ContainerPropertyBag<EGOJLCJCMPB>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x81BE1B0", Offset = "0x81BC7B0", VA = "0x1881BE1B0")]
	public OJICLNJAJFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class DHKLPFOOIJE : ContainerPropertyBag<MDCFOJGGMEC>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x81BD1B0", Offset = "0x81BB7B0", VA = "0x1881BD1B0")]
	public DHKLPFOOIJE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x81BE270", Offset = "0x81BC870", VA = "0x1881BE270")]
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
