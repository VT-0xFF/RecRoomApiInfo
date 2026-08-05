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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8383A80", Offset = "0x8382A80", VA = "0x188383A80", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8334620", Offset = "0x8333620", VA = "0x188334620", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x838B8C0", Offset = "0x838A8C0", VA = "0x18838B8C0")]
		private void MNKCLNFPDFM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x838BE60", Offset = "0x838AE60", VA = "0x18838BE60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x838BEC0", Offset = "0x838AEC0", VA = "0x18838BEC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BBJKGEOHHMJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x836CE60", Offset = "0x836BE60", VA = "0x18836CE60")]
	public static Quaternion HEONLFLDIEI([In] this AIMFNKAJFPO CPHKFOPBBEK, [In] Vector3 NBFEGPDMMPI)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DLIGCOMBKJE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x836EAF0", Offset = "0x836DAF0", VA = "0x18836EAF0")]
	public static bool JCINMEBCMKG(this BCMIKBHBKJF PNINCLCEGEG, DDFFFHLEFPB HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x836E9A0", Offset = "0x836D9A0", VA = "0x18836E9A0")]
	public static bool GOBNLIMKDNL(this BCMIKBHBKJF PNINCLCEGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x836F760", Offset = "0x836E760", VA = "0x18836F760")]
	public static bool OMKKGEHDODO(this BCMIKBHBKJF PNINCLCEGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x836EDC0", Offset = "0x836DDC0", VA = "0x18836EDC0")]
	public static void JKOKEFMBPND(this BCMIKBHBKJF PNINCLCEGEG, Vector3 ICKKFKGPPIG, Quaternion HKHEDAGHKAN, float MGJGIJAADIJ, bool JECAFHNEHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x836EB30", Offset = "0x836DB30", VA = "0x18836EB30")]
	public static void JCLJHHPLNHL(this BCMIKBHBKJF PNINCLCEGEG, Vector3 ICKKFKGPPIG, Quaternion HKHEDAGHKAN, float MGJGIJAADIJ, int GPCCKEIGKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x836E9D0", Offset = "0x836D9D0", VA = "0x18836E9D0")]
	public static void IMHMKHPMGEK(this BCMIKBHBKJF PNINCLCEGEG, int GPCCKEIGKCP, Vector3 ICKKFKGPPIG, Quaternion HKHEDAGHKAN, float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x836D9C0", Offset = "0x836C9C0", VA = "0x18836D9C0")]
	public static void AEBODGNBEPM(this BCMIKBHBKJF PNINCLCEGEG, Vector3 ENJHPEHFBFM, Quaternion NEAHCFMNLNE, float MGJGIJAADIJ, bool JECAFHNEHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x836DB20", Offset = "0x836CB20", VA = "0x18836DB20")]
	private static void AMOBOPJPOAJ(this BCMIKBHBKJF PNINCLCEGEG, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float MGJGIJAADIJ, bool JECAFHNEHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x836EEF0", Offset = "0x836DEF0", VA = "0x18836EEF0")]
	private static void JODNHNNNKMA(this BCMIKBHBKJF PNINCLCEGEG, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN, float NIFKJACBIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x836F350", Offset = "0x836E350", VA = "0x18836F350")]
	private static void MHIKJKAKPJC(this BCMIKBHBKJF PNINCLCEGEG, int HLGKMAPOEBE, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN, float NIFKJACBIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x836E480", Offset = "0x836D480", VA = "0x18836E480")]
	private static bool CDBDIPGNJMD(this BCMIKBHBKJF PNINCLCEGEG, int HLGKMAPOEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x836F0B0", Offset = "0x836E0B0", VA = "0x18836F0B0")]
	private static void KEIBCKCNHBO(this BCMIKBHBKJF PNINCLCEGEG, int HLGKMAPOEBE, Vector3 GKANPAILENO, Quaternion MMKPIDNBBJN, float NIFKJACBIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x836E4B0", Offset = "0x836D4B0", VA = "0x18836E4B0")]
	public static Vector3 EJELKIJONMN(this BCMIKBHBKJF PNINCLCEGEG, int HLGKMAPOEBE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x836DA10", Offset = "0x836CA10", VA = "0x18836DA10")]
	public static Quaternion AEMHDOLFCOB(this BCMIKBHBKJF PNINCLCEGEG, int HLGKMAPOEBE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x836F540", Offset = "0x836E540", VA = "0x18836F540")]
	public static Vector3 MKKDOKKLBMH(DDFFFHLEFPB OMENDEGIBIL, Vector3 EBGKGBGFPOC, Vector3? HBMLONMACIC, Vector3 IFLOMPHLJDM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface MBDPEDAENGE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCHFHEMACPF(EntityQuery BMJBBIGFJMO, EntityManager FMBMFCMHGGJ, CPHOFNKOFED IEHKKLCADNA, NAJHLIHKOCF BGLCECEBAMH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface LNFCCFAEDLF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType PMMOPHNAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFKEGACGKII(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDCNDKAJKJA(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHHAHJNGGJL(DJNEMOFCFJP MGHKGJBJAPH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class HMPNNOHKCAI : MBDPEDAENGE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x837CDB0", Offset = "0x837BDB0", VA = "0x18837CDB0", Slot = "4")]
	public void DCHFHEMACPF(EntityQuery BMJBBIGFJMO, EntityManager FMBMFCMHGGJ, CPHOFNKOFED IEHKKLCADNA, NAJHLIHKOCF BGLCECEBAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HMPNNOHKCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class AGBMOGILIOP : MBDPEDAENGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CFCGOEKOEDO MHMKGPBCAJP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
	public AGBMOGILIOP(CFCGOEKOEDO MHMKGPBCAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x836C590", Offset = "0x836B590", VA = "0x18836C590", Slot = "4")]
	public void DCHFHEMACPF(EntityQuery BMJBBIGFJMO, EntityManager FMBMFCMHGGJ, CPHOFNKOFED IEHKKLCADNA, NAJHLIHKOCF BGLCECEBAMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class LPFJMEBGFKO : MBDPEDAENGE
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8383550", Offset = "0x8382550", VA = "0x188383550", Slot = "4")]
	public void DCHFHEMACPF(EntityQuery BMJBBIGFJMO, EntityManager FMBMFCMHGGJ, CPHOFNKOFED IEHKKLCADNA, NAJHLIHKOCF BGLCECEBAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LPFJMEBGFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HAJHNOMBDHN : LNFCCFAEDLF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType PMMOPHNAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x837BAE0", Offset = "0x837AAE0", VA = "0x18837BAE0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x837B860", Offset = "0x837A860", VA = "0x18837B860", Slot = "5")]
	public void JFKEGACGKII(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x837BB10", Offset = "0x837AB10", VA = "0x18837BB10", Slot = "6")]
	public void PDCNDKAJKJA(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x837B810", Offset = "0x837A810", VA = "0x18837B810", Slot = "7")]
	public void FHHAHJNGGJL(DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HAJHNOMBDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FMJNGFAIPLN : LNFCCFAEDLF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType PMMOPHNAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8370ED0", Offset = "0x836FED0", VA = "0x188370ED0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8370C50", Offset = "0x836FC50", VA = "0x188370C50", Slot = "5")]
	public void JFKEGACGKII(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8370F00", Offset = "0x836FF00", VA = "0x188370F00", Slot = "6")]
	public void PDCNDKAJKJA(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8370C00", Offset = "0x836FC00", VA = "0x188370C00", Slot = "7")]
	public void FHHAHJNGGJL(DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FMJNGFAIPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AOLKMAJGNDL : LNFCCFAEDLF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType PMMOPHNAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x836CBB0", Offset = "0x836BBB0", VA = "0x18836CBB0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x836C930", Offset = "0x836B930", VA = "0x18836C930", Slot = "5")]
	public void JFKEGACGKII(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x836CBE0", Offset = "0x836BBE0", VA = "0x18836CBE0", Slot = "6")]
	public void PDCNDKAJKJA(EntityQuery BMJBBIGFJMO, DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x836C8E0", Offset = "0x836B8E0", VA = "0x18836C8E0", Slot = "7")]
	public void FHHAHJNGGJL(DJNEMOFCFJP MGHKGJBJAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AOLKMAJGNDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FMHBOABLGAF : CJAAJCOIOJB, PJNGLGAADAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CPHOFNKOFED IEHKKLCADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LGKOFLOEHGF BMNBEONBGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NAJHLIHKOCF BGLCECEBAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, MBDPEDAENGE adapter)> CMLLMGEPHOH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8370750", Offset = "0x836F750", VA = "0x188370750", Slot = "15")]
	public virtual void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83707E0", Offset = "0x836F7E0", VA = "0x1883707E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83705F0", Offset = "0x836F5F0", VA = "0x1883705F0")]
	private void HLFFPCOMEJD(EntityQueryDesc EOLNECHGGHO, MBDPEDAENGE OKLMFOLPPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8370A10", Offset = "0x836FA10", VA = "0x188370A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
	public FMHBOABLGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class MKPLMFCLNJM : CJAAJCOIOJB, PJNGLGAADAH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class IIACGKJFJAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery GGLAMIHBEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery IGBLEPEJFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery HMHFOIAGHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery MHLLMGBCIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery IIKHHBEDIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery NNFMBNNEJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery BINFGHHKIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LNFCCFAEDLF OEBDBGCEBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType MOAEBGPMOLE;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public IIACGKJFJAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CPHOFNKOFED IEHKKLCADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NAJHLIHKOCF BGLCECEBAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private LGKOFLOEHGF BMNBEONBGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<IIACGKJFJAB> CMLLMGEPHOH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83849C0", Offset = "0x83839C0", VA = "0x1883849C0", Slot = "14")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8384A50", Offset = "0x8383A50", VA = "0x188384A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8384BD0", Offset = "0x8383BD0", VA = "0x188384BD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8383E00", Offset = "0x8382E00", VA = "0x188383E00")]
	private void CLGICGNLCOO(IIACGKJFJAB MMIBJOBOHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8384250", Offset = "0x8383250", VA = "0x188384250")]
	private void HLFFPCOMEJD(LNFCCFAEDLF OEBDBGCEBDK, ComponentType FMOGACBBGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
	public MKPLMFCLNJM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct HMDHPIGAJBI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct LDAEKKPAEFB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct CKMLNBMGMKD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(NAJHLIHKOCF), new string[] { })]
public class PFEMFMMNGON : NAJHLIHKOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CIMLIBKMPND GJJNMLHFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CIMLIBKMPND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PFEMFMMNGON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(DLKBDHPNALP), new string[] { })]
public class HBOIENDOPGD : DLKBDHPNALP, EEIGNHCPHDL, KELFAPLDHJK, GDOFPGECDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private AIMNAMMCJGJ BABHHEKHGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private CPHOFNKOFED IEHKKLCADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private MLBLOFEMENF PMNGIBDJKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity BJHHBDMNJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private FGANHAMJGGJ EGAPHIEOOMA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x837BE20", Offset = "0x837AE20", VA = "0x18837BE20", Slot = "4")]
	public bool FKLGACALKCL(GOLADBGGMAB MPAKEJAFLKL, FPIECMLDEPF IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x837C010", Offset = "0x837B010", VA = "0x18837C010", Slot = "5")]
	public FGANHAMJGGJ NCELEGDFKAD()
	{
		return default(FGANHAMJGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x837BF00", Offset = "0x837AF00", VA = "0x18837BF00", Slot = "6")]
	public void GKILICICKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x837BD90", Offset = "0x837AD90", VA = "0x18837BD90", Slot = "7")]
	private void FDOELKOHJIM(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x12D41A0", Offset = "0x12D31A0", VA = "0x1812D41A0", Slot = "8")]
	private void BBFHDNOELJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HBOIENDOPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(OFEPDFNKNDL), new string[] { })]
public class HHKMEFDHBPC : OFEPDFNKNDL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x837C430", Offset = "0x837B430", VA = "0x18837C430", Slot = "4")]
	public void KDCMJBCBPGI(World BABHHEKHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x837C2D0", Offset = "0x837B2D0", VA = "0x18837C2D0", Slot = "5")]
	public void BEMHMGEHHCH(World BABHHEKHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x837C320", Offset = "0x837B320", VA = "0x18837C320", Slot = "6")]
	public ComponentSystemBase BFHIHMGHAAM(World BABHHEKHGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x837C4B0", Offset = "0x837B4B0", VA = "0x18837C4B0", Slot = "7")]
	public void MDIPNJBCINA(World BABHHEKHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x837C370", Offset = "0x837B370", VA = "0x18837C370", Slot = "8")]
	public void CLGHMEPKGCK(World BABHHEKHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x837C3D0", Offset = "0x837B3D0", VA = "0x18837C3D0", Slot = "9")]
	public void FEPDGENAJGP(World BABHHEKHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x837C510", Offset = "0x837B510", VA = "0x18837C510", Slot = "10")]
	public void MLBINOBNFAL(World BABHHEKHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x837C580", Offset = "0x837B580", VA = "0x18837C580", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> NJBGHOGOJIN()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HHKMEFDHBPC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct OLOBMOGAKGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct JOBHBPKBFNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PDKINFNIGMG : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PGILHJFJMGB BNADBFJGECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83871A0", Offset = "0x83861A0", VA = "0x1883871A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8387130", Offset = "0x8386130", VA = "0x188387130", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PDKINFNIGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct DCPNMDMAMFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public FGANHAMJGGJ OFODLANBDMC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static DCPNMDMAMFE MJOOONLKLLN(FGANHAMJGGJ EBEJPHPLJAD)
	{
		return default(DCPNMDMAMFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PNLKKMEFIJF : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ILAFMLGLELN EOGICNFJKME
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8387A20", Offset = "0x8386A20", VA = "0x188387A20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PNLKKMEFIJF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct DHBOHPKDOKB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct GPHPADGCDNE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public FLJADJJDFKC OFGOKBJCOHI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static GPHPADGCDNE MJOOONLKLLN(FLJADJJDFKC EBEJPHPLJAD)
	{
		return default(GPHPADGCDNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct CIPLOEJMIIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public FGANHAMJGGJ OFODLANBDMC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static CIPLOEJMIIC MJOOONLKLLN(FGANHAMJGGJ EBEJPHPLJAD)
	{
		return default(CIPLOEJMIIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DPPIGNGMEKD : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PGOGCEBABLM INCOBNBMDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x836FB70", Offset = "0x836EB70", VA = "0x18836FB70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x836FB00", Offset = "0x836EB00", VA = "0x18836FB00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DPPIGNGMEKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JAJIPCEOEBL : ANNJBPKJBNN, PGILHJFJMGB, JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DOKODMHNDOA BJGONHHMLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE55690", Offset = "0xE54690", VA = "0x180E55690", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(DOKODMHNDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KAELNHDLOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD17AA0", Offset = "0xD16AA0", VA = "0x180D17AA0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 MCBGKODEIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x122ED00", Offset = "0x122DD00", VA = "0x18122ED00", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x837EE90", Offset = "0x837DE90", VA = "0x18837EE90")]
	public JAJIPCEOEBL(UniformTRS AJBCGIEIIAC, CJNFLLJGPFC EBJBKAEFOPM, float GFBPONDLNBA, float3 LNGOLIMELND, KOGANNKCGHD GGLLCOBILLK, DOKJMPJMCCI GMLDDAFCAKD, DOKODMHNDOA ABFAIEAFIJF, float3 FGDOOFKFBCH, bool CHCEGEJGNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x837EE40", Offset = "0x837DE40", VA = "0x18837EE40", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LNFKPKACFMF : ANNJBPKJBNN, PGOGCEBABLM, JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<KOLICHJFOBE> HCAJEJLPKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LIHMFCNMLMG OGEALFKCCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float MLMDEACCCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int PGHFPADNACP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EEMCFACAADG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8382BF0", Offset = "0x8381BF0", VA = "0x188382BF0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GHDHADLKKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8382C10", Offset = "0x8381C10", VA = "0x188382C10", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EGMNBLKHIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8382C00", Offset = "0x8381C00", VA = "0x188382C00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IMGBMHIEIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAC2B00", Offset = "0xAC1B00", VA = "0x180AC2B00", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float LOMHABMPDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xDB0980", Offset = "0xDAF980", VA = "0x180DB0980", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IGFAPKMCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1041860", Offset = "0x1040860", VA = "0x181041860", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8382B40", Offset = "0x8381B40", VA = "0x188382B40")]
	public LNFKPKACFMF(UniformTRS AJBCGIEIIAC, CJNFLLJGPFC EBJBKAEFOPM, float GFBPONDLNBA, float3 LNGOLIMELND, KOGANNKCGHD GGLLCOBILLK, DOKJMPJMCCI GMLDDAFCAKD, LIHMFCNMLMG OGEALFKCCAP, float MLMDEACCCED, int PGHFPADNACP, NativeArray<KOLICHJFOBE> HCAJEJLPKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1245FE0", Offset = "0x1244FE0", VA = "0x181245FE0", Slot = "33")]
	public NativeArray<KOLICHJFOBE> GetNativeCurvePoints()
	{
		return default(NativeArray<KOLICHJFOBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8382A80", Offset = "0x8381A80", VA = "0x188382A80", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NLGKNMNDLLA : FDPHCMLIKCI, PGILHJFJMGB, JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<GOAIGCDFKPE, DOKODMHNDOA> JOFLEFKLPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DOKODMHNDOA ABFAIEAFIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool CHCEGEJGNLD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private DOKODMHNDOA CJJDFGCKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570", Slot = "28")]
		get
		{
			return default(DOKODMHNDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PNHJOBGCPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xF67FD0", Offset = "0xF66FD0", VA = "0x180F67FD0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 MCBGKODEIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83868F0", Offset = "0x83858F0", VA = "0x1883868F0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83868D0", Offset = "0x83858D0", VA = "0x1883868D0")]
	public NLGKNMNDLLA(GOLADBGGMAB GNMFDIECOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8386240", Offset = "0x8385240", VA = "0x188386240", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8386290", Offset = "0x8385290", VA = "0x188386290", Slot = "26")]
	public override void PHBANHJIEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PNGEMNOKNFH : IDFOKLPEEIM, ILAFMLGLELN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject LEBCJAJCIJL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject HLLLIANPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83872D0", Offset = "0x83862D0", VA = "0x1883872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MHHODEBGAFD DBHNDLPLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8387670", Offset = "0x8386670", VA = "0x188387670", Slot = "15")]
		get
		{
			return default(MHHODEBGAFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JBBPLPCKICC PELIOPKGAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83878C0", Offset = "0x83868C0", VA = "0x1883878C0", Slot = "16")]
		get
		{
			return default(JBBPLPCKICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8387770", Offset = "0x8386770", VA = "0x188387770")]
	public PNGEMNOKNFH(GOLADBGGMAB MPAKEJAFLKL, bool POFJPHFGPAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8387360", Offset = "0x8386360", VA = "0x188387360")]
	public void CMLHJEJGLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8387670", Offset = "0x8386670", VA = "0x188387670")]
	protected MHHODEBGAFD OLOPDKAFMLO()
	{
		return default(MHHODEBGAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8387520", Offset = "0x8386520", VA = "0x188387520")]
	private static bool JONCHLLNEPM(GOLADBGGMAB OIBMMJFJCFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x83874F0", Offset = "0x83864F0", VA = "0x1883874F0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LODKKFAHLFH : FDPHCMLIKCI, PGOGCEBABLM, JMBBCJIGALM, IDisposable, DLCDHJHIFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<KOLICHJFOBE> HCAJEJLPKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool NMBNFKHCFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool EKOLAAGMLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float MLMDEACCCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int PGHFPADNACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool MLEONCJNPHD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool OEOPNGEBLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD243C0", Offset = "0xD233C0", VA = "0x180D243C0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool CADHKFFLOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD3C0", Offset = "0xAAC3C0", VA = "0x180AAD3C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float IKCKMAPCNML
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEC2860", Offset = "0xEC1860", VA = "0x180EC2860", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int NDDIAEPCIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE55690", Offset = "0xE54690", VA = "0x180E55690", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DANIEALNFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD17AA0", Offset = "0xD16AA0", VA = "0x180D17AA0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int FNIOPAACCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8382FE0", Offset = "0x8381FE0", VA = "0x188382FE0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int OGGJBHGDBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8383200", Offset = "0x8382200", VA = "0x188383200", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8383520", Offset = "0x8382520", VA = "0x188383520")]
	public LODKKFAHLFH(GOLADBGGMAB GNMFDIECOJL, [Optional] NativeList<KOLICHJFOBE> HCAJEJLPKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8383440", Offset = "0x8382440", VA = "0x188383440", Slot = "26")]
	public override void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8382C20", Offset = "0x8381C20", VA = "0x188382C20", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8382D10", Offset = "0x8381D10", VA = "0x188382D10", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8382D70", Offset = "0x8381D70", VA = "0x188382D70")]
	public void EMHIBPAGOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8383000", Offset = "0x8382000", VA = "0x188383000", Slot = "34")]
	public NativeArray<KOLICHJFOBE> GetNativeCurvePoints()
	{
		return default(NativeArray<KOLICHJFOBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x83832F0", Offset = "0x83822F0", VA = "0x1883832F0", Slot = "35")]
	private Vector3 KFIECJHPDDM(int LFBGKHDOJNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x83831D0", Offset = "0x83821D0", VA = "0x1883831D0", Slot = "36")]
	private Quaternion JLEMGNODCJG(int LFBGKHDOJNO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8382E40", Offset = "0x8381E40", VA = "0x188382E40", Slot = "37")]
	private float GFKCHLODLFA(int LFBGKHDOJNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8382DD0", Offset = "0x8381DD0", VA = "0x188382DD0")]
	private NativeArray<Entity> FLDNKPBFFDB()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class NCFMFELPJKL : MCKGGDDJNKD
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8384E70", Offset = "0x8383E70", VA = "0x188384E70", Slot = "15")]
	protected override ComponentSystemBase CMILBEOFFPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8385290", Offset = "0x8384290", VA = "0x188385290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x83852A0", Offset = "0x83842A0", VA = "0x1883852A0")]
	public NCFMFELPJKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PDFOECGLEOP]
public sealed class GLPOLOBFGFN : OJNBNCLAKHE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery LJGECOJHGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery NFHAOHDJNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery DCGJAJLHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery NIFPCIMCFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery MKHFKELHPML;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x83763F0", Offset = "0x83753F0", VA = "0x1883763F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8376750", Offset = "0x8375750", VA = "0x188376750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8375FC0", Offset = "0x8374FC0", VA = "0x188375FC0")]
	private void IABDIOEDFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8375E50", Offset = "0x8374E50", VA = "0x188375E50")]
	private void GNOINGKLHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8376790", Offset = "0x8375790", VA = "0x188376790")]
	private void PBCEIANHBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x83762F0", Offset = "0x83752F0", VA = "0x1883762F0")]
	private void LOHBDFMHAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x83761F0", Offset = "0x83751F0", VA = "0x1883761F0")]
	private void JENDICKPABF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x83761A0", Offset = "0x83751A0", VA = "0x1883761A0")]
	private NativeList<Entity> IEHNFJFPEEI(NativeArray<Entity> PCOPFIMLFLG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8375E00", Offset = "0x8374E00", VA = "0x188375E00")]
	private NativeList<Entity> COALGKHBBFB(NativeArray<Entity> PCOPFIMLFLG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8375F60", Offset = "0x8374F60", VA = "0x188375F60")]
	private void HBDOMJCKPJI(NativeArray<Entity> PCOPFIMLFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public GLPOLOBFGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PDFOECGLEOP]
public sealed class KLDOGLKEGEG : OJNBNCLAKHE, PJNGLGAADAH
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery ENGBDOCOLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery JHLKMIFAPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery HMHFOIAGHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DLKBDHPNALP LEKMJPLEHJK;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8380640", Offset = "0x837F640", VA = "0x188380640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8380390", Offset = "0x837F390", VA = "0x188380390", Slot = "15")]
	public override void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8380810", Offset = "0x837F810", VA = "0x188380810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8380070", Offset = "0x837F070", VA = "0x188380070")]
	private void INMPIDDDFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x837F9E0", Offset = "0x837E9E0", VA = "0x18837F9E0")]
	private void GMCHPHAIMME(NativeParallelHashSet<FGANHAMJGGJ> JNDCONCHGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x837F350", Offset = "0x837E350", VA = "0x18837F350")]
	private void DJKANFFLBFM(NativeParallelHashSet<FGANHAMJGGJ> JNDCONCHGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x837EFA0", Offset = "0x837DFA0", VA = "0x18837EFA0")]
	private void AAPNFHBLBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x83803F0", Offset = "0x837F3F0", VA = "0x1883803F0")]
	private bool KCMCOFNPCIH(Entity KELHIEHPDJD, [Out] FGANHAMJGGJ OFODLANBDMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8380490", Offset = "0x837F490", VA = "0x188380490")]
	private bool NEJLMBENBEM(Entity KELHIEHPDJD, [Out] FGANHAMJGGJ OFODLANBDMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public KLDOGLKEGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PDFOECGLEOP]
public sealed class FAHGKEMHLFO : OJNBNCLAKHE
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery OFBFDBFDAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery CPKDIEEJLCI;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x83703F0", Offset = "0x836F3F0", VA = "0x1883703F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8370540", Offset = "0x836F540", VA = "0x188370540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x83700F0", Offset = "0x836F0F0", VA = "0x1883700F0")]
	private void GMCHPHAIMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x836FE00", Offset = "0x836EE00", VA = "0x18836FE00")]
	private void DJKANFFLBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public FAHGKEMHLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LAHHMGLDICB : OJNBNCLAKHE, PJNGLGAADAH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct CCEMMNCPCJH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob JINIBLGGJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob PFLIICHNDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob FNADLIPNBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob HFMLKMEJNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle HMJPHFDBGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<CIPLOEJMIIC> MHJGEODBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<FGANHAMJGGJ> IGMDIBABJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> CGPDNMMJCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> GMPFBMIKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x836D800", Offset = "0x836C800", VA = "0x18836D800", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x836D720", Offset = "0x836C720", VA = "0x18836D720")]
		private void AOMIJNJEPDD(EntityQueryInJob BMJBBIGFJMO, NativeList<Entity> LCHEFGANKDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct EKNDFFKLHFF : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle HMJPHFDBGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<CIPLOEJMIIC> MHJGEODBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<FGANHAMJGGJ> IGMDIBABJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> LCHEFGANKDE;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x836FBC0", Offset = "0x836EBC0", VA = "0x18836FBC0", Slot = "4")]
		public void Execute(ArchetypeChunk PBMMINNFPEG, int NDLMFFIOPPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct NDIJCLDMLAI : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle HMJPHFDBGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> EECMJJFDOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<GPHPADGCDNE> BMHGHIHAMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<DCPNMDMAMFE> IKFDLANBBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<CIPLOEJMIIC> OIDCKAOOFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<FGANHAMJGGJ> IGMDIBABJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> FOOBHODMOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<GPHPADGCDNE> IMKABINCMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<FGANHAMJGGJ> ALKAIDIMFBP;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83852B0", Offset = "0x83842B0", VA = "0x1883852B0", Slot = "4")]
		public void Execute(ArchetypeChunk PBMMINNFPEG, int NDLMFFIOPPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery JINIBLGGJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery PFLIICHNDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery FNADLIPNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery HFMLKMEJNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery MABLEHOHNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery NFHGHPDIALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery ALBIFHBPFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private DLKBDHPNALP MMPMMGAHKMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x83820F0", Offset = "0x83810F0", VA = "0x1883820F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8381AA0", Offset = "0x8380AA0", VA = "0x188381AA0", Slot = "15")]
	public override void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8382670", Offset = "0x8381670", VA = "0x188382670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x83814A0", Offset = "0x83804A0", VA = "0x1883814A0")]
	private void IBBMOFFIGFG(NativeParallelHashSet<FGANHAMJGGJ> IGMDIBABJGN, int IMOFMODDPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8380CC0", Offset = "0x837FCC0", VA = "0x188380CC0")]
	private void BEJFDEMMLMK(NativeParallelHashSet<FGANHAMJGGJ> IGMDIBABJGN, int FNHEPMIMCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8381B00", Offset = "0x8380B00", VA = "0x188381B00")]
	private void KHBALGCEIAM(NativeParallelHashSet<FGANHAMJGGJ> IGMDIBABJGN, int JOGCINGCCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8381110", Offset = "0x8380110", VA = "0x188381110")]
	private void HLHENCNEDCE(NativeParallelHashSet<FGANHAMJGGJ> JNDCONCHGDA, int GDGIEDPPANF, int PNJOPCMJLOA, int INIGLADLAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8381F40", Offset = "0x8380F40", VA = "0x188381F40")]
	private void OECPFEBBNOE(Entity PMOJPGIHKMB, FLJADJJDFKC OIIBOCMBCKP, FGANHAMJGGJ OFODLANBDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public LAHHMGLDICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class BGJLLHPKGCM : OJNBNCLAKHE
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery POLKOABIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery IHEIBLEBLBB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x836CF40", Offset = "0x836BF40", VA = "0x18836CF40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x836D180", Offset = "0x836C180", VA = "0x18836D180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public BGJLLHPKGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DPNDIIFAOAF : OJNBNCLAKHE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct GHLIMHIBJAI : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery FAGLJBDPIJN;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x836F790", Offset = "0x836E790", VA = "0x18836F790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x836F8D0", Offset = "0x836E8D0", VA = "0x18836F8D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public DPNDIIFAOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PDFOECGLEOP]
internal class NGNAPHCIIGP : OJNBNCLAKHE
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class GNBIFHMIEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery KGAHJKFIHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery IMDMNDOLIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FFFLKOECKOJ KPLBJMOFODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType NGLMHMPHOHA;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GNBIFHMIEAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void FFFLKOECKOJ(NativeArray<FLJADJJDFKC> EBEJPHPLJAD, DJNEMOFCFJP MGHKGJBJAPH);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<GNBIFHMIEAJ> CMLLMGEPHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private LGKOFLOEHGF BMNBEONBGBL;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8385920", Offset = "0x8384920", VA = "0x188385920", Slot = "15")]
	public override void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8385B20", Offset = "0x8384B20", VA = "0x188385B20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8385CB0", Offset = "0x8384CB0", VA = "0x188385CB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DF31B0", Offset = "0x3DF21B0", VA = "0x183DF31B0")]
	private void HLFFPCOMEJD<T>(FFFLKOECKOJ KPLBJMOFODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8385980", Offset = "0x8384980", VA = "0x188385980")]
	private static void JNEFJFBKCGP(NativeArray<FLJADJJDFKC> KNFPKIKAMOM, DJNEMOFCFJP GGDICBAEKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x83855E0", Offset = "0x83845E0", VA = "0x1883855E0")]
	private static void CJCFPPECJEC(NativeArray<FLJADJJDFKC> KNFPKIKAMOM, DJNEMOFCFJP GGDICBAEKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8385780", Offset = "0x8384780", VA = "0x188385780")]
	private static void ILHAINJIBOH(NativeArray<FLJADJJDFKC> KNFPKIKAMOM, DJNEMOFCFJP GGDICBAEKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public NGNAPHCIIGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PDFOECGLEOP]
public sealed class OHEIJELGEGM : OJNBNCLAKHE
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery BMJBBIGFJMO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8386CF0", Offset = "0x8385CF0", VA = "0x188386CF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BIPLAKDKELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS AJBCGIEIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData POLDMCLGBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public DOKODMHNDOA ABFAIEAFIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 FGDOOFKFBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool CHCEGEJGNLD;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[MOKODDBDMJN(Lifetime.LoadInstance)]
public struct LCMHFKKGDHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity KJIOEGBKNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> PMOOBGJMBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> LHDAOOAFFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<BIPLAKDKELL> EHCIJONAPBC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83829F0", Offset = "0x83819F0", VA = "0x1883829F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(IGOINIEKNEC), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class IGOINIEKNEC : PJNGLGAADAH, MEIFILLJDCJ, KELFAPLDHJK, GDOFPGECDFM
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LAHBMBLICEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly IGOINIEKNEC EBJBKAEFOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool FLPDDNNEJFN;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A08DD0", Offset = "0x1A07DD0", VA = "0x181A08DD0")]
		public LAHBMBLICEP(IGOINIEKNEC EBJBKAEFOPM, bool FLPDDNNEJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8380C00", Offset = "0x837FC00", VA = "0x188380C00")]
		public Queue<PKIAJGICOBK>.Enumerator GHDHEBFDHCI()
		{
			return default(Queue<PKIAJGICOBK>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83808C0", Offset = "0x837F8C0", VA = "0x1883808C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private MLBLOFEMENF OOEAPKFLJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private LNHIHKHCOML HMJKOALILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<KOLICHJFOBE>> PGALPFJEFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> ONILINLLEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<FLJADJJDFKC> GEKJHHFDFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private KDLOMLPKIPI<PKIAJGICOBK> FBOAHNLPFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private KDLOMLPKIPI<LCMHFKKGDHG> OCHDEIMFEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private KDLOMLPKIPI<NPHJHNLPCJA> ALMLDDBMDPB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x837E600", Offset = "0x837D600", VA = "0x18837E600", Slot = "4")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x837E800", Offset = "0x837D800", VA = "0x18837E800")]
	public void JHKFDPDGIFC(NativeList<KOLICHJFOBE> JCIKIOMMJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x837E1C0", Offset = "0x837D1C0", VA = "0x18837E1C0")]
	public void CPKKOELOHKF(Entity EBJBKAEFOPM, [In] FNGMMGDEDMM<GameObject> PGFHGMNGDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x837E130", Offset = "0x837D130", VA = "0x18837E130")]
	public void CIOJLGGOHJF(NativeList<FLJADJJDFKC> KNFPKIKAMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x837E3D0", Offset = "0x837D3D0", VA = "0x18837E3D0")]
	public void FEPDGENAJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x837DC80", Offset = "0x837CC80", VA = "0x18837DC80")]
	public void BCBJDLCEBMC(CANHEHLEDKA PAOKFDJPALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x837EB70", Offset = "0x837DB70", VA = "0x18837EB70")]
	public JobHandle MDEEOLJHEGM([In] PKIAJGICOBK OBCNAJEENCI, JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x837EAD0", Offset = "0x837DAD0", VA = "0x18837EAD0")]
	public JobHandle MDEEOLJHEGM([In] LCMHFKKGDHG OBCNAJEENCI, JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7FF9480", Offset = "0x7FF8480", VA = "0x187FF9480")]
	public LAHBMBLICEP ABKMMIJAIOP(bool FLPDDNNEJFN)
	{
		return default(LAHBMBLICEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x837EC10", Offset = "0x837DC10", VA = "0x18837EC10")]
	public KBFDHOBHDHN<LCMHFKKGDHG> OMBOOFMFAPM()
	{
		return default(KBFDHOBHDHN<LCMHFKKGDHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x837E310", Offset = "0x837D310", VA = "0x18837E310")]
	public KBFDHOBHDHN<NPHJHNLPCJA> EMJGEPKNFJJ()
	{
		return default(KBFDHOBHDHN<NPHJHNLPCJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x837E8B0", Offset = "0x837D8B0", VA = "0x18837E8B0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x837EC60", Offset = "0x837DC60", VA = "0x18837EC60", Slot = "5")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x837E360", Offset = "0x837D360", VA = "0x18837E360", Slot = "6")]
	private void FDOELKOHJIM(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x12C73A0", Offset = "0x12C63A0", VA = "0x1812C73A0", Slot = "7")]
	private void BBFHDNOELJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IGOINIEKNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct NFIBBAGBPGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS AJBCGIEIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData POLDMCLGBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NIPIDDDBDNP OGEALFKCCAP;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MOKODDBDMJN(Lifetime.LoadInstance)]
public struct PKIAJGICOBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity KJIOEGBKNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> PMOOBGJMBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> LHDAOOAFFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<LKKNDHJDELB> CCDDFEOCBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<KOLICHJFOBE> JCIKIOMMJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<NFIBBAGBPGL> CFFAMGHPJFD;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x83871F0", Offset = "0x83861F0", VA = "0x1883871F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8387200", Offset = "0x8386200", VA = "0x188387200")]
	public void NIIIKCLLCBL(bool FLPDDNNEJFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(KBHNLAFIBEN), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class KBHNLAFIBEN : FAFPDCNJCHG, KELFAPLDHJK, GDOFPGECDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private IGOINIEKNEC NJLCOLNEADO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x837EF80", Offset = "0x837DF80", VA = "0x18837EF80", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x837EF30", Offset = "0x837DF30", VA = "0x18837EF30", Slot = "5")]
	private void FDOELKOHJIM(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x12C4280", Offset = "0x12C3280", VA = "0x1812C4280", Slot = "6")]
	private void BBFHDNOELJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KBHNLAFIBEN()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : OJNBNCLAKHE, PJNGLGAADAH
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
			public NativeParallelHashMap<int, DOKODMHNDOA> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<BIPLAKDKELL> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8376DF0", Offset = "0x8375DF0", VA = "0x188376DF0", Slot = "4")]
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
			public NativeArray<KOLICHJFOBE> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<LKKNDHJDELB> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<NFIBBAGBPGL> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8377190", Offset = "0x8376190", VA = "0x188377190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x836D880", Offset = "0x836C880", VA = "0x18836D880", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x8387AE0", Offset = "0x8386AE0", VA = "0x188387AE0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x8387A90", Offset = "0x8386A90", VA = "0x188387A90")]
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
				float3 MNBDFKLNPDA(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x83836D0", Offset = "0x83826D0", VA = "0x1883836D0", Slot = "5")]
				public float3 PBGJBMHPNDM(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x8383690", Offset = "0x8382690", VA = "0x188383690", Slot = "4")]
				public float3 MNBDFKLNPDA(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x83869C0", Offset = "0x83859C0", VA = "0x1883869C0", Slot = "4")]
				public float3 MNBDFKLNPDA(quaternion rotation)
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
			public NativeArray<LKKNDHJDELB> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<KOLICHJFOBE> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8378280", Offset = "0x8377280", VA = "0x188378280", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8378E70", Offset = "0x8377E70", VA = "0x188378E70")]
			private void LDANONOKLHO(NativeList<PointSrcData> srcData, NativeList<KOLICHJFOBE> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x837AE50", Offset = "0x8379E50", VA = "0x18837AE50")]
			public static Vector3 OBHCGBFNCIF(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8379D50", Offset = "0x8378D50", VA = "0x188379D50")]
			public static quaternion MJDKIFPCMIN(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8377E80", Offset = "0x8376E80", VA = "0x188377E80")]
			private static quaternion EIDEMLDFFCB(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x83780B0", Offset = "0x83770B0", VA = "0x1883780B0")]
			private static float3 EOKDMBHAECN(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8379DD0", Offset = "0x8378DD0", VA = "0x188379DD0")]
			private static quaternion NAEEPGOBHIP(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8377C10", Offset = "0x8376C10", VA = "0x188377C10")]
			private static KOLICHJFOBE EGCCPGEFDHO(int idx, NativeList<PointSrcData> srcData)
			{
				return default(KOLICHJFOBE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x439DD80", Offset = "0x439CD80", VA = "0x18439DD80")]
			private void CPLBIMHBELB<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8379E60", Offset = "0x8378E60", VA = "0x188379E60")]
			private void NDODEKMOJPM(NativeList<PointSrcData> sourcePoints, NativeList<KOLICHJFOBE> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x837B260", Offset = "0x837A260", VA = "0x18837B260")]
			public static float OOGIGLCLDNN(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x837B590", Offset = "0x837A590", VA = "0x18837B590")]
			private static quaternion PMAGOIOOJGI(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8377A60", Offset = "0x8376A60", VA = "0x188377A60")]
			private static KOLICHJFOBE DDDEFBHFNOD(PointSrcData point)
			{
				return default(KOLICHJFOBE);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8377B80", Offset = "0x8376B80", VA = "0x188377B80")]
			private static KOLICHJFOBE DDDEFBHFNOD(float3 pos, quaternion rot, float radius)
			{
				return default(KOLICHJFOBE);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8378DD0", Offset = "0x8377DD0", VA = "0x188378DD0")]
			private static bool HJAJGJHLAHC(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8378D00", Offset = "0x8377D00", VA = "0x188378D00")]
			private static float3 GHENPMDEIGD(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x83778B0", Offset = "0x83768B0", VA = "0x1883778B0")]
			public static float3 ADLHAFPECJA(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x837B3E0", Offset = "0x837A3E0", VA = "0x18837B3E0")]
			public static float3 PBGJBMHPNDM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x83788A0", Offset = "0x83778A0", VA = "0x1883788A0")]
			private static quaternion FPDHNBKIECM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x837AC70", Offset = "0x8379C70", VA = "0x18837AC70")]
			private static float OANDCGEOAMP(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x8389B40", Offset = "0x8388B40", VA = "0x188389B40")]
			private void IPDILOFAIGN(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8389A50", Offset = "0x8388A50", VA = "0x188389A50", Slot = "4")]
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
			public NativeList<KOLICHJFOBE> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x838B4E0", Offset = "0x838A4E0", VA = "0x18838B4E0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x838B4D0", Offset = "0x838A4D0", VA = "0x18838B4D0", Slot = "4")]
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
			public NativeList<KOLICHJFOBE> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x838B480", Offset = "0x838A480", VA = "0x18838B480")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x838B470", Offset = "0x838A470", VA = "0x18838B470", Slot = "4")]
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
			public NativeList<BIPLAKDKELL> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x83774E0", Offset = "0x83764E0", VA = "0x1883774E0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x83774D0", Offset = "0x83764D0", VA = "0x1883774D0", Slot = "4")]
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
			public NativeList<LKKNDHJDELB> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<NFIBBAGBPGL> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83776B0", Offset = "0x83766B0", VA = "0x1883776B0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83776A0", Offset = "0x83766A0", VA = "0x1883776A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x838B050", Offset = "0x838A050", VA = "0x18838B050")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x838B040", Offset = "0x838A040", VA = "0x18838B040", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly ONIHMLNNEEF log;

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
		private BIDEHNPHCNI replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MLBLOFEMENF objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IGOINIEKNEC bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private PAKDOOIPEAH ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83894A0", Offset = "0x83884A0", VA = "0x1883894A0", Slot = "15")]
		public override void InitReferences(BLPLIKKLKBG services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x838AA50", Offset = "0x8389A50", VA = "0x18838AA50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x838AB40", Offset = "0x8389B40", VA = "0x18838AB40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x838ABA0", Offset = "0x8389BA0", VA = "0x18838ABA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8387E80", Offset = "0x8386E80", VA = "0x188387E80")]
		private JobHandle BGHLOBKAEOD(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8389C20", Offset = "0x8388C20", VA = "0x188389C20")]
		private JobHandle MLLCKMGFDLN(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83883B0", Offset = "0x83873B0", VA = "0x1883883B0")]
		private JobHandle PKBJPFIGPJC(NativeArray<int> pointCount, NativeList<KOLICHJFOBE> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8388920", Offset = "0x8387920", VA = "0x188388920")]
		private JobHandle HGBHNNADMIM(NativeList<KOLICHJFOBE> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83889C0", Offset = "0x83879C0", VA = "0x1883889C0")]
		private JobHandle HIENACBCAAK(EntityQuery query, NativeList<LKKNDHJDELB> splinePointRanges, NativeList<KOLICHJFOBE> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8389380", Offset = "0x8388380", VA = "0x188389380")]
		private JobHandle IKFHBEGLHCO(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8388800", Offset = "0x8387800", VA = "0x188388800")]
		private JobHandle HCPBPCEHOCN(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x838AD10", Offset = "0x8389D10", VA = "0x18838AD10")]
		private JobHandle PFCJGJBNLDJ(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<BIPLAKDKELL> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8388540", Offset = "0x8387540", VA = "0x188388540")]
		private JobHandle EJCKNEFHAMM(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<LKKNDHJDELB> splinePointRanges, [Out] NativeList<NFIBBAGBPGL> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8387B00", Offset = "0x8386B00", VA = "0x188387B00")]
		private JobHandle AKMGJLIIMEJ(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8389540", Offset = "0x8388540", VA = "0x188389540")]
		private JobHandle JNBNDCHHEFO(EntityQuery query, NativeList<BIPLAKDKELL> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x838A2E0", Offset = "0x83892E0", VA = "0x18838A2E0")]
		private static NativeParallelHashMap<int, DOKODMHNDOA> NLDHDMBLFOF()
		{
			return default(NativeParallelHashMap<int, DOKODMHNDOA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8388FE0", Offset = "0x8387FE0", VA = "0x188388FE0")]
		private JobHandle IBOKGAEJEJJ(EntityQuery query, NativeList<LKKNDHJDELB> splinePointRanges, NativeList<KOLICHJFOBE> splinePointData, NativeList<NFIBBAGBPGL> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x83882D0", Offset = "0x83872D0", VA = "0x1883882D0")]
		private JobHandle BPIINEEOOOA(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83883B0", Offset = "0x83873B0", VA = "0x1883883B0")]
		private JobHandle CDLHNONIMCF(NativeArray<int> pointCount, NativeList<KOLICHJFOBE> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8388920", Offset = "0x8387920", VA = "0x188388920")]
		private JobHandle NHJPEEADBEA(NativeList<KOLICHJFOBE> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8388450", Offset = "0x8387450", VA = "0x188388450")]
		private JobHandle DINEOLDMDDA(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<BIPLAKDKELL> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83881C0", Offset = "0x83871C0", VA = "0x1883881C0")]
		private JobHandle BHCHBFNGNLI(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<LKKNDHJDELB> ranges, NativeList<NFIBBAGBPGL> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8388E90", Offset = "0x8387E90", VA = "0x188388E90")]
		private JobHandle HJPNJHJAJCA(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x838A700", Offset = "0x8389700", VA = "0x18838A700", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class ILKNEPCLFJG : CJAAJCOIOJB, PJNGLGAADAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private IGOINIEKNEC NJLCOLNEADO;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x837EDD0", Offset = "0x837DDD0", VA = "0x18837EDD0", Slot = "14")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x837EE20", Offset = "0x837DE20", VA = "0x18837EE20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
	public ILKNEPCLFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class GJDFLHGPCAM : OJNBNCLAKHE, PJNGLGAADAH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct MHOOEBPOHOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager FMBMFCMHGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NKAAFNLJAAO<T> DKHDCGMKNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int HLGKMAPOEBE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x56D7520", Offset = "0x56D6520", VA = "0x1856D7520")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x56D7FA0", Offset = "0x56D6FA0", VA = "0x1856D7FA0")]
		public MHOOEBPOHOB(EntityManager FMBMFCMHGGJ, NKAAFNLJAAO<T> DKHDCGMKNOM, NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x49C3D30", Offset = "0x49C2D30", VA = "0x1849C3D30")]
		public MHOOEBPOHOB<T> GHDHEBFDHCI()
		{
			return default(MHOOEBPOHOB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x56D7F40", Offset = "0x56D6F40", VA = "0x1856D7F40")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ONIHMLNNEEF JJJGICJMGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LNHIHKHCOML HMJKOALILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IGOINIEKNEC NJLCOLNEADO;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8372490", Offset = "0x8371490", VA = "0x188372490", Slot = "15")]
	public override void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x83729F0", Offset = "0x83719F0", VA = "0x1883729F0")]
	public void MLBINOBNFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8373B40", Offset = "0x8372B40", VA = "0x188373B40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8372A20", Offset = "0x8371A20", VA = "0x188372A20")]
	private void MMHBHDEABPF(NPHJHNLPCJA OBCNAJEENCI, Mesh[] BIEDIFDPLJP, NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F3A0", Offset = "0x3C5E3A0", VA = "0x183C5F3A0")]
	private MHOOEBPOHOB<T> FECHLGEBCFG<T>(NKAAFNLJAAO<T> DKHDCGMKNOM, NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL) where T : struct
	{
		return default(MHOOEBPOHOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8371180", Offset = "0x8370180", VA = "0x188371180")]
	private void BBALLAKFICD(Transform EBJBKAEFOPM, NativeArray<AHNCACIPFMO> GDDDCMPPAHK, FNGMMGDEDMM<GameObject> KINOPACNLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8374CC0", Offset = "0x8373CC0", VA = "0x188374CC0")]
	private void PGHNONGOIJP(Transform EBJBKAEFOPM, NativeArray<MCNLPCOOOIH> POBOIHDKJAD, FNGMMGDEDMM<GameObject> KINOPACNLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8372510", Offset = "0x8371510", VA = "0x188372510")]
	private void KJKAGFFMOJI(Transform EBJBKAEFOPM, NativeArray<INMCAKEGCGH> OCPECJKMPEN, FNGMMGDEDMM<GameObject> KINOPACNLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8371510", Offset = "0x8370510", VA = "0x188371510")]
	private void BKOOLPFLJJJ(Transform EBJBKAEFOPM, NativeArray<JGNCNLEAGON> BIEDIFDPLJP, Mesh[] FEFOMBDJHDI, FNGMMGDEDMM<GameObject> KINOPACNLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8372340", Offset = "0x8371340", VA = "0x188372340")]
	private static void IOIKFJEPCAG(NativeParallelHashSet<Entity> PCOPFIMLFLG, NativeParallelHashSet<Entity> FOICANJOCGI, NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8371940", Offset = "0x8370940", VA = "0x188371940")]
	private static void DBGCGOFCBHB(NativeList<Entity> KKAPDLIJLLM, NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8375180", Offset = "0x8374180", VA = "0x188375180")]
	private NativeParallelHashMap<Entity, DCPNMDMAMFE> PJFOGHIJGHF(IGOINIEKNEC.LAHBMBLICEP NKBFJLMEHMG, KBFDHOBHDHN<LCMHFKKGDHG> BLONJANLMIJ, List<GameObject> KINOPACNLHL)
	{
		return default(NativeParallelHashMap<Entity, DCPNMDMAMFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x83728F0", Offset = "0x83718F0", VA = "0x1883728F0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> MKPNKOAPPBP(Entity IIAMOGJDDJD)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8371A00", Offset = "0x8370A00", VA = "0x188371A00")]
	private void HDELMDKGLLA(NativeList<Entity> BFMACILFDLM, NativeList<Entity> GNEHCLHFPAA, NativeParallelHashMap<Entity, DCPNMDMAMFE> DIAIGCMPJPB, NativeList<LKKNDHJDELB> BBPAEKAKICE, NativeList<KOLICHJFOBE> CDMLKFBOLCG, NativeList<NFIBBAGBPGL> PGALPFJEFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8371F50", Offset = "0x8370F50", VA = "0x188371F50")]
	private void IOGBGFGGNBE(NativeList<Entity> PCOPFIMLFLG, NativeList<Entity> PMOOBGJMBHK, NativeParallelHashMap<Entity, DCPNMDMAMFE> DIAIGCMPJPB, NativeList<BIPLAKDKELL> EHCIJONAPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x836D710", Offset = "0x836C710", VA = "0x18836D710")]
	public GJDFLHGPCAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class GMMMOBNJECB : AEFNLMCLFOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS AJBCGIEIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly CJNFLLJGPFC EBJBKAEFOPM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject CDHNIFNKKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS NJAJNEEFFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8376CC0", Offset = "0x8375CC0", VA = "0x188376CC0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 NDKNINKFEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8376A40", Offset = "0x8375A40", VA = "0x188376A40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 BHCDAABJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8376AE0", Offset = "0x8375AE0", VA = "0x188376AE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 BDFGOJIONDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8376B30", Offset = "0x8375B30", VA = "0x188376B30", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83769F0", Offset = "0x83759F0", VA = "0x1883769F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion IGOJBLALCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8376BD0", Offset = "0x8375BD0", VA = "0x188376BD0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8376C20", Offset = "0x8375C20", VA = "0x188376C20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 EOMGDMINNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8376C70", Offset = "0x8375C70", VA = "0x188376C70", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 FGAACNHFKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8376B80", Offset = "0x8375B80", VA = "0x188376B80", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 KMEJHFHIEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8376A90", Offset = "0x8375A90", VA = "0x188376A90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8376DA0", Offset = "0x8375DA0", VA = "0x188376DA0")]
	public GMMMOBNJECB(UniformTRS AJBCGIEIIAC, CJNFLLJGPFC EBJBKAEFOPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class ANNJBPKJBNN : GMMMOBNJECB, JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float GFBPONDLNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 LNGOLIMELND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly KOGANNKCGHD GGLLCOBILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly DOKJMPJMCCI GMLDDAFCAKD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private MHHODEBGAFD MFGPALMPGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x836C6E0", Offset = "0x836B6E0", VA = "0x18836C6E0", Slot = "17")]
		get
		{
			return default(MHHODEBGAFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS NHNLPCGJHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x836C780", Offset = "0x836B780", VA = "0x18836C780", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float AINDIDBDCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAB2F30", Offset = "0xAB1F30", VA = "0x180AB2F30", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 GMANJOINDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x836C730", Offset = "0x836B730", VA = "0x18836C730", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private KOGANNKCGHD IMCALNJLGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xAD3230", Offset = "0xAD2230", VA = "0x180AD3230", Slot = "21")]
		get
		{
			return default(KOGANNKCGHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private DOKJMPJMCCI MFEEPDAIMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x143B970", Offset = "0x143A970", VA = "0x18143B970", Slot = "22")]
		get
		{
			return default(DOKJMPJMCCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool LAHJCKHOPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool OBHJHGHKLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x836C860", Offset = "0x836B860", VA = "0x18836C860")]
	protected ANNJBPKJBNN(UniformTRS AJBCGIEIIAC, CJNFLLJGPFC EBJBKAEFOPM, float GFBPONDLNBA, float3 LNGOLIMELND, KOGANNKCGHD GGLLCOBILLK, DOKJMPJMCCI GMLDDAFCAKD)
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
public abstract class IDFOKLPEEIM : AEFNLMCLFOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly GOLADBGGMAB NCIBPMAFIKA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected CJNFLLJGPFC PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1298290", Offset = "0x1297290", VA = "0x181298290")]
		get
		{
			return default(CJNFLLJGPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity NLJPPBMCPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x837D580", Offset = "0x837C580", VA = "0x18837D580")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected MLBLOFEMENF COOMBFPNNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x837D6D0", Offset = "0x837C6D0", VA = "0x18837D6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected IANIJLFPGEK HENPKKNEMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x837CFC0", Offset = "0x837BFC0", VA = "0x18837CFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected CPPFMOPAJKK DLLFACHBFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x837DBF0", Offset = "0x837CBF0", VA = "0x18837DBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject CDHNIFNKKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x837D3E0", Offset = "0x837C3E0", VA = "0x18837D3E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS NJAJNEEFFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12D2260", Offset = "0x12D1260", VA = "0x1812D2260", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 NDKNINKFEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x837D130", Offset = "0x837C130", VA = "0x18837D130", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 BHCDAABJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x837D410", Offset = "0x837C410", VA = "0x18837D410", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 BDFGOJIONDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x837D5A0", Offset = "0x837C5A0", VA = "0x18837D5A0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x837D020", Offset = "0x837C020", VA = "0x18837D020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion IGOJBLALCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x837D8A0", Offset = "0x837C8A0", VA = "0x18837D8A0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x837D9C0", Offset = "0x837C9C0", VA = "0x18837D9C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 EOMGDMINNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x837DAD0", Offset = "0x837CAD0", VA = "0x18837DAD0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 FGAACNHFKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x837D6E0", Offset = "0x837C6E0", VA = "0x18837D6E0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 KMEJHFHIEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x837D220", Offset = "0x837C220", VA = "0x18837D220", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xF1F8E0", Offset = "0xF1E8E0", VA = "0x180F1F8E0")]
	protected IDFOKLPEEIM(GOLADBGGMAB GNMFDIECOJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x837DBC0", Offset = "0x837CBC0", VA = "0x18837DBC0")]
	public static MHHODEBGAFD MJOOONLKLLN(IDFOKLPEEIM HBPDACJCCKM)
	{
		return default(MHHODEBGAFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LGEPKGDDAKJ
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x838D0F0", Offset = "0x838C0F0", VA = "0x18838D0F0")]
	public static void JPADHCGJBDJ(NativeArray<Entity> PCOPFIMLFLG, EntityManager FMBMFCMHGGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CAELJJEEKPK
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x838C020", Offset = "0x838B020", VA = "0x18838C020")]
	public static void CJMNFKJJLNL(NativeArray<Entity> PCOPFIMLFLG, EntityManager FMBMFCMHGGJ, CANHEHLEDKA GJLMIFDDMCP, MLBLOFEMENF PMNGIBDJKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x838C6D0", Offset = "0x838B6D0", VA = "0x18838C6D0")]
	public static void EEPOOCNCKPE(NativeArray<Entity> PCOPFIMLFLG, EntityManager FMBMFCMHGGJ, CANHEHLEDKA GJLMIFDDMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x838C430", Offset = "0x838B430", VA = "0x18838C430")]
	public static NativeList<Entity> COALGKHBBFB(NativeArray<Entity> PCOPFIMLFLG, EntityManager FMBMFCMHGGJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x838C9E0", Offset = "0x838B9E0", VA = "0x18838C9E0")]
	public static NativeList<Entity> IEHNFJFPEEI(NativeArray<Entity> PCOPFIMLFLG, EntityManager FMBMFCMHGGJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x838C470", Offset = "0x838B470", VA = "0x18838C470")]
	private static NativeList<Entity> COALGKHBBFB(NativeArray<Entity> PCOPFIMLFLG, EntityManager FMBMFCMHGGJ, bool GNKBJEHMLLH)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class FDPHCMLIKCI : IDFOKLPEEIM, JMBBCJIGALM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float GFBPONDLNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 LNGOLIMELND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private KOGANNKCGHD GGLLCOBILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private DOKJMPJMCCI GMLDDAFCAKD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager GLANLJGHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x838CDB0", Offset = "0x838BDB0", VA = "0x18838CDB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected AIMNAMMCJGJ AABFOAEAFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x838CC60", Offset = "0x838BC60", VA = "0x18838CC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData MKKBEDOANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x838CCC0", Offset = "0x838BCC0", VA = "0x18838CCC0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private MHHODEBGAFD MFGPALMPGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x837DBC0", Offset = "0x837CBC0", VA = "0x18837DBC0", Slot = "17")]
		get
		{
			return default(MHHODEBGAFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float AINDIDBDCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xABF1F0", Offset = "0xABE1F0", VA = "0x180ABF1F0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 GMANJOINDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x13AC190", Offset = "0x13AB190", VA = "0x1813AC190", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private KOGANNKCGHD IMCALNJLGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0", Slot = "21")]
		get
		{
			return default(KOGANNKCGHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private DOKJMPJMCCI MFEEPDAIMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090", Slot = "22")]
		get
		{
			return default(DOKJMPJMCCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS NHNLPCGJHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x838CFD0", Offset = "0x838BFD0", VA = "0x18838CFD0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool OBHJHGHKLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool LAHJCKHOPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x838D000", Offset = "0x838C000", VA = "0x18838D000")]
	protected FDPHCMLIKCI(GOLADBGGMAB GNMFDIECOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x838CE40", Offset = "0x838BE40", VA = "0x18838CE40", Slot = "26")]
	public virtual void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class OJNBNCLAKHE : CJAAJCOIOJB, PJNGLGAADAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected MLBLOFEMENF PMNGIBDJKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private CPHOFNKOFED IEHKKLCADNA;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected CANHEHLEDKA DGNOGNOGGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x838D380", Offset = "0x838C380", VA = "0x18838D380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected DJNEMOFCFJP AKEFDKNONMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x838D330", Offset = "0x838C330", VA = "0x18838D330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool NLAENCKPMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x838D3D0", Offset = "0x838C3D0", VA = "0x18838D3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x838D490", Offset = "0x838C490", VA = "0x18838D490", Slot = "15")]
	public virtual void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
	protected OJNBNCLAKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ELCECMGBEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x838CA20", Offset = "0x838BA20", VA = "0x18838CA20")]
	public static void FJLNLBKLICC(NativeArray<Entity> BFMACILFDLM, EntityManager FMBMFCMHGGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1414780430
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x838D6C0", Offset = "0x838C6C0", VA = "0x18838D6C0")]
	public static void ELOKOGMACMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x838D940", Offset = "0x838C940", VA = "0x18838D940")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class IGFPCKALOMJ : ContainerPropertyBag<PDKINFNIGMG>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x838D090", Offset = "0x838C090", VA = "0x18838D090")]
	public IGFPCKALOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class GIICLJOPDHO : ContainerPropertyBag<PNLKKMEFIJF>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x838D030", Offset = "0x838C030", VA = "0x18838D030")]
	public GIICLJOPDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class AFKEFCLJEGH : ContainerPropertyBag<DPPIGNGMEKD>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x838BFC0", Offset = "0x838AFC0", VA = "0x18838BFC0")]
	public AFKEFCLJEGH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x838D500", Offset = "0x838C500", VA = "0x18838D500")]
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
