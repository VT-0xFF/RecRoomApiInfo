using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251D6A0", Offset = "0x251CAA0", VA = "0x18251D6A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ANALLCGONGO : IDisposable, OHCEKJDAKFA, ECOMDBPJGBI, KOEMANGIIDJ, NNFIGJFLKIC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class KBBECALOOID : OALMGBEMPGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int HGOCPMKGIPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2519D70", Offset = "0x2519170", VA = "0x182519D70", Slot = "5")]
		public HNDIPKGBMMO HNNCMPMKNIG(AKKKOMJEAOO.OLOBPBHCFKI GKFDJGEMKAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void MHLJMPHNMEF();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void NHIABHMIMML();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2519F40", Offset = "0x2519340", VA = "0x182519F40", Slot = "13")]
		public virtual void NFOKJFBPIHF(ANALLCGONGO DFLGEEGCPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2519EC0", Offset = "0x25192C0", VA = "0x182519EC0", Slot = "14")]
		public virtual void KFCGHNNPOPA(ANALLCGONGO DFLGEEGCPMI, GKPCJPMFCCN PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		protected KBBECALOOID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OALMGBEMPGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int HGOCPMKGIPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HNDIPKGBMMO HNNCMPMKNIG(AKKKOMJEAOO.OLOBPBHCFKI GKFDJGEMKAB);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MHLJMPHNMEF();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NHIABHMIMML();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NFOKJFBPIHF(ANALLCGONGO DFLGEEGCPMI);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KFCGHNNPOPA(ANALLCGONGO DFLGEEGCPMI, GKPCJPMFCCN PJDAFKMDDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct GFBEBKDMEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NKBPINFEMPK<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> NBIHMNBOAEA;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x250C4B0", Offset = "0x250B8B0", VA = "0x18250C4B0")]
		internal GFBEBKDMEGG(NKBPINFEMPK<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ADDHNMPOBIA : NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly ADDHNMPOBIA IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		private ADDHNMPOBIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D0BF0", Offset = "0x9CFFF0", VA = "0x1809D0BF0", Slot = "4")]
		public BKANLMFPFAO ECMMNNHBDPD(GKPCJPMFCCN JDCFMPOHCEA)
		{
			return default(BKANLMFPFAO);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x25026E0", Offset = "0x2501AE0", VA = "0x1825026E0", Slot = "5")]
		public void NFOKJFBPIHF(ANALLCGONGO JGHOOBNHEJB, GKPCJPMFCCN PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x25025D0", Offset = "0x25019D0", VA = "0x1825025D0", Slot = "6")]
		public void KFCGHNNPOPA(ANALLCGONGO JGHOOBNHEJB, GKPCJPMFCCN PJDAFKMDDCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BPNMPGBEFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HMHNOMGHDBI<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> NBIHMNBOAEA;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2505520", Offset = "0x2504920", VA = "0x182505520")]
		internal BPNMPGBEFAB(HMHNOMGHDBI<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x25054D0", Offset = "0x25048D0", VA = "0x1825054D0")]
		public static BPNMPGBEFAB FEOBEKOIKMG()
		{
			return default(BPNMPGBEFAB);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct DMODJMPEDLA : JJINKDABDAO.DDEAJPHIICG<GKPCJPMFCCN, ANALLCGONGO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct CPCMFIMAMEB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public ANALLCGONGO receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GKPCJPMFCCN action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DMODJMPEDLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2505AB0", Offset = "0x2504EB0", VA = "0x182505AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2505C90", Offset = "0x2505090", VA = "0x182505C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD39090", Offset = "0xD38490", VA = "0x180D39090", Slot = "4")]
		public AAFGLNNJOHN<LEJAOJOLFIL> PCAPCCPBPKC(ANALLCGONGO ODAGIILJBBF)
		{
			return default(AAFGLNNJOHN<LEJAOJOLFIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2506860", Offset = "0x2505C60", VA = "0x182506860", Slot = "5")]
		public void PCCIFMBJCNL(ANALLCGONGO ODAGIILJBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2506730", Offset = "0x2505B30", VA = "0x182506730", Slot = "6")]
		[AsyncStateMachine(typeof(CPCMFIMAMEB))]
		public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> NHFLDOKKJDG(ANALLCGONGO ODAGIILJBBF, GKPCJPMFCCN PJDAFKMDDCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2506710", Offset = "0x2505B10", VA = "0x182506710", Slot = "7")]
		public GKPCJPMFCCN[] GGJBDHLEMGE(ANALLCGONGO ODAGIILJBBF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ELKKPMIPCGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<bool, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ANALLCGONGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<JOFBNNGKBOO<bool, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2508ED0", Offset = "0x25082D0", VA = "0x182508ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2509160", Offset = "0x2508560", VA = "0x182509160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NDHHBAONFCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ANALLCGONGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x251D450", Offset = "0x251C850", VA = "0x18251D450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x251D630", Offset = "0x251CA30", VA = "0x18251D630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HEMOODLCLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ANALLCGONGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GKPCJPMFCCN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x250D370", Offset = "0x250C770", VA = "0x18250D370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x250D560", Offset = "0x250C960", VA = "0x18250D560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AAFGLNNJOHN<LEJAOJOLFIL> OHIAPKNBLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GFBEBKDMEGG BCKOFFPGOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MCFODAPLEMO JHPCJNONPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly PLFMNGFKFHK FDMBLNBINGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AF0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IMAMHOOCJJD OPLKDHGAEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AF8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NAPFONIDFOF.DHABAJMPACM BBMDLIEJGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PFHMAFDDNAH MLOBGKIJFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly IKAOBOCJFBC DMJAIGOOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly GMPNDNPPCAN MCOCHJIGJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EBKJNLBDILK EMPPPMCOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KCDLEKFBDJI CPNDLFGBNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FIJJIOIHDCF JNGDDKHPGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly MCFODAPLEMO.EIINLOONONC MKIOBPKHMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly IINEAIHFAEH DPCJCMNPBNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MCFODAPLEMO IJCMOLCPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2504220", Offset = "0x2503620", VA = "0x182504220")]
		get
		{
			return default(MCFODAPLEMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal OALMGBEMPGB PPAJKFABENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25041D0", Offset = "0x25035D0", VA = "0x1825041D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HNDIPKGBMMO KFHBLOKIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2504DB0", Offset = "0x25041B0", VA = "0x182504DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2504A20", Offset = "0x2503E20", VA = "0x182504A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool JDEAJEAMBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2504C60", Offset = "0x2504060", VA = "0x182504C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2504A10", Offset = "0x2503E10", VA = "0x182504A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AJLEDLNKANK BIANCAINFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x25050C0", Offset = "0x25044C0", VA = "0x1825050C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GNIGFNFNOIA JAOFKFOLIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x25050D0", Offset = "0x25044D0", VA = "0x1825050D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KFBJGPELJDA IBJPNDOMINL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x25050F0", Offset = "0x25044F0", VA = "0x1825050F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PCBMEDABEPH CDGCNGPDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x25050E0", Offset = "0x25044E0", VA = "0x1825050E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NAPFONIDFOF? KJMECFJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2503AB0", Offset = "0x2502EB0", VA = "0x182503AB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private MIBHJHEHAJB? JAACGHEPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2504A40", Offset = "0x2503E40", VA = "0x182504A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2504DC0", Offset = "0x25041C0", VA = "0x182504DC0")]
	private ANALLCGONGO(IMAMHOOCJJD KPHLIDJMEFA, AAFGLNNJOHN<LEJAOJOLFIL> CGHBAOIKKLL, [In] GFBEBKDMEGG HAHFPCFGGPJ, [In] MCFODAPLEMO JMCFKKNNBPG, [In] PLFMNGFKFHK MFDCKPKKMGD, HNDIPKGBMMO LLDKBOFNBEP, [In] NAPFONIDFOF.DHABAJMPACM KONEPOGDPOP, MCFODAPLEMO.EIINLOONONC PHCJIPOMDCG, IINEAIHFAEH DOPCGIDJNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2504540", Offset = "0x2503940", VA = "0x182504540")]
	public static ANALLCGONGO FEOBEKOIKMG(IMAMHOOCJJD GKFDJGEMKAB, [In] MPIJMBBAFGM NIHKHDELHBC, OAMPFCKMMAH NPMHMGNGBCB, [In] CBHNHGPJBLC LBCFDHIHPOP, GCIMGMNHDFF KNCFIIMLEHI, AAFGLNNJOHN<LEJAOJOLFIL> CGHBAOIKKLL, AAFGLNNJOHN<LOCODMBOCKM> GHJDKDMDPJE, NHECKHEMBJH MKMHAKPJKLC, JGNLKIBMJMM HKAEADLODCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2504230", Offset = "0x2503630", VA = "0x182504230")]
	public static ANALLCGONGO FEOBEKOIKMG(IMAMHOOCJJD KPHLIDJMEFA, [In] MCFODAPLEMO JMCFKKNNBPG, [In] PLFMNGFKFHK MFDCKPKKMGD, AAFGLNNJOHN<LEJAOJOLFIL> CGHBAOIKKLL, AAFGLNNJOHN<LOCODMBOCKM> GHJDKDMDPJE, NHECKHEMBJH MKMHAKPJKLC, JGNLKIBMJMM HKAEADLODCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2503FE0", Offset = "0x25033E0", VA = "0x182503FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2504B70", Offset = "0x2503F70", VA = "0x182504B70")]
	[AsyncStateMachine(typeof(ELKKPMIPCGJ))]
	public Task<JOFBNNGKBOO<bool, PPAGHPBHFJD>> MIMGDLJCPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2504CC0", Offset = "0x25040C0", VA = "0x182504CC0")]
	[AsyncStateMachine(typeof(NDHHBAONFCF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> PEBNGKPELPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2503B30", Offset = "0x2502F30", VA = "0x182503B30")]
	internal void DHACCMKHHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2503A30", Offset = "0x2502E30", VA = "0x182503A30")]
	internal HEGNJKKKIBE<GKPCJPMFCCN> COCDEILOMPH([In] HDICGNLFMJC CLCDGLGOFOK)
	{
		return default(HEGNJKKKIBE<GKPCJPMFCCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x25039C0", Offset = "0x2502DC0", VA = "0x1825039C0")]
	internal bool BMICDOJFOHM([In] HDICGNLFMJC CLCDGLGOFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2503D40", Offset = "0x2503140", VA = "0x182503D40")]
	internal JOFBNNGKBOO<GKPCJPMFCCN, PPAGHPBHFJD> DMJBNMEOAIB([In] DGLIEKMCMIA HOPODOMHJIG)
	{
		return default(JOFBNNGKBOO<GKPCJPMFCCN, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2504C70", Offset = "0x2504070", VA = "0x182504C70")]
	private void PCCIFMBJCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2503ED0", Offset = "0x25032D0", VA = "0x182503ED0")]
	[AsyncStateMachine(typeof(HEMOODLCLBA))]
	internal Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> DPDNBFEHLMB(GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2504680", Offset = "0x2503A80", VA = "0x182504680")]
	private GKPCJPMFCCN[] GGJBDHLEMGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CDBCIIIFODN<TData> : PGAGFEIEKID, LOBMCHILMEJ, EAPODONBJNH where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HMBFEKDDECL<MOHGMBIPFPM>? FKOJNEADOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string MADHOOEDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData FENODPMPHEB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HMBFEKDDECL<MOHGMBIPFPM>? HGOJPGMPGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x277E5B0", Offset = "0x277D9B0", VA = "0x18277E5B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5A38710", Offset = "0x5A37B10", VA = "0x185A38710")]
	internal CDBCIIIFODN([In] HMBFEKDDECL<MOHGMBIPFPM>? CDNDAAFFENM, AAFGLNNJOHN<MBNEIPNGAFM>? PIBGEDDCHCI, IOKind? GACCJJGLILE, string MIALAMIFNLM, [In] TData GIDGOODJFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class INGPJGPFAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x250D990", Offset = "0x250CD90", VA = "0x18250D990")]
	public static JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ> HDEKFCLEBND([In] this MPALANKACLD<KNKGKAJFOIB> MHMBHELMFMF)
	{
		return default(JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33CF650", Offset = "0x33CEA50", VA = "0x1833CF650")]
	public static JOFBNNGKBOO<TOk, LOBMCHILMEJ> KHELFIMHHKF<TOk>([In] this JOFBNNGKBOO<TOk, LOBMCHILMEJ> JDCFMPOHCEA, [In] HMBFEKDDECL<MOHGMBIPFPM>? CDNDAAFFENM, AAFGLNNJOHN<MBNEIPNGAFM>? PIBGEDDCHCI, IOKind? GACCJJGLILE, string MIALAMIFNLM) where TOk : notnull
	{
		return default(JOFBNNGKBOO<TOk, LOBMCHILMEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IMAMHOOCJJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GLOHCHOJCIM.IJLPCMCDLFO HHGEHMFJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	AKKKOMJEAOO.OLOBPBHCFKI PLDNNPNAFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	ANALLCGONGO.OALMGBEMPGB KEHCLAIANAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	AIIOGMFDPOA.OLMPEGJBIHN IKELANILPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO> NHPNLEHJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MPIPBIEPCIM.CIPPEHHPPDA CAMCBHODMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IMJBELIIDML PMGFIKOAALP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	ALENBMHCMPF KOGCJAMCEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KNGKLKCEJJA DEHFCECFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GAOMEGJGNAE GGOADPDKCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BGOLFJJKINL FIBNHGPDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MHOBNALCLBG
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x251D110", Offset = "0x251C510", VA = "0x18251D110")]
	public static GKPCJPMFCCN MJFLCHPCKPJ(this GKPCJPMFCCN JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x251D040", Offset = "0x251C440", VA = "0x18251D040")]
	public static GKPCJPMFCCN HJMDNNECGMF(this PPBKDIGKDNJ JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct PPBKDIGKDNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct GGKEBAMCGON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public ANALLCGONGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PPBKDIGKDNJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x250C4C0", Offset = "0x250B8C0", VA = "0x18250C4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x250C780", Offset = "0x250BB80", VA = "0x18250C780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString DEDOPNLMLPL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	private PPBKDIGKDNJ(ByteString KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x251F670", Offset = "0x251EA70", VA = "0x18251F670")]
	public static GKPCJPMFCCN CEMOOOEJOGL(ByteString KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x251F840", Offset = "0x251EC40", VA = "0x18251F840")]
	public static FAGPPDKBBNO<BKANLMFPFAO, PPBKDIGKDNJ> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, PPBKDIGKDNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x251F730", Offset = "0x251EB30", VA = "0x18251F730")]
	[AsyncStateMachine(typeof(GGKEBAMCGON))]
	public static Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> DPDNBFEHLMB(ANALLCGONGO JGHOOBNHEJB, PPBKDIGKDNJ JDCFMPOHCEA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CIKENIFGBLP
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2505620", Offset = "0x2504A20", VA = "0x182505620")]
	public static GKPCJPMFCCN CEMOOOEJOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25056C0", Offset = "0x2504AC0", VA = "0x1825056C0")]
	public static FAGPPDKBBNO<BKANLMFPFAO, CIKENIFGBLP> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, CIKENIFGBLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2505730", Offset = "0x2504B30", VA = "0x182505730")]
	public static JOFBNNGKBOO<IDMEFNAINAN, MPAEBDCEOBD> IAKLNGNNDFI(ANALLCGONGO JGHOOBNHEJB, [In] CIKENIFGBLP JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<IDMEFNAINAN, MPAEBDCEOBD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct DABMDHIJLOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct AJMIBMLPMPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, MPAEBDCEOBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ANALLCGONGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DABMDHIJLOH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JOFBNNGKBOO<IDMEFNAINAN, MPAEBDCEOBD> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2502FB0", Offset = "0x25023B0", VA = "0x182502FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2503320", Offset = "0x2502720", VA = "0x182503320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DJKKMHFELNP? LAIECHLPADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly OELEFOKLIPK? NPDJEIMBMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HFDFODLNHEC? MBHJDOOLIBH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x243BC70", Offset = "0x243B070", VA = "0x18243BC70")]
	private DABMDHIJLOH(DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2505D00", Offset = "0x2505100", VA = "0x182505D00")]
	public static GKPCJPMFCCN? CEMOOOEJOGL(DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2505F40", Offset = "0x2505340", VA = "0x182505F40")]
	public static FAGPPDKBBNO<BKANLMFPFAO, DABMDHIJLOH> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, DABMDHIJLOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2505E00", Offset = "0x2505200", VA = "0x182505E00")]
	[AsyncStateMachine(typeof(AJMIBMLPMPC))]
	public static Task<JOFBNNGKBOO<IDMEFNAINAN, MPAEBDCEOBD>> DPDNBFEHLMB(ANALLCGONGO JGHOOBNHEJB, DABMDHIJLOH JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JDPJGGMODMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct ENNGHLGEKAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JDPJGGMODMC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ANALLCGONGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JOFBNNGKBOO<object?, EAPODONBJNH>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JOFBNNGKBOO<object?, EAPODONBJNH> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private JOFBNNGKBOO<object?, EAPODONBJNH>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x25091D0", Offset = "0x25085D0", VA = "0x1825091D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2509630", Offset = "0x2508A30", VA = "0x182509630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<GKPCJPMFCCN> HJPMLCHDFAK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	private JDPJGGMODMC(IReadOnlyList<GKPCJPMFCCN> NOFICAHDIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2518C40", Offset = "0x2518040", VA = "0x182518C40")]
	public static GKPCJPMFCCN CEMOOOEJOGL(IReadOnlyList<GKPCJPMFCCN> NOFICAHDIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2518E40", Offset = "0x2518240", VA = "0x182518E40")]
	public static FAGPPDKBBNO<BKANLMFPFAO, JDPJGGMODMC> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, JDPJGGMODMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2518D00", Offset = "0x2518100", VA = "0x182518D00")]
	[AsyncStateMachine(typeof(ENNGHLGEKAC))]
	public static Task<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> DPDNBFEHLMB(ANALLCGONGO JGHOOBNHEJB, JDPJGGMODMC JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DGLIEKMCMIA
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class ACDDHAOJDHA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JJIHNLJMGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HMBFEKDDECL<ACDDHAOJDHA> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JJIHNLJMGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2519A40", Offset = "0x2518E40", VA = "0x182519A40")]
		internal GKPCJPMFCCN EPNFPDNJPNP(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly HMBFEKDDECL<ACDDHAOJDHA> CIDOAEGFKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int AGHLCEGEAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int MPMCCDHNNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] FENODPMPHEB;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25066F0", Offset = "0x2505AF0", VA = "0x1825066F0")]
	private DGLIEKMCMIA(HMBFEKDDECL<ACDDHAOJDHA> GPBEADEPELC, int BBEJNKBNMID, int EAHKFAJBNDN, byte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25061E0", Offset = "0x25055E0", VA = "0x1825061E0")]
	public static GKPCJPMFCCN CEMOOOEJOGL(HMBFEKDDECL<ACDDHAOJDHA> GPBEADEPELC, int BBEJNKBNMID, int EAHKFAJBNDN, ByteString GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25065E0", Offset = "0x25059E0", VA = "0x1825065E0")]
	public static GKPCJPMFCCN[] OLLCFLKPEGG(GKPCJPMFCCN PJDAFKMDDCG, int AAMJFOFMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25062F0", Offset = "0x25056F0", VA = "0x1825062F0")]
	public static FAGPPDKBBNO<BKANLMFPFAO, DGLIEKMCMIA> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, DGLIEKMCMIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2506440", Offset = "0x2505840", VA = "0x182506440")]
	public static JOFBNNGKBOO<GKPCJPMFCCN, PPAGHPBHFJD> IAKLNGNNDFI(ANALLCGONGO JGHOOBNHEJB, [In] DGLIEKMCMIA JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<GKPCJPMFCCN, PPAGHPBHFJD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct HDICGNLFMJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct ELAIDBBJMJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<bool, MPAEBDCEOBD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ANALLCGONGO root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public HDICGNLFMJC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JOFBNNGKBOO<bool, MPAEBDCEOBD> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, MPAEBDCEOBD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2508820", Offset = "0x2507C20", VA = "0x182508820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2508E60", Offset = "0x2508260", VA = "0x182508E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int AGHLCEGEAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int MPMCCDHNNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] FENODPMPHEB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xAA87C0", Offset = "0xAA7BC0", VA = "0x180AA87C0")]
	private HDICGNLFMJC(int BBEJNKBNMID, int EAHKFAJBNDN, byte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x250CE80", Offset = "0x250C280", VA = "0x18250CE80")]
	public static GKPCJPMFCCN CEMOOOEJOGL(int BBEJNKBNMID, int EAHKFAJBNDN, ByteString GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x250D090", Offset = "0x250C490", VA = "0x18250D090")]
	public static GKPCJPMFCCN?[]? ELKGMNEHJDM(int AAMJFOFMHFE, DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x250D290", Offset = "0x250C690", VA = "0x18250D290")]
	public static FAGPPDKBBNO<BKANLMFPFAO, HDICGNLFMJC> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, HDICGNLFMJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x250CF60", Offset = "0x250C360", VA = "0x18250CF60")]
	[AsyncStateMachine(typeof(ELAIDBBJMJD))]
	public static Task<JOFBNNGKBOO<bool, MPAEBDCEOBD>> DPDNBFEHLMB(ANALLCGONGO JGHOOBNHEJB, HDICGNLFMJC JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PFHMAFDDNAH : AJLEDLNKANK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BDPFCDHFIFF? IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x251F000", Offset = "0x251E400", VA = "0x18251F000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	internal PFHMAFDDNAH(ANALLCGONGO DFLGEEGCPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EDICMIIAGJB : BDPFCDHFIFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FGAGELOHMIE MIEFHMKNDJG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public EDICMIIAGJB(ANALLCGONGO DFLGEEGCPMI, FGAGELOHMIE LPHHLKJDLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2506C30", Offset = "0x2506030", VA = "0x182506C30", Slot = "4")]
	public JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ> HEAAGMPGNPF(HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO)
	{
		return default(JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2506F10", Offset = "0x2506310", VA = "0x182506F10", Slot = "5")]
	public JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ> NLONLDFDPCO(HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP)
	{
		return default(JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GLOHCHOJCIM : HLOLLCBMKHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IJLPCMCDLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FGAGELOHMIE> CCHENACKIKG(ANALLCGONGO DFLGEEGCPMI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IIPMLPJOFAH FPGHKBAMHMG(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class AIJEOBDIICE : IJLPCMCDLFO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct FKLJFHDCGPL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<FGAGELOHMIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public ANALLCGONGO circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public OELEFOKLIPK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HFDFODLNHEC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<AIIOGMFDPOA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x250B650", Offset = "0x250AA50", VA = "0x18250B650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x250B820", Offset = "0x250AC20", VA = "0x18250B820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly AIJEOBDIICE IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		private AIJEOBDIICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2502B10", Offset = "0x2501F10", VA = "0x182502B10", Slot = "4")]
		[AsyncStateMachine(typeof(FKLJFHDCGPL))]
		public Task<FGAGELOHMIE> CCHENACKIKG(ANALLCGONGO DFLGEEGCPMI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2502C70", Offset = "0x2502070", VA = "0x182502C70", Slot = "5")]
		public IIPMLPJOFAH FPGHKBAMHMG(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct PDHIPNEMJCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<GLOHCHOJCIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ANALLCGONGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public OELEFOKLIPK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HFDFODLNHEC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DJKKMHFELNP evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private IJLPCMCDLFO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<FGAGELOHMIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x251EA90", Offset = "0x251DE90", VA = "0x18251EA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x251EF90", Offset = "0x251E390", VA = "0x18251EF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FGAGELOHMIE MIEFHMKNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly IIPMLPJOFAH IEBFOMGJIAO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NAPFONIDFOF KJMECFJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x250C7F0", Offset = "0x250BBF0", VA = "0x18250C7F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MIBHJHEHAJB LPAFAHPPKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x250C8A0", Offset = "0x250BCA0", VA = "0x18250C8A0", Slot = "5")]
		get
		{
			return default(MIBHJHEHAJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EDICMIIAGJB IAFJMKPEANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public GHGILLKJOFN CKPGHPIJDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xDB5AD0", Offset = "0xDB4ED0", VA = "0x180DB5AD0")]
	private GLOHCHOJCIM(FGAGELOHMIE LPHHLKJDLIO, IIPMLPJOFAH GEACFDKHKOC, EDICMIIAGJB OGEMFOHPEOL, GHGILLKJOFN HNHMGPGOPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x250C960", Offset = "0x250BD60", VA = "0x18250C960")]
	[AsyncStateMachine(typeof(PDHIPNEMJCJ))]
	public static Task<GLOHCHOJCIM> PIEBIBJICAE(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x250C840", Offset = "0x250BC40", VA = "0x18250C840", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class AKKKOMJEAOO : HNDIPKGBMMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface OLOBPBHCFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HLOLLCBMKHJ> JGGBIMNHBBI(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LFCGHPHDMPI();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HLNIKOFFLHO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class JPNBIHPKMKO : OLOBPBHCFKI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct HABLDJMIJJE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<HLOLLCBMKHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public ANALLCGONGO circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public DJKKMHFELNP evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public OELEFOKLIPK cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HFDFODLNHEC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<GLOHCHOJCIM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x250CAD0", Offset = "0x250BED0", VA = "0x18250CAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x250CE10", Offset = "0x250C210", VA = "0x18250CE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2519C10", Offset = "0x2519010", VA = "0x182519C10", Slot = "4")]
		[AsyncStateMachine(typeof(HABLDJMIJJE))]
		public Task<HLOLLCBMKHJ> JGGBIMNHBBI(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LFCGHPHDMPI();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HLNIKOFFLHO();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		protected JPNBIHPKMKO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct BLBKMPFFPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<HLOLLCBMKHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AKKKOMJEAOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<IDMEFNAINAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2505260", Offset = "0x2504660", VA = "0x182505260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2505460", Offset = "0x2504860", VA = "0x182505460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct OBALLDLMCNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AKKKOMJEAOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public ANALLCGONGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DJKKMHFELNP evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public OELEFOKLIPK cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HFDFODLNHEC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HLOLLCBMKHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x251D990", Offset = "0x251CD90", VA = "0x18251D990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x251DEC0", Offset = "0x251D2C0", VA = "0x18251DEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OLOBPBHCFKI JDFKOKOAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<IDMEFNAINAN> GODFENIFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<IDMEFNAINAN> OCOKLFNMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource FMNHMHHPEFF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JDEAJEAMBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x977EC0", Offset = "0x9772C0", VA = "0x180977EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xC3E0F0", Offset = "0xC3D4F0", VA = "0x180C3E0F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x11075F0", Offset = "0x11069F0", VA = "0x1811075F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GAHCALICHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1779820", Offset = "0x1778C20", VA = "0x181779820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2503480", Offset = "0x2502880", VA = "0x182503480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HLOLLCBMKHJ? EMBEKCDACDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x94FAD0", Offset = "0x94EED0", VA = "0x18094FAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2503390", Offset = "0x2502790", VA = "0x182503390", Slot = "7")]
	[AsyncStateMachine(typeof(BLBKMPFFPJD))]
	public Task<HLOLLCBMKHJ> ACGMJKHEDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2503770", Offset = "0x2502B70", VA = "0x182503770")]
	public AKKKOMJEAOO(OLOBPBHCFKI GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2503610", Offset = "0x2502A10", VA = "0x182503610", Slot = "8")]
	[AsyncStateMachine(typeof(OBALLDLMCNL))]
	public Task IJJPGHFDAMO(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2503490", Offset = "0x2502890", VA = "0x182503490", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class IBHLCLHDLIN : OMODINFLPGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GHGILLKJOFN PHLPNONMAOP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public IBHLCLHDLIN(GHGILLKJOFN HNHMGPGOPBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class DAECCEEAMGB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class HOAKKKMMIPN<TGraph> : GOKGCFFOMBC where TGraph : PKHNPALDKBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph MGKNBEDBJLD;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual DHADCBFMHEB? IMJHEIHICIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x15969A0", Offset = "0x1595DA0", VA = "0x1815969A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AAFGLNNJOHN<IBLJEHJLOFH> JEDJBPCDOPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x46680B0", Offset = "0x46674B0", VA = "0x1846680B0", Slot = "5")]
			get
			{
				return default(AAFGLNNJOHN<IBLJEHJLOFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AAFGLNNJOHN<IBLJEHJLOFH>? JPBBGBOJFBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4668030", Offset = "0x4667430", VA = "0x184668030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
		public HOAKKKMMIPN(TGraph CJLJJENJCHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class AOJEEGOIOEC : HOAKKKMMIPN<NJNKJGHAEIP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override DHADCBFMHEB? IMJHEIHICIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2505100", Offset = "0x2504500", VA = "0x182505100", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2505120", Offset = "0x2504520", VA = "0x182505120")]
		public AOJEEGOIOEC(NJNKJGHAEIP IHLGBEHIHGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2506050", Offset = "0x2505450", VA = "0x182506050")]
	public static GOKGCFFOMBC FEOBEKOIKMG(PKHNPALDKBJ CJLJJENJCHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class KDPBGGCOFDK : FJGNOIDBIMJ, CDCNPBIAEIP, FPMPKFDBAJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CAPKLIINEEK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CAPKLIINEEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public IMJBELIIDML errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x251F8F0", Offset = "0x251ECF0", VA = "0x18251F8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x251FB60", Offset = "0x251EF60", VA = "0x18251FB60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KDPBGGCOFDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CAPKLIINEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2505530", Offset = "0x2504930", VA = "0x182505530")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task MNDEBMJMGNF(IMJBELIIDML errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct PJLHPHBJBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public KDPBGGCOFDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x251F100", Offset = "0x251E500", VA = "0x18251F100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x251F610", Offset = "0x251EA10", VA = "0x18251F610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FNOOOMNODEB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public FNOOOMNODEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x251FBC0", Offset = "0x251EFC0", VA = "0x18251FBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x251FEA0", Offset = "0x251F2A0", VA = "0x18251FEA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public KDPBGGCOFDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FNOOOMNODEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x250B890", Offset = "0x250AC90", VA = "0x18250B890")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task JCEKGBMPONI(IMJBELIIDML errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JBHKBKNGGIE LNNMLJCHLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<BBEGDIMCAGL> DEEAGJNIHGL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private IMAMHOOCJJD BPADDHGGIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x251A560", Offset = "0x2519960", VA = "0x18251A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public AAFGLNNJOHN<EAGGAAMICCD> DPENBOJHKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xD72810", Offset = "0xD71C10", VA = "0x180D72810", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<EAGGAAMICCD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xD71670", Offset = "0xD70A70", VA = "0x180D71670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private AAFGLNNJOHN<GLPBIEDACAD> HAADBKFHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1108470", Offset = "0x1107870", VA = "0x181108470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> GGBFAFGOPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x971C10", Offset = "0x971010", VA = "0x180971C10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override AAFGLNNJOHN<MBNEIPNGAFM> JNKHFFHLLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x251AE20", Offset = "0x251A220", VA = "0x18251AE20", Slot = "21")]
		get
		{
			return default(AAFGLNNJOHN<MBNEIPNGAFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OMHAABKOGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x251AEC0", Offset = "0x251A2C0", VA = "0x18251AEC0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x251C7D0", Offset = "0x251BBD0", VA = "0x18251C7D0")]
	private KDPBGGCOFDK(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, JBHKBKNGGIE BBOEDEGJDGO, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO, AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, bool PFCNKPEGGGF, string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x251AA70", Offset = "0x2519E70", VA = "0x18251AA70")]
	public static KDPBGGCOFDK FEOBEKOIKMG(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, JBHKBKNGGIE IOJLNNHDMIE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO, bool PFCNKPEGGGF, bool CAIFGFNEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x251B090", Offset = "0x251A490", VA = "0x18251B090", Slot = "22")]
	protected override void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x251A8F0", Offset = "0x2519CF0", VA = "0x18251A8F0", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x251B340", Offset = "0x251A740", VA = "0x18251B340", Slot = "31")]
	public void JIPOAEFLEIC(BBEGDIMCAGL GMCKAINFGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x251A580", Offset = "0x2519980", VA = "0x18251A580", Slot = "28")]
	public void DMOMODCOIJB(CJOLANKLLLC MFMAAEJAKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x251BE20", Offset = "0x251B220", VA = "0x18251BE20", Slot = "29")]
	public void PAPEFNAGMAJ(NAFIPGKODIH IKBBGNEMAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x251AF40", Offset = "0x251A340", VA = "0x18251AF40", Slot = "24")]
	protected override void HKJFIOLGBII(LHFOHFDEOKM IMBHIBDELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x251BBA0", Offset = "0x251AFA0", VA = "0x18251BBA0", Slot = "33")]
	public string OHDFKHEOEHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2519F80", Offset = "0x2519380", VA = "0x182519F80", Slot = "30")]
	public string AONPCELGDMA(int FCDJJGFAGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x251B4B0", Offset = "0x251A8B0", VA = "0x18251B4B0")]
	private void KJIBGEBPHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x251B6E0", Offset = "0x251AAE0", VA = "0x18251B6E0", Slot = "32")]
	public void KPEEJDOADBI(BBEGDIMCAGL GMCKAINFGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x251A3A0", Offset = "0x25197A0", VA = "0x18251A3A0")]
	private void CACEHLIGNEE(bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x251BD10", Offset = "0x251B110", VA = "0x18251BD10", Slot = "34")]
	[AsyncStateMachine(typeof(PJLHPHBJBGK))]
	public Task OJCIHPNGCHI(string KBGCCIOIGBD, bool HNHIAMODIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x251B130", Offset = "0x251A530", VA = "0x18251B130")]
	public void JFFADKLCNOO(string KBGCCIOIGBD, bool HNHIAMODIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x251B870", Offset = "0x251AC70", VA = "0x18251B870")]
	private void MPPLKHEBNMF(int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xD71670", Offset = "0xD70A70", VA = "0x180D71670")]
	internal void NLOIHDBPEPA(AAFGLNNJOHN<EAGGAAMICCD> KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x251A310", Offset = "0x2519710", VA = "0x18251A310")]
	[CompilerGenerated]
	private void BOMFONPKLIA(string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x251B7B0", Offset = "0x251ABB0", VA = "0x18251B7B0")]
	[CompilerGenerated]
	private bool MNIKGGBFCCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x251B280", Offset = "0x251A680", VA = "0x18251B280")]
	[CompilerGenerated]
	private bool JGDGHBNFPBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x251A990", Offset = "0x2519D90", VA = "0x18251A990")]
	[CompilerGenerated]
	private int EHPCDAPPMCL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x251A9E0", Offset = "0x2519DE0", VA = "0x18251A9E0")]
	[CompilerGenerated]
	private bool FEAIHGMIEEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x251B7A0", Offset = "0x251ABA0", VA = "0x18251B7A0")]
	[CompilerGenerated]
	private void MNEEBMGIBDM(string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x251BA10", Offset = "0x251AE10", VA = "0x18251BA10")]
	[CompilerGenerated]
	private bool NEOBEBFDHAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x251AE70", Offset = "0x251A270", VA = "0x18251AE70")]
	[CompilerGenerated]
	private bool GPNOGPBNIFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x251B3A0", Offset = "0x251A7A0", VA = "0x18251B3A0")]
	[CompilerGenerated]
	private bool KCGHOHJBPGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x251A990", Offset = "0x2519D90", VA = "0x18251A990")]
	[CompilerGenerated]
	private int MLDGONLDKGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x251BAD0", Offset = "0x251AED0", VA = "0x18251BAD0")]
	[CompilerGenerated]
	private bool OGGEJIOADIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x251B430", Offset = "0x251A830", VA = "0x18251B430")]
	[CompilerGenerated]
	private object KFPOJHAGHND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x251A320", Offset = "0x2519720", VA = "0x18251A320")]
	[CompilerGenerated]
	private void BPOGPOBBCBN(object KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x251A240", Offset = "0x2519640", VA = "0x18251A240")]
	[CompilerGenerated]
	private bool BLDNCBOJFMO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class EENJAHAJEJK
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class CNMMOKIBEGG : KPJGEGMJNEL<PEDLBFHLHOK>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class KLGODBOPLOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public CNMMOKIBEGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KLGODBOPLOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x251CC90", Offset = "0x251C090", VA = "0x18251CC90")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x251CBC0", Offset = "0x251BFC0", VA = "0x18251CBC0")]
			internal void FHAIOPDBBKM(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2505A40", Offset = "0x2504E40", VA = "0x182505A40")]
		public CNMMOKIBEGG(ANALLCGONGO DFLGEEGCPMI, PEDLBFHLHOK AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x25057B0", Offset = "0x2504BB0", VA = "0x1825057B0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class JJMHJGAEEKL : OKEKOINPNCC<AHOJMOMFBEM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override FAIPOOJKNPF JOJILFEBLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2519BB0", Offset = "0x2518FB0", VA = "0x182519BB0")]
		public JJMHJGAEEKL(ANALLCGONGO DFLGEEGCPMI, AHOJMOMFBEM AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class DPJPIMCIMPP : KPJGEGMJNEL<FGFEELIEOLM>
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2506BC0", Offset = "0x2505FC0", VA = "0x182506BC0")]
		public DPJPIMCIMPP(ANALLCGONGO DFLGEEGCPMI, FGFEELIEOLM HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x25069F0", Offset = "0x2505DF0", VA = "0x1825069F0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2506B70", Offset = "0x2505F70", VA = "0x182506B70")]
		[CompilerGenerated]
		private bool LBHCJCADGGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x25068C0", Offset = "0x2505CC0", VA = "0x1825068C0")]
		[CompilerGenerated]
		private void CCMCMDCHFML(bool KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class OMMNMNEIKED : KPJGEGMJNEL<LAAIEHIAPEN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class OAFNIJDCMFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public OMMNMNEIKED <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public OAFNIJDCMFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x251D8F0", Offset = "0x251CCF0", VA = "0x18251D8F0")]
			internal void MNLGAMGLBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x251D770", Offset = "0x251CB70", VA = "0x18251D770")]
			internal bool FHAIOPDBBKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x251D940", Offset = "0x251CD40", VA = "0x18251D940")]
			internal bool MNPFLPCHHNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x251D7C0", Offset = "0x251CBC0", VA = "0x18251D7C0")]
			internal void JFBADLEIDLK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x251D720", Offset = "0x251CB20", VA = "0x18251D720")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x251E260", Offset = "0x251D660", VA = "0x18251E260")]
		public OMMNMNEIKED(ANALLCGONGO DFLGEEGCPMI, LAAIEHIAPEN HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x251DF20", Offset = "0x251D320", VA = "0x18251DF20", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class OPIEGBPGLFI : KPJGEGMJNEL<MJJADHBDHME>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class GEJKLGPIKJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public OPIEGBPGLFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public GEJKLGPIKJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x250C240", Offset = "0x250B640", VA = "0x18250C240")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x250BEC0", Offset = "0x250B2C0", VA = "0x18250BEC0")]
			internal bool FFNOGLAOMOO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x250BF40", Offset = "0x250B340", VA = "0x18250BF40")]
			internal void FHAIOPDBBKM(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x250C340", Offset = "0x250B740", VA = "0x18250C340")]
			internal string MNPFLPCHHNE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x250C1A0", Offset = "0x250B5A0", VA = "0x18250C1A0")]
			internal IReadOnlyList<object> JFBADLEIDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x250BD20", Offset = "0x250B120", VA = "0x18250BD20")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x250C1F0", Offset = "0x250B5F0", VA = "0x18250C1F0")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x250BD90", Offset = "0x250B190", VA = "0x18250BD90")]
			internal void EOFCJLIFDNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x251EA20", Offset = "0x251DE20", VA = "0x18251EA20")]
		public OPIEGBPGLFI(ANALLCGONGO DFLGEEGCPMI, MJJADHBDHME HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x251E2D0", Offset = "0x251D6D0", VA = "0x18251E2D0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class AILAOLHCNAK : KPJGEGMJNEL<EIBFDEPAGCD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class KFNJFFCGNFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AILAOLHCNAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KFNJFFCGNFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x251CB20", Offset = "0x251BF20", VA = "0x18251CB20")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x251C9F0", Offset = "0x251BDF0", VA = "0x18251C9F0")]
			internal void FHAIOPDBBKM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x251CB70", Offset = "0x251BF70", VA = "0x18251CB70")]
			internal bool MNPFLPCHHNE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2502F40", Offset = "0x2502340", VA = "0x182502F40")]
		public AILAOLHCNAK(ANALLCGONGO DFLGEEGCPMI, EIBFDEPAGCD HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2502D10", Offset = "0x2502110", VA = "0x182502D10", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class LGEECOLFGLO<TNode> : KPJGEGMJNEL<TNode> where TNode : notnull, FNLFINKGLNN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CJDBOPOOCHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LGEECOLFGLO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5A43ED0", Offset = "0x5A432D0", VA = "0x185A43ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5A442E0", Offset = "0x5A436E0", VA = "0x185A442E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct EDIEECLBBCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public LGEECOLFGLO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9010", Offset = "0x3FF8410", VA = "0x183FF9010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9420", Offset = "0x3FF8820", VA = "0x183FF9420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool DIDJGIAICIC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override AAFGLNNJOHN<FANPJMFIOIH>? GGAOKAAECHE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4B5DCE0", Offset = "0x4B5D0E0", VA = "0x184B5DCE0", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4B5DC90", Offset = "0x4B5D090", VA = "0x184B5DC90")]
		protected LGEECOLFGLO(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4B5D880", Offset = "0x4B5CC80", VA = "0x184B5D880", Slot = "112")]
		[AsyncStateMachine(typeof(LGEECOLFGLO<>.CJDBOPOOCHH))]
		public override Task<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> AAGHMFMMFIK(string OMOOEGOLALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4B5D9A0", Offset = "0x4B5CDA0", VA = "0x184B5D9A0", Slot = "136")]
		public sealed override bool FGCCEDEMFKF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4B5DBF0", Offset = "0x4B5CFF0", VA = "0x184B5DBF0", Slot = "124")]
		protected sealed override bool ODGPFOGEFMK(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4B5DB50", Offset = "0x4B5CF50", VA = "0x184B5DB50", Slot = "125")]
		protected override bool LIPAHAGNIEN(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4B5DA40", Offset = "0x4B5CE40", VA = "0x184B5DA40", Slot = "113")]
		[AsyncStateMachine(typeof(LGEECOLFGLO<>.EDIEECLBBCC))]
		public override Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LIBHMPMMKHI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class AEANKGOCDJJ : NMGOABEKKFO<HBANPKEGEJE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class AMIMNFPALGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AEANKGOCDJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public AMIMNFPALGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2503880", Offset = "0x2502C80", VA = "0x182503880")]
			internal bool ANPGGHIJLED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2503900", Offset = "0x2502D00", VA = "0x182503900")]
			internal void KACMPDEBBLL(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2502AB0", Offset = "0x2501EB0", VA = "0x182502AB0")]
		public AEANKGOCDJJ(ANALLCGONGO DFLGEEGCPMI, HBANPKEGEJE AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2502860", Offset = "0x2501C60", VA = "0x182502860", Slot = "138")]
		protected override void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class LJJMIGPCJDA : PAIFOJMLBIA<DDJBKNJBBNG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x251CFE0", Offset = "0x251C3E0", VA = "0x18251CFE0")]
		public LJJMIGPCJDA(ANALLCGONGO DFLGEEGCPMI, DDJBKNJBBNG HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class PAIFOJMLBIA<TNode> : KPJGEGMJNEL<TNode> where TNode : notnull, GIHCNLHIOIN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct LNNKLAIJEHP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public PAIFOJMLBIA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4B6C680", Offset = "0x4B6BA80", VA = "0x184B6C680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4B6CB30", Offset = "0x4B6BF30", VA = "0x184B6CB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct POPKPPPCDJE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public PAIFOJMLBIA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x50B9D60", Offset = "0x50B9160", VA = "0x1850B9D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x50BA1E0", Offset = "0x50B95E0", VA = "0x1850BA1E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct OCPGKGNMGNA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public PAIFOJMLBIA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4F8B9D0", Offset = "0x4F8ADD0", VA = "0x184F8B9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4F8C080", Offset = "0x4F8B480", VA = "0x184F8C080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class MKOBDMKMABF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public MKOBDMKMABF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x3CE22B0", Offset = "0x3CE16B0", VA = "0x183CE22B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public JNIHAMPHLFB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public PAIFOJMLBIA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public MKOBDMKMABF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4DAD4C0", Offset = "0x4DAC8C0", VA = "0x184DAD4C0")]
			internal bool EOFCJLIFDNB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4DADA30", Offset = "0x4DACE30", VA = "0x184DADA30")]
			internal void MNLGAMGLBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4DAD5A0", Offset = "0x4DAC9A0", VA = "0x184DAD5A0")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.MKOBDMKMABF.<<BuildConfigMenuInternal>b__7>d))]
			internal void FFNOGLAOMOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4DAD640", Offset = "0x4DACA40", VA = "0x184DAD640")]
			internal bool FHAIOPDBBKM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class KMPDFKMLODF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public KMPDFKMLODF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3CE1F40", Offset = "0x3CE1340", VA = "0x183CE1F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public MKOBDMKMABF CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KMPDFKMLODF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4A69540", Offset = "0x4A68940", VA = "0x184A69540")]
			internal void MNPFLPCHHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			internal string JFBADLEIDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			internal void CFFDGMAAICP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4A694A0", Offset = "0x4A688A0", VA = "0x184A694A0")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.KMPDFKMLODF.<<BuildConfigMenuInternal>b__5>d))]
			internal void MHLJJEBILLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class OOJKPPHEAMA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public OOJKPPHEAMA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3CE1A70", Offset = "0x3CE0E70", VA = "0x183CE1A70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				public OOJKPPHEAMA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<JOFBNNGKBOO<AAFGLNNJOHN<GLPBIEDACAD>, PPAGHPBHFJD>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3CE1C50", Offset = "0x3CE1050", VA = "0x183CE1C50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public OOJKPPHEAMA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<JOFBNNGKBOO<AAFGLNNJOHN<JEHMBJHBIMC>, PPAGHPBHFJD>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3CE13B0", Offset = "0x3CE07B0", VA = "0x183CE13B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public PAIFOJMLBIA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public JNIHAMPHLFB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public BCINBNEJLKM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public NADGPPCKHDL selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<PKCIAPNEFJF> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public NADGPPCKHDL selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<PKCIAPNEFJF> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public OOJKPPHEAMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4FCBDD0", Offset = "0x4FCB1D0", VA = "0x184FCBDD0")]
			internal bool CMDEAHEOLMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC4C0", Offset = "0x4FCB8C0", VA = "0x184FCC4C0")]
			internal void MOHKNFFJPJD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC3E0", Offset = "0x4FCB7E0", VA = "0x184FCC3E0")]
			internal bool MMJBBPBNHLD(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC010", Offset = "0x4FCB410", VA = "0x184FCC010")]
			internal bool FGHBFFAABNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC110", Offset = "0x4FCB510", VA = "0x184FCC110")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OOJKPPHEAMA.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void GEJGLANPPCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC1B0", Offset = "0x4FCB5B0", VA = "0x184FCC1B0")]
			internal bool HEMLPLFODBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC050", Offset = "0x4FCB450", VA = "0x184FCC050")]
			internal void GCLBJIKHGID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC600", Offset = "0x4FCBA00", VA = "0x184FCC600")]
			internal bool PIFLKAAPLHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4FCBEE0", Offset = "0x4FCB2E0", VA = "0x184FCBEE0")]
			internal void COJJFMHKIEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC330", Offset = "0x4FCB730", VA = "0x184FCC330")]
			internal bool MLPODFAPGNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC1F0", Offset = "0x4FCB5F0", VA = "0x184FCC1F0")]
			internal bool LPKOGAGGFMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4FCBFA0", Offset = "0x4FCB3A0", VA = "0x184FCBFA0")]
			internal void DGFMAMOJJLC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4FCBD30", Offset = "0x4FCB130", VA = "0x184FCBD30")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OOJKPPHEAMA.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void BJGNFMHBKAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC260", Offset = "0x4FCB660", VA = "0x184FCC260")]
			internal bool LPLFFGNNKEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC590", Offset = "0x4FCB990", VA = "0x184FCC590")]
			internal bool PHPOAECPPGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC2C0", Offset = "0x4FCB6C0", VA = "0x184FCC2C0")]
			internal void MAOCEALLBIN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4FCBE40", Offset = "0x4FCB240", VA = "0x184FCBE40")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OOJKPPHEAMA.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CNOCFOOGDKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4FCC530", Offset = "0x4FCB930", VA = "0x184FCC530")]
			internal bool OOBLJGOONGG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class PIMJMLIJALN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public PIMJMLIJALN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3CE16A0", Offset = "0x3CE0AA0", VA = "0x183CE16A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public OOJKPPHEAMA CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public PIMJMLIJALN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x50A72E0", Offset = "0x50A66E0", VA = "0x1850A72E0")]
			internal void NFAKIAMLCLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			internal string IGLNKMIBKKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			internal void PHPNDHHBLNI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x50A76F0", Offset = "0x50A6AF0", VA = "0x1850A76F0")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.PIMJMLIJALN.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void NOFCHAJAKEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class MMFPGAJOOAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public BCINBNEJLKM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<PKCIAPNEFJF> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public PAIFOJMLBIA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public MMFPGAJOOAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4DBB3A0", Offset = "0x4DBA7A0", VA = "0x184DBB3A0")]
			internal bool APEGFEGHHPG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class JJLHCBFOKJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public FPMPKFDBAJK port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public MMFPGAJOOAA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public JJLHCBFOKJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4974E00", Offset = "0x4974200", VA = "0x184974E00")]
			internal void OHJLONAFGPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4974D50", Offset = "0x4974150", VA = "0x184974D50")]
			internal bool MMLNOMIHAID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4974C30", Offset = "0x4974030", VA = "0x184974C30")]
			internal void JCEDLJGDOKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4974DA0", Offset = "0x49741A0", VA = "0x184974DA0")]
			internal bool NOFODFIDKIJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class DHBOGECJPEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public PKCIAPNEFJF portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JJLHCBFOKJO CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public DHBOGECJPEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x62A7BC0", Offset = "0x62A6FC0", VA = "0x1862A7BC0")]
			internal void JACDDDHFPDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class PJNMIHPNMGM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public PJNMIHPNMGM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x3CE36E0", Offset = "0x3CE2AE0", VA = "0x183CE36E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public NADGPPCKHDL selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public BCINBNEJLKM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public FPMPKFDBAJK port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public PJNMIHPNMGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x50AA140", Offset = "0x50A9540", VA = "0x1850AA140")]
			internal int BDPKHKDEIKB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x50AA180", Offset = "0x50A9580", VA = "0x1850AA180")]
			internal void CIEHMGFKHCM(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			internal string LAJKHLOJCBO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x50AA4B0", Offset = "0x50A98B0", VA = "0x1850AA4B0")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.PJNMIHPNMGM.<<CreatePortItemV2>b__3>d))]
			internal void DNMJGFKEFOH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x50AA3D0", Offset = "0x50A97D0", VA = "0x1850AA3D0")]
			internal bool DFKHEHOBNEB(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<AAFGLNNJOHN<FANPJMFIOIH>, bool> ENIAKDJBMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<AAFGLNNJOHN<FANPJMFIOIH>, bool> HGDNNEPMNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<AAFGLNNJOHN<FANPJMFIOIH>, bool> HEGGEJJHHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<AAFGLNNJOHN<FANPJMFIOIH>, bool> MPMNCAJNNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<AAFGLNNJOHN<FANPJMFIOIH>, bool> ICNHJDCOCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<AAFGLNNJOHN<FANPJMFIOIH>, bool> NKCPPCGEMGJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool JDPIAKIDKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool BDACDICJDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "138")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool LHLODOLAMFG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "139")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool HCDEMMHOAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override AAFGLNNJOHN<IBLJEHJLOFH>? KCLMIPMJJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x506CEB0", Offset = "0x506C2B0", VA = "0x18506CEB0", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override AAFGLNNJOHN<FANPJMFIOIH>? GGAOKAAECHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x506D160", Offset = "0x506C560", VA = "0x18506D160", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>>? MLLAGLOBHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x506CF60", Offset = "0x506C360", VA = "0x18506CF60", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x506CC90", Offset = "0x506C090", VA = "0x18506CC90")]
		public PAIFOJMLBIA(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "141")]
		protected virtual bool NGFOIDJBGEF(int FJDBFNNAAKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "142")]
		protected virtual bool JEOIMILNNJC(int FJDBFNNAAKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "143")]
		protected virtual bool HHBMIIKJKJP(int FJDBFNNAAKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "144")]
		protected virtual void APMLDJMKEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5069060", Offset = "0x5068460", VA = "0x185069060", Slot = "136")]
		public override bool FGCCEDEMFKF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5068310", Offset = "0x5067710", VA = "0x185068310", Slot = "112")]
		[AsyncStateMachine(typeof(PAIFOJMLBIA<>.LNNKLAIJEHP))]
		public override Task<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> AAGHMFMMFIK(string OMOOEGOLALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x506AFD0", Offset = "0x506A3D0", VA = "0x18506AFD0", Slot = "113")]
		[AsyncStateMachine(typeof(PAIFOJMLBIA<>.POPKPPPCDJE))]
		public override Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LIBHMPMMKHI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x506B350", Offset = "0x506A750", VA = "0x18506B350", Slot = "114")]
		public override void NMECNBPNFEN(AAFGLNNJOHN<FANPJMFIOIH> EAHKFAJBNDN, AAFGLNNJOHN<FANPJMFIOIH> MOCLCNOAHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x506B0E0", Offset = "0x506A4E0", VA = "0x18506B0E0", Slot = "115")]
		public override IEnumerable<GKPCJPMFCCN> MDJGDBMDLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5068F60", Offset = "0x5068360", VA = "0x185068F60")]
		[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OCPGKGNMGNA))]
		private Task<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> CDFFEEBJOPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "145")]
		protected virtual bool KEKEJAIBHOF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "146")]
		protected virtual bool BABMPOOFJOO(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "147")]
		protected virtual bool COIONFGDFNP(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "148")]
		protected virtual bool HLBEOOAMFEI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "149")]
		protected virtual bool LPNJFMEBJEP(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int CJAOOJKODJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "150")]
		protected virtual bool OPDAKIEBJPC(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int CJAOOJKODJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "151")]
		protected virtual bool EMLDBMCINLO(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int FDBDHBKHPNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "152")]
		protected virtual bool ACBEOEAGCLG(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int FDBDHBKHPNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "153")]
		protected virtual bool FDNMEOFBLNI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int HAONHOPHKAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "154")]
		protected virtual bool ILKIFLCLNJE(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int JLLMELNAAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x506ACA0", Offset = "0x506A0A0", VA = "0x18506ACA0", Slot = "155")]
		protected virtual List<NADGPPCKHDL> JNIBBLFJBPO(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "156")]
		protected virtual void GGEIIJCCBJF(JNIHAMPHLFB BFJOGMMEGHN, MAGDHBMCIOD HFOGNBBNAHB, BCINBNEJLKM LGLGJHFKMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5069100", Offset = "0x5068500", VA = "0x185069100", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x506B560", Offset = "0x506A960", VA = "0x18506B560")]
		private MAGDHBMCIOD PHNLPLJHGPM(JNIHAMPHLFB BFJOGMMEGHN, BCINBNEJLKM LGLGJHFKMFK, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5069B60", Offset = "0x5068F60", VA = "0x185069B60")]
		private List<PKCIAPNEFJF> HBFAKONKGGH(JNIHAMPHLFB BFJOGMMEGHN, BCINBNEJLKM LGLGJHFKMFK, MAGDHBMCIOD LHKJFNOFGLC, bool NLHKPNGOOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5068430", Offset = "0x5067830", VA = "0x185068430")]
		private List<PKCIAPNEFJF> BBNHEEEFBLA(JNIHAMPHLFB BFJOGMMEGHN, BCINBNEJLKM LGLGJHFKMFK, FPMPKFDBAJK GMEMHACONIH, bool NLHKPNGOOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5068D70", Offset = "0x5068170", VA = "0x185068D70")]
		private NADGPPCKHDL BFDBCJOCFDG(List<NADGPPCKHDL> LNHHHADKGMM, FPMPKFDBAJK GMEMHACONIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x506AF40", Offset = "0x506A340", VA = "0x18506AF40")]
		[CompilerGenerated]
		private GKPCJPMFCCN KHLPKNIKGBA(ALJLKHOFDLJ BKHEBBAMMAK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class MMILCOBCECM : KPJGEGMJNEL<GOPPKFCBKIB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class KLIMMPELILI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public MMILCOBCECM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KLIMMPELILI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x251CD90", Offset = "0x251C190", VA = "0x18251CD90")]
			internal int MNLGAMGLBJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x251CD00", Offset = "0x251C100", VA = "0x18251CD00")]
			internal void FHAIOPDBBKM(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECE1D0", VA = "0x180ECEDD0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x251D3E0", Offset = "0x251C7E0", VA = "0x18251D3E0")]
		public MMILCOBCECM(ANALLCGONGO DFLGEEGCPMI, GOPPKFCBKIB HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x251D220", Offset = "0x251C620", VA = "0x18251D220", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class IIGCEKEAOIP : NMGOABEKKFO<HPMDMHPCLBB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class ILFNADIFHLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public IIGCEKEAOIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public ILFNADIFHLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x250D870", Offset = "0x250CC70", VA = "0x18250D870")]
			internal int ANPGGHIJLED()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x250D8F0", Offset = "0x250CCF0", VA = "0x18250D8F0")]
			internal void KACMPDEBBLL(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x250D810", Offset = "0x250CC10", VA = "0x18250D810")]
		public IIGCEKEAOIP(ANALLCGONGO DFLGEEGCPMI, HPMDMHPCLBB AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x250D5D0", Offset = "0x250C9D0", VA = "0x18250D5D0", Slot = "138")]
		protected override void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class BDCHGPHCKEM : KPJGEGMJNEL<CCCLAMOLEGI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC004D0", Offset = "0xBFF8D0", VA = "0x180C004D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x25051F0", Offset = "0x25045F0", VA = "0x1825051F0")]
		public BDCHGPHCKEM(ANALLCGONGO DFLGEEGCPMI, CCCLAMOLEGI HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class FJEOLEMFKCG : KPJGEGMJNEL<DHCDMFPPKPL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class JCOMDDBKDAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public FJEOLEMFKCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public JNIHAMPHLFB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public JCOMDDBKDAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2517C60", Offset = "0x2517060", VA = "0x182517C60")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2515BA0", Offset = "0x2514FA0", VA = "0x182515BA0")]
			internal void FHAIOPDBBKM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x250EC20", Offset = "0x250E020", VA = "0x18250EC20")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2517AA0", Offset = "0x2516EA0", VA = "0x182517AA0")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2515760", Offset = "0x2514B60", VA = "0x182515760")]
			internal void EOFCJLIFDNB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2518560", Offset = "0x2517960", VA = "0x182518560")]
			internal bool PAFFPCEOHAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x250F2D0", Offset = "0x250E6D0", VA = "0x18250F2D0")]
			internal bool DJEPEOCLBMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2517A40", Offset = "0x2516E40", VA = "0x182517A40")]
			internal void MHGKDMAEKNL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2517490", Offset = "0x2516890", VA = "0x182517490")]
			internal bool LENJCKCPMFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x25168C0", Offset = "0x2515CC0", VA = "0x1825168C0")]
			internal bool IGLDHMCDLKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2518250", Offset = "0x2517650", VA = "0x182518250")]
			internal void OBIOHKPKDLM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x2518600", Offset = "0x2517A00", VA = "0x182518600")]
			internal bool PDGPMHDKFCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2517860", Offset = "0x2516C60", VA = "0x182517860")]
			internal bool MDGJJBACGEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x25181B0", Offset = "0x25175B0", VA = "0x1825181B0")]
			internal bool NPJPOPKEGFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2517DB0", Offset = "0x25171B0", VA = "0x182517DB0")]
			internal bool NHIAAPBHBBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x250F550", Offset = "0x250E950", VA = "0x18250F550")]
			internal bool EFHKDHJIKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x250EBD0", Offset = "0x250DFD0", VA = "0x18250EBD0")]
			internal bool CFCJCCHJDEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x250EF60", Offset = "0x250E360", VA = "0x18250EF60")]
			internal bool DBJCFBKOBML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x250EA20", Offset = "0x250DE20", VA = "0x18250EA20")]
			internal bool CAOJMOPFBEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2516EB0", Offset = "0x25162B0", VA = "0x182516EB0")]
			internal bool KCDHGPAMGND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2515DB0", Offset = "0x25151B0", VA = "0x182515DB0")]
			internal void FLDEBBCNFBN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x250F1C0", Offset = "0x250E5C0", VA = "0x18250F1C0")]
			internal bool DHJMILALOHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x250E430", Offset = "0x250D830", VA = "0x18250E430")]
			internal bool AHPEODDEBKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x25164D0", Offset = "0x25158D0", VA = "0x1825164D0")]
			internal bool HNBIMCMNDKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2516A10", Offset = "0x2515E10", VA = "0x182516A10")]
			internal bool IOLLDEJMLKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2517EA0", Offset = "0x25172A0", VA = "0x182517EA0")]
			internal bool NKBHOPJGHPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2516680", Offset = "0x2515A80", VA = "0x182516680")]
			internal bool IACHLJHJMKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x25165E0", Offset = "0x25159E0", VA = "0x1825165E0")]
			internal bool HPJKGIAPNJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x250E3E0", Offset = "0x250D7E0", VA = "0x18250E3E0")]
			internal bool AHNNBNADIKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2517CB0", Offset = "0x25170B0", VA = "0x182517CB0")]
			internal void MOGIMGLBHHC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x250DE30", Offset = "0x250D230", VA = "0x18250DE30")]
			internal bool AADHAJACJML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2517240", Offset = "0x2516640", VA = "0x182517240")]
			internal bool KMHLNONDDGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2516150", Offset = "0x2515550", VA = "0x182516150")]
			internal void GOILPAKGPBD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2516390", Offset = "0x2515790", VA = "0x182516390")]
			internal bool HJKMDCCGFJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x25185B0", Offset = "0x25179B0", VA = "0x1825185B0")]
			internal bool PDBDKMIOCGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x250F160", Offset = "0x250E560", VA = "0x18250F160")]
			internal void DGGAOACIFDH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x250F5F0", Offset = "0x250E9F0", VA = "0x18250F5F0")]
			internal List<PKCIAPNEFJF> EJMLGFMGLFM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x25158D0", Offset = "0x2514CD0", VA = "0x1825158D0")]
			internal bool EOLHINCMNLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2516A60", Offset = "0x2515E60", VA = "0x182516A60")]
			internal int IPIFIIBFAIH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2515F50", Offset = "0x2515350", VA = "0x182515F50")]
			internal void GEFGMGEOBIE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2515C50", Offset = "0x2515050", VA = "0x182515C50")]
			internal bool FILDGGMPAKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x250E680", Offset = "0x250DA80", VA = "0x18250E680")]
			internal bool BELHECJFCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2515E60", Offset = "0x2515260", VA = "0x182515E60")]
			internal bool FMGJEADJGFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x250ECC0", Offset = "0x250E0C0", VA = "0x18250ECC0")]
			internal int CHNOPPACJEI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x25183F0", Offset = "0x25177F0", VA = "0x1825183F0")]
			internal void OHBDCCJCFIO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x250F460", Offset = "0x250E860", VA = "0x18250F460")]
			internal bool EDFEABDGBKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2515E10", Offset = "0x2515210", VA = "0x182515E10")]
			internal bool FLKAONCFKHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2515D60", Offset = "0x2515160", VA = "0x182515D60")]
			internal bool FLBOBGDLHJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x250E7C0", Offset = "0x250DBC0", VA = "0x18250E7C0")]
			internal bool BNFEGNCAKIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2515AB0", Offset = "0x2514EB0", VA = "0x182515AB0")]
			internal bool FCJDGEAHHGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x25169C0", Offset = "0x2515DC0", VA = "0x1825169C0")]
			internal bool INOKCGIGCJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2516DB0", Offset = "0x25161B0", VA = "0x182516DB0")]
			internal string JOGEIDNKHPO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2516D40", Offset = "0x2516140", VA = "0x182516D40")]
			internal void JMMMFOBFDOC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2517D10", Offset = "0x2517110", VA = "0x182517D10")]
			internal int MPMEGEIBAAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x250E810", Offset = "0x250DC10", VA = "0x18250E810")]
			internal void BNINDOKNBLC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x250E720", Offset = "0x250DB20", VA = "0x18250E720")]
			internal bool BLMBAALCPHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2516820", Offset = "0x2515C20", VA = "0x182516820")]
			internal bool IFCBMPAFIIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x250E4E0", Offset = "0x250D8E0", VA = "0x18250E4E0")]
			internal bool ALDPFEGEPFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x250EB30", Offset = "0x250DF30", VA = "0x18250EB30")]
			internal float CEIGIMDMDFL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2518650", Offset = "0x2517A50", VA = "0x182518650")]
			internal void PFALMAMNIAJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x250E870", Offset = "0x250DC70", VA = "0x18250E870")]
			internal bool BNMIMHCNLEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x250EFB0", Offset = "0x250E3B0", VA = "0x18250EFB0")]
			internal bool DCEDIABAMGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2515920", Offset = "0x2514D20", VA = "0x182515920")]
			internal bool EONECAFNEMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2516430", Offset = "0x2515830", VA = "0x182516430")]
			internal bool HLKPEGJDBPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2518000", Offset = "0x2517400", VA = "0x182518000")]
			internal bool NMHMLENGEKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x250F3C0", Offset = "0x250E7C0", VA = "0x18250F3C0")]
			internal bool DNMCJPKGPBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x250DED0", Offset = "0x250D2D0", VA = "0x18250DED0")]
			internal void ADFKFPLDGHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2516480", Offset = "0x2515880", VA = "0x182516480")]
			internal string HLNANALFCKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x25170E0", Offset = "0x25164E0", VA = "0x1825170E0")]
			internal void KLBENAKFKFC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2517090", Offset = "0x2516490", VA = "0x182517090")]
			internal bool KLAHLLBJHFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x250F0C0", Offset = "0x250E4C0", VA = "0x18250F0C0")]
			internal bool DFLKNELDINK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2516AB0", Offset = "0x2515EB0", VA = "0x182516AB0")]
			internal bool JANAEELBOJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2518970", Offset = "0x2517D70", VA = "0x182518970")]
			internal void PPPEILOOCHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x25162A0", Offset = "0x25156A0", VA = "0x1825162A0")]
			internal bool HGKDNHBNGOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x250EEC0", Offset = "0x250E2C0", VA = "0x18250EEC0")]
			internal bool CPNBGOJNIOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x250F410", Offset = "0x250E810", VA = "0x18250F410")]
			internal bool DPGOAFGMMEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x250E8C0", Offset = "0x250DCC0", VA = "0x18250E8C0")]
			internal bool BOPKGPGEPMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x25166D0", Offset = "0x2515AD0", VA = "0x1825166D0")]
			internal void IAOJGMAGGKH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2517810", Offset = "0x2516C10", VA = "0x182517810")]
			internal bool MBDCIABHMKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2515970", Offset = "0x2514D70", VA = "0x182515970")]
			internal bool EPJANIPLPFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x250E6D0", Offset = "0x250DAD0", VA = "0x18250E6D0")]
			internal bool BLKONHAPONP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2518720", Offset = "0x2517B20", VA = "0x182518720")]
			internal bool PGJOAAOFJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x250E480", Offset = "0x250D880", VA = "0x18250E480")]
			internal void AICGPGJADIL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x25179A0", Offset = "0x2516DA0", VA = "0x1825179A0")]
			internal bool MEMBFELHDMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x25176C0", Offset = "0x2516AC0", VA = "0x1825176C0")]
			internal bool LOLKIHBACCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2517AF0", Offset = "0x2516EF0", VA = "0x182517AF0")]
			internal bool MIKADMICEBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2517FB0", Offset = "0x25173B0", VA = "0x182517FB0")]
			internal bool NMCANBFKPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x250F260", Offset = "0x250E660", VA = "0x18250F260")]
			internal object DJCGLBAOBGI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2517BD0", Offset = "0x2516FD0", VA = "0x182517BD0")]
			internal void MNBGOJPPBKD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x25162F0", Offset = "0x25156F0", VA = "0x1825162F0")]
			internal bool HGMNPKHPNMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x25188D0", Offset = "0x2517CD0", VA = "0x1825188D0")]
			internal bool PNODIHFFGDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2517E00", Offset = "0x2517200", VA = "0x182517E00")]
			internal int NIDHPEHLANH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2517710", Offset = "0x2516B10", VA = "0x182517710")]
			internal void LOPBKPKJHCN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2516250", Offset = "0x2515650", VA = "0x182516250")]
			internal bool HBDDLMLEPEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2516B50", Offset = "0x2515F50", VA = "0x182516B50")]
			internal bool JCOEDIDJIJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2518300", Offset = "0x2517700", VA = "0x182518300")]
			internal int ODGLNBBOKBN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x250EA70", Offset = "0x250DE70", VA = "0x18250EA70")]
			internal void CBAAGKKAGKI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2516910", Offset = "0x2515D10", VA = "0x182516910")]
			internal bool IIJNHBPPAPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2515FB0", Offset = "0x25153B0", VA = "0x182515FB0")]
			internal bool GFMCJMKJDHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x25180A0", Offset = "0x25174A0", VA = "0x1825180A0")]
			internal bool NOAIMJFDHEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2515880", Offset = "0x2514C80", VA = "0x182515880")]
			internal int EOKNOBGCBCP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x250E2E0", Offset = "0x250D6E0", VA = "0x18250E2E0")]
			internal void ADLBAPDJNKC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2516F00", Offset = "0x2516300", VA = "0x182516F00")]
			internal bool KDEEJCEFGPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x250EB80", Offset = "0x250DF80", VA = "0x18250EB80")]
			internal bool CEINCODHIKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x25159C0", Offset = "0x2514DC0", VA = "0x1825159C0")]
			internal bool FBMDEPOALOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2516570", Offset = "0x2515970", VA = "0x182516570")]
			internal object HOHEEIGLCLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2517B40", Offset = "0x2516F40", VA = "0x182517B40")]
			internal void MMMADGNGJDB(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x25174E0", Offset = "0x25168E0", VA = "0x1825174E0")]
			internal bool LEOEEIGGJBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2516000", Offset = "0x2515400", VA = "0x182516000")]
			internal bool GIADPBHJICM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2518450", Offset = "0x2517850", VA = "0x182518450")]
			internal object OHNPNJMFEGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2516CB0", Offset = "0x25160B0", VA = "0x182516CB0")]
			internal void JMFGCOJGPOH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x250F5A0", Offset = "0x250E9A0", VA = "0x18250F5A0")]
			internal bool EGPMNFILNLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x25178B0", Offset = "0x2516CB0", VA = "0x1825178B0")]
			internal int MDOEFMIFBPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x250E580", Offset = "0x250D980", VA = "0x18250E580")]
			internal void AOPMAFGHPLP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2517F60", Offset = "0x2517360", VA = "0x182517F60")]
			internal bool NLACLCMMOLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2516FA0", Offset = "0x25163A0", VA = "0x182516FA0")]
			internal bool KHJILCCCDLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2516FF0", Offset = "0x25163F0", VA = "0x182516FF0")]
			internal bool KHLBPBBDMFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x250E770", Offset = "0x250DB70", VA = "0x18250E770")]
			internal int BMBAEPMEOMA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2516960", Offset = "0x2515D60", VA = "0x182516960")]
			internal void IKMIGNLFJBE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2516630", Offset = "0x2515A30", VA = "0x182516630")]
			internal bool IAAABBDBMNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x250EE70", Offset = "0x250E270", VA = "0x18250EE70")]
			internal bool CPMPHAPGENO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2518350", Offset = "0x2517750", VA = "0x182518350")]
			internal bool OEEGDELPAFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2518880", Offset = "0x2517C80", VA = "0x182518880")]
			internal float PNCBBEIILCO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2517580", Offset = "0x2516980", VA = "0x182517580")]
			internal void LGHKEKLHKAA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x25172E0", Offset = "0x25166E0", VA = "0x1825172E0")]
			internal bool KONHJHPIMAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2517900", Offset = "0x2516D00", VA = "0x182517900")]
			internal bool MDPHODPKPOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2515C00", Offset = "0x2515000", VA = "0x182515C00")]
			internal bool FIFIDLKCLFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2517150", Offset = "0x2516550", VA = "0x182517150")]
			internal float KLBIJKDIOMD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x250EAD0", Offset = "0x250DED0", VA = "0x18250EAD0")]
			internal void CDCCOJGHKHH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x25163E0", Offset = "0x25157E0", VA = "0x1825163E0")]
			internal bool HKPMKOLEDND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x250F320", Offset = "0x250E720", VA = "0x18250F320")]
			internal bool DKEBOCBKIEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2516780", Offset = "0x2515B80", VA = "0x182516780")]
			internal string ICPIDJCMOJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x250EDB0", Offset = "0x250E1B0", VA = "0x18250EDB0")]
			internal void CMAHMBKBONF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x250EF10", Offset = "0x250E310", VA = "0x18250EF10")]
			internal bool CPNMCAMKNAP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x250E9D0", Offset = "0x250DDD0", VA = "0x18250E9D0")]
			internal bool CANBCKCPKAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2517E50", Offset = "0x2517250", VA = "0x182517E50")]
			internal bool NKANCDEELMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2518920", Offset = "0x2517D20", VA = "0x182518920")]
			internal bool POCPCBPKKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x250EC70", Offset = "0x250E070", VA = "0x18250EC70")]
			internal string CFJJIFJFEEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x25180F0", Offset = "0x25174F0", VA = "0x1825180F0")]
			internal void NONGBMEKFOA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2515710", Offset = "0x2514B10", VA = "0x182515710")]
			internal bool ENODGILEBCL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x250E5E0", Offset = "0x250D9E0", VA = "0x18250E5E0")]
			internal bool BABNMNFDCCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x25183A0", Offset = "0x25177A0", VA = "0x1825183A0")]
			internal bool OGFPFDGIOAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2515B50", Offset = "0x2514F50", VA = "0x182515B50")]
			internal bool FFLBBDPHBPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2516730", Offset = "0x2515B30", VA = "0x182516730")]
			internal string ICGDEDDGCND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x25187C0", Offset = "0x2517BC0", VA = "0x1825187C0")]
			internal void PKGGIHLJIEK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x25157C0", Offset = "0x2514BC0", VA = "0x1825157C0")]
			internal bool EOFHMBOLHJB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x25184C0", Offset = "0x25178C0", VA = "0x1825184C0")]
			internal bool OMCAPLDJGID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2515EB0", Offset = "0x25152B0", VA = "0x182515EB0")]
			internal bool FNFKJFBMNNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2515B00", Offset = "0x2514F00", VA = "0x182515B00")]
			internal bool FDICEDDHKJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2516B00", Offset = "0x2515F00", VA = "0x182516B00")]
			internal string JCLDFILGABP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2517330", Offset = "0x2516730", VA = "0x182517330")]
			internal void LBFIDGDFCED(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2518510", Offset = "0x2517910", VA = "0x182518510")]
			internal bool OMPGFEPOGIC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2516C60", Offset = "0x2516060", VA = "0x182516C60")]
			internal bool JLBBNNDOMOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2516870", Offset = "0x2515C70", VA = "0x182516870")]
			internal bool IFDFNOMKKIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x250DE80", Offset = "0x250D280", VA = "0x18250DE80")]
			internal bool ABPPODFJAOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x250EE20", Offset = "0x250E220", VA = "0x18250EE20")]
			internal string CPANNPCBBKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2517650", Offset = "0x2516A50", VA = "0x182517650")]
			internal void LODHLPIKPFK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x250E340", Offset = "0x250D740", VA = "0x18250E340")]
			internal bool AEMENFBAEHF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x250F210", Offset = "0x250E610", VA = "0x18250F210")]
			internal bool DIDPJNCLHID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x25171A0", Offset = "0x25165A0", VA = "0x1825171A0")]
			internal bool KLNAJIHDPMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x250ED60", Offset = "0x250E160", VA = "0x18250ED60")]
			internal bool CLLGLBFMFKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2518770", Offset = "0x2517B70", VA = "0x182518770")]
			internal string PJGNMANEEJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2516BA0", Offset = "0x2515FA0", VA = "0x182516BA0")]
			internal void JIFMKKLJEBG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x25182B0", Offset = "0x25176B0", VA = "0x1825182B0")]
			internal bool OCBOJJDIBML(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x250F000", Offset = "0x250E400", VA = "0x18250F000")]
			internal bool DEJGALFMGCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x25177C0", Offset = "0x2516BC0", VA = "0x1825177C0")]
			internal bool MALLOHHMINK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x25173A0", Offset = "0x25167A0", VA = "0x1825173A0")]
			internal bool LCNEJAGJHON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x250E530", Offset = "0x250D930", VA = "0x18250E530")]
			internal string AOHBPEJBEGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2515810", Offset = "0x2514C10", VA = "0x182515810")]
			internal void EOFLJMNLDBG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2516F50", Offset = "0x2516350", VA = "0x182516F50")]
			internal bool KDHJGEEEGOG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x250F110", Offset = "0x250E510", VA = "0x18250F110")]
			internal bool DFOLDKCOACL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2517040", Offset = "0x2516440", VA = "0x182517040")]
			internal bool KKMANMKAHNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2515A60", Offset = "0x2514E60", VA = "0x182515A60")]
			internal bool FCHNKPCOMGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x250E910", Offset = "0x250DD10", VA = "0x18250E910")]
			internal string BOPPENOILHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x250E960", Offset = "0x250DD60", VA = "0x18250E960")]
			internal void CAABIIAJMKF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2517D60", Offset = "0x2517160", VA = "0x182517D60")]
			internal bool NHHPMLIFGIO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x25179F0", Offset = "0x2516DF0", VA = "0x1825179F0")]
			internal bool MFBPGCOFOOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2515D10", Offset = "0x2515110", VA = "0x182515D10")]
			internal bool FLAGDNFHICD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2516520", Offset = "0x2515920", VA = "0x182516520")]
			internal bool HNMKPNHBHLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x250F4B0", Offset = "0x250E8B0", VA = "0x18250F4B0")]
			internal string EEAHOOAKNGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x250F050", Offset = "0x250E450", VA = "0x18250F050")]
			internal void DFENFCDMONC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2518160", Offset = "0x2517560", VA = "0x182518160")]
			internal bool NPFAIJDLDPF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x250E390", Offset = "0x250D790", VA = "0x18250E390")]
			internal bool AHCNDNMDKMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2517950", Offset = "0x2516D50", VA = "0x182517950")]
			internal bool MDPHPMGMCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x250E290", Offset = "0x250D690", VA = "0x18250E290")]
			internal bool ADGJDDEGFLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2518050", Offset = "0x2517450", VA = "0x182518050")]
			internal string NMOBHMFBGIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x25175E0", Offset = "0x25169E0", VA = "0x1825175E0")]
			internal void LGOLFIAFJOJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x2516C10", Offset = "0x2516010", VA = "0x182516C10")]
			internal bool JIFOALHGKFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2515F00", Offset = "0x2515300", VA = "0x182515F00")]
			internal bool GBAMPDELDMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2518830", Offset = "0x2517C30", VA = "0x182518830")]
			internal bool PLFPMINPDMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x25167D0", Offset = "0x2515BD0", VA = "0x1825167D0")]
			internal string IELPEPOKACI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2517EF0", Offset = "0x25172F0", VA = "0x182517EF0")]
			internal void NKIHDJABDNM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2516200", Offset = "0x2515600", VA = "0x182516200")]
			internal bool HANLPLNGEIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x25160A0", Offset = "0x25154A0", VA = "0x1825160A0")]
			internal bool GMGPAJFDNIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2517290", Offset = "0x2516690", VA = "0x182517290")]
			internal bool KOJJILMDAON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2518200", Offset = "0x2517600", VA = "0x182518200")]
			internal string OABICHGMEIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2515CA0", Offset = "0x25150A0", VA = "0x182515CA0")]
			internal void FIMDBEELPKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x250F500", Offset = "0x250E900", VA = "0x18250F500")]
			internal bool EFFKHLIDPML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x250E630", Offset = "0x250DA30", VA = "0x18250E630")]
			internal bool BCIKKIJKOEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x25161B0", Offset = "0x25155B0", VA = "0x1825161B0")]
			internal bool HADPGCEADMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x2515A10", Offset = "0x2514E10", VA = "0x182515A10")]
			internal string FCDBEHJIGJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x25186B0", Offset = "0x2517AB0", VA = "0x1825186B0")]
			internal void PGDDEKOOFOK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x25173F0", Offset = "0x25167F0", VA = "0x1825173F0")]
			internal bool LCPGDOCCGMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2516050", Offset = "0x2515450", VA = "0x182516050")]
			internal bool GJNKMACLBMJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x25171F0", Offset = "0x25165F0", VA = "0x1825171F0")]
			internal float KMCPLNOEGPB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x25160F0", Offset = "0x25154F0", VA = "0x1825160F0")]
			internal void GNLGICDFCIE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x250F370", Offset = "0x250E770", VA = "0x18250F370")]
			internal bool DLDDINPACAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2517440", Offset = "0x2516840", VA = "0x182517440")]
			internal bool LDGONIMNAAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x250ED10", Offset = "0x250E110", VA = "0x18250ED10")]
			internal bool CHPHGBJLPLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x2516E00", Offset = "0x2516200", VA = "0x182516E00")]
			internal int JPAJLHLDKPI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2516E50", Offset = "0x2516250", VA = "0x182516E50")]
			internal void JPDIINHGKFL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2517530", Offset = "0x2516930", VA = "0x182517530")]
			internal bool LFBNFCKNEOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2517770", Offset = "0x2516B70", VA = "0x182517770")]
			internal bool MAECLMOEADD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x2516340", Offset = "0x2515740", VA = "0x182516340")]
			internal bool HHLEKDBEBGE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class JGKDIJHBKEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public JCOMDDBKDAN CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public JGKDIJHBKEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2518EE0", Offset = "0x25182E0", VA = "0x182518EE0")]
			internal void NLHBIFPLFOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class FFJHFOJLNKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public FFJHFOJLNKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x25096A0", Offset = "0x2508AA0", VA = "0x1825096A0")]
			internal bool JBEPBPHNEEH(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly HEJCMKDLMJK AIHKIBCMCIN;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x250B4F0", Offset = "0x250A8F0", VA = "0x18250B4F0")]
		public FJEOLEMFKCG(ANALLCGONGO DFLGEEGCPMI, DHCDMFPPKPL HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2509720", Offset = "0x2508B20", VA = "0x182509720", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class FOLFMBNMOBE : KPJGEGMJNEL<OHDHMGBBLLN>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class LEDIEPMGOMB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public LEDIEPMGOMB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x253D580", Offset = "0x253C980", VA = "0x18253D580", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public FOLFMBNMOBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public LEDIEPMGOMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x251CF40", Offset = "0x251C340", VA = "0x18251CF40")]
			internal string MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x251CDE0", Offset = "0x251C1E0", VA = "0x18251CDE0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FHAIOPDBBKM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x251CF90", Offset = "0x251C390", VA = "0x18251CF90")]
			internal int MNPFLPCHHNE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x251CEB0", Offset = "0x251C2B0", VA = "0x18251CEB0")]
			internal void JFBADLEIDLK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECE1D0", VA = "0x180ECEDD0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x250BCB0", Offset = "0x250B0B0", VA = "0x18250BCB0")]
		public FOLFMBNMOBE(ANALLCGONGO DFLGEEGCPMI, OHDHMGBBLLN AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x250B960", Offset = "0x250AD60", VA = "0x18250B960", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class PGBDONLMNJD : KPJGEGMJNEL<HNPGMCGFDCI>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class KODAKCKHIPO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public KODAKCKHIPO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x253D240", Offset = "0x253C640", VA = "0x18253D240", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public KODAKCKHIPO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x253D890", Offset = "0x253CC90", VA = "0x18253D890", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public PGBDONLMNJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KODAKCKHIPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2537CD0", Offset = "0x25370D0", VA = "0x182537CD0")]
			internal string MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x25379A0", Offset = "0x2536DA0", VA = "0x1825379A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FHAIOPDBBKM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2537D20", Offset = "0x2537120", VA = "0x182537D20")]
			internal int MNPFLPCHHNE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2537A70", Offset = "0x2536E70", VA = "0x182537A70")]
			internal void JFBADLEIDLK(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2537730", Offset = "0x2536B30", VA = "0x182537730")]
			internal string CFFDGMAAICP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2537C00", Offset = "0x2537000", VA = "0x182537C00")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void MHLJJEBILLG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x25378C0", Offset = "0x2536CC0", VA = "0x1825378C0")]
			internal bool EOFCJLIFDNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2537910", Offset = "0x2536D10", VA = "0x182537910")]
			internal void FFNOGLAOMOO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2537870", Offset = "0x2536C70", VA = "0x182537870")]
			internal bool EHAKKILEBCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2537D70", Offset = "0x2537170", VA = "0x182537D70")]
			internal void PAFFPCEOHAP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2537820", Offset = "0x2536C20", VA = "0x182537820")]
			internal float DJEPEOCLBMP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2537B70", Offset = "0x2536F70", VA = "0x182537B70")]
			internal void MHGKDMAEKNL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2537E00", Offset = "0x2537200", VA = "0x182537E00")]
			internal int PAKGKIOGBCB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x2537780", Offset = "0x2536B80", VA = "0x182537780")]
			internal void DGCIBDNEBDB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x2537B00", Offset = "0x2536F00", VA = "0x182537B00")]
			internal bool LENJCKCPMFL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECE1D0", VA = "0x180ECEDD0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x253CCE0", Offset = "0x253C0E0", VA = "0x18253CCE0")]
		public PGBDONLMNJD(ANALLCGONGO DFLGEEGCPMI, HNPGMCGFDCI HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x253C290", Offset = "0x253B690", VA = "0x18253C290", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class KOFCMIMKMOB : KPJGEGMJNEL<BKNHCNOPJME>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class LMHGGKLGFMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public KOFCMIMKMOB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public LMHGGKLGFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x2538630", Offset = "0x2537A30", VA = "0x182538630")]
			internal Dictionary<string, OEKJFHFPCFG> MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2538560", Offset = "0x2537960", VA = "0x182538560")]
			internal int FHAIOPDBBKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x25386D0", Offset = "0x2537AD0", VA = "0x1825386D0")]
			internal void MNPFLPCHHNE(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x25385B0", Offset = "0x25379B0", VA = "0x1825385B0")]
			internal bool JFBADLEIDLK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECE1D0", VA = "0x180ECEDD0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x2538130", Offset = "0x2537530", VA = "0x182538130")]
		public KOFCMIMKMOB(ANALLCGONGO DFLGEEGCPMI, BKNHCNOPJME AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2537E60", Offset = "0x2537260", VA = "0x182537E60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class FJNFGBFAIJL : KPJGEGMJNEL<FFOLJPEKHGD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class EBDDKKNHFMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public FJNFGBFAIJL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public EBDDKKNHFMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x25280D0", Offset = "0x25274D0", VA = "0x1825280D0")]
			internal void MNLGAMGLBJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECE1D0", VA = "0x180ECEDD0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x252B090", Offset = "0x252A490", VA = "0x18252B090")]
		public FJNFGBFAIJL(ANALLCGONGO DFLGEEGCPMI, FFOLJPEKHGD AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x252AF10", Offset = "0x252A310", VA = "0x18252AF10", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class CDNJPDEENAH<TNode> : PAIFOJMLBIA<TNode> where TNode : notnull, GDPMKBBODID
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool BIMGKLHLGLC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override MAALIMGMDEF? IBIOLNAMFGP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x5A3A2A0", Offset = "0x5A396A0", VA = "0x185A3A2A0", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool OJGJGEDGDHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x5A3A310", Offset = "0x5A39710", VA = "0x185A3A310", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC11800", Offset = "0xC10C00", VA = "0x180C11800", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x52BC150", Offset = "0x52BB550", VA = "0x1852BC150")]
		public CDNJPDEENAH(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class KAFKBOJEFPO : CDNJPDEENAH<DBPIEFONOFG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class MKECEANOLAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public KAFKBOJEFPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public MKECEANOLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x2539450", Offset = "0x2538850", VA = "0x182539450")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x2539380", Offset = "0x2538780", VA = "0x182539380")]
			internal void FHAIOPDBBKM(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x25394C0", Offset = "0x25388C0", VA = "0x1825394C0")]
			internal void MNPFLPCHHNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? IMAMPLGCAMB;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2536B40", Offset = "0x2535F40", VA = "0x182536B40")]
		public KAFKBOJEFPO(ANALLCGONGO DFLGEEGCPMI, DBPIEFONOFG HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2536590", Offset = "0x2535990", VA = "0x182536590", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class IBIPMNBJDAD : KPJGEGMJNEL<GMIGJOPKPNA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xB415A0", Offset = "0xB409A0", VA = "0x180B415A0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2533470", Offset = "0x2532870", VA = "0x182533470")]
		public IBIPMNBJDAD(ANALLCGONGO DFLGEEGCPMI, GMIGJOPKPNA HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class HLDBMNEDGKG : KPJGEGMJNEL<GOHNFKCLOKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA608F0", Offset = "0xA5FCF0", VA = "0x180A608F0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2533040", Offset = "0x2532440", VA = "0x182533040")]
		public HLDBMNEDGKG(ANALLCGONGO DFLGEEGCPMI, GOHNFKCLOKG HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "124")]
		protected override bool ODGPFOGEFMK(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class GHLKJCMFBOO : KPJGEGMJNEL<ELKLOGKINHK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA4F470", Offset = "0xA4E870", VA = "0x180A4F470", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x2532510", Offset = "0x2531910", VA = "0x182532510", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x25324A0", Offset = "0x25318A0", VA = "0x1825324A0")]
		public GHLKJCMFBOO(ANALLCGONGO DFLGEEGCPMI, ELKLOGKINHK HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class OKPMDBMGAOL : KPJGEGMJNEL<MLALODAFHBC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x253AE00", Offset = "0x253A200", VA = "0x18253AE00", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected override bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x253AD90", Offset = "0x253A190", VA = "0x18253AD90")]
		public OKPMDBMGAOL(ANALLCGONGO DFLGEEGCPMI, MLALODAFHBC HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class EEOEACFDIJI : NMGOABEKKFO<FAHNLAPEDKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class OIGGBBDLNBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public EEOEACFDIJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public OIGGBBDLNBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x253A7C0", Offset = "0x2539BC0", VA = "0x18253A7C0")]
			internal float ANPGGHIJLED()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x253A840", Offset = "0x2539C40", VA = "0x18253A840")]
			internal void KACMPDEBBLL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x25291B0", Offset = "0x25285B0", VA = "0x1825291B0")]
		public EEOEACFDIJI(ANALLCGONGO DFLGEEGCPMI, FAHNLAPEDKJ AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2528F30", Offset = "0x2528330", VA = "0x182528F30", Slot = "138")]
		protected override void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class EBBMHOBOBNL : KPJGEGMJNEL<IMPCLAPCEAI>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class PJHCGFKDMAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public EBBMHOBOBNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public PJHCGFKDMAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x253CE80", Offset = "0x253C280", VA = "0x18253CE80")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x253CD50", Offset = "0x253C150", VA = "0x18253CD50")]
			internal void FHAIOPDBBKM(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2528060", Offset = "0x2527460", VA = "0x182528060")]
		public EBBMHOBOBNL(ANALLCGONGO DFLGEEGCPMI, IMPCLAPCEAI AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2527DB0", Offset = "0x25271B0", VA = "0x182527DB0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class MGDBNEMBMIF : KPJGEGMJNEL<NPBJKGIEAFL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class EKFFAKBFIMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public MGDBNEMBMIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public EKFFAKBFIMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2529730", Offset = "0x2528B30", VA = "0x182529730")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x25293B0", Offset = "0x25287B0", VA = "0x1825293B0")]
			internal bool FFNOGLAOMOO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2529430", Offset = "0x2528830", VA = "0x182529430")]
			internal void FHAIOPDBBKM(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2529860", Offset = "0x2528C60", VA = "0x182529860")]
			internal string MNPFLPCHHNE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2529690", Offset = "0x2528A90", VA = "0x182529690")]
			internal IReadOnlyList<object> JFBADLEIDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2529210", Offset = "0x2528610", VA = "0x182529210")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x25296E0", Offset = "0x2528AE0", VA = "0x1825296E0")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x2529280", Offset = "0x2528680", VA = "0x182529280")]
			internal void EOFCJLIFDNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x25390C0", Offset = "0x25384C0", VA = "0x1825390C0")]
		public MGDBNEMBMIF(ANALLCGONGO DFLGEEGCPMI, NPBJKGIEAFL AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x25388B0", Offset = "0x2537CB0", VA = "0x1825388B0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class OILHKHDPHPP : LGEECOLFGLO<EFJPFBOANKD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xC00000", Offset = "0xBFF400", VA = "0x180C00000", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x253A8E0", Offset = "0x2539CE0", VA = "0x18253A8E0")]
		public OILHKHDPHPP(ANALLCGONGO DFLGEEGCPMI, EFJPFBOANKD HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class BELNPEFMDNF : NMGOABEKKFO<KFIHFMLKPIM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class PDICMHIBBCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public BELNPEFMDNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public PDICMHIBBCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x253C170", Offset = "0x253B570", VA = "0x18253C170")]
			internal int ANPGGHIJLED()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x253C1F0", Offset = "0x253B5F0", VA = "0x18253C1F0")]
			internal void KACMPDEBBLL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2521DD0", Offset = "0x25211D0", VA = "0x182521DD0")]
		public BELNPEFMDNF(ANALLCGONGO DFLGEEGCPMI, KFIHFMLKPIM AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2521AD0", Offset = "0x2520ED0", VA = "0x182521AD0", Slot = "138")]
		protected override void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class MJMPNFAFJFA : KPJGEGMJNEL<BLJJMKGMGAH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class KFOPFGIDGAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public MJMPNFAFJFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KFOPFGIDGAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x25376E0", Offset = "0x2536AE0", VA = "0x1825376E0")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x2537650", Offset = "0x2536A50", VA = "0x182537650")]
			internal void FHAIOPDBBKM(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2539310", Offset = "0x2538710", VA = "0x182539310")]
		public MJMPNFAFJFA(ANALLCGONGO DFLGEEGCPMI, BLJJMKGMGAH AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2539130", Offset = "0x2538530", VA = "0x182539130", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class ICHJOAACOLH : KPJGEGMJNEL<FBGBCKOIOFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class NOGKCHDGMFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ICHJOAACOLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public NOGKCHDGMFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x2539F90", Offset = "0x2539390", VA = "0x182539F90")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x2539F00", Offset = "0x2539300", VA = "0x182539F00")]
			internal void FHAIOPDBBKM(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x25336C0", Offset = "0x2532AC0", VA = "0x1825336C0")]
		public ICHJOAACOLH(ANALLCGONGO DFLGEEGCPMI, FBGBCKOIOFJ AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x25334E0", Offset = "0x25328E0", VA = "0x1825334E0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class ONJFLOLOGBB : KPJGEGMJNEL<MKKLAFJCHLK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class GIMBLGOEJKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public ONJFLOLOGBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public GIMBLGOEJKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x25325F0", Offset = "0x25319F0", VA = "0x1825325F0")]
			internal int MNLGAMGLBJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2532560", Offset = "0x2531960", VA = "0x182532560")]
			internal void FHAIOPDBBKM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x253B1E0", Offset = "0x253A5E0", VA = "0x18253B1E0")]
		public ONJFLOLOGBB(ANALLCGONGO DFLGEEGCPMI, MKKLAFJCHLK AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x253AF70", Offset = "0x253A370", VA = "0x18253AF70", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class JNGKDEIEECG : OKEKOINPNCC<HGHIDGKPBDO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override FAIPOOJKNPF JOJILFEBLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x25360F0", Offset = "0x25354F0", VA = "0x1825360F0")]
		public JNGKDEIEECG(ANALLCGONGO DFLGEEGCPMI, HGHIDGKPBDO AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class HGJGMPLAIGN : KPJGEGMJNEL<ALJLKHOFDLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x252B100", Offset = "0x252A500", VA = "0x18252B100")]
		public HGJGMPLAIGN(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class KPJGEGMJNEL<TNode> : NBNILIEIFAK, IDisposable where TNode : notnull, ALJLKHOFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class OPAFBKCCMAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public KPJGEGMJNEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public ANALLCGONGO circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public OPAFBKCCMAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4FD4510", Offset = "0x4FD3910", VA = "0x184FD4510")]
			internal CLIMCMMFPBK BPFJHAFMIFK(LKBOPANOFBG portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct COKKOGLJDGK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public KPJGEGMJNEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x5C13470", Offset = "0x5C12870", VA = "0x185C13470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct MNCPPLBNLFM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public KPJGEGMJNEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public DGJDOPKLGLD? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public GEPCHMOMIFB? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x4DBD3D0", Offset = "0x4DBC7D0", VA = "0x184DBD3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x4DBD670", Offset = "0x4DBCA70", VA = "0x184DBD670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class DKDBHJNNPPO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000091")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				public DKDBHJNNPPO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x3CE24B0", Offset = "0x3CE18B0", VA = "0x183CE24B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public KPJGEGMJNEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public JNIHAMPHLFB configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public DKDBHJNNPPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			internal string CFDNAADKJFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			internal void GACLAEAFJCG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x62B56D0", Offset = "0x62B4AD0", VA = "0x1862B56D0")]
			[AsyncStateMachine(typeof(KPJGEGMJNEL<>.DKDBHJNNPPO.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void EKIEOHLCFMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class HAENLPOPGCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public HAENLPOPGCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x4590970", Offset = "0x458FD70", VA = "0x184590970")]
			internal bool FNLHPNKAODK(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4590A50", Offset = "0x458FE50", VA = "0x184590A50")]
			internal bool OOPHACDCGDB(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct MPBLPEKDLCI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public KPJGEGMJNEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4DDC7E0", Offset = "0x4DDBBE0", VA = "0x184DDC7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4DDCB70", Offset = "0x4DDBF70", VA = "0x184DDCB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly ANALLCGONGO IFNIGKPEJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool EIMHOPOAPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private JKLJLNHAMKI<FANPJMFIOIH, CLIMCMMFPBK> MLAMCPAMKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private JKLJLNHAMKI<FANPJMFIOIH, BCINBNEJLKM> CCMGKDGGANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> JDPMKPMPIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<AAFGLNNJOHN<FANPJMFIOIH>>? AAHJMBBBAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM>? AIPNJIHCAEA;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected CBKCDAKDLFJ CKPGHPIJDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x4ADDF20", Offset = "0x4ADD320", VA = "0x184ADDF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected JMEEEIBMDBN JKFAMCEKGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF040", Offset = "0x4ADE440", VA = "0x184ADF040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected TNode APHFGALDMDK
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public HMBFEKDDECL<LIPCHELCHBL> LGKPHIDDPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x11680F0", Offset = "0x11674F0", VA = "0x1811680F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HMBFEKDDECL<LIPCHELCHBL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public AAFGLNNJOHN<GDEODHDOKBB> FIEMOOADDIH
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0820", Offset = "0x4ADFC20", VA = "0x184AE0820", Slot = "6")]
			get
			{
				return default(AAFGLNNJOHN<GDEODHDOKBB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public object EJODNIKFKNF
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x4074450", Offset = "0x4073850", VA = "0x184074450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool CCGGJAPHJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int GKMLNPEPKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0480", Offset = "0x4ADF880", VA = "0x184AE0480", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public MCFINBPPNLI DPCIPBBMKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0420", Offset = "0x4ADF820", VA = "0x184AE0420", Slot = "10")]
			get
			{
				return default(MCFINBPPNLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string DGAKLLAFKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0A20", Offset = "0x4ADFE20", VA = "0x184AE0A20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AAFGLNNJOHN<KINEADPEALH> KLPGJHBFBLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xCED280", Offset = "0xCEC680", VA = "0x180CED280", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(AAFGLNNJOHN<KINEADPEALH>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xCEFDC0", Offset = "0xCEF1C0", VA = "0x180CEFDC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool BIMGKLHLGLC
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual BKPLPAFEPPD BODHKPCACPF
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xD9CFF0", Offset = "0xD9C3F0", VA = "0x180D9CFF0", Slot = "106")]
			get
			{
				return default(BKPLPAFEPPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool CBJHLOGFLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0190", Offset = "0x4ADF590", VA = "0x184AE0190", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool LDAMKENILBG
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4AE01F0", Offset = "0x4ADF5F0", VA = "0x184AE01F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AIDNDMBGMDN
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0250", Offset = "0x4ADF650", VA = "0x184AE0250", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int IPBGLIBLMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4AE07D0", Offset = "0x4ADFBD0", VA = "0x184AE07D0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool ICBANNHIHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0600", Offset = "0x4ADFA00", VA = "0x184AE0600", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool IEPMFMICDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0360", Offset = "0x4ADF760", VA = "0x184AE0360", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool HMILCBKCGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0300", Offset = "0x4ADF700", VA = "0x184AE0300", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool NBNOCAPGFFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xD6AAA0", Offset = "0xD69EA0", VA = "0x180D6AAA0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x1138640", Offset = "0x1137A40", VA = "0x181138640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool MKILAGBOONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool LMGDAKEKODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x4AE02B0", Offset = "0x4ADF6B0", VA = "0x184AE02B0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool CFOOFEAFJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0530", Offset = "0x4ADF930", VA = "0x184AE0530", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public DGJDOPKLGLD KOHIGCEHKOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0710", Offset = "0x4ADFB10", VA = "0x184AE0710", Slot = "28")]
			get
			{
				return default(DGJDOPKLGLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public GEPCHMOMIFB NDNJPIJMLJM
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0770", Offset = "0x4ADFB70", VA = "0x184AE0770", Slot = "30")]
			get
			{
				return default(GEPCHMOMIFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool AJGBCDHLADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual ALMLELKCNKA? CBDLHIKDKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual MAALIMGMDEF? IBIOLNAMFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>>? MLLAGLOBHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool MBFNJHFEDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x4AE03C0", Offset = "0x4ADF7C0", VA = "0x184AE03C0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public HMBFEKDDECL<IBLJEHJLOFH> JCIJECICIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0650", Offset = "0x4ADFA50", VA = "0x184AE0650", Slot = "62")]
			get
			{
				return default(HMBFEKDDECL<IBLJEHJLOFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AAFGLNNJOHN<IBLJEHJLOFH> JEDJBPCDOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4AE04D0", Offset = "0x4ADF8D0", VA = "0x184AE04D0", Slot = "56")]
			get
			{
				return default(AAFGLNNJOHN<IBLJEHJLOFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DIDJGIAICIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual AAFGLNNJOHN<IBLJEHJLOFH>? KCLMIPMJJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual bool OJGJGEDGDHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool NLIHJNLIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0590", Offset = "0x4ADF990", VA = "0x184AE0590", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x955550", Offset = "0x954950", VA = "0x180955550", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x9555C0", Offset = "0x9549C0", VA = "0x1809555C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string DIENLOIPIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x955640", Offset = "0x954A40", VA = "0x180955640", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9554E0", Offset = "0x9548E0", VA = "0x1809554E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public AAFGLNNJOHN<MOHGMBIPFPM> HLCGAADKCLI
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4AE08A0", Offset = "0x4ADFCA0", VA = "0x184AE08A0", Slot = "63")]
			get
			{
				return default(AAFGLNNJOHN<MOHGMBIPFPM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public HMBFEKDDECL<MOHGMBIPFPM> GJLMLEHEODI
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4AE06B0", Offset = "0x4ADFAB0", VA = "0x184AE06B0", Slot = "64")]
			get
			{
				return default(HMBFEKDDECL<MOHGMBIPFPM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public HMBFEKDDECL<MOHGMBIPFPM>? DALJNOLELOC
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4AE0900", Offset = "0x4ADFD00", VA = "0x184AE0900", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public GIBMKDJCJAI<FANPJMFIOIH, BCINBNEJLKM> GPPFNOCEPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4AE09E0", Offset = "0x4ADFDE0", VA = "0x184AE09E0", Slot = "67")]
			get
			{
				return default(GIBMKDJCJAI<FANPJMFIOIH, BCINBNEJLKM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual AAFGLNNJOHN<FANPJMFIOIH>? GGAOKAAECHE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool JDPIAKIDKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public virtual bool HNHBKABBAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "135")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LDBEPLFEKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4ADC040", Offset = "0x4ADB440", VA = "0x184ADC040", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4ADBEE0", Offset = "0x4ADB2E0", VA = "0x184ADBEE0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CLDJGCLAJOD BOMAGLCEIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4ADE500", Offset = "0x4ADD900", VA = "0x184ADE500", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x4ADBD30", Offset = "0x4ADB130", VA = "0x184ADBD30", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LPHMAADDAIN JOPLJGIECJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4ADFB20", Offset = "0x4ADEF20", VA = "0x184ADFB20", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4ADC9E0", Offset = "0x4ADBDE0", VA = "0x184ADC9E0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action HEAONIAFCPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF670", Offset = "0x4ADEA70", VA = "0x184ADF670", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4ADD0A0", Offset = "0x4ADC4A0", VA = "0x184ADD0A0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action ENAFBNEOKDE
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4ADDDC0", Offset = "0x4ADD1C0", VA = "0x184ADDDC0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4ADD1F0", Offset = "0x4ADC5F0", VA = "0x184ADD1F0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM> PNLPDEEAKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF570", Offset = "0x4ADE970", VA = "0x184ADF570", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF790", Offset = "0x4ADEB90", VA = "0x184ADF790", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM> GMHOGMKKLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF9A0", Offset = "0x4ADEDA0", VA = "0x184ADF9A0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF6D0", Offset = "0x4ADEAD0", VA = "0x184ADF6D0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>> IPNMIPAKEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4ADBF80", Offset = "0x4ADB380", VA = "0x184ADBF80", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4ADEDF0", Offset = "0x4ADE1F0", VA = "0x184ADEDF0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<FANPJMFIOIH>> NKHLJCEMOOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4ADDE60", Offset = "0x4ADD260", VA = "0x184ADDE60", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4ADFA60", Offset = "0x4ADEE60", VA = "0x184ADFA60", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM> ONHAKCLFAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4ADC0E0", Offset = "0x4ADB4E0", VA = "0x184ADC0E0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4ADD300", Offset = "0x4ADC700", VA = "0x184ADD300", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<FANPJMFIOIH>> BAJLKFJMKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4ADDF80", Offset = "0x4ADD380", VA = "0x184ADDF80", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF8A0", Offset = "0x4ADECA0", VA = "0x184ADF8A0", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4ADFBC0", Offset = "0x4ADEFC0", VA = "0x184ADFBC0")]
		[CGDEHPHFPEN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CGDEHPHFPEN("Need to handle `Name` better.")]
		protected KPJGEGMJNEL(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB, bool CAIFGFNEGNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD790", Offset = "0x4ADCB90", VA = "0x184ADD790", Slot = "99")]
		protected virtual void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCA80", Offset = "0x4ADBE80", VA = "0x184ADCA80", Slot = "100")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD140", Offset = "0x4ADC540", VA = "0x184ADD140", Slot = "9")]
		[AsyncStateMachine(typeof(KPJGEGMJNEL<>.COKKOGLJDGK))]
		public void FIKOICMAOKG(int JFJOJKJCICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x4ADBDD0", Offset = "0x4ADB1D0", VA = "0x184ADBDD0")]
		public bool AJGENMFNDCH([In] DGJDOPKLGLD KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE880", Offset = "0x4ADDC80", VA = "0x184ADE880")]
		public bool MAABBEGGFHN([In] GEPCHMOMIFB KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE670", Offset = "0x4ADDA70", VA = "0x184ADE670", Slot = "32")]
		public void LOPCFIAJOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4ADDA30", Offset = "0x4ADCE30", VA = "0x184ADDA30", Slot = "33")]
		[AsyncStateMachine(typeof(KPJGEGMJNEL<>.MNCPPLBNLFM))]
		public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> IAJLFJHJDHC(DGJDOPKLGLD? IJNCCGADGJC, GEPCHMOMIFB? BALNGIJIBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "109")]
		public virtual void OFEGAOGPOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "110")]
		public virtual void AILMGNDDGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "111")]
		public virtual void PIPKFMLNGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xD47C10", Offset = "0xD47010", VA = "0x180D47C10")]
		protected void NMPKEJKPKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD950E0", Offset = "0xD944E0", VA = "0x180D950E0")]
		protected void OFHMPFLOABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x4ADDB80", Offset = "0x4ADCF80", VA = "0x184ADDB80")]
		private void IANFANHNFKF([In] GEPCHMOMIFB MLMNPOCKAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB840", Offset = "0x4ADAC40", VA = "0x184ADB840", Slot = "112")]
		public virtual Task<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> AAGHMFMMFIK(string OMOOEGOLALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE5A0", Offset = "0x4ADD9A0", VA = "0x184ADE5A0", Slot = "113")]
		public virtual Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LIBHMPMMKHI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "114")]
		public virtual void NMECNBPNFEN(AAFGLNNJOHN<FANPJMFIOIH> CPPAAHHOJNH, AAFGLNNJOHN<FANPJMFIOIH> DMFBJLELBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE960", Offset = "0x4ADDD60", VA = "0x184ADE960", Slot = "115")]
		public virtual IEnumerable<GKPCJPMFCCN> MDJGDBMDLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4ADF130", Offset = "0x4ADE530", VA = "0x184ADF130", Slot = "116")]
		public JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD> NHLFBPGBJNM(string HNIOMJBGMOD)
		{
			return default(JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD3C0", Offset = "0x4ADC7C0", VA = "0x184ADD3C0", Slot = "47")]
		public bool GPGIDKANHKB([Out] Guid KDNCMGDENBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE0A0", Offset = "0x4ADD4A0", VA = "0x184ADE0A0")]
		public bool LEGFFKJKJGN([In] Guid JLMDJNDONMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "117")]
		public virtual void KLOHADBCHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "118")]
		public virtual void DIICKOAPKMI(bool ICHCKIDAGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "119")]
		public virtual LBBIDBBGKFK AJHJGKNFGDB([In] FJMMBAHKKNM HGELIBOAOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCEB0", Offset = "0x4ADC2B0", VA = "0x184ADCEB0")]
		protected void FAIIIGGKHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4ADF630", Offset = "0x4ADEA30", VA = "0x184ADF630", Slot = "124")]
		protected virtual bool ODGPFOGEFMK(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4ADCE80", Offset = "0x4ADC280", VA = "0x184ADCE80", Slot = "88")]
		public bool EICCLPLGGOL(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "125")]
		protected virtual bool LIPAHAGNIEN(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected virtual void FLDPOCMCIGG(JNIHAMPHLFB JALKMGCKDFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE9F0", Offset = "0x4ADDDF0", VA = "0x184ADE9F0")]
		protected void MDNPHNFNEFD(JNIHAMPHLFB BFJOGMMEGHN, Func<string> IOJNLMENKPG, Action<string> OMLJMBCNGAC, string HBAOACFBMEC, string LOKGAAAILHC, string FNOABHLCKFM, PDJPDNJJLNC ACABJGDJJDD, GNPJDLPPMAF LLEDIPFJHHP, Func<string, bool> AGNOGNOOPCP, string ABGFJFLGJOH, Func<string, bool> NHNLHGILMPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD510", Offset = "0x4ADC910", VA = "0x184ADD510")]
		protected void HFNHAMBINEG(JNIHAMPHLFB BFJOGMMEGHN, Func<string> IOJNLMENKPG, Action<string> OMLJMBCNGAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4ADDBA0", Offset = "0x4ADCFA0", VA = "0x184ADDBA0", Slot = "133")]
		protected virtual void IIJPAKENBLJ(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4ADF850", Offset = "0x4ADEC50", VA = "0x184ADF850", Slot = "82")]
		public void PAPEFNAGMAJ(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC760", Offset = "0x4ADBB60", VA = "0x184ADC760", Slot = "83")]
		public ODGDOIFMABH DFJMFHMOJHJ()
		{
			return default(ODGDOIFMABH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "136")]
		public virtual bool FGCCEDEMFKF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8400", Offset = "0x1CF7800", VA = "0x181CF8400")]
		private void GPKADDAKCID([In] DGJDOPKLGLD NDADPNJPMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4ADEEF0", Offset = "0x4ADE2F0", VA = "0x184ADEEF0")]
		private void NFBANKGOLEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4ADEEB0", Offset = "0x4ADE2B0", VA = "0x184ADEEB0", Slot = "89")]
		private void NEHICIIOGJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC1A0", Offset = "0x4ADB5A0", VA = "0x184ADC1A0", Slot = "91")]
		private void CNKACMOKACM(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xED1CA0", Offset = "0xED10A0", VA = "0x180ED1CA0", Slot = "93")]
		private void CFEGHPDNDNO(AAFGLNNJOHN<FANPJMFIOIH> KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE350", Offset = "0x4ADD750", VA = "0x184ADE350", Slot = "95")]
		private void LFMIGDDGPJL(AAFGLNNJOHN<FANPJMFIOIH> KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4ADF1C0", Offset = "0x4ADE5C0", VA = "0x184ADF1C0", Slot = "96")]
		private void NNEJEPAHLNP(AAFGLNNJOHN<FANPJMFIOIH> CPPAAHHOJNH, AAFGLNNJOHN<FANPJMFIOIH> DMFBJLELBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xED2720", Offset = "0xED1B20", VA = "0x180ED2720", Slot = "97")]
		private void EGNOCACJCOG(AAFGLNNJOHN<FANPJMFIOIH> CPPAAHHOJNH, AAFGLNNJOHN<FANPJMFIOIH> DMFBJLELBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE080", Offset = "0x4ADD480", VA = "0x184ADE080", Slot = "90")]
		private void KNGGJLOPPBC(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB910", Offset = "0x4ADAD10", VA = "0x184ADB910", Slot = "92")]
		private void ADHDAIBMHGM(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD290", Offset = "0x4ADC690", VA = "0x184ADD290", Slot = "94")]
		private void GBAHKHHHNFB(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC850", Offset = "0x4ADBC50", VA = "0x184ADC850", Slot = "137")]
		[AsyncStateMachine(typeof(KPJGEGMJNEL<>.MPBLPEKDLCI))]
		public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> DKEEDAFMGEN(string HNIOMJBGMOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE8F0", Offset = "0x4ADDCF0", VA = "0x184ADE8F0", Slot = "54")]
		private void MBOODFNKNPA(object CMEDKNHFJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC970", Offset = "0x4ADBD70", VA = "0x184ADC970", Slot = "55")]
		private void DNFMKHEDNKI(object CMEDKNHFJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4667A20", Offset = "0x4666E20", VA = "0x184667A20", Slot = "29")]
		private bool CJBEHPIPMIN([In] DGJDOPKLGLD KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE040", Offset = "0x4ADD440", VA = "0x184ADE040", Slot = "31")]
		private bool KIKLNONBJNJ([In] GEPCHMOMIFB KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4ADD100", Offset = "0x4ADC500", VA = "0x184ADD100", Slot = "48")]
		private bool FFDCAGPNEOP([In] Guid JLMDJNDONMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4ADF960", Offset = "0x4ADED60", VA = "0x184ADF960")]
		[CompilerGenerated]
		private string PDHMFIEBKJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4ADBE40", Offset = "0x4ADB240", VA = "0x184ADBE40")]
		[CompilerGenerated]
		private void BJBFKOCIHCC(string OMOOEGOLALI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class IEEEHADCGOP : LGEECOLFGLO<FMKGOELDDLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xC03780", Offset = "0xC02B80", VA = "0x180C03780", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2533730", Offset = "0x2532B30", VA = "0x182533730")]
		public IEEEHADCGOP(ANALLCGONGO DFLGEEGCPMI, FMKGOELDDLJ HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class HKLCLIBPGFP : PAIFOJMLBIA<EENMBDBPPKI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2532FE0", Offset = "0x25323E0", VA = "0x182532FE0")]
		public HKLCLIBPGFP(ANALLCGONGO DFLGEEGCPMI, EENMBDBPPKI HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class OKEKOINPNCC<T> : KPJGEGMJNEL<T> where T : notnull, OCOCEKBLHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class NEFCGEFKFKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, OEKJFHFPCFG>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public OKEKOINPNCC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public FAIPOOJKNPF clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public NEFCGEFKFKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			internal IReadOnlyList<KeyValuePair<string, OEKJFHFPCFG>> MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4E29820", Offset = "0x4E28C20", VA = "0x184E29820")]
			internal int FHAIOPDBBKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x4E29A90", Offset = "0x4E28E90", VA = "0x184E29A90")]
			internal void MNPFLPCHHNE(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x4E29980", Offset = "0x4E28D80", VA = "0x184E29980")]
			internal void JFBADLEIDLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4E29490", Offset = "0x4E28890", VA = "0x184E29490")]
			internal void CFFDGMAAICP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x4E29790", Offset = "0x4E28B90", VA = "0x184E29790")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x4E29740", Offset = "0x4E28B40", VA = "0x184E29740")]
			internal void EOFCJLIFDNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x4E29790", Offset = "0x4E28B90", VA = "0x184E29790")]
			internal bool FFNOGLAOMOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x4E296F0", Offset = "0x4E28AF0", VA = "0x184E296F0")]
			internal float EHAKKILEBCG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x4E29CB0", Offset = "0x4E290B0", VA = "0x184E29CB0")]
			internal void PAFFPCEOHAP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x4E296A0", Offset = "0x4E28AA0", VA = "0x184E296A0")]
			internal float DJEPEOCLBMP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x4E299D0", Offset = "0x4E28DD0", VA = "0x184E299D0")]
			internal void MHGKDMAEKNL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x4E29D70", Offset = "0x4E29170", VA = "0x184E29D70")]
			internal float PAKGKIOGBCB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x4E295E0", Offset = "0x4E289E0", VA = "0x184E295E0")]
			internal void DGCIBDNEBDB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECE1D0", VA = "0x180ECEDD0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public abstract FAIPOOJKNPF JOJILFEBLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(Slot = "138")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x4590110", Offset = "0x458F510", VA = "0x184590110")]
		public OKEKOINPNCC(ANALLCGONGO DFLGEEGCPMI, T HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4FBA630", Offset = "0x4FB9A30", VA = "0x184FBA630", Slot = "132")]
		protected sealed override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class EBDLEHBGJKF : KPJGEGMJNEL<KMIHDMGAHED>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xC05FC0", Offset = "0xC053C0", VA = "0x180C05FC0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x25281E0", Offset = "0x25275E0", VA = "0x1825281E0")]
		public EBDLEHBGJKF(ANALLCGONGO DFLGEEGCPMI, KMIHDMGAHED HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class OCDDCPHEMCL : KPJGEGMJNEL<KOFBPILCNAF>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class MMLOILEIPLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public OCDDCPHEMCL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public MMLOILEIPLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x25395B0", Offset = "0x25389B0", VA = "0x1825395B0")]
			internal int FHAIOPDBBKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x2539600", Offset = "0x2538A00", VA = "0x182539600")]
			internal void MNPFLPCHHNE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, OEKJFHFPCFG>? EBNAPPOLNLJ;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x253A370", Offset = "0x2539770", VA = "0x18253A370")]
		public OCDDCPHEMCL(ANALLCGONGO DFLGEEGCPMI, KOFBPILCNAF HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2539FE0", Offset = "0x25393E0", VA = "0x182539FE0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class PNPLEGDGHKJ : OKEKOINPNCC<KPOEDOGBFJE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override FAIPOOJKNPF JOJILFEBLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x253CED0", Offset = "0x253C2D0", VA = "0x18253CED0")]
		public PNPLEGDGHKJ(ANALLCGONGO DFLGEEGCPMI, KPOEDOGBFJE AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class JOKPKOONBGN : PAIFOJMLBIA<DLKONHINKGB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2536150", Offset = "0x2535550", VA = "0x182536150")]
		public JOKPKOONBGN(ANALLCGONGO DFLGEEGCPMI, DLKONHINKGB HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class ENEDLCKPCHF : PAIFOJMLBIA<GIENAPDKAGE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x25299D0", Offset = "0x2528DD0", VA = "0x1825299D0")]
		public ENEDLCKPCHF(ANALLCGONGO DFLGEEGCPMI, GIENAPDKAGE HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class AJOAIDPNPOH : NMGOABEKKFO<OFFOBCJBDPD>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class IIMDDCONOBG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				public IIMDDCONOBG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x253CF30", Offset = "0x253C330", VA = "0x18253CF30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AJOAIDPNPOH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public IIMDDCONOBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x25354F0", Offset = "0x25348F0", VA = "0x1825354F0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void ANPGGHIJLED(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2521A70", Offset = "0x2520E70", VA = "0x182521A70")]
		public AJOAIDPNPOH(ANALLCGONGO DFLGEEGCPMI, OFFOBCJBDPD AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2521790", Offset = "0x2520B90", VA = "0x182521790", Slot = "138")]
		protected override void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class CPGLIPMIHAE : OKEKOINPNCC<OGBKGLDEODI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override FAIPOOJKNPF JOJILFEBLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA4F470", Offset = "0xA4E870", VA = "0x180A4F470", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2527670", Offset = "0x2526A70", VA = "0x182527670")]
		public CPGLIPMIHAE(ANALLCGONGO DFLGEEGCPMI, OGBKGLDEODI AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class GFENDFNOGIE : KPJGEGMJNEL<MJONBFOJNIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xC089E0", Offset = "0xC07DE0", VA = "0x180C089E0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x252B170", Offset = "0x252A570", VA = "0x18252B170")]
		public GFENDFNOGIE(ANALLCGONGO DFLGEEGCPMI, MJONBFOJNIE HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class EABLHMGIGAN : KPJGEGMJNEL<OEPAFHBFCNF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public sealed override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public sealed override bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected sealed override bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2527D40", Offset = "0x2527140", VA = "0x182527D40")]
		public EABLHMGIGAN(ANALLCGONGO DFLGEEGCPMI, OEPAFHBFCNF HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2527A10", Offset = "0x2526E10", VA = "0x182527A10", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x25279D0", Offset = "0x2526DD0", VA = "0x1825279D0")]
		private int EEJDEDENCPJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2527CE0", Offset = "0x25270E0", VA = "0x182527CE0")]
		private void PMKOCHKLCLB(int JJFHAAOAACO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class GEKIGDEKJMO : HGJGMPLAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x252B100", Offset = "0x252A500", VA = "0x18252B100")]
		public GEKIGDEKJMO(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class FBPIHDGCJPG : NMGOABEKKFO<GGAINCJCLJO>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2529A30", Offset = "0x2528E30", VA = "0x182529A30")]
		public FBPIHDGCJPG(ANALLCGONGO DFLGEEGCPMI, GGAINCJCLJO HPEELAFENFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class NMGOABEKKFO<TVariableNode> : KPJGEGMJNEL<TVariableNode> where TVariableNode : notnull, GGAINCJCLJO
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class BBOFOLFPBFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public NMGOABEKKFO<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public BBOFOLFPBFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x5836620", Offset = "0x5835A20", VA = "0x185836620")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x58364A0", Offset = "0x58358A0", VA = "0x1858364A0")]
			internal void FHAIOPDBBKM(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x5836680", Offset = "0x5835A80", VA = "0x185836680")]
			internal bool MNPFLPCHHNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x5836560", Offset = "0x5835960", VA = "0x185836560")]
			internal void JFBADLEIDLK(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x58363F0", Offset = "0x58357F0", VA = "0x1858363F0")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class BCHEAGBLGAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public JMEEEIBMDBN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public NMGOABEKKFO<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public BCHEAGBLGAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x58379A0", Offset = "0x5836DA0", VA = "0x1858379A0")]
			internal void ANPGGHIJLED(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xA69700", Offset = "0xA68B00", VA = "0x180A69700", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override BKPLPAFEPPD BODHKPCACPF
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x4E89D70", Offset = "0x4E89170", VA = "0x184E89D70", Slot = "106")]
			get
			{
				return default(BKPLPAFEPPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E89BD0", Offset = "0x4E88FD0", VA = "0x184E89BD0")]
		protected NMGOABEKKFO(ANALLCGONGO DFLGEEGCPMI, TVariableNode HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E89140", Offset = "0x4E88540", VA = "0x184E89140", Slot = "100")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4E892C0", Offset = "0x4E886C0", VA = "0x184E892C0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4E89750", Offset = "0x4E88B50", VA = "0x184E89750", Slot = "138")]
		protected virtual void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4E89AE0", Offset = "0x4E88EE0", VA = "0x184E89AE0", Slot = "117")]
		public override void KLOHADBCHCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25071F0", Offset = "0x25065F0", VA = "0x1825071F0")]
	public static NBNILIEIFAK FEOBEKOIKMG(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class KFCLDBJIIHP : FJGNOIDBIMJ, FGCCEOJGPLJ, FPMPKFDBAJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public AAFGLNNJOHN<OECNLCLGMED> PDGCAIFIDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xC07FD0", Offset = "0xC073D0", VA = "0x180C07FD0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<OECNLCLGMED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AAFGLNNJOHN<LFNDACGNNFN> KCGCIJKNMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xCFBE70", Offset = "0xCFB270", VA = "0x180CFBE70", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<LFNDACGNNFN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2536FB0", Offset = "0x25363B0", VA = "0x182536FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private AAFGLNNJOHN<JEHMBJHBIMC> HLCBFEPFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xC08550", Offset = "0xC07950", VA = "0x180C08550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public override AAFGLNNJOHN<MBNEIPNGAFM> JNKHFFHLLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2537310", Offset = "0x2536710", VA = "0x182537310", Slot = "21")]
		get
		{
			return default(AAFGLNNJOHN<MBNEIPNGAFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2537360", Offset = "0x2536760", VA = "0x182537360")]
	private KFCLDBJIIHP(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, ICKNDFCPJHD IFBFIOLGMBJ, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP, AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, bool PFCNKPEGGGF, string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2536FC0", Offset = "0x25363C0", VA = "0x182536FC0")]
	public static KFCLDBJIIHP FEOBEKOIKMG(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, ICKNDFCPJHD IBAFMNIDEPH, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP, bool PFCNKPEGGGF, bool CAIFGFNEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2536FB0", Offset = "0x25363B0", VA = "0x182536FB0")]
	internal void EHFKHJNOJOG(AAFGLNNJOHN<LFNDACGNNFN> KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class FJGNOIDBIMJ : FPMPKFDBAJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct MCFANKJKAIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private CIAJDHIOEOD? EDCEJFFMPIF;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x25388A0", Offset = "0x2537CA0", VA = "0x1825388A0")]
		public void KKIOKOIHHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2538800", Offset = "0x2537C00", VA = "0x182538800")]
		public CIAJDHIOEOD APHFCECOKMI(FJGNOIDBIMJ OOFAOBHPCAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly ALJLKHOFDLJ KFIHMGKGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private MCFANKJKAIJ DGMMKKIJCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly KLDDEHGIEGN OLONBJHIBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<BOENHIKFFHK> FBKNNFBDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<NHLCFGEFNJK> NFGEPNIIKCG;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	[CGDEHPHFPEN("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> CMJMNGCNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2529DA0", Offset = "0x25291A0", VA = "0x182529DA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DisplayKind LIBCGPMMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x95A2B0", Offset = "0x9596B0", VA = "0x18095A2B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public AAFGLNNJOHN<IBLJEHJLOFH> JEDJBPCDOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2529D70", Offset = "0x2529170", VA = "0x182529D70", Slot = "6")]
		get
		{
			return default(AAFGLNNJOHN<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HMBFEKDDECL<IBLJEHJLOFH> JCIJECICIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x252AB30", Offset = "0x2529F30", VA = "0x18252AB30", Slot = "7")]
		get
		{
			return default(HMBFEKDDECL<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public NNEBJMMJLKO FELCFIGBMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xBE1890", Offset = "0xBE0C90", VA = "0x180BE1890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public FBIOAFHMNPO GLFIAJFPPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2529F50", Offset = "0x2529350", VA = "0x182529F50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	protected CIAJDHIOEOD PHGCADFGEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2529F50", Offset = "0x2529350", VA = "0x182529F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PortImage OCNMCINAMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2529AF0", Offset = "0x2528EF0", VA = "0x182529AF0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x94FB20", Offset = "0x94EF20", VA = "0x18094FB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public HMBFEKDDECL<MOHGMBIPFPM> GJLMLEHEODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x252AB60", Offset = "0x2529F60", VA = "0x18252AB60", Slot = "9")]
		get
		{
			return default(HMBFEKDDECL<MOHGMBIPFPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AAFGLNNJOHN<FANPJMFIOIH> FNMGHCHEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xBC3BD0", Offset = "0xBC2FD0", VA = "0x180BC3BD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<FANPJMFIOIH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xCFB1D0", Offset = "0xCFA5D0", VA = "0x180CFB1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract AAFGLNNJOHN<MBNEIPNGAFM> JNKHFFHLLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x252ADB0", Offset = "0x252A1B0", VA = "0x18252ADB0")]
	protected FJGNOIDBIMJ(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, KLDDEHGIEGN GMEMHACONIH, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, bool PFCNKPEGGGF, string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x252A390", Offset = "0x2529790", VA = "0x18252A390", Slot = "22")]
	protected virtual void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2529C20", Offset = "0x2529020", VA = "0x182529C20", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2529D10", Offset = "0x2529110", VA = "0x182529D10", Slot = "14")]
	public void EADEPODEBJK(BOENHIKFFHK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x252AD50", Offset = "0x252A150", VA = "0x18252AD50", Slot = "15")]
	public void PEICFAJOAPF(NHLCFGEFNJK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x252A480", Offset = "0x2529880", VA = "0x18252A480", Slot = "16")]
	public void LNJAABKJLHF(LHFOHFDEOKM IMBHIBDELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x252A330", Offset = "0x2529730", VA = "0x18252A330", Slot = "24")]
	protected virtual void HKJFIOLGBII(LHFOHFDEOKM IMBHIBDELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2529FF0", Offset = "0x25293F0", VA = "0x182529FF0", Slot = "19")]
	private void HEDAKCJOKDJ(bool MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x252A180", Offset = "0x2529580", VA = "0x18252A180")]
	private void HJFGHLMJKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x252ABA0", Offset = "0x2529FA0", VA = "0x18252ABA0")]
	private void ODAEEJPHMII([In] GEEFDFPIKIO JHKLDKAMILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2529EF0", Offset = "0x25292F0", VA = "0x182529EF0", Slot = "17")]
	public void HAFBDCBCODO(BOENHIKFFHK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2529A90", Offset = "0x2528E90", VA = "0x182529A90", Slot = "18")]
	public void BFNKOLEDLLB(NHLCFGEFNJK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x94FB20", Offset = "0x94EF20", VA = "0x18094FB20")]
	internal void HJPEOOBKOIJ(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x252AB80", Offset = "0x2529F80", VA = "0x18252AB80")]
	internal void MPANIHEEDCN(BGKDLLEIHBK GKFDJGEMKAB, NNEBJMMJLKO BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xCFB1D0", Offset = "0xCFA5D0", VA = "0x180CFB1D0")]
	internal void ALJHLCPHMNA(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class CLIMCMMFPBK : BCINBNEJLKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class OLEBOEFDBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public ANALLCGONGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public ALJLKHOFDLJ node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OLEBOEFDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x253AEE0", Offset = "0x253A2E0", VA = "0x18253AEE0")]
		internal KDPBGGCOFDK NFHFJBEPDMN((int PortDescIndex, int PortIndex, JBHKBKNGGIE InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x253AE50", Offset = "0x253A250", VA = "0x18253AE50")]
		internal KFCLDBJIIHP LNLGDCIKMLB(ICKNDFCPJHD i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct JGMKGKHJKFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2535960", Offset = "0x2534D60", VA = "0x182535960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2535DD0", Offset = "0x25351D0", VA = "0x182535DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct NDPFOCMHIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public AAFGLNNJOHN<GLPBIEDACAD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2539B40", Offset = "0x2538F40", VA = "0x182539B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2539E90", Offset = "0x2539290", VA = "0x182539E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct HMBKBFPAGCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AAFGLNNJOHN<JEHMBJHBIMC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x25330B0", Offset = "0x25324B0", VA = "0x1825330B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2533400", Offset = "0x2532800", VA = "0x182533400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct BJLLGBCOIIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AAFGLNNJOHN<GLPBIEDACAD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AAFGLNNJOHN<GLPBIEDACAD> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2521E30", Offset = "0x2521230", VA = "0x182521E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2522190", Offset = "0x2521590", VA = "0x182522190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct ACOCDOIGBLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AAFGLNNJOHN<JEHMBJHBIMC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public AAFGLNNJOHN<JEHMBJHBIMC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2521020", Offset = "0x2520420", VA = "0x182521020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2521380", Offset = "0x2520780", VA = "0x182521380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct HEDFIBMFPLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2532AF0", Offset = "0x2531EF0", VA = "0x182532AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2532F70", Offset = "0x2532370", VA = "0x182532F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct LGEGEOHIJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x25381A0", Offset = "0x25375A0", VA = "0x1825381A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x25384F0", Offset = "0x25378F0", VA = "0x1825384F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct OFFEHJJNGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AAFGLNNJOHN<GLPBIEDACAD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x253A3E0", Offset = "0x25397E0", VA = "0x18253A3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x253A750", Offset = "0x2539B50", VA = "0x18253A750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct JOPKLPEJGHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public AAFGLNNJOHN<JEHMBJHBIMC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x25361B0", Offset = "0x25355B0", VA = "0x1825361B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2536520", Offset = "0x2535920", VA = "0x182536520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct KENLDLCIMPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public NADGPPCKHDL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AAFGLNNJOHN<GLPBIEDACAD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2536BA0", Offset = "0x2535FA0", VA = "0x182536BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2536F40", Offset = "0x2536340", VA = "0x182536F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HDECDLMOBFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public CLIMCMMFPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public NADGPPCKHDL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AAFGLNNJOHN<JEHMBJHBIMC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private IMJBELIIDML <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x25326E0", Offset = "0x2531AE0", VA = "0x1825326E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2532A80", Offset = "0x2531E80", VA = "0x182532A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool FLBFCJPGEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool GOMKMIKMGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private GIBMKDJCJAI<EAGGAAMICCD, KDPBGGCOFDK> JPNJDDPMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP> FKMKGKENAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly ALJLKHOFDLJ KFIHMGKGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private GIBMKDJCJAI<LFNDACGNNFN, KFCLDBJIIHP> CFELNNFMEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ> MKDMJFHEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? EFMPFHGBFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly LKBOPANOFBG HDHPCDNBDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private AAFGLNNJOHN<FANPJMFIOIH> COOIFPLNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool EIMHOPOAPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? PAOAOHMEKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? FLKDIEJGMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<AAFGLNNJOHN<EAGGAAMICCD>>? DGKJAHHOIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<AAFGLNNJOHN<LFNDACGNNFN>>? FLKCDBLHHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private BCINBNEJLKM.FMCEGGEAAPD? CJCJFJDKJID;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool FBNPJIDGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2527330", Offset = "0x2526730", VA = "0x182527330", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool MIGNCOEGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2525E40", Offset = "0x2525240", VA = "0x182525E40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool JDAHFBBNIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2526ED0", Offset = "0x25262D0", VA = "0x182526ED0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HMBFEKDDECL<IBLJEHJLOFH> JCIJECICIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x25268C0", Offset = "0x2525CC0", VA = "0x1825268C0", Slot = "7")]
		get
		{
			return default(HMBFEKDDECL<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool KEMLEBKEDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2525960", Offset = "0x2524D60", VA = "0x182525960", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP> FHGGHNBKBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0", Slot = "9")]
		get
		{
			return default(GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x25269B0", Offset = "0x2525DB0", VA = "0x1825269B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HMBFEKDDECL<MOHGMBIPFPM> GJLMLEHEODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2526B50", Offset = "0x2525F50", VA = "0x182526B50", Slot = "11")]
		get
		{
			return default(HMBFEKDDECL<MOHGMBIPFPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ> AGONGCDEPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0", Slot = "12")]
		get
		{
			return default(GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AAFGLNNJOHN<FANPJMFIOIH> FNMGHCHEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA60780", Offset = "0xA5FB80", VA = "0x180A60780", Slot = "13")]
		get
		{
			return default(AAFGLNNJOHN<FANPJMFIOIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? MMFCEFMNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2527180", Offset = "0x2526580", VA = "0x182527180", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2522EA0", Offset = "0x25222A0", VA = "0x182522EA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? HEGMKKPFPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2526AA0", Offset = "0x2525EA0", VA = "0x182526AA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x25257F0", Offset = "0x2524BF0", VA = "0x1825257F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, AAFGLNNJOHN<EAGGAAMICCD?>>? IOLIPONLDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x25258A0", Offset = "0x2524CA0", VA = "0x1825258A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x25268F0", Offset = "0x2525CF0", VA = "0x1825268F0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, AAFGLNNJOHN<EAGGAAMICCD?>>? AJIBMCHPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x25273F0", Offset = "0x25267F0", VA = "0x1825273F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2526CF0", Offset = "0x25260F0", VA = "0x182526CF0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, AAFGLNNJOHN<LFNDACGNNFN?>>? GBIBFKDCNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2526510", Offset = "0x2525910", VA = "0x182526510", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2525D80", Offset = "0x2525180", VA = "0x182525D80", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, AAFGLNNJOHN<LFNDACGNNFN?>>? MGDFMPGONKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x25274B0", Offset = "0x25268B0", VA = "0x1825274B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2525EA0", Offset = "0x25252A0", VA = "0x182525EA0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, CDCNPBIAEIP?>? GKHEAMNCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2522A20", Offset = "0x2521E20", VA = "0x182522A20", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2526450", Offset = "0x2525850", VA = "0x182526450", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>>? ENLNBOOHMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2526800", Offset = "0x2525C00", VA = "0x182526800", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2523620", Offset = "0x2522A20", VA = "0x182523620", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, CDCNPBIAEIP?>? JGFFOIOHCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x25254B0", Offset = "0x25248B0", VA = "0x1825254B0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2524860", Offset = "0x2523C60", VA = "0x182524860", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, FGCCEOJGPLJ?>? BJIIAEBGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x25269E0", Offset = "0x2525DE0", VA = "0x1825269E0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x25253F0", Offset = "0x25247F0", VA = "0x1825253F0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>>? LFIJIDHFOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2526F90", Offset = "0x2526390", VA = "0x182526F90", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2526C30", Offset = "0x2526030", VA = "0x182526C30", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, FGCCEOJGPLJ?>? CMECECNKGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2526B70", Offset = "0x2525F70", VA = "0x182526B70", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2522CF0", Offset = "0x25220F0", VA = "0x182522CF0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2527570", Offset = "0x2526970", VA = "0x182527570")]
	private CLIMCMMFPBK(bool PFCNKPEGGGF, ANALLCGONGO DFLGEEGCPMI, bool AMGMPBDAHBA, GIBMKDJCJAI<EAGGAAMICCD, KDPBGGCOFDK> NLHKPNGOOIF, GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP> NHADFFHGNEP, ALJLKHOFDLJ HPEELAFENFB, GIBMKDJCJAI<LFNDACGNNFN, KFCLDBJIIHP> HLLOODEPJFO, GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ> JNMPMBBENKB, string? JONJJHKHLOE, LKBOPANOFBG CGDHKNOCJLM, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, bool CAIFGFNEGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x25241E0", Offset = "0x25235E0", VA = "0x1825241E0")]
	public static CLIMCMMFPBK FEOBEKOIKMG(bool PFCNKPEGGGF, ANALLCGONGO DFLGEEGCPMI, bool AMGMPBDAHBA, ALJLKHOFDLJ HPEELAFENFB, LKBOPANOFBG CGDHKNOCJLM, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, bool CAIFGFNEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x25236E0", Offset = "0x2522AE0", VA = "0x1825236E0", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2524920", Offset = "0x2523D20", VA = "0x182524920", Slot = "38")]
	[AsyncStateMachine(typeof(JGMKGKHJKFH))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? GDLCENFPJEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x25265D0", Offset = "0x25259D0", VA = "0x1825265D0")]
	private (MFCFENGOEMN?, int)? LNOCEBMPPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2522DB0", Offset = "0x25221B0", VA = "0x182522DB0", Slot = "58")]
	private void BJCPLDDHLNG(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1D18210", Offset = "0x1D17610", VA = "0x181D18210", Slot = "57")]
	private void FGCMGAEIIMJ(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2525F80", Offset = "0x2525380", VA = "0x182525F80", Slot = "61")]
	private void LDKMCGFKBBI(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x25235C0", Offset = "0x25229C0", VA = "0x1825235C0", Slot = "63")]
	private void CPIFGILJLFJ(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2522F40", Offset = "0x2522340", VA = "0x182522F40", Slot = "50")]
	private void CHECPPGFEOI(int DPDJNHDNCGL, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2525E80", Offset = "0x2525280", VA = "0x182525E80", Slot = "54")]
	private void KHGJFHOEHFK(int MEBAFDHEDIN, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2524010", Offset = "0x2523410", VA = "0x182524010", Slot = "49")]
	private void EGLEOIICCOO(int MEBAFDHEDIN, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2524A10", Offset = "0x2523E10", VA = "0x182524A10", Slot = "53")]
	private void GMEFAIBBDLJ(int DPDJNHDNCGL, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2525570", Offset = "0x2524970", VA = "0x182525570", Slot = "66")]
	private void IBBAKJMAPOM(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1108CD0", Offset = "0x11080D0", VA = "0x181108CD0", Slot = "65")]
	private void NFMFINKEPHE(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2522AE0", Offset = "0x2521EE0", VA = "0x182522AE0", Slot = "60")]
	private void BCKLGJHLKKI(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1D18210", Offset = "0x1D17610", VA = "0x181D18210", Slot = "59")]
	private void PGJNCNPIPLJ(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x25259E0", Offset = "0x2524DE0", VA = "0x1825259E0", Slot = "62")]
	private void JCLHPPAOAMP(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2524160", Offset = "0x2523560", VA = "0x182524160", Slot = "64")]
	private void FAHFKEIBKLH(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2524E60", Offset = "0x2524260", VA = "0x182524E60", Slot = "52")]
	private void GOKEAJKOBLF(int DPDJNHDNCGL, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x25241C0", Offset = "0x25235C0", VA = "0x1825241C0", Slot = "56")]
	private void FBJFJNHFMDE(int MEBAFDHEDIN, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2525F60", Offset = "0x2525360", VA = "0x182525F60", Slot = "51")]
	private void LBLIIBMEPFN(int MEBAFDHEDIN, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2523BA0", Offset = "0x2522FA0", VA = "0x182523BA0", Slot = "55")]
	private void EEBOHNGOHIL(int DPDJNHDNCGL, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x25228D0", Offset = "0x2521CD0", VA = "0x1825228D0", Slot = "68")]
	private void AOHEJPLNDFK(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1108CD0", Offset = "0x11080D0", VA = "0x181108CD0", Slot = "67")]
	private void NPJAJMJANGK(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2524750", Offset = "0x2523B50", VA = "0x182524750", Slot = "39")]
	[AsyncStateMachine(typeof(NDPFOCMHIED))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? FLMNPHNEJKP(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2527220", Offset = "0x2526620", VA = "0x182527220", Slot = "40")]
	[AsyncStateMachine(typeof(HMBKBFPAGCP))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? OGJHDIGNLFB(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2526DB0", Offset = "0x25261B0", VA = "0x182526DB0", Slot = "41")]
	[AsyncStateMachine(typeof(BJLLGBCOIIH))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? NGFDKNJCALF(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, AAFGLNNJOHN<GLPBIEDACAD> OPMFOHFDNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2522BD0", Offset = "0x2521FD0", VA = "0x182522BD0", Slot = "42")]
	[AsyncStateMachine(typeof(ACOCDOIGBLA))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? BDLKBOOGFPP(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, AAFGLNNJOHN<JEHMBJHBIMC> OPMFOHFDNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x25234D0", Offset = "0x25228D0", VA = "0x1825234D0", Slot = "43")]
	[AsyncStateMachine(typeof(HEDFIBMFPLH))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? CMJBLLMJIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2523A80", Offset = "0x2522E80", VA = "0x182523A80", Slot = "44")]
	[AsyncStateMachine(typeof(LGEGEOHIJLB))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> ECNBNJAOBGO(string HNIOMJBGMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x25256C0", Offset = "0x2524AC0", VA = "0x1825256C0", Slot = "45")]
	[AsyncStateMachine(typeof(OFFEHJJNGPF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> ICKDHBBCLFN(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, string OMOOEGOLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2524030", Offset = "0x2523430", VA = "0x182524030", Slot = "46")]
	[AsyncStateMachine(typeof(JOPKLPEJGHF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> EIEKIAEHEKJ(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, string OMOOEGOLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2527050", Offset = "0x2526450", VA = "0x182527050", Slot = "47")]
	[AsyncStateMachine(typeof(KENLDLCIMPK))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> OBIMBKLDPMH(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, NADGPPCKHDL BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2526320", Offset = "0x2525720", VA = "0x182526320", Slot = "48")]
	[AsyncStateMachine(typeof(HDECDLMOBFN))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LEOFDBMEKDO(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, NADGPPCKHDL BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2522510", Offset = "0x2521910", VA = "0x182522510")]
	internal void ALJHLCPHMNA(AAFGLNNJOHN<FANPJMFIOIH> KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class AIIOGMFDPOA : FGAGELOHMIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface OLMPEGJBIHN
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct LBAADKPPCFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<HMBFEKDDECL<IBLJEHJLOFH>, Guid>? MPKPJGDGGED;

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
			public LBAADKPPCFG(IReadOnlyDictionary<HMBFEKDDECL<IBLJEHJLOFH>, Guid>? MPKPJGDGGED)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		BGKDLLEIHBK DPBDGODOPAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OELEFOKLIPK> EIJDFFDELAO(CancellationToken LAEIHJHNGEK);

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HFDFODLNHEC> DKMIOFJKAAA(CancellationToken LAEIHJHNGEK);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<IPICNJAGLAJ> OGCHJHOOGKK(CancellationToken LAEIHJHNGEK);

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<LBAADKPPCFG> FFFKEFBJGIE(CancellationToken LAEIHJHNGEK);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<KACEGKBGPCC> KAIDGEOLIHO(CancellationToken LAEIHJHNGEK);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct PCEANGNMGGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<AIIOGMFDPOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public ANALLCGONGO circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public OELEFOKLIPK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public HFDFODLNHEC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private OLMPEGJBIHN <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private OELEFOKLIPK <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private OELEFOKLIPK <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private KACEGKBGPCC <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private HFDFODLNHEC <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private IPICNJAGLAJ <playerSaveData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<OELEFOKLIPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private OELEFOKLIPK <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<KACEGKBGPCC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<HFDFODLNHEC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<IPICNJAGLAJ> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<OLMPEGJBIHN.LBAADKPPCFG> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<NAPFONIDFOF> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x253B250", Offset = "0x253A650", VA = "0x18253B250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x253C100", Offset = "0x253B500", VA = "0x18253C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly NAPFONIDFOF HHOMIDCFHNE;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public NAPFONIDFOF KJMECFJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	private AIIOGMFDPOA(NAPFONIDFOF AALMIJNHLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2521620", Offset = "0x2520A20", VA = "0x182521620")]
	[AsyncStateMachine(typeof(PCEANGNMGGO))]
	public static Task<AIIOGMFDPOA> PIEBIBJICAE(ANALLCGONGO DFLGEEGCPMI, OELEFOKLIPK? MIMFFPFKBEA, HFDFODLNHEC? LBDLMMONJCN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2521600", Offset = "0x2520A00", VA = "0x182521600", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct IINEAIHFAEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct DKAPLAJLOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public IINEAIHFAEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public GKPCJPMFCCN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x25276D0", Offset = "0x2526AD0", VA = "0x1825276D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2527960", Offset = "0x2526D60", VA = "0x182527960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct OJCBMHEKNAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<bool, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public DJKKMHFELNP rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public OELEFOKLIPK circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public HFDFODLNHEC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public IINEAIHFAEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private GKPCJPMFCCN[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x253A940", Offset = "0x2539D40", VA = "0x18253A940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x253AD20", Offset = "0x253A120", VA = "0x18253AD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct JKJOBDIMEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public IINEAIHFAEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2535E40", Offset = "0x2535240", VA = "0x182535E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2536080", Offset = "0x2535480", VA = "0x182536080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private readonly NHECKHEMBJH HIOOFICJKMA;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	public IINEAIHFAEH(NHECKHEMBJH MKMHAKPJKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x25355C0", Offset = "0x25349C0", VA = "0x1825355C0")]
	[AsyncStateMachine(typeof(DKAPLAJLOPH))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> AICDCFGMFHH(GKPCJPMFCCN PJDAFKMDDCG, bool LELKEOHAIGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x25357E0", Offset = "0x2534BE0", VA = "0x1825357E0")]
	[AsyncStateMachine(typeof(OJCBMHEKNAO))]
	public Task<JOFBNNGKBOO<bool, PPAGHPBHFJD?>>? MHLPFKNCMPJ(int AAMJFOFMHFE, DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x25356F0", Offset = "0x2534AF0", VA = "0x1825356F0")]
	[AsyncStateMachine(typeof(JKJOBDIMEAF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> MHAKNCNBNPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class AEHFFPDLMCJ : IIPMLPJOFAH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly EBNJEDCLKBE KCIPEDMFEOH;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public EBNJEDCLKBE INKDKBOEFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	private AEHFFPDLMCJ(EBNJEDCLKBE DHNAOKJIGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2521410", Offset = "0x2520810", VA = "0x182521410")]
	public static AEHFFPDLMCJ GFOCOOKFNLL(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x25213F0", Offset = "0x25207F0", VA = "0x1825213F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface HLOLLCBMKHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	NAPFONIDFOF KJMECFJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	MIBHJHEHAJB LPAFAHPPKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	EDICMIIAGJB IAFJMKPEANG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	GHGILLKJOFN CKPGHPIJDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface HNDIPKGBMMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	HLOLLCBMKHJ? EMBEKCDACDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool JDEAJEAMBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<HLOLLCBMKHJ?>? ACGMJKHEDAO();

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IJJPGHFDAMO(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[JFFCMMKHJLF("IStaticCV2Instance")]
public interface FGAGELOHMIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	NAPFONIDFOF KJMECFJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[JFFCMMKHJLF("IStaticEVInstance")]
public interface IIPMLPJOFAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	EBNJEDCLKBE INKDKBOEFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class NCMKBOAEKCE
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2539690", Offset = "0x2538A90", VA = "0x182539690")]
	public static HMHNOMGHDBI<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> CMLOBOAPJLK([In] this HMHNOMGHDBI<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> POIHHIPDGMM)
	{
		return default(HMHNOMGHDBI<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class IKAOBOCJFBC : GNIGFNFNOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JDEAJEAMBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2535940", Offset = "0x2534D40", VA = "0x182535940", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	internal IKAOBOCJFBC(ANALLCGONGO DFLGEEGCPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class GMPNDNPPCAN : PCBMEDABEPH
{
	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2532640", Offset = "0x2531A40", VA = "0x182532640", Slot = "4")]
	public AOBOCLPFDHH? KAEKCPMEMMB(string? AEDDPJHJGBN, string? AFOBJDILGGP, string? IBJIEKIJIFJ, ENMPEBIDCHO.DKEGNGFDPPC.DPKMJELBHKO AEDCOFHFHLF, bool HJECKNFLPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public GMPNDNPPCAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class EBKJNLBDILK : KFBJGPELJDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct CLAPCJKHEKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<CBKCDAKDLFJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EBKJNLBDILK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<HLOLLCBMKHJ?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x2522200", Offset = "0x2521600", VA = "0x182522200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x25224A0", Offset = "0x25218A0", VA = "0x1825224A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CBKCDAKDLFJ? IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2528A50", Offset = "0x2527E50", VA = "0x182528A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GHGILLKJOFN? ENPAKKPHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2528B30", Offset = "0x2527F30", VA = "0x182528B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool GLBEGEGCABB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x25289F0", Offset = "0x2527DF0", VA = "0x1825289F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool CLNALJABGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2528AD0", Offset = "0x2527ED0", VA = "0x182528AD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2528D40", Offset = "0x2528140", VA = "0x182528D40")]
	internal EBKJNLBDILK(ANALLCGONGO DFLGEEGCPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x2528250", Offset = "0x2527650", VA = "0x182528250", Slot = "7")]
	[AsyncStateMachine(typeof(CLAPCJKHEKG))]
	public Task<CBKCDAKDLFJ> ALGCLFNNKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2528680", Offset = "0x2527A80", VA = "0x182528680", Slot = "9")]
	public IReadOnlyDictionary<HMBFEKDDECL<IBLJEHJLOFH>, Guid> FJNMKGLKJAG(IEnumerable<PGEJPEMIJFO> BIKKNAJKJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2528BB0", Offset = "0x2527FB0", VA = "0x182528BB0", Slot = "10")]
	public HLHFOEDMKGI OFABHOIEDGE(IEnumerable<PGEJPEMIJFO> BIKKNAJKJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2528340", Offset = "0x2527740", VA = "0x182528340")]
	public JOFBNNGKBOO<EDCAHLAPEPD, EAPODONBJNH> ENLIMJLBEIO([In] EDCAHLAPEPD MKNANILKFNH)
	{
		return default(JOFBNNGKBOO<EDCAHLAPEPD, EAPODONBJNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x25284E0", Offset = "0x25278E0", VA = "0x1825284E0", Slot = "8")]
	private JOFBNNGKBOO<EDCAHLAPEPD, EAPODONBJNH> FCEJNBNAEJJ([In] EDCAHLAPEPD MKNANILKFNH)
	{
		return default(JOFBNNGKBOO<EDCAHLAPEPD, EAPODONBJNH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class GHGILLKJOFN : CBKCDAKDLFJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class IGGOHGGOLEH
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class ALMGGNDBNMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public NAPFONIDFOF state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public PKHNPALDKBJ spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public ALMGGNDBNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x253F020", Offset = "0x253E420", VA = "0x18253F020")]
			internal bool CPNMECNBKJH(BMEMLKEGJDK n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class MMBLFFFBILM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public MMBLFFFBILM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x25433C0", Offset = "0x25427C0", VA = "0x1825433C0")]
			internal void AFFCGAGEAMO(BMEMLKEGJDK n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2534BB0", Offset = "0x2533FB0", VA = "0x182534BB0")]
		public static JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC> IKIFLPOJPIB(GHGILLKJOFN JDCFMPOHCEA, [In] CBKCDAKDLFJ.DMDNDIMIHGD JIEBKPCGKFF)
		{
			return default(JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2533D40", Offset = "0x2533140", VA = "0x182533D40")]
		internal static JOFBNNGKBOO<(MHEDMHEDCEP, CGIFKBGLAGM), KFNJBCGDAAC> EAEJBALEIPH(GHGILLKJOFN JDCFMPOHCEA, CGIFKBGLAGM DOJPCCJJBEP, bool HBBFJHPDMOA, [In] HMBFEKDDECL<IBLJEHJLOFH> CODLLOBEPJE, [In] int? HNAFDCGBLCO, [In] ODGDOIFMABH? NGEJGCMHAPD, [In] ODGDOIFMABH? PJKGADMGHNI)
		{
			return default(JOFBNNGKBOO<(MHEDMHEDCEP, CGIFKBGLAGM), KFNJBCGDAAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2533790", Offset = "0x2532B90", VA = "0x182533790")]
		private static void ACAOADICCJJ(bool HBBFJHPDMOA, PGEJPEMIJFO JOHGLFIKFAB, MHEDMHEDCEP FBPALFHGIKN, [In] HMBFEKDDECL<IBLJEHJLOFH> CODLLOBEPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x25350F0", Offset = "0x25344F0", VA = "0x1825350F0")]
		public static void NJJAPFCMACD(PFGLFMIDBPK FPIDBKEMNOJ, [In] CBKCDAKDLFJ.NIOGBKGKACM BIPCBLCLEIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2533C20", Offset = "0x2533020", VA = "0x182533C20")]
		[CompilerGenerated]
		internal static bool CDFGBNNDGEB(NAPFONIDFOF PGNNFCOHAOH, PKHNPALDKBJ HOJDFFFLNKN, BMEMLKEGJDK EPOFBJFECFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2533D10", Offset = "0x2533110", VA = "0x182533D10")]
		[CompilerGenerated]
		internal static bool CEMPECMBMEN(BMEMLKEGJDK NAKBEFGIDDJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct CCJHCJLFJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AAFGLNNJOHN<IBLJEHJLOFH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AAFGLNNJOHN<MOHGMBIPFPM> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public DGJDOPKLGLD offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x253F5C0", Offset = "0x253E9C0", VA = "0x18253F5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x253F810", Offset = "0x253EC10", VA = "0x18253F810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct KLLKGOFJOKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AAFGLNNJOHN<IBLJEHJLOFH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public HMBFEKDDECL<MOHGMBIPFPM> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public List<AAFGLNNJOHN<MOHGMBIPFPM>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public DGJDOPKLGLD localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public GEPCHMOMIFB localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public DGJDOPKLGLD offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2542650", Offset = "0x2541A50", VA = "0x182542650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2542910", Offset = "0x2541D10", VA = "0x182542910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct ELHPNMEFBHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AAFGLNNJOHN<IBLJEHJLOFH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public HMBFEKDDECL<MOHGMBIPFPM> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public List<AAFGLNNJOHN<MOHGMBIPFPM>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x25417E0", Offset = "0x2540BE0", VA = "0x1825417E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2541A20", Offset = "0x2540E20", VA = "0x182541A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct LIIHHHONNKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AAFGLNNJOHN<IBLJEHJLOFH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public HMBFEKDDECL<MOHGMBIPFPM> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AAFGLNNJOHN<IBLJEHJLOFH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public List<AAFGLNNJOHN<MOHGMBIPFPM>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2542980", Offset = "0x2541D80", VA = "0x182542980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2542BC0", Offset = "0x2541FC0", VA = "0x182542BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct PGLCIIGGDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public HMBFEKDDECL<IBLJEHJLOFH> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public HMBFEKDDECL<MOHGMBIPFPM> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2544080", Offset = "0x2543480", VA = "0x182544080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x25446C0", Offset = "0x2543AC0", VA = "0x1825446C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct ACBPHNNOJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AAFGLNNJOHN<IBLJEHJLOFH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AAFGLNNJOHN<OECNLCLGMED> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AAFGLNNJOHN<KPIEMJMGBJJ> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x253E5B0", Offset = "0x253D9B0", VA = "0x18253E5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x253EC00", Offset = "0x253E000", VA = "0x18253EC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct ACLJLBDJDME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public HMBFEKDDECL<MOHGMBIPFPM> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public HMBFEKDDECL<IBLJEHJLOFH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AAFGLNNJOHN<FANPJMFIOIH> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AAFGLNNJOHN<EAGGAAMICCD> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x253EC70", Offset = "0x253E070", VA = "0x18253EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x253EFB0", Offset = "0x253E3B0", VA = "0x18253EFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct ENEGJLDJOPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public HMBFEKDDECL<MOHGMBIPFPM> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public HMBFEKDDECL<IBLJEHJLOFH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public AAFGLNNJOHN<FANPJMFIOIH> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AAFGLNNJOHN<LFNDACGNNFN> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2541A90", Offset = "0x2540E90", VA = "0x182541A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2541DD0", Offset = "0x25411D0", VA = "0x182541DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct CAGKGBMMGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public GHGILLKJOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x253F330", Offset = "0x253E730", VA = "0x18253F330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x253F550", Offset = "0x253E950", VA = "0x18253F550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private readonly ANALLCGONGO IFNIGKPEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private readonly FGAGELOHMIE MIEFHMKNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly IIPMLPJOFAH IEBFOMGJIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly HEJCMKDLMJK AIHKIBCMCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly EBKJNLBDILK LMNDNGPCAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private Dictionary<HMBFEKDDECL<MOHGMBIPFPM>, NBNILIEIFAK> MPINBMJOIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[CompilerGenerated]
	private Action<HMBFEKDDECL<MOHGMBIPFPM>>? HEAONIAFCPK;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public HMBFEKDDECL<IBLJEHJLOFH> DNPFLKOAPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x252B1E0", Offset = "0x252A5E0", VA = "0x18252B1E0", Slot = "4")]
		get
		{
			return default(HMBFEKDDECL<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HEJCMKDLMJK HMNAPPILJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2504220", Offset = "0x2503620", VA = "0x182504220", Slot = "5")]
		get
		{
			return default(HEJCMKDLMJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2531F80", Offset = "0x2531380", VA = "0x182531F80")]
	public GHGILLKJOFN(ANALLCGONGO DFLGEEGCPMI, FGAGELOHMIE LPHHLKJDLIO, IIPMLPJOFAH GEACFDKHKOC, EBKJNLBDILK MIOKKEMFKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2531E10", Offset = "0x2531210", VA = "0x182531E10", Slot = "65")]
	public AAFGLNNJOHN<PBJODNNKGBJ> PLABMCMEFBI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AAFGLNNJOHN<PBJODNNKGBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x252D430", Offset = "0x252C830", VA = "0x18252D430", Slot = "66")]
	public AAFGLNNJOHN<ILELENOJNKM> FDOGEDLAKII(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AAFGLNNJOHN<ILELENOJNKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x252CBC0", Offset = "0x252BFC0", VA = "0x18252CBC0", Slot = "6")]
	public (bool, bool) ECBBELLFNDB(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2530000", Offset = "0x252F400", VA = "0x182530000")]
	public bool LGFHBIFMEIM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x252D980", Offset = "0x252CD80", VA = "0x18252D980", Slot = "8")]
	public bool GKDJOMEEEMJ(CDCNPBIAEIP GLHBFHFFMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x252DA00", Offset = "0x252CE00", VA = "0x18252DA00", Slot = "9")]
	public bool HANAIALAMBO(FGCCEOJGPLJ FLFFBFGJHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x252E580", Offset = "0x252D980", VA = "0x18252E580", Slot = "10")]
	public EBLIMHGMFBB? IGGGEFDAKEC(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x252D7C0", Offset = "0x252CBC0", VA = "0x18252D7C0", Slot = "11")]
	public PFOKEHFDPAJ? GBMDCNHHNOJ(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x252F480", Offset = "0x252E880", VA = "0x18252F480", Slot = "12")]
	public AAFGLNNJOHN<OECNLCLGMED>? KAMNMOMCNFO(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<LFNDACGNNFN> JLLMELNAAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x252DE40", Offset = "0x252D240", VA = "0x18252DE40", Slot = "13")]
	public AAFGLNNJOHN<KPIEMJMGBJJ>? HOHAKAJMONM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<EAGGAAMICCD> HAONHOPHKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x252D880", Offset = "0x252CC80", VA = "0x18252D880", Slot = "14")]
	public IEnumerable<AAFGLNNJOHN<IBLJEHJLOFH>> GENEHMKFKCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x252DF60", Offset = "0x252D360", VA = "0x18252DF60", Slot = "15")]
	public IEnumerable<AAFGLNNJOHN<DBJJLNDECIK>> HPDIEBMAPIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2530540", Offset = "0x252F940", VA = "0x182530540", Slot = "16")]
	public string LLGEBGEPMEM(AAFGLNNJOHN<DBJJLNDECIK> OPBDNNBOBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x25319A0", Offset = "0x2530DA0", VA = "0x1825319A0", Slot = "17")]
	public string ONOLOEINFFP(AAFGLNNJOHN<DBJJLNDECIK> OPBDNNBOBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x252E090", Offset = "0x252D490", VA = "0x18252E090")]
	public NBNILIEIFAK? IEKAJAOOLDL([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x252BA60", Offset = "0x252AE60", VA = "0x18252BA60", Slot = "23")]
	public AAFGLNNJOHN<GDEODHDOKBB> BNFCFFFLFCA(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(AAFGLNNJOHN<GDEODHDOKBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x252BAE0", Offset = "0x252AEE0", VA = "0x18252BAE0")]
	public AAFGLNNJOHN<MOHGMBIPFPM> FLOGGOFCJKB(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] HMBFEKDDECL<MOHGMBIPFPM> PFCMOGNDPJN)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x252E010", Offset = "0x252D410", VA = "0x18252E010", Slot = "33")]
	public AAFGLNNJOHN<MOHGMBIPFPM> IAAHONLOLLK(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x252FDD0", Offset = "0x252F1D0", VA = "0x18252FDD0", Slot = "34")]
	public AAFGLNNJOHN<MOHGMBIPFPM> KPJJLDGNGAI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x252D740", Offset = "0x252CB40", VA = "0x18252D740")]
	public AAFGLNNJOHN<MOHGMBIPFPM>? GBAFJGOKMKO(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] HMBFEKDDECL<MOHGMBIPFPM> PFCMOGNDPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x252C640", Offset = "0x252BA40", VA = "0x18252C640", Slot = "25")]
	public DAGDBEHPBOA? CHKJMPFJNEN(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x252DDE0", Offset = "0x252D1E0", VA = "0x18252DDE0", Slot = "26")]
	public long HILMLELNPLM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x252F080", Offset = "0x252E480", VA = "0x18252F080")]
	private void JJOGMOEKHOM(HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x252D2E0", Offset = "0x252C6E0", VA = "0x18252D2E0", Slot = "31")]
	public IEnumerable<(AAFGLNNJOHN<IBLJEHJLOFH>, AAFGLNNJOHN<MOHGMBIPFPM>)> EJLNACNHDHM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x252DED0", Offset = "0x252D2D0", VA = "0x18252DED0", Slot = "32")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> HOHAKAJMONM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<PBJODNNKGBJ> HAONHOPHKAF)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x252F3F0", Offset = "0x252E7F0", VA = "0x18252F3F0", Slot = "35")]
	public AAFGLNNJOHN<OECNLCLGMED> KAMNMOMCNFO(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<ILELENOJNKM> JLLMELNAAHA)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x252DD30", Offset = "0x252D130", VA = "0x18252DD30")]
	private NBNILIEIFAK? HHLBFEILNLE([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x252B4C0", Offset = "0x252A8C0", VA = "0x18252B4C0")]
	public ALJLKHOFDLJ? AHIJJKIAALG([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x252FDA0", Offset = "0x252F1A0", VA = "0x18252FDA0")]
	public GOKGCFFOMBC? KMLKFKHEBDG([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2530330", Offset = "0x252F730", VA = "0x182530330", Slot = "27")]
	public IEnumerable<NPEOPECJINL> LKKKNPCKOBG(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x252EEC0", Offset = "0x252E2C0", VA = "0x18252EEC0", Slot = "28")]
	public bool JEPMPNCPKHN(AAFGLNNJOHN<DBJJLNDECIK> OPBDNNBOBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x252B240", Offset = "0x252A640", VA = "0x18252B240", Slot = "29")]
	public IEnumerable<OLNKAEDKNJN> AGPOKBMKNOI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x252FB20", Offset = "0x252EF20", VA = "0x18252FB20", Slot = "30")]
	public IEnumerable<OLNKAEDKNJN> KJFMAEEAACJ(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x252B8F0", Offset = "0x252ACF0", VA = "0x18252B8F0")]
	public AAFGLNNJOHN<IBLJEHJLOFH> BABAGDLOKFH([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(AAFGLNNJOHN<IBLJEHJLOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x252B6C0", Offset = "0x252AAC0", VA = "0x18252B6C0")]
	public AAFGLNNJOHN<IBLJEHJLOFH>? GBNLGMEMBFH([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x252EF50", Offset = "0x252E350", VA = "0x18252EF50")]
	private PKHNPALDKBJ? JJBHMHEJPHO([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x252FDA0", Offset = "0x252F1A0", VA = "0x18252FDA0")]
	private GOKGCFFOMBC? MNPBLEODLOD([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x252B740", Offset = "0x252AB40", VA = "0x18252B740", Slot = "21")]
	public AAFGLNNJOHN<IBLJEHJLOFH>? AKPHDJNOJOE(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x252D3C0", Offset = "0x252C7C0", VA = "0x18252D3C0", Slot = "39")]
	public HMBFEKDDECL<IBLJEHJLOFH> FBEEPOPOKBM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(HMBFEKDDECL<IBLJEHJLOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x252BB60", Offset = "0x252AF60", VA = "0x18252BB60", Slot = "36")]
	public IEnumerable<NADGPPCKHDL> CAJJEDGFINP(JBEJALNFNNM MBFPNEOFNAB, bool KCNBABHGEFF, bool IIIJNHDCCID, bool NOJAPOAPMBG, bool EDMKGIOPGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2531AA0", Offset = "0x2530EA0", VA = "0x182531AA0", Slot = "37")]
	public NADGPPCKHDL PBFPEFHBPMA(JBEJALNFNNM MBFPNEOFNAB, FPMPKFDBAJK OMFJOIDAOAF, bool KCNBABHGEFF, bool IIIJNHDCCID, bool NOJAPOAPMBG, bool EDMKGIOPGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x252B550", Offset = "0x252A950", VA = "0x18252B550")]
	public NPEOPECJINL LMKMLBEIMJL(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(NPEOPECJINL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x252C990", Offset = "0x252BD90", VA = "0x18252C990", Slot = "40")]
	public OLNKAEDKNJN DOMHOHHMECI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return default(OLNKAEDKNJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x252DA80", Offset = "0x252CE80", VA = "0x18252DA80", Slot = "41")]
	[AsyncStateMachine(typeof(CCJHCJLFJGD))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> HGKNAKAMJKJ(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, AAFGLNNJOHN<MOHGMBIPFPM> KOHCBOMIKFA, DGJDOPKLGLD FDJGEFDKBBO, bool LHOBMLIMOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x25305B0", Offset = "0x252F9B0", VA = "0x1825305B0", Slot = "42")]
	[AsyncStateMachine(typeof(KLLKGOFJOKO))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LLGEOKHJHIH(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, List<AAFGLNNJOHN<MOHGMBIPFPM>> GNFNEFOKFHF, DGJDOPKLGLD NAAPAKKFPOM, GEPCHMOMIFB EBMNAHJKBDM, DGJDOPKLGLD FDJGEFDKBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x25303F0", Offset = "0x252F7F0", VA = "0x1825303F0", Slot = "45")]
	[AsyncStateMachine(typeof(ELHPNMEFBHF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LLEKNBPGFND(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, List<AAFGLNNJOHN<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2531610", Offset = "0x2530A10", VA = "0x182531610", Slot = "46")]
	[AsyncStateMachine(typeof(LIIHHHONNKK))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> NKKLPGPIMAL(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, List<AAFGLNNJOHN<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x252F9B0", Offset = "0x252EDB0", VA = "0x18252F9B0", Slot = "43")]
	public (IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)>, IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)>) KJCPDICAAHL(HMBFEKDDECL<IBLJEHJLOFH> CJEDJDOCNCA, AAFGLNNJOHN<MOHGMBIPFPM> KOHCBOMIKFA)
	{
		return default((IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)>, IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x252FE50", Offset = "0x252F250", VA = "0x18252FE50", Slot = "44")]
	[AsyncStateMachine(typeof(PGLCIIGGDBB))]
	public Task LCGCMBIGINH(HMBFEKDDECL<IBLJEHJLOFH> CJEDJDOCNCA, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> BAMNJIOFLEE, IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)> FAABHMALLCL, IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)> BEKOPDLICIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x252C7F0", Offset = "0x252BBF0", VA = "0x18252C7F0", Slot = "47")]
	public bool CJDKOBBKLNM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x252C770", Offset = "0x252BB70", VA = "0x18252C770", Slot = "48")]
	public bool CHNDGNHFKJI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x252B970", Offset = "0x252AD70", VA = "0x18252B970", Slot = "49")]
	public bool BBLENKCLFPB(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x252D390", Offset = "0x252C790", VA = "0x18252D390")]
	public JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC> IOPEHHEJHHJ([In] CBKCDAKDLFJ.DMDNDIMIHGD JIEBKPCGKFF)
	{
		return default(JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x252C860", Offset = "0x252BC60", VA = "0x18252C860", Slot = "51")]
	[AsyncStateMachine(typeof(ACBPHNNOJFP))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> CJJNNDMOJBP(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2531250", Offset = "0x2530650", VA = "0x182531250", Slot = "52")]
	public JOFBNNGKBOO<GDCECNBKGDJ, EAPODONBJNH> MDKFLNEHBCA(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, GDCECNBKGDJ BAHCLAPPIIA, GEPCHMOMIFB OKPBCMCCLNH)
	{
		return default(JOFBNNGKBOO<GDCECNBKGDJ, EAPODONBJNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x252F290", Offset = "0x252E690", VA = "0x18252F290", Slot = "53")]
	[AsyncStateMachine(typeof(ACLJLBDJDME))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> KACAHPBDHGG(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> FGHFBEDHADD, AAFGLNNJOHN<FANPJMFIOIH> KGANNGMMHBO, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x252DBD0", Offset = "0x252CFD0", VA = "0x18252DBD0", Slot = "54")]
	[AsyncStateMachine(typeof(ENEGJLDJOPC))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> HHDFFEKBKGO(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> LMENEPJPOKA, AAFGLNNJOHN<FANPJMFIOIH> HCAFJHOJGAL, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x252D0D0", Offset = "0x252C4D0", VA = "0x18252D0D0", Slot = "55")]
	public NNBMBEDJBPD EFIJKHODPGG()
	{
		return default(NNBMBEDJBPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x252F170", Offset = "0x252E570", VA = "0x18252F170", Slot = "56")]
	public NNBMBEDJBPD JPDILCEPHGK()
	{
		return default(NNBMBEDJBPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x25317D0", Offset = "0x2530BD0", VA = "0x1825317D0", Slot = "58")]
	public IHAOFOGJBHP OALBAAMCJLH(LHMJOHFKNMN IBPBICKJEGO, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IEnumerable<HMBFEKDDECL<IBLJEHJLOFH>> OMDJCPDNFEN, IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return default(IHAOFOGJBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x252ED10", Offset = "0x252E110", VA = "0x18252ED10")]
	private IHAOFOGJBHP ILAHOGAKONC(LHMJOHFKNMN IBPBICKJEGO, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IEnumerable<HMBFEKDDECL<IBLJEHJLOFH>> OMDJCPDNFEN, IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return default(IHAOFOGJBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x252D4B0", Offset = "0x252C8B0", VA = "0x18252D4B0", Slot = "57")]
	public IHAOFOGJBHP FMFGPANNIMK(LHMJOHFKNMN IBPBICKJEGO, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> GNFNEFOKFHF, IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD)
	{
		return default(IHAOFOGJBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x252E200", Offset = "0x252D600", VA = "0x18252E200")]
	private static IEnumerable<HMBFEKDDECL<IBLJEHJLOFH>> IFFEBFLAFDL(IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x252F510", Offset = "0x252E910", VA = "0x18252F510")]
	private IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> KEDCCPFLPKI(IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2531A10", Offset = "0x2530E10", VA = "0x182531A10", Slot = "59")]
	public List<CJHHNHLLHIJ> OPJNPGGHPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x252E640", Offset = "0x252DA40", VA = "0x18252E640")]
	public (List<CJHHNHLLHIJ>, bool) IIJCEPKOJGK([In] GIOBPIGMMED DPHAJJFDCDC, string BPPCEJGCMKA, [In] EDNEPNABDLO EFPEOIMBIIL, LCLLAFFONKF JFBOEMOFKMH, AEAHJHOGBME MBCEHNPFDKI)
	{
		return default((List<CJHHNHLLHIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2531E90", Offset = "0x2531290", VA = "0x182531E90", Slot = "61")]
	public bool PLODDDKODCN(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x252FFA0", Offset = "0x252F3A0", VA = "0x18252FFA0")]
	internal void LDCFEJBPJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2531770", Offset = "0x2530B70", VA = "0x182531770")]
	internal Task OACKPFOKJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x252BC70", Offset = "0x252B070", VA = "0x18252BC70", Slot = "62")]
	public JOFBNNGKBOO<AAFGLNNJOHN<OECNLCLGMED>?, PPAGHPBHFJD> CFOEOBGJBCI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(JOFBNNGKBOO<AAFGLNNJOHN<OECNLCLGMED>?, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2530730", Offset = "0x252FB30", VA = "0x182530730", Slot = "63")]
	public JOFBNNGKBOO<AAFGLNNJOHN<KPIEMJMGBJJ>?, PPAGHPBHFJD> LOGJIDGLFKD(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(JOFBNNGKBOO<AAFGLNNJOHN<KPIEMJMGBJJ>?, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x252D1F0", Offset = "0x252C5F0", VA = "0x18252D1F0", Slot = "64")]
	[AsyncStateMachine(typeof(CAGKGBMMGOP))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> EGCHKPDMPJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x252BC60", Offset = "0x252B060", VA = "0x18252BC60", Slot = "7")]
	private bool CFFALMGACJE(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x252FDA0", Offset = "0x252F1A0", VA = "0x18252FDA0", Slot = "18")]
	private GOKGCFFOMBC MGMMAANJBKA([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x252D0C0", Offset = "0x252C4C0", VA = "0x18252D0C0", Slot = "19")]
	private AAFGLNNJOHN<IBLJEHJLOFH> EEEGJECPNNF([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(AAFGLNNJOHN<IBLJEHJLOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x252B6C0", Offset = "0x252AAC0", VA = "0x18252B6C0", Slot = "20")]
	private AAFGLNNJOHN<IBLJEHJLOFH>? AIKHBIIFCJF([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2531100", Offset = "0x2530500", VA = "0x182531100", Slot = "22")]
	private NBNILIEIFAK MCIOOJAAPKD([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x252BAE0", Offset = "0x252AEE0", VA = "0x18252BAE0", Slot = "24")]
	private AAFGLNNJOHN<MOHGMBIPFPM> BNJGGONHCOJ(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] HMBFEKDDECL<MOHGMBIPFPM> PFCMOGNDPJN)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x252B550", Offset = "0x252A950", VA = "0x18252B550", Slot = "38")]
	private NPEOPECJINL AHNIHHBHHLI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(NPEOPECJINL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x252D390", Offset = "0x252C790", VA = "0x18252D390", Slot = "50")]
	private JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC> FAILHJPKMDC([In] CBKCDAKDLFJ.DMDNDIMIHGD JIEBKPCGKFF)
	{
		return default(JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x252F110", Offset = "0x252E510", VA = "0x18252F110", Slot = "60")]
	private (List<CJHHNHLLHIJ>, bool) JLGBIPGOKEL([In] GIOBPIGMMED DPHAJJFDCDC, string BPPCEJGCMKA, [In] EDNEPNABDLO EFPEOIMBIIL, LCLLAFFONKF JFBOEMOFKMH, AEAHJHOGBME MBCEHNPFDKI)
	{
		return default((List<CJHHNHLLHIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x252B870", Offset = "0x252AC70", VA = "0x18252B870")]
	[CompilerGenerated]
	private OOCBNANOENM AOIGDOICHOO(NNEBJMMJLKO BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x252D910", Offset = "0x252CD10", VA = "0x18252D910")]
	[CompilerGenerated]
	private ALJLKHOFDLJ GJHPIBACBHC(HMBFEKDDECL<MOHGMBIPFPM> BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x252F010", Offset = "0x252E410", VA = "0x18252F010")]
	[CompilerGenerated]
	private PKHNPALDKBJ JJLELHPMHOH(HMBFEKDDECL<IBLJEHJLOFH> BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2531DA0", Offset = "0x25311A0", VA = "0x182531DA0")]
	[CompilerGenerated]
	private ALJLKHOFDLJ PGGGBJGILPJ(HMBFEKDDECL<MOHGMBIPFPM> BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x252B9F0", Offset = "0x252ADF0", VA = "0x18252B9F0")]
	[CompilerGenerated]
	private PKHNPALDKBJ BKGGILLCOKF(HMBFEKDDECL<IBLJEHJLOFH> BKHEBBAMMAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class OOCBNANOENM : NADGPPCKHDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct KIHKHMHBALD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<AAFGLNNJOHN<GLPBIEDACAD>, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public OOCBNANOENM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public HMBFEKDDECL<IBLJEHJLOFH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public HMBFEKDDECL<MOHGMBIPFPM> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<JOFBNNGKBOO<AAFGLNNJOHN<GLPBIEDACAD>, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2542100", Offset = "0x2541500", VA = "0x182542100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2542380", Offset = "0x2541780", VA = "0x182542380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct BNBPENFPNIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<AAFGLNNJOHN<JEHMBJHBIMC>, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public OOCBNANOENM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public HMBFEKDDECL<IBLJEHJLOFH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public HMBFEKDDECL<MOHGMBIPFPM> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public AAFGLNNJOHN<FANPJMFIOIH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter<JOFBNNGKBOO<AAFGLNNJOHN<JEHMBJHBIMC>, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x253F040", Offset = "0x253E440", VA = "0x18253F040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x253F2C0", Offset = "0x253E6C0", VA = "0x18253F2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly NNEBJMMJLKO MIPHAIHKLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly FGAGELOHMIE MIEFHMKNDJG;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey EFCCEFONJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string GKFKADFNNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x253FC80", Offset = "0x253F080", VA = "0x18253FC80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NNEBJMMJLKO KIHPMKMJDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2543FE0", Offset = "0x25433E0", VA = "0x182543FE0")]
	public OOCBNANOENM(NNEBJMMJLKO KCGLNLMLKOE, FGAGELOHMIE LPHHLKJDLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2543D00", Offset = "0x2543100", VA = "0x182543D00", Slot = "6")]
	[AsyncStateMachine(typeof(KIHKHMHBALD))]
	public Task<JOFBNNGKBOO<AAFGLNNJOHN<GLPBIEDACAD>, PPAGHPBHFJD>> CKJAPCPBIEM(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, string OMOOEGOLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2543E70", Offset = "0x2543270", VA = "0x182543E70", Slot = "7")]
	[AsyncStateMachine(typeof(BNBPENFPNIL))]
	public Task<JOFBNNGKBOO<AAFGLNNJOHN<JEHMBJHBIMC>, PPAGHPBHFJD>> HFEDLIOCKEM(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, string OMOOEGOLALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class CIAJDHIOEOD : FBIOAFHMNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly NNEBJMMJLKO PJBCGMNPFFM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly HashSet<NNEBJMMJLKO> DBHDMLOGDLP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly HashSet<NNEBJMMJLKO> NDNBGGCDLAA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<NNEBJMMJLKO> FNBMNMBPILD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey PJGLJNJMAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2540F60", Offset = "0x2540360", VA = "0x182540F60", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool OGEPPCANEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2540F50", Offset = "0x2540350", VA = "0x182540F50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool IFIGMEECAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2540FB0", Offset = "0x25403B0", VA = "0x182540FB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool BDPKFNICMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2540ED0", Offset = "0x25402D0", VA = "0x182540ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x253F880", Offset = "0x253EC80", VA = "0x18253F880")]
	public bool COOFJEFBFLM(string KBGCCIOIGBD, [Out] GMLLPHEKNBK LICNGAMDKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public CIAJDHIOEOD(NNEBJMMJLKO AAMBBOLAGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x253FAF0", Offset = "0x253EEF0", VA = "0x18253FAF0")]
	internal static TypeKey JGECIPFBKFJ(NNEBJMMJLKO BMIPLDLMPCD)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x253FC80", Offset = "0x253F080", VA = "0x18253FC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct DFDJGJOJANJ : JJINKDABDAO.NEGMACIPDDF<GKPCJPMFCCN, IDMEFNAINAN>
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2541150", Offset = "0x2540550", VA = "0x182541150", Slot = "4")]
	public int IFJCMLBDBDB(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2541140", Offset = "0x2540540", VA = "0x182541140", Slot = "5")]
	public GKPCJPMFCCN GGMOOALNMDD(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x25411F0", Offset = "0x25405F0", VA = "0x1825411F0", Slot = "6")]
	public GKPCJPMFCCN OEPKLKMDNMF(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2541190", Offset = "0x2540590", VA = "0x182541190", Slot = "7")]
	public IReadOnlyList<GKPCJPMFCCN> JDGLOHBFGDE(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2541110", Offset = "0x2540510", VA = "0x182541110", Slot = "8")]
	public GKPCJPMFCCN[] EIOAOEDBCHK(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG, int LPGGENAOHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x25410F0", Offset = "0x25404F0", VA = "0x1825410F0", Slot = "9")]
	public bool CCKEILMOEBH(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2541120", Offset = "0x2540520", VA = "0x182541120", Slot = "10")]
	public bool GACEAADLHNB(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2541170", Offset = "0x2540570", VA = "0x182541170", Slot = "11")]
	public bool IKIJAKPDOAM(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x25410D0", Offset = "0x25404D0", VA = "0x1825410D0", Slot = "12")]
	public bool ADCEMGCPJOG(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x25411B0", Offset = "0x25405B0", VA = "0x1825411B0", Slot = "13")]
	public bool KGDPKHINAIE(IDMEFNAINAN ONLGAKFGMFI, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x25411D0", Offset = "0x25405D0", VA = "0x1825411D0", Slot = "14")]
	public bool NJHIKKCCDLE(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class MFGGHJEABLM : IMAMHOOCJJD
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GLOHCHOJCIM.IJLPCMCDLFO HHGEHMFJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2543260", Offset = "0x2542660", VA = "0x182543260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract AKKKOMJEAOO.OLOBPBHCFKI PLDNNPNAFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract ANALLCGONGO.OALMGBEMPGB KEHCLAIANAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract AIIOGMFDPOA.OLMPEGJBIHN IKELANILPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO> NHPNLEHJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x2543210", Offset = "0x2542610", VA = "0x182543210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract MPIPBIEPCIM.CIPPEHHPPDA CAMCBHODMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract IMJBELIIDML PMGFIKOAALP
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract ALENBMHCMPF KOGCJAMCEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract KNGKLKCEJJA DEHFCECFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract GAOMEGJGNAE GGOADPDKCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract BGOLFJJKINL FIBNHGPDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected MFGGHJEABLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class KLGFMKMNNGA : OMHDEOHDFHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct DOCIHNLDFBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public KLGFMKMNNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public GKPCJPMFCCN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2541220", Offset = "0x2540620", VA = "0x182541220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x25414C0", Offset = "0x25408C0", VA = "0x1825414C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct LOAPFBABAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public KLGFMKMNNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public IReadOnlyList<GKPCJPMFCCN> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2542E20", Offset = "0x2542220", VA = "0x182542E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x25431A0", Offset = "0x25425A0", VA = "0x1825431A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly NHECKHEMBJH HIOOFICJKMA;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public KLGFMKMNNGA(NHECKHEMBJH MKMHAKPJKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x25423F0", Offset = "0x25417F0", VA = "0x1825423F0")]
	[AsyncStateMachine(typeof(DOCIHNLDFBL))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> AICDCFGMFHH(GKPCJPMFCCN PJDAFKMDDCG, bool LELKEOHAIGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2542520", Offset = "0x2541920", VA = "0x182542520", Slot = "4")]
	[AsyncStateMachine(typeof(LOAPFBABAIL))]
	public Task<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> PJMMPPKNNIG(IReadOnlyList<GKPCJPMFCCN> NOFICAHDIEO, bool LELKEOHAIGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct FIJJIOIHDCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	internal CDNENBDPFJG<DGLIEKMCMIA, HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>, GKPCJPMFCCN, JDEFGJNCHCF> PJBCGMNPFFM;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x250C4B0", Offset = "0x250B8B0", VA = "0x18250C4B0")]
	private FIJJIOIHDCF([In] CDNENBDPFJG<DGLIEKMCMIA, HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>, GKPCJPMFCCN, JDEFGJNCHCF> JALFBPOCJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2541E40", Offset = "0x2541240", VA = "0x182541E40")]
	public static FIJJIOIHDCF FEOBEKOIKMG()
	{
		return default(FIJJIOIHDCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class HACCJCHMPBN
{
	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static CDNENBDPFJG<DGLIEKMCMIA, HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>, GKPCJPMFCCN, JDEFGJNCHCF> PDFGDBEJOPK(this FIJJIOIHDCF JDCFMPOHCEA)
	{
		return default(CDNENBDPFJG<DGLIEKMCMIA, HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>, GKPCJPMFCCN, JDEFGJNCHCF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct JDEFGJNCHCF : KAIEJPDBAIC.ALBGEODONGO<DGLIEKMCMIA, HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>, GKPCJPMFCCN>
{
	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2541EB0", Offset = "0x25412B0", VA = "0x182541EB0", Slot = "7")]
	public GKPCJPMFCCN LKMMOIMJJEN(DGLIEKMCMIA[] PLAABCPFEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x108F650", Offset = "0x108EA50", VA = "0x18108F650")]
	public HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA> MKELKMAHBOA([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xEE8930", Offset = "0xEE7D30", VA = "0x180EE8930")]
	public int HIHAJIPHNGC([In] DGLIEKMCMIA BHPCFAFLNGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2541EA0", Offset = "0x25412A0", VA = "0x182541EA0")]
	public int DECIHGFHIIC([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xEE8930", Offset = "0xEE7D30", VA = "0x180EE8930", Slot = "4")]
	private int MGGEKKMJPCA([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2541EA0", Offset = "0x25412A0", VA = "0x182541EA0", Slot = "5")]
	private int KNHNPBDKPNK([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x108F650", Offset = "0x108EA50", VA = "0x18108F650", Slot = "6")]
	private HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA> KHHEPCDGKPB([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct KCDLEKFBDJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	internal DNKMKDFCIDD<HDICGNLFMJC, GKPCJPMFCCN, LJNLFOLJOPD> PJBCGMNPFFM;

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x250C4B0", Offset = "0x250B8B0", VA = "0x18250C4B0")]
	private KCDLEKFBDJI([In] DNKMKDFCIDD<HDICGNLFMJC, GKPCJPMFCCN, LJNLFOLJOPD> MJPHLECBKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x25420A0", Offset = "0x25414A0", VA = "0x1825420A0")]
	public static KCDLEKFBDJI FEOBEKOIKMG()
	{
		return default(KCDLEKFBDJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class NPKKPJJIMGO
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static DNKMKDFCIDD<HDICGNLFMJC, GKPCJPMFCCN, LJNLFOLJOPD> PDFGDBEJOPK(this KCDLEKFBDJI JDCFMPOHCEA)
	{
		return default(DNKMKDFCIDD<HDICGNLFMJC, GKPCJPMFCCN, LJNLFOLJOPD>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct LJNLFOLJOPD : HKNLEIECMDG.DDMEHABLAMH<HDICGNLFMJC, GKPCJPMFCCN>
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF61A0", Offset = "0x1EF55A0", VA = "0x181EF61A0")]
	public int FOBJDOIEMAF([In] HDICGNLFMJC BHPCFAFLNGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2542C30", Offset = "0x2542030", VA = "0x182542C30", Slot = "5")]
	public GKPCJPMFCCN DEHEADAEJJA(HDICGNLFMJC[] EFLGBPFHINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x1EF61A0", Offset = "0x1EF55A0", VA = "0x181EF61A0", Slot = "4")]
	private int JNAIBOLGPIH([In] HDICGNLFMJC BHPCFAFLNGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class DPNMMFCPDJL : PGAGFEIEKID, KFNJBCGDAAC, PPAGHPBHFJD, EAPODONBJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly EAPODONBJNH? IMBIFHIAACP;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IJNGEOMLPGN BELNLGLGBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(IJNGEOMLPGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x94D450", Offset = "0x94C850", VA = "0x18094D450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override EAPODONBJNH? AFMGOADBMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2541530", Offset = "0x2540930", VA = "0x182541530", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x25417A0", Offset = "0x2540BA0", VA = "0x1825417A0")]
	private DPNMMFCPDJL(IJNGEOMLPGN OPCPCOOFBPO, EAPODONBJNH? POIIGEEAHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2541640", Offset = "0x2540A40", VA = "0x182541640")]
	public static DPNMMFCPDJL DDKKDBGDBIM(EAPODONBJNH POIIGEEAHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2541730", Offset = "0x2540B30", VA = "0x182541730")]
	public static DPNMMFCPDJL HALFOMOABBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x25416C0", Offset = "0x2540AC0", VA = "0x1825416C0")]
	public static DPNMMFCPDJL FLGEDKNPMIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class KEFNEMPFENP
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x3453C00", Offset = "0x3453000", VA = "0x183453C00")]
	public static JOFBNNGKBOO<TOk, KFNJBCGDAAC> FAIKBLGIMBB<TOk>([In] this JOFBNNGKBOO<TOk, KFNJBCGDAAC> JDCFMPOHCEA, EAPODONBJNH POIIGEEAHNE) where TOk : notnull
	{
		return default(JOFBNNGKBOO<TOk, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x3453B00", Offset = "0x3452F00", VA = "0x183453B00")]
	public static JOFBNNGKBOO<TOk?, KFNJBCGDAAC?> AKKEGGAGEFC<TOk>([In] this JOFBNNGKBOO<TOk, KFNJBCGDAAC> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<TOk, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x3453CF0", Offset = "0x34530F0", VA = "0x183453CF0")]
	public static JOFBNNGKBOO<TOk?, KFNJBCGDAAC?> LNOINFPOJDN<TOk>([In] this JOFBNNGKBOO<TOk, KFNJBCGDAAC> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<TOk, KFNJBCGDAAC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface IMJBELIIDML
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMAOPMABLLD([In] JOFBNNGKBOO<IDMEFNAINAN, EAPODONBJNH> BIEIOPPGBOB);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class IHDJEIGBAHC
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x33C1CA0", Offset = "0x33C10A0", VA = "0x1833C1CA0")]
	public static bool GMAOPMABLLD<TOk, TErr>(this IMJBELIIDML JDCFMPOHCEA, [In] JOFBNNGKBOO<TOk, TErr> BIEIOPPGBOB) where TOk : notnull where TErr : notnull, EAPODONBJNH
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface ALENBMHCMPF
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	BEAPGDJFAIH LLGLHHHJLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface KNGKLKCEJJA
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCFINBPPNLI FKGEMKOKHOC(int FEIBMFKLDKE);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface HJMBCGFFCPI
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface NFPIBBPOCFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDGCEOACEGG? HLHDAJNFPAD(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface MFHFCJPBOHA
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface HDGCEOACEGG
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MFHFCJPBOHA? FNGLOMEGCKE(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HJMBCGFFCPI? NIPGAGECHKE(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface GAOMEGJGNAE
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LJFNNOKAAMI(string KBGCCIOIGBD, string BPPCEJGCMKA);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface BGOLFJJKINL
{
	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFPIBBPOCFJ? APBNHIPAGLE([In] HMBFEKDDECL<LIPCHELCHBL> FPMJDPLOKIG);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class OICGHPBBMFF
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct MLDEMKCAONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int MPMCCDHNNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public OELEFOKLIPK? HDMCDPGNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public OELEFOKLIPK? KHLGANIHEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public readonly List<GKPCJPMFCCN> HJPMLCHDFAK;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x2543370", Offset = "0x2542770", VA = "0x182543370")]
		private MLDEMKCAONL(int EAHKFAJBNDN, OELEFOKLIPK? FAGJDLBMPNC, OELEFOKLIPK? JIDJJBKPEPG, List<GKPCJPMFCCN> NOFICAHDIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x25432B0", Offset = "0x25426B0", VA = "0x1825432B0")]
		public static MLDEMKCAONL FEOBEKOIKMG()
		{
			return default(MLDEMKCAONL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly DIKMIHOBJDI<MLDEMKCAONL> AEAJILPCCGH;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public static OICGHPBBMFF IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2543B00", Offset = "0x2542F00", VA = "0x182543B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool OEJONGMPBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xB39EB0", Offset = "0xB392B0", VA = "0x180B39EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xB396D0", Offset = "0xB38AD0", VA = "0x180B396D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x25433E0", Offset = "0x25427E0", VA = "0x1825433E0")]
	public void BENCOMJLKLN(NAPFONIDFOF JIDJJBKPEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2543800", Offset = "0x2542C00", VA = "0x182543800")]
	public void HMIICEIFENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x25434A0", Offset = "0x25428A0", VA = "0x1825434A0")]
	private static string? CKAGFFAJEBJ([In] MLDEMKCAONL OMLGPKOAPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2543C50", Offset = "0x2543050", VA = "0x182543C50")]
	public OICGHPBBMFF()
	{
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
