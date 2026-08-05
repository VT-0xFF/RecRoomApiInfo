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
public interface BPCCDLFFPJF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MKBBKJJMLEJ(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction COONJGCAJJC(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction HDOMPIHNBLG(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> OIKKGLHOHNN(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GJAJJAPOFKG(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LGCAIEFHDAE(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KCNINAMDONG(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MPKKEMKPNPD(in TAction CGKOOFFNHKL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KEHHPKLOHBC(in TAction CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BFHDHLBEFEP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::OBHDOFHBHBB<LFFJKEJNKLD> HHKOCELMGID
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLMGOKCGOOG();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJCKEFLBMMO(in global::OBHDOFHBHBB<IMJLJDOANLA> IPNILBFBOEI, in TAction CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ONHGJDBOJHB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PHAAHECGOKK(TPartialSnapshot JLBHLAAKIBL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot BLFELNHIGOE(TPartialSnapshot[] IKPLGDLLEAO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LFFJKEJNKLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IMJLJDOANLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HKDBKDKJPHB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::GCIDOEIPIDG<TAction, Task<global::BEHELEDFPDP<object, FOCKIOEBELC>>, TActionReceiver> where TActionReceiver : global::LMBPAONFPBB<TAction, Task<global::BEHELEDFPDP<object, FOCKIOEBELC>>> where TActionDeps : global::BPCCDLFFPJF<TAction> where TStaticNetSysDeps : global::BFHDHLBEFEP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private interface KPGLDEEECON
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KHAIMPGKJBP();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LGCPJCLAGML(Exception KLJBPOILBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class FDDFOMCPIMP : KPGLDEEECON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> LGGDBJCGDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::BEHELEDFPDP<object, FOCKIOEBELC>> MNFAOAEEIAI;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x259C0C0", Offset = "0x259AEC0", VA = "0x18259C0C0")]
		private FDDFOMCPIMP(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1AD65F0", Offset = "0x1AD53F0", VA = "0x181AD65F0")]
		public static FDDFOMCPIMP MIHDEIPKAKJ(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x259BF20", Offset = "0x259AD20", VA = "0x18259BF20")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x259BF80", Offset = "0x259AD80", VA = "0x18259BF80", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x259BE70", Offset = "0x259AC70", VA = "0x18259BE70", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x259C060", Offset = "0x259AE60", VA = "0x18259C060", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6500", Offset = "0x1AD5300", VA = "0x181AD6500", Slot = "4")]
		private void GPFAMDMNIOM(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class ELFMJJMMNNM : KPGLDEEECON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> LGGDBJCGDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::BEHELEDFPDP<object, FOCKIOEBELC> MJJHFGFNAAE;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x17ABF10", Offset = "0x17AAD10", VA = "0x1817ABF10")]
		private ELFMJJMMNNM(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1AD65F0", Offset = "0x1AD53F0", VA = "0x181AD65F0")]
		public static ELFMJJMMNNM MIHDEIPKAKJ(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1AD64E0", Offset = "0x1AD52E0", VA = "0x181AD64E0")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6530", Offset = "0x1AD5330", VA = "0x181AD6530", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6590", Offset = "0x1AD5390", VA = "0x181AD6590", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6500", Offset = "0x1AD5300", VA = "0x181AD6500", Slot = "4")]
		private void GPFAMDMNIOM(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class LLPLAHLPDFP : KPGLDEEECON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::BEHELEDFPDP<object, FOCKIOEBELC>> MNFAOAEEIAI;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2E9B230", Offset = "0x2E9A030", VA = "0x182E9B230")]
		private LLPLAHLPDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x22FF9E0", Offset = "0x22FE7E0", VA = "0x1822FF9E0")]
		public static LLPLAHLPDFP MIHDEIPKAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2E9B1D0", Offset = "0x2E99FD0", VA = "0x182E9B1D0")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2E9B170", Offset = "0x2E99F70", VA = "0x182E9B170", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6500", Offset = "0x1AD5300", VA = "0x181AD6500", Slot = "4")]
		private void GPFAMDMNIOM(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class GCCPGDAPGFF : KPGLDEEECON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::BEHELEDFPDP<object, FOCKIOEBELC> MJJHFGFNAAE;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		private GCCPGDAPGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x22FF9E0", Offset = "0x22FE7E0", VA = "0x1822FF9E0")]
		public static GCCPGDAPGFF MIHDEIPKAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x11A3F00", Offset = "0x11A2D00", VA = "0x1811A3F00")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6500", Offset = "0x1AD5300", VA = "0x181AD6500", Slot = "4")]
		private void GPFAMDMNIOM(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MCFJJLIFFNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::BEHELEDFPDP<object, FOCKIOEBELC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::HKDBKDKJPHB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::OBHDOFHBHBB<LFFJKEJNKLD> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::OBHDOFHBHBB<IMJLJDOANLA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::BEHELEDFPDP<object, FOCKIOEBELC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2E47F50", Offset = "0x2E46D50", VA = "0x182E47F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E48200", Offset = "0x2E47000", VA = "0x182E48200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EMHNEIPKKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::BEHELEDFPDP<object, FOCKIOEBELC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::HKDBKDKJPHB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::OBHDOFHBHBB<LFFJKEJNKLD> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::OBHDOFHBHBB<IMJLJDOANLA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KPGLDEEECON <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1AD7970", Offset = "0x1AD6770", VA = "0x181AD7970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1AD8170", Offset = "0x1AD6F70", VA = "0x181AD8170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KMBGEIMALAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::HKDBKDKJPHB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public KPGLDEEECON completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KPGLDEEECON <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::BEHELEDFPDP<object, FOCKIOEBELC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x311BAC0", Offset = "0x311A8C0", VA = "0x18311BAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver LLIINLDFEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps KJKENHABJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps AHMOENIOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int BGANLBFMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int CHBCKAAJHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::OBHDOFHBHBB<IMJLJDOANLA>, TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>>> IELDFODILDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::LKJGPKMAFBH<IMJLJDOANLA> EGECKLFLMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool HDLOKBBHAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int PNLKCIHAIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task BJAGEAJOIKE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D019D0", Offset = "0x2D007D0", VA = "0x182D019D0")]
	protected HKDBKDKJPHB(TActionDeps HOAHHFGCGPF, TStaticNetSysDeps KKNHLMEHFNB, int EILFPCAPJNP, int MBKOHPBMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2D01560", Offset = "0x2D00360", VA = "0x182D01560")]
	public static global::HKDBKDKJPHB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> MIHDEIPKAKJ(TActionDeps HOAHHFGCGPF, TStaticNetSysDeps KKNHLMEHFNB, [Optional] int? EILFPCAPJNP, [Optional] int? MBKOHPBMHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2D016B0", Offset = "0x2D004B0", VA = "0x182D016B0")]
	public Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> OJCKEFLBMMO(in TAction CGKOOFFNHKL, bool EIPCKAKCFGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2D016A0", Offset = "0x2D004A0", VA = "0x182D016A0")]
	public void ODCMGCDFPIC(in TActionReceiver GCLPBOILCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2D01400", Offset = "0x2D00200", VA = "0x182D01400")]
	[AsyncStateMachine(typeof(global::HKDBKDKJPHB<, , , >.MCFJJLIFFNP))]
	public Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> GFCPFEDJLNJ(global::OBHDOFHBHBB<LFFJKEJNKLD> KKLMLLAHIKF, global::OBHDOFHBHBB<IMJLJDOANLA> IPNILBFBOEI, TAction CGKOOFFNHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2D01150", Offset = "0x2CFFF50", VA = "0x182D01150")]
	[AsyncStateMachine(typeof(global::HKDBKDKJPHB<, , , >.EMHNEIPKKIO))]
	private Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> DEHOPGMMAKI(global::OBHDOFHBHBB<LFFJKEJNKLD> KKLMLLAHIKF, global::OBHDOFHBHBB<IMJLJDOANLA> IPNILBFBOEI, TAction CGKOOFFNHKL, Task AAAFPDBJOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2D012C0", Offset = "0x2D000C0", VA = "0x182D012C0")]
	[AsyncStateMachine(typeof(global::HKDBKDKJPHB<, , , >.KMBGEIMALAJ))]
	private Task FCMAPMJOMPN(TAction CGKOOFFNHKL, KPGLDEEECON IBNFJFFMOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2D00F70", Offset = "0x2CFFD70", VA = "0x182D00F70")]
	private void ADDDDBKKCDJ(TAction CGKOOFFNHKL, bool KJJDKLIHLOC, bool IFIIMFEKOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x259BE40", Offset = "0x259AC40", VA = "0x18259BE40", Slot = "4")]
	private Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> NPLKLJGOEKD(in TAction CGKOOFFNHKL, bool EIPCKAKCFGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HOOLPMJKALN<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::ONHGJDBOJHB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] JPCANPNCIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int MIEILAOPOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps NKIPKAGLJMM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D22DE0", Offset = "0x2D21BE0", VA = "0x182D22DE0")]
	internal HOOLPMJKALN(TPartialSnapshot[] PMBBLBDONPM, int FLOLGJDKPLD, TDeps HADJLLLCKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D22890", Offset = "0x2D21690", VA = "0x182D22890")]
	public global::KIHNHCKGABD<TFullSnapshot> HDJLPIMLCAC(TPartialSnapshot JLBHLAAKIBL)
	{
		return default(global::KIHNHCKGABD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D22840", Offset = "0x2D21640", VA = "0x182D22840")]
	public bool ACPCPDIEMAO(TPartialSnapshot JLBHLAAKIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D22D80", Offset = "0x2D21B80", VA = "0x182D22D80")]
	public static global::HOOLPMJKALN<TPartialSnapshot, TFullSnapshot, TDeps> MIHDEIPKAKJ(TDeps HADJLLLCKOJ)
	{
		return default(global::HOOLPMJKALN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KOOIPNPLIBP : FOCKIOEBELC
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xD932C0", Offset = "0xD920C0", VA = "0x180D932C0", Slot = "5")]
	public override string BABNNBMBGEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xD932F0", Offset = "0xD920F0", VA = "0x180D932F0")]
	public KOOIPNPLIBP()
	{
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
