using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct BHBPOCEFBGG<TPartialAction, TFullAction, TDeps> where TDeps : EMHMHKCIFHB.EKJFLNMGEMN<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] CEPPBEKHJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int NCNAEFLEFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x442A6B0", Offset = "0x44290B0", VA = "0x18442A6B0")]
	internal BHBPOCEFBGG(TPartialAction[] DOHKOBNPNMK, int OPBKBBEFJFD, TDeps LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x442A600", Offset = "0x4429000", VA = "0x18442A600")]
	public static BHBPOCEFBGG<TPartialAction, TFullAction, TDeps> GGBAHLJJLHO(TDeps LAKCFHGOLJA)
	{
		return default(BHBPOCEFBGG<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EMHMHKCIFHB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EKJFLNMGEMN<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NJJKAJPOLFL([In] TPartialAction LGEGPBPIJEN);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction NOANCEBBCHI(TPartialAction[] GCGECJMEOOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BEF7E0", Offset = "0x2BEE1E0", VA = "0x182BEF7E0")]
	public static OLCEOJBLPLC<TFullAction> EMDCFNEBBEI<TFullAction, TPartialAction, TDeps>(this BHBPOCEFBGG<TPartialAction, TFullAction, TDeps> BJNJBGHPMEH, TPartialAction LGEGPBPIJEN) where TDeps : EKJFLNMGEMN<TPartialAction, TFullAction>
	{
		return default(OLCEOJBLPLC<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KHGNBNGFBDM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LPBANJKMDOB.ELFPKLHOBFD<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] NBBKMAIAHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int DEAOEPLAPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x442A6B0", Offset = "0x44290B0", VA = "0x18442A6B0")]
	internal KHGNBNGFBDM(TPartialSnapshot[] NJOKAGHEKGD, int LFBHAEHFGGN, TDeps LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x442A600", Offset = "0x4429000", VA = "0x18442A600")]
	public static KHGNBNGFBDM<TPartialSnapshot, TFullSnapshot, TDeps> GGBAHLJJLHO(TDeps LAKCFHGOLJA)
	{
		return default(KHGNBNGFBDM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LPBANJKMDOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ELFPKLHOBFD<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KLDOIHEMJFL([In] TPartialSnapshot IBEOBEHLBLA);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot AEFBJABAPOD(TPartialSnapshot[] AFLGGLEOMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E190", Offset = "0x2E5CB90", VA = "0x182E5E190")]
	public static OLCEOJBLPLC<TFullSnapshot> EMDCFNEBBEI<TFullSnapshot, TPartialSnapshot, TDeps>(this KHGNBNGFBDM<TPartialSnapshot, TFullSnapshot, TDeps> BJNJBGHPMEH, TPartialSnapshot IBEOBEHLBLA) where TDeps : ELFPKLHOBFD<TPartialSnapshot, TFullSnapshot>
	{
		return default(OLCEOJBLPLC<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E310", Offset = "0x2E5CD10", VA = "0x182E5E310")]
	public static bool IFCKOBLGPKD<TPartialSnapshot, TFullSnapshot, TDeps>(this KHGNBNGFBDM<TPartialSnapshot, TFullSnapshot, TDeps> BJNJBGHPMEH, TPartialSnapshot IBEOBEHLBLA) where TDeps : ELFPKLHOBFD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JJJFDPJNNAA : NGACCPLNJOL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2175000", Offset = "0x2173A00", VA = "0x182175000", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2175030", Offset = "0x2173A30", VA = "0x182175030")]
	public JJJFDPJNNAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MCCOHLECHIO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : CLPIGHBJMNE.KJKIDNIDONJ<TAction, TNetSys> where TReceiverDeps : CLPIGHBJMNE.DGPLBPMJBOM<TAction, TReceiver> where TRootDeps : CLPIGHBJMNE.DOBIHDNJLCD<TMRequest, TAction, TRoot> where TDeps : CLPIGHBJMNE.JALEDEOHMCN<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface EHDODDFOMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FODNJFOCEJK([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OGFNODCIBBJ();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BCLNLKLFCPB<object, OBJIPJOMIPB> JKIFFLOGNMN();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FHCKJAPMNFB(Exception NJACFNFHNDN);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class AGEBGCOANBI : EHDODDFOMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> JMHFKLMGNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<BCLNLKLFCPB<object, JHLAIJINHDF>> CLPPCJNCCIP;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D3E0", Offset = "0x3E7BDE0", VA = "0x183E7D3E0")]
		private AGEBGCOANBI(TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> NKDMIPFFBGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CF00", Offset = "0x3E7B900", VA = "0x183E7CF00")]
		public static AGEBGCOANBI GGBAHLJJLHO(TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> NKDMIPFFBGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CDE0", Offset = "0x3E7B7E0", VA = "0x183E7CDE0")]
		public void FODNJFOCEJK([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D220", Offset = "0x3E7BC20", VA = "0x183E7D220", Slot = "5")]
		public void OGFNODCIBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D090", Offset = "0x3E7BA90", VA = "0x183E7D090", Slot = "6")]
		public BCLNLKLFCPB<object, OBJIPJOMIPB> JKIFFLOGNMN()
		{
			return default(BCLNLKLFCPB<object, OBJIPJOMIPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CC60", Offset = "0x3E7B660", VA = "0x183E7CC60", Slot = "7")]
		public void FHCKJAPMNFB(Exception NJACFNFHNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D300", Offset = "0x3E7BD00", VA = "0x183E7D300", Slot = "4")]
		private void PAKLNGAKMAE([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class GICAMDGIMJO : EHDODDFOMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> JMHFKLMGNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BCLNLKLFCPB<object, OBJIPJOMIPB> PFDBFNHMNFO;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
		private GICAMDGIMJO(TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> NKDMIPFFBGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CF00", Offset = "0x3E7B900", VA = "0x183E7CF00")]
		public static GICAMDGIMJO GGBAHLJJLHO(TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> NKDMIPFFBGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A10E40", Offset = "0x3A0F840", VA = "0x183A10E40")]
		public void FODNJFOCEJK([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED87B0", Offset = "0x3ED71B0", VA = "0x183ED87B0", Slot = "5")]
		public void OGFNODCIBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE88380", Offset = "0xE86D80", VA = "0x180E88380", Slot = "6")]
		public BCLNLKLFCPB<object, OBJIPJOMIPB> JKIFFLOGNMN()
		{
			return default(BCLNLKLFCPB<object, OBJIPJOMIPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8690", Offset = "0x3ED7090", VA = "0x183ED8690", Slot = "7")]
		public void FHCKJAPMNFB(Exception NJACFNFHNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D300", Offset = "0x3E7BD00", VA = "0x183E7D300", Slot = "4")]
		private void PAKLNGAKMAE([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DPIHAGMADKH : EHDODDFOMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<BCLNLKLFCPB<object, OBJIPJOMIPB>> CLPPCJNCCIP;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D890", Offset = "0x5B5C290", VA = "0x185B5D890")]
		private DPIHAGMADKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x478D7C0", Offset = "0x478C1C0", VA = "0x18478D7C0")]
		public static DPIHAGMADKH GGBAHLJJLHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D580", Offset = "0x5B5BF80", VA = "0x185B5D580")]
		public void FODNJFOCEJK([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void OGFNODCIBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D740", Offset = "0x5B5C140", VA = "0x185B5D740", Slot = "6")]
		public BCLNLKLFCPB<object, OBJIPJOMIPB> JKIFFLOGNMN()
		{
			return default(BCLNLKLFCPB<object, OBJIPJOMIPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D4E0", Offset = "0x5B5BEE0", VA = "0x185B5D4E0", Slot = "7")]
		[EMDAHHLEKNJ("This may be terminal and should probably do more than discarding the exception.")]
		public void FHCKJAPMNFB(Exception NJACFNFHNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D300", Offset = "0x3E7BD00", VA = "0x183E7D300", Slot = "4")]
		private void PAKLNGAKMAE([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MOFFBFLKHJM : EHDODDFOMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BCLNLKLFCPB<object, OBJIPJOMIPB> PFDBFNHMNFO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		private MOFFBFLKHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x478D7C0", Offset = "0x478C1C0", VA = "0x18478D7C0")]
		public static MOFFBFLKHJM GGBAHLJJLHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1A88080", Offset = "0x1A86A80", VA = "0x181A88080")]
		public void FODNJFOCEJK([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void OGFNODCIBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20", Slot = "6")]
		public BCLNLKLFCPB<object, OBJIPJOMIPB> JKIFFLOGNMN()
		{
			return default(BCLNLKLFCPB<object, OBJIPJOMIPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x478D770", Offset = "0x478C170", VA = "0x18478D770", Slot = "7")]
		[EMDAHHLEKNJ("This may be terminal and should probably do more than discarding the exception.")]
		public void FHCKJAPMNFB(Exception NJACFNFHNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D300", Offset = "0x3E7BD00", VA = "0x183E7D300", Slot = "4")]
		private void PAKLNGAKMAE([In] BCLNLKLFCPB<object, OBJIPJOMIPB> POBDLJBBBCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DAFGOLHAPEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MCCOHLECHIO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MJGAEDNBJIL<DGAGHFGMOJF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B23A50", Offset = "0x5B22450", VA = "0x185B23A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B23FC0", Offset = "0x5B229C0", VA = "0x185B23FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CCNIMGJBNNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MCCOHLECHIO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MJGAEDNBJIL<DGAGHFGMOJF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x557B2B0", Offset = "0x5579CB0", VA = "0x18557B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x557BC20", Offset = "0x557A620", VA = "0x18557BC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IFDEOMKMPGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public MCCOHLECHIO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MJGAEDNBJIL<DGAGHFGMOJF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MJGAEDNBJIL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x404A540", Offset = "0x4048F40", VA = "0x18404A540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x404AC80", Offset = "0x4049680", VA = "0x18404AC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DPPEHHJJKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MCCOHLECHIO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MJGAEDNBJIL<DGAGHFGMOJF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MJGAEDNBJIL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private EHDODDFOMOP <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5B5DA40", Offset = "0x5B5C440", VA = "0x185B5DA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5B5F530", Offset = "0x5B5DF30", VA = "0x185B5F530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CMLLGPPKIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MCCOHLECHIO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public EHDODDFOMOP completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EHDODDFOMOP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x585AEA0", Offset = "0x58598A0", VA = "0x18585AEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x585EEC0", Offset = "0x585D8C0", VA = "0x18585EEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<MJGAEDNBJIL<TMRequest>, TaskCompletionSource<BCLNLKLFCPB<object, OBJIPJOMIPB>>> FIFOLOAEEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FNLAMAIPCEL<TMRequest> NFKHJANBKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int KNMLPAIBFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task DNFBPJPCOMK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps ONOEAJMLHFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4758EB0", Offset = "0x47578B0", VA = "0x184758EB0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps MPNCHMHHFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4758D10", Offset = "0x4757710", VA = "0x184758D10")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps FJJDAELLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x47584D0", Offset = "0x4756ED0", VA = "0x1847584D0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KGECNELGOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB7D340", Offset = "0xB7BD40", VA = "0x180B7D340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x16E6DE0", Offset = "0x16E57E0", VA = "0x1816E6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FJJCPACCAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x11A9250", Offset = "0x11A7C50", VA = "0x1811A9250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x201A530", Offset = "0x2018F30", VA = "0x18201A530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MMFCMHEPAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4759030", Offset = "0x4757A30", VA = "0x184759030")]
	public MCCOHLECHIO(TDeps LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4758660", Offset = "0x4757060", VA = "0x184758660")]
	public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> EMABKMAHOIP(TRoot JPBBEMPIGCM, TNetSys NMNDPAOCEFH, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, TAction PMCMEAHOBEF, bool ODAOKKACEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4758500", Offset = "0x4756F00", VA = "0x184758500")]
	[AsyncStateMachine(typeof(MCCOHLECHIO<, , , , , , , , >.DAFGOLHAPEM))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> EMABKMAHOIP(TRoot JPBBEMPIGCM, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, TAction PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x47581F0", Offset = "0x4756BF0", VA = "0x1847581F0")]
	[AsyncStateMachine(typeof(MCCOHLECHIO<, , , , , , , , >.CCNIMGJBNNN))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> AOEDJJOBLGE(TRoot JPBBEMPIGCM, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, TAction[] EENNPJMHNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4758D40", Offset = "0x4757740", VA = "0x184758D40")]
	[AsyncStateMachine(typeof(MCCOHLECHIO<, , , , , , , , >.IFDEOMKMPGC))]
	public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> IHEJBKOPHKO(TRoot JPBBEMPIGCM, TNetSys JDMBMLOJNMI, TReceiver PHPEHEJEKBD, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, MJGAEDNBJIL<TMRequest> DKJFIAGOKPG, TAction PMCMEAHOBEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4758350", Offset = "0x4756D50", VA = "0x184758350")]
	[AsyncStateMachine(typeof(MCCOHLECHIO<, , , , , , , , >.DPPEHHJJKKJ))]
	private Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> BMMPAEOAIDP(TRoot JPBBEMPIGCM, TNetSys JDMBMLOJNMI, TReceiver PHPEHEJEKBD, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, MJGAEDNBJIL<TMRequest> DKJFIAGOKPG, TAction PMCMEAHOBEF, Task HMEGDMMHLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4758EE0", Offset = "0x47578E0", VA = "0x184758EE0")]
	[AsyncStateMachine(typeof(MCCOHLECHIO<, , , , , , , , >.CMLLGPPKIPP))]
	private Task OLELKPNKIFL(TRoot JPBBEMPIGCM, TNetSys JDMBMLOJNMI, TReceiver PHPEHEJEKBD, TAction PMCMEAHOBEF, EHDODDFOMOP JDGGMGFIFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x47589E0", Offset = "0x47573E0", VA = "0x1847589E0")]
	private void GHFENGHFDMM(TRoot JPBBEMPIGCM, TNetSys JDMBMLOJNMI, TReceiver PHPEHEJEKBD, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, TAction PMCMEAHOBEF, bool JGCLADDLEKK, bool CIDJFKEPHPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CLPIGHBJMNE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KJKIDNIDONJ<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PBIHFPGECEM(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction CJIJFGLHFCK(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HCCEBIGFGKG(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> EEJOGACOINC(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] IHJIPFOCGOK(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF, int JPBCAMCEGCB);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool INFAKIJBNBJ(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LCBKKANPDKA(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IDFOHOCIBKH(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BCHHKPGBIIF(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HFBCLKIGHHI(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EAENEDBMMEI(TNetSys GHAOBMIKKNE, TAction PMCMEAHOBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JALEDEOHMCN<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps ONOEAJMLHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps FJJDAELLMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps MPNCHMHHFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DGPLBPMJBOM<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MJGAEDNBJIL<DGAGHFGMOJF> BFBMLNJPCMD(TReceiver PHPEHEJEKBD);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> IHEJBKOPHKO(TReceiver PHPEHEJEKBD, TAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BGMEACEJGHE(TReceiver PHPEHEJEKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface DOBIHDNJLCD<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JHOOLACIFLA(TRoot JPBBEMPIGCM);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FHAIOPCPGOG(TRoot JPBBEMPIGCM);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int OANEFFONLNL(TRoot JPBBEMPIGCM);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int FGKOLKBCGPL(TRoot JPBBEMPIGCM);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NJEDLOCACJJ(TRoot JPBBEMPIGCM);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task EMABKMAHOIP(TRoot JPBBEMPIGCM, MJGAEDNBJIL<DGAGHFGMOJF> MPNIFGFJIPM, MJGAEDNBJIL<TMRequest> DKJFIAGOKPG, TAction PMCMEAHOBEF, bool PMEGEMKDPNG = true);
	}
}
namespace Cpp2IlInjected;

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
