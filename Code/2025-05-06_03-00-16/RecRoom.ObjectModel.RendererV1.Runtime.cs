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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7C10", Offset = "0x7CE6410", VA = "0x187CE7C10", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2025EF0", Offset = "0x20246F0", VA = "0x182025EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CEE4E0", Offset = "0x7CECCE0", VA = "0x187CEE4E0")]
		private void BEJJPGDKNLF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEA80", Offset = "0x7CED280", VA = "0x187CEEA80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CEEAE0", Offset = "0x7CED2E0", VA = "0x187CEEAE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HMAILIIJOAH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDAB0", Offset = "0x7CDC2B0", VA = "0x187CDDAB0")]
	public static Quaternion PCIEAKMABPK([In] this FGALNGBLIBB PKPGBOOHCAB, [In] Vector3 ELEEIMOLKDP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HCHNHDEJDAI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB4F0", Offset = "0x7CD9CF0", VA = "0x187CDB4F0")]
	public static bool GMHIBDEBGLD(this IEELNOOEJIA MAPHNMEPAOC, MGFGEDENDIF GAKNJCMEOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB7E0", Offset = "0x7CD9FE0", VA = "0x187CDB7E0")]
	public static bool JOCMCHFONNO(this IEELNOOEJIA MAPHNMEPAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB7B0", Offset = "0x7CD9FB0", VA = "0x187CDB7B0")]
	public static bool IMLKOGBABDD(this IEELNOOEJIA MAPHNMEPAOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAEE0", Offset = "0x7CD96E0", VA = "0x187CDAEE0")]
	public static void FCGLIAJICEA(this IEELNOOEJIA MAPHNMEPAOC, Vector3 FFMKLBNKGAI, Quaternion HEEAGBBKIEI, float BCDEDKPOOJB, bool CNOLCMPANDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB530", Offset = "0x7CD9D30", VA = "0x187CDB530")]
	public static void HALJOLBCDLF(this IEELNOOEJIA MAPHNMEPAOC, Vector3 FFMKLBNKGAI, Quaternion HEEAGBBKIEI, float BCDEDKPOOJB, int PDKBLJPIEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB810", Offset = "0x7CDA010", VA = "0x187CDB810")]
	public static void KBPHJECOKBG(this IEELNOOEJIA MAPHNMEPAOC, int PDKBLJPIEAI, Vector3 FFMKLBNKGAI, Quaternion HEEAGBBKIEI, float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAE90", Offset = "0x7CD9690", VA = "0x187CDAE90")]
	public static void BOFOMDAGGAI(this IEELNOOEJIA MAPHNMEPAOC, Vector3 KIAKDDKLOEC, Quaternion PHOPNDKBCIL, float BCDEDKPOOJB, bool CNOLCMPANDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBB10", Offset = "0x7CDA310", VA = "0x187CDBB10")]
	private static void KMEDGLEPKBH(this IEELNOOEJIA MAPHNMEPAOC, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float BCDEDKPOOJB, bool CNOLCMPANDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB340", Offset = "0x7CD9B40", VA = "0x187CDB340")]
	private static void GBNJEJCNHHD(this IEELNOOEJIA MAPHNMEPAOC, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML, float IPNMOCLKCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB930", Offset = "0x7CDA130", VA = "0x187CDB930")]
	private static void KLHLIFOJPOI(this IEELNOOEJIA MAPHNMEPAOC, int FPEOONOJHML, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML, float IPNMOCLKCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCBE0", Offset = "0x7CDB3E0", VA = "0x187CDCBE0")]
	private static bool PKEEPHOFNEC(this IEELNOOEJIA MAPHNMEPAOC, int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC950", Offset = "0x7CDB150", VA = "0x187CDC950")]
	private static void PJIJHGLHHHM(this IEELNOOEJIA MAPHNMEPAOC, int FPEOONOJHML, Vector3 IKAECBBFJHO, Quaternion KOBOFDGKPML, float IPNMOCLKCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC460", Offset = "0x7CDAC60", VA = "0x187CDC460")]
	public static Vector3 LECANOODLJJ(this IEELNOOEJIA MAPHNMEPAOC, int FPEOONOJHML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB010", Offset = "0x7CD9810", VA = "0x187CDB010")]
	public static Quaternion FFGCOGALGGE(this IEELNOOEJIA MAPHNMEPAOC, int FPEOONOJHML)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB120", Offset = "0x7CD9920", VA = "0x187CDB120")]
	public static Vector3 FJIGIHNPPLK(MGFGEDENDIF ENMPGGCMLIP, Vector3 NCGKJMOKFAF, Vector3? BFPEJJHHDBP, Vector3 CHLKIEMAELF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface JDEDAPPLBHP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INMNEOJCDKK(EntityQuery DMCOBMDNKEK, EntityManager MIJJPMGKBJK, HOJAHAKCPLA MHBIGPFAJHC, EIMGAAKBBMF COMGDLJLHIF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface FBFEBJBFNLC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType FIECLFHALAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCAHOBBKIHM(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCLBHLDIKGE(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPPCAPADJCK(OJMGMPCIMIF MGOIJMAMEFL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class PHJEOHPHDFE : JDEDAPPLBHP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA4E0", Offset = "0x7CE8CE0", VA = "0x187CEA4E0", Slot = "4")]
	public void INMNEOJCDKK(EntityQuery DMCOBMDNKEK, EntityManager MIJJPMGKBJK, HOJAHAKCPLA MHBIGPFAJHC, EIMGAAKBBMF COMGDLJLHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PHJEOHPHDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class IEJJGKAEHCH : JDEDAPPLBHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KKHCPEKNJIC NOGCCJNOPLG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
	public IEJJGKAEHCH(KKHCPEKNJIC NOGCCJNOPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDCF0", Offset = "0x7CDC4F0", VA = "0x187CDDCF0", Slot = "4")]
	public void INMNEOJCDKK(EntityQuery DMCOBMDNKEK, EntityManager MIJJPMGKBJK, HOJAHAKCPLA MHBIGPFAJHC, EIMGAAKBBMF COMGDLJLHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class KOGLCEILHEP : JDEDAPPLBHP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CE76F0", Offset = "0x7CE5EF0", VA = "0x187CE76F0", Slot = "4")]
	public void INMNEOJCDKK(EntityQuery DMCOBMDNKEK, EntityManager MIJJPMGKBJK, HOJAHAKCPLA MHBIGPFAJHC, EIMGAAKBBMF COMGDLJLHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KOGLCEILHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JOEGFJAOPPD : FBFEBJBFNLC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType FIECLFHALAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4B70", Offset = "0x7CE3370", VA = "0x187CE4B70", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4620", Offset = "0x7CE2E20", VA = "0x187CE4620", Slot = "5")]
	public void GCAHOBBKIHM(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CE48F0", Offset = "0x7CE30F0", VA = "0x187CE48F0", Slot = "6")]
	public void NCLBHLDIKGE(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CE48A0", Offset = "0x7CE30A0", VA = "0x187CE48A0", Slot = "7")]
	public void GPPCAPADJCK(OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JOEGFJAOPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HCICCJFLAHJ : FBFEBJBFNLC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType FIECLFHALAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD160", Offset = "0x7CDB960", VA = "0x187CDD160", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCC10", Offset = "0x7CDB410", VA = "0x187CDCC10", Slot = "5")]
	public void GCAHOBBKIHM(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCEE0", Offset = "0x7CDB6E0", VA = "0x187CDCEE0", Slot = "6")]
	public void NCLBHLDIKGE(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCE90", Offset = "0x7CDB690", VA = "0x187CDCE90", Slot = "7")]
	public void GPPCAPADJCK(OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HCICCJFLAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BMMMCOFNELM : FBFEBJBFNLC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType FIECLFHALAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0F10", Offset = "0x7CCF710", VA = "0x187CD0F10", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CD09C0", Offset = "0x7CCF1C0", VA = "0x187CD09C0", Slot = "5")]
	public void GCAHOBBKIHM(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0C90", Offset = "0x7CCF490", VA = "0x187CD0C90", Slot = "6")]
	public void NCLBHLDIKGE(EntityQuery DMCOBMDNKEK, OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0C40", Offset = "0x7CCF440", VA = "0x187CD0C40", Slot = "7")]
	public void GPPCAPADJCK(OJMGMPCIMIF MGOIJMAMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BMMMCOFNELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class PBIGBDMJEOI : KNGBAOCKOIB, JOGFKELELCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HOJAHAKCPLA MHBIGPFAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MPMGNAFDKAM PJIFJNKDMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private EIMGAAKBBMF COMGDLJLHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, JDEDAPPLBHP adapter)> FBCGHPONNOF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9FC0", Offset = "0x7CE87C0", VA = "0x187CE9FC0", Slot = "15")]
	public virtual void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA050", Offset = "0x7CE8850", VA = "0x187CEA050", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9E50", Offset = "0x7CE8650", VA = "0x187CE9E50")]
	private void ENHJJBDBEBH(EntityQueryDesc EJOBCDODHHF, JDEDAPPLBHP DKKIAKBAHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA280", Offset = "0x7CE8A80", VA = "0x187CEA280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
	public PBIGBDMJEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class KBINKDOFAFI : KNGBAOCKOIB, JOGFKELELCN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NBFNAJABDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery AHJDJIABKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery POCAHHPBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery OONDKCEMEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery IDKNJEOMPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery EOPPMLONGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery MCKHNJDCPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery GHMMCAIIBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FBFEBJBFNLC EMCKGOEEDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType OGNBMDMMJKM;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NBFNAJABDMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HOJAHAKCPLA MHBIGPFAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EIMGAAKBBMF COMGDLJLHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MPMGNAFDKAM PJIFJNKDMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<NBFNAJABDMF> FBCGHPONNOF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE57A0", Offset = "0x7CE3FA0", VA = "0x187CE57A0", Slot = "14")]
	public void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5830", Offset = "0x7CE4030", VA = "0x187CE5830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE59B0", Offset = "0x7CE41B0", VA = "0x187CE59B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4C10", Offset = "0x7CE3410", VA = "0x187CE4C10")]
	private void ELEOJHABBMI(NBFNAJABDMF ELPPHJCDNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5060", Offset = "0x7CE3860", VA = "0x187CE5060")]
	private void ENHJJBDBEBH(FBFEBJBFNLC EMCKGOEEDIO, ComponentType BMEEANCGBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
	public KBINKDOFAFI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct JKIMCEONLDI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct DJICEKHBAKH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct LLEHBBPEDEF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(EIMGAAKBBMF), new string[] { })]
public class FLJCLDHLFEF : EIMGAAKBBMF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HFLHFCIMFNP AHPKFLMKIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HFLHFCIMFNP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FLJCLDHLFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(DEEEKFNCCJH), new string[] { })]
public class EMFGPOGGLLM : DEEEKFNCCJH, PICHPJOKMDH, KKFFKJEIEOE, CDBAFKLBPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private FHKJIGHACNJ GOCNACMHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private HOJAHAKCPLA MHBIGPFAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private EFICJEHFEEE KIJJLOBIFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity BPHMOAFBPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NKPCNGHCBDP DIOCOKKMGJK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3D10", Offset = "0x7CD2510", VA = "0x187CD3D10", Slot = "4")]
	public bool JINODKBAGLA(FGFPKLDJIEL DGLFHMAFDAJ, MCGLDLPOEGP OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3DF0", Offset = "0x7CD25F0", VA = "0x187CD3DF0", Slot = "5")]
	public NKPCNGHCBDP KCBNBMIKAGC()
	{
		return default(NKPCNGHCBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CD40B0", Offset = "0x7CD28B0", VA = "0x187CD40B0", Slot = "6")]
	public void OJKEOIMPGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3C80", Offset = "0x7CD2480", VA = "0x187CD3C80", Slot = "7")]
	private void ECHJCHGCHFC(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1137340", Offset = "0x1135B40", VA = "0x181137340", Slot = "8")]
	private void BKNPNDBLAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EMFGPOGGLLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(ELAFEKELMAB), new string[] { })]
public class CLCJFPBMMPJ : ELAFEKELMAB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1390", Offset = "0x7CCFB90", VA = "0x187CD1390", Slot = "4")]
	public void KELGJIMEANC(World GOCNACMHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD14D0", Offset = "0x7CCFCD0", VA = "0x187CD14D0", Slot = "5")]
	public void ODHIICHIDHA(World GOCNACMHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD12D0", Offset = "0x7CCFAD0", VA = "0x187CD12D0", Slot = "6")]
	public ComponentSystemBase BJBODGOAIIE(World GOCNACMHICP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1410", Offset = "0x7CCFC10", VA = "0x187CD1410", Slot = "7")]
	public void MIKMGHBHIAL(World GOCNACMHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1470", Offset = "0x7CCFC70", VA = "0x187CD1470", Slot = "8")]
	public void ODADPIMPIPE(World GOCNACMHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1270", Offset = "0x7CCFA70", VA = "0x187CD1270", Slot = "9")]
	public void AINMKAOALFB(World GOCNACMHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1320", Offset = "0x7CCFB20", VA = "0x187CD1320", Slot = "10")]
	public void HDDDKLNBGFD(World GOCNACMHICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1520", Offset = "0x7CCFD20", VA = "0x187CD1520", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> OMLDFEKBLJA()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public CLCJFPBMMPJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct EJEEHNIALNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct LEGFMOLGOCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FOBHCLLMNHB : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FMOLHEJODCJ NBBPCEHNGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4AD0", Offset = "0x7CD32D0", VA = "0x187CD4AD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4A60", Offset = "0x7CD3260", VA = "0x187CD4A60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FOBHCLLMNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct IKJMMOKKKIF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NKPCNGHCBDP IIFCDCJFPFO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static IKJMMOKKKIF FGIKKMMHFBO(NKPCNGHCBDP EKNJAMPDKID)
	{
		return default(IKJMMOKKKIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PDNIFCOGNNO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OFIGCCKINJH NDEHFNJADIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA470", Offset = "0x7CE8C70", VA = "0x187CEA470", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PDNIFCOGNNO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct CGNNFDJMHFN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct HBHBONENEPH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DLGAKKGEPKP DACOEMODODH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static HBHBONENEPH FGIKKMMHFBO(DLGAKKGEPKP EKNJAMPDKID)
	{
		return default(HBHBONENEPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct MEAILBMNEBA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NKPCNGHCBDP IIFCDCJFPFO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static MEAILBMNEBA FGIKKMMHFBO(NKPCNGHCBDP EKNJAMPDKID)
	{
		return default(MEAILBMNEBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AJJNDMPHDMN : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CILFHMBDFBH CDJMJLPIIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFBB0", Offset = "0x7CCE3B0", VA = "0x187CCFBB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB40", Offset = "0x7CCE340", VA = "0x187CCFB40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AJJNDMPHDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ECCLDALMFEG : IJJAFMAIAKN, FMOLHEJODCJ, PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PFDGIOAKAOJ OCKFKHHPDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCF7CF0", Offset = "0xCF64F0", VA = "0x180CF7CF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(PFDGIOAKAOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MILDILAPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBCE330", Offset = "0xBCCB30", VA = "0x180BCE330", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 MICMADINKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x108A6F0", Offset = "0x1088EF0", VA = "0x18108A6F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1EB0", Offset = "0x7CD06B0", VA = "0x187CD1EB0")]
	public ECCLDALMFEG(UniformTRS FDMLLHGDCDA, JAIEPPMCFLB DFPCBMGPBFO, float FAIAGJPDHEJ, float3 GBPGNAMPCBK, CGKMKJEAANA CPEAAHKBCMA, KLEDGCGHKKL IPDPBDINOIB, PFDGIOAKAOJ KJNOHGKHCJC, float3 IFLAEBIIEHD, bool KGEIMLJLEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1E60", Offset = "0x7CD0660", VA = "0x187CD1E60", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KMNCHGEOOCJ : IJJAFMAIAKN, CILFHMBDFBH, PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<OFEAEHKGGHH> NBHKPDIOKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly GDGHNDGMHNE KIAKHLGFPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float FLHICPCFHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int ODCAPHCCFLH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BPOLINDOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE76C0", Offset = "0x7CE5EC0", VA = "0x187CE76C0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NNBCPAEDGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE76E0", Offset = "0x7CE5EE0", VA = "0x187CE76E0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool CCBOMDCEPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE76D0", Offset = "0x7CE5ED0", VA = "0x187CE76D0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JKGDKNOICOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD43E80", Offset = "0xD42680", VA = "0x180D43E80", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float HEALHAGNOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC466D0", Offset = "0xC44ED0", VA = "0x180C466D0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DMLIMHEEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF1C4B0", Offset = "0xF1ACB0", VA = "0x180F1C4B0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7610", Offset = "0x7CE5E10", VA = "0x187CE7610")]
	public KMNCHGEOOCJ(UniformTRS FDMLLHGDCDA, JAIEPPMCFLB DFPCBMGPBFO, float FAIAGJPDHEJ, float3 GBPGNAMPCBK, CGKMKJEAANA CPEAAHKBCMA, KLEDGCGHKKL IPDPBDINOIB, GDGHNDGMHNE KIAKHLGFPAF, float FLHICPCFHBF, int ODCAPHCCFLH, NativeArray<OFEAEHKGGHH> NBHKPDIOKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10A04D0", Offset = "0x109ECD0", VA = "0x1810A04D0", Slot = "33")]
	public NativeArray<OFEAEHKGGHH> GetNativeCurvePoints()
	{
		return default(NativeArray<OFEAEHKGGHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7550", Offset = "0x7CE5D50", VA = "0x187CE7550", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AOOEHPIEDDI : OHKBAKGFDEF, FMOLHEJODCJ, PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<INNMCPGDHCO, PFDGIOAKAOJ> LPBGLLMELBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private PFDGIOAKAOJ KJNOHGKHCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool KGEIMLJLEAK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private PFDGIOAKAOJ ELOEGEPGEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80", Slot = "28")]
		get
		{
			return default(PFDGIOAKAOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool LDGOGOCPECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xDFC880", Offset = "0xDFB080", VA = "0x180DFC880", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 MICMADINKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD04F0", Offset = "0x7CCECF0", VA = "0x187CD04F0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CD04D0", Offset = "0x7CCECD0", VA = "0x187CD04D0")]
	public AOOEHPIEDDI(FGFPKLDJIEL GOKHBEHMPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFE50", Offset = "0x7CCE650", VA = "0x187CCFE50", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFEA0", Offset = "0x7CCE6A0", VA = "0x187CCFEA0", Slot = "26")]
	public override void MAEEPMKIKNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JEBNIOKBKGH : IPCHIDACINP, OFIGCCKINJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject HANMFEOIJHF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject KHPLFMGJOON
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3EB0", Offset = "0x7CE26B0", VA = "0x187CE3EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AIFAFFNBDPH FCHHAJKLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3C30", Offset = "0x7CE2430", VA = "0x187CE3C30", Slot = "15")]
		get
		{
			return default(AIFAFFNBDPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DHLGPNHKFGA PKBBGPAIKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4090", Offset = "0x7CE2890", VA = "0x187CE4090", Slot = "16")]
		get
		{
			return default(DHLGPNHKFGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3F40", Offset = "0x7CE2740", VA = "0x187CE3F40")]
	public JEBNIOKBKGH(FGFPKLDJIEL DGLFHMAFDAJ, bool AEDLBKLDGFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3AA0", Offset = "0x7CE22A0", VA = "0x187CE3AA0")]
	public void AOAHBIGGCGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3C30", Offset = "0x7CE2430", VA = "0x187CE3C30")]
	protected AIFAFFNBDPH CJMHOGGLPLM()
	{
		return default(AIFAFFNBDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3D60", Offset = "0x7CE2560", VA = "0x187CE3D60")]
	private static bool ENMHMAKGGII(FGFPKLDJIEL IFHJAMIIJFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3D30", Offset = "0x7CE2530", VA = "0x187CE3D30", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HEGFNOPMLBM : OHKBAKGFDEF, CILFHMBDFBH, PBDOHGFKHAA, IDisposable, DFJCBJNFNEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<OFEAEHKGGHH> NBHKPDIOKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool JDJNEMHBEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LNCKLLLNHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float FLHICPCFHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int ODCAPHCCFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool PLNDJAIOCMC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool GJGIKIDDNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9E0", Offset = "0xBFC1E0", VA = "0x180BFD9E0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool HFOHGBJMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA2A680", Offset = "0xA28E80", VA = "0x180A2A680", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float DCBELJCOLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1048640", Offset = "0x1046E40", VA = "0x181048640", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int HCJIOKDCAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xCF7CF0", Offset = "0xCF64F0", VA = "0x180CF7CF0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool FABEEAOGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBCE330", Offset = "0xBCCB30", VA = "0x180BCE330", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int HMCDGHOGOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD2E0", Offset = "0x7CDBAE0", VA = "0x187CDD2E0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int DLPHAHDFMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7CDD920", Offset = "0x7CDC120", VA = "0x187CDD920", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDA80", Offset = "0x7CDC280", VA = "0x187CDDA80")]
	public HEGFNOPMLBM(FGFPKLDJIEL GOKHBEHMPCJ, [Optional] NativeList<OFEAEHKGGHH> NBHKPDIOKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD810", Offset = "0x7CDC010", VA = "0x187CDD810", Slot = "26")]
	public override void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD1F0", Offset = "0x7CDB9F0", VA = "0x187CDD1F0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD300", Offset = "0x7CDBB00", VA = "0x187CDD300", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD190", Offset = "0x7CDB990", VA = "0x187CDD190")]
	public void CFEEKFEKMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD4B0", Offset = "0x7CDBCB0", VA = "0x187CDD4B0", Slot = "34")]
	public NativeArray<OFEAEHKGGHH> GetNativeCurvePoints()
	{
		return default(NativeArray<OFEAEHKGGHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD360", Offset = "0x7CDBB60", VA = "0x187CDD360", Slot = "35")]
	private Vector3 FLPBMCMLKLO(int IGNBGDBAAAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD8F0", Offset = "0x7CDC0F0", VA = "0x187CDD8F0", Slot = "36")]
	private Quaternion NPJELCEGBLA(int IGNBGDBAAAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7CDD680", Offset = "0x7CDBE80", VA = "0x187CDD680", Slot = "37")]
	private float JMOECEPHPIJ(int IGNBGDBAAAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDA10", Offset = "0x7CDC210", VA = "0x187CDDA10")]
	private NativeArray<Entity> OKNCLIFBFCF()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class FBBLPHMBIBM : JGKHHNABHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7CD41C0", Offset = "0x7CD29C0", VA = "0x187CD41C0", Slot = "15")]
	protected override ComponentSystemBase GMPFHHDBBII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7CD45D0", Offset = "0x7CD2DD0", VA = "0x187CD45D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7CD45E0", Offset = "0x7CD2DE0", VA = "0x187CD45E0")]
	public FBBLPHMBIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PFJDKBHDINN]
public sealed class MEEHBIBMLFH : OILHAKDGMKA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery BPELKCCEGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery DGINNCBCNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery EEAKMPBLMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery GJHEGLPHGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery BACBHHJPFJH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8A70", Offset = "0x7CE7270", VA = "0x187CE8A70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8DD0", Offset = "0x7CE75D0", VA = "0x187CE8DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8300", Offset = "0x7CE6B00", VA = "0x187CE8300")]
	private void AJMEIBFJNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8540", Offset = "0x7CE6D40", VA = "0x187CE8540")]
	private void FFEJAFEDHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE88A0", Offset = "0x7CE70A0", VA = "0x187CE88A0")]
	private void OHBIAGLGPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8750", Offset = "0x7CE6F50", VA = "0x187CE8750")]
	private void KIJFICFPPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8650", Offset = "0x7CE6E50", VA = "0x187CE8650")]
	private void GOBEOELNEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8850", Offset = "0x7CE7050", VA = "0x187CE8850")]
	private NativeList<Entity> LOCBPBCMENE(NativeArray<Entity> OOCEMABKIJN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8E10", Offset = "0x7CE7610", VA = "0x187CE8E10")]
	private NativeList<Entity> PBFPNDCKMBB(NativeArray<Entity> OOCEMABKIJN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE84E0", Offset = "0x7CE6CE0", VA = "0x187CE84E0")]
	private void BGKKBAJHMAL(NativeArray<Entity> OOCEMABKIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public MEEHBIBMLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PFJDKBHDINN]
public sealed class KBNECOCEHMP : OILHAKDGMKA, JOGFKELELCN
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery DDKOINMDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery AIACIKIEJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery OONDKCEMEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DEEEKFNCCJH FOGPNGDKCJF;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CE72E0", Offset = "0x7CE5AE0", VA = "0x187CE72E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6720", Offset = "0x7CE4F20", VA = "0x187CE6720", Slot = "15")]
	public override void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CE74B0", Offset = "0x7CE5CB0", VA = "0x187CE74B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6780", Offset = "0x7CE4F80", VA = "0x187CE6780")]
	private void JHGAAAOEOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6C50", Offset = "0x7CE5450", VA = "0x187CE6C50")]
	private void NEBAMDAPJGE(NativeParallelHashSet<NKPCNGHCBDP> OIIMNCPAMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5C40", Offset = "0x7CE4440", VA = "0x187CE5C40")]
	private void AOLNJDCFBGO(NativeParallelHashSet<NKPCNGHCBDP> OIIMNCPAMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CE62D0", Offset = "0x7CE4AD0", VA = "0x187CE62D0")]
	private void EGECGMBBBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6680", Offset = "0x7CE4E80", VA = "0x187CE6680")]
	private bool IJEEBMDIFKH(Entity EAALLGNPDMK, [Out] NKPCNGHCBDP IIFCDCJFPFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6AA0", Offset = "0x7CE52A0", VA = "0x187CE6AA0")]
	private bool LCOIPIKNJLM(Entity EAALLGNPDMK, [Out] NKPCNGHCBDP IIFCDCJFPFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public KBNECOCEHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PFJDKBHDINN]
public sealed class ABCMDHMLCEO : OILHAKDGMKA
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery HGOEPPPFBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery PGMGIBNAIHF;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF940", Offset = "0x7CCE140", VA = "0x187CCF940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFA90", Offset = "0x7CCE290", VA = "0x187CCFA90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF640", Offset = "0x7CCDE40", VA = "0x187CCF640")]
	private void NEBAMDAPJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF350", Offset = "0x7CCDB50", VA = "0x187CCF350")]
	private void AOLNJDCFBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public ABCMDHMLCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EJKOINPJGBD : OILHAKDGMKA, JOGFKELELCN
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct HMMBHNMJHCC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob KONIIEMLLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob CGIDHPONJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob DIGDCAHOJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob FJIMNMPENIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle CBDINHAHKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<MEAILBMNEBA> OIEGEMPHLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<NKPCNGHCBDP> NOFMGGLPHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> IMHKNGFGKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> JOHNIHACHFP;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDB90", Offset = "0x7CDC390", VA = "0x187CDDB90", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CDDC10", Offset = "0x7CDC410", VA = "0x187CDDC10")]
		private void FAKBNOAIJBE(EntityQueryInJob DMCOBMDNKEK, NativeList<Entity> GAKJEIDOMPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct ALCNGHJBBLJ : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle CBDINHAHKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<MEAILBMNEBA> OIEGEMPHLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<NKPCNGHCBDP> NOFMGGLPHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> GAKJEIDOMPO;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFC00", Offset = "0x7CCE400", VA = "0x187CCFC00", Slot = "4")]
		public void Execute(ArchetypeChunk EKFGGMJJCJP, int EBLEGMJEKBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct BOHDEFNNCCP : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle CBDINHAHKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> OKIJIBNAJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<HBHBONENEPH> HNFONNHHBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<IKJMMOKKKIF> NEONNNEDHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<MEAILBMNEBA> OBDPEDHBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<NKPCNGHCBDP> NOFMGGLPHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> PHCFCMGNPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<HBHBONENEPH> FHBBFCDPIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<NKPCNGHCBDP> GDHMMICEABA;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0F40", Offset = "0x7CCF740", VA = "0x187CD0F40", Slot = "4")]
		public void Execute(ArchetypeChunk EKFGGMJJCJP, int EBLEGMJEKBH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery KONIIEMLLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery CGIDHPONJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery DIGDCAHOJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery FJIMNMPENIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery ACAOCEMFNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery NOIPNGBOFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery AINLEKICDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private DEEEKFNCCJH JFODEDPMJJK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3380", Offset = "0x7CD1B80", VA = "0x187CD3380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2B50", Offset = "0x7CD1350", VA = "0x187CD2B50", Slot = "15")]
	public override void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3900", Offset = "0x7CD2100", VA = "0x187CD3900", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1F50", Offset = "0x7CD0750", VA = "0x187CD1F50")]
	private void BAEMKIKBBHI(NativeParallelHashSet<NKPCNGHCBDP> NOFMGGLPHDA, int CNABGOPABLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2550", Offset = "0x7CD0D50", VA = "0x187CD2550")]
	private void EPCNBGBBHNI(NativeParallelHashSet<NKPCNGHCBDP> NOFMGGLPHDA, int ODOHNPPIKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2F40", Offset = "0x7CD1740", VA = "0x187CD2F40")]
	private void KJDOIGLGJKJ(NativeParallelHashSet<NKPCNGHCBDP> NOFMGGLPHDA, int EOBDHNFAPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2BB0", Offset = "0x7CD13B0", VA = "0x187CD2BB0")]
	private void JIOAIGLMCPE(NativeParallelHashSet<NKPCNGHCBDP> OIIMNCPAMPO, int OABLAOMNKNM, int IMLKMPHGAAP, int ANJEEOFDDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CD29A0", Offset = "0x7CD11A0", VA = "0x187CD29A0")]
	private void FAMELEMIIEK(Entity OAEICIAOFDJ, DLGAKKGEPKP KGJBFMFEJAK, NKPCNGHCBDP IIFCDCJFPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public EJKOINPJGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GCACJDBDGPH : OILHAKDGMKA
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery MJDPNLOADNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery HPKFDDPOFCB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4B20", Offset = "0x7CD3320", VA = "0x187CD4B20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4D50", Offset = "0x7CD3550", VA = "0x187CD4D50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public GCACJDBDGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MBHALNHKNEC : OILHAKDGMKA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct MDICBJJODOA : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery FACGFEGHHCA;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7F90", Offset = "0x7CE6790", VA = "0x187CE7F90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CE80D0", Offset = "0x7CE68D0", VA = "0x187CE80D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public MBHALNHKNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PFJDKBHDINN]
internal class MLJIEOHBBAM : OILHAKDGMKA
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class DGCLGHFNNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery BCEIKJFCFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery KEIEEHEPJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public OBIKNNNCGCB OPJNCCGDJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType MAGNEKMJGBB;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DGCLGHFNNNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void OBIKNNNCGCB(NativeArray<DLGAKKGEPKP> EKNJAMPDKID, OJMGMPCIMIF MGOIJMAMEFL);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<DGCLGHFNNNM> FBCGHPONNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private MPMGNAFDKAM PJIFJNKDMKN;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9080", Offset = "0x7CE7880", VA = "0x187CE9080", Slot = "15")]
	public override void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9420", Offset = "0x7CE7C20", VA = "0x187CE9420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CE95B0", Offset = "0x7CE7DB0", VA = "0x187CE95B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x38C5C20", Offset = "0x38C4420", VA = "0x1838C5C20")]
	private void ENHJJBDBEBH<T>(OBIKNNNCGCB OPJNCCGDJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8EE0", Offset = "0x7CE76E0", VA = "0x187CE8EE0")]
	private static void HDCGDKOLGCL(NativeArray<DLGAKKGEPKP> HAIKNNMBBDO, OJMGMPCIMIF FCBLHMAOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9280", Offset = "0x7CE7A80", VA = "0x187CE9280")]
	private static void MNGPCAPDMPH(NativeArray<DLGAKKGEPKP> HAIKNNMBBDO, OJMGMPCIMIF FCBLHMAOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CE90E0", Offset = "0x7CE78E0", VA = "0x187CE90E0")]
	private static void JPDJDHPANHG(NativeArray<DLGAKKGEPKP> HAIKNNMBBDO, OJMGMPCIMIF FCBLHMAOBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public MLJIEOHBBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PFJDKBHDINN]
public sealed class JGCNBGHBMFI : OILHAKDGMKA
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery DMCOBMDNKEK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE41F0", Offset = "0x7CE29F0", VA = "0x187CE41F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct HGAGJJJJPPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS FDMLLHGDCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData CHMPHLKCFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public PFDGIOAKAOJ KJNOHGKHCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 IFLAEBIIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool KGEIMLJLEAK;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[LPCEEANGMDL(Lifetime.LoadInstance)]
public struct IHAOKIDFDKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity MGAACDLILLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> KNGEPMJCFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> LLLNAKOJKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<HGAGJJJJPPM> DMBKBKDACPI;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDE40", Offset = "0x7CDC640", VA = "0x187CDDE40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(GILEBMJAOIN), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class GILEBMJAOIN : JOGFKELELCN, JPHALCNLDIO, KKFFKJEIEOE, CDBAFKLBPMB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct FHKJMEPFJPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly GILEBMJAOIN DFPCBMGPBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool FFFEPLPCPBD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1774470", Offset = "0x1772C70", VA = "0x181774470")]
		public FHKJMEPFJPI(GILEBMJAOIN DFPCBMGPBFO, bool FFFEPLPCPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CD45F0", Offset = "0x7CD2DF0", VA = "0x187CD45F0")]
		public Queue<IJDPIABLLKP>.Enumerator DPNIJJHCOGM()
		{
			return default(Queue<IJDPIABLLKP>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CD46B0", Offset = "0x7CD2EB0", VA = "0x187CD46B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private EFICJEHFEEE EHALGOCJDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private LONGCCCLIGA NNLADPFICHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<OFEAEHKGGHH>> PMJAEMNDBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> FKMIHOIDKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<DLGAKKGEPKP> DFHMHKKDAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private BDIILLPFAOM<IJDPIABLLKP> BHJKJFEKMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private BDIILLPFAOM<IHAOKIDFDKM> EILGECGFBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private BDIILLPFAOM<HHFCFJHBALA> OHBJDOFJPPH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5760", Offset = "0x7CD3F60", VA = "0x187CD5760", Slot = "4")]
	public void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5640", Offset = "0x7CD3E40", VA = "0x187CD5640")]
	public void FNMEAKKKDAB(NativeList<OFEAEHKGGHH> PIEHIJCBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5960", Offset = "0x7CD4160", VA = "0x187CD5960")]
	public void MBCGCFHLAAA(Entity DFPCBMGPBFO, [In] JNOBHPMEBLN<GameObject> EGGIJMAHJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6190", Offset = "0x7CD4990", VA = "0x187CD6190")]
	public void OJCEHJBKDFJ(NativeList<DLGAKKGEPKP> HAIKNNMBBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CD52C0", Offset = "0x7CD3AC0", VA = "0x187CD52C0")]
	public void AINMKAOALFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5CE0", Offset = "0x7CD44E0", VA = "0x187CD5CE0")]
	public void OAOGEMONGEA(OBHDPEBCHIG IPKPNIAEJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6270", Offset = "0x7CD4A70", VA = "0x187CD6270")]
	public JobHandle PIBPOLHNODM([In] IJDPIABLLKP NJAAPDELBNN, JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6310", Offset = "0x7CD4B10", VA = "0x187CD6310")]
	public JobHandle PIBPOLHNODM([In] IHAOKIDFDKM NJAAPDELBNN, JobHandle LHPJLLFOIME)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x79BA480", Offset = "0x79B8C80", VA = "0x1879BA480")]
	public FHKJMEPFJPI MAOADOAEOOO(bool FFFEPLPCPBD)
	{
		return default(FHKJMEPFJPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CD6220", Offset = "0x7CD4A20", VA = "0x187CD6220")]
	public EAIGDPKCEHP<IHAOKIDFDKM> OMGIOKFOLMC()
	{
		return default(EAIGDPKCEHP<IHAOKIDFDKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5710", Offset = "0x7CD3F10", VA = "0x187CD5710")]
	public EAIGDPKCEHP<HHFCFJHBALA> IOFLNOCEGBN()
	{
		return default(EAIGDPKCEHP<HHFCFJHBALA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5AC0", Offset = "0x7CD42C0", VA = "0x187CD5AC0")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CD54F0", Offset = "0x7CD3CF0", VA = "0x187CD54F0", Slot = "5")]
	public void DPMOIAAKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CD55D0", Offset = "0x7CD3DD0", VA = "0x187CD55D0", Slot = "6")]
	private void ECHJCHGCHFC(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x113B690", Offset = "0x1139E90", VA = "0x18113B690", Slot = "7")]
	private void BKNPNDBLAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GILEBMJAOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct NMGOALJHFII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS FDMLLHGDCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData CHMPHLKCFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public IGMEPMPFKOO KIAKHLGFPAF;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[LPCEEANGMDL(Lifetime.LoadInstance)]
public struct IJDPIABLLKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity MGAACDLILLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> OOCEMABKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> KNGEPMJCFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> LLLNAKOJKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<CFCDJGMMHDE> FKFNNPLMJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<OFEAEHKGGHH> PIEHIJCBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<NMGOALJHFII> PALEIBPCMKO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2AF0", Offset = "0x7CE12F0", VA = "0x187CE2AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2B00", Offset = "0x7CE1300", VA = "0x187CE2B00")]
	public void OCOBEACFBKJ(bool FFFEPLPCPBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(FNDDOJGCKAC), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class FNDDOJGCKAC : OIBDBHHNNDB, KKFFKJEIEOE, CDBAFKLBPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private GILEBMJAOIN FLMLAPMHPPJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4A40", Offset = "0x7CD3240", VA = "0x187CD4A40", Slot = "4")]
	public void HCNBIBECBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CD49F0", Offset = "0x7CD31F0", VA = "0x187CD49F0", Slot = "5")]
	private void ECHJCHGCHFC(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1118BD0", Offset = "0x11173D0", VA = "0x181118BD0", Slot = "6")]
	private void BKNPNDBLAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FNDDOJGCKAC()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : OILHAKDGMKA, JOGFKELELCN
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
			public NativeParallelHashMap<int, PFDGIOAKAOJ> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<HGAGJJJJPPM> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6430", Offset = "0x7CD4C30", VA = "0x187CD6430", Slot = "4")]
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
			public NativeArray<OFEAEHKGGHH> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<CFCDJGMMHDE> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<NMGOALJHFII> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7CD67D0", Offset = "0x7CD4FD0", VA = "0x187CD67D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CD1D20", Offset = "0x7CD0520", VA = "0x187CD1D20", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7CEA730", Offset = "0x7CE8F30", VA = "0x187CEA730")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7CEA6E0", Offset = "0x7CE8EE0", VA = "0x187CEA6E0")]
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
				float3 HNJMDAKLEDL(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7CE7870", Offset = "0x7CE6070", VA = "0x187CE7870", Slot = "5")]
				public float3 MGDLMJOIMFM(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7CE7830", Offset = "0x7CE6030", VA = "0x187CE7830", Slot = "4")]
				public float3 HNJMDAKLEDL(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7CE9B30", Offset = "0x7CE8330", VA = "0x187CE9B30", Slot = "4")]
				public float3 HNJMDAKLEDL(quaternion rotation)
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
			public NativeArray<CFCDJGMMHDE> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<OFEAEHKGGHH> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7CD7570", Offset = "0x7CD5D70", VA = "0x187CD7570", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7CD9C10", Offset = "0x7CD8410", VA = "0x187CD9C10")]
			private void MDEBGJALOEI(NativeList<PointSrcData> srcData, NativeList<OFEAEHKGGHH> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7CD7FA0", Offset = "0x7CD67A0", VA = "0x187CD7FA0")]
			public static Vector3 GBPEGCNGGKD(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6EF0", Offset = "0x7CD56F0", VA = "0x187CD6EF0")]
			public static quaternion AMCEPBPMHLD(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6F70", Offset = "0x7CD5770", VA = "0x187CD6F70")]
			private static quaternion BAPBLDINJDH(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7CD9A40", Offset = "0x7CD8240", VA = "0x187CD9A40")]
			private static float3 KGBDCBGIPGL(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7CDAD70", Offset = "0x7CD9570", VA = "0x187CDAD70")]
			private static quaternion PACJEGPFFPP(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7CD89C0", Offset = "0x7CD71C0", VA = "0x187CD89C0")]
			private static OFEAEHKGGHH JCNNLCPKFIO(int idx, NativeList<PointSrcData> srcData)
			{
				return default(OFEAEHKGGHH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3EACF80", Offset = "0x3EAB780", VA = "0x183EACF80")]
			private void JOALLNFPJJH<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7CD8C30", Offset = "0x7CD7430", VA = "0x187CD8C30")]
			private void JHPDHHCOFOO(NativeList<PointSrcData> sourcePoints, NativeList<OFEAEHKGGHH> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7CD71A0", Offset = "0x7CD59A0", VA = "0x187CD71A0")]
			public static float BCKBJIGLCMO(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7CD7BD0", Offset = "0x7CD63D0", VA = "0x187CD7BD0")]
			private static quaternion FHCHNJOCLKN(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7CD7320", Offset = "0x7CD5B20", VA = "0x187CD7320")]
			private static OFEAEHKGGHH CJPCBMBDPKG(PointSrcData point)
			{
				return default(OFEAEHKGGHH);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7CD7440", Offset = "0x7CD5C40", VA = "0x187CD7440")]
			private static OFEAEHKGGHH CJPCBMBDPKG(float3 pos, quaternion rot, float radius)
			{
				return default(OFEAEHKGGHH);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7CD74D0", Offset = "0x7CD5CD0", VA = "0x187CD74D0")]
			private static bool CLMJINMNEOA(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7CDACA0", Offset = "0x7CD94A0", VA = "0x187CDACA0")]
			private static float3 OGAAKNBDIBP(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7CD83B0", Offset = "0x7CD6BB0", VA = "0x187CD83B0")]
			public static float3 GCDGHFFCJJM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7CDAAF0", Offset = "0x7CD92F0", VA = "0x187CDAAF0")]
			public static float3 MGDLMJOIMFM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7CD8560", Offset = "0x7CD6D60", VA = "0x187CD8560")]
			private static quaternion IKNCFEAMFOP(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7CD7DC0", Offset = "0x7CD65C0", VA = "0x187CD7DC0")]
			private static float FJEOACKEJEG(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7CED160", Offset = "0x7CEB960", VA = "0x187CED160")]
			private void EGDFHKOBBEF(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7CED240", Offset = "0x7CEBA40", VA = "0x187CED240", Slot = "4")]
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
			public NativeList<OFEAEHKGGHH> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7CEE100", Offset = "0x7CEC900", VA = "0x187CEE100")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7CEE160", Offset = "0x7CEC960", VA = "0x187CEE160", Slot = "4")]
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
			public NativeList<OFEAEHKGGHH> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7CEE0A0", Offset = "0x7CEC8A0", VA = "0x187CEE0A0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7CEE0F0", Offset = "0x7CEC8F0", VA = "0x187CEE0F0", Slot = "4")]
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
			public NativeList<HGAGJJJJPPM> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6B10", Offset = "0x7CD5310", VA = "0x187CD6B10")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6CD0", Offset = "0x7CD54D0", VA = "0x187CD6CD0", Slot = "4")]
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
			public NativeList<CFCDJGMMHDE> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<NMGOALJHFII> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6CE0", Offset = "0x7CD54E0", VA = "0x187CD6CE0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7CD6EE0", Offset = "0x7CD56E0", VA = "0x187CD6EE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CEDC70", Offset = "0x7CEC470", VA = "0x187CEDC70")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7CEE090", Offset = "0x7CEC890", VA = "0x187CEE090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly LLPKKNNAIAE log;

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
		private JMPIPIDCPJJ replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private EFICJEHFEEE objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private GILEBMJAOIN bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private FMCAIKHKOAG ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC8E0", Offset = "0x7CEB0E0", VA = "0x187CEC8E0", Slot = "15")]
		public override void InitReferences(FOMOPIDDKEF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CED670", Offset = "0x7CEBE70", VA = "0x187CED670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CED760", Offset = "0x7CEBF60", VA = "0x187CED760", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CED7C0", Offset = "0x7CEBFC0", VA = "0x187CED7C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBFB0", Offset = "0x7CEA7B0", VA = "0x187CEBFB0")]
		private JobHandle GLEDEOPCDNM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CECAA0", Offset = "0x7CEB2A0", VA = "0x187CECAA0")]
		private JobHandle KJCKEBHKIGH(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB8C0", Offset = "0x7CEA0C0", VA = "0x187CEB8C0")]
		private JobHandle FFEPJIGLLCE(NativeArray<int> pointCount, NativeList<OFEAEHKGGHH> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB820", Offset = "0x7CEA020", VA = "0x187CEB820")]
		private JobHandle EMJKBMDHJLM(NativeList<OFEAEHKGGHH> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB350", Offset = "0x7CE9B50", VA = "0x187CEB350")]
		private JobHandle EECBNFNEHKM(EntityQuery query, NativeList<CFCDJGMMHDE> splinePointRanges, NativeList<OFEAEHKGGHH> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC980", Offset = "0x7CEB180", VA = "0x187CEC980")]
		private JobHandle KIDOHDBLCDH(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBA70", Offset = "0x7CEA270", VA = "0x187CEBA70")]
		private JobHandle FPKGAFBABDA(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB0B0", Offset = "0x7CE98B0", VA = "0x187CEB0B0")]
		private JobHandle DGBECLKLONI(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<HGAGJJJJPPM> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CED930", Offset = "0x7CEC130", VA = "0x187CED930")]
		private JobHandle PMMELHHPCOE(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<CFCDJGMMHDE> splinePointRanges, [Out] NativeList<NMGOALJHFII> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA8A0", Offset = "0x7CE90A0", VA = "0x187CEA8A0")]
		private JobHandle BIAMPMAHDPE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC3D0", Offset = "0x7CEABD0", VA = "0x187CEC3D0")]
		private JobHandle IKONAODPLJH(EntityQuery query, NativeList<HGAGJJJJPPM> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBB90", Offset = "0x7CEA390", VA = "0x187CEBB90")]
		private static NativeParallelHashMap<int, PFDGIOAKAOJ> GHKCBDICMOE()
		{
			return default(NativeParallelHashMap<int, PFDGIOAKAOJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAD10", Offset = "0x7CE9510", VA = "0x187CEAD10")]
		private JobHandle DEGAJPKENFD(EntityQuery query, NativeList<CFCDJGMMHDE> splinePointRanges, NativeList<OFEAEHKGGHH> splinePointData, NativeList<NMGOALJHFII> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC2F0", Offset = "0x7CEAAF0", VA = "0x187CEC2F0")]
		private JobHandle HBMFCJLCNLI(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB8C0", Offset = "0x7CEA0C0", VA = "0x187CEB8C0")]
		private JobHandle FJNAJNGBICA(NativeArray<int> pointCount, NativeList<OFEAEHKGGHH> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB820", Offset = "0x7CEA020", VA = "0x187CEB820")]
		private JobHandle LNAGJMGKPEE(NativeList<OFEAEHKGGHH> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAC20", Offset = "0x7CE9420", VA = "0x187CEAC20")]
		private JobHandle DDNALFPMGAH(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<HGAGJJJJPPM> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB960", Offset = "0x7CEA160", VA = "0x187CEB960")]
		private JobHandle FIBIDGAACPG(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<CFCDJGMMHDE> ranges, NativeList<NMGOALJHFII> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA750", Offset = "0x7CE8F50", VA = "0x187CEA750")]
		private JobHandle BHEEEANOBLP(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7CED330", Offset = "0x7CEBB30", VA = "0x187CED330", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JPHOBCFGINI : KNGBAOCKOIB, JOGFKELELCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private GILEBMJAOIN FLMLAPMHPPJ;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4BA0", Offset = "0x7CE33A0", VA = "0x187CE4BA0", Slot = "14")]
	public void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4BF0", Offset = "0x7CE33F0", VA = "0x187CE4BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
	public JPHOBCFGINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class IHGBMBMPCGA : OILHAKDGMKA, JOGFKELELCN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct OKODHNMPLEN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager MIJJPMGKBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private EOLNFCHDLMC<T> NKKKOCAGLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int FPEOONOJHML;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5477D20", Offset = "0x5476520", VA = "0x185477D20")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5477F80", Offset = "0x5476780", VA = "0x185477F80")]
		public OKODHNMPLEN(EntityManager MIJJPMGKBJK, EOLNFCHDLMC<T> NKKKOCAGLDI, NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x44D7A50", Offset = "0x44D6250", VA = "0x1844D7A50")]
		public OKODHNMPLEN<T> DPNIJJHCOGM()
		{
			return default(OKODHNMPLEN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x54775A0", Offset = "0x5475DA0", VA = "0x1854775A0")]
		public bool EPAECCABOFG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly LLPKKNNAIAE KJHGGBOKNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LONGCCCLIGA NNLADPFICHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private GILEBMJAOIN FLMLAPMHPPJ;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFE20", Offset = "0x7CDE620", VA = "0x187CDFE20", Slot = "15")]
	public override void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE850", Offset = "0x7CDD050", VA = "0x187CDE850")]
	public void HDDDKLNBGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE18B0", Offset = "0x7CE00B0", VA = "0x187CE18B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE06D0", Offset = "0x7CDEED0", VA = "0x187CE06D0")]
	private void OBJIKELNICC(HHFCFJHBALA NJAAPDELBNN, Mesh[] EPEHJJONMPA, NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x37E9160", Offset = "0x37E7960", VA = "0x1837E9160")]
	private OKODHNMPLEN<T> AEHCHHGPIAA<T>(EOLNFCHDLMC<T> NKKKOCAGLDI, NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK) where T : struct
	{
		return default(OKODHNMPLEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE880", Offset = "0x7CDD080", VA = "0x187CDE880")]
	private void HFEFBMPPCOD(Transform DFPCBMGPBFO, NativeArray<EBHIDGBHEAI> DKMDPNEMNHM, JNOBHPMEBLN<GameObject> LIHLJHDLICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDED0", Offset = "0x7CDC6D0", VA = "0x187CDDED0")]
	private void AAFGBPOCKMA(Transform DFPCBMGPBFO, NativeArray<ADBMNGCDADC> JPEDAFIJCCA, JNOBHPMEBLN<GameObject> LIHLJHDLICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE3A0", Offset = "0x7CDCBA0", VA = "0x187CDE3A0")]
	private void BFJBFAHHGIH(Transform DFPCBMGPBFO, NativeArray<FPNKIMELDFH> DHBEOKCGGHH, JNOBHPMEBLN<GameObject> LIHLJHDLICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0290", Offset = "0x7CDEA90", VA = "0x187CE0290")]
	private void JJIMNFPNPHH(Transform DFPCBMGPBFO, NativeArray<NOHDFBCEHKE> EPEHJJONMPA, Mesh[] BCCEEJLFFCI, JNOBHPMEBLN<GameObject> LIHLJHDLICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF160", Offset = "0x7CDD960", VA = "0x187CDF160")]
	private static void HLKFJHPGNFK(NativeParallelHashSet<Entity> OOCEMABKIJN, NativeParallelHashSet<Entity> NOPPKFKKKOC, NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE790", Offset = "0x7CDCF90", VA = "0x187CDE790")]
	private static void EPKGJGFCHGF(NativeList<Entity> GIPAMJGJGNH, NativeArray<EntityRemapUtility.EntityRemapInfo> OBGAALJBDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF2B0", Offset = "0x7CDDAB0", VA = "0x187CDF2B0")]
	private NativeParallelHashMap<Entity, IKJMMOKKKIF> HMLABHPJOAE(GILEBMJAOIN.FHKJMEPFJPI DOACHEBBGPL, EAIGDPKCEHP<IHAOKIDFDKM> CJCOEBCBGBE, List<GameObject> LIHLJHDLICA)
	{
		return default(NativeParallelHashMap<Entity, IKJMMOKKKIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7CE17B0", Offset = "0x7CDFFB0", VA = "0x187CE17B0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OEFNMKCNEPP(Entity PEDEBAFIJPB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7CDEC10", Offset = "0x7CDD410", VA = "0x187CDEC10")]
	private void HKEMNCOMCAF(NativeList<Entity> GLPFAPCIIFN, NativeList<Entity> HIOFNEBBHJA, NativeParallelHashMap<Entity, IKJMMOKKKIF> NBMGIAHIOCI, NativeList<CFCDJGMMHDE> FOMEBHKCEGD, NativeList<OFEAEHKGGHH> EBIAJFPDPFB, NativeList<NMGOALJHFII> PMJAEMNDBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFEA0", Offset = "0x7CDE6A0", VA = "0x187CDFEA0")]
	private void JCMFLILOEPJ(NativeList<Entity> OOCEMABKIJN, NativeList<Entity> KNGEPMJCFBL, NativeParallelHashMap<Entity, IKJMMOKKKIF> NBMGIAHIOCI, NativeList<HGAGJJJJPPM> DMBKBKDACPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB30", Offset = "0x7CCE330", VA = "0x187CCFB30")]
	public IHGBMBMPCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class BBHIAEHGICC : IGFAIHOLKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS FDMLLHGDCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly JAIEPPMCFLB DFPCBMGPBFO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject JOOGMOPMOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS MGNHPEMIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0750", Offset = "0x7CCEF50", VA = "0x187CD0750", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 BCDLKKDONKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0920", Offset = "0x7CCF120", VA = "0x187CD0920", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 IJILFOGDGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0700", Offset = "0x7CCEF00", VA = "0x187CD0700", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 HPDCGJMIOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0660", Offset = "0x7CCEE60", VA = "0x187CD0660", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD08D0", Offset = "0x7CCF0D0", VA = "0x187CD08D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion BNMNHBLKBAF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD05C0", Offset = "0x7CCEDC0", VA = "0x187CD05C0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0830", Offset = "0x7CCF030", VA = "0x187CD0830", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 HPCKCCELLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0610", Offset = "0x7CCEE10", VA = "0x187CD0610", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 HLHDIMJCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0880", Offset = "0x7CCF080", VA = "0x187CD0880", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 PIDADIGICEP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD06B0", Offset = "0x7CCEEB0", VA = "0x187CD06B0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0970", Offset = "0x7CCF170", VA = "0x187CD0970")]
	public BBHIAEHGICC(UniformTRS FDMLLHGDCDA, JAIEPPMCFLB DFPCBMGPBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IJJAFMAIAKN : BBHIAEHGICC, PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float FAIAGJPDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 GBPGNAMPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly CGKMKJEAANA CPEAAHKBCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly KLEDGCGHKKL IPDPBDINOIB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private AIFAFFNBDPH AIBNPFEFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2C20", Offset = "0x7CE1420", VA = "0x187CE2C20", Slot = "17")]
		get
		{
			return default(AIFAFFNBDPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS KCNDDBNMBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2C70", Offset = "0x7CE1470", VA = "0x187CE2C70", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float KPEFKADJODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xBD7F00", Offset = "0xBD6700", VA = "0x180BD7F00", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 JPHMFPNNPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2BD0", Offset = "0x7CE13D0", VA = "0x187CE2BD0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private CGKMKJEAANA NEMCIAKEJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE297D0", Offset = "0xE27FD0", VA = "0x180E297D0", Slot = "21")]
		get
		{
			return default(CGKMKJEAANA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private KLEDGCGHKKL KDPHJCELCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1323500", Offset = "0x1321D00", VA = "0x181323500", Slot = "22")]
		get
		{
			return default(KLEDGCGHKKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool FLOEEFAGJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IFJKMMEMEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2D50", Offset = "0x7CE1550", VA = "0x187CE2D50")]
	protected IJJAFMAIAKN(UniformTRS FDMLLHGDCDA, JAIEPPMCFLB DFPCBMGPBFO, float FAIAGJPDHEJ, float3 GBPGNAMPCBK, CGKMKJEAANA CPEAAHKBCMA, KLEDGCGHKKL IPDPBDINOIB)
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
public abstract class IPCHIDACINP : IGFAIHOLKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly FGFPKLDJIEL GHMCDKKCGHO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected JAIEPPMCFLB LJJLPIHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x111B830", Offset = "0x111A030", VA = "0x18111B830")]
		get
		{
			return default(JAIEPPMCFLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity DJOLAHNDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3990", Offset = "0x7CE2190", VA = "0x187CE3990")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected EFICJEHFEEE HIBEMMMBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2DD0", Offset = "0x7CE15D0", VA = "0x187CE2DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected KOJGGCMNOGM JKGJBDFHPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2FF0", Offset = "0x7CE17F0", VA = "0x187CE2FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected GLMBECBONIF LMLBJIJDIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3900", Offset = "0x7CE2100", VA = "0x187CE3900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject JOOGMOPMOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7CE34F0", Offset = "0x7CE1CF0", VA = "0x187CE34F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS MGNHPEMIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1139570", Offset = "0x1137D70", VA = "0x181139570", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 BCDLKKDONKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7CE39B0", Offset = "0x7CE21B0", VA = "0x187CE39B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 IJILFOGDGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3340", Offset = "0x7CE1B40", VA = "0x187CE3340", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 HPDCGJMIOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3050", Offset = "0x7CE1850", VA = "0x187CE3050", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CE37F0", Offset = "0x7CE1FF0", VA = "0x187CE37F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion BNMNHBLKBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2DE0", Offset = "0x7CE15E0", VA = "0x187CE2DE0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3520", Offset = "0x7CE1D20", VA = "0x187CE3520", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 HPCKCCELLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2F00", Offset = "0x7CE1700", VA = "0x187CE2F00", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 HLHDIMJCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3630", Offset = "0x7CE1E30", VA = "0x187CE3630", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 PIDADIGICEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3180", Offset = "0x7CE1980", VA = "0x187CE3180", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xDC41C0", Offset = "0xDC29C0", VA = "0x180DC41C0")]
	protected IPCHIDACINP(FGFPKLDJIEL GOKHBEHMPCJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7CE34C0", Offset = "0x7CE1CC0", VA = "0x187CE34C0")]
	public static AIFAFFNBDPH FGIKKMMHFBO(IPCHIDACINP NACLDKPPPKG)
	{
		return default(AIFAFFNBDPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EIKHJMGGGOE
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF880", Offset = "0x7CEE080", VA = "0x187CEF880")]
	public static void JLACCANBIGB(NativeArray<Entity> OOCEMABKIJN, EntityManager MIJJPMGKBJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ABCOJBAAPIP
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEEF0", Offset = "0x7CED6F0", VA = "0x187CEEEF0")]
	public static void LAFPLDDJHLI(NativeArray<Entity> OOCEMABKIJN, EntityManager MIJJPMGKBJK, OBHDPEBCHIG HKLPOCODENK, EFICJEHFEEE KIJJLOBIFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEBE0", Offset = "0x7CED3E0", VA = "0x187CEEBE0")]
	public static void JJFNKDFOGCO(NativeArray<Entity> OOCEMABKIJN, EntityManager MIJJPMGKBJK, OBHDPEBCHIG HKLPOCODENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF340", Offset = "0x7CEDB40", VA = "0x187CEF340")]
	public static NativeList<Entity> PBFPNDCKMBB(NativeArray<Entity> OOCEMABKIJN, EntityManager MIJJPMGKBJK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF300", Offset = "0x7CEDB00", VA = "0x187CEF300")]
	public static NativeList<Entity> LOCBPBCMENE(NativeArray<Entity> OOCEMABKIJN, EntityManager MIJJPMGKBJK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF380", Offset = "0x7CEDB80", VA = "0x187CEF380")]
	private static NativeList<Entity> PBFPNDCKMBB(NativeArray<Entity> OOCEMABKIJN, EntityManager MIJJPMGKBJK, bool AAKFGCHDFPP)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class OHKBAKGFDEF : IPCHIDACINP, PBDOHGFKHAA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float FAIAGJPDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 GBPGNAMPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CGKMKJEAANA CPEAAHKBCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private KLEDGCGHKKL IPDPBDINOIB;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager DAIKDJIAKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFBE0", Offset = "0x7CEE3E0", VA = "0x187CEFBE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected FHKJIGHACNJ POMJOMHKPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFB80", Offset = "0x7CEE380", VA = "0x187CEFB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData KIPCICKCPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFE00", Offset = "0x7CEE600", VA = "0x187CEFE00")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private AIFAFFNBDPH AIBNPFEFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE34C0", Offset = "0x7CE1CC0", VA = "0x187CE34C0", Slot = "17")]
		get
		{
			return default(AIFAFFNBDPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float KPEFKADJODN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xEB6410", Offset = "0xEB4C10", VA = "0x180EB6410", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 JPHMFPNNPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x15C0A10", Offset = "0x15BF210", VA = "0x1815C0A10", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private CGKMKJEAANA NEMCIAKEJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90", Slot = "21")]
		get
		{
			return default(CGKMKJEAANA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private KLEDGCGHKKL KDPHJCELCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC4B9C0", Offset = "0xC4A1C0", VA = "0x180C4B9C0", Slot = "22")]
		get
		{
			return default(KLEDGCGHKKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS KCNDDBNMBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFEF0", Offset = "0x7CEE6F0", VA = "0x187CEFEF0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IFJKMMEMEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool FLOEEFAGJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFF20", Offset = "0x7CEE720", VA = "0x187CEFF20")]
	protected OHKBAKGFDEF(FGFPKLDJIEL GOKHBEHMPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFC70", Offset = "0x7CEE470", VA = "0x187CEFC70", Slot = "26")]
	public virtual void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class OILHAKDGMKA : KNGBAOCKOIB, JOGFKELELCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected EFICJEHFEEE KIJJLOBIFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private HOJAHAKCPLA MHBIGPFAJHC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected OBHDPEBCHIG FFJELFFNNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFF50", Offset = "0x7CEE750", VA = "0x187CEFF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected OJMGMPCIMIF AFDMIKHOJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7CF00D0", Offset = "0x7CEE8D0", VA = "0x187CF00D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool HCMHAANDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7CEFFA0", Offset = "0x7CEE7A0", VA = "0x187CEFFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0060", Offset = "0x7CEE860", VA = "0x187CF0060", Slot = "15")]
	public virtual void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
	protected OILHAKDGMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BLONCGCBNJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF5E0", Offset = "0x7CEDDE0", VA = "0x187CEF5E0")]
	public static void HMLAEEPBCCG(NativeArray<Entity> GLPFAPCIIFN, EntityManager MIJJPMGKBJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2994080539
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF02F0", Offset = "0x7CEEAF0", VA = "0x187CF02F0")]
	public static void IABNMKOPMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF02E0", Offset = "0x7CEEAE0", VA = "0x187CF02E0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class NLCKNLMMEPI : ContainerPropertyBag<FOBHCLLMNHB>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFB20", Offset = "0x7CEE320", VA = "0x187CEFB20")]
	public NLCKNLMMEPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class EBDIKNJBJNA : ContainerPropertyBag<PDNIFCOGNNO>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF820", Offset = "0x7CEE020", VA = "0x187CEF820")]
	public EBDIKNJBJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class LMOCJEDAJCB : ContainerPropertyBag<AJJNDMPHDMN>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFAC0", Offset = "0x7CEE2C0", VA = "0x187CEFAC0")]
	public LMOCJEDAJCB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0120", Offset = "0x7CEE920", VA = "0x187CF0120")]
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
