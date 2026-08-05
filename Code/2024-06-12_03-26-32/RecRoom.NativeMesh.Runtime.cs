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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69487A0", Offset = "0x69473A0", VA = "0x1869487A0", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MAACIMNGHGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int KMLFGMHGICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 DOAOCFCIHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion MKOAIKBDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 KBLCDMODMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int AFDBCPGONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int IFLIDIAMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NIKGDGACHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float NNNDEDNDFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 EKOKNCOOGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool MCGLOFKGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public MCDPNEDALEI IBILIEMLFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 ODBGOOLMAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float DPEKKFDHAEI;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MIFCIJEACKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static GBNCKKMGOCO HAICBPMBBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<MAACIMNGHGA> AOEOEINHBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<COBDJLBJLPG> BFKEFLGPBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<NKPNLLOAEEE> IICAOJHOHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<LPFJHNJFEMI> LHAHGIBNEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<COBDJLBJLPG> CMDKLMOPOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<JKBHACPMHNO> KMNBOIOGKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<LPFJHNJFEMI>> PJBNONCDNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<HNDIMPDNNMG> AMIGIHPLJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> OCPPLKCHJCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDB5CF0", Offset = "0xDB48F0", VA = "0x180DB5CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDB4480", Offset = "0xDB3080", VA = "0x180DB4480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PJALGAPEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D00", Offset = "0xDB4900", VA = "0x180DB5D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB48F0", Offset = "0xDB34F0", VA = "0x180DB48F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x694B220", Offset = "0x6949E20", VA = "0x18694B220")]
	public MIFCIJEACKE(int IIDHBIJNCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6949850", Offset = "0x6948450", VA = "0x186949850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x694AB80", Offset = "0x6949780", VA = "0x18694AB80")]
	public void LNHLHNCBJPB(JobHandle CAEABJCEFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x694B000", Offset = "0x6949C00", VA = "0x18694B000")]
	public void PNFFMIPBOGM(MAACIMNGHGA IMCLGJBJJKP, HNDIMPDNNMG MJDCGGIJOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6949A10", Offset = "0x6948610", VA = "0x186949A10")]
	public void GFDBGNHDPOB(NKPNLLOAEEE IMCLGJBJJKP, NativeArray<LPFJHNJFEMI> FIOMKAIFGGC, int DEKBEBJEJFH, int ONAEOHMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6949B70", Offset = "0x6948770", VA = "0x186949B70")]
	public JobHandle IBNEGBDNOFO(LMMNEJCMKMI OMJMJBHLIBF, FFNAJOLLOGD FIPNINMIBMI, float3 GMGEHHMNBOC, quaternion MFEPGJJFCLJ, float LMMMJJEBLOP, bool GANEMIJHFKM, int PJINPOLDAIF = 0, int JIFEIJBJDOK = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6949510", Offset = "0x6948110", VA = "0x186949510")]
	public static JobHandle ACBMACIFDGJ(JOCHAPLMNCP KCHLOIGCLIF, LMMNEJCMKMI OMJMJBHLIBF, MAACIMNGHGA IMCLGJBJJKP, JobHandle CAEABJCEFAI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x694AD50", Offset = "0x6949950", VA = "0x18694AD50")]
	public static JobHandle NCMIOLIFAKA(JEIFKPCOENI KCHLOIGCLIF, LMMNEJCMKMI OMJMJBHLIBF, NKPNLLOAEEE IMCLGJBJJKP, NativeArray<LPFJHNJFEMI> FIOMKAIFGGC, int DEKBEBJEJFH, int ONAEOHMBPHC, JobHandle CAEABJCEFAI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class KILHCAAOJJN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct ALBPDBDCGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half IJAHPPCGNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort GAPEGFGLMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte CIJBDBFAEOB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void MKAMIGDIOEK([NoAlias] float3* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class LHCCGBCHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6947730", Offset = "0x6946330", VA = "0x186947730")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6947B20", Offset = "0x6946720", VA = "0x186947B20")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6947A70", Offset = "0x6946670", VA = "0x186947A70")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6947860", Offset = "0x6946460", VA = "0x186947860")]
		public unsafe static void DOBCDLDNJAI([NoAlias] float3* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void NOOGHCMONIK([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class EECGKNACEIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6934E20", Offset = "0x6933A20", VA = "0x186934E20")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6935290", Offset = "0x6933E90", VA = "0x186935290")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69351E0", Offset = "0x6933DE0", VA = "0x1869351E0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6934F50", Offset = "0x6933B50", VA = "0x186934F50")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void KJKCCMOLJLB([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class GOIALOBKFGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x693A710", Offset = "0x6939310", VA = "0x18693A710")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x693AB80", Offset = "0x6939780", VA = "0x18693AB80")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x693AAD0", Offset = "0x69396D0", VA = "0x18693AAD0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x693A840", Offset = "0x6939440", VA = "0x18693A840")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void PLIJGHLKHBL([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class EFALMDIHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69353F0", Offset = "0x6933FF0", VA = "0x1869353F0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6935860", Offset = "0x6934460", VA = "0x186935860")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69357B0", Offset = "0x69343B0", VA = "0x1869357B0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6935520", Offset = "0x6934120", VA = "0x186935520")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void CDEAFHIOOEB([NoAlias] ushort* CNOGDOOCKKH, [Out] float3 FNCCDEJNMNF, [Out] float3 IEKMGPGLLMM, [In][NoAlias] float3* FIJEENPFFEC, int GAGKKEJAEBP, int OGGCPDDOCHP);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class DFNHMNCBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6934390", Offset = "0x6932F90", VA = "0x186934390")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6934790", Offset = "0x6933390", VA = "0x186934790")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69346E0", Offset = "0x69332E0", VA = "0x1869346E0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69344C0", Offset = "0x69330C0", VA = "0x1869344C0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] ushort* CNOGDOOCKKH, [Out] float3 FNCCDEJNMNF, [Out] float3 IEKMGPGLLMM, [In][NoAlias] float3* FIJEENPFFEC, int GAGKKEJAEBP, int OGGCPDDOCHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void DOIMBDJLPFL([NoAlias] ushort* JMOFGMDEMMC, [In][NoAlias] float3* CGGPJEKDELC, int OGGCPDDOCHP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class DOPOLMOGDLH
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69348F0", Offset = "0x69334F0", VA = "0x1869348F0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6934CC0", Offset = "0x69338C0", VA = "0x186934CC0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6934C10", Offset = "0x6933810", VA = "0x186934C10")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6934A20", Offset = "0x6933620", VA = "0x186934A20")]
		public unsafe static void DOBCDLDNJAI([NoAlias] ushort* JMOFGMDEMMC, [In][NoAlias] float3* CGGPJEKDELC, int OGGCPDDOCHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void NGBDJLGAFPA([NoAlias] float3* NPMGAKBODBF, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class CPAMELKLDAM
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6933E00", Offset = "0x6932A00", VA = "0x186933E00")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6934230", Offset = "0x6932E30", VA = "0x186934230")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6934180", Offset = "0x6932D80", VA = "0x186934180")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6933F30", Offset = "0x6932B30", VA = "0x186933F30")]
		public unsafe static void DOBCDLDNJAI([NoAlias] float3* NPMGAKBODBF, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void PCKMFAPDHJE([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class GNOGNHNOBLH
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x693A1E0", Offset = "0x6938DE0", VA = "0x18693A1E0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x693A5B0", Offset = "0x69391B0", VA = "0x18693A5B0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x693A500", Offset = "0x6939100", VA = "0x18693A500")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x693A310", Offset = "0x6938F10", VA = "0x18693A310")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void OEILCJJFKAA([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class MFBJIAHMIEA
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6948F10", Offset = "0x6947B10", VA = "0x186948F10")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69493B0", Offset = "0x6947FB0", VA = "0x1869493B0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6949300", Offset = "0x6947F00", VA = "0x186949300")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6949040", Offset = "0x6947C40", VA = "0x186949040")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void MKLEPIIBFBL([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class ELBOLKJMCFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69359C0", Offset = "0x69345C0", VA = "0x1869359C0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6935E50", Offset = "0x6934A50", VA = "0x186935E50")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6935DA0", Offset = "0x69349A0", VA = "0x186935DA0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6935AF0", Offset = "0x69346F0", VA = "0x186935AF0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void PODGHLOFIBK([NoAlias] ushort* GOHJAHLPMHM, [Out] float2 JALBANMKKPO, [Out] float2 FEGFKMKOKJI, [In][NoAlias] float2* KGLPMGDBLDA, int GAGKKEJAEBP, int OGGCPDDOCHP);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class PELMIGHJBEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x694CAC0", Offset = "0x694B6C0", VA = "0x18694CAC0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x694CEC0", Offset = "0x694BAC0", VA = "0x18694CEC0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x694CE10", Offset = "0x694BA10", VA = "0x18694CE10")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x694CBF0", Offset = "0x694B7F0", VA = "0x18694CBF0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] ushort* GOHJAHLPMHM, [Out] float2 JALBANMKKPO, [Out] float2 FEGFKMKOKJI, [In][NoAlias] float2* KGLPMGDBLDA, int GAGKKEJAEBP, int OGGCPDDOCHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void GLNHGKMGIEL([Out] float2 BIEFILDINCP, ushort HPGBFMALFJN, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class ACOILHKDOIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69309E0", Offset = "0x692F5E0", VA = "0x1869309E0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6930E00", Offset = "0x692FA00", VA = "0x186930E00")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6930D50", Offset = "0x692F950", VA = "0x186930D50")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6930B10", Offset = "0x692F710", VA = "0x186930B10")]
		public static void DOBCDLDNJAI([Out] float2 BIEFILDINCP, ushort HPGBFMALFJN, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void PJINOMJKPMN([NoAlias] float2* GOHJAHLPMHM, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class BCIAJELIBLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6932F90", Offset = "0x6931B90", VA = "0x186932F90")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6933400", Offset = "0x6932000", VA = "0x186933400")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6933350", Offset = "0x6931F50", VA = "0x186933350")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69330C0", Offset = "0x6931CC0", VA = "0x1869330C0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] float2* GOHJAHLPMHM, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void GPJHGEBFIJH([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class LHOJPAIJHFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6947C80", Offset = "0x6946880", VA = "0x186947C80")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6948130", Offset = "0x6946D30", VA = "0x186948130")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6948080", Offset = "0x6946C80", VA = "0x186948080")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6947DB0", Offset = "0x69469B0", VA = "0x186947DB0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void LGJMJAPAJHN([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GLGDDEIDICH
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x69382B0", Offset = "0x6936EB0", VA = "0x1869382B0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6938760", Offset = "0x6937360", VA = "0x186938760")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69386B0", Offset = "0x69372B0", VA = "0x1869386B0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x69383E0", Offset = "0x6936FE0", VA = "0x1869383E0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void JBHADCKNBAB([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class GLFBHKCLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6937BC0", Offset = "0x69367C0", VA = "0x186937BC0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6938150", Offset = "0x6936D50", VA = "0x186938150")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x69380A0", Offset = "0x6936CA0", VA = "0x1869380A0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6937CF0", Offset = "0x69368F0", VA = "0x186937CF0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void PPAIHDKDPFD([NoAlias] ushort* JDAEIDEKFAO, [In][NoAlias] float4* NAFDKIMCCCJ, int GAGKKEJAEBP, int OGGCPDDOCHP);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class KHJIANGPHGA
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x693FEA0", Offset = "0x693EAA0", VA = "0x18693FEA0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x69402D0", Offset = "0x693EED0", VA = "0x1869402D0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6940220", Offset = "0x693EE20", VA = "0x186940220")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x693FFD0", Offset = "0x693EBD0", VA = "0x18693FFD0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] ushort* JDAEIDEKFAO, [In][NoAlias] float4* NAFDKIMCCCJ, int GAGKKEJAEBP, int OGGCPDDOCHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort PBBJMNHGEMG([In] float4 LOCEOOKGKLF);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class PAEGIIBIGFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x694C570", Offset = "0x694B170", VA = "0x18694C570")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x694C960", Offset = "0x694B560", VA = "0x18694C960")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x694C8B0", Offset = "0x694B4B0", VA = "0x18694C8B0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x694C6A0", Offset = "0x694B2A0", VA = "0x18694C6A0")]
		public static ushort DOBCDLDNJAI([In] float4 LOCEOOKGKLF)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void NJJDCJEDIKO([NoAlias] float4* JDAEIDEKFAO, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class KNKPGGHGAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x69471A0", Offset = "0x6945DA0", VA = "0x1869471A0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x69475D0", Offset = "0x69461D0", VA = "0x1869475D0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6947520", Offset = "0x6946120", VA = "0x186947520")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x69472D0", Offset = "0x6945ED0", VA = "0x1869472D0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] float4* JDAEIDEKFAO, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void AJAEDLBNJBG([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class BCAELDDFLOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6932A60", Offset = "0x6931660", VA = "0x186932A60")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6932E30", Offset = "0x6931A30", VA = "0x186932E30")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6932D80", Offset = "0x6931980", VA = "0x186932D80")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6932B90", Offset = "0x6931790", VA = "0x186932B90")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void AFEEMICFJCM([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class NPLCCIMMNIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x694BE70", Offset = "0x694AA70", VA = "0x18694BE70")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x694C310", Offset = "0x694AF10", VA = "0x18694C310")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x694C260", Offset = "0x694AE60", VA = "0x18694C260")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x694BFA0", Offset = "0x694ABA0", VA = "0x18694BFA0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void FKPEGLMLNCE([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class BAIGDAFCPKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6932470", Offset = "0x6931070", VA = "0x186932470")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6932900", Offset = "0x6931500", VA = "0x186932900")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6932850", Offset = "0x6931450", VA = "0x186932850")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x69325A0", Offset = "0x69311A0", VA = "0x1869325A0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void JKJDJPDFKEL([Out] float4 JFBAIGMLPKE, ushort HPGBFMALFJN);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class JMLLIBGKBBA
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x693EB00", Offset = "0x693D700", VA = "0x18693EB00")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x693EF60", Offset = "0x693DB60", VA = "0x18693EF60")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x693EEB0", Offset = "0x693DAB0", VA = "0x18693EEB0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x693EC30", Offset = "0x693D830", VA = "0x18693EC30")]
		public static void DOBCDLDNJAI([Out] float4 JFBAIGMLPKE, ushort HPGBFMALFJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void OOIFIIEHCFM([NoAlias] float4* NCGKNFHNANP, [NoAlias] byte* OJAPPBGOGBB, [Out] int ENGDNBBBMIM, [Out] int FEINLNBEIJF, [NoAlias] float4* NMFPDKPAMPA, int GAGKKEJAEBP, int OGGCPDDOCHP);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class HHOLJGMAEDI
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x693ADE0", Offset = "0x69399E0", VA = "0x18693ADE0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x693B1E0", Offset = "0x6939DE0", VA = "0x18693B1E0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x693B130", Offset = "0x6939D30", VA = "0x18693B130")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x693AF10", Offset = "0x6939B10", VA = "0x18693AF10")]
		public unsafe static void DOBCDLDNJAI([NoAlias] float4* NCGKNFHNANP, [NoAlias] byte* OJAPPBGOGBB, [Out] int ENGDNBBBMIM, [Out] int FEINLNBEIJF, [NoAlias] float4* NMFPDKPAMPA, int GAGKKEJAEBP, int OGGCPDDOCHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void LLBNOJPCNPO([NoAlias] float4* LIIIACKPECP, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class MACONBBDKHI
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x69488F0", Offset = "0x69474F0", VA = "0x1869488F0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6948DB0", Offset = "0x69479B0", VA = "0x186948DB0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6948D00", Offset = "0x6947900", VA = "0x186948D00")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6948A20", Offset = "0x6947620", VA = "0x186948A20")]
		public unsafe static void DOBCDLDNJAI([NoAlias] float4* LIIIACKPECP, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void HKFHMABOFKI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class ALNEJPJOGIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6931DA0", Offset = "0x69309A0", VA = "0x186931DA0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6932310", Offset = "0x6930F10", VA = "0x186932310")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6932260", Offset = "0x6930E60", VA = "0x186932260")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6931ED0", Offset = "0x6930AD0", VA = "0x186931ED0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void BHCODCBJGIF([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class IEBHDBHIADK
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x693BDC0", Offset = "0x693A9C0", VA = "0x18693BDC0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x693C340", Offset = "0x693AF40", VA = "0x18693C340")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x693C290", Offset = "0x693AE90", VA = "0x18693C290")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x693BEF0", Offset = "0x693AAF0", VA = "0x18693BEF0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void IBCNHAOBEEO([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class KANCOKHIFKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x693F7D0", Offset = "0x693E3D0", VA = "0x18693F7D0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x693FD40", Offset = "0x693E940", VA = "0x18693FD40")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x693FC90", Offset = "0x693E890", VA = "0x18693FC90")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x693F900", Offset = "0x693E500", VA = "0x18693F900")]
		public unsafe static void DOBCDLDNJAI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int FDOMACLJDCK([NoAlias] byte* BMGJDDKFEDH, [In][NoAlias] int* OJMIIKABODC, int IGAHEKDDJCA);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class KMIHFMIOHOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6946BE0", Offset = "0x69457E0", VA = "0x186946BE0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6947040", Offset = "0x6945C40", VA = "0x186947040")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6946F90", Offset = "0x6945B90", VA = "0x186946F90")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6946D10", Offset = "0x6945910", VA = "0x186946D10")]
		public unsafe static int DOBCDLDNJAI([NoAlias] byte* BMGJDDKFEDH, [In][NoAlias] int* OJMIIKABODC, int IGAHEKDDJCA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void CGBBAIOOJJL([NoAlias] int* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class MLIGJEPLAOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x694B430", Offset = "0x694A030", VA = "0x18694B430")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x694B850", Offset = "0x694A450", VA = "0x18694B850")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x694B7A0", Offset = "0x694A3A0", VA = "0x18694B7A0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x694B560", Offset = "0x694A160", VA = "0x18694B560")]
		public unsafe static void DOBCDLDNJAI([NoAlias] int* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void GAJKANIHLMN([NoAlias] ushort* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class JNLOONKPCJM
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x693F0C0", Offset = "0x693DCC0", VA = "0x18693F0C0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x693F4E0", Offset = "0x693E0E0", VA = "0x18693F4E0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x693F430", Offset = "0x693E030", VA = "0x18693F430")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x693F1F0", Offset = "0x693DDF0", VA = "0x18693F1F0")]
		public unsafe static void DOBCDLDNJAI([NoAlias] ushort* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void PDMPPGBGPFK([Out] float3 BIEFILDINCP, ushort HPGBFMALFJN);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class BEFEAAPMAJD
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6933560", Offset = "0x6932160", VA = "0x186933560")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6933AA0", Offset = "0x69326A0", VA = "0x186933AA0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x69339F0", Offset = "0x69325F0", VA = "0x1869339F0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6933690", Offset = "0x6932290", VA = "0x186933690")]
		public static void DOBCDLDNJAI([Out] float3 BIEFILDINCP, ushort HPGBFMALFJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort MAHPDDALMJK([In] float3 LOCEOOKGKLF);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class LOMJEAJHJKP
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6948290", Offset = "0x6946E90", VA = "0x186948290")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6948640", Offset = "0x6947240", VA = "0x186948640")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6948590", Offset = "0x6947190", VA = "0x186948590")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69483C0", Offset = "0x6946FC0", VA = "0x1869483C0")]
		public static ushort DOBCDLDNJAI([In] float3 LOCEOOKGKLF)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DEKBEBJEJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int ONAEOHMBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> BPEKIFJBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> NLAKIACODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> EBNICOCLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> FHNPGGHFDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<ALBPDBDCGGO> JMGMPJKEBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> LIPDNDMOBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> IOIEKIBENAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 OKPHEPPKJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 IEKMGPGLLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 IOAMICHEMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 FEGFKMKOKJI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long PEFCHPBOCFP;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long BPBEKENBECH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float OOIJFHBKDDD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool LIDBKAGEPPB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FLJKDMIHIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69469C0", Offset = "0x69455C0", VA = "0x1869469C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69450E0", Offset = "0x6943CE0", VA = "0x1869450E0")]
	public void LNHLHNCBJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6942E90", Offset = "0x6941A90", VA = "0x186942E90")]
	public static KILHCAAOJJN GADNMLFOLLL(Allocator BLMBIIGOJPG, LMMNEJCMKMI BFNFDCLDNFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6943070", Offset = "0x6941C70", VA = "0x186943070")]
	public static KILHCAAOJJN GADNMLFOLLL(Allocator BLMBIIGOJPG, NativeArray<float3> FIJEENPFFEC, NativeArray<float3> CGGPJEKDELC, NativeArray<float2> KGLPMGDBLDA, NativeArray<float4> NMFPDKPAMPA, bool KKKNPBOJEJB, NativeArray<float4> EIPOLOCODAG, NativeArray<int> OJMIIKABODC, int DEKBEBJEJFH, int HOAGEJBKMKE, int ONAEOHMBPHC, int GAGKKEJAEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69414F0", Offset = "0x69400F0", VA = "0x1869414F0")]
	public LMMNEJCMKMI CDOHLEBOLKA(Allocator BLMBIIGOJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6941DC0", Offset = "0x69409C0", VA = "0x186941DC0")]
	public void CKDKGPGHKHI(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6946820", Offset = "0x6945420", VA = "0x186946820")]
	private void PEBBHDGDPMD(Mesh AIKMKIOPGIF, NativeArray<ushort> CIDKDFNMIBN, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6944160", Offset = "0x6942D60", VA = "0x186944160")]
	public void JACHFIKJOIF(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69428B0", Offset = "0x69414B0", VA = "0x1869428B0")]
	public void FPABKBJPGPL(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6945E80", Offset = "0x6944A80", VA = "0x186945E80")]
	public void OGNDEIFNIJD(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6943850", Offset = "0x6942450", VA = "0x186943850")]
	public void HCIOMDNKCMI(Mesh AIKMKIOPGIF, LMMNEJCMKMI.GJKIEGIEBEL KKEJAEKDBIN, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6946790", Offset = "0x6945390", VA = "0x186946790")]
	public long PAEJIDGKEKJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6944080", Offset = "0x6942C80", VA = "0x186944080")]
	public long IFOOKEFGNEL(LMMNEJCMKMI.GJKIEGIEBEL KKEJAEKDBIN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69435C0", Offset = "0x69421C0", VA = "0x1869435C0")]
	private void GCJMNEGAMAM(int CPKKHGLLOGC, int OGGCPDDOCHP, Allocator BLMBIIGOJPG, bool DNNDPOCHOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6944B40", Offset = "0x6943740", VA = "0x186944B40")]
	private void JJKHHENPDGO(NativeArray<float3> CNOGDOOCKKH, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6944C40", Offset = "0x6943840", VA = "0x186944C40")]
	[BurstCompile]
	private unsafe static void JJKHHENPDGO([NoAlias] float3* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6943B40", Offset = "0x6942740", VA = "0x186943B40")]
	[BurstCompile]
	private unsafe static void HHMHEDNEOHA([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6945CC0", Offset = "0x69448C0", VA = "0x186945CC0")]
	[BurstCompile]
	private unsafe static void ODNHHANCOAN([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69409B0", Offset = "0x693F5B0", VA = "0x1869409B0")]
	[BurstCompile]
	private unsafe static void AHIJIFOPNKF([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6941AD0", Offset = "0x69406D0", VA = "0x186941AD0")]
	private void CDOOCPLFKLF(NativeArray<float3> FIJEENPFFEC, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6941BD0", Offset = "0x69407D0", VA = "0x186941BD0")]
	[BurstCompile]
	private unsafe static void CDOOCPLFKLF([NoAlias] ushort* CNOGDOOCKKH, [Out] float3 FNCCDEJNMNF, [Out] float3 IEKMGPGLLMM, [In][NoAlias] float3* FIJEENPFFEC, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69408F0", Offset = "0x693F4F0", VA = "0x1869408F0")]
	private void AHIFCGEJNFA(NativeArray<float3> CGGPJEKDELC, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69406D0", Offset = "0x693F2D0", VA = "0x1869406D0")]
	[BurstCompile]
	private unsafe static void AHIFCGEJNFA([NoAlias] ushort* JMOFGMDEMMC, [In][NoAlias] float3* CGGPJEKDELC, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6945DB0", Offset = "0x69449B0", VA = "0x186945DB0")]
	private void OEODPEMNKOI(NativeArray<float3> NPMGAKBODBF, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6945D40", Offset = "0x6944940", VA = "0x186945D40")]
	[BurstCompile]
	private unsafe static void OEODPEMNKOI([NoAlias] float3* NPMGAKBODBF, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69410E0", Offset = "0x693FCE0", VA = "0x1869410E0")]
	[BurstCompile]
	private unsafe static void BNAFLCHOHBE([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6940430", Offset = "0x693F030", VA = "0x186940430")]
	[BurstCompile]
	private unsafe static void AEAACPBPDPH([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6941480", Offset = "0x6940080", VA = "0x186941480")]
	[BurstCompile]
	private unsafe static void CCICNHFHDKF([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6944A70", Offset = "0x6943670", VA = "0x186944A70")]
	private void JEBBJNHAAEO(NativeArray<float2> KGLPMGDBLDA, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6944820", Offset = "0x6943420", VA = "0x186944820")]
	[BurstCompile]
	private unsafe static void JEBBJNHAAEO([NoAlias] ushort* GOHJAHLPMHM, [Out] float2 JALBANMKKPO, [Out] float2 FEGFKMKOKJI, [In][NoAlias] float2* KGLPMGDBLDA, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6942150", Offset = "0x6940D50", VA = "0x186942150")]
	[BurstCompile]
	private static void DKMBEBEIBKA([Out] float2 BIEFILDINCP, ushort HPGBFMALFJN, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6941300", Offset = "0x693FF00", VA = "0x186941300")]
	private void BPCHAOKFAAD(NativeArray<float2> GOHJAHLPMHM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6941400", Offset = "0x6940000", VA = "0x186941400")]
	[BurstCompile]
	private unsafe static void BPCHAOKFAAD([NoAlias] float2* GOHJAHLPMHM, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6945AB0", Offset = "0x69446B0", VA = "0x186945AB0")]
	[BurstCompile]
	private unsafe static void NLNMAMDDJBN([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69420D0", Offset = "0x6940CD0", VA = "0x1869420D0")]
	[BurstCompile]
	private unsafe static void DJDMLNDPOOP([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69427B0", Offset = "0x69413B0", VA = "0x1869427B0")]
	[BurstCompile]
	private unsafe static void FFOHCGKAFGI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6942250", Offset = "0x6940E50", VA = "0x186942250")]
	private void DLJGOKCLCMD(NativeArray<float4> EIPOLOCODAG, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69421D0", Offset = "0x6940DD0", VA = "0x1869421D0")]
	[BurstCompile]
	private unsafe static void DLJGOKCLCMD([NoAlias] ushort* JDAEIDEKFAO, [In][NoAlias] float4* NAFDKIMCCCJ, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6945C70", Offset = "0x6944870", VA = "0x186945C70")]
	[BurstCompile]
	private static ushort OAIGAFOAICO([In] float4 LOCEOOKGKLF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6942340", Offset = "0x6940F40", VA = "0x186942340")]
	private void EEJDMFJFODA(NativeArray<float4> JDAEIDEKFAO, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6942410", Offset = "0x6941010", VA = "0x186942410")]
	[BurstCompile]
	private unsafe static void EEJDMFJFODA([NoAlias] float4* JDAEIDEKFAO, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6945620", Offset = "0x6944220", VA = "0x186945620")]
	[BurstCompile]
	private unsafe static void MPLGDIGNCPJ([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6945A40", Offset = "0x6944640", VA = "0x186945A40")]
	[BurstCompile]
	private unsafe static void NKEMELALAKK([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69425C0", Offset = "0x69411C0", VA = "0x1869425C0")]
	[BurstCompile]
	private unsafe static void EJDMMMDIMJN([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6943560", Offset = "0x6942160", VA = "0x186943560")]
	[BurstCompile]
	private static void GBPDJLEMAKB([Out] float4 JFBAIGMLPKE, ushort HPGBFMALFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6940C80", Offset = "0x693F880", VA = "0x186940C80")]
	private void APGJKPIJMGJ(Allocator BLMBIIGOJPG, NativeArray<float4> NMFPDKPAMPA, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6940A30", Offset = "0x693F630", VA = "0x186940A30")]
	[BurstCompile]
	private unsafe static void APGJKPIJMGJ([NoAlias] float4* NCGKNFHNANP, [NoAlias] byte* OJAPPBGOGBB, [Out] int ENGDNBBBMIM, [Out] int FEINLNBEIJF, [NoAlias] float4* NMFPDKPAMPA, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69439B0", Offset = "0x69425B0", VA = "0x1869439B0")]
	private static void HDLJAJKIGPJ(NativeArray<float4> LIIIACKPECP, NativeArray<ALBPDBDCGGO> HOHDCKKDOFJ, NativeArray<byte> FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6943AC0", Offset = "0x69426C0", VA = "0x186943AC0")]
	[BurstCompile]
	private unsafe static void HDLJAJKIGPJ([NoAlias] float4* LIIIACKPECP, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6942830", Offset = "0x6941430", VA = "0x186942830")]
	[BurstCompile]
	private unsafe static void FKLOOEAFEOG([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6946940", Offset = "0x6945540", VA = "0x186946940")]
	[BurstCompile]
	private unsafe static void PFAGDEEKFEA([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6941060", Offset = "0x693FC60", VA = "0x186941060")]
	[BurstCompile]
	private unsafe static void BHJNADDLACD([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6942630", Offset = "0x6941230", VA = "0x186942630")]
	private void EJPPHODOKOD(Allocator BLMBIIGOJPG, NativeArray<int> OJMIIKABODC, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6943E10", Offset = "0x6942A10", VA = "0x186943E10")]
	private static NativeArray<byte> IAEGGMCHKKO(Allocator BLMBIIGOJPG, NativeArray<int> OJMIIKABODC, int IGAHEKDDJCA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6943DA0", Offset = "0x69429A0", VA = "0x186943DA0")]
	[BurstCompile]
	private unsafe static int IAEGGMCHKKO([NoAlias] byte* BMGJDDKFEDH, [In][NoAlias] int* OJMIIKABODC, int IGAHEKDDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69446E0", Offset = "0x69432E0", VA = "0x1869446E0")]
	private static void JDOAOCCMNGC(NativeArray<int> BNIMJDJCLJG, NativeArray<byte> GGIINHEBNDL, int ONAEOHMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69447B0", Offset = "0x69433B0", VA = "0x1869447B0")]
	[BurstCompile]
	private unsafe static void JDOAOCCMNGC([NoAlias] int* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69440F0", Offset = "0x6942CF0", VA = "0x1869440F0")]
	[BurstCompile]
	private unsafe static void ILMIPEIODMB([NoAlias] ushort* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6945080", Offset = "0x6943C80", VA = "0x186945080")]
	[BurstCompile]
	private static void LMBPKABEDIL([Out] float3 BIEFILDINCP, ushort HPGBFMALFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6946580", Offset = "0x6945180", VA = "0x186946580")]
	[BurstCompile]
	private static ushort ONNDOBGEOBB([In] float3 LOCEOOKGKLF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KILHCAAOJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x692FE30", Offset = "0x692EA30", VA = "0x18692FE30")]
	[BurstCompile]
	public unsafe static void IKILLADDEBA([NoAlias] float3* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6941D00", Offset = "0x6940900", VA = "0x186941D00")]
	[BurstCompile]
	public unsafe static void CIAOFBKEDFM([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69436F0", Offset = "0x69422F0", VA = "0x1869436F0")]
	[BurstCompile]
	public unsafe static void GFKBLIENOFJ([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6945980", Offset = "0x6944580", VA = "0x186945980")]
	[BurstCompile]
	public unsafe static void NKAGPLCEGGD([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* FIJEENPFFEC, int DEKBEBJEJFH, [In] float3 OKPHEPPKJKF, [In] float3 IEKMGPGLLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x692F2A0", Offset = "0x692DEA0", VA = "0x18692F2A0")]
	[BurstCompile]
	public unsafe static void AKPAMKGJECE([NoAlias] ushort* CNOGDOOCKKH, [Out] float3 FNCCDEJNMNF, [Out] float3 IEKMGPGLLMM, [In][NoAlias] float3* FIJEENPFFEC, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x692F040", Offset = "0x692DC40", VA = "0x18692F040")]
	[BurstCompile]
	public unsafe static void AJKGFDGPJIC([NoAlias] ushort* JMOFGMDEMMC, [In][NoAlias] float3* CGGPJEKDELC, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69454C0", Offset = "0x69440C0", VA = "0x1869454C0")]
	[BurstCompile]
	public unsafe static void MLFIKJMKLGN([NoAlias] float3* NPMGAKBODBF, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x692FBF0", Offset = "0x692E7F0", VA = "0x18692FBF0")]
	[BurstCompile]
	public unsafe static void HJKALOGPOOD([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6946460", Offset = "0x6945060", VA = "0x186946460")]
	[BurstCompile]
	public unsafe static void OHBAOBLHCDE([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6941FC0", Offset = "0x6940BC0", VA = "0x186941FC0")]
	[BurstCompile]
	public unsafe static void DJAMFPCDKJN([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* CGGPJEKDELC, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x692F930", Offset = "0x692E530", VA = "0x18692F930")]
	[BurstCompile]
	public unsafe static void GPCHDBDCGIB([NoAlias] ushort* GOHJAHLPMHM, [Out] float2 JALBANMKKPO, [Out] float2 FEGFKMKOKJI, [In][NoAlias] float2* KGLPMGDBLDA, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6945C20", Offset = "0x6944820", VA = "0x186945C20")]
	[BurstCompile]
	public static void NPFNHCLLJFE([Out] float2 BIEFILDINCP, ushort HPGBFMALFJN, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6945840", Offset = "0x6944440", VA = "0x186945840")]
	[BurstCompile]
	public unsafe static void NCOEMAMKPBC([NoAlias] float2* GOHJAHLPMHM, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6945B30", Offset = "0x6944730", VA = "0x186945B30")]
	[BurstCompile]
	public unsafe static void NMKLJMJGBOI([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69453C0", Offset = "0x6943FC0", VA = "0x1869453C0")]
	[BurstCompile]
	public unsafe static void MFLJCAPLFPJ([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6944EA0", Offset = "0x6943AA0", VA = "0x186944EA0")]
	[BurstCompile]
	public unsafe static void LGNJHMCEFML([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [NoAlias] ushort* KGLPMGDBLDA, int DEKBEBJEJFH, [In] float2 IOAMICHEMDF, [In] float2 FEGFKMKOKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6942710", Offset = "0x6941310", VA = "0x186942710")]
	[BurstCompile]
	public unsafe static void EMMLGADLLMD([NoAlias] ushort* JDAEIDEKFAO, [In][NoAlias] float4* NAFDKIMCCCJ, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6945920", Offset = "0x6944520", VA = "0x186945920")]
	[BurstCompile]
	public static ushort NJNNJNNFBGG([In] float4 LOCEOOKGKLF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69437B0", Offset = "0x69423B0", VA = "0x1869437B0")]
	[BurstCompile]
	public unsafe static void GJELDCAKBKD([NoAlias] float4* JDAEIDEKFAO, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x692F680", Offset = "0x692E280", VA = "0x18692F680")]
	[BurstCompile]
	public unsafe static void FEAAAHHOPJH([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69405B0", Offset = "0x693F1B0", VA = "0x1869405B0")]
	[BurstCompile]
	public unsafe static void AFPLOFEMLJO([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69404A0", Offset = "0x693F0A0", VA = "0x1869404A0")]
	[BurstCompile]
	public unsafe static void AFIPOMFJPHI([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ushort* EIPOLOCODAG, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6945560", Offset = "0x6944160", VA = "0x186945560")]
	[BurstCompile]
	public static void MNBLKCIFPJF([Out] float4 JFBAIGMLPKE, ushort HPGBFMALFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6930080", Offset = "0x692EC80", VA = "0x186930080")]
	[BurstCompile]
	public unsafe static void KNEFFONKAJI([NoAlias] float4* NCGKNFHNANP, [NoAlias] byte* OJAPPBGOGBB, [Out] int ENGDNBBBMIM, [Out] int FEINLNBEIJF, [NoAlias] float4* NMFPDKPAMPA, int GAGKKEJAEBP, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6942480", Offset = "0x6941080", VA = "0x186942480")]
	[BurstCompile]
	public unsafe static void EIDDKFJFPON([NoAlias] float4* LIIIACKPECP, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6944CC0", Offset = "0x69438C0", VA = "0x186944CC0")]
	[BurstCompile]
	public unsafe static void KHBMIEBGMBD([NoAlias] LMMNEJCMKMI.LHDJLNNJOCL* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6946A00", Offset = "0x6945600", VA = "0x186946A00")]
	[BurstCompile]
	public unsafe static void PMKIDCGJAJI([NoAlias] LMMNEJCMKMI.BDIIOGGPADE* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x69451E0", Offset = "0x6943DE0", VA = "0x1869451E0")]
	[BurstCompile]
	public unsafe static void MEJNELPIHDN([NoAlias] LMMNEJCMKMI.DDOOHJOGKPB* CNOGDOOCKKH, [In][NoAlias] ALBPDBDCGGO* HOHDCKKDOFJ, [In][NoAlias] byte* FBBEAHHFGKM, int DEKBEBJEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6941EC0", Offset = "0x6940AC0", VA = "0x186941EC0")]
	[BurstCompile]
	public unsafe static int DDEKHDNMEGN([NoAlias] byte* BMGJDDKFEDH, [In][NoAlias] int* OJMIIKABODC, int IGAHEKDDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6943BC0", Offset = "0x69427C0", VA = "0x186943BC0")]
	[BurstCompile]
	public unsafe static void HHMKCHIFBFH([NoAlias] int* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6941C60", Offset = "0x6940860", VA = "0x186941C60")]
	[BurstCompile]
	public unsafe static void CFPDBLHHACO([NoAlias] ushort* BNIMJDJCLJG, [In][NoAlias] byte* GGIINHEBNDL, int ONAEOHMBPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6943C60", Offset = "0x6942860", VA = "0x186943C60")]
	[BurstCompile]
	public static void HLCAFHOBEMA([Out] float3 BIEFILDINCP, ushort HPGBFMALFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6930240", Offset = "0x692EE40", VA = "0x186930240")]
	[BurstCompile]
	public static ushort PMOABINADID([In] float3 LOCEOOKGKLF)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct EKFFDEJLBOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 OPIIJFJCLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 LDJLGOFDCLG;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class AIMHJEJBNMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<EKFFDEJLBOM> FGEBABECNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> JKDMFDMJKGO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PJALGAPEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x844560", Offset = "0x843160", VA = "0x180844560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6931CE0", Offset = "0x69308E0", VA = "0x186931CE0")]
	public AIMHJEJBNMD(int CPKKHGLLOGC, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6931C80", Offset = "0x6930880", VA = "0x186931C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6931BA0", Offset = "0x69307A0", VA = "0x186931BA0")]
	public void DCNHNFPJNMN(AIMHJEJBNMD BEOONNIMBFM, int KBLMIJNFOBN, int PAGNMFPMINA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GMJKMGODGEI
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AIMHJEJBNMD GBNLEGCIDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<COBDJLBJLPG> FNOAGKHNLPL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] OFCMGOHLNMG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool GFMLEEAGAEN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, AIMHJEJBNMD> EEAFAKJPEKD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, AIMHJEJBNMD> OEAOKHAHAMO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool GNEFGKACDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6939D80", Offset = "0x6938980", VA = "0x186939D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<COBDJLBJLPG> AOHAGELBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6939080", Offset = "0x6937C80", VA = "0x186939080")]
		get
		{
			return default(NativeList<COBDJLBJLPG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static AIMHJEJBNMD HIHIJFBGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6939E00", Offset = "0x6938A00", VA = "0x186939E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6939730", Offset = "0x6938330", VA = "0x186939730")]
	private static void IPDPHCNKANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6939EA0", Offset = "0x6938AA0", VA = "0x186939EA0")]
	public static int NEGBPKAIHEN(bool MOHIMACCOOJ, int KDDGKGOKAKD, bool DCFJIIBGMDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69396F0", Offset = "0x69382F0", VA = "0x1869396F0")]
	private static int HJHGFMNCDGD(int KDDGKGOKAKD, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6939ED0", Offset = "0x6938AD0", VA = "0x186939ED0")]
	private static int NGAAFBPJIHM(int KDDGKGOKAKD, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6939660", Offset = "0x6938260", VA = "0x186939660")]
	public static int HFCEEOMMKEE(int ICDAEIIIEFB, int KDDGKGOKAKD, int POCPOCDDHFA, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6939FD0", Offset = "0x6938BD0", VA = "0x186939FD0")]
	public static int PKMGGILDEDA(int ICDAEIIIEFB, int KDDGKGOKAKD, int POCPOCDDHFA, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6939630", Offset = "0x6938230", VA = "0x186939630")]
	public static int ELFOHJHNMCK(int POCPOCDDHFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x693A060", Offset = "0x6938C60", VA = "0x18693A060")]
	private static int PLFDNOOCKIE(int KDDGKGOKAKD, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6939710", Offset = "0x6938310", VA = "0x186939710")]
	private static int IBJPOGCFLOL(int KDDGKGOKAKD, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6939530", Offset = "0x6938130", VA = "0x186939530")]
	public static int DLGLLJLDEDI(int ICDAEIIIEFB, int KDDGKGOKAKD, int POCPOCDDHFA, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69395A0", Offset = "0x69381A0", VA = "0x1869395A0")]
	public static int ECAHHBCEKJG(int ICDAEIIIEFB, int KDDGKGOKAKD, int POCPOCDDHFA, bool AFMLNAPFMMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6939640", Offset = "0x6938240", VA = "0x186939640")]
	public static int GIMJFMCBBML(int POCPOCDDHFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6938F90", Offset = "0x6937B90", VA = "0x186938F90")]
	public static AIMHJEJBNMD BHFJGMMDJNH(int KDDGKGOKAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x69389C0", Offset = "0x69375C0", VA = "0x1869389C0")]
	private static AIMHJEJBNMD ANEPFIFDPEJ(int KDDGKGOKAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6939EE0", Offset = "0x6938AE0", VA = "0x186939EE0")]
	public static AIMHJEJBNMD OBHPMPMJFCD(int KDDGKGOKAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6938C50", Offset = "0x6937850", VA = "0x186938C50")]
	private static AIMHJEJBNMD BFAPFKCEOEL(int KDDGKGOKAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6939120", Offset = "0x6937D20", VA = "0x186939120")]
	public static void DKIOIKPIJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NKPNLLOAEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int IGHLABAKIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 DOAOCFCIHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion MKOAIKBDPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float KBLCDMODMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float GBGGDLGIDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int AFDBCPGONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int IFLIDIAMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NIKGDGACHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool HLHOGLGGHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool DKBHDEFOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float NNNDEDNDFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 EKOKNCOOGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool GPGBGHIIAPD;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct JKBHACPMHNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int CMMAFNOCEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int AMDNFAKFEGA;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JEIFKPCOENI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<NKPNLLOAEEE> LEBEOADFNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<LPFJHNJFEMI> DFNKFDBLPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<COBDJLBJLPG> FENNHLHPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<JKBHACPMHNO> GFPDDCMCFGK;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x693E9D0", Offset = "0x693D5D0", VA = "0x18693E9D0")]
	public JEIFKPCOENI(NativeArray<LPFJHNJFEMI> DFNKFDBLPMB, int AEOJMEBJNPD = 1, Allocator BLMBIIGOJPG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x693E8E0", Offset = "0x693D4E0", VA = "0x18693E8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct IHPJNGOPJCG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<EKFFDEJLBOM> APGNJMIKPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> ONMHEGELIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<COBDJLBJLPG> KDPPNDDNEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<NKPNLLOAEEE> LEBEOADFNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<LPFJHNJFEMI> DFNKFDBLPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<COBDJLBJLPG> FENNHLHPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<JKBHACPMHNO> GFPDDCMCFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int CFFNHNDNHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int OMEBHBAJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 PEEOPDPLHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion NMBGKPNDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 LJFMDGJJGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CIHALJBBJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DNCCBFFLHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HOIDGCFACDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GLEOEDGNCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NFIHLBLOOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CGNNDIIFDBK;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x693E650", Offset = "0x693D250", VA = "0x18693E650")]
	public IHPJNGOPJCG(MIFCIJEACKE DLLLINKKONJ, LMMNEJCMKMI JAPLBHJMFBA, float3 OIBDPLAMNOH, quaternion BNKIMEOMGHP, float COFMACFMALC, int PJINPOLDAIF = 0, int JIFEIJBJDOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x693E420", Offset = "0x693D020", VA = "0x18693E420")]
	public IHPJNGOPJCG(JEIFKPCOENI DLLLINKKONJ, LMMNEJCMKMI JAPLBHJMFBA, float3 OIBDPLAMNOH, quaternion BNKIMEOMGHP, float3 COFMACFMALC, int PJINPOLDAIF = 0, int JIFEIJBJDOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x693E2F0", Offset = "0x693CEF0", VA = "0x18693E2F0")]
	private float3 PPOPHCJFJID(float3 BDLEKLLOOKD, Matrix4x4 NABPGNKMIIB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x693E270", Offset = "0x693CE70", VA = "0x18693E270")]
	private float3x3 OKECPPLBOAL(float3x3 KHENOBLJNOE, float3x3 NEPAFJEEKPF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x693DE00", Offset = "0x693CA00", VA = "0x18693DE00")]
	private float KEMLIHKJMNE(float IADPMFLONGE, float PIFIFMDCMDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x693CAF0", Offset = "0x693B6F0", VA = "0x18693CAF0", Slot = "4")]
	public void Execute(int BIIBCGDMKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x693DC90", Offset = "0x693C890", VA = "0x18693DC90")]
	private void FCCCLPBCPEF(int HJNHOOLJCJI, float3 DFPHDEDIHFK, float3 KLEPCPADMKG, float3 GLLONGLNLBL, float HNLLDLBIGBG, bool NEELNADNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x693DE10", Offset = "0x693CA10", VA = "0x18693DE10")]
	private void LBFHIIANPPB(NKPNLLOAEEE ADBLBFFGHJO, float3 CILJGBPKAKN, float3x3 JLMIPDKPKDA, float IADPMFLONGE, int KDFNMOINNLI, int INIKIHFILPG, int GECOIDDEPBL, float IEPMADKDKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x693C4A0", Offset = "0x693B0A0", VA = "0x18693C4A0")]
	private void CGDBFOAFAFN(int HJNHOOLJCJI, int MHMBJEBAFLO, NKPNLLOAEEE ADBLBFFGHJO, float3 CILJGBPKAKN, float3x3 JLMIPDKPKDA, bool OBOEFPGIKAF, float IADPMFLONGE, int BPKHIAGALBB, int GMADBLGLIBO, int GECOIDDEPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct JOCHAPLMNCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<MAACIMNGHGA> EILMODJMKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<COBDJLBJLPG> PFPHFDCLDML;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x693F6E0", Offset = "0x693E2E0", VA = "0x18693F6E0")]
	public JOCHAPLMNCP(int AEOJMEBJNPD, Allocator BLMBIIGOJPG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x693F640", Offset = "0x693E240", VA = "0x18693F640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct FEKDHGDOKIH : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum LADGPNCCLME
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
	private NativeList<float3> HMOPMPHMCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> EEBHBKKFGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> PNIFLLKMAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> KPGMPANECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> LFBFOKDJPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> IBILKFKOGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> NLCJAPLLLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> NKJJFIMHDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<COBDJLBJLPG> PDKMMDELHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<MAACIMNGHGA> EILMODJMKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<COBDJLBJLPG> PFPHFDCLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int CFFNHNDNHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int OMEBHBAJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CIHALJBBJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DNCCBFFLHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HOIDGCFACDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GLEOEDGNCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NFIHLBLOOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CGNNDIIFDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 LJFMDGJJGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion NMBGKPNDCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 PEEOPDPLHOO;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x69376B0", Offset = "0x69362B0", VA = "0x1869376B0")]
	public FEKDHGDOKIH(MIFCIJEACKE DLLLINKKONJ, LMMNEJCMKMI JAPLBHJMFBA, float3 OIBDPLAMNOH, quaternion BNKIMEOMGHP, float COFMACFMALC, int PJINPOLDAIF = 0, int JIFEIJBJDOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x69374C0", Offset = "0x69360C0", VA = "0x1869374C0")]
	public FEKDHGDOKIH(JOCHAPLMNCP IMCLGJBJJKP, LMMNEJCMKMI JAPLBHJMFBA, float3 OIBDPLAMNOH, quaternion BNKIMEOMGHP, float3 COFMACFMALC, int PJINPOLDAIF = 0, int JIFEIJBJDOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6936170", Offset = "0x6934D70", VA = "0x186936170", Slot = "4")]
	public void Execute(int BIIBCGDMKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69370D0", Offset = "0x6935CD0", VA = "0x1869370D0")]
	private void JHFGJGGPNKF(float4x4 JPIJFFCOHKA, int BIIBCGDMKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6936100", Offset = "0x6934D00", VA = "0x186936100")]
	private LADGPNCCLME BFDLHOEOBPE(float3 KLEPCPADMKG)
	{
		return default(LADGPNCCLME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x69360B0", Offset = "0x6934CB0", VA = "0x1869360B0")]
	private float4 AGDHDBFKOBB(LADGPNCCLME JPHHLDCLJPJ, int OPDMGNJCACB)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6937480", Offset = "0x6936080", VA = "0x186937480")]
	private float2 MMDBDMDKPBP(LADGPNCCLME JPHHLDCLJPJ, float3 DFPHDEDIHFK)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct HNDIMPDNNMG
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum EFONAAKMIPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static HNDIMPDNNMG BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 KJEIHCPEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 INEDIBJAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 LBOCLAHFPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public EFONAAKMIPH AJCKJIKGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 GFPMPELFLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 LFMDGEHMDGM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GKFNCCNFNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x693B340", Offset = "0x6939F40", VA = "0x18693B340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 JLBJEJBAMPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x693B350", Offset = "0x6939F50", VA = "0x18693B350")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x693BCD0", Offset = "0x693A8D0", VA = "0x18693BCD0")]
	public HNDIMPDNNMG(float3 DFPHDEDIHFK, quaternion DELGPMLKBMI, float3 AEOJMEBJNPD, EFONAAKMIPH NCNNODEFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x693B960", Offset = "0x693A560", VA = "0x18693B960")]
	public float OENEPKJGNNO(float3 CILJGBPKAKN, float NAACFNHBJLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x693B430", Offset = "0x693A030", VA = "0x18693B430")]
	public bool HAABMOPFMDO(float3 KLEPCPADMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x693B7B0", Offset = "0x693A3B0", VA = "0x18693B7B0")]
	public void MBJAKHMCBBO(float3 MPLHBOMCJPH, float3x3 LJCPHBBHBML, float LKBMGBKLLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x693BB60", Offset = "0x693A760", VA = "0x18693BB60")]
	private void OKNAHNDIIKD(float3 EJEEODBGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x693B520", Offset = "0x693A120", VA = "0x18693B520")]
	public void IOCKDBAHMLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct AICDBGKFCPO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<HNDIMPDNNMG> IMCLGJBJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> BPEKIFJBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> IOIEKIBENAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OCPPLKCHJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<COBDJLBJLPG> PFPHFDCLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int ALFEMKAEOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int PEBOMHBBILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float NAACFNHBJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float EFCDEFKJFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MDKHKMPIKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> COHKJGMKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> JMIELJENIIN;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6931B00", Offset = "0x6930700", VA = "0x186931B00")]
	public AICDBGKFCPO(LMMNEJCMKMI AIKMKIOPGIF, float BLEFOJOEJMK, int PAGNMFPMINA, int KDFNMOINNLI, NativeList<HNDIMPDNNMG> IMCLGJBJJKP, NativeArray<int> OCPPLKCHJCO, NativeList<COBDJLBJLPG> PFPHFDCLDML, FFNAJOLLOGD FIPNINMIBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6931300", Offset = "0x692FF00", VA = "0x186931300", Slot = "4")]
	public void Execute(int NPNKKGDECIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6931A40", Offset = "0x6930640", VA = "0x186931A40")]
	private bool GNCAAFOEDID(HNDIMPDNNMG NABHBOMGBNH, HNDIMPDNNMG EIKHFLMLKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6931060", Offset = "0x692FC60", VA = "0x186931060")]
	private bool AFLBNBNFPHG(HNDIMPDNNMG BKMPOHCPCGL, int KBFHDEMMFEK, int ACFMPMLDNJN, int LFDCDOKGNPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FFNAJOLLOGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> EJCANBFIOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> JLOJDBEBLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> MMHPGLHIDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> FKEDCHAAIGG;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6937990", Offset = "0x6936590", VA = "0x186937990")]
	public void GCJMNEGAMAM(int CPKKHGLLOGC, int OGGCPDDOCHP, Allocator BLMBIIGOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6937BA0", Offset = "0x69367A0", VA = "0x186937BA0")]
	public static long OGEGEMFGHBJ(int CPKKHGLLOGC, int OGGCPDDOCHP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x69378A0", Offset = "0x69364A0", VA = "0x1869378A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6937AB0", Offset = "0x69366B0", VA = "0x186937AB0")]
	public void LNHLHNCBJPB(JobHandle CAEABJCEFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FFNAJOLLOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct NMELLABHMCL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> BPEKIFJBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> NLAKIACODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> JMGMPJKEBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> FHNPGGHFDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> IOIEKIBENAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EBNICOCLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> OFGBPPLKEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> MDKHKMPIKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> COHKJGMKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int PJINPOLDAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int JIFEIJBJDOK;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x694BDF0", Offset = "0x694A9F0", VA = "0x18694BDF0")]
	public NMELLABHMCL(LMMNEJCMKMI AIKMKIOPGIF, FFNAJOLLOGD FIPNINMIBMI, int JIFEIJBJDOK = 0, int PJINPOLDAIF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x694B9B0", Offset = "0x694A5B0", VA = "0x18694B9B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x694BD90", Offset = "0x694A990", VA = "0x18694BD90")]
	private void LOIALMPPDJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PGPLMPACJNN
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB4A0", Offset = "0x2CEA0A0", VA = "0x182CEB4A0")]
	public static bool NJLJBDPNNPI<T>(NativeArray<T> CHPEIOMPEEH, int AEOJMEBJNPD, Allocator BLMBIIGOJPG, NativeArrayOptions MMOLNDGHCHC = NativeArrayOptions.ClearMemory, int LPJLCNAGOCP = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB620", Offset = "0x2CEA220", VA = "0x182CEB620")]
	public static bool NJLJBDPNNPI<T>(NativeList<T> KNDOIJDCKAF, int AEOJMEBJNPD, Allocator BLMBIIGOJPG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum KGJGBLBKEFH
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
public interface DDMJJMAFFKD
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CBNCALLEGGB(KGJGBLBKEFH ICDAEIIIEFB);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PDDAMKOHBMH(KGJGBLBKEFH ICDAEIIIEFB);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds MENOKNFHDIN();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float IJLEJCLNBHJ();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLIKAKHCLNI(KGJGBLBKEFH ICDAEIIIEFB, MIFCIJEACKE FFMLDGLBBOI, int PFMHMDAIDDB = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class LMMNEJCMKMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum GJKIEGIEBEL
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
	public struct JHCGKBDLIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public GJKIEGIEBEL KKEJAEKDBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool OLJGGLHOMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int EJBPPJMNNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] JMDJEFMLOIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct AIAOKBLNHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 DFPHDEDIHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 KLEPCPADMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 GLLONGLNLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 EIMKNMPGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 JMGMPJKEBLC;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] JMDJEFMLOIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct LHDJLNNJOCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 DFPHDEDIHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 KLEPCPADMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 GLLONGLNLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 EIMKNMPGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 JMGMPJKEBLC;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] JMDJEFMLOIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct HGBPMCOPCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 DFPHDEDIHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 KLEPCPADMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 GLLONGLNLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 EIMKNMPGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint JMGMPJKEBLC;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] JMDJEFMLOIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct BDIIOGGPADE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 DFPHDEDIHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint KLEPCPADMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint GLLONGLNLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 EIMKNMPGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 JMGMPJKEBLC;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] JMDJEFMLOIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct DDOOHJOGKPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 DFPHDEDIHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint KLEPCPADMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint GLLONGLNLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 EIMKNMPGLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 JMGMPJKEBLC;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] JMDJEFMLOIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int LBDCNDOAEMB(float KNFDPFPHEON);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class IPHCGBOAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x69544C0", Offset = "0x69530C0", VA = "0x1869544C0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6954910", Offset = "0x6953510", VA = "0x186954910")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6954860", Offset = "0x6953460", VA = "0x186954860")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x69545F0", Offset = "0x69531F0", VA = "0x1869545F0")]
		public static int DOBCDLDNJAI(float KNFDPFPHEON)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint LKOIHIMMOCB([In] float4 BGNEHGMDHMD);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class GHBMGFDDDAM
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6953050", Offset = "0x6951C50", VA = "0x186953050")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6953570", Offset = "0x6952170", VA = "0x186953570")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x69534C0", Offset = "0x69520C0", VA = "0x1869534C0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6953180", Offset = "0x6951D80", VA = "0x186953180")]
		public static uint DOBCDLDNJAI([In] float4 BGNEHGMDHMD)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint JMOODMMGMBH([In] float3 BGNEHGMDHMD);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class IFDAFGHNOOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6953F00", Offset = "0x6952B00", VA = "0x186953F00")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6954360", Offset = "0x6952F60", VA = "0x186954360")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x69542B0", Offset = "0x6952EB0", VA = "0x1869542B0")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6954030", Offset = "0x6952C30", VA = "0x186954030")]
		public static uint DOBCDLDNJAI([In] float3 BGNEHGMDHMD)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void HHCPLOPICAD([NoAlias] BDIIOGGPADE* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class GODMIFLDLMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x69536D0", Offset = "0x69522D0", VA = "0x1869536D0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6953AF0", Offset = "0x69526F0", VA = "0x186953AF0")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6953A40", Offset = "0x6952640", VA = "0x186953A40")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6953800", Offset = "0x6952400", VA = "0x186953800")]
		public unsafe static void DOBCDLDNJAI([NoAlias] BDIIOGGPADE* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void OGCJDAOGHLO([NoAlias] DDOOHJOGKPB* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class CCBKMDOFMJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr OLEOLLBPMJC;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr EJGKMOBLDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x694E2F0", Offset = "0x694CEF0", VA = "0x18694E2F0")]
		[BurstDiscard]
		private static void CKJAJHJFNLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x694E710", Offset = "0x694D310", VA = "0x18694E710")]
		private static IntPtr PJBEJBFBGNB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x694E660", Offset = "0x694D260", VA = "0x18694E660")]
		public static void OCNAMCBHJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x694E420", Offset = "0x694D020", VA = "0x18694E420")]
		public unsafe static void DOBCDLDNJAI([NoAlias] DDOOHJOGKPB* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int AHADCGPJNIA = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> AKODOEHHDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> PEOFEPJIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> BALFFAOEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> GNPDAABBPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> CBMBFDLJKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> OCHIBIHMFOB;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] PEKADOEOCNB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool AFLGMNBNEKB;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static JHCGKBDLIFO[] EPOEOOHGOED;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IHNECOIEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6954E90", Offset = "0x6953A90", VA = "0x186954E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6954C20", Offset = "0x6953820", VA = "0x186954C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PJALGAPEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6956820", Offset = "0x6955420", VA = "0x186956820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FLJKDMIHIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6959CA0", Offset = "0x69588A0", VA = "0x186959CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void ABLCGNFCFEC(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void PDEPCHCEHNB(bool BLMOINJCONF, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6956860", Offset = "0x6955460", VA = "0x186956860", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6957030", Offset = "0x6955C30", VA = "0x186957030")]
	public void GCJMNEGAMAM(int CPKKHGLLOGC, int OGGCPDDOCHP, Allocator BLMBIIGOJPG, bool BEDJKEPLNKN, bool DNNDPOCHOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6958C90", Offset = "0x6957890", VA = "0x186958C90")]
	public void KANMFGLHFMM(int CPKKHGLLOGC, int OGGCPDDOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6959C90", Offset = "0x6958890", VA = "0x186959C90", Slot = "6")]
	public bool PCFOMDMAMGM(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6955E20", Offset = "0x6954A20", VA = "0x186955E20")]
	public bool CKDKGPGHKHI(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x69575B0", Offset = "0x69561B0", VA = "0x1869575B0")]
	public bool IKOCNFPHHJM(Mesh AIKMKIOPGIF, LMMNEJCMKMI FBPMIAKBDID, bool FPFFNBJJKOC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6957BE0", Offset = "0x69567E0", VA = "0x186957BE0")]
	public void JACHFIKJOIF(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69553A0", Offset = "0x6953FA0", VA = "0x1869553A0")]
	public void CFNBEFHGBCE(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6954DF0", Offset = "0x69539F0", VA = "0x186954DF0")]
	[BurstCompile]
	public static int AJPLHELECCI(float KNFDPFPHEON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6954DA0", Offset = "0x69539A0", VA = "0x186954DA0")]
	[BurstCompile]
	public static uint AJPLHELECCI([In] float4 BGNEHGMDHMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6954E40", Offset = "0x6953A40", VA = "0x186954E40")]
	[BurstCompile]
	public static uint AJPLHELECCI([In] float3 BGNEHGMDHMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x69569F0", Offset = "0x69555F0", VA = "0x1869569F0")]
	public void FPABKBJPGPL(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6954ED0", Offset = "0x6953AD0", VA = "0x186954ED0")]
	[BurstCompile]
	private unsafe static void APIDAJBMJIE([NoAlias] BDIIOGGPADE* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6959450", Offset = "0x6958050", VA = "0x186959450")]
	public void OGNDEIFNIJD(Mesh AIKMKIOPGIF, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6956970", Offset = "0x6955570", VA = "0x186956970")]
	[BurstCompile]
	private unsafe static void ECJHANEDHCD([NoAlias] DDOOHJOGKPB* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6957220", Offset = "0x6955E20", VA = "0x186957220")]
	public void HCIOMDNKCMI(Mesh AIKMKIOPGIF, GJKIEGIEBEL KKEJAEKDBIN, bool FPFFNBJJKOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6956200", Offset = "0x6954E00", VA = "0x186956200")]
	public void DCNHNFPJNMN(LMMNEJCMKMI AIKMKIOPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6954C60", Offset = "0x6953860", VA = "0x186954C60")]
	public LMMNEJCMKMI AIIIFAEPLFO(Allocator BLMBIIGOJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6959B00", Offset = "0x6958700", VA = "0x186959B00")]
	public long PAEJIDGKEKJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6959C30", Offset = "0x6958830", VA = "0x186959C30")]
	public static long PAEJIDGKEKJ(int KGLNBDKHKAF, int DNMAHECHAFN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6957510", Offset = "0x6956110", VA = "0x186957510")]
	public static long IFOOKEFGNEL(int KGLNBDKHKAF, int DNMAHECHAFN, GJKIEGIEBEL KKEJAEKDBIN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6957450", Offset = "0x6956050", VA = "0x186957450")]
	public long IFOOKEFGNEL(GJKIEGIEBEL KKEJAEKDBIN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69573F0", Offset = "0x6955FF0", VA = "0x1869573F0")]
	public void HNOEAOGCPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6958D10", Offset = "0x6957910", VA = "0x186958D10")]
	public static void KHANEBMHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6958630", Offset = "0x6957230", VA = "0x186958630")]
	public GJKIEGIEBEL JMCMJMEPJJC()
	{
		return default(GJKIEGIEBEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x69590A0", Offset = "0x6957CA0", VA = "0x1869590A0")]
	public static (int, int) LMDEABOPGEN(Mesh AIKMKIOPGIF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6957310", Offset = "0x6955F10", VA = "0x186957310")]
	public static int HJJLIMIKBJN(VertexAttributeDescriptor[] MAPPJDELIID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6959A90", Offset = "0x6958690", VA = "0x186959A90")]
	public static long OJDCMNANILD(Mesh AIKMKIOPGIF, int HFFLIKDPGHC, int LHOIBDOPJMC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LMMNEJCMKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6959170", Offset = "0x6957D70", VA = "0x186959170")]
	[BurstCompile]
	public static int MHFOKDLKHKO(float KNFDPFPHEON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x69592C0", Offset = "0x6957EC0", VA = "0x1869592C0")]
	[BurstCompile]
	public static uint MHFOKDLKHKO([In] float4 BGNEHGMDHMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6959210", Offset = "0x6957E10", VA = "0x186959210")]
	[BurstCompile]
	public static uint MHFOKDLKHKO([In] float3 BGNEHGMDHMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6956470", Offset = "0x6955070", VA = "0x186956470")]
	[BurstCompile]
	public unsafe static void DDKOJHLLNBP([NoAlias] BDIIOGGPADE* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6954F50", Offset = "0x6953B50", VA = "0x186954F50")]
	[BurstCompile]
	public unsafe static void CANGHJCINHI([NoAlias] DDOOHJOGKPB* CNOGDOOCKKH, int DEKBEBJEJFH, [In][NoAlias] float3* AEDMAPHFDAE, [In][NoAlias] float3* NLAKIACODEK, [In][NoAlias] float4* EBNICOCLCAL, [In][NoAlias] float2* FHNPGGHFDLO, [In][NoAlias] float4* JMGMPJKEBLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class BPAKKIJEKIC
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x694E1A0", Offset = "0x694CDA0", VA = "0x18694E1A0")]
	public static void DKIOIKPIJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DGPNKCCILAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> AKODOEHHDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> PEOFEPJIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> IIMOCNFGJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> CPDDGIBLCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> NNHELBMPGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> KKLKDIIJBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> EGHEGBOFGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> OCHIBIHMFOB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x694EA20", Offset = "0x694D620", VA = "0x18694EA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PJALGAPEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x694F2E0", Offset = "0x694DEE0", VA = "0x18694F2E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AAEDOHNLHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x694F8C0", Offset = "0x694E4C0", VA = "0x18694F8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x694FBF0", Offset = "0x694E7F0", VA = "0x18694FBF0")]
	public DGPNKCCILAO(int CPKKHGLLOGC, int OGGCPDDOCHP, int PMCMFJMLKGJ, Allocator BLMBIIGOJPG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x694F900", Offset = "0x694E500", VA = "0x18694F900")]
	public DGPNKCCILAO(Mesh AIKMKIOPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x694F320", Offset = "0x694DF20", VA = "0x18694F320", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x694EFE0", Offset = "0x694DBE0", VA = "0x18694EFE0")]
	public void DCNHNFPJNMN(DGPNKCCILAO AIKMKIOPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x694F430", Offset = "0x694E030", VA = "0x18694F430")]
	private void HOOBHEDFABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x694EA60", Offset = "0x694D660", VA = "0x18694EA60")]
	private void BLHILMCBIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct COBDJLBJLPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int NCPBMHBEPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int CEBNKMJLOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int JJFBMMKIKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int PJALGAPEPPB;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x13D5BF0", Offset = "0x13D47F0", VA = "0x1813D5BF0")]
	public COBDJLBJLPG(int KDFNMOINNLI, int DEKBEBJEJFH, int PAGNMFPMINA, int ONAEOHMBPHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GBNCKKMGOCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<COBDJLBJLPG> AHEDIKMLGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<COBDJLBJLPG>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x978B90", Offset = "0x977790", VA = "0x180978B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DGPNKCCILAO OEOBLGFMCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6952AA0", Offset = "0x69516A0", VA = "0x186952AA0")]
	public GBNCKKMGOCO(IEnumerable<DGPNKCCILAO> PCDMMGMHGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6952A30", Offset = "0x6951630", VA = "0x186952A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum MCDPNEDALEI
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class EDMFCLILCMO
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> AKMKMHOHENF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> KIEDDLLDKNI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> CLOMPAHGDLG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> CMPKNEHPDKL;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x69500E0", Offset = "0x694ECE0", VA = "0x1869500E0")]
	public static void DKIOIKPIJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x694FEC0", Offset = "0x694EAC0", VA = "0x18694FEC0")]
	public static NativeArray<float2> AANIICJHONO(NativeArray<float2> DKPMAKCPPLL, int EKOILANPFKL, NativeArray<float2> MBGIGPLIPBO, int IOMIHIGGFOO)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x694FFD0", Offset = "0x694EBD0", VA = "0x18694FFD0")]
	public static NativeArray<float3> DIDBGLOHFCB(NativeArray<float3> DKPMAKCPPLL, int EKOILANPFKL, NativeArray<float3> MBGIGPLIPBO, int IOMIHIGGFOO)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6950310", Offset = "0x694EF10", VA = "0x186950310")]
	public static NativeArray<float4> NAEJHOFMJBP(NativeArray<float4> DKPMAKCPPLL, int EKOILANPFKL, NativeArray<float4> MBGIGPLIPBO, int IOMIHIGGFOO)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6950200", Offset = "0x694EE00", VA = "0x186950200")]
	public static NativeArray<int> FGAIOHFMFEL(NativeArray<int> DKPMAKCPPLL, int EKOILANPFKL, NativeArray<int> MBGIGPLIPBO, int IOMIHIGGFOO)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2973B60", Offset = "0x2972760", VA = "0x182973B60")]
	private static void MLFNCIDJPJD<T>(NativeArray<T> CHPEIOMPEEH, int FLOKNMBPNBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2973A80", Offset = "0x2972680", VA = "0x182973A80")]
	private static void APPMGLKHAHD<T>(NativeArray<T> DKPMAKCPPLL, int EKOILANPFKL, NativeArray<T> MBGIGPLIPBO, int IOMIHIGGFOO, NativeArray<T> IHEIGHJNJIL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OJPDGIKIEPK
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum ALCJMENLFBE
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
	public class POCDHKDGIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public KILHCAAOJJN AIKMKIOPGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int OEADCEDODIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int CHPEENDPIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long MPCPANOHECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long KGNPDPGAFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float KOFBAJDAIIA;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6963CE0", Offset = "0x69628E0", VA = "0x186963CE0")]
		public POCDHKDGIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6963CA0", Offset = "0x69628A0", VA = "0x186963CA0")]
		public void LNHLHNCBJPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string EPHAGBPLGPA;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string KDOJNBDPFNN;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker APJFJHLOAOI;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker JLINELKFLCK;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker KHPNOPDCKDE;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker NBOCAOMGNOC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker CHAODMMNFKE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker FPBMLDOCEBC;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker NLNCCJNHFEK;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker FDKDKOMBKKN;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker GIKEDGKBGDH;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker DBNHMELCOPI;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker JGPBMPCLBDN;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker FKPJKCOOIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<DDMJJMAFFKD> NNPPNIHAGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly DEAGKENLJKN MCACOIILMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int DEKBEBJEJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int ONAEOHMBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool NBMGMGAOFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool GOLBGPLKMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal ALCJMENLFBE GJEHPOMDLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool GMNIHAIABMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 FKIJHNFDLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 IKNLMBAHFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float KOOHKMPAKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float ONPHLMOKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int GCPECMJPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int CIEMICGGNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int LNDMEGGMJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int JKBDAEJNOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float KNEHNLKAIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float MHNPFHCGIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int CKBMMBHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long JMBDOOGFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long MJMFAONCJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long MIMAJGFCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int ODDLKAKKNOG;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int HAPHNPCMEPN = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] OGLEHFDIFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] NKIKPHELFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] EGBKJGBKHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private LMMNEJCMKMI FEAPKLHIOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long NLHNKMFCNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long BBMDNNFNIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int FFJHODLFCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<POCDHKDGIHO> FCDCKILDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float HHFFGPCHIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal LMMNEJCMKMI.GJKIEGIEBEL AFOAJNPHOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool KNPKOOIBOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private EFOGHEKJLLN CKMAFLGKNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle DNDFHNBIJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> MDHMBEJGILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool BAKFCPOPNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle HMDAIOLOIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private LMMNEJCMKMI MJMNCLAOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform IMIAHLLPDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private KGJGBLBKEFH GOKMINJHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long KCIPFEKIMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long LMCPOICPKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long LKKNHJOOJIL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OEOBLGFMCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer HLNHIMHJGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KBLEBDALJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8B3970", Offset = "0x8B2570", VA = "0x1808B3970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EGNBAALODKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xC22600", Offset = "0xC21200", VA = "0x180C22600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int CEBNKMJLOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x695A6E0", Offset = "0x69592E0", VA = "0x18695A6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<DDMJJMAFFKD> AKLIHCALONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void PDEPCHCEHNB(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void ABLCGNFCFEC(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void PDEPCHCEHNB(bool BLMOINJCONF, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x695DF70", Offset = "0x695CB70", VA = "0x18695DF70")]
	public void HJMIKGPFPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x695A2A0", Offset = "0x6958EA0", VA = "0x18695A2A0")]
	private void ACJJPIFPAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x69639C0", Offset = "0x69625C0", VA = "0x1869639C0")]
	public OJPDGIKIEPK(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6960470", Offset = "0x695F070", VA = "0x186960470")]
	public void LNHLHNCBJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6960240", Offset = "0x695EE40", VA = "0x186960240")]
	public void KHPIGHLEDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x695A730", Offset = "0x6959330", VA = "0x18695A730")]
	private void BBBHKJBEPIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x695E220", Offset = "0x695CE20", VA = "0x18695E220")]
	public void JBINENPFJDC(DDMJJMAFFKD INFCDBBIIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x695C1A0", Offset = "0x695ADA0", VA = "0x18695C1A0")]
	public bool DMNMFCLLDGF(DDMJJMAFFKD INFCDBBIIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x695C110", Offset = "0x695AD10", VA = "0x18695C110")]
	public bool CPCALDGNEHE(DDMJJMAFFKD INFCDBBIIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x695C030", Offset = "0x695AC30", VA = "0x18695C030", Slot = "4")]
	public virtual void CBKDALFMEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x695A090", Offset = "0x6958C90", VA = "0x18695A090")]
	public void ACALOAMNIHN(Transform AENEBDOMFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x695D530", Offset = "0x695C130", VA = "0x18695D530")]
	private long FEOMKFEHLDD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x695D610", Offset = "0x695C210", VA = "0x18695D610")]
	private long GJINBPNNOGE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x695F210", Offset = "0x695DE10", VA = "0x18695F210")]
	public bool KGBODGHLFPF(Transform AENEBDOMFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x695ADB0", Offset = "0x69599B0", VA = "0x18695ADB0")]
	public bool BPEKFNICIDA(bool FMGBEEACLPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x695A9C0", Offset = "0x69595C0", VA = "0x18695A9C0")]
	public void BGIDDCGNHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x695C240", Offset = "0x695AE40", VA = "0x18695C240")]
	public bool EKAKGPDNJAM(float4x4 BFJLHHOANID, BatchedMeshRenderer KMPKLGJMHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x695AB40", Offset = "0x6959740", VA = "0x18695AB40")]
	public void BICMDCGOGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x695E3F0", Offset = "0x695CFF0", VA = "0x18695E3F0")]
	public bool JDAMBDKIHEF(bool FMGBEEACLPP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6960E70", Offset = "0x695FA70", VA = "0x186960E70")]
	public void NLLAHFBEBJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x695C170", Offset = "0x695AD70", VA = "0x18695C170")]
	public void DAGHKFIFNNK(LMMNEJCMKMI AIKMKIOPGIF, int ICOFJLIFAKG, int AMCFJKOMNPH, float NJKJKOKJOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x695C0E0", Offset = "0x695ACE0", VA = "0x18695C0E0")]
	public void CJBDOOMOGKF(KILHCAAOJJN FMLFFEJEHMB, int ICOFJLIFAKG, int AMCFJKOMNPH, float NJKJKOKJOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6963180", Offset = "0x6961D80", VA = "0x186963180")]
	public (long, long, long) PAEJIDGKEKJ()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xA59020", Offset = "0xA57C20", VA = "0x180A59020")]
	public long OMPPNGDKHHJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69602D0", Offset = "0x695EED0", VA = "0x1869602D0")]
	private void LAAPGIGCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x69631F0", Offset = "0x6961DF0", VA = "0x1869631F0")]
	public (long, long) POEGPDNJAPI(float GGJMPJNAPCL, float4x4 BFJLHHOANID)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	public void PHACDKGMKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6962AD0", Offset = "0x69616D0", VA = "0x186962AD0")]
	internal void OFOMPOOKKCN(ALCJMENLFBE DAPDCHLLPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6961FF0", Offset = "0x6960BF0", VA = "0x186961FF0")]
	private (float, float, float) OCFBBPECPMG(float JKEBBGODDNC, float4x4 BFJLHHOANID)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6962DD0", Offset = "0x69619D0", VA = "0x186962DD0")]
	private (int, int) OMCJIMCFBNK(float BADBOIFEMKJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6960E80", Offset = "0x695FA80", VA = "0x186960E80")]
	public void OAMDCOFCHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x695A700", Offset = "0x6959300", VA = "0x18695A700")]
	private void AOMOMJAFFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6962BF0", Offset = "0x69617F0", VA = "0x186962BF0")]
	private void OLLOGEOBHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x695D790", Offset = "0x695C390", VA = "0x18695D790")]
	public long GMIGJFHMBLF(long EFNEJGKOPOD, int MEIKKIOCIBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6960590", Offset = "0x695F190", VA = "0x186960590")]
	private void NECKJPBMCEN(LMMNEJCMKMI ELKNMNEKABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x695DF80", Offset = "0x695CB80", VA = "0x18695DF80")]
	private void IJJPNCMJJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x695E6C0", Offset = "0x695D2C0", VA = "0x18695E6C0")]
	private void JLGALFOMEHL(LMMNEJCMKMI AIKMKIOPGIF, KILHCAAOJJN FMLFFEJEHMB, int ICOFJLIFAKG, int AMCFJKOMNPH, float NJKJKOKJOCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct EFOGHEKJLLN : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct NJCBPAPEDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int PHDLDANOJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int DMBMEEDAKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int IBKCFLHDDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int FCIMMLPLKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int HNAJNPPEAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int ACBCDAOJFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int OEADCEDODIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int CHPEENDPIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float KOFBAJDAIIA;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct DJDMDDECONA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public FJPEAHHCJNK.GIHBLHKKNGO GIJAINEKGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float FADDJCAGEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float OENELCBOKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float OAJGNHJJOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float CJHMJODPPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float JIPDFFHJJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float PJJPGOKLJPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct EMCLAKCKLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> AKODOEHHDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> PEOFEPJIGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> BALFFAOEHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> GNPDAABBPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> CBMBFDLJKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> OCHIBIHMFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool KKKNPBOJEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int CEBNKMJLOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int PJALGAPEPPB;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6969B40", Offset = "0x6968740", VA = "0x186969B40")]
		public void GCJMNEGAMAM(int CPKKHGLLOGC, int OGGCPDDOCHP, Allocator BLMBIIGOJPG, bool DNNDPOCHOEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69698F0", Offset = "0x69684F0", VA = "0x1869698F0")]
		public static EMCLAKCKLOF EOAPLDPJLOG(LMMNEJCMKMI AIFEMCDFFGN)
		{
			return default(EMCLAKCKLOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6969D20", Offset = "0x6968920", VA = "0x186969D20")]
		public void LNHLHNCBJPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker ALCEPMKFBIN;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker HAGNONKEBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<NJCBPAPEDOM> AFHLLIDNPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private EMCLAKCKLOF BJENKMPGNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private EMCLAKCKLOF ELKNMNEKABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 IFNFLHACCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 MAIJFCLICDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private DJDMDDECONA GCBCHGAFCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* FCGODHGKINO;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	[BurstDiscard]
	private static void PDEPCHCEHNB(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	[BurstDiscard]
	private static void ABLCGNFCFEC(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	[BurstDiscard]
	private static void PDEPCHCEHNB(bool BLMOINJCONF, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6952440", Offset = "0x6951040", VA = "0x186952440")]
	public EFOGHEKJLLN([In] List<OJPDGIKIEPK.POCDHKDGIHO> GPJJGIGLMCL, [In] LMMNEJCMKMI PIGFBIHFIDA, [In] OJPDGIKIEPK PJCNEMBBGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6950AA0", Offset = "0x694F6A0", VA = "0x186950AA0", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6950420", Offset = "0x694F020", VA = "0x186950420")]
	public void CKANFEJJKKJ(List<OJPDGIKIEPK.POCDHKDGIHO> JNFJIDNPFOM, [In] OJPDGIKIEPK PJCNEMBBGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6952380", Offset = "0x6950F80", VA = "0x186952380")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool OIPEACPKGIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69522B0", Offset = "0x6950EB0", VA = "0x1869522B0")]
	private KILHCAAOJJN MHCGPOEIOEE(int EPMLOOGJJLF, Allocator BLMBIIGOJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6950F60", Offset = "0x694FB60", VA = "0x186950F60")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void MGAHCKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6950AF0", Offset = "0x694F6F0", VA = "0x186950AF0")]
	[IgnoreWarning(1371)]
	private NJCBPAPEDOM GAFJJHGPOOG([In] NJCBPAPEDOM GFKLHMKCHEN, int LNEDBGNKGLM, [In] NativeArray<int> IOIEKIBENAB, [In] NativeArray<bool> COHKJGMKPKD, NativeArray<int> GNFJDAIKODF)
	{
		return default(NJCBPAPEDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6950E60", Offset = "0x694FA60", VA = "0x186950E60")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int GPMLGGNINGE(NativeArray<int> IOIEKIBENAB, int FKOFPGLBJPD, int KNMPANLOMGA, int LIPPCJFJBCB)
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
		public static readonly KEDKJKIEEGM log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker NHKJEBCDFGL;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker FKCEMJMMBHG;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker KHCDGPDDKBP;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker LNNJGHCLPCD;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker IGLOCEAMOBN;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker CHAODMMNFKE;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker GOJONONOKJP;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int EPBMAGFHGKO = 65000;

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
		private Dictionary<Material, List<OJPDGIKIEPK>> DLGOAEDMMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<OJPDGIKIEPK> OCCKDPKMADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> HNALJADOIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool MABMMCNGCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool HNFIMMIFLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int OAADLBACFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> AOKOEICKBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> KAJJMBPPFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> KOMAJHIBGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> DKEMEHDIKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private OJPDGIKIEPK JBLLBFFPGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material HOBFHJFKHKE;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int HLBDPMJDBKE = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, DDMJJMAFFKD)> EPDNFENCEIJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> LGEFNENHFKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int PAPKPFBFIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x69698A0", Offset = "0x69684A0", VA = "0x1869698A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		private static void PDEPCHCEHNB(bool BLMOINJCONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		private static void PDEPCHCEHNB(bool BLMOINJCONF, string JIMAFLGJGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6965F90", Offset = "0x6964B90", VA = "0x186965F90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x69647C0", Offset = "0x69633C0", VA = "0x1869647C0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6963FA0", Offset = "0x6962BA0", VA = "0x186963FA0")]
		public OJPDGIKIEPK AddToBatchedMesh(DDMJJMAFFKD OIFKKFNCACM, Material MBCOMNNFJFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x69689B0", Offset = "0x69675B0", VA = "0x1869689B0")]
		public void RemoveFromBatchedMesh(DDMJJMAFFKD AIKMKIOPGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6964690", Offset = "0x6963290", VA = "0x186964690")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6969190", Offset = "0x6967D90", VA = "0x186969190")]
		public void SetMaterialProperty(int INFKGBJLKGB, Color BFOBNFFGJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6968D50", Offset = "0x6967950", VA = "0x186968D50")]
		public void SetMaterialProperty(int INFKGBJLKGB, float GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6968F70", Offset = "0x6967B70", VA = "0x186968F70")]
		public void SetMaterialProperty(int INFKGBJLKGB, Vector4 FDDDOEFBAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6968AF0", Offset = "0x69676F0", VA = "0x186968AF0")]
		public void SetMaterialProperty(int INFKGBJLKGB, Matrix4x4 AGFIHLAPICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69640A0", Offset = "0x6962CA0", VA = "0x1869640A0")]
		private void CIBGEICHPBO(Renderer KKNFDPNGCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6964FB0", Offset = "0x6963BB0", VA = "0x186964FB0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6964FA0", Offset = "0x6963BA0", VA = "0x186964FA0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6965050", Offset = "0x6963C50", VA = "0x186965050")]
		private void GPGMLKGHFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6964980", Offset = "0x6963580", VA = "0x186964980")]
		private OJPDGIKIEPK FEPHAEKJAPC(DDMJJMAFFKD AIKMKIOPGIF, Material MBCOMNNFJFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6966280", Offset = "0x6964E80", VA = "0x186966280")]
		private OJPDGIKIEPK PPCEAILGLED(Material MBCOMNNFJFG, int CIOMEHCPBBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6964BA0", Offset = "0x69637A0", VA = "0x186964BA0")]
		private OJPDGIKIEPK FHBNCEDPHAI(Material MBCOMNNFJFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x18A0340", Offset = "0x189EF40", VA = "0x1818A0340")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6965AB0", Offset = "0x69646B0", VA = "0x186965AB0")]
		public void MarkDirty(DDMJJMAFFKD AIKMKIOPGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6965C10", Offset = "0x6964810", VA = "0x186965C10")]
		public (long, long) MemorySizeInBytesForChosenDetail(float GGJMPJNAPCL)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6967A40", Offset = "0x6966640", VA = "0x186967A40")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6965570", Offset = "0x6964170", VA = "0x186965570")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6966560", Offset = "0x6965160", VA = "0x186966560")]
		public void RebatchOptimally(int EFAACCIPKKD, int NAJLGAEDLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6969630", Offset = "0x6968230", VA = "0x186969630")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class PPGBDEJMEAK
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct DJJLJIABAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float BBABGOPLEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer OHAOFLDHLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public OJPDGIKIEPK JAKIPNEGFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long CFHHLOHDCLD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HCNKHIOMBCN : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x90BF50", Offset = "0x90AB50", VA = "0x18090BF50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x696ABD0", Offset = "0x69697D0", VA = "0x18696ABD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xFC5520", Offset = "0xFC4120", VA = "0x180FC5520")]
		[DebuggerHidden]
		public HCNKHIOMBCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x696AC20", Offset = "0x6969820", VA = "0x18696AC20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6969E80", Offset = "0x6968A80", VA = "0x186969E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6969E30", Offset = "0x6968A30", VA = "0x186969E30")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6969DE0", Offset = "0x69689E0", VA = "0x186969DE0")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x696AB80", Offset = "0x6969780", VA = "0x18696AB80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x696AAD0", Offset = "0x69696D0", VA = "0x18696AAD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x696AAD0", Offset = "0x69696D0", VA = "0x18696AAD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker CHAODMMNFKE;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker GBELADBHDKO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker PNGEFGEBIBL;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker FAPDPFPLKEC;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 LBJDBDFBBOF;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int AHPOKNNGMMI;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int PNOMBGLMFGM;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int OGALFFBIPPN;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int KPAPALOFLLN;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int COCNHNHADHO;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int NKPGECGBAOG;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int LEMCHFFADMP;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int NLEGAOILBMH;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int ENPHEOGGAPL;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int PIMGJFEFHEO;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int ODLOHDNADHL;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int OBHAPFHPLPO;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int HOKNIFFBLEP;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int MHJIBBFBOFD;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long GJNCOGGPAMB;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long EOFOOBDBDFD;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int FFFOOJAHANK;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int EHEKPDACOMI;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int PMAIGBCLKCD;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long AACCLABBCLL;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool CKCDALENHMK;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> KALIHFMJIFO;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<DJJLJIABAGK> AEEBJCCNJDA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool ONMHDAFMGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x696DC20", Offset = "0x696C820", VA = "0x18696DC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void PDEPCHCEHNB(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void ABLCGNFCFEC(bool BLMOINJCONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void PDEPCHCEHNB(bool BLMOINJCONF, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x696DD60", Offset = "0x696C960", VA = "0x18696DD60")]
	public static void JOJMDOFEJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x696E4F0", Offset = "0x696D0F0", VA = "0x18696E4F0")]
	public static void OHPCOHENDFO(BatchedMeshRenderer JBCNBKFPNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x696DCB0", Offset = "0x696C8B0", VA = "0x18696DCB0")]
	public static void IKPNPEOOGMM(BatchedMeshRenderer JBCNBKFPNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x696AD40", Offset = "0x6969940", VA = "0x18696AD40")]
	private static (long, long, long) AHEBIOPBJCM(long JNDHFCEMJKA)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x696B0A0", Offset = "0x6969CA0", VA = "0x18696B0A0")]
	public static void EKAKGPDNJAM(long JNDHFCEMJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x696D780", Offset = "0x696C380", VA = "0x18696D780")]
	public static long GMIGJFHMBLF(long EFNEJGKOPOD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x696E3E0", Offset = "0x696CFE0", VA = "0x18696E3E0")]
	public static void MGEMEAMIPKN(OJPDGIKIEPK JAKIPNEGFKI, BatchedMeshRenderer OHAOFLDHLFG, long CFHHLOHDCLD, float BBABGOPLEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x696DB20", Offset = "0x696C720", VA = "0x18696DB20")]
	public static void HIJHLAENLDO(OJPDGIKIEPK JAKIPNEGFKI, BatchedMeshRenderer OHAOFLDHLFG, long CFHHLOHDCLD, float GDFODBDHOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x696AF90", Offset = "0x6969B90", VA = "0x18696AF90")]
	public static void ANFOFOICCEF(OJPDGIKIEPK JAKIPNEGFKI, BatchedMeshRenderer OHAOFLDHLFG, long CFHHLOHDCLD, float GDFODBDHOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x696E760", Offset = "0x696D360", VA = "0x18696E760")]
	public static void PKFLLKHFEGP(OJPDGIKIEPK JAKIPNEGFKI, BatchedMeshRenderer OHAOFLDHLFG, long CFHHLOHDCLD, float BBABGOPLEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x696DF10", Offset = "0x696CB10", VA = "0x18696DF10")]
	public static float KBALOGHPEKA(long HOHHGCIFDJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x696E990", Offset = "0x696D590", VA = "0x18696E990")]
	public static (long, long) POEGPDNJAPI(float GGJMPJNAPCL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x696E900", Offset = "0x696D500", VA = "0x18696E900")]
	[IteratorStateMachine(typeof(HCNKHIOMBCN))]
	public static IEnumerable<bool> PLCGDAEBBKH(long JBOKHNDELKA, bool LEJPEKDEMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x696E270", Offset = "0x696CE70", VA = "0x18696E270")]
	public static void KGBIAMICBJK(long JBOKHNDELKA, bool LEJPEKDEMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x696AE50", Offset = "0x6969A50", VA = "0x18696AE50")]
	public static int AHGLADLICME()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class BANDHMLBLAB<KeyType> : OJPDGIKIEPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, DDMJJMAFFKD> GJKFOEGFLDE;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4E05DF0", Offset = "0x4E049F0", VA = "0x184E05DF0")]
	public BANDHMLBLAB(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E05BE0", Offset = "0x4E047E0", VA = "0x184E05BE0")]
	public void JBINENPFJDC(KeyType DPHIOKCFMFC, DDMJJMAFFKD INFCDBBIIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E05AF0", Offset = "0x4E046F0", VA = "0x184E05AF0")]
	public bool CFLBHFBHHMB(KeyType DPHIOKCFMFC, DDMJJMAFFKD CEELBJINKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4E05C50", Offset = "0x4E04850", VA = "0x184E05C50")]
	public void OLLFOFJPOGK(KeyType DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E059A0", Offset = "0x4E045A0", VA = "0x184E059A0", Slot = "4")]
	public override void CBKDALFMEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x696EED0", Offset = "0x696DAD0", VA = "0x18696EED0")]
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
