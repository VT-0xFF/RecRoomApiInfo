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
public struct ODEOBNPHKAF<TPartialAction, TFullAction, TDeps> where TDeps : PGOBAIBFGJE.EEAKMAGLMBJ<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] OODAOJLOGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int LLDEJCHLBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps LPKKIADABBC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x43475E0", Offset = "0x43467E0", VA = "0x1843475E0")]
	internal ODEOBNPHKAF(TPartialAction[] DGAPPPCDNMD, int GKACLOPAEMM, TDeps LJHLMAFOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43474C0", Offset = "0x43466C0", VA = "0x1843474C0")]
	public static ODEOBNPHKAF<TPartialAction, TFullAction, TDeps> MIFIOLMMIDE(TDeps LJHLMAFOMCA)
	{
		return default(ODEOBNPHKAF<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PGOBAIBFGJE
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EEAKMAGLMBJ<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DDCNPHKMOMF([In] TPartialAction HKAPDOJMFMP);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction KDFNKJAODNE(TPartialAction[] PJLMFPJCPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7850", Offset = "0x2FC6A50", VA = "0x182FC7850")]
	public static BMNACOJIPCO<TFullAction> LCMPEIBNOJH<TFullAction, TPartialAction, TDeps>(this ODEOBNPHKAF<TPartialAction, TFullAction, TDeps> AEFKHDNCNFD, TPartialAction HKAPDOJMFMP) where TDeps : EEAKMAGLMBJ<TPartialAction, TFullAction>
	{
		return default(BMNACOJIPCO<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JBDFIPCBALH<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : PEKAMIPLDOB.HIIDABOIFGO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] PONHCHLAPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int CCAJEINAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps LPKKIADABBC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43475E0", Offset = "0x43467E0", VA = "0x1843475E0")]
	internal JBDFIPCBALH(TPartialSnapshot[] MKPKDHOCDMC, int ICLHCJLDKLC, TDeps LJHLMAFOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43474C0", Offset = "0x43466C0", VA = "0x1843474C0")]
	public static JBDFIPCBALH<TPartialSnapshot, TFullSnapshot, TDeps> MIFIOLMMIDE(TDeps LJHLMAFOMCA)
	{
		return default(JBDFIPCBALH<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PEKAMIPLDOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HIIDABOIFGO<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FOPALMHIJIB([In] TPartialSnapshot EKBHMICEKBE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot PJCJCMDICJI(TPartialSnapshot[] PKPOOKOEJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FC53A0", Offset = "0x2FC45A0", VA = "0x182FC53A0")]
	public static BMNACOJIPCO<TFullSnapshot> LCMPEIBNOJH<TFullSnapshot, TPartialSnapshot, TDeps>(this JBDFIPCBALH<TPartialSnapshot, TFullSnapshot, TDeps> AEFKHDNCNFD, TPartialSnapshot EKBHMICEKBE) where TDeps : HIIDABOIFGO<TPartialSnapshot, TFullSnapshot>
	{
		return default(BMNACOJIPCO<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5730", Offset = "0x2FC4930", VA = "0x182FC5730")]
	public static bool PECMGNNFGJE<TPartialSnapshot, TFullSnapshot, TDeps>(this JBDFIPCBALH<TPartialSnapshot, TFullSnapshot, TDeps> AEFKHDNCNFD, TPartialSnapshot EKBHMICEKBE) where TDeps : HIIDABOIFGO<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NDDKBBODIOD : GDNNKDPAIAP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2219660", Offset = "0x2218860", VA = "0x182219660", Slot = "7")]
	public override string PBDEAEJPOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2219690", Offset = "0x2218890", VA = "0x182219690")]
	public NDDKBBODIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NOKNKFJPMLG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : HBIMPLJEHAG.BEEKGINOKHK<TAction, TNetSys> where TReceiverDeps : HBIMPLJEHAG.DFCICADBFEO<TAction, TReceiver> where TRootDeps : HBIMPLJEHAG.ELIPBOEIKKM<TMRequest, TAction, TRoot> where TDeps : HBIMPLJEHAG.JAKELDGCCEL<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface FECAEMLBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JEKPJKCKGAP([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EHLLHJACNLJ();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KJEOKHCIBGM<object, IJNOPJPLCIM> CGGIAIHDMFN();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IMBMAMBFHBK(Exception JIAKIFPLAMP);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class KHBNILGJDJO : FECAEMLBKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> EIIAFGEFOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<KJEOKHCIBGM<object, NDNNGNKGHFF>> CCEOMENFMEG;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x44A3050", Offset = "0x44A2250", VA = "0x1844A3050")]
		private KHBNILGJDJO(TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> HNKDADPHGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6C60", Offset = "0x3AD5E60", VA = "0x183AD6C60")]
		public static KHBNILGJDJO MIFIOLMMIDE(TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> HNKDADPHGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x44A2E90", Offset = "0x44A2090", VA = "0x1844A2E90")]
		public void JEKPJKCKGAP([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x44A2BD0", Offset = "0x44A1DD0", VA = "0x1844A2BD0", Slot = "5")]
		public void EHLLHJACNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x44A2A40", Offset = "0x44A1C40", VA = "0x1844A2A40", Slot = "6")]
		public KJEOKHCIBGM<object, IJNOPJPLCIM> CGGIAIHDMFN()
		{
			return default(KJEOKHCIBGM<object, IJNOPJPLCIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x44A2D10", Offset = "0x44A1F10", VA = "0x1844A2D10", Slot = "7")]
		public void IMBMAMBFHBK(Exception JIAKIFPLAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x434F840", Offset = "0x434EA40", VA = "0x18434F840", Slot = "4")]
		private void CFLLCDFGBEL([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JDMLDILIGIL : FECAEMLBKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> EIIAFGEFOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KJEOKHCIBGM<object, IJNOPJPLCIM> JMELFCOEOCO;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
		private JDMLDILIGIL(TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> HNKDADPHGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6C60", Offset = "0x3AD5E60", VA = "0x183AD6C60")]
		public static JDMLDILIGIL MIFIOLMMIDE(TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> HNKDADPHGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x434FA00", Offset = "0x434EC00", VA = "0x18434FA00")]
		public void JEKPJKCKGAP([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x434F8E0", Offset = "0x434EAE0", VA = "0x18434F8E0", Slot = "5")]
		public void EHLLHJACNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90B430", Offset = "0x90A630", VA = "0x18090B430", Slot = "6")]
		public KJEOKHCIBGM<object, IJNOPJPLCIM> CGGIAIHDMFN()
		{
			return default(KJEOKHCIBGM<object, IJNOPJPLCIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x434F940", Offset = "0x434EB40", VA = "0x18434F940", Slot = "7")]
		public void IMBMAMBFHBK(Exception JIAKIFPLAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x434F840", Offset = "0x434EA40", VA = "0x18434F840", Slot = "4")]
		private void CFLLCDFGBEL([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class OMHPABDHHOO : FECAEMLBKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<KJEOKHCIBGM<object, IJNOPJPLCIM>> CCEOMENFMEG;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x497F580", Offset = "0x497E780", VA = "0x18497F580")]
		private OMHPABDHHOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4783270", Offset = "0x4782470", VA = "0x184783270")]
		public static OMHPABDHHOO MIFIOLMMIDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x497F4A0", Offset = "0x497E6A0", VA = "0x18497F4A0")]
		public void JEKPJKCKGAP([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void EHLLHJACNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x497F2C0", Offset = "0x497E4C0", VA = "0x18497F2C0", Slot = "6")]
		public KJEOKHCIBGM<object, IJNOPJPLCIM> CGGIAIHDMFN()
		{
			return default(KJEOKHCIBGM<object, IJNOPJPLCIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x497F370", Offset = "0x497E570", VA = "0x18497F370", Slot = "7")]
		[NLMOIDEGKNH("This may be terminal and should probably do more than discarding the exception.")]
		public void IMBMAMBFHBK(Exception JIAKIFPLAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x434F840", Offset = "0x434EA40", VA = "0x18434F840", Slot = "4")]
		private void CFLLCDFGBEL([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MGEJFEACNCD : FECAEMLBKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KJEOKHCIBGM<object, IJNOPJPLCIM> JMELFCOEOCO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		private MGEJFEACNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4783270", Offset = "0x4782470", VA = "0x184783270")]
		public static MGEJFEACNCD MIFIOLMMIDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1BA79E0", Offset = "0x1BA6BE0", VA = "0x181BA79E0")]
		public void JEKPJKCKGAP([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void EHLLHJACNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA7FAC0", Offset = "0xA7ECC0", VA = "0x180A7FAC0", Slot = "6")]
		public KJEOKHCIBGM<object, IJNOPJPLCIM> CGGIAIHDMFN()
		{
			return default(KJEOKHCIBGM<object, IJNOPJPLCIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4783220", Offset = "0x4782420", VA = "0x184783220", Slot = "7")]
		[NLMOIDEGKNH("This may be terminal and should probably do more than discarding the exception.")]
		public void IMBMAMBFHBK(Exception JIAKIFPLAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x434F840", Offset = "0x434EA40", VA = "0x18434F840", Slot = "4")]
		private void CFLLCDFGBEL([In] KJEOKHCIBGM<object, IJNOPJPLCIM> KHPJAGHLNBM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DHEELEFDGPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NOKNKFJPMLG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GJCCLPKGONN<AGPJHJICIGM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BC30", Offset = "0x5B2AE30", VA = "0x185B2BC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B2C710", Offset = "0x5B2B910", VA = "0x185B2C710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BFOIONNHIHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NOKNKFJPMLG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GJCCLPKGONN<AGPJHJICIGM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x51CDD00", Offset = "0x51CCF00", VA = "0x1851CDD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51CE5C0", Offset = "0x51CD7C0", VA = "0x1851CE5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OJIIBBJBCDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NOKNKFJPMLG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GJCCLPKGONN<AGPJHJICIGM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GJCCLPKGONN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x49761F0", Offset = "0x49753F0", VA = "0x1849761F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49765D0", Offset = "0x49757D0", VA = "0x1849765D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CJNONFHDFPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NOKNKFJPMLG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GJCCLPKGONN<AGPJHJICIGM> senderId;

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
		public GJCCLPKGONN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FECAEMLBKJL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57C6080", Offset = "0x57C5280", VA = "0x1857C6080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57C7A20", Offset = "0x57C6C20", VA = "0x1857C7A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IDGLCKOFNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NOKNKFJPMLG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FECAEMLBKJL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FECAEMLBKJL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4107550", Offset = "0x4106750", VA = "0x184107550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x410B3B0", Offset = "0x410A5B0", VA = "0x18410B3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps LPKKIADABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<GJCCLPKGONN<TMRequest>, TaskCompletionSource<KJEOKHCIBGM<object, IJNOPJPLCIM>>> KDGLFHMIFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private AMHDPNBEEBI<TMRequest> EELHKACILFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PDOCKBMCMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task JNBLPKNEHGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps HFDKJKACJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x486A170", Offset = "0x4869370", VA = "0x18486A170")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps EGJCLAIGCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4869580", Offset = "0x4868780", VA = "0x184869580")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps OOFNAPNEBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4868E90", Offset = "0x4868090", VA = "0x184868E90")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ONMOIFOCBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xBCAB90", Offset = "0xBC9D90", VA = "0x180BCAB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x17F6310", Offset = "0x17F5510", VA = "0x1817F6310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IADMFAHKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1212C70", Offset = "0x1211E70", VA = "0x181212C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x20BF6D0", Offset = "0x20BE8D0", VA = "0x1820BF6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AOEPPHDCDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x486AD00", Offset = "0x4869F00", VA = "0x18486AD00")]
	public NOKNKFJPMLG(TDeps LJHLMAFOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4869760", Offset = "0x4868960", VA = "0x184869760")]
	public Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> ICHCHBDFADK(TRoot LPLEFLJFGNH, TNetSys FOOHAJJOBEH, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, TAction ECFGAICLGCA, bool DCDLPLKJNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4869AA0", Offset = "0x4868CA0", VA = "0x184869AA0")]
	[AsyncStateMachine(typeof(NOKNKFJPMLG<, , , , , , , , >.DHEELEFDGPD))]
	private Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> ICHCHBDFADK(TRoot LPLEFLJFGNH, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, TAction ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x486A300", Offset = "0x4869500", VA = "0x18486A300")]
	[AsyncStateMachine(typeof(NOKNKFJPMLG<, , , , , , , , >.BFOIONNHIHA))]
	private Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> NOJHCDCLOLK(TRoot LPLEFLJFGNH, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, TAction[] CHFBGJFMMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x486A460", Offset = "0x4869660", VA = "0x18486A460")]
	[AsyncStateMachine(typeof(NOKNKFJPMLG<, , , , , , , , >.OJIIBBJBCDF))]
	public Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> OACPMHKCACD(TRoot LPLEFLJFGNH, TNetSys LJMJODAHLIB, TReceiver CDBPAMBCOAE, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, GJCCLPKGONN<TMRequest> APBAMLHINFA, TAction ECFGAICLGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x486A9F0", Offset = "0x4869BF0", VA = "0x18486A9F0")]
	[AsyncStateMachine(typeof(NOKNKFJPMLG<, , , , , , , , >.CJNONFHDFPB))]
	private Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> PAKPHGIIKKB(TRoot LPLEFLJFGNH, TNetSys LJMJODAHLIB, TReceiver CDBPAMBCOAE, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, GJCCLPKGONN<TMRequest> APBAMLHINFA, TAction ECFGAICLGCA, Task EIHECFBJJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x486A740", Offset = "0x4869940", VA = "0x18486A740")]
	[AsyncStateMachine(typeof(NOKNKFJPMLG<, , , , , , , , >.IDGLCKOFNGI))]
	private Task OIEPPMNONEJ(TRoot LPLEFLJFGNH, TNetSys LJMJODAHLIB, TReceiver CDBPAMBCOAE, TAction ECFGAICLGCA, FECAEMLBKJL AFPPAMHNCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4868EC0", Offset = "0x48680C0", VA = "0x184868EC0")]
	private void CJFCELCHBKI(TRoot LPLEFLJFGNH, TNetSys LJMJODAHLIB, TReceiver CDBPAMBCOAE, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, TAction ECFGAICLGCA, bool KICGNHDAHGO, bool FGLEDNMHBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HBIMPLJEHAG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface BEEKGINOKHK<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FHJJOBGJABP(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction BECIFEAGIBF(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction CBDMMLHKBPC(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> NGLMEPNPNCB(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] KOMIDCGOMLK(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA, int FCGGPALAGHN);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NBONIHBFBAN(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool BBCKDEJNIAD(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BNCLDGBDFDC(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool EJGBFJFHCNI(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool LJNCEPIEEEI(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BLHECBGKCMC(TNetSys JKDKFMIKEAL, TAction ECFGAICLGCA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JAKELDGCCEL<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps HFDKJKACJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps OOFNAPNEBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps EGJCLAIGCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DFCICADBFEO<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GJCCLPKGONN<AGPJHJICIGM> NNELMDIEPOL(TReceiver CDBPAMBCOAE);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> OACPMHKCACD(TReceiver CDBPAMBCOAE, TAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] FOOOIEODNKN(TReceiver CDBPAMBCOAE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ELIPBOEIKKM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PIKIINDIJLN(TRoot LPLEFLJFGNH);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KEIDMNBFAEC(TRoot LPLEFLJFGNH);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int EHLPIPPCNKE(TRoot LPLEFLJFGNH);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MMGOMOBFNDI(TRoot LPLEFLJFGNH);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FBDCCOPLKJL(TRoot LPLEFLJFGNH);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task ICHCHBDFADK(TRoot LPLEFLJFGNH, GJCCLPKGONN<AGPJHJICIGM> HBHNJMJCEAB, GJCCLPKGONN<TMRequest> APBAMLHINFA, TAction ECFGAICLGCA, bool CGCBFFGFAKC = true);
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
