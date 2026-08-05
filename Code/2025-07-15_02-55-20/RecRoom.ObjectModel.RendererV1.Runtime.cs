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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8309210", Offset = "0x8307E10", VA = "0x188309210", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82BC380", Offset = "0x82BAF80", VA = "0x1882BC380", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8313620", Offset = "0x8312220", VA = "0x188313620")]
		private void GAOPLNBGOGD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8313BC0", Offset = "0x83127C0", VA = "0x188313BC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8313C20", Offset = "0x8312820", VA = "0x188313C20")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EPHKLCADJML
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82FDA30", Offset = "0x82FC630", VA = "0x1882FDA30")]
	public static Quaternion IJHGPOPPMID([In] this CONIGAAIGCB KGIAOCDIILA, [In] Vector3 DBIJDHDPOAF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FGGAONECEFA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82FF610", Offset = "0x82FE210", VA = "0x1882FF610")]
	public static bool OPOOAOCHCLP(this CPLPDHBAEJC JAPNMDMDLII, EHENCINGLKE KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82FF3A0", Offset = "0x82FDFA0", VA = "0x1882FF3A0")]
	public static bool NGODPJGKKIP(this CPLPDHBAEJC JAPNMDMDLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82FE110", Offset = "0x82FCD10", VA = "0x1882FE110")]
	public static bool KGALKLHAEPC(this CPLPDHBAEJC JAPNMDMDLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82FDB10", Offset = "0x82FC710", VA = "0x1882FDB10")]
	public static void ADDMONBAHLA(this CPLPDHBAEJC JAPNMDMDLII, Vector3 FMKJNEENPGI, Quaternion FKFLGAOOFEB, float BNDEJLLMNLK, bool EGDCAHBBELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82FF650", Offset = "0x82FE250", VA = "0x1882FF650")]
	public static void PAEDCAAHFIO(this CPLPDHBAEJC JAPNMDMDLII, Vector3 FMKJNEENPGI, Quaternion FKFLGAOOFEB, float BNDEJLLMNLK, int LFNOLJHJIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82FDC40", Offset = "0x82FC840", VA = "0x1882FDC40")]
	public static void AINPNPHMEAN(this CPLPDHBAEJC JAPNMDMDLII, int LFNOLJHJIOD, Vector3 FMKJNEENPGI, Quaternion FKFLGAOOFEB, float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82FF5C0", Offset = "0x82FE1C0", VA = "0x1882FF5C0")]
	public static void ONDLEIMEPJH(this CPLPDHBAEJC JAPNMDMDLII, Vector3 BBMDFNLMEFL, Quaternion EJDPILGJOJG, float BNDEJLLMNLK, bool EGDCAHBBELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82FEA40", Offset = "0x82FD640", VA = "0x1882FEA40")]
	private static void NFNDPOGKDJE(this CPLPDHBAEJC JAPNMDMDLII, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float BNDEJLLMNLK, bool EGDCAHBBELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82FF400", Offset = "0x82FE000", VA = "0x1882FF400")]
	private static void NMCCDICKFDP(this CPLPDHBAEJC JAPNMDMDLII, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, float GDOFDNBBNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82FE850", Offset = "0x82FD450", VA = "0x1882FE850")]
	private static void LFICDBNPENE(this CPLPDHBAEJC JAPNMDMDLII, int LCCBBMBENOH, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, float GDOFDNBBNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82FF3D0", Offset = "0x82FDFD0", VA = "0x1882FF3D0")]
	private static bool NJJFHGGJOLI(this CPLPDHBAEJC JAPNMDMDLII, int LCCBBMBENOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82FDD60", Offset = "0x82FC960", VA = "0x1882FDD60")]
	private static void DKMBPCBFKIO(this CPLPDHBAEJC JAPNMDMDLII, int LCCBBMBENOH, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, float GDOFDNBBNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82FE140", Offset = "0x82FCD40", VA = "0x1882FE140")]
	public static Vector3 KKOCDHCNOLL(this CPLPDHBAEJC JAPNMDMDLII, int LCCBBMBENOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82FE000", Offset = "0x82FCC00", VA = "0x1882FE000")]
	public static Quaternion EFKBJCHFLLA(this CPLPDHBAEJC JAPNMDMDLII, int LCCBBMBENOH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82FE630", Offset = "0x82FD230", VA = "0x1882FE630")]
	public static Vector3 LDPCAFGEPNK(EHENCINGLKE HHPCFHFLKHA, Vector3 FEMJLOIOGIK, Vector3? ANMGJLFKAHA, Vector3 MJKEFOMPECH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface CPIAKFIHKCE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIPKGGDBNBO(EntityQuery FKCEPNMCPIG, EntityManager HFPCKBDCDBJ, CDLMMLHCEPH IEAEJIDPCDO, GEPCMKHFHDK LBFIEBENCOM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface PCIMKBDFCKL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType FMPPPGIFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOKGDHPNJCN(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBGAADCDHFC(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHNBBFNCGMJ(ANFGPDFLLEL FNCAMBMILEM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class KLCPMNCMEHJ : CPIAKFIHKCE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8307A00", Offset = "0x8306600", VA = "0x188307A00", Slot = "4")]
	public void KIPKGGDBNBO(EntityQuery FKCEPNMCPIG, EntityManager HFPCKBDCDBJ, CDLMMLHCEPH IEAEJIDPCDO, GEPCMKHFHDK LBFIEBENCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KLCPMNCMEHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class AFJLMJAMCBM : CPIAKFIHKCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KEFCOOGBPIF HPKPAJMIMBN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
	public AFJLMJAMCBM(KEFCOOGBPIF HPKPAJMIMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82F4530", Offset = "0x82F3130", VA = "0x1882F4530", Slot = "4")]
	public void KIPKGGDBNBO(EntityQuery FKCEPNMCPIG, EntityManager HFPCKBDCDBJ, CDLMMLHCEPH IEAEJIDPCDO, GEPCMKHFHDK LBFIEBENCOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class JHEPALANAMM : CPIAKFIHKCE
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8307220", Offset = "0x8305E20", VA = "0x188307220", Slot = "4")]
	public void KIPKGGDBNBO(EntityQuery FKCEPNMCPIG, EntityManager HFPCKBDCDBJ, CDLMMLHCEPH IEAEJIDPCDO, GEPCMKHFHDK LBFIEBENCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public JHEPALANAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GNGNDHCPFCN : PCIMKBDFCKL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType FMPPPGIFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8300A00", Offset = "0x82FF600", VA = "0x188300A00", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8300A30", Offset = "0x82FF630", VA = "0x188300A30", Slot = "5")]
	public void KOKGDHPNJCN(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8300CB0", Offset = "0x82FF8B0", VA = "0x188300CB0", Slot = "6")]
	public void MBGAADCDHFC(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83009B0", Offset = "0x82FF5B0", VA = "0x1883009B0", Slot = "7")]
	public void BHNBBFNCGMJ(ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GNGNDHCPFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OJMGBAKBKKD : PCIMKBDFCKL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType FMPPPGIFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x830E230", Offset = "0x830CE30", VA = "0x18830E230", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x830E260", Offset = "0x830CE60", VA = "0x18830E260", Slot = "5")]
	public void KOKGDHPNJCN(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x830E4E0", Offset = "0x830D0E0", VA = "0x18830E4E0", Slot = "6")]
	public void MBGAADCDHFC(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x830E1E0", Offset = "0x830CDE0", VA = "0x18830E1E0", Slot = "7")]
	public void BHNBBFNCGMJ(ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public OJMGBAKBKKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FKPMCAPJKAM : PCIMKBDFCKL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType FMPPPGIFMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82FF930", Offset = "0x82FE530", VA = "0x1882FF930", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82FF960", Offset = "0x82FE560", VA = "0x1882FF960", Slot = "5")]
	public void KOKGDHPNJCN(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82FFBE0", Offset = "0x82FE7E0", VA = "0x1882FFBE0", Slot = "6")]
	public void MBGAADCDHFC(EntityQuery FKCEPNMCPIG, ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82FF8E0", Offset = "0x82FE4E0", VA = "0x1882FF8E0", Slot = "7")]
	public void BHNBBFNCGMJ(ANFGPDFLLEL FNCAMBMILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public FKPMCAPJKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KKBCHOOIGHE : DJDDGPLMPFH, PNNOEJFPBEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CDLMMLHCEPH IEAEJIDPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PJCKLHFCOMI DFKEDMFGFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GEPCMKHFHDK LBFIEBENCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, CPIAKFIHKCE adapter)> LKEKMPIOEJG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8307550", Offset = "0x8306150", VA = "0x188307550", Slot = "15")]
	public virtual void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83075E0", Offset = "0x83061E0", VA = "0x1883075E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83073F0", Offset = "0x8305FF0", VA = "0x1883073F0")]
	private void DCCKILAGHHM(EntityQueryDesc LHELDJOCKIF, CPIAKFIHKCE JLDPFJAMHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8307810", Offset = "0x8306410", VA = "0x188307810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
	public KKBCHOOIGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class HLEMHJDECEM : DJDDGPLMPFH, PNNOEJFPBEL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class HIOEGCDHOGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery JFIPFIDFMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery BNBHHDMKBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery JGLEOBJIPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery CNDLIFEOOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery ONDNJCKKOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery NKMIJGNBFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery EONFIBEAELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PCIMKBDFCKL GKLKDLOLEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType AEJOPHPBLBC;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HIOEGCDHOGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CDLMMLHCEPH IEAEJIDPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GEPCMKHFHDK LBFIEBENCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PJCKLHFCOMI DFKEDMFGFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<HIOEGCDHOGH> LKEKMPIOEJG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8306840", Offset = "0x8305440", VA = "0x188306840", Slot = "14")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83068D0", Offset = "0x83054D0", VA = "0x1883068D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8306A50", Offset = "0x8305650", VA = "0x188306A50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83063F0", Offset = "0x8304FF0", VA = "0x1883063F0")]
	private void GBCLPADMGFH(HIOEGCDHOGH PEAODMOPBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8305C80", Offset = "0x8304880", VA = "0x188305C80")]
	private void DCCKILAGHHM(PCIMKBDFCKL GKLKDLOLEGM, ComponentType IHGMOPEBLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
	public HLEMHJDECEM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct CGIEDEJBPBK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct EOKLFBDENAM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct PEHONHMHGLE : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(GEPCMKHFHDK), new string[] { })]
public class PGGGPNNABPH : GEPCMKHFHDK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HEODKAOIMMP IONMHLHENEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HEODKAOIMMP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PGGGPNNABPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(KHJEKAIJGGO), new string[] { })]
public class PBAMNIENLPP : KHJEKAIJGGO, HFOOIEJDCCF, FPAFPEELFNB, EFGOCCCLGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private JAAAEPMFELN FPCAGECIADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private CDLMMLHCEPH IEAEJIDPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private HAOJOPIKEAB AMCCDFCIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity EPPDEEDDHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private ILKDGFHCBCG FDDGCGAJOIC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x830EAB0", Offset = "0x830D6B0", VA = "0x18830EAB0", Slot = "4")]
	public bool MJAKGMLCAIJ(CFFDHOCCNNL ILPOHEPFNOO, ODGPDIMIKDO BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x830E760", Offset = "0x830D360", VA = "0x18830E760", Slot = "5")]
	public ILKDGFHCBCG FICFLPMLKNI()
	{
		return default(ILKDGFHCBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x830EB90", Offset = "0x830D790", VA = "0x18830EB90", Slot = "6")]
	public void OPOAIGHCBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x830EA20", Offset = "0x830D620", VA = "0x18830EA20", Slot = "7")]
	private void HMKAAGAACIK(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x12C1460", Offset = "0x12C0060", VA = "0x1812C1460", Slot = "8")]
	private void GJFDCMOAOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PBAMNIENLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(LEBDAJPFOGA), new string[] { })]
public class DBBEOBNJPLJ : LEBDAJPFOGA
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82F6AE0", Offset = "0x82F56E0", VA = "0x1882F6AE0", Slot = "4")]
	public void JOGPOOIPELK(World FPCAGECIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82F61A0", Offset = "0x82F4DA0", VA = "0x1882F61A0", Slot = "5")]
	public void BAFCHILNNLE(World FPCAGECIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82F6150", Offset = "0x82F4D50", VA = "0x1882F6150", Slot = "6")]
	public ComponentSystemBase AIBJOMJBCEN(World FPCAGECIADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82F6B60", Offset = "0x82F5760", VA = "0x1882F6B60", Slot = "7")]
	public void NCOIMDDGLID(World FPCAGECIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82F61F0", Offset = "0x82F4DF0", VA = "0x1882F61F0", Slot = "8")]
	public void FFGBOHAKOGL(World FPCAGECIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82F6A80", Offset = "0x82F5680", VA = "0x1882F6A80", Slot = "9")]
	public void JOFCFICGGKB(World FPCAGECIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82F6BC0", Offset = "0x82F57C0", VA = "0x1882F6BC0", Slot = "10")]
	public void NNNFMODJIGJ(World FPCAGECIADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82F6250", Offset = "0x82F4E50", VA = "0x1882F6250", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> IDNFILGGEOH()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public DBBEOBNJPLJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct KGDFNHHJNNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct JKGHOFBGBHC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LOENPINCHCE : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEBKPDHAODJ FLKBGJODOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8308DD0", Offset = "0x83079D0", VA = "0x188308DD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8308D60", Offset = "0x8307960", VA = "0x188308D60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public LOENPINCHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct MEFDGFAEGBF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ILKDGFHCBCG OLFIIEIGDNE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static MEFDGFAEGBF KDDDGPNBGLG(ILKDGFHCBCG PHMFHDLJBOO)
	{
		return default(MEFDGFAEGBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NJEBAFCGNAA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CEIOAGBLDNK GLIDGNJHAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x830B630", Offset = "0x830A230", VA = "0x18830B630", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public NJEBAFCGNAA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct HLLOKGKDILJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct BFLLFFANOKF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IFPPNNMCBNN ODLKKJDLFPL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static BFLLFFANOKF KDDDGPNBGLG(IFPPNNMCBNN PHMFHDLJBOO)
	{
		return default(BFLLFFANOKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct HLPECFIGEKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ILKDGFHCBCG OLFIIEIGDNE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static HLPECFIGEKH KDDDGPNBGLG(ILKDGFHCBCG PHMFHDLJBOO)
	{
		return default(HLPECFIGEKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IODJDKGLAIO : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FGNJANJHMFN GLFDKOMLPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8306D60", Offset = "0x8305960", VA = "0x188306D60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8306CF0", Offset = "0x83058F0", VA = "0x188306CF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public IODJDKGLAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HIDAOHKEPKB : FNLJLBLGIHH, IEBKPDHAODJ, IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GKNAEPKFNMA HCELMBEODLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE4A4E0", Offset = "0xE490E0", VA = "0x180E4A4E0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(GKNAEPKFNMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AIAIFDLKLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD1C170", Offset = "0xD1AD70", VA = "0x180D1C170", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 CNAFFGNNJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x12050D0", Offset = "0x1203CD0", VA = "0x1812050D0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8305BE0", Offset = "0x83047E0", VA = "0x188305BE0")]
	public HIDAOHKEPKB(UniformTRS ENNHNJJNKNI, MDCMDKHFPFC IEPNOLIPIDE, float CAOAAOPJCFM, float3 OKLEHNCNIBL, HEEBNBDCPDH FGHGOHHNEEE, BNIMJFMEDEA JMANHKKLHEC, GKNAEPKFNMA NEIMHFIDMMK, float3 JIIJLIJJNIJ, bool NAJOABFECCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8305B90", Offset = "0x8304790", VA = "0x188305B90", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FLMDOOLDIKM : FNLJLBLGIHH, FGNJANJHMFN, IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<FKNJJMFFJFL> NOKEMKJHHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly IJJMALMNFPP KCHMACEBLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float MMDCHBAKHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int NGAFEKGAMPO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DHEBGNPKEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82FFFD0", Offset = "0x82FEBD0", VA = "0x1882FFFD0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JKMDJDJCGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82FFFF0", Offset = "0x82FEBF0", VA = "0x1882FFFF0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PFJLFFLPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82FFFE0", Offset = "0x82FEBE0", VA = "0x1882FFFE0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DOJIAPEBMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAB96A0", Offset = "0xAB82A0", VA = "0x180AB96A0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JPEGBLFKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xDAA020", Offset = "0xDA8C20", VA = "0x180DAA020", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IAAPJBOFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1024D40", Offset = "0x1023940", VA = "0x181024D40", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82FFF20", Offset = "0x82FEB20", VA = "0x1882FFF20")]
	public FLMDOOLDIKM(UniformTRS ENNHNJJNKNI, MDCMDKHFPFC IEPNOLIPIDE, float CAOAAOPJCFM, float3 OKLEHNCNIBL, HEEBNBDCPDH FGHGOHHNEEE, BNIMJFMEDEA JMANHKKLHEC, IJJMALMNFPP KCHMACEBLIA, float MMDCHBAKHMP, int NGAFEKGAMPO, NativeArray<FKNJJMFFJFL> NOKEMKJHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x121CDC0", Offset = "0x121B9C0", VA = "0x18121CDC0", Slot = "33")]
	public NativeArray<FKNJJMFFJFL> GetNativeCurvePoints()
	{
		return default(NativeArray<FKNJJMFFJFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82FFE60", Offset = "0x82FEA60", VA = "0x1882FFE60", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MEDIFBPFLKG : GIODBOELDNP, IEBKPDHAODJ, IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<LDLEEKNJJFJ, GKNAEPKFNMA> PEBNMMLPEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private GKNAEPKFNMA NEIMHFIDMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool NAJOABFECCF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private GKNAEPKFNMA CGBDKCBLFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160", Slot = "28")]
		get
		{
			return default(GKNAEPKFNMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool ICIIAKPLJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xF64F50", Offset = "0xF63B50", VA = "0x180F64F50", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 CNAFFGNNJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8309C40", Offset = "0x8308840", VA = "0x188309C40", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8309C20", Offset = "0x8308820", VA = "0x188309C20")]
	public MEDIFBPFLKG(CFFDHOCCNNL DBEBLODPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8309590", Offset = "0x8308190", VA = "0x188309590", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83095E0", Offset = "0x83081E0", VA = "0x1883095E0", Slot = "26")]
	public override void MONBEGLCAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PNLGFEDHMNK : CFAKEGEDLNO, CEIOAGBLDNK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject LEGOICPIAMD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject LKABGMIDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x830F260", Offset = "0x830DE60", VA = "0x18830F260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MFFDCMMCMLL AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x830F440", Offset = "0x830E040", VA = "0x18830F440", Slot = "15")]
		get
		{
			return default(MFFDCMMCMLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EMCDMLHOHNO FNEFDBHFLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x830F690", Offset = "0x830E290", VA = "0x18830F690", Slot = "16")]
		get
		{
			return default(EMCDMLHOHNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x830F540", Offset = "0x830E140", VA = "0x18830F540")]
	public PNLGFEDHMNK(CFFDHOCCNNL ILPOHEPFNOO, bool DBGKKHCMNHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x830F0A0", Offset = "0x830DCA0", VA = "0x18830F0A0")]
	public void DCMGAEFCKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x830F440", Offset = "0x830E040", VA = "0x18830F440")]
	protected MFFDCMMCMLL OCIKOEPKLEE()
	{
		return default(MFFDCMMCMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x830F2F0", Offset = "0x830DEF0", VA = "0x18830F2F0")]
	private static bool MDKAAIJBKND(CFFDHOCCNNL OEEPIJMJAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x830F230", Offset = "0x830DE30", VA = "0x18830F230", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CBNFDAGEFBN : GIODBOELDNP, FGNJANJHMFN, IDFFCAJFBJL, IDisposable, KOACOFFPOFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<FKNJJMFFJFL> NOKEMKJHHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool EBMHLAIEPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool ICOHOLKANJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float MMDCHBAKHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int NGAFEKGAMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool OIOLMOIKPAG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool KDLAHLMOJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD297D0", Offset = "0xD283D0", VA = "0x180D297D0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool CJBCJBABGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA93C0", Offset = "0xAA7FC0", VA = "0x180AA93C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float HGAPGMLHMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEB4910", Offset = "0xEB3510", VA = "0x180EB4910", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int BGLGGJCLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE4A4E0", Offset = "0xE490E0", VA = "0x180E4A4E0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool NPGPIMEPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD1C170", Offset = "0xD1AD70", VA = "0x180D1C170", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int PPMFJINNBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82F4BF0", Offset = "0x82F37F0", VA = "0x1882F4BF0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int JBMFJJDDIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82F4CF0", Offset = "0x82F38F0", VA = "0x1882F4CF0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82F4F80", Offset = "0x82F3B80", VA = "0x1882F4F80")]
	public CBNFDAGEFBN(CFFDHOCCNNL DBEBLODPEEN, [Optional] NativeList<FKNJJMFFJFL> NOKEMKJHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82F4C10", Offset = "0x82F3810", VA = "0x1882F4C10", Slot = "26")]
	public override void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82F4800", Offset = "0x82F3400", VA = "0x1882F4800", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x82F48F0", Offset = "0x82F34F0", VA = "0x1882F48F0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82F4B90", Offset = "0x82F3790", VA = "0x1882F4B90")]
	public void HAOFCEICPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82F49C0", Offset = "0x82F35C0", VA = "0x1882F49C0", Slot = "34")]
	public NativeArray<FKNJJMFFJFL> GetNativeCurvePoints()
	{
		return default(NativeArray<FKNJJMFFJFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x82F46B0", Offset = "0x82F32B0", VA = "0x1882F46B0", Slot = "35")]
	private Vector3 CCGKLNDCPLN(int DFLLFMHMLAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82F4680", Offset = "0x82F3280", VA = "0x1882F4680", Slot = "36")]
	private Quaternion BGNDMMCFAII(int DFLLFMHMLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x82F4DE0", Offset = "0x82F39E0", VA = "0x1882F4DE0", Slot = "37")]
	private float OLMAAOMHEMA(int DFLLFMHMLAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x82F4950", Offset = "0x82F3550", VA = "0x1882F4950")]
	private NativeArray<Entity> EMPBHAOBCGK()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class EIFKPDFBMDG : NIJOJFAHCHM
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8C0", Offset = "0x82FA4C0", VA = "0x1882FB8C0", Slot = "15")]
	protected override ComponentSystemBase DMALEDNBNJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82FBCE0", Offset = "0x82FA8E0", VA = "0x1882FBCE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x82FBCF0", Offset = "0x82FA8F0", VA = "0x1882FBCF0")]
	public EIFKPDFBMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DPEAOOAAEJL]
public sealed class OAEMFFHNDNC : DKCKOPGODPB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery LPHINPNOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery BMFGGBPCEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery DOFBFJKBNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery MIDCNNKINJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery HPIGHHEBPMC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x830D5E0", Offset = "0x830C1E0", VA = "0x18830D5E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x830D940", Offset = "0x830C540", VA = "0x18830D940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x830D1D0", Offset = "0x830BDD0", VA = "0x18830D1D0")]
	private void KFMDDJEEMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x830D0C0", Offset = "0x830BCC0", VA = "0x18830D0C0")]
	private void FEDFEAJHEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x830D410", Offset = "0x830C010", VA = "0x18830D410")]
	private void NHCPFBMCINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x830CE70", Offset = "0x830BA70", VA = "0x18830CE70")]
	private void CCEMPDJPJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x830CF70", Offset = "0x830BB70", VA = "0x18830CF70")]
	private void EBBJKCGPLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x830D070", Offset = "0x830BC70", VA = "0x18830D070")]
	private NativeList<Entity> FCAPEIFJEAF(NativeArray<Entity> ADEOCFOIFAB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x830CE20", Offset = "0x830BA20", VA = "0x18830CE20")]
	private NativeList<Entity> AJPOPHMJOMF(NativeArray<Entity> ADEOCFOIFAB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x830D3B0", Offset = "0x830BFB0", VA = "0x18830D3B0")]
	private void LDFLBNEBIPN(NativeArray<Entity> ADEOCFOIFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public OAEMFFHNDNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DPEAOOAAEJL]
public sealed class NIOPABCOHOD : DKCKOPGODPB, PNNOEJFPBEL
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery ALPCLFDECPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery CHGDCBPMKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery JGLEOBJIPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KHJEKAIJGGO MGNCNHOPIIK;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x830B3B0", Offset = "0x8309FB0", VA = "0x18830B3B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x830AB10", Offset = "0x8309710", VA = "0x18830AB10", Slot = "15")]
	public override void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x830B580", Offset = "0x830A180", VA = "0x18830B580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8309DB0", Offset = "0x83089B0", VA = "0x188309DB0")]
	private void CICKMDJNJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x830AD20", Offset = "0x8309920", VA = "0x18830AD20")]
	private void NJOKAMPJLCF(NativeParallelHashSet<ILKDGFHCBCG> DHGICNNGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x830A0D0", Offset = "0x8308CD0", VA = "0x18830A0D0")]
	private void EJIMCCLGLIC(NativeParallelHashSet<ILKDGFHCBCG> DHGICNNGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x830A760", Offset = "0x8309360", VA = "0x18830A760")]
	private void GOEOOMJOFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8309D10", Offset = "0x8308910", VA = "0x188309D10")]
	private bool AFDJHLPKOEG(Entity CGLPEGHHGMM, [Out] ILKDGFHCBCG OLFIIEIGDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x830AB70", Offset = "0x8309770", VA = "0x18830AB70")]
	private bool LIBCACINJMM(Entity CGLPEGHHGMM, [Out] ILKDGFHCBCG OLFIIEIGDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public NIOPABCOHOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DPEAOOAAEJL]
public sealed class NKGCOMIDHOM : DKCKOPGODPB
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery AOALGIKFOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery CBFEINLFDBH;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x830BC90", Offset = "0x830A890", VA = "0x18830BC90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x830BDE0", Offset = "0x830A9E0", VA = "0x18830BDE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x830B990", Offset = "0x830A590", VA = "0x18830B990")]
	private void NJOKAMPJLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x830B6A0", Offset = "0x830A2A0", VA = "0x18830B6A0")]
	private void EJIMCCLGLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public NKGCOMIDHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EKLMJONJLBA : DKCKOPGODPB, PNNOEJFPBEL
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct HHFNCNIOBMF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob LNFBDFOCNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob NNHHMNOOJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob LMLGLAJJJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob AALMNNMMAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle MEDJONJFFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<HLPECFIGEKH> KABKNFBOAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<ILKDGFHCBCG> LIKKNKFDNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> FPOLLEHBLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> FHAGDAAPLBI;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8305B10", Offset = "0x8304710", VA = "0x188305B10", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8305A30", Offset = "0x8304630", VA = "0x188305A30")]
		private void EMPCEGKOGND(EntityQueryInJob FKCEPNMCPIG, NativeList<Entity> NEOFHGAMPBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct ACPIBBPMDLE : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle MEDJONJFFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<HLPECFIGEKH> KABKNFBOAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<ILKDGFHCBCG> LIKKNKFDNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> NEOFHGAMPBA;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82F42F0", Offset = "0x82F2EF0", VA = "0x1882F42F0", Slot = "4")]
		public void Execute(ArchetypeChunk BIIFLPGDNMN, int GNHAIEDDMNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct CHPAMPHNIAM : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle MEDJONJFFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> GODIHAFFMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<BFLLFFANOKF> KIPBDGLDOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<MEFDGFAEGBF> HIBNNDFIODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<HLPECFIGEKH> ADDADPEHJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<ILKDGFHCBCG> LIKKNKFDNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> IIKENMIIKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<BFLLFFANOKF> BCJHEBBJHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<ILKDGFHCBCG> PGMBLKPLMLK;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82F5C70", Offset = "0x82F4870", VA = "0x1882F5C70", Slot = "4")]
		public void Execute(ArchetypeChunk BIIFLPGDNMN, int GNHAIEDDMNM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery LNFBDFOCNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery NNHHMNOOJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery LMLGLAJJJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery AALMNNMMAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery ODPAAAKJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery FCGNFLFHBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery KMBMAFEIDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private KHJEKAIJGGO HABPFMDHLLK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x82FD130", Offset = "0x82FBD30", VA = "0x1882FD130", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82FC690", Offset = "0x82FB290", VA = "0x1882FC690", Slot = "15")]
	public override void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x82FD6B0", Offset = "0x82FC2B0", VA = "0x1882FD6B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82FC6F0", Offset = "0x82FB2F0", VA = "0x1882FC6F0")]
	private void KGDHKFJKPHN(NativeParallelHashSet<ILKDGFHCBCG> LIKKNKFDNDL, int PPMBNBLCOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82FC240", Offset = "0x82FAE40", VA = "0x1882FC240")]
	private void FKEPJGBKBPI(NativeParallelHashSet<ILKDGFHCBCG> LIKKNKFDNDL, int BKPNGFMJMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82FCCF0", Offset = "0x82FB8F0", VA = "0x1882FCCF0")]
	private void ODIMNKLBGJO(NativeParallelHashSet<ILKDGFHCBCG> LIKKNKFDNDL, int JOJMHDCCIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82FBEB0", Offset = "0x82FAAB0", VA = "0x1882FBEB0")]
	private void DPIMAPIFENF(NativeParallelHashSet<ILKDGFHCBCG> DHGICNNGDNE, int MNPMIBMOFOA, int HKIDMAIMNEH, int DEFJICMNLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x82FBD00", Offset = "0x82FA900", VA = "0x1882FBD00")]
	private void DFADOMFHAEK(Entity OIJOFLLBJDA, IFPPNNMCBNN JLJINLNFMOE, ILKDGFHCBCG OLFIIEIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public EKLMJONJLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OJKPPCFBOJO : DKCKOPGODPB
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery AOENCJPHIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery HAHBOEPMNJI;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x830DA10", Offset = "0x830C610", VA = "0x18830DA10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x830DC50", Offset = "0x830C850", VA = "0x18830DC50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public OJKPPCFBOJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GBLMNMMJAKH : DKCKOPGODPB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct OJNJEELIEPE : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery EFFJMBBBCIJ;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8300200", Offset = "0x82FEE00", VA = "0x188300200", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8300340", Offset = "0x82FEF40", VA = "0x188300340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public GBLMNMMJAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DPEAOOAAEJL]
internal class NPDMNOJKJHD : DKCKOPGODPB
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class KLKJLNNECMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery KDLOJJIEPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery FLGMCHIIDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GPGADGMFJLG KGGIHJBLKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType IBOJNJGJHFH;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public KLKJLNNECMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void GPGADGMFJLG(NativeArray<IFPPNNMCBNN> PHMFHDLJBOO, ANFGPDFLLEL FNCAMBMILEM);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<KLKJLNNECMM> LKEKMPIOEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PJCKLHFCOMI DFKEDMFGFIB;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x830C370", Offset = "0x830AF70", VA = "0x18830C370", Slot = "15")]
	public override void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x830C3D0", Offset = "0x830AFD0", VA = "0x18830C3D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x830C560", Offset = "0x830B160", VA = "0x18830C560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD250", Offset = "0x3DCBE50", VA = "0x183DCD250")]
	private void DCCKILAGHHM<T>(GPGADGMFJLG KGGIHJBLKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x830C1D0", Offset = "0x830ADD0", VA = "0x18830C1D0")]
	private static void CHDLJEPHAAI(NativeArray<IFPPNNMCBNN> PFNBMKKIEIH, ANFGPDFLLEL DKNFJFDKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x830BE90", Offset = "0x830AA90", VA = "0x18830BE90")]
	private static void ALGCBPEIELP(NativeArray<IFPPNNMCBNN> PFNBMKKIEIH, ANFGPDFLLEL DKNFJFDKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x830C030", Offset = "0x830AC30", VA = "0x18830C030")]
	private static void CBANCIKJPFN(NativeArray<IFPPNNMCBNN> PFNBMKKIEIH, ANFGPDFLLEL DKNFJFDKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public NPDMNOJKJHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DPEAOOAAEJL]
public sealed class GECBCIHKIDA : DKCKOPGODPB
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery FKCEPNMCPIG;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8300570", Offset = "0x82FF170", VA = "0x188300570", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct JNJMLCDNJJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS ENNHNJJNKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData HDLJOMDGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public GKNAEPKFNMA NEIMHFIDMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 JIIJLIJJNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool NAJOABFECCF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[JCFJPPCKIAC(Lifetime.LoadInstance)]
public struct KHNPMFPDLNH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity CMBCIMNOCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> PDBLAMJNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> HFDBLHNGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<JNJMLCDNJJF> OHAFAIOAKIP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8307360", Offset = "0x8305F60", VA = "0x188307360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(KLPOEOCCDOG), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class KLPOEOCCDOG : PNNOEJFPBEL, IBPJLLPNJDI, FPAFPEELFNB, EFGOCCCLGDB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct IOKACFPKAHJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly KLPOEOCCDOG IEPNOLIPIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool FJBEOPCDHHE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x19E6500", Offset = "0x19E5100", VA = "0x1819E6500")]
		public IOKACFPKAHJ(KLPOEOCCDOG IEPNOLIPIDE, bool FJBEOPCDHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83070F0", Offset = "0x8305CF0", VA = "0x1883070F0")]
		public Queue<HGDCADLIJCP>.Enumerator MIEHOANGBJG()
		{
			return default(Queue<HGDCADLIJCP>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8306DB0", Offset = "0x83059B0", VA = "0x188306DB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private HAOJOPIKEAB LAIPFPANCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private CLNBIBBJHAN LMEBJHJLDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<FKNJJMFFJFL>> GEMCADNAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> PONDMCHCEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<IFPPNNMCBNN> FNEDANEEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private OCKOPEIOEME<HGDCADLIJCP> DDJLEINGMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OCKOPEIOEME<KHNPMFPDLNH> NHOFHBAPDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private OCKOPEIOEME<MPDIEANFNJJ> JJOEAFKJFLK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83082F0", Offset = "0x8306EF0", VA = "0x1883082F0", Slot = "4")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8308770", Offset = "0x8307370", VA = "0x188308770")]
	public void LCIFPHANDFC(NativeList<FKNJJMFFJFL> PMNENKNDJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x83081A0", Offset = "0x8306DA0", VA = "0x1883081A0")]
	public void IHFJJLMPFIN(Entity IEPNOLIPIDE, [In] EAICLJOGAIB<GameObject> CFEGOLNKBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8307E30", Offset = "0x8306A30", VA = "0x188307E30")]
	public void EOGOAFBJMIN(NativeList<IFPPNNMCBNN> PFNBMKKIEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8308540", Offset = "0x8307140", VA = "0x188308540")]
	public void JOFCFICGGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8308820", Offset = "0x8307420", VA = "0x188308820")]
	public void PBNOBCPFAAM(CDDCNNEAHAH GHKGDJLGKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8307CB0", Offset = "0x83068B0", VA = "0x188307CB0")]
	public JobHandle ADDGEJALDFN([In] HGDCADLIJCP HLMEMBFCHLD, JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8307C10", Offset = "0x8306810", VA = "0x188307C10")]
	public JobHandle ADDGEJALDFN([In] KHNPMFPDLNH HLMEMBFCHLD, JobHandle OIHAJOEEKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F85D40", Offset = "0x7F84940", VA = "0x187F85D40")]
	public IOKACFPKAHJ NNHDMOILIHN(bool FJBEOPCDHHE)
	{
		return default(IOKACFPKAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8308150", Offset = "0x8306D50", VA = "0x188308150")]
	public OPIKBDNKOJF<KHNPMFPDLNH> HPNOJHOLLMM()
	{
		return default(OPIKBDNKOJF<KHNPMFPDLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x83084F0", Offset = "0x83070F0", VA = "0x1883084F0")]
	public OPIKBDNKOJF<MPDIEANFNJJ> JKEGEGENLJJ()
	{
		return default(OPIKBDNKOJF<MPDIEANFNJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8307EC0", Offset = "0x8306AC0", VA = "0x188307EC0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8307D50", Offset = "0x8306950", VA = "0x188307D50", Slot = "5")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x83080E0", Offset = "0x8306CE0", VA = "0x1883080E0", Slot = "6")]
	private void HMKAAGAACIK(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x12C55A0", Offset = "0x12C41A0", VA = "0x1812C55A0", Slot = "7")]
	private void GJFDCMOAOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KLPOEOCCDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct CNOEDHNBEHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS ENNHNJJNKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData HDLJOMDGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public LIACMAGLFCP KCHMACEBLIA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[JCFJPPCKIAC(Lifetime.LoadInstance)]
public struct HGDCADLIJCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity CMBCIMNOCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> ADEOCFOIFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> PDBLAMJNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> HFDBLHNGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<FPNBEMALHAC> FLPHPIGMBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<FKNJJMFFJFL> PMNENKNDJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<CNOEDHNBEHE> LDJDOJHKMGI;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8305950", Offset = "0x8304550", VA = "0x188305950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8305960", Offset = "0x8304560", VA = "0x188305960")]
	public void EDJAHJBIEKL(bool FJBEOPCDHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(JBNCCNFPFKK), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class JBNCCNFPFKK : HPINOMAFHJF, FPAFPEELFNB, EFGOCCCLGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private KLPOEOCCDOG KDDCKHLGOAP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8307200", Offset = "0x8305E00", VA = "0x188307200", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x83071B0", Offset = "0x8305DB0", VA = "0x1883071B0", Slot = "5")]
	private void HMKAAGAACIK(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x128AEC0", Offset = "0x1289AC0", VA = "0x18128AEC0", Slot = "6")]
	private void GJFDCMOAOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public JBNCCNFPFKK()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : DKCKOPGODPB, PNNOEJFPBEL
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
			public NativeParallelHashMap<int, GKNAEPKFNMA> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<JNJMLCDNJJF> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8300F30", Offset = "0x82FFB30", VA = "0x188300F30", Slot = "4")]
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
			public NativeArray<FKNJJMFFJFL> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<FPNBEMALHAC> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<CNOEDHNBEHE> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x83012D0", Offset = "0x82FFED0", VA = "0x1883012D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x82F6010", Offset = "0x82F4C10", VA = "0x1882F6010", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x830F840", Offset = "0x830E440", VA = "0x18830F840")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x830F7F0", Offset = "0x830E3F0", VA = "0x18830F7F0")]
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
				float3 LKPFLLBFDOI(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8308E20", Offset = "0x8307A20", VA = "0x188308E20", Slot = "5")]
				public float3 LDHACFFBJCD(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x83091D0", Offset = "0x8307DD0", VA = "0x1883091D0", Slot = "4")]
				public float3 LKPFLLBFDOI(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x830CAF0", Offset = "0x830B6F0", VA = "0x18830CAF0", Slot = "4")]
				public float3 LKPFLLBFDOI(quaternion rotation)
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
			public NativeArray<FPNBEMALHAC> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<FKNJJMFFJFL> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8302440", Offset = "0x8301040", VA = "0x188302440", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x83042D0", Offset = "0x8302ED0", VA = "0x1883042D0")]
			private void MEKGKKCBKDH(NativeList<PointSrcData> srcData, NativeList<FKNJJMFFJFL> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8303AE0", Offset = "0x83026E0", VA = "0x188303AE0")]
			public static Vector3 JDJBMILFPBI(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8303EF0", Offset = "0x8302AF0", VA = "0x188303EF0")]
			public static quaternion JLCKKBBPMOJ(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8302040", Offset = "0x8300C40", VA = "0x188302040")]
			private static quaternion DPACKPBLAPM(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8302270", Offset = "0x8300E70", VA = "0x188302270")]
			private static float3 EDKAMCBICAH(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8302A60", Offset = "0x8301660", VA = "0x188302A60")]
			private static quaternion FOIBBDNNJNH(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83051B0", Offset = "0x8303DB0", VA = "0x1883051B0")]
			private static FKNJJMFFJFL NEIKPJBIIKJ(int idx, NativeList<PointSrcData> srcData)
			{
				return default(FKNJJMFFJFL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4379F90", Offset = "0x4378B90", VA = "0x184379F90")]
			private void OAINAIFLNAJ<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8302CD0", Offset = "0x83018D0", VA = "0x188302CD0")]
			private void HBECFFBLFBA(NativeList<PointSrcData> sourcePoints, NativeList<FKNJJMFFJFL> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x83054C0", Offset = "0x83040C0", VA = "0x1883054C0")]
			public static float NOPFONEFPEK(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8301E50", Offset = "0x8300A50", VA = "0x188301E50")]
			private static quaternion CHJKLMHHBIA(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x83041B0", Offset = "0x8302DB0", VA = "0x1883041B0")]
			private static FKNJJMFFJFL LNFIDIFLFKM(PointSrcData point)
			{
				return default(FKNJJMFFJFL);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8304120", Offset = "0x8302D20", VA = "0x188304120")]
			private static FKNJJMFFJFL LNFIDIFLFKM(float3 pos, quaternion rot, float radius)
			{
				return default(FKNJJMFFJFL);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8305420", Offset = "0x8304020", VA = "0x188305420")]
			private static bool NJHMGCOLKBH(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x83057F0", Offset = "0x83043F0", VA = "0x1883057F0")]
			private static float3 PLNAJEKFAKD(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8305640", Offset = "0x8304240", VA = "0x188305640")]
			public static float3 PKIIOADHFDN(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8303F70", Offset = "0x8302B70", VA = "0x188303F70")]
			public static float3 LDHACFFBJCD(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x83019F0", Offset = "0x83005F0", VA = "0x1883019F0")]
			private static quaternion ALMGBDAAGNO(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8302AF0", Offset = "0x83016F0", VA = "0x188302AF0")]
			private static float GAFHLBEDCFD(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x8311630", Offset = "0x8310230", VA = "0x188311630")]
			private void FOBOJFMNNKJ(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8311540", Offset = "0x8310140", VA = "0x188311540", Slot = "4")]
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
			public NativeList<FKNJJMFFJFL> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8313240", Offset = "0x8311E40", VA = "0x188313240")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8313230", Offset = "0x8311E30", VA = "0x188313230", Slot = "4")]
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
			public NativeList<FKNJJMFFJFL> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x83131E0", Offset = "0x8311DE0", VA = "0x1883131E0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x83131D0", Offset = "0x8311DD0", VA = "0x1883131D0", Slot = "4")]
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
			public NativeList<JNJMLCDNJJF> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8301620", Offset = "0x8300220", VA = "0x188301620")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8301610", Offset = "0x8300210", VA = "0x188301610", Slot = "4")]
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
			public NativeList<FPNBEMALHAC> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<CNOEDHNBEHE> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83017F0", Offset = "0x83003F0", VA = "0x1883017F0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83017E0", Offset = "0x83003E0", VA = "0x1883017E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8312DB0", Offset = "0x83119B0", VA = "0x188312DB0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8312DA0", Offset = "0x83119A0", VA = "0x188312DA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly PEOHNMCPNIJ log;

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
		private BDAMIMFHOJA replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private HAOJOPIKEAB objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KLPOEOCCDOG bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private EOAMKLHGDHE ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8310A50", Offset = "0x830F650", VA = "0x188310A50", Slot = "15")]
		public override void InitReferences(MDHHMAKNOBB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8312670", Offset = "0x8311270", VA = "0x188312670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8312760", Offset = "0x8311360", VA = "0x188312760", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83127C0", Offset = "0x83113C0", VA = "0x1883127C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8311200", Offset = "0x830FE00", VA = "0x188311200")]
		private JobHandle LGFIMPAFOMP(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x830FFF0", Offset = "0x830EBF0", VA = "0x18830FFF0")]
		private JobHandle IAMCMCHIPPO(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x830FD20", Offset = "0x830E920", VA = "0x18830FD20")]
		private JobHandle GCLAHMPFHFL(NativeArray<int> pointCount, NativeList<FKNJJMFFJFL> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x830F860", Offset = "0x830E460", VA = "0x18830F860")]
		private JobHandle EGNELCPGBJB(NativeList<FKNJJMFFJFL> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8311710", Offset = "0x8310310", VA = "0x188311710")]
		private JobHandle MBAEDJFOGGB(EntityQuery query, NativeList<FPNBEMALHAC> splinePointRanges, NativeList<FKNJJMFFJFL> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x830FED0", Offset = "0x830EAD0", VA = "0x18830FED0")]
		private JobHandle HIMPOBNMOGO(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8312930", Offset = "0x8311530", VA = "0x188312930")]
		private JobHandle PJFMDBJGNAD(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8310E70", Offset = "0x830FA70", VA = "0x188310E70")]
		private JobHandle JJAAGMPCLJL(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JNJMLCDNJJF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8312A50", Offset = "0x8311650", VA = "0x188312A50")]
		private JobHandle PPBEIGKLFHG(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<FPNBEMALHAC> splinePointRanges, [Out] NativeList<CNOEDHNBEHE> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8310AF0", Offset = "0x830F6F0", VA = "0x188310AF0")]
		private JobHandle JHOKMANKKGG(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8311E10", Offset = "0x8310A10", VA = "0x188311E10")]
		private JobHandle OGNACCOADOL(EntityQuery query, NativeList<JNJMLCDNJJF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x830F900", Offset = "0x830E500", VA = "0x18830F900")]
		private static NativeParallelHashMap<int, GKNAEPKFNMA> BMBEEIPLHAA()
		{
			return default(NativeParallelHashMap<int, GKNAEPKFNMA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x83106B0", Offset = "0x830F2B0", VA = "0x1883106B0")]
		private JobHandle ICHAIFINEFM(EntityQuery query, NativeList<FPNBEMALHAC> splinePointRanges, NativeList<FKNJJMFFJFL> splinePointData, NativeList<CNOEDHNBEHE> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8311BE0", Offset = "0x83107E0", VA = "0x188311BE0")]
		private JobHandle MPAJPACENGD(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x830FD20", Offset = "0x830E920", VA = "0x18830FD20")]
		private JobHandle OBKFDODCKBL(NativeArray<int> pointCount, NativeList<FKNJJMFFJFL> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x830F860", Offset = "0x830E460", VA = "0x18830F860")]
		private JobHandle AJPKDPLBLOG(NativeList<FKNJJMFFJFL> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8311110", Offset = "0x830FD10", VA = "0x188311110")]
		private JobHandle KKEIAOMNMFL(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JNJMLCDNJJF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x830FDC0", Offset = "0x830E9C0", VA = "0x18830FDC0")]
		private JobHandle GFKMKACNPJO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<FPNBEMALHAC> ranges, NativeList<CNOEDHNBEHE> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8311CC0", Offset = "0x83108C0", VA = "0x188311CC0")]
		private JobHandle NJPFLCADABE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8312320", Offset = "0x8310F20", VA = "0x188312320", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class COGJJABDNMI : DJDDGPLMPFH, PNNOEJFPBEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private KLPOEOCCDOG KDDCKHLGOAP;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x82F5FA0", Offset = "0x82F4BA0", VA = "0x1882F5FA0", Slot = "14")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x82F5FF0", Offset = "0x82F4BF0", VA = "0x1882F5FF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
	public COGJJABDNMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class DMIJILJFEKP : DKCKOPGODPB, PNNOEJFPBEL
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct FJHEDDOAPDC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager HFPCKBDCDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LAHFAPEFACB<T> DEDCAGHHAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int LCCBBMBENOH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4D77D50", Offset = "0x4D76950", VA = "0x184D77D50")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4D78410", Offset = "0x4D77010", VA = "0x184D78410")]
		public FJHEDDOAPDC(EntityManager HFPCKBDCDBJ, LAHFAPEFACB<T> DEDCAGHHAEE, NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x499E8F0", Offset = "0x499D4F0", VA = "0x18499E8F0")]
		public FJHEDDOAPDC<T> MIEHOANGBJG()
		{
			return default(FJHEDDOAPDC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4D77A50", Offset = "0x4D76650", VA = "0x184D77A50")]
		public bool PCJKIKDLNGG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly PEOHNMCPNIJ HOPBCJDOBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CLNBIBBJHAN LMEBJHJLDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private KLPOEOCCDOG KDDCKHLGOAP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x82FA100", Offset = "0x82F8D00", VA = "0x1882FA100", Slot = "15")]
	public override void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x82FA180", Offset = "0x82F8D80", VA = "0x1882FA180")]
	public void NNNFMODJIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x82FA1B0", Offset = "0x82F8DB0", VA = "0x1882FA1B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x82F8B30", Offset = "0x82F7730", VA = "0x1882F8B30")]
	private void HJKGMOPPLDA(MPDIEANFNJJ HLMEMBFCHLD, Mesh[] PCGDPIHLPGE, NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F990", Offset = "0x3A9E590", VA = "0x183A9F990")]
	private FJHEDDOAPDC<T> IBDGIHDEGDG<T>(LAHFAPEFACB<T> DEDCAGHHAEE, NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC) where T : struct
	{
		return default(FJHEDDOAPDC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x82F87A0", Offset = "0x82F73A0", VA = "0x1882F87A0")]
	private void HJFBGLOKMFC(Transform IEPNOLIPIDE, NativeArray<DLBMECHEMBJ> GBDNNKFKMFC, EAICLJOGAIB<GameObject> PDNPOCECEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x82FB330", Offset = "0x82F9F30", VA = "0x1882FB330")]
	private void PJMFAEHOJEO(Transform IEPNOLIPIDE, NativeArray<ANKINDEIHHC> OOCKCNJCKDA, EAICLJOGAIB<GameObject> PDNPOCECEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82F8270", Offset = "0x82F6E70", VA = "0x1882F8270")]
	private void BEIKKCLLPJM(Transform IEPNOLIPIDE, NativeArray<LGNMIPBLNPH> OBECBMFMEAL, EAICLJOGAIB<GameObject> PDNPOCECEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x82F7E40", Offset = "0x82F6A40", VA = "0x1882F7E40")]
	private void BDEAKJNMEGF(Transform IEPNOLIPIDE, NativeArray<AJEJJCBKHOA> PCGDPIHLPGE, Mesh[] KFOEOHJGMOO, EAICLJOGAIB<GameObject> PDNPOCECEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x82F8650", Offset = "0x82F7250", VA = "0x1882F8650")]
	private static void CFJIKJEMIAN(NativeParallelHashSet<Entity> ADEOCFOIFAB, NativeParallelHashSet<Entity> NJHDAKJOHID, NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x82FA040", Offset = "0x82F8C40", VA = "0x1882FA040")]
	private static void IOJALLIBEJJ(NativeList<Entity> ADEANPNALNF, NativeArray<EntityRemapUtility.EntityRemapInfo> DINBNKNLNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x82F7280", Offset = "0x82F5E80", VA = "0x1882F7280")]
	private NativeParallelHashMap<Entity, MEFDGFAEGBF> AOLLKIPILCL(KLPOEOCCDOG.IOKACFPKAHJ EKEMJPPDEPE, OPIKBDNKOJF<KHNPMFPDLNH> LMNAGOEMOAI, List<GameObject> PDNPOCECEBM)
	{
		return default(NativeParallelHashMap<Entity, MEFDGFAEGBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x82F6C30", Offset = "0x82F5830", VA = "0x1882F6C30")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AJBAMCHLKAE(Entity AKNLLEJOBBM)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x82F6D30", Offset = "0x82F5930", VA = "0x1882F6D30")]
	private void ALEOBNNGACE(NativeList<Entity> DAKHDAHLDPF, NativeList<Entity> CNBACDLBPCI, NativeParallelHashMap<Entity, MEFDGFAEGBF> MGHGMNBAGMD, NativeList<FPNBEMALHAC> PMBDFOJBBBF, NativeList<FKNJJMFFJFL> FIMPAIOPINC, NativeList<CNOEDHNBEHE> GEMCADNAIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x82F9C50", Offset = "0x82F8850", VA = "0x1882F9C50")]
	private void IFJNNOBMAMF(NativeList<Entity> ADEOCFOIFAB, NativeList<Entity> PDBLAMJNJNC, NativeParallelHashMap<Entity, MEFDGFAEGBF> MGHGMNBAGMD, NativeList<JNJMLCDNJJF> OHAFAIOAKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x82FB8B0", Offset = "0x82FA4B0", VA = "0x1882FB8B0")]
	public DMIJILJFEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class PKJOIHLFAEE : HFNKDDMMOLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS ENNHNJJNKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly MDCMDKHFPFC IEPNOLIPIDE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject MMBGOBHCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS CGLBHIKNDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x830ECF0", Offset = "0x830D8F0", VA = "0x18830ECF0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 CKMMGEHJKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x830EFB0", Offset = "0x830DBB0", VA = "0x18830EFB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 GPCCKHFNPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x830EE70", Offset = "0x830DA70", VA = "0x18830EE70", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 BGCDKJJEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x830F000", Offset = "0x830DC00", VA = "0x18830F000", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x830ECA0", Offset = "0x830D8A0", VA = "0x18830ECA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion EFMCAAGBKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x830EEC0", Offset = "0x830DAC0", VA = "0x18830EEC0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x830EF10", Offset = "0x830DB10", VA = "0x18830EF10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 IHLGOHAEHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x830EE20", Offset = "0x830DA20", VA = "0x18830EE20", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 ECKOAHNCIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x830EF60", Offset = "0x830DB60", VA = "0x18830EF60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 JPLEEHLGNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x830EDD0", Offset = "0x830D9D0", VA = "0x18830EDD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x830F050", Offset = "0x830DC50", VA = "0x18830F050")]
	public PKJOIHLFAEE(UniformTRS ENNHNJJNKNI, MDCMDKHFPFC IEPNOLIPIDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class FNLJLBLGIHH : PKJOIHLFAEE, IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float CAOAAOPJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 OKLEHNCNIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly HEEBNBDCPDH FGHGOHHNEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly BNIMJFMEDEA JMANHKKLHEC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private MFFDCMMCMLL CDFNCIHGIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83000E0", Offset = "0x82FECE0", VA = "0x1883000E0", Slot = "17")]
		get
		{
			return default(MFFDCMMCMLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS MPALJNFKNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8300000", Offset = "0x82FEC00", VA = "0x188300000", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float FCCBHEBPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAAF0F0", Offset = "0xAADCF0", VA = "0x180AAF0F0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 NILNDLAPHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8300130", Offset = "0x82FED30", VA = "0x188300130", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HEEBNBDCPDH EAGGJOIEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xACDDA0", Offset = "0xACC9A0", VA = "0x180ACDDA0", Slot = "21")]
		get
		{
			return default(HEEBNBDCPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private BNIMJFMEDEA FFDDFIHFEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x141A080", Offset = "0x1418C80", VA = "0x18141A080", Slot = "22")]
		get
		{
			return default(BNIMJFMEDEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool DGEFFKMPFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MPHJOIAJLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8300180", Offset = "0x82FED80", VA = "0x188300180")]
	protected FNLJLBLGIHH(UniformTRS ENNHNJJNKNI, MDCMDKHFPFC IEPNOLIPIDE, float CAOAAOPJCFM, float3 OKLEHNCNIBL, HEEBNBDCPDH FGHGOHHNEEE, BNIMJFMEDEA JMANHKKLHEC)
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
public abstract class CFAKEGEDLNO : HFNKDDMMOLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly CFFDHOCCNNL LNPPHFKBHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected MDCMDKHFPFC ACNBOEGLBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1291950", Offset = "0x1290550", VA = "0x181291950")]
		get
		{
			return default(MDCMDKHFPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity KJHIOGAKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x82F5B20", Offset = "0x82F4720", VA = "0x1882F5B20")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected HAOJOPIKEAB BFFFNMCIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x82F50C0", Offset = "0x82F3CC0", VA = "0x1882F50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected ONGKNFGGJFK NMKMFCLEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x82F5A90", Offset = "0x82F4690", VA = "0x1882F5A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected DDHLMFDNOPE MLGFNFKLABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82F50D0", Offset = "0x82F3CD0", VA = "0x1882F50D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject MMBGOBHCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x82F5AF0", Offset = "0x82F46F0", VA = "0x1882F5AF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS CGLBHIKNDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12CC510", Offset = "0x12CB110", VA = "0x1812CC510", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 CKMMGEHJKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x82F59A0", Offset = "0x82F45A0", VA = "0x1882F59A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 GPCCKHFNPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x82F5410", Offset = "0x82F4010", VA = "0x1882F5410", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 BGCDKJJEIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x82F5B40", Offset = "0x82F4740", VA = "0x1882F5B40", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x82F4FB0", Offset = "0x82F3BB0", VA = "0x1882F4FB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion EFMCAAGBKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x82F5580", Offset = "0x82F4180", VA = "0x1882F5580", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x82F56D0", Offset = "0x82F42D0", VA = "0x1882F56D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 IHLGOHAEHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x82F5320", Offset = "0x82F3F20", VA = "0x1882F5320", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 ECKOAHNCIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x82F57E0", Offset = "0x82F43E0", VA = "0x1882F57E0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 JPLEEHLGNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x82F5160", Offset = "0x82F3D60", VA = "0x1882F5160", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xF1EC10", Offset = "0xF1D810", VA = "0x180F1EC10")]
	protected CFAKEGEDLNO(CFFDHOCCNNL DBEBLODPEEN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x82F56A0", Offset = "0x82F42A0", VA = "0x1882F56A0")]
	public static MFFDCMMCMLL KDDDGPNBGLG(CFAKEGEDLNO KJCIKLJPCMB)
	{
		return default(MFFDCMMCMLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class GDKMEFBDPGJ
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8314130", Offset = "0x8312D30", VA = "0x188314130")]
	public static void EHGLMBAPNAP(NativeArray<Entity> ADEOCFOIFAB, EntityManager HFPCKBDCDBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class MNOCPLCGGGB
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8314DF0", Offset = "0x83139F0", VA = "0x188314DF0")]
	public static void GGEGALEAFLH(NativeArray<Entity> ADEOCFOIFAB, EntityManager HFPCKBDCDBJ, CDDCNNEAHAH KJNDANMPLKO, HAOJOPIKEAB AMCCDFCIJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8314800", Offset = "0x8313400", VA = "0x188314800")]
	public static void ABMMIAAGJJN(NativeArray<Entity> ADEOCFOIFAB, EntityManager HFPCKBDCDBJ, CDDCNNEAHAH KJNDANMPLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8314B10", Offset = "0x8313710", VA = "0x188314B10")]
	public static NativeList<Entity> AJPOPHMJOMF(NativeArray<Entity> ADEOCFOIFAB, EntityManager HFPCKBDCDBJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8314DB0", Offset = "0x83139B0", VA = "0x188314DB0")]
	public static NativeList<Entity> FCAPEIFJEAF(NativeArray<Entity> ADEOCFOIFAB, EntityManager HFPCKBDCDBJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8314B50", Offset = "0x8313750", VA = "0x188314B50")]
	private static NativeList<Entity> AJPOPHMJOMF(NativeArray<Entity> ADEOCFOIFAB, EntityManager HFPCKBDCDBJ, bool NPNEFIIIIJA)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class GIODBOELDNP : CFAKEGEDLNO, IDFFCAJFBJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float CAOAAOPJCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 OKLEHNCNIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private HEEBNBDCPDH FGHGOHHNEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private BNIMJFMEDEA JMANHKKLHEC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager IEBLFDPIILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83144F0", Offset = "0x83130F0", VA = "0x1883144F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected JAAAEPMFELN DPCMCHNFMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x83143A0", Offset = "0x8312FA0", VA = "0x1883143A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData AENGDJNFGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8314400", Offset = "0x8313000", VA = "0x188314400")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private MFFDCMMCMLL CDFNCIHGIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x82F56A0", Offset = "0x82F42A0", VA = "0x1882F56A0", Slot = "17")]
		get
		{
			return default(MFFDCMMCMLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float FCCBHEBPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAB55B0", Offset = "0xAB41B0", VA = "0x180AB55B0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 NILNDLAPHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x13A8BD0", Offset = "0x13A77D0", VA = "0x1813A8BD0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HEEBNBDCPDH EAGGJOIEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C760", Offset = "0xA5B360", VA = "0x180A5C760", Slot = "21")]
		get
		{
			return default(HEEBNBDCPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BNIMJFMEDEA FFDDFIHFEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD070", Offset = "0xAABC70", VA = "0x180AAD070", Slot = "22")]
		get
		{
			return default(BNIMJFMEDEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS MPALJNFKNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8314370", Offset = "0x8312F70", VA = "0x188314370", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MPHJOIAJLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool DGEFFKMPFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8314710", Offset = "0x8313310", VA = "0x188314710")]
	protected GIODBOELDNP(CFFDHOCCNNL DBEBLODPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8314580", Offset = "0x8313180", VA = "0x188314580", Slot = "26")]
	public virtual void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class DKCKOPGODPB : DJDDGPLMPFH, PNNOEJFPBEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected HAOJOPIKEAB AMCCDFCIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private CDLMMLHCEPH IEAEJIDPCDO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected CDDCNNEAHAH LNGPPJAFPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x83140E0", Offset = "0x8312CE0", VA = "0x1883140E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected ANFGPDFLLEL KLALOGMANPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8313F60", Offset = "0x8312B60", VA = "0x188313F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool FLBEEFMLPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8314020", Offset = "0x8312C20", VA = "0x188314020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8313FB0", Offset = "0x8312BB0", VA = "0x188313FB0", Slot = "15")]
	public virtual void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
	protected DKCKOPGODPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AJAAAHJBAHI
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8313D20", Offset = "0x8312920", VA = "0x188313D20")]
	public static void NJANCLPNAIH(NativeArray<Entity> DAKHDAHLDPF, EntityManager HFPCKBDCDBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3818559327
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8315420", Offset = "0x8314020", VA = "0x188315420")]
	public static void BHBOJBGFAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x83156A0", Offset = "0x83142A0", VA = "0x1883156A0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class JCLAFLIFPOP : ContainerPropertyBag<LOENPINCHCE>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x83147A0", Offset = "0x83133A0", VA = "0x1883147A0")]
	public JCLAFLIFPOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class HAMMAAIHMEF : ContainerPropertyBag<NJEBAFCGNAA>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8314740", Offset = "0x8313340", VA = "0x188314740")]
	public HAMMAAIHMEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class OILAMMLNLAK : ContainerPropertyBag<IODJDKGLAIO>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8315200", Offset = "0x8313E00", VA = "0x188315200")]
	public OILAMMLNLAK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8315260", Offset = "0x8313E60", VA = "0x188315260")]
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
