using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A34EC0", Offset = "0x2A33AC0", VA = "0x182A34EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HPNJFNGJGCN : HIMPFMKCELK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A34E00", Offset = "0x2A33A00", VA = "0x182A34E00", Slot = "7")]
	public override string BAMDPIFKGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A34E80", Offset = "0x2A33A80", VA = "0x182A34E80")]
	private HPNJFNGJGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A34E30", Offset = "0x2A33A30", VA = "0x182A34E30")]
	public static HPNJFNGJGCN MJMNOIPJNFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DMFJJCNKABC<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, IDEOPPIBPCE.MAAGPCBBEFC<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CPNHGLLAKAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] GKFBBGAAIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int PALKEAODHPG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12F1070", Offset = "0x12EFC70", VA = "0x1812F1070")]
		private CPNHGLLAKAH(TPartialAction[] MKJHBMDDDPJ, int PHFCNPMHKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C599E0", Offset = "0x6C585E0", VA = "0x186C599E0")]
		public static DMFJJCNKABC<TPartialAction, TPartialActionId, TFullAction, TDeps>.CPNHGLLAKAH MJMNOIPJNFN(int DFDPHEPPCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C598C0", Offset = "0x6C584C0", VA = "0x186C598C0")]
		public MFDCCLPPFCM<TFullAction> ACBOOPOPPMG(TPartialAction ALIDFPJOEGC, TDeps BNLBDNCLLFN)
		{
			return default(MFDCCLPPFCM<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, CPNHGLLAKAH>? BHDEAJEOMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps HIMLJAGALBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, CPNHGLLAKAH> INIJNJEBKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4476AD0", Offset = "0x44756D0", VA = "0x184476AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4476BB0", Offset = "0x44757B0", VA = "0x184476BB0")]
	private DMFJJCNKABC(Dictionary<TPartialActionId, CPNHGLLAKAH>? BFJKHMIMGBH, TDeps BNLBDNCLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4476A20", Offset = "0x4475620", VA = "0x184476A20")]
	public static DMFJJCNKABC<TPartialAction, TPartialActionId, TFullAction, TDeps> MJMNOIPJNFN(TDeps BNLBDNCLLFN)
	{
		return default(DMFJJCNKABC<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4476390", Offset = "0x4474F90", VA = "0x184476390")]
	public IADHIMOENNN<MFDCCLPPFCM<TFullAction>, KHGGKMBDLJL> ACBOOPOPPMG(TPartialAction ALIDFPJOEGC)
	{
		return default(IADHIMOENNN<MFDCCLPPFCM<TFullAction>, KHGGKMBDLJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4476970", Offset = "0x4475570", VA = "0x184476970")]
	public void DDPCEKPPINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IDEOPPIBPCE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface MAAGPCBBEFC<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IIEANGCNAHE([In] TPartialAction ALIDFPJOEGC);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NACIADNBKDN([In] TPartialAction ALIDFPJOEGC);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId DPKKNONMGFB([In] TPartialAction ALIDFPJOEGC);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction AKFDKHFKDEM(TPartialAction[] NDHCACJPEKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FCIABJBHDIG<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : GCFKJAFKFHP.DBMEDGIMMEI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] GOPPLOHLDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int MEKGGPENBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps HIMLJAGALBM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BA80", Offset = "0x4D5A680", VA = "0x184D5BA80")]
	internal FCIABJBHDIG(TPartialSnapshot[] HAFLDPIEPHI, int ALMGBAEBCHA, TDeps BNLBDNCLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B9B0", Offset = "0x4D5A5B0", VA = "0x184D5B9B0")]
	public static FCIABJBHDIG<TPartialSnapshot, TFullSnapshot, TDeps> MJMNOIPJNFN(TDeps BNLBDNCLLFN)
	{
		return default(FCIABJBHDIG<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GCFKJAFKFHP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface DBMEDGIMMEI<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MDJLJKJOHHE([In] TPartialSnapshot IKGLFKGNPBH);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NDGLEGJBKEJ(TPartialSnapshot[] DGIOKCKPIIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C42090", Offset = "0x3C40C90", VA = "0x183C42090")]
	public static MFDCCLPPFCM<TFullSnapshot> ACBOOPOPPMG<TFullSnapshot, TPartialSnapshot, TDeps>(this FCIABJBHDIG<TPartialSnapshot, TFullSnapshot, TDeps> JBDFDFABHKD, TPartialSnapshot IKGLFKGNPBH) where TDeps : DBMEDGIMMEI<TPartialSnapshot, TFullSnapshot>
	{
		return default(MFDCCLPPFCM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C42440", Offset = "0x3C41040", VA = "0x183C42440")]
	public static bool KMDBDHMDKAK<TPartialSnapshot, TFullSnapshot, TDeps>(this FCIABJBHDIG<TPartialSnapshot, TFullSnapshot, TDeps> JBDFDFABHKD, TPartialSnapshot IKGLFKGNPBH) where TDeps : DBMEDGIMMEI<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class IGCBEBBHIFG : HIMPFMKCELK
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A34E90", Offset = "0x2A33A90", VA = "0x182A34E90", Slot = "7")]
	public override string BAMDPIFKGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A34E80", Offset = "0x2A33A80", VA = "0x182A34E80")]
	public IGCBEBBHIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : GJDHOMEHADK.KPNNGKBLNKM<TAction, TNetSys> where TReceiverDeps : GJDHOMEHADK.CPPICEMGEJL<TAction, TReceiver> where TRootDeps : GJDHOMEHADK.FJMCDEDNNIB<TMRequest, TAction, TRoot> where TDeps : GJDHOMEHADK.KCLJCJPPNFK<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface HMHIJIFOOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OGAGOIIHLGH([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BMEJDICONEA();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IADHIMOENNN<object, KHGGKMBDLJL> LNCAKPDHLNO();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DLGIEDBGBLE(Exception EBNIDHCOLMC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class NPPANBECKAI : HMHIJIFOOKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> HJOLOACPOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<IADHIMOENNN<object, KLHHEJIOGEP>> FMOHPCOLNHP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5732D60", Offset = "0x5731960", VA = "0x185732D60")]
		private NPPANBECKAI(TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> FFNPFGAHDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x53C75A0", Offset = "0x53C61A0", VA = "0x1853C75A0")]
		public static NPPANBECKAI MJMNOIPJNFN(TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> FFNPFGAHDNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5732C60", Offset = "0x5731860", VA = "0x185732C60")]
		public void OGAGOIIHLGH([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5732650", Offset = "0x5731250", VA = "0x185732650", Slot = "5")]
		public void BMEJDICONEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5732850", Offset = "0x5731450", VA = "0x185732850", Slot = "6")]
		public IADHIMOENNN<object, KHGGKMBDLJL> LNCAKPDHLNO()
		{
			return default(IADHIMOENNN<object, KHGGKMBDLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5732790", Offset = "0x5731390", VA = "0x185732790", Slot = "7")]
		public void DLGIEDBGBLE(Exception EBNIDHCOLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x48C5E50", Offset = "0x48C4A50", VA = "0x1848C5E50", Slot = "4")]
		private void AIBBCGHAIFB([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class KHEKAGMBEEO : HMHIJIFOOKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> HJOLOACPOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IADHIMOENNN<object, KHGGKMBDLJL> NDFLEMDFFHJ;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
		private KHEKAGMBEEO(TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> FFNPFGAHDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x53C75A0", Offset = "0x53C61A0", VA = "0x1853C75A0")]
		public static KHEKAGMBEEO MJMNOIPJNFN(TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> FFNPFGAHDNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xEF3510", Offset = "0xEF2110", VA = "0x180EF3510")]
		public void OGAGOIIHLGH([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x53C7420", Offset = "0x53C6020", VA = "0x1853C7420", Slot = "5")]
		public void BMEJDICONEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0", Slot = "6")]
		public IADHIMOENNN<object, KHGGKMBDLJL> LNCAKPDHLNO()
		{
			return default(IADHIMOENNN<object, KHGGKMBDLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x53C7480", Offset = "0x53C6080", VA = "0x1853C7480", Slot = "7")]
		public void DLGIEDBGBLE(Exception EBNIDHCOLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x48C5E50", Offset = "0x48C4A50", VA = "0x1848C5E50", Slot = "4")]
		private void AIBBCGHAIFB([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class EOPGGPLMJAI : HMHIJIFOOKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<IADHIMOENNN<object, KHGGKMBDLJL>> FMOHPCOLNHP;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x48F6D10", Offset = "0x48F5910", VA = "0x1848F6D10")]
		private EOPGGPLMJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x48F69F0", Offset = "0x48F55F0", VA = "0x1848F69F0")]
		public static EOPGGPLMJAI MJMNOIPJNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x48F6C40", Offset = "0x48F5840", VA = "0x1848F6C40")]
		public void OGAGOIIHLGH([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void BMEJDICONEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x48F6990", Offset = "0x48F5590", VA = "0x1848F6990", Slot = "6")]
		public IADHIMOENNN<object, KHGGKMBDLJL> LNCAKPDHLNO()
		{
			return default(IADHIMOENNN<object, KHGGKMBDLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x48F6830", Offset = "0x48F5430", VA = "0x1848F6830", Slot = "7")]
		[ABLFJIFLPNO("This may be terminal and should probably do more than discarding the exception.")]
		public void DLGIEDBGBLE(Exception EBNIDHCOLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x48C5E50", Offset = "0x48C4A50", VA = "0x1848C5E50", Slot = "4")]
		private void AIBBCGHAIFB([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LHBIEKJBAOG : HMHIJIFOOKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IADHIMOENNN<object, KHGGKMBDLJL> NDFLEMDFFHJ;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		private LHBIEKJBAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x48F69F0", Offset = "0x48F55F0", VA = "0x1848F69F0")]
		public static LHBIEKJBAOG MJMNOIPJNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2626540", Offset = "0x2625140", VA = "0x182626540")]
		public void OGAGOIIHLGH([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void BMEJDICONEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xE507D0", Offset = "0xE4F3D0", VA = "0x180E507D0", Slot = "6")]
		public IADHIMOENNN<object, KHGGKMBDLJL> LNCAKPDHLNO()
		{
			return default(IADHIMOENNN<object, KHGGKMBDLJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5461E60", Offset = "0x5460A60", VA = "0x185461E60", Slot = "7")]
		[ABLFJIFLPNO("This may be terminal and should probably do more than discarding the exception.")]
		public void DLGIEDBGBLE(Exception EBNIDHCOLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x48C5E50", Offset = "0x48C4A50", VA = "0x1848C5E50", Slot = "4")]
		private void AIBBCGHAIFB([In] IADHIMOENNN<object, KHGGKMBDLJL> ABEFNIJCBBN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct GPKADCLFHDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<object, KHGGKMBDLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<IADHIMOENNN<object, KHGGKMBDLJL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F28ED0", Offset = "0x4F27AD0", VA = "0x184F28ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4F29830", Offset = "0x4F28430", VA = "0x184F29830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HPMAFEFLEDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<object, KHGGKMBDLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<IADHIMOENNN<object, KHGGKMBDLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4FB0CF0", Offset = "0x4FAF8F0", VA = "0x184FB0CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4FB19F0", Offset = "0x4FB05F0", VA = "0x184FB19F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FEFAOCLJBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<object, KHGGKMBDLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public COMEADPNKEA<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<IADHIMOENNN<object, KHGGKMBDLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D67100", Offset = "0x4D65D00", VA = "0x184D67100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D67530", Offset = "0x4D66130", VA = "0x184D67530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OEDIACEMNOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<object, KHGGKMBDLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public COMEADPNKEA<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private HMHIJIFOOKC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5858110", Offset = "0x5856D10", VA = "0x185858110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5858D10", Offset = "0x5857910", VA = "0x185858D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FPNJENOAMLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HMHIJIFOOKC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HMHIJIFOOKC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<IADHIMOENNN<object?, KHGGKMBDLJL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4DBADC0", Offset = "0x4DB99C0", VA = "0x184DBADC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4DBCBD0", Offset = "0x4DBB7D0", VA = "0x184DBCBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct BMKFHBKOMNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ABMHJIEHPIL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66F8B80", Offset = "0x66F7780", VA = "0x1866F8B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x66F92A0", Offset = "0x66F7EA0", VA = "0x1866F92A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps HIMLJAGALBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<COMEADPNKEA<TMRequest>, TaskCompletionSource<IADHIMOENNN<object, KHGGKMBDLJL>>> IFAFFDCJDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FEMBHFFCMGF<TMRequest> FBOEILOGOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PECDLELKPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int OABBPDDHNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task GDHBHJBPJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int BJLMNJKPFPD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps KDNCIENNIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4F70110", Offset = "0x4F6ED10", VA = "0x184F70110")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps ONDNDMJEEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4F702F0", Offset = "0x4F6EEF0", VA = "0x184F702F0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps JGJEKCHFEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DF20", Offset = "0x4F6CB20", VA = "0x184F6DF20")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GIPEFFDPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE4BEA0", Offset = "0xE4AAA0", VA = "0x180E4BEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE4C340", Offset = "0xE4AF40", VA = "0x180E4C340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JEIPEGPOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA5C760", Offset = "0xA5B360", VA = "0x180A5C760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OICMKFPKBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4F713D0", Offset = "0x4F6FFD0", VA = "0x184F713D0")]
	public ABMHJIEHPIL(TDeps BNLBDNCLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F6F340", Offset = "0x4F6DF40", VA = "0x184F6F340")]
	public Task<IADHIMOENNN<object, KHGGKMBDLJL>> DKHAACOFLDL(TRoot OLIIIAEGOLD, TNetSys OGHNNMCNOBC, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction KLIEOOEGDML, bool NJBBGJCHDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FB60", Offset = "0x4F6E760", VA = "0x184F6FB60")]
	[AsyncStateMachine(typeof(ABMHJIEHPIL<, , , , , , , , >.GPKADCLFHDK))]
	private Task<IADHIMOENNN<object, KHGGKMBDLJL>> DKHAACOFLDL(TRoot OLIIIAEGOLD, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction KLIEOOEGDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F70FC0", Offset = "0x4F6FBC0", VA = "0x184F70FC0")]
	[AsyncStateMachine(typeof(ABMHJIEHPIL<, , , , , , , , >.HPMAFEFLEDA))]
	private Task<IADHIMOENNN<object, KHGGKMBDLJL>> OEOLOIHBLII(TRoot OLIIIAEGOLD, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction[] MNCJLAMGDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FFA0", Offset = "0x4F6EBA0", VA = "0x184F6FFA0")]
	[AsyncStateMachine(typeof(ABMHJIEHPIL<, , , , , , , , >.FEFAOCLJBNC))]
	public Task<IADHIMOENNN<object, KHGGKMBDLJL>> ENJILADPIFM(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, TReceiver NHJPJMHIKLA, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, COMEADPNKEA<TMRequest> MANPAFALMMC, TAction KLIEOOEGDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4F709D0", Offset = "0x4F6F5D0", VA = "0x184F709D0")]
	[AsyncStateMachine(typeof(ABMHJIEHPIL<, , , , , , , , >.OEDIACEMNOP))]
	private Task<IADHIMOENNN<object, KHGGKMBDLJL>> MKIINDHGDJI(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, TReceiver NHJPJMHIKLA, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, COMEADPNKEA<TMRequest> MANPAFALMMC, TAction KLIEOOEGDML, Task NJOLGDBGAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DD80", Offset = "0x4F6C980", VA = "0x184F6DD80")]
	[AsyncStateMachine(typeof(ABMHJIEHPIL<, , , , , , , , >.FPNJENOAMLK))]
	private Task BAKEFOACAFN(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, TReceiver NHJPJMHIKLA, TAction KLIEOOEGDML, HMHIJIFOOKC LJLHNFKNEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F70190", Offset = "0x4F6ED90", VA = "0x184F70190")]
	private void GOODHFGMKMM(TReceiver NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EC00", Offset = "0x4F6D800", VA = "0x184F6EC00")]
	private void DEMEMAGGANJ(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, TReceiver NHJPJMHIKLA, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction KLIEOOEGDML, bool KEFDMLINKIO, bool ADNFGDKGOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4F6DF50", Offset = "0x4F6CB50", VA = "0x184F6DF50")]
	[AsyncStateMachine(typeof(ABMHJIEHPIL<, , , , , , , , >.BMKFHBKOMNE))]
	public Task COAIEGIDCID(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction[] HFLBAJAMEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4F70320", Offset = "0x4F6EF20", VA = "0x184F70320")]
	private (TAction, int) LMIBIIEBHNP(TRoot OLIIIAEGOLD, TNetSys OPPLCBEBFJJ, TAction KLIEOOEGDML)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GJDHOMEHADK
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface KPNNGKBLNKM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HDIHJDKNIEN(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MEINDMLNBGB(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction EEJFBOBHIDK(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> AABGEJBILDA(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] MJHNDIGJNKM(TNetSys JADMLIFJIID, TAction KLIEOOEGDML, int MNFKLFGIABP);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AHPNIMDEFNA(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DKJPDNNNNFE(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OHPNDLJJFIH(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OAGOBLDDBML(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool JAODNIPOAHN(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KBMNBHLGEPD(TNetSys JADMLIFJIID, TAction KLIEOOEGDML);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface KCLJCJPPNFK<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps KDNCIENNIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps JGJEKCHFEKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps ONDNDMJEEPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface CPPICEMGEJL<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		COMEADPNKEA<CFLJBDKGOMH> GFLCKHEHJFM(TReceiver NHJPJMHIKLA);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ALDBAEOOMPN(TReceiver NHJPJMHIKLA);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<IADHIMOENNN<object, KHGGKMBDLJL>> ENJILADPIFM(TReceiver NHJPJMHIKLA, TAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] COEPIFNJLIA(TReceiver NHJPJMHIKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface FJMCDEDNNIB<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LCICEAIGDHG(TRoot OLIIIAEGOLD);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OEEEIEEGGAG(TRoot OLIIIAEGOLD);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int FICNKOAPGNI(TRoot OLIIIAEGOLD);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PNIOAPJKMCE(TRoot OLIIIAEGOLD);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ELCFKCFOJDC(TRoot OLIIIAEGOLD);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OEFIAPBCIIK(TRoot OLIIIAEGOLD, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction[] MNCJLAMGDMC);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LDAABFHLFGL(TRoot OLIIIAEGOLD, int IHBCELLCMFC);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task DKHAACOFLDL(TRoot OLIIIAEGOLD, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, COMEADPNKEA<TMRequest> MANPAFALMMC, TAction KLIEOOEGDML, bool KPNPMGMKLNE = true);
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
