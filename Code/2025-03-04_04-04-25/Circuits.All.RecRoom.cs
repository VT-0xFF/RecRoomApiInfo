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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x2550420", Offset = "0x254EA20", VA = "0x182550420")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
		[Cpp2IlInjected.Address(RVA = "0x254CAF0", Offset = "0x254B0F0", VA = "0x18254CAF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x254CCC0", Offset = "0x254B2C0", VA = "0x18254CCC0", Slot = "13")]
		public virtual void NFOKJFBPIHF(ANALLCGONGO DFLGEEGCPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x254CC40", Offset = "0x254B240", VA = "0x18254CC40", Slot = "14")]
		public virtual void KFCGHNNPOPA(ANALLCGONGO DFLGEEGCPMI, GKPCJPMFCCN PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x253F230", Offset = "0x253D830", VA = "0x18253F230")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		private ADDHNMPOBIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D8710", Offset = "0x9D6D10", VA = "0x1809D8710", Slot = "4")]
		public BKANLMFPFAO ECMMNNHBDPD(GKPCJPMFCCN JDCFMPOHCEA)
		{
			return default(BKANLMFPFAO);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2535460", Offset = "0x2533A60", VA = "0x182535460", Slot = "5")]
		public void NFOKJFBPIHF(ANALLCGONGO JGHOOBNHEJB, GKPCJPMFCCN PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2535350", Offset = "0x2533950", VA = "0x182535350", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x25382A0", Offset = "0x25368A0", VA = "0x1825382A0")]
		internal BPNMPGBEFAB(HMHNOMGHDBI<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO, NOEGOOCAILH.NBFPMIDGEGN<BKANLMFPFAO, GKPCJPMFCCN, ANALLCGONGO>> AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2538250", Offset = "0x2536850", VA = "0x182538250")]
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
			[Cpp2IlInjected.Address(RVA = "0x2538830", Offset = "0x2536E30", VA = "0x182538830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2538A10", Offset = "0x2537010", VA = "0x182538A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD47200", Offset = "0xD45800", VA = "0x180D47200", Slot = "4")]
		public AAFGLNNJOHN<LEJAOJOLFIL> PCAPCCPBPKC(ANALLCGONGO ODAGIILJBBF)
		{
			return default(AAFGLNNJOHN<LEJAOJOLFIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x25395E0", Offset = "0x2537BE0", VA = "0x1825395E0", Slot = "5")]
		public void PCCIFMBJCNL(ANALLCGONGO ODAGIILJBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x25394B0", Offset = "0x2537AB0", VA = "0x1825394B0", Slot = "6")]
		[AsyncStateMachine(typeof(CPCMFIMAMEB))]
		public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> NHFLDOKKJDG(ANALLCGONGO ODAGIILJBBF, GKPCJPMFCCN PJDAFKMDDCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2539490", Offset = "0x2537A90", VA = "0x182539490", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x253BC50", Offset = "0x253A250", VA = "0x18253BC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x253BEE0", Offset = "0x253A4E0", VA = "0x18253BEE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x25501D0", Offset = "0x254E7D0", VA = "0x1825501D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25503B0", Offset = "0x254E9B0", VA = "0x1825503B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x25400F0", Offset = "0x253E6F0", VA = "0x1825400F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x25402E0", Offset = "0x253E8E0", VA = "0x1825402E0", Slot = "5")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B00")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IMAMHOOCJJD OPLKDHGAEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B08")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NAPFONIDFOF.DHABAJMPACM BBMDLIEJGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PFHMAFDDNAH MLOBGKIJFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly IKAOBOCJFBC DMJAIGOOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly GMPNDNPPCAN MCOCHJIGJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EBKJNLBDILK EMPPPMCOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KCDLEKFBDJI CPNDLFGBNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FIJJIOIHDCF JNGDDKHPGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly MCFODAPLEMO.EIINLOONONC MKIOBPKHMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly IINEAIHFAEH DPCJCMNPBNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MCFODAPLEMO IJCMOLCPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2536FA0", Offset = "0x25355A0", VA = "0x182536FA0")]
		get
		{
			return default(MCFODAPLEMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal OALMGBEMPGB PPAJKFABENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2536F50", Offset = "0x2535550", VA = "0x182536F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HNDIPKGBMMO KFHBLOKIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2537B30", Offset = "0x2536130", VA = "0x182537B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x25377A0", Offset = "0x2535DA0", VA = "0x1825377A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool JDEAJEAMBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x25379E0", Offset = "0x2535FE0", VA = "0x1825379E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2537790", Offset = "0x2535D90", VA = "0x182537790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AJLEDLNKANK BIANCAINFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2537E40", Offset = "0x2536440", VA = "0x182537E40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GNIGFNFNOIA JAOFKFOLIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2537E50", Offset = "0x2536450", VA = "0x182537E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KFBJGPELJDA IBJPNDOMINL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2537E70", Offset = "0x2536470", VA = "0x182537E70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PCBMEDABEPH CDGCNGPDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2537E60", Offset = "0x2536460", VA = "0x182537E60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NAPFONIDFOF? KJMECFJCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2536830", Offset = "0x2534E30", VA = "0x182536830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private MIBHJHEHAJB? JAACGHEPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x25377C0", Offset = "0x2535DC0", VA = "0x1825377C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2537B40", Offset = "0x2536140", VA = "0x182537B40")]
	private ANALLCGONGO(IMAMHOOCJJD KPHLIDJMEFA, AAFGLNNJOHN<LEJAOJOLFIL> CGHBAOIKKLL, [In] GFBEBKDMEGG HAHFPCFGGPJ, [In] MCFODAPLEMO JMCFKKNNBPG, [In] PLFMNGFKFHK MFDCKPKKMGD, HNDIPKGBMMO LLDKBOFNBEP, [In] NAPFONIDFOF.DHABAJMPACM KONEPOGDPOP, MCFODAPLEMO.EIINLOONONC PHCJIPOMDCG, IINEAIHFAEH DOPCGIDJNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x25372C0", Offset = "0x25358C0", VA = "0x1825372C0")]
	public static ANALLCGONGO FEOBEKOIKMG(IMAMHOOCJJD GKFDJGEMKAB, [In] MPIJMBBAFGM NIHKHDELHBC, OAMPFCKMMAH NPMHMGNGBCB, [In] CBHNHGPJBLC LBCFDHIHPOP, GCIMGMNHDFF KNCFIIMLEHI, AAFGLNNJOHN<LEJAOJOLFIL> CGHBAOIKKLL, AAFGLNNJOHN<LOCODMBOCKM> GHJDKDMDPJE, NHECKHEMBJH MKMHAKPJKLC, JGNLKIBMJMM HKAEADLODCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2536FB0", Offset = "0x25355B0", VA = "0x182536FB0")]
	public static ANALLCGONGO FEOBEKOIKMG(IMAMHOOCJJD KPHLIDJMEFA, [In] MCFODAPLEMO JMCFKKNNBPG, [In] PLFMNGFKFHK MFDCKPKKMGD, AAFGLNNJOHN<LEJAOJOLFIL> CGHBAOIKKLL, AAFGLNNJOHN<LOCODMBOCKM> GHJDKDMDPJE, NHECKHEMBJH MKMHAKPJKLC, JGNLKIBMJMM HKAEADLODCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2536D60", Offset = "0x2535360", VA = "0x182536D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25378F0", Offset = "0x2535EF0", VA = "0x1825378F0")]
	[AsyncStateMachine(typeof(ELKKPMIPCGJ))]
	public Task<JOFBNNGKBOO<bool, PPAGHPBHFJD>> MIMGDLJCPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2537A40", Offset = "0x2536040", VA = "0x182537A40")]
	[AsyncStateMachine(typeof(NDHHBAONFCF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> PEBNGKPELPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x25368B0", Offset = "0x2534EB0", VA = "0x1825368B0")]
	internal void DHACCMKHHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x25367B0", Offset = "0x2534DB0", VA = "0x1825367B0")]
	internal HEGNJKKKIBE<GKPCJPMFCCN> COCDEILOMPH([In] HDICGNLFMJC CLCDGLGOFOK)
	{
		return default(HEGNJKKKIBE<GKPCJPMFCCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2536740", Offset = "0x2534D40", VA = "0x182536740")]
	internal bool BMICDOJFOHM([In] HDICGNLFMJC CLCDGLGOFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2536AC0", Offset = "0x25350C0", VA = "0x182536AC0")]
	internal JOFBNNGKBOO<GKPCJPMFCCN, PPAGHPBHFJD> DMJBNMEOAIB([In] DGLIEKMCMIA HOPODOMHJIG)
	{
		return default(JOFBNNGKBOO<GKPCJPMFCCN, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25379F0", Offset = "0x2535FF0", VA = "0x1825379F0")]
	private void PCCIFMBJCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2536C50", Offset = "0x2535250", VA = "0x182536C50")]
	[AsyncStateMachine(typeof(HEMOODLCLBA))]
	internal Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> DPDNBFEHLMB(GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2537400", Offset = "0x2535A00", VA = "0x182537400")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B2200", Offset = "0x27B0800", VA = "0x1827B2200", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5A71390", Offset = "0x5A6F990", VA = "0x185A71390")]
	internal CDBCIIIFODN([In] HMBFEKDDECL<MOHGMBIPFPM>? CDNDAAFFENM, AAFGLNNJOHN<MBNEIPNGAFM>? PIBGEDDCHCI, IOKind? GACCJJGLILE, string MIALAMIFNLM, [In] TData GIDGOODJFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class INGPJGPFAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2540710", Offset = "0x253ED10", VA = "0x182540710")]
	public static JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ> HDEKFCLEBND([In] this MPALANKACLD<KNKGKAJFOIB> MHMBHELMFMF)
	{
		return default(JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3414440", Offset = "0x3412A40", VA = "0x183414440")]
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
	[Cpp2IlInjected.Address(RVA = "0x254FE90", Offset = "0x254E490", VA = "0x18254FE90")]
	public static GKPCJPMFCCN MJFLCHPCKPJ(this GKPCJPMFCCN JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x254FDC0", Offset = "0x254E3C0", VA = "0x18254FDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x253F240", Offset = "0x253D840", VA = "0x18253F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x253F500", Offset = "0x253DB00", VA = "0x18253F500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString DEDOPNLMLPL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	private PPBKDIGKDNJ(ByteString KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25523F0", Offset = "0x25509F0", VA = "0x1825523F0")]
	public static GKPCJPMFCCN CEMOOOEJOGL(ByteString KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25525C0", Offset = "0x2550BC0", VA = "0x1825525C0")]
	public static FAGPPDKBBNO<BKANLMFPFAO, PPBKDIGKDNJ> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, PPBKDIGKDNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25524B0", Offset = "0x2550AB0", VA = "0x1825524B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x25383A0", Offset = "0x25369A0", VA = "0x1825383A0")]
	public static GKPCJPMFCCN CEMOOOEJOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2538440", Offset = "0x2536A40", VA = "0x182538440")]
	public static FAGPPDKBBNO<BKANLMFPFAO, CIKENIFGBLP> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, CIKENIFGBLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25384B0", Offset = "0x2536AB0", VA = "0x1825384B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2535D30", Offset = "0x2534330", VA = "0x182535D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x25360A0", Offset = "0x25346A0", VA = "0x1825360A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x246E9F0", Offset = "0x246CFF0", VA = "0x18246E9F0")]
	private DABMDHIJLOH(DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2538A80", Offset = "0x2537080", VA = "0x182538A80")]
	public static GKPCJPMFCCN? CEMOOOEJOGL(DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2538CC0", Offset = "0x25372C0", VA = "0x182538CC0")]
	public static FAGPPDKBBNO<BKANLMFPFAO, DABMDHIJLOH> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, DABMDHIJLOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2538B80", Offset = "0x2537180", VA = "0x182538B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x253BF50", Offset = "0x253A550", VA = "0x18253BF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x253C3B0", Offset = "0x253A9B0", VA = "0x18253C3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<GKPCJPMFCCN> HJPMLCHDFAK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	private JDPJGGMODMC(IReadOnlyList<GKPCJPMFCCN> NOFICAHDIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x254B9C0", Offset = "0x2549FC0", VA = "0x18254B9C0")]
	public static GKPCJPMFCCN CEMOOOEJOGL(IReadOnlyList<GKPCJPMFCCN> NOFICAHDIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x254BBC0", Offset = "0x254A1C0", VA = "0x18254BBC0")]
	public static FAGPPDKBBNO<BKANLMFPFAO, JDPJGGMODMC> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, JDPJGGMODMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x254BA80", Offset = "0x254A080", VA = "0x18254BA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JJIHNLJMGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x254C7C0", Offset = "0x254ADC0", VA = "0x18254C7C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2539470", Offset = "0x2537A70", VA = "0x182539470")]
	private DGLIEKMCMIA(HMBFEKDDECL<ACDDHAOJDHA> GPBEADEPELC, int BBEJNKBNMID, int EAHKFAJBNDN, byte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2538F60", Offset = "0x2537560", VA = "0x182538F60")]
	public static GKPCJPMFCCN CEMOOOEJOGL(HMBFEKDDECL<ACDDHAOJDHA> GPBEADEPELC, int BBEJNKBNMID, int EAHKFAJBNDN, ByteString GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2539360", Offset = "0x2537960", VA = "0x182539360")]
	public static GKPCJPMFCCN[] OLLCFLKPEGG(GKPCJPMFCCN PJDAFKMDDCG, int AAMJFOFMHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2539070", Offset = "0x2537670", VA = "0x182539070")]
	public static FAGPPDKBBNO<BKANLMFPFAO, DGLIEKMCMIA> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, DGLIEKMCMIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25391C0", Offset = "0x25377C0", VA = "0x1825391C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x253B5A0", Offset = "0x2539BA0", VA = "0x18253B5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x253BBE0", Offset = "0x253A1E0", VA = "0x18253BBE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB05B0", Offset = "0xAAEBB0", VA = "0x180AB05B0")]
	private HDICGNLFMJC(int BBEJNKBNMID, int EAHKFAJBNDN, byte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x253FC00", Offset = "0x253E200", VA = "0x18253FC00")]
	public static GKPCJPMFCCN CEMOOOEJOGL(int BBEJNKBNMID, int EAHKFAJBNDN, ByteString GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x253FE10", Offset = "0x253E410", VA = "0x18253FE10")]
	public static GKPCJPMFCCN?[]? ELKGMNEHJDM(int AAMJFOFMHFE, DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2540010", Offset = "0x253E610", VA = "0x182540010")]
	public static FAGPPDKBBNO<BKANLMFPFAO, HDICGNLFMJC> GCDALANACLC(GKPCJPMFCCN MFICDCCHLFD)
	{
		return default(FAGPPDKBBNO<BKANLMFPFAO, HDICGNLFMJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x253FCE0", Offset = "0x253E2E0", VA = "0x18253FCE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2551D80", Offset = "0x2550380", VA = "0x182551D80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public EDICMIIAGJB(ANALLCGONGO DFLGEEGCPMI, FGAGELOHMIE LPHHLKJDLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25399B0", Offset = "0x2537FB0", VA = "0x1825399B0", Slot = "4")]
	public JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ> HEAAGMPGNPF(HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO)
	{
		return default(JOFBNNGKBOO<PPOFOMJOKDI, LOBMCHILMEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2539C90", Offset = "0x2538290", VA = "0x182539C90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x253E3D0", Offset = "0x253C9D0", VA = "0x18253E3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x253E5A0", Offset = "0x253CBA0", VA = "0x18253E5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly AIJEOBDIICE IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		private AIJEOBDIICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2535890", Offset = "0x2533E90", VA = "0x182535890", Slot = "4")]
		[AsyncStateMachine(typeof(FKLJFHDCGPL))]
		public Task<FGAGELOHMIE> CCHENACKIKG(ANALLCGONGO DFLGEEGCPMI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x25359F0", Offset = "0x2533FF0", VA = "0x1825359F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2551810", Offset = "0x254FE10", VA = "0x182551810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2551D10", Offset = "0x2550310", VA = "0x182551D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x253F570", Offset = "0x253DB70", VA = "0x18253F570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MIBHJHEHAJB LPAFAHPPKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x253F620", Offset = "0x253DC20", VA = "0x18253F620", Slot = "5")]
		get
		{
			return default(MIBHJHEHAJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EDICMIIAGJB IAFJMKPEANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xDDF810", Offset = "0xDDDE10", VA = "0x180DDF810")]
	private GLOHCHOJCIM(FGAGELOHMIE LPHHLKJDLIO, IIPMLPJOFAH GEACFDKHKOC, EDICMIIAGJB OGEMFOHPEOL, GHGILLKJOFN HNHMGPGOPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x253F6E0", Offset = "0x253DCE0", VA = "0x18253F6E0")]
	[AsyncStateMachine(typeof(PDHIPNEMJCJ))]
	public static Task<GLOHCHOJCIM> PIEBIBJICAE(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x253F5C0", Offset = "0x253DBC0", VA = "0x18253F5C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x253F850", Offset = "0x253DE50", VA = "0x18253F850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x253FB90", Offset = "0x253E190", VA = "0x18253FB90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x254C990", Offset = "0x254AF90", VA = "0x18254C990", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2537FE0", Offset = "0x25365E0", VA = "0x182537FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x25381E0", Offset = "0x25367E0", VA = "0x1825381E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2550710", Offset = "0x254ED10", VA = "0x182550710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2550C40", Offset = "0x254F240", VA = "0x182550C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x97EF20", Offset = "0x97D520", VA = "0x18097EF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xC46D10", Offset = "0xC45310", VA = "0x180C46D10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x111C6B0", Offset = "0x111ACB0", VA = "0x18111C6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GAHCALICHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x17C6140", Offset = "0x17C4740", VA = "0x1817C6140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2536200", Offset = "0x2534800", VA = "0x182536200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HLOLLCBMKHJ? EMBEKCDACDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2536110", Offset = "0x2534710", VA = "0x182536110", Slot = "7")]
	[AsyncStateMachine(typeof(BLBKMPFFPJD))]
	public Task<HLOLLCBMKHJ> ACGMJKHEDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x25364F0", Offset = "0x2534AF0", VA = "0x1825364F0")]
	public AKKKOMJEAOO(OLOBPBHCFKI GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2536390", Offset = "0x2534990", VA = "0x182536390", Slot = "8")]
	[AsyncStateMachine(typeof(OBALLDLMCNL))]
	public Task IJJPGHFDAMO(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI, OELEFOKLIPK? IMKLDCLNPCM, HFDFODLNHEC? KGOBGOFEEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2536210", Offset = "0x2534810", VA = "0x182536210", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15A52D0", Offset = "0x15A38D0", VA = "0x1815A52D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AAFGLNNJOHN<IBLJEHJLOFH> JEDJBPCDOPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x46C14C0", Offset = "0x46BFAC0", VA = "0x1846C14C0", Slot = "5")]
			get
			{
				return default(AAFGLNNJOHN<IBLJEHJLOFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AAFGLNNJOHN<IBLJEHJLOFH>? JPBBGBOJFBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x46C1440", Offset = "0x46BFA40", VA = "0x1846C1440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2537E80", Offset = "0x2536480", VA = "0x182537E80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2537EA0", Offset = "0x25364A0", VA = "0x182537EA0")]
		public AOJEEGOIOEC(NJNKJGHAEIP IHLGBEHIHGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2538DD0", Offset = "0x25373D0", VA = "0x182538DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2552670", Offset = "0x2550C70", VA = "0x182552670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x25528E0", Offset = "0x2550EE0", VA = "0x1825528E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CAPKLIINEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x25382B0", Offset = "0x25368B0", VA = "0x1825382B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2551E80", Offset = "0x2550480", VA = "0x182551E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2552390", Offset = "0x2550990", VA = "0x182552390", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2552940", Offset = "0x2550F40", VA = "0x182552940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2552C20", Offset = "0x2551220", VA = "0x182552C20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FNOOOMNODEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x253E610", Offset = "0x253CC10", VA = "0x18253E610")]
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
		[Cpp2IlInjected.Address(RVA = "0x254D2E0", Offset = "0x254B8E0", VA = "0x18254D2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public AAFGLNNJOHN<EAGGAAMICCD> DPENBOJHKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xD804F0", Offset = "0xD7EAF0", VA = "0x180D804F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<EAGGAAMICCD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xD7F330", Offset = "0xD7D930", VA = "0x180D7F330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private AAFGLNNJOHN<GLPBIEDACAD> HAADBKFHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x111D530", Offset = "0x111BB30", VA = "0x18111D530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> GGBFAFGOPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x978C70", Offset = "0x977270", VA = "0x180978C70", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x254DBA0", Offset = "0x254C1A0", VA = "0x18254DBA0", Slot = "21")]
		get
		{
			return default(AAFGLNNJOHN<MBNEIPNGAFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OMHAABKOGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x254DC40", Offset = "0x254C240", VA = "0x18254DC40", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x254F550", Offset = "0x254DB50", VA = "0x18254F550")]
	private KDPBGGCOFDK(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, JBHKBKNGGIE BBOEDEGJDGO, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO, AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, bool PFCNKPEGGGF, string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x254D7F0", Offset = "0x254BDF0", VA = "0x18254D7F0")]
	public static KDPBGGCOFDK FEOBEKOIKMG(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, JBHKBKNGGIE IOJLNNHDMIE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO, bool PFCNKPEGGGF, bool CAIFGFNEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x254DE10", Offset = "0x254C410", VA = "0x18254DE10", Slot = "22")]
	protected override void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x254D670", Offset = "0x254BC70", VA = "0x18254D670", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x254E0C0", Offset = "0x254C6C0", VA = "0x18254E0C0", Slot = "31")]
	public void JIPOAEFLEIC(BBEGDIMCAGL GMCKAINFGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x254D300", Offset = "0x254B900", VA = "0x18254D300", Slot = "28")]
	public void DMOMODCOIJB(CJOLANKLLLC MFMAAEJAKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x254EBA0", Offset = "0x254D1A0", VA = "0x18254EBA0", Slot = "29")]
	public void PAPEFNAGMAJ(NAFIPGKODIH IKBBGNEMAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x254DCC0", Offset = "0x254C2C0", VA = "0x18254DCC0", Slot = "24")]
	protected override void HKJFIOLGBII(LHFOHFDEOKM IMBHIBDELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x254E920", Offset = "0x254CF20", VA = "0x18254E920", Slot = "33")]
	public string OHDFKHEOEHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x254CD00", Offset = "0x254B300", VA = "0x18254CD00", Slot = "30")]
	public string AONPCELGDMA(int FCDJJGFAGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x254E230", Offset = "0x254C830", VA = "0x18254E230")]
	private void KJIBGEBPHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x254E460", Offset = "0x254CA60", VA = "0x18254E460", Slot = "32")]
	public void KPEEJDOADBI(BBEGDIMCAGL GMCKAINFGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x254D120", Offset = "0x254B720", VA = "0x18254D120")]
	private void CACEHLIGNEE(bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x254EA90", Offset = "0x254D090", VA = "0x18254EA90", Slot = "34")]
	[AsyncStateMachine(typeof(PJLHPHBJBGK))]
	public Task OJCIHPNGCHI(string KBGCCIOIGBD, bool HNHIAMODIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x254DEB0", Offset = "0x254C4B0", VA = "0x18254DEB0")]
	public void JFFADKLCNOO(string KBGCCIOIGBD, bool HNHIAMODIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x254E5F0", Offset = "0x254CBF0", VA = "0x18254E5F0")]
	private void MPPLKHEBNMF(int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xD7F330", Offset = "0xD7D930", VA = "0x180D7F330")]
	internal void NLOIHDBPEPA(AAFGLNNJOHN<EAGGAAMICCD> KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x254D090", Offset = "0x254B690", VA = "0x18254D090")]
	[CompilerGenerated]
	private void BOMFONPKLIA(string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x254E530", Offset = "0x254CB30", VA = "0x18254E530")]
	[CompilerGenerated]
	private bool MNIKGGBFCCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x254E000", Offset = "0x254C600", VA = "0x18254E000")]
	[CompilerGenerated]
	private bool JGDGHBNFPBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x254D710", Offset = "0x254BD10", VA = "0x18254D710")]
	[CompilerGenerated]
	private int EHPCDAPPMCL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x254D760", Offset = "0x254BD60", VA = "0x18254D760")]
	[CompilerGenerated]
	private bool FEAIHGMIEEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x254E520", Offset = "0x254CB20", VA = "0x18254E520")]
	[CompilerGenerated]
	private void MNEEBMGIBDM(string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x254E790", Offset = "0x254CD90", VA = "0x18254E790")]
	[CompilerGenerated]
	private bool NEOBEBFDHAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x254DBF0", Offset = "0x254C1F0", VA = "0x18254DBF0")]
	[CompilerGenerated]
	private bool GPNOGPBNIFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x254E120", Offset = "0x254C720", VA = "0x18254E120")]
	[CompilerGenerated]
	private bool KCGHOHJBPGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x254D710", Offset = "0x254BD10", VA = "0x18254D710")]
	[CompilerGenerated]
	private int MLDGONLDKGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x254E850", Offset = "0x254CE50", VA = "0x18254E850")]
	[CompilerGenerated]
	private bool OGGEJIOADIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x254E1B0", Offset = "0x254C7B0", VA = "0x18254E1B0")]
	[CompilerGenerated]
	private object KFPOJHAGHND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x254D0A0", Offset = "0x254B6A0", VA = "0x18254D0A0")]
	[CompilerGenerated]
	private void BPOGPOBBCBN(object KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x254CFC0", Offset = "0x254B5C0", VA = "0x18254CFC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KLGODBOPLOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x254FA10", Offset = "0x254E010", VA = "0x18254FA10")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x254F940", Offset = "0x254DF40", VA = "0x18254F940")]
			internal void FHAIOPDBBKM(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x25387C0", Offset = "0x2536DC0", VA = "0x1825387C0")]
		public CNMMOKIBEGG(ANALLCGONGO DFLGEEGCPMI, PEDLBFHLHOK AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2538530", Offset = "0x2536B30", VA = "0x182538530", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F6D0", Offset = "0xA6DCD0", VA = "0x180A6F6D0", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x254C930", Offset = "0x254AF30", VA = "0x18254C930")]
		public JJMHJGAEEKL(ANALLCGONGO DFLGEEGCPMI, AHOJMOMFBEM AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class DPJPIMCIMPP : KPJGEGMJNEL<FGFEELIEOLM>
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2539940", Offset = "0x2537F40", VA = "0x182539940")]
		public DPJPIMCIMPP(ANALLCGONGO DFLGEEGCPMI, FGFEELIEOLM HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2539770", Offset = "0x2537D70", VA = "0x182539770", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x25398F0", Offset = "0x2537EF0", VA = "0x1825398F0")]
		[CompilerGenerated]
		private bool LBHCJCADGGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2539640", Offset = "0x2537C40", VA = "0x182539640")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public OAFNIJDCMFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2550670", Offset = "0x254EC70", VA = "0x182550670")]
			internal void MNLGAMGLBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x25504F0", Offset = "0x254EAF0", VA = "0x1825504F0")]
			internal bool FHAIOPDBBKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x25506C0", Offset = "0x254ECC0", VA = "0x1825506C0")]
			internal bool MNPFLPCHHNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2550540", Offset = "0x254EB40", VA = "0x182550540")]
			internal void JFBADLEIDLK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x25504A0", Offset = "0x254EAA0", VA = "0x1825504A0")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2550FE0", Offset = "0x254F5E0", VA = "0x182550FE0")]
		public OMMNMNEIKED(ANALLCGONGO DFLGEEGCPMI, LAAIEHIAPEN HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2550CA0", Offset = "0x254F2A0", VA = "0x182550CA0", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public GEJKLGPIKJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x253EFC0", Offset = "0x253D5C0", VA = "0x18253EFC0")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x253EC40", Offset = "0x253D240", VA = "0x18253EC40")]
			internal bool FFNOGLAOMOO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x253ECC0", Offset = "0x253D2C0", VA = "0x18253ECC0")]
			internal void FHAIOPDBBKM(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x253F0C0", Offset = "0x253D6C0", VA = "0x18253F0C0")]
			internal string MNPFLPCHHNE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x253EF20", Offset = "0x253D520", VA = "0x18253EF20")]
			internal IReadOnlyList<object> JFBADLEIDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x253EAA0", Offset = "0x253D0A0", VA = "0x18253EAA0")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x253EF70", Offset = "0x253D570", VA = "0x18253EF70")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x253EB10", Offset = "0x253D110", VA = "0x18253EB10")]
			internal void EOFCJLIFDNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x25517A0", Offset = "0x254FDA0", VA = "0x1825517A0")]
		public OPIEGBPGLFI(ANALLCGONGO DFLGEEGCPMI, MJJADHBDHME HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2551050", Offset = "0x254F650", VA = "0x182551050", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KFNJFFCGNFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x254F8A0", Offset = "0x254DEA0", VA = "0x18254F8A0")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x254F770", Offset = "0x254DD70", VA = "0x18254F770")]
			internal void FHAIOPDBBKM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x254F8F0", Offset = "0x254DEF0", VA = "0x18254F8F0")]
			internal bool MNPFLPCHHNE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2535CC0", Offset = "0x25342C0", VA = "0x182535CC0")]
		public AILAOLHCNAK(ANALLCGONGO DFLGEEGCPMI, EIBFDEPAGCD HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2535A90", Offset = "0x2534090", VA = "0x182535A90", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B5DAC0", Offset = "0x5B5C0C0", VA = "0x185B5DAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5B5DED0", Offset = "0x5B5C4D0", VA = "0x185B5DED0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x404B910", Offset = "0x4049F10", VA = "0x18404B910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x404BD20", Offset = "0x404A320", VA = "0x18404BD20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool DIDJGIAICIC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override AAFGLNNJOHN<FANPJMFIOIH>? GGAOKAAECHE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4BBAAB0", Offset = "0x4BB90B0", VA = "0x184BBAAB0", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4BBAA60", Offset = "0x4BB9060", VA = "0x184BBAA60")]
		protected LGEECOLFGLO(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA650", Offset = "0x4BB8C50", VA = "0x184BBA650", Slot = "112")]
		[AsyncStateMachine(typeof(LGEECOLFGLO<>.CJDBOPOOCHH))]
		public override Task<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> AAGHMFMMFIK(string OMOOEGOLALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA770", Offset = "0x4BB8D70", VA = "0x184BBA770", Slot = "136")]
		public sealed override bool FGCCEDEMFKF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA9C0", Offset = "0x4BB8FC0", VA = "0x184BBA9C0", Slot = "124")]
		protected sealed override bool ODGPFOGEFMK(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA920", Offset = "0x4BB8F20", VA = "0x184BBA920", Slot = "125")]
		protected override bool LIPAHAGNIEN(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA810", Offset = "0x4BB8E10", VA = "0x184BBA810", Slot = "113")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public AMIMNFPALGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2536600", Offset = "0x2534C00", VA = "0x182536600")]
			internal bool ANPGGHIJLED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2536680", Offset = "0x2534C80", VA = "0x182536680")]
			internal void KACMPDEBBLL(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2535830", Offset = "0x2533E30", VA = "0x182535830")]
		public AEANKGOCDJJ(ANALLCGONGO DFLGEEGCPMI, HBANPKEGEJE AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x25355E0", Offset = "0x2533BE0", VA = "0x1825355E0", Slot = "138")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x254FD60", Offset = "0x254E360", VA = "0x18254FD60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BC8C00", Offset = "0x4BC7200", VA = "0x184BC8C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4BC90B0", Offset = "0x4BC76B0", VA = "0x184BC90B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5118290", Offset = "0x5116890", VA = "0x185118290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5118710", Offset = "0x5116D10", VA = "0x185118710", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FEA490", Offset = "0x4FE8A90", VA = "0x184FEA490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4FEAB40", Offset = "0x4FE9140", VA = "0x184FEAB40", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D299F0", Offset = "0x3D27FF0", VA = "0x183D299F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public MKOBDMKMABF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4E0B070", Offset = "0x4E09670", VA = "0x184E0B070")]
			internal bool EOFCJLIFDNB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4E0B5E0", Offset = "0x4E09BE0", VA = "0x184E0B5E0")]
			internal void MNLGAMGLBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4E0B150", Offset = "0x4E09750", VA = "0x184E0B150")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.MKOBDMKMABF.<<BuildConfigMenuInternal>b__7>d))]
			internal void FFNOGLAOMOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4E0B1F0", Offset = "0x4E097F0", VA = "0x184E0B1F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D29680", Offset = "0x3D27C80", VA = "0x183D29680", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KMPDFKMLODF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4AC56A0", Offset = "0x4AC3CA0", VA = "0x184AC56A0")]
			internal void MNPFLPCHHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			internal string JFBADLEIDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			internal void CFFDGMAAICP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4AC5600", Offset = "0x4AC3C00", VA = "0x184AC5600")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D291B0", Offset = "0x3D277B0", VA = "0x183D291B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D29390", Offset = "0x3D27990", VA = "0x183D29390", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D28AF0", Offset = "0x3D270F0", VA = "0x183D28AF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public OOJKPPHEAMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x502A8B0", Offset = "0x5028EB0", VA = "0x18502A8B0")]
			internal bool CMDEAHEOLMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x502AFA0", Offset = "0x50295A0", VA = "0x18502AFA0")]
			internal void MOHKNFFJPJD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x502AEC0", Offset = "0x50294C0", VA = "0x18502AEC0")]
			internal bool MMJBBPBNHLD(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x502AAF0", Offset = "0x50290F0", VA = "0x18502AAF0")]
			internal bool FGHBFFAABNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x502ABF0", Offset = "0x50291F0", VA = "0x18502ABF0")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OOJKPPHEAMA.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void GEJGLANPPCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x502AC90", Offset = "0x5029290", VA = "0x18502AC90")]
			internal bool HEMLPLFODBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x502AB30", Offset = "0x5029130", VA = "0x18502AB30")]
			internal void GCLBJIKHGID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x502B0E0", Offset = "0x50296E0", VA = "0x18502B0E0")]
			internal bool PIFLKAAPLHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x502A9C0", Offset = "0x5028FC0", VA = "0x18502A9C0")]
			internal void COJJFMHKIEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x502AE10", Offset = "0x5029410", VA = "0x18502AE10")]
			internal bool MLPODFAPGNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x50292D0", VA = "0x18502ACD0")]
			internal bool LPKOGAGGFMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x502AA80", Offset = "0x5029080", VA = "0x18502AA80")]
			internal void DGFMAMOJJLC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x502A810", Offset = "0x5028E10", VA = "0x18502A810")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OOJKPPHEAMA.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void BJGNFMHBKAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x502AD40", Offset = "0x5029340", VA = "0x18502AD40")]
			internal bool LPLFFGNNKEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x502B070", Offset = "0x5029670", VA = "0x18502B070")]
			internal bool PHPOAECPPGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x502ADA0", Offset = "0x50293A0", VA = "0x18502ADA0")]
			internal void MAOCEALLBIN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x502A920", Offset = "0x5028F20", VA = "0x18502A920")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OOJKPPHEAMA.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CNOCFOOGDKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x502B010", Offset = "0x5029610", VA = "0x18502B010")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D28DE0", Offset = "0x3D273E0", VA = "0x183D28DE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public PIMJMLIJALN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x51058F0", Offset = "0x5103EF0", VA = "0x1851058F0")]
			internal void NFAKIAMLCLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			internal string IGLNKMIBKKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			internal void PHPNDHHBLNI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x5105D00", Offset = "0x5104300", VA = "0x185105D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public MMFPGAJOOAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4E18E10", Offset = "0x4E17410", VA = "0x184E18E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public JJLHCBFOKJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x49D0800", Offset = "0x49CEE00", VA = "0x1849D0800")]
			internal void OHJLONAFGPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x49D0750", Offset = "0x49CED50", VA = "0x1849D0750")]
			internal bool MMLNOMIHAID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x49D0630", Offset = "0x49CEC30", VA = "0x1849D0630")]
			internal void JCEDLJGDOKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x49D07A0", Offset = "0x49CEDA0", VA = "0x1849D07A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DHBOGECJPEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x630FD90", Offset = "0x630E390", VA = "0x18630FD90")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D2AE20", Offset = "0x3D29420", VA = "0x183D2AE20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public PJNMIHPNMGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x5108750", Offset = "0x5106D50", VA = "0x185108750")]
			internal int BDPKHKDEIKB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x5108790", Offset = "0x5106D90", VA = "0x185108790")]
			internal void CIEHMGFKHCM(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			internal string LAJKHLOJCBO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x5108AC0", Offset = "0x51070C0", VA = "0x185108AC0")]
			[AsyncStateMachine(typeof(PAIFOJMLBIA<>.PJNMIHPNMGM.<<CreatePortItemV2>b__3>d))]
			internal void DNMJGFKEFOH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x51089E0", Offset = "0x5106FE0", VA = "0x1851089E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool BDACDICJDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "138")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool LHLODOLAMFG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "139")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool HCDEMMHOAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override AAFGLNNJOHN<IBLJEHJLOFH>? KCLMIPMJJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x50D8BA0", Offset = "0x50D71A0", VA = "0x1850D8BA0", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override AAFGLNNJOHN<FANPJMFIOIH>? GGAOKAAECHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x50D8E50", Offset = "0x50D7450", VA = "0x1850D8E50", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>>? MLLAGLOBHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x50D8C50", Offset = "0x50D7250", VA = "0x1850D8C50", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50D8980", Offset = "0x50D6F80", VA = "0x1850D8980")]
		public PAIFOJMLBIA(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "141")]
		protected virtual bool NGFOIDJBGEF(int FJDBFNNAAKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "142")]
		protected virtual bool JEOIMILNNJC(int FJDBFNNAAKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "143")]
		protected virtual bool HHBMIIKJKJP(int FJDBFNNAAKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "144")]
		protected virtual void APMLDJMKEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50D4D50", Offset = "0x50D3350", VA = "0x1850D4D50", Slot = "136")]
		public override bool FGCCEDEMFKF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x50D4000", Offset = "0x50D2600", VA = "0x1850D4000", Slot = "112")]
		[AsyncStateMachine(typeof(PAIFOJMLBIA<>.LNNKLAIJEHP))]
		public override Task<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> AAGHMFMMFIK(string OMOOEGOLALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x50D6CC0", Offset = "0x50D52C0", VA = "0x1850D6CC0", Slot = "113")]
		[AsyncStateMachine(typeof(PAIFOJMLBIA<>.POPKPPPCDJE))]
		public override Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LIBHMPMMKHI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x50D7040", Offset = "0x50D5640", VA = "0x1850D7040", Slot = "114")]
		public override void NMECNBPNFEN(AAFGLNNJOHN<FANPJMFIOIH> EAHKFAJBNDN, AAFGLNNJOHN<FANPJMFIOIH> MOCLCNOAHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x50D6DD0", Offset = "0x50D53D0", VA = "0x1850D6DD0", Slot = "115")]
		public override IEnumerable<GKPCJPMFCCN> MDJGDBMDLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x50D4C50", Offset = "0x50D3250", VA = "0x1850D4C50")]
		[AsyncStateMachine(typeof(PAIFOJMLBIA<>.OCPGKGNMGNA))]
		private Task<JOFBNNGKBOO<GIBAOAAAPHF, PPAGHPBHFJD>> CDFFEEBJOPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "145")]
		protected virtual bool KEKEJAIBHOF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "146")]
		protected virtual bool BABMPOOFJOO(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "147")]
		protected virtual bool COIONFGDFNP(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "148")]
		protected virtual bool HLBEOOAMFEI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "149")]
		protected virtual bool LPNJFMEBJEP(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int CJAOOJKODJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "150")]
		protected virtual bool OPDAKIEBJPC(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int CJAOOJKODJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "151")]
		protected virtual bool EMLDBMCINLO(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int FDBDHBKHPNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "152")]
		protected virtual bool ACBEOEAGCLG(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int FDBDHBKHPNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "153")]
		protected virtual bool FDNMEOFBLNI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int HAONHOPHKAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "154")]
		protected virtual bool ILKIFLCLNJE(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, int JLLMELNAAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x50D6990", Offset = "0x50D4F90", VA = "0x1850D6990", Slot = "155")]
		protected virtual List<NADGPPCKHDL> JNIBBLFJBPO(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "156")]
		protected virtual void GGEIIJCCBJF(JNIHAMPHLFB BFJOGMMEGHN, MAGDHBMCIOD HFOGNBBNAHB, BCINBNEJLKM LGLGJHFKMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x50D4DF0", Offset = "0x50D33F0", VA = "0x1850D4DF0", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x50D7250", Offset = "0x50D5850", VA = "0x1850D7250")]
		private MAGDHBMCIOD PHNLPLJHGPM(JNIHAMPHLFB BFJOGMMEGHN, BCINBNEJLKM LGLGJHFKMFK, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x50D5850", Offset = "0x50D3E50", VA = "0x1850D5850")]
		private List<PKCIAPNEFJF> HBFAKONKGGH(JNIHAMPHLFB BFJOGMMEGHN, BCINBNEJLKM LGLGJHFKMFK, MAGDHBMCIOD LHKJFNOFGLC, bool NLHKPNGOOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x50D4120", Offset = "0x50D2720", VA = "0x1850D4120")]
		private List<PKCIAPNEFJF> BBNHEEEFBLA(JNIHAMPHLFB BFJOGMMEGHN, BCINBNEJLKM LGLGJHFKMFK, FPMPKFDBAJK GMEMHACONIH, bool NLHKPNGOOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x50D4A60", Offset = "0x50D3060", VA = "0x1850D4A60")]
		private NADGPPCKHDL BFDBCJOCFDG(List<NADGPPCKHDL> LNHHHADKGMM, FPMPKFDBAJK GMEMHACONIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C30", Offset = "0x50D5230", VA = "0x1850D6C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KLIMMPELILI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x254FB10", Offset = "0x254E110", VA = "0x18254FB10")]
			internal int MNLGAMGLBJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x254FA80", Offset = "0x254E080", VA = "0x18254FA80")]
			internal void FHAIOPDBBKM(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xEE1450", Offset = "0xEDFA50", VA = "0x180EE1450", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2550160", Offset = "0x254E760", VA = "0x182550160")]
		public MMILCOBCECM(ANALLCGONGO DFLGEEGCPMI, GOPPKFCBKIB HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x254FFA0", Offset = "0x254E5A0", VA = "0x18254FFA0", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public ILFNADIFHLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x25405F0", Offset = "0x253EBF0", VA = "0x1825405F0")]
			internal int ANPGGHIJLED()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2540670", Offset = "0x253EC70", VA = "0x182540670")]
			internal void KACMPDEBBLL(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2540590", Offset = "0x253EB90", VA = "0x182540590")]
		public IIGCEKEAOIP(ANALLCGONGO DFLGEEGCPMI, HPMDMHPCLBB AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2540350", Offset = "0x253E950", VA = "0x182540350", Slot = "138")]
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
			[Cpp2IlInjected.Address(RVA = "0xC267F0", Offset = "0xC24DF0", VA = "0x180C267F0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2537F70", Offset = "0x2536570", VA = "0x182537F70")]
		public BDCHGPHCKEM(ANALLCGONGO DFLGEEGCPMI, CCCLAMOLEGI HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public JCOMDDBKDAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x254A9E0", Offset = "0x2548FE0", VA = "0x18254A9E0")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2548920", Offset = "0x2546F20", VA = "0x182548920")]
			internal void FHAIOPDBBKM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x25419A0", Offset = "0x253FFA0", VA = "0x1825419A0")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x254A820", Offset = "0x2548E20", VA = "0x18254A820")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x25484E0", Offset = "0x2546AE0", VA = "0x1825484E0")]
			internal void EOFCJLIFDNB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x254B2E0", Offset = "0x25498E0", VA = "0x18254B2E0")]
			internal bool PAFFPCEOHAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2542050", Offset = "0x2540650", VA = "0x182542050")]
			internal bool DJEPEOCLBMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x254A7C0", Offset = "0x2548DC0", VA = "0x18254A7C0")]
			internal void MHGKDMAEKNL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x254A210", Offset = "0x2548810", VA = "0x18254A210")]
			internal bool LENJCKCPMFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2549640", Offset = "0x2547C40", VA = "0x182549640")]
			internal bool IGLDHMCDLKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x254AFD0", Offset = "0x25495D0", VA = "0x18254AFD0")]
			internal void OBIOHKPKDLM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x254B380", Offset = "0x2549980", VA = "0x18254B380")]
			internal bool PDGPMHDKFCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x254A5E0", Offset = "0x2548BE0", VA = "0x18254A5E0")]
			internal bool MDGJJBACGEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x254AF30", Offset = "0x2549530", VA = "0x18254AF30")]
			internal bool NPJPOPKEGFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x254AB30", Offset = "0x2549130", VA = "0x18254AB30")]
			internal bool NHIAAPBHBBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x25422D0", Offset = "0x25408D0", VA = "0x1825422D0")]
			internal bool EFHKDHJIKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2541950", Offset = "0x253FF50", VA = "0x182541950")]
			internal bool CFCJCCHJDEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2541CE0", Offset = "0x25402E0", VA = "0x182541CE0")]
			internal bool DBJCFBKOBML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x25417A0", Offset = "0x253FDA0", VA = "0x1825417A0")]
			internal bool CAOJMOPFBEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2549C30", Offset = "0x2548230", VA = "0x182549C30")]
			internal bool KCDHGPAMGND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2548B30", Offset = "0x2547130", VA = "0x182548B30")]
			internal void FLDEBBCNFBN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2541F40", Offset = "0x2540540", VA = "0x182541F40")]
			internal bool DHJMILALOHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x25411B0", Offset = "0x253F7B0", VA = "0x1825411B0")]
			internal bool AHPEODDEBKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2549250", Offset = "0x2547850", VA = "0x182549250")]
			internal bool HNBIMCMNDKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2549790", Offset = "0x2547D90", VA = "0x182549790")]
			internal bool IOLLDEJMLKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x254AC20", Offset = "0x2549220", VA = "0x18254AC20")]
			internal bool NKBHOPJGHPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2549400", Offset = "0x2547A00", VA = "0x182549400")]
			internal bool IACHLJHJMKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2549360", Offset = "0x2547960", VA = "0x182549360")]
			internal bool HPJKGIAPNJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2541160", Offset = "0x253F760", VA = "0x182541160")]
			internal bool AHNNBNADIKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x254AA30", Offset = "0x2549030", VA = "0x18254AA30")]
			internal void MOGIMGLBHHC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2540BB0", Offset = "0x253F1B0", VA = "0x182540BB0")]
			internal bool AADHAJACJML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2549FC0", Offset = "0x25485C0", VA = "0x182549FC0")]
			internal bool KMHLNONDDGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2548ED0", Offset = "0x25474D0", VA = "0x182548ED0")]
			internal void GOILPAKGPBD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2549110", Offset = "0x2547710", VA = "0x182549110")]
			internal bool HJKMDCCGFJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x254B330", Offset = "0x2549930", VA = "0x18254B330")]
			internal bool PDBDKMIOCGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2541EE0", Offset = "0x25404E0", VA = "0x182541EE0")]
			internal void DGGAOACIFDH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2542370", Offset = "0x2540970", VA = "0x182542370")]
			internal List<PKCIAPNEFJF> EJMLGFMGLFM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2548650", Offset = "0x2546C50", VA = "0x182548650")]
			internal bool EOLHINCMNLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x25497E0", Offset = "0x2547DE0", VA = "0x1825497E0")]
			internal int IPIFIIBFAIH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2548CD0", Offset = "0x25472D0", VA = "0x182548CD0")]
			internal void GEFGMGEOBIE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x25489D0", Offset = "0x2546FD0", VA = "0x1825489D0")]
			internal bool FILDGGMPAKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2541400", Offset = "0x253FA00", VA = "0x182541400")]
			internal bool BELHECJFCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2548BE0", Offset = "0x25471E0", VA = "0x182548BE0")]
			internal bool FMGJEADJGFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2541A40", Offset = "0x2540040", VA = "0x182541A40")]
			internal int CHNOPPACJEI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x254B170", Offset = "0x2549770", VA = "0x18254B170")]
			internal void OHBDCCJCFIO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x25421E0", Offset = "0x25407E0", VA = "0x1825421E0")]
			internal bool EDFEABDGBKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2548B90", Offset = "0x2547190", VA = "0x182548B90")]
			internal bool FLKAONCFKHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2548AE0", Offset = "0x25470E0", VA = "0x182548AE0")]
			internal bool FLBOBGDLHJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x2541540", Offset = "0x253FB40", VA = "0x182541540")]
			internal bool BNFEGNCAKIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2548830", Offset = "0x2546E30", VA = "0x182548830")]
			internal bool FCJDGEAHHGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2549740", Offset = "0x2547D40", VA = "0x182549740")]
			internal bool INOKCGIGCJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2549B30", Offset = "0x2548130", VA = "0x182549B30")]
			internal string JOGEIDNKHPO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2549AC0", Offset = "0x25480C0", VA = "0x182549AC0")]
			internal void JMMMFOBFDOC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x254AA90", Offset = "0x2549090", VA = "0x18254AA90")]
			internal int MPMEGEIBAAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2541590", Offset = "0x253FB90", VA = "0x182541590")]
			internal void BNINDOKNBLC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x25414A0", Offset = "0x253FAA0", VA = "0x1825414A0")]
			internal bool BLMBAALCPHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x25495A0", Offset = "0x2547BA0", VA = "0x1825495A0")]
			internal bool IFCBMPAFIIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2541260", Offset = "0x253F860", VA = "0x182541260")]
			internal bool ALDPFEGEPFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x25418B0", Offset = "0x253FEB0", VA = "0x1825418B0")]
			internal float CEIGIMDMDFL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x254B3D0", Offset = "0x25499D0", VA = "0x18254B3D0")]
			internal void PFALMAMNIAJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x25415F0", Offset = "0x253FBF0", VA = "0x1825415F0")]
			internal bool BNMIMHCNLEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2541D30", Offset = "0x2540330", VA = "0x182541D30")]
			internal bool DCEDIABAMGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x25486A0", Offset = "0x2546CA0", VA = "0x1825486A0")]
			internal bool EONECAFNEMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x25491B0", Offset = "0x25477B0", VA = "0x1825491B0")]
			internal bool HLKPEGJDBPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x254AD80", Offset = "0x2549380", VA = "0x18254AD80")]
			internal bool NMHMLENGEKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2542140", Offset = "0x2540740", VA = "0x182542140")]
			internal bool DNMCJPKGPBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2540C50", Offset = "0x253F250", VA = "0x182540C50")]
			internal void ADFKFPLDGHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2549200", Offset = "0x2547800", VA = "0x182549200")]
			internal string HLNANALFCKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2549E60", Offset = "0x2548460", VA = "0x182549E60")]
			internal void KLBENAKFKFC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2549E10", Offset = "0x2548410", VA = "0x182549E10")]
			internal bool KLAHLLBJHFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2541E40", Offset = "0x2540440", VA = "0x182541E40")]
			internal bool DFLKNELDINK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2549830", Offset = "0x2547E30", VA = "0x182549830")]
			internal bool JANAEELBOJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x254B6F0", Offset = "0x2549CF0", VA = "0x18254B6F0")]
			internal void PPPEILOOCHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2549020", Offset = "0x2547620", VA = "0x182549020")]
			internal bool HGKDNHBNGOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2541C40", Offset = "0x2540240", VA = "0x182541C40")]
			internal bool CPNBGOJNIOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2542190", Offset = "0x2540790", VA = "0x182542190")]
			internal bool DPGOAFGMMEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2541640", Offset = "0x253FC40", VA = "0x182541640")]
			internal bool BOPKGPGEPMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2549450", Offset = "0x2547A50", VA = "0x182549450")]
			internal void IAOJGMAGGKH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x254A590", Offset = "0x2548B90", VA = "0x18254A590")]
			internal bool MBDCIABHMKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x25486F0", Offset = "0x2546CF0", VA = "0x1825486F0")]
			internal bool EPJANIPLPFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2541450", Offset = "0x253FA50", VA = "0x182541450")]
			internal bool BLKONHAPONP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x254B4A0", Offset = "0x2549AA0", VA = "0x18254B4A0")]
			internal bool PGJOAAOFJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2541200", Offset = "0x253F800", VA = "0x182541200")]
			internal void AICGPGJADIL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x254A720", Offset = "0x2548D20", VA = "0x18254A720")]
			internal bool MEMBFELHDMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x254A440", Offset = "0x2548A40", VA = "0x18254A440")]
			internal bool LOLKIHBACCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x254A870", Offset = "0x2548E70", VA = "0x18254A870")]
			internal bool MIKADMICEBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x254AD30", Offset = "0x2549330", VA = "0x18254AD30")]
			internal bool NMCANBFKPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2541FE0", Offset = "0x25405E0", VA = "0x182541FE0")]
			internal object DJCGLBAOBGI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x254A950", Offset = "0x2548F50", VA = "0x18254A950")]
			internal void MNBGOJPPBKD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2549070", Offset = "0x2547670", VA = "0x182549070")]
			internal bool HGMNPKHPNMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x254B650", Offset = "0x2549C50", VA = "0x18254B650")]
			internal bool PNODIHFFGDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x254AB80", Offset = "0x2549180", VA = "0x18254AB80")]
			internal int NIDHPEHLANH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x254A490", Offset = "0x2548A90", VA = "0x18254A490")]
			internal void LOPBKPKJHCN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2548FD0", Offset = "0x25475D0", VA = "0x182548FD0")]
			internal bool HBDDLMLEPEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x25498D0", Offset = "0x2547ED0", VA = "0x1825498D0")]
			internal bool JCOEDIDJIJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x254B080", Offset = "0x2549680", VA = "0x18254B080")]
			internal int ODGLNBBOKBN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x25417F0", Offset = "0x253FDF0", VA = "0x1825417F0")]
			internal void CBAAGKKAGKI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2549690", Offset = "0x2547C90", VA = "0x182549690")]
			internal bool IIJNHBPPAPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2548D30", Offset = "0x2547330", VA = "0x182548D30")]
			internal bool GFMCJMKJDHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x254AE20", Offset = "0x2549420", VA = "0x18254AE20")]
			internal bool NOAIMJFDHEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2548600", Offset = "0x2546C00", VA = "0x182548600")]
			internal int EOKNOBGCBCP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2541060", Offset = "0x253F660", VA = "0x182541060")]
			internal void ADLBAPDJNKC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2549C80", Offset = "0x2548280", VA = "0x182549C80")]
			internal bool KDEEJCEFGPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2541900", Offset = "0x253FF00", VA = "0x182541900")]
			internal bool CEINCODHIKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2548740", Offset = "0x2546D40", VA = "0x182548740")]
			internal bool FBMDEPOALOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x25492F0", Offset = "0x25478F0", VA = "0x1825492F0")]
			internal object HOHEEIGLCLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x254A8C0", Offset = "0x2548EC0", VA = "0x18254A8C0")]
			internal void MMMADGNGJDB(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x254A260", Offset = "0x2548860", VA = "0x18254A260")]
			internal bool LEOEEIGGJBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2548D80", Offset = "0x2547380", VA = "0x182548D80")]
			internal bool GIADPBHJICM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x254B1D0", Offset = "0x25497D0", VA = "0x18254B1D0")]
			internal object OHNPNJMFEGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2549A30", Offset = "0x2548030", VA = "0x182549A30")]
			internal void JMFGCOJGPOH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2542320", Offset = "0x2540920", VA = "0x182542320")]
			internal bool EGPMNFILNLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x254A630", Offset = "0x2548C30", VA = "0x18254A630")]
			internal int MDOEFMIFBPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2541300", Offset = "0x253F900", VA = "0x182541300")]
			internal void AOPMAFGHPLP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x254ACE0", Offset = "0x25492E0", VA = "0x18254ACE0")]
			internal bool NLACLCMMOLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2549D20", Offset = "0x2548320", VA = "0x182549D20")]
			internal bool KHJILCCCDLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2549D70", Offset = "0x2548370", VA = "0x182549D70")]
			internal bool KHLBPBBDMFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x25414F0", Offset = "0x253FAF0", VA = "0x1825414F0")]
			internal int BMBAEPMEOMA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x25496E0", Offset = "0x2547CE0", VA = "0x1825496E0")]
			internal void IKMIGNLFJBE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x25493B0", Offset = "0x25479B0", VA = "0x1825493B0")]
			internal bool IAAABBDBMNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2541BF0", Offset = "0x25401F0", VA = "0x182541BF0")]
			internal bool CPMPHAPGENO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x254B0D0", Offset = "0x25496D0", VA = "0x18254B0D0")]
			internal bool OEEGDELPAFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x254B600", Offset = "0x2549C00", VA = "0x18254B600")]
			internal float PNCBBEIILCO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x254A300", Offset = "0x2548900", VA = "0x18254A300")]
			internal void LGHKEKLHKAA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x254A060", Offset = "0x2548660", VA = "0x18254A060")]
			internal bool KONHJHPIMAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x254A680", Offset = "0x2548C80", VA = "0x18254A680")]
			internal bool MDPHODPKPOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2548980", Offset = "0x2546F80", VA = "0x182548980")]
			internal bool FIFIDLKCLFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2549ED0", Offset = "0x25484D0", VA = "0x182549ED0")]
			internal float KLBIJKDIOMD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2541850", Offset = "0x253FE50", VA = "0x182541850")]
			internal void CDCCOJGHKHH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2549160", Offset = "0x2547760", VA = "0x182549160")]
			internal bool HKPMKOLEDND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x25420A0", Offset = "0x25406A0", VA = "0x1825420A0")]
			internal bool DKEBOCBKIEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2549500", Offset = "0x2547B00", VA = "0x182549500")]
			internal string ICPIDJCMOJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2541B30", Offset = "0x2540130", VA = "0x182541B30")]
			internal void CMAHMBKBONF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2541C90", Offset = "0x2540290", VA = "0x182541C90")]
			internal bool CPNMCAMKNAP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2541750", Offset = "0x253FD50", VA = "0x182541750")]
			internal bool CANBCKCPKAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x254ABD0", Offset = "0x25491D0", VA = "0x18254ABD0")]
			internal bool NKANCDEELMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x254B6A0", Offset = "0x2549CA0", VA = "0x18254B6A0")]
			internal bool POCPCBPKKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x25419F0", Offset = "0x253FFF0", VA = "0x1825419F0")]
			internal string CFJJIFJFEEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x254AE70", Offset = "0x2549470", VA = "0x18254AE70")]
			internal void NONGBMEKFOA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2548490", Offset = "0x2546A90", VA = "0x182548490")]
			internal bool ENODGILEBCL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2541360", Offset = "0x253F960", VA = "0x182541360")]
			internal bool BABNMNFDCCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x254B120", Offset = "0x2549720", VA = "0x18254B120")]
			internal bool OGFPFDGIOAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x25488D0", Offset = "0x2546ED0", VA = "0x1825488D0")]
			internal bool FFLBBDPHBPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x25494B0", Offset = "0x2547AB0", VA = "0x1825494B0")]
			internal string ICGDEDDGCND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x254B540", Offset = "0x2549B40", VA = "0x18254B540")]
			internal void PKGGIHLJIEK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2548540", Offset = "0x2546B40", VA = "0x182548540")]
			internal bool EOFHMBOLHJB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x254B240", Offset = "0x2549840", VA = "0x18254B240")]
			internal bool OMCAPLDJGID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2548C30", Offset = "0x2547230", VA = "0x182548C30")]
			internal bool FNFKJFBMNNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2548880", Offset = "0x2546E80", VA = "0x182548880")]
			internal bool FDICEDDHKJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2549880", Offset = "0x2547E80", VA = "0x182549880")]
			internal string JCLDFILGABP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x254A0B0", Offset = "0x25486B0", VA = "0x18254A0B0")]
			internal void LBFIDGDFCED(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x254B290", Offset = "0x2549890", VA = "0x18254B290")]
			internal bool OMPGFEPOGIC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x25499E0", Offset = "0x2547FE0", VA = "0x1825499E0")]
			internal bool JLBBNNDOMOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x25495F0", Offset = "0x2547BF0", VA = "0x1825495F0")]
			internal bool IFDFNOMKKIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x2540C00", Offset = "0x253F200", VA = "0x182540C00")]
			internal bool ABPPODFJAOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2541BA0", Offset = "0x25401A0", VA = "0x182541BA0")]
			internal string CPANNPCBBKC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x254A3D0", Offset = "0x25489D0", VA = "0x18254A3D0")]
			internal void LODHLPIKPFK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x25410C0", Offset = "0x253F6C0", VA = "0x1825410C0")]
			internal bool AEMENFBAEHF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2541F90", Offset = "0x2540590", VA = "0x182541F90")]
			internal bool DIDPJNCLHID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2549F20", Offset = "0x2548520", VA = "0x182549F20")]
			internal bool KLNAJIHDPMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2541AE0", Offset = "0x25400E0", VA = "0x182541AE0")]
			internal bool CLLGLBFMFKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x254B4F0", Offset = "0x2549AF0", VA = "0x18254B4F0")]
			internal string PJGNMANEEJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2549920", Offset = "0x2547F20", VA = "0x182549920")]
			internal void JIFMKKLJEBG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x254B030", Offset = "0x2549630", VA = "0x18254B030")]
			internal bool OCBOJJDIBML(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2541D80", Offset = "0x2540380", VA = "0x182541D80")]
			internal bool DEJGALFMGCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x254A540", Offset = "0x2548B40", VA = "0x18254A540")]
			internal bool MALLOHHMINK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x254A120", Offset = "0x2548720", VA = "0x18254A120")]
			internal bool LCNEJAGJHON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x25412B0", Offset = "0x253F8B0", VA = "0x1825412B0")]
			internal string AOHBPEJBEGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2548590", Offset = "0x2546B90", VA = "0x182548590")]
			internal void EOFLJMNLDBG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2549CD0", Offset = "0x25482D0", VA = "0x182549CD0")]
			internal bool KDHJGEEEGOG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2541E90", Offset = "0x2540490", VA = "0x182541E90")]
			internal bool DFOLDKCOACL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2549DC0", Offset = "0x25483C0", VA = "0x182549DC0")]
			internal bool KKMANMKAHNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x25487E0", Offset = "0x2546DE0", VA = "0x1825487E0")]
			internal bool FCHNKPCOMGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2541690", Offset = "0x253FC90", VA = "0x182541690")]
			internal string BOPPENOILHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x25416E0", Offset = "0x253FCE0", VA = "0x1825416E0")]
			internal void CAABIIAJMKF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x254AAE0", Offset = "0x25490E0", VA = "0x18254AAE0")]
			internal bool NHHPMLIFGIO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x254A770", Offset = "0x2548D70", VA = "0x18254A770")]
			internal bool MFBPGCOFOOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2548A90", Offset = "0x2547090", VA = "0x182548A90")]
			internal bool FLAGDNFHICD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x25492A0", Offset = "0x25478A0", VA = "0x1825492A0")]
			internal bool HNMKPNHBHLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2542230", Offset = "0x2540830", VA = "0x182542230")]
			internal string EEAHOOAKNGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2541DD0", Offset = "0x25403D0", VA = "0x182541DD0")]
			internal void DFENFCDMONC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x254AEE0", Offset = "0x25494E0", VA = "0x18254AEE0")]
			internal bool NPFAIJDLDPF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2541110", Offset = "0x253F710", VA = "0x182541110")]
			internal bool AHCNDNMDKMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x254A6D0", Offset = "0x2548CD0", VA = "0x18254A6D0")]
			internal bool MDPHPMGMCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x2541010", Offset = "0x253F610", VA = "0x182541010")]
			internal bool ADGJDDEGFLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x254ADD0", Offset = "0x25493D0", VA = "0x18254ADD0")]
			internal string NMOBHMFBGIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x254A360", Offset = "0x2548960", VA = "0x18254A360")]
			internal void LGOLFIAFJOJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x2549990", Offset = "0x2547F90", VA = "0x182549990")]
			internal bool JIFOALHGKFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2548C80", Offset = "0x2547280", VA = "0x182548C80")]
			internal bool GBAMPDELDMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x254B5B0", Offset = "0x2549BB0", VA = "0x18254B5B0")]
			internal bool PLFPMINPDMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2549550", Offset = "0x2547B50", VA = "0x182549550")]
			internal string IELPEPOKACI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x254AC70", Offset = "0x2549270", VA = "0x18254AC70")]
			internal void NKIHDJABDNM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2548F80", Offset = "0x2547580", VA = "0x182548F80")]
			internal bool HANLPLNGEIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x2548E20", Offset = "0x2547420", VA = "0x182548E20")]
			internal bool GMGPAJFDNIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x254A010", Offset = "0x2548610", VA = "0x18254A010")]
			internal bool KOJJILMDAON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x254AF80", Offset = "0x2549580", VA = "0x18254AF80")]
			internal string OABICHGMEIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2548A20", Offset = "0x2547020", VA = "0x182548A20")]
			internal void FIMDBEELPKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2542280", Offset = "0x2540880", VA = "0x182542280")]
			internal bool EFFKHLIDPML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x25413B0", Offset = "0x253F9B0", VA = "0x1825413B0")]
			internal bool BCIKKIJKOEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2548F30", Offset = "0x2547530", VA = "0x182548F30")]
			internal bool HADPGCEADMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x2548790", Offset = "0x2546D90", VA = "0x182548790")]
			internal string FCDBEHJIGJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x254B430", Offset = "0x2549A30", VA = "0x18254B430")]
			internal void PGDDEKOOFOK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x254A170", Offset = "0x2548770", VA = "0x18254A170")]
			internal bool LCPGDOCCGMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2548DD0", Offset = "0x25473D0", VA = "0x182548DD0")]
			internal bool GJNKMACLBMJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x2549F70", Offset = "0x2548570", VA = "0x182549F70")]
			internal float KMCPLNOEGPB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2548E70", Offset = "0x2547470", VA = "0x182548E70")]
			internal void GNLGICDFCIE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x25420F0", Offset = "0x25406F0", VA = "0x1825420F0")]
			internal bool DLDDINPACAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x254A1C0", Offset = "0x25487C0", VA = "0x18254A1C0")]
			internal bool LDGONIMNAAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2541A90", Offset = "0x2540090", VA = "0x182541A90")]
			internal bool CHPHGBJLPLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x2549B80", Offset = "0x2548180", VA = "0x182549B80")]
			internal int JPAJLHLDKPI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2549BD0", Offset = "0x25481D0", VA = "0x182549BD0")]
			internal void JPDIINHGKFL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x254A2B0", Offset = "0x25488B0", VA = "0x18254A2B0")]
			internal bool LFBNFCKNEOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x254A4F0", Offset = "0x2548AF0", VA = "0x18254A4F0")]
			internal bool MAECLMOEADD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x25490C0", Offset = "0x25476C0", VA = "0x1825490C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public JGKDIJHBKEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x254BC60", Offset = "0x254A260", VA = "0x18254BC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public FFJHFOJLNKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x253C420", Offset = "0x253AA20", VA = "0x18253C420")]
			internal bool JBEPBPHNEEH(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly HEJCMKDLMJK AIHKIBCMCIN;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x253E270", Offset = "0x253C870", VA = "0x18253E270")]
		public FJEOLEMFKCG(ANALLCGONGO DFLGEEGCPMI, DHCDMFPPKPL HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x253C4A0", Offset = "0x253AAA0", VA = "0x18253C4A0", Slot = "132")]
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
				[Cpp2IlInjected.Address(RVA = "0x2570300", Offset = "0x256E900", VA = "0x182570300", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public LEDIEPMGOMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x254FCC0", Offset = "0x254E2C0", VA = "0x18254FCC0")]
			internal string MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x254FB60", Offset = "0x254E160", VA = "0x18254FB60")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FHAIOPDBBKM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x254FD10", Offset = "0x254E310", VA = "0x18254FD10")]
			internal int MNPFLPCHHNE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x254FC30", Offset = "0x254E230", VA = "0x18254FC30")]
			internal void JFBADLEIDLK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xEE1450", Offset = "0xEDFA50", VA = "0x180EE1450", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x253EA30", Offset = "0x253D030", VA = "0x18253EA30")]
		public FOLFMBNMOBE(ANALLCGONGO DFLGEEGCPMI, OHDHMGBBLLN AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x253E6E0", Offset = "0x253CCE0", VA = "0x18253E6E0", Slot = "132")]
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
				[Cpp2IlInjected.Address(RVA = "0x256FFC0", Offset = "0x256E5C0", VA = "0x18256FFC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x2570610", Offset = "0x256EC10", VA = "0x182570610", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KODAKCKHIPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x256AA50", Offset = "0x2569050", VA = "0x18256AA50")]
			internal string MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x256A720", Offset = "0x2568D20", VA = "0x18256A720")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FHAIOPDBBKM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x256AAA0", Offset = "0x25690A0", VA = "0x18256AAA0")]
			internal int MNPFLPCHHNE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x256A7F0", Offset = "0x2568DF0", VA = "0x18256A7F0")]
			internal void JFBADLEIDLK(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x256A4B0", Offset = "0x2568AB0", VA = "0x18256A4B0")]
			internal string CFFDGMAAICP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x256A980", Offset = "0x2568F80", VA = "0x18256A980")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void MHLJJEBILLG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x256A640", Offset = "0x2568C40", VA = "0x18256A640")]
			internal bool EOFCJLIFDNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x256A690", Offset = "0x2568C90", VA = "0x18256A690")]
			internal void FFNOGLAOMOO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x256A5F0", Offset = "0x2568BF0", VA = "0x18256A5F0")]
			internal bool EHAKKILEBCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x256AAF0", Offset = "0x25690F0", VA = "0x18256AAF0")]
			internal void PAFFPCEOHAP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x256A5A0", Offset = "0x2568BA0", VA = "0x18256A5A0")]
			internal float DJEPEOCLBMP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x256A8F0", Offset = "0x2568EF0", VA = "0x18256A8F0")]
			internal void MHGKDMAEKNL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x256AB80", Offset = "0x2569180", VA = "0x18256AB80")]
			internal int PAKGKIOGBCB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x256A500", Offset = "0x2568B00", VA = "0x18256A500")]
			internal void DGCIBDNEBDB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x256A880", Offset = "0x2568E80", VA = "0x18256A880")]
			internal bool LENJCKCPMFL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xEE1450", Offset = "0xEDFA50", VA = "0x180EE1450", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x256FA60", Offset = "0x256E060", VA = "0x18256FA60")]
		public PGBDONLMNJD(ANALLCGONGO DFLGEEGCPMI, HNPGMCGFDCI HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x256F010", Offset = "0x256D610", VA = "0x18256F010", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public LMHGGKLGFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x256B3B0", Offset = "0x25699B0", VA = "0x18256B3B0")]
			internal Dictionary<string, OEKJFHFPCFG> MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x256B2E0", Offset = "0x25698E0", VA = "0x18256B2E0")]
			internal int FHAIOPDBBKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x256B450", Offset = "0x2569A50", VA = "0x18256B450")]
			internal void MNPFLPCHHNE(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x256B330", Offset = "0x2569930", VA = "0x18256B330")]
			internal bool JFBADLEIDLK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xEE1450", Offset = "0xEDFA50", VA = "0x180EE1450", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x256AEB0", Offset = "0x25694B0", VA = "0x18256AEB0")]
		public KOFCMIMKMOB(ANALLCGONGO DFLGEEGCPMI, BKNHCNOPJME AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x256ABE0", Offset = "0x25691E0", VA = "0x18256ABE0", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public EBDDKKNHFMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x255AE50", Offset = "0x2559450", VA = "0x18255AE50")]
			internal void MNLGAMGLBJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xEE1450", Offset = "0xEDFA50", VA = "0x180EE1450", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x255DE10", Offset = "0x255C410", VA = "0x18255DE10")]
		public FJNFGBFAIJL(ANALLCGONGO DFLGEEGCPMI, FFOLJPEKHGD AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x255DC90", Offset = "0x255C290", VA = "0x18255DC90", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override MAALIMGMDEF? IBIOLNAMFGP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x5A72F20", Offset = "0x5A71520", VA = "0x185A72F20", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool OJGJGEDGDHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x5A72F90", Offset = "0x5A71590", VA = "0x185A72F90", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC39E30", Offset = "0xC38430", VA = "0x180C39E30", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x531CA20", Offset = "0x531B020", VA = "0x18531CA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public MKECEANOLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x256C1D0", Offset = "0x256A7D0", VA = "0x18256C1D0")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x256C100", Offset = "0x256A700", VA = "0x18256C100")]
			internal void FHAIOPDBBKM(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x256C240", Offset = "0x256A840", VA = "0x18256C240")]
			internal void MNPFLPCHHNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? IMAMPLGCAMB;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x25698C0", Offset = "0x2567EC0", VA = "0x1825698C0")]
		public KAFKBOJEFPO(ANALLCGONGO DFLGEEGCPMI, DBPIEFONOFG HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2569310", Offset = "0x2567910", VA = "0x182569310", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xB49FB0", Offset = "0xB485B0", VA = "0x180B49FB0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x25661F0", Offset = "0x25647F0", VA = "0x1825661F0")]
		public IBIPMNBJDAD(ANALLCGONGO DFLGEEGCPMI, GMIGJOPKPNA HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xA69000", Offset = "0xA67600", VA = "0x180A69000", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2565DC0", Offset = "0x25643C0", VA = "0x182565DC0")]
		public HLDBMNEDGKG(ANALLCGONGO DFLGEEGCPMI, GOHNFKCLOKG HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "124")]
		protected override bool ODGPFOGEFMK(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57410", Offset = "0xA55A10", VA = "0x180A57410", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x2565290", Offset = "0x2563890", VA = "0x182565290", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2565220", Offset = "0x2563820", VA = "0x182565220")]
		public GHLKJCMFBOO(ANALLCGONGO DFLGEEGCPMI, ELKLOGKINHK HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F6D0", Offset = "0xA6DCD0", VA = "0x180A6F6D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x256DB80", Offset = "0x256C180", VA = "0x18256DB80", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected override bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x256DB10", Offset = "0x256C110", VA = "0x18256DB10")]
		public OKPMDBMGAOL(ANALLCGONGO DFLGEEGCPMI, MLALODAFHBC HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public OIGGBBDLNBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x256D540", Offset = "0x256BB40", VA = "0x18256D540")]
			internal float ANPGGHIJLED()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x256D5C0", Offset = "0x256BBC0", VA = "0x18256D5C0")]
			internal void KACMPDEBBLL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x255BF30", Offset = "0x255A530", VA = "0x18255BF30")]
		public EEOEACFDIJI(ANALLCGONGO DFLGEEGCPMI, FAHNLAPEDKJ AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x255BCB0", Offset = "0x255A2B0", VA = "0x18255BCB0", Slot = "138")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public PJHCGFKDMAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x256FC00", Offset = "0x256E200", VA = "0x18256FC00")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x256FAD0", Offset = "0x256E0D0", VA = "0x18256FAD0")]
			internal void FHAIOPDBBKM(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x255ADE0", Offset = "0x25593E0", VA = "0x18255ADE0")]
		public EBBMHOBOBNL(ANALLCGONGO DFLGEEGCPMI, IMPCLAPCEAI AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x255AB30", Offset = "0x2559130", VA = "0x18255AB30", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public EKFFAKBFIMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x255C4B0", Offset = "0x255AAB0", VA = "0x18255C4B0")]
			internal object MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x255C130", Offset = "0x255A730", VA = "0x18255C130")]
			internal bool FFNOGLAOMOO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x255C1B0", Offset = "0x255A7B0", VA = "0x18255C1B0")]
			internal void FHAIOPDBBKM(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x255C5E0", Offset = "0x255ABE0", VA = "0x18255C5E0")]
			internal string MNPFLPCHHNE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x255C410", Offset = "0x255AA10", VA = "0x18255C410")]
			internal IReadOnlyList<object> JFBADLEIDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x255BF90", Offset = "0x255A590", VA = "0x18255BF90")]
			internal bool CFFDGMAAICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x255C460", Offset = "0x255AA60", VA = "0x18255C460")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x255C000", Offset = "0x255A600", VA = "0x18255C000")]
			internal void EOFCJLIFDNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x256BE40", Offset = "0x256A440", VA = "0x18256BE40")]
		public MGDBNEMBMIF(ANALLCGONGO DFLGEEGCPMI, NPBJKGIEAFL AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x256B630", Offset = "0x2569C30", VA = "0x18256B630", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xC25A00", Offset = "0xC24000", VA = "0x180C25A00", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x256D660", Offset = "0x256BC60", VA = "0x18256D660")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public PDICMHIBBCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x256EEF0", Offset = "0x256D4F0", VA = "0x18256EEF0")]
			internal int ANPGGHIJLED()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x256EF70", Offset = "0x256D570", VA = "0x18256EF70")]
			internal void KACMPDEBBLL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2554B50", Offset = "0x2553150", VA = "0x182554B50")]
		public BELNPEFMDNF(ANALLCGONGO DFLGEEGCPMI, KFIHFMLKPIM AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2554850", Offset = "0x2552E50", VA = "0x182554850", Slot = "138")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public KFOPFGIDGAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x256A460", Offset = "0x2568A60", VA = "0x18256A460")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x256A3D0", Offset = "0x25689D0", VA = "0x18256A3D0")]
			internal void FHAIOPDBBKM(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x256C090", Offset = "0x256A690", VA = "0x18256C090")]
		public MJMPNFAFJFA(ANALLCGONGO DFLGEEGCPMI, BLJJMKGMGAH AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x256BEB0", Offset = "0x256A4B0", VA = "0x18256BEB0", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public NOGKCHDGMFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x256CD10", Offset = "0x256B310", VA = "0x18256CD10")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x256CC80", Offset = "0x256B280", VA = "0x18256CC80")]
			internal void FHAIOPDBBKM(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2566440", Offset = "0x2564A40", VA = "0x182566440")]
		public ICHJOAACOLH(ANALLCGONGO DFLGEEGCPMI, FBGBCKOIOFJ AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2566260", Offset = "0x2564860", VA = "0x182566260", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public GIMBLGOEJKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2565370", Offset = "0x2563970", VA = "0x182565370")]
			internal int MNLGAMGLBJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x25652E0", Offset = "0x25638E0", VA = "0x1825652E0")]
			internal void FHAIOPDBBKM(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x256DF60", Offset = "0x256C560", VA = "0x18256DF60")]
		public ONJFLOLOGBB(ANALLCGONGO DFLGEEGCPMI, MKKLAFJCHLK AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x256DCF0", Offset = "0x256C2F0", VA = "0x18256DCF0", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2568E70", Offset = "0x2567470", VA = "0x182568E70")]
		public JNGKDEIEECG(ANALLCGONGO DFLGEEGCPMI, HGHIDGKPBDO AAMBBOLAGCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class HGJGMPLAIGN : KPJGEGMJNEL<ALJLKHOFDLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x255DE80", Offset = "0x255C480", VA = "0x18255DE80")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public OPAFBKCCMAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x5032FF0", Offset = "0x50315F0", VA = "0x185032FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C4B780", Offset = "0x5C49D80", VA = "0x185C4B780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E1AE40", Offset = "0x4E19440", VA = "0x184E1AE40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x4E1B0E0", Offset = "0x4E196E0", VA = "0x184E1B0E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x3D29BF0", Offset = "0x3D281F0", VA = "0x183D29BF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DKDBHJNNPPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			internal string CFDNAADKJFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			internal void GACLAEAFJCG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x631D840", Offset = "0x631BE40", VA = "0x18631D840")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public HAENLPOPGCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x45EA9C0", Offset = "0x45E8FC0", VA = "0x1845EA9C0")]
			internal bool FNLHPNKAODK(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x45EAAA0", Offset = "0x45E90A0", VA = "0x1845EAAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E3A320", Offset = "0x4E38920", VA = "0x184E3A320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4E3A6B0", Offset = "0x4E38CB0", VA = "0x184E3A6B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B3A100", Offset = "0x4B38700", VA = "0x184B3A100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected JMEEEIBMDBN JKFAMCEKGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x4B3B220", Offset = "0x4B39820", VA = "0x184B3B220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected TNode APHFGALDMDK
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x117DC80", Offset = "0x117C280", VA = "0x18117DC80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B3CA00", Offset = "0x4B3B000", VA = "0x184B3CA00", Slot = "6")]
			get
			{
				return default(AAFGLNNJOHN<GDEODHDOKBB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public object EJODNIKFKNF
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x40C8C20", Offset = "0x40C7220", VA = "0x1840C8C20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool CCGGJAPHJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int GKMLNPEPKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C660", Offset = "0x4B3AC60", VA = "0x184B3C660", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public MCFINBPPNLI DPCIPBBMKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C600", Offset = "0x4B3AC00", VA = "0x184B3C600", Slot = "10")]
			get
			{
				return default(MCFINBPPNLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string DGAKLLAFKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4B3CC00", Offset = "0x4B3B200", VA = "0x184B3CC00", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AAFGLNNJOHN<KINEADPEALH> KLPGJHBFBLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xCFF400", Offset = "0xCFDA00", VA = "0x180CFF400", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(AAFGLNNJOHN<KINEADPEALH>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xD01F40", Offset = "0xD00540", VA = "0x180D01F40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool BIMGKLHLGLC
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual BKPLPAFEPPD BODHKPCACPF
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xDC5E60", Offset = "0xDC4460", VA = "0x180DC5E60", Slot = "106")]
			get
			{
				return default(BKPLPAFEPPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool CBJHLOGFLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C370", Offset = "0x4B3A970", VA = "0x184B3C370", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool LDAMKENILBG
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C3D0", Offset = "0x4B3A9D0", VA = "0x184B3C3D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AIDNDMBGMDN
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C430", Offset = "0x4B3AA30", VA = "0x184B3C430", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int IPBGLIBLMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C9B0", Offset = "0x4B3AFB0", VA = "0x184B3C9B0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool ICBANNHIHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C7E0", Offset = "0x4B3ADE0", VA = "0x184B3C7E0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool IEPMFMICDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C540", Offset = "0x4B3AB40", VA = "0x184B3C540", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool HMILCBKCGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C4E0", Offset = "0x4B3AAE0", VA = "0x184B3C4E0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool NBNOCAPGFFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xD78760", Offset = "0xD76D60", VA = "0x180D78760", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x114D800", Offset = "0x114BE00", VA = "0x18114D800")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool MKILAGBOONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool LMGDAKEKODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C490", Offset = "0x4B3AA90", VA = "0x184B3C490", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool CFOOFEAFJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C710", Offset = "0x4B3AD10", VA = "0x184B3C710", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public DGJDOPKLGLD KOHIGCEHKOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C8F0", Offset = "0x4B3AEF0", VA = "0x184B3C8F0", Slot = "28")]
			get
			{
				return default(DGJDOPKLGLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public GEPCHMOMIFB NDNJPIJMLJM
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C950", Offset = "0x4B3AF50", VA = "0x184B3C950", Slot = "30")]
			get
			{
				return default(GEPCHMOMIFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool AJGBCDHLADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual ALMLELKCNKA? CBDLHIKDKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual MAALIMGMDEF? IBIOLNAMFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>>? MLLAGLOBHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool MBFNJHFEDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C5A0", Offset = "0x4B3ABA0", VA = "0x184B3C5A0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public HMBFEKDDECL<IBLJEHJLOFH> JCIJECICIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C830", Offset = "0x4B3AE30", VA = "0x184B3C830", Slot = "62")]
			get
			{
				return default(HMBFEKDDECL<IBLJEHJLOFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AAFGLNNJOHN<IBLJEHJLOFH> JEDJBPCDOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C6B0", Offset = "0x4B3ACB0", VA = "0x184B3C6B0", Slot = "56")]
			get
			{
				return default(AAFGLNNJOHN<IBLJEHJLOFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DIDJGIAICIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual AAFGLNNJOHN<IBLJEHJLOFH>? KCLMIPMJJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual bool OJGJGEDGDHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool NLIHJNLIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C770", Offset = "0x4B3AD70", VA = "0x184B3C770", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x95C550", Offset = "0x95AB50", VA = "0x18095C550", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x95C5C0", Offset = "0x95ABC0", VA = "0x18095C5C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string DIENLOIPIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x95C640", Offset = "0x95AC40", VA = "0x18095C640", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95AAE0", VA = "0x18095C4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public AAFGLNNJOHN<MOHGMBIPFPM> HLCGAADKCLI
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4B3CA80", Offset = "0x4B3B080", VA = "0x184B3CA80", Slot = "63")]
			get
			{
				return default(AAFGLNNJOHN<MOHGMBIPFPM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public HMBFEKDDECL<MOHGMBIPFPM> GJLMLEHEODI
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C890", Offset = "0x4B3AE90", VA = "0x184B3C890", Slot = "64")]
			get
			{
				return default(HMBFEKDDECL<MOHGMBIPFPM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public HMBFEKDDECL<MOHGMBIPFPM>? DALJNOLELOC
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4B3CAE0", Offset = "0x4B3B0E0", VA = "0x184B3CAE0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public GIBMKDJCJAI<FANPJMFIOIH, BCINBNEJLKM> GPPFNOCEPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4B3CBC0", Offset = "0x4B3B1C0", VA = "0x184B3CBC0", Slot = "67")]
			get
			{
				return default(GIBMKDJCJAI<FANPJMFIOIH, BCINBNEJLKM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual AAFGLNNJOHN<FANPJMFIOIH>? GGAOKAAECHE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool JDPIAKIDKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public virtual bool HNHBKABBAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "135")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LDBEPLFEKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4B38220", Offset = "0x4B36820", VA = "0x184B38220", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4B380C0", Offset = "0x4B366C0", VA = "0x184B380C0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CLDJGCLAJOD BOMAGLCEIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4B3A6E0", Offset = "0x4B38CE0", VA = "0x184B3A6E0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x4B37F10", Offset = "0x4B36510", VA = "0x184B37F10", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LPHMAADDAIN JOPLJGIECJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4B3BD00", Offset = "0x4B3A300", VA = "0x184B3BD00", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4B38BC0", Offset = "0x4B371C0", VA = "0x184B38BC0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action HEAONIAFCPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4B3B850", Offset = "0x4B39E50", VA = "0x184B3B850", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4B39280", Offset = "0x4B37880", VA = "0x184B39280", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action ENAFBNEOKDE
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4B39FA0", Offset = "0x4B385A0", VA = "0x184B39FA0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4B393D0", Offset = "0x4B379D0", VA = "0x184B393D0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM> PNLPDEEAKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4B3B750", Offset = "0x4B39D50", VA = "0x184B3B750", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4B3B970", Offset = "0x4B39F70", VA = "0x184B3B970", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM> GMHOGMKKLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4B3BB80", Offset = "0x4B3A180", VA = "0x184B3BB80", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4B3B8B0", Offset = "0x4B39EB0", VA = "0x184B3B8B0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>> IPNMIPAKEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4B38160", Offset = "0x4B36760", VA = "0x184B38160", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4B3AFD0", Offset = "0x4B395D0", VA = "0x184B3AFD0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<FANPJMFIOIH>> NKHLJCEMOOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4B3A040", Offset = "0x4B38640", VA = "0x184B3A040", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4B3BC40", Offset = "0x4B3A240", VA = "0x184B3BC40", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, BCINBNEJLKM> ONHAKCLFAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4B382C0", Offset = "0x4B368C0", VA = "0x184B382C0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4B394E0", Offset = "0x4B37AE0", VA = "0x184B394E0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<FANPJMFIOIH>> BAJLKFJMKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4B3A160", Offset = "0x4B38760", VA = "0x184B3A160", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4B3BA80", Offset = "0x4B3A080", VA = "0x184B3BA80", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BDA0", Offset = "0x4B3A3A0", VA = "0x184B3BDA0")]
		[CGDEHPHFPEN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CGDEHPHFPEN("Need to handle `Name` better.")]
		protected KPJGEGMJNEL(ANALLCGONGO DFLGEEGCPMI, TNode HPEELAFENFB, bool CAIFGFNEGNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4B39970", Offset = "0x4B37F70", VA = "0x184B39970", Slot = "99")]
		protected virtual void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4B38C60", Offset = "0x4B37260", VA = "0x184B38C60", Slot = "100")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4B39320", Offset = "0x4B37920", VA = "0x184B39320", Slot = "9")]
		[AsyncStateMachine(typeof(KPJGEGMJNEL<>.COKKOGLJDGK))]
		public void FIKOICMAOKG(int JFJOJKJCICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x4B37FB0", Offset = "0x4B365B0", VA = "0x184B37FB0")]
		public bool AJGENMFNDCH([In] DGJDOPKLGLD KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x4B3AA60", Offset = "0x4B39060", VA = "0x184B3AA60")]
		public bool MAABBEGGFHN([In] GEPCHMOMIFB KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A850", Offset = "0x4B38E50", VA = "0x184B3A850", Slot = "32")]
		public void LOPCFIAJOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4B39C10", Offset = "0x4B38210", VA = "0x184B39C10", Slot = "33")]
		[AsyncStateMachine(typeof(KPJGEGMJNEL<>.MNCPPLBNLFM))]
		public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> IAJLFJHJDHC(DGJDOPKLGLD? IJNCCGADGJC, GEPCHMOMIFB? BALNGIJIBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "109")]
		public virtual void OFEGAOGPOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "110")]
		public virtual void AILMGNDDGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "111")]
		public virtual void PIPKFMLNGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xD55AA0", Offset = "0xD540A0", VA = "0x180D55AA0")]
		protected void NMPKEJKPKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xDBDEF0", Offset = "0xDBC4F0", VA = "0x180DBDEF0")]
		protected void OFHMPFLOABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x4B39D60", Offset = "0x4B38360", VA = "0x184B39D60")]
		private void IANFANHNFKF([In] GEPCHMOMIFB MLMNPOCKAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x4B37A20", Offset = "0x4B36020", VA = "0x184B37A20", Slot = "112")]
		public virtual Task<JOFBNNGKBOO<AAFGLNNJOHN<FANPJMFIOIH>, PPAGHPBHFJD>> AAGHMFMMFIK(string OMOOEGOLALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A780", Offset = "0x4B38D80", VA = "0x184B3A780", Slot = "113")]
		public virtual Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LIBHMPMMKHI(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "114")]
		public virtual void NMECNBPNFEN(AAFGLNNJOHN<FANPJMFIOIH> CPPAAHHOJNH, AAFGLNNJOHN<FANPJMFIOIH> DMFBJLELBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x4B3AB40", Offset = "0x4B39140", VA = "0x184B3AB40", Slot = "115")]
		public virtual IEnumerable<GKPCJPMFCCN> MDJGDBMDLFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4B3B310", Offset = "0x4B39910", VA = "0x184B3B310", Slot = "116")]
		public JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD> NHLFBPGBJNM(string HNIOMJBGMOD)
		{
			return default(JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4B395A0", Offset = "0x4B37BA0", VA = "0x184B395A0", Slot = "47")]
		public bool GPGIDKANHKB([Out] Guid KDNCMGDENBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A280", Offset = "0x4B38880", VA = "0x184B3A280")]
		public bool LEGFFKJKJGN([In] Guid JLMDJNDONMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "117")]
		public virtual void KLOHADBCHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "118")]
		public virtual void DIICKOAPKMI(bool ICHCKIDAGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "119")]
		public virtual LBBIDBBGKFK AJHJGKNFGDB([In] FJMMBAHKKNM HGELIBOAOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x4B39090", Offset = "0x4B37690", VA = "0x184B39090")]
		protected void FAIIIGGKHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4B3B810", Offset = "0x4B39E10", VA = "0x184B3B810", Slot = "124")]
		protected virtual bool ODGPFOGEFMK(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4B39060", Offset = "0x4B37660", VA = "0x184B39060", Slot = "88")]
		public bool EICCLPLGGOL(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "125")]
		protected virtual bool LIPAHAGNIEN(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
		protected virtual void FLDPOCMCIGG(JNIHAMPHLFB JALKMGCKDFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4B3ABD0", Offset = "0x4B391D0", VA = "0x184B3ABD0")]
		protected void MDNPHNFNEFD(JNIHAMPHLFB BFJOGMMEGHN, Func<string> IOJNLMENKPG, Action<string> OMLJMBCNGAC, string HBAOACFBMEC, string LOKGAAAILHC, string FNOABHLCKFM, PDJPDNJJLNC ACABJGDJJDD, GNPJDLPPMAF LLEDIPFJHHP, Func<string, bool> AGNOGNOOPCP, string ABGFJFLGJOH, Func<string, bool> NHNLHGILMPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4B396F0", Offset = "0x4B37CF0", VA = "0x184B396F0")]
		protected void HFNHAMBINEG(JNIHAMPHLFB BFJOGMMEGHN, Func<string> IOJNLMENKPG, Action<string> OMLJMBCNGAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4B39D80", Offset = "0x4B38380", VA = "0x184B39D80", Slot = "133")]
		protected virtual void IIJPAKENBLJ(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BA30", Offset = "0x4B3A030", VA = "0x184B3BA30", Slot = "82")]
		public void PAPEFNAGMAJ(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4B38940", Offset = "0x4B36F40", VA = "0x184B38940", Slot = "83")]
		public ODGDOIFMABH DFJMFHMOJHJ()
		{
			return default(ODGDOIFMABH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "136")]
		public virtual bool FGCCEDEMFKF(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1D19890", Offset = "0x1D17E90", VA = "0x181D19890")]
		private void GPKADDAKCID([In] DGJDOPKLGLD NDADPNJPMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4B3B0D0", Offset = "0x4B396D0", VA = "0x184B3B0D0")]
		private void NFBANKGOLEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4B3B090", Offset = "0x4B39690", VA = "0x184B3B090", Slot = "89")]
		private void NEHICIIOGJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4B38380", Offset = "0x4B36980", VA = "0x184B38380", Slot = "91")]
		private void CNKACMOKACM(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xEE4320", Offset = "0xEE2920", VA = "0x180EE4320", Slot = "93")]
		private void CFEGHPDNDNO(AAFGLNNJOHN<FANPJMFIOIH> KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A530", Offset = "0x4B38B30", VA = "0x184B3A530", Slot = "95")]
		private void LFMIGDDGPJL(AAFGLNNJOHN<FANPJMFIOIH> KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4B3B3A0", Offset = "0x4B399A0", VA = "0x184B3B3A0", Slot = "96")]
		private void NNEJEPAHLNP(AAFGLNNJOHN<FANPJMFIOIH> CPPAAHHOJNH, AAFGLNNJOHN<FANPJMFIOIH> DMFBJLELBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xEE4DA0", Offset = "0xEE33A0", VA = "0x180EE4DA0", Slot = "97")]
		private void EGNOCACJCOG(AAFGLNNJOHN<FANPJMFIOIH> CPPAAHHOJNH, AAFGLNNJOHN<FANPJMFIOIH> DMFBJLELBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A260", Offset = "0x4B38860", VA = "0x184B3A260", Slot = "90")]
		private void KNGGJLOPPBC(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4B37AF0", Offset = "0x4B360F0", VA = "0x184B37AF0", Slot = "92")]
		private void ADHDAIBMHGM(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4B39470", Offset = "0x4B37A70", VA = "0x184B39470", Slot = "94")]
		private void GBAHKHHHNFB(AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4B38A30", Offset = "0x4B37030", VA = "0x184B38A30", Slot = "137")]
		[AsyncStateMachine(typeof(KPJGEGMJNEL<>.MPBLPEKDLCI))]
		public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> DKEEDAFMGEN(string HNIOMJBGMOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4B3AAD0", Offset = "0x4B390D0", VA = "0x184B3AAD0", Slot = "54")]
		private void MBOODFNKNPA(object CMEDKNHFJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4B38B50", Offset = "0x4B37150", VA = "0x184B38B50", Slot = "55")]
		private void DNFMKHEDNKI(object CMEDKNHFJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x46BEB80", Offset = "0x46BD180", VA = "0x1846BEB80", Slot = "29")]
		private bool CJBEHPIPMIN([In] DGJDOPKLGLD KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A220", Offset = "0x4B38820", VA = "0x184B3A220", Slot = "31")]
		private bool KIKLNONBJNJ([In] GEPCHMOMIFB KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4B392E0", Offset = "0x4B378E0", VA = "0x184B392E0", Slot = "48")]
		private bool FFDCAGPNEOP([In] Guid JLMDJNDONMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4B3BB40", Offset = "0x4B3A140", VA = "0x184B3BB40")]
		[CompilerGenerated]
		private string PDHMFIEBKJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4B38020", Offset = "0x4B36620", VA = "0x184B38020")]
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
			[Cpp2IlInjected.Address(RVA = "0xC27580", Offset = "0xC25B80", VA = "0x180C27580", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x25664B0", Offset = "0x2564AB0", VA = "0x1825664B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2565D60", Offset = "0x2564360", VA = "0x182565D60")]
		public HKLCLIBPGFP(ANALLCGONGO DFLGEEGCPMI, EENMBDBPPKI HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public NEFCGEFKFKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			internal IReadOnlyList<KeyValuePair<string, OEKJFHFPCFG>> MNLGAMGLBJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4E93E30", Offset = "0x4E92430", VA = "0x184E93E30")]
			internal int FHAIOPDBBKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x4E940A0", Offset = "0x4E926A0", VA = "0x184E940A0")]
			internal void MNPFLPCHHNE(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x4E93F90", Offset = "0x4E92590", VA = "0x184E93F90")]
			internal void JFBADLEIDLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x4E93AA0", Offset = "0x4E920A0", VA = "0x184E93AA0")]
			internal void CFFDGMAAICP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x4E93DA0", Offset = "0x4E923A0", VA = "0x184E93DA0")]
			internal bool MHLJJEBILLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x4E93D50", Offset = "0x4E92350", VA = "0x184E93D50")]
			internal void EOFCJLIFDNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x4E93DA0", Offset = "0x4E923A0", VA = "0x184E93DA0")]
			internal bool FFNOGLAOMOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x4E93D00", Offset = "0x4E92300", VA = "0x184E93D00")]
			internal float EHAKKILEBCG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x4E942C0", Offset = "0x4E928C0", VA = "0x184E942C0")]
			internal void PAFFPCEOHAP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x4E93CB0", Offset = "0x4E922B0", VA = "0x184E93CB0")]
			internal float DJEPEOCLBMP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x4E93FE0", Offset = "0x4E925E0", VA = "0x184E93FE0")]
			internal void MHGKDMAEKNL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x4E94380", Offset = "0x4E92980", VA = "0x184E94380")]
			internal float PAKGKIOGBCB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x4E93BF0", Offset = "0x4E921F0", VA = "0x184E93BF0")]
			internal void DGCIBDNEBDB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xEE1450", Offset = "0xEDFA50", VA = "0x180EE1450", Slot = "103")]
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
		[Cpp2IlInjected.Address(RVA = "0x45EA160", Offset = "0x45E8760", VA = "0x1845EA160")]
		public OKEKOINPNCC(ANALLCGONGO DFLGEEGCPMI, T HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5019110", Offset = "0x5017710", VA = "0x185019110", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xC2B890", Offset = "0xC29E90", VA = "0x180C2B890", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x255AF60", Offset = "0x2559560", VA = "0x18255AF60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public MMLOILEIPLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x256C330", Offset = "0x256A930", VA = "0x18256C330")]
			internal int FHAIOPDBBKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x256C380", Offset = "0x256A980", VA = "0x18256C380")]
			internal void MNPFLPCHHNE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, OEKJFHFPCFG>? EBNAPPOLNLJ;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x256D0F0", Offset = "0x256B6F0", VA = "0x18256D0F0")]
		public OCDDCPHEMCL(ANALLCGONGO DFLGEEGCPMI, KOFBPILCNAF HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x256CD60", Offset = "0x256B360", VA = "0x18256CD60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x256FC50", Offset = "0x256E250", VA = "0x18256FC50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2568ED0", Offset = "0x25674D0", VA = "0x182568ED0")]
		public JOKPKOONBGN(ANALLCGONGO DFLGEEGCPMI, DLKONHINKGB HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x255C750", Offset = "0x255AD50", VA = "0x18255C750")]
		public ENEDLCKPCHF(ANALLCGONGO DFLGEEGCPMI, GIENAPDKAGE HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
				[Cpp2IlInjected.Address(RVA = "0x256FCB0", Offset = "0x256E2B0", VA = "0x18256FCB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public IIMDDCONOBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2568270", Offset = "0x2566870", VA = "0x182568270")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void ANPGGHIJLED(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x25547F0", Offset = "0x2552DF0", VA = "0x1825547F0")]
		public AJOAIDPNPOH(ANALLCGONGO DFLGEEGCPMI, OFFOBCJBDPD AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2554510", Offset = "0x2552B10", VA = "0x182554510", Slot = "138")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57410", Offset = "0xA55A10", VA = "0x180A57410", Slot = "138")]
			get
			{
				return default(FAIPOOJKNPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x255A3F0", Offset = "0x25589F0", VA = "0x18255A3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC0D000", Offset = "0xC0B600", VA = "0x180C0D000", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x255DEF0", Offset = "0x255C4F0", VA = "0x18255DEF0")]
		public GFENDFNOGIE(ANALLCGONGO DFLGEEGCPMI, MJONBFOJNIE HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
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
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public sealed override bool LCGKNLENACP
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected sealed override bool GIFOOFDAHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x255AAC0", Offset = "0x25590C0", VA = "0x18255AAC0")]
		public EABLHMGIGAN(ANALLCGONGO DFLGEEGCPMI, OEPAFHBFCNF HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x255A790", Offset = "0x2558D90", VA = "0x18255A790", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x255A750", Offset = "0x2558D50", VA = "0x18255A750")]
		private int EEJDEDENCPJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x255AA60", Offset = "0x2559060", VA = "0x18255AA60")]
		private void PMKOCHKLCLB(int JJFHAAOAACO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class GEKIGDEKJMO : HGJGMPLAIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x255DE80", Offset = "0x255C480", VA = "0x18255DE80")]
		public GEKIGDEKJMO(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class FBPIHDGCJPG : NMGOABEKKFO<GGAINCJCLJO>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x255C7B0", Offset = "0x255ADB0", VA = "0x18255C7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public BBOFOLFPBFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x5899F10", Offset = "0x5898510", VA = "0x185899F10")]
			internal bool MNLGAMGLBJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x5899D90", Offset = "0x5898390", VA = "0x185899D90")]
			internal void FHAIOPDBBKM(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x5899F70", Offset = "0x5898570", VA = "0x185899F70")]
			internal bool MNPFLPCHHNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x5899E50", Offset = "0x5898450", VA = "0x185899E50")]
			internal void JFBADLEIDLK(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x5899CE0", Offset = "0x58982E0", VA = "0x185899CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public BCHEAGBLGAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x589B290", Offset = "0x5899890", VA = "0x18589B290")]
			internal void ANPGGHIJLED(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override NodeVisualizationKey PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xA71E10", Offset = "0xA70410", VA = "0x180A71E10", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override BKPLPAFEPPD BODHKPCACPF
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x4EE8240", Offset = "0x4EE6840", VA = "0x184EE8240", Slot = "106")]
			get
			{
				return default(BKPLPAFEPPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x4EE80A0", Offset = "0x4EE66A0", VA = "0x184EE80A0")]
		protected NMGOABEKKFO(ANALLCGONGO DFLGEEGCPMI, TVariableNode HPEELAFENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7610", Offset = "0x4EE5C10", VA = "0x184EE7610", Slot = "100")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7790", Offset = "0x4EE5D90", VA = "0x184EE7790", Slot = "132")]
		protected override void FLDPOCMCIGG(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7C20", Offset = "0x4EE6220", VA = "0x184EE7C20", Slot = "138")]
		protected virtual void JKCGJHNLNLO(JNIHAMPHLFB BFJOGMMEGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7FB0", Offset = "0x4EE65B0", VA = "0x184EE7FB0", Slot = "117")]
		public override void KLOHADBCHCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2539F70", Offset = "0x2538570", VA = "0x182539F70")]
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
		[Cpp2IlInjected.Address(RVA = "0xC0C580", Offset = "0xC0AB80", VA = "0x180C0C580", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF9380", Offset = "0xCF7980", VA = "0x180CF9380", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<LFNDACGNNFN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2569D30", Offset = "0x2568330", VA = "0x182569D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private AAFGLNNJOHN<JEHMBJHBIMC> HLCBFEPFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xC0CB00", Offset = "0xC0B100", VA = "0x180C0CB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public override AAFGLNNJOHN<MBNEIPNGAFM> JNKHFFHLLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x256A090", Offset = "0x2568690", VA = "0x18256A090", Slot = "21")]
		get
		{
			return default(AAFGLNNJOHN<MBNEIPNGAFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x256A0E0", Offset = "0x25686E0", VA = "0x18256A0E0")]
	private KFCLDBJIIHP(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, ICKNDFCPJHD IFBFIOLGMBJ, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP, AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, bool PFCNKPEGGGF, string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2569D40", Offset = "0x2568340", VA = "0x182569D40")]
	public static KFCLDBJIIHP FEOBEKOIKMG(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, ICKNDFCPJHD IBAFMNIDEPH, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP, bool PFCNKPEGGGF, bool CAIFGFNEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2569D30", Offset = "0x2568330", VA = "0x182569D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x256B620", Offset = "0x2569C20", VA = "0x18256B620")]
		public void KKIOKOIHHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x256B580", Offset = "0x2569B80", VA = "0x18256B580")]
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
		[Cpp2IlInjected.Address(RVA = "0x255CB20", Offset = "0x255B120", VA = "0x18255CB20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DisplayKind LIBCGPMMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x9612B0", Offset = "0x95F8B0", VA = "0x1809612B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255CAF0", Offset = "0x255B0F0", VA = "0x18255CAF0", Slot = "6")]
		get
		{
			return default(AAFGLNNJOHN<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HMBFEKDDECL<IBLJEHJLOFH> JCIJECICIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x255D8B0", Offset = "0x255BEB0", VA = "0x18255D8B0", Slot = "7")]
		get
		{
			return default(HMBFEKDDECL<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public NNEBJMMJLKO FELCFIGBMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xBEBB80", Offset = "0xBEA180", VA = "0x180BEBB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public FBIOAFHMNPO GLFIAJFPPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x255CCD0", Offset = "0x255B2D0", VA = "0x18255CCD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	protected CIAJDHIOEOD PHGCADFGEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x255CCD0", Offset = "0x255B2D0", VA = "0x18255CCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PortImage OCNMCINAMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x255C870", Offset = "0x255AE70", VA = "0x18255C870", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x956B20", Offset = "0x955120", VA = "0x180956B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public HMBFEKDDECL<MOHGMBIPFPM> GJLMLEHEODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x255D8E0", Offset = "0x255BEE0", VA = "0x18255D8E0", Slot = "9")]
		get
		{
			return default(HMBFEKDDECL<MOHGMBIPFPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AAFGLNNJOHN<FANPJMFIOIH> FNMGHCHEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xBCCAA0", Offset = "0xBCB0A0", VA = "0x180BCCAA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(AAFGLNNJOHN<FANPJMFIOIH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xCF8270", Offset = "0xCF6870", VA = "0x180CF8270")]
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
	[Cpp2IlInjected.Address(RVA = "0x255DB30", Offset = "0x255C130", VA = "0x18255DB30")]
	protected FJGNOIDBIMJ(ANALLCGONGO DFLGEEGCPMI, ALJLKHOFDLJ HPEELAFENFB, KLDDEHGIEGN GMEMHACONIH, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, bool PFCNKPEGGGF, string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x255D110", Offset = "0x255B710", VA = "0x18255D110", Slot = "22")]
	protected virtual void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x255C9A0", Offset = "0x255AFA0", VA = "0x18255C9A0", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x255CA90", Offset = "0x255B090", VA = "0x18255CA90", Slot = "14")]
	public void EADEPODEBJK(BOENHIKFFHK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x255DAD0", Offset = "0x255C0D0", VA = "0x18255DAD0", Slot = "15")]
	public void PEICFAJOAPF(NHLCFGEFNJK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x255D200", Offset = "0x255B800", VA = "0x18255D200", Slot = "16")]
	public void LNJAABKJLHF(LHFOHFDEOKM IMBHIBDELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x255D0B0", Offset = "0x255B6B0", VA = "0x18255D0B0", Slot = "24")]
	protected virtual void HKJFIOLGBII(LHFOHFDEOKM IMBHIBDELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x255CD70", Offset = "0x255B370", VA = "0x18255CD70", Slot = "19")]
	private void HEDAKCJOKDJ(bool MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x255CF00", Offset = "0x255B500", VA = "0x18255CF00")]
	private void HJFGHLMJKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x255D920", Offset = "0x255BF20", VA = "0x18255D920")]
	private void ODAEEJPHMII([In] GEEFDFPIKIO JHKLDKAMILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x255CC70", Offset = "0x255B270", VA = "0x18255CC70", Slot = "17")]
	public void HAFBDCBCODO(BOENHIKFFHK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x255C810", Offset = "0x255AE10", VA = "0x18255C810", Slot = "18")]
	public void BFNKOLEDLLB(NHLCFGEFNJK OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x956B20", Offset = "0x955120", VA = "0x180956B20")]
	internal void HJPEOOBKOIJ(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x255D900", Offset = "0x255BF00", VA = "0x18255D900")]
	internal void MPANIHEEDCN(BGKDLLEIHBK GKFDJGEMKAB, NNEBJMMJLKO BMIPLDLMPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xCF8270", Offset = "0xCF6870", VA = "0x180CF8270")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OLEBOEFDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x256DC60", Offset = "0x256C260", VA = "0x18256DC60")]
		internal KDPBGGCOFDK NFHFJBEPDMN((int PortDescIndex, int PortIndex, JBHKBKNGGIE InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x256DBD0", Offset = "0x256C1D0", VA = "0x18256DBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25686E0", Offset = "0x2566CE0", VA = "0x1825686E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2568B50", Offset = "0x2567150", VA = "0x182568B50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x256C8C0", Offset = "0x256AEC0", VA = "0x18256C8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x256CC10", Offset = "0x256B210", VA = "0x18256CC10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2565E30", Offset = "0x2564430", VA = "0x182565E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2566180", Offset = "0x2564780", VA = "0x182566180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2554BB0", Offset = "0x25531B0", VA = "0x182554BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2554F10", Offset = "0x2553510", VA = "0x182554F10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2553DA0", Offset = "0x25523A0", VA = "0x182553DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2554100", Offset = "0x2552700", VA = "0x182554100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2565870", Offset = "0x2563E70", VA = "0x182565870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2565CF0", Offset = "0x25642F0", VA = "0x182565CF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x256AF20", Offset = "0x2569520", VA = "0x18256AF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x256B270", Offset = "0x2569870", VA = "0x18256B270", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x256D160", Offset = "0x256B760", VA = "0x18256D160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x256D4D0", Offset = "0x256BAD0", VA = "0x18256D4D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2568F30", Offset = "0x2567530", VA = "0x182568F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x25692A0", Offset = "0x25678A0", VA = "0x1825692A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2569920", Offset = "0x2567F20", VA = "0x182569920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2569CC0", Offset = "0x25682C0", VA = "0x182569CC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2565460", Offset = "0x2563A60", VA = "0x182565460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2565800", Offset = "0x2563E00", VA = "0x182565800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255A0B0", Offset = "0x25586B0", VA = "0x18255A0B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool MIGNCOEGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2558BC0", Offset = "0x25571C0", VA = "0x182558BC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool JDAHFBBNIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2559C50", Offset = "0x2558250", VA = "0x182559C50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HMBFEKDDECL<IBLJEHJLOFH> JCIJECICIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2559640", Offset = "0x2557C40", VA = "0x182559640", Slot = "7")]
		get
		{
			return default(HMBFEKDDECL<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool KEMLEBKEDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x25586E0", Offset = "0x2556CE0", VA = "0x1825586E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP> FHGGHNBKBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "9")]
		get
		{
			return default(GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2559730", Offset = "0x2557D30", VA = "0x182559730", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HMBFEKDDECL<MOHGMBIPFPM> GJLMLEHEODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x25598D0", Offset = "0x2557ED0", VA = "0x1825598D0", Slot = "11")]
		get
		{
			return default(HMBFEKDDECL<MOHGMBIPFPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ> AGONGCDEPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0", Slot = "12")]
		get
		{
			return default(GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AAFGLNNJOHN<FANPJMFIOIH> FNMGHCHEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA68E90", Offset = "0xA67490", VA = "0x180A68E90", Slot = "13")]
		get
		{
			return default(AAFGLNNJOHN<FANPJMFIOIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? MMFCEFMNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2559F00", Offset = "0x2558500", VA = "0x182559F00", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2555C20", Offset = "0x2554220", VA = "0x182555C20", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? HEGMKKPFPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2559820", Offset = "0x2557E20", VA = "0x182559820", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2558570", Offset = "0x2556B70", VA = "0x182558570", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, AAFGLNNJOHN<EAGGAAMICCD?>>? IOLIPONLDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2558620", Offset = "0x2556C20", VA = "0x182558620", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2559670", Offset = "0x2557C70", VA = "0x182559670", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, AAFGLNNJOHN<EAGGAAMICCD?>>? AJIBMCHPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x255A170", Offset = "0x2558770", VA = "0x18255A170", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2559A70", Offset = "0x2558070", VA = "0x182559A70", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, AAFGLNNJOHN<LFNDACGNNFN?>>? GBIBFKDCNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2559290", Offset = "0x2557890", VA = "0x182559290", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2558B00", Offset = "0x2557100", VA = "0x182558B00", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, AAFGLNNJOHN<LFNDACGNNFN?>>? MGDFMPGONKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x255A230", Offset = "0x2558830", VA = "0x18255A230", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2558C20", Offset = "0x2557220", VA = "0x182558C20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, CDCNPBIAEIP?>? GKHEAMNCAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x25557A0", Offset = "0x2553DA0", VA = "0x1825557A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x25591D0", Offset = "0x25577D0", VA = "0x1825591D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>>? ENLNBOOHMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2559580", Offset = "0x2557B80", VA = "0x182559580", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x25563A0", Offset = "0x25549A0", VA = "0x1825563A0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AAFGLNNJOHN<EAGGAAMICCD?>, CDCNPBIAEIP?>? JGFFOIOHCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2558230", Offset = "0x2556830", VA = "0x182558230", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x25575E0", Offset = "0x2555BE0", VA = "0x1825575E0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, FGCCEOJGPLJ?>? BJIIAEBGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2559760", Offset = "0x2557D60", VA = "0x182559760", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2558170", Offset = "0x2556770", VA = "0x182558170", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>>? LFIJIDHFOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2559D10", Offset = "0x2558310", VA = "0x182559D10", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x25599B0", Offset = "0x2557FB0", VA = "0x1825599B0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AAFGLNNJOHN<LFNDACGNNFN?>, FGCCEOJGPLJ?>? CMECECNKGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x25598F0", Offset = "0x2557EF0", VA = "0x1825598F0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2555A70", Offset = "0x2554070", VA = "0x182555A70", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x255A2F0", Offset = "0x25588F0", VA = "0x18255A2F0")]
	private CLIMCMMFPBK(bool PFCNKPEGGGF, ANALLCGONGO DFLGEEGCPMI, bool AMGMPBDAHBA, GIBMKDJCJAI<EAGGAAMICCD, KDPBGGCOFDK> NLHKPNGOOIF, GIBMKDJCJAI<EAGGAAMICCD, CDCNPBIAEIP> NHADFFHGNEP, ALJLKHOFDLJ HPEELAFENFB, GIBMKDJCJAI<LFNDACGNNFN, KFCLDBJIIHP> HLLOODEPJFO, GIBMKDJCJAI<LFNDACGNNFN, FGCCEOJGPLJ> JNMPMBBENKB, string? JONJJHKHLOE, LKBOPANOFBG CGDHKNOCJLM, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, bool CAIFGFNEGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2556F60", Offset = "0x2555560", VA = "0x182556F60")]
	public static CLIMCMMFPBK FEOBEKOIKMG(bool PFCNKPEGGGF, ANALLCGONGO DFLGEEGCPMI, bool AMGMPBDAHBA, ALJLKHOFDLJ HPEELAFENFB, LKBOPANOFBG CGDHKNOCJLM, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, bool CAIFGFNEGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2556460", Offset = "0x2554A60", VA = "0x182556460", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x25576A0", Offset = "0x2555CA0", VA = "0x1825576A0", Slot = "38")]
	[AsyncStateMachine(typeof(JGMKGKHJKFH))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? GDLCENFPJEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2559350", Offset = "0x2557950", VA = "0x182559350")]
	private (MFCFENGOEMN?, int)? LNOCEBMPPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2555B30", Offset = "0x2554130", VA = "0x182555B30", Slot = "58")]
	private void BJCPLDDHLNG(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1D396A0", Offset = "0x1D37CA0", VA = "0x181D396A0", Slot = "57")]
	private void FGCMGAEIIMJ(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2558D00", Offset = "0x2557300", VA = "0x182558D00", Slot = "61")]
	private void LDKMCGFKBBI(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2556340", Offset = "0x2554940", VA = "0x182556340", Slot = "63")]
	private void CPIFGILJLFJ(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2555CC0", Offset = "0x25542C0", VA = "0x182555CC0", Slot = "50")]
	private void CHECPPGFEOI(int DPDJNHDNCGL, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2558C00", Offset = "0x2557200", VA = "0x182558C00", Slot = "54")]
	private void KHGJFHOEHFK(int MEBAFDHEDIN, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2556D90", Offset = "0x2555390", VA = "0x182556D90", Slot = "49")]
	private void EGLEOIICCOO(int MEBAFDHEDIN, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2557790", Offset = "0x2555D90", VA = "0x182557790", Slot = "53")]
	private void GMEFAIBBDLJ(int DPDJNHDNCGL, AAFGLNNJOHN<EAGGAAMICCD> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x25582F0", Offset = "0x25568F0", VA = "0x1825582F0", Slot = "66")]
	private void IBBAKJMAPOM(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x111DD90", Offset = "0x111C390", VA = "0x18111DD90", Slot = "65")]
	private void NFMFINKEPHE(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2555860", Offset = "0x2553E60", VA = "0x182555860", Slot = "60")]
	private void BCKLGJHLKKI(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1D396A0", Offset = "0x1D37CA0", VA = "0x181D396A0", Slot = "59")]
	private void PGJNCNPIPLJ(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2558760", Offset = "0x2556D60", VA = "0x182558760", Slot = "62")]
	private void JCLHPPAOAMP(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2556EE0", Offset = "0x25554E0", VA = "0x182556EE0", Slot = "64")]
	private void FAHFKEIBKLH(int HIGFEMHDELM, int JGGEFKHOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2557BE0", Offset = "0x25561E0", VA = "0x182557BE0", Slot = "52")]
	private void GOKEAJKOBLF(int DPDJNHDNCGL, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2556F40", Offset = "0x2555540", VA = "0x182556F40", Slot = "56")]
	private void FBJFJNHFMDE(int MEBAFDHEDIN, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2558CE0", Offset = "0x25572E0", VA = "0x182558CE0", Slot = "51")]
	private void LBLIIBMEPFN(int MEBAFDHEDIN, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2556920", Offset = "0x2554F20", VA = "0x182556920", Slot = "55")]
	private void EEBOHNGOHIL(int DPDJNHDNCGL, AAFGLNNJOHN<LFNDACGNNFN> MAACANNINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2555650", Offset = "0x2553C50", VA = "0x182555650", Slot = "68")]
	private void AOHEJPLNDFK(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x111DD90", Offset = "0x111C390", VA = "0x18111DD90", Slot = "67")]
	private void NPJAJMJANGK(int DPDJNHDNCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x25574D0", Offset = "0x2555AD0", VA = "0x1825574D0", Slot = "39")]
	[AsyncStateMachine(typeof(NDPFOCMHIED))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? FLMNPHNEJKP(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2559FA0", Offset = "0x25585A0", VA = "0x182559FA0", Slot = "40")]
	[AsyncStateMachine(typeof(HMBKBFPAGCP))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? OGJHDIGNLFB(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2559B30", Offset = "0x2558130", VA = "0x182559B30", Slot = "41")]
	[AsyncStateMachine(typeof(BJLLGBCOIIH))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? NGFDKNJCALF(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, AAFGLNNJOHN<GLPBIEDACAD> OPMFOHFDNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2555950", Offset = "0x2553F50", VA = "0x182555950", Slot = "42")]
	[AsyncStateMachine(typeof(ACOCDOIGBLA))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? BDLKBOOGFPP(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, AAFGLNNJOHN<JEHMBJHBIMC> OPMFOHFDNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2556250", Offset = "0x2554850", VA = "0x182556250", Slot = "43")]
	[AsyncStateMachine(typeof(HEDFIBMFPLH))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD?>>? CMJBLLMJIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2556800", Offset = "0x2554E00", VA = "0x182556800", Slot = "44")]
	[AsyncStateMachine(typeof(LGEGEOHIJLB))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> ECNBNJAOBGO(string HNIOMJBGMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2558440", Offset = "0x2556A40", VA = "0x182558440", Slot = "45")]
	[AsyncStateMachine(typeof(OFFEHJJNGPF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> ICKDHBBCLFN(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, string OMOOEGOLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2556DB0", Offset = "0x25553B0", VA = "0x182556DB0", Slot = "46")]
	[AsyncStateMachine(typeof(JOPKLPEJGHF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> EIEKIAEHEKJ(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, string OMOOEGOLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2559DD0", Offset = "0x25583D0", VA = "0x182559DD0", Slot = "47")]
	[AsyncStateMachine(typeof(KENLDLCIMPK))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> OBIMBKLDPMH(AAFGLNNJOHN<GLPBIEDACAD> DKKHBAOHFCK, NADGPPCKHDL BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x25590A0", Offset = "0x25576A0", VA = "0x1825590A0", Slot = "48")]
	[AsyncStateMachine(typeof(HDECDLMOBFN))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LEOFDBMEKDO(AAFGLNNJOHN<JEHMBJHBIMC> AJKFHANKPNK, NADGPPCKHDL BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2555290", Offset = "0x2553890", VA = "0x182555290")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
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
		[Cpp2IlInjected.Address(RVA = "0x256DFD0", Offset = "0x256C5D0", VA = "0x18256DFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x256EE80", Offset = "0x256D480", VA = "0x18256EE80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	private AIIOGMFDPOA(NAPFONIDFOF AALMIJNHLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x25543A0", Offset = "0x25529A0", VA = "0x1825543A0")]
	[AsyncStateMachine(typeof(PCEANGNMGGO))]
	public static Task<AIIOGMFDPOA> PIEBIBJICAE(ANALLCGONGO DFLGEEGCPMI, OELEFOKLIPK? MIMFFPFKBEA, HFDFODLNHEC? LBDLMMONJCN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2554380", Offset = "0x2552980", VA = "0x182554380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255A450", Offset = "0x2558A50", VA = "0x18255A450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x255A6E0", Offset = "0x2558CE0", VA = "0x18255A6E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x256D6C0", Offset = "0x256BCC0", VA = "0x18256D6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x256DAA0", Offset = "0x256C0A0", VA = "0x18256DAA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2568BC0", Offset = "0x25671C0", VA = "0x182568BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2568E00", Offset = "0x2567400", VA = "0x182568E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private readonly NHECKHEMBJH HIOOFICJKMA;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	public IINEAIHFAEH(NHECKHEMBJH MKMHAKPJKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2568340", Offset = "0x2566940", VA = "0x182568340")]
	[AsyncStateMachine(typeof(DKAPLAJLOPH))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> AICDCFGMFHH(GKPCJPMFCCN PJDAFKMDDCG, bool LELKEOHAIGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2568560", Offset = "0x2566B60", VA = "0x182568560")]
	[AsyncStateMachine(typeof(OJCBMHEKNAO))]
	public Task<JOFBNNGKBOO<bool, PPAGHPBHFJD?>>? MHLPFKNCMPJ(int AAMJFOFMHFE, DJKKMHFELNP? EHMJINIHOLK, OELEFOKLIPK? OGAEJFFJGMI, HFDFODLNHEC? LBDLMMONJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2568470", Offset = "0x2566A70", VA = "0x182568470")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	private AEHFFPDLMCJ(EBNJEDCLKBE DHNAOKJIGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2554190", Offset = "0x2552790", VA = "0x182554190")]
	public static AEHFFPDLMCJ GFOCOOKFNLL(ANALLCGONGO DFLGEEGCPMI, DJKKMHFELNP KFHCOMMDLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2554170", Offset = "0x2552770", VA = "0x182554170", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x256C410", Offset = "0x256AA10", VA = "0x18256C410")]
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
		[Cpp2IlInjected.Address(RVA = "0x25686C0", Offset = "0x2566CC0", VA = "0x1825686C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	internal IKAOBOCJFBC(ANALLCGONGO DFLGEEGCPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class GMPNDNPPCAN : PCBMEDABEPH
{
	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x25653C0", Offset = "0x25639C0", VA = "0x1825653C0", Slot = "4")]
	public AOBOCLPFDHH? KAEKCPMEMMB(string? AEDDPJHJGBN, string? AFOBJDILGGP, string? IBJIEKIJIFJ, ENMPEBIDCHO.DKEGNGFDPPC.DPKMJELBHKO AEDCOFHFHLF, bool HJECKNFLPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2554F80", Offset = "0x2553580", VA = "0x182554F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x2555220", Offset = "0x2553820", VA = "0x182555220", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255B7D0", Offset = "0x2559DD0", VA = "0x18255B7D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GHGILLKJOFN? ENPAKKPHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x255B8B0", Offset = "0x2559EB0", VA = "0x18255B8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool GLBEGEGCABB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x255B770", Offset = "0x2559D70", VA = "0x18255B770", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool CLNALJABGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x255B850", Offset = "0x2559E50", VA = "0x18255B850", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x255BAC0", Offset = "0x255A0C0", VA = "0x18255BAC0")]
	internal EBKJNLBDILK(ANALLCGONGO DFLGEEGCPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x255AFD0", Offset = "0x25595D0", VA = "0x18255AFD0", Slot = "7")]
	[AsyncStateMachine(typeof(CLAPCJKHEKG))]
	public Task<CBKCDAKDLFJ> ALGCLFNNKOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x255B400", Offset = "0x2559A00", VA = "0x18255B400", Slot = "9")]
	public IReadOnlyDictionary<HMBFEKDDECL<IBLJEHJLOFH>, Guid> FJNMKGLKJAG(IEnumerable<PGEJPEMIJFO> BIKKNAJKJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x255B930", Offset = "0x2559F30", VA = "0x18255B930", Slot = "10")]
	public HLHFOEDMKGI OFABHOIEDGE(IEnumerable<PGEJPEMIJFO> BIKKNAJKJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x255B0C0", Offset = "0x25596C0", VA = "0x18255B0C0")]
	public JOFBNNGKBOO<EDCAHLAPEPD, EAPODONBJNH> ENLIMJLBEIO([In] EDCAHLAPEPD MKNANILKFNH)
	{
		return default(JOFBNNGKBOO<EDCAHLAPEPD, EAPODONBJNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x255B260", Offset = "0x2559860", VA = "0x18255B260", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public ALMGGNDBNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x2571DA0", Offset = "0x25703A0", VA = "0x182571DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public MMBLFFFBILM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x2576140", Offset = "0x2574740", VA = "0x182576140")]
			internal void AFFCGAGEAMO(BMEMLKEGJDK n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2567930", Offset = "0x2565F30", VA = "0x182567930")]
		public static JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC> IKIFLPOJPIB(GHGILLKJOFN JDCFMPOHCEA, [In] CBKCDAKDLFJ.DMDNDIMIHGD JIEBKPCGKFF)
		{
			return default(JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2566AC0", Offset = "0x25650C0", VA = "0x182566AC0")]
		internal static JOFBNNGKBOO<(MHEDMHEDCEP, CGIFKBGLAGM), KFNJBCGDAAC> EAEJBALEIPH(GHGILLKJOFN JDCFMPOHCEA, CGIFKBGLAGM DOJPCCJJBEP, bool HBBFJHPDMOA, [In] HMBFEKDDECL<IBLJEHJLOFH> CODLLOBEPJE, [In] int? HNAFDCGBLCO, [In] ODGDOIFMABH? NGEJGCMHAPD, [In] ODGDOIFMABH? PJKGADMGHNI)
		{
			return default(JOFBNNGKBOO<(MHEDMHEDCEP, CGIFKBGLAGM), KFNJBCGDAAC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2566510", Offset = "0x2564B10", VA = "0x182566510")]
		private static void ACAOADICCJJ(bool HBBFJHPDMOA, PGEJPEMIJFO JOHGLFIKFAB, MHEDMHEDCEP FBPALFHGIKN, [In] HMBFEKDDECL<IBLJEHJLOFH> CODLLOBEPJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2567E70", Offset = "0x2566470", VA = "0x182567E70")]
		public static void NJJAPFCMACD(PFGLFMIDBPK FPIDBKEMNOJ, [In] CBKCDAKDLFJ.NIOGBKGKACM BIPCBLCLEIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x25669A0", Offset = "0x2564FA0", VA = "0x1825669A0")]
		[CompilerGenerated]
		internal static bool CDFGBNNDGEB(NAPFONIDFOF PGNNFCOHAOH, PKHNPALDKBJ HOJDFFFLNKN, BMEMLKEGJDK EPOFBJFECFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2566A90", Offset = "0x2565090", VA = "0x182566A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2572340", Offset = "0x2570940", VA = "0x182572340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2572590", Offset = "0x2570B90", VA = "0x182572590", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x25753D0", Offset = "0x25739D0", VA = "0x1825753D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2575690", Offset = "0x2573C90", VA = "0x182575690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2574560", Offset = "0x2572B60", VA = "0x182574560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x25747A0", Offset = "0x2572DA0", VA = "0x1825747A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2575700", Offset = "0x2573D00", VA = "0x182575700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2575940", Offset = "0x2573F40", VA = "0x182575940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2576E00", Offset = "0x2575400", VA = "0x182576E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2577440", Offset = "0x2575A40", VA = "0x182577440", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2571330", Offset = "0x256F930", VA = "0x182571330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x2571980", Offset = "0x256FF80", VA = "0x182571980", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x25719F0", Offset = "0x256FFF0", VA = "0x1825719F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x2571D30", Offset = "0x2570330", VA = "0x182571D30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2574810", Offset = "0x2572E10", VA = "0x182574810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2574B50", Offset = "0x2573150", VA = "0x182574B50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x25720B0", Offset = "0x25706B0", VA = "0x1825720B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x25722D0", Offset = "0x25708D0", VA = "0x1825722D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255DF60", Offset = "0x255C560", VA = "0x18255DF60", Slot = "4")]
		get
		{
			return default(HMBFEKDDECL<IBLJEHJLOFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HEJCMKDLMJK HMNAPPILJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2536FA0", Offset = "0x25355A0", VA = "0x182536FA0", Slot = "5")]
		get
		{
			return default(HEJCMKDLMJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2564D00", Offset = "0x2563300", VA = "0x182564D00")]
	public GHGILLKJOFN(ANALLCGONGO DFLGEEGCPMI, FGAGELOHMIE LPHHLKJDLIO, IIPMLPJOFAH GEACFDKHKOC, EBKJNLBDILK MIOKKEMFKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2564B90", Offset = "0x2563190", VA = "0x182564B90", Slot = "65")]
	public AAFGLNNJOHN<PBJODNNKGBJ> PLABMCMEFBI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AAFGLNNJOHN<PBJODNNKGBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x25601B0", Offset = "0x255E7B0", VA = "0x1825601B0", Slot = "66")]
	public AAFGLNNJOHN<ILELENOJNKM> FDOGEDLAKII(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AAFGLNNJOHN<ILELENOJNKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x255F940", Offset = "0x255DF40", VA = "0x18255F940", Slot = "6")]
	public (bool, bool) ECBBELLFNDB(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2562D80", Offset = "0x2561380", VA = "0x182562D80")]
	public bool LGFHBIFMEIM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2560700", Offset = "0x255ED00", VA = "0x182560700", Slot = "8")]
	public bool GKDJOMEEEMJ(CDCNPBIAEIP GLHBFHFFMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2560780", Offset = "0x255ED80", VA = "0x182560780", Slot = "9")]
	public bool HANAIALAMBO(FGCCEOJGPLJ FLFFBFGJHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2561300", Offset = "0x255F900", VA = "0x182561300", Slot = "10")]
	public EBLIMHGMFBB? IGGGEFDAKEC(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2560540", Offset = "0x255EB40", VA = "0x182560540", Slot = "11")]
	public PFOKEHFDPAJ? GBMDCNHHNOJ(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2562200", Offset = "0x2560800", VA = "0x182562200", Slot = "12")]
	public AAFGLNNJOHN<OECNLCLGMED>? KAMNMOMCNFO(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<LFNDACGNNFN> JLLMELNAAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2560BC0", Offset = "0x255F1C0", VA = "0x182560BC0", Slot = "13")]
	public AAFGLNNJOHN<KPIEMJMGBJJ>? HOHAKAJMONM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, AAFGLNNJOHN<EAGGAAMICCD> HAONHOPHKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2560600", Offset = "0x255EC00", VA = "0x182560600", Slot = "14")]
	public IEnumerable<AAFGLNNJOHN<IBLJEHJLOFH>> GENEHMKFKCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x2560CE0", Offset = "0x255F2E0", VA = "0x182560CE0", Slot = "15")]
	public IEnumerable<AAFGLNNJOHN<DBJJLNDECIK>> HPDIEBMAPIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x25632C0", Offset = "0x25618C0", VA = "0x1825632C0", Slot = "16")]
	public string LLGEBGEPMEM(AAFGLNNJOHN<DBJJLNDECIK> OPBDNNBOBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2564720", Offset = "0x2562D20", VA = "0x182564720", Slot = "17")]
	public string ONOLOEINFFP(AAFGLNNJOHN<DBJJLNDECIK> OPBDNNBOBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2560E10", Offset = "0x255F410", VA = "0x182560E10")]
	public NBNILIEIFAK? IEKAJAOOLDL([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x255E7E0", Offset = "0x255CDE0", VA = "0x18255E7E0", Slot = "23")]
	public AAFGLNNJOHN<GDEODHDOKBB> BNFCFFFLFCA(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default(AAFGLNNJOHN<GDEODHDOKBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x255E860", Offset = "0x255CE60", VA = "0x18255E860")]
	public AAFGLNNJOHN<MOHGMBIPFPM> FLOGGOFCJKB(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] HMBFEKDDECL<MOHGMBIPFPM> PFCMOGNDPJN)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2560D90", Offset = "0x255F390", VA = "0x182560D90", Slot = "33")]
	public AAFGLNNJOHN<MOHGMBIPFPM> IAAHONLOLLK(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2562B50", Offset = "0x2561150", VA = "0x182562B50", Slot = "34")]
	public AAFGLNNJOHN<MOHGMBIPFPM> KPJJLDGNGAI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x25604C0", Offset = "0x255EAC0", VA = "0x1825604C0")]
	public AAFGLNNJOHN<MOHGMBIPFPM>? GBAFJGOKMKO(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] HMBFEKDDECL<MOHGMBIPFPM> PFCMOGNDPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x255F3C0", Offset = "0x255D9C0", VA = "0x18255F3C0", Slot = "25")]
	public DAGDBEHPBOA? CHKJMPFJNEN(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2560B60", Offset = "0x255F160", VA = "0x182560B60", Slot = "26")]
	public long HILMLELNPLM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2561E00", Offset = "0x2560400", VA = "0x182561E00")]
	private void JJOGMOEKHOM(HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2560060", Offset = "0x255E660", VA = "0x182560060", Slot = "31")]
	public IEnumerable<(AAFGLNNJOHN<IBLJEHJLOFH>, AAFGLNNJOHN<MOHGMBIPFPM>)> EJLNACNHDHM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2560C50", Offset = "0x255F250", VA = "0x182560C50", Slot = "32")]
	public AAFGLNNJOHN<KPIEMJMGBJJ> HOHAKAJMONM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<PBJODNNKGBJ> HAONHOPHKAF)
	{
		return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2562170", Offset = "0x2560770", VA = "0x182562170", Slot = "35")]
	public AAFGLNNJOHN<OECNLCLGMED> KAMNMOMCNFO(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<ILELENOJNKM> JLLMELNAAHA)
	{
		return default(AAFGLNNJOHN<OECNLCLGMED>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2560AB0", Offset = "0x255F0B0", VA = "0x182560AB0")]
	private NBNILIEIFAK? HHLBFEILNLE([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x255E240", Offset = "0x255C840", VA = "0x18255E240")]
	public ALJLKHOFDLJ? AHIJJKIAALG([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2562B20", Offset = "0x2561120", VA = "0x182562B20")]
	public GOKGCFFOMBC? KMLKFKHEBDG([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x25630B0", Offset = "0x25616B0", VA = "0x1825630B0", Slot = "27")]
	public IEnumerable<NPEOPECJINL> LKKKNPCKOBG(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2561C40", Offset = "0x2560240", VA = "0x182561C40", Slot = "28")]
	public bool JEPMPNCPKHN(AAFGLNNJOHN<DBJJLNDECIK> OPBDNNBOBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x255DFC0", Offset = "0x255C5C0", VA = "0x18255DFC0", Slot = "29")]
	public IEnumerable<OLNKAEDKNJN> AGPOKBMKNOI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x25628A0", Offset = "0x2560EA0", VA = "0x1825628A0", Slot = "30")]
	public IEnumerable<OLNKAEDKNJN> KJFMAEEAACJ(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x255E670", Offset = "0x255CC70", VA = "0x18255E670")]
	public AAFGLNNJOHN<IBLJEHJLOFH> BABAGDLOKFH([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(AAFGLNNJOHN<IBLJEHJLOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x255E440", Offset = "0x255CA40", VA = "0x18255E440")]
	public AAFGLNNJOHN<IBLJEHJLOFH>? GBNLGMEMBFH([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2561CD0", Offset = "0x25602D0", VA = "0x182561CD0")]
	private PKHNPALDKBJ? JJBHMHEJPHO([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2562B20", Offset = "0x2561120", VA = "0x182562B20")]
	private GOKGCFFOMBC? MNPBLEODLOD([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x255E4C0", Offset = "0x255CAC0", VA = "0x18255E4C0", Slot = "21")]
	public AAFGLNNJOHN<IBLJEHJLOFH>? AKPHDJNOJOE(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2560140", Offset = "0x255E740", VA = "0x182560140", Slot = "39")]
	public HMBFEKDDECL<IBLJEHJLOFH> FBEEPOPOKBM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(HMBFEKDDECL<IBLJEHJLOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x255E8E0", Offset = "0x255CEE0", VA = "0x18255E8E0", Slot = "36")]
	public IEnumerable<NADGPPCKHDL> CAJJEDGFINP(JBEJALNFNNM MBFPNEOFNAB, bool KCNBABHGEFF, bool IIIJNHDCCID, bool NOJAPOAPMBG, bool EDMKGIOPGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2564820", Offset = "0x2562E20", VA = "0x182564820", Slot = "37")]
	public NADGPPCKHDL PBFPEFHBPMA(JBEJALNFNNM MBFPNEOFNAB, FPMPKFDBAJK OMFJOIDAOAF, bool KCNBABHGEFF, bool IIIJNHDCCID, bool NOJAPOAPMBG, bool EDMKGIOPGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x255E2D0", Offset = "0x255C8D0", VA = "0x18255E2D0")]
	public NPEOPECJINL LMKMLBEIMJL(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(NPEOPECJINL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x255F710", Offset = "0x255DD10", VA = "0x18255F710", Slot = "40")]
	public OLNKAEDKNJN DOMHOHHMECI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return default(OLNKAEDKNJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2560800", Offset = "0x255EE00", VA = "0x182560800", Slot = "41")]
	[AsyncStateMachine(typeof(CCJHCJLFJGD))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> HGKNAKAMJKJ(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, AAFGLNNJOHN<MOHGMBIPFPM> KOHCBOMIKFA, DGJDOPKLGLD FDJGEFDKBBO, bool LHOBMLIMOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2563330", Offset = "0x2561930", VA = "0x182563330", Slot = "42")]
	[AsyncStateMachine(typeof(KLLKGOFJOKO))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LLGEOKHJHIH(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, List<AAFGLNNJOHN<MOHGMBIPFPM>> GNFNEFOKFHF, DGJDOPKLGLD NAAPAKKFPOM, GEPCHMOMIFB EBMNAHJKBDM, DGJDOPKLGLD FDJGEFDKBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2563170", Offset = "0x2561770", VA = "0x182563170", Slot = "45")]
	[AsyncStateMachine(typeof(ELHPNMEFBHF))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> LLEKNBPGFND(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, List<AAFGLNNJOHN<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2564390", Offset = "0x2562990", VA = "0x182564390", Slot = "46")]
	[AsyncStateMachine(typeof(LIIHHHONNKK))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> NKKLPGPIMAL(AAFGLNNJOHN<IBLJEHJLOFH> PKLOLFAIMJJ, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, List<AAFGLNNJOHN<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2562730", Offset = "0x2560D30", VA = "0x182562730", Slot = "43")]
	public (IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)>, IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)>) KJCPDICAAHL(HMBFEKDDECL<IBLJEHJLOFH> CJEDJDOCNCA, AAFGLNNJOHN<MOHGMBIPFPM> KOHCBOMIKFA)
	{
		return default((IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)>, IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2562BD0", Offset = "0x25611D0", VA = "0x182562BD0", Slot = "44")]
	[AsyncStateMachine(typeof(PGLCIIGGDBB))]
	public Task LCGCMBIGINH(HMBFEKDDECL<IBLJEHJLOFH> CJEDJDOCNCA, HMBFEKDDECL<MOHGMBIPFPM> KOHCBOMIKFA, IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> BAMNJIOFLEE, IReadOnlyDictionary<OPEBBLAJOMK, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<EAGGAAMICCD>)> FAABHMALLCL, IReadOnlyDictionary<NEPKIEPOMGB, (AAFGLNNJOHN<FANPJMFIOIH>, AAFGLNNJOHN<LFNDACGNNFN>)> BEKOPDLICIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x255F570", Offset = "0x255DB70", VA = "0x18255F570", Slot = "47")]
	public bool CJDKOBBKLNM(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x255F4F0", Offset = "0x255DAF0", VA = "0x18255F4F0", Slot = "48")]
	public bool CHNDGNHFKJI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x255E6F0", Offset = "0x255CCF0", VA = "0x18255E6F0", Slot = "49")]
	public bool BBLENKCLFPB(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2560110", Offset = "0x255E710", VA = "0x182560110")]
	public JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC> IOPEHHEJHHJ([In] CBKCDAKDLFJ.DMDNDIMIHGD JIEBKPCGKFF)
	{
		return default(JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x255F5E0", Offset = "0x255DBE0", VA = "0x18255F5E0", Slot = "51")]
	[AsyncStateMachine(typeof(ACBPHNNOJFP))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> CJJNNDMOJBP(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> LHFAKPEIOLP, AAFGLNNJOHN<KPIEMJMGBJJ> GLFIAEKPNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2563FD0", Offset = "0x25625D0", VA = "0x182563FD0", Slot = "52")]
	public JOFBNNGKBOO<GDCECNBKGDJ, EAPODONBJNH> MDKFLNEHBCA(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, GDCECNBKGDJ BAHCLAPPIIA, GEPCHMOMIFB OKPBCMCCLNH)
	{
		return default(JOFBNNGKBOO<GDCECNBKGDJ, EAPODONBJNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2562010", Offset = "0x2560610", VA = "0x182562010", Slot = "53")]
	[AsyncStateMachine(typeof(ACLJLBDJDME))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> KACAHPBDHGG(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> FGHFBEDHADD, AAFGLNNJOHN<FANPJMFIOIH> KGANNGMMHBO, AAFGLNNJOHN<EAGGAAMICCD> FAEFIHLMPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2560950", Offset = "0x255EF50", VA = "0x182560950", Slot = "54")]
	[AsyncStateMachine(typeof(ENEGJLDJOPC))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> HHDFFEKBKGO(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> LMENEPJPOKA, AAFGLNNJOHN<FANPJMFIOIH> HCAFJHOJGAL, AAFGLNNJOHN<LFNDACGNNFN> HFCCPEEKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x255FE50", Offset = "0x255E450", VA = "0x18255FE50", Slot = "55")]
	public NNBMBEDJBPD EFIJKHODPGG()
	{
		return default(NNBMBEDJBPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2561EF0", Offset = "0x25604F0", VA = "0x182561EF0", Slot = "56")]
	public NNBMBEDJBPD JPDILCEPHGK()
	{
		return default(NNBMBEDJBPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2564550", Offset = "0x2562B50", VA = "0x182564550", Slot = "58")]
	public IHAOFOGJBHP OALBAAMCJLH(LHMJOHFKNMN IBPBICKJEGO, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IEnumerable<HMBFEKDDECL<IBLJEHJLOFH>> OMDJCPDNFEN, IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return default(IHAOFOGJBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2561A90", Offset = "0x2560090", VA = "0x182561A90")]
	private IHAOFOGJBHP ILAHOGAKONC(LHMJOHFKNMN IBPBICKJEGO, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IEnumerable<HMBFEKDDECL<IBLJEHJLOFH>> OMDJCPDNFEN, IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> GNFNEFOKFHF)
	{
		return default(IHAOFOGJBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2560230", Offset = "0x255E830", VA = "0x182560230", Slot = "57")]
	public IHAOFOGJBHP FMFGPANNIMK(LHMJOHFKNMN IBPBICKJEGO, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> GNFNEFOKFHF, IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD)
	{
		return default(IHAOFOGJBHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2560F80", Offset = "0x255F580", VA = "0x182560F80")]
	private static IEnumerable<HMBFEKDDECL<IBLJEHJLOFH>> IFFEBFLAFDL(IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2562290", Offset = "0x2560890", VA = "0x182562290")]
	private IEnumerable<HMBFEKDDECL<MOHGMBIPFPM>> KEDCCPFLPKI(IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2564790", Offset = "0x2562D90", VA = "0x182564790", Slot = "59")]
	public List<CJHHNHLLHIJ> OPJNPGGHPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x25613C0", Offset = "0x255F9C0", VA = "0x1825613C0")]
	public (List<CJHHNHLLHIJ>, bool) IIJCEPKOJGK([In] GIOBPIGMMED DPHAJJFDCDC, string BPPCEJGCMKA, [In] EDNEPNABDLO EFPEOIMBIIL, LCLLAFFONKF JFBOEMOFKMH, AEAHJHOGBME MBCEHNPFDKI)
	{
		return default((List<CJHHNHLLHIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2564C10", Offset = "0x2563210", VA = "0x182564C10", Slot = "61")]
	public bool PLODDDKODCN(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2562D20", Offset = "0x2561320", VA = "0x182562D20")]
	internal void LDCFEJBPJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x25644F0", Offset = "0x2562AF0", VA = "0x1825644F0")]
	internal Task OACKPFOKJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x255E9F0", Offset = "0x255CFF0", VA = "0x18255E9F0", Slot = "62")]
	public JOFBNNGKBOO<AAFGLNNJOHN<OECNLCLGMED>?, PPAGHPBHFJD> CFOEOBGJBCI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return default(JOFBNNGKBOO<AAFGLNNJOHN<OECNLCLGMED>?, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x25634B0", Offset = "0x2561AB0", VA = "0x1825634B0", Slot = "63")]
	public JOFBNNGKBOO<AAFGLNNJOHN<KPIEMJMGBJJ>?, PPAGHPBHFJD> LOGJIDGLFKD(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return default(JOFBNNGKBOO<AAFGLNNJOHN<KPIEMJMGBJJ>?, PPAGHPBHFJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x255FF70", Offset = "0x255E570", VA = "0x18255FF70", Slot = "64")]
	[AsyncStateMachine(typeof(CAGKGBMMGOP))]
	public Task<JOFBNNGKBOO<IDMEFNAINAN, PPAGHPBHFJD>> EGCHKPDMPJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x255E9E0", Offset = "0x255CFE0", VA = "0x18255E9E0", Slot = "7")]
	private bool CFFALMGACJE(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2562B20", Offset = "0x2561120", VA = "0x182562B20", Slot = "18")]
	private GOKGCFFOMBC MGMMAANJBKA([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x255FE40", Offset = "0x255E440", VA = "0x18255FE40", Slot = "19")]
	private AAFGLNNJOHN<IBLJEHJLOFH> EEEGJECPNNF([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return default(AAFGLNNJOHN<IBLJEHJLOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x255E440", Offset = "0x255CA40", VA = "0x18255E440", Slot = "20")]
	private AAFGLNNJOHN<IBLJEHJLOFH>? AIKHBIIFCJF([In] HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2563E80", Offset = "0x2562480", VA = "0x182563E80", Slot = "22")]
	private NBNILIEIFAK MCIOOJAAPKD([In] HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x255E860", Offset = "0x255CE60", VA = "0x18255E860", Slot = "24")]
	private AAFGLNNJOHN<MOHGMBIPFPM> BNJGGONHCOJ(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] HMBFEKDDECL<MOHGMBIPFPM> PFCMOGNDPJN)
	{
		return default(AAFGLNNJOHN<MOHGMBIPFPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x255E2D0", Offset = "0x255C8D0", VA = "0x18255E2D0", Slot = "38")]
	private NPEOPECJINL AHNIHHBHHLI(AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, [In] OLNKAEDKNJN JDLNLEEPEHB)
	{
		return default(NPEOPECJINL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2560110", Offset = "0x255E710", VA = "0x182560110", Slot = "50")]
	private JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC> FAILHJPKMDC([In] CBKCDAKDLFJ.DMDNDIMIHGD JIEBKPCGKFF)
	{
		return default(JOFBNNGKBOO<CBKCDAKDLFJ.BBMLJHBBMGE, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2561E90", Offset = "0x2560490", VA = "0x182561E90", Slot = "60")]
	private (List<CJHHNHLLHIJ>, bool) JLGBIPGOKEL([In] GIOBPIGMMED DPHAJJFDCDC, string BPPCEJGCMKA, [In] EDNEPNABDLO EFPEOIMBIIL, LCLLAFFONKF JFBOEMOFKMH, AEAHJHOGBME MBCEHNPFDKI)
	{
		return default((List<CJHHNHLLHIJ>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x255E5F0", Offset = "0x255CBF0", VA = "0x18255E5F0")]
	[CompilerGenerated]
	private OOCBNANOENM AOIGDOICHOO(NNEBJMMJLKO BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2560690", Offset = "0x255EC90", VA = "0x182560690")]
	[CompilerGenerated]
	private ALJLKHOFDLJ GJHPIBACBHC(HMBFEKDDECL<MOHGMBIPFPM> BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2561D90", Offset = "0x2560390", VA = "0x182561D90")]
	[CompilerGenerated]
	private PKHNPALDKBJ JJLELHPMHOH(HMBFEKDDECL<IBLJEHJLOFH> BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2564B20", Offset = "0x2563120", VA = "0x182564B20")]
	[CompilerGenerated]
	private ALJLKHOFDLJ PGGGBJGILPJ(HMBFEKDDECL<MOHGMBIPFPM> BKHEBBAMMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x255E770", Offset = "0x255CD70", VA = "0x18255E770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2574E80", Offset = "0x2573480", VA = "0x182574E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2575100", Offset = "0x2573700", VA = "0x182575100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2571DC0", Offset = "0x25703C0", VA = "0x182571DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2572040", Offset = "0x2570640", VA = "0x182572040", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2572A00", Offset = "0x2571000", VA = "0x182572A00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NNEBJMMJLKO KIHPMKMJDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2576D60", Offset = "0x2575360", VA = "0x182576D60")]
	public OOCBNANOENM(NNEBJMMJLKO KCGLNLMLKOE, FGAGELOHMIE LPHHLKJDLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2576A80", Offset = "0x2575080", VA = "0x182576A80", Slot = "6")]
	[AsyncStateMachine(typeof(KIHKHMHBALD))]
	public Task<JOFBNNGKBOO<AAFGLNNJOHN<GLPBIEDACAD>, PPAGHPBHFJD>> CKJAPCPBIEM(HMBFEKDDECL<IBLJEHJLOFH> JLMDJNDONMA, HMBFEKDDECL<MOHGMBIPFPM> MEGMENINLOE, AAFGLNNJOHN<FANPJMFIOIH> FHDCCHMOCAI, string OMOOEGOLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2576BF0", Offset = "0x25751F0", VA = "0x182576BF0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x2573CE0", Offset = "0x25722E0", VA = "0x182573CE0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool OGEPPCANEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2573CD0", Offset = "0x25722D0", VA = "0x182573CD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool IFIGMEECAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2573D30", Offset = "0x2572330", VA = "0x182573D30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool BDPKFNICMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2573C50", Offset = "0x2572250", VA = "0x182573C50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2572600", Offset = "0x2570C00", VA = "0x182572600")]
	public bool COOFJEFBFLM(string KBGCCIOIGBD, [Out] GMLLPHEKNBK LICNGAMDKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public CIAJDHIOEOD(NNEBJMMJLKO AAMBBOLAGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2572870", Offset = "0x2570E70", VA = "0x182572870")]
	internal static TypeKey JGECIPFBKFJ(NNEBJMMJLKO BMIPLDLMPCD)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2572A00", Offset = "0x2571000", VA = "0x182572A00", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2573ED0", Offset = "0x25724D0", VA = "0x182573ED0", Slot = "4")]
	public int IFJCMLBDBDB(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2573EC0", Offset = "0x25724C0", VA = "0x182573EC0", Slot = "5")]
	public GKPCJPMFCCN GGMOOALNMDD(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2573F70", Offset = "0x2572570", VA = "0x182573F70", Slot = "6")]
	public GKPCJPMFCCN OEPKLKMDNMF(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2573F10", Offset = "0x2572510", VA = "0x182573F10", Slot = "7")]
	public IReadOnlyList<GKPCJPMFCCN> JDGLOHBFGDE(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2573E90", Offset = "0x2572490", VA = "0x182573E90", Slot = "8")]
	public GKPCJPMFCCN[] EIOAOEDBCHK(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG, int LPGGENAOHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2573E70", Offset = "0x2572470", VA = "0x182573E70", Slot = "9")]
	public bool CCKEILMOEBH(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2573EA0", Offset = "0x25724A0", VA = "0x182573EA0", Slot = "10")]
	public bool GACEAADLHNB(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2573EF0", Offset = "0x25724F0", VA = "0x182573EF0", Slot = "11")]
	public bool IKIJAKPDOAM(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2573E50", Offset = "0x2572450", VA = "0x182573E50", Slot = "12")]
	public bool ADCEMGCPJOG(IDMEFNAINAN MEBAFDHEDIN, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2573F30", Offset = "0x2572530", VA = "0x182573F30", Slot = "13")]
	public bool KGDPKHINAIE(IDMEFNAINAN ONLGAKFGMFI, GKPCJPMFCCN PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2573F50", Offset = "0x2572550", VA = "0x182573F50", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x2575FE0", Offset = "0x25745E0", VA = "0x182575FE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2575F90", Offset = "0x2574590", VA = "0x182575F90", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2573FA0", Offset = "0x25725A0", VA = "0x182573FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2574240", Offset = "0x2572840", VA = "0x182574240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2575BA0", Offset = "0x25741A0", VA = "0x182575BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2575F20", Offset = "0x2574520", VA = "0x182575F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly NHECKHEMBJH HIOOFICJKMA;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public KLGFMKMNNGA(NHECKHEMBJH MKMHAKPJKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2575170", Offset = "0x2573770", VA = "0x182575170")]
	[AsyncStateMachine(typeof(DOCIHNLDFBL))]
	private Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> AICDCFGMFHH(GKPCJPMFCCN PJDAFKMDDCG, bool LELKEOHAIGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x25752A0", Offset = "0x25738A0", VA = "0x1825752A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x253F230", Offset = "0x253D830", VA = "0x18253F230")]
	private FIJJIOIHDCF([In] CDNENBDPFJG<DGLIEKMCMIA, HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>, GKPCJPMFCCN, JDEFGJNCHCF> JALFBPOCJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2574BC0", Offset = "0x25731C0", VA = "0x182574BC0")]
	public static FIJJIOIHDCF FEOBEKOIKMG()
	{
		return default(FIJJIOIHDCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class HACCJCHMPBN
{
	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
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
	[Cpp2IlInjected.Address(RVA = "0x2574C30", Offset = "0x2573230", VA = "0x182574C30", Slot = "7")]
	public GKPCJPMFCCN LKMMOIMJJEN(DGLIEKMCMIA[] PLAABCPFEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x10A43C0", Offset = "0x10A29C0", VA = "0x1810A43C0")]
	public HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA> MKELKMAHBOA([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(HMBFEKDDECL<DGLIEKMCMIA.ACDDHAOJDHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xEFAFC0", Offset = "0xEF95C0", VA = "0x180EFAFC0")]
	public int HIHAJIPHNGC([In] DGLIEKMCMIA BHPCFAFLNGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2574C20", Offset = "0x2573220", VA = "0x182574C20")]
	public int DECIHGFHIIC([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xEFAFC0", Offset = "0xEF95C0", VA = "0x180EFAFC0", Slot = "4")]
	private int MGGEKKMJPCA([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2574C20", Offset = "0x2573220", VA = "0x182574C20", Slot = "5")]
	private int KNHNPBDKPNK([In] DGLIEKMCMIA NAIPMAAFDBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x10A43C0", Offset = "0x10A29C0", VA = "0x1810A43C0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x253F230", Offset = "0x253D830", VA = "0x18253F230")]
	private KCDLEKFBDJI([In] DNKMKDFCIDD<HDICGNLFMJC, GKPCJPMFCCN, LJNLFOLJOPD> MJPHLECBKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x2574E20", Offset = "0x2573420", VA = "0x182574E20")]
	public static KCDLEKFBDJI FEOBEKOIKMG()
	{
		return default(KCDLEKFBDJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class NPKKPJJIMGO
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0")]
	public int FOBJDOIEMAF([In] HDICGNLFMJC BHPCFAFLNGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x25759B0", Offset = "0x2573FB0", VA = "0x1825759B0", Slot = "5")]
	public GKPCJPMFCCN DEHEADAEJJA(HDICGNLFMJC[] EFLGBPFHINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(IJNGEOMLPGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x954450", Offset = "0x952A50", VA = "0x180954450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override EAPODONBJNH? AFMGOADBMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x25742B0", Offset = "0x25728B0", VA = "0x1825742B0", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2574520", Offset = "0x2572B20", VA = "0x182574520")]
	private DPNMMFCPDJL(IJNGEOMLPGN OPCPCOOFBPO, EAPODONBJNH? POIIGEEAHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x25743C0", Offset = "0x25729C0", VA = "0x1825743C0")]
	public static DPNMMFCPDJL DDKKDBGDBIM(EAPODONBJNH POIIGEEAHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x25744B0", Offset = "0x2572AB0", VA = "0x1825744B0")]
	public static DPNMMFCPDJL HALFOMOABBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x2574440", Offset = "0x2572A40", VA = "0x182574440")]
	public static DPNMMFCPDJL FLGEDKNPMIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class KEFNEMPFENP
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x349E780", Offset = "0x349CD80", VA = "0x18349E780")]
	public static JOFBNNGKBOO<TOk, KFNJBCGDAAC> FAIKBLGIMBB<TOk>([In] this JOFBNNGKBOO<TOk, KFNJBCGDAAC> JDCFMPOHCEA, EAPODONBJNH POIIGEEAHNE) where TOk : notnull
	{
		return default(JOFBNNGKBOO<TOk, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x349E680", Offset = "0x349CC80", VA = "0x18349E680")]
	public static JOFBNNGKBOO<TOk?, KFNJBCGDAAC?> AKKEGGAGEFC<TOk>([In] this JOFBNNGKBOO<TOk, KFNJBCGDAAC> JDCFMPOHCEA)
	{
		return default(JOFBNNGKBOO<TOk, KFNJBCGDAAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x349E870", Offset = "0x349CE70", VA = "0x18349E870")]
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
	[Cpp2IlInjected.Address(RVA = "0x3406A90", Offset = "0x3405090", VA = "0x183406A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x25760F0", Offset = "0x25746F0", VA = "0x1825760F0")]
		private MLDEMKCAONL(int EAHKFAJBNDN, OELEFOKLIPK? FAGJDLBMPNC, OELEFOKLIPK? JIDJJBKPEPG, List<GKPCJPMFCCN> NOFICAHDIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x2576030", Offset = "0x2574630", VA = "0x182576030")]
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
		[Cpp2IlInjected.Address(RVA = "0x2576880", Offset = "0x2574E80", VA = "0x182576880")]
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
		[Cpp2IlInjected.Address(RVA = "0xB459D0", Offset = "0xB43FD0", VA = "0x180B459D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xB45120", Offset = "0xB43720", VA = "0x180B45120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2576160", Offset = "0x2574760", VA = "0x182576160")]
	public void BENCOMJLKLN(NAPFONIDFOF JIDJJBKPEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2576580", Offset = "0x2574B80", VA = "0x182576580")]
	public void HMIICEIFENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2576220", Offset = "0x2574820", VA = "0x182576220")]
	private static string? CKAGFFAJEBJ([In] MLDEMKCAONL OMLGPKOAPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x25769D0", Offset = "0x2574FD0", VA = "0x1825769D0")]
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
