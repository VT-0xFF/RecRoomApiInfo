using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A79CA0", Offset = "0x6A782A0", VA = "0x186A79CA0", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct INMGEFAEGAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int JNFKFBHBIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 BEGKNFGIAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion OMFCMEMKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 FIAELHFMNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int JOEAPFOLGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int MPMBBOKEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int PCKMCPFOFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float JPFBFIPPKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 OFOLEKMDDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool PFFCFJMHOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NMOCELICNOP EDGMENPNOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 LBBEFIIMDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float LKOOLJBPEMD;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HEAFCDEBBOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static EJCCJHONJOD IDAMGEKEFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<INMGEFAEGAI> LAPILKBJMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<GAKBIENKEJE> CGACELHCCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<FEKJLCDDAHK> GDGMLJFANHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<CPDENJNCAAG> HOINHMPIMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<GAKBIENKEJE> FEBMBMMDJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NEOOCPNPFME> NJFJGBGJIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<CPDENJNCAAG>> AHHBJOBILJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<IJHLPEHFBCN> DLBEKACLCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> BDJLDKIDCKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDF6910", Offset = "0xDF4F10", VA = "0x180DF6910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDF5B90", Offset = "0xDF4190", VA = "0x180DF5B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA7780", Offset = "0xAA5D80", VA = "0x180AA7780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDF5A30", Offset = "0xDF4030", VA = "0x180DF5A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A739C0", Offset = "0x6A71FC0", VA = "0x186A739C0")]
	public HEAFCDEBBOK(int JFIDKOLDPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A71E10", Offset = "0x6A70410", VA = "0x186A71E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A71FD0", Offset = "0x6A705D0", VA = "0x186A71FD0")]
	public void EKANILNIIHI(JobHandle KDEMNIPNNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A724E0", Offset = "0x6A70AE0", VA = "0x186A724E0")]
	public void HMFBNACJIEC(INMGEFAEGAI MMDLBEBNCGC, IJHLPEHFBCN PGDFJFLNEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A71CB0", Offset = "0x6A702B0", VA = "0x186A71CB0")]
	public void CEBKMEAPKNP(FEKJLCDDAHK MMDLBEBNCGC, NativeArray<CPDENJNCAAG> GDCIMCONMPO, int KJLIFFOOJEF, int PHNKJDLMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A72700", Offset = "0x6A70D00", VA = "0x186A72700")]
	public JobHandle JMFJDFFLMNH(OMKOMDIKKEA JFNLGLHGEEN, EGJMPJNCICF PKKNCHDHLJM, float3 FGLALPFIKDN, quaternion DKIBHHEHNLA, float LCKBNCCCIEG, bool BMFHPKDANKH, int LIPEPEKOINC = 0, int HHJHMBOIDLG = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A721A0", Offset = "0x6A707A0", VA = "0x186A721A0")]
	public static JobHandle FOOHIIMJMFO(LHDDFFBHCJI DBEKDCHDJGH, OMKOMDIKKEA JFNLGLHGEEN, INMGEFAEGAI MMDLBEBNCGC, JobHandle KDEMNIPNNKE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A73710", Offset = "0x6A71D10", VA = "0x186A73710")]
	public static JobHandle OHNICPIFFGL(ILEDHHPLJDK DBEKDCHDJGH, OMKOMDIKKEA JFNLGLHGEEN, FEKJLCDDAHK MMDLBEBNCGC, NativeArray<CPDENJNCAAG> GDCIMCONMPO, int KJLIFFOOJEF, int PHNKJDLMLOL, JobHandle KDEMNIPNNKE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class OFOAFDPCCEM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BOFELBKOLMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half MCFLKLJDKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort IOKIOMFNPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte BNIFGFMGHCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void FIPJIHCONAL([NoAlias] float3* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class EOBHAFEAFAI
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D920", Offset = "0x6A6BF20", VA = "0x186A6D920")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DA50", Offset = "0x6A6C050", VA = "0x186A6DA50")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D660", Offset = "0x6A6BC60", VA = "0x186A6D660")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D710", Offset = "0x6A6BD10", VA = "0x186A6D710")]
		public unsafe static void DKJHOBNJMII([NoAlias] float3* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void GGMGPKOKGHM([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class PLANOKOJGJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A83B90", Offset = "0x6A82190", VA = "0x186A83B90")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A83CC0", Offset = "0x6A822C0", VA = "0x186A83CC0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A83850", Offset = "0x6A81E50", VA = "0x186A83850")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A83900", Offset = "0x6A81F00", VA = "0x186A83900")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void LLMJGCFMEFF([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class CDJAPLFCCEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A69AE0", Offset = "0x6A680E0", VA = "0x186A69AE0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A69C10", Offset = "0x6A68210", VA = "0x186A69C10")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A697A0", Offset = "0x6A67DA0", VA = "0x186A697A0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A69850", Offset = "0x6A67E50", VA = "0x186A69850")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void PMEIDJNNEJB([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class GNCBDINGNLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A70E20", Offset = "0x6A6F420", VA = "0x186A70E20")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A70F50", Offset = "0x6A6F550", VA = "0x186A70F50")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A70AE0", Offset = "0x6A6F0E0", VA = "0x186A70AE0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A70B90", Offset = "0x6A6F190", VA = "0x186A70B90")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void LNIJANJMBAD([NoAlias] ushort* HNEGHPJHCEO, [Out] float3 DODJJANLEDN, [Out] float3 ACDPCGOLIBH, [In][NoAlias] float3* EGODGDEDJFA, int DCNDPIDGONB, int IEKNLKKGAIM);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class HBGPKBGPKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A71A20", Offset = "0x6A70020", VA = "0x186A71A20")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A71B50", Offset = "0x6A70150", VA = "0x186A71B50")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A71750", Offset = "0x6A6FD50", VA = "0x186A71750")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A71800", Offset = "0x6A6FE00", VA = "0x186A71800")]
		public unsafe static void DKJHOBNJMII([NoAlias] ushort* HNEGHPJHCEO, [Out] float3 DODJJANLEDN, [Out] float3 ACDPCGOLIBH, [In][NoAlias] float3* EGODGDEDJFA, int DCNDPIDGONB, int IEKNLKKGAIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void AHGKEMAIBDA([NoAlias] ushort* MIOBEICGPEI, [In][NoAlias] float3* CFGEHJLPKDL, int IEKNLKKGAIM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class GHPAPEFEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A70850", Offset = "0x6A6EE50", VA = "0x186A70850")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A70980", Offset = "0x6A6EF80", VA = "0x186A70980")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A705B0", Offset = "0x6A6EBB0", VA = "0x186A705B0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A70660", Offset = "0x6A6EC60", VA = "0x186A70660")]
		public unsafe static void DKJHOBNJMII([NoAlias] ushort* MIOBEICGPEI, [In][NoAlias] float3* CFGEHJLPKDL, int IEKNLKKGAIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void PGOEABGFNBC([NoAlias] float3* NPPMLCCFJHO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class NEALJOBCCNC
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AB10", Offset = "0x6A79110", VA = "0x186A7AB10")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AC40", Offset = "0x6A79240", VA = "0x186A7AC40")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A810", Offset = "0x6A78E10", VA = "0x186A7A810")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A8C0", Offset = "0x6A78EC0", VA = "0x186A7A8C0")]
		public unsafe static void DKJHOBNJMII([NoAlias] float3* NPPMLCCFJHO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void NJPINKLCLKL([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class OIFINIHAPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A824B0", Offset = "0x6A80AB0", VA = "0x186A824B0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A825E0", Offset = "0x6A80BE0", VA = "0x186A825E0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A82210", Offset = "0x6A80810", VA = "0x186A82210")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A822C0", Offset = "0x6A808C0", VA = "0x186A822C0")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void MNAKPDFPLJL([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class EBIFFGLIKCC
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A6E0", Offset = "0x6A68CE0", VA = "0x186A6A6E0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A810", Offset = "0x6A68E10", VA = "0x186A6A810")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A370", Offset = "0x6A68970", VA = "0x186A6A370")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A420", Offset = "0x6A68A20", VA = "0x186A6A420")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void EJGBLPNCIAJ([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class LLPIAINGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A79A10", Offset = "0x6A78010", VA = "0x186A79A10")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A79B40", Offset = "0x6A78140", VA = "0x186A79B40")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A796B0", Offset = "0x6A77CB0", VA = "0x186A796B0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A79760", Offset = "0x6A77D60", VA = "0x186A79760")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void LAIKKFCLNOD([NoAlias] ushort* PFCMCLPDAJP, [Out] float2 NEOPGCOAOOB, [Out] float2 PLMJACIOEKG, [In][NoAlias] float2* DELLODABDIL, int DCNDPIDGONB, int IEKNLKKGAIM);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class PECGLJJCJFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82A10", Offset = "0x6A81010", VA = "0x186A82A10")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A82B40", Offset = "0x6A81140", VA = "0x186A82B40")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A82740", Offset = "0x6A80D40", VA = "0x186A82740")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A827F0", Offset = "0x6A80DF0", VA = "0x186A827F0")]
		public unsafe static void DKJHOBNJMII([NoAlias] ushort* PFCMCLPDAJP, [Out] float2 NEOPGCOAOOB, [Out] float2 PLMJACIOEKG, [In][NoAlias] float2* DELLODABDIL, int DCNDPIDGONB, int IEKNLKKGAIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void AGEFMHEFHMP([Out] float2 AJKKABOCBKA, ushort PENLEJDLINN, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class LIOFGEBLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A79420", Offset = "0x6A77A20", VA = "0x186A79420")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A79550", Offset = "0x6A77B50", VA = "0x186A79550")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A79130", Offset = "0x6A77730", VA = "0x186A79130")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A791E0", Offset = "0x6A777E0", VA = "0x186A791E0")]
		public static void DKJHOBNJMII([Out] float2 AJKKABOCBKA, ushort PENLEJDLINN, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void DAHLGMFDJBJ([NoAlias] float2* PFCMCLPDAJP, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class OBCFHFMAHLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B0E0", Offset = "0x6A796E0", VA = "0x186A7B0E0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B210", Offset = "0x6A79810", VA = "0x186A7B210")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ADA0", Offset = "0x6A793A0", VA = "0x186A7ADA0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A7AE50", Offset = "0x6A79450", VA = "0x186A7AE50")]
		public unsafe static void DKJHOBNJMII([NoAlias] float2* PFCMCLPDAJP, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void CCHPEIHIBDE([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class JHAIFGDMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A758F0", Offset = "0x6A73EF0", VA = "0x186A758F0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A75A20", Offset = "0x6A74020", VA = "0x186A75A20")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A75570", Offset = "0x6A73B70", VA = "0x186A75570")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A75620", Offset = "0x6A73C20", VA = "0x186A75620")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void BCHHFKOMGIH([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class KOEJIOKMIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A77C70", Offset = "0x6A76270", VA = "0x186A77C70")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A77DA0", Offset = "0x6A763A0", VA = "0x186A77DA0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A778F0", Offset = "0x6A75EF0", VA = "0x186A778F0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A779A0", Offset = "0x6A75FA0", VA = "0x186A779A0")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void KALMICPNLFD([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class OBPEBGHNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B7D0", Offset = "0x6A79DD0", VA = "0x186A7B7D0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B900", Offset = "0x6A79F00", VA = "0x186A7B900")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B370", Offset = "0x6A79970", VA = "0x186A7B370")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A7B420", Offset = "0x6A79A20", VA = "0x186A7B420")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void ABDCHAFAABC([NoAlias] ushort* OPMMIFOGHHK, [In][NoAlias] float4* LBPBIBIEBKP, int DCNDPIDGONB, int IEKNLKKGAIM);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class EDKNFJMKICH
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D0B0", Offset = "0x6A6B6B0", VA = "0x186A6D0B0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D1E0", Offset = "0x6A6B7E0", VA = "0x186A6D1E0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CDB0", Offset = "0x6A6B3B0", VA = "0x186A6CDB0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CE60", Offset = "0x6A6B460", VA = "0x186A6CE60")]
		public unsafe static void DKJHOBNJMII([NoAlias] ushort* OPMMIFOGHHK, [In][NoAlias] float4* LBPBIBIEBKP, int DCNDPIDGONB, int IEKNLKKGAIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort FEHOAKEINEC([In] float4 BFGBEMOOEIA);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class FHCOABNHBHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E540", Offset = "0x6A6CB40", VA = "0x186A6E540")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E670", Offset = "0x6A6CC70", VA = "0x186A6E670")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E280", Offset = "0x6A6C880", VA = "0x186A6E280")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E330", Offset = "0x6A6C930", VA = "0x186A6E330")]
		public static ushort DKJHOBNJMII([In] float4 BFGBEMOOEIA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void JIKCEEGHFGC([NoAlias] float4* OPMMIFOGHHK, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class PEKBKMHLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A82FA0", Offset = "0x6A815A0", VA = "0x186A82FA0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A830D0", Offset = "0x6A816D0", VA = "0x186A830D0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A82CA0", Offset = "0x6A812A0", VA = "0x186A82CA0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D50", Offset = "0x6A81350", VA = "0x186A82D50")]
		public unsafe static void DKJHOBNJMII([NoAlias] float4* OPMMIFOGHHK, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void CHONPNLKFJM([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class ICEGENELCOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A73F70", Offset = "0x6A72570", VA = "0x186A73F70")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A740A0", Offset = "0x6A726A0", VA = "0x186A740A0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A73CD0", Offset = "0x6A722D0", VA = "0x186A73CD0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A73D80", Offset = "0x6A72380", VA = "0x186A73D80")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void FKBNIMAIBEJ([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class CEGBIBONGEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A0E0", Offset = "0x6A686E0", VA = "0x186A6A0E0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A210", Offset = "0x6A68810", VA = "0x186A6A210")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A69D70", Offset = "0x6A68370", VA = "0x186A69D70")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A69E20", Offset = "0x6A68420", VA = "0x186A69E20")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void NODMJCOIOOE([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class ABMLGOPOAJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A67C40", Offset = "0x6A66240", VA = "0x186A67C40")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A67D70", Offset = "0x6A66370", VA = "0x186A67D70")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A678E0", Offset = "0x6A65EE0", VA = "0x186A678E0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A67990", Offset = "0x6A65F90", VA = "0x186A67990")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void HLNNIDHIONM([Out] float4 IAFCFGOKEAK, ushort PENLEJDLINN);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class FIGKGLIHKCA
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A70320", Offset = "0x6A6E920", VA = "0x186A70320")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6A70450", Offset = "0x6A6EA50", VA = "0x186A70450")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FFF0", Offset = "0x6A6E5F0", VA = "0x186A6FFF0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A700A0", Offset = "0x6A6E6A0", VA = "0x186A700A0")]
		public static void DKJHOBNJMII([Out] float4 IAFCFGOKEAK, ushort PENLEJDLINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void HFDIPCDMACP([NoAlias] float4* BACHJFJMMGB, [NoAlias] byte* JPDHJBFBKLB, [Out] int KMJEPNCCHFK, [Out] int IIBBLIKNCGC, [NoAlias] float4* FPIBGAAAJGA, int DCNDPIDGONB, int IEKNLKKGAIM);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class NDOAHFPNAFH
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A580", Offset = "0x6A78B80", VA = "0x186A7A580")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A6B0", Offset = "0x6A78CB0", VA = "0x186A7A6B0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A2B0", Offset = "0x6A788B0", VA = "0x186A7A2B0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7A360", Offset = "0x6A78960", VA = "0x186A7A360")]
		public unsafe static void DKJHOBNJMII([NoAlias] float4* BACHJFJMMGB, [NoAlias] byte* JPDHJBFBKLB, [Out] int KMJEPNCCHFK, [Out] int IIBBLIKNCGC, [NoAlias] float4* FPIBGAAAJGA, int DCNDPIDGONB, int IEKNLKKGAIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void BJBPGJDHEDC([NoAlias] float4* EHIANJCIDOO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class PKKLBPGLONO
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A835C0", Offset = "0x6A81BC0", VA = "0x186A835C0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A836F0", Offset = "0x6A81CF0", VA = "0x186A836F0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A83230", Offset = "0x6A81830", VA = "0x186A83230")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A832E0", Offset = "0x6A818E0", VA = "0x186A832E0")]
		public unsafe static void DKJHOBNJMII([NoAlias] float4* EHIANJCIDOO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void NFOEFBIOIJO([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class IKCIGHLNLMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6A750C0", Offset = "0x6A736C0", VA = "0x186A750C0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A751F0", Offset = "0x6A737F0", VA = "0x186A751F0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6A74C80", Offset = "0x6A73280", VA = "0x186A74C80")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6A74D30", Offset = "0x6A73330", VA = "0x186A74D30")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void JILFEKLHILJ([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class KPCNMPEPHOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6A78550", Offset = "0x6A76B50", VA = "0x186A78550")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6A78680", Offset = "0x6A76C80", VA = "0x186A78680")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A78100", Offset = "0x6A76700", VA = "0x186A78100")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A781B0", Offset = "0x6A767B0", VA = "0x186A781B0")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void ACKNDKPKPFB([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class FCCFEOCMJKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DFF0", Offset = "0x6A6C5F0", VA = "0x186A6DFF0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E120", Offset = "0x6A6C720", VA = "0x186A6E120")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DBB0", Offset = "0x6A6C1B0", VA = "0x186A6DBB0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DC60", Offset = "0x6A6C260", VA = "0x186A6DC60")]
		public unsafe static void DKJHOBNJMII([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int LEGDANNDNPH([NoAlias] byte* AMEKBPDAGOH, [In][NoAlias] int* FKKFAIHCCDF, int JEHCCHCOEGB);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class LENLLMAJHJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6A78D10", Offset = "0x6A77310", VA = "0x186A78D10")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6A78E40", Offset = "0x6A77440", VA = "0x186A78E40")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6A789E0", Offset = "0x6A76FE0", VA = "0x186A789E0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A78A90", Offset = "0x6A77090", VA = "0x186A78A90")]
		public unsafe static int DKJHOBNJMII([NoAlias] byte* AMEKBPDAGOH, [In][NoAlias] int* FKKFAIHCCDF, int JEHCCHCOEGB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void LHCGJMLPKJI([NoAlias] int* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class AOHIDNGMKKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6A69410", Offset = "0x6A67A10", VA = "0x186A69410")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A69540", Offset = "0x6A67B40", VA = "0x186A69540")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A69120", Offset = "0x6A67720", VA = "0x186A69120")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6A691D0", Offset = "0x6A677D0", VA = "0x186A691D0")]
		public unsafe static void DKJHOBNJMII([NoAlias] int* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void CBBMMKOMBPF([NoAlias] ushort* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class KJCPBEACODC
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6A75E70", Offset = "0x6A74470", VA = "0x186A75E70")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6A75FA0", Offset = "0x6A745A0", VA = "0x186A75FA0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6A75B80", Offset = "0x6A74180", VA = "0x186A75B80")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6A75C30", Offset = "0x6A74230", VA = "0x186A75C30")]
		public unsafe static void DKJHOBNJMII([NoAlias] ushort* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void FACKMFNJEOH([Out] float3 AJKKABOCBKA, ushort PENLEJDLINN);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class GPJNHCMLJKH
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6A714C0", Offset = "0x6A6FAC0", VA = "0x186A714C0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6A715F0", Offset = "0x6A6FBF0", VA = "0x186A715F0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6A710B0", Offset = "0x6A6F6B0", VA = "0x186A710B0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6A71160", Offset = "0x6A6F760", VA = "0x186A71160")]
		public static void DKJHOBNJMII([Out] float3 AJKKABOCBKA, ushort PENLEJDLINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort MLHMBDKIIIH([In] float3 BFGBEMOOEIA);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class ANIAJFDPNHH
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6A68E90", Offset = "0x6A67490", VA = "0x186A68E90")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6A68FC0", Offset = "0x6A675C0", VA = "0x186A68FC0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6A68C10", Offset = "0x6A67210", VA = "0x186A68C10")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6A68CC0", Offset = "0x6A672C0", VA = "0x186A68CC0")]
		public static ushort DKJHOBNJMII([In] float3 BFGBEMOOEIA)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int KJLIFFOOJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int PHNKJDLMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> JOBFACGCDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> GLFJMEKNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> BICNKLEFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> HBNAPPOFLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BOFELBKOLMD> BMHCDJEMBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> HOCHLJMBDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> FLNOIJGKJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 AELJBCGDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 ACDPCGOLIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 CAGPHMHMDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 PLMJACIOEKG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long HOCLIGPIKOF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long GAOHKBJGPBH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float JHDACAELNPL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool BMGGHONGIFL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OCBHAJPOPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6A81950", Offset = "0x6A7FF50", VA = "0x186A81950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E090", Offset = "0x6A7C690", VA = "0x186A7E090")]
	public void EKANILNIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C910", Offset = "0x6A7AF10", VA = "0x186A7C910")]
	public static OFOAFDPCCEM BBHPEKFPBBP(Allocator KOIILCBLJPK, OMKOMDIKKEA CNAJJIONOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C420", Offset = "0x6A7AA20", VA = "0x186A7C420")]
	public static OFOAFDPCCEM BBHPEKFPBBP(Allocator KOIILCBLJPK, NativeArray<float3> EGODGDEDJFA, NativeArray<float3> CFGEHJLPKDL, NativeArray<float2> DELLODABDIL, NativeArray<float4> FPIBGAAAJGA, bool JEOIGDOMKBH, NativeArray<float4> LEFDIIKCJEG, NativeArray<int> FKKFAIHCCDF, int KJLIFFOOJEF, int LCNGDBLGDKD, int PHNKJDLMLOL, int DCNDPIDGONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F020", Offset = "0x6A7D620", VA = "0x186A7F020")]
	public OMKOMDIKKEA HLMAAPAINGI(Allocator KOIILCBLJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CBB0", Offset = "0x6A7B1B0", VA = "0x186A7CBB0")]
	public void BOILBEHCKNM(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A82080", Offset = "0x6A80680", VA = "0x186A82080")]
	private void PJNNDLNNHOE(Mesh CKFPIMAMAKM, NativeArray<ushort> IJGPDLHDKMO, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FA90", Offset = "0x6A7E090", VA = "0x186A7FA90")]
	public void JLBHOCOHEBH(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BA60", Offset = "0x6A7A060", VA = "0x186A7BA60")]
	public void ADIMOGGDHLL(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E310", Offset = "0x6A7C910", VA = "0x186A7E310")]
	public void FKFDNGJBDHP(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DF30", Offset = "0x6A7C530", VA = "0x186A7DF30")]
	public void EIEKAMEENFF(Mesh CKFPIMAMAKM, OMKOMDIKKEA.INHFGGCOFCH MLEOMJOOIIP, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F600", Offset = "0x6A7DC00", VA = "0x186A7F600")]
	public long HLOJPBFCELG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A80D30", Offset = "0x6A7F330", VA = "0x186A80D30")]
	public long LOOCBGOPPNH(OMKOMDIKKEA.INHFGGCOFCH MLEOMJOOIIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EA30", Offset = "0x6A7D030", VA = "0x186A7EA30")]
	private void FMOJIDBMNCN(int KPGHDFKJEPO, int IEKNLKKGAIM, Allocator KOIILCBLJPK, bool BKMPIBDHEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F890", Offset = "0x6A7DE90", VA = "0x186A7F890")]
	private void IDKDICEKIJN(NativeArray<float3> HNEGHPJHCEO, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F810", Offset = "0x6A7DE10", VA = "0x186A7F810")]
	[BurstCompile]
	private unsafe static void IDKDICEKIJN([NoAlias] float3* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A816B0", Offset = "0x6A7FCB0", VA = "0x186A816B0")]
	[BurstCompile]
	private unsafe static void OBBKAGNJLDM([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A80510", Offset = "0x6A7EB10", VA = "0x186A80510")]
	[BurstCompile]
	private unsafe static void KLLBFDOPLGH([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EDC0", Offset = "0x6A7D3C0", VA = "0x186A7EDC0")]
	[BurstCompile]
	private unsafe static void GIILALOICCF([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A81E60", Offset = "0x6A80460", VA = "0x186A81E60")]
	private void PBFCMCNBEFO(NativeArray<float3> EGODGDEDJFA, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A81DD0", Offset = "0x6A803D0", VA = "0x186A81DD0")]
	[BurstCompile]
	private unsafe static void PBFCMCNBEFO([NoAlias] ushort* HNEGHPJHCEO, [Out] float3 DODJJANLEDN, [Out] float3 ACDPCGOLIBH, [In][NoAlias] float3* EGODGDEDJFA, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DDD0", Offset = "0x6A7C3D0", VA = "0x186A7DDD0")]
	private void DOCNLOMIGHC(NativeArray<float3> CFGEHJLPKDL, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DBB0", Offset = "0x6A7C1B0", VA = "0x186A7DBB0")]
	[BurstCompile]
	private unsafe static void DOCNLOMIGHC([NoAlias] ushort* MIOBEICGPEI, [In][NoAlias] float3* CFGEHJLPKDL, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C040", Offset = "0x6A7A640", VA = "0x186A7C040")]
	private void AJKAHJICPCJ(NativeArray<float3> NPPMLCCFJHO, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C110", Offset = "0x6A7A710", VA = "0x186A7C110")]
	[BurstCompile]
	private unsafe static void AJKAHJICPCJ([NoAlias] float3* NPPMLCCFJHO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A81730", Offset = "0x6A7FD30", VA = "0x186A81730")]
	[BurstCompile]
	private unsafe static void OEBBIJBHMAE([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A821A0", Offset = "0x6A807A0", VA = "0x186A821A0")]
	[BurstCompile]
	private unsafe static void PLANCEGABHD([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D360", Offset = "0x6A7B960", VA = "0x186A7D360")]
	[BurstCompile]
	private unsafe static void CKICLEBBMFG([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D950", Offset = "0x6A7BF50", VA = "0x186A7D950")]
	private void DBPJFCFFFLG(NativeArray<float2> DELLODABDIL, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D700", Offset = "0x6A7BD00", VA = "0x186A7D700")]
	[BurstCompile]
	private unsafe static void DBPJFCFFFLG([NoAlias] ushort* PFCMCLPDAJP, [Out] float2 NEOPGCOAOOB, [Out] float2 PLMJACIOEKG, [In][NoAlias] float2* DELLODABDIL, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EC00", Offset = "0x6A7D200", VA = "0x186A7EC00")]
	[BurstCompile]
	private static void GCHMJFHDKCL([Out] float2 AJKKABOCBKA, ushort PENLEJDLINN, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F710", Offset = "0x6A7DD10", VA = "0x186A7F710")]
	private void IDEKFKGDMDO(NativeArray<float2> PFCMCLPDAJP, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F690", Offset = "0x6A7DC90", VA = "0x186A7F690")]
	[BurstCompile]
	private unsafe static void IDEKFKGDMDO([NoAlias] float2* PFCMCLPDAJP, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DB30", Offset = "0x6A7C130", VA = "0x186A7DB30")]
	[BurstCompile]
	private unsafe static void DJNMBCMCGNJ([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A81F60", Offset = "0x6A80560", VA = "0x186A81F60")]
	[BurstCompile]
	private unsafe static void PDLJKABJOCO([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A80010", Offset = "0x6A7E610", VA = "0x186A80010")]
	[BurstCompile]
	private unsafe static void JLNCOLGKDHM([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A812A0", Offset = "0x6A7F8A0", VA = "0x186A812A0")]
	private void NFHIMBGFEDG(NativeArray<float4> LEFDIIKCJEG, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A81220", Offset = "0x6A7F820", VA = "0x186A81220")]
	[BurstCompile]
	private unsafe static void NFHIMBGFEDG([NoAlias] ushort* OPMMIFOGHHK, [In][NoAlias] float4* LBPBIBIEBKP, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D3D0", Offset = "0x6A7B9D0", VA = "0x186A7D3D0")]
	[BurstCompile]
	private static ushort CKPMHIGCBHB([In] float4 BFGBEMOOEIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E960", Offset = "0x6A7CF60", VA = "0x186A7E960")]
	private void FKJBEGALFDF(NativeArray<float4> OPMMIFOGHHK, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E8F0", Offset = "0x6A7CEF0", VA = "0x186A7E8F0")]
	[BurstCompile]
	private unsafe static void FKJBEGALFDF([NoAlias] float4* OPMMIFOGHHK, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A81490", Offset = "0x6A7FA90", VA = "0x186A81490")]
	[BurstCompile]
	private unsafe static void NMGHDBOGMDB([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A804A0", Offset = "0x6A7EAA0", VA = "0x186A804A0")]
	[BurstCompile]
	private unsafe static void KLGABPAFLDC([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A81C40", Offset = "0x6A80240", VA = "0x186A81C40")]
	[BurstCompile]
	private unsafe static void OPNHPNAFCLC([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E190", Offset = "0x6A7C790", VA = "0x186A7E190")]
	[BurstCompile]
	private static void FEJNGECEPBI([Out] float4 IAFCFGOKEAK, ushort PENLEJDLINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CF00", Offset = "0x6A7B500", VA = "0x186A7CF00")]
	private void CAELMEAPOMJ(Allocator KOIILCBLJPK, NativeArray<float4> FPIBGAAAJGA, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CCB0", Offset = "0x6A7B2B0", VA = "0x186A7CCB0")]
	[BurstCompile]
	private unsafe static void CAELMEAPOMJ([NoAlias] float4* BACHJFJMMGB, [NoAlias] byte* JPDHJBFBKLB, [Out] int KMJEPNCCHFK, [Out] int IIBBLIKNCGC, [NoAlias] float4* FPIBGAAAJGA, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A802A0", Offset = "0x6A7E8A0", VA = "0x186A802A0")]
	private static void KCLAHMJPHGJ(NativeArray<float4> EHIANJCIDOO, NativeArray<BOFELBKOLMD> AIIHNAJANNH, NativeArray<byte> AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A803B0", Offset = "0x6A7E9B0", VA = "0x186A803B0")]
	[BurstCompile]
	private unsafe static void KCLAHMJPHGJ([NoAlias] float4* EHIANJCIDOO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D2E0", Offset = "0x6A7B8E0", VA = "0x186A7D2E0")]
	[BurstCompile]
	private unsafe static void CJDAJCOHEOO([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A81990", Offset = "0x6A7FF90", VA = "0x186A81990")]
	[BurstCompile]
	private unsafe static void OHFCPMBGHBM([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EEE0", Offset = "0x6A7D4E0", VA = "0x186A7EEE0")]
	[BurstCompile]
	private unsafe static void HBNHBNBACKO([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A80820", Offset = "0x6A7EE20", VA = "0x186A80820")]
	private void LHLMJPPPAAH(Allocator KOIILCBLJPK, NativeArray<int> FKKFAIHCCDF, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D420", Offset = "0x6A7BA20", VA = "0x186A7D420")]
	private static NativeArray<byte> DAFPFCBFBCD(Allocator KOIILCBLJPK, NativeArray<int> FKKFAIHCCDF, int JEHCCHCOEGB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D690", Offset = "0x6A7BC90", VA = "0x186A7D690")]
	[BurstCompile]
	private unsafe static int DAFPFCBFBCD([NoAlias] byte* AMEKBPDAGOH, [In][NoAlias] int* FKKFAIHCCDF, int JEHCCHCOEGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A80600", Offset = "0x6A7EC00", VA = "0x186A80600")]
	private static void KOLJFLECAMG(NativeArray<int> CHKOKDDMIDB, NativeArray<byte> KAOFIKJKJPO, int PHNKJDLMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A80590", Offset = "0x6A7EB90", VA = "0x186A80590")]
	[BurstCompile]
	private unsafe static void KOLJFLECAMG([NoAlias] int* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A80430", Offset = "0x6A7EA30", VA = "0x186A80430")]
	[BurstCompile]
	private unsafe static void KGMINJAICLD([NoAlias] ushort* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A81100", Offset = "0x6A7F700", VA = "0x186A81100")]
	[BurstCompile]
	private static void NADLIHAOJPJ([Out] float3 AJKKABOCBKA, ushort PENLEJDLINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A80090", Offset = "0x6A7E690", VA = "0x186A80090")]
	[BurstCompile]
	private static ushort JMOBJIKMIAC([In] float3 BFGBEMOOEIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public OFOAFDPCCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A66240", Offset = "0x6A64840", VA = "0x186A66240")]
	[BurstCompile]
	public unsafe static void GJAKJJHAGDJ([NoAlias] float3* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CAF0", Offset = "0x6A7B0F0", VA = "0x186A7CAF0")]
	[BurstCompile]
	public unsafe static void BFJKBMBBLJE([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C360", Offset = "0x6A7A960", VA = "0x186A7C360")]
	[BurstCompile]
	public unsafe static void ANLEEAPLNGC([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EF60", Offset = "0x6A7D560", VA = "0x186A7EF60")]
	[BurstCompile]
	public unsafe static void HIIHOAAOIMF([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* EGODGDEDJFA, int KJLIFFOOJEF, [In] float3 AELJBCGDCLJ, [In] float3 ACDPCGOLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A66E20", Offset = "0x6A65420", VA = "0x186A66E20")]
	[BurstCompile]
	public unsafe static void LKLNALODIEG([NoAlias] ushort* HNEGHPJHCEO, [Out] float3 DODJJANLEDN, [Out] float3 ACDPCGOLIBH, [In][NoAlias] float3* EGODGDEDJFA, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A66490", Offset = "0x6A64A90", VA = "0x186A66490")]
	[BurstCompile]
	public unsafe static void ICIGMGNEALN([NoAlias] ushort* MIOBEICGPEI, [In][NoAlias] float3* CFGEHJLPKDL, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DE90", Offset = "0x6A7C490", VA = "0x186A7DE90")]
	[BurstCompile]
	public unsafe static void EEGMJMOILMD([NoAlias] float3* NPPMLCCFJHO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A66000", Offset = "0x6A64600", VA = "0x186A66000")]
	[BurstCompile]
	public unsafe static void CNBIHFHBFCK([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A81CB0", Offset = "0x6A802B0", VA = "0x186A81CB0")]
	[BurstCompile]
	public unsafe static void PANECDEHHHC([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A80900", Offset = "0x6A7EF00", VA = "0x186A80900")]
	[BurstCompile]
	public unsafe static void LIFBDMONEAM([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* CFGEHJLPKDL, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A668B0", Offset = "0x6A64EB0", VA = "0x186A668B0")]
	[BurstCompile]
	public unsafe static void KJNOFLMDAEG([NoAlias] ushort* PFCMCLPDAJP, [Out] float2 NEOPGCOAOOB, [Out] float2 PLMJACIOEKG, [In][NoAlias] float2* DELLODABDIL, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A81A10", Offset = "0x6A80010", VA = "0x186A81A10")]
	[BurstCompile]
	public static void OJJCPFKKDAC([Out] float2 AJKKABOCBKA, ushort PENLEJDLINN, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A80E40", Offset = "0x6A7F440", VA = "0x186A80E40")]
	[BurstCompile]
	public unsafe static void MMJADJENHCF([NoAlias] float2* PFCMCLPDAJP, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A80730", Offset = "0x6A7ED30", VA = "0x186A80730")]
	[BurstCompile]
	public unsafe static void LGIOEELPCFM([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F990", Offset = "0x6A7DF90", VA = "0x186A7F990")]
	[BurstCompile]
	public unsafe static void IJLCAFLJLNB([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A80F20", Offset = "0x6A7F520", VA = "0x186A80F20")]
	[BurstCompile]
	public unsafe static void MMPCFLNHMCI([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [NoAlias] ushort* DELLODABDIL, int KJLIFFOOJEF, [In] float2 CAGPHMHMDDO, [In] float2 PLMJACIOEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A80DA0", Offset = "0x6A7F3A0", VA = "0x186A80DA0")]
	[BurstCompile]
	public unsafe static void MGDNDELFONB([NoAlias] ushort* OPMMIFOGHHK, [In][NoAlias] float4* LBPBIBIEBKP, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A806D0", Offset = "0x6A7ECD0", VA = "0x186A806D0")]
	[BurstCompile]
	public static ushort LANPMFNIBKA([In] float4 BFGBEMOOEIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EE40", Offset = "0x6A7D440", VA = "0x186A7EE40")]
	[BurstCompile]
	public unsafe static void GPIICNNECLO([NoAlias] float4* OPMMIFOGHHK, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A66B70", Offset = "0x6A65170", VA = "0x186A66B70")]
	[BurstCompile]
	public unsafe static void LFAJLGEHDOJ([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E1F0", Offset = "0x6A7C7F0", VA = "0x186A7E1F0")]
	[BurstCompile]
	public unsafe static void FFPDCEJPBHE([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DA20", Offset = "0x6A7C020", VA = "0x186A7DA20")]
	[BurstCompile]
	public unsafe static void DDJKFMIDLNP([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] ushort* LEFDIIKCJEG, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A81160", Offset = "0x6A7F760", VA = "0x186A81160")]
	[BurstCompile]
	public static void NDKOIOJCAAE([Out] float4 IAFCFGOKEAK, ushort PENLEJDLINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A666F0", Offset = "0x6A64CF0", VA = "0x186A666F0")]
	[BurstCompile]
	public unsafe static void JGNPFEPCMLC([NoAlias] float4* BACHJFJMMGB, [NoAlias] byte* JPDHJBFBKLB, [Out] int KMJEPNCCHFK, [Out] int IIBBLIKNCGC, [NoAlias] float4* FPIBGAAAJGA, int DCNDPIDGONB, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A80BF0", Offset = "0x6A7F1F0", VA = "0x186A80BF0")]
	[BurstCompile]
	public unsafe static void LMJEJFJOLDN([NoAlias] float4* EHIANJCIDOO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A81A60", Offset = "0x6A80060", VA = "0x186A81A60")]
	[BurstCompile]
	public unsafe static void OKPNMBENKII([NoAlias] OMKOMDIKKEA.JDJFJDJPHJK* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C180", Offset = "0x6A7A780", VA = "0x186A7C180")]
	[BurstCompile]
	public unsafe static void ALDLADNKGDP([NoAlias] OMKOMDIKKEA.NCGJDDHLFLA* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A80A10", Offset = "0x6A7F010", VA = "0x186A80A10")]
	[BurstCompile]
	public unsafe static void LJEFDFIMNBI([NoAlias] OMKOMDIKKEA.FHLLIGBHDCH* HNEGHPJHCEO, [In][NoAlias] BOFELBKOLMD* AIIHNAJANNH, [In][NoAlias] byte* AJLHJBBMHJH, int KJLIFFOOJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A81390", Offset = "0x6A7F990", VA = "0x186A81390")]
	[BurstCompile]
	public unsafe static int NJEPHOCMPJE([NoAlias] byte* AMEKBPDAGOH, [In][NoAlias] int* FKKFAIHCCDF, int JEHCCHCOEGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EB60", Offset = "0x6A7D160", VA = "0x186A7EB60")]
	[BurstCompile]
	public unsafe static void FPHPGLGLAEP([NoAlias] int* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A81FE0", Offset = "0x6A805E0", VA = "0x186A81FE0")]
	[BurstCompile]
	public unsafe static void PFMIMAPHIFP([NoAlias] ushort* CHKOKDDMIDB, [In][NoAlias] byte* KAOFIKJKJPO, int PHNKJDLMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EC80", Offset = "0x6A7D280", VA = "0x186A7EC80")]
	[BurstCompile]
	public static void GEKLPDJNOCJ([Out] float3 AJKKABOCBKA, ushort PENLEJDLINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A65E40", Offset = "0x6A64440", VA = "0x186A65E40")]
	[BurstCompile]
	public static ushort CACOIALDILJ([In] float3 BFGBEMOOEIA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct ICNOFGMAJGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 MLKNMOMOHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 JCJMLJKLEPH;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KOHIMKLADPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<ICNOFGMAJGL> NPKKDEMFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> AODLEMOIOIF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x86E900", Offset = "0x86CF00", VA = "0x18086E900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A78040", Offset = "0x6A76640", VA = "0x186A78040")]
	public KOHIMKLADPA(int KPGHDFKJEPO, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A77F00", Offset = "0x6A76500", VA = "0x186A77F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A77F60", Offset = "0x6A76560", VA = "0x186A77F60")]
	public void LOAJHLPEHFH(KOHIMKLADPA FHKHILCJKNO, int IHBNDOOCKIJ, int CMKHMGALFJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FHEIGEAMDKL
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static KOHIMKLADPA MFGJLILCEPG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<GAKBIENKEJE> MAOONFGFJBE;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] KNEFDCDCPHG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool KLOCDCHHMHN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, KOHIMKLADPA> CHJJKECCIPO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, KOHIMKLADPA> CBGFMFDALCI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool NIDJNNIDHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FC90", Offset = "0x6A6E290", VA = "0x186A6FC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<GAKBIENKEJE> AOPDIBDPKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EE20", Offset = "0x6A6D420", VA = "0x186A6EE20")]
		get
		{
			return default(NativeList<GAKBIENKEJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static KOHIMKLADPA KOBAGCPHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EC80", Offset = "0x6A6D280", VA = "0x186A6EC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EEE0", Offset = "0x6A6D4E0", VA = "0x186A6EEE0")]
	private static void FPPKLIHHGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FE50", Offset = "0x6A6E450", VA = "0x186A6FE50")]
	public static int PNLDKPCKDBJ(bool FABEGALJIPC, int MBDKGIBEHIG, bool JMDKDBHGCMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F540", Offset = "0x6A6DB40", VA = "0x186A6F540")]
	private static int JAPFNAPIONK(int MBDKGIBEHIG, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EE10", Offset = "0x6A6D410", VA = "0x186A6EE10")]
	private static int EBKOLEFNECA(int MBDKGIBEHIG, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FDC0", Offset = "0x6A6E3C0", VA = "0x186A6FDC0")]
	public static int PEFPDHDBAJF(int HEPMKAJPNDG, int MBDKGIBEHIG, int PGPPHPOHPPK, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F7F0", Offset = "0x6A6DDF0", VA = "0x186A6F7F0")]
	public static int LKHEIOMFAOK(int HEPMKAJPNDG, int MBDKGIBEHIG, int PGPPHPOHPPK, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EC70", Offset = "0x6A6D270", VA = "0x186A6EC70")]
	public static int CDLELCGMDCF(int PGPPHPOHPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F530", Offset = "0x6A6DB30", VA = "0x186A6F530")]
	private static int IHJGKKDHOIC(int MBDKGIBEHIG, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EEC0", Offset = "0x6A6D4C0", VA = "0x186A6EEC0")]
	private static int FOGFHBPNNNF(int MBDKGIBEHIG, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EB10", Offset = "0x6A6D110", VA = "0x186A6EB10")]
	public static int ANPJAOBMCOJ(int HEPMKAJPNDG, int MBDKGIBEHIG, int PGPPHPOHPPK, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FD10", Offset = "0x6A6E310", VA = "0x186A6FD10")]
	public static int NEEMBBIFKKN(int HEPMKAJPNDG, int MBDKGIBEHIG, int PGPPHPOHPPK, bool ICEKMGIOJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FDA0", Offset = "0x6A6E3A0", VA = "0x186A6FDA0")]
	public static int NMMDMFEEMDI(int PGPPHPOHPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EB80", Offset = "0x6A6D180", VA = "0x186A6EB80")]
	public static KOHIMKLADPA BEBGPFGMNAK(int MBDKGIBEHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F560", Offset = "0x6A6DB60", VA = "0x186A6F560")]
	private static KOHIMKLADPA KNDGDDKMJCE(int MBDKGIBEHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6ED20", Offset = "0x6A6D320", VA = "0x186A6ED20")]
	public static KOHIMKLADPA DKMFCNIPDGO(int MBDKGIBEHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E7D0", Offset = "0x6A6CDD0", VA = "0x186A6E7D0")]
	private static KOHIMKLADPA AFEIDKAOAMD(int MBDKGIBEHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F880", Offset = "0x6A6DE80", VA = "0x186A6F880")]
	public static void MBDDKAFGCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct FEKJLCDDAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int NPJGCMPNHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 BEGKNFGIAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion OMFCMEMKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float FIAELHFMNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float NJCGBCEKLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int JOEAPFOLGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int MPMBBOKEEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int PCKMCPFOFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool HFAKNLDPEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool MJECCGDKEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float JPFBFIPPKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 OFOLEKMDDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool FACPMEDGJCK;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct NEOOCPNPFME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int FDNJPOAMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int EBLIMJPILKO;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ILEDHHPLJDK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<FEKJLCDDAHK> KLLMGLBBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<CPDENJNCAAG> OBPFGDGLOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<GAKBIENKEJE> BEKIHAALEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<NEOOCPNPFME> NECNFIPHKBN;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A75440", Offset = "0x6A73A40", VA = "0x186A75440")]
	public ILEDHHPLJDK(NativeArray<CPDENJNCAAG> OBPFGDGLOEC, int LPKLLJKOBNO = 1, Allocator KOIILCBLJPK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A75350", Offset = "0x6A73950", VA = "0x186A75350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct ECGIIAOMGOA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<ICNOFGMAJGL> KAMOJNHDBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> KGMHKAILHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<GAKBIENKEJE> KIEEHIDLNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<FEKJLCDDAHK> KLLMGLBBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<CPDENJNCAAG> OBPFGDGLOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<GAKBIENKEJE> BEKIHAALEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<NEOOCPNPFME> NECNFIPHKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int IHIBKOMEKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int CDMOMPCBGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 FDIDMKHOKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion LGCJFIEAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 FIOAKLEMJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OJAFFIMLEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> AMGOENAPMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IPMODJBPCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NHBBLDPMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> HMGJHPDACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EBOPKALJHOO;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C8F0", Offset = "0x6A6AEF0", VA = "0x186A6C8F0")]
	public ECGIIAOMGOA(HEAFCDEBBOK NHGDLKPMJCE, OMKOMDIKKEA NAMEJACELDK, float3 KKFNFBAFNIF, quaternion FILIIGJPBJG, float PLGAEBIDPGP, int LIPEPEKOINC = 0, int HHJHMBOIDLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A6CB80", Offset = "0x6A6B180", VA = "0x186A6CB80")]
	public ECGIIAOMGOA(ILEDHHPLJDK NHGDLKPMJCE, OMKOMDIKKEA NAMEJACELDK, float3 KKFNFBAFNIF, quaternion FILIIGJPBJG, float3 PLGAEBIDPGP, int LIPEPEKOINC = 0, int HHJHMBOIDLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BB10", Offset = "0x6A6A110", VA = "0x186A6BB10")]
	private float3 KOKIPEECDHG(float3 NFPAPJHNCPC, Matrix4x4 OOEOPKIFJKB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BC40", Offset = "0x6A6A240", VA = "0x186A6BC40")]
	private float3x3 LBMLBPJPJFF(float3x3 LHGHNJOBCFK, float3x3 EEILOFBDLOI)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C770", Offset = "0x6A6AD70", VA = "0x186A6C770")]
	private float NINCCDLAJDL(float ICLEOPHCOMM, float CGANDHIMBMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A970", Offset = "0x6A68F70", VA = "0x186A6A970", Slot = "4")]
	public void Execute(int EAHBLIIOOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C780", Offset = "0x6A6AD80", VA = "0x186A6C780")]
	private void POLNNIBCEFN(int NNIOAJBECDP, float3 MCPNOOFMAHG, float3 MHHLIPGJMOK, float3 PDEEPPMIHOL, float PKDKCKJPOHP, bool PDNPHFJBPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BCC0", Offset = "0x6A6A2C0", VA = "0x186A6BCC0")]
	private void MFDBBBDCDJH(FEKJLCDDAHK JNAACMPLJHG, float3 KIPJBGAHLFJ, float3x3 HPAIEAFGHDJ, float ICLEOPHCOMM, int KGKLIILPCKN, int DLAMJGDAILP, int JLCFMKKEBCM, float EIHDOFLFOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C120", Offset = "0x6A6A720", VA = "0x186A6C120")]
	private void MOLDFPPLOGC(int NNIOAJBECDP, int MBOAMBPHGJB, FEKJLCDDAHK JNAACMPLJHG, float3 KIPJBGAHLFJ, float3x3 HPAIEAFGHDJ, bool DGLNGMGCEAP, float ICLEOPHCOMM, int MABHDMKNDKD, int BHKGICEKHCN, int JLCFMKKEBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct LHDDFFBHCJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<INMGEFAEGAI> AEJGKFEHLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<GAKBIENKEJE> ELLEPDAPBDN;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A79040", Offset = "0x6A77640", VA = "0x186A79040")]
	public LHDDFFBHCJI(int LPKLLJKOBNO, Allocator KOIILCBLJPK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6A78FA0", Offset = "0x6A775A0", VA = "0x186A78FA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct KJLGDNHJAHG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum DMDPMEBKAPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<float3> CKCCKMBCFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> LFJMBLOCAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> KMMNGJINLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> FGNFHAHHHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> JPFAMHNCLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> FEANFIABNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> NIODGDBNOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> GHPKEMNKPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<GAKBIENKEJE> LDIGLFPIEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<INMGEFAEGAI> AEJGKFEHLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<GAKBIENKEJE> ELLEPDAPBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int IHIBKOMEKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int CDMOMPCBGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OJAFFIMLEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> AMGOENAPMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IPMODJBPCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NHBBLDPMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> HMGJHPDACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EBOPKALJHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 FIOAKLEMJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion LGCJFIEAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 FDIDMKHOKKF;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A77510", Offset = "0x6A75B10", VA = "0x186A77510")]
	public KJLGDNHJAHG(HEAFCDEBBOK NHGDLKPMJCE, OMKOMDIKKEA NAMEJACELDK, float3 KKFNFBAFNIF, quaternion FILIIGJPBJG, float PLGAEBIDPGP, int LIPEPEKOINC = 0, int HHJHMBOIDLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A77700", Offset = "0x6A75D00", VA = "0x186A77700")]
	public KJLGDNHJAHG(LHDDFFBHCJI MMDLBEBNCGC, OMKOMDIKKEA NAMEJACELDK, float3 KKFNFBAFNIF, quaternion FILIIGJPBJG, float3 PLGAEBIDPGP, int LIPEPEKOINC = 0, int HHJHMBOIDLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A761B0", Offset = "0x6A747B0", VA = "0x186A761B0", Slot = "4")]
	public void Execute(int EAHBLIIOOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A77110", Offset = "0x6A75710", VA = "0x186A77110")]
	private void JIFJFEAPMPB(float4x4 PNFNIMBCPGN, int EAHBLIIOOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A76140", Offset = "0x6A74740", VA = "0x186A76140")]
	private DMDPMEBKAPH EEMAHNDCEJA(float3 MHHLIPGJMOK)
	{
		return default(DMDPMEBKAPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A774C0", Offset = "0x6A75AC0", VA = "0x186A774C0")]
	private float4 LJMPDMFKBDP(DMDPMEBKAPH MGNEPOPEPLN, int PDMMEDBMFPP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A76100", Offset = "0x6A74700", VA = "0x186A76100")]
	private float2 DLHBBEMJPIN(DMDPMEBKAPH MGNEPOPEPLN, float3 MCPNOOFMAHG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct IJHLPEHFBCN
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum OIENOBOADOO
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static IJHLPEHFBCN CHPFPNHMMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 GJMAELHLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 FODPGOBPIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 FPMEMCFLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public OIENOBOADOO LADEKBPIHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 DAAFMPJNNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 PGNEDAHKLBO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IPGIKMPLLND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A74200", Offset = "0x6A72800", VA = "0x186A74200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 AKJBDIOFCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A74A40", Offset = "0x6A73040", VA = "0x186A74A40")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A74B90", Offset = "0x6A73190", VA = "0x186A74B90")]
	public IJHLPEHFBCN(float3 MCPNOOFMAHG, quaternion GLKHDAMNPBA, float3 LPKLLJKOBNO, OIENOBOADOO GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A74690", Offset = "0x6A72C90", VA = "0x186A74690")]
	public float PDPFHFEBMBN(float3 KIPJBGAHLFJ, float PDGFLBOKJPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A74310", Offset = "0x6A72910", VA = "0x186A74310")]
	public bool KJNPGIKLPND(float3 MHHLIPGJMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A74890", Offset = "0x6A72E90", VA = "0x186A74890")]
	public void PKOLJOMFJNP(float3 DHCCAPKIIED, float3x3 NCMOCOPGPEN, float JIPPDKNBKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A74210", Offset = "0x6A72810", VA = "0x186A74210")]
	private void DIPMKIIGFFC(float3 PKGGNLMKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A74400", Offset = "0x6A72A00", VA = "0x186A74400")]
	public void PAAIIILEIKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct AHLLNFBMJGD : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<IJHLPEHFBCN> MMDLBEBNCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> JOBFACGCDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> FLNOIJGKJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BDJLDKIDCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<GAKBIENKEJE> ELLEPDAPBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int HJEPBNGKBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int KIPELOEBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float PDGFLBOKJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float ILDJBCAJHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MFGBBEENLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GCHBPOJMDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NPIHKOMDIJN;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A68B70", Offset = "0x6A67170", VA = "0x186A68B70")]
	public AHLLNFBMJGD(OMKOMDIKKEA CKFPIMAMAKM, float GAMHOAHCHNP, int CMKHMGALFJE, int KGKLIILPCKN, NativeList<IJHLPEHFBCN> MMDLBEBNCGC, NativeArray<int> BDJLDKIDCKE, NativeList<GAKBIENKEJE> ELLEPDAPBDN, EGJMPJNCICF PKKNCHDHLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A680D0", Offset = "0x6A666D0", VA = "0x186A680D0", Slot = "4")]
	public void Execute(int ALGAELGMCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A68810", Offset = "0x6A66E10", VA = "0x186A68810")]
	private bool HJEOPCPODKL(IJHLPEHFBCN KHKPJFABMKM, IJHLPEHFBCN CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A688D0", Offset = "0x6A66ED0", VA = "0x186A688D0")]
	private bool OHFIKGJIGNJ(IJHLPEHFBCN NLNPOEKBPGG, int COAGCMINMBE, int DNNEHOBKDJG, int OCKAOKEOFLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EGJMPJNCICF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> OJHEKJKDHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> FDNIHPPIMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> HNPBBBFMBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> KDKHGBNOLDE;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D540", Offset = "0x6A6BB40", VA = "0x186A6D540")]
	public void FMOJIDBMNCN(int KPGHDFKJEPO, int IEKNLKKGAIM, Allocator KOIILCBLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D340", Offset = "0x6A6B940", VA = "0x186A6D340")]
	public static long DEEGEGDBHLA(int KPGHDFKJEPO, int IEKNLKKGAIM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D360", Offset = "0x6A6B960", VA = "0x186A6D360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D450", Offset = "0x6A6BA50", VA = "0x186A6D450")]
	public void EKANILNIIHI(JobHandle KDEMNIPNNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public EGJMPJNCICF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct MIPEEBOBLMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> JOBFACGCDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> GLFJMEKNHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> BMHCDJEMBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> HBNAPPOFLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> FLNOIJGKJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BICNKLEFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> BBIEOCPEHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> MFGBBEENLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> GCHBPOJMDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int LIPEPEKOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int HHJHMBOIDLG;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A230", Offset = "0x6A78830", VA = "0x186A7A230")]
	public MIPEEBOBLMD(OMKOMDIKKEA CKFPIMAMAKM, EGJMPJNCICF PKKNCHDHLJM, int HHJHMBOIDLG = 0, int LIPEPEKOINC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A79DF0", Offset = "0x6A783F0", VA = "0x186A79DF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A1D0", Offset = "0x6A787D0", VA = "0x186A7A1D0")]
	private void IBPPBKGCNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DBFNOAFLMGB
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x29E4150", Offset = "0x29E2750", VA = "0x1829E4150")]
	public static bool JADPIIKGMCH<T>(NativeArray<T> FAJBEEIFFCK, int LPKLLJKOBNO, Allocator KOIILCBLJPK, NativeArrayOptions EFDCDFNAODA = NativeArrayOptions.ClearMemory, int JBFPBNOJBLC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x29E4210", Offset = "0x29E2810", VA = "0x1829E4210")]
	public static bool JADPIIKGMCH<T>(NativeList<T> DEPHDEBCNCK, int LPKLLJKOBNO, Allocator KOIILCBLJPK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum FBANJHDKKJI
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface IGGMCOMIHMK
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CNBPJBALINA(FBANJHDKKJI HEPMKAJPNDG);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IIAIHJCEFGF(FBANJHDKKJI HEPMKAJPNDG);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds BFNPFABLBEC();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float FIIIGANAIOH();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHJIMEDJMNL(FBANJHDKKJI HEPMKAJPNDG, HEAFCDEBBOK MLDFLCHLFPO, int JMOEGHALLJA = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class OMKOMDIKKEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum INHFGGCOFCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		NormTanF16MatUi8,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct ECLDNJMGLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public INHFGGCOFCH MLEOMJOOIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool PILONHKKCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int PEOMNPDAFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] MFENAHILALC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct JMECHOANJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 MCPNOOFMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 MHHLIPGJMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 PDEEPPMIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 JEAFHOAOADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 BMHCDJEMBDP;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] MFENAHILALC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct JDJFJDJPHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 MCPNOOFMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 MHHLIPGJMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 PDEEPPMIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 JEAFHOAOADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 BMHCDJEMBDP;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] MFENAHILALC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct IAAKFGEGDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 MCPNOOFMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 MHHLIPGJMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 PDEEPPMIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 JEAFHOAOADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint BMHCDJEMBDP;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] MFENAHILALC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct NCGJDDHLFLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 MCPNOOFMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint MHHLIPGJMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint PDEEPPMIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 JEAFHOAOADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 BMHCDJEMBDP;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] MFENAHILALC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct FHLLIGBHDCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 MCPNOOFMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint MHHLIPGJMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint PDEEPPMIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 JEAFHOAOADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 BMHCDJEMBDP;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] MFENAHILALC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int IBGIGMAFJCC(float OCPDJIJPMCG);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class AKGDADDOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A84E60", Offset = "0x6A83460", VA = "0x186A84E60")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A84F90", Offset = "0x6A83590", VA = "0x186A84F90")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A84B40", Offset = "0x6A83140", VA = "0x186A84B40")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A84BF0", Offset = "0x6A831F0", VA = "0x186A84BF0")]
		public static int DKJHOBNJMII(float OCPDJIJPMCG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint KEDFOGOAILI([In] float4 HAHPKMHGFDD);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class KDGNOIHNAAD
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A92510", Offset = "0x6A90B10", VA = "0x186A92510")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A92640", Offset = "0x6A90C40", VA = "0x186A92640")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A92120", Offset = "0x6A90720", VA = "0x186A92120")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A921D0", Offset = "0x6A907D0", VA = "0x186A921D0")]
		public static uint DKJHOBNJMII([In] float4 HAHPKMHGFDD)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint DGHPKIKPINB([In] float3 HAHPKMHGFDD);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class BBGFLMMAEHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6A85420", Offset = "0x6A83A20", VA = "0x186A85420")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6A85550", Offset = "0x6A83B50", VA = "0x186A85550")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6A850F0", Offset = "0x6A836F0", VA = "0x186A850F0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6A851A0", Offset = "0x6A837A0", VA = "0x186A851A0")]
		public static uint DKJHOBNJMII([In] float3 HAHPKMHGFDD)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void CCPHLMKGMGO([NoAlias] NCGJDDHLFLA* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class BOEBMFOGHJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6A859A0", Offset = "0x6A83FA0", VA = "0x186A859A0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6A85AD0", Offset = "0x6A840D0", VA = "0x186A85AD0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6A856B0", Offset = "0x6A83CB0", VA = "0x186A856B0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6A85760", Offset = "0x6A83D60", VA = "0x186A85760")]
		public unsafe static void DKJHOBNJMII([NoAlias] NCGJDDHLFLA* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void DJFOELBGGGK([NoAlias] FHLLIGBHDCH* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class CEAELEGPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6A860B0", Offset = "0x6A846B0", VA = "0x186A860B0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6A861E0", Offset = "0x6A847E0", VA = "0x186A861E0")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6A85DC0", Offset = "0x6A843C0", VA = "0x186A85DC0")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6A85E70", Offset = "0x6A84470", VA = "0x186A85E70")]
		public unsafe static void DKJHOBNJMII([NoAlias] FHLLIGBHDCH* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int PPELGOJCJIG = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> FLPCELBAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> IFCDOHNCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> KHGAJFONIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> EKKJEHPOKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> KJGMJKMAMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> JMDHNHGDBOF;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] HCCBEONBFHA;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool FKFCOPHKIEA;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static ECLDNJMGLAA[] CMHHDNKMANP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HIFFGJEKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A96150", Offset = "0x6A94750", VA = "0x186A96150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A970E0", Offset = "0x6A956E0", VA = "0x186A970E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A98A50", Offset = "0x6A97050", VA = "0x186A98A50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OCBHAJPOPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A690", Offset = "0x6A98C90", VA = "0x186A9A690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void MIGDCHAEACO(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC, string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A97120", Offset = "0x6A95720", VA = "0x186A97120", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A97B30", Offset = "0x6A96130", VA = "0x186A97B30")]
	public void FMOJIDBMNCN(int KPGHDFKJEPO, int IEKNLKKGAIM, Allocator KOIILCBLJPK, bool FGHHPJFLHJD, bool BKMPIBDHEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A989D0", Offset = "0x6A96FD0", VA = "0x186A989D0")]
	public void INCLMFHNBAM(int KPGHDFKJEPO, int IEKNLKKGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A95610", Offset = "0x6A93C10", VA = "0x186A95610", Slot = "6")]
	public bool AAJPOKDGAKL(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A96C10", Offset = "0x6A95210", VA = "0x186A96C10")]
	public bool BOILBEHCKNM(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A99630", Offset = "0x6A97C30", VA = "0x186A99630")]
	public bool LGIOGMMNLDO(Mesh CKFPIMAMAKM, OMKOMDIKKEA NEGKOJIFKHJ, bool JPGJMPOIMAO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A98A90", Offset = "0x6A97090", VA = "0x186A98A90")]
	public void JLBHOCOHEBH(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A96190", Offset = "0x6A94790", VA = "0x186A96190")]
	public void BJLFHMPKFEA(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A97040", Offset = "0x6A95640", VA = "0x186A97040")]
	[BurstCompile]
	public static int CBCIBFPAGIG(float OCPDJIJPMCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A97090", Offset = "0x6A95690", VA = "0x186A97090")]
	[BurstCompile]
	public static uint CBCIBFPAGIG([In] float4 HAHPKMHGFDD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A96FF0", Offset = "0x6A955F0", VA = "0x186A96FF0")]
	[BurstCompile]
	public static uint CBCIBFPAGIG([In] float3 HAHPKMHGFDD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A95620", Offset = "0x6A93C20", VA = "0x186A95620")]
	public void ADIMOGGDHLL(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A973A0", Offset = "0x6A959A0", VA = "0x186A973A0")]
	[BurstCompile]
	private unsafe static void ELOJALPNAFO([NoAlias] NCGJDDHLFLA* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A97420", Offset = "0x6A95A20", VA = "0x186A97420")]
	public void FKFDNGJBDHP(Mesh CKFPIMAMAKM, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A97320", Offset = "0x6A95920", VA = "0x186A97320")]
	[BurstCompile]
	private unsafe static void EIKIBKAFKNH([NoAlias] FHLLIGBHDCH* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A97230", Offset = "0x6A95830", VA = "0x186A97230")]
	public void EIEKAMEENFF(Mesh CKFPIMAMAKM, INHFGGCOFCH MLEOMJOOIIP, bool JPGJMPOIMAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A99C60", Offset = "0x6A98260", VA = "0x186A99C60")]
	public void LOAJHLPEHFH(OMKOMDIKKEA CKFPIMAMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A95C60", Offset = "0x6A94260", VA = "0x186A95C60")]
	public OMKOMDIKKEA AGJCCCHJIOG(Allocator KOIILCBLJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A98060", Offset = "0x6A96660", VA = "0x186A98060")]
	public long HLOJPBFCELG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A98000", Offset = "0x6A96600", VA = "0x186A98000")]
	public static long HLOJPBFCELG(int KDPAPBIDCPP, int AOLMCFECMFB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A99ED0", Offset = "0x6A984D0", VA = "0x186A99ED0")]
	public static long LOOCBGOPPNH(int KDPAPBIDCPP, int AOLMCFECMFB, INHFGGCOFCH MLEOMJOOIIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A99F70", Offset = "0x6A98570", VA = "0x186A99F70")]
	public long LOOCBGOPPNH(INHFGGCOFCH MLEOMJOOIIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A985E0", Offset = "0x6A96BE0", VA = "0x186A985E0")]
	public void IBAACJOHGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A98640", Offset = "0x6A96C40", VA = "0x186A98640")]
	public static void IHANBDLHNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A030", Offset = "0x6A98630", VA = "0x186A9A030")]
	public INHFGGCOFCH NAMPDBOFKMA()
	{
		return default(INHFGGCOFCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A97A60", Offset = "0x6A96060", VA = "0x186A97A60")]
	public static (int, int) FMKHJBCJIFA(Mesh CKFPIMAMAKM)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A99550", Offset = "0x6A97B50", VA = "0x186A99550")]
	public static int KPMFCJPIAJN(VertexAttributeDescriptor[] JPPMDKGFFJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A994E0", Offset = "0x6A97AE0", VA = "0x186A994E0")]
	public static long JMGCCCMDNBI(Mesh CKFPIMAMAKM, int OCPBLDIFNLP, int EOLKHGPJEHP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public OMKOMDIKKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A97F60", Offset = "0x6A96560", VA = "0x186A97F60")]
	[BurstCompile]
	public static int GPDGCCHKEEK(float OCPDJIJPMCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A97D20", Offset = "0x6A96320", VA = "0x186A97D20")]
	[BurstCompile]
	public static uint GPDGCCHKEEK([In] float4 HAHPKMHGFDD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A97EB0", Offset = "0x6A964B0", VA = "0x186A97EB0")]
	[BurstCompile]
	public static uint GPDGCCHKEEK([In] float3 HAHPKMHGFDD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A95DA0", Offset = "0x6A943A0", VA = "0x186A95DA0")]
	[BurstCompile]
	public unsafe static void AOFAKJONLBP([NoAlias] NCGJDDHLFLA* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A98190", Offset = "0x6A96790", VA = "0x186A98190")]
	[BurstCompile]
	public unsafe static void HPLAMMFFCJP([NoAlias] FHLLIGBHDCH* HNEGHPJHCEO, int KJLIFFOOJEF, [In][NoAlias] float3* BPNPNNCOAHG, [In][NoAlias] float3* GLFJMEKNHHG, [In][NoAlias] float4* BICNKLEFNGO, [In][NoAlias] float2* HBNAPPOFLFB, [In][NoAlias] float4* BMHCDJEMBDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class MNGCHOPJBIG
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6A92D00", Offset = "0x6A91300", VA = "0x186A92D00")]
	public static void MBDDKAFGCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class HKAPPCKHMBE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> FLPCELBAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> IFCDOHNCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> EOMFFJGIAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> NHMEICCHBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> GGCGHHPJLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> MOLMNBHMFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> BIMOJHCNFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> JMDHNHGDBOF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6A86FB0", Offset = "0x6A855B0", VA = "0x186A86FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int ALMEHFENJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6A87140", Offset = "0x6A85740", VA = "0x186A87140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int ANGPIEAIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6A87100", Offset = "0x6A85700", VA = "0x186A87100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A87CF0", Offset = "0x6A862F0", VA = "0x186A87CF0")]
	public HKAPPCKHMBE(int KPGHDFKJEPO, int IEKNLKKGAIM, int LGGLJPIMLDE, Allocator KOIILCBLJPK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6A87A00", Offset = "0x6A86000", VA = "0x186A87A00")]
	public HKAPPCKHMBE(Mesh CKFPIMAMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6A86FF0", Offset = "0x6A855F0", VA = "0x186A86FF0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6A87180", Offset = "0x6A85780", VA = "0x186A87180")]
	public void LOAJHLPEHFH(HKAPPCKHMBE CKFPIMAMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6A86B20", Offset = "0x6A85120", VA = "0x186A86B20")]
	private void BOIOPDBGCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6A87480", Offset = "0x6A85A80", VA = "0x186A87480")]
	private void ONANIPMFOPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct GAKBIENKEJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int HDJFHLFDEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int DJEJONINPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int CJAJEEAJEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int ALMEHFENJNK;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1432DB0", Offset = "0x14313B0", VA = "0x181432DB0")]
	public GAKBIENKEJE(int KGKLIILPCKN, int KJLIFFOOJEF, int CMKHMGALFJE, int PHNKJDLMLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class EJCCJHONJOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<GAKBIENKEJE> HCDOHBNLNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<GAKBIENKEJE>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD80", Offset = "0x9CE380", VA = "0x1809CFD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HKAPPCKHMBE LOGLHJINEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6A863B0", Offset = "0x6A849B0", VA = "0x186A863B0")]
	public EJCCJHONJOD(IEnumerable<HKAPPCKHMBE> INKJCILNAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6A86340", Offset = "0x6A84940", VA = "0x186A86340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum NMOCELICNOP
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class LMHIGPFCFGE
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> DOCNNNCLJFH;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> GNKNDOONFNC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> HFFJDEJLGPI;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> GJLALIGAJGK;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6A92AD0", Offset = "0x6A910D0", VA = "0x186A92AD0")]
	public static void MBDDKAFGCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6A928B0", Offset = "0x6A90EB0", VA = "0x186A928B0")]
	public static NativeArray<float2> ENIMGHBHDNE(NativeArray<float2> LGJCMKFCPCM, int CMHCJOLNPLA, NativeArray<float2> HKJNDAIMNKC, int PAEGMFBFFNF)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6A929C0", Offset = "0x6A90FC0", VA = "0x186A929C0")]
	public static NativeArray<float3> ICIMMHEBGDA(NativeArray<float3> LGJCMKFCPCM, int CMHCJOLNPLA, NativeArray<float3> HKJNDAIMNKC, int PAEGMFBFFNF)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6A92BF0", Offset = "0x6A911F0", VA = "0x186A92BF0")]
	public static NativeArray<float4> MLFOOMLOKDP(NativeArray<float4> LGJCMKFCPCM, int CMHCJOLNPLA, NativeArray<float4> HKJNDAIMNKC, int PAEGMFBFFNF)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6A927A0", Offset = "0x6A90DA0", VA = "0x186A927A0")]
	public static NativeArray<int> ADCDBNOKGIC(NativeArray<int> LGJCMKFCPCM, int CMHCJOLNPLA, NativeArray<int> HKJNDAIMNKC, int PAEGMFBFFNF)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2C594A0", Offset = "0x2C57AA0", VA = "0x182C594A0")]
	private static void LNGBBECMJNL<T>(NativeArray<T> FAJBEEIFFCK, int LIOCDLMFHHL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2C593C0", Offset = "0x2C579C0", VA = "0x182C593C0")]
	private static void CMEKIDIJIFB<T>(NativeArray<T> LGJCMKFCPCM, int CMHCJOLNPLA, NativeArray<T> HKJNDAIMNKC, int PAEGMFBFFNF, NativeArray<T> DHABKBHIKDD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IAFNPJALNLP
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum FFHFGOPEEEF
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class BPAPBBPGDJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public OFOAFDPCCEM CKFPIMAMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int JHMHPFJNIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int EGGKPKCEMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long ICIBJAPPGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long LPMDEILOJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float IKFNMENGNDB;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6A85C70", Offset = "0x6A84270", VA = "0x186A85C70")]
		public BPAPBBPGDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6A85C30", Offset = "0x6A84230", VA = "0x186A85C30")]
		public void EKANILNIIHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string MMODDFLDIAD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string ICMIJLEOJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker NCNDNMACHOM;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker MLLBOAEJJCP;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker MOLLGHDIJJN;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker HLAMFANPKHA;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker CJOJBIBIOBI;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker FPADILAIJLM;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker DHLIGAEGJJK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker LGOFBMHFLDI;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker KNHKKPLOCPA;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker INCBEDPEJMB;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker BMCLPJKGNOA;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker CNFFKHEENJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<IGGMCOMIHMK> BHDAJGDNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly MOPBPKFEPJN OKKPMMJALBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int KJLIFFOOJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int PHNKJDLMLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool MLMEJKPKOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool LNKAMFPCEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal FFHFGOPEEEF NEIJPCGNELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool DCAHEKMNODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 PLMKFCFADOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 NEPGIBAHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float CCJGILFNDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float DONLJLAEBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int LNLCEFHNCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int DFLDKMIAIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int MADFICPANCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int KADBFBHNIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float OMGEJDFMLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float LJANIGMNCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int BHGFNMIGCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long MPJLFGNEAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long NABHEJINEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long OHKAKDOGMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int OPGHNCGAFBO;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int KDGNCMFPBFO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] DKOHOFACCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] ABKIOMIGDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] BBMKKJFPDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private OMKOMDIKKEA MBODDJJNLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long GIIEFFMCBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long NFEJNOPJEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int JCCLJOAGPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<BPAPBBPGDJL> AHDPKEFFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float CDELGKJOKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal OMKOMDIKKEA.INHFGGCOFCH KFIBHKNEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool PBODNHMNPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NFNLHNENLIO CJMAKMNKPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle PHMNPEJAIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> OGPIKNGLDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool DFGGMBNCMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle EKEOCFEJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private OMKOMDIKKEA GHMAJAPNPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform IEEMJNAAFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private FBANJHDKKJI CPFHFJFFIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long LNPKICOIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long BIKCFBGFHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long LPDJPOCMDJK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh LOGLHJINEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x868280", Offset = "0x866880", VA = "0x180868280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer POFJKDIJFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EAFFBIIFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8F7E40", Offset = "0x8F6440", VA = "0x1808F7E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JKNJJPJBFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8CF960", Offset = "0x8CDF60", VA = "0x1808CF960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6A89600", Offset = "0x6A87C00", VA = "0x186A89600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<IGGMCOMIHMK> GPMLMBLEGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void MIGDCHAEACO(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC, string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F4F0", Offset = "0x6A8DAF0", VA = "0x186A8F4F0")]
	public void KDGHGDPJBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F620", Offset = "0x6A8DC20", VA = "0x186A8F620")]
	private void LOBOKHNOKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6A91AE0", Offset = "0x6A900E0", VA = "0x186A91AE0")]
	public IAFNPJALNLP(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8ABA0", Offset = "0x6A891A0", VA = "0x186A8ABA0")]
	public void EKANILNIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F500", Offset = "0x6A8DB00", VA = "0x186A8F500")]
	public void LADCOHEBKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AEA0", Offset = "0x6A894A0", VA = "0x186A8AEA0")]
	private void FNACBNJJPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6A914E0", Offset = "0x6A8FAE0", VA = "0x186A914E0")]
	public void PAHIHILCCKN(IGGMCOMIHMK JNODLMCJKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FB10", Offset = "0x6A8E110", VA = "0x186A8FB10")]
	public bool MKHNAOJLKFD(IGGMCOMIHMK JNODLMCJKOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F5C0", Offset = "0x6A8DBC0", VA = "0x186A8F5C0")]
	public bool LGJHGFMDMBF(IGGMCOMIHMK JNODLMCJKOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FA60", Offset = "0x6A8E060", VA = "0x186A8FA60", Slot = "4")]
	public virtual void MJINHNFGIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E9D0", Offset = "0x6A8CFD0", VA = "0x186A8E9D0")]
	public void IOLKHHHPIKD(Transform MGFHCPPOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B130", Offset = "0x6A89730", VA = "0x186A8B130")]
	private long GDPKINOJLEC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6A897A0", Offset = "0x6A87DA0", VA = "0x186A897A0")]
	private long EFCDEOKIOFJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D990", Offset = "0x6A8BF90", VA = "0x186A8D990")]
	public bool INPEJJLIFKA(Transform MGFHCPPOOIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A89920", Offset = "0x6A87F20", VA = "0x186A89920")]
	public bool EIINDNBDCIM(bool FKJLACBHBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A89620", Offset = "0x6A87C20", VA = "0x186A89620")]
	public void EBIOANIFCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B210", Offset = "0x6A89810", VA = "0x186A8B210")]
	public bool GPKNNKOJFBM(float4x4 KJGAGCEOPBC, BatchedMeshRenderer CFIDMPNOOGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FBB0", Offset = "0x6A8E1B0", VA = "0x186A8FBB0")]
	public void NDBDKMPGFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6A88170", Offset = "0x6A86770", VA = "0x186A88170")]
	public bool AFFFCFJHCMD(bool FKJLACBHBCE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D980", Offset = "0x6A8BF80", VA = "0x186A8D980")]
	public void IHKLHIOLCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F4C0", Offset = "0x6A8DAC0", VA = "0x186A8F4C0")]
	public void KDEHIHBJEKH(OMKOMDIKKEA CKFPIMAMAKM, int HHCDLAEEJPG, int JKMBFEGPNAN, float MPDLEAHHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A910E0", Offset = "0x6A8F6E0", VA = "0x186A910E0")]
	public void OAEBHOLGMFA(OFOAFDPCCEM PAFMGBBEHFA, int HHCDLAEEJPG, int JKMBFEGPNAN, float MPDLEAHHHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C7A0", Offset = "0x6A8ADA0", VA = "0x186A8C7A0")]
	public (long, long, long) HLOJPBFCELG()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9F6890", Offset = "0x9F4E90", VA = "0x1809F6890")]
	public long KJHCGNJMDAA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A89460", Offset = "0x6A87A60", VA = "0x186A89460")]
	private void DHKLAJKNEHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A91110", Offset = "0x6A8F710", VA = "0x186A91110")]
	public (long, long) ONAGCEAJBLA(float KNBHKGDFFAJ, float4x4 KJGAGCEOPBC)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	public void NBNANBIKDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A89340", Offset = "0x6A87940", VA = "0x186A89340")]
	internal void CJBOAEBEDBI(FFHFGOPEEEF DJBPOIKJIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FE20", Offset = "0x6A8E420", VA = "0x186A8FE20")]
	private (float, float, float) NIGPIDNPHED(float FJJOAJLNIKL, float4x4 KJGAGCEOPBC)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A88F90", Offset = "0x6A87590", VA = "0x186A88F90")]
	private (int, int) CHNEHBMOJLE(float AIPFPIJDMMH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C810", Offset = "0x6A8AE10", VA = "0x186A8C810")]
	public void HOBIPIJFAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6A916B0", Offset = "0x6A8FCB0", VA = "0x186A916B0")]
	private void PMPLDLBGHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8ACC0", Offset = "0x6A892C0", VA = "0x186A8ACC0")]
	private void EKCNHCKJKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6A90900", Offset = "0x6A8EF00", VA = "0x186A90900")]
	public long NLHBGJBKFCC(long PDLDLEKDEBE, int DOINFLMDPJA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EBE0", Offset = "0x6A8D1E0", VA = "0x186A8EBE0")]
	private void JLKCHCMNKMB(OMKOMDIKKEA FCHLOIAJDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C500", Offset = "0x6A8AB00", VA = "0x186A8C500")]
	private void HJEPHCBNGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6A88440", Offset = "0x6A86A40", VA = "0x186A88440")]
	private void AOMLGNGOEOC(OMKOMDIKKEA CKFPIMAMAKM, OFOAFDPCCEM PAFMGBBEHFA, int HHCDLAEEJPG, int JKMBFEGPNAN, float MPDLEAHHHHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct NFNLHNENLIO : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct KNKGFOJHFIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int PGBEDDPBPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int CPFOIFPIOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int DLKIFHNFFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int DNAIOGBHENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int JBFDBPACDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int HDDONELCBHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int JHMHPFJNIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int EGGKPKCEMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float IKFNMENGNDB;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct PMJNDNLMFNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public FABPFOCDMII.BKPLGEGKNNC GEMGJEDECMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float AINONKNOCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float MEADDKGBDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float NGPBGFBGCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float OOFKPGMKHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float CPJHIICMOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float LDOKJGFJIBN;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct NFGNGFEOPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> FLPCELBAHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> IFCDOHNCNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> KHGAJFONIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> EKKJEHPOKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> KJGMJKMAMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> JMDHNHGDBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool JEOIGDOMKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int DJEJONINPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int ALMEHFENJNK;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5820", Offset = "0x6AA3E20", VA = "0x186AA5820")]
		public void FMOJIDBMNCN(int KPGHDFKJEPO, int IEKNLKKGAIM, Allocator KOIILCBLJPK, bool BKMPIBDHEIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5A00", Offset = "0x6AA4000", VA = "0x186AA5A00")]
		public static NFGNGFEOPMA KFBNHLJEPCE(OMKOMDIKKEA MBEDFGIGBHI)
		{
			return default(NFGNGFEOPMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5760", Offset = "0x6AA3D60", VA = "0x186AA5760")]
		public void EKANILNIIHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker LGKALLLGDDA;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker CGEFOBFHFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<KNKGFOJHFIL> OPODDMONAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NFGNGFEOPMA BOEIJNHFGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NFGNGFEOPMA FCHLOIAJDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 ANKAIGNHBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 ILJOEFOONBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private PMJNDNLMFNO CEMEIODGEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* FEEBFICLPIE;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	[BurstDiscard]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	[BurstDiscard]
	private static void MIGDCHAEACO(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	[BurstDiscard]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC, string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A95020", Offset = "0x6A93620", VA = "0x186A95020")]
	public NFNLHNENLIO([In] List<IAFNPJALNLP.BPAPBBPGDJL> JGPJBLHLIBM, [In] OMKOMDIKKEA JCHIINJJIGA, [In] IAFNPJALNLP MOPMNMLOLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A93B10", Offset = "0x6A92110", VA = "0x186A93B10", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A93490", Offset = "0x6A91A90", VA = "0x186A93490")]
	public void EAMBGBOFJBG(List<IAFNPJALNLP.BPAPBBPGDJL> ANGMGCKGDNN, [In] IAFNPJALNLP MOPMNMLOLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6A93370", Offset = "0x6A91970", VA = "0x186A93370")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool CBHKPDEDBLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6A94EB0", Offset = "0x6A934B0", VA = "0x186A94EB0")]
	private OFOAFDPCCEM ODMGDPEMIDD(int EMLPCIOLDJE, Allocator KOIILCBLJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A93B60", Offset = "0x6A92160", VA = "0x186A93B60")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void LCKKGOLFMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A93000", Offset = "0x6A91600", VA = "0x186A93000")]
	[IgnoreWarning(1371)]
	private KNKGFOJHFIL AGOCNADDAIH([In] KNKGFOJHFIL HKKKCGHFKLN, int DCLMDFNIGON, [In] NativeArray<int> FLNOIJGKJIO, [In] NativeArray<bool> GCHBPOJMDCJ, NativeArray<int> JKEKCCMLFHP)
	{
		return default(KNKGFOJHFIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A93390", Offset = "0x6A91990", VA = "0x186A93390")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int CMPCEEJFBOM(NativeArray<int> FLNOIJGKJIO, int NBLGJJJJHHO, int HIGEIDAHBBM, int ELGCNDPBFGE)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly PBGLEKOCCEM log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker NBAMHGMIJKE;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker LPIGBONLAHC;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker EFHPJLDJDBE;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker IADFLBHHODO;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker LIEBPOHNCFA;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker CJOJBIBIOBI;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker LDIBAGNDGGH;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int HGNLJNJCJKI = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Dictionary<Material, List<IAFNPJALNLP>> FGEKDACKNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<IAFNPJALNLP> OLMIDOEFPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> HEDMALBNOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool IGPBILDBLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool EJICPIJGDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int NDKILGJCJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> DGGKKMAKNKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> FHKPLGCFCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> GOOCMNBPOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> JJDHINLFIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private IAFNPJALNLP IKNFHOICLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material GOBOHHHJNJP;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int MIEFBLHLGEM = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, IGGMCOMIHMK)> EPFIBOFJDPC;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> JJPOAMCPGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int FGODKIEHNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6AA5710", Offset = "0x6AA3D10", VA = "0x186AA5710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		private static void AHDMIJHIPIB(bool HGHLIEFOBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		private static void AHDMIJHIPIB(bool HGHLIEFOBKC, string ELIMFPDKMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6AA20C0", Offset = "0x6AA06C0", VA = "0x186AA20C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0610", Offset = "0x6A9EC10", VA = "0x186AA0610")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6AA03E0", Offset = "0x6A9E9E0", VA = "0x186AA03E0")]
		public IAFNPJALNLP AddToBatchedMesh(IGGMCOMIHMK LDEGGMKBBNH, Material OLKLLNJBJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4800", Offset = "0x6AA2E00", VA = "0x186AA4800")]
		public void RemoveFromBatchedMesh(IGGMCOMIHMK CKFPIMAMAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6AA04E0", Offset = "0x6A9EAE0", VA = "0x186AA04E0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4FF0", Offset = "0x6AA35F0", VA = "0x186AA4FF0")]
		public void SetMaterialProperty(int KKEFBAKIJFE, Color PHHAMGLLFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4BA0", Offset = "0x6AA31A0", VA = "0x186AA4BA0")]
		public void SetMaterialProperty(int KKEFBAKIJFE, float DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4DC0", Offset = "0x6AA33C0", VA = "0x186AA4DC0")]
		public void SetMaterialProperty(int KKEFBAKIJFE, Vector4 OHPCMFIHAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4940", Offset = "0x6AA2F40", VA = "0x186AA4940")]
		public void SetMaterialProperty(int KKEFBAKIJFE, Matrix4x4 JAFOIIPJPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FDF0", Offset = "0x6A9E3F0", VA = "0x186A9FDF0")]
		private void APBMNLCIFHE(Renderer PGOGAFFEFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0D00", Offset = "0x6A9F300", VA = "0x186AA0D00")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0CF0", Offset = "0x6A9F2F0", VA = "0x186AA0CF0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6AA07D0", Offset = "0x6A9EDD0", VA = "0x186AA07D0")]
		private void EIOKGMBGADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6AA19C0", Offset = "0x6A9FFC0", VA = "0x186AA19C0")]
		private IAFNPJALNLP JKNENFHNODA(IGGMCOMIHMK CKFPIMAMAKM, Material OLKLLNJBJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6AA12E0", Offset = "0x6A9F8E0", VA = "0x186AA12E0")]
		private IAFNPJALNLP HECAGCHNNOA(Material OLKLLNJBJND, int IHLDLLACMDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6AA15C0", Offset = "0x6A9FBC0", VA = "0x186AA15C0")]
		private IAFNPJALNLP HHFAPBPNHGN(Material OLKLLNJBJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x191CD30", Offset = "0x191B330", VA = "0x18191CD30")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1BE0", Offset = "0x6AA01E0", VA = "0x186AA1BE0")]
		public void MarkDirty(IGGMCOMIHMK CKFPIMAMAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1D40", Offset = "0x6AA0340", VA = "0x186AA1D40")]
		public (long, long) MemorySizeInBytesForChosenDetail(float KNBHKGDFFAJ)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3890", Offset = "0x6AA1E90", VA = "0x186AA3890")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0DA0", Offset = "0x6A9F3A0", VA = "0x186AA0DA0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA23B0", Offset = "0x6AA09B0", VA = "0x186AA23B0")]
		public void RebatchOptimally(int GPAFKEFHHFN, int DNGLLJCNBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA54A0", Offset = "0x6AA3AA0", VA = "0x186AA54A0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class BIAJHNIDFAE
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct MDJJJKAPKFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float LOLKACMOLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer CHEPPGIMDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public IAFNPJALNLP OAJMLOOODMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long IPKGGMOHICB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class BINJEBJNLCC : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x950D30", Offset = "0x94F330", VA = "0x180950D30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x6A9FC80", Offset = "0x6A9E280", VA = "0x186A9FC80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xABDB90", Offset = "0xABC190", VA = "0x180ABDB90")]
		[DebuggerHidden]
		public BINJEBJNLCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FCD0", Offset = "0x6A9E2D0", VA = "0x186A9FCD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EF30", Offset = "0x6A9D530", VA = "0x186A9EF30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EEE0", Offset = "0x6A9D4E0", VA = "0x186A9EEE0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EE90", Offset = "0x6A9D490", VA = "0x186A9EE90")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FC30", Offset = "0x6A9E230", VA = "0x186A9FC30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FB80", Offset = "0x6A9E180", VA = "0x186A9FB80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FB80", Offset = "0x6A9E180", VA = "0x186A9FB80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker CJOJBIBIOBI;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker BCKMAGBMIPH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker LCDADLJLMFH;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker JEHMKDBCOHC;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 BFKNNHCFHCH;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int IEHMCGDOCKM;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int EFGPCHDDCAF;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int LIHNBGNDIPL;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int OJDGNKFBINF;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int IEMFFFPFNPK;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int BDNHCOCECAG;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int GMIFAHPIIHG;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int OMFOHLBCKPE;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int GPEKBHGLEBG;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int MCCNBAMPLOO;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int DHFPPGGPAAP;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int NKJODPKLJFE;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int HJMFILFPEMN;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int CLGCLPMPBLC;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long CAPCEPLCFGN;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long HMFMKALGKMM;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int ADJFGBBDING;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int LICNCLBAIHI;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int NKDIGBJHHHK;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long NKDOHAGICIB;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool HHFBFPEONGJ;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> LIEMNJPGLLC;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<MDJJJKAPKFG> NILCJKLJGIF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool MEMOHLGMJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B310", Offset = "0x6A99910", VA = "0x186A9B310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void MIGDCHAEACO(bool HGHLIEFOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void AHDMIJHIPIB(bool HGHLIEFOBKC, string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A9ACF0", Offset = "0x6A992F0", VA = "0x186A9ACF0")]
	public static void ADKLMMLJNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E2B0", Offset = "0x6A9C8B0", VA = "0x186A9E2B0")]
	public static void NLHABKKDFDM(BatchedMeshRenderer BCCBNFLNEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E200", Offset = "0x6A9C800", VA = "0x186A9E200")]
	public static void KBIOPONDNCP(BatchedMeshRenderer BCCBNFLNEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B5B0", Offset = "0x6A99BB0", VA = "0x186A9B5B0")]
	private static (long, long, long) EKCNJMBMMHN(long KKLMAAOGFHP)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B870", Offset = "0x6A99E70", VA = "0x186A9B870")]
	public static void GPKNNKOJFBM(long KKLMAAOGFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E520", Offset = "0x6A9CB20", VA = "0x186A9E520")]
	public static long NLHBGJBKFCC(long PDLDLEKDEBE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AEA0", Offset = "0x6A994A0", VA = "0x186A9AEA0")]
	public static void AMIBPPCAJHL(IAFNPJALNLP OAJMLOOODMC, BatchedMeshRenderer CHEPPGIMDIN, long IPKGGMOHICB, float LOLKACMOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B4B0", Offset = "0x6A99AB0", VA = "0x186A9B4B0")]
	public static void EIMFLGEMGIH(IAFNPJALNLP OAJMLOOODMC, BatchedMeshRenderer CHEPPGIMDIN, long IPKGGMOHICB, float IALBEHFBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B3A0", Offset = "0x6A999A0", VA = "0x186A9B3A0")]
	public static void CLEOOJMADLC(IAFNPJALNLP OAJMLOOODMC, BatchedMeshRenderer CHEPPGIMDIN, long IPKGGMOHICB, float IALBEHFBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B6C0", Offset = "0x6A99CC0", VA = "0x186A9B6C0")]
	public static void EMAELCBJLKJ(IAFNPJALNLP OAJMLOOODMC, BatchedMeshRenderer CHEPPGIMDIN, long IPKGGMOHICB, float LOLKACMOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AFB0", Offset = "0x6A995B0", VA = "0x186A9AFB0")]
	public static float ANAPLEBDPJD(long AFPNLHJOLEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E950", Offset = "0x6A9CF50", VA = "0x186A9E950")]
	public static (long, long) ONAGCEAJBLA(float KNBHKGDFFAJ)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E8C0", Offset = "0x6A9CEC0", VA = "0x186A9E8C0")]
	[IteratorStateMachine(typeof(BINJEBJNLCC))]
	public static IEnumerable<bool> NLHONKFJIFK(long ADCHGFGJMDN, bool MBHAHNBFMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E090", Offset = "0x6A9C690", VA = "0x186A9E090")]
	public static void IGPJJDBHBKA(long ADCHGFGJMDN, bool MBHAHNBFMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DF50", Offset = "0x6A9C550", VA = "0x186A9DF50")]
	public static int HPJHEMPHNNH()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class OOOHMFBJDDP<KeyType> : IAFNPJALNLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, IGGMCOMIHMK> ILAHEMFLDCK;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x46FAFF0", Offset = "0x46F95F0", VA = "0x1846FAFF0")]
	public OOOHMFBJDDP(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x46FAE90", Offset = "0x46F9490", VA = "0x1846FAE90")]
	public void PAHIHILCCKN(KeyType IBBDLGCDELM, IGGMCOMIHMK JNODLMCJKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x46FAD90", Offset = "0x46F9390", VA = "0x1846FAD90")]
	public bool MNCGGKEFENB(KeyType IBBDLGCDELM, IGGMCOMIHMK EPHKFBNNNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x46FAA70", Offset = "0x46F9070", VA = "0x1846FAA70")]
	public void CCEMOPAIHIL(KeyType IBBDLGCDELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x46FAC30", Offset = "0x46F9230", VA = "0x1846FAC30", Slot = "4")]
	public override void MJINHNFGIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5C50", Offset = "0x6AA4250", VA = "0x186AA5C50")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
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
