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
public struct NIHGKAFEDPL<TPartialAction, TFullAction, TDeps> where TDeps : HBJHEMLPGDJ.NHMOPANLNDJ<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] NFMKFBPPMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int MOEHLOPIHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F910", Offset = "0x3F1E510", VA = "0x183F1F910")]
	internal NIHGKAFEDPL(TPartialAction[] ABCLJDNGNIE, int NMPKMHKJKLI, TDeps DDNPAGAAIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F8B0", Offset = "0x3F1E4B0", VA = "0x183F1F8B0")]
	public static NIHGKAFEDPL<TPartialAction, TFullAction, TDeps> LMDPPDEOAIA(TDeps DDNPAGAAIOD)
	{
		return default(NIHGKAFEDPL<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HBJHEMLPGDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NHMOPANLNDJ<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HIEDPGHCNPG([In] TPartialAction KKGBMHECKEB);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction HINBBFDILPN(TPartialAction[] HEPKBGAOODM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E13FA0", Offset = "0x2E12BA0", VA = "0x182E13FA0")]
	public static GENIMIBGNOF<TFullAction> IFAEDHDMEDH<TFullAction, TPartialAction, TDeps>(this NIHGKAFEDPL<TPartialAction, TFullAction, TDeps> GMNCELIMKIF, TPartialAction KKGBMHECKEB) where TDeps : NHMOPANLNDJ<TPartialAction, TFullAction>
	{
		return default(GENIMIBGNOF<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AOBABHPKNDM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : PKIJDFIGBNH.KFJPBOMAIHL<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] COOOMMALBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int LJOPPOPHOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F910", Offset = "0x3F1E510", VA = "0x183F1F910")]
	internal AOBABHPKNDM(TPartialSnapshot[] JAGNGBHFDJD, int OBEJCICOAAN, TDeps DDNPAGAAIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F8B0", Offset = "0x3F1E4B0", VA = "0x183F1F8B0")]
	public static AOBABHPKNDM<TPartialSnapshot, TFullSnapshot, TDeps> LMDPPDEOAIA(TDeps DDNPAGAAIOD)
	{
		return default(AOBABHPKNDM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PKIJDFIGBNH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KFJPBOMAIHL<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PMOPMGFBMIK([In] TPartialSnapshot CHFJEIGACEL);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot OPDECGOCDPC(TPartialSnapshot[] IDACKIBEGCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9870", Offset = "0x2FD8470", VA = "0x182FD9870")]
	public static GENIMIBGNOF<TFullSnapshot> IFAEDHDMEDH<TFullSnapshot, TPartialSnapshot, TDeps>(this AOBABHPKNDM<TPartialSnapshot, TFullSnapshot, TDeps> GMNCELIMKIF, TPartialSnapshot CHFJEIGACEL) where TDeps : KFJPBOMAIHL<TPartialSnapshot, TFullSnapshot>
	{
		return default(GENIMIBGNOF<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FD99F0", Offset = "0x2FD85F0", VA = "0x182FD99F0")]
	public static bool IJCCPLKCBFD<TPartialSnapshot, TFullSnapshot, TDeps>(this AOBABHPKNDM<TPartialSnapshot, TFullSnapshot, TDeps> GMNCELIMKIF, TPartialSnapshot CHFJEIGACEL) where TDeps : KFJPBOMAIHL<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BLFCMKHDIKL : LJHFFGOEJCA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2183960", Offset = "0x2182560", VA = "0x182183960", Slot = "7")]
	public override string GCHBDOEJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2183990", Offset = "0x2182590", VA = "0x182183990")]
	public BLFCMKHDIKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FDMFBILDOPO.NONOCIIBHKC<TAction, TNetSys> where TReceiverDeps : FDMFBILDOPO.IPJHMCAMGKG<TAction, TReceiver> where TRootDeps : FDMFBILDOPO.KKEPDBMNGKN<TMRequest, TAction, TRoot> where TDeps : FDMFBILDOPO.ADNBOLKIIIE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface GAONDFMGPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CBDGJPHEJIB([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CHMINJIMNDI();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OAMIPODNNBO<object, BDMFJEIOIAD> AKIEGDJJHIC();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GHDCOCMGDGJ(Exception JFFKMOFPCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class HBICDPIINBM : GAONDFMGPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> FAMOPLKMAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly List<OAMIPODNNBO<object, OILOBAEJEDE>> MOBFHEPIGNC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F318D0", Offset = "0x3F304D0", VA = "0x183F318D0")]
		private HBICDPIINBM(TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> IJDPKOGCIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F31800", Offset = "0x3F30400", VA = "0x183F31800")]
		public static HBICDPIINBM LMDPPDEOAIA(TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> IJDPKOGCIHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F31460", Offset = "0x3F30060", VA = "0x183F31460")]
		public void CBDGJPHEJIB([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F31660", Offset = "0x3F30260", VA = "0x183F31660", Slot = "5")]
		public void CHMINJIMNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F31290", Offset = "0x3F2FE90", VA = "0x183F31290", Slot = "6")]
		public OAMIPODNNBO<object, BDMFJEIOIAD> AKIEGDJJHIC()
		{
			return default(OAMIPODNNBO<object, BDMFJEIOIAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F31740", Offset = "0x3F30340", VA = "0x183F31740", Slot = "7")]
		public void GHDCOCMGDGJ(Exception JFFKMOFPCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4B90", Offset = "0x3DE3790", VA = "0x183DE4B90", Slot = "4")]
		private void HCDHIHLFJPD([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IKAAKBGPJEO : GAONDFMGPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> FAMOPLKMAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OAMIPODNNBO<object, BDMFJEIOIAD> JEBJFGBJBEK;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
		private IKAAKBGPJEO(TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> IJDPKOGCIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3F31800", Offset = "0x3F30400", VA = "0x183F31800")]
		public static IKAAKBGPJEO LMDPPDEOAIA(TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> IJDPKOGCIHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E460", Offset = "0x3E1D060", VA = "0x183E1E460")]
		public void CBDGJPHEJIB([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4030910", Offset = "0x402F510", VA = "0x184030910", Slot = "5")]
		public void CHMINJIMNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDF95E0", Offset = "0xDF81E0", VA = "0x180DF95E0", Slot = "6")]
		public OAMIPODNNBO<object, BDMFJEIOIAD> AKIEGDJJHIC()
		{
			return default(OAMIPODNNBO<object, BDMFJEIOIAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40309D0", Offset = "0x402F5D0", VA = "0x1840309D0", Slot = "7")]
		public void GHDCOCMGDGJ(Exception JFFKMOFPCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4B90", Offset = "0x3DE3790", VA = "0x183DE4B90", Slot = "4")]
		private void HCDHIHLFJPD([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DANMKGKMLPO : GAONDFMGPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<OAMIPODNNBO<object, BDMFJEIOIAD>> MOBFHEPIGNC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7640", Offset = "0x5AB6240", VA = "0x185AB7640")]
		private DANMKGKMLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4BD0", Offset = "0x3DE37D0", VA = "0x183DE4BD0")]
		public static DANMKGKMLPO LMDPPDEOAIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5AB74C0", Offset = "0x5AB60C0", VA = "0x185AB74C0")]
		public void CBDGJPHEJIB([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void CHMINJIMNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7320", Offset = "0x5AB5F20", VA = "0x185AB7320", Slot = "6")]
		public OAMIPODNNBO<object, BDMFJEIOIAD> AKIEGDJJHIC()
		{
			return default(OAMIPODNNBO<object, BDMFJEIOIAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5AB75A0", Offset = "0x5AB61A0", VA = "0x185AB75A0", Slot = "7")]
		[CEKOJAIAJNA("This may be terminal and should probably do more than discarding the exception.")]
		public void GHDCOCMGDGJ(Exception JFFKMOFPCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4B90", Offset = "0x3DE3790", VA = "0x183DE4B90", Slot = "4")]
		private void HCDHIHLFJPD([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class FACOBAFJGNI : GAONDFMGPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private OAMIPODNNBO<object, BDMFJEIOIAD> JEBJFGBJBEK;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		private FACOBAFJGNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4BD0", Offset = "0x3DE37D0", VA = "0x183DE4BD0")]
		public static FACOBAFJGNI LMDPPDEOAIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x19D2540", Offset = "0x19D1140", VA = "0x1819D2540")]
		public void CBDGJPHEJIB([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void CHMINJIMNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0", Slot = "6")]
		public OAMIPODNNBO<object, BDMFJEIOIAD> AKIEGDJJHIC()
		{
			return default(OAMIPODNNBO<object, BDMFJEIOIAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4AF0", Offset = "0x3DE36F0", VA = "0x183DE4AF0", Slot = "7")]
		[CEKOJAIAJNA("This may be terminal and should probably do more than discarding the exception.")]
		public void GHDCOCMGDGJ(Exception JFFKMOFPCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4B90", Offset = "0x3DE3790", VA = "0x183DE4B90", Slot = "4")]
		private void HCDHIHLFJPD([In] OAMIPODNNBO<object, BDMFJEIOIAD> CMNKPAFMHMO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FFJFEKFNHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FANMFDLLPNO<LIPJNACBMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD710", Offset = "0x3DFC310", VA = "0x183DFD710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE180", Offset = "0x3DFCD80", VA = "0x183DFE180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EOHOMLLMFGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FANMFDLLPNO<LIPJNACBMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3A928E0", Offset = "0x3A914E0", VA = "0x183A928E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A931A0", Offset = "0x3A91DA0", VA = "0x183A931A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CBLKBOLPJEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public FANMFDLLPNO<LIPJNACBMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FANMFDLLPNO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5238D30", Offset = "0x5237930", VA = "0x185238D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5239400", Offset = "0x5238000", VA = "0x185239400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FMMABJJGEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<object, BDMFJEIOIAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public FANMFDLLPNO<LIPJNACBMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public FANMFDLLPNO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GAONDFMGPBL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3E13EE0", Offset = "0x3E12AE0", VA = "0x183E13EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E14B90", Offset = "0x3E13790", VA = "0x183E14B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ODFOHLNPBHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GAONDFMGPBL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private GAONDFMGPBL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<OAMIPODNNBO<object, BDMFJEIOIAD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4799DB0", Offset = "0x47989B0", VA = "0x184799DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x479DC80", Offset = "0x479C880", VA = "0x18479DC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct DPDOCILBBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KLPDFBFHCDE<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FANMFDLLPNO<LIPJNACBMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5B14120", Offset = "0x5B12D20", VA = "0x185B14120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5B144A0", Offset = "0x5B130A0", VA = "0x185B144A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KPJEAHOHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<FANMFDLLPNO<TMRequest>, TaskCompletionSource<OAMIPODNNBO<object, BDMFJEIOIAD>>> FHMHKBAMMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KHMAIAOOGCL<TMRequest> CACPNMJHOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool MHKEIBBJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int DEMCNJECDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Task NHOJKPJPIKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps MCDHJGICAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x42CFC60", Offset = "0x42CE860", VA = "0x1842CFC60")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps NJICDCLOOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x42D12A0", Offset = "0x42CFEA0", VA = "0x1842D12A0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HGBNDLPFMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x42D0020", Offset = "0x42CEC20", VA = "0x1842D0020")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ILGBFDEJFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xADFE20", Offset = "0xADEA20", VA = "0x180ADFE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15EA490", Offset = "0x15E9090", VA = "0x1815EA490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HDNEEAGAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x11203E0", Offset = "0x111EFE0", VA = "0x1811203E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x42CFCE0", Offset = "0x42CE8E0", VA = "0x1842CFCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AIEJNCPMCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x887AC0", Offset = "0x8866C0", VA = "0x180887AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42D1BF0", Offset = "0x42D07F0", VA = "0x1842D1BF0")]
	public KLPDFBFHCDE(TDeps DDNPAGAAIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42D0770", Offset = "0x42CF370", VA = "0x1842D0770")]
	public Task<OAMIPODNNBO<object, BDMFJEIOIAD>> KIIGCBMFIBF(TRoot AHFIDHNOIFE, TNetSys AECOHPIJBOL, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, TAction FNGNLBJEBKM, bool DFCDOALJFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42D0610", Offset = "0x42CF210", VA = "0x1842D0610")]
	[AsyncStateMachine(typeof(KLPDFBFHCDE<, , , , , , , , >.FFJFEKFNHPI))]
	private Task<OAMIPODNNBO<object, BDMFJEIOIAD>> KIIGCBMFIBF(TRoot AHFIDHNOIFE, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, TAction FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x42CF9A0", Offset = "0x42CE5A0", VA = "0x1842CF9A0")]
	[AsyncStateMachine(typeof(KLPDFBFHCDE<, , , , , , , , >.EOHOMLLMFGA))]
	private Task<OAMIPODNNBO<object, BDMFJEIOIAD>> DHIEPBDNANO(TRoot AHFIDHNOIFE, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, TAction[] FCICDOOOFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42CFCF0", Offset = "0x42CE8F0", VA = "0x1842CFCF0")]
	[AsyncStateMachine(typeof(KLPDFBFHCDE<, , , , , , , , >.CBLKBOLPJEJ))]
	public Task<OAMIPODNNBO<object, BDMFJEIOIAD>> EFPAJGHFNCL(TRoot AHFIDHNOIFE, TNetSys OPKBGMBNLBB, TReceiver IMHHBHNOLMB, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, FANMFDLLPNO<TMRequest> CFOEIOJEJHE, TAction FNGNLBJEBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42D0300", Offset = "0x42CEF00", VA = "0x1842D0300")]
	[AsyncStateMachine(typeof(KLPDFBFHCDE<, , , , , , , , >.FMMABJJGEGE))]
	private Task<OAMIPODNNBO<object, BDMFJEIOIAD>> HGGLGEFMGLI(TRoot AHFIDHNOIFE, TNetSys OPKBGMBNLBB, TReceiver IMHHBHNOLMB, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, FANMFDLLPNO<TMRequest> CFOEIOJEJHE, TAction FNGNLBJEBKM, Task JGIGIOLFNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42D01B0", Offset = "0x42CEDB0", VA = "0x1842D01B0")]
	[AsyncStateMachine(typeof(KLPDFBFHCDE<, , , , , , , , >.ODFOHLNPBHA))]
	private Task FPCGIFELKAI(TRoot AHFIDHNOIFE, TNetSys OPKBGMBNLBB, TReceiver IMHHBHNOLMB, TAction FNGNLBJEBKM, GAONDFMGPBL LMCIGJKDEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42D1320", Offset = "0x42CFF20", VA = "0x1842D1320")]
	private void MLLJAELAFBK(TRoot AHFIDHNOIFE, TNetSys OPKBGMBNLBB, TReceiver IMHHBHNOLMB, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, TAction FNGNLBJEBKM, bool ANGBCAGCDOK, bool HMMCDNLEFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42CF860", Offset = "0x42CE460", VA = "0x1842CF860")]
	[AsyncStateMachine(typeof(KLPDFBFHCDE<, , , , , , , , >.DPDOCILBBNG))]
	public Task BCKGMKIAPFD(TRoot AHFIDHNOIFE, TNetSys OPKBGMBNLBB, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, TAction[] MDNCKHIFMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FDMFBILDOPO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NONOCIIBHKC<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CHBGHCPNEPN(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction BAJAONKDOOC(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction AMPCJDAPHNO(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HGGMKNAIHND(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] EMGGMFDKFHF(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM, int DOPIEFFGKNM);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CCJECFGONAH(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NCGLOMGCFAA(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CMOMANKLEHD(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool HONKNOFHDAL(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KKENDIGBLJG(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NMFGFDIKDII(TNetSys BDBODJKDEFI, TAction FNGNLBJEBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ADNBOLKIIIE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps MCDHJGICAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HGBNDLPFMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps NJICDCLOOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IPJHMCAMGKG<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FANMFDLLPNO<LIPJNACBMBC> FIACPLFMFDP(TReceiver IMHHBHNOLMB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OAMIPODNNBO<object, BDMFJEIOIAD>> EFPAJGHFNCL(TReceiver IMHHBHNOLMB, TAction FNGNLBJEBKM);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] HOANELFGKKA(TReceiver IMHHBHNOLMB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface KKEPDBMNGKN<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LFMKIOEBDNO(TRoot AHFIDHNOIFE);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HCNDFBLLGEB(TRoot AHFIDHNOIFE);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int FHIGJLJOJFM(TRoot AHFIDHNOIFE);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NIEHOKEBPLI(TRoot AHFIDHNOIFE);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FMJOHEJEPCC(TRoot AHFIDHNOIFE);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LPPMMGEMBON(TRoot AHFIDHNOIFE, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, TAction[] FCICDOOOFNC);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task KIIGCBMFIBF(TRoot AHFIDHNOIFE, FANMFDLLPNO<LIPJNACBMBC> ANAIMHELOBD, FANMFDLLPNO<TMRequest> CFOEIOJEJHE, TAction FNGNLBJEBKM, bool FPFFOGFMPNA = true);
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
