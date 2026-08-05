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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
	public class LogRegistrationIndex : MBMEJMGLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6941000", Offset = "0x693FA00", VA = "0x186941000", Slot = "4")]
		public override void PMAGAGNLFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CDIHAFDBKHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GKOLCCJHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 DGKFMMGCNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion NBBLNIODLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 EMHEOCJABLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int ELGPMOBIFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int CFMBBGMFHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int IFKIHIMJMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float MDBGILJIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 HEJEHEAHMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool JPBLLDEGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NEEKECBNPAF OKDIAFLGLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 KMHMCAHEDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float FCHICGODAGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DHOOIPBKPIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static CFCCKEJPPEB OPMNOGGKOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<CDIHAFDBKHN> FHAOFPGGFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<GNGCCKIDABH> KADNDMODPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<EBKCGDALKHK> EADAAKOHKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<PEHEHHOPNDC> CFKEGPKIMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<GNGCCKIDABH> OFMKCIPEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<MOPCHPNNKBP> MHKBNLJKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<PEHEHHOPNDC>> KHPEBIDIALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<CDMKMDCBFDP> AHKJCNKKEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> DFGOBEDECDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDBCED0", Offset = "0xDBB8D0", VA = "0x180DBCED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDBC400", Offset = "0xDBAE00", VA = "0x180DBC400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NKAFOLBGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA679B0", Offset = "0xA663B0", VA = "0x180A679B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDBB660", Offset = "0xDBA060", VA = "0x180DBB660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x692F6C0", Offset = "0x692E0C0", VA = "0x18692F6C0")]
	public DHOOIPBKPIJ(int KGDHDAONPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x692DF10", Offset = "0x692C910", VA = "0x18692DF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x692F4F0", Offset = "0x692DEF0", VA = "0x18692F4F0")]
	public void NELEFDBDAJB(JobHandle IOPBMLMLGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x692D9B0", Offset = "0x692C3B0", VA = "0x18692D9B0")]
	public void ABNAGNOAMKP(CDIHAFDBKHN EEOBDBMOHPL, CDMKMDCBFDP NDPJGBALCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x692F0E0", Offset = "0x692DAE0", VA = "0x18692F0E0")]
	public void MIDNNKLKGNK(EBKCGDALKHK EEOBDBMOHPL, NativeArray<PEHEHHOPNDC> MOBCCABHBBF, int PMNNDMLMMHM, int FBOAKBIHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x692E0D0", Offset = "0x692CAD0", VA = "0x18692E0D0")]
	public JobHandle KMMLGDJBCFJ(AEOIJLLIIPA IJADDAHBADJ, EDPFGOEHLGG GCBAPFPCNFK, float3 FKLKIJOHOCM, quaternion ACJMCAFCKEN, float JILJKDEHAEH, bool DMEHGFFEGDN, int BBKAFGKEJAD = 0, int JGPJJFNPFGE = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x692DBD0", Offset = "0x692C5D0", VA = "0x18692DBD0")]
	public static JobHandle AFGMOJAOPOO(CIACOHNFNMK HINDIGOPKFC, AEOIJLLIIPA IJADDAHBADJ, CDIHAFDBKHN EEOBDBMOHPL, JobHandle IOPBMLMLGLO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x692F240", Offset = "0x692DC40", VA = "0x18692F240")]
	public static JobHandle NCANEHOOBMD(MGDMKKFIOBN HINDIGOPKFC, AEOIJLLIIPA IJADDAHBADJ, EBKCGDALKHK EEOBDBMOHPL, NativeArray<PEHEHHOPNDC> MOBCCABHBBF, int PMNNDMLMMHM, int FBOAKBIHCNN, JobHandle IOPBMLMLGLO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class EBNJBMIMMPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MDNPAMNHCKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half AJHKLPBPNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort AFOGOBPEODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte FAKDPEMKPBN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void FNIBKKDPAPM([NoAlias] float3* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class OANCHBPEBJO
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69434D0", Offset = "0x6941ED0", VA = "0x1869434D0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6943370", Offset = "0x6941D70", VA = "0x186943370")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6943600", Offset = "0x6942000", VA = "0x186943600")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6943160", Offset = "0x6941B60", VA = "0x186943160")]
		public unsafe static void EDIAJIJOMBB([NoAlias] float3* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void OGILNCEPBAC([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class CJIKEBCKNDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x692CB20", Offset = "0x692B520", VA = "0x18692CB20")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x692C9C0", Offset = "0x692B3C0", VA = "0x18692C9C0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x692CC50", Offset = "0x692B650", VA = "0x18692CC50")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x692C730", Offset = "0x692B130", VA = "0x18692C730")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void HNDKPBFJCLH([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class FMEAEFJBOHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69372E0", Offset = "0x6935CE0", VA = "0x1869372E0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6937180", Offset = "0x6935B80", VA = "0x186937180")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6937410", Offset = "0x6935E10", VA = "0x186937410")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6936EF0", Offset = "0x69358F0", VA = "0x186936EF0")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void CIKNHJBFJJH([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class NMGKMKJHCKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6942990", Offset = "0x6941390", VA = "0x186942990")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6942830", Offset = "0x6941230", VA = "0x186942830")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6942AC0", Offset = "0x69414C0", VA = "0x186942AC0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69425A0", Offset = "0x6940FA0", VA = "0x1869425A0")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void HLHGNNPKKBL([NoAlias] ushort* PEBHNCDODKK, [Out] float3 DJLGCPHOPGA, [Out] float3 BOLMGEKNLLN, [In][NoAlias] float3* JBCNMGEGDKH, int KBGNNMMHPLE, int AENDFGPLPAL);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class MOEBNIDIMPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69423C0", Offset = "0x6940DC0", VA = "0x1869423C0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6942260", Offset = "0x6940C60", VA = "0x186942260")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69424F0", Offset = "0x6940EF0", VA = "0x1869424F0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6942040", Offset = "0x6940A40", VA = "0x186942040")]
		public unsafe static void EDIAJIJOMBB([NoAlias] ushort* PEBHNCDODKK, [Out] float3 DJLGCPHOPGA, [Out] float3 BOLMGEKNLLN, [In][NoAlias] float3* JBCNMGEGDKH, int KBGNNMMHPLE, int AENDFGPLPAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void KIJBANGFHBE([NoAlias] ushort* ADFOLCJJBKM, [In][NoAlias] float3* PNCIBBBOELM, int AENDFGPLPAL);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class KPGEENHCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x693DE90", Offset = "0x693C890", VA = "0x18693DE90")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x693DD30", Offset = "0x693C730", VA = "0x18693DD30")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x693DFC0", Offset = "0x693C9C0", VA = "0x18693DFC0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x693DB40", Offset = "0x693C540", VA = "0x18693DB40")]
		public unsafe static void EDIAJIJOMBB([NoAlias] ushort* ADFOLCJJBKM, [In][NoAlias] float3* PNCIBBBOELM, int AENDFGPLPAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void JMKPCILNPLO([NoAlias] float3* IAADDCLFGEG, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class EJNDEOJIGDP
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6936750", Offset = "0x6935150", VA = "0x186936750")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69365F0", Offset = "0x6934FF0", VA = "0x1869365F0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6936880", Offset = "0x6935280", VA = "0x186936880")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69363A0", Offset = "0x6934DA0", VA = "0x1869363A0")]
		public unsafe static void EDIAJIJOMBB([NoAlias] float3* IAADDCLFGEG, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void MFMFDCPHEGM([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class DAEOLAAECPF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x692D150", Offset = "0x692BB50", VA = "0x18692D150")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x692CFF0", Offset = "0x692B9F0", VA = "0x18692CFF0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x692D280", Offset = "0x692BC80", VA = "0x18692D280")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x692CE00", Offset = "0x692B800", VA = "0x18692CE00")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void LPIADCCDOKC([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class PMLODHMLCKC
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6945D30", Offset = "0x6944730", VA = "0x186945D30")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6945BD0", Offset = "0x69445D0", VA = "0x186945BD0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6945E60", Offset = "0x6944860", VA = "0x186945E60")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6945910", Offset = "0x6944310", VA = "0x186945910")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void MBCFMNOABLJ([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class OJNHLPDMNCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6944660", Offset = "0x6943060", VA = "0x186944660")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6944500", Offset = "0x6942F00", VA = "0x186944500")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6944790", Offset = "0x6943190", VA = "0x186944790")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6944250", Offset = "0x6942C50", VA = "0x186944250")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void CLLNOGHEPJF([NoAlias] ushort* FLMBIBGGLKO, [Out] float2 DLCOAIHPAIP, [Out] float2 JEOJDNAAEJE, [In][NoAlias] float2* IDCJLNFABHG, int KBGNNMMHPLE, int AENDFGPLPAL);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class PPGIJLKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6946290", Offset = "0x6944C90", VA = "0x186946290")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6946130", Offset = "0x6944B30", VA = "0x186946130")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69463C0", Offset = "0x6944DC0", VA = "0x1869463C0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6945F10", Offset = "0x6944910", VA = "0x186945F10")]
		public unsafe static void EDIAJIJOMBB([NoAlias] ushort* FLMBIBGGLKO, [Out] float2 DLCOAIHPAIP, [Out] float2 JEOJDNAAEJE, [In][NoAlias] float2* IDCJLNFABHG, int KBGNNMMHPLE, int AENDFGPLPAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void BBEBMBAMECP([Out] float2 BBKNOBEIKNO, ushort HMFOOIHANFN, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class JGLOPCDONDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x693D280", Offset = "0x693BC80", VA = "0x18693D280")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x693D120", Offset = "0x693BB20", VA = "0x18693D120")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x693D3B0", Offset = "0x693BDB0", VA = "0x18693D3B0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x693CEE0", Offset = "0x693B8E0", VA = "0x18693CEE0")]
		public static void EDIAJIJOMBB([Out] float2 BBKNOBEIKNO, ushort HMFOOIHANFN, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void PGEAEDEOGMF([NoAlias] float2* FLMBIBGGLKO, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class GPNAMOIKEDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6938F50", Offset = "0x6937950", VA = "0x186938F50")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6938DF0", Offset = "0x69377F0", VA = "0x186938DF0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6939080", Offset = "0x6937A80", VA = "0x186939080")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6938B60", Offset = "0x6937560", VA = "0x186938B60")]
		public unsafe static void EDIAJIJOMBB([NoAlias] float2* FLMBIBGGLKO, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void DPNFOGHDGEL([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class OHFKDEHLLNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6943AE0", Offset = "0x69424E0", VA = "0x186943AE0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6943980", Offset = "0x6942380", VA = "0x186943980")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6943C10", Offset = "0x6942610", VA = "0x186943C10")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69436B0", Offset = "0x69420B0", VA = "0x1869436B0")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void MKOBIMNJLLD([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GHHODLMIMGL
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6938430", Offset = "0x6936E30", VA = "0x186938430")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x69382D0", Offset = "0x6936CD0", VA = "0x1869382D0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6938560", Offset = "0x6936F60", VA = "0x186938560")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6938000", Offset = "0x6936A00", VA = "0x186938000")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void MHPIABHCAEE([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class HPBAHALCEME
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x693A910", Offset = "0x6939310", VA = "0x18693A910")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x693A7B0", Offset = "0x69391B0", VA = "0x18693A7B0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x693AA40", Offset = "0x6939440", VA = "0x18693AA40")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x693A400", Offset = "0x6938E00", VA = "0x18693A400")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void BJHFNJDNIDL([NoAlias] ushort* IOJFFEEFMMF, [In][NoAlias] float4* HCEJJHPNMHC, int KBGNNMMHPLE, int AENDFGPLPAL);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class PAGFIPOBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6945170", Offset = "0x6943B70", VA = "0x186945170")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6945010", Offset = "0x6943A10", VA = "0x186945010")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69452A0", Offset = "0x6943CA0", VA = "0x1869452A0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6944DC0", Offset = "0x69437C0", VA = "0x186944DC0")]
		public unsafe static void EDIAJIJOMBB([NoAlias] ushort* IOJFFEEFMMF, [In][NoAlias] float4* HCEJJHPNMHC, int KBGNNMMHPLE, int AENDFGPLPAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort IABDLILDHPD([In] float4 KAFAEACCHBG);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class GNIKFEHPJPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6938980", Offset = "0x6937380", VA = "0x186938980")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6938820", Offset = "0x6937220", VA = "0x186938820")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6938AB0", Offset = "0x69374B0", VA = "0x186938AB0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6938610", Offset = "0x6937010", VA = "0x186938610")]
		public static ushort EDIAJIJOMBB([In] float4 KAFAEACCHBG)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void KMKONDCNDEC([NoAlias] float4* IOJFFEEFMMF, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class OJIFHPMGOEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6944070", Offset = "0x6942A70", VA = "0x186944070")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6943F10", Offset = "0x6942910", VA = "0x186943F10")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69441A0", Offset = "0x6942BA0", VA = "0x1869441A0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6943CC0", Offset = "0x69426C0", VA = "0x186943CC0")]
		public unsafe static void EDIAJIJOMBB([NoAlias] float4* IOJFFEEFMMF, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void JDBNKDEEIHI([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class LFJKANHHDOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x693E9E0", Offset = "0x693D3E0", VA = "0x18693E9E0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x693E880", Offset = "0x693D280", VA = "0x18693E880")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x693EB10", Offset = "0x693D510", VA = "0x18693EB10")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x693E690", Offset = "0x693D090", VA = "0x18693E690")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void IEABLLJLCFK([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class MEACCALKCAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6941570", Offset = "0x693FF70", VA = "0x186941570")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6941410", Offset = "0x693FE10", VA = "0x186941410")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69416A0", Offset = "0x69400A0", VA = "0x1869416A0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6941150", Offset = "0x693FB50", VA = "0x186941150")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void CAMPHDMHFID([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class NOJKAJBFEIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6942F80", Offset = "0x6941980", VA = "0x186942F80")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6942E20", Offset = "0x6941820", VA = "0x186942E20")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69430B0", Offset = "0x6941AB0", VA = "0x1869430B0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6942B70", Offset = "0x6941570", VA = "0x186942B70")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void LNOIAOGFMEN([Out] float4 EBPHIJANMPN, ushort HMFOOIHANFN);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class FHHJKFLBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6936D10", Offset = "0x6935710", VA = "0x186936D10")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6936BB0", Offset = "0x69355B0", VA = "0x186936BB0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6936E40", Offset = "0x6935840", VA = "0x186936E40")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6936930", Offset = "0x6935330", VA = "0x186936930")]
		public static void EDIAJIJOMBB([Out] float4 EBPHIJANMPN, ushort HMFOOIHANFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void DCHCPEAOLPK([NoAlias] float4* IDOAEOEJMHL, [NoAlias] byte* FHHEOBKBMEK, [Out] int DDCDBNABKGO, [Out] int FLEEEDDEJPB, [NoAlias] float4* DKJDNKLKHIG, int KBGNNMMHPLE, int AENDFGPLPAL);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class HIFFMMAIDPG
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x69394B0", Offset = "0x6937EB0", VA = "0x1869394B0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6939350", Offset = "0x6937D50", VA = "0x186939350")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x69395E0", Offset = "0x6937FE0", VA = "0x1869395E0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6939130", Offset = "0x6937B30", VA = "0x186939130")]
		public unsafe static void EDIAJIJOMBB([NoAlias] float4* IDOAEOEJMHL, [NoAlias] byte* FHHEOBKBMEK, [Out] int DDCDBNABKGO, [Out] int FLEEEDDEJPB, [NoAlias] float4* DKJDNKLKHIG, int KBGNNMMHPLE, int AENDFGPLPAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void GLHJKNMPOKE([NoAlias] float4* FFMLFFOEKLF, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class LEMAGGAHBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x693E4B0", Offset = "0x693CEB0", VA = "0x18693E4B0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x693E350", Offset = "0x693CD50", VA = "0x18693E350")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x693E5E0", Offset = "0x693CFE0", VA = "0x18693E5E0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x693E070", Offset = "0x693CA70", VA = "0x18693E070")]
		public unsafe static void EDIAJIJOMBB([NoAlias] float4* FFMLFFOEKLF, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void OLFFLCOMPIB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class HONCOKMAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x693A220", Offset = "0x6938C20", VA = "0x18693A220")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x693A0C0", Offset = "0x6938AC0", VA = "0x18693A0C0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x693A350", Offset = "0x6938D50", VA = "0x18693A350")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6939D30", Offset = "0x6938730", VA = "0x186939D30")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void CGIMMIPDKBJ([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class JJAILCINGCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x693D960", Offset = "0x693C360", VA = "0x18693D960")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x693D800", Offset = "0x693C200", VA = "0x18693D800")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x693DA90", Offset = "0x693C490", VA = "0x18693DA90")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x693D460", Offset = "0x693BE60", VA = "0x18693D460")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void FLKJLIDNKCJ([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class MNIFBJAAIME
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6941E60", Offset = "0x6940860", VA = "0x186941E60")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6941D00", Offset = "0x6940700", VA = "0x186941D00")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6941F90", Offset = "0x6940990", VA = "0x186941F90")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6941970", Offset = "0x6940370", VA = "0x186941970")]
		public unsafe static void EDIAJIJOMBB([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int AJCCBPDPIBM([NoAlias] byte* DIBFNAODPNK, [In][NoAlias] int* KGAJNDNCING, int AMGGPAGMEOA);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class PBPLCIMHECB
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6945730", Offset = "0x6944130", VA = "0x186945730")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x69455D0", Offset = "0x6943FD0", VA = "0x1869455D0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6945860", Offset = "0x6944260", VA = "0x186945860")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6945350", Offset = "0x6943D50", VA = "0x186945350")]
		public unsafe static int EDIAJIJOMBB([NoAlias] byte* DIBFNAODPNK, [In][NoAlias] int* KGAJNDNCING, int AMGGPAGMEOA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void MMMICGMIBPN([NoAlias] int* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class DGJODMOCIDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x692D7D0", Offset = "0x692C1D0", VA = "0x18692D7D0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x692D670", Offset = "0x692C070", VA = "0x18692D670")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x692D900", Offset = "0x692C300", VA = "0x18692D900")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x692D430", Offset = "0x692BE30", VA = "0x18692D430")]
		public unsafe static void EDIAJIJOMBB([NoAlias] int* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void OKECHOMJGCI([NoAlias] ushort* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class ONNJAANOLLP
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6944BE0", Offset = "0x69435E0", VA = "0x186944BE0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6944A80", Offset = "0x6943480", VA = "0x186944A80")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6944D10", Offset = "0x6943710", VA = "0x186944D10")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6944840", Offset = "0x6943240", VA = "0x186944840")]
		public unsafe static void EDIAJIJOMBB([NoAlias] ushort* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void EDKEJJOACPG([Out] float3 BBKNOBEIKNO, ushort HMFOOIHANFN);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class HJPFOGOJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6939B50", Offset = "0x6938550", VA = "0x186939B50")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x69399F0", Offset = "0x69383F0", VA = "0x1869399F0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6939C80", Offset = "0x6938680", VA = "0x186939C80")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6939690", Offset = "0x6938090", VA = "0x186939690")]
		public static void EDIAJIJOMBB([Out] float3 BBKNOBEIKNO, ushort HMFOOIHANFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort GHCFBHBACDL([In] float3 KAFAEACCHBG);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class JCADJEONPMC
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x693C840", Offset = "0x693B240", VA = "0x18693C840")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x693C6E0", Offset = "0x693B0E0", VA = "0x18693C6E0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x693C970", Offset = "0x693B370", VA = "0x18693C970")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x693C510", Offset = "0x693AF10", VA = "0x18693C510")]
		public static ushort EDIAJIJOMBB([In] float3 KAFAEACCHBG)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int PMNNDMLMMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int FBOAKBIHCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> GGCPLLDHPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> LFGGFECHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> EEOAIIBHAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MGJKKAOJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<MDNPAMNHCKI> PCIGOGHCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> DIJDCGFECOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> AGIIHBHOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 ILOCOIOGNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 BOLMGEKNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 MGJGLAKCMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 JEOJDNAAEJE;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long IAJNFLFKCOI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long IOCOOMNGEGD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float MFPAHABCDKN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool NNIIGLGDJOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MONHEEDKLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69348E0", Offset = "0x69332E0", VA = "0x1869348E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6935400", Offset = "0x6933E00", VA = "0x186935400")]
	public void NELEFDBDAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6931090", Offset = "0x692FA90", VA = "0x186931090")]
	public static EBNJBMIMMPJ CBNOJCEAKCL(Allocator BPMIGAHMDHE, AEOIJLLIIPA KJIACEHHPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6930BA0", Offset = "0x692F5A0", VA = "0x186930BA0")]
	public static EBNJBMIMMPJ CBNOJCEAKCL(Allocator BPMIGAHMDHE, NativeArray<float3> JBCNMGEGDKH, NativeArray<float3> PNCIBBBOELM, NativeArray<float2> IDCJLNFABHG, NativeArray<float4> DKJDNKLKHIG, bool BMPFHDPHFFO, NativeArray<float4> ILJPCMMMJGF, NativeArray<int> KGAJNDNCING, int PMNNDMLMMHM, int NCFIAMNILBC, int FBOAKBIHCNN, int KBGNNMMHPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69329B0", Offset = "0x69313B0", VA = "0x1869329B0")]
	public AEOIJLLIIPA GMEHGGNJPMP(Allocator BPMIGAHMDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6933240", Offset = "0x6931C40", VA = "0x186933240")]
	public void HMICBKIJCLD(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6934C20", Offset = "0x6933620", VA = "0x186934C20")]
	private void MBDFNKJIMKL(Mesh KJFFCELEION, NativeArray<ushort> CGHNECFIFKG, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6934E00", Offset = "0x6933800", VA = "0x186934E00")]
	public void MCPDMBIIOPN(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6931FA0", Offset = "0x69309A0", VA = "0x186931FA0")]
	public void EHBPMFEKMPD(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6933E80", Offset = "0x6932880", VA = "0x186933E80")]
	public void KDFLMGHCMDE(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6935500", Offset = "0x6933F00", VA = "0x186935500")]
	public void NHJBBMFIOCL(Mesh KJFFCELEION, AEOIJLLIIPA.BFOIAECHFDO PHCNDPLEFBH, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69316A0", Offset = "0x69300A0", VA = "0x1869316A0")]
	public long DBDANGDOFMG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6934590", Offset = "0x6932F90", VA = "0x186934590")]
	public long KILJJFIAPMI(AEOIJLLIIPA.BFOIAECHFDO PHCNDPLEFBH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6934460", Offset = "0x6932E60", VA = "0x186934460")]
	private void KDNHMNFFJOO(int MNGECEBMIEA, int AENDFGPLPAL, Allocator BPMIGAHMDHE, bool OJKFFKNLBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6935870", Offset = "0x6934270", VA = "0x186935870")]
	private void NNEAOJMHKNP(NativeArray<float3> PEBHNCDODKK, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6935970", Offset = "0x6934370", VA = "0x186935970")]
	[BurstCompile]
	private unsafe static void NNEAOJMHKNP([NoAlias] float3* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6933340", Offset = "0x6931D40", VA = "0x186933340")]
	[BurstCompile]
	private unsafe static void HNJJALMPMNK([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6933990", Offset = "0x6932390", VA = "0x186933990")]
	[BurstCompile]
	private unsafe static void JEGKPEKEBPB([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6935C80", Offset = "0x6934680", VA = "0x186935C80")]
	[BurstCompile]
	private unsafe static void OOLNLHFIMIP([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x692FCD0", Offset = "0x692E6D0", VA = "0x18692FCD0")]
	private void BALGFJFLDLI(NativeArray<float3> JBCNMGEGDKH, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x692FC40", Offset = "0x692E640", VA = "0x18692FC40")]
	[BurstCompile]
	private unsafe static void BALGFJFLDLI([NoAlias] ushort* PEBHNCDODKK, [Out] float3 DJLGCPHOPGA, [Out] float3 BOLMGEKNLLN, [In][NoAlias] float3* JBCNMGEGDKH, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6931780", Offset = "0x6930180", VA = "0x186931780")]
	private void DLJODGMLNGD(NativeArray<float3> PNCIBBBOELM, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6931840", Offset = "0x6930240", VA = "0x186931840")]
	[BurstCompile]
	private unsafe static void DLJODGMLNGD([NoAlias] ushort* ADFOLCJJBKM, [In][NoAlias] float3* PNCIBBBOELM, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69308D0", Offset = "0x692F2D0", VA = "0x1869308D0")]
	private void BKMPMNOBEEA(NativeArray<float3> IAADDCLFGEG, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6930860", Offset = "0x692F260", VA = "0x186930860")]
	[BurstCompile]
	private unsafe static void BKMPMNOBEEA([NoAlias] float3* IAADDCLFGEG, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6930640", Offset = "0x692F040", VA = "0x186930640")]
	[BurstCompile]
	private unsafe static void BIOLLGMFBOH([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6932F90", Offset = "0x6931990", VA = "0x186932F90")]
	[BurstCompile]
	private unsafe static void HAHDNNBDAMN([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6931270", Offset = "0x692FC70", VA = "0x186931270")]
	[BurstCompile]
	private unsafe static void CCMAKFGJJJH([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6931CB0", Offset = "0x69306B0", VA = "0x186931CB0")]
	private void DNDBMDEMPME(NativeArray<float2> IDCJLNFABHG, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6931A60", Offset = "0x6930460", VA = "0x186931A60")]
	[BurstCompile]
	private unsafe static void DNDBMDEMPME([NoAlias] ushort* FLMBIBGGLKO, [Out] float2 DLCOAIHPAIP, [Out] float2 JEOJDNAAEJE, [In][NoAlias] float2* IDCJLNFABHG, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x692F920", Offset = "0x692E320", VA = "0x18692F920")]
	[BurstCompile]
	private static void AEJFCGIAKLP([Out] float2 BBKNOBEIKNO, ushort HMFOOIHANFN, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69330C0", Offset = "0x6931AC0", VA = "0x1869330C0")]
	private void HHKJONJPLDM(NativeArray<float2> FLMBIBGGLKO, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69331C0", Offset = "0x6931BC0", VA = "0x1869331C0")]
	[BurstCompile]
	private unsafe static void HHKJONJPLDM([NoAlias] float2* FLMBIBGGLKO, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6930AC0", Offset = "0x692F4C0", VA = "0x186930AC0")]
	[BurstCompile]
	private unsafe static void BPOMIAPDMJO([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6931F20", Offset = "0x6930920", VA = "0x186931F20")]
	[BurstCompile]
	private unsafe static void ECOLLPBKBPH([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6935C00", Offset = "0x6934600", VA = "0x186935C00")]
	[BurstCompile]
	private unsafe static void OOGGLPPPIHP([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69312E0", Offset = "0x692FCE0", VA = "0x1869312E0")]
	private void CDJMFPPAPOK(NativeArray<float4> ILJPCMMMJGF, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69313D0", Offset = "0x692FDD0", VA = "0x1869313D0")]
	[BurstCompile]
	private unsafe static void CDJMFPPAPOK([NoAlias] ushort* IOJFFEEFMMF, [In][NoAlias] float4* HCEJJHPNMHC, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x692F8D0", Offset = "0x692E2D0", VA = "0x18692F8D0")]
	[BurstCompile]
	private static ushort ADGFBECKDBK([In] float4 KAFAEACCHBG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69359F0", Offset = "0x69343F0", VA = "0x1869359F0")]
	private void NNGJKPIDHOI(NativeArray<float4> IOJFFEEFMMF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6935AC0", Offset = "0x69344C0", VA = "0x186935AC0")]
	[BurstCompile]
	private unsafe static void NNGJKPIDHOI([NoAlias] float4* IOJFFEEFMMF, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6934A00", Offset = "0x6933400", VA = "0x186934A00")]
	[BurstCompile]
	private unsafe static void LNMKFHKKLAG([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69335A0", Offset = "0x6931FA0", VA = "0x1869335A0")]
	[BurstCompile]
	private unsafe static void IBOHJJMNMPN([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6932800", Offset = "0x6931200", VA = "0x186932800")]
	[BurstCompile]
	private unsafe static void FNMIGBODDNM([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6930B40", Offset = "0x692F540", VA = "0x186930B40")]
	[BurstCompile]
	private static void CAHLPJFLEGJ([Out] float4 EBPHIJANMPN, ushort HMFOOIHANFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6930120", Offset = "0x692EB20", VA = "0x186930120")]
	private void BFGIIDAMFPE(Allocator BPMIGAHMDHE, NativeArray<float4> DKJDNKLKHIG, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x692FED0", Offset = "0x692E8D0", VA = "0x18692FED0")]
	[BurstCompile]
	private unsafe static void BFGIIDAMFPE([NoAlias] float4* IDOAEOEJMHL, [NoAlias] byte* FHHEOBKBMEK, [Out] int DDCDBNABKGO, [Out] int FLEEEDDEJPB, [NoAlias] float4* DKJDNKLKHIG, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6933CF0", Offset = "0x69326F0", VA = "0x186933CF0")]
	private static void JHGAAOLAHPJ(NativeArray<float4> FFMLFFOEKLF, NativeArray<MDNPAMNHCKI> OGLPFLDJCNE, NativeArray<byte> HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6933E00", Offset = "0x6932800", VA = "0x186933E00")]
	[BurstCompile]
	private unsafe static void JHGAAOLAHPJ([NoAlias] float4* FFMLFFOEKLF, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6935380", Offset = "0x6933D80", VA = "0x186935380")]
	[BurstCompile]
	private unsafe static void MEJEIFEODPK([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6932580", Offset = "0x6930F80", VA = "0x186932580")]
	[BurstCompile]
	private unsafe static void FFHMNHOMLDN([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6933910", Offset = "0x6932310", VA = "0x186933910")]
	[BurstCompile]
	private unsafe static void JCMPOJJCOEK([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6934920", Offset = "0x6933320", VA = "0x186934920")]
	private void LKOONBMFCPK(Allocator BPMIGAHMDHE, NativeArray<int> KGAJNDNCING, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6933A80", Offset = "0x6932480", VA = "0x186933A80")]
	private static NativeArray<byte> JHBCBLICOJO(Allocator BPMIGAHMDHE, NativeArray<int> KGAJNDNCING, int AMGGPAGMEOA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6933A10", Offset = "0x6932410", VA = "0x186933A10")]
	[BurstCompile]
	private unsafe static int JHBCBLICOJO([NoAlias] byte* DIBFNAODPNK, [In][NoAlias] int* KGAJNDNCING, int AMGGPAGMEOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6935DD0", Offset = "0x69347D0", VA = "0x186935DD0")]
	private static void PNHHBDFKFPK(NativeArray<int> OPBCHHIOCGN, NativeArray<byte> CECBKNDEEEH, int FBOAKBIHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6935D60", Offset = "0x6934760", VA = "0x186935D60")]
	[BurstCompile]
	private unsafe static void PNHHBDFKFPK([NoAlias] int* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6935B90", Offset = "0x6934590", VA = "0x186935B90")]
	[BurstCompile]
	private unsafe static void OCKLIDNPDPF([NoAlias] ushort* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6935B30", Offset = "0x6934530", VA = "0x186935B30")]
	[BurstCompile]
	private static void NPMEGFDABOP([Out] float3 BBKNOBEIKNO, ushort HMFOOIHANFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6935660", Offset = "0x6934060", VA = "0x186935660")]
	[BurstCompile]
	private static ushort NMOFJEGOIMF([In] float3 KAFAEACCHBG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public EBNJBMIMMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6928F30", Offset = "0x6927930", VA = "0x186928F30")]
	[BurstCompile]
	public unsafe static void GKKHBEDNNAG([NoAlias] float3* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6934D40", Offset = "0x6933740", VA = "0x186934D40")]
	[BurstCompile]
	public unsafe static void MBMHJPKIKLG([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6933000", Offset = "0x6931A00", VA = "0x186933000")]
	[BurstCompile]
	public unsafe static void HCKPPIMPPKG([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x692F9A0", Offset = "0x692E3A0", VA = "0x18692F9A0")]
	[BurstCompile]
	public unsafe static void AIGMDFBOLBN([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* JBCNMGEGDKH, int PMNNDMLMMHM, [In] float3 ILOCOIOGNMH, [In] float3 BOLMGEKNLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6928490", Offset = "0x6926E90", VA = "0x186928490")]
	[BurstCompile]
	public unsafe static void AKLIKKHJIJA([NoAlias] ushort* PEBHNCDODKK, [Out] float3 DJLGCPHOPGA, [Out] float3 BOLMGEKNLLN, [In][NoAlias] float3* JBCNMGEGDKH, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6929340", Offset = "0x6927D40", VA = "0x186929340")]
	[BurstCompile]
	public unsafe static void LOPOGEJKBBF([NoAlias] ushort* ADFOLCJJBKM, [In][NoAlias] float3* PNCIBBBOELM, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6932910", Offset = "0x6931310", VA = "0x186932910")]
	[BurstCompile]
	public unsafe static void GHOINCDFDBL([NoAlias] float3* IAADDCLFGEG, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6928B30", Offset = "0x6927530", VA = "0x186928B30")]
	[BurstCompile]
	public unsafe static void DAKDNBPCOMF([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6933610", Offset = "0x6932010", VA = "0x186933610")]
	[BurstCompile]
	public unsafe static void IPFKAOAAPJC([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69347D0", Offset = "0x69331D0", VA = "0x1869347D0")]
	[BurstCompile]
	public unsafe static void KNCALDJKJLB([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* PNCIBBBOELM, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6928870", Offset = "0x6927270", VA = "0x186928870")]
	[BurstCompile]
	public unsafe static void CKGHKHLNEGJ([NoAlias] ushort* FLMBIBGGLKO, [Out] float2 DLCOAIHPAIP, [Out] float2 JEOJDNAAEJE, [In][NoAlias] float2* IDCJLNFABHG, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6931730", Offset = "0x6930130", VA = "0x186931730")]
	[BurstCompile]
	public static void DKNGPANHEIE([Out] float2 BBKNOBEIKNO, ushort HMFOOIHANFN, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69346F0", Offset = "0x69330F0", VA = "0x1869346F0")]
	[BurstCompile]
	public unsafe static void KLNHMMLLJKJ([NoAlias] float2* FLMBIBGGLKO, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6934600", Offset = "0x6933000", VA = "0x186934600")]
	[BurstCompile]
	public unsafe static void KINOKNNLJKB([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x692FDD0", Offset = "0x692E7D0", VA = "0x18692FDD0")]
	[BurstCompile]
	public unsafe static void BEJOGKODLCN([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x692FA60", Offset = "0x692E460", VA = "0x18692FA60")]
	[BurstCompile]
	public unsafe static void AMGOANFEPEH([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [NoAlias] ushort* IDCJLNFABHG, int PMNNDMLMMHM, [In] float2 MGJGLAKCMJP, [In] float2 JEOJDNAAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6931600", Offset = "0x6930000", VA = "0x186931600")]
	[BurstCompile]
	public unsafe static void CMCFDMDIIMF([NoAlias] ushort* IOJFFEEFMMF, [In][NoAlias] float4* HCEJJHPNMHC, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6935D00", Offset = "0x6934700", VA = "0x186935D00")]
	[BurstCompile]
	public static ushort PEGNOJOLPEI([In] float4 KAFAEACCHBG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6931E80", Offset = "0x6930880", VA = "0x186931E80")]
	[BurstCompile]
	public unsafe static void ECJLEDKBGGL([NoAlias] float4* IOJFFEEFMMF, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69295A0", Offset = "0x6927FA0", VA = "0x1869295A0")]
	[BurstCompile]
	public unsafe static void PIJKICNLINE([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69309A0", Offset = "0x692F3A0", VA = "0x1869309A0")]
	[BurstCompile]
	public unsafe static void BLDANGMOHJN([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6931450", Offset = "0x692FE50", VA = "0x186931450")]
	[BurstCompile]
	public unsafe static void CHKDHJBACHC([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] ushort* ILJPCMMMJGF, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6932740", Offset = "0x6931140", VA = "0x186932740")]
	[BurstCompile]
	public static void FMCINCNHEFE([Out] float4 EBPHIJANMPN, ushort HMFOOIHANFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6928D70", Offset = "0x6927770", VA = "0x186928D70")]
	[BurstCompile]
	public unsafe static void EHCMMCIMBEO([NoAlias] float4* IDOAEOEJMHL, [NoAlias] byte* FHHEOBKBMEK, [Out] int DDCDBNABKGO, [Out] int FLEEEDDEJPB, [NoAlias] float4* DKJDNKLKHIG, int KBGNNMMHPLE, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6930500", Offset = "0x692EF00", VA = "0x186930500")]
	[BurstCompile]
	public unsafe static void BIDDLJEENPN([NoAlias] float4* FFMLFFOEKLF, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6933730", Offset = "0x6932130", VA = "0x186933730")]
	[BurstCompile]
	public unsafe static void JANDANIAJMF([NoAlias] AEOIJLLIIPA.LMFIPOGLPNA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69333C0", Offset = "0x6931DC0", VA = "0x1869333C0")]
	[BurstCompile]
	public unsafe static void IAKPJGMMGHE([NoAlias] AEOIJLLIIPA.BIAGBMFBMEO* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6935EA0", Offset = "0x69348A0", VA = "0x186935EA0")]
	[BurstCompile]
	public unsafe static void PPCDDEHLPGJ([NoAlias] AEOIJLLIIPA.DDKBLEHJBFA* PEBHNCDODKK, [In][NoAlias] MDNPAMNHCKI* OGLPFLDJCNE, [In][NoAlias] byte* HDGIDHBEFIA, int PMNNDMLMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6931D80", Offset = "0x6930780", VA = "0x186931D80")]
	[BurstCompile]
	public unsafe static int DNIJHKFFGFG([NoAlias] byte* DIBFNAODPNK, [In][NoAlias] int* KGAJNDNCING, int AMGGPAGMEOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6932870", Offset = "0x6931270", VA = "0x186932870")]
	[BurstCompile]
	public unsafe static void GENNCHDDLAN([NoAlias] int* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6931560", Offset = "0x692FF60", VA = "0x186931560")]
	[BurstCompile]
	public unsafe static void CKMOJNMPEEE([NoAlias] ushort* OPBCHHIOCGN, [In][NoAlias] byte* CECBKNDEEEH, int FBOAKBIHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6932600", Offset = "0x6931000", VA = "0x186932600")]
	[BurstCompile]
	public static void FHDIAAEGBIL([Out] float3 BBKNOBEIKNO, ushort HMFOOIHANFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6929180", Offset = "0x6927B80", VA = "0x186929180")]
	[BurstCompile]
	public static ushort LMDHJBKGLCI([In] float3 KAFAEACCHBG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DCEKPGBLDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 DMLMLBJLCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 BEOHJFBPBPK;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class IBECMLOHPFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<DCEKPGBLDFD> LHICNHPNLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> ANGEGJPKKJP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NKAFOLBGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8566A0", Offset = "0x8550A0", VA = "0x1808566A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x693AC30", Offset = "0x6939630", VA = "0x18693AC30")]
	public IBECMLOHPFI(int MNGECEBMIEA, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x693AAF0", Offset = "0x69394F0", VA = "0x18693AAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x693AB50", Offset = "0x6939550", VA = "0x18693AB50")]
	public void MKOPHGCIALK(IBECMLOHPFI AMFLOFIGNCE, int KCDMDPGHMHG, int PFNBAEBFNFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IGDHACILAME
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static IBECMLOHPFI DJGNOKMPLBB;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<GNGCCKIDABH> OLMBHPGMEJO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] CIBNIAIIEHF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool FELAHOGNAJB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, IBECMLOHPFI> KAIIAOHFJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, IBECMLOHPFI> HNEDLAIHNMB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool EIOFLNDAABN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x693B700", Offset = "0x693A100", VA = "0x18693B700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<GNGCCKIDABH> GMOGKBIHMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x693C080", Offset = "0x693AA80", VA = "0x18693C080")]
		get
		{
			return default(NativeList<GNGCCKIDABH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static IBECMLOHPFI JMODLJIAEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x693C300", Offset = "0x693AD00", VA = "0x18693C300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x693B0B0", Offset = "0x6939AB0", VA = "0x18693B0B0")]
	private static void BIAPNLFBMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x693B8A0", Offset = "0x693A2A0", VA = "0x18693B8A0")]
	public static int EPLBPAOJCPD(bool DLJJPFHGOBI, int DDCCBOEOLNC, bool KDDCIFGLDJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x693C120", Offset = "0x693AB20", VA = "0x18693C120")]
	private static int KGOIMBEOOJF(int DDCCBOEOLNC, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x693C140", Offset = "0x693AB40", VA = "0x18693C140")]
	private static int LNHPMCGLIAC(int DDCCBOEOLNC, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x693B810", Offset = "0x693A210", VA = "0x18693B810")]
	public static int ELCNFOCIILI(int IADKDCBBENH, int DDCCBOEOLNC, int NFBOLONLAJD, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x693B780", Offset = "0x693A180", VA = "0x18693B780")]
	public static int EINDIFFFFPN(int IADKDCBBENH, int DDCCBOEOLNC, int NFBOLONLAJD, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x693C150", Offset = "0x693AB50", VA = "0x18693C150")]
	public static int MHHHJEAADMB(int NFBOLONLAJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x693B0A0", Offset = "0x6939AA0", VA = "0x18693B0A0")]
	private static int ALJJDPADIFD(int DDCCBOEOLNC, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x693BB60", Offset = "0x693A560", VA = "0x18693BB60")]
	private static int HCEDHCANPAE(int DDCCBOEOLNC, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x693ACF0", Offset = "0x69396F0", VA = "0x18693ACF0")]
	public static int ACCHFKKAJKF(int IADKDCBBENH, int DDCCBOEOLNC, int NFBOLONLAJD, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x693C270", Offset = "0x693AC70", VA = "0x18693C270")]
	public static int NGAEOOHNCBF(int IADKDCBBENH, int DDCCBOEOLNC, int NFBOLONLAJD, bool LFEJLPPCGFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x693C160", Offset = "0x693AB60", VA = "0x18693C160")]
	public static int NEBNGHCIBCI(int NFBOLONLAJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x693C180", Offset = "0x693AB80", VA = "0x18693C180")]
	public static IBECMLOHPFI NFMOPNFOFKE(int DDCCBOEOLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x693B8D0", Offset = "0x693A2D0", VA = "0x18693B8D0")]
	private static IBECMLOHPFI FAPNGJGGNPJ(int DDCCBOEOLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x693BB80", Offset = "0x693A580", VA = "0x18693BB80")]
	public static IBECMLOHPFI HOMMMBALFHB(int DDCCBOEOLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x693AD60", Offset = "0x6939760", VA = "0x18693AD60")]
	private static IBECMLOHPFI AJPPOGJGGLF(int DDCCBOEOLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x693BC70", Offset = "0x693A670", VA = "0x18693BC70")]
	public static void IMHCGHCDCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EBKCGDALKHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int DEILBPNCEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 DGKFMMGCNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion NBBLNIODLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float EMHEOCJABLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float IDAKECALNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int ELGPMOBIFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int CFMBBGMFHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int IFKIHIMJMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool MJNGHJJPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool BDBHEMIOHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float MDBGILJIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 HEJEHEAHMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool KCKGJAJANHE;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MOPCHPNNKBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int EGMAPMOBAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int JKLDPAKDINC;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MGDMKKFIOBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<EBKCGDALKHK> KODEDMEPJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<PEHEHHOPNDC> GEIBLGCLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<GNGCCKIDABH> AGCHGAGPAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<MOPCHPNNKBP> JADJLCEFPFO;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6941840", Offset = "0x6940240", VA = "0x186941840")]
	public MGDMKKFIOBN(NativeArray<PEHEHHOPNDC> GEIBLGCLILA, int BKEGNEKBPFA = 1, Allocator BPMIGAHMDHE = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6941750", Offset = "0x6940150", VA = "0x186941750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct LGEAFHFAPKH : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<DCEKPGBLDFD> KMOEDNGDIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> GLGEIJLEODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<GNGCCKIDABH> LBJCELNEIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<EBKCGDALKHK> KODEDMEPJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<PEHEHHOPNDC> GEIBLGCLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<GNGCCKIDABH> AGCHGAGPAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<MOPCHPNNKBP> JADJLCEFPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int GBKKPOOGCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int JNHPFJEGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 JLNNAJEMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion AAAIPOMAMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 HNAIFOBBFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FPJMPCDBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ONGOMFPIMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AOPFIDINOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KAJBDMCNKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MDKGHNGAHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MILAACGEJMP;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6940B40", Offset = "0x693F540", VA = "0x186940B40")]
	public LGEAFHFAPKH(DHOOIPBKPIJ ECBJHFEODPG, AEOIJLLIIPA NNAJGBINAJK, float3 GCNMLMPCCAD, quaternion CKPJJHDKOLP, float HEJNJIALJHA, int BBKAFGKEJAD = 0, int JGPJJFNPFGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6940DD0", Offset = "0x693F7D0", VA = "0x186940DD0")]
	public LGEAFHFAPKH(MGDMKKFIOBN ECBJHFEODPG, AEOIJLLIIPA NNAJGBINAJK, float3 GCNMLMPCCAD, quaternion CKPJJHDKOLP, float3 HEJNJIALJHA, int BBKAFGKEJAD = 0, int JGPJJFNPFGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x693FDE0", Offset = "0x693E7E0", VA = "0x18693FDE0")]
	private float3 GFJAHCOKHAJ(float3 NMEHDMMGBMO, Matrix4x4 ILGJMFCJODC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x693EBC0", Offset = "0x693D5C0", VA = "0x18693EBC0")]
	private float3x3 BHNIDPNJDHH(float3x3 EOAANJOIIAG, float3x3 OHMAACKLFPJ)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x693FF10", Offset = "0x693E910", VA = "0x18693FF10")]
	private float HPAIOKGNLOH(float GIFACOBMIEN, float MBKIFKDCCIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x693EC40", Offset = "0x693D640", VA = "0x18693EC40", Slot = "4")]
	public void Execute(int OPBNGFFAEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6940380", Offset = "0x693ED80", VA = "0x186940380")]
	private void KHDIHIEDDCH(int AFHNCKBEPEL, float3 GLNEOPDBMFP, float3 GKJCNLBHEIK, float3 GMLKGNBBAOM, float EHEGOIJKGEH, bool OIINMCGBOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x693FF20", Offset = "0x693E920", VA = "0x18693FF20")]
	private void JKGEFAOIHAG(EBKCGDALKHK KCKNAJKPKLE, float3 FKMPANFIJIC, float3x3 CMAJCEDKDLM, float GIFACOBMIEN, int GNAAPFHEMIM, int OCKFJAGKFBN, int OKKJIDHKMPA, float IHKAEDPDEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x69404F0", Offset = "0x693EEF0", VA = "0x1869404F0")]
	private void MBMPMLFOPFA(int AFHNCKBEPEL, int EANDNBGHFOM, EBKCGDALKHK KCKNAJKPKLE, float3 FKMPANFIJIC, float3x3 CMAJCEDKDLM, bool JJBHMHEBNIJ, float GIFACOBMIEN, int AEAAEMHAMPP, int DLHFINFIGAP, int OKKJIDHKMPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct CIACOHNFNMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<CDIHAFDBKHN> CCAGLBHCKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<GNGCCKIDABH> IHDAEIGDKAK;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x692C540", Offset = "0x692AF40", VA = "0x18692C540")]
	public CIACOHNFNMK(int BKEGNEKBPFA, Allocator BPMIGAHMDHE = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x692C4A0", Offset = "0x692AEA0", VA = "0x18692C4A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct ACOLGAMFCFE : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum JBMKCONNOHA
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
	private NativeList<float3> GHACMJHBFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> CBBPFBMDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> CPIHKGKNBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> AHPEBPPMCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> KKPMOPKCKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> ACLENNMOIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> GGPMNNNEKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> PKJNBBGALCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<GNGCCKIDABH> MFPEJCFABPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<CDIHAFDBKHN> CCAGLBHCKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<GNGCCKIDABH> IHDAEIGDKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int GBKKPOOGCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int JNHPFJEGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FPJMPCDBIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ONGOMFPIMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AOPFIDINOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KAJBDMCNKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MDKGHNGAHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MILAACGEJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 HNAIFOBBFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion AAAIPOMAMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 JLNNAJEMKFL;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x692B240", Offset = "0x6929C40", VA = "0x18692B240")]
	public ACOLGAMFCFE(DHOOIPBKPIJ ECBJHFEODPG, AEOIJLLIIPA NNAJGBINAJK, float3 GCNMLMPCCAD, quaternion CKPJJHDKOLP, float HEJNJIALJHA, int BBKAFGKEJAD = 0, int JGPJJFNPFGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x692B430", Offset = "0x6929E30", VA = "0x18692B430")]
	public ACOLGAMFCFE(CIACOHNFNMK EEOBDBMOHPL, AEOIJLLIIPA NNAJGBINAJK, float3 GCNMLMPCCAD, quaternion CKPJJHDKOLP, float3 HEJNJIALJHA, int BBKAFGKEJAD = 0, int JGPJJFNPFGE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6929EA0", Offset = "0x69288A0", VA = "0x186929EA0", Slot = "4")]
	public void Execute(int OPBNGFFAEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x692AE90", Offset = "0x6929890", VA = "0x18692AE90")]
	private void LHFNOBEOMCI(float4x4 JPPEKANEHBC, int OPBNGFFAEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6929E30", Offset = "0x6928830", VA = "0x186929E30")]
	private JBMKCONNOHA DFNFECELOMM(float3 GKJCNLBHEIK)
	{
		return default(JBMKCONNOHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x692AE40", Offset = "0x6929840", VA = "0x18692AE40")]
	private float4 FOHKFNMFGPG(JBMKCONNOHA AMALFPBCHHH, int ILOCEPPJPDO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x692AE00", Offset = "0x6929800", VA = "0x18692AE00")]
	private float2 FIKFNFHCFFG(JBMKCONNOHA AMALFPBCHHH, float3 GLNEOPDBMFP)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct CDMKMDCBFDP
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum OAGOMEILKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static CDMKMDCBFDP EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 IOJOFKPMLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 JIIABDGOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 DLJBGHKKEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public OAGOMEILKJJ PNFBJLDEHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 BNOEJJEAIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 AGDKPHKGOPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x692BB00", Offset = "0x692A500", VA = "0x18692BB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 OHIGOIMIMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x692BA20", Offset = "0x692A420", VA = "0x18692BA20")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x692C3B0", Offset = "0x692ADB0", VA = "0x18692C3B0")]
	public CDMKMDCBFDP(float3 GLNEOPDBMFP, quaternion NGGFFKDNCFB, float3 BKEGNEKBPFA, OAGOMEILKJJ ADDOHDGDFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x692BE90", Offset = "0x692A890", VA = "0x18692BE90")]
	public float DPONOABKCFC(float3 FKMPANFIJIC, float LOGEIABIEDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x692BDA0", Offset = "0x692A7A0", VA = "0x18692BDA0")]
	public bool AOHBLMAJLAM(float3 GKJCNLBHEIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x692C190", Offset = "0x692AB90", VA = "0x18692C190")]
	public void PKOBBIHCJLO(float3 HGJKMPGHBLA, float3x3 MBDEIAHBIBA, float DBJAPEOFFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x692C090", Offset = "0x692AA90", VA = "0x18692C090")]
	private void IGOAJLDJMIL(float3 EKHDIPBLLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x692BB10", Offset = "0x692A510", VA = "0x18692BB10")]
	public void ANGKJEJPCLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct FPJCPEAOBHN : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<CDMKMDCBFDP> EEOBDBMOHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> GGCPLLDHPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> AGIIHBHOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DFGOBEDECDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<GNGCCKIDABH> IHDAEIGDKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int JKLOCMMPEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int KPNLJPBEOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float LOGEIABIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float ABNEEADPGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MFGIIBALKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CMFHJMLBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> FOIKLHPMOCH;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6937F60", Offset = "0x6936960", VA = "0x186937F60")]
	public FPJCPEAOBHN(AEOIJLLIIPA KJFFCELEION, float FAICPAHHJPH, int PFNBAEBFNFJ, int GNAAPFHEMIM, NativeList<CDMKMDCBFDP> EEOBDBMOHPL, NativeArray<int> DFGOBEDECDE, NativeList<GNGCCKIDABH> IHDAEIGDKAK, EDPFGOEHLGG GCBAPFPCNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6937820", Offset = "0x6936220", VA = "0x186937820", Slot = "4")]
	public void Execute(int PNKGOLHBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x69374C0", Offset = "0x6935EC0", VA = "0x1869374C0")]
	private bool AKIDEDEGAGH(CDMKMDCBFDP GDMICPKKGFK, CDMKMDCBFDP JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6937580", Offset = "0x6935F80", VA = "0x186937580")]
	private bool BNJEANEOHCF(CDMKMDCBFDP FKNKIJMNFJI, int EAECEJKGHOK, int KEHBLLHFKGB, int IAJKNEOEKCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EDPFGOEHLGG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> KLDPPLPFJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> BMMDKJEBMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> KCDEIHLGIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> NCCOLGGOEPN;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6936170", Offset = "0x6934B70", VA = "0x186936170")]
	public void KDNHMNFFJOO(int MNGECEBMIEA, int AENDFGPLPAL, Allocator BPMIGAHMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6936290", Offset = "0x6934C90", VA = "0x186936290")]
	public static long LCAOHJHNBDL(int MNGECEBMIEA, int AENDFGPLPAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6936080", Offset = "0x6934A80", VA = "0x186936080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x69362B0", Offset = "0x6934CB0", VA = "0x1869362B0")]
	public void NELEFDBDAJB(JobHandle IOPBMLMLGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public EDPFGOEHLGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct JEHFJBPDKLI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> GGCPLLDHPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> LFGGFECHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> PCIGOGHCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> MGJKKAOJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> AGIIHBHOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EEOAIIBHAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> CNCIBHLNGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> MFGIIBALKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> CMFHJMLBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int BBKAFGKEJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int JGPJJFNPFGE;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x693CE60", Offset = "0x693B860", VA = "0x18693CE60")]
	public JEHFJBPDKLI(AEOIJLLIIPA KJFFCELEION, EDPFGOEHLGG GCBAPFPCNFK, int JGPJJFNPFGE = 0, int BBKAFGKEJAD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x693CA80", Offset = "0x693B480", VA = "0x18693CA80", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x693CA20", Offset = "0x693B420", VA = "0x18693CA20")]
	private void EJJOEBNKNLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KJHDMPOABMF
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9D60", Offset = "0x2BB8760", VA = "0x182BB9D60")]
	public static bool FHKHKHLJNEM<T>(NativeArray<T> MHMBNFEOIBK, int BKEGNEKBPFA, Allocator BPMIGAHMDHE, NativeArrayOptions FKJNBGBCACC = NativeArrayOptions.ClearMemory, int APIACOBOLOL = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9E20", Offset = "0x2BB8820", VA = "0x182BB9E20")]
	public static bool FHKHKHLJNEM<T>(NativeList<T> AGFBCPPODBI, int BKEGNEKBPFA, Allocator BPMIGAHMDHE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum BDOEGCALIDM
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
public interface PJCIMFHBGCB
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CBMFJMHKNDJ(BDOEGCALIDM IADKDCBBENH);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GBBDHGCPEMF(BDOEGCALIDM IADKDCBBENH);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds EKHLJJCPIEN();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float BGDKKOFFDNI();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDHKJCIBFLO(BDOEGCALIDM IADKDCBBENH, DHOOIPBKPIJ GBGDEKJMCMB, int DKDLHHEJGFD = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class AEOIJLLIIPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum BFOIAECHFDO
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
	public struct GFECHDHAKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public BFOIAECHFDO PHCNDPLEFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool OBFBMFBFPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int JOMGLMFIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] CMOLJFKMKNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct GEDKHKHGADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 GLNEOPDBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 GKJCNLBHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 GMLKGNBBAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 BLDPBPFHOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 PCIGOGHCKAD;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] CMOLJFKMKNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct LMFIPOGLPNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 GLNEOPDBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 GKJCNLBHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 GMLKGNBBAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 BLDPBPFHOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 PCIGOGHCKAD;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] CMOLJFKMKNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct OGABLHFKHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 GLNEOPDBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 GKJCNLBHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 GMLKGNBBAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 BLDPBPFHOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint PCIGOGHCKAD;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] CMOLJFKMKNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct BIAGBMFBMEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 GLNEOPDBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint GKJCNLBHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint GMLKGNBBAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 BLDPBPFHOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 PCIGOGHCKAD;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] CMOLJFKMKNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct DDKBLEHJBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 GLNEOPDBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint GKJCNLBHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint GMLKGNBBAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 BLDPBPFHOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 PCIGOGHCKAD;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] CMOLJFKMKNC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int HDJAABIMJEE(float PHDMOAMCFBE);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class OGPGEPFLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x695CEC0", Offset = "0x695B8C0", VA = "0x18695CEC0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x695CD60", Offset = "0x695B760", VA = "0x18695CD60")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x695CFF0", Offset = "0x695B9F0", VA = "0x18695CFF0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x695CAF0", Offset = "0x695B4F0", VA = "0x18695CAF0")]
		public static int EDIAJIJOMBB(float PHDMOAMCFBE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint OIHLMHAOELE([In] float4 CGDFPKFKHGF);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class FDEIOMLCOEK
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6959CE0", Offset = "0x69586E0", VA = "0x186959CE0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6959B80", Offset = "0x6958580", VA = "0x186959B80")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6959E10", Offset = "0x6958810", VA = "0x186959E10")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6959840", Offset = "0x6958240", VA = "0x186959840")]
		public static uint EDIAJIJOMBB([In] float4 CGDFPKFKHGF)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint GBPDCGJAOCD([In] float3 CGDFPKFKHGF);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class KJIJBHBDHDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x695BF00", Offset = "0x695A900", VA = "0x18695BF00")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x695BDA0", Offset = "0x695A7A0", VA = "0x18695BDA0")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x695C030", Offset = "0x695AA30", VA = "0x18695C030")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x695BB20", Offset = "0x695A520", VA = "0x18695BB20")]
		public static uint EDIAJIJOMBB([In] float3 CGDFPKFKHGF)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void KEKFEGPLPDK([NoAlias] BIAGBMFBMEO* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class BBIKOCKCGIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x694F0B0", Offset = "0x694DAB0", VA = "0x18694F0B0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x694EF50", Offset = "0x694D950", VA = "0x18694EF50")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x694F1E0", Offset = "0x694DBE0", VA = "0x18694F1E0")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x694ED10", Offset = "0x694D710", VA = "0x18694ED10")]
		public unsafe static void EDIAJIJOMBB([NoAlias] BIAGBMFBMEO* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void APNDDIMIGGJ([NoAlias] DDKBLEHJBFA* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class FPKPMHOPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr GOAPPLMKMME;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr ODOJOHJLAHK;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x695A2F0", Offset = "0x6958CF0", VA = "0x18695A2F0")]
		[BurstDiscard]
		private static void JCMIGMPPKIK(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x695A190", Offset = "0x6958B90", VA = "0x18695A190")]
		private static IntPtr GDEBDKGDEOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x695A420", Offset = "0x6958E20", VA = "0x18695A420")]
		public static void KLONJBLNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public static void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6959F50", Offset = "0x6958950", VA = "0x186959F50")]
		public unsafe static void EDIAJIJOMBB([NoAlias] DDKBLEHJBFA* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int JGEGOMPGPKN = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> PJHABPGAEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> BCBCICIKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> LNDNPKINEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> ODOAEIPAPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> MNPEKLKENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> HMPJDJIDOJL;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] HBEOPCLOLBD;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool OHHCDLIIHHC;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static GFECHDHAKCM[] PIMIACDEFAD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DJEJGGIOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x694B860", Offset = "0x694A260", VA = "0x18694B860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x694A3C0", Offset = "0x6948DC0", VA = "0x18694A3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NKAFOLBGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x694DB90", Offset = "0x694C590", VA = "0x18694DB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MONHEEDKLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x694CA80", Offset = "0x694B480", VA = "0x18694CA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void KMMIMMGNDMJ(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD, string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x694AC40", Offset = "0x6949640", VA = "0x18694AC40", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x694BF60", Offset = "0x694A960", VA = "0x18694BF60")]
	public void KDNHMNFFJOO(int MNGECEBMIEA, int AENDFGPLPAL, Allocator BPMIGAHMDHE, bool JAFEJGHEJDA, bool OJKFFKNLBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x694D8A0", Offset = "0x694C2A0", VA = "0x18694D8A0")]
	public void MJMNCJAPAON(int MNGECEBMIEA, int AENDFGPLPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x694E1F0", Offset = "0x694CBF0", VA = "0x18694E1F0", Slot = "6")]
	public bool PEMBOPIDCBL(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x694B480", Offset = "0x6949E80", VA = "0x18694B480")]
	public bool HMICBKIJCLD(Mesh KJFFCELEION, bool FJOLFOCDFFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x694A590", Offset = "0x6948F90", VA = "0x18694A590")]
	public bool DJGBPNHAFJM(Mesh KJFFCELEION, AEOIJLLIIPA CLAFGNGIMED, bool FJOLFOCDFFO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x694CAC0", Offset = "0x694B4C0", VA = "0x18694CAC0")]
	public void MCPDMBIIOPN(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6949940", Offset = "0x6948340", VA = "0x186949940")]
	public void CHLCFIEJJIL(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x694B3E0", Offset = "0x6949DE0", VA = "0x18694B3E0")]
	[BurstCompile]
	public static int FHBLJCPIJAK(float PHDMOAMCFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x694B430", Offset = "0x6949E30", VA = "0x18694B430")]
	[BurstCompile]
	public static uint FHBLJCPIJAK([In] float4 CGDFPKFKHGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x694B390", Offset = "0x6949D90", VA = "0x18694B390")]
	[BurstCompile]
	public static uint FHBLJCPIJAK([In] float3 CGDFPKFKHGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x694AD50", Offset = "0x6949750", VA = "0x18694AD50")]
	public void EHBPMFEKMPD(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x694ABC0", Offset = "0x69495C0", VA = "0x18694ABC0")]
	[BurstCompile]
	private unsafe static void DMJPMAMAJJJ([NoAlias] BIAGBMFBMEO* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x694B920", Offset = "0x694A320", VA = "0x18694B920")]
	public void KDFLMGHCMDE(Mesh KJFFCELEION, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x694B8A0", Offset = "0x694A2A0", VA = "0x18694B8A0")]
	[BurstCompile]
	private unsafe static void HPCFNBCACLM([NoAlias] DDKBLEHJBFA* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x694DCB0", Offset = "0x694C6B0", VA = "0x18694DCB0")]
	public void NHJBBMFIOCL(Mesh KJFFCELEION, BFOIAECHFDO PHCNDPLEFBH, bool FJOLFOCDFFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x694D920", Offset = "0x694C320", VA = "0x18694D920")]
	public void MKOPHGCIALK(AEOIJLLIIPA KJFFCELEION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x694C430", Offset = "0x694AE30", VA = "0x18694C430")]
	public AEOIJLLIIPA KHMOMCMPNHI(Allocator BPMIGAHMDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x694A460", Offset = "0x6948E60", VA = "0x18694A460")]
	public long DBDANGDOFMG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x694A400", Offset = "0x6948E00", VA = "0x18694A400")]
	public static long DBDANGDOFMG(int DFMEDPGEFGB, int HDDKMNLPOCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x694C630", Offset = "0x694B030", VA = "0x18694C630")]
	public static long KILJJFIAPMI(int DFMEDPGEFGB, int HDDKMNLPOCH, BFOIAECHFDO PHCNDPLEFBH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x694C570", Offset = "0x694AF70", VA = "0x18694C570")]
	public long KILJJFIAPMI(BFOIAECHFDO PHCNDPLEFBH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69498E0", Offset = "0x69482E0", VA = "0x1869498E0")]
	public void CELOEIMEIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x694D510", Offset = "0x694BF10", VA = "0x18694D510")]
	public static void MEMPPGCNNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x694E200", Offset = "0x694CC00", VA = "0x18694E200")]
	public BFOIAECHFDO PGKCFLMLDBP()
	{
		return default(BFOIAECHFDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6949810", Offset = "0x6948210", VA = "0x186949810")]
	public static (int, int) BHBMNCPLNHG(Mesh KJFFCELEION)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x694DBD0", Offset = "0x694C5D0", VA = "0x18694DBD0")]
	public static int NHDMICEDAJA(VertexAttributeDescriptor[] MONGPCLAEPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x69497A0", Offset = "0x69481A0", VA = "0x1869497A0")]
	public static long AIBBBAJDHGO(Mesh KJFFCELEION, int LAMGGBFCEIJ, int MJLPEOBHJMJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public AEOIJLLIIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x694C150", Offset = "0x694AB50", VA = "0x18694C150")]
	[BurstCompile]
	public static int KHMCCHBBJHI(float PHDMOAMCFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x694C1F0", Offset = "0x694ABF0", VA = "0x18694C1F0")]
	[BurstCompile]
	public static uint KHMCCHBBJHI([In] float4 CGDFPKFKHGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x694C380", Offset = "0x694AD80", VA = "0x18694C380")]
	[BurstCompile]
	public static uint KHMCCHBBJHI([In] float3 CGDFPKFKHGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x694C6D0", Offset = "0x694B0D0", VA = "0x18694C6D0")]
	[BurstCompile]
	public unsafe static void KMFDICEAJIO([NoAlias] BIAGBMFBMEO* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x694DDA0", Offset = "0x694C7A0", VA = "0x18694DDA0")]
	[BurstCompile]
	public unsafe static void OKJLKIHKING([NoAlias] DDKBLEHJBFA* PEBHNCDODKK, int PMNNDMLMMHM, [In][NoAlias] float3* FICHHPJDHKH, [In][NoAlias] float3* LFGGFECHHCL, [In][NoAlias] float4* EEOAIIBHAMK, [In][NoAlias] float2* MGJKKAOJLDH, [In][NoAlias] float4* PCIGOGHCKAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class MJADCIANDBP
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x695C7F0", Offset = "0x695B1F0", VA = "0x18695C7F0")]
	public static void IMHCGHCDCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class IJNICNFNKBA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> PJHABPGAEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> BCBCICIKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> BGKOOELNFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> MHMMKMMPLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> CMKIJBLAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> OEEJNDBNLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> KEOGGJOKGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> HMPJDJIDOJL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x695A680", Offset = "0x6959080", VA = "0x18695A680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NKAFOLBGCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x695AF60", Offset = "0x6959960", VA = "0x18695AF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NJHHJJKKDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x695AFA0", Offset = "0x69599A0", VA = "0x18695AFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x695B850", Offset = "0x695A250", VA = "0x18695B850")]
	public IJNICNFNKBA(int MNGECEBMIEA, int AENDFGPLPAL, int JFDEEPEEBOI, Allocator BPMIGAHMDHE = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x695B560", Offset = "0x6959F60", VA = "0x18695B560")]
	public IJNICNFNKBA(Mesh KJFFCELEION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x695A6C0", Offset = "0x69590C0", VA = "0x18695A6C0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x695AC60", Offset = "0x6959660", VA = "0x18695AC60")]
	public void MKOPHGCIALK(IJNICNFNKBA KJFFCELEION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x695A7D0", Offset = "0x69591D0", VA = "0x18695A7D0")]
	private void IPPFHLBPCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x695AFE0", Offset = "0x69599E0", VA = "0x18695AFE0")]
	private void PKDLIMMHNKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct GNGCCKIDABH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int EPABNAMKLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int DNEDLMPJAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int FEDIGKINMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int NKAFOLBGCJA;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x13E2400", Offset = "0x13E0E00", VA = "0x1813E2400")]
	public GNGCCKIDABH(int GNAAPFHEMIM, int PMNNDMLMMHM, int PFNBAEBFNFJ, int FBOAKBIHCNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class CFCCKEJPPEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<GNGCCKIDABH> LAKEEDOGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<GNGCCKIDABH>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9911C0", Offset = "0x98FBC0", VA = "0x1809911C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IJNICNFNKBA NJDMKGFBJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x694F4B0", Offset = "0x694DEB0", VA = "0x18694F4B0")]
	public CFCCKEJPPEB(IEnumerable<IJNICNFNKBA> EIGBIJCOJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x694F440", Offset = "0x694DE40", VA = "0x18694F440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum NEEKECBNPAF
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class LMKIOCHIGLN
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> PJIGEFELLCN;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> BAOABHJMDIC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> LDPECHKFDAE;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> NHPDAEPEPPP;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x695C5C0", Offset = "0x695AFC0", VA = "0x18695C5C0")]
	public static void IMHCGHCDCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x695C6E0", Offset = "0x695B0E0", VA = "0x18695C6E0")]
	public static NativeArray<float2> MIGFPDLFLGP(NativeArray<float2> OMFEOJOGKFO, int EEGILDOHJPJ, NativeArray<float2> FAGDNANACJF, int HDHJNDPIHNJ)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x695C3A0", Offset = "0x695ADA0", VA = "0x18695C3A0")]
	public static NativeArray<float3> EDEFOIPGPLE(NativeArray<float3> OMFEOJOGKFO, int EEGILDOHJPJ, NativeArray<float3> FAGDNANACJF, int HDHJNDPIHNJ)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x695C4B0", Offset = "0x695AEB0", VA = "0x18695C4B0")]
	public static NativeArray<float4> FLHAMNKCEIP(NativeArray<float4> OMFEOJOGKFO, int EEGILDOHJPJ, NativeArray<float4> FAGDNANACJF, int HDHJNDPIHNJ)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x695C290", Offset = "0x695AC90", VA = "0x18695C290")]
	public static NativeArray<int> CJAGBJMNNBL(NativeArray<int> OMFEOJOGKFO, int EEGILDOHJPJ, NativeArray<int> FAGDNANACJF, int HDHJNDPIHNJ)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE14C0", Offset = "0x2BDFEC0", VA = "0x182BE14C0")]
	private static void DILNIKGHDAB<T>(NativeArray<T> MHMBNFEOIBK, int NBOJFJPCDEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE16C0", Offset = "0x2BE00C0", VA = "0x182BE16C0")]
	private static void JGEPJFHJOHH<T>(NativeArray<T> OMFEOJOGKFO, int EEGILDOHJPJ, NativeArray<T> FAGDNANACJF, int HDHJNDPIHNJ, NativeArray<T> FGNEDPHMDDC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DOMKHBHDEFE
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum JAENOCDAINL
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
	public class FMOGODODJHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public EBNJBMIMMPJ KJFFCELEION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int JCEBAPCPPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int MPGDMIINJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long NDBKBEAJEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long BLMFBJPNOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float DIBCEBOCOFB;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6959F00", Offset = "0x6958900", VA = "0x186959F00")]
		public FMOGODODJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6959EC0", Offset = "0x69588C0", VA = "0x186959EC0")]
		public void NELEFDBDAJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string DOOIGKFIAOB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string AHOGOOEEBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker KDHGKIKPKMD;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker KDPGGCMPLEH;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker COGKANFGPGM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker NGFGOMNBPOB;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker JHKLLOLLAPN;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker BJHEOHGGEND;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker APDIDLCNGGA;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker GMCKBNEMHBC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker JOEINKDNJKH;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker LLBNBEGAALP;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker EBILPDKGJDJ;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker ENIMIADECMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<PJCIMFHBGCB> LHIBAIKPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly EIFADGOBFBO JLMCBPNENDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int PMNNDMLMMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int FBOAKBIHCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool OJCICBIHGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool NDDIALLOPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal JAENOCDAINL FAKDNFCMPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool CEBNOPIKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 AGBKONBBBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 FKHNAEMCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float APFDHJKPHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float OLNKOFILKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int OHPHAENJIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int HCJCJFIDNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int MFMJEPMOHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int HDEDBAMJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float BHIJPDCJPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float DJBDKJHBPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int LCGMNBGLGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long PEOHMCCAGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long PABGMBJCABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long DLPFIHJKLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int JPCOFNLBLGA;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int ELMNMDHEJIB = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] IDNAAKODEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] HBKPDLDCGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] KAMBNPLCMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private AEOIJLLIIPA AIKJPOHHELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long FJFPCNBHPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long JADELIOHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int FFPECAEMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<FMOGODODJHO> KPICEKJODBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float LCNPHMMEKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal AEOIJLLIIPA.BFOIAECHFDO CMHAOHGIGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool BFJJKOCBPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private ABKHIIHEHIJ JLFPGKNKEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle CDMPMDBDMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> ALEHDNHHNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool GMIFMNEMBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle IPCGDCEBNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private AEOIJLLIIPA FCLIPOMECNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform BAGGNMPEDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private BDOEGCALIDM GEFONPFHAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long JONJIMFHKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long LGMINGABNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long GBOOCAHAKLE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NJDMKGFBJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer DIHEHAJEBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int FNGLJJAJFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2E0", Offset = "0x8BACE0", VA = "0x1808BC2E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int KAMBHIFLDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC2A050", Offset = "0xC28A50", VA = "0x180C2A050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DNEDLMPJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6951470", Offset = "0x694FE70", VA = "0x186951470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<PJCIMFHBGCB> LCCFFHIMJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void KMMIMMGNDMJ(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD, string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6950D80", Offset = "0x694F780", VA = "0x186950D80")]
	public void BABIBKHLHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6957B20", Offset = "0x6956520", VA = "0x186957B20")]
	private void IPAAFJFCMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6959560", Offset = "0x6957F60", VA = "0x186959560")]
	public DOMKHBHDEFE(string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6958380", Offset = "0x6956D80", VA = "0x186958380")]
	public void NELEFDBDAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x69581A0", Offset = "0x6956BA0", VA = "0x1869581A0")]
	public void LPFHKBLPKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6950D90", Offset = "0x694F790", VA = "0x186950D90")]
	private void BBGNINIJLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6957100", Offset = "0x6955B00", VA = "0x186957100")]
	public void GLFKJNOAFCH(PJCIMFHBGCB PBJNABDOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6957F60", Offset = "0x6956960", VA = "0x186957F60")]
	public bool KLNIJLGEPDD(PJCIMFHBGCB PBJNABDOAJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6957AC0", Offset = "0x69564C0", VA = "0x186957AC0")]
	public bool IKNOCAOHLJM(PJCIMFHBGCB PBJNABDOAJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6954BC0", Offset = "0x69535C0", VA = "0x186954BC0", Slot = "4")]
	public virtual void EPKECFNCHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6958710", Offset = "0x6957110", VA = "0x186958710")]
	public void OGFALKIGBBF(Transform NEGPNIDHHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6957860", Offset = "0x6956260", VA = "0x186957860")]
	private long HJELAFEHEHI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6957940", Offset = "0x6956340", VA = "0x186957940")]
	private long HLINEFMDJDO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69557F0", Offset = "0x69541F0", VA = "0x1869557F0")]
	public bool FOFJLCDHJIE(Transform NEGPNIDHHGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6953940", Offset = "0x6952340", VA = "0x186953940")]
	public bool EENHFLGLOGF(bool IIFANLMFLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6951020", Offset = "0x694FA20", VA = "0x186951020")]
	public void BDJICNHENNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6951490", Offset = "0x694FE90", VA = "0x186951490")]
	public bool COIJEIACHIL(float4x4 CHLCJCBLBFB, BatchedMeshRenderer LEODIFJIEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69584A0", Offset = "0x6956EA0", VA = "0x1869584A0")]
	public void OCBNDCJLOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69511A0", Offset = "0x694FBA0", VA = "0x1869511A0")]
	public bool BOAJHGIKEBM(bool IIFANLMFLHP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6950D70", Offset = "0x694F770", VA = "0x186950D70")]
	public void AODPHGHENDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6958920", Offset = "0x6957320", VA = "0x186958920")]
	public void ONNLFLJNGPE(AEOIJLLIIPA KJFFCELEION, int LCNFCGDOJIH, int PCECFIOFBHP, float KFGLEOKCNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6959130", Offset = "0x6957B30", VA = "0x186959130")]
	public void PKJKPJNABLI(EBNJBMIMMPJ KOIHFFJAEIJ, int LCNFCGDOJIH, int PCECFIOFBHP, float KFGLEOKCNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6952A20", Offset = "0x6951420", VA = "0x186952A20")]
	public (long, long, long) DBDANGDOFMG()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x9EA650", Offset = "0x9E9050", VA = "0x1809EA650")]
	public long FOMDIEHHNAM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6958000", Offset = "0x6956A00", VA = "0x186958000")]
	private void KODMNMKLNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6952A90", Offset = "0x6951490", VA = "0x186952A90")]
	public (long, long) DLCIBEFFCNK(float ACOAKDBKDKB, float4x4 CHLCJCBLBFB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	public void BMLLCEHEMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6958260", Offset = "0x6956C60", VA = "0x186958260")]
	internal void MGNJHNLLDPO(JAENOCDAINL MOFAIBLGMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6952E60", Offset = "0x6951860", VA = "0x186952E60")]
	private (float, float, float) DOHFBBMOOAC(float OBMAIMNLKLI, float4x4 CHLCJCBLBFB)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x69574B0", Offset = "0x6955EB0", VA = "0x1869574B0")]
	private (int, int) HEHGGAPOJNK(float NINGJOOHDHL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x694FC00", Offset = "0x694E600", VA = "0x18694FC00")]
	public void AKEILOPCCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6954C70", Offset = "0x6953670", VA = "0x186954C70")]
	private void FAKEAJKJPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x69572D0", Offset = "0x6955CD0", VA = "0x1869572D0")]
	private void HBEPEELBOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6958950", Offset = "0x6957350", VA = "0x186958950")]
	public long PGJBDJKEJGH(long FJDKPJBBKHC, int EMIIDAEIFDJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6956820", Offset = "0x6955220", VA = "0x186956820")]
	private void GDICPNDLBOG(AEOIJLLIIPA AEONLJAHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6952780", Offset = "0x6951180", VA = "0x186952780")]
	private void DAKJPEINNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6954CA0", Offset = "0x69536A0", VA = "0x186954CA0")]
	private void FFKGALKHKOA(AEOIJLLIIPA KJFFCELEION, EBNJBMIMMPJ KOIHFFJAEIJ, int LCNFCGDOJIH, int PCECFIOFBHP, float KFGLEOKCNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct ABKHIIHEHIJ : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct NALAIDKIPEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int DHIEFEEMHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int AAMCKCGENNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int HIIBJEAPMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int KNDJCJKBLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int DKODHCEIKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int LEDBCGMOEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int JCEBAPCPPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int MPGDMIINJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float DIBCEBOCOFB;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct BLBHAGGCGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public LCLCNAJNNAN.CAPKDFHHKLG EANLNHJMOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float PJCGPKMCIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float DNMAFFJIMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float NIMGMKPJCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float CBPHEFHLNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float FMCJFFPAKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float ENHJLFPDBIN;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct AENCIFGMPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> PJHABPGAEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> BCBCICIKLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> LNDNPKINEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> ODOAEIPAPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> MNPEKLKENNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> HMPJDJIDOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool BMPFHDPHFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int DNEDLMPJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int NKAFOLBGCJA;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x695D310", Offset = "0x695BD10", VA = "0x18695D310")]
		public void KDNHMNFFJOO(int MNGECEBMIEA, int AENDFGPLPAL, Allocator BPMIGAHMDHE, bool OJKFFKNLBBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x695D4F0", Offset = "0x695BEF0", VA = "0x18695D4F0")]
		public static AENCIFGMPFK KEAAPNJHDGN(AEOIJLLIIPA PPJABDMHAEE)
		{
			return default(AENCIFGMPFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x695D740", Offset = "0x695C140", VA = "0x18695D740")]
		public void NELEFDBDAJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker JMCAGHHIODE;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker FAICNOBIHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<NALAIDKIPEB> OLJEOCLFBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private AENCIFGMPFK NMOCNFOJINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private AENCIFGMPFK AEONLJAHDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 EOLFCJLKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 NOMCPNIBNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private BLBHAGGCGFO NKHHKDMHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* DLBMGPFAEFO;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	[BurstDiscard]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	[BurstDiscard]
	private static void KMMIMMGNDMJ(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	[BurstDiscard]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD, string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69491B0", Offset = "0x6947BB0", VA = "0x1869491B0")]
	public ABKHIIHEHIJ([In] List<DOMKHBHDEFE.FMOGODODJHO> LGJNNGNNBKK, [In] AEOIJLLIIPA HLIEOPGCGJP, [In] DOMKHBHDEFE PLCEIKHODFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69475D0", Offset = "0x6945FD0", VA = "0x1869475D0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6948990", Offset = "0x6947390", VA = "0x186948990")]
	public void MCJCDMEKONH(List<DOMKHBHDEFE.FMOGODODJHO> FLDCABGIGNE, [In] DOMKHBHDEFE PLCEIKHODFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6948970", Offset = "0x6947370", VA = "0x186948970")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool LKPOKOEOPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6947190", Offset = "0x6945B90", VA = "0x186947190")]
	private EBNJBMIMMPJ ADANGJKJGEC(int FKNFMKEOPPJ, Allocator BPMIGAHMDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6947620", Offset = "0x6946020", VA = "0x186947620")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void KPJPCJCAKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6947260", Offset = "0x6945C60", VA = "0x186947260")]
	[IgnoreWarning(1371)]
	private NALAIDKIPEB CICMONPEEFO([In] NALAIDKIPEB KDGBGPCHCFH, int EMECOFCJDNA, [In] NativeArray<int> AGIIHBHOCHM, [In] NativeArray<bool> CMFHJMLBMAJ, NativeArray<int> HDELOLMFPHJ)
	{
		return default(NALAIDKIPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6949010", Offset = "0x6947A10", VA = "0x186949010")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int PJDBFJAPEIN(NativeArray<int> AGIIHBHOCHM, int CGBJFFNBEND, int JEGIDOECOGJ, int BFJAIPFFODG)
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
		public static readonly LGKLDLNGEGN log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker MIIMDINJPJM;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker NEGGEIMMDCM;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker NICBBJCNCCG;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker NLEGKNPIOMK;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker FEOBAAKOHPH;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker JHKLLOLLAPN;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker KCIJBPMKKDF;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int OEDNDNHJMOP = 65000;

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
		private Dictionary<Material, List<DOMKHBHDEFE>> BGOAEOIMKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<DOMKHBHDEFE> NPIBGIJLLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> HNPGHHANOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool GONFKFLGJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool HOBHLDPFNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int NIHPNHHFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> LDKPEJOICPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> AJFICPDDMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> IIOCPDADHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> OGNBOJMBAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private DOMKHBHDEFE JFOKGHJGMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material GACKDFMCCIC;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int KGNBMJHBGLG = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, PJCIMFHBGCB)> LGAPJMIEODP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> AELHHFIKONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int INNLGDBIECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x69630F0", Offset = "0x6961AF0", VA = "0x1869630F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		private static void DLMOEPBOBFL(bool HMCMCKLEOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		private static void DLMOEPBOBFL(bool HMCMCKLEOKD, string BDCMABOIIFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x695FAD0", Offset = "0x695E4D0", VA = "0x18695FAD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x695DA30", Offset = "0x695C430", VA = "0x18695DA30")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x695D800", Offset = "0x695C200", VA = "0x18695D800")]
		public DOMKHBHDEFE AddToBatchedMesh(PJCIMFHBGCB OFKHAIDMEIG, Material OKNIOBAOHHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6962210", Offset = "0x6960C10", VA = "0x186962210")]
		public void RemoveFromBatchedMesh(PJCIMFHBGCB KJFFCELEION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x695D900", Offset = "0x695C300", VA = "0x18695D900")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x69629E0", Offset = "0x69613E0", VA = "0x1869629E0")]
		public void SetMaterialProperty(int PKDIIGAGCEA, Color COGPPELINPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x69625B0", Offset = "0x6960FB0", VA = "0x1869625B0")]
		public void SetMaterialProperty(int PKDIIGAGCEA, float DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x69627C0", Offset = "0x69611C0", VA = "0x1869627C0")]
		public void SetMaterialProperty(int PKDIIGAGCEA, Vector4 DBCAIGCKMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6962350", Offset = "0x6960D50", VA = "0x186962350")]
		public void SetMaterialProperty(int PKDIIGAGCEA, Matrix4x4 CNAAJOBBGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x695E1E0", Offset = "0x695CBE0", VA = "0x18695E1E0")]
		private void IEJAFMHJNPB(Renderer EBCGCCILOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x695DC00", Offset = "0x695C600", VA = "0x18695DC00")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x695DBF0", Offset = "0x695C5F0", VA = "0x18695DBF0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x695E7D0", Offset = "0x695D1D0", VA = "0x18695E7D0")]
		private void INHLAIDGFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x695EFD0", Offset = "0x695D9D0", VA = "0x18695EFD0")]
		private DOMKHBHDEFE JGHNOHLOOLF(PJCIMFHBGCB KJFFCELEION, Material OKNIOBAOHHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x695ECF0", Offset = "0x695D6F0", VA = "0x18695ECF0")]
		private DOMKHBHDEFE JCIPKMMJAFJ(Material OKNIOBAOHHE, int DMEODEGKKIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x695F6D0", Offset = "0x695E0D0", VA = "0x18695F6D0")]
		private DOMKHBHDEFE NJAHOCNMMDF(Material OKNIOBAOHHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18ADCF0", Offset = "0x18AC6F0", VA = "0x1818ADCF0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x695F1F0", Offset = "0x695DBF0", VA = "0x18695F1F0")]
		public void MarkDirty(PJCIMFHBGCB KJFFCELEION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x695F350", Offset = "0x695DD50", VA = "0x18695F350")]
		public (long, long) MemorySizeInBytesForChosenDetail(float ACOAKDBKDKB)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x69612A0", Offset = "0x695FCA0", VA = "0x1869612A0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x695DCA0", Offset = "0x695C6A0", VA = "0x18695DCA0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x695FDC0", Offset = "0x695E7C0", VA = "0x18695FDC0")]
		public void RebatchOptimally(int ACJNPAJNIEP, int PCFFICFPBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6962E80", Offset = "0x6961880", VA = "0x186962E80")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FOAFHLGIMAF
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct CCNJLINJKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float AJDJDACIIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer ABGCKILINIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public DOMKHBHDEFE MJAEMMHPDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long MGHKDHODNED;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HALJJNGFMFP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x915D80", Offset = "0x914780", VA = "0x180915D80", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x69680C0", Offset = "0x6966AC0", VA = "0x1869680C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA799C0", Offset = "0xA783C0", VA = "0x180A799C0")]
		[DebuggerHidden]
		public HALJJNGFMFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6968110", Offset = "0x6966B10", VA = "0x186968110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6967370", Offset = "0x6965D70", VA = "0x186967370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6967320", Offset = "0x6965D20", VA = "0x186967320")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x69672D0", Offset = "0x6965CD0", VA = "0x1869672D0")]
		private void FLCLOIILAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6968070", Offset = "0x6966A70", VA = "0x186968070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6967FC0", Offset = "0x69669C0", VA = "0x186967FC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6967FC0", Offset = "0x69669C0", VA = "0x186967FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker JHKLLOLLAPN;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker BMAEDGHDAFG;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker JJHHODGLJKL;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker GCBALMIAEHD;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 PHLEMAKHFDA;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int BPHLBMGEPFP;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int MNGDGEIAHJM;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int FIHAKFPAFEC;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int EMENLNIGPNC;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int ADIMHIOEBLH;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int FHEJKDGAEEK;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int JGMJOLHBHBA;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int NCIALFGIPPD;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int JHGKMIEDLPG;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int CALJEDKCMCB;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int EHBAMFOJPGA;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int NBFPBBHAAMG;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int BOOGHFLGKIH;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int HMFKDPNBFKA;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long GJEMLPFDDBI;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long LFMKEJFBHIM;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int BMDMPOHOOHH;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int DNKINCNHLOG;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int KOABAIOADGP;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long EGALPHHCGDK;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool NPKLAPNGCOI;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> NGHGNOGDFCP;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<CCNJLINJKCJ> NGKMKDKALGO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LLHAPOGJPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6966740", Offset = "0x6965140", VA = "0x186966740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void KMMIMMGNDMJ(bool HMCMCKLEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void DLMOEPBOBFL(bool HMCMCKLEOKD, string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6966210", Offset = "0x6964C10", VA = "0x186966210")]
	public static void GKMPMEFLHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x69664D0", Offset = "0x6964ED0", VA = "0x1869664D0")]
	public static void JDMKADHPFEO(BatchedMeshRenderer FDGDHCAEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6963140", Offset = "0x6961B40", VA = "0x186963140")]
	public static void BOPLOCODEHD(BatchedMeshRenderer FDGDHCAEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6966A20", Offset = "0x6965420", VA = "0x186966A20")]
	private static (long, long, long) MEDCDNMIODN(long DCKNODABEBN)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6963390", Offset = "0x6961D90", VA = "0x186963390")]
	public static void COIJEIACHIL(long DCKNODABEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6966BC0", Offset = "0x69655C0", VA = "0x186966BC0")]
	public static long PGJBDJKEJGH(long FJDKPJBBKHC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x69663C0", Offset = "0x6964DC0", VA = "0x1869663C0")]
	public static void HMPDFEMKEHM(DOMKHBHDEFE MJAEMMHPDKN, BatchedMeshRenderer ABGCKILINIC, long MGHKDHODNED, float AJDJDACIIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6965DB0", Offset = "0x69647B0", VA = "0x186965DB0")]
	public static void FMEPLJCDFIN(DOMKHBHDEFE MJAEMMHPDKN, BatchedMeshRenderer ABGCKILINIC, long MGHKDHODNED, float OCMAPLHGDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6966910", Offset = "0x6965310", VA = "0x186966910")]
	public static void LPAPANAHPOH(DOMKHBHDEFE MJAEMMHPDKN, BatchedMeshRenderer ABGCKILINIC, long MGHKDHODNED, float OCMAPLHGDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x69631F0", Offset = "0x6961BF0", VA = "0x1869631F0")]
	public static void CHAOIFBCKAH(DOMKHBHDEFE MJAEMMHPDKN, BatchedMeshRenderer ABGCKILINIC, long MGHKDHODNED, float AJDJDACIIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6965EB0", Offset = "0x69648B0", VA = "0x186965EB0")]
	public static float FNEACKDOACM(long AOHKOJFCKEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6965BE0", Offset = "0x69645E0", VA = "0x186965BE0")]
	public static (long, long) DLCIBEFFCNK(float ACOAKDBKDKB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6966B30", Offset = "0x6965530", VA = "0x186966B30")]
	[IteratorStateMachine(typeof(HALJJNGFMFP))]
	public static IEnumerable<bool> NAJNDOMGGHJ(long FIDKIBPPJFG, bool FMKGOHHOFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6965A70", Offset = "0x6964470", VA = "0x186965A70")]
	public static void DBCDMAMFKGJ(long FIDKIBPPJFG, bool FMKGOHHOFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x69667D0", Offset = "0x69651D0", VA = "0x1869667D0")]
	public static int JPDCDBEOPPL()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class CLDLDHEJDBE<KeyType> : DOMKHBHDEFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, PJCIMFHBGCB> MGJJPLGOMIG;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5247910", Offset = "0x5246310", VA = "0x185247910")]
	public CLDLDHEJDBE(string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5247430", Offset = "0x5245E30", VA = "0x185247430")]
	public void GLFKJNOAFCH(KeyType LDDEKIBHION, PJCIMFHBGCB PBJNABDOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5247640", Offset = "0x5246040", VA = "0x185247640")]
	public bool LPFOGKHGNCF(KeyType LDDEKIBHION, PJCIMFHBGCB AMHBOJBBDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5247570", Offset = "0x5245F70", VA = "0x185247570")]
	public void GONKDDGADOA(KeyType LDDEKIBHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x52473D0", Offset = "0x5245DD0", VA = "0x1852473D0", Slot = "4")]
	public override void EPKECFNCHBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6968230", Offset = "0x6966C30", VA = "0x186968230")]
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
