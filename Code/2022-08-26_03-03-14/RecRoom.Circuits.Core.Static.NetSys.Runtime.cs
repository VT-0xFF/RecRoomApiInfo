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
public interface MEKNGGNPPDO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PIJHJOFAGFB(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction MBMKEFPHPKB(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction IBPHHPEAMHB(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> CINKFMINKPH(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LJBDDLGKBNG(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JCDEDOOPLBK(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CEEJDAIPDJE(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PBDGFEKLPIC(in TAction KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GBDOGIABKBG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::AFOJODLLEBF<MFDFJKHNNGE> BNECHBFNDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLDCFAAGNNO();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFGPNGKADPN(in global::AFOJODLLEBF<BHOHJPGINPB> BANAAFJPHEJ, in TAction KINCGCMCJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MFDFJKHNNGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BHOHJPGINPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BOFLGGGDDJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::CDOPNHGGOBN<TAction, Task<global::NNAPGACKIDJ<object, PMPJEEMDACG>>, TActionReceiver> where TActionReceiver : global::GADGCLGHLPK<TAction, Task<global::NNAPGACKIDJ<object, PMPJEEMDACG>>> where TActionDeps : global::MEKNGGNPPDO<TAction> where TStaticNetSysDeps : global::GBDOGIABKBG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface JPEMIPDCFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ONMDLAHABNO(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PMJAJBMOCIF();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::NNAPGACKIDJ<object, PMPJEEMDACG> CBKDLKMKMFL();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BHPIECHIJCA(Exception BJEAAGJFDCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class EJINANKFJHF : JPEMIPDCFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>> BIFIIJODMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::NNAPGACKIDJ<object, PMPJEEMDACG>> CGNAGEKCCPJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2909DB0", Offset = "0x29089B0", VA = "0x182909DB0")]
		private EJINANKFJHF(TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>> NCCIBPILHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x29094B0", Offset = "0x29080B0", VA = "0x1829094B0")]
		public static EJINANKFJHF GLGBCEHJPPK(TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>> NCCIBPILHBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2909C90", Offset = "0x2908890", VA = "0x182909C90")]
		public void ONMDLAHABNO(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2909CF0", Offset = "0x29088F0", VA = "0x182909CF0", Slot = "5")]
		public void PMJAJBMOCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2909BF0", Offset = "0x29087F0", VA = "0x182909BF0", Slot = "6")]
		public global::NNAPGACKIDJ<object, PMPJEEMDACG> CBKDLKMKMFL()
		{
			return default(global::NNAPGACKIDJ<object, PMPJEEMDACG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2909B90", Offset = "0x2908790", VA = "0x182909B90", Slot = "7")]
		public void BHPIECHIJCA(Exception BJEAAGJFDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2909580", Offset = "0x2908180", VA = "0x182909580", Slot = "4")]
		private void IFPPENEKGEN(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class CGHFKLNAIED : JPEMIPDCFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>> BIFIIJODMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::NNAPGACKIDJ<object, PMPJEEMDACG> MIANEMIAOHC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2265A90", Offset = "0x2264690", VA = "0x182265A90")]
		private CGHFKLNAIED(TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>> NCCIBPILHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x29094B0", Offset = "0x29080B0", VA = "0x1829094B0")]
		public static CGHFKLNAIED GLGBCEHJPPK(TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>> NCCIBPILHBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26AFE10", Offset = "0x26AEA10", VA = "0x1826AFE10")]
		public void ONMDLAHABNO(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x29095B0", Offset = "0x29081B0", VA = "0x1829095B0", Slot = "5")]
		public void PMJAJBMOCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "6")]
		public global::NNAPGACKIDJ<object, PMPJEEMDACG> CBKDLKMKMFL()
		{
			return default(global::NNAPGACKIDJ<object, PMPJEEMDACG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2909450", Offset = "0x2908050", VA = "0x182909450", Slot = "7")]
		public void BHPIECHIJCA(Exception BJEAAGJFDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2909580", Offset = "0x2908180", VA = "0x182909580", Slot = "4")]
		private void IFPPENEKGEN(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class EHPMMEPJGDK : JPEMIPDCFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::NNAPGACKIDJ<object, PMPJEEMDACG>> CGNAGEKCCPJ;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2909B20", Offset = "0x2908720", VA = "0x182909B20")]
		private EHPMMEPJGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2909A00", Offset = "0x2908600", VA = "0x182909A00")]
		public static EHPMMEPJGDK GLGBCEHJPPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2909AC0", Offset = "0x29086C0", VA = "0x182909AC0")]
		public void ONMDLAHABNO(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		public void PMJAJBMOCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x29099A0", Offset = "0x29085A0", VA = "0x1829099A0", Slot = "6")]
		public global::NNAPGACKIDJ<object, PMPJEEMDACG> CBKDLKMKMFL()
		{
			return default(global::NNAPGACKIDJ<object, PMPJEEMDACG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		public void BHPIECHIJCA(Exception BJEAAGJFDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2909580", Offset = "0x2908180", VA = "0x182909580", Slot = "4")]
		private void IFPPENEKGEN(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class FFJJBFIOLAM : JPEMIPDCFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::NNAPGACKIDJ<object, PMPJEEMDACG> MIANEMIAOHC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		private FFJJBFIOLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2909A00", Offset = "0x2908600", VA = "0x182909A00")]
		public static FFJJBFIOLAM GLGBCEHJPPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x140FAB0", Offset = "0x140E6B0", VA = "0x18140FAB0")]
		public void ONMDLAHABNO(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		public void PMJAJBMOCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40", Slot = "6")]
		public global::NNAPGACKIDJ<object, PMPJEEMDACG> CBKDLKMKMFL()
		{
			return default(global::NNAPGACKIDJ<object, PMPJEEMDACG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		public void BHPIECHIJCA(Exception BJEAAGJFDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2909580", Offset = "0x2908180", VA = "0x182909580", Slot = "4")]
		private void IFPPENEKGEN(in global::NNAPGACKIDJ<object, PMPJEEMDACG> MIILAJKCKHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BGLNHCPNNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::NNAPGACKIDJ<object, PMPJEEMDACG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::BOFLGGGDDJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::AFOJODLLEBF<MFDFJKHNNGE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::AFOJODLLEBF<BHOHJPGINPB> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::NNAPGACKIDJ<object, PMPJEEMDACG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2902C30", Offset = "0x2901830", VA = "0x182902C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2902E60", Offset = "0x2901A60", VA = "0x182902E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KMDDAJHBEMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::NNAPGACKIDJ<object, PMPJEEMDACG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::BOFLGGGDDJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::AFOJODLLEBF<MFDFJKHNNGE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::AFOJODLLEBF<BHOHJPGINPB> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JPEMIPDCFKL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x290EB40", Offset = "0x290D740", VA = "0x18290EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x290F2D0", Offset = "0x290DED0", VA = "0x18290F2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FNGILGJBINB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::BOFLGGGDDJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public JPEMIPDCFKL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JPEMIPDCFKL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::NNAPGACKIDJ<object, PMPJEEMDACG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2909E40", Offset = "0x2908A40", VA = "0x182909E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver DBBAAIHFOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps CEOFENOIHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps BFBDDIMKIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int DBLGEADILFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int CAFABHIKMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::AFOJODLLEBF<BHOHJPGINPB>, TaskCompletionSource<global::NNAPGACKIDJ<object, PMPJEEMDACG>>> DEIGNOMBAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::HIJGHHEDFOJ<BHOHJPGINPB> OIJANIDIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool IMPAMPFONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BGACIJONACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PLBDNBLAPMI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2909340", Offset = "0x2907F40", VA = "0x182909340")]
	protected BOFLGGGDDJE(TActionDeps HICLGPFLHGF, TStaticNetSysDeps LFIGLILLPOC, int EFIHANPCGMG, int BAGGLHALLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29089A0", Offset = "0x29075A0", VA = "0x1829089A0")]
	public static global::BOFLGGGDDJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> GLGBCEHJPPK(TActionDeps HICLGPFLHGF, TStaticNetSysDeps LFIGLILLPOC, [Optional] int? EFIHANPCGMG, [Optional] int? BAGGLHALLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2908EF0", Offset = "0x2907AF0", VA = "0x182908EF0")]
	public Task<global::NNAPGACKIDJ<object, PMPJEEMDACG>> OFGPNGKADPN(in TAction KINCGCMCJLI, bool LGDLENHLBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2908990", Offset = "0x2907590", VA = "0x182908990")]
	public void DEKGBDEPCEL(in TActionReceiver AGHFCAFPHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2908DA0", Offset = "0x29079A0", VA = "0x182908DA0")]
	[AsyncStateMachine(typeof(global::BOFLGGGDDJE<, , , >.BGLNHCPNNFO))]
	public Task<global::NNAPGACKIDJ<object, PMPJEEMDACG>> OBDJFAIFOBI(global::AFOJODLLEBF<MFDFJKHNNGE> HNNEPLMLAAB, global::AFOJODLLEBF<BHOHJPGINPB> BANAAFJPHEJ, TAction KINCGCMCJLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29091F0", Offset = "0x2907DF0", VA = "0x1829091F0")]
	[AsyncStateMachine(typeof(global::BOFLGGGDDJE<, , , >.KMDDAJHBEMB))]
	private Task<global::NNAPGACKIDJ<object, PMPJEEMDACG>> PHBDAKBFMCB(global::AFOJODLLEBF<MFDFJKHNNGE> HNNEPLMLAAB, global::AFOJODLLEBF<BHOHJPGINPB> BANAAFJPHEJ, TAction KINCGCMCJLI, Task AHFBOECJBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2908AD0", Offset = "0x29076D0", VA = "0x182908AD0")]
	[AsyncStateMachine(typeof(global::BOFLGGGDDJE<, , , >.FNGILGJBINB))]
	private Task JDCPGCOFHDI(TAction KINCGCMCJLI, JPEMIPDCFKL HFFNKKFAMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2908C20", Offset = "0x2907820", VA = "0x182908C20")]
	private void NDEILKPBHGM(TAction KINCGCMCJLI, bool DKMPKCLMJHB, bool ACOJPDBMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2908960", Offset = "0x2907560", VA = "0x182908960", Slot = "4")]
	private Task<global::NNAPGACKIDJ<object, PMPJEEMDACG>> BBMBHGCOAOE(in TAction KINCGCMCJLI, bool LGDLENHLBCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GIPMCFPMNLO : PMPJEEMDACG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE5CAD0", Offset = "0xE5B6D0", VA = "0x180E5CAD0", Slot = "4")]
	public override string DNOGBFDJAGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE5CB00", Offset = "0xE5B700", VA = "0x180E5CB00")]
	private GIPMCFPMNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20C8010", Offset = "0x20C6C10", VA = "0x1820C8010")]
	public static global::NNAPGACKIDJ<TOk, PMPJEEMDACG> GLGBCEHJPPK<TOk>()
	{
		return default(global::NNAPGACKIDJ<TOk, PMPJEEMDACG>);
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
