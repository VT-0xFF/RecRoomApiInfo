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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x696C290", Offset = "0x696B690", VA = "0x18696C290", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JAJLKEBNELI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int EIDGGGHDOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 HCJCHHJIAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion NNFGMJPLIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 OMLNEKDBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KEAFBLNCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int NNFOKMMOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int CCKLGMMGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float CNPPJMLFBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 FKGGDNDPHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool EHNHNACDMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public MCJHAKEBCFO PFKHFDKFEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 DJLDBDHPKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float JHIBGHDELLP;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MAFKMJEPOIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static JCDIBLMPGLA LFPEELIHMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<JAJLKEBNELI> FGNMFCKMEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<LHLEFIKFIFF> DBPBLOLDCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<HEAMBEBCGBO> EJKEJDBFNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<CKPHKFFGLGA> DBPPFGNCCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<LHLEFIKFIFF> FKBDEOPMMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NEIBEJPBCPE> OKPANFCFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<CKPHKFFGLGA>> GIOMKHHBCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<GOALGAAPFMD> GNCMPIJBFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> NLDEAABGKIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GLEMFOKAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEB96C0", Offset = "0xEB8AC0", VA = "0x180EB96C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEB8300", Offset = "0xEB7700", VA = "0x180EB8300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EJGCOECJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEB96D0", Offset = "0xEB8AD0", VA = "0x180EB96D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEB8D40", Offset = "0xEB8140", VA = "0x180EB8D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x696E0F0", Offset = "0x696D4F0", VA = "0x18696E0F0")]
	public MAFKMJEPOIF(int CIAKAJIJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x696C3E0", Offset = "0x696B7E0", VA = "0x18696C3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x696CA70", Offset = "0x696BE70", VA = "0x18696CA70")]
	public void HGGBIMJODNJ(JobHandle DBNLEGDAPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x696C850", Offset = "0x696BC50", VA = "0x18696C850")]
	public void EGEDHDAGJBB(JAJLKEBNELI LDNEPNAGEGN, GOALGAAPFMD MALBFFNKMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x696DF90", Offset = "0x696D390", VA = "0x18696DF90")]
	public void OIJMCPIJBOM(HEAMBEBCGBO LDNEPNAGEGN, NativeArray<CKPHKFFGLGA> BMGDHCPCAFB, int AKKCHCGDDPD, int KJADDLBDLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x696CF80", Offset = "0x696C380", VA = "0x18696CF80")]
	public JobHandle KELJMEDCOBK(AGIFCHBLDPN GKPNNBIAKFB, CILABMCHBMA NFNCPILNBLH, float3 OLHPMOCEPMN, quaternion KJIGDFGGJFE, float HELBKMGDADD, bool JIMILIOIPHJ, int AODJMMIBHAA = 0, int LJFLLIIANNH = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x696CC40", Offset = "0x696C040", VA = "0x18696CC40")]
	public static JobHandle KDNPBHJKNBP(DLKOAOFCNIK HDGHGPJIHNG, AGIFCHBLDPN GKPNNBIAKFB, JAJLKEBNELI LDNEPNAGEGN, JobHandle DBNLEGDAPHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x696C5A0", Offset = "0x696B9A0", VA = "0x18696C5A0")]
	public static JobHandle EFPCBMEKPOL(HHHCDBIAJNM HDGHGPJIHNG, AGIFCHBLDPN GKPNNBIAKFB, HEAMBEBCGBO LDNEPNAGEGN, NativeArray<CKPHKFFGLGA> BMGDHCPCAFB, int AKKCHCGDDPD, int KJADDLBDLJP, JobHandle DBNLEGDAPHE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public class IJIPMMOPBHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct DNDEBEJCNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half NDNGFICBDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort HJIGNFKAMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte HDMHNDCKHIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void CFIGDPLEPDO([NoAlias] float3* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class GCIFJGINNEP
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69607B0", Offset = "0x695FBB0", VA = "0x1869607B0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6960650", Offset = "0x695FA50", VA = "0x186960650")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6960AF0", Offset = "0x695FEF0", VA = "0x186960AF0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69608E0", Offset = "0x695FCE0", VA = "0x1869608E0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] float3* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void PIOCGNPKCKI([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class CDLHDIMNDPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x695A140", Offset = "0x6959540", VA = "0x18695A140")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6959FE0", Offset = "0x69593E0", VA = "0x186959FE0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x695A500", Offset = "0x6959900", VA = "0x18695A500")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x695A270", Offset = "0x6959670", VA = "0x18695A270")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void OPGFJNJHHJG([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class GPHDCFIBFGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6961780", Offset = "0x6960B80", VA = "0x186961780")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6961620", Offset = "0x6960A20", VA = "0x186961620")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6961B40", Offset = "0x6960F40", VA = "0x186961B40")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69618B0", Offset = "0x6960CB0", VA = "0x1869618B0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void NJACILNMIGL([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class PDKOELELJOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6973140", Offset = "0x6972540", VA = "0x186973140")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6972FE0", Offset = "0x69723E0", VA = "0x186972FE0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6973500", Offset = "0x6972900", VA = "0x186973500")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6973270", Offset = "0x6972670", VA = "0x186973270")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void MNMFCJBICNM([NoAlias] ushort* JHPFENMHHDM, [Out] float3 ANEHAEJNMKP, [Out] float3 HIGEBIIBOPL, [In][NoAlias] float3* GFNMEBPHFFI, int GAHEJGOIIHM, int EFLEFHDHJNC);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class HKIOGAEBHGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69626F0", Offset = "0x6961AF0", VA = "0x1869626F0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6962590", Offset = "0x6961990", VA = "0x186962590")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6962A40", Offset = "0x6961E40", VA = "0x186962A40")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6962820", Offset = "0x6961C20", VA = "0x186962820")]
		public unsafe static void KGLFFAEFCMK([NoAlias] ushort* JHPFENMHHDM, [Out] float3 ANEHAEJNMKP, [Out] float3 HIGEBIIBOPL, [In][NoAlias] float3* GFNMEBPHFFI, int GAHEJGOIIHM, int EFLEFHDHJNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void FFCLNIFPDFP([NoAlias] ushort* HIOBGKHMDAD, [In][NoAlias] float3* GDIFIALFJDP, int EFLEFHDHJNC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class LIKNLKIFMMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x696BEC0", Offset = "0x696B2C0", VA = "0x18696BEC0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x696BD60", Offset = "0x696B160", VA = "0x18696BD60")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x696C1E0", Offset = "0x696B5E0", VA = "0x18696C1E0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x696BFF0", Offset = "0x696B3F0", VA = "0x18696BFF0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] ushort* HIOBGKHMDAD, [In][NoAlias] float3* GDIFIALFJDP, int EFLEFHDHJNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void BGGCJNMCAAJ([NoAlias] float3* NFNKIGHBNIL, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class PPFOPHNDHDC
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6974380", Offset = "0x6973780", VA = "0x186974380")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6974220", Offset = "0x6973620", VA = "0x186974220")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6974700", Offset = "0x6973B00", VA = "0x186974700")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69744B0", Offset = "0x69738B0", VA = "0x1869744B0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] float3* NFNKIGHBNIL, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void OELMEEMPIDA([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class NNIILEFLPDA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6970280", Offset = "0x696F680", VA = "0x186970280")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6970120", Offset = "0x696F520", VA = "0x186970120")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69705A0", Offset = "0x696F9A0", VA = "0x1869705A0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69703B0", Offset = "0x696F7B0", VA = "0x1869703B0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void INIBMOEEPCM([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class KEAPEANPNCB
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x696AD20", Offset = "0x696A120", VA = "0x18696AD20")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x696ABC0", Offset = "0x6969FC0", VA = "0x18696ABC0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x696B110", Offset = "0x696A510", VA = "0x18696B110")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x696AE50", Offset = "0x696A250", VA = "0x18696AE50")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void FPMNKACFPFJ([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class MMLOOJDHHGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x696FB90", Offset = "0x696EF90", VA = "0x18696FB90")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x696FA30", Offset = "0x696EE30", VA = "0x18696FA30")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x696FF70", Offset = "0x696F370", VA = "0x18696FF70")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x696FCC0", Offset = "0x696F0C0", VA = "0x18696FCC0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void NNNPDGIBOHG([NoAlias] ushort* IGIKELHAEGI, [Out] float2 IFAGLHPHFAD, [Out] float2 LOHDJBCGIAI, [In][NoAlias] float2* MFKEKAPJOFL, int GAHEJGOIIHM, int EFLEFHDHJNC);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class IGKMNJMDJKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6963420", Offset = "0x6962820", VA = "0x186963420")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69632C0", Offset = "0x69626C0", VA = "0x1869632C0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6963770", Offset = "0x6962B70", VA = "0x186963770")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6963550", Offset = "0x6962950", VA = "0x186963550")]
		public unsafe static void KGLFFAEFCMK([NoAlias] ushort* IGIKELHAEGI, [Out] float2 IFAGLHPHFAD, [Out] float2 LOHDJBCGIAI, [In][NoAlias] float2* MFKEKAPJOFL, int GAHEJGOIIHM, int EFLEFHDHJNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void FENLEFAKIFL([Out] float2 JKIMLGEFEHK, ushort LLGJJOLCKKL, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class NPOJPDMBHLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69707B0", Offset = "0x696FBB0", VA = "0x1869707B0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6970650", Offset = "0x696FA50", VA = "0x186970650")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6970B20", Offset = "0x696FF20", VA = "0x186970B20")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69708E0", Offset = "0x696FCE0", VA = "0x1869708E0")]
		public static void KGLFFAEFCMK([Out] float2 JKIMLGEFEHK, ushort LLGJJOLCKKL, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void NJGOENJEKDN([NoAlias] float2* IGIKELHAEGI, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class PNLGDJCNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6973DB0", Offset = "0x69731B0", VA = "0x186973DB0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6973C50", Offset = "0x6973050", VA = "0x186973C50")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6974170", Offset = "0x6973570", VA = "0x186974170")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6973EE0", Offset = "0x69732E0", VA = "0x186973EE0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] float2* IGIKELHAEGI, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void HGMMFHHOKBI([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class LHCNNDHGFKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x696B8B0", Offset = "0x696ACB0", VA = "0x18696B8B0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x696B750", Offset = "0x696AB50", VA = "0x18696B750")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x696BCB0", Offset = "0x696B0B0", VA = "0x18696BCB0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x696B9E0", Offset = "0x696ADE0", VA = "0x18696B9E0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void ODJDDGGIELF([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class FCPIFHLGIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x695F560", Offset = "0x695E960", VA = "0x18695F560")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x695F400", Offset = "0x695E800", VA = "0x18695F400")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x695F960", Offset = "0x695ED60", VA = "0x18695F960")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x695F690", Offset = "0x695EA90", VA = "0x18695F690")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public unsafe delegate void HEEHIFINEKF([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class DKOIADLGHLB
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x695E1D0", Offset = "0x695D5D0", VA = "0x18695E1D0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x695E070", Offset = "0x695D470", VA = "0x18695E070")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x695E6B0", Offset = "0x695DAB0", VA = "0x18695E6B0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x695E300", Offset = "0x695D700", VA = "0x18695E300")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void EDFGLFPPHAG([NoAlias] ushort* IJJMOPCPEBF, [In][NoAlias] float4* HDGGFMNGBCM, int GAHEJGOIIHM, int EFLEFHDHJNC);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class LAFDGPOKHAN
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x696B320", Offset = "0x696A720", VA = "0x18696B320")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x696B1C0", Offset = "0x696A5C0", VA = "0x18696B1C0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x696B6A0", Offset = "0x696AAA0", VA = "0x18696B6A0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x696B450", Offset = "0x696A850", VA = "0x18696B450")]
		public unsafe static void KGLFFAEFCMK([NoAlias] ushort* IJJMOPCPEBF, [In][NoAlias] float4* HDGGFMNGBCM, int GAHEJGOIIHM, int EFLEFHDHJNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate ushort JIFGHCCHOKN([In] float4 NLJPEJLAKEP);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class EDGIOOJOPND
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x695F010", Offset = "0x695E410", VA = "0x18695F010")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x695EEB0", Offset = "0x695E2B0", VA = "0x18695EEB0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x695F350", Offset = "0x695E750", VA = "0x18695F350")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x695F140", Offset = "0x695E540", VA = "0x18695F140")]
		public static ushort KGLFFAEFCMK([In] float4 NLJPEJLAKEP)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void PGIDCIJGBME([NoAlias] float4* IJJMOPCPEBF, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class COGPIIFKFGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x695CF70", Offset = "0x695C370", VA = "0x18695CF70")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x695CE10", Offset = "0x695C210", VA = "0x18695CE10")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x695D2F0", Offset = "0x695C6F0", VA = "0x18695D2F0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x695D0A0", Offset = "0x695C4A0", VA = "0x18695D0A0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] float4* IJJMOPCPEBF, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void ADEAFIHIFBE([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class IMLIGJKNLFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x696A130", Offset = "0x6969530", VA = "0x18696A130")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6969FD0", Offset = "0x69693D0", VA = "0x186969FD0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x696A450", Offset = "0x6969850", VA = "0x18696A450")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x696A260", Offset = "0x6969660", VA = "0x18696A260")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void EFOCMJILONB([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class DBOLCPEHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x695DBD0", Offset = "0x695CFD0", VA = "0x18695DBD0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x695DA70", Offset = "0x695CE70", VA = "0x18695DA70")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x695DFC0", Offset = "0x695D3C0", VA = "0x18695DFC0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x695DD00", Offset = "0x695D100", VA = "0x18695DD00")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void PEBCNDEOFBG([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class MKJABLPLIGG
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x696F5A0", Offset = "0x696E9A0", VA = "0x18696F5A0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x696F440", Offset = "0x696E840", VA = "0x18696F440")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x696F980", Offset = "0x696ED80", VA = "0x18696F980")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x696F6D0", Offset = "0x696EAD0", VA = "0x18696F6D0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void PFBEKEABFAD([Out] float4 LLANANCGECL, ushort LLGJJOLCKKL);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class MJLEEHIILGL
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x696EFE0", Offset = "0x696E3E0", VA = "0x18696EFE0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x696EE80", Offset = "0x696E280", VA = "0x18696EE80")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x696F390", Offset = "0x696E790", VA = "0x18696F390")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x696F110", Offset = "0x696E510", VA = "0x18696F110")]
		public static void KGLFFAEFCMK([Out] float4 LLANANCGECL, ushort LLGJJOLCKKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public unsafe delegate void JDBFJABIJFD([NoAlias] float4* JIIBJCPGJNH, [NoAlias] byte* KGMDHHPOKOE, [Out] int NACENBIGMAH, [Out] int LGHOGKEFPOK, [NoAlias] float4* FBBKDIECING, int GAHEJGOIIHM, int EFLEFHDHJNC);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class MDJEDLMBIJE
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x696E460", Offset = "0x696D860", VA = "0x18696E460")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x696E300", Offset = "0x696D700", VA = "0x18696E300")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x696E7B0", Offset = "0x696DBB0", VA = "0x18696E7B0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x696E590", Offset = "0x696D990", VA = "0x18696E590")]
		public unsafe static void KGLFFAEFCMK([NoAlias] float4* JIIBJCPGJNH, [NoAlias] byte* KGMDHHPOKOE, [Out] int NACENBIGMAH, [Out] int LGHOGKEFPOK, [NoAlias] float4* FBBKDIECING, int GAHEJGOIIHM, int EFLEFHDHJNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void BIPLCPEMIHP([NoAlias] float4* FMHCALKFGNP, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class MGHANCMKFDN
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x696E9C0", Offset = "0x696DDC0", VA = "0x18696E9C0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x696E860", Offset = "0x696DC60", VA = "0x18696E860")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x696EDD0", Offset = "0x696E1D0", VA = "0x18696EDD0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x696EAF0", Offset = "0x696DEF0", VA = "0x18696EAF0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] float4* FMHCALKFGNP, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void MGDHHMFJOBK([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class HLKDKALBJED
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6962D50", Offset = "0x6962150", VA = "0x186962D50")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6962BF0", Offset = "0x6961FF0", VA = "0x186962BF0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6963210", Offset = "0x6962610", VA = "0x186963210")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6962E80", Offset = "0x6962280", VA = "0x186962E80")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void DJAEEIILLOP([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class PBDOEEPEJCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6972A60", Offset = "0x6971E60", VA = "0x186972A60")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6972900", Offset = "0x6971D00", VA = "0x186972900")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6972F30", Offset = "0x6972330", VA = "0x186972F30")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6972B90", Offset = "0x6971F90", VA = "0x186972B90")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void HANCLOAIGMJ([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class DBKLBLIFMJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x695D500", Offset = "0x695C900", VA = "0x18695D500")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x695D3A0", Offset = "0x695C7A0", VA = "0x18695D3A0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x695D9C0", Offset = "0x695CDC0", VA = "0x18695D9C0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x695D630", Offset = "0x695CA30", VA = "0x18695D630")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate int HKPPMPCIMDN([NoAlias] byte* LPEADGMFEHC, [In][NoAlias] int* EAPLABBFKML, int JNLMCGCLFJC);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class JDCGOBKIDJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x696A760", Offset = "0x6969B60", VA = "0x18696A760")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x696A600", Offset = "0x6969A00", VA = "0x18696A600")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x696AB10", Offset = "0x6969F10", VA = "0x18696AB10")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x696A890", Offset = "0x6969C90", VA = "0x18696A890")]
		public unsafe static int KGLFFAEFCMK([NoAlias] byte* LPEADGMFEHC, [In][NoAlias] int* EAPLABBFKML, int JNLMCGCLFJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void BOPBJNMGEAE([NoAlias] int* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class HHNOBJEIHAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6962170", Offset = "0x6961570", VA = "0x186962170")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6962010", Offset = "0x6961410", VA = "0x186962010")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x69624E0", Offset = "0x69618E0", VA = "0x1869624E0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x69622A0", Offset = "0x69616A0", VA = "0x1869622A0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] int* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public unsafe delegate void IKFPDILAIFP([NoAlias] ushort* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class BNFLBLLCIDF
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x69583D0", Offset = "0x69577D0", VA = "0x1869583D0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6958270", Offset = "0x6957670", VA = "0x186958270")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6958740", Offset = "0x6957B40", VA = "0x186958740")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6958500", Offset = "0x6957900", VA = "0x186958500")]
		public unsafe static void KGLFFAEFCMK([NoAlias] ushort* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate void CBJEIIFBFDL([Out] float3 JKIMLGEFEHK, ushort LLGJJOLCKKL);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class PGOHDJCHPDH
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6973710", Offset = "0x6972B10", VA = "0x186973710")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x69735B0", Offset = "0x69729B0", VA = "0x1869735B0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6973BA0", Offset = "0x6972FA0", VA = "0x186973BA0")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6973840", Offset = "0x6972C40", VA = "0x186973840")]
		public static void KGLFFAEFCMK([Out] float3 JKIMLGEFEHK, ushort LLGJJOLCKKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate ushort HPLNPICNPMG([In] float3 NLJPEJLAKEP);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class ODKHDLODDHN
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6970D30", Offset = "0x6970130", VA = "0x186970D30")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6970BD0", Offset = "0x696FFD0", VA = "0x186970BD0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6971030", Offset = "0x6970430", VA = "0x186971030")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6970E60", Offset = "0x6970260", VA = "0x186970E60")]
		public static ushort KGLFFAEFCMK([In] float3 NLJPEJLAKEP)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int AKKCHCGDDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int KJADDLBDLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> IHIMHEHBKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> EEAPKKFGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> AAPLLALEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> AKNHCBMIGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DNDEBEJCNIE> JACEJAPODNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> CKEHPFFPJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> PBOEIEKIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 LLPBCMDPCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 HIGEBIIBOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 CKDFGIFMAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 LOHDJBCGIAI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long JDLIPGOINFM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long IBAFCIKHJGL;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float EILPDEFEGKN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool JHOMKBMMJPP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JOMLJAJAIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69649C0", Offset = "0x6963DC0", VA = "0x1869649C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69661B0", Offset = "0x69655B0", VA = "0x1869661B0")]
	public void HGGBIMJODNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69664D0", Offset = "0x69658D0", VA = "0x1869664D0")]
	public static IJIPMMOPBHJ IBMNHJIAJMD(Allocator EIFDLGAHDFC, AGIFCHBLDPN EOHEBAOIHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69666B0", Offset = "0x6965AB0", VA = "0x1869666B0")]
	public static IJIPMMOPBHJ IBMNHJIAJMD(Allocator EIFDLGAHDFC, NativeArray<float3> GFNMEBPHFFI, NativeArray<float3> GDIFIALFJDP, NativeArray<float2> MFKEKAPJOFL, NativeArray<float4> FBBKDIECING, bool AJHIPMCDLJG, NativeArray<float4> AJADFDNJCHF, NativeArray<int> EAPLABBFKML, int AKKCHCGDDPD, int OFKJFCNBMHF, int KJADDLBDLJP, int GAHEJGOIIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6968A80", Offset = "0x6967E80", VA = "0x186968A80")]
	public AGIFCHBLDPN NACIEOCNDAK(Allocator EIFDLGAHDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6967E00", Offset = "0x6967200", VA = "0x186967E00")]
	public void LFEPOMHGMGO(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6969540", Offset = "0x6968940", VA = "0x186969540")]
	private void OLKPFKDEHBL(Mesh GFKLPJBCEPF, NativeArray<ushort> EPOKACPEDLE, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6969780", Offset = "0x6968B80", VA = "0x186969780")]
	public void PALFFBLNBIE(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6967F00", Offset = "0x6967300", VA = "0x186967F00")]
	public void LGNJKGIMLBD(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6966E80", Offset = "0x6966280", VA = "0x186966E80")]
	public void IIHLAGEKHPK(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6964540", Offset = "0x6963940", VA = "0x186964540")]
	public void CIEMALICNPD(Mesh GFKLPJBCEPF, AGIFCHBLDPN.EFOGHNOBDIO DNDIAOIJGOO, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6964F50", Offset = "0x6964350", VA = "0x186964F50")]
	public long EAPCLLMOOHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69687F0", Offset = "0x6967BF0", VA = "0x1869687F0")]
	public long MIBGHCKMDNF(AGIFCHBLDPN.EFOGHNOBDIO DNDIAOIJGOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6965DB0", Offset = "0x69651B0", VA = "0x186965DB0")]
	private void GOBPIALLIIA(int NEAMGOHHBGB, int EFLEFHDHJNC, Allocator EIFDLGAHDFC, bool NABLBCNGEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6964D30", Offset = "0x6964130", VA = "0x186964D30")]
	private void DHPGIKNFFHM(NativeArray<float3> JHPFENMHHDM, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6964CB0", Offset = "0x69640B0", VA = "0x186964CB0")]
	[BurstCompile]
	private unsafe static void DHPGIKNFFHM([NoAlias] float3* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6968530", Offset = "0x6967930", VA = "0x186968530")]
	[BurstCompile]
	private unsafe static void LJPGKLNOCLD([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6963E60", Offset = "0x6963260", VA = "0x186963E60")]
	[BurstCompile]
	private unsafe static void BENNKGABIHN([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6968920", Offset = "0x6967D20", VA = "0x186968920")]
	[BurstCompile]
	private unsafe static void MMFMDGKFBLJ([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6969ED0", Offset = "0x69692D0", VA = "0x186969ED0")]
	private void PNCKIOAAALP(NativeArray<float3> GFNMEBPHFFI, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6969E40", Offset = "0x6969240", VA = "0x186969E40")]
	[BurstCompile]
	private unsafe static void PNCKIOAAALP([NoAlias] ushort* JHPFENMHHDM, [Out] float3 ANEHAEJNMKP, [Out] float3 HIGEBIIBOPL, [In][NoAlias] float3* GFNMEBPHFFI, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6966BA0", Offset = "0x6965FA0", VA = "0x186966BA0")]
	private void IFFKBDFINFM(NativeArray<float3> GDIFIALFJDP, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6966C60", Offset = "0x6966060", VA = "0x186966C60")]
	[BurstCompile]
	private unsafe static void IFFKBDFINFM([NoAlias] ushort* HIOBGKHMDAD, [In][NoAlias] float3* GDIFIALFJDP, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6969D00", Offset = "0x6969100", VA = "0x186969D00")]
	private void PJJBPGPIKJJ(NativeArray<float3> NFNKIGHBNIL, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6969DD0", Offset = "0x69691D0", VA = "0x186969DD0")]
	[BurstCompile]
	private unsafe static void PJJBPGPIKJJ([NoAlias] float3* NFNKIGHBNIL, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69662B0", Offset = "0x69656B0", VA = "0x1869662B0")]
	[BurstCompile]
	private unsafe static void HIFHGNBHPDO([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6967D40", Offset = "0x6967140", VA = "0x186967D40")]
	[BurstCompile]
	private unsafe static void LDLEKFNFHAK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6967460", Offset = "0x6966860", VA = "0x186967460")]
	[BurstCompile]
	private unsafe static void IJCMIIIBBCO([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69648F0", Offset = "0x6963CF0", VA = "0x1869648F0")]
	private void CPBGCEIICFM(NativeArray<float2> MFKEKAPJOFL, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69646A0", Offset = "0x6963AA0", VA = "0x1869646A0")]
	[BurstCompile]
	private unsafe static void CPBGCEIICFM([NoAlias] ushort* IGIKELHAEGI, [Out] float2 IFAGLHPHFAD, [Out] float2 LOHDJBCGIAI, [In][NoAlias] float2* MFKEKAPJOFL, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6963BB0", Offset = "0x6962FB0", VA = "0x186963BB0")]
	[BurstCompile]
	private static void ANNDODBNCPI([Out] float2 JKIMLGEFEHK, ushort LLGJJOLCKKL, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6968630", Offset = "0x6967A30", VA = "0x186968630")]
	private void LMPOOPGJAMA(NativeArray<float2> IGIKELHAEGI, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69685B0", Offset = "0x69679B0", VA = "0x1869685B0")]
	[BurstCompile]
	private unsafe static void LMPOOPGJAMA([NoAlias] float2* IGIKELHAEGI, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6967A60", Offset = "0x6966E60", VA = "0x186967A60")]
	[BurstCompile]
	private unsafe static void KFBJKAAOPIG([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6963CA0", Offset = "0x69630A0", VA = "0x186963CA0")]
	[BurstCompile]
	private unsafe static void BAKBFHAAGPA([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69674D0", Offset = "0x69668D0", VA = "0x1869674D0")]
	[BurstCompile]
	private unsafe static void IPCEAOLDCGJ([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69675D0", Offset = "0x69669D0", VA = "0x1869675D0")]
	private void IPKFAMLANEI(NativeArray<float4> AJADFDNJCHF, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6967550", Offset = "0x6966950", VA = "0x186967550")]
	[BurstCompile]
	private unsafe static void IPKFAMLANEI([NoAlias] ushort* IJJMOPCPEBF, [In][NoAlias] float4* HDGGFMNGBCM, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6967DB0", Offset = "0x69671B0", VA = "0x186967DB0")]
	[BurstCompile]
	private static ushort LFEBIFFLBID([In] float4 NLJPEJLAKEP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6967920", Offset = "0x6966D20", VA = "0x186967920")]
	private void KDPCLBJEJII(NativeArray<float4> IJJMOPCPEBF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69679F0", Offset = "0x6966DF0", VA = "0x1869679F0")]
	[BurstCompile]
	private unsafe static void KDPCLBJEJII([NoAlias] float4* IJJMOPCPEBF, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6965260", Offset = "0x6964660", VA = "0x186965260")]
	[BurstCompile]
	private unsafe static void FOFMKLIHIGB([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6964A00", Offset = "0x6963E00", VA = "0x186964A00")]
	[BurstCompile]
	private unsafe static void DCIPBLKDOPE([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69694D0", Offset = "0x69688D0", VA = "0x1869694D0")]
	[BurstCompile]
	private unsafe static void OCAKONNKBOK([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6964C50", Offset = "0x6964050", VA = "0x186964C50")]
	[BurstCompile]
	private static void DFAFAODMLCM([Out] float4 LLANANCGECL, ushort LLGJJOLCKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6965780", Offset = "0x6964B80", VA = "0x186965780")]
	private void GGMFDAOFNKK(Allocator EIFDLGAHDFC, NativeArray<float4> FBBKDIECING, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6965B60", Offset = "0x6964F60", VA = "0x186965B60")]
	[BurstCompile]
	private unsafe static void GGMFDAOFNKK([NoAlias] float4* JIIBJCPGJNH, [NoAlias] byte* KGMDHHPOKOE, [Out] int NACENBIGMAH, [Out] int LGHOGKEFPOK, [NoAlias] float4* FBBKDIECING, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69690E0", Offset = "0x69684E0", VA = "0x1869690E0")]
	private static void NICIEDDPGGD(NativeArray<float4> FMHCALKFGNP, NativeArray<DNDEBEJCNIE> OJNDDLHKGHK, NativeArray<byte> ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6969060", Offset = "0x6968460", VA = "0x186969060")]
	[BurstCompile]
	private unsafe static void NICIEDDPGGD([NoAlias] float4* FMHCALKFGNP, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6966130", Offset = "0x6965530", VA = "0x186966130")]
	[BurstCompile]
	private unsafe static void HDEBOJMBLIP([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69676C0", Offset = "0x6966AC0", VA = "0x1869676C0")]
	[BurstCompile]
	private unsafe static void JDAKACFCAFK([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6967BC0", Offset = "0x6966FC0", VA = "0x186967BC0")]
	[BurstCompile]
	private unsafe static void KLFALFMBCAC([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6967AE0", Offset = "0x6966EE0", VA = "0x186967AE0")]
	private void KGBKOELGHAP(Allocator EIFDLGAHDFC, NativeArray<int> EAPLABBFKML, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69691F0", Offset = "0x69685F0", VA = "0x1869691F0")]
	private static NativeArray<byte> NLBONEMAMAI(Allocator EIFDLGAHDFC, NativeArray<int> EAPLABBFKML, int JNLMCGCLFJC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6969460", Offset = "0x6968860", VA = "0x186969460")]
	[BurstCompile]
	private unsafe static int NLBONEMAMAI([NoAlias] byte* LPEADGMFEHC, [In][NoAlias] int* EAPLABBFKML, int JNLMCGCLFJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6963930", Offset = "0x6962D30", VA = "0x186963930")]
	private static void ADNOFPDFNAK(NativeArray<int> CDNOCJAMBFH, NativeArray<byte> CEOMDJEJBPJ, int KJADDLBDLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69638C0", Offset = "0x6962CC0", VA = "0x1869638C0")]
	[BurstCompile]
	private unsafe static void ADNOFPDFNAK([NoAlias] int* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6963C30", Offset = "0x6963030", VA = "0x186963C30")]
	[BurstCompile]
	private unsafe static void BADNANOAPGL([NoAlias] ushort* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6963EE0", Offset = "0x69632E0", VA = "0x186963EE0")]
	[BurstCompile]
	private static void BHJILGFEFLE([Out] float3 JKIMLGEFEHK, ushort LLGJJOLCKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6965570", Offset = "0x6964970", VA = "0x186965570")]
	[BurstCompile]
	private static ushort GGCOIMCNDAB([In] float3 NLJPEJLAKEP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public IJIPMMOPBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6957050", Offset = "0x6956450", VA = "0x186957050")]
	[BurstCompile]
	public unsafe static void FAJDPGEGDCF([NoAlias] float3* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6968730", Offset = "0x6967B30", VA = "0x186968730")]
	[BurstCompile]
	public unsafe static void MCADPHEKIDJ([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69650E0", Offset = "0x69644E0", VA = "0x1869650E0")]
	[BurstCompile]
	public unsafe static void ELCMKPJFDOD([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6968860", Offset = "0x6967C60", VA = "0x186968860")]
	[BurstCompile]
	public unsafe static void MLLLDLHFPBJ([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GFNMEBPHFFI, int AKKCHCGDDPD, [In] float3 LLPBCMDPCBM, [In] float3 HIGEBIIBOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6957500", Offset = "0x6956900", VA = "0x186957500")]
	[BurstCompile]
	public unsafe static void JCKNMIOAAKM([NoAlias] ushort* JHPFENMHHDM, [Out] float3 ANEHAEJNMKP, [Out] float3 HIGEBIIBOPL, [In][NoAlias] float3* GFNMEBPHFFI, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69572A0", Offset = "0x69566A0", VA = "0x1869572A0")]
	[BurstCompile]
	public unsafe static void FNBBAFMGBDN([NoAlias] ushort* HIOBGKHMDAD, [In][NoAlias] float3* GDIFIALFJDP, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6963D20", Offset = "0x6963120", VA = "0x186963D20")]
	[BurstCompile]
	public unsafe static void BBHNGNEAPMP([NoAlias] float3* NFNKIGHBNIL, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x69567D0", Offset = "0x6955BD0", VA = "0x1869567D0")]
	[BurstCompile]
	public unsafe static void ADBDHFJLBOJ([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6969660", Offset = "0x6968A60", VA = "0x186969660")]
	[BurstCompile]
	public unsafe static void PACEGGNHJCI([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6966020", Offset = "0x6965420", VA = "0x186966020")]
	[BurstCompile]
	public unsafe static void HCELIOEAHAG([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* GDIFIALFJDP, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6956A10", Offset = "0x6955E10", VA = "0x186956A10")]
	[BurstCompile]
	public unsafe static void CDJIEHIEMOF([NoAlias] ushort* IGIKELHAEGI, [Out] float2 IFAGLHPHFAD, [Out] float2 LOHDJBCGIAI, [In][NoAlias] float2* MFKEKAPJOFL, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69684E0", Offset = "0x69678E0", VA = "0x1869684E0")]
	[BurstCompile]
	public static void LJGFOLMPHKM([Out] float2 JKIMLGEFEHK, ushort LLGJJOLCKKL, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69689A0", Offset = "0x6967DA0", VA = "0x1869689A0")]
	[BurstCompile]
	public unsafe static void MNJAADCNOBG([NoAlias] float2* IGIKELHAEGI, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6965480", Offset = "0x6964880", VA = "0x186965480")]
	[BurstCompile]
	public unsafe static void FOJEAJCLNEP([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6964FE0", Offset = "0x69643E0", VA = "0x186964FE0")]
	[BurstCompile]
	public unsafe static void EFMIFEOOMAH([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6963F40", Offset = "0x6963340", VA = "0x186963F40")]
	[BurstCompile]
	public unsafe static void BMMMFGHPBOI([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [NoAlias] ushort* MFKEKAPJOFL, int AKKCHCGDDPD, [In] float2 CKDFGIFMAJI, [In] float2 LOHDJBCGIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6963DC0", Offset = "0x69631C0", VA = "0x186963DC0")]
	[BurstCompile]
	public unsafe static void BCGHHNABONH([NoAlias] ushort* IJJMOPCPEBF, [In][NoAlias] float4* HDGGFMNGBCM, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6967CE0", Offset = "0x69670E0", VA = "0x186967CE0")]
	[BurstCompile]
	public static ushort LALCNPFKFGB([In] float4 NLJPEJLAKEP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6963820", Offset = "0x6962C20", VA = "0x186963820")]
	[BurstCompile]
	public unsafe static void ACIAINIKMAO([NoAlias] float4* IJJMOPCPEBF, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69578E0", Offset = "0x6956CE0", VA = "0x1869578E0")]
	[BurstCompile]
	public unsafe static void OPAKCAPBAGO([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6964E30", Offset = "0x6964230", VA = "0x186964E30")]
	[BurstCompile]
	public unsafe static void DJPBIEKGNOO([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6963AA0", Offset = "0x6962EA0", VA = "0x186963AA0")]
	[BurstCompile]
	public unsafe static void AJNDEPFCCLA([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] ushort* AJADFDNJCHF, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69651A0", Offset = "0x69645A0", VA = "0x1869651A0")]
	[BurstCompile]
	public static void ELONNLIMECJ([Out] float4 LLANANCGECL, ushort LLGJJOLCKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6956E90", Offset = "0x6956290", VA = "0x186956E90")]
	[BurstCompile]
	public unsafe static void EHFHPCDIFLI([NoAlias] float4* JIIBJCPGJNH, [NoAlias] byte* KGMDHHPOKOE, [Out] int NACENBIGMAH, [Out] int LGHOGKEFPOK, [NoAlias] float4* FBBKDIECING, int GAHEJGOIIHM, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6965EE0", Offset = "0x69652E0", VA = "0x186965EE0")]
	[BurstCompile]
	public unsafe static void GODBJLDBKIA([NoAlias] float4* FMHCALKFGNP, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6964A70", Offset = "0x6963E70", VA = "0x186964A70")]
	[BurstCompile]
	public unsafe static void DCKEKAAODIL([NoAlias] AGIFCHBLDPN.OMPGEBLLCFC* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6967740", Offset = "0x6966B40", VA = "0x186967740")]
	[BurstCompile]
	public unsafe static void JKGPECPAAFF([NoAlias] AGIFCHBLDPN.OAGIHFMAMCE* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6964360", Offset = "0x6963760", VA = "0x186964360")]
	[BurstCompile]
	public unsafe static void CFDPJEELLJL([NoAlias] AGIFCHBLDPN.AOGFIHMJJCH* JHPFENMHHDM, [In][NoAlias] DNDEBEJCNIE* OJNDDLHKGHK, [In][NoAlias] byte* ACMJKFMOHHE, int AKKCHCGDDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6964260", Offset = "0x6963660", VA = "0x186964260")]
	[BurstCompile]
	public unsafe static int CCOLMOMEIHA([NoAlias] byte* LPEADGMFEHC, [In][NoAlias] int* EAPLABBFKML, int JNLMCGCLFJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6963A00", Offset = "0x6962E00", VA = "0x186963A00")]
	[BurstCompile]
	public unsafe static void AFLDACEGOCG([NoAlias] int* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6967C40", Offset = "0x6967040", VA = "0x186967C40")]
	[BurstCompile]
	public unsafe static void KOLKJLHPNEF([NoAlias] ushort* CDNOCJAMBFH, [In][NoAlias] byte* CEOMDJEJBPJ, int KJADDLBDLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6964120", Offset = "0x6963520", VA = "0x186964120")]
	[BurstCompile]
	public static void CBHCHOLHALE([Out] float3 JKIMLGEFEHK, ushort LLGJJOLCKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6956CD0", Offset = "0x69560D0", VA = "0x186956CD0")]
	[BurstCompile]
	public static ushort CMCFONNDLBG([In] float3 NLJPEJLAKEP)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MCLMPIKOMCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float2 KGLBMPMHJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float2 APLKKOFGKEG;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class HFEIAEOMDDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<MCLMPIKOMCJ> OIPJEPDDDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> CFNHFOLEFMF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GLEMFOKAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EJGCOECJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84D8E0", Offset = "0x84CCE0", VA = "0x18084D8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6961D30", Offset = "0x6961130", VA = "0x186961D30")]
	public HFEIAEOMDDD(int NEAMGOHHBGB, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6961BF0", Offset = "0x6960FF0", VA = "0x186961BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6961C50", Offset = "0x6961050", VA = "0x186961C50")]
	public void GAGCAMMLDDC(HFEIAEOMDDD HOMGGMLEFOD, int PJKHAHOFAJG, int OCDCDAOIAHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OGIIABKANDN
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static HFEIAEOMDDD DLDGKMKEHPI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static NativeList<LHLEFIKFIFF> DPAMMCOICLM;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static int[] PLHGEGPKDCH;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool JNCNOIINGKP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static Dictionary<int, HFEIAEOMDDD> LJIEGHBDECH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Dictionary<int, HFEIAEOMDDD> IDODDPFMMLD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool FHKPBIMMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6971770", Offset = "0x6970B70", VA = "0x186971770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<LHLEFIKFIFF> MONDEEMJBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6971200", Offset = "0x6970600", VA = "0x186971200")]
		get
		{
			return default(NativeList<LHLEFIKFIFF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static HFEIAEOMDDD BHFBEJGNDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6971CC0", Offset = "0x69710C0", VA = "0x186971CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6971EB0", Offset = "0x69712B0", VA = "0x186971EB0")]
	private static void NGAIGJAAMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6971E60", Offset = "0x6971260", VA = "0x186971E60")]
	public static int MGMDEOHLMPL(bool EAJGNDPNDEJ, int KCAGMGMGHEB, bool GOBNIHGCCJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6971E90", Offset = "0x6971290", VA = "0x186971E90")]
	private static int MOAADFGHJHK(int KCAGMGMGHEB, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x69716D0", Offset = "0x6970AD0", VA = "0x1869716D0")]
	private static int FNHNAMOKNDJ(int KCAGMGMGHEB, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x69718F0", Offset = "0x6970CF0", VA = "0x1869718F0")]
	public static int JEPBBNALGCC(int DDIIAJHFBBE, int KCAGMGMGHEB, int NJONPMMNFGF, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6971860", Offset = "0x6970C60", VA = "0x186971860")]
	public static int IMOOOMFFIMK(int DDIIAJHFBBE, int KCAGMGMGHEB, int NJONPMMNFGF, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x69710E0", Offset = "0x69704E0", VA = "0x1869710E0")]
	public static int AJGIGPKNMEK(int NJONPMMNFGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6971D60", Offset = "0x6971160", VA = "0x186971D60")]
	private static int LNJMLAGGNIF(int KCAGMGMGHEB, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x69716B0", Offset = "0x6970AB0", VA = "0x1869716B0")]
	private static int EIKKGDAFNMB(int KCAGMGMGHEB, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x69717F0", Offset = "0x6970BF0", VA = "0x1869717F0")]
	public static int HKIIDICNKMJ(int DDIIAJHFBBE, int KCAGMGMGHEB, int NJONPMMNFGF, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69716E0", Offset = "0x6970AE0", VA = "0x1869716E0")]
	public static int GKKAIIDHDNP(int DDIIAJHFBBE, int KCAGMGMGHEB, int NJONPMMNFGF, bool AKEDDIFGCDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x69711E0", Offset = "0x69705E0", VA = "0x1869711E0")]
	public static int BHCLMLGAHNO(int NJONPMMNFGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x69710F0", Offset = "0x69704F0", VA = "0x1869710F0")]
	public static HFEIAEOMDDD BHCKDNIENED(int KCAGMGMGHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6972500", Offset = "0x6971900", VA = "0x186972500")]
	private static HFEIAEOMDDD NJFKJNJJHOC(int KCAGMGMGHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6971D70", Offset = "0x6971170", VA = "0x186971D70")]
	public static HFEIAEOMDDD MFGCKKBJLCN(int KCAGMGMGHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6971980", Offset = "0x6970D80", VA = "0x186971980")]
	private static HFEIAEOMDDD KBKIINGAPHF(int KCAGMGMGHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x69712A0", Offset = "0x69706A0", VA = "0x1869712A0")]
	public static void EGPPFONICEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HEAMBEBCGBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int HEOINEPLJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 HCJCHHJIAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public quaternion NNFGMJPLIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float OMLNEKDBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float JHNGAGKLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int KEAFBLNCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int NNFOKMMOCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int CCKLGMMGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool PABMOANCJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool FKBJENLJLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float CNPPJMLFBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 FKGGDNDPHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool AGGDMOHHBEG;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct NEIBEJPBCPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int EPNMPNBDJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int KEHHGMONOAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HHHCDBIAJNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<HEAMBEBCGBO> CFNCLKJEBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeArray<CKPHKFFGLGA> AGIDHJIIELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeArray<LHLEFIKFIFF> OBEKEJCLMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeArray<NEIBEJPBCPE> PHEGGGDIBEF;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6961EE0", Offset = "0x69612E0", VA = "0x186961EE0")]
	public HHHCDBIAJNM(NativeArray<CKPHKFFGLGA> AGIDHJIIELE, int CGDIEJGGJMK = 1, Allocator EIFDLGAHDFC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6961DF0", Offset = "0x69611F0", VA = "0x186961DF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[BurstCompile]
public struct CMECPBHDCGM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	private NativeArray<MCLMPIKOMCJ> NHKHKCKEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	private NativeArray<int> ONHECLHNHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[ReadOnly]
	private NativeList<LHLEFIKFIFF> POLHIKILCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	private NativeList<HEAMBEBCGBO> CFNCLKJEBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	private NativeArray<CKPHKFFGLGA> AGIDHJIIELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[ReadOnly]
	private NativeArray<LHLEFIKFIFF> OBEKEJCLMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<NEIBEJPBCPE> PHEGGGDIBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	private int JDBLIKLMOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ReadOnly]
	private int LACFDHBDNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ReadOnly]
	private float3 MGDJKIIGICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[ReadOnly]
	private quaternion LEJPPLHEOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[ReadOnly]
	private float3 PFLINGJLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MCFDCALAOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ICMFHGNJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CJLNHKLFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AHIFHMFMHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FAIECJHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OCNIEBOFGKL;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x695C950", Offset = "0x695BD50", VA = "0x18695C950")]
	public CMECPBHDCGM(MAFKMJEPOIF BPOAFKFPBNI, AGIFCHBLDPN LECPDGPKFAL, float3 CBMFFECHHFM, quaternion PIAGNLFMBCM, float GCFKOLJNJBH, int AODJMMIBHAA = 0, int LJFLLIIANNH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x695CBE0", Offset = "0x695BFE0", VA = "0x18695CBE0")]
	public CMECPBHDCGM(HHHCDBIAJNM BPOAFKFPBNI, AGIFCHBLDPN LECPDGPKFAL, float3 CBMFFECHHFM, quaternion PIAGNLFMBCM, float3 GCFKOLJNJBH, int AODJMMIBHAA = 0, int LJFLLIIANNH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x695A9D0", Offset = "0x6959DD0", VA = "0x18695A9D0")]
	private float3 DFAHMFBNJGG(float3 IEOMLIMFCHM, Matrix4x4 KOOPMGADIDF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x695C750", Offset = "0x695BB50", VA = "0x18695C750")]
	private float3x3 IKHGPGKDMIO(float3x3 JDOODPLHHBB, float3x3 EMOBLCILIPM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x695C940", Offset = "0x695BD40", VA = "0x18695C940")]
	private float NBOHKJIBBNI(float MFGJMFBCPKM, float OIFNKGAGODH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x695AB00", Offset = "0x6959F00", VA = "0x18695AB00", Slot = "4")]
	public void Execute(int NIMLCNCKAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x695C7D0", Offset = "0x695BBD0", VA = "0x18695C7D0")]
	private void JNDCHKIKFCM(int HAJPFIEGCJJ, float3 HBGADHMDPAD, float3 EKOLOLBNIGP, float3 GOFLBGENOOE, float JHKMHGJCHGK, bool ALDDJLEPCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x695BCA0", Offset = "0x695B0A0", VA = "0x18695BCA0")]
	private void FPGJAKIEAEL(HEAMBEBCGBO GAJHBJJEFLP, float3 DHLCOAONPFN, float3x3 JMBDPCHIGAH, float MFGJMFBCPKM, int MCDIJLGEOPE, int KPEELNGONPJ, int AKNHCIMMAEL, float LHMNLCMOFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x695C100", Offset = "0x695B500", VA = "0x18695C100")]
	private void IHIDCLGBKIE(int HAJPFIEGCJJ, int MBIGLNKMAFC, HEAMBEBCGBO GAJHBJJEFLP, float3 DHLCOAONPFN, float3x3 JMBDPCHIGAH, bool FFEIOEHPHDP, float MFGJMFBCPKM, int OJDIIODBFAF, int PKALAHFGJDF, int AKNHCIMMAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct DLKOAOFCNIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public NativeList<JAJLKEBNELI> GNHMKNJHDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NativeList<LHLEFIKFIFF> NMKNJIGOIFD;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x695E800", Offset = "0x695DC00", VA = "0x18695E800")]
	public DLKOAOFCNIK(int CGDIEJGGJMK, Allocator EIFDLGAHDFC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x695E760", Offset = "0x695DB60", VA = "0x18695E760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
public struct BPGICFENEGP : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private enum MIAJEJEHGLL
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
	private NativeList<float3> EGKEPFIHFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<float3> EOGECKBCLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeList<int> BLGFPGFNALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	private NativeArray<int> IKFHOACMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private NativeArray<float4> LGFFKKEKDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private NativeArray<float4> MCLEPJHBMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private NativeArray<float4> KBJFEBJBJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private NativeList<float3> FLLBHHCEFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private NativeList<LHLEFIKFIFF> KBDPHMPAEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[ReadOnly]
	private NativeList<JAJLKEBNELI> GNHMKNJHDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	private NativeList<LHLEFIKFIFF> NMKNJIGOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[ReadOnly]
	private int JDBLIKLMOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ReadOnly]
	private int LACFDHBDNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MCFDCALAOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ICMFHGNJIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CJLNHKLFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AHIFHMFMHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FAIECJHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OCNIEBOFGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private float3 PFLINGJLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private quaternion LEJPPLHEOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private float3 MGDJKIIGICO;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6959DF0", Offset = "0x69591F0", VA = "0x186959DF0")]
	public BPGICFENEGP(MAFKMJEPOIF BPOAFKFPBNI, AGIFCHBLDPN LECPDGPKFAL, float3 CBMFFECHHFM, quaternion PIAGNLFMBCM, float GCFKOLJNJBH, int AODJMMIBHAA = 0, int LJFLLIIANNH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6959C00", Offset = "0x6959000", VA = "0x186959C00")]
	public BPGICFENEGP(DLKOAOFCNIK LDNEPNAGEGN, AGIFCHBLDPN LECPDGPKFAL, float3 CBMFFECHHFM, quaternion PIAGNLFMBCM, float3 GCFKOLJNJBH, int AODJMMIBHAA = 0, int LJFLLIIANNH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6958860", Offset = "0x6957C60", VA = "0x186958860", Slot = "4")]
	public void Execute(int NIMLCNCKAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x69597C0", Offset = "0x6958BC0", VA = "0x1869597C0")]
	private void GECKCFFAFEA(float4x4 LODGBKANAFG, int NIMLCNCKAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x69587F0", Offset = "0x6957BF0", VA = "0x1869587F0")]
	private MIAJEJEHGLL AEGACHCCEIH(float3 EKOLOLBNIGP)
	{
		return default(MIAJEJEHGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6959BB0", Offset = "0x6958FB0", VA = "0x186959BB0")]
	private float4 LPPIJOFAMBF(MIAJEJEHGLL NPGOLNEELKL, int AGAGKNBDCIG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6959B70", Offset = "0x6958F70", VA = "0x186959B70")]
	private float2 KGFIHMHFMBL(MIAJEJEHGLL NPGOLNEELKL, float3 HBGADHMDPAD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct GOALGAAPFMD
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum GOOLLANCKBL
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static GOALGAAPFMD ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 DJODFMOGEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float3x3 NFFIALOEONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float3 MBPNHHIKNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public GOOLLANCKBL CJOIENFDBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float3 KKANEFEDFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 CCLKPOHJCOI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MDFNJNDPCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6960BA0", Offset = "0x695FFA0", VA = "0x186960BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 MNKMFOOAAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6960D60", Offset = "0x6960160", VA = "0x186960D60")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6961530", Offset = "0x6960930", VA = "0x186961530")]
	public GOALGAAPFMD(float3 HBGADHMDPAD, quaternion MGJIDJKDGAB, float3 CGDIEJGGJMK, GOOLLANCKBL EPPKBKJHHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x69611D0", Offset = "0x69605D0", VA = "0x1869611D0")]
	public float INIBBJHAHMN(float3 DHLCOAONPFN, float EEEGBCEHCPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x69613D0", Offset = "0x69607D0", VA = "0x1869613D0")]
	public bool OFDJCMMHEEJ(float3 EKOLOLBNIGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6960BB0", Offset = "0x695FFB0", VA = "0x186960BB0")]
	public void EENCEOOBJDM(float3 MMMOFBEHKHH, float3x3 CFBCMIKIGOJ, float PBPLCHGMJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6960E40", Offset = "0x6960240", VA = "0x186960E40")]
	private void GMGFLHFJAAE(float3 LNCAKBGPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6960F40", Offset = "0x6960340", VA = "0x186960F40")]
	public void HHKKGAMFMNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
public struct GAOJCKCFPCA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private NativeList<GOALGAAPFMD> LDNEPNAGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private NativeList<float3> IHIMHEHBKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[ReadOnly]
	private NativeList<int> PBOEIEKIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NLDEAABGKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[ReadOnly]
	private NativeList<LHLEFIKFIFF> NMKNJIGOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ReadOnly]
	private int GIDONMHGJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ReadOnly]
	private int EAIOJKBMEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ReadOnly]
	private float EEEGBCEHCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ReadOnly]
	private float BOLGOHFOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MIGHFHGCMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NCGPEEEGHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> GKPHLNHHHGE;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x69605B0", Offset = "0x695F9B0", VA = "0x1869605B0")]
	public GAOJCKCFPCA(AGIFCHBLDPN GFKLPJBCEPF, float PDJLDKDACJK, int OCDCDAOIAHP, int MCDIJLGEOPE, NativeList<GOALGAAPFMD> LDNEPNAGEGN, NativeArray<int> NLDEAABGKIL, NativeList<LHLEFIKFIFF> NMKNJIGOIFD, CILABMCHBMA NFNCPILNBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x695FE70", Offset = "0x695F270", VA = "0x18695FE70", Slot = "4")]
	public void Execute(int NMFCMOHELBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x695FB10", Offset = "0x695EF10", VA = "0x18695FB10")]
	private bool DKAOJBABJEL(GOALGAAPFMD DKLJHPKNDLA, GOALGAAPFMD EALBLGNMNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x695FBD0", Offset = "0x695EFD0", VA = "0x18695FBD0")]
	private bool DPFJJOPPNHD(GOALGAAPFMD EFBOINOKFAK, int BGADPNEJPBE, int IONBNHHHHBM, int CIMCMAHEMHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class CILABMCHBMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeArray<bool> CJKIHMECOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeArray<int> EGIINBJNIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public NativeArray<bool> OHPKNHNKNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public NativeArray<float> OOLOIGAJMFD;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x695A7A0", Offset = "0x6959BA0", VA = "0x18695A7A0")]
	public void GOBPIALLIIA(int NEAMGOHHBGB, int EFLEFHDHJNC, Allocator EIFDLGAHDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x695A9B0", Offset = "0x6959DB0", VA = "0x18695A9B0")]
	public static long JONMLCBAMLJ(int NEAMGOHHBGB, int EFLEFHDHJNC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x695A6B0", Offset = "0x6959AB0", VA = "0x18695A6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x695A8C0", Offset = "0x6959CC0", VA = "0x18695A8C0")]
	public void HGGBIMJODNJ(JobHandle DBNLEGDAPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public CILABMCHBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BurstCompile]
public struct EANABNHBPEG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeList<float3> IHIMHEHBKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<float3> EEAPKKFGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<float4> JACEJAPODNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<float2> AKNHCBMIGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeList<int> PBOEIEKIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AAPLLALEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeArray<int> OBIPNPGNAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private NativeArray<bool> MIGHFHGCMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private NativeArray<bool> NCGPEEEGHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private int AODJMMIBHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	private int LJFLLIIANNH;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x695ED30", Offset = "0x695E130", VA = "0x18695ED30")]
	public EANABNHBPEG(AGIFCHBLDPN GFKLPJBCEPF, CILABMCHBMA NFNCPILNBLH, int LJFLLIIANNH = 0, int AODJMMIBHAA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x695E950", Offset = "0x695DD50", VA = "0x18695E950", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x695E8F0", Offset = "0x695DCF0", VA = "0x18695E8F0")]
	private void EHJIAJHENAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class HNABINLKKKM
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E250", Offset = "0x2B7D650", VA = "0x182B7E250")]
	public static bool EDOAGCGLPCA<T>(NativeArray<T> ELFCOFFIPBP, int CGDIEJGGJMK, Allocator EIFDLGAHDFC, NativeArrayOptions ANGMLGCFELB = NativeArrayOptions.ClearMemory, int KLIJCGOMAFE = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E310", Offset = "0x2B7D710", VA = "0x182B7E310")]
	public static bool EDOAGCGLPCA<T>(NativeList<T> EGGGJKKPDIP, int CGDIEJGGJMK, Allocator EIFDLGAHDFC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HGFHPCOBBNK
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
public interface MHOPGKFJMAL
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PKGEGPGBNGG(HGFHPCOBBNK DDIIAJHFBBE);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BPKFFAMBFEB(HGFHPCOBBNK DDIIAJHFBBE);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds HMECCAINCJF();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float LPEELCFOFID();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPLCMNPPKIC(HGFHPCOBBNK DDIIAJHFBBE, MAFKMJEPOIF IGCJCAEEHNP, int GFCJLGBPMAF = -1);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BurstCompile]
public class AGIFCHBLDPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum EFOGHNOBDIO
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
	public struct FEBMNIHJMAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public EFOGHNOBDIO DNDIAOIJGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public bool JLKENGABNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int LGHHDAMPCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public VertexAttributeDescriptor[] BNNODKNMIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[BurstCompile]
	public struct EMAOLHKJANB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float3 HBGADHMDPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float3 EKOLOLBNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public float4 GOFLBGENOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float2 FNFNNCOFLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float4 JACEJAPODNA;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly VertexAttributeDescriptor[] BNNODKNMIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[BurstCompile]
	public struct OMPGEBLLCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float3 HBGADHMDPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public half4 EKOLOLBNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public half4 GOFLBGENOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float2 FNFNNCOFLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public half4 JACEJAPODNA;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly VertexAttributeDescriptor[] BNNODKNMIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[BurstCompile]
	public struct CJKEEDEPGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float3 HBGADHMDPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public half4 EKOLOLBNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public half4 GOFLBGENOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public float2 FNFNNCOFLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public uint JACEJAPODNA;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly VertexAttributeDescriptor[] BNNODKNMIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct OAGIHFMAMCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float3 HBGADHMDPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public uint EKOLOLBNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public uint GOFLBGENOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float2 FNFNNCOFLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public half4 JACEJAPODNA;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly VertexAttributeDescriptor[] BNNODKNMIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct AOGFIHMJJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float3 HBGADHMDPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public uint EKOLOLBNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint GOFLBGENOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public half2 FNFNNCOFLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public half4 JACEJAPODNA;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VertexAttributeDescriptor[] BNNODKNMIMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate int GHDDLKIIKNN(float PCHHOKEGOFA);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal static class JGDJBIIINEL
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x697CE90", Offset = "0x697C290", VA = "0x18697CE90")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x697CD30", Offset = "0x697C130", VA = "0x18697CD30")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x697D230", Offset = "0x697C630", VA = "0x18697D230")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x697CFC0", Offset = "0x697C3C0", VA = "0x18697CFC0")]
		public static int KGLFFAEFCMK(float PCHHOKEGOFA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate uint AMFAOONPIBC([In] float4 LMJDILMPEPB);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class CBGFPHLFOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x697B720", Offset = "0x697AB20", VA = "0x18697B720")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x697B5C0", Offset = "0x697A9C0", VA = "0x18697B5C0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x697BB90", Offset = "0x697AF90", VA = "0x18697BB90")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x697B850", Offset = "0x697AC50", VA = "0x18697B850")]
		public static uint KGLFFAEFCMK([In] float4 LMJDILMPEPB)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate uint HBJNDOHNLHB([In] float3 LMJDILMPEPB);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class OOHHOGLPNJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x698AEA0", Offset = "0x698A2A0", VA = "0x18698AEA0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x698AD40", Offset = "0x698A140", VA = "0x18698AD40")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x698B250", Offset = "0x698A650", VA = "0x18698B250")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x698AFD0", Offset = "0x698A3D0", VA = "0x18698AFD0")]
		public static uint KGLFFAEFCMK([In] float3 LMJDILMPEPB)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public unsafe delegate void PICLLEAONDA([NoAlias] OAGIHFMAMCE* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class BLCBCNFFKAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x697B1A0", Offset = "0x697A5A0", VA = "0x18697B1A0")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x697B040", Offset = "0x697A440", VA = "0x18697B040")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x697B510", Offset = "0x697A910", VA = "0x18697B510")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x697B2D0", Offset = "0x697A6D0", VA = "0x18697B2D0")]
		public unsafe static void KGLFFAEFCMK([NoAlias] OAGIHFMAMCE* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void PJMFNHEGGLB([NoAlias] AOGFIHMJJCH* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class JDKHNKPJGHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x697C910", Offset = "0x697BD10", VA = "0x18697C910")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x697C7B0", Offset = "0x697BBB0", VA = "0x18697C7B0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x697CC80", Offset = "0x697C080", VA = "0x18697CC80")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x697CA40", Offset = "0x697BE40", VA = "0x18697CA40")]
		public unsafe static void KGLFFAEFCMK([NoAlias] AOGFIHMJJCH* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const int MMCMOJKMHNL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NativeList<float3> HMPMIOEPMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public NativeArray<float3> MJGNHOCKGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public NativeArray<float4> MIOCFDLPGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public NativeArray<float4> BFKINJIFJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public NativeArray<float2> PPIPCMJNABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public NativeList<int> FKJCOMCBNCO;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly VertexAttributeDescriptor[][] AOCNPHLFOJA;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static bool DAJPPNOECHM;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static FEBMNIHJMAL[] DCIKOJOMPHN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6977870", Offset = "0x6976C70", VA = "0x186977870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GLEMFOKAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6979010", Offset = "0x6978410", VA = "0x186979010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EJGCOECJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6977740", Offset = "0x6976B40", VA = "0x186977740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JOMLJAJAIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69755C0", Offset = "0x69749C0", VA = "0x1869755C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void BJGDDGKOAIJ(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void JODIPHEDAAI(bool DHKICBLCKBN, string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6975600", Offset = "0x6974A00", VA = "0x186975600", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6976D40", Offset = "0x6976140", VA = "0x186976D40")]
	public void GOBPIALLIIA(int NEAMGOHHBGB, int EFLEFHDHJNC, Allocator EIFDLGAHDFC, bool GACGNFAODNF, bool NABLBCNGEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6977000", Offset = "0x6976400", VA = "0x186977000")]
	public void IEHOGPBJDCD(int NEAMGOHHBGB, int EFLEFHDHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x69789D0", Offset = "0x6977DD0", VA = "0x1869789D0", Slot = "6")]
	public bool LOKIAAAFJBG(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6977FB0", Offset = "0x69773B0", VA = "0x186977FB0")]
	public bool LFEPOMHGMGO(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x69778B0", Offset = "0x6976CB0", VA = "0x1869778B0")]
	public bool JNHGHGAPFLE(Mesh GFKLPJBCEPF, AGIFCHBLDPN BMHNADABJAA, bool CGIHFEBKBIF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x69796B0", Offset = "0x6978AB0", VA = "0x1869796B0")]
	public void PALFFBLNBIE(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69758A0", Offset = "0x6974CA0", VA = "0x1869758A0")]
	public void FGADDLGAAAO(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x69777D0", Offset = "0x6976BD0", VA = "0x1869777D0")]
	[BurstCompile]
	public static int JJEEKJJHOGD(float PCHHOKEGOFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6977820", Offset = "0x6976C20", VA = "0x186977820")]
	[BurstCompile]
	public static uint JJEEKJJHOGD([In] float4 LMJDILMPEPB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6977780", Offset = "0x6976B80", VA = "0x186977780")]
	[BurstCompile]
	public static uint JJEEKJJHOGD([In] float3 LMJDILMPEPB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6978390", Offset = "0x6977790", VA = "0x186978390")]
	public void LGNJKGIMLBD(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x69776C0", Offset = "0x6976AC0", VA = "0x1869776C0")]
	[BurstCompile]
	private unsafe static void ILAAAKOMPHG([NoAlias] OAGIHFMAMCE* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6977080", Offset = "0x6976480", VA = "0x186977080")]
	public void IIHLAGEKHPK(Mesh GFKLPJBCEPF, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6976770", Offset = "0x6975B70", VA = "0x186976770")]
	[BurstCompile]
	private unsafe static void FODOJLIPDMA([NoAlias] AOGFIHMJJCH* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x69754D0", Offset = "0x69748D0", VA = "0x1869754D0")]
	public void CIEMALICNPD(Mesh GFKLPJBCEPF, EFOGHNOBDIO DNDIAOIJGOO, bool CGIHFEBKBIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6976AD0", Offset = "0x6975ED0", VA = "0x186976AD0")]
	public void GAGCAMMLDDC(AGIFCHBLDPN GFKLPJBCEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x69789E0", Offset = "0x6977DE0", VA = "0x1869789E0")]
	public AGIFCHBLDPN MFEBHLHMDPE(Allocator EIFDLGAHDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6975770", Offset = "0x6974B70", VA = "0x186975770")]
	public long EAPCLLMOOHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6975710", Offset = "0x6974B10", VA = "0x186975710")]
	public static long EAPCLLMOOHC(int NAOPGFKNDML, int HBIMEEGDGPH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6978EB0", Offset = "0x69782B0", VA = "0x186978EB0")]
	public static long MIBGHCKMDNF(int NAOPGFKNDML, int HBIMEEGDGPH, EFOGHNOBDIO DNDIAOIJGOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6978F50", Offset = "0x6978350", VA = "0x186978F50")]
	public long MIBGHCKMDNF(EFOGHNOBDIO DNDIAOIJGOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6977F50", Offset = "0x6977350", VA = "0x186977F50")]
	public void LAECGEKJCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6978B20", Offset = "0x6977F20", VA = "0x186978B20")]
	public static void MGDNIGGEFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6979050", Offset = "0x6978450", VA = "0x186979050")]
	public EFOGHNOBDIO OAHBEGJGGLP()
	{
		return default(EFOGHNOBDIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6976F30", Offset = "0x6976330", VA = "0x186976F30")]
	public static (int, int) HEAILEANKNN(Mesh GFKLPJBCEPF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x697A4B0", Offset = "0x69798B0", VA = "0x18697A4B0")]
	public static int PJNJGLKCPDI(VertexAttributeDescriptor[] EMFKOLLFNHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6977EE0", Offset = "0x69772E0", VA = "0x186977EE0")]
	public static long KKGJNHCAHAJ(Mesh GFKLPJBCEPF, int IIEKHEHECNC, int LAEEODCBNNL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public AGIFCHBLDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6976980", Offset = "0x6975D80", VA = "0x186976980")]
	[BurstCompile]
	public static int FOIPJFMKKII(float PCHHOKEGOFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x69767F0", Offset = "0x6975BF0", VA = "0x1869767F0")]
	[BurstCompile]
	public static uint FOIPJFMKKII([In] float4 LMJDILMPEPB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6976A20", Offset = "0x6975E20", VA = "0x186976A20")]
	[BurstCompile]
	public static uint FOIPJFMKKII([In] float3 LMJDILMPEPB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x697A100", Offset = "0x6979500", VA = "0x18697A100")]
	[BurstCompile]
	public unsafe static void PIEIMCAFFJK([NoAlias] OAGIHFMAMCE* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6976320", Offset = "0x6975720", VA = "0x186976320")]
	[BurstCompile]
	public unsafe static void FNHFJBLOCJF([NoAlias] AOGFIHMJJCH* JHPFENMHHDM, int AKKCHCGDDPD, [In][NoAlias] float3* CHBHKICBDCA, [In][NoAlias] float3* EEAPKKFGPAF, [In][NoAlias] float4* AAPLLALEIMN, [In][NoAlias] float2* AKNHCBMIGIG, [In][NoAlias] float4* JACEJAPODNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class EBMAJINMFPL
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x697BDF0", Offset = "0x697B1F0", VA = "0x18697BDF0")]
	public static void EGPPFONICEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class NICEIHIECLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public NativeList<float3> HMPMIOEPMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NativeArray<float3> MJGNHOCKGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public NativeArray<int> HNILBIMJADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public NativeArray<float4> MADGJLJDNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public NativeArray<float4> AMOCKAGHOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public NativeArray<float4> ECPAEFFLKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public NativeList<float3> IILBFJPFEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public NativeList<int> FKJCOMCBNCO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GLEMFOKAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6987850", Offset = "0x6986C50", VA = "0x186987850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EJGCOECJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6987810", Offset = "0x6986C10", VA = "0x186987810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AONFEILOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6986F30", Offset = "0x6986330", VA = "0x186986F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6988100", Offset = "0x6987500", VA = "0x186988100")]
	public NICEIHIECLG(int NEAMGOHHBGB, int EFLEFHDHJNC, int HAFKLFMNBAG, Allocator EIFDLGAHDFC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6987E10", Offset = "0x6987210", VA = "0x186987E10")]
	public NICEIHIECLG(Mesh GFKLPJBCEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6986F70", Offset = "0x6986370", VA = "0x186986F70", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6987510", Offset = "0x6986910", VA = "0x186987510")]
	public void GAGCAMMLDDC(NICEIHIECLG GFKLPJBCEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6987080", Offset = "0x6986480", VA = "0x186987080")]
	private void EAABHJKCOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6987890", Offset = "0x6986C90", VA = "0x186987890")]
	private void OALMGNDFKBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LHLEFIKFIFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public int IEPDKHLCFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public int GLEMFOKAEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public int CIPIMBGFLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int EJGCOECJOPL;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x14D1020", Offset = "0x14D0420", VA = "0x1814D1020")]
	public LHLEFIKFIFF(int MCDIJLGEOPE, int AKKCHCGDDPD, int OCDCDAOIAHP, int KJADDLBDLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JCDIBLMPGLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<LHLEFIKFIFF> DLGKFKEDHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B50", Offset = "0x99FF50", VA = "0x1809A0B50")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LHLEFIKFIFF>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA94D30", Offset = "0xA94130", VA = "0x180A94D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NICEIHIECLG NDKNOJPDHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x697C1F0", Offset = "0x697B5F0", VA = "0x18697C1F0")]
	public JCDIBLMPGLA(IEnumerable<NICEIHIECLG> PGOOPHHPJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x697C180", Offset = "0x697B580", VA = "0x18697C180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum MCJHAKEBCFO
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class AMLKDKFIGDI
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static NativeArray<float2> FDILEEDEDOM;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static NativeArray<float3> DCKBDEPKBMN;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static NativeArray<float4> DKECLDMBEHE;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static NativeArray<int> EFCCNENOHOL;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x697AB50", Offset = "0x6979F50", VA = "0x18697AB50")]
	public static void EGPPFONICEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x697AD80", Offset = "0x697A180", VA = "0x18697AD80")]
	public static NativeArray<float2> LKJLLEMMAIM(NativeArray<float2> BJPMCCPPMAE, int BPFFDEDLLJL, NativeArray<float2> GCAPFBIOLIC, int EBJKGEJHEAB)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x697AA40", Offset = "0x6979E40", VA = "0x18697AA40")]
	public static NativeArray<float3> EBBKMEGIMCH(NativeArray<float3> BJPMCCPPMAE, int BPFFDEDLLJL, NativeArray<float3> GCAPFBIOLIC, int EBJKGEJHEAB)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x697A930", Offset = "0x6979D30", VA = "0x18697A930")]
	public static NativeArray<float4> AGGDLFICOON(NativeArray<float4> BJPMCCPPMAE, int BPFFDEDLLJL, NativeArray<float4> GCAPFBIOLIC, int EBJKGEJHEAB)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x697AC70", Offset = "0x697A070", VA = "0x18697AC70")]
	public static NativeArray<int> KEBOJAPNBOD(NativeArray<int> BJPMCCPPMAE, int BPFFDEDLLJL, NativeArray<int> GCAPFBIOLIC, int EBJKGEJHEAB)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x32257E0", Offset = "0x3224BE0", VA = "0x1832257E0")]
	private static void OLJGBDMLEIF<T>(NativeArray<T> ELFCOFFIPBP, int HLGNGKDFBHA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3225700", Offset = "0x3224B00", VA = "0x183225700")]
	private static void OEMHADMCHMH<T>(NativeArray<T> BJPMCCPPMAE, int BPFFDEDLLJL, NativeArray<T> GCAPFBIOLIC, int EBJKGEJHEAB, NativeArray<T> GOKGCJFOCAB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LMAMKEBMGCK
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum IKGHONJKGOF
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
	public class ENDPLGLKOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public IJIPMMOPBHJ GFKLPJBCEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int EOEBINGEKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int LCECHDGMBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public long PJAEFKKLIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long INAPEFFPKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float CBGNGOFIFOL;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x697C130", Offset = "0x697B530", VA = "0x18697C130")]
		public ENDPLGLKOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x697C0F0", Offset = "0x697B4F0", VA = "0x18697C0F0")]
		public void HGGBIMJODNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly string JAEFBPCKEMI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly string DIKJFPGGOMM;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly ProfilerMarker BIJANCPHNPM;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly ProfilerMarker IJMPDKJOKJF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly ProfilerMarker HCKMBKJBAAC;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly ProfilerMarker GLNOONNCONO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly ProfilerMarker CNKGNKMIHCL;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly ProfilerMarker BAGMCDFAODM;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly ProfilerMarker DEFMMNPHMNB;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly ProfilerMarker OFMBMICNHIG;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly ProfilerMarker NJEMAFHPIBF;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker PCLGDNPOCJE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker HBLCNBCKPFN;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker KKIEDPJAGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly List<MHOPGKFJMAL> GGJIKPNMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly MNJBIBIKDGH ILOMOKBPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int AKKCHCGDDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int KJADDLBDLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool EEPOJPMMICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	internal bool NELCCCDLEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	internal IKGHONJKGOF AHEJMLCHHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	internal bool FJCMNAKJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	internal float3 IIHJNFICCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal float3 AOCAIBCNBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal float FEKBDOHCEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	internal float NBLGCIDIMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal int NDGJKGEOMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal int GDFIELPNMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int KGAIIHMCLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private int EMCNGMMOMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float GHJHFLHIAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float OOOFFIADJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private int KOKODGPJAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private long ICEACNKCKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long NCGKPKCHMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private long NJNBGBDKAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public int CEJNOOLDCFA;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private const int APBHDMDPBMP = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float[] BMOGKAGKFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int[] LCLPFIPFOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private long[] GHHAEJGOLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private AGIFCHBLDPN DKJBEDDJKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private long IGBFJPKCPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private long OCIDOJHEPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private int MGJNDGPJEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private List<ENDPLGLKOOE> NKNPGPKLIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	internal float ODACIGEPMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	internal AGIFCHBLDPN.EFOGHNOBDIO KFDONMLAHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool NDJCGBEOJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private OHDHJICOHDB NDNJJPLEMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JobHandle CIDGKLKGHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	internal NativeArray<long> ONAKKFNJICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private bool AJNKPMENGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JobHandle JLHCONIPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private AGIFCHBLDPN IPLCALEJCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Transform CJNNALDILDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private HGFHPCOBBNK HFNDMOKEMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private long DALLFGFBCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private long LBMECEKLIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private long HIPCJOCKLIH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NDKNOJPDHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer NDLDFMKFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ECGIMLOCHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x996330", Offset = "0x995730", VA = "0x180996330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int GNFMBPMJELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x94D910", Offset = "0x94CD10", VA = "0x18094D910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GLEMFOKAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6984AE0", Offset = "0x6983EE0", VA = "0x186984AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<MHOPGKFJMAL> JLJACOPOHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void JODIPHEDAAI(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void BJGDDGKOAIJ(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void JODIPHEDAAI(bool DHKICBLCKBN, string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6984630", Offset = "0x6983A30", VA = "0x186984630")]
	public void JIONKMMAFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x69846A0", Offset = "0x6983AA0", VA = "0x1869846A0")]
	private void NNFBFEAJKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6986C50", Offset = "0x6986050", VA = "0x186986C50")]
	public LMAMKEBMGCK(string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x69840A0", Offset = "0x69834A0", VA = "0x1869840A0")]
	public void HGGBIMJODNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6983870", Offset = "0x6982C70", VA = "0x186983870")]
	public void EJCLMDEOKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x69842A0", Offset = "0x69836A0", VA = "0x1869842A0")]
	private void IBCAFOLDGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6983ED0", Offset = "0x69832D0", VA = "0x186983ED0")]
	public void HBJCEBHMBFK(MHOPGKFJMAL KKCBEFPBHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6984590", Offset = "0x6983990", VA = "0x186984590")]
	public bool JFFDNOKOPPG(MHOPGKFJMAL KKCBEFPBHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6984530", Offset = "0x6983930", VA = "0x186984530")]
	public bool IMCHJPMIMGD(MHOPGKFJMAL KKCBEFPBHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6982CE0", Offset = "0x69820E0", VA = "0x186982CE0", Slot = "4")]
	public virtual void EBHKJNPNNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x69852F0", Offset = "0x69846F0", VA = "0x1869852F0")]
	public void PHIMDKJGEPF(Transform EKCGGEIDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69841C0", Offset = "0x69835C0", VA = "0x1869841C0")]
	private long HKCMHAHLJDF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6982720", Offset = "0x6981B20", VA = "0x186982720")]
	private long DOEGKMNEDHL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6980B90", Offset = "0x697FF90", VA = "0x186980B90")]
	public bool DIMKLMHAKPD(Transform EKCGGEIDECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x697DBA0", Offset = "0x697CFA0", VA = "0x18697DBA0")]
	public bool BKAKMLMHKAC(bool KDEIEKHDIDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6983D20", Offset = "0x6983120", VA = "0x186983D20")]
	public void FFOKPBFEHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x697EFC0", Offset = "0x697E3C0", VA = "0x18697EFC0")]
	public bool CJAHEIPNJDF(float4x4 ILIAHNJMIED, BatchedMeshRenderer PBMHKILDDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x697D930", Offset = "0x697CD30", VA = "0x18697D930")]
	public void BDNOJLEIBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6983930", Offset = "0x6982D30", VA = "0x186983930")]
	public bool EKCAHNEEJCA(bool KDEIEKHDIDK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x69852E0", Offset = "0x69846E0", VA = "0x1869852E0")]
	public void PAICPAFMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6984640", Offset = "0x6983A40", VA = "0x186984640")]
	public void MEEKIPJPMOH(AGIFCHBLDPN GFKLPJBCEPF, int NPPPKBPNLGP, int INFINNNKEOF, float FNKEFMODEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6983EA0", Offset = "0x69832A0", VA = "0x186983EA0")]
	public void HAHEEPFNODO(IJIPMMOPBHJ KOIKDMMNMFA, int NPPPKBPNLGP, int INFINNNKEOF, float FNKEFMODEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6982C70", Offset = "0x6982070", VA = "0x186982C70")]
	public (long, long, long) EAPCLLMOOHC()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xAB1560", Offset = "0xAB0960", VA = "0x180AB1560")]
	public long GCDCEIPGPPG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x697EE20", Offset = "0x697E220", VA = "0x18697EE20")]
	private void CFMLGHNHLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x69828A0", Offset = "0x6981CA0", VA = "0x1869828A0")]
	public (long, long) DOODOIDLPLB(float LLFIKABGNAO, float4x4 ILIAHNJMIED)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	public void BCDPGMDJPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6983C00", Offset = "0x6983000", VA = "0x186983C00")]
	internal void EPHCODLOFMD(IKGHONJKGOF HEMFJEPGPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6982D90", Offset = "0x6982190", VA = "0x186982D90")]
	private (float, float, float) ECCPBDKDGIB(float FMEGMCECKLC, float4x4 ILIAHNJMIED)
	{
		return default((float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x697D580", Offset = "0x697C980", VA = "0x18697D580")]
	private (int, int) ANCENAHPOII(float BNDPJOLNHNI)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69856E0", Offset = "0x6984AE0", VA = "0x1869856E0")]
	public void PMACCMHGCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6984670", Offset = "0x6983A70", VA = "0x186984670")]
	private void MKIPMEBNDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6985500", Offset = "0x6984900", VA = "0x186985500")]
	private void PIECNKPLGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6984B00", Offset = "0x6983F00", VA = "0x186984B00")]
	public long OINHEECPJKO(long KKLLHACCJBC, int LMBDOPGHHAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x69802B0", Offset = "0x697F6B0", VA = "0x1869802B0")]
	private void DEGMPBKAJPC(AGIFCHBLDPN IHEFFONHLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x697D2E0", Offset = "0x697C6E0", VA = "0x18697D2E0")]
	private void AGDMDOJCGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6981BD0", Offset = "0x6980FD0", VA = "0x186981BD0")]
	private void DKAIDEBDPOM(AGIFCHBLDPN GFKLPJBCEPF, IJIPMMOPBHJ KOIKDMMNMFA, int NPPPKBPNLGP, int INFINNNKEOF, float FNKEFMODEOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal struct OHDHJICOHDB : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private struct MNPEHOGGEJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int GCBHCFACNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int LKDHILDFECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int LICOBAPMNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int AAGGPCIOKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int BKEJHNFGHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int EAEBEGFBOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int EOEBINGEKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int LCECHDGMBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public float CBGNGOFIFOL;
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct BPGALKIBOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public FNHOMJIGJPF.NCECMNJBDPL JGLKCPAPMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public float BCDPBENKFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float BBPIMBPFIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public float BDGFKEKEDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float HAFMCDFNMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float KPJAEFANFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float PJDFOKAHNIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct MBAHBGBNFNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NativeArray<float3> HMPMIOEPMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NativeArray<float3> MJGNHOCKGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public NativeArray<float4> MIOCFDLPGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NativeArray<float4> BFKINJIFJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NativeArray<float2> PPIPCMJNABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public NativeArray<int> FKJCOMCBNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool AJHIPMCDLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int GLEMFOKAEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int EJGCOECJOPL;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6996320", Offset = "0x6995720", VA = "0x186996320")]
		public void GOBPIALLIIA(int NEAMGOHHBGB, int EFLEFHDHJNC, Allocator EIFDLGAHDFC, bool NABLBCNGEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69960D0", Offset = "0x69954D0", VA = "0x1869960D0")]
		public static MBAHBGBNFNC ACAHGBIFHBI(AGIFCHBLDPN DENOKKMKOFP)
		{
			return default(MBAHBGBNFNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6996500", Offset = "0x6995900", VA = "0x186996500")]
		public void HGGBIMJODNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly ProfilerMarker PGNACEFHNGH;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly ProfilerMarker AHGGPBAHKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeArray<MNPEHOGGEJD> MPEAJAHOKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private MBAHBGBNFNC IIKMIBPNDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private MBAHBGBNFNC IHEFFONHLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private float3 LDINDJGJELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private float3 PBDIMKPCLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private BPGALKIBOCO CIFKBCGCEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* JHPOJOBIECM;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	[BurstDiscard]
	private static void JODIPHEDAAI(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	[BurstDiscard]
	private static void BJGDDGKOAIJ(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	[BurstDiscard]
	private static void JODIPHEDAAI(bool DHKICBLCKBN, string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x698A5A0", Offset = "0x69899A0", VA = "0x18698A5A0")]
	public OHDHJICOHDB([In] List<LMAMKEBMGCK.ENDPLGLKOOE> IKHOKBLJNGJ, [In] AGIFCHBLDPN JKDHDMPKEJM, [In] LMAMKEBMGCK NFFIDDGKPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6988580", Offset = "0x6987980", VA = "0x186988580", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6989B10", Offset = "0x6988F10", VA = "0x186989B10")]
	public void OEJLMHAMIEA(List<LMAMKEBMGCK.ENDPLGLKOOE> PDFJMCKFINE, [In] LMAMKEBMGCK NFFIDDGKPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x69885D0", Offset = "0x69879D0", VA = "0x1869885D0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool FLLONIFLGKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6989A40", Offset = "0x6988E40", VA = "0x186989A40")]
	private IJIPMMOPBHJ NEGDAODADFP(int ECJOGOKEOAE, Allocator EIFDLGAHDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69886F0", Offset = "0x6987AF0", VA = "0x1869886F0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void JHFMGLKMALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x698A190", Offset = "0x6989590", VA = "0x18698A190")]
	[IgnoreWarning(1371)]
	private MNPEHOGGEJD PLEHPDNCJCP([In] MNPEHOGGEJD NCADCJFLECI, int OPLELOPNKAL, [In] NativeArray<int> PBOEIEKIDKH, [In] NativeArray<bool> NCGPEEEGHJG, NativeArray<int> AKIFOGDIPFM)
	{
		return default(MNPEHOGGEJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x69885F0", Offset = "0x69879F0", VA = "0x1869885F0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int FOCBIIIOMFD(NativeArray<int> PBOEIEKIDKH, int CCLHDBGAILL, int OIHFJDPNGMP, int LGOKFFENBAM)
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
		public static readonly BADOKLEEAHE log;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly ProfilerMarker DNPEGCOENEK;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly ProfilerMarker JGFFGJFOLNH;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly ProfilerMarker MCEHGLMMIOL;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly ProfilerMarker COKLIHDCOMI;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly ProfilerMarker CBBALAMPFHN;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private static readonly ProfilerMarker CNKGNKMIHCL;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private static readonly ProfilerMarker IHOLODNCIHO;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal const int FHOHMOKMBHB = 65000;

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
		private Dictionary<Material, List<LMAMKEBMGCK>> JBPHAJHJHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal List<LMAMKEBMGCK> JPOICKAOMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private List<MeshRenderer> INDCCFJMCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool APKJDHIFGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool IPCLJGAPCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int BJNLOGEMAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private Dictionary<int, float> PLNEODNDMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<int, Color> CEFLIFAPCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private Dictionary<int, Vector4> MINKPDLJEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private Dictionary<int, Matrix4x4> HDBOMCFJJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private LMAMKEBMGCK ABFOGCONAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Material HLIGOGGHEFB;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private const int ECGIGKMIGLI = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private static List<(long, Bounds, MHOPGKFJMAL)> HCIMMNNLGDJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> KLEFHFPNEGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int APJIEIFPAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x6990F90", Offset = "0x6990390", VA = "0x186990F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		private static void JODIPHEDAAI(bool DHKICBLCKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		private static void JODIPHEDAAI(bool DHKICBLCKBN, string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x698D940", Offset = "0x698CD40", VA = "0x18698D940")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x698B8A0", Offset = "0x698ACA0", VA = "0x18698B8A0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x698B670", Offset = "0x698AA70", VA = "0x18698B670")]
		public LMAMKEBMGCK AddToBatchedMesh(MHOPGKFJMAL HEAFCAMCIKO, Material JOFMGPCHADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6990080", Offset = "0x698F480", VA = "0x186990080")]
		public void RemoveFromBatchedMesh(MHOPGKFJMAL GFKLPJBCEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x698B770", Offset = "0x698AB70", VA = "0x18698B770")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6990870", Offset = "0x698FC70", VA = "0x186990870")]
		public void SetMaterialProperty(int MKMLIBNPMMN, Color IGDDAGDAAIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6990420", Offset = "0x698F820", VA = "0x186990420")]
		public void SetMaterialProperty(int MKMLIBNPMMN, float OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6990640", Offset = "0x698FA40", VA = "0x186990640")]
		public void SetMaterialProperty(int MKMLIBNPMMN, Vector4 KHEAPNLKJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69901C0", Offset = "0x698F5C0", VA = "0x1869901C0")]
		public void SetMaterialProperty(int MKMLIBNPMMN, Matrix4x4 PMCBLPKBOFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x698C080", Offset = "0x698B480", VA = "0x18698C080")]
		private void EHOMFHNFPNB(Renderer CODANAEIMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x698C680", Offset = "0x698BA80", VA = "0x18698C680")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x698C670", Offset = "0x698BA70", VA = "0x18698C670")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x698CC60", Offset = "0x698C060", VA = "0x18698CC60")]
		private void IDJJDEPPNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x698BE60", Offset = "0x698B260", VA = "0x18698BE60")]
		private LMAMKEBMGCK EDNKKGJCDLE(MHOPGKFJMAL GFKLPJBCEPF, Material JOFMGPCHADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x698D180", Offset = "0x698C580", VA = "0x18698D180")]
		private LMAMKEBMGCK LLJDFDIKIJA(Material JOFMGPCHADM, int COPOHMGAJPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x698BA60", Offset = "0x698AE60", VA = "0x18698BA60")]
		private LMAMKEBMGCK EBIDLOMFFMB(Material JOFMGPCHADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x19822C0", Offset = "0x19816C0", VA = "0x1819822C0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x698D460", Offset = "0x698C860", VA = "0x18698D460")]
		public void MarkDirty(MHOPGKFJMAL GFKLPJBCEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x698D5C0", Offset = "0x698C9C0", VA = "0x18698D5C0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float LLFIKABGNAO)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x698F110", Offset = "0x698E510", VA = "0x18698F110")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x698C720", Offset = "0x698BB20", VA = "0x18698C720")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x698DC30", Offset = "0x698D030", VA = "0x18698DC30")]
		public void RebatchOptimally(int APDCELMNLFE, int HDHBGCHDNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6990D20", Offset = "0x6990120", VA = "0x186990D20")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class IJMDNFCEDAL
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct DLLOAKPLBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public float OMFADEMDLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BatchedMeshRenderer JCCMNFBMCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public LMAMKEBMGCK AMDIDCEHHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public long CFDIGEPELCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class GOHHCFOAJGC : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9F3850", Offset = "0x9F2C50", VA = "0x1809F3850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6991DD0", Offset = "0x69911D0", VA = "0x186991DD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xB48C10", Offset = "0xB48010", VA = "0x180B48C10")]
		[DebuggerHidden]
		public GOHHCFOAJGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6991E20", Offset = "0x6991220", VA = "0x186991E20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6991030", Offset = "0x6990430", VA = "0x186991030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6990FE0", Offset = "0x69903E0", VA = "0x186990FE0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6991C80", Offset = "0x6991080", VA = "0x186991C80")]
		private void OANBEGBCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6991D80", Offset = "0x6991180", VA = "0x186991D80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6991CD0", Offset = "0x69910D0", VA = "0x186991CD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6991CD0", Offset = "0x69910D0", VA = "0x186991CD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker CNKGNKMIHCL;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker KDLHKONIEEH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker CGIPBFHDEBP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly ProfilerMarker MLNGMKADMCG;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float3 FKHPPFHNPCG;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static int IMGOMCGKHHL;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static int BPLMEACADKF;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static int JPMMAGGCMMA;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static int IFNIPCHKCFO;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static int FANEIECJNMB;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static int NPACDJKLAMA;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static int EKONAJONJDE;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static int EPHBABDEGIL;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public static int FAOGFCGPGOI;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public static int CPAOKMIIOBE;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public static int EGDHKAPALEM;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public static int HPEAKEIBLAM;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static int HHJMMMELJKN;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static int BAGFKNBHCNA;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static long FACMKEKGCOE;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public static long KPHEDNLHOPJ;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public static int HKJBDIKEMKI;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public static int IOEAHEJGPPP;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public static int JABLGEOOCFD;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static long JCAJCNGICHO;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public static bool KABCEALIBMC;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static List<BatchedMeshRenderer> OECCEDHIPNK;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static List<DLLOAKPLBHI> CPNJEIKLKLA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool CAEAGDDMGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6995420", Offset = "0x6994820", VA = "0x186995420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void JODIPHEDAAI(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void BJGDDGKOAIJ(bool DHKICBLCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void JODIPHEDAAI(bool DHKICBLCKBN, string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6992160", Offset = "0x6991560", VA = "0x186992160")]
	public static void BGMBKGHFJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6995950", Offset = "0x6994D50", VA = "0x186995950")]
	public static void ONGMPIBKNIL(BatchedMeshRenderer CBJGGMCIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6994D50", Offset = "0x6994150", VA = "0x186994D50")]
	public static void CPDAPCCEPLF(BatchedMeshRenderer CBJGGMCIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6991F40", Offset = "0x6991340", VA = "0x186991F40")]
	private static (long, long, long) ADJCHFFHMND(long JAHEGOLLEMF)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6992670", Offset = "0x6991A70", VA = "0x186992670")]
	public static void CJAHEIPNJDF(long JAHEGOLLEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69955B0", Offset = "0x69949B0", VA = "0x1869955B0")]
	public static long OINHEECPJKO(long KKLLHACCJBC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6992050", Offset = "0x6991450", VA = "0x186992050")]
	public static void AOINBMGOOAG(LMAMKEBMGCK AMDIDCEHHEM, BatchedMeshRenderer JCCMNFBMCPB, long CFDIGEPELCL, float OMFADEMDLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69954B0", Offset = "0x69948B0", VA = "0x1869954B0")]
	public static void IBOCJIKCHNK(LMAMKEBMGCK AMDIDCEHHEM, BatchedMeshRenderer JCCMNFBMCPB, long CFDIGEPELCL, float BKFFEEPKOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x69951A0", Offset = "0x69945A0", VA = "0x1869951A0")]
	public static void FBEGDCDKDKP(LMAMKEBMGCK AMDIDCEHHEM, BatchedMeshRenderer JCCMNFBMCPB, long CFDIGEPELCL, float BKFFEEPKOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6995BC0", Offset = "0x6994FC0", VA = "0x186995BC0")]
	public static void PCPBEKKKKKF(LMAMKEBMGCK AMDIDCEHHEM, BatchedMeshRenderer JCCMNFBMCPB, long CFDIGEPELCL, float OMFADEMDLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6992310", Offset = "0x6991710", VA = "0x186992310")]
	public static float BMLKFCOGFII(long BBNKBICALAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6994E90", Offset = "0x6994290", VA = "0x186994E90")]
	public static (long, long) DOODOIDLPLB(float LLFIKABGNAO)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6994E00", Offset = "0x6994200", VA = "0x186994E00")]
	[IteratorStateMachine(typeof(GOHHCFOAJGC))]
	public static IEnumerable<bool> DKNKGDAFJGI(long CCJBNKMLPIO, bool KKHMFKIDBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x69952B0", Offset = "0x69946B0", VA = "0x1869952B0")]
	public static void FCDPNLNHBHL(long CCJBNKMLPIO, bool KKHMFKIDBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6995060", Offset = "0x6994460", VA = "0x186995060")]
	public static int EFPJFHBAJGO()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class JKBHJIEFOEM<KeyType> : LMAMKEBMGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly Dictionary<KeyType, MHOPGKFJMAL> IJPHMOGIJED;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x406A700", Offset = "0x4069B00", VA = "0x18406A700")]
	public JKBHJIEFOEM(string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x406A3C0", Offset = "0x40697C0", VA = "0x18406A3C0")]
	public void HBJCEBHMBFK(KeyType PEDCMDADFIN, MHOPGKFJMAL KKCBEFPBHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x406A520", Offset = "0x4069920", VA = "0x18406A520")]
	public bool LMMCBMJBBKB(KeyType PEDCMDADFIN, MHOPGKFJMAL MOGFKOMMMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x406A1C0", Offset = "0x40695C0", VA = "0x18406A1C0")]
	public void DOOBCIKNLOC(KeyType PEDCMDADFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x406A360", Offset = "0x4069760", VA = "0x18406A360", Slot = "4")]
	public override void EBHKJNPNNKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x69965C0", Offset = "0x69959C0", VA = "0x1869965C0")]
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
