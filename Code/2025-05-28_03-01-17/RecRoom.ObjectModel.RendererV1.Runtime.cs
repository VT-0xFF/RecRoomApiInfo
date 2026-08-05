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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FA02E0", Offset = "0x7F9F0E0", VA = "0x187FA02E0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20D9300", Offset = "0x20D8100", VA = "0x1820D9300", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5B30", Offset = "0x7FA4930", VA = "0x187FA5B30")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FA60D0", Offset = "0x7FA4ED0", VA = "0x187FA60D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6130", Offset = "0x7FA4F30", VA = "0x187FA6130")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MNFOMNOHJEC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA07C0", Offset = "0x7F9F5C0", VA = "0x187FA07C0")]
	public static Quaternion EFNPJJABCCI([In] this BHFKEEBMCFO PPNONDAGEOL, [In] Vector3 MACLBEFOGKL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GGCINGGNPPM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F91E50", Offset = "0x7F90C50", VA = "0x187F91E50")]
	public static bool OEHELNJDAPE(this GPDKOMIOIOC GLOHLOECDHC, PGGJHKNGOPJ BFCGDPAMADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F909C0", Offset = "0x7F8F7C0", VA = "0x187F909C0")]
	public static bool DCNDHOEOLDP(this GPDKOMIOIOC GLOHLOECDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F906C0", Offset = "0x7F8F4C0", VA = "0x187F906C0")]
	public static bool ANJMBINHPFG(this GPDKOMIOIOC GLOHLOECDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F90C80", Offset = "0x7F8FA80", VA = "0x187F90C80")]
	public static void GBOCMKJKIJJ(this GPDKOMIOIOC GLOHLOECDHC, Vector3 GOPFKHHAGKA, Quaternion HPBEHKPPAAA, float MEHMJKKFJEH, bool GGMBFPBEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F909F0", Offset = "0x7F8F7F0", VA = "0x187F909F0")]
	public static void FKILEHFKKCB(this GPDKOMIOIOC GLOHLOECDHC, Vector3 GOPFKHHAGKA, Quaternion HPBEHKPPAAA, float MEHMJKKFJEH, int DFMJPHGLEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F90DB0", Offset = "0x7F8FBB0", VA = "0x187F90DB0")]
	public static void GILPAMGKJBK(this GPDKOMIOIOC GLOHLOECDHC, int DFMJPHGLEOM, Vector3 GOPFKHHAGKA, Quaternion HPBEHKPPAAA, float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F91280", Offset = "0x7F90080", VA = "0x187F91280")]
	public static void KGIKGDHFPHE(this GPDKOMIOIOC GLOHLOECDHC, Vector3 DOLGMJKDGLD, Quaternion HIOHNJPLIFL, float MEHMJKKFJEH, bool GGMBFPBEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F914F0", Offset = "0x7F902F0", VA = "0x187F914F0")]
	private static void NCFPHJEOFIK(this GPDKOMIOIOC GLOHLOECDHC, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float MEHMJKKFJEH, bool GGMBFPBEADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F910C0", Offset = "0x7F8FEC0", VA = "0x187F910C0")]
	private static void IMDLPJCHOGH(this GPDKOMIOIOC GLOHLOECDHC, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL, float DIAOLLCPBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F90ED0", Offset = "0x7F8FCD0", VA = "0x187F90ED0")]
	private static void HBHNBPPBHJE(this GPDKOMIOIOC GLOHLOECDHC, int GLAOLHCPLLG, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL, float DIAOLLCPBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F906F0", Offset = "0x7F8F4F0", VA = "0x187F906F0")]
	private static bool APFJFLMPAOP(this GPDKOMIOIOC GLOHLOECDHC, int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F90720", Offset = "0x7F8F520", VA = "0x187F90720")]
	private static void BGOJKLOJOIJ(this GPDKOMIOIOC GLOHLOECDHC, int GLAOLHCPLLG, Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL, float DIAOLLCPBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F901D0", Offset = "0x7F8EFD0", VA = "0x187F901D0")]
	public static Vector3 ALBOOIKIDIM(this GPDKOMIOIOC GLOHLOECDHC, int GLAOLHCPLLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F91E90", Offset = "0x7F90C90", VA = "0x187F91E90")]
	public static Quaternion OHELCOIBEHN(this GPDKOMIOIOC GLOHLOECDHC, int GLAOLHCPLLG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F912D0", Offset = "0x7F900D0", VA = "0x187F912D0")]
	public static Vector3 MJKIFPODMNH(PGGJHKNGOPJ KKBDAOHAGLC, Vector3 NPJPCFKLMHD, Vector3? MCIEPJDGKEJ, Vector3 HDJPDJPKNAK)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface NNHAJKAICIO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABFNBICKBH(EntityQuery LPMNLGHDNKG, EntityManager CCPBGAMLKKA, PHMNNCHKCOI NMFFKEACGFO, DMKHLICKBBC MPCLMEDIELO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface ELOFIOOFOJC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType HNEIKFGJHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEMABEHKBJC(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJJJNJCINIL(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOOKBOPGHGJ(GDJLPLLNOFP CJGOHNIPOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class ICJIBLDPNAB : NNHAJKAICIO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C210", Offset = "0x7F9B010", VA = "0x187F9C210", Slot = "4")]
	public void AABFNBICKBH(EntityQuery LPMNLGHDNKG, EntityManager CCPBGAMLKKA, PHMNNCHKCOI NMFFKEACGFO, DMKHLICKBBC MPCLMEDIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public ICJIBLDPNAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class HAMEAFHENGD : NNHAJKAICIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BBFHFFOIEKE ALNLEONPBLH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
	public HAMEAFHENGD(BBFHFFOIEKE ALNLEONPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B970", Offset = "0x7F9A770", VA = "0x187F9B970", Slot = "4")]
	public void AABFNBICKBH(EntityQuery LPMNLGHDNKG, EntityManager CCPBGAMLKKA, PHMNNCHKCOI NMFFKEACGFO, DMKHLICKBBC MPCLMEDIELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PBCKEOFGIOA : NNHAJKAICIO
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FA14B0", Offset = "0x7FA02B0", VA = "0x187FA14B0", Slot = "4")]
	public void AABFNBICKBH(EntityQuery LPMNLGHDNKG, EntityManager CCPBGAMLKKA, PHMNNCHKCOI NMFFKEACGFO, DMKHLICKBBC MPCLMEDIELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PBCKEOFGIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PCIDFHNPMAH : ELOFIOOFOJC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType HNEIKFGJHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FA15F0", Offset = "0x7FA03F0", VA = "0x187FA15F0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FA18A0", Offset = "0x7FA06A0", VA = "0x187FA18A0", Slot = "5")]
	public void HEMABEHKBJC(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1620", Offset = "0x7FA0420", VA = "0x187FA1620", Slot = "6")]
	public void GJJJNJCINIL(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1B20", Offset = "0x7FA0920", VA = "0x187FA1B20", Slot = "7")]
	public void JOOKBOPGHGJ(GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PCIDFHNPMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BMNOJBEAFDK : ELOFIOOFOJC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType HNEIKFGJHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F895F0", Offset = "0x7F883F0", VA = "0x187F895F0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F898A0", Offset = "0x7F886A0", VA = "0x187F898A0", Slot = "5")]
	public void HEMABEHKBJC(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F89620", Offset = "0x7F88420", VA = "0x187F89620", Slot = "6")]
	public void GJJJNJCINIL(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F89B20", Offset = "0x7F88920", VA = "0x187F89B20", Slot = "7")]
	public void JOOKBOPGHGJ(GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BMNOJBEAFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FBAIEEOMGKL : ELOFIOOFOJC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType HNEIKFGJHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F8D2D0", Offset = "0x7F8C0D0", VA = "0x187F8D2D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D580", Offset = "0x7F8C380", VA = "0x187F8D580", Slot = "5")]
	public void HEMABEHKBJC(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D300", Offset = "0x7F8C100", VA = "0x187F8D300", Slot = "6")]
	public void GJJJNJCINIL(EntityQuery LPMNLGHDNKG, GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D800", Offset = "0x7F8C600", VA = "0x187F8D800", Slot = "7")]
	public void JOOKBOPGHGJ(GDJLPLLNOFP CJGOHNIPOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FBAIEEOMGKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class ECFIMKLCPPC : PKLCKAMFOHP, GACJOGFPDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PHMNNCHKCOI NMFFKEACGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BAFJGOHFPIO AGDCFJLPIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private DMKHLICKBBC MPCLMEDIELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, NNHAJKAICIO adapter)> DNKJMFNAGPH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CC40", Offset = "0x7F8BA40", VA = "0x187F8CC40", Slot = "15")]
	public virtual void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CE40", Offset = "0x7F8BC40", VA = "0x187F8CE40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CCD0", Offset = "0x7F8BAD0", VA = "0x187F8CCD0")]
	private void LCDGDLPCNND(EntityQueryDesc AEEBALPNNBP, NNHAJKAICIO FMANEAHMKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D070", Offset = "0x7F8BE70", VA = "0x187F8D070", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
	public ECFIMKLCPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class IOPLAMIPLMO : PKLCKAMFOHP, GACJOGFPDAE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class DJLKGKGPOLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery BLLNNBBIEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery INAEJMPNILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery OEDIKHHJGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery POMMKCENOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery PMIPAMIOJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery CDENILOMGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery OFKHDKNAGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ELOFIOOFOJC DHFHEALEPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType JGIMJCCOAGH;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DJLKGKGPOLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PHMNNCHKCOI NMFFKEACGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DMKHLICKBBC MPCLMEDIELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private BAFJGOHFPIO AGDCFJLPIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<DJLKGKGPOLN> DNKJMFNAGPH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C420", Offset = "0x7F9B220", VA = "0x187F9C420", Slot = "14")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D040", Offset = "0x7F9BE40", VA = "0x187F9D040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D1C0", Offset = "0x7F9BFC0", VA = "0x187F9D1C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CBF0", Offset = "0x7F9B9F0", VA = "0x187F9CBF0")]
	private void ODIHDCMJJJH(DJLKGKGPOLN BKGJFHDBIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C4B0", Offset = "0x7F9B2B0", VA = "0x187F9C4B0")]
	private void LCDGDLPCNND(ELOFIOOFOJC DHFHEALEPJG, ComponentType MHIDLCOPKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
	public IOPLAMIPLMO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct FFMGKALFGPE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct BHJPDNBFKPF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct FPJICPDFLLD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(DMKHLICKBBC), new string[] { })]
public class BMNLFNEKIFK : DMKHLICKBBC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MNEOPFCLMIK ILNKCAOGEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MNEOPFCLMIK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public BMNLFNEKIFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(JODNHFAOMAE), new string[] { })]
public class CHDKDPGJOCN : JODNHFAOMAE, DKKCOAOBEHF, AHDIFPEGPEL, FAGFKOAOOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private KEIHHBEOEPM KBBMPPHMANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private PHMNNCHKCOI NMFFKEACGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private FNPHLLFAMCL BNLNGOBLDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity EAMAEKEGGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private BLHOJKOBONC EAOFKHCNCLE;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F89B70", Offset = "0x7F88970", VA = "0x187F89B70", Slot = "4")]
	public bool ALIKBBIJCCC(JBBGAMGOICI CBBNAACPEGP, MPGMAKFMEHA OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F89C50", Offset = "0x7F88A50", VA = "0x187F89C50", Slot = "5")]
	public BLHOJKOBONC HOGAEMGOJAJ()
	{
		return default(BLHOJKOBONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F89FA0", Offset = "0x7F88DA0", VA = "0x187F89FA0", Slot = "6")]
	public void KMEHAKMMBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F89F10", Offset = "0x7F88D10", VA = "0x187F89F10", Slot = "7")]
	private void KHEDDOBEPFG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x11F5F90", Offset = "0x11F4D90", VA = "0x1811F5F90", Slot = "8")]
	private void JLHNKKDCLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CHDKDPGJOCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(BJAFFPIEHPF), new string[] { })]
public class JBECCNFJEDB : BJAFFPIEHPF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D650", Offset = "0x7F9C450", VA = "0x187F9D650", Slot = "4")]
	public void CKLHMLOOCGC(World KBBMPPHMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D6D0", Offset = "0x7F9C4D0", VA = "0x187F9D6D0", Slot = "5")]
	public void GHJJDEAHGHJ(World KBBMPPHMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D720", Offset = "0x7F9C520", VA = "0x187F9D720", Slot = "6")]
	public ComponentSystemBase IDLMCJJCFGL(World KBBMPPHMANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D7E0", Offset = "0x7F9C5E0", VA = "0x187F9D7E0", Slot = "7")]
	public void MGFDNPEHMLF(World KBBMPPHMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D5F0", Offset = "0x7F9C3F0", VA = "0x187F9D5F0", Slot = "8")]
	public void CINCCNHMIEJ(World KBBMPPHMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D590", Offset = "0x7F9C390", VA = "0x187F9D590", Slot = "9")]
	public void CHDOCNCFICA(World KBBMPPHMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D770", Offset = "0x7F9C570", VA = "0x187F9D770", Slot = "10")]
	public void KPPBBBENNHI(World KBBMPPHMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D840", Offset = "0x7F9C640", VA = "0x187F9D840", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> OHLPIJDHFLB()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JBECCNFJEDB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct KBBKDGIKBIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct BALBLKFJMPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CIBCCEMGGIN : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EPJPNHNLMPC DHOIIIHMNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B2A0", Offset = "0x7F8A0A0", VA = "0x187F8B2A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B230", Offset = "0x7F8A030", VA = "0x187F8B230", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CIBCCEMGGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct MINENEEIPBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public BLHOJKOBONC FPEGLGDOFAG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static MINENEEIPBC HEKJAOMNHLJ(BLHOJKOBONC BHHPJCAPOMD)
	{
		return default(MINENEEIPBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JAFJOPPLADG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HFMBOPLHMPF JLDLIAJGPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D460", Offset = "0x7F9C260", VA = "0x187F9D460", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JAFJOPPLADG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct MHCOAOHKAGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct EKDLHNAIJLH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public FANFIOCPJIG CNFOADENEII;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static EKDLHNAIJLH HEKJAOMNHLJ(FANFIOCPJIG BHHPJCAPOMD)
	{
		return default(EKDLHNAIJLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct LJOEOBHEOFO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BLHOJKOBONC FPEGLGDOFAG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static LJOEOBHEOFO HEKJAOMNHLJ(BLHOJKOBONC BHHPJCAPOMD)
	{
		return default(LJOEOBHEOFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JAGCCAOKGCE : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FLPJCOCICAD CLBNDJBOOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D540", Offset = "0x7F9C340", VA = "0x187F9D540", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D4D0", Offset = "0x7F9C2D0", VA = "0x187F9D4D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public JAGCCAOKGCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GNKABGBKDCP : JHHMFIIPJOJ, EPJPNHNLMPC, GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JBBAGKFDBNF JPGHHKCECDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xD5AFA0", Offset = "0xD59DA0", VA = "0x180D5AFA0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(JBBAGKFDBNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LPEOJCIOMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC2CF80", Offset = "0xC2BD80", VA = "0x180C2CF80", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 PFEPEINALJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1110C70", Offset = "0x110FA70", VA = "0x181110C70", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F92240", Offset = "0x7F91040", VA = "0x187F92240")]
	public GNKABGBKDCP(UniformTRS OAAOKGIMOHH, GALEOJBODPG BOGJJGPKPIJ, float MGKFNAJLFPM, float3 IJKOECMCNMM, FLGDJDIBGKI GKEJGMJMNOD, BDLOEKFKAIO PGLPAGHPDBF, JBBAGKFDBNF MNGJGHJDPLA, float3 BAAINAAOMAP, bool JFKBJHLNDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F921F0", Offset = "0x7F90FF0", VA = "0x187F921F0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PFLGJBLMCDA : JHHMFIIPJOJ, FLPJCOCICAD, GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<CCHLCODHAON> NGODMFFAOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LBIFFCGMBDC CNCKIIIBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float BMCNJIBFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int PHIOHHPKAEP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JBNHOGIHMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1CE0", Offset = "0x7FA0AE0", VA = "0x187FA1CE0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IMDCLHNOKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1D00", Offset = "0x7FA0B00", VA = "0x187FA1D00", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LCBEGGAOLML
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1CF0", Offset = "0x7FA0AF0", VA = "0x187FA1CF0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int KODFJIDKBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD99670", Offset = "0xD98470", VA = "0x180D99670", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float BIGFHKNOFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xCA82A0", Offset = "0xCA70A0", VA = "0x180CA82A0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MNLNKGDCNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF873E0", Offset = "0xF861E0", VA = "0x180F873E0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1C30", Offset = "0x7FA0A30", VA = "0x187FA1C30")]
	public PFLGJBLMCDA(UniformTRS OAAOKGIMOHH, GALEOJBODPG BOGJJGPKPIJ, float MGKFNAJLFPM, float3 IJKOECMCNMM, FLGDJDIBGKI GKEJGMJMNOD, BDLOEKFKAIO PGLPAGHPDBF, LBIFFCGMBDC CNCKIIIBBGO, float BMCNJIBFIGJ, int PHIOHHPKAEP, NativeArray<CCHLCODHAON> NGODMFFAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x11288A0", Offset = "0x11276A0", VA = "0x1811288A0", Slot = "33")]
	public NativeArray<CCHLCODHAON> GetNativeCurvePoints()
	{
		return default(NativeArray<CCHLCODHAON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1B70", Offset = "0x7FA0970", VA = "0x187FA1B70", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CNFAJJDADLL : GMAKIGJBPFP, EPJPNHNLMPC, GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<AEHNMCPGHOA, JBBAGKFDBNF> FBLODMKCBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private JBBAGKFDBNF MNGJGHJDPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool JFKBJHLNDJG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private JBBAGKFDBNF NAIHMONIAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0", Slot = "28")]
		get
		{
			return default(JBBAGKFDBNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool NLMMHNOHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xE52870", Offset = "0xE51670", VA = "0x180E52870", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 PFEPEINALJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8C2D0", Offset = "0x7F8B0D0", VA = "0x187F8C2D0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C2B0", Offset = "0x7F8B0B0", VA = "0x187F8C2B0")]
	public CNFAJJDADLL(JBBGAMGOICI HMMCMNPLNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BC20", Offset = "0x7F8AA20", VA = "0x187F8BC20", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BC70", Offset = "0x7F8AA70", VA = "0x187F8BC70", Slot = "26")]
	public override void JPEBABACHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HMLKPHJMPKG : ADELKEIOLCB, HFMBOPLHMPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject LOFDFMFCMHP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject DIBJMNKHENG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BAC0", Offset = "0x7F9A8C0", VA = "0x187F9BAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GNLCMFNGHKL MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F9BE60", Offset = "0x7F9AC60", VA = "0x187F9BE60", Slot = "15")]
		get
		{
			return default(GNLCMFNGHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MFLNAOCPGAE JCHFAJHFICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F9C0B0", Offset = "0x7F9AEB0", VA = "0x187F9C0B0", Slot = "16")]
		get
		{
			return default(MFLNAOCPGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BF60", Offset = "0x7F9AD60", VA = "0x187F9BF60")]
	public HMLKPHJMPKG(JBBGAMGOICI CBBNAACPEGP, bool EOJAEDHOJOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BCD0", Offset = "0x7F9AAD0", VA = "0x187F9BCD0")]
	public void FHPEGMLKICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BE60", Offset = "0x7F9AC60", VA = "0x187F9BE60")]
	protected GNLCMFNGHKL JPNBFBPMBOO()
	{
		return default(GNLCMFNGHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BB50", Offset = "0x7F9A950", VA = "0x187F9BB50")]
	private static bool CGMDMDIFKOL(JBBGAMGOICI CPEKFLDAEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BCA0", Offset = "0x7F9AAA0", VA = "0x187F9BCA0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CIGLFFHJAFA : GMAKIGJBPFP, FLPJCOCICAD, GJFJJPHBPAF, IDisposable, IEAOPNPEIDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<CCHLCODHAON> NGODMFFAOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool IPFACGEDNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LBNCONNBLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float BMCNJIBFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int PHIOHHPKAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool ILNFFGCHNJP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool IPKMODAAPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC3A4C0", Offset = "0xC392C0", VA = "0x180C3A4C0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KEMJNOGEEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA55A50", Offset = "0xA54850", VA = "0x180A55A50", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float AMNJLPPBFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x10B8AF0", Offset = "0x10B78F0", VA = "0x1810B8AF0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int MNGBMFPCKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xD5AFA0", Offset = "0xD59DA0", VA = "0x180D5AFA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DFKDNABILID
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC2CF80", Offset = "0xC2BD80", VA = "0x180C2CF80", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int MFCOBECMGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B4E0", Offset = "0x7F8A2E0", VA = "0x187F8B4E0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int MBNKBEFOEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F8BAA0", Offset = "0x7F8A8A0", VA = "0x187F8BAA0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BBF0", Offset = "0x7F8A9F0", VA = "0x187F8BBF0")]
	public CIGLFFHJAFA(JBBGAMGOICI HMMCMNPLNJA, [Optional] NativeList<CCHLCODHAON> NGODMFFAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B870", Offset = "0x7F8A670", VA = "0x187F8B870", Slot = "26")]
	public override void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B390", Offset = "0x7F8A190", VA = "0x187F8B390", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B480", Offset = "0x7F8A280", VA = "0x187F8B480", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F8BB90", Offset = "0x7F8A990", VA = "0x187F8BB90")]
	public void NKPEDEOMFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B500", Offset = "0x7F8A300", VA = "0x187F8B500", Slot = "34")]
	public NativeArray<CCHLCODHAON> GetNativeCurvePoints()
	{
		return default(NativeArray<CCHLCODHAON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B950", Offset = "0x7F8A750", VA = "0x187F8B950", Slot = "35")]
	private Vector3 KBFMFMFPKKO(int KILCKNBNPEG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B360", Offset = "0x7F8A160", VA = "0x187F8B360", Slot = "36")]
	private Quaternion CCHAIGKGNHK(int KILCKNBNPEG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B6D0", Offset = "0x7F8A4D0", VA = "0x187F8B6D0", Slot = "37")]
	private float HJPMBAHDKFB(int KILCKNBNPEG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B2F0", Offset = "0x7F8A0F0", VA = "0x187F8B2F0")]
	private NativeArray<Entity> AIHNPAGGAKN()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class DCBODKHHJDJ : HEDHMPJOLCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C810", Offset = "0x7F8B610", VA = "0x187F8C810", Slot = "15")]
	protected override ComponentSystemBase KJLIEAKCKCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CC20", Offset = "0x7F8BA20", VA = "0x187F8CC20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CC30", Offset = "0x7F8BA30", VA = "0x187F8CC30")]
	public DCBODKHHJDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DIOPPOOGLEP]
public sealed class GEBANPFJHMK : GDBJGGCIAGE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery ICKMHMCOFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery OEAIKNBDKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery EBOJGHBEEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery NAHIJNPPFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery HNIOCAFBGIF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FAC0", Offset = "0x7F8E8C0", VA = "0x187F8FAC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FE20", Offset = "0x7F8EC20", VA = "0x187F8FE20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FE60", Offset = "0x7F8EC60", VA = "0x187F8FE60")]
	private void PKAKHGKMOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F7B0", Offset = "0x7F8E5B0", VA = "0x187F8F7B0")]
	private void DOKAPIGCHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F5E0", Offset = "0x7F8E3E0", VA = "0x187F8F5E0")]
	private void BHOLHNPJLCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F970", Offset = "0x7F8E770", VA = "0x187F8F970")]
	private void LACLDGOJLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F90040", Offset = "0x7F8EE40", VA = "0x187F90040")]
	private void POANMIIDAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F920", Offset = "0x7F8E720", VA = "0x187F8F920")]
	private NativeList<Entity> KBNCICKNDMC(NativeArray<Entity> KKDBICIHPCE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FA70", Offset = "0x7F8E870", VA = "0x187F8FA70")]
	private NativeList<Entity> MAMLGJCKAKL(NativeArray<Entity> KKDBICIHPCE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F8C0", Offset = "0x7F8E6C0", VA = "0x187F8F8C0")]
	private void HOBOLFLHFCM(NativeArray<Entity> KKDBICIHPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public GEBANPFJHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DIOPPOOGLEP]
public sealed class FOEGFBDEHLD : GDBJGGCIAGE, GACJOGFPDAE
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery KCELONCBCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery EEIKLEBHOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery OEDIKHHJGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private JODNHFAOMAE CBHEEHHGBEA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F8EF10", Offset = "0x7F8DD10", VA = "0x187F8EF10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E5D0", Offset = "0x7F8D3D0", VA = "0x187F8E5D0", Slot = "15")]
	public override void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F0E0", Offset = "0x7F8DEE0", VA = "0x187F8F0E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DC10", Offset = "0x7F8CA10", VA = "0x187F8DC10")]
	private void EFJJHNLMKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E7E0", Offset = "0x7F8D5E0", VA = "0x187F8E7E0")]
	private void KLKGGNNBFJJ(NativeParallelHashSet<BLHOJKOBONC> KHADJBHGNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DF40", Offset = "0x7F8CD40", VA = "0x187F8DF40")]
	private void FMOHNDIKDFK(NativeParallelHashSet<BLHOJKOBONC> KHADJBHGNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D850", Offset = "0x7F8C650", VA = "0x187F8D850")]
	private void DOLCPONIJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F8EE70", Offset = "0x7F8DC70", VA = "0x187F8EE70")]
	private bool OGFPIOGHBIP(Entity OFJKELIPJNP, [Out] BLHOJKOBONC FPEGLGDOFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E630", Offset = "0x7F8D430", VA = "0x187F8E630")]
	private bool KLIJGOOEBOM(Entity OFJKELIPJNP, [Out] BLHOJKOBONC FPEGLGDOFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public FOEGFBDEHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DIOPPOOGLEP]
public sealed class LKACKDJKNLN : GDBJGGCIAGE
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery LKCFONALCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery LDEAIJMAGFB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F090", Offset = "0x7F9DE90", VA = "0x187F9F090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F1E0", Offset = "0x7F9DFE0", VA = "0x187F9F1E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F9ED90", Offset = "0x7F9DB90", VA = "0x187F9ED90")]
	private void KLKGGNNBFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EAA0", Offset = "0x7F9D8A0", VA = "0x187F9EAA0")]
	private void FMOHNDIKDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public LKACKDJKNLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BGKIEHGEABB : GDBJGGCIAGE, GACJOGFPDAE
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct MLOKGDKHMOJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob KNAHALHBMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob MFFELLKLHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob NFOEBBPFLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob FGPLGGBNNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle DEJBFGEHNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<LJOEOBHEOFO> OMBOALGCDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<BLHOJKOBONC> EELBJLCNPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> MKCBAPJMLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> KJOCDPMGJKP;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0740", Offset = "0x7F9F540", VA = "0x187FA0740", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0660", Offset = "0x7F9F460", VA = "0x187FA0660")]
		private void DBJDNOJJMBA(EntityQueryInJob LPMNLGHDNKG, NativeList<Entity> PFHLHPMOKHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct GLGNCGNBNLH : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle DEJBFGEHNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<LJOEOBHEOFO> OMBOALGCDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<BLHOJKOBONC> EELBJLCNPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> PFHLHPMOKHJ;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F91FA0", Offset = "0x7F90DA0", VA = "0x187F91FA0", Slot = "4")]
		public void Execute(ArchetypeChunk IALBAMFCNMF, int LGHNKMCENEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct CNNBDFNFCGH : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle DEJBFGEHNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> FOEBEIKGOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<EKDLHNAIJLH> ILCFLLBBGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<MINENEEIPBC> IKEPLAEANLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<LJOEOBHEOFO> EGOGBLOACFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<BLHOJKOBONC> EELBJLCNPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> DGJINPKMPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<EKDLHNAIJLH> EDHABLAMOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<BLHOJKOBONC> IAAPNOHMJAL;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F8C3A0", Offset = "0x7F8B1A0", VA = "0x187F8C3A0", Slot = "4")]
		public void Execute(ArchetypeChunk IALBAMFCNMF, int LGHNKMCENEL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery KNAHALHBMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery MFFELLKLHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery NFOEBBPFLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery FGPLGGBNNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery MLMJEMGNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery LMODNNLDKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery NNODDKDPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private JODNHFAOMAE AIBJCJBHFHC;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F88CE0", Offset = "0x7F87AE0", VA = "0x187F88CE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F883F0", Offset = "0x7F871F0", VA = "0x187F883F0", Slot = "15")]
	public override void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F89260", Offset = "0x7F88060", VA = "0x187F89260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F87DF0", Offset = "0x7F86BF0", VA = "0x187F87DF0")]
	private void IMFIOEDJOCE(NativeParallelHashSet<BLHOJKOBONC> EELBJLCNPKK, int ICMBJPIPLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F88890", Offset = "0x7F87690", VA = "0x187F88890")]
	private void NJDBAMMLDBP(NativeParallelHashSet<BLHOJKOBONC> EELBJLCNPKK, int CFNNIPGJPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F88450", Offset = "0x7F87250", VA = "0x187F88450")]
	private void NDMOMGDFOPD(NativeParallelHashSet<BLHOJKOBONC> EELBJLCNPKK, int IOCOHAOKONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F87A60", Offset = "0x7F86860", VA = "0x187F87A60")]
	private void HLDIMLPDIBP(NativeParallelHashSet<BLHOJKOBONC> KHADJBHGNKA, int BDPAHLJEMKP, int EDCLIFLGDPL, int NPMDFNEMDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F878B0", Offset = "0x7F866B0", VA = "0x187F878B0")]
	private void CBHACNDKIGE(Entity PDHBELGOPHG, FANFIOCPJIG EKAJJIBFKFA, BLHOJKOBONC FPEGLGDOFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public BGKIEHGEABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class JPONPLKEHCL : GDBJGGCIAGE
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery KAGEILGNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery EMGBHIBEDGH;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E270", Offset = "0x7F9D070", VA = "0x187F9E270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E4A0", Offset = "0x7F9D2A0", VA = "0x187F9E4A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public JPONPLKEHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OFCHCPJBPFD : GDBJGGCIAGE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct CJOBFGGMICG : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery CFNKJOEJAEJ;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1140", Offset = "0x7F9FF40", VA = "0x187FA1140", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1280", Offset = "0x7FA0080", VA = "0x187FA1280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public OFCHCPJBPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DIOPPOOGLEP]
internal class LLFAKNCECAH : GDBJGGCIAGE
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class OELMOHDJFPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery PFCPCAFFDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery FCLGKKKDANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LNMKNNMCLKB DJPGJEHIIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType AHFIEDGPHPP;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OELMOHDJFPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void LNMKNNMCLKB(NativeArray<FANFIOCPJIG> BHHPJCAPOMD, GDJLPLLNOFP CJGOHNIPOAJ);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<OELMOHDJFPH> DNKJMFNAGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private BAFJGOHFPIO AGDCFJLPIHH;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F430", Offset = "0x7F9E230", VA = "0x187F9F430", Slot = "15")]
	public override void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F7D0", Offset = "0x7F9E5D0", VA = "0x187F9F7D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F960", Offset = "0x7F9E760", VA = "0x187F9F960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x39F1CE0", Offset = "0x39F0AE0", VA = "0x1839F1CE0")]
	private void LCDGDLPCNND<T>(LNMKNNMCLKB DJPGJEHIIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F290", Offset = "0x7F9E090", VA = "0x187F9F290")]
	private static void FBBLFFJIGJB(NativeArray<FANFIOCPJIG> FPNAGIBIHJN, GDJLPLLNOFP BJGGDNOAMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F490", Offset = "0x7F9E290", VA = "0x187F9F490")]
	private static void JJDEGGNDILL(NativeArray<FANFIOCPJIG> FPNAGIBIHJN, GDJLPLLNOFP BJGGDNOAMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F630", Offset = "0x7F9E430", VA = "0x187F9F630")]
	private static void LGMDJDHIBMG(NativeArray<FANFIOCPJIG> FPNAGIBIHJN, GDJLPLLNOFP BJGGDNOAMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public LLFAKNCECAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DIOPPOOGLEP]
public sealed class GANCELGIPOM : GDBJGGCIAGE
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery LPMNLGHDNKG;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F190", Offset = "0x7F8DF90", VA = "0x187F8F190", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OBLMMEJIGNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS OAAOKGIMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData PNKDKEFCPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public JBBAGKFDBNF MNGJGHJDPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 BAAINAAOMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool JFKBJHLNDJG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[OGIPMCIBBIG(Lifetime.LoadInstance)]
public struct NMOHLBGFECE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity EEMDMFPCGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> GEGMKOHLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> BKCBLIOOFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<OBLMMEJIGNP> OPFADJDBLEP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0D80", Offset = "0x7F9FB80", VA = "0x187FA0D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(CHJNBBCEPHC), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class CHJNBBCEPHC : GACJOGFPDAE, IMNKKHLGPLB, AHDIFPEGPEL, FAGFKOAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NGOFIOCNPHP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly CHJNBBCEPHC BOGJJGPKPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool LHAEBGIBNPJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1803FC0", Offset = "0x1802DC0", VA = "0x181803FC0")]
		public NGOFIOCNPHP(CHJNBBCEPHC BOGJJGPKPIJ, bool LHAEBGIBNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0CC0", Offset = "0x7F9FAC0", VA = "0x187FA0CC0")]
		public Queue<MNMEFDKNIPD>.Enumerator PHEMDOOJNPF()
		{
			return default(Queue<MNMEFDKNIPD>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0980", Offset = "0x7F9F780", VA = "0x187FA0980", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private FNPHLLFAMCL CGBFOHCHDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private GMINMCACEMG PNEOEMPMPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<CCHLCODHAON>> CGPDPGEGOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> FOANCMFEOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<FANFIOCPJIG> LCMJINHNMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private JMLGPCELCAI<MNMEFDKNIPD> JIDLAKOADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private JMLGPCELCAI<NMOHLBGFECE> GEGOEKLNMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JMLGPCELCAI<MFNCOADAFPF> OMDNDKEHECD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AD50", Offset = "0x7F89B50", VA = "0x187F8AD50", Slot = "4")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AC80", Offset = "0x7F89A80", VA = "0x187F8AC80")]
	public void GIMCDPFKOEJ(NativeList<CCHLCODHAON> BKMMPHCNDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A5E0", Offset = "0x7F893E0", VA = "0x187F8A5E0")]
	public void DILBKBNPJLE(Entity BOGJJGPKPIJ, [In] HIMKNIEIOHE<GameObject> AAIJGCNAKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A740", Offset = "0x7F89540", VA = "0x187F8A740")]
	public void DNIHKGINFJP(NativeList<FANFIOCPJIG> FPNAGIBIHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A2D0", Offset = "0x7F890D0", VA = "0x187F8A2D0")]
	public void CHDOCNCFICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A7D0", Offset = "0x7F895D0", VA = "0x187F8A7D0")]
	public void FDMBGLMEEEA(NBGHGFAEDDJ HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B100", Offset = "0x7F89F00", VA = "0x187F8B100")]
	public JobHandle NEBLEJCEOIJ([In] MNMEFDKNIPD NJJDPBHNDPA, JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B060", Offset = "0x7F89E60", VA = "0x187F8B060")]
	public JobHandle NEBLEJCEOIJ([In] NMOHLBGFECE NJJDPBHNDPA, JobHandle BMHAFJILJPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C327A0", Offset = "0x7C315A0", VA = "0x187C327A0")]
	public NGOFIOCNPHP OIAGEEFFOAC(bool LHAEBGIBNPJ)
	{
		return default(NGOFIOCNPHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B010", Offset = "0x7F89E10", VA = "0x187F8B010")]
	public BEKFPJLNOIH<NMOHLBGFECE> MPLMKIFCJCN()
	{
		return default(BEKFPJLNOIH<NMOHLBGFECE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AFC0", Offset = "0x7F89DC0", VA = "0x187F8AFC0")]
	public BEKFPJLNOIH<MFNCOADAFPF> LKAIPHMAEKO()
	{
		return default(BEKFPJLNOIH<MFNCOADAFPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A0B0", Offset = "0x7F88EB0", VA = "0x187F8A0B0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A500", Offset = "0x7F89300", VA = "0x187F8A500", Slot = "5")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AF50", Offset = "0x7F89D50", VA = "0x187F8AF50", Slot = "6")]
	private void KHEDDOBEPFG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x11E2B80", Offset = "0x11E1980", VA = "0x1811E2B80", Slot = "7")]
	private void JLHNKKDCLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CHJNBBCEPHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct APPPLLCANIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS OAAOKGIMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData PNKDKEFCPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public DDONCCKEKIL CNCKIIIBBGO;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[OGIPMCIBBIG(Lifetime.LoadInstance)]
public struct MNMEFDKNIPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity EEMDMFPCGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> KKDBICIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> GEGMKOHLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> BKCBLIOOFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<MAINECODIKP> NDMMAKJNDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<CCHLCODHAON> BKMMPHCNDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<APPPLLCANIL> DGJIJDOHDJP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FA08A0", Offset = "0x7F9F6A0", VA = "0x187FA08A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FA08B0", Offset = "0x7F9F6B0", VA = "0x187FA08B0")]
	public void LNJEMOCDJGL(bool LHAEBGIBNPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(EMMPLOCNJED), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class EMMPLOCNJED : GNJGKFCJPFE, AHDIFPEGPEL, FAGFKOAOOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private CHJNBBCEPHC GFCEDBNAIBN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D260", Offset = "0x7F8C060", VA = "0x187F8D260", Slot = "4")]
	public void BFNHDDHMDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D280", Offset = "0x7F8C080", VA = "0x187F8D280", Slot = "5")]
	private void KHEDDOBEPFG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x118AF40", Offset = "0x1189D40", VA = "0x18118AF40", Slot = "6")]
	private void JLHNKKDCLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public EMMPLOCNJED()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : GDBJGGCIAGE, GACJOGFPDAE
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
			public NativeParallelHashMap<int, JBBAGKFDBNF> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<OBLMMEJIGNP> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7F96F50", Offset = "0x7F95D50", VA = "0x187F96F50", Slot = "4")]
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
			public NativeArray<CCHLCODHAON> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<MAINECODIKP> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<APPPLLCANIL> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7F972F0", Offset = "0x7F960F0", VA = "0x187F972F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F8C6D0", Offset = "0x7F8B4D0", VA = "0x187F8C6D0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7FA1D60", Offset = "0x7FA0B60", VA = "0x187FA1D60")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7FA1D10", Offset = "0x7FA0B10", VA = "0x187FA1D10")]
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
				float3 HLAOLPHNNLI(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7F9FF30", Offset = "0x7F9ED30", VA = "0x187F9FF30", Slot = "5")]
				public float3 OLAMLFHBBJG(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7F9FEF0", Offset = "0x7F9ECF0", VA = "0x187F9FEF0", Slot = "4")]
				public float3 HLAOLPHNNLI(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7FA0E10", Offset = "0x7F9FC10", VA = "0x187FA0E10", Slot = "4")]
				public float3 HLAOLPHNNLI(quaternion rotation)
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
			public NativeArray<MAINECODIKP> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<CCHLCODHAON> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7F980D0", Offset = "0x7F96ED0", VA = "0x187F980D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7F99FD0", Offset = "0x7F98DD0", VA = "0x187F99FD0")]
			private void LPPPFHDIHOP(NativeList<PointSrcData> srcData, NativeList<CCHLCODHAON> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B0C0", Offset = "0x7F99EC0", VA = "0x187F9B0C0")]
			public static Vector3 NACHGJPNNNJ(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B680", Offset = "0x7F9A480", VA = "0x187F9B680")]
			public static quaternion OLLELCLIBMF(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7F97A10", Offset = "0x7F96810", VA = "0x187F97A10")]
			private static quaternion AJKNJCMMHPN(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7F97D10", Offset = "0x7F96B10", VA = "0x187F97D10")]
			private static float3 CGNEJIJOGCD(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F9AEB0", Offset = "0x7F99CB0", VA = "0x187F9AEB0")]
			private static quaternion MCBKKOFFGBP(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7F99D60", Offset = "0x7F98B60", VA = "0x187F99D60")]
			private static CCHLCODHAON LNKJAIANEOG(int idx, NativeList<PointSrcData> srcData)
			{
				return default(CCHLCODHAON);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x406FDA0", Offset = "0x406EBA0", VA = "0x18406FDA0")]
			private void FPFCFOFPMBI<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7F986F0", Offset = "0x7F974F0", VA = "0x187F986F0")]
			private void GALGMIECNBH(NativeList<PointSrcData> sourcePoints, NativeList<CCHLCODHAON> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7F9AF40", Offset = "0x7F99D40", VA = "0x187F9AF40")]
			public static float MPFHEGGNGOE(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7F97EE0", Offset = "0x7F96CE0", VA = "0x187F97EE0")]
			private static quaternion DNCBJEFEHMI(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7F99BB0", Offset = "0x7F989B0", VA = "0x187F99BB0")]
			private static CCHLCODHAON JCNCNGHJDOF(PointSrcData point)
			{
				return default(CCHLCODHAON);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7F99CD0", Offset = "0x7F98AD0", VA = "0x187F99CD0")]
			private static CCHLCODHAON JCNCNGHJDOF(float3 pos, quaternion rot, float radius)
			{
				return default(CCHLCODHAON);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7F99B10", Offset = "0x7F98910", VA = "0x187F99B10")]
			private static bool HOFLLCHGOEI(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F97C40", Offset = "0x7F96A40", VA = "0x187F97C40")]
			private static float3 BJMNCOKBBMI(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7F99500", Offset = "0x7F98300", VA = "0x187F99500")]
			public static float3 GJMJFFCLIGB(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B4D0", Offset = "0x7F9A2D0", VA = "0x187F9B4D0")]
			public static float3 OLAMLFHBBJG(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7F996B0", Offset = "0x7F984B0", VA = "0x187F996B0")]
			private static quaternion GPGIEPEJJGH(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7F9B700", Offset = "0x7F9A500", VA = "0x187F9B700")]
			private static float PHGDKKPBPOH(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7FA3F20", Offset = "0x7FA2D20", VA = "0x187FA3F20")]
			private void DNAIKHKCNMP(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA4000", Offset = "0x7FA2E00", VA = "0x187FA4000", Slot = "4")]
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
			public NativeList<CCHLCODHAON> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA5740", Offset = "0x7FA4540", VA = "0x187FA5740")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA57A0", Offset = "0x7FA45A0", VA = "0x187FA57A0", Slot = "4")]
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
			public NativeList<CCHLCODHAON> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA56E0", Offset = "0x7FA44E0", VA = "0x187FA56E0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA5730", Offset = "0x7FA4530", VA = "0x187FA5730", Slot = "4")]
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
			public NativeList<OBLMMEJIGNP> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7F97630", Offset = "0x7F96430", VA = "0x187F97630")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7F977F0", Offset = "0x7F965F0", VA = "0x187F977F0", Slot = "4")]
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
			public NativeList<MAINECODIKP> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<APPPLLCANIL> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7F97800", Offset = "0x7F96600", VA = "0x187F97800")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7F97A00", Offset = "0x7F96800", VA = "0x187F97A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA52B0", Offset = "0x7FA40B0", VA = "0x187FA52B0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7FA56D0", Offset = "0x7FA44D0", VA = "0x187FA56D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly IEBEPMGFCGH log;

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
		private CBOPJEJFGFL replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private FNPHLLFAMCL objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private CHJNBBCEPHC bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private MAGAPILIALN ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3830", Offset = "0x7FA2630", VA = "0x187FA3830", Slot = "15")]
		public override void InitReferences(LFBEMDOHFPC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4F60", Offset = "0x7FA3D60", VA = "0x187FA4F60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5050", Offset = "0x7FA3E50", VA = "0x187FA5050", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FA50B0", Offset = "0x7FA3EB0", VA = "0x187FA50B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4200", Offset = "0x7FA3000", VA = "0x187FA4200")]
		private JobHandle OCGCFMDCBOI(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2900", Offset = "0x7FA1700", VA = "0x187FA2900")]
		private JobHandle FJJAJJMOFEF(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2740", Offset = "0x7FA1540", VA = "0x187FA2740")]
		private JobHandle MCDIMGABABF(NativeArray<int> pointCount, NativeList<CCHLCODHAON> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA38D0", Offset = "0x7FA26D0", VA = "0x187FA38D0")]
		private JobHandle JEMKNALHHPO(NativeList<CCHLCODHAON> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3970", Offset = "0x7FA2770", VA = "0x187FA3970")]
		private JobHandle JHEIGLPLHNJ(EntityQuery query, NativeList<MAINECODIKP> splinePointRanges, NativeList<CCHLCODHAON> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FA34D0", Offset = "0x7FA22D0", VA = "0x187FA34D0")]
		private JobHandle HGKAAGHAJFE(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FA27E0", Offset = "0x7FA15E0", VA = "0x187FA27E0")]
		private JobHandle FHLILBCNHAO(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2100", Offset = "0x7FA0F00", VA = "0x187FA2100")]
		private JobHandle AMICLBLIOJE(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<OBLMMEJIGNP> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4540", Offset = "0x7FA3340", VA = "0x187FA4540")]
		private JobHandle OLJNKKPDMOG(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<MAINECODIKP> splinePointRanges, [Out] NativeList<APPPLLCANIL> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1D80", Offset = "0x7FA0B80", VA = "0x187FA1D80")]
		private JobHandle AKEFKIHFIAJ(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2FC0", Offset = "0x7FA1DC0", VA = "0x187FA2FC0")]
		private JobHandle FKFOKPLMHLC(EntityQuery query, NativeList<OBLMMEJIGNP> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4800", Offset = "0x7FA3600", VA = "0x187FA4800")]
		private static NativeParallelHashMap<int, JBBAGKFDBNF> OLKDNDIOGJL()
		{
			return default(NativeParallelHashMap<int, JBBAGKFDBNF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7FA23A0", Offset = "0x7FA11A0", VA = "0x187FA23A0")]
		private JobHandle BCJEMEDHCKG(EntityQuery query, NativeList<MAINECODIKP> splinePointRanges, NativeList<CCHLCODHAON> splinePointData, NativeList<APPPLLCANIL> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3E40", Offset = "0x7FA2C40", VA = "0x187FA3E40")]
		private JobHandle JJNEOCIJEMG(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2740", Offset = "0x7FA1540", VA = "0x187FA2740")]
		private JobHandle EPFBDHJCDNO(NativeArray<int> pointCount, NativeList<CCHLCODHAON> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7FA38D0", Offset = "0x7FA26D0", VA = "0x187FA38D0")]
		private JobHandle KADMHKIPLII(NativeList<CCHLCODHAON> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3740", Offset = "0x7FA2540", VA = "0x187FA3740")]
		private JobHandle IPJEOMHBGIK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<OBLMMEJIGNP> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7FA40F0", Offset = "0x7FA2EF0", VA = "0x187FA40F0")]
		private JobHandle NGNGPFDDFIP(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<MAINECODIKP> ranges, NativeList<APPPLLCANIL> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7FA35F0", Offset = "0x7FA23F0", VA = "0x187FA35F0")]
		private JobHandle HIBHDGLOBJI(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4C20", Offset = "0x7FA3A20", VA = "0x187FA4C20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class LBAFJGMPPOJ : PKLCKAMFOHP, GACJOGFPDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private CHJNBBCEPHC GFCEDBNAIBN;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EA30", Offset = "0x7F9D830", VA = "0x187F9EA30", Slot = "14")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EA80", Offset = "0x7F9D880", VA = "0x187F9EA80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
	public LBAFJGMPPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class GOILLGPODNL : GDBJGGCIAGE, GACJOGFPDAE
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct FIBBBCACHEH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager CCPBGAMLKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private FKEMJNOOPNO<T> HKJIFBOMMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int GLAOLHCPLLG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4ACE1C0", Offset = "0x4ACCFC0", VA = "0x184ACE1C0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4ACE800", Offset = "0x4ACD600", VA = "0x184ACE800")]
		public FIBBBCACHEH(EntityManager CCPBGAMLKKA, FKEMJNOOPNO<T> HKJIFBOMMOL, NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x46ADFA0", Offset = "0x46ACDA0", VA = "0x1846ADFA0")]
		public FIBBBCACHEH<T> PHEMDOOJNPF()
		{
			return default(FIBBBCACHEH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4ACE7A0", Offset = "0x4ACD5A0", VA = "0x184ACE7A0")]
		public bool JONKILIIGKI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IEBEPMGFCGH OEKENBMGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private GMINMCACEMG PNEOEMPMPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private CHJNBBCEPHC GFCEDBNAIBN;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7F93060", Offset = "0x7F91E60", VA = "0x187F93060", Slot = "15")]
	public override void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F93A10", Offset = "0x7F92810", VA = "0x187F93A10")]
	public void KPPBBBENNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F94850", Offset = "0x7F93650", VA = "0x187F94850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F959D0", Offset = "0x7F947D0", VA = "0x187F959D0")]
	private void PAFPKDPLBFF(MFNCOADAFPF NJJDPBHNDPA, Mesh[] LPILIBFAFBD, NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3912F90", Offset = "0x3911D90", VA = "0x183912F90")]
	private FIBBBCACHEH<T> KHNGLPMPLNI<T>(FKEMJNOOPNO<T> HKJIFBOMMOL, NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM) where T : struct
	{
		return default(FIBBBCACHEH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F96AF0", Offset = "0x7F958F0", VA = "0x187F96AF0")]
	private void PDMNJAIDDIN(Transform BOGJJGPKPIJ, NativeArray<DIABBLALIAD> LDHMNHGOPMD, HIMKNIEIOHE<GameObject> GKGINNAJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F93A40", Offset = "0x7F92840", VA = "0x187F93A40")]
	private void LECCBMGPCJD(Transform BOGJJGPKPIJ, NativeArray<FECGKGAPPIH> DMKMPMPNKBL, HIMKNIEIOHE<GameObject> GKGINNAJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7F93620", Offset = "0x7F92420", VA = "0x187F93620")]
	private void KMLGEJDKLMC(Transform BOGJJGPKPIJ, NativeArray<EOJDACGGNGF> JKICNOOPDKC, HIMKNIEIOHE<GameObject> GKGINNAJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7F930E0", Offset = "0x7F91EE0", VA = "0x187F930E0")]
	private void JDJELOFLDCD(Transform BOGJJGPKPIJ, NativeArray<JMLHOLHNPGI> LPILIBFAFBD, Mesh[] EOPJDAFJFGB, HIMKNIEIOHE<GameObject> GKGINNAJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7F922E0", Offset = "0x7F910E0", VA = "0x187F922E0")]
	private static void DDMOGIENBFM(NativeParallelHashSet<Entity> KKDBICIHPCE, NativeParallelHashSet<Entity> KPLJFLFNLLA, NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7F92430", Offset = "0x7F91230", VA = "0x187F92430")]
	private static void EBPOHIODOAJ(NativeList<Entity> COKPAJOONAO, NativeArray<EntityRemapUtility.EntityRemapInfo> CCBAJOGADLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7F924F0", Offset = "0x7F912F0", VA = "0x187F924F0")]
	private NativeParallelHashMap<Entity, MINENEEIPBC> GLGCKFFELLG(CHJNBBCEPHC.NGOFIOCNPHP OFEDPGKCNEK, BEKFPJLNOIH<NMOHLBGFECE> FOFICHPFBPD, List<GameObject> GKGINNAJOOH)
	{
		return default(NativeParallelHashMap<Entity, MINENEEIPBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7F93520", Offset = "0x7F92320", VA = "0x187F93520")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> JOKBOOKLPGB(Entity MDLJJEJELDK)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7F93F10", Offset = "0x7F92D10", VA = "0x187F93F10")]
	private void NLLLMDFCMJK(NativeList<Entity> POPOBAIHMAE, NativeList<Entity> HPOCOLHFMAM, NativeParallelHashMap<Entity, MINENEEIPBC> MPJBMPFCKGB, NativeList<MAINECODIKP> ELNKPEOIAGM, NativeList<CCHLCODHAON> FAIEMMHCJEH, NativeList<APPPLLCANIL> CGPDPGEGOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7F94460", Offset = "0x7F93260", VA = "0x187F94460")]
	private void NMJMFHINOAN(NativeList<Entity> KKDBICIHPCE, NativeList<Entity> GEGMKOHLNDI, NativeParallelHashMap<Entity, MINENEEIPBC> MPJBMPFCKGB, NativeList<OBLMMEJIGNP> OPFADJDBLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2AF0", Offset = "0x2AB18F0", VA = "0x182AB2AF0")]
	public GOILLGPODNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class AMDGEGAOBPM : EOEFBNMFPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS OAAOKGIMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly GALEOJBODPG BOGJJGPKPIJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject LKDIEELMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS GJGIGHHPPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F87640", Offset = "0x7F86440", VA = "0x187F87640", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 NENBLMGCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7F87720", Offset = "0x7F86520", VA = "0x187F87720", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 HOOJHPCDPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F875A0", Offset = "0x7F863A0", VA = "0x187F875A0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 EICBCPGMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7F87500", Offset = "0x7F86300", VA = "0x187F87500", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7F87550", Offset = "0x7F86350", VA = "0x187F87550", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion JHMFIOLFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7F87810", Offset = "0x7F86610", VA = "0x187F87810", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7F87770", Offset = "0x7F86570", VA = "0x187F87770", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 HCDFJODJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7F877C0", Offset = "0x7F865C0", VA = "0x187F877C0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 GLAGCOBFLAI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7F875F0", Offset = "0x7F863F0", VA = "0x187F875F0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 LDIFLKEFDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7F874B0", Offset = "0x7F862B0", VA = "0x187F874B0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F87860", Offset = "0x7F86660", VA = "0x187F87860")]
	public AMDGEGAOBPM(UniformTRS OAAOKGIMOHH, GALEOJBODPG BOGJJGPKPIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class JHHMFIIPJOJ : AMDGEGAOBPM, GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float MGKFNAJLFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 IJKOECMCNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly FLGDJDIBGKI GKEJGMJMNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly BDLOEKFKAIO PGLPAGHPDBF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private GNLCMFNGHKL AGINPFNGCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E0C0", Offset = "0x7F9CEC0", VA = "0x187F9E0C0", Slot = "17")]
		get
		{
			return default(GNLCMFNGHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS CALFAGJMMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E110", Offset = "0x7F9CF10", VA = "0x187F9E110", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float FKBNJDAKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC27EC0", Offset = "0xC26CC0", VA = "0x180C27EC0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 IGGJDMGDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E070", Offset = "0x7F9CE70", VA = "0x187F9E070", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private FLGDJDIBGKI PBJNEHHIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE8BBB0", Offset = "0xE8A9B0", VA = "0x180E8BBB0", Slot = "21")]
		get
		{
			return default(FLGDJDIBGKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private BDLOEKFKAIO MNHNGELGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x13AF010", Offset = "0x13ADE10", VA = "0x1813AF010", Slot = "22")]
		get
		{
			return default(BDLOEKFKAIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool AMBGNNENKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PFHEOOCJDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E1F0", Offset = "0x7F9CFF0", VA = "0x187F9E1F0")]
	protected JHHMFIIPJOJ(UniformTRS OAAOKGIMOHH, GALEOJBODPG BOGJJGPKPIJ, float MGKFNAJLFPM, float3 IJKOECMCNMM, FLGDJDIBGKI GKEJGMJMNOD, BDLOEKFKAIO PGLPAGHPDBF)
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
public abstract class ADELKEIOLCB : EOEFBNMFPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly JBBGAMGOICI NIFNCNHCJID;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected GALEOJBODPG EKMIHGEOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x11BA6A0", Offset = "0x11B94A0", VA = "0x1811BA6A0")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity LMKJAAFDABE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7F86E60", Offset = "0x7F85C60", VA = "0x187F86E60")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected FNPHLLFAMCL ALKLOCLCPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F86E50", Offset = "0x7F85C50", VA = "0x187F86E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected JHHFKKLJKBJ KBGAALBLMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7F86A20", Offset = "0x7F85820", VA = "0x187F86A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected HCALMMNKPKA DFOIIHCIFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7F86990", Offset = "0x7F85790", VA = "0x187F86990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject LKDIEELMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F86E80", Offset = "0x7F85C80", VA = "0x187F86E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS GJGIGHHPPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x11BE2D0", Offset = "0x11BD0D0", VA = "0x1811BE2D0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 NENBLMGCKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7F870A0", Offset = "0x7F85EA0", VA = "0x187F870A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 HOOJHPCDPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7F86CC0", Offset = "0x7F85AC0", VA = "0x187F86CC0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 EICBCPGMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7F86A80", Offset = "0x7F85880", VA = "0x187F86A80", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7F86BB0", Offset = "0x7F859B0", VA = "0x187F86BB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion JHMFIOLFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7F87390", Offset = "0x7F86190", VA = "0x187F87390", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F87190", Offset = "0x7F85F90", VA = "0x187F87190", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 HCDFJODJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7F872A0", Offset = "0x7F860A0", VA = "0x187F872A0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 GLAGCOBFLAI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F86EE0", Offset = "0x7F85CE0", VA = "0x187F86EE0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 LDIFLKEFDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F867D0", Offset = "0x7F855D0", VA = "0x187F867D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xE05700", Offset = "0xE04500", VA = "0x180E05700")]
	protected ADELKEIOLCB(JBBGAMGOICI HMMCMNPLNJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F86EB0", Offset = "0x7F85CB0", VA = "0x187F86EB0")]
	public static GNLCMFNGHKL HEKJAOMNHLJ(ADELKEIOLCB JIJABGNNHPJ)
	{
		return default(GNLCMFNGHKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class ICGGCGONAPD
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA74D0", Offset = "0x7FA62D0", VA = "0x187FA74D0")]
	public static void ANIDIJGCFML(NativeArray<Entity> KKDBICIHPCE, EntityManager CCPBGAMLKKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CMHDJAKNACH
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6AC0", Offset = "0x7FA58C0", VA = "0x187FA6AC0")]
	public static void OGDOHDBNMGJ(NativeArray<Entity> KKDBICIHPCE, EntityManager CCPBGAMLKKA, NBGHGFAEDDJ FGDGGNCDLNA, FNPHLLFAMCL BNLNGOBLDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7FA64D0", Offset = "0x7FA52D0", VA = "0x187FA64D0")]
	public static void JNFBHKDEFPM(NativeArray<Entity> KKDBICIHPCE, EntityManager CCPBGAMLKKA, NBGHGFAEDDJ FGDGGNCDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6820", Offset = "0x7FA5620", VA = "0x187FA6820")]
	public static NativeList<Entity> MAMLGJCKAKL(NativeArray<Entity> KKDBICIHPCE, EntityManager CCPBGAMLKKA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7FA67E0", Offset = "0x7FA55E0", VA = "0x187FA67E0")]
	public static NativeList<Entity> KBNCICKNDMC(NativeArray<Entity> KKDBICIHPCE, EntityManager CCPBGAMLKKA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6860", Offset = "0x7FA5660", VA = "0x187FA6860")]
	private static NativeList<Entity> MAMLGJCKAKL(NativeArray<Entity> KKDBICIHPCE, EntityManager CCPBGAMLKKA, bool AEEKOMBBJDJ)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class GMAKIGJBPFP : ADELKEIOLCB, GJFJJPHBPAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float MGKFNAJLFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 IJKOECMCNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private FLGDJDIBGKI GKEJGMJMNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private BDLOEKFKAIO PGLPAGHPDBF;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager CHBLGEAMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7160", Offset = "0x7FA5F60", VA = "0x187FA7160")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected KEIHHBEOEPM ODALAFALJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7100", Offset = "0x7FA5F00", VA = "0x187FA7100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData EAKDIDDHGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7380", Offset = "0x7FA6180", VA = "0x187FA7380")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private GNLCMFNGHKL AGINPFNGCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7F86EB0", Offset = "0x7F85CB0", VA = "0x187F86EB0", Slot = "17")]
		get
		{
			return default(GNLCMFNGHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float FKBNJDAKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xF09910", Offset = "0xF08710", VA = "0x180F09910", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 IGGJDMGDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x16485F0", Offset = "0x16473F0", VA = "0x1816485F0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private FLGDJDIBGKI PBJNEHHIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300", Slot = "21")]
		get
		{
			return default(FLGDJDIBGKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BDLOEKFKAIO MNHNGELGMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0", Slot = "22")]
		get
		{
			return default(BDLOEKFKAIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS CALFAGJMMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7470", Offset = "0x7FA6270", VA = "0x187FA7470", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PFHEOOCJDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool AMBGNNENKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7FA74A0", Offset = "0x7FA62A0", VA = "0x187FA74A0")]
	protected GMAKIGJBPFP(JBBGAMGOICI HMMCMNPLNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7FA71F0", Offset = "0x7FA5FF0", VA = "0x187FA71F0", Slot = "26")]
	public virtual void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class GDBJGGCIAGE : PKLCKAMFOHP, GACJOGFPDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected FNPHLLFAMCL BNLNGOBLDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PHMNNCHKCOI NMFFKEACGFO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected NBGHGFAEDDJ BBAOFGPOLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7FA70B0", Offset = "0x7FA5EB0", VA = "0x187FA70B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected GDJLPLLNOFP ICHODNMACGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6F30", Offset = "0x7FA5D30", VA = "0x187FA6F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool AOCCNEMLGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6FF0", Offset = "0x7FA5DF0", VA = "0x187FA6FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6F80", Offset = "0x7FA5D80", VA = "0x187FA6F80", Slot = "15")]
	public virtual void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
	protected GDBJGGCIAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CCDIABGCPOC
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6230", Offset = "0x7FA5030", VA = "0x187FA6230")]
	public static void CBKNLOBIDOL(NativeArray<Entity> POPOBAIHMAE, EntityManager CCPBGAMLKKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1967940750
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7930", Offset = "0x7FA6730", VA = "0x187FA7930")]
	public static void BGDPAPHEPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7BB0", Offset = "0x7FA69B0", VA = "0x187FA7BB0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class CEMFGLBEIEJ : ContainerPropertyBag<CIBCCEMGGIN>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6470", Offset = "0x7FA5270", VA = "0x187FA6470")]
	public CEMFGLBEIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class DOPNICLIAMA : ContainerPropertyBag<JAFJOPPLADG>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6ED0", Offset = "0x7FA5CD0", VA = "0x187FA6ED0")]
	public DOPNICLIAMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class INOALIBCGMC : ContainerPropertyBag<JAGCCAOKGCE>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7710", Offset = "0x7FA6510", VA = "0x187FA7710")]
	public INOALIBCGMC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7770", Offset = "0x7FA6570", VA = "0x187FA7770")]
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
