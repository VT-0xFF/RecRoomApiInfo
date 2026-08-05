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
		[Cpp2IlInjected.Address(RVA = "0x27729D0", Offset = "0x27719D0", VA = "0x1827729D0")]
		private FDDFOMCPIMP(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CAECA0", Offset = "0x1CADCA0", VA = "0x181CAECA0")]
		public static FDDFOMCPIMP MIHDEIPKAKJ(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2772830", Offset = "0x2771830", VA = "0x182772830")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2772890", Offset = "0x2771890", VA = "0x182772890", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2772780", Offset = "0x2771780", VA = "0x182772780", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2772970", Offset = "0x2771970", VA = "0x182772970", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEBB0", Offset = "0x1CADBB0", VA = "0x181CAEBB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x19845E0", Offset = "0x19835E0", VA = "0x1819845E0")]
		private ELFMJJMMNNM(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1CAECA0", Offset = "0x1CADCA0", VA = "0x181CAECA0")]
		public static ELFMJJMMNNM MIHDEIPKAKJ(TaskCompletionSource<global::BEHELEDFPDP<object, FOCKIOEBELC>> JOLONLLBEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEB90", Offset = "0x1CADB90", VA = "0x181CAEB90")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEBE0", Offset = "0x1CADBE0", VA = "0x181CAEBE0", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEC40", Offset = "0x1CADC40", VA = "0x181CAEC40", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEBB0", Offset = "0x1CADBB0", VA = "0x181CAEBB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3070A60", Offset = "0x306FA60", VA = "0x183070A60")]
		private LLPLAHLPDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24D6EE0", Offset = "0x24D5EE0", VA = "0x1824D6EE0")]
		public static LLPLAHLPDFP MIHDEIPKAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3070A00", Offset = "0x306FA00", VA = "0x183070A00")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x30709A0", Offset = "0x306F9A0", VA = "0x1830709A0", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEBB0", Offset = "0x1CADBB0", VA = "0x181CAEBB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		private GCCPGDAPGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x24D6EE0", Offset = "0x24D5EE0", VA = "0x1824D6EE0")]
		public static GCCPGDAPGFF MIHDEIPKAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x137D020", Offset = "0x137C020", VA = "0x18137D020")]
		public void GBJPJDIOKPG(in global::BEHELEDFPDP<object, FOCKIOEBELC> BBLJKOEKFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		public void KHAIMPGKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0", Slot = "6")]
		public global::BEHELEDFPDP<object, FOCKIOEBELC> CHFBMGOFFLG()
		{
			return default(global::BEHELEDFPDP<object, FOCKIOEBELC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		public void LGCPJCLAGML(Exception KLJBPOILBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEBB0", Offset = "0x1CADBB0", VA = "0x181CAEBB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x301D7A0", Offset = "0x301C7A0", VA = "0x18301D7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x301DA50", Offset = "0x301CA50", VA = "0x18301DA50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CB0020", Offset = "0x1CAF020", VA = "0x181CB0020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0820", Offset = "0x1CAF820", VA = "0x181CB0820", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x32F0F30", Offset = "0x32EFF30", VA = "0x1832F0F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2ED7240", Offset = "0x2ED6240", VA = "0x182ED7240")]
	protected HKDBKDKJPHB(TActionDeps HOAHHFGCGPF, TStaticNetSysDeps KKNHLMEHFNB, int EILFPCAPJNP, int MBKOHPBMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2ED6DD0", Offset = "0x2ED5DD0", VA = "0x182ED6DD0")]
	public static global::HKDBKDKJPHB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> MIHDEIPKAKJ(TActionDeps HOAHHFGCGPF, TStaticNetSysDeps KKNHLMEHFNB, [Optional] int? EILFPCAPJNP, [Optional] int? MBKOHPBMHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2ED6F20", Offset = "0x2ED5F20", VA = "0x182ED6F20")]
	public Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> OJCKEFLBMMO(in TAction CGKOOFFNHKL, bool EIPCKAKCFGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2ED6F10", Offset = "0x2ED5F10", VA = "0x182ED6F10")]
	public void ODCMGCDFPIC(in TActionReceiver GCLPBOILCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2ED6C70", Offset = "0x2ED5C70", VA = "0x182ED6C70")]
	[AsyncStateMachine(typeof(global::HKDBKDKJPHB<, , , >.MCFJJLIFFNP))]
	public Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> GFCPFEDJLNJ(global::OBHDOFHBHBB<LFFJKEJNKLD> KKLMLLAHIKF, global::OBHDOFHBHBB<IMJLJDOANLA> IPNILBFBOEI, TAction CGKOOFFNHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2ED69C0", Offset = "0x2ED59C0", VA = "0x182ED69C0")]
	[AsyncStateMachine(typeof(global::HKDBKDKJPHB<, , , >.EMHNEIPKKIO))]
	private Task<global::BEHELEDFPDP<object, FOCKIOEBELC>> DEHOPGMMAKI(global::OBHDOFHBHBB<LFFJKEJNKLD> KKLMLLAHIKF, global::OBHDOFHBHBB<IMJLJDOANLA> IPNILBFBOEI, TAction CGKOOFFNHKL, Task AAAFPDBJOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2ED6B30", Offset = "0x2ED5B30", VA = "0x182ED6B30")]
	[AsyncStateMachine(typeof(global::HKDBKDKJPHB<, , , >.KMBGEIMALAJ))]
	private Task FCMAPMJOMPN(TAction CGKOOFFNHKL, KPGLDEEECON IBNFJFFMOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2ED67E0", Offset = "0x2ED57E0", VA = "0x182ED67E0")]
	private void ADDDDBKKCDJ(TAction CGKOOFFNHKL, bool KJJDKLIHLOC, bool IFIIMFEKOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2772750", Offset = "0x2771750", VA = "0x182772750", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EF8650", Offset = "0x2EF7650", VA = "0x182EF8650")]
	internal HOOLPMJKALN(TPartialSnapshot[] PMBBLBDONPM, int FLOLGJDKPLD, TDeps HADJLLLCKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8100", Offset = "0x2EF7100", VA = "0x182EF8100")]
	public global::KIHNHCKGABD<TFullSnapshot> HDJLPIMLCAC(TPartialSnapshot JLBHLAAKIBL)
	{
		return default(global::KIHNHCKGABD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2EF80B0", Offset = "0x2EF70B0", VA = "0x182EF80B0")]
	public bool ACPCPDIEMAO(TPartialSnapshot JLBHLAAKIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2EF85F0", Offset = "0x2EF75F0", VA = "0x182EF85F0")]
	public static global::HOOLPMJKALN<TPartialSnapshot, TFullSnapshot, TDeps> MIHDEIPKAKJ(TDeps HADJLLLCKOJ)
	{
		return default(global::HOOLPMJKALN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KOOIPNPLIBP : FOCKIOEBELC
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xF6C7E0", Offset = "0xF6B7E0", VA = "0x180F6C7E0", Slot = "5")]
	public override string BABNNBMBGEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xF6C810", Offset = "0xF6B810", VA = "0x180F6C810")]
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
