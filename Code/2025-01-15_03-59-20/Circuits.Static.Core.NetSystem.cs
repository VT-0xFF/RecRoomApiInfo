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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x234D430", Offset = "0x234C830", VA = "0x18234D430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OMAPHECMAHG : JMMAFLLBCOF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x234D4B0", Offset = "0x234C8B0", VA = "0x18234D4B0", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x234D420", Offset = "0x234C820", VA = "0x18234D420")]
	private OMAPHECMAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x234D4E0", Offset = "0x234C8E0", VA = "0x18234D4E0")]
	public static OMAPHECMAHG ODOFIFAGLAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FLNEFILAEJL<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, ADBLJHAIMGH.CPAHDHBOHHN<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EJKFMFMMCKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] DKMCJBJDGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int CEGMJKJMCND;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD2E870", Offset = "0xD2DC70", VA = "0x180D2E870")]
		private EJKFMFMMCKG(TPartialAction[] IJKOGECLBJG, int AEMLLAKDCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB210", Offset = "0x3CCA610", VA = "0x183CCB210")]
		public static FLNEFILAEJL<TPartialAction, TPartialActionId, TFullAction, TDeps>.EJKFMFMMCKG ODOFIFAGLAJ(int HNPBEKCAADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB0C0", Offset = "0x3CCA4C0", VA = "0x183CCB0C0")]
		public GPPELIJDOJB<TFullAction> LCHNDNHJGMB(TPartialAction BKMJPEKIFBP, TDeps CFAPAOIIPAA)
		{
			return default(GPPELIJDOJB<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, EJKFMFMMCKG>? PELKHAFOFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps OIKLGOFBDMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, EJKFMFMMCKG> CGHEMEBBIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x40A8B20", Offset = "0x40A7F20", VA = "0x1840A8B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40A9C20", Offset = "0x40A9020", VA = "0x1840A9C20")]
	private FLNEFILAEJL(Dictionary<TPartialActionId, EJKFMFMMCKG>? BPBKBEJLACK, TDeps CFAPAOIIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x40A9BD0", Offset = "0x40A8FD0", VA = "0x1840A9BD0")]
	public static FLNEFILAEJL<TPartialAction, TPartialActionId, TFullAction, TDeps> ODOFIFAGLAJ(TDeps CFAPAOIIPAA)
	{
		return default(FLNEFILAEJL<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x40A9480", Offset = "0x40A8880", VA = "0x1840A9480")]
	public ABNAGONECLM<GPPELIJDOJB<TFullAction>, IAAGGMEHHFI> LCHNDNHJGMB(TPartialAction BKMJPEKIFBP)
	{
		return default(ABNAGONECLM<GPPELIJDOJB<TFullAction>, IAAGGMEHHFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40A8A60", Offset = "0x40A7E60", VA = "0x1840A8A60")]
	public void INBHMKLKIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ADBLJHAIMGH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CPAHDHBOHHN<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KPDLEJHHFIM([In] TPartialAction BKMJPEKIFBP);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JDPKJCHNKBI([In] TPartialAction BKMJPEKIFBP);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId FGFALFHCJEF([In] TPartialAction BKMJPEKIFBP);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction BNIIOLMLNKD(TPartialAction[] KKNMPCLHGNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GMPCAACGKJP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : DDEEBJIOBPL.MFCHOLONLOD<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] ALEJACJIPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int BDEMFJLDKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps OIKLGOFBDMC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x41A9AC0", Offset = "0x41A8EC0", VA = "0x1841A9AC0")]
	internal GMPCAACGKJP(TPartialSnapshot[] ILIMIKLONJE, int GLFMIEKEBKN, TDeps CFAPAOIIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x41A9A60", Offset = "0x41A8E60", VA = "0x1841A9A60")]
	public static GMPCAACGKJP<TPartialSnapshot, TFullSnapshot, TDeps> ODOFIFAGLAJ(TDeps CFAPAOIIPAA)
	{
		return default(GMPCAACGKJP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DDEEBJIOBPL
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface MFCHOLONLOD<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KFNJGJCBCON([In] TPartialSnapshot CONAAJKMBJN);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot CCNPAKJBKPC(TPartialSnapshot[] GBGOJPLMHPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2E93BE0", Offset = "0x2E92FE0", VA = "0x182E93BE0")]
	public static GPPELIJDOJB<TFullSnapshot> LCHNDNHJGMB<TFullSnapshot, TPartialSnapshot, TDeps>(this GMPCAACGKJP<TPartialSnapshot, TFullSnapshot, TDeps> MPLBPEBNKFP, TPartialSnapshot CONAAJKMBJN) where TDeps : MFCHOLONLOD<TPartialSnapshot, TFullSnapshot>
	{
		return default(GPPELIJDOJB<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E93AA0", Offset = "0x2E92EA0", VA = "0x182E93AA0")]
	public static bool HCLHCMAHACP<TPartialSnapshot, TFullSnapshot, TDeps>(this GMPCAACGKJP<TPartialSnapshot, TFullSnapshot, TDeps> MPLBPEBNKFP, TPartialSnapshot CONAAJKMBJN) where TDeps : MFCHOLONLOD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FAEOHNLMJMM : JMMAFLLBCOF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x234D3F0", Offset = "0x234C7F0", VA = "0x18234D3F0", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x234D420", Offset = "0x234C820", VA = "0x18234D420")]
	public FAEOHNLMJMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : KKLBFHFGGKP.DLLOBHHPIKL<TAction, TNetSys> where TReceiverDeps : KKLBFHFGGKP.NCJNPBNMBKJ<TAction, TReceiver> where TRootDeps : KKLBFHFGGKP.HJEGEFPJLCF<TMRequest, TAction, TRoot> where TDeps : KKLBFHFGGKP.IKADKHOGHKM<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface BNMOEJHNKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CJDLCNHFNEL([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MAHBIGAKCOP();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ABNAGONECLM<object, IAAGGMEHHFI> BEIGOFEJLLB();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ALKBDJJOEOL(Exception DIPLOOHMPFH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class IHEIJPEKOKJ : BNMOEJHNKGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> FOCNGIJJILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<ABNAGONECLM<object, NAONGKGFBLO>> PFBMABHPDGE;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x434EEE0", Offset = "0x434E2E0", VA = "0x18434EEE0")]
		private IHEIJPEKOKJ(TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> NOJOJIMAJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x40A4C20", Offset = "0x40A4020", VA = "0x1840A4C20")]
		public static IHEIJPEKOKJ ODOFIFAGLAJ(TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> NOJOJIMAJMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x434EAE0", Offset = "0x434DEE0", VA = "0x18434EAE0")]
		public void CJDLCNHFNEL([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x434EE00", Offset = "0x434E200", VA = "0x18434EE00", Slot = "5")]
		public void MAHBIGAKCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x434E980", Offset = "0x434DD80", VA = "0x18434E980", Slot = "6")]
		public ABNAGONECLM<object, IAAGGMEHHFI> BEIGOFEJLLB()
		{
			return default(ABNAGONECLM<object, IAAGGMEHHFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x434E920", Offset = "0x434DD20", VA = "0x18434E920", Slot = "7")]
		public void ALKBDJJOEOL(Exception DIPLOOHMPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x40532B0", Offset = "0x40526B0", VA = "0x1840532B0", Slot = "4")]
		private void HMPCLLNIKGH([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class FKBLKEOGHAL : BNMOEJHNKGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> FOCNGIJJILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private ABNAGONECLM<object, IAAGGMEHHFI> HNEEKBFGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
		private FKBLKEOGHAL(TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> NOJOJIMAJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x40A4C20", Offset = "0x40A4020", VA = "0x1840A4C20")]
		public static FKBLKEOGHAL ODOFIFAGLAJ(TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> NOJOJIMAJMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x40A4B40", Offset = "0x40A3F40", VA = "0x1840A4B40")]
		public void CJDLCNHFNEL([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x40A4BC0", Offset = "0x40A3FC0", VA = "0x1840A4BC0", Slot = "5")]
		public void MAHBIGAKCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10", Slot = "6")]
		public ABNAGONECLM<object, IAAGGMEHHFI> BEIGOFEJLLB()
		{
			return default(ABNAGONECLM<object, IAAGGMEHHFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40A4A80", Offset = "0x40A3E80", VA = "0x1840A4A80", Slot = "7")]
		public void ALKBDJJOEOL(Exception DIPLOOHMPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x40532B0", Offset = "0x40526B0", VA = "0x1840532B0", Slot = "4")]
		private void HMPCLLNIKGH([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PLGPPDLHNPG : BNMOEJHNKGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<ABNAGONECLM<object, IAAGGMEHHFI>> PFBMABHPDGE;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4C738F0", Offset = "0x4C72CF0", VA = "0x184C738F0")]
		private PLGPPDLHNPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40532F0", Offset = "0x40526F0", VA = "0x1840532F0")]
		public static PLGPPDLHNPG ODOFIFAGLAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4C73730", Offset = "0x4C72B30", VA = "0x184C73730")]
		public void CJDLCNHFNEL([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void MAHBIGAKCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C73670", Offset = "0x4C72A70", VA = "0x184C73670", Slot = "6")]
		public ABNAGONECLM<object, IAAGGMEHHFI> BEIGOFEJLLB()
		{
			return default(ABNAGONECLM<object, IAAGGMEHHFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4C735D0", Offset = "0x4C729D0", VA = "0x184C735D0", Slot = "7")]
		[FAOCFIAPHCP("This may be terminal and should probably do more than discarding the exception.")]
		public void ALKBDJJOEOL(Exception DIPLOOHMPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x40532B0", Offset = "0x40526B0", VA = "0x1840532B0", Slot = "4")]
		private void HMPCLLNIKGH([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class FCAHDEFGEFA : BNMOEJHNKGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ABNAGONECLM<object, IAAGGMEHHFI> HNEEKBFGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private FCAHDEFGEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x40532F0", Offset = "0x40526F0", VA = "0x1840532F0")]
		public static FCAHDEFGEFA ODOFIFAGLAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1CC9D30", Offset = "0x1CC9130", VA = "0x181CC9D30")]
		public void CJDLCNHFNEL([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void MAHBIGAKCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB5FC10", Offset = "0xB5F010", VA = "0x180B5FC10", Slot = "6")]
		public ABNAGONECLM<object, IAAGGMEHHFI> BEIGOFEJLLB()
		{
			return default(ABNAGONECLM<object, IAAGGMEHHFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4053210", Offset = "0x4052610", VA = "0x184053210", Slot = "7")]
		[FAOCFIAPHCP("This may be terminal and should probably do more than discarding the exception.")]
		public void ALKBDJJOEOL(Exception DIPLOOHMPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x40532B0", Offset = "0x40526B0", VA = "0x1840532B0", Slot = "4")]
		private void HMPCLLNIKGH([In] ABNAGONECLM<object, IAAGGMEHHFI> CEDDFJCBLGM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FKIMNECPJFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AHPCDKCOAJM<APADOHEFPGP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x40A4F10", Offset = "0x40A4310", VA = "0x1840A4F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x40A5A30", Offset = "0x40A4E30", VA = "0x1840A5A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GHELPOLOOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AHPCDKCOAJM<APADOHEFPGP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4198470", Offset = "0x4197870", VA = "0x184198470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4198DE0", Offset = "0x41981E0", VA = "0x184198DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NLGFGHOLHFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AHPCDKCOAJM<APADOHEFPGP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AHPCDKCOAJM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4A9B720", Offset = "0x4A9AB20", VA = "0x184A9B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4A9BDF0", Offset = "0x4A9B1F0", VA = "0x184A9BDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HPEKKBDCJKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AHPCDKCOAJM<APADOHEFPGP> senderId;

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
		public AHPCDKCOAJM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private BNMOEJHNKGN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4275A10", Offset = "0x4274E10", VA = "0x184275A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4276730", Offset = "0x4275B30", VA = "0x184276730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct JOBGDKEAGJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BNMOEJHNKGN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private BNMOEJHNKGN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<ABNAGONECLM<object?, IAAGGMEHHFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x45993F0", Offset = "0x45987F0", VA = "0x1845993F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x459D580", Offset = "0x459C980", VA = "0x18459D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EMFLFODJCJE : IAsyncStateMachine
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
		public DNPFEOLOPMB<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AHPCDKCOAJM<APADOHEFPGP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC5B0", Offset = "0x3CDB9B0", VA = "0x183CDC5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC930", Offset = "0x3CDBD30", VA = "0x183CDC930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps OIKLGOFBDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<AHPCDKCOAJM<TMRequest>, TaskCompletionSource<ABNAGONECLM<object, IAAGGMEHHFI>>> KIMOGMDJNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PCDCNFJJHBF<TMRequest> HPACDIBMOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MFIOCOHCIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int BBBHHINPHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task MGKNGEAHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int HGIFFJKMHPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps KFGBDAEFOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E89DF0", Offset = "0x5E891F0", VA = "0x185E89DF0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps OEIMAKOFAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A180", Offset = "0x5E89580", VA = "0x185E8A180")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps IHBCNEDPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E882B0", Offset = "0x5E876B0", VA = "0x185E882B0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DPMKFNAHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96F840", Offset = "0x96EC40", VA = "0x18096F840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96FA30", Offset = "0x96EE30", VA = "0x18096FA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BPEIPFMLMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C50", Offset = "0x8C8050", VA = "0x1808C8C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OJMACCJIGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E4C50", Offset = "0x8E4050", VA = "0x1808E4C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A750", Offset = "0x5E89B50", VA = "0x185E8A750")]
	public DNPFEOLOPMB(TDeps CFAPAOIIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E89860", Offset = "0x5E88C60", VA = "0x185E89860")]
	public Task<ABNAGONECLM<object, IAAGGMEHHFI>> DIBJHJHPMFL(TRoot NIMLNKDMKHI, TNetSys PODGMDDMABO, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, TAction OLHFOBIBHCJ, bool AECCPLEBFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E895A0", Offset = "0x5E889A0", VA = "0x185E895A0")]
	[AsyncStateMachine(typeof(DNPFEOLOPMB<, , , , , , , , >.FKIMNECPJFO))]
	private Task<ABNAGONECLM<object, IAAGGMEHHFI>> DIBJHJHPMFL(TRoot NIMLNKDMKHI, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, TAction OLHFOBIBHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E89FD0", Offset = "0x5E893D0", VA = "0x185E89FD0")]
	[AsyncStateMachine(typeof(DNPFEOLOPMB<, , , , , , , , >.GHELPOLOOBN))]
	private Task<ABNAGONECLM<object, IAAGGMEHHFI>> NJIDFONBDLB(TRoot NIMLNKDMKHI, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, TAction[] GAEGLPHPPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E88460", Offset = "0x5E87860", VA = "0x185E88460")]
	[AsyncStateMachine(typeof(DNPFEOLOPMB<, , , , , , , , >.NLGFGHOLHFL))]
	public Task<ABNAGONECLM<object, IAAGGMEHHFI>> CGIHCOLCIHO(TRoot NIMLNKDMKHI, TNetSys FMEGFPGAECE, TReceiver NCFNENNCOJO, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, AHPCDKCOAJM<TMRequest> FIBHIHHMBFF, TAction OLHFOBIBHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A340", Offset = "0x5E89740", VA = "0x185E8A340")]
	[AsyncStateMachine(typeof(DNPFEOLOPMB<, , , , , , , , >.HPEKKBDCJKC))]
	private Task<ABNAGONECLM<object, IAAGGMEHHFI>> NPLKMJCGBEH(TRoot NIMLNKDMKHI, TNetSys FMEGFPGAECE, TReceiver NCFNENNCOJO, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, AHPCDKCOAJM<TMRequest> FIBHIHHMBFF, TAction OLHFOBIBHCJ, Task BIHJAFOPJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E885D0", Offset = "0x5E879D0", VA = "0x185E885D0")]
	[AsyncStateMachine(typeof(DNPFEOLOPMB<, , , , , , , , >.JOBGDKEAGJN))]
	private Task CHLICJEDHNE(TRoot NIMLNKDMKHI, TNetSys FMEGFPGAECE, TReceiver NCFNENNCOJO, TAction OLHFOBIBHCJ, BNMOEJHNKGN AFBJCAIFEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E89D60", Offset = "0x5E89160", VA = "0x185E89D60")]
	private void FKDOIIFDEHP(TReceiver NCFNENNCOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E88880", Offset = "0x5E87C80", VA = "0x185E88880")]
	private void DDGMPCHGBDI(TRoot NIMLNKDMKHI, TNetSys FMEGFPGAECE, TReceiver NCFNENNCOJO, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, TAction OLHFOBIBHCJ, bool FFKMADIBCIE, bool EALJMJKKGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A4C0", Offset = "0x5E898C0", VA = "0x185E8A4C0")]
	[AsyncStateMachine(typeof(DNPFEOLOPMB<, , , , , , , , >.EMFLFODJCJE))]
	public Task ODNMHGPONBH(TRoot NIMLNKDMKHI, TNetSys FMEGFPGAECE, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, TAction[] PNEMANFNDJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KKLBFHFGGKP
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface DLLOBHHPIKL<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JEJCANPELGG(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction LHBEKALPJJH(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction GHPBCHIBMKJ(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> AGCHFLFECOM(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] IFABCMMHNCD(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ, int CKLLDOCGFDG);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BCBDDPFOOMF(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JGDMGPPOAID(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OLADNCOAAFH(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JLNAAFAIOPD(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool LIKJIJKKKOJ(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IHFHHIHGGEF(TNetSys LGKJMLLHKCN, TAction OLHFOBIBHCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface IKADKHOGHKM<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps KFGBDAEFOLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps IHBCNEDPNGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps OEIMAKOFAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface NCJNPBNMBKJ<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AHPCDKCOAJM<APADOHEFPGP> IMLIGOOGFGH(TReceiver NCFNENNCOJO);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NKDBPFGGBAI(TReceiver NCFNENNCOJO);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<ABNAGONECLM<object, IAAGGMEHHFI>> CGIHCOLCIHO(TReceiver NCFNENNCOJO, TAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] MEIHMPDNGIH(TReceiver NCFNENNCOJO);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface HJEGEFPJLCF<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AALJCCKIJCN(TRoot NIMLNKDMKHI);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DDMCPGIJDHI(TRoot NIMLNKDMKHI);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int OPGJCGFJNON(TRoot NIMLNKDMKHI);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NAEBHHDMLHL(TRoot NIMLNKDMKHI);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BFGHNAHJPHC(TRoot NIMLNKDMKHI);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FFLJOFOONDB(TRoot NIMLNKDMKHI, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, TAction[] GAEGLPHPPHO);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task DIBJHJHPMFL(TRoot NIMLNKDMKHI, AHPCDKCOAJM<APADOHEFPGP> OAAKGEPPNGN, AHPCDKCOAJM<TMRequest> FIBHIHHMBFF, TAction OLHFOBIBHCJ, bool GAOKENEPGPG = true);
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
