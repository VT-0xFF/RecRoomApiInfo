using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PMKBNOODNEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int HIPAKHOILHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 EHOLCFDOAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion JHGNAHCIIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 MGELKLCFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int JFAIEMENCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LLKBDMEOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NCPHLKJPOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LOJLEIOPNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 OCGCEGOJCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool CEIOAPOIFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public KHNPPILKLFH GBKMDKHOHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 ECKHBFEHCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float JIOKBEDIGHI;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HNGHOKDHCHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static JDCJDOMAEOA KFLGOKMFPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<PMKBNOODNEP> MFELLKNHAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<DIHJGJEKENF> DDDOMCMAEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<MOCOKHCGABF> EHODABHBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<CBFDAHLKPCD> MIBKDMOOMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<DIHJGJEKENF> LOICBOPEDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<IIFBEMFOHGO> AKPEFJDKALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<CBFDAHLKPCD>> LPMOBCACJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<BIBMDPIJAII> FNOCEGDMCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> HIJDHCPEJMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PENGDLNAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC904F0", Offset = "0xC8EEF0", VA = "0x180C904F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC8F4C0", Offset = "0xC8DEC0", VA = "0x180C8F4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CDIBEELIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC90500", Offset = "0xC8EF00", VA = "0x180C90500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC8F0C0", Offset = "0xC8DAC0", VA = "0x180C8F0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63A28E0", Offset = "0x63A12E0", VA = "0x1863A28E0")]
	public HNGHOKDHCHG(int OEAIILDDLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63A2300", Offset = "0x63A0D00", VA = "0x1863A2300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63A2710", Offset = "0x63A1110", VA = "0x1863A2710")]
	public void POEDLPEEEKF(JobHandle KLHLHHDJPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63A0D90", Offset = "0x639F790", VA = "0x1863A0D90")]
	public void AOCIOPHFHHA(PMKBNOODNEP ABDLEBPKDKC, BIBMDPIJAII OMANMOEIOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63A2320", Offset = "0x63A0D20", VA = "0x1863A2320")]
	public void MNPKJCNJEDN(MOCOKHCGABF ABDLEBPKDKC, NativeArray<CBFDAHLKPCD> FHPDGAODOBJ, int NDNMCFIKHGD, int NCJEGPKKOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63A0FB0", Offset = "0x639F9B0", VA = "0x1863A0FB0")]
	public JobHandle BNAEMDOFMAI(DNFKGNJMGDP DFGJPHHFNEN, AIGOIAPDBPE FGJFMLBAFHC, float3 HPGJJOHNOIO, quaternion PCNIPCFGGHE, float CMGLMILGMIC, bool AJEPCMKCELM, int JCHLLAPOJJO = 0, int GCCIPCGEPDA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63A1FC0", Offset = "0x63A09C0", VA = "0x1863A1FC0")]
	public static JobHandle DBHODGBAKLC(COJFGBMIEDO IIFCPAOIOPH, DNFKGNJMGDP DFGJPHHFNEN, PMKBNOODNEP ABDLEBPKDKC, JobHandle KLHLHHDJPHP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63A2460", Offset = "0x63A0E60", VA = "0x1863A2460")]
	public static JobHandle OMNFJNDMGBK(GHIOPBECHMO IIFCPAOIOPH, DNFKGNJMGDP DFGJPHHFNEN, MOCOKHCGABF ABDLEBPKDKC, NativeArray<CBFDAHLKPCD> FHPDGAODOBJ, int NDNMCFIKHGD, int NCJEGPKKOJP, JobHandle KLHLHHDJPHP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class NGNPBFFPEAL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct BHJGCCMJHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half ILADLKNMPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort KBLFCBLBFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte LMKCEKCACFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public unsafe delegate void PGAMMDPGFPC(float3* AEFPKCIDKCK, [In] ushort* MGDKMLPEBFK, int NDNMCFIKHGD, [In] float3 NFINHJKGNDO, [In] float3 MDDGLLNHAGK);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class FCLDMAENAEH
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x639E690", Offset = "0x639D090", VA = "0x18639E690")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x639E7C0", Offset = "0x639D1C0", VA = "0x18639E7C0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x639E5E0", Offset = "0x639CFE0", VA = "0x18639E5E0")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x639E3D0", Offset = "0x639CDD0", VA = "0x18639E3D0")]
		public unsafe static void BCLHLDBBMGO(float3* AEFPKCIDKCK, [In] ushort* MGDKMLPEBFK, int NDNMCFIKHGD, [In] float3 NFINHJKGNDO, [In] float3 MDDGLLNHAGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void GIEHEEEEGNF(ushort* AEFPKCIDKCK, [Out] float3 OIAKAIIMCNG, [Out] float3 MDDGLLNHAGK, [In] float3* MGDKMLPEBFK, int JHKGLOBKGKJ, int PCNHJLHNPGO);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class JJALKFELKBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x63A4E60", Offset = "0x63A3860", VA = "0x1863A4E60")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x63A4F90", Offset = "0x63A3990", VA = "0x1863A4F90")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x63A4DB0", Offset = "0x63A37B0", VA = "0x1863A4DB0")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63A4B90", Offset = "0x63A3590", VA = "0x1863A4B90")]
		public unsafe static void BCLHLDBBMGO(ushort* AEFPKCIDKCK, [Out] float3 OIAKAIIMCNG, [Out] float3 MDDGLLNHAGK, [In] float3* MGDKMLPEBFK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public unsafe delegate void ONNIENECEMG(ushort* AIDGLNENIJG, [In] float3* CMDLMNNAGPI, int PCNHJLHNPGO);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class MKONKGADAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63AF800", Offset = "0x63AE200", VA = "0x1863AF800")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63AF930", Offset = "0x63AE330", VA = "0x1863AF930")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63AF750", Offset = "0x63AE150", VA = "0x1863AF750")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63AF560", Offset = "0x63ADF60", VA = "0x1863AF560")]
		public unsafe static void BCLHLDBBMGO(ushort* AIDGLNENIJG, [In] float3* CMDLMNNAGPI, int PCNHJLHNPGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public unsafe delegate void BGEBBDGHFEO(float3* DFOPPAEDFND, [In] ushort* CMDLMNNAGPI, int NDNMCFIKHGD);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class IELEGCBOINB
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63A41E0", Offset = "0x63A2BE0", VA = "0x1863A41E0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63A4310", Offset = "0x63A2D10", VA = "0x1863A4310")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x63A4130", Offset = "0x63A2B30", VA = "0x1863A4130")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63A3EE0", Offset = "0x63A28E0", VA = "0x1863A3EE0")]
		public unsafe static void BCLHLDBBMGO(float3* DFOPPAEDFND, [In] ushort* CMDLMNNAGPI, int NDNMCFIKHGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public unsafe delegate void KANCFILCNHH(ushort* PBEHKEKJDAA, [Out] float2 IPPGCBBDIGF, [Out] float2 BNKHEPPCCMN, [In] float2* MIAKKNDBFCD, int JHKGLOBKGKJ, int PCNHJLHNPGO);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class PINMKLGPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63B4F10", Offset = "0x63B3910", VA = "0x1863B4F10")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5040", Offset = "0x63B3A40", VA = "0x1863B5040")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63B4E60", Offset = "0x63B3860", VA = "0x1863B4E60")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63B4C40", Offset = "0x63B3640", VA = "0x1863B4C40")]
		public unsafe static void BCLHLDBBMGO(ushort* PBEHKEKJDAA, [Out] float2 IPPGCBBDIGF, [Out] float2 BNKHEPPCCMN, [In] float2* MIAKKNDBFCD, int JHKGLOBKGKJ, int PCNHJLHNPGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void CABAANMFHHC([Out] float2 DPAFIMGCIFG, ushort JCDKCHBIOFL, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class HGJPKCEFANP
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63A0640", Offset = "0x639F040", VA = "0x1863A0640")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63A0770", Offset = "0x639F170", VA = "0x1863A0770")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63A0590", Offset = "0x639EF90", VA = "0x1863A0590")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63A0350", Offset = "0x639ED50", VA = "0x1863A0350")]
		public static void BCLHLDBBMGO([Out] float2 DPAFIMGCIFG, ushort JCDKCHBIOFL, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public unsafe delegate void PPKCGGKIEOJ(float2* PBEHKEKJDAA, ushort* MIAKKNDBFCD, int NDNMCFIKHGD, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class CIGHNJFODIB
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x639A4B0", Offset = "0x6398EB0", VA = "0x18639A4B0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x639A5E0", Offset = "0x6398FE0", VA = "0x18639A5E0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x639A400", Offset = "0x6398E00", VA = "0x18639A400")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x639A170", Offset = "0x6398B70", VA = "0x18639A170")]
		public unsafe static void BCLHLDBBMGO(float2* PBEHKEKJDAA, ushort* MIAKKNDBFCD, int NDNMCFIKHGD, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public unsafe delegate void CGBEACMCJFC(ushort* PMEEIDANJAD, [In] float4* MFLGGGLGKID, int JHKGLOBKGKJ, int PCNHJLHNPGO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class LECKKBJCAHL
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63ACFB0", Offset = "0x63AB9B0", VA = "0x1863ACFB0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63AD0E0", Offset = "0x63ABAE0", VA = "0x1863AD0E0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63ACF00", Offset = "0x63AB900", VA = "0x1863ACF00")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63ACCB0", Offset = "0x63AB6B0", VA = "0x1863ACCB0")]
		public unsafe static void BCLHLDBBMGO(ushort* PMEEIDANJAD, [In] float4* MFLGGGLGKID, int JHKGLOBKGKJ, int PCNHJLHNPGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate ushort ADMKEONLJLG([In] float4 KDPDBABEFOO);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class KAAICCANMOH
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63A53B0", Offset = "0x63A3DB0", VA = "0x1863A53B0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63A54E0", Offset = "0x63A3EE0", VA = "0x1863A54E0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63A5300", Offset = "0x63A3D00", VA = "0x1863A5300")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63A50F0", Offset = "0x63A3AF0", VA = "0x1863A50F0")]
		public static ushort BCLHLDBBMGO([In] float4 KDPDBABEFOO)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public unsafe delegate void JPBJJFKMFFB(float4* PMEEIDANJAD, [In] ushort* AEMIDKBFIBC, int NDNMCFIKHGD);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal static class FCPNHJENEGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x639EC20", Offset = "0x639D620", VA = "0x18639EC20")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x639ED50", Offset = "0x639D750", VA = "0x18639ED50")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x639EB70", Offset = "0x639D570", VA = "0x18639EB70")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x639E920", Offset = "0x639D320", VA = "0x18639E920")]
		public unsafe static void BCLHLDBBMGO(float4* PMEEIDANJAD, [In] ushort* AEMIDKBFIBC, int NDNMCFIKHGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void MDPHCFEHDEB([Out] float4 LKBGEIGOHEF, ushort JCDKCHBIOFL);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal static class PNIKNACJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63B54D0", Offset = "0x63B3ED0", VA = "0x1863B54D0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5600", Offset = "0x63B4000", VA = "0x1863B5600")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5420", Offset = "0x63B3E20", VA = "0x1863B5420")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x63B51A0", Offset = "0x63B3BA0", VA = "0x1863B51A0")]
		public static void BCLHLDBBMGO([Out] float4 LKBGEIGOHEF, ushort JCDKCHBIOFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public unsafe delegate void DFCBELJFALI(float4* GHEFENGEFPA, byte* LBNPHBBKEAG, [Out] int LKJAFIKHAIA, [Out] int BKCACPMJNGL, float4* IPFFJIIKJMK, int JHKGLOBKGKJ, int PCNHJLHNPGO);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class KJOADEILGFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x63AC8D0", Offset = "0x63AB2D0", VA = "0x1863AC8D0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x63ACA00", Offset = "0x63AB400", VA = "0x1863ACA00")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x63AC820", Offset = "0x63AB220", VA = "0x1863AC820")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63AC600", Offset = "0x63AB000", VA = "0x1863AC600")]
		public unsafe static void BCLHLDBBMGO(float4* GHEFENGEFPA, byte* LBNPHBBKEAG, [Out] int LKJAFIKHAIA, [Out] int BKCACPMJNGL, float4* IPFFJIIKJMK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public unsafe delegate void JCBJIGKIEFK(float4* KHNGFHEHJFP, [In] BHJGCCMJHID* LLCJGKFFGHN, [In] byte* POHGBOICFKJ, int NDNMCFIKHGD);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class CHDAJOEADAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6399EE0", Offset = "0x63988E0", VA = "0x186399EE0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x639A010", Offset = "0x6398A10", VA = "0x18639A010")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6399E30", Offset = "0x6398830", VA = "0x186399E30")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6399B50", Offset = "0x6398550", VA = "0x186399B50")]
		public unsafe static void BCLHLDBBMGO(float4* KHNGFHEHJFP, [In] BHJGCCMJHID* LLCJGKFFGHN, [In] byte* POHGBOICFKJ, int NDNMCFIKHGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public unsafe delegate int AHDEDCMMIJC(byte* MGAJHGDICGM, [In] int* KKMFCCIDEDP, int GDAHEFPPFPO);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class CGDKBBHDFEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x63998C0", Offset = "0x63982C0", VA = "0x1863998C0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x63999F0", Offset = "0x63983F0", VA = "0x1863999F0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6399810", Offset = "0x6398210", VA = "0x186399810")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6399590", Offset = "0x6397F90", VA = "0x186399590")]
		public unsafe static int BCLHLDBBMGO(byte* MGAJHGDICGM, [In] int* KKMFCCIDEDP, int GDAHEFPPFPO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public unsafe delegate void JBHCLEJFHGO(int* CCHKDKINEDA, [In] byte* KGAHEPIIDAJ, int NCJEGPKKOJP);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class FOHLNJBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x639F840", Offset = "0x639E240", VA = "0x18639F840")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x639F970", Offset = "0x639E370", VA = "0x18639F970")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x639F790", Offset = "0x639E190", VA = "0x18639F790")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x639F550", Offset = "0x639DF50", VA = "0x18639F550")]
		public unsafe static void BCLHLDBBMGO(int* CCHKDKINEDA, [In] byte* KGAHEPIIDAJ, int NCJEGPKKOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void ODABECGKKDO([Out] float3 DPAFIMGCIFG, ushort JCDKCHBIOFL);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class FNPOAHIPMCB
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x639F2C0", Offset = "0x639DCC0", VA = "0x18639F2C0")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x639F3F0", Offset = "0x639DDF0", VA = "0x18639F3F0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x639F210", Offset = "0x639DC10", VA = "0x18639F210")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x639EEB0", Offset = "0x639D8B0", VA = "0x18639EEB0")]
		public static void BCLHLDBBMGO([Out] float3 DPAFIMGCIFG, ushort JCDKCHBIOFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate ushort DNHENOHIBNN([In] float3 KDPDBABEFOO);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class BEGKOMLBFFA
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr OHIOICFPGDM;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr BPDLFOJKFKM;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6398580", Offset = "0x6396F80", VA = "0x186398580")]
		[BurstDiscard]
		private static void HEFJEOJGEOC(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x63986B0", Offset = "0x63970B0", VA = "0x1863986B0")]
		private static IntPtr PDHAHOAOBCJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x63984D0", Offset = "0x6396ED0", VA = "0x1863984D0")]
		public static void EPPIEPFMEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6398300", Offset = "0x6396D00", VA = "0x186398300")]
		public static ushort BCLHLDBBMGO([In] float3 KDPDBABEFOO)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int NDNMCFIKHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int NCJEGPKKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> DPNCIKONKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> GAPFMLEFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> KNFFNHCMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> JALCNOBOBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BHJGCCMJHID> MOFMKEAHBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> JCLIGDJOILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> PPMAFAFGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 NFINHJKGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 MDDGLLNHAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 AGHJLPAGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 BNKHEPPCCMN;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long BCFDPLGKLND;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long EOLAAAAAJJD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float LKHAKDFGPPC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool BIJOPIJAILG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AELHAHFENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63AFF20", Offset = "0x63AE920", VA = "0x1863AFF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63B3250", Offset = "0x63B1C50", VA = "0x1863B3250")]
	public void POEDLPEEEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63B0B60", Offset = "0x63AF560", VA = "0x1863B0B60")]
	public static NGNPBFFPEAL HGOBECNKDLP(Allocator IMPJLMNPHBC, DNFKGNJMGDP JOMMKDFMOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63B0DA0", Offset = "0x63AF7A0", VA = "0x1863B0DA0")]
	public static NGNPBFFPEAL HGOBECNKDLP(Allocator IMPJLMNPHBC, NativeArray<float3> MGDKMLPEBFK, NativeArray<float3> CMDLMNNAGPI, NativeArray<float2> MIAKKNDBFCD, NativeArray<float4> IPFFJIIKJMK, bool JOLNGFPHJFG, NativeArray<float4> AEMIDKBFIBC, NativeArray<int> KKMFCCIDEDP, int NDNMCFIKHGD, int BJOCNIBPFKP, int NCJEGPKKOJP, int JHKGLOBKGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63B1270", Offset = "0x63AFC70", VA = "0x1863B1270")]
	public DNFKGNJMGDP HIEJJEAKLNL(Allocator IMPJLMNPHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63AFF60", Offset = "0x63AE960", VA = "0x1863AFF60")]
	public void DBKHOBMEEME(Mesh LPABBIBOFCJ, bool BJFIDECNEBE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63B2800", Offset = "0x63B1200", VA = "0x1863B2800")]
	public long MGJLFGGAGOJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63AFCC0", Offset = "0x63AE6C0", VA = "0x1863AFCC0")]
	public static long BDAIMJFHCNH(int MDMBKMEHONL, int GAKAFIDGIDD, bool MJJAGEDDPIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63AFD10", Offset = "0x63AE710", VA = "0x1863AFD10")]
	public long BDAIMJFHCNH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63B3140", Offset = "0x63B1B40", VA = "0x1863B3140")]
	private void PKKLPDGEOAD(int LFMNHCKBJME, int PCNHJLHNPGO, Allocator IMPJLMNPHBC, bool OPBAAKOKOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB40", Offset = "0x63AE540", VA = "0x1863AFB40")]
	private void AJKKIAPFGMF(NativeArray<float3> AEFPKCIDKCK, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63AFC40", Offset = "0x63AE640", VA = "0x1863AFC40")]
	[BurstCompile]
	private unsafe static void AJKKIAPFGMF(float3* AEFPKCIDKCK, [In] ushort* MGDKMLPEBFK, int NDNMCFIKHGD, [In] float3 NFINHJKGNDO, [In] float3 MDDGLLNHAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63B26B0", Offset = "0x63B10B0", VA = "0x1863B26B0")]
	private void LAKLIEFLADN(NativeArray<float3> MGDKMLPEBFK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63B2620", Offset = "0x63B1020", VA = "0x1863B2620")]
	[BurstCompile]
	private unsafe static void LAKLIEFLADN(ushort* AEFPKCIDKCK, [Out] float3 OIAKAIIMCNG, [Out] float3 MDDGLLNHAGK, [In] float3* MGDKMLPEBFK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63B1C50", Offset = "0x63B0650", VA = "0x1863B1C50")]
	private void JDGHCFFMDGC(NativeArray<float3> CMDLMNNAGPI, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63B1A30", Offset = "0x63B0430", VA = "0x1863B1A30")]
	[BurstCompile]
	private unsafe static void JDGHCFFMDGC(ushort* AIDGLNENIJG, [In] float3* CMDLMNNAGPI, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63B0370", Offset = "0x63AED70", VA = "0x1863B0370")]
	private void DNMBCDOCGGC(NativeArray<float3> DFOPPAEDFND, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63B0300", Offset = "0x63AED00", VA = "0x1863B0300")]
	[BurstCompile]
	private unsafe static void DNMBCDOCGGC(float3* DFOPPAEDFND, [In] ushort* CMDLMNNAGPI, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63B2B30", Offset = "0x63B1530", VA = "0x1863B2B30")]
	private void OEPOJLLBILF(NativeArray<float2> MIAKKNDBFCD, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63B2C00", Offset = "0x63B1600", VA = "0x1863B2C00")]
	[BurstCompile]
	private unsafe static void OEPOJLLBILF(ushort* PBEHKEKJDAA, [Out] float2 IPPGCBBDIGF, [Out] float2 BNKHEPPCCMN, [In] float2* MIAKKNDBFCD, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63B04E0", Offset = "0x63AEEE0", VA = "0x1863B04E0")]
	[BurstCompile]
	private static void EEPFDDEBKPA([Out] float2 DPAFIMGCIFG, ushort JCDKCHBIOFL, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63B0040", Offset = "0x63AEA40", VA = "0x1863B0040")]
	private void DLBDDFECCAP(NativeArray<float2> PBEHKEKJDAA, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63B0140", Offset = "0x63AEB40", VA = "0x1863B0140")]
	[BurstCompile]
	private unsafe static void DLBDDFECCAP(float2* PBEHKEKJDAA, ushort* MIAKKNDBFCD, int NDNMCFIKHGD, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63B0830", Offset = "0x63AF230", VA = "0x1863B0830")]
	private void GFLLBAJJLPM(NativeArray<float4> AEMIDKBFIBC, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63B0920", Offset = "0x63AF320", VA = "0x1863B0920")]
	[BurstCompile]
	private unsafe static void GFLLBAJJLPM(ushort* PMEEIDANJAD, [In] float4* MFLGGGLGKID, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63AFA90", Offset = "0x63AE490", VA = "0x1863AFA90")]
	[BurstCompile]
	private static ushort AEHIEIFGJPL([In] float4 KDPDBABEFOO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63B29F0", Offset = "0x63B13F0", VA = "0x1863B29F0")]
	private void ODGCAEJNFDK(NativeArray<float4> PMEEIDANJAD, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63B2AC0", Offset = "0x63B14C0", VA = "0x1863B2AC0")]
	[BurstCompile]
	private unsafe static void ODGCAEJNFDK(float4* PMEEIDANJAD, [In] ushort* AEMIDKBFIBC, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63B2990", Offset = "0x63B1390", VA = "0x1863B2990")]
	[BurstCompile]
	private static void NOMDDHDHPBC([Out] float4 LKBGEIGOHEF, ushort JCDKCHBIOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63B2240", Offset = "0x63B0C40", VA = "0x1863B2240")]
	private void KOPAAKCMANI(Allocator IMPJLMNPHBC, NativeArray<float4> IPFFJIIKJMK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63B1FF0", Offset = "0x63B09F0", VA = "0x1863B1FF0")]
	[BurstCompile]
	private unsafe static void KOPAAKCMANI(float4* GHEFENGEFPA, byte* LBNPHBBKEAG, [Out] int LKJAFIKHAIA, [Out] int BKCACPMJNGL, float4* IPFFJIIKJMK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63B05E0", Offset = "0x63AEFE0", VA = "0x1863B05E0")]
	private static void EGJBKCOKJKF(NativeArray<float4> KHNGFHEHJFP, NativeArray<BHJGCCMJHID> LLCJGKFFGHN, NativeArray<byte> POHGBOICFKJ, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63B0560", Offset = "0x63AEF60", VA = "0x1863B0560")]
	[BurstCompile]
	private unsafe static void EGJBKCOKJKF(float4* KHNGFHEHJFP, [In] BHJGCCMJHID* LLCJGKFFGHN, [In] byte* POHGBOICFKJ, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63B3060", Offset = "0x63B1A60", VA = "0x1863B3060")]
	private void PEOBJDMOPHK(Allocator IMPJLMNPHBC, NativeArray<int> KKMFCCIDEDP, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63B1D10", Offset = "0x63B0710", VA = "0x1863B1D10")]
	private static NativeArray<byte> JNGDBIJGIBG(Allocator IMPJLMNPHBC, NativeArray<int> KKMFCCIDEDP, int GDAHEFPPFPO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63B1F80", Offset = "0x63B0980", VA = "0x1863B1F80")]
	[BurstCompile]
	private unsafe static int JNGDBIJGIBG(byte* MGAJHGDICGM, [In] int* KKMFCCIDEDP, int GDAHEFPPFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63B01C0", Offset = "0x63AEBC0", VA = "0x1863B01C0")]
	private static void DNHENIHBEPE(NativeArray<int> CCHKDKINEDA, NativeArray<byte> KGAHEPIIDAJ, int NCJEGPKKOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63B0290", Offset = "0x63AEC90", VA = "0x1863B0290")]
	[BurstCompile]
	private unsafe static void DNHENIHBEPE(int* CCHKDKINEDA, [In] byte* KGAHEPIIDAJ, int NCJEGPKKOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x63B2930", Offset = "0x63B1330", VA = "0x1863B2930")]
	[BurstCompile]
	private static void MIHICCAJBOF([Out] float3 DPAFIMGCIFG, ushort JCDKCHBIOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x63B2E50", Offset = "0x63B1850", VA = "0x1863B2E50")]
	[BurstCompile]
	private static ushort PAIIHMFHAPG([In] float3 KDPDBABEFOO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public NGNPBFFPEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63974A0", Offset = "0x6395EA0", VA = "0x1863974A0")]
	[BurstCompile]
	public unsafe static void LDFJLCFMDIF(float3* AEFPKCIDKCK, [In] ushort* MGDKMLPEBFK, int NDNMCFIKHGD, [In] float3 NFINHJKGNDO, [In] float3 MDDGLLNHAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63970C0", Offset = "0x6395AC0", VA = "0x1863970C0")]
	[BurstCompile]
	public unsafe static void AEGKHNLFIKP(ushort* AEFPKCIDKCK, [Out] float3 OIAKAIIMCNG, [Out] float3 MDDGLLNHAGK, [In] float3* MGDKMLPEBFK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6397D30", Offset = "0x6396730", VA = "0x186397D30")]
	[BurstCompile]
	public unsafe static void PHHKECHEHNH(ushort* AIDGLNENIJG, [In] float3* CMDLMNNAGPI, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63B0440", Offset = "0x63AEE40", VA = "0x1863B0440")]
	[BurstCompile]
	public unsafe static void EDKDJGKIMAE(float3* DFOPPAEDFND, [In] ushort* CMDLMNNAGPI, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63976F0", Offset = "0x63960F0", VA = "0x1863976F0")]
	[BurstCompile]
	public unsafe static void LGHILBFLLMC(ushort* PBEHKEKJDAA, [Out] float2 IPPGCBBDIGF, [Out] float2 BNKHEPPCCMN, [In] float2* MIAKKNDBFCD, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63B27B0", Offset = "0x63B11B0", VA = "0x1863B27B0")]
	[BurstCompile]
	public static void MACHPHNIBCI([Out] float2 DPAFIMGCIFG, ushort JCDKCHBIOFL, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63AFDA0", Offset = "0x63AE7A0", VA = "0x1863AFDA0")]
	[BurstCompile]
	public unsafe static void BKLEPFKFFBK(float2* PBEHKEKJDAA, ushort* MIAKKNDBFCD, int NDNMCFIKHGD, [In] float2 AGHJLPAGGBC, [In] float2 BNKHEPPCCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63B1850", Offset = "0x63B0250", VA = "0x1863B1850")]
	[BurstCompile]
	public unsafe static void HNGLMMCMHCJ(ushort* PMEEIDANJAD, [In] float4* MFLGGGLGKID, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63AFAE0", Offset = "0x63AE4E0", VA = "0x1863AFAE0")]
	[BurstCompile]
	public static ushort AJKALOEHKGL([In] float4 KDPDBABEFOO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63AFE80", Offset = "0x63AE880", VA = "0x1863AFE80")]
	[BurstCompile]
	public unsafe static void CCHELIPNGAI(float4* PMEEIDANJAD, [In] ushort* AEMIDKBFIBC, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63B0AA0", Offset = "0x63AF4A0", VA = "0x1863B0AA0")]
	[BurstCompile]
	public static void GPIDEMHBDBN([Out] float4 LKBGEIGOHEF, ushort JCDKCHBIOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63979B0", Offset = "0x63963B0", VA = "0x1863979B0")]
	[BurstCompile]
	public unsafe static void MAFLEALBJDL(float4* GHEFENGEFPA, byte* LBNPHBBKEAG, [Out] int LKJAFIKHAIA, [Out] int BKCACPMJNGL, float4* IPFFJIIKJMK, int JHKGLOBKGKJ, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63B06F0", Offset = "0x63AF0F0", VA = "0x1863B06F0")]
	[BurstCompile]
	public unsafe static void FOPLCBGDBAF(float4* KHNGFHEHJFP, [In] BHJGCCMJHID* LLCJGKFFGHN, [In] byte* POHGBOICFKJ, int NDNMCFIKHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x63B09A0", Offset = "0x63AF3A0", VA = "0x1863B09A0")]
	[BurstCompile]
	public unsafe static int GIFMPNPBIAM(byte* MGAJHGDICGM, [In] int* KKMFCCIDEDP, int GDAHEFPPFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x63B2890", Offset = "0x63B1290", VA = "0x1863B2890")]
	[BurstCompile]
	public unsafe static void MHKNIECGIJO(int* CCHKDKINEDA, [In] byte* KGAHEPIIDAJ, int NCJEGPKKOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x63B18F0", Offset = "0x63B02F0", VA = "0x1863B18F0")]
	[BurstCompile]
	public static void JBDBPMFJPPJ([Out] float3 DPAFIMGCIFG, ushort JCDKCHBIOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6397B70", Offset = "0x6396570", VA = "0x186397B70")]
	[BurstCompile]
	public static ushort PHAPINHAMGE([In] float3 KDPDBABEFOO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DJLNLPALFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float2 NLEOKFMGCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float2 ACHFGAEIKEO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DIKNFEPGCKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<DJLNLPALFOL> OGJKJLOHJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<int> DKEIAFEJKKD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PENGDLNAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CDIBEELIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C87B0", Offset = "0x7C71B0", VA = "0x1807C87B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x639CF50", Offset = "0x639B950", VA = "0x18639CF50")]
	public DIKNFEPGCKK(int LFMNHCKBJME, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x639CE10", Offset = "0x639B810", VA = "0x18639CE10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x639CE70", Offset = "0x639B870", VA = "0x18639CE70")]
	public void NJHPDJGABOH(DIKNFEPGCKK JGHKAFLDDLC, int BKMCNGGILPM, int ALMDOMLFINK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LJHGINGPHIC
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static DIKNFEPGCKK NIGDPNLOCDB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static NativeList<DIHJGJEKENF> CAMADOKEPIF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static int[] FPMHPIBPGNL;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static bool ABDMNDJIDMD;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, DIKNFEPGCKK> DLNJJDLHNAD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, DIKNFEPGCKK> DFBOAFFHOIL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool DOPKLDEGCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x63AD3D0", Offset = "0x63ABDD0", VA = "0x1863AD3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<DIHJGJEKENF> AJHKBNELNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x63AD330", Offset = "0x63ABD30", VA = "0x1863AD330")]
		get
		{
			return default(NativeList<DIHJGJEKENF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static DIKNFEPGCKK DOIKMMPDBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x63ADE00", Offset = "0x63AC800", VA = "0x1863ADE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63AD740", Offset = "0x63AC140", VA = "0x1863AD740")]
	private static void IGOEBBCFFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x63ADFD0", Offset = "0x63AC9D0", VA = "0x1863ADFD0")]
	public static int NGBHPFNMMEM(bool KPCCIDEICGP, int JAGDIDHLHDC, bool FNAONAGMBOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x63ADD50", Offset = "0x63AC750", VA = "0x1863ADD50")]
	private static int IIBAPJEBIIC(int JAGDIDHLHDC, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x63AD450", Offset = "0x63ABE50", VA = "0x1863AD450")]
	private static int BNHDKIKADAE(int JAGDIDHLHDC, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x63ADEB0", Offset = "0x63AC8B0", VA = "0x1863ADEB0")]
	public static int LJJMFMLOFJH(int NLNFAEHMBKG, int JAGDIDHLHDC, int GLLGGBEGGAN, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x63ADF40", Offset = "0x63AC940", VA = "0x1863ADF40")]
	public static int MGIIDKMJLIC(int NLNFAEHMBKG, int JAGDIDHLHDC, int GLLGGBEGGAN, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x63ADEA0", Offset = "0x63AC8A0", VA = "0x1863ADEA0")]
	public static int LJAKJMJHJOC(int GLLGGBEGGAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x63AD710", Offset = "0x63AC110", VA = "0x1863AD710")]
	private static int GFMJAONCLHO(int JAGDIDHLHDC, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x63AD460", Offset = "0x63ABE60", VA = "0x1863AD460")]
	private static int DGFICGENCIP(int JAGDIDHLHDC, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x63AE750", Offset = "0x63AD150", VA = "0x1863AE750")]
	public static int OIGKJNLDCFM(int NLNFAEHMBKG, int JAGDIDHLHDC, int GLLGGBEGGAN, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x63ADD70", Offset = "0x63AC770", VA = "0x1863ADD70")]
	public static int KHLKDABFFEK(int NLNFAEHMBKG, int JAGDIDHLHDC, int GLLGGBEGGAN, bool FPIFEMILILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x63AD720", Offset = "0x63AC120", VA = "0x1863AD720")]
	public static int IBPKPEIJIIK(int GLLGGBEGGAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x63AE7C0", Offset = "0x63AD1C0", VA = "0x1863AE7C0")]
	public static DIKNFEPGCKK PDMJHLJGMKP(int JAGDIDHLHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x63AD480", Offset = "0x63ABE80", VA = "0x1863AD480")]
	private static DIKNFEPGCKK GANOBLEBJEC(int JAGDIDHLHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x63AD240", Offset = "0x63ABC40", VA = "0x1863AD240")]
	public static DIKNFEPGCKK AEPEDGMPKCH(int JAGDIDHLHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x63AE410", Offset = "0x63ACE10", VA = "0x1863AE410")]
	private static DIKNFEPGCKK NJMHFHIAFCK(int JAGDIDHLHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x63AE000", Offset = "0x63ACA00", VA = "0x1863AE000")]
	public static void NHFMBKBOCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MOCOKHCGABF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int NHAADOLBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 EHOLCFDOAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion JHGNAHCIIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float MGELKLCFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float ACJDOEPCBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int JFAIEMENCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int LLKBDMEOKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int NCPHLKJPOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool GOIEIPLNMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool LBJPCFEDOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float LOJLEIOPNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 OCGCEGOJCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool GGNJGHGGFJH;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct IIFBEMFOHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int KJEKHHJJODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int IBGBKBAJMCJ;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct GHIOPBECHMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeList<MOCOKHCGABF> AKEPHMCGLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public NativeArray<CBFDAHLKPCD> DIIFAPNKOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<DIHJGJEKENF> OCMMGKIGFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<IIFBEMFOHGO> HIFGGELFMLK;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x63A0120", Offset = "0x639EB20", VA = "0x1863A0120")]
	public GHIOPBECHMO(NativeArray<CBFDAHLKPCD> DIIFAPNKOEM, int CBAOPDHODHO = 1, Allocator IMPJLMNPHBC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x63A0030", Offset = "0x639EA30", VA = "0x1863A0030", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
public struct CNEHJCAJPMC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[ReadOnly]
	private NativeArray<DJLNLPALFOL> HIFFFJOINOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[ReadOnly]
	private NativeArray<int> ILGDBFJCIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[ReadOnly]
	private NativeList<DIHJGJEKENF> DCPDAKLOBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<MOCOKHCGABF> AKEPHMCGLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeArray<CBFDAHLKPCD> DIIFAPNKOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeArray<DIHJGJEKENF> OCMMGKIGFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	public NativeArray<IIFBEMFOHGO> HIFGGELFMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private int HCIFJMEPGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int PCIBDPBABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private float3 MOAHMDICDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private quaternion AFDPNFDKDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float3 FFINPGGGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HLOIAMKHNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BPELGOLPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FNOGEBGHJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FGBOOJJPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BOEGJKCEOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> AHEOJCOIEDH;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x639C6C0", Offset = "0x639B0C0", VA = "0x18639C6C0")]
	public CNEHJCAJPMC(HNGHOKDHCHG JHMLCGHDONN, DNFKGNJMGDP IOHMHOHOHNJ, float3 DCBMPACEJDB, quaternion PJGOPLLJGLA, float OMIJMKCLOAM, int JCHLLAPOJJO = 0, int GCCIPCGEPDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x639C950", Offset = "0x639B350", VA = "0x18639C950")]
	public CNEHJCAJPMC(GHIOPBECHMO JHMLCGHDONN, DNFKGNJMGDP IOHMHOHOHNJ, float3 DCBMPACEJDB, quaternion PJGOPLLJGLA, float3 OMIJMKCLOAM, int JCHLLAPOJJO = 0, int GCCIPCGEPDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x639A740", Offset = "0x6399140", VA = "0x18639A740")]
	private float3 BKAMJHDHOCJ(float3 INCDLAEOBGN, Matrix4x4 JOKAEOBHEFC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x639C4C0", Offset = "0x639AEC0", VA = "0x18639C4C0")]
	private float3x3 JLHHIIGKOAG(float3x3 OOEKBHCIFBJ, float3x3 BIENLEEMAAN)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x639C6B0", Offset = "0x639B0B0", VA = "0x18639C6B0")]
	private float PCNBNNAAKNG(float LFNFJOFKAIK, float MMDEGGGBBIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x639A870", Offset = "0x6399270", VA = "0x18639A870", Slot = "4")]
	public void Execute(int OGNEKOOOPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x639C540", Offset = "0x639AF40", VA = "0x18639C540")]
	private void NEGHBAAEADP(int CEJOFEBNBLH, float3 DGOJEOCFHHN, float3 AMMBIDJOPFP, float3 FDDEPLNPPCK, float JMJINJAJLIO, bool FLDMIINMIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x639C060", Offset = "0x639AA60", VA = "0x18639C060")]
	private void IPIHGOEGOLB(MOCOKHCGABF DCKDGEIAEEO, float3 BNPKKMNBEBA, float3x3 CMIACCILPCG, float LFNFJOFKAIK, int BGJCNEJBMHG, int HCNJNONMNCC, int EFFAHACCJME, float KNNDGNLBAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x639BA10", Offset = "0x639A410", VA = "0x18639BA10")]
	private void HGOOFKIEJEJ(int CEJOFEBNBLH, int GKEOFPOJMFM, MOCOKHCGABF DCKDGEIAEEO, float3 BNPKKMNBEBA, float3x3 CMIACCILPCG, bool CEMCONNPLCB, float LFNFJOFKAIK, int DLPAFOPLBHD, int FPFGFLHIGNL, int EFFAHACCJME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct COJFGBMIEDO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeList<PMKBNOODNEP> BHIMEODDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeList<DIHJGJEKENF> KKBHCIBNFMD;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x639CC20", Offset = "0x639B620", VA = "0x18639CC20")]
	public COJFGBMIEDO(int CBAOPDHODHO, Allocator IMPJLMNPHBC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x639CB80", Offset = "0x639B580", VA = "0x18639CB80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
public struct NMNGJBLMCII : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private enum EHNCNCKFPBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[ReadOnly]
	private NativeList<float3> PDGHBIIMPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ReadOnly]
	private NativeArray<float3> NPHCDCCMDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[ReadOnly]
	private NativeList<int> OAGCGLPCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeArray<int> ENIOCAAEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeArray<float4> EJOOOHEKELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeArray<float4> IKEMNAKFNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<float4> HBCFKPDBOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<float3> KCCPCNDIIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private NativeList<DIHJGJEKENF> CAKOHFHEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private NativeList<PMKBNOODNEP> BHIMEODDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private NativeList<DIHJGJEKENF> KKBHCIBNFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private int HCIFJMEPGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private int PCIBDPBABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HLOIAMKHNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BPELGOLPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FNOGEBGHJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FGBOOJJPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BOEGJKCEOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> AHEOJCOIEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private float3 FFINPGGGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private quaternion AFDPNFDKDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 MOAHMDICDNF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x63B4760", Offset = "0x63B3160", VA = "0x1863B4760")]
	public NMNGJBLMCII(HNGHOKDHCHG JHMLCGHDONN, DNFKGNJMGDP IOHMHOHOHNJ, float3 DCBMPACEJDB, quaternion PJGOPLLJGLA, float OMIJMKCLOAM, int JCHLLAPOJJO = 0, int GCCIPCGEPDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x63B4950", Offset = "0x63B3350", VA = "0x1863B4950")]
	public NMNGJBLMCII(COJFGBMIEDO ABDLEBPKDKC, DNFKGNJMGDP IOHMHOHOHNJ, float3 DCBMPACEJDB, quaternion PJGOPLLJGLA, float3 OMIJMKCLOAM, int JCHLLAPOJJO = 0, int GCCIPCGEPDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x63B33C0", Offset = "0x63B1DC0", VA = "0x1863B33C0", Slot = "4")]
	public void Execute(int OGNEKOOOPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x63B43B0", Offset = "0x63B2DB0", VA = "0x1863B43B0")]
	private void IKOKJIDMNEI(float4x4 DPMDGFHGJDJ, int OGNEKOOOPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x63B3350", Offset = "0x63B1D50", VA = "0x1863B3350")]
	private EHNCNCKFPBG BIHHPJDPFNM(float3 AMMBIDJOPFP)
	{
		return default(EHNCNCKFPBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x63B4360", Offset = "0x63B2D60", VA = "0x1863B4360")]
	private float4 IHBAKOLKCLO(EHNCNCKFPBG NOHEPBEDAAI, int ABBNIPHGMGH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x63B4320", Offset = "0x63B2D20", VA = "0x1863B4320")]
	private float2 FBDBOJLOECK(EHNCNCKFPBG NOHEPBEDAAI, float3 DGOJEOCFHHN)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct BIBMDPIJAII
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum PFKCBGMNHLF
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static BIBMDPIJAII ENNIKGPCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float3 LDHIOGOHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public float3x3 BPHIJKBMKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float3 LIKCBNMIJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public PFKCBGMNHLF OHELAGOCJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 LEFNKJMACNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float3 CJOGPCJMIEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6399220", Offset = "0x6397C20", VA = "0x186399220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 JHNCLCOKNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6398E50", Offset = "0x6397850", VA = "0x186398E50")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x63992A0", Offset = "0x6397CA0", VA = "0x1863992A0")]
	public BIBMDPIJAII(float3 DGOJEOCFHHN, quaternion DMBBOEJIOJM, float3 CBAOPDHODHO, PFKCBGMNHLF CGEOAHHPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6398F30", Offset = "0x6397930", VA = "0x186398F30")]
	public float JFFNEBOFCFL(float3 BNPKKMNBEBA, float MLDCDMCEIGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6399130", Offset = "0x6397B30", VA = "0x186399130")]
	public bool OAMEDEKLMKA(float3 AMMBIDJOPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6398BA0", Offset = "0x63975A0", VA = "0x186398BA0")]
	public void BPKGBHBPFAB(float3 JIDHMEMOBAC, float3x3 GKIFICKEDGI, float BODPAKLDOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6398D50", Offset = "0x6397750", VA = "0x186398D50")]
	private void DKJKPPJILCM(float3 OENLNJOIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6398910", Offset = "0x6397310", VA = "0x186398910")]
	public void AEGOLIBEDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
public struct MILGKEHBLND : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeList<BIBMDPIJAII> ABDLEBPKDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeList<float3> DPNCIKONKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<int> PPMAFAFGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HIJDHCPEJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<DIHJGJEKENF> KKBHCIBNFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private int PHNAINKEJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int NIDOOKONJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private float MLDCDMCEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ReadOnly]
	private float ADHACMEMLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GIBCGDBGIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CJMJIFFKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> JILFEJHFFCP;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x63AF4C0", Offset = "0x63ADEC0", VA = "0x1863AF4C0")]
	public MILGKEHBLND(DNFKGNJMGDP LPABBIBOFCJ, float BFGOBHFCDDC, int ALMDOMLFINK, int BGJCNEJBMHG, NativeList<BIBMDPIJAII> ABDLEBPKDKC, NativeArray<int> HIJDHCPEJMN, NativeList<DIHJGJEKENF> KKBHCIBNFMD, AIGOIAPDBPE FGJFMLBAFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x63AEA20", Offset = "0x63AD420", VA = "0x1863AEA20", Slot = "4")]
	public void Execute(int MMCLHDFCOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x63AF400", Offset = "0x63ADE00", VA = "0x1863AF400")]
	private bool IDCINLLCGBG(BIBMDPIJAII LMANHAAPNDE, BIBMDPIJAII AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x63AF160", Offset = "0x63ADB60", VA = "0x1863AF160")]
	private bool FDEFOBKPCLD(BIBMDPIJAII PNJHJOFNOLP, int AFFLICAAMJI, int IJKMDDHMLLK, int ENKKJFAPNDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class AIGOIAPDBPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<bool> GOAMCHMBMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<int> HNEHKJCAEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeArray<bool> PDGMOFIEBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeArray<float> KJOHKDLDGAL;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6398110", Offset = "0x6396B10", VA = "0x186398110")]
	public void PKKLPDGEOAD(int LFMNHCKBJME, int PCNHJLHNPGO, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x63980F0", Offset = "0x6396AF0", VA = "0x1863980F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6398210", Offset = "0x6396C10", VA = "0x186398210")]
	public void POEDLPEEEKF(JobHandle KLHLHHDJPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public AIGOIAPDBPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
public struct HMDGLMJLPJK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NativeList<float3> DPNCIKONKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NativeArray<float3> GAPFMLEFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private NativeArray<float4> MOFMKEAHBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private NativeArray<float2> JALCNOBOBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NativeList<int> PPMAFAFGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KNFFNHCMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<int> EBEOIFNFJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private NativeArray<bool> GIBCGDBGIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private NativeArray<bool> CJMJIFFKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ReadOnly]
	private int JCHLLAPOJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[ReadOnly]
	private int GCCIPCGEPDA;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x63A0D10", Offset = "0x639F710", VA = "0x1863A0D10")]
	public HMDGLMJLPJK(DNFKGNJMGDP LPABBIBOFCJ, AIGOIAPDBPE FGJFMLBAFHC, int GCCIPCGEPDA = 0, int JCHLLAPOJJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x63A0930", Offset = "0x639F330", VA = "0x1863A0930", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x63A08D0", Offset = "0x639F2D0", VA = "0x1863A08D0")]
	private void APFNACJFNAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class GBGIDMOBNCL
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x294E450", Offset = "0x294CE50", VA = "0x18294E450")]
	public static bool BIGADFFIHBF<T>(NativeArray<T> KKAKPOKBAHF, int CBAOPDHODHO, Allocator IMPJLMNPHBC, NativeArrayOptions KCIHFJELBPK = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x294E4F0", Offset = "0x294CEF0", VA = "0x18294E4F0")]
	public static bool BIGADFFIHBF<T>(NativeList<T> GOJPHGMMOOM, int CBAOPDHODHO, Allocator IMPJLMNPHBC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum EOJBFDOEJFA
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MLEBJBIBBOI
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PEGECCPMGAG(EOJBFDOEJFA NLNFAEHMBKG);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EFLABNCKDCE(EOJBFDOEJFA NLNFAEHMBKG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds HOGDGNGHJHB();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float KDGLOEGPHLG();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPLGMJAJNJA(EOJBFDOEJFA NLNFAEHMBKG, HNGHOKDHCHG EOJMIFPGAIJ, int IJLAECCLEMF = -1);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DNFKGNJMGDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const int ODHMHDEDLML = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NativeList<float3> BDJCPGNHOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NativeArray<float3> KPALCOCKLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NativeArray<float4> AOCDNMIKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public NativeArray<float4> LBACMJPAFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeArray<float2> IPJAHNBHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<int> KLCOEGMPPBE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MJOGKGKNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x639D620", Offset = "0x639C020", VA = "0x18639D620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PENGDLNAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x639D010", Offset = "0x639BA10", VA = "0x18639D010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CDIBEELIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x639D200", Offset = "0x639BC00", VA = "0x18639D200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool AELHAHFENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x639D050", Offset = "0x639BA50", VA = "0x18639D050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x639D0F0", Offset = "0x639BAF0", VA = "0x18639D0F0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x639E200", Offset = "0x639CC00", VA = "0x18639E200")]
	public void PKKLPDGEOAD(int LFMNHCKBJME, int PCNHJLHNPGO, Allocator IMPJLMNPHBC, bool NPOGEGEPCFA, bool OPBAAKOKOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x639DC90", Offset = "0x639C690", VA = "0x18639DC90")]
	public void MGGPAOODDLF(int LFMNHCKBJME, int PCNHJLHNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x639D240", Offset = "0x639BC40", VA = "0x18639D240", Slot = "6")]
	public bool JEDPLDMFBFD(Mesh LPABBIBOFCJ, bool BJFIDECNEBE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x639D660", Offset = "0x639C060", VA = "0x18639D660")]
	public bool MAKHMJCONJO(Mesh LPABBIBOFCJ, DNFKGNJMGDP DOIIMGHCJHA, bool BJFIDECNEBE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x639DF90", Offset = "0x639C990", VA = "0x18639DF90")]
	public void NJHPDJGABOH(DNFKGNJMGDP LPABBIBOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x639DE50", Offset = "0x639C850", VA = "0x18639DE50")]
	public DNFKGNJMGDP NEBOBDLOGAK(Allocator IMPJLMNPHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x639DD10", Offset = "0x639C710", VA = "0x18639DD10")]
	public long MGJLFGGAGOJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x639D090", Offset = "0x639BA90", VA = "0x18639D090")]
	public void DGIHHPBJFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public DNFKGNJMGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KKECGOONLIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x63ACB60", Offset = "0x63AB560", VA = "0x1863ACB60")]
	public static void NHFMBKBOCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HPBADDFBPJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<float3> BDJCPGNHOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<float3> KPALCOCKLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<int> HDFLMIICBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<float4> BMBFGOMPAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<float4> KNAPHDBGDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float4> IPDPMODCAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public NativeList<float3> NMACDMIGAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public NativeList<int> KLCOEGMPPBE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int PENGDLNAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x63A2AF0", Offset = "0x63A14F0", VA = "0x1863A2AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CDIBEELIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x63A3110", Offset = "0x63A1B10", VA = "0x1863A3110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NBDAGFIDOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x63A30D0", Offset = "0x63A1AD0", VA = "0x1863A30D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x63A39D0", Offset = "0x63A23D0", VA = "0x1863A39D0")]
	public HPBADDFBPJO(int LFMNHCKBJME, int PCNHJLHNPGO, int PMMNFGFDBJH, Allocator IMPJLMNPHBC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x63A3BF0", Offset = "0x63A25F0", VA = "0x1863A3BF0")]
	public HPBADDFBPJO(Mesh LPABBIBOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x63A2B30", Offset = "0x63A1530", VA = "0x1863A2B30", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x63A3150", Offset = "0x63A1B50", VA = "0x1863A3150")]
	public void NJHPDJGABOH(HPBADDFBPJO LPABBIBOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x63A2C40", Offset = "0x63A1640", VA = "0x1863A2C40")]
	private void EGGIDFKMNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x63A3450", Offset = "0x63A1E50", VA = "0x1863A3450")]
	private void PACIPJEJDHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DIHJGJEKENF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public int OEKKOGAEJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public int PENGDLNAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int FGCHPGGDHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public int CDIBEELIFEG;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x129CCD0", Offset = "0x129B6D0", VA = "0x18129CCD0")]
	public DIHJGJEKENF(int BGJCNEJBMHG, int NDNMCFIKHGD, int ALMDOMLFINK, int NCJEGPKKOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JDCJDOMAEOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<DIHJGJEKENF> EPBDJECKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x85BFA0", Offset = "0x85A9A0", VA = "0x18085BFA0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<DIHJGJEKENF>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85BFB0", Offset = "0x85A9B0", VA = "0x18085BFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HPBADDFBPJO CDLJGMJOALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x63A45E0", Offset = "0x63A2FE0", VA = "0x1863A45E0")]
	public JDCJDOMAEOA(IEnumerable<HPBADDFBPJO> HGDGJGEKCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x63A4570", Offset = "0x63A2F70", VA = "0x1863A4570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum KHNPPILKLFH
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GGKMEGMAJPA
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static NativeArray<float2> OEAOMKGJBOC;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static NativeArray<float3> OIIDHMPGOEH;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static NativeArray<float4> JADBCKMCEFI;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static NativeArray<int> FOKCJMDOBLC;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x639FF10", Offset = "0x639E910", VA = "0x18639FF10")]
	public static void NHFMBKBOCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x639FAD0", Offset = "0x639E4D0", VA = "0x18639FAD0")]
	public static NativeArray<float2> DAPGPFFONEL(NativeArray<float2> JGDFHMLBPLH, int KGLCBEKPOFL, NativeArray<float2> LFNHJDIHIOA, int MGEBJHCEDDC)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x639FE00", Offset = "0x639E800", VA = "0x18639FE00")]
	public static NativeArray<float3> KOGLGJHPLPK(NativeArray<float3> JGDFHMLBPLH, int KGLCBEKPOFL, NativeArray<float3> LFNHJDIHIOA, int MGEBJHCEDDC)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x639FCF0", Offset = "0x639E6F0", VA = "0x18639FCF0")]
	public static NativeArray<float4> FIFNJLCANFF(NativeArray<float4> JGDFHMLBPLH, int KGLCBEKPOFL, NativeArray<float4> LFNHJDIHIOA, int MGEBJHCEDDC)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x639FBE0", Offset = "0x639E5E0", VA = "0x18639FBE0")]
	public static NativeArray<int> ECBIACDBMHP(NativeArray<int> JGDFHMLBPLH, int KGLCBEKPOFL, NativeArray<int> LFNHJDIHIOA, int MGEBJHCEDDC)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x29594A0", Offset = "0x2957EA0", VA = "0x1829594A0")]
	private static void BCCJOLKJMLK<T>(NativeArray<T> KKAKPOKBAHF, int FLGKKCPAGPM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x29596A0", Offset = "0x29580A0", VA = "0x1829596A0")]
	private static void ICEPCCILNGH<T>(NativeArray<T> JGDFHMLBPLH, int KGLCBEKPOFL, NativeArray<T> LFNHJDIHIOA, int MGEBJHCEDDC, NativeArray<T> KAIGNNGGAPM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DebuggerStepThrough]
public static class MBGEFDCKMHE
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	public static void FCFIDFLACIE(bool GCGDEDCNCCJ, string PNCIFFCGEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	public static void FCFIDFLACIE(bool GCGDEDCNCCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KHFMADDILFI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal enum IKDALFBHPKE
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class GFFPCEGPDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NGNPBFFPEAL LPABBIBOFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int DGLGEPPBFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int EFEPIHLKMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long KEDJPLKIFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public long CIGJOGDPABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float HPBPOBGJKDO;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x63BF020", Offset = "0x63BDA20", VA = "0x1863BF020")]
		public GFFPCEGPDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x63BEFE0", Offset = "0x63BD9E0", VA = "0x1863BEFE0")]
		public void POEDLPEEEKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly string JAAJIBMEJNM;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly string GEBHLFLBJDO;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker LJIFPPKMHAP;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ProfilerMarker JCGHHOFEDEA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker KPFBGOFANPD;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker NPCDDKPCGFI;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker BAKEBAMHGCC;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker LBPCPLJPPFO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker DMIOFNECJAM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker EECOMCBMBFG;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker PPLEEKFNAHG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker FLLCFPEAONF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker CHLOIEFKGAL;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker LLFECNDDFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<MLEBJBIBBOI> IHGGEODABFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly CNDCANKNEFB KMONLFHHGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int NDNMCFIKHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int NCJEGPKKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool NOBANLOAHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	internal bool LPCPGKLMNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	internal IKDALFBHPKE MLJADEFEEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	internal bool MKODHMJHGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal float3 FCNJBJNBILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal float3 PMJMOLLHOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal float FPDFNLJIHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	internal float KIHILCFBILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	internal int APNFEGKBKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	internal int CMENLMFHPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int PBHPMLEOFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float OBGCKPDLHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float DDABJFIILCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int DCHFEHEFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private long PGJHAOGIELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PGBGEPKNBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private long JIFEOBADMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public int KOLKFGIBJKM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int GHENEGONONI = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float[] IPDCEDGNINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int[] KPBKFIEFOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private long[] CKFEPOEEODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private DNFKGNJMGDP AFKMEIFBALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private long PFLENCKMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private long GFBFNOBBBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int AOCGFBFJMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private List<GFFPCEGPDDD> HJIFLDPIKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	internal float OHCJJLPOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool AEBJCCMHEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private ICOIIKHAMGE GFALCNNDJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JobHandle MBAHMBEDMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal NativeArray<long> LPGEBFPGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool OFBAPJDGPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private JobHandle KBLEKLHCAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DNFKGNJMGDP MDLLIGALHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private Transform IIFDCEFFDED;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh CDLJGMJOALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer KLJKAIAOGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int GGGIAPIHDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xB019F0", Offset = "0xB003F0", VA = "0x180B019F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int IDKIOBOLPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F20", Offset = "0x7E8920", VA = "0x1807E9F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PENGDLNAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x63A5640", Offset = "0x63A4040", VA = "0x1863A5640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<MLEBJBIBBOI> MOMKPGDNOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x63A72E0", Offset = "0x63A5CE0", VA = "0x1863A72E0")]
	public void FIHLIGEPHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x63A5660", Offset = "0x63A4060", VA = "0x1863A5660")]
	private void BKEIOKAMFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x63AC340", Offset = "0x63AAD40", VA = "0x1863AC340")]
	public KHFMADDILFI(string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x63ABE90", Offset = "0x63AA890", VA = "0x1863ABE90")]
	public void POEDLPEEEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x63A7250", Offset = "0x63A5C50", VA = "0x1863A7250")]
	public void FFCFCPGFIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x63A8080", Offset = "0x63A6A80", VA = "0x1863A8080")]
	private void HKPBDHACNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x63AB0E0", Offset = "0x63A9AE0", VA = "0x1863AB0E0")]
	public void OMIJIBCAKIO(MLEBJBIBBOI IHNEGEPLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x63A8320", Offset = "0x63A6D20", VA = "0x1863A8320")]
	public bool IIKLDLHDKHG(MLEBJBIBBOI IHNEGEPLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x63AB080", Offset = "0x63A9A80", VA = "0x1863AB080")]
	public bool OBHCHEDFPHH(MLEBJBIBBOI IHNEGEPLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x63A72F0", Offset = "0x63A5CF0", VA = "0x1863A72F0", Slot = "4")]
	public virtual void HBMJILLALEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x63ABD50", Offset = "0x63AA750", VA = "0x1863ABD50")]
	public void PGEIAJPBIOJ(Transform IDOHLBJMFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x63AB240", Offset = "0x63A9C40", VA = "0x1863AB240")]
	public bool PBKOFHBMIIA(Transform IDOHLBJMFCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x63AA2C0", Offset = "0x63A8CC0", VA = "0x1863AA2C0")]
	public bool NGOEIMADJEP(bool JCEJDEJEPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x63A7F10", Offset = "0x63A6910", VA = "0x1863A7F10")]
	public void HHNEPPBFHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x63A73A0", Offset = "0x63A5DA0", VA = "0x1863A73A0")]
	public bool HGOJAOMAMBJ(float4x4 HKMKIFGLNNH, BatchedMeshRenderer MJJLCBDACOM, bool NDDGLDPEGOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x63A9480", Offset = "0x63A7E80", VA = "0x1863A9480")]
	public void LIBIEABJFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x63A6C30", Offset = "0x63A5630", VA = "0x1863A6C30")]
	public bool CMHIJNMIGIO(bool JCEJDEJEPOO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x63A9E50", Offset = "0x63A8850", VA = "0x1863A9E50")]
	public void MAHEIICICJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x63A9450", Offset = "0x63A7E50", VA = "0x1863A9450")]
	public void LHDCDOEDKKC(DNFKGNJMGDP LPABBIBOFCJ, int OIMGJAALEGN, float PECMMIIECDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x63A83C0", Offset = "0x63A6DC0", VA = "0x1863A83C0")]
	public void IMEEHIDEEOA(NGNPBFFPEAL OKKGDEJEPAA, int OIMGJAALEGN, float PECMMIIECDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x63A9E60", Offset = "0x63A8860", VA = "0x1863A9E60")]
	public long MGJLFGGAGOJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7CFA10", Offset = "0x7CE410", VA = "0x1807CFA10")]
	public long MCACNMMABCL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x63A6E60", Offset = "0x63A5860", VA = "0x1863A6E60")]
	private void EECEJCEAHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x63A5840", Offset = "0x63A4240", VA = "0x1863A5840")]
	public (long, long) BNDDKOGIDMC(float FKGCKDCEFEG, float4x4 HKMKIFGLNNH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xAA19F0", Offset = "0xAA03F0", VA = "0x180AA19F0")]
	internal void CNGKFIBNPPD(IKDALFBHPKE JMLHIOCCEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CC0", Offset = "0x63A76C0", VA = "0x1863A8CC0")]
	private (float, float, float) KNAPBEBHLKM(float LNFNHLLHMPD, float4x4 HKMKIFGLNNH)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x63A6FD0", Offset = "0x63A59D0", VA = "0x1863A6FD0")]
	private (int, int) FFAMOKGKENP(float GPLMDLOFGAI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x63A5BC0", Offset = "0x63A45C0", VA = "0x1863A5BC0")]
	public void CMDGGKNKJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x63A82F0", Offset = "0x63A6CF0", VA = "0x1863A82F0")]
	private void IBNMHFOLACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x63AA100", Offset = "0x63A8B00", VA = "0x1863AA100")]
	private void NBEPLDCEBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x63A83F0", Offset = "0x63A6DF0", VA = "0x1863A83F0")]
	private void JMDGFAFOEFM(DNFKGNJMGDP HFCAGDHEAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x63A9E70", Offset = "0x63A8870", VA = "0x1863A9E70")]
	private void MMJFEFOEFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x63A9550", Offset = "0x63A7F50", VA = "0x1863A9550")]
	private void LPDPKFOJFJE(DNFKGNJMGDP LPABBIBOFCJ, NGNPBFFPEAL OKKGDEJEPAA, int OIMGJAALEGN, float PECMMIIECDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[BurstCompile]
internal struct ICOIIKHAMGE : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct HKEJLPAMHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int GPMLLDLIOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int GPFOFAHGOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int CPAOJKLJGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int DBPIBFKIJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int AFPOGLCANKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int FHGDBKEIOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int DGLGEPPBFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int EFEPIHLKMLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float HPBPOBGJKDO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct OEGHADGEELF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public HGDEHBOGPNC.OFCKBCILGJG ILBNPFMDAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float MFFFEFCAMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float OGFOPCNKAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float DPLJHFEBPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float KDJJLEKBIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float ALDIFNGPACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float AHNOGDODMAC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct OFIACJFEEEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NativeArray<float3> BDJCPGNHOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NativeArray<float3> KPALCOCKLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public NativeArray<float4> AOCDNMIKANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public NativeArray<float4> LBACMJPAFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public NativeArray<float2> IPJAHNBHAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NativeArray<int> KLCOEGMPPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool JOLNGFPHJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public int PENGDLNAGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int CDIBEELIFEG;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x63C1AE0", Offset = "0x63C04E0", VA = "0x1863C1AE0")]
		public void PKKLPDGEOAD(int LFMNHCKBJME, int PCNHJLHNPGO, Allocator IMPJLMNPHBC, bool OPBAAKOKOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x63C1890", Offset = "0x63C0290", VA = "0x1863C1890")]
		public static OFIACJFEEEK NEDCMHIPGLA(DNFKGNJMGDP HJEPAOPBPKH)
		{
			return default(OFIACJFEEEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x63C1C30", Offset = "0x63C0630", VA = "0x1863C1C30")]
		public void POEDLPEEEKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker IIGLDIHIEDH;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker COHAKDOIHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private NativeArray<HKEJLPAMHBI> GIDMHBNFOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private OFIACJFEEEK AGCMIGDNKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private OFIACJFEEEK HFCAGDHEAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float3 AAEOBLAODNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private float3 NJNMGLNJOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private OEGHADGEELF CMCCKNPLKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* IKDBKOJBLAM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x63C1280", Offset = "0x63BFC80", VA = "0x1863C1280")]
	public ICOIIKHAMGE([In] List<KHFMADDILFI.GFFPCEGPDDD> PCPGGBCONIN, [In] DNFKGNJMGDP KIICLIGAEPJ, [In] KHFMADDILFI IPEOHDLDNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x63C0B80", Offset = "0x63BF580", VA = "0x1863C0B80", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x63BF070", Offset = "0x63BDA70", VA = "0x1863BF070")]
	public void ADDGFPKILJD(List<KHFMADDILFI.GFFPCEGPDDD> NPPMMJFHGEJ, [In] KHFMADDILFI IPEOHDLDNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x63BF6B0", Offset = "0x63BE0B0", VA = "0x1863BF6B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool EABKHFLMLNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x63C1010", Offset = "0x63BFA10", VA = "0x1863C1010")]
	private NGNPBFFPEAL JIMEKKOGFIO(int BGMAFMLFBFD, Allocator IMPJLMNPHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x63BF6D0", Offset = "0x63BE0D0", VA = "0x1863BF6D0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void EPMLCKIIFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x63C0BD0", Offset = "0x63BF5D0", VA = "0x1863C0BD0")]
	[IgnoreWarning(1371)]
	private HKEJLPAMHBI GODOAPFFCJJ([In] HKEJLPAMHBI KLEEDAJDNJF, int GOOGCOMEKNA, [In] NativeArray<int> PPMAFAFGCKM, [In] NativeArray<bool> CJMJIFFKKBE, NativeArray<int> IJIMBIMNPEM)
	{
		return default(HKEJLPAMHBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x63C10E0", Offset = "0x63BFAE0", VA = "0x1863C10E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int PFIEIMEBFAL(NativeArray<int> PPMAFAFGCKM, int DOGOAAGFBOP, int IDGLEAJKJIJ, int FMMFBMDPFCF)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly ProfilerMarker IOHDFCJJKJM;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly ProfilerMarker BBNDADCKIDP;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly ProfilerMarker BPFEIJJMPCO;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly ProfilerMarker JLIHHFOOPEE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly ProfilerMarker BAKEBAMHGCC;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly ProfilerMarker KHILPOABEKK;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly ProfilerMarker LIBBOOCHLBH;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal const int JLFIMLMHBAP = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Dictionary<Material, List<KHFMADDILFI>> OPIKDMOPCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal List<KHFMADDILFI> LIBDFCICGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private List<MeshRenderer> OGLNDFOJHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool JPLIOPNFEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool NKMIGIKMLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int PPAPIEGIPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Dictionary<int, float> HLBNCHKJBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Dictionary<int, Color> GJDPLCDNPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Dictionary<int, Vector4> BHLPIJLNKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, Matrix4x4> NNFPNNKFLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private KHFMADDILFI DBNJBEFAFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Material BNCMKAGKMAN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> KPHHINJOFLK
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int CIDEHEGICLF
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x63BEF90", Offset = "0x63BD990", VA = "0x1863BEF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x63BB930", Offset = "0x63BA330", VA = "0x1863BB930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x63BA140", Offset = "0x63B8B40", VA = "0x1863BA140")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x63B9D00", Offset = "0x63B8700", VA = "0x1863B9D00")]
		public KHFMADDILFI AddToBatchedMesh(MLEBJBIBBOI GJHCABOPGPL, Material FEIOCBKHAFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x63BE160", Offset = "0x63BCB60", VA = "0x1863BE160")]
		public void RemoveFromBatchedMesh(MLEBJBIBBOI LPABBIBOFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x63B9E00", Offset = "0x63B8800", VA = "0x1863B9E00")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x63BE2A0", Offset = "0x63BCCA0", VA = "0x1863BE2A0")]
		public void SetMaterialProperty(int LIJAEAOCHAJ, Color GLALCIBBONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x63BE720", Offset = "0x63BD120", VA = "0x1863BE720")]
		public void SetMaterialProperty(int LIJAEAOCHAJ, float AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x63BE940", Offset = "0x63BD340", VA = "0x1863BE940")]
		public void SetMaterialProperty(int LIJAEAOCHAJ, Vector4 JNMFNAHPHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x63BE4C0", Offset = "0x63BCEC0", VA = "0x1863BE4C0")]
		public void SetMaterialProperty(int LIJAEAOCHAJ, Matrix4x4 DKJDKDGBGOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x63BB340", Offset = "0x63B9D40", VA = "0x1863BB340")]
		private void NMFGFEPACGD(Renderer LDIKCIPDAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x63BA310", Offset = "0x63B8D10", VA = "0x1863BA310")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x63BA300", Offset = "0x63B8D00", VA = "0x1863BA300")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x63B97C0", Offset = "0x63B81C0", VA = "0x1863B97C0")]
		private void ABCCFCFKLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x63B9F30", Offset = "0x63B8930", VA = "0x1863B9F30")]
		private KHFMADDILFI DBFLCPBACEN(MLEBJBIBBOI LPABBIBOFCJ, Material FEIOCBKHAFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x63BBC20", Offset = "0x63BA620", VA = "0x1863BBC20")]
		private KHFMADDILFI PMBKLHOIPIN(Material FEIOCBKHAFO, int JJBFHENKMEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x63BA930", Offset = "0x63B9330", VA = "0x1863BA930")]
		private KHFMADDILFI LOPBCAHOMLH(Material FEIOCBKHAFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1798FD0", Offset = "0x17979D0", VA = "0x181798FD0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x63BAE60", Offset = "0x63B9860", VA = "0x1863BAE60")]
		public void MarkDirty(MLEBJBIBBOI LPABBIBOFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x63BAFC0", Offset = "0x63B99C0", VA = "0x1863BAFC0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float FKGCKDCEFEG)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x63BD2D0", Offset = "0x63BBCD0", VA = "0x1863BD2D0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x63BA3B0", Offset = "0x63B8DB0", VA = "0x1863BA3B0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x63BBE20", Offset = "0x63BA820", VA = "0x1863BBE20")]
		public void RebatchOptimally(int LAONEBPDAHF, int CHGDHDEIFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x63BED20", Offset = "0x63BD720", VA = "0x1863BED20")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ACONOGKLMKD
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct HNDDLMGBGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public float NBNHCPDHIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BatchedMeshRenderer AFGKCGKAMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public KHFMADDILFI EIJBMMBMEFF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly ProfilerMarker BAKEBAMHGCC;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly ProfilerMarker EMODPHACJFP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly ProfilerMarker PKECKJIHEMC;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ProfilerMarker COJDEJLEBJI;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public static float3 GKPHENBANLA;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public static int INOCDHJJNGD;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static int KPLICNKOFML;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static int MKCOJMDDNNA;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public static int BOEMAINHBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public static int ACCHOPHGGGC;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static int GCEKBDOOAIA;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static int GAFILHJFJGM;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static int IABDOFICIOF;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static int AMHMAMGOKJL;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static int NAJKEJINOCD;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public static int EOOBBEFPKDG;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public static int LLPOPGILJKP;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public static int OAPKHINMLEI;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public static int MEONKHKHJAG;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static int EFLOHKBGGIN;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public static int BOLFGJJPPGC;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public static long ENOLAGEIFAM;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public static bool KLJJPJMKANK;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static List<BatchedMeshRenderer> MFLDBPLOMLH;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static List<HNDDLMGBGGD> OBDIIHPPLNM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool DIICAKFLEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x63B8CE0", Offset = "0x63B76E0", VA = "0x1863B8CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x63B5C00", Offset = "0x63B4600", VA = "0x1863B5C00")]
	public static void BMGPKAMLICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x63B9210", Offset = "0x63B7C10", VA = "0x1863B9210")]
	public static void PPHGLPJAODB(BatchedMeshRenderer HMHAJPMMPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x63B8C30", Offset = "0x63B7630", VA = "0x1863B8C30")]
	public static void HJGONDPIOCN(BatchedMeshRenderer HMHAJPMMPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x63B58F0", Offset = "0x63B42F0", VA = "0x1863B58F0")]
	private static void AMJBNDBGAEI([Out] long LLMGNPMIEHO, [Out] long CDBOFJKGIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x63B6C20", Offset = "0x63B5620", VA = "0x1863B6C20")]
	public static void HGOJAOMAMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x63B8F30", Offset = "0x63B7930", VA = "0x1863B8F30")]
	public static void NGCCDDDIACH(KHFMADDILFI EIJBMMBMEFF, BatchedMeshRenderer AFGKCGKAMNG, float NBNHCPDHIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x63B8FD0", Offset = "0x63B79D0", VA = "0x1863B8FD0")]
	public static void NOMKJDCOHCK(KHFMADDILFI EIJBMMBMEFF, BatchedMeshRenderer AFGKCGKAMNG, float AKGNECODMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x63B5FB0", Offset = "0x63B49B0", VA = "0x1863B5FB0")]
	public static void CJADCHFHIMO(KHFMADDILFI EIJBMMBMEFF, BatchedMeshRenderer AFGKCGKAMNG, float AKGNECODMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x63B5AA0", Offset = "0x63B44A0", VA = "0x1863B5AA0")]
	public static void BHNEPMLCLKF(KHFMADDILFI EIJBMMBMEFF, BatchedMeshRenderer AFGKCGKAMNG, float NBNHCPDHIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x63B9070", Offset = "0x63B7A70", VA = "0x1863B9070")]
	public static void PHJOGNLFMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x63B8D70", Offset = "0x63B7770", VA = "0x1863B8D70")]
	public static void KBBHODLMEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x63B8930", Offset = "0x63B7330", VA = "0x1863B8930")]
	public static float HIPNJGKBGAF(long EMPJOCBDLJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x63B5DE0", Offset = "0x63B47E0", VA = "0x1863B5DE0")]
	public static (long, long) BNDDKOGIDMC(float FKGCKDCEFEG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x63B6140", Offset = "0x63B4B40", VA = "0x1863B6140")]
	public static void EDGPFEIDKDM(bool KBKJBBGKDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x63B6050", Offset = "0x63B4A50", VA = "0x1863B6050")]
	public static int DADPIAOGKAK()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OCLJAKHICEH<KeyType> : KHFMADDILFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly Dictionary<KeyType, MLEBJBIBBOI> NOHFICAPPBE;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4202A90", Offset = "0x4201490", VA = "0x184202A90")]
	public OCLJAKHICEH(string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4202A40", Offset = "0x4201440", VA = "0x184202A40")]
	public void OMIJIBCAKIO(KeyType KLDFLAABJKH, MLEBJBIBBOI IHNEGEPLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x42028A0", Offset = "0x42012A0", VA = "0x1842028A0")]
	public bool NDBNAEDGBKC(KeyType KLDFLAABJKH, MLEBJBIBBOI GFJPEDHEICJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4202760", Offset = "0x4201160", VA = "0x184202760")]
	public void HENGEMJKIAH(KeyType KLDFLAABJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4202720", Offset = "0x4201120", VA = "0x184202720", Slot = "4")]
	public override void HBMJILLALEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x63C1CF0", Offset = "0x63C06F0", VA = "0x1863C1CF0")]
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
