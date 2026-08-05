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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x741D740", Offset = "0x741C540", VA = "0x18741D740", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BA10", Offset = "0x1E0A810", VA = "0x181E0BA10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7428B70", Offset = "0x7427970", VA = "0x187428B70")]
		private void OGIEEDDHGBJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7428FF0", Offset = "0x7427DF0", VA = "0x187428FF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7429050", Offset = "0x7427E50", VA = "0x187429050")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NECPDEIHFCL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7421150", Offset = "0x741FF50", VA = "0x187421150")]
	public static Quaternion IGOEGFJPHNP([In] this GGEMMGDIFCI ELKAABPKIGE, [In] Vector3 GGAAGAFEPHJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IJKKFNPMCEF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x741A7E0", Offset = "0x74195E0", VA = "0x18741A7E0")]
	public static bool BMAPNLPMGBD(this PNAODGFELJJ MPFNEAFMDIA, GEJEIADHCHJ ACCBEMFKLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x741ABC0", Offset = "0x74199C0", VA = "0x18741ABC0")]
	public static bool KAPGHNNBCDI(this PNAODGFELJJ MPFNEAFMDIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x741B3E0", Offset = "0x741A1E0", VA = "0x18741B3E0")]
	public static bool NNNLHKDAEHP(this PNAODGFELJJ MPFNEAFMDIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x741A870", Offset = "0x7419670", VA = "0x18741A870")]
	public static void GCNDDKPFIPF(this PNAODGFELJJ MPFNEAFMDIA, Vector3 EFOJHDJANND, Quaternion PAGDMEDLOGD, float HCPBBIGLAFG, bool GGBMJDIJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x741A360", Offset = "0x7419160", VA = "0x18741A360")]
	public static void BCLOKFFNFPG(this PNAODGFELJJ MPFNEAFMDIA, Vector3 EFOJHDJANND, Quaternion PAGDMEDLOGD, float HCPBBIGLAFG, int IHMFFPLBGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x741C010", Offset = "0x741AE10", VA = "0x18741C010")]
	public static void PKCHGLDKFPH(this PNAODGFELJJ MPFNEAFMDIA, int IHMFFPLBGNC, Vector3 EFOJHDJANND, Quaternion PAGDMEDLOGD, float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x741A820", Offset = "0x7419620", VA = "0x18741A820")]
	public static void EMJEFLCEHBP(this PNAODGFELJJ MPFNEAFMDIA, Vector3 CCCDAPGIFNI, Quaternion MLDGFLAJCNK, float HCPBBIGLAFG, bool GGBMJDIJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x741B6B0", Offset = "0x741A4B0", VA = "0x18741B6B0")]
	private static void OPGNGBOPCFA(this PNAODGFELJJ MPFNEAFMDIA, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float HCPBBIGLAFG, bool GGBMJDIJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x741AD30", Offset = "0x7419B30", VA = "0x18741AD30")]
	private static void NDBAOLJANIE(this PNAODGFELJJ MPFNEAFMDIA, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG, float CBPEMMBLMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x741A5F0", Offset = "0x74193F0", VA = "0x18741A5F0")]
	private static void BGAIMBLKMEE(this PNAODGFELJJ MPFNEAFMDIA, int KNCPCNBMDNF, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG, float CBPEMMBLMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x741ABF0", Offset = "0x74199F0", VA = "0x18741ABF0")]
	private static bool LGBOBGBKDMC(this PNAODGFELJJ MPFNEAFMDIA, int KNCPCNBMDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x741B410", Offset = "0x741A210", VA = "0x18741B410")]
	private static void ONMDBJOMLHM(this PNAODGFELJJ MPFNEAFMDIA, int KNCPCNBMDNF, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG, float CBPEMMBLMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x741AEF0", Offset = "0x7419CF0", VA = "0x18741AEF0")]
	public static Vector3 NNAHFANKCBD(this PNAODGFELJJ MPFNEAFMDIA, int KNCPCNBMDNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x741AC20", Offset = "0x7419A20", VA = "0x18741AC20")]
	public static Quaternion LPDPKNEFEKF(this PNAODGFELJJ MPFNEAFMDIA, int KNCPCNBMDNF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x741A9A0", Offset = "0x74197A0", VA = "0x18741A9A0")]
	public static Vector3 GNKBDLBJLBE(GEJEIADHCHJ HNALEDONGCB, Vector3 AKEODPFBHJE, Vector3? KAHBNIHHHIJ, Vector3 MJIILOPKIEP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface PDDJMPJJNND
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLAJGDLGJF(EntityQuery JONMOOEGIAL, EntityManager LEDLAOLOFCD, IBDHPMDGIEI ONBPKFMECNJ, GMHFBEBHIDF KHLJCPDCMCK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface AEEKFLLIBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType CAGONBDFJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJOKEDBLDJO(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COIHFALNEPN(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHDMKHCGGNF(CKINBMACMLL NJJLAJMJCHE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class DFEPOMIBAMM : PDDJMPJJNND
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74104D0", Offset = "0x740F2D0", VA = "0x1874104D0", Slot = "4")]
	public void CKLAJGDLGJF(EntityQuery JONMOOEGIAL, EntityManager LEDLAOLOFCD, IBDHPMDGIEI ONBPKFMECNJ, GMHFBEBHIDF KHLJCPDCMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DFEPOMIBAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class FNNFDIGENKB : PDDJMPJJNND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IJIMINIKDMH ICGIPJGENJM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
	public FNNFDIGENKB(IJIMINIKDMH ICGIPJGENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7412100", Offset = "0x7410F00", VA = "0x187412100", Slot = "4")]
	public void CKLAJGDLGJF(EntityQuery JONMOOEGIAL, EntityManager LEDLAOLOFCD, IBDHPMDGIEI ONBPKFMECNJ, GMHFBEBHIDF KHLJCPDCMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class CJKKIPFCKIO : PDDJMPJJNND
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x740F9C0", Offset = "0x740E7C0", VA = "0x18740F9C0", Slot = "4")]
	public void CKLAJGDLGJF(EntityQuery JONMOOEGIAL, EntityManager LEDLAOLOFCD, IBDHPMDGIEI ONBPKFMECNJ, GMHFBEBHIDF KHLJCPDCMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public CJKKIPFCKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MIEGJLFFMLL : AEEKFLLIBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType CAGONBDFJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x741EF80", Offset = "0x741DD80", VA = "0x18741EF80", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x741F230", Offset = "0x741E030", VA = "0x18741F230", Slot = "5")]
	public void JJOKEDBLDJO(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x741EFB0", Offset = "0x741DDB0", VA = "0x18741EFB0", Slot = "6")]
	public void COIHFALNEPN(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x741F4B0", Offset = "0x741E2B0", VA = "0x18741F4B0", Slot = "7")]
	public void LHDMKHCGGNF(CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public MIEGJLFFMLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JEPPIJEKBDG : AEEKFLLIBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType CAGONBDFJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x741C2D0", Offset = "0x741B0D0", VA = "0x18741C2D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x741C580", Offset = "0x741B380", VA = "0x18741C580", Slot = "5")]
	public void JJOKEDBLDJO(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x741C300", Offset = "0x741B100", VA = "0x18741C300", Slot = "6")]
	public void COIHFALNEPN(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x741C800", Offset = "0x741B600", VA = "0x18741C800", Slot = "7")]
	public void LHDMKHCGGNF(CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public JEPPIJEKBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AMHDFFDBHAB : AEEKFLLIBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType CAGONBDFJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74090E0", Offset = "0x7407EE0", VA = "0x1874090E0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7409390", Offset = "0x7408190", VA = "0x187409390", Slot = "5")]
	public void JJOKEDBLDJO(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7409110", Offset = "0x7407F10", VA = "0x187409110", Slot = "6")]
	public void COIHFALNEPN(EntityQuery JONMOOEGIAL, CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7409610", Offset = "0x7408410", VA = "0x187409610", Slot = "7")]
	public void LHDMKHCGGNF(CKINBMACMLL NJJLAJMJCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public AMHDFFDBHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class JODKAGFPFBL : FILBMAFFENK, PLOJOFMKFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private IBDHPMDGIEI ONBPKFMECNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FGGPAEHHFJE HEOBKMCNHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GMHFBEBHIDF KHLJCPDCMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, PDDJMPJJNND adapter)> GNBFNNOMEIJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x741C9C0", Offset = "0x741B7C0", VA = "0x18741C9C0", Slot = "15")]
	public virtual void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x741CA50", Offset = "0x741B850", VA = "0x18741CA50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x741C850", Offset = "0x741B650", VA = "0x18741C850")]
	private void CMHEMKDKDAK(EntityQueryDesc JLPLAJMBPPI, PDDJMPJJNND JKNLAOCGPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x741CC80", Offset = "0x741BA80", VA = "0x18741CC80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public JODKAGFPFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class PIHGKBGLHMG : FILBMAFFENK, PLOJOFMKFEM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class OAPGHLFGDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery BDKLBDNBGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery EODBGGNJAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery OIIKKCKHHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery EALMMGDGAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery INHHALKOOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery NPNDFBKFMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AEEKFLLIBJA JAPJMPPEIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ComponentType ODCPFLHJICG;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OAPGHLFGDKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private IBDHPMDGIEI ONBPKFMECNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GMHFBEBHIDF KHLJCPDCMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FGGPAEHHFJE HEOBKMCNHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<OAPGHLFGDKJ> GNBFNNOMEIJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7424470", Offset = "0x7423270", VA = "0x187424470", Slot = "14")]
	public void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7424680", Offset = "0x7423480", VA = "0x187424680", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7424500", Offset = "0x7423300", VA = "0x187424500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7424810", Offset = "0x7423610", VA = "0x187424810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7424130", Offset = "0x7422F30", VA = "0x187424130")]
	private void EMLFGDBOCJH(OAPGHLFGDKJ HBDFCFPKJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7423AA0", Offset = "0x74228A0", VA = "0x187423AA0")]
	private void CMHEMKDKDAK(AEEKFLLIBJA JAPJMPPEIJI, ComponentType PKNGLGIDMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public PIHGKBGLHMG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct MDHNCFGACKL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct OONKACAPFIP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct IHDBLDMKFPA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(GMHFBEBHIDF), new string[] { })]
public class DCLHDFLGOOH : GMHFBEBHIDF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IIDEEAJADIF NLPDAPCFJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(IIDEEAJADIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DCLHDFLGOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(OPBMJKMLKCL), new string[] { })]
public class PLNDPADPKFA : OPBMJKMLKCL, HLDKHMCNNCM, JGMFHEFMNDL, HFKIOGDGJAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[DependsOn]
	private AMOENAFJHDD FNFMGPKBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private IBDHPMDGIEI ONBPKFMECNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private PHOLKIHIPKK CPAMHBBHFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Entity MFNKOEABCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KLDPLFJBOPH HAKJCPBNJAJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7424C50", Offset = "0x7423A50", VA = "0x187424C50", Slot = "4")]
	public bool MENCIGIFFDE(ODHMICMEHJH ADODGOLJGFP, ALJDIGJCPKP IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7424D30", Offset = "0x7423B30", VA = "0x187424D30", Slot = "5")]
	public KLDPLFJBOPH ODJAFLHPDJO()
	{
		return default(KLDPLFJBOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7424B40", Offset = "0x7423940", VA = "0x187424B40", Slot = "6")]
	public void GKLMMJNAKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7424AB0", Offset = "0x74238B0", VA = "0x187424AB0", Slot = "7")]
	private void BKNPNHIBBHM(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xFBD300", Offset = "0xFBC100", VA = "0x180FBD300", Slot = "8")]
	private void JAPPIEFINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PLNDPADPKFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(BFBEPFHMAPD), new string[] { })]
public class IBLBLHGBEDN : BFBEPFHMAPD
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7419F80", Offset = "0x7418D80", VA = "0x187419F80", Slot = "4")]
	public void PLINPMHMJOD(World FNFMGPKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7419ED0", Offset = "0x7418CD0", VA = "0x187419ED0", Slot = "5")]
	public void KPGDGGIAKEK(World FNFMGPKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7419710", Offset = "0x7418510", VA = "0x187419710", Slot = "6")]
	public ComponentSystemBase EHMOIDFHDIG(World FNFMGPKBOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7419F20", Offset = "0x7418D20", VA = "0x187419F20", Slot = "7")]
	public void LJEMOLEJMJP(World FNFMGPKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7419760", Offset = "0x7418560", VA = "0x187419760", Slot = "8")]
	public void EJFJHNLPPEG(World FNFMGPKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74197C0", Offset = "0x74185C0", VA = "0x1874197C0", Slot = "9")]
	public void HBLJNIJLLOH(World FNFMGPKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7419670", Offset = "0x7418470", VA = "0x187419670", Slot = "10")]
	public void CENLLPEJCFJ(World FNFMGPKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7419820", Offset = "0x7418620", VA = "0x187419820", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> JKPMJLOGEON()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public IBLBLHGBEDN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AAIOHDEALHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct EFFDBKOPFIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NHMMFAOCPGH : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MPBNEJBMNDN LDPAEDHIGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74230E0", Offset = "0x7421EE0", VA = "0x1874230E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7423070", Offset = "0x7421E70", VA = "0x187423070", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public NHMMFAOCPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GHOIIOIKDOH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public KLDPLFJBOPH KBHDOGMOGPP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static GHOIIOIKDOH JCHCBNMNCNP(KLDPLFJBOPH IPNJAOPIHCP)
	{
		return default(GHOIIOIKDOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GDBMCMHDABP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LPPLGFGBCLD EBFMDBIEJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74122D0", Offset = "0x74110D0", VA = "0x1874122D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GDBMCMHDABP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DIJABFKJKDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CGJCDJIOAKP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OKIHHGKOEFK MPILHLIPHOB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static CGJCDJIOAKP JCHCBNMNCNP(OKIHHGKOEFK IPNJAOPIHCP)
	{
		return default(CGJCDJIOAKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AJBOLNIJIGI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public KLDPLFJBOPH KBHDOGMOGPP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static AJBOLNIJIGI JCHCBNMNCNP(KLDPLFJBOPH IPNJAOPIHCP)
	{
		return default(AJBOLNIJIGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OBCHDAHFBNA : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ELAPOOPPBIK NALOFMCCONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7423800", Offset = "0x7422600", VA = "0x187423800", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7423790", Offset = "0x7422590", VA = "0x187423790", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OBCHDAHFBNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OHFIEMMHLMF : NDICMAILJBK, MPBNEJBMNDN, PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GMFMCBMNOIN NLDIOBKAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBE66A0", Offset = "0xBE54A0", VA = "0x180BE66A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(GMFMCBMNOIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DPEGJFFOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAACE40", Offset = "0xAABC40", VA = "0x180AACE40", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 FJJPNKGFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xEF13F0", Offset = "0xEF01F0", VA = "0x180EF13F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7423A00", Offset = "0x7422800", VA = "0x187423A00")]
	public OHFIEMMHLMF(UniformTRS PDJPMBJBOLO, JNCOEOPKELP IFAMCPHMKIP, float FGOEMOFGMDG, float3 NIELAKCJCGF, BDCLPCNFFNI GBDNJOEDEEM, OPLNEGJOKGG DPPNBCGJAIP, GMFMCBMNOIN NEIPKGMCBIF, float3 PGAEFKGNCON, bool FJNCPLBLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74239B0", Offset = "0x74227B0", VA = "0x1874239B0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JBJAMDCABPA : NDICMAILJBK, ELAPOOPPBIK, PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<HNPJEHHNIMF> IPILHKCPCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly CHKBNPKBLIJ KODPGCABALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly float DEOMDOAOJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int DLEDIKFGPIF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FPBDAGOKOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x741C2A0", Offset = "0x741B0A0", VA = "0x18741C2A0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BEDNAGIDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x741C2C0", Offset = "0x741B0C0", VA = "0x18741C2C0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OPPCEGHPOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x741C2B0", Offset = "0x741B0B0", VA = "0x18741C2B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CBBLDBCKHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC2A540", Offset = "0xC29340", VA = "0x180C2A540", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MGPEOPDMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xB4AB10", Offset = "0xB49910", VA = "0x180B4AB10", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LECAHJFFKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA76320", Offset = "0xA75120", VA = "0x180A76320", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x741C1F0", Offset = "0x741AFF0", VA = "0x18741C1F0")]
	public JBJAMDCABPA(UniformTRS PDJPMBJBOLO, JNCOEOPKELP IFAMCPHMKIP, float FGOEMOFGMDG, float3 NIELAKCJCGF, BDCLPCNFFNI GBDNJOEDEEM, OPLNEGJOKGG DPPNBCGJAIP, CHKBNPKBLIJ KODPGCABALO, float DEOMDOAOJHD, int DLEDIKFGPIF, NativeArray<HNPJEHHNIMF> IPILHKCPCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xF086C0", Offset = "0xF074C0", VA = "0x180F086C0", Slot = "33")]
	public NativeArray<HNPJEHHNIMF> GetNativeCurvePoints()
	{
		return default(NativeArray<HNPJEHHNIMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x741C130", Offset = "0x741AF30", VA = "0x18741C130", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DBJFNHLMPBL : BKFDBGHKMDA, MPBNEJBMNDN, PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Dictionary<LOEIMIFIJEN, GMFMCBMNOIN> KCKIIABJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GMFMCBMNOIN NEIPKGMCBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool FJNCPLBLOOD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private GMFMCBMNOIN DNNFDNCLNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x914100", Offset = "0x912F00", VA = "0x180914100", Slot = "28")]
		get
		{
			return default(GMFMCBMNOIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool BJIMEEHKHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCE57F0", Offset = "0xCE45F0", VA = "0x180CE57F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 FJJPNKGFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7410390", Offset = "0x740F190", VA = "0x187410390", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7410350", Offset = "0x740F150", VA = "0x187410350")]
	public DBJFNHLMPBL(ODHMICMEHJH HHAPNBLKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x740FCC0", Offset = "0x740EAC0", VA = "0x18740FCC0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x740FD10", Offset = "0x740EB10", VA = "0x18740FD10", Slot = "26")]
	public override void IGIPDIBMNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LFMEPIHHDPD : EHCHMHAIMII, LPPLGFGBCLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private GameObject EOGJDJKEBLJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject JEKAHIGLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x741CE70", Offset = "0x741BC70", VA = "0x18741CE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IDOAIIMFGBF HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x741D0A0", Offset = "0x741BEA0", VA = "0x18741D0A0", Slot = "15")]
		get
		{
			return default(IDOAIIMFGBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MPNDAIDMIFL OHNCPBDNLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "16")]
		get
		{
			return default(MPNDAIDMIFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x741D1A0", Offset = "0x741BFA0", VA = "0x18741D1A0")]
	public LFMEPIHHDPD(ODHMICMEHJH ADODGOLJGFP, bool IHBHONJOJHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x741CF30", Offset = "0x741BD30", VA = "0x18741CF30")]
	public void HMNMNNCNPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x741D0A0", Offset = "0x741BEA0", VA = "0x18741D0A0")]
	protected IDOAIIMFGBF IOAJCHBBPAB()
	{
		return default(IDOAIIMFGBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x741CF00", Offset = "0x741BD00", VA = "0x18741CF00", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BPIFINNFDOD : BKFDBGHKMDA, ELAPOOPPBIK, PJDOFLMGJLE, IDisposable, PGOLGEJEGCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeList<HNPJEHHNIMF> IPILHKCPCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool ALIDJOBHGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool OCFJJBOAAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private float DEOMDOAOJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int DLEDIKFGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private bool ANCNINHEHPP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool GJMKAINLGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xADD5A0", Offset = "0xADC3A0", VA = "0x180ADD5A0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool DPBMHIOIKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9406F0", Offset = "0x93F4F0", VA = "0x1809406F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float ELJBBMAAHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEB2BC0", Offset = "0xEB19C0", VA = "0x180EB2BC0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int OLKHAAOGDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBE66A0", Offset = "0xBE54A0", VA = "0x180BE66A0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool HFADPHMDHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE40", Offset = "0xAABC40", VA = "0x180AACE40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int MNKKFAEEPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x740F410", Offset = "0x740E210", VA = "0x18740F410", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int BKEDAHPGKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x740EE50", Offset = "0x740DC50", VA = "0x18740EE50", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x740F5B0", Offset = "0x740E3B0", VA = "0x18740F5B0")]
	public BPIFINNFDOD(ODHMICMEHJH HHAPNBLKCIB, [Optional] NativeList<HNPJEHHNIMF> IPILHKCPCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x740F330", Offset = "0x740E130", VA = "0x18740F330", Slot = "26")]
	public override void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x740EF40", Offset = "0x740DD40", VA = "0x18740EF40", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x740F030", Offset = "0x740DE30", VA = "0x18740F030", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x740F100", Offset = "0x740DF00", VA = "0x18740F100")]
	public void GEOLGKNPBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x740F160", Offset = "0x740DF60", VA = "0x18740F160", Slot = "34")]
	public NativeArray<HNPJEHHNIMF> GetNativeCurvePoints()
	{
		return default(NativeArray<HNPJEHHNIMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x740F460", Offset = "0x740E260", VA = "0x18740F460", Slot = "35")]
	private Vector3 PANPDGJCFED(int NBNGIGCCLIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x740F430", Offset = "0x740E230", VA = "0x18740F430", Slot = "36")]
	private Quaternion NCBMAPCHHJG(int NBNGIGCCLIC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x740ECB0", Offset = "0x740DAB0", VA = "0x18740ECB0", Slot = "37")]
	private float ABLNBCCCIKP(int NBNGIGCCLIC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x740F090", Offset = "0x740DE90", VA = "0x18740F090")]
	private NativeArray<Entity> GDNFFJMHPBN()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class NBAEBKDPDOO : LCOFABCLCED
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7420B70", Offset = "0x741F970", VA = "0x187420B70", Slot = "15")]
	protected override ComponentSystemBase NHEODOPNIME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7420F30", Offset = "0x741FD30", VA = "0x187420F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7420F40", Offset = "0x741FD40", VA = "0x187420F40")]
	public NBAEBKDPDOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PKKFCEHIJMC]
public sealed class FHBPGHCNHLJ : IGMHOLGPKAM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EntityQuery EMJBIJCNMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery EKGFJKBDBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery IJEJLELLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery LPJPBCJMNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery ILNJIOJLILN;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7411980", Offset = "0x7410780", VA = "0x187411980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7411CE0", Offset = "0x7410AE0", VA = "0x187411CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7411D20", Offset = "0x7410B20", VA = "0x187411D20")]
	private void PBLPDJMAFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7411840", Offset = "0x7410640", VA = "0x187411840")]
	private void NPJCMICMHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7411570", Offset = "0x7410370", VA = "0x187411570")]
	private void JPNOICGGEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7411F40", Offset = "0x7410D40", VA = "0x187411F40")]
	private void PDCDGPJBNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74113B0", Offset = "0x74101B0", VA = "0x1874113B0")]
	private void DHJINLFKBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74117E0", Offset = "0x74105E0", VA = "0x1874117E0")]
	private NativeList<Entity> KIMCKFKCAPG(NativeArray<Entity> AIJKCNMCOKI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7411780", Offset = "0x7410580", VA = "0x187411780")]
	private NativeList<Entity> KGHNMPIKJAK(NativeArray<Entity> AIJKCNMCOKI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x74114E0", Offset = "0x74102E0", VA = "0x1874114E0")]
	private void JLFLFDIHKCP(NativeArray<Entity> AIJKCNMCOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public FHBPGHCNHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PKKFCEHIJMC]
public sealed class MMBDLDPJOAD : IGMHOLGPKAM, PLOJOFMKFEM
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery CCFNAGJOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery JOALBKKCJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery OIIKKCKHHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private OPBMJKMLKCL AJPCFBGIBJI;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x74208E0", Offset = "0x741F6E0", VA = "0x1874208E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x741FD30", Offset = "0x741EB30", VA = "0x18741FD30", Slot = "15")]
	public override void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7420AB0", Offset = "0x741F8B0", VA = "0x187420AB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x741FDD0", Offset = "0x741EBD0", VA = "0x18741FDD0")]
	private void KGIAOKCLDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x741F500", Offset = "0x741E300", VA = "0x18741F500")]
	private void AKHBENNEILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7420450", Offset = "0x741F250", VA = "0x187420450")]
	private void LDAMGLPDPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7420840", Offset = "0x741F640", VA = "0x187420840")]
	private bool MEBBEGPKEOJ(Entity DGNDJCBPFEH, [Out] KLDPLFJBOPH KBHDOGMOGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x741FB80", Offset = "0x741E980", VA = "0x18741FB80")]
	private bool CFKJKHOKPHO(Entity DGNDJCBPFEH, [Out] KLDPLFJBOPH KBHDOGMOGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public MMBDLDPJOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PKKFCEHIJMC]
public sealed class MHMLFACHFML : IGMHOLGPKAM
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EntityQuery OJNMLAIMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery OANAIKMCNAC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x741ED80", Offset = "0x741DB80", VA = "0x18741ED80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x741EED0", Offset = "0x741DCD0", VA = "0x18741EED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x741EA70", Offset = "0x741D870", VA = "0x18741EA70")]
	private void KGIAOKCLDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x741E760", Offset = "0x741D560", VA = "0x18741E760")]
	private void AKHBENNEILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public MHMLFACHFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NGNHPEHOLCK : IGMHOLGPKAM, PLOJOFMKFEM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct OEPIPHNMNIP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public EntityQueryInJob NBNGLHKAPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob ABJLJBFHLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob JOEHMMLBLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob KABNPGNLNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ReadOnly]
		public EntityTypeHandle EMNGDJJEHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public ComponentTypeHandle<AJBOLNIJIGI> MMMEODEEKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NativeParallelHashSet<KLDPLFJBOPH> DIGLHDLKGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeList<Entity> PFOKEJMFBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> HFJPLGEILMO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7423850", Offset = "0x7422650", VA = "0x187423850", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x74238D0", Offset = "0x74226D0", VA = "0x1874238D0")]
		private void IIBMMMEBLNC(EntityQueryInJob JONMOOEGIAL, NativeList<Entity> JGNNJEGCHHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct IEPIKFLEFGB : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ReadOnly]
		public EntityTypeHandle EMNGDJJEHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public ComponentTypeHandle<AJBOLNIJIGI> MMMEODEEKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeParallelHashSet<KLDPLFJBOPH> DIGLHDLKGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeList<Entity> JGNNJEGCHHP;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x741A000", Offset = "0x7418E00", VA = "0x18741A000", Slot = "4")]
		public void Execute(ArchetypeChunk FEJDJOOGKAE, int FLEJIOBDKHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct NOHAHPDONDD : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ReadOnly]
		public EntityTypeHandle EMNGDJJEHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> NHHMCIKLGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<CGJCDJIOAKP> IFPNDNFMMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentDataFromEntity<GHOIIOIKDOH> GOIKCJHCGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public ComponentTypeHandle<AJBOLNIJIGI> FADMEIDGJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public NativeParallelHashSet<KLDPLFJBOPH> DIGLHDLKGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeList<Entity> GNILLJGCHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<CGJCDJIOAKP> OAMEBHJBMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<KLDPLFJBOPH> IDMPLKDJMEA;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7423130", Offset = "0x7421F30", VA = "0x187423130", Slot = "4")]
		public void Execute(ArchetypeChunk FEJDJOOGKAE, int FLEJIOBDKHJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery NBNGLHKAPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery ABJLJBFHLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery JOEHMMLBLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery KABNPGNLNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery JMMPAKGMPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery AAEFJBLNKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery EHJIEBIONOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private OPBMJKMLKCL FMLMMGJBKIO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7422730", Offset = "0x7421530", VA = "0x187422730", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7422250", Offset = "0x7421050", VA = "0x187422250", Slot = "15")]
	public override void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7422CB0", Offset = "0x7421AB0", VA = "0x187422CB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x74215C0", Offset = "0x74203C0", VA = "0x1874215C0")]
	private void IGFCNCIMIDD(NativeParallelHashSet<KLDPLFJBOPH> DIGLHDLKGOM, int EBANAJCFLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7421E00", Offset = "0x7420C00", VA = "0x187421E00")]
	private void IMLOADDAKEA(NativeParallelHashSet<KLDPLFJBOPH> DIGLHDLKGOM, int LBIDMAHOBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x74222F0", Offset = "0x74210F0", VA = "0x1874222F0")]
	private void NKJGBLKBMAN(NativeParallelHashSet<KLDPLFJBOPH> DIGLHDLKGOM, int GFBKNNPHDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7421230", Offset = "0x7420030", VA = "0x187421230")]
	private void DEFDLPPCLJF(NativeParallelHashSet<KLDPLFJBOPH> IKKCLCALIKA, int FDKHBCGMALI, int KPKDBCEMNBF, int HAOBDDGBJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7421BC0", Offset = "0x74209C0", VA = "0x187421BC0")]
	private void IHLGGLKOCGL(Entity KCOFLBNOGIE, OKIHHGKOEFK OPKFMBCACPH, KLDPLFJBOPH KBHDOGMOGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public NGNHPEHOLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class BHELHOCOPKP : IGMHOLGPKAM
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EntityQuery JONMOOEGIAL;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x740E310", Offset = "0x740D110", VA = "0x18740E310", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x740E3C0", Offset = "0x740D1C0", VA = "0x18740E3C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public BHELHOCOPKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[PKKFCEHIJMC]
internal class MGIBKGKAJHA : IGMHOLGPKAM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class KAGKLJGILPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EntityQuery KHCPBOJFFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public EntityQuery BPJIBIECJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GFJGAABKDOC MLNAAELAOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ComponentType DDAMMGOAFEL;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KAGKLJGILPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private delegate void GFJGAABKDOC(NativeArray<OKIHHGKOEFK> IPNJAOPIHCP, CKINBMACMLL NJJLAJMJCHE);

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<KAGKLJGILPI> GNBFNNOMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private FGGPAEHHFJE HEOBKMCNHIM;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x741DFA0", Offset = "0x741CDA0", VA = "0x18741DFA0", Slot = "15")]
	public override void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x741E040", Offset = "0x741CE40", VA = "0x18741E040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x741E1D0", Offset = "0x741CFD0", VA = "0x18741E1D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x33C6EA0", Offset = "0x33C5CA0", VA = "0x1833C6EA0")]
	private void CMHEMKDKDAK<T>(GFJGAABKDOC MLNAAELAOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x741DE00", Offset = "0x741CC00", VA = "0x18741DE00")]
	private static void GLLHNOHCLCP(NativeArray<OKIHHGKOEFK> GOFFLFBJEKK, CKINBMACMLL BCHDIGLPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x741DAC0", Offset = "0x741C8C0", VA = "0x18741DAC0")]
	private static void CEOFEGOBMAO(NativeArray<OKIHHGKOEFK> GOFFLFBJEKK, CKINBMACMLL BCHDIGLPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x741DC60", Offset = "0x741CA60", VA = "0x18741DC60")]
	private static void GHFEAAIMBDO(NativeArray<OKIHHGKOEFK> GOFFLFBJEKK, CKINBMACMLL BCHDIGLPJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public MGIBKGKAJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PKKFCEHIJMC]
public sealed class HIBNCCGMGAH : IGMHOLGPKAM
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private EntityQuery JONMOOEGIAL;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7418130", Offset = "0x7416F30", VA = "0x187418130", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DBBJJFHFDHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public UniformTRS PDJPMBJBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public StandardRenderableVisualData JBFJGBAOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public GMFMCBMNOIN NEIPKGMCBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float3 PGAEFKGNCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool FJNCPLBLOOD;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GIGKJCMFAGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeList<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<Entity> CPBNAMBBBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeParallelHashSet<Entity> PNGLDPAGNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<DBBJJFHFDHJ> DDMGDEDJMIE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7412DC0", Offset = "0x7411BC0", VA = "0x187412DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(HMBCGKICEDC), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
public class HMBCGKICEDC : PLOJOFMKFEM, EJBGNPMNAED, JGMFHEFMNDL, HFKIOGDGJAO
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct CECBILDELGF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly HMBCGKICEDC IFAMCPHMKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly bool IJHGILLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x155A9B0", Offset = "0x15597B0", VA = "0x18155A9B0")]
		public CECBILDELGF(HMBCGKICEDC IFAMCPHMKIP, bool IJHGILLJNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x740F910", Offset = "0x740E710", VA = "0x18740F910")]
		public Queue<AFJOGJKFCPO>.Enumerator NAPBKLICNNH()
		{
			return default(Queue<AFJOGJKFCPO>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x740F600", Offset = "0x740E400", VA = "0x18740F600", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[DependsOn]
	private PHOLKIHIPKK KOCCLJIALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[DependsOn]
	private JIKIFDDGENG OAAJBJIBGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<NativeList<HNPJEHHNIMF>> AAAMPCLMLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<OKIHHGKOEFK> EPJEDAKMCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<(Entity, List<GameObject>)> FMKOCIJBGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private IOBLPNMOABG<AFJOGJKFCPO> DIKCDDFFNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private IOBLPNMOABG<GIGKJCMFAGJ> BCPIHNABHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private IOBLPNMOABG<JPKNCPFCCEF> PIMOOLMGFFA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7418F50", Offset = "0x7417D50", VA = "0x187418F50", Slot = "4")]
	public void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7418620", Offset = "0x7417420", VA = "0x187418620")]
	public void DLHIGJLINAC(NativeList<HNPJEHHNIMF> NNAHHJHOKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7419150", Offset = "0x7417F50", VA = "0x187419150")]
	public void JGPBOHFGGFB(Entity IFAMCPHMKIP, [In] ODEPIHBIIKA<GameObject> JMMGBEMOIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x74192F0", Offset = "0x74180F0", VA = "0x1874192F0")]
	public void MNOAIIGLANB(NativeList<OKIHHGKOEFK> GOFFLFBJEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x74186F0", Offset = "0x74174F0", VA = "0x1874186F0")]
	public void HBLJNIJLLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7418910", Offset = "0x7417710", VA = "0x187418910")]
	public void HOFNCPEMBJO(EHONGHPLPEE HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7418EB0", Offset = "0x7417CB0", VA = "0x187418EB0")]
	public JobHandle IKAIICBDNCB([In] AFJOGJKFCPO KKBJAPCBOHH, JobHandle KBDBPNNHAFG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7418E10", Offset = "0x7417C10", VA = "0x187418E10")]
	public JobHandle IKAIICBDNCB([In] GIGKJCMFAGJ KKBJAPCBOHH, JobHandle KBDBPNNHAFG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7124F90", Offset = "0x7123D90", VA = "0x187124F90")]
	public CECBILDELGF MGHKFDMJLPP(bool IJHGILLJNPO)
	{
		return default(CECBILDELGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7419590", Offset = "0x7418390", VA = "0x187419590")]
	public DGIPNFMFIFO<GIGKJCMFAGJ> PAHGCJODCJO()
	{
		return default(DGIPNFMFIFO<GIGKJCMFAGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7418DC0", Offset = "0x7417BC0", VA = "0x187418DC0")]
	public DGIPNFMFIFO<JPKNCPFCCEF> HPLADDPPBMA()
	{
		return default(DGIPNFMFIFO<JPKNCPFCCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7419380", Offset = "0x7418180", VA = "0x187419380", Slot = "5")]
	public void OAKNFNBDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x74185B0", Offset = "0x74173B0", VA = "0x1874185B0", Slot = "6")]
	private void BKNPNHIBBHM(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x73CCB50", Offset = "0x73CB950", VA = "0x1873CCB50", Slot = "7")]
	private void JAPPIEFINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public HMBCGKICEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MJLMPMFAJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public UniformTRS PDJPMBJBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public StandardRenderableVisualData JBFJGBAOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public KFOIBPICOAF KODPGCABALO;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct AFJOGJKFCPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeList<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeList<Entity> CPBNAMBBBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NativeParallelHashSet<Entity> PNGLDPAGNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NativeList<GGPBJDCMKPH> IKCPCDDOOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeList<HNPJEHHNIMF> NNAHHJHOKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<MJLMPMFAJLN> NBENINPJBJO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7409000", Offset = "0x7407E00", VA = "0x187409000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7409010", Offset = "0x7407E10", VA = "0x187409010")]
	public void MOHLAAINEEE(bool IJHGILLJNPO)
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public class PostDeserializeBakeShapesSystem : IGMHOLGPKAM, PLOJOFMKFEM
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[ReadOnly]
			public NativeParallelHashMap<int, GMFMCBMNOIN> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public NativeArray<DBBJJFHFDHJ> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7413090", Offset = "0x7411E90", VA = "0x187413090", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public NativeArray<HNPJEHHNIMF> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			[ReadOnly]
			public NativeArray<GGPBJDCMKPH> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<MJLMPMFAJLN> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7413430", Offset = "0x7412230", VA = "0x187413430", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x740FB80", Offset = "0x740E980", VA = "0x18740FB80", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x7425040", Offset = "0x7423E40", VA = "0x187425040")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x7424FF0", Offset = "0x7423DF0", VA = "0x187424FF0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 DJPILIFGDHI(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x741D390", Offset = "0x741C190", VA = "0x18741D390", Slot = "5")]
				public float3 DKDBHKDDAHK(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x741D350", Offset = "0x741C150", VA = "0x18741D350", Slot = "4")]
				public float3 DJPILIFGDHI(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x7423460", Offset = "0x7422260", VA = "0x187423460", Slot = "4")]
				public float3 DJPILIFGDHI(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public NativeArray<GGPBJDCMKPH> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public NativeArray<HNPJEHHNIMF> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x74143D0", Offset = "0x74131D0", VA = "0x1874143D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7416B80", Offset = "0x7415980", VA = "0x187416B80")]
			private void ONIKEPKGBIM(NativeList<PointSrcData> srcData, NativeList<HNPJEHHNIMF> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7414AC0", Offset = "0x74138C0", VA = "0x187414AC0")]
			public static Vector3 GLGMFPOGIGF(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7413E10", Offset = "0x7412C10", VA = "0x187413E10")]
			public static quaternion CJHOCOGPJCN(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x74162F0", Offset = "0x74150F0", VA = "0x1874162F0")]
			private static quaternion IHNOKGOIOIE(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7416830", Offset = "0x7415630", VA = "0x187416830")]
			private static float3 LNFOMCPKAHJ(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7414A30", Offset = "0x7413830", VA = "0x187414A30")]
			private static quaternion FDOHOLGDBCF(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7416520", Offset = "0x7415320", VA = "0x187416520")]
			private static HNPJEHHNIMF JMOLOCACLKA(int idx, NativeList<PointSrcData> srcData)
			{
				return default(HNPJEHHNIMF);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x39D92E0", Offset = "0x39D80E0", VA = "0x1839D92E0")]
			private void NBOIOEEEFDF<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7415330", Offset = "0x7414130", VA = "0x187415330")]
			private void HHPNAOJDCNA(NativeList<PointSrcData> sourcePoints, NativeList<HNPJEHHNIMF> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7416A00", Offset = "0x7415800", VA = "0x187416A00")]
			public static float NFAPLAOKBHN(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7413B50", Offset = "0x7412950", VA = "0x187413B50")]
			private static quaternion BPCBFJPOOOJ(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7414070", Offset = "0x7412E70", VA = "0x187414070")]
			private static HNPJEHHNIMF DCALAHININE(PointSrcData point)
			{
				return default(HNPJEHHNIMF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7414190", Offset = "0x7412F90", VA = "0x187414190")]
			private static HNPJEHHNIMF DCALAHININE(float3 pos, quaternion rot, float radius)
			{
				return default(HNPJEHHNIMF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7416790", Offset = "0x7415590", VA = "0x187416790")]
			private static bool JOPBKBBMMCE(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7413D40", Offset = "0x7412B40", VA = "0x187413D40")]
			private static float3 CAFJNKLBJDC(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7416140", Offset = "0x7414F40", VA = "0x187416140")]
			public static float3 IFIJCGINBAC(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7414220", Offset = "0x7413020", VA = "0x187414220")]
			public static float3 DKDBHKDDAHK(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7414ED0", Offset = "0x7413CD0", VA = "0x187414ED0")]
			private static quaternion GOEMOHHGAOM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7413E90", Offset = "0x7412C90", VA = "0x187413E90")]
			private static float COAHLJKFCJI(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7426CF0", Offset = "0x7425AF0", VA = "0x187426CF0")]
			private void NFIHNGDINFK(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7426C00", Offset = "0x7425A00", VA = "0x187426C00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public NativeList<HNPJEHHNIMF> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7428790", Offset = "0x7427590", VA = "0x187428790")]
			private void NFIHNGDINFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7428780", Offset = "0x7427580", VA = "0x187428780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public NativeList<HNPJEHHNIMF> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7428730", Offset = "0x7427530", VA = "0x187428730")]
			private void NFIHNGDINFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7428720", Offset = "0x7427520", VA = "0x187428720", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public NativeList<DBBJJFHFDHJ> data;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7413780", Offset = "0x7412580", VA = "0x187413780")]
			private void NFIHNGDINFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7413770", Offset = "0x7412570", VA = "0x187413770", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherSplinesAndUniqueParents_Job : IJob
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
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NativeList<GGPBJDCMKPH> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public NativeList<MJLMPMFAJLN> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7413950", Offset = "0x7412750", VA = "0x187413950")]
			private void NFIHNGDINFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7413940", Offset = "0x7412740", VA = "0x187413940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7428300", Offset = "0x7427100", VA = "0x187428300")]
			private void NFIHNGDINFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x74282F0", Offset = "0x74270F0", VA = "0x1874282F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly IMOCAMGHNDM log;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AELCFOEALJK replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private PHOLKIHIPKK objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private HMBCGKICEDC bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private LCNKLBDPNCD ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7426280", Offset = "0x7425080", VA = "0x187426280", Slot = "15")]
		public override void InitReferences(BFHPBCPPECP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7428000", Offset = "0x7426E00", VA = "0x187428000", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74280F0", Offset = "0x7426EF0", VA = "0x1874280F0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7428150", Offset = "0x7426F50", VA = "0x187428150", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7426810", Offset = "0x7425610", VA = "0x187426810")]
		private JobHandle LIJEABIDHLB(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7427040", Offset = "0x7425E40", VA = "0x187427040")]
		private JobHandle NDGJPOBGGBK(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7426360", Offset = "0x7425160", VA = "0x187426360")]
		private JobHandle KEFBMADIGIL(NativeArray<int> pointCount, NativeList<HNPJEHHNIMF> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7425740", Offset = "0x7424540", VA = "0x187425740")]
		private JobHandle CKBIOFKLJFF(NativeList<HNPJEHHNIMF> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7425060", Offset = "0x7423E60", VA = "0x187425060")]
		private JobHandle AAPNMGIKPFI(EntityQuery query, NativeList<GGPBJDCMKPH> splinePointRanges, NativeList<HNPJEHHNIMF> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7427CD0", Offset = "0x7426AD0", VA = "0x187427CD0")]
		private JobHandle NIPKPNCBNMM(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x74259D0", Offset = "0x74247D0", VA = "0x1874259D0")]
		private JobHandle FNKAFFDLIFJ(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7426DD0", Offset = "0x7425BD0", VA = "0x187426DD0")]
		private JobHandle MCHFMIFFGPP(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<DBBJJFHFDHJ> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7426400", Offset = "0x7425200", VA = "0x187426400")]
		private JobHandle KHLGIDAIKPG(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<GGPBJDCMKPH> splinePointRanges, [Out] NativeList<MJLMPMFAJLN> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7425530", Offset = "0x7424330", VA = "0x187425530")]
		private JobHandle APKGOJGAAJC(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7425D70", Offset = "0x7424B70", VA = "0x187425D70")]
		private JobHandle HJHFAPOCABC(EntityQuery query, NativeList<DBBJJFHFDHJ> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x74278B0", Offset = "0x74266B0", VA = "0x1874278B0")]
		private static NativeParallelHashMap<int, GMFMCBMNOIN> NGPFJMBHGPN()
		{
			return default(NativeParallelHashMap<int, GMFMCBMNOIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7425AC0", Offset = "0x74248C0", VA = "0x187425AC0")]
		private JobHandle GACONMIIJIJ(EntityQuery query, NativeList<GGPBJDCMKPH> splinePointRanges, NativeList<HNPJEHHNIMF> splinePointData, NativeList<MJLMPMFAJLN> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74258F0", Offset = "0x74246F0", VA = "0x1874258F0")]
		private JobHandle EHGHPDOFLNH(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7426360", Offset = "0x7425160", VA = "0x187426360")]
		private JobHandle KFEAICLNPLE(NativeArray<int> pointCount, NativeList<HNPJEHHNIMF> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7425740", Offset = "0x7424540", VA = "0x187425740")]
		private JobHandle JMIMFJGCJFP(NativeList<HNPJEHHNIMF> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7426B10", Offset = "0x7425910", VA = "0x187426B10")]
		private JobHandle LMNLBECCCJC(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<DBBJJFHFDHJ> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x74257E0", Offset = "0x74245E0", VA = "0x1874257E0")]
		private JobHandle EDGALABOFHL(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<GGPBJDCMKPH> ranges, NativeList<MJLMPMFAJLN> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x74266C0", Offset = "0x74254C0", VA = "0x1874266C0")]
		private JobHandle LFOMKALMFKG(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7427DF0", Offset = "0x7426BF0", VA = "0x187427DF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DDBBKGONMBK : FILBMAFFENK, PLOJOFMKFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public HMBCGKICEDC JEOJFDPCJJI;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7410460", Offset = "0x740F260", VA = "0x187410460", Slot = "14")]
	public void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x74104B0", Offset = "0x740F2B0", VA = "0x1874104B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public DDBBKGONMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class ANABADAFFNF : IGMHOLGPKAM, PLOJOFMKFEM
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct CHIOIGECNPA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private EntityManager LEDLAOLOFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private NDFEHHCLIPA<T> BJHMCNLIEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int KNCPCNBMDNF;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5961F50", Offset = "0x5960D50", VA = "0x185961F50")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5962A50", Offset = "0x5961850", VA = "0x185962A50")]
		public CHIOIGECNPA(EntityManager LEDLAOLOFCD, NDFEHHCLIPA<T> BJHMCNLIEAP, NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4091780", Offset = "0x4090580", VA = "0x184091780")]
		public CHIOIGECNPA<T> NAPBKLICNNH()
		{
			return default(CHIOIGECNPA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x59628D0", Offset = "0x59616D0", VA = "0x1859628D0")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly IMOCAMGHNDM JIKGKEKJBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private JIKIFDDGENG OAAJBJIBGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private HMBCGKICEDC JEOJFDPCJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private global::ACJEOEGMJJI NJNMHLCCHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int GNJFHEALKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private string MNJCHHHJHBO;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x740AD70", Offset = "0x7409B70", VA = "0x18740AD70", Slot = "15")]
	public override void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x740A570", Offset = "0x7409370", VA = "0x18740A570")]
	public void CENLLPEJCFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x740D0D0", Offset = "0x740BED0", VA = "0x18740D0D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x740BF20", Offset = "0x740AD20", VA = "0x18740BF20")]
	private void MPKIDEFNENA(JPKNCPFCCEF KKBJAPCBOHH, Mesh[] OBGKKCDOELJ, NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3A305B0", Offset = "0x3A2F3B0", VA = "0x183A305B0")]
	private CHIOIGECNPA<T> ALHDDCEPCEG<T>(NDFEHHCLIPA<T> BJHMCNLIEAP, NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM) where T : struct
	{
		return default(CHIOIGECNPA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x740A9E0", Offset = "0x74097E0", VA = "0x18740A9E0")]
	private void FHNMOPGCMNH(Transform IFAMCPHMKIP, NativeArray<PCNJCNHLLEP> PAPLKJIBNOI, ODEPIHBIIKA<GameObject> KLCFMPAJFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7409FF0", Offset = "0x7408DF0", VA = "0x187409FF0")]
	private void BEFNMCNMDGA(Transform IFAMCPHMKIP, NativeArray<PECOPAMMLIC> ELGDNLJGENI, ODEPIHBIIKA<GameObject> KLCFMPAJFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7409C00", Offset = "0x7408A00", VA = "0x187409C00")]
	private void AMEFAENNHHC(Transform IFAMCPHMKIP, NativeArray<OIJOPANDJND> NHOAIAHBKFJ, ODEPIHBIIKA<GameObject> KLCFMPAJFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x740A5E0", Offset = "0x74093E0", VA = "0x18740A5E0")]
	private void EEFKGAJLMAK(Transform IFAMCPHMKIP, NativeArray<FBMABBEGIAN> OBGKKCDOELJ, Mesh[] PJJPHLFAAHH, ODEPIHBIIKA<GameObject> KLCFMPAJFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x740CF80", Offset = "0x740BD80", VA = "0x18740CF80")]
	private static void NLAKHOPDKFH(NativeParallelHashSet<Entity> AIJKCNMCOKI, NativeParallelHashSet<Entity> HEHELEANFAJ, NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x740A4B0", Offset = "0x74092B0", VA = "0x18740A4B0")]
	private static void CDPFPINPAFO(NativeList<Entity> BJCKKCNKPEK, NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x740AF80", Offset = "0x7409D80", VA = "0x18740AF80")]
	private NativeParallelHashMap<Entity, GHOIIOIKDOH> JMDKIGDJLPO(HMBCGKICEDC.CECBILDELGF BMEMKCJPMBJ, DGIPNFMFIFO<GIGKJCMFAGJ> JKLHLGIAMHA, NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM, List<GameObject> KLCFMPAJFDN)
	{
		return default(NativeParallelHashMap<Entity, GHOIIOIKDOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7409660", Offset = "0x7408460", VA = "0x187409660")]
	private void AMDHIPCPCPB(NativeList<Entity> NJMIHODOKHN, NativeList<Entity> HPLNDPIKMLI, NativeParallelHashMap<Entity, GHOIIOIKDOH> DEMMDJNCAJL, NativeList<GGPBJDCMKPH> AIDBPCIHHNN, NativeList<HNPJEHHNIMF> NMPKFPDFCMM, NativeList<MJLMPMFAJLN> AAAMPCLMLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x740BB00", Offset = "0x740A900", VA = "0x18740BB00")]
	private void MBLKEJNDPIL(NativeList<Entity> AIJKCNMCOKI, NativeList<Entity> CPBNAMBBBNC, NativeParallelHashMap<Entity, GHOIIOIKDOH> DEMMDJNCAJL, NativeList<DBBJJFHFDHJ> DDMGDEDJMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	public ANABADAFFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class HIAAOOHDJFP : KALDHDOGJDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly UniformTRS PDJPMBJBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly JNCOEOPKELP IFAMCPHMKIP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject IDNODAIEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS EFHONKNDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7417E70", Offset = "0x7416C70", VA = "0x187417E70", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 MBCLFAPHABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7417FF0", Offset = "0x7416DF0", VA = "0x187417FF0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 BHJEKBLHDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7417DD0", Offset = "0x7416BD0", VA = "0x187417DD0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 OLNGFBBHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7417E20", Offset = "0x7416C20", VA = "0x187417E20", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7417F50", Offset = "0x7416D50", VA = "0x187417F50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion LPCIIOBMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7417D80", Offset = "0x7416B80", VA = "0x187417D80", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7418040", Offset = "0x7416E40", VA = "0x187418040", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 LDDDJOKIGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7417FA0", Offset = "0x7416DA0", VA = "0x187417FA0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 JBAMMHOLCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7417D30", Offset = "0x7416B30", VA = "0x187417D30", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 NIHOOOIDFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7418090", Offset = "0x7416E90", VA = "0x187418090", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74180E0", Offset = "0x7416EE0", VA = "0x1874180E0")]
	public HIAAOOHDJFP(UniformTRS PDJPMBJBOLO, JNCOEOPKELP IFAMCPHMKIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class NDICMAILJBK : HIAAOOHDJFP, PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly float FGOEMOFGMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float3 NIELAKCJCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly BDCLPCNFFNI GBDNJOEDEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly OPLNEGJOKGG DPPNBCGJAIP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private IDOAIIMFGBF HIKAOLFEILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7421080", Offset = "0x741FE80", VA = "0x187421080", Slot = "17")]
		get
		{
			return default(IDOAIIMFGBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS ACPDCNJNACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7420F50", Offset = "0x741FD50", VA = "0x187420F50", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float FDFGAOABJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAC8300", Offset = "0xAC7100", VA = "0x180AC8300", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 NCPNGEJDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7421030", Offset = "0x741FE30", VA = "0x187421030", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private BDCLPCNFFNI AIEPIMOJECB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1D0", Offset = "0xCFDFD0", VA = "0x180CFF1D0", Slot = "21")]
		get
		{
			return default(BDCLPCNFFNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private OPLNEGJOKGG IJCIIKJFKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x11753D0", Offset = "0x11741D0", VA = "0x1811753D0", Slot = "22")]
		get
		{
			return default(OPLNEGJOKGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool OOHCJKFEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ILEFMALIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x74210D0", Offset = "0x741FED0", VA = "0x1874210D0")]
	protected NDICMAILJBK(UniformTRS PDJPMBJBOLO, JNCOEOPKELP IFAMCPHMKIP, float FGOEMOFGMDG, float3 NIELAKCJCGF, BDCLPCNFFNI GBDNJOEDEEM, OPLNEGJOKGG DPPNBCGJAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class EHCHMHAIMII : KALDHDOGJDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly ODHMICMEHJH FEOCBDNIFLG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected JNCOEOPKELP DACMFKEKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xFA0630", Offset = "0xF9F430", VA = "0x180FA0630")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity HDAMGELLPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7410D90", Offset = "0x740FB90", VA = "0x187410D90")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected PHOLKIHIPKK FMOMHMCAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7410730", Offset = "0x740F530", VA = "0x187410730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected PLKPCGBKHBF FNNKILGPPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7410FA0", Offset = "0x740FDA0", VA = "0x187410FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected FOBFMNKCFNO PBPJCDCONKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7410A50", Offset = "0x740F850", VA = "0x187410A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject IDNODAIEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7410900", Offset = "0x740F700", VA = "0x187410900", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS EFHONKNDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xFC4490", Offset = "0xFC3290", VA = "0x180FC4490", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 MBCLFAPHABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7411000", Offset = "0x740FE00", VA = "0x187411000", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 BHJEKBLHDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7410AE0", Offset = "0x740F8E0", VA = "0x187410AE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 OLNGFBBHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7410C60", Offset = "0x740FA60", VA = "0x187410C60", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7410DB0", Offset = "0x740FBB0", VA = "0x187410DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion LPCIIOBMCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7410930", Offset = "0x740F730", VA = "0x187410930", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x74110F0", Offset = "0x740FEF0", VA = "0x1874110F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 LDDDJOKIGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7410EB0", Offset = "0x740FCB0", VA = "0x187410EB0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 JBAMMHOLCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7410740", Offset = "0x740F540", VA = "0x187410740", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 NIHOOOIDFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x74111F0", Offset = "0x740FFF0", VA = "0x1874111F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0xCAD3F0", Offset = "0xCAC1F0", VA = "0x180CAD3F0")]
	protected EHCHMHAIMII(ODHMICMEHJH HHAPNBLKCIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x740EAF0", Offset = "0x740D8F0", VA = "0x18740EAF0")]
	public static IDOAIIMFGBF JCHCBNMNCNP(EHCHMHAIMII DHJLEBFEJME)
	{
		return default(IDOAIIMFGBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HFNFFNJDCEA
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7417AF0", Offset = "0x74168F0", VA = "0x187417AF0")]
	public static void JNKOGOBEOJD(NativeArray<Entity> AIJKCNMCOKI, EntityManager LEDLAOLOFCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class GEGGIHODAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7412940", Offset = "0x7411740", VA = "0x187412940")]
	public static void PCBGLJKGPIM(NativeArray<Entity> AIJKCNMCOKI, EntityManager LEDLAOLOFCD, EHONGHPLPEE CLENADCJAJG, PHOLKIHIPKK CPAMHBBHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x74125F0", Offset = "0x74113F0", VA = "0x1874125F0")]
	public static void KGPLNOFLMEM(NativeArray<Entity> AIJKCNMCOKI, EntityManager LEDLAOLOFCD, EHONGHPLPEE CLENADCJAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7412340", Offset = "0x7411140", VA = "0x187412340")]
	public static NativeList<Entity> KGHNMPIKJAK(NativeArray<Entity> AIJKCNMCOKI, EntityManager LEDLAOLOFCD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7412900", Offset = "0x7411700", VA = "0x187412900")]
	public static NativeList<Entity> KIMCKFKCAPG(NativeArray<Entity> AIJKCNMCOKI, EntityManager LEDLAOLOFCD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7412380", Offset = "0x7411180", VA = "0x187412380")]
	private static NativeList<Entity> KGHNMPIKJAK(NativeArray<Entity> AIJKCNMCOKI, EntityManager LEDLAOLOFCD, bool PGOADEDOBJI)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class BKFDBGHKMDA : EHCHMHAIMII, PJDOFLMGJLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float FGOEMOFGMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Vector3 NIELAKCJCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BDCLPCNFFNI GBDNJOEDEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private OPLNEGJOKGG DPPNBCGJAIP;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager IDMDBPOIAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x740EB20", Offset = "0x740D920", VA = "0x18740EB20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected AMOENAFJHDD HPCKJPNFEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x740E8D0", Offset = "0x740D6D0", VA = "0x18740E8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData LEKOAFJIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x740EBE0", Offset = "0x740D9E0", VA = "0x18740EBE0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private IDOAIIMFGBF HIKAOLFEILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x740EAF0", Offset = "0x740D8F0", VA = "0x18740EAF0", Slot = "17")]
		get
		{
			return default(IDOAIIMFGBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float FDFGAOABJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xD9F810", Offset = "0xD9E610", VA = "0x180D9F810", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 NCPNGEJDGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x13B7EA0", Offset = "0x13B6CA0", VA = "0x1813B7EA0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private BDCLPCNFFNI AIEPIMOJECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70", Slot = "21")]
		get
		{
			return default(BDCLPCNFFNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private OPLNEGJOKGG IJCIIKJFKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xB48030", Offset = "0xB46E30", VA = "0x180B48030", Slot = "22")]
		get
		{
			return default(OPLNEGJOKGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS ACPDCNJNACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xFC4490", Offset = "0xFC3290", VA = "0x180FC4490", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ILEFMALIOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x922F70", Offset = "0x921D70", VA = "0x180922F70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x922CF0", Offset = "0x921AF0", VA = "0x180922CF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool OOHCJKFEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x740EC70", Offset = "0x740DA70", VA = "0x18740EC70")]
	protected BKFDBGHKMDA(ODHMICMEHJH HHAPNBLKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x740E960", Offset = "0x740D760", VA = "0x18740E960", Slot = "26")]
	public virtual void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class IGMHOLGPKAM : FILBMAFFENK, PLOJOFMKFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected PHOLKIHIPKK CPAMHBBHFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private IBDHPMDGIEI ONBPKFMECNJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected EHONGHPLPEE FPIMKJAMJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x741A2A0", Offset = "0x74190A0", VA = "0x18741A2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected CKINBMACMLL DFGBAIKMIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x741A250", Offset = "0x7419050", VA = "0x18741A250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x741A2F0", Offset = "0x74190F0", VA = "0x18741A2F0", Slot = "15")]
	public virtual void InitReferences(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x275BB50", Offset = "0x275A950", VA = "0x18275BB50")]
	protected IGMHOLGPKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GNPOHOPHGHB
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7412E50", Offset = "0x7411C50", VA = "0x187412E50")]
	public static void EMHJOHHIKPF(NativeArray<Entity> NJMIHODOKHN, EntityManager LEDLAOLOFCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3172240423
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7429160", Offset = "0x7427F60", VA = "0x187429160")]
	public static void LKCLEJJFMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7429150", Offset = "0x7427F50", VA = "0x187429150")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class IFLGNOLLOBC : ContainerPropertyBag<NHMMFAOCPGH>
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x74294A0", Offset = "0x74282A0", VA = "0x1874294A0")]
	public IFLGNOLLOBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class AJLLMMBGHHP : ContainerPropertyBag<GDBMCMHDABP>
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x74293E0", Offset = "0x74281E0", VA = "0x1874293E0")]
	public AJLLMMBGHHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class EGGDPDIHPBC : ContainerPropertyBag<OBCHDAHFBNA>
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7429440", Offset = "0x7428240", VA = "0x187429440")]
	public EGGDPDIHPBC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7429500", Offset = "0x7428300", VA = "0x187429500")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
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
