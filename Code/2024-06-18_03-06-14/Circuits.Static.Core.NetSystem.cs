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
public struct OAPFFJLMNLA<TPartialAction, TFullAction, TDeps> where TDeps : ENGINCFDICI.OBJHBMACLEH<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LBLKEJAMJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int ADHPHJMCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x37CB900", Offset = "0x37CA300", VA = "0x1837CB900")]
	internal OAPFFJLMNLA(TPartialAction[] LADPIDPCAGB, int GFKABIINMOH, TDeps GMLBPALEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37CB7E0", Offset = "0x37CA1E0", VA = "0x1837CB7E0")]
	public static OAPFFJLMNLA<TPartialAction, TFullAction, TDeps> KHKANEAPNIK(TDeps GMLBPALEECE)
	{
		return default(OAPFFJLMNLA<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ENGINCFDICI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface OBJHBMACLEH<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IJDDDMOJDPN([In] TPartialAction BILACMLHEFB);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction KBMLGFJBODG(TPartialAction[] PDPAGCDDBBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29BB3C0", Offset = "0x29B9DC0", VA = "0x1829BB3C0")]
	public static ABMFALHKFKK<TFullAction> OICCOMJKNDM<TFullAction, TPartialAction, TDeps>(this OAPFFJLMNLA<TPartialAction, TFullAction, TDeps> BBCPNLGGBMJ, TPartialAction BILACMLHEFB) where TDeps : OBJHBMACLEH<TPartialAction, TFullAction>
	{
		return default(ABMFALHKFKK<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EAMFAHDFHOF<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LMNCKBKCPHC.EAMGEDGIIOG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] HIGMANBHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int EDKJFPKPOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37CB900", Offset = "0x37CA300", VA = "0x1837CB900")]
	internal EAMFAHDFHOF(TPartialSnapshot[] JJGMPNBJONA, int KGPNAFLDDFK, TDeps GMLBPALEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37CB7E0", Offset = "0x37CA1E0", VA = "0x1837CB7E0")]
	public static EAMFAHDFHOF<TPartialSnapshot, TFullSnapshot, TDeps> KHKANEAPNIK(TDeps GMLBPALEECE)
	{
		return default(EAMFAHDFHOF<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LMNCKBKCPHC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface EAMGEDGIIOG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AEAJHHDGEFA([In] TPartialSnapshot EBMLBMIHNBE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot OAACDPFMFHN(TPartialSnapshot[] NLMNKCPBKNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BE18E0", Offset = "0x2BE02E0", VA = "0x182BE18E0")]
	public static ABMFALHKFKK<TFullSnapshot> OICCOMJKNDM<TFullSnapshot, TPartialSnapshot, TDeps>(this EAMFAHDFHOF<TPartialSnapshot, TFullSnapshot, TDeps> BBCPNLGGBMJ, TPartialSnapshot EBMLBMIHNBE) where TDeps : EAMGEDGIIOG<TPartialSnapshot, TFullSnapshot>
	{
		return default(ABMFALHKFKK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BE17A0", Offset = "0x2BE01A0", VA = "0x182BE17A0")]
	public static bool JOFEDEKPDDP<TPartialSnapshot, TFullSnapshot, TDeps>(this EAMFAHDFHOF<TPartialSnapshot, TFullSnapshot, TDeps> BBCPNLGGBMJ, TPartialSnapshot EBMLBMIHNBE) where TDeps : EAMGEDGIIOG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EDIHKLODDFE : GACFHBDKGHN
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF6A0", Offset = "0x1FBE0A0", VA = "0x181FBF6A0", Slot = "7")]
	public override string BMFLCAMIMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF6D0", Offset = "0x1FBE0D0", VA = "0x181FBF6D0")]
	public EDIHKLODDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DHBLPLACKMH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FKPGAEPJDNF.LLEPLJPJKKB<TAction, TNetSys> where TReceiverDeps : FKPGAEPJDNF.EMLEGDJAHBO<TAction, TReceiver> where TRootDeps : FKPGAEPJDNF.IDGCACBMEDN<TMRequest, TAction, TRoot> where TDeps : FKPGAEPJDNF.KAPHIAMEFBL<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface FHNHOFCFHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NMJLBNNKECI([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HAJFBMCCANO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FNBKHJCMJJM<object, AEFDHDNANIN> ONBLBBKODON();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GKFCHDBCNEI(Exception JKHACPOPJJF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class DKPMNMJFAKF : FHNHOFCFHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> JFFDILALFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<FNBKHJCMJJM<object, LHAJNHDLEEF>> KFHDKAHENIB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x57CAEF0", Offset = "0x57C98F0", VA = "0x1857CAEF0")]
		private DKPMNMJFAKF(TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> PHLJDCJAGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x405CF40", Offset = "0x405B940", VA = "0x18405CF40")]
		public static DKPMNMJFAKF KHKANEAPNIK(TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> PHLJDCJAGMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x57CAAB0", Offset = "0x57C94B0", VA = "0x1857CAAB0")]
		public void NMJLBNNKECI([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x57CA8F0", Offset = "0x57C92F0", VA = "0x1857CA8F0", Slot = "5")]
		public void HAJFBMCCANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57CACF0", Offset = "0x57C96F0", VA = "0x1857CACF0", Slot = "6")]
		public FNBKHJCMJJM<object, AEFDHDNANIN> ONBLBBKODON()
		{
			return default(FNBKHJCMJJM<object, AEFDHDNANIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x57CA890", Offset = "0x57C9290", VA = "0x1857CA890", Slot = "7")]
		public void GKFCHDBCNEI(Exception JKHACPOPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3844050", Offset = "0x3842A50", VA = "0x183844050", Slot = "4")]
		private void FCICMPPCIFJ([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JFMDJFOFHMI : FHNHOFCFHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> JFFDILALFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private FNBKHJCMJJM<object, AEFDHDNANIN> EDMGOLKCKHN;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
		private JFMDJFOFHMI(TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> PHLJDCJAGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x405CF40", Offset = "0x405B940", VA = "0x18405CF40")]
		public static JFMDJFOFHMI KHKANEAPNIK(TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> PHLJDCJAGMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3832F00", Offset = "0x3831900", VA = "0x183832F00")]
		public void NMJLBNNKECI([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x405CEE0", Offset = "0x405B8E0", VA = "0x18405CEE0", Slot = "5")]
		public void HAJFBMCCANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC2A030", Offset = "0xC28A30", VA = "0x180C2A030", Slot = "6")]
		public FNBKHJCMJJM<object, AEFDHDNANIN> ONBLBBKODON()
		{
			return default(FNBKHJCMJJM<object, AEFDHDNANIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x405CE20", Offset = "0x405B820", VA = "0x18405CE20", Slot = "7")]
		public void GKFCHDBCNEI(Exception JKHACPOPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3844050", Offset = "0x3842A50", VA = "0x183844050", Slot = "4")]
		private void FCICMPPCIFJ([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EFJKGNAEGBP : FHNHOFCFHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<FNBKHJCMJJM<object, AEFDHDNANIN>> KFHDKAHENIB;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3844470", Offset = "0x3842E70", VA = "0x183844470")]
		private EFJKGNAEGBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3844130", Offset = "0x3842B30", VA = "0x183844130")]
		public static EFJKGNAEGBP KHKANEAPNIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38442D0", Offset = "0x3842CD0", VA = "0x1838442D0")]
		public void NMJLBNNKECI([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void HAJFBMCCANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38443B0", Offset = "0x3842DB0", VA = "0x1838443B0", Slot = "6")]
		public FNBKHJCMJJM<object, AEFDHDNANIN> ONBLBBKODON()
		{
			return default(FNBKHJCMJJM<object, AEFDHDNANIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x38440E0", Offset = "0x3842AE0", VA = "0x1838440E0", Slot = "7")]
		[AFLDEPHJFEH("This may be terminal and should probably do more than discarding the exception.")]
		public void GKFCHDBCNEI(Exception JKHACPOPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3844050", Offset = "0x3842A50", VA = "0x183844050", Slot = "4")]
		private void FCICMPPCIFJ([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MHCGFDNMHJE : FHNHOFCFHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FNBKHJCMJJM<object, AEFDHDNANIN> EDMGOLKCKHN;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		private MHCGFDNMHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3844130", Offset = "0x3842B30", VA = "0x183844130")]
		public static MHCGFDNMHJE KHKANEAPNIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x16E9D20", Offset = "0x16E8720", VA = "0x1816E9D20")]
		public void NMJLBNNKECI([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void HAJFBMCCANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0", Slot = "6")]
		public FNBKHJCMJJM<object, AEFDHDNANIN> ONBLBBKODON()
		{
			return default(FNBKHJCMJJM<object, AEFDHDNANIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4471580", Offset = "0x446FF80", VA = "0x184471580", Slot = "7")]
		[AFLDEPHJFEH("This may be terminal and should probably do more than discarding the exception.")]
		public void GKFCHDBCNEI(Exception JKHACPOPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3844050", Offset = "0x3842A50", VA = "0x183844050", Slot = "4")]
		private void FCICMPPCIFJ([In] FNBKHJCMJJM<object, AEFDHDNANIN> EBPHIJANMPN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JMNONDHNNKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DHBLPLACKMH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AEAOKLPMJLF<JDFEFHNOHPF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4105360", Offset = "0x4103D60", VA = "0x184105360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4105840", Offset = "0x4104240", VA = "0x184105840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EPCHIELJFGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DHBLPLACKMH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AEAOKLPMJLF<JDFEFHNOHPF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x387C6A0", Offset = "0x387B0A0", VA = "0x18387C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x387CFD0", Offset = "0x387B9D0", VA = "0x18387CFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GGAELJCBKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DHBLPLACKMH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AEAOKLPMJLF<JDFEFHNOHPF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AEAOKLPMJLF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D28110", Offset = "0x3D26B10", VA = "0x183D28110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D287E0", Offset = "0x3D271E0", VA = "0x183D287E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BAOADNFLILK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public DHBLPLACKMH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AEAOKLPMJLF<JDFEFHNOHPF> senderId;

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
		public AEAOKLPMJLF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FHNHOFCFHHO <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4DD4420", Offset = "0x4DD2E20", VA = "0x184DD4420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4DD5E40", Offset = "0x4DD4840", VA = "0x184DD5E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ECPGJBBPKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DHBLPLACKMH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FHNHOFCFHHO completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FHNHOFCFHHO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x38378B0", Offset = "0x38362B0", VA = "0x1838378B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x383B910", Offset = "0x383A310", VA = "0x18383B910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<AEAOKLPMJLF<TMRequest>, TaskCompletionSource<FNBKHJCMJJM<object, AEFDHDNANIN>>> AFKCCFJIIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NKDEMEAACMH<TMRequest> IFNLHNMEEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int HGAIIIODCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GDKGGLPMBCD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps ANOEMOHMOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x57BC700", Offset = "0x57BB100", VA = "0x1857BC700")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps BKFNFENCJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57BB640", Offset = "0x57BA040", VA = "0x1857BB640")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps FINFAIDGIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57BAF80", Offset = "0x57B9980", VA = "0x1857BAF80")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LPAFLFLGKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9154E0", Offset = "0x913EE0", VA = "0x1809154E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1377FC0", Offset = "0x13769C0", VA = "0x181377FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DLJFLLANLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF2C160", Offset = "0xF2AB60", VA = "0x180F2C160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E65130", Offset = "0x1E63B30", VA = "0x181E65130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OCBBELFNEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8566A0", Offset = "0x8550A0", VA = "0x1808566A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57BCE40", Offset = "0x57BB840", VA = "0x1857BCE40")]
	public DHBLPLACKMH(TDeps GMLBPALEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57BBCF0", Offset = "0x57BA6F0", VA = "0x1857BBCF0")]
	public Task<FNBKHJCMJJM<object, AEFDHDNANIN>> MDLDPHPDFHK(TRoot GPKGNPPAAHE, TNetSys DHOMLJPHINM, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, TAction GKKKLNHPKBN, bool EILLGIEGMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57BC030", Offset = "0x57BAA30", VA = "0x1857BC030")]
	[AsyncStateMachine(typeof(DHBLPLACKMH<, , , , , , , , >.JMNONDHNNKM))]
	private Task<FNBKHJCMJJM<object, AEFDHDNANIN>> MDLDPHPDFHK(TRoot GPKGNPPAAHE, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, TAction GKKKLNHPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57BC5A0", Offset = "0x57BAFA0", VA = "0x1857BC5A0")]
	[AsyncStateMachine(typeof(DHBLPLACKMH<, , , , , , , , >.EPCHIELJFGF))]
	private Task<FNBKHJCMJJM<object, AEFDHDNANIN>> OFPBOBPNJCE(TRoot GPKGNPPAAHE, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, TAction[] NENNGNGAKJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57BB480", Offset = "0x57B9E80", VA = "0x1857BB480")]
	[AsyncStateMachine(typeof(DHBLPLACKMH<, , , , , , , , >.GGAELJCBKHA))]
	public Task<FNBKHJCMJJM<object, AEFDHDNANIN>> FOLIPLMGKGJ(TRoot GPKGNPPAAHE, TNetSys KBBDIIKGDBD, TReceiver KGEAKKOPFLC, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, AEAOKLPMJLF<TMRequest> JPDDLNHOEAE, TAction GKKKLNHPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57BB190", Offset = "0x57B9B90", VA = "0x1857BB190")]
	[AsyncStateMachine(typeof(DHBLPLACKMH<, , , , , , , , >.BAOADNFLILK))]
	private Task<FNBKHJCMJJM<object, AEFDHDNANIN>> FCFDLDCKHLN(TRoot GPKGNPPAAHE, TNetSys KBBDIIKGDBD, TReceiver KGEAKKOPFLC, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, AEAOKLPMJLF<TMRequest> JPDDLNHOEAE, TAction GKKKLNHPKBN, Task LIPAJJKKKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57BC190", Offset = "0x57BAB90", VA = "0x1857BC190")]
	[AsyncStateMachine(typeof(DHBLPLACKMH<, , , , , , , , >.ECPGJBBPKKK))]
	private Task NBEAOACFDJP(TRoot GPKGNPPAAHE, TNetSys KBBDIIKGDBD, TReceiver KGEAKKOPFLC, TAction GKKKLNHPKBN, FHNHOFCFHHO NMHFPKIOFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x57BCB30", Offset = "0x57BB530", VA = "0x1857BCB30")]
	private void PIBJOEODNOO(TRoot GPKGNPPAAHE, TNetSys KBBDIIKGDBD, TReceiver KGEAKKOPFLC, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, TAction GKKKLNHPKBN, bool GDEEFMDDPLJ, bool GJANCNONOEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FKPGAEPJDNF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface LLEPLJPJKKB<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ALOKHBNOLNB(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction JOLLHHNENOE(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PBDPPJJPJGN(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> CHNPMFCJNDH(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] DJOCNPFFDCI(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN, int DPMLHNJLAAD);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NBDDEDFAGCK(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IOHNGDINHJK(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KCDICLGCFHN(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CMIJPMKBNBO(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FAHEPBCHPKF(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BKPOGEDBMFD(TNetSys AELKGENHKKJ, TAction GKKKLNHPKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KAPHIAMEFBL<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps ANOEMOHMOJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps FINFAIDGIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps BKFNFENCJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EMLEGDJAHBO<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AEAOKLPMJLF<JDFEFHNOHPF> GGPIHHLCAMA(TReceiver KGEAKKOPFLC);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FNBKHJCMJJM<object, AEFDHDNANIN>> FOLIPLMGKGJ(TReceiver KGEAKKOPFLC, TAction GKKKLNHPKBN);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] IHNJKBMGHAP(TReceiver KGEAKKOPFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IDGCACBMEDN<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OLPJHJECPDN(TRoot GPKGNPPAAHE);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MJHPNMLFDNN(TRoot GPKGNPPAAHE);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GHOPMFHKOHF(TRoot GPKGNPPAAHE);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int KKJLDPLAAGH(TRoot GPKGNPPAAHE);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PILIFBONEDK(TRoot GPKGNPPAAHE);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task MDLDPHPDFHK(TRoot GPKGNPPAAHE, AEAOKLPMJLF<JDFEFHNOHPF> FHOIOAHBGEP, AEAOKLPMJLF<TMRequest> JPDDLNHOEAE, TAction GKKKLNHPKBN, bool KANOICOOHCF = true);
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
