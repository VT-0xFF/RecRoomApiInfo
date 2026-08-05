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
public interface MFENJCCOMHF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IPPBDNCHCPA(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction CLPNFHGKMOD(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction JIPJKADFGEI(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> JKJKFMNLCAK(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KEKFANODKJM(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ACEHAEDKOKN(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EOGDBBMMCCN(in TAction FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GGJHOICBAJH(in TAction FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FGLPACHNKMK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::CIFPHBKLPJI<JAJGHMMBKDD> LPDMFKNACEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNODOMFLEEI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODLLLEPJJLB(in global::CIFPHBKLPJI<DFHKOFEHMLN> JBEDNGOOODE, in TAction FHCMCNABNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JAJGHMMBKDD
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DFHKOFEHMLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OIKOOBCAEPL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::PMAMFJLLLDF<TAction, Task<global::HEOOIFLCBHF<object, ENAKEJDNHIE>>, TActionReceiver> where TActionReceiver : global::IDCBFAJKJBM<TAction, Task<global::HEOOIFLCBHF<object, ENAKEJDNHIE>>> where TActionDeps : global::MFENJCCOMHF<TAction> where TStaticNetSysDeps : global::FGLPACHNKMK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface BDFEJANFBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EJIBJFHICDL(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AKPJFLNOMIA();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::HEOOIFLCBHF<object, ENAKEJDNHIE> BIBMFIFNNFL();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ADKNGJOBIDJ(Exception NINELMHCJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class PLPFIIHHMLD : BDFEJANFBBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ENCMDOOMHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> AMFHLBOLAHJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x405F270", Offset = "0x405DE70", VA = "0x18405F270")]
		private PLPFIIHHMLD(TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ALKHODPIBDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C270", Offset = "0x2A4AE70", VA = "0x182A4C270")]
		public static PLPFIIHHMLD EBNJNBKPCHE(TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ALKHODPIBDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x405F210", Offset = "0x405DE10", VA = "0x18405F210")]
		public void EJIBJFHICDL(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x405F0B0", Offset = "0x405DCB0", VA = "0x18405F0B0", Slot = "5")]
		public void AKPJFLNOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x405F170", Offset = "0x405DD70", VA = "0x18405F170", Slot = "6")]
		public global::HEOOIFLCBHF<object, ENAKEJDNHIE> BIBMFIFNNFL()
		{
			return default(global::HEOOIFLCBHF<object, ENAKEJDNHIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x405F050", Offset = "0x405DC50", VA = "0x18405F050", Slot = "7")]
		public void ADKNGJOBIDJ(Exception NINELMHCJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B540", Offset = "0x2A4A140", VA = "0x182A4B540", Slot = "4")]
		private void KHEJHAEOOEP(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class GIBILLIELJP : BDFEJANFBBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ENCMDOOMHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::HEOOIFLCBHF<object, ENAKEJDNHIE> DNIPINHNCPG;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
		private GIBILLIELJP(TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ALKHODPIBDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C270", Offset = "0x2A4AE70", VA = "0x182A4C270")]
		public static GIBILLIELJP EBNJNBKPCHE(TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ALKHODPIBDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x25597F0", Offset = "0x25583F0", VA = "0x1825597F0")]
		public void EJIBJFHICDL(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C210", Offset = "0x2A4AE10", VA = "0x182A4C210", Slot = "5")]
		public void AKPJFLNOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "6")]
		public global::HEOOIFLCBHF<object, ENAKEJDNHIE> BIBMFIFNNFL()
		{
			return default(global::HEOOIFLCBHF<object, ENAKEJDNHIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C1B0", Offset = "0x2A4ADB0", VA = "0x182A4C1B0", Slot = "7")]
		public void ADKNGJOBIDJ(Exception NINELMHCJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B540", Offset = "0x2A4A140", VA = "0x182A4B540", Slot = "4")]
		private void KHEJHAEOOEP(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class IKIBMCHDFIL : BDFEJANFBBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> AMFHLBOLAHJ;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C440", Offset = "0x2A4B040", VA = "0x182A4C440")]
		private IKIBMCHDFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B480", Offset = "0x2A4A080", VA = "0x182A4B480")]
		public static IKIBMCHDFIL EBNJNBKPCHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C3E0", Offset = "0x2A4AFE0", VA = "0x182A4C3E0")]
		public void EJIBJFHICDL(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		public void AKPJFLNOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C380", Offset = "0x2A4AF80", VA = "0x182A4C380", Slot = "6")]
		public global::HEOOIFLCBHF<object, ENAKEJDNHIE> BIBMFIFNNFL()
		{
			return default(global::HEOOIFLCBHF<object, ENAKEJDNHIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		public void ADKNGJOBIDJ(Exception NINELMHCJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B540", Offset = "0x2A4A140", VA = "0x182A4B540", Slot = "4")]
		private void KHEJHAEOOEP(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class EFIIDIBCIEN : BDFEJANFBBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::HEOOIFLCBHF<object, ENAKEJDNHIE> DNIPINHNCPG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		private EFIIDIBCIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B480", Offset = "0x2A4A080", VA = "0x182A4B480")]
		public static EFIIDIBCIEN EBNJNBKPCHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x131ADD0", Offset = "0x13199D0", VA = "0x18131ADD0")]
		public void EJIBJFHICDL(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		public void AKPJFLNOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A40", Offset = "0x8F4640", VA = "0x1808F5A40", Slot = "6")]
		public global::HEOOIFLCBHF<object, ENAKEJDNHIE> BIBMFIFNNFL()
		{
			return default(global::HEOOIFLCBHF<object, ENAKEJDNHIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		public void ADKNGJOBIDJ(Exception NINELMHCJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B540", Offset = "0x2A4A140", VA = "0x182A4B540", Slot = "4")]
		private void KHEJHAEOOEP(in global::HEOOIFLCBHF<object, ENAKEJDNHIE> FADBLLIMALF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct KFBEKMPIIAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::OIKOOBCAEPL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::CIFPHBKLPJI<JAJGHMMBKDD> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::CIFPHBKLPJI<DFHKOFEHMLN> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C6A0", Offset = "0x2A4B2A0", VA = "0x182A4C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C8D0", Offset = "0x2A4B4D0", VA = "0x182A4C8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PAEIHLBDJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::OIKOOBCAEPL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::CIFPHBKLPJI<JAJGHMMBKDD> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::CIFPHBKLPJI<DFHKOFEHMLN> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BDFEJANFBBM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2A59940", Offset = "0x2A58540", VA = "0x182A59940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2A5A0D0", Offset = "0x2A58CD0", VA = "0x182A5A0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct BHEOLAEHIDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::OIKOOBCAEPL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BDFEJANFBBM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BDFEJANFBBM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2A46A50", Offset = "0x2A45650", VA = "0x182A46A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver GELIAAEGOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps PFGDLBMGPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps MLDJGJKNDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int AAJAGHCMMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int EBGLEBCNMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::CIFPHBKLPJI<DFHKOFEHMLN>, TaskCompletionSource<global::HEOOIFLCBHF<object, ENAKEJDNHIE>>> KNLBGBPKDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::KAMAAJEBNFG<DFHKOFEHMLN> JNGGCPGKHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool OFDEIOCAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int KECDHJBAAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task HLFOLCOCKOB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x404F270", Offset = "0x404DE70", VA = "0x18404F270")]
	protected OIKOOBCAEPL(TActionDeps EENLJPOKJDF, TStaticNetSysDeps BBCFDAJDBEC, int MKEJOHEKBFK, int OHKIHJOHPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x404EB90", Offset = "0x404D790", VA = "0x18404EB90")]
	public static global::OIKOOBCAEPL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> EBNJNBKPCHE(TActionDeps EENLJPOKJDF, TStaticNetSysDeps BBCFDAJDBEC, [Optional] int? MKEJOHEKBFK, [Optional] int? OHKIHJOHPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x404EF70", Offset = "0x404DB70", VA = "0x18404EF70")]
	public Task<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> ODLLLEPJJLB(in TAction FHCMCNABNIM, bool JJPILNGENFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x404ECC0", Offset = "0x404D8C0", VA = "0x18404ECC0")]
	public void ECGEMPJNGJH(in TActionReceiver FMJBEFCIEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x404E8C0", Offset = "0x404D4C0", VA = "0x18404E8C0")]
	[AsyncStateMachine(typeof(global::OIKOOBCAEPL<, , , >.KFBEKMPIIAO))]
	public Task<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> APJKFPDNGPO(global::CIFPHBKLPJI<JAJGHMMBKDD> BHOBBHFIIOL, global::CIFPHBKLPJI<DFHKOFEHMLN> JBEDNGOOODE, TAction FHCMCNABNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x404ECD0", Offset = "0x404D8D0", VA = "0x18404ECD0")]
	[AsyncStateMachine(typeof(global::OIKOOBCAEPL<, , , >.PAEIHLBDJMN))]
	private Task<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> LFJOKECGGCE(global::CIFPHBKLPJI<JAJGHMMBKDD> BHOBBHFIIOL, global::CIFPHBKLPJI<DFHKOFEHMLN> JBEDNGOOODE, TAction FHCMCNABNIM, Task PJAKDEFHCJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x404EE20", Offset = "0x404DA20", VA = "0x18404EE20")]
	[AsyncStateMachine(typeof(global::OIKOOBCAEPL<, , , >.BHEOLAEHIDG))]
	private Task MNMJCDFAHAA(TAction FHCMCNABNIM, BDFEJANFBBM BALKEADOKJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x404EA10", Offset = "0x404D610", VA = "0x18404EA10")]
	private void BPAEPPNPPMM(TAction FHCMCNABNIM, bool ONMLJDCBIDJ, bool FCNHPFEHGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3314F30", Offset = "0x3313B30", VA = "0x183314F30", Slot = "4")]
	private Task<global::HEOOIFLCBHF<object, ENAKEJDNHIE>> LHKNGIOMKIJ(in TAction FHCMCNABNIM, bool JJPILNGENFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class IPPACFKALKD : ENAKEJDNHIE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE54AD0", Offset = "0xE536D0", VA = "0x180E54AD0", Slot = "4")]
	public override string ECPKHNEAEAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE54B00", Offset = "0xE53700", VA = "0x180E54B00")]
	private IPPACFKALKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x218F430", Offset = "0x218E030", VA = "0x18218F430")]
	public static global::HEOOIFLCBHF<TOk, ENAKEJDNHIE> EBNJNBKPCHE<TOk>()
	{
		return default(global::HEOOIFLCBHF<TOk, ENAKEJDNHIE>);
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
